using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.RingsDb;

namespace HallOfBeorn.Services.LotR.RingsDb
{
    public class RingsDbRepository
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

        private SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
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
                slots = new Dictionary<string,byte>()
            };

            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = string.Format(getDeckSqlFormat, deckId);

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
            }

            return deck;
        }
    }
}