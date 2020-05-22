using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.RingsDb;
using HallOfBeorn.Services.LotR.RingsDb;

namespace HallOfBeorn.Client
{
    public class RingsDbHelper
    {
        public RingsDbHelper()
        {
        }

        private const string connectionString = "Data Source=.\\RingsDB.data";
        private const string getDeckCardSqlFormat = "select card_id, quantity from deck where id = '{0}';";
        private const string getSideboardCardSqlFormat = "select card_id, quantity from sideboard where id = '{0}';";
        private const string getDeckInfoSqlFormat = "select name, user_id, description from deck_info where id = '{0}';";

        private SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        private Tuple<string, byte> getSetAndNumber(string ringsDbId)
        {
            if (string.IsNullOrEmpty(ringsDbId)
                || ringsDbId.Length < 5)
            {
                return null;
            }

            var setId = ringsDbId.Length == 6
                ? ringsDbId.Substring(0, 3)
                : ringsDbId.Substring(0, 2);

            var cardId = ringsDbId.Length == 6
                ? ringsDbId.Substring(3, 3)
                : ringsDbId.Substring(2, 3);

            byte cardNumber = 0;
            if (!byte.TryParse(cardId, out cardNumber))
            {
                return null;
            }

            switch (setId)
            {
                case "01":
                    return new Tuple<string, byte>("Core Set", cardNumber);
                case "02":
                    return new Tuple<string,byte>( "Shadows of Mirkwood", cardNumber);
                case "03":
                    return new Tuple<string, byte>("Khazad-dûm", cardNumber);
                case "04":
                    return new Tuple<string,byte>("Dwarrowdelf", cardNumber);
                case "05":
                    return new Tuple<string,byte>("Heirs of Númenor", cardNumber);
                case "06":
                    return new Tuple<string,byte>("Against the Shadow", cardNumber);
                case "07":
                    return new Tuple<string, byte>("The Voice of Isengard", cardNumber);
                case "08":
                    return new Tuple<string,byte>("The Ring-maker", cardNumber);
                case "09":
                    return new Tuple<string, byte>("The Lost Realm", cardNumber);
                case "10":
                    return new Tuple<string,byte>("Angmar Awakened", cardNumber);
                case "11":
                    return new Tuple<string, byte>("The Lost Realm", cardNumber);
                case "12":
                    return new Tuple<string,byte>("Dream-chaser", cardNumber);
                case "16":
                    return new Tuple<string, byte>("The Sands of Harad", cardNumber);
                case "17":
                    return new Tuple<string,byte>("Haradrim", cardNumber);
                case "18":
                    return new Tuple<string, byte>("The Wilds of Rhovanion", cardNumber);
                case "19":
                    return new Tuple<string, byte>("Ered Mithrin", cardNumber);
                case "20":
                    return new Tuple<string, byte>("Two-Player Limited Edition Starter", cardNumber);
                case "21":
                    return new Tuple<string, byte>("A Shadow in the East", cardNumber);
                case "22":
                    return new Tuple<string, byte>("Vengeance of Mordor", cardNumber);
                case "131":
                    return new Tuple<string, byte>("The Hobbit: Over Hill and Under Hill", cardNumber);
                case "132":
                    return new Tuple<string, byte>("The Hobbit: On the Doorstep", cardNumber);
                case "141":
                    return new Tuple<string, byte>("The Black Riders", cardNumber);
                case "142":
                    return new Tuple<string, byte>("The Road Darkens", cardNumber);
                case "143":
                    return new Tuple<string, byte>("The Treason of Saruman", cardNumber);
                case "144":
                    return new Tuple<string, byte>("The Land of Shadow", cardNumber);
                case "145":
                    return new Tuple<string, byte>("The Flame of the West", cardNumber);
                case "146":
                    return new Tuple<string, byte>("The Mountain of Fire", cardNumber);
                default:
                    return new Tuple<string,byte>(string.Empty, 0);
            }
        }

        public LotRCard GetCard(string cardId, Func<string, IEnumerable<CardSet>> lookupSets)
        {
            var setAndNumber = getSetAndNumber(cardId);

            if (setAndNumber.Item2 == 0)
            {
                return null;
            }

            var sets = lookupSets(setAndNumber.Item1);

            foreach (var item in sets)
            {
                foreach (var card in item.Cards)
                {
                    if (card.CardNumber == setAndNumber.Item2)
                    {
                        return card;
                    }
                }
            }

            return null;
        }

        public RingsDbDeckList GetDeckList(string deckId)
        {
            uint parsedId = 0;
            if (!uint.TryParse(deckId, out parsedId))
            {
                return null;
            }

            var deck = new RingsDbDeckList
            { 
                id = parsedId, 
                heroes = new Dictionary<string,byte>(), 
                slots = new Dictionary<string,byte>(),
                sideslots = new Dictionary<string,byte>(),
            };

            using (var connection = GetConnection())
            {
                connection.Open();
                AddDeckInfo(connection, deck);
                AddDeckCards(connection, deck);
                AddSideboardCards(connection, deck);
            }

            return deck;
        }

        private void AddDeckInfo(SQLiteConnection connection, RingsDbDeckList deck)
        {
            var deckInfoCommand = connection.CreateCommand();
            deckInfoCommand.CommandText = string.Format(getDeckInfoSqlFormat, deck.id);

            using (var reader = deckInfoCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    deck.name = reader.GetString(0);
                    deck.user_id = (uint)reader.GetInt32(1);
                    deck.description_md = reader.GetString(2);
                }
            }
        }

        private void AddDeckCards(SQLiteConnection connection, RingsDbDeckList deck)
        {
            var deckCardCommand = connection.CreateCommand();
            deckCardCommand.CommandText = string.Format(getDeckCardSqlFormat, deck.id);

            using (var reader = deckCardCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    var cardId = reader.GetString(0);
                    var quantity = reader.GetByte(1);

                    if (!deck.slots.ContainsKey(cardId))
                        deck.slots.Add(cardId, quantity);
                }
            }
        }

        private void AddSideboardCards(SQLiteConnection connection, RingsDbDeckList deck)
        {
            var sideboardCardCommand = connection.CreateCommand();
            sideboardCardCommand.CommandText = string.Format(getSideboardCardSqlFormat, deck.id);

            using (var reader = sideboardCardCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    var cardId = reader.GetString(0);
                    var quantity = reader.GetByte(1);

                    if (!deck.sideslots.ContainsKey(cardId))
                        deck.sideslots.Add(cardId, quantity);
                }
            }
        }
    }
}