using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using HallOfBeorn.Models.RingsDb;
using System.Data.SQLite;

namespace RingsDbBuilder
{
    public class DeckCardBuilder
    {
        public DeckCardBuilder(Options options)
        {
            _options = options;
            _databasePath = _options.DownloadDirectory + _options.DatabaseName;
            _connectionString = string.Format(dataSourceFormat, _databasePath);
        }

        private readonly Options _options;
        private readonly string _databasePath;
        private readonly string _connectionString;

        private const string dataSourceFormat = "Data Source={0}";
        private const string deckCardFormat = "addDeckCard(\"{0}\", \"{1}\", {2});";
        private const string createTableSql = 
@"create table if not exists deck (
  id varchar(100) not null, 
  card_id varchar(100) not null, 
  quantity int not null, 
  primary key(id, card_id)
);
create index if not exists deck_id_index
  on deck (id);";

        private const string insertSqlFormat =
"insert into deck (id, card_id, quantity) values ('{0}', '{1}', {2}) on conflict do nothing;";

        private void ExecuteSql(string sql)
        {
            using(var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
            }
        }

        public void Init()
        {
            if (!File.Exists(_databasePath))
            {
                SQLiteConnection.CreateFile(_databasePath);
            }

            ExecuteSql(createTableSql);
        }

        public void AddDeckCards(RingsDbDeckList deck)
        {
            var insertSql = new StringBuilder();

            foreach (var hero in deck.heroes)
            {
                if (_options.Verbose)
                {
                    Console.WriteLine(string.Format(deckCardFormat, deck.id, hero.Key, 1));
                }

                insertSql.AppendLine(string.Format(insertSqlFormat, deck.id, hero.Key, 1));
            }

            foreach (var card in deck.slots)
            {
                if (_options.Verbose)
                {
                    Console.WriteLine(string.Format(deckCardFormat, deck.id, card.Key, card.Value));
                }

                insertSql.AppendLine(string.Format(insertSqlFormat, deck.id, card.Key, card.Value));
            }

            ExecuteSql(insertSql.ToString());
        }
    }
}
