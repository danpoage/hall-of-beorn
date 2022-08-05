using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.RingsDb;

namespace HallOfBeorn.Services.LotR.RingsDb
{
    public class RingsDbRepository
        : IRingsDbRepository
    {
        public RingsDbRepository()
        {
            binPath = System.IO.Path.GetDirectoryName( 
                    System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Remove(0, 7))
                    .Remove(0, 1);

            connectionString = string.Format(connectionStringFormat, binPath);
        }

        private readonly string binPath;
        private readonly string connectionString;

        private const string connectionStringFormat = "Data Source={0}\\App_Data\\RingsDB.data";
        private const string getDeckSqlFormat = "select card_id, quantity from deck where id = '{0}';";
        private const string getUserDeckIdsSqlFormat = "select id, name, description from deck_info where user_id = {0};";

        private const string getAllDecksSql = "select id, card_id, quantity from deck order by id asc;";
        private const string getAllUserDecksSql = "select user_id, id, name, description from deck_info;";

        private SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        private RingsDbDeckList GetDeck(SQLiteConnection connection, string deckId)
        {
            uint parsedId = 0;
            if (!uint.TryParse(deckId, out parsedId))
            {
                return null;
            }

            var command = connection.CreateCommand();
            command.CommandText = string.Format(getDeckSqlFormat, deckId);

            var deck = new RingsDbDeckList
            { 
                id = parsedId, 
                heroes = new Dictionary<string,byte>(), 
                slots = new Dictionary<string,byte>()
            };

            using (var reader = command.ExecuteReader())
            {
                var count = 0;
                while (reader.Read())
                {
                    var cardId = reader.GetString(0);
                    var quantity = reader.GetByte(1);

                    count++;
                    if (count < 4)
                    {
                        if (!deck.heroes.ContainsKey(cardId))
                            deck.heroes.Add(cardId, quantity);
                    }
                    else
                    {
                        if (!deck.slots.ContainsKey(cardId))
                            deck.slots.Add(cardId, quantity);
                    }
                }
            }

            return deck;
        }

        private Dictionary<uint, RingsDbDeckList> GetDecksWithCards(
            SQLiteConnection connection, HashSet<string> cardIds)
        {
            var allDecks = new List<uint>();
            var deckMap = new Dictionary<uint, RingsDbDeckList>();
            var matchingDecks = new HashSet<uint>();

            var command = connection.CreateCommand();
            command.CommandText = getAllDecksSql;

            var sequence = 0; uint lastDeckId = 0;

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    sequence++;

                    var deckIdString = reader.GetString(0);
                    var cardId = reader.GetString(1);
                    var quantity = reader.GetByte(2);
                    
                    uint deckId = 0;
                    uint.TryParse(deckIdString, out deckId);

                    if (deckId > 0)
                    {
                        if (deckId != lastDeckId)
                        {
                            sequence = 1;
                            lastDeckId = deckId;
                        }

                        if (!deckMap.ContainsKey(deckId))
                        {
                            allDecks.Add(deckId);
                            deckMap[deckId] = new RingsDbDeckList { 
                                id = deckId, 
                                heroes = new Dictionary<string,byte>(),
                                slots = new Dictionary<string,byte>(),
                                sideslots = new Dictionary<string,byte>(),
                            };
                        }

                        if (sequence < 4)
                        {
                            deckMap[deckId].heroes.Add(cardId, quantity);
                        }
                        else
                        {
                            deckMap[deckId].slots.Add(cardId, quantity);
                        }

                        if (cardIds.Contains(cardId) && !matchingDecks.Contains(deckId))
                        {
                            matchingDecks.Add(deckId);
                        }
                    }
                }
            }

            //Remove decks which don't match
            foreach (var deckId in allDecks)
            {
                if (!matchingDecks.Contains(deckId))
                {
                    deckMap.Remove(deckId);
                }
            }

            return deckMap;
        }

        private void PopulateDecks(SQLiteConnection connection, Dictionary<uint, RingsDbDeckList> deckMap)
        {
            var command = connection.CreateCommand();
            command.CommandText = getAllUserDecksSql;

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var userId = reader.GetInt32(0);
                    var deckIdString = reader.GetString(1);
                    var name = reader.GetString(2);
                    var description = reader.GetString(3);

                    uint deckId = 0;
                    uint.TryParse(deckIdString, out deckId);

                    if (deckId > 0 && deckMap.ContainsKey(deckId))
                    {
                        var deck = deckMap[deckId];

                        deck.user_id = (uint)userId;
                        deck.name = name;
                        deck.description_md = description;
                    }
                }
            }
        }

        public IEnumerable<RingsDbDeckList> AllDecks(HashSet<string> cardIds)
        {
            Dictionary<uint, RingsDbDeckList> deckMap;

            using (var connection = GetConnection())
            {
                connection.Open();

                deckMap = GetDecksWithCards(connection, cardIds);

                PopulateDecks(connection, deckMap);
            }

            return deckMap.Values;
        }

        public RingsDbDeckList GetDeckList(string deckId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                return GetDeck(connection, deckId);
            }
        }

        public IEnumerable<RingsDbDeckList> GetUserDeckLists(int userId)
        {
            var decks = new Dictionary<string, RingsDbDeckList>();

            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = string.Format(getUserDeckIdsSqlFormat, userId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var deckId = reader.GetString(0);
                        var name = reader.GetString(1);
                        var description = reader.GetString(2);

                        if (!string.IsNullOrEmpty(deckId) && !decks.ContainsKey(deckId))
                        {
                            var detailCommand = connection.CreateCommand();
                            detailCommand.CommandText = string.Format(getDeckSqlFormat, deckId);
                            var deck = GetDeck(connection, deckId);
                            if (deck != null)
                            {
                                deck.name = name;
                                deck.description_md = description;
                                decks[deckId] = deck;
                            }
                        }
                    }
                }
            }

            return decks.Values;
        }
    }
}