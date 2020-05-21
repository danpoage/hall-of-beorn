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
        private const string sideboardCardFormat = "addSideboardCard(\"{0}\", \"{1}\", {2});";

        private const string createTableSql = 
@"create table if not exists deck (
  id varchar(100) not null, 
  card_id varchar(100) not null, 
  quantity int not null, 
  primary key(id, card_id)
);
create table if not exists sideboard (
  id varchar(100) not null, 
  card_id varchar(100) not null, 
  quantity int not null, 
  primary key(id, card_id)
);
create table if not exists deck_info (
  id varchar(100) not null,
  user_id int not null,
  name varchar(200) not null,
  description varchar(500) null,  
  primary key(id)
);
create index if not exists deck_id_index
  on deck (id);
create index if not exists sideboard_id_index
  on sideboard (id);";

        private const string insertDeckSqlFormat =
"insert into deck (id, card_id, quantity) values ('{0}', '{1}', {2}) on conflict do nothing;";
        private const string insertSideboardSqlFormat =
"insert into sideboard (id, card_id, quantity) values ('{0}', '{1}', {2}) on conflict do nothing;";
        private const string insertDeckInfoSqlFormat =
"insert into deck_info (id, user_id, name, description) values ('{0}', {1}, '{2}', '{3}') on conflict do nothing;";

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
            if (!_options.Verbose)
            {
                Console.WriteLine("Deck ID: " + deck.id);
            }

            var insertSql = new StringBuilder();

            const int maxName = 200;
            const int maxDescription = 500;

            var name = deck.name != null
                ? deck.name.Replace("'", "’").Replace('\\', '-')
                : string.Empty;
            if (name.Length > maxName)
            {
                name = name.Substring(0, maxName);
            }

            var description = deck.description_md != null
                ? deck.description_md.Replace("'", "’").Replace('\\', '-')
                : string.Empty;
            if (description.Length > maxDescription)
            {
                description = description.Substring(0, maxDescription);
            }

            insertSql.AppendLine(string.Format(insertDeckInfoSqlFormat, deck.id, deck.user_id, name, description));

            foreach (var hero in deck.heroes)
            {
                if (_options.Verbose)
                {
                    Console.WriteLine(string.Format(deckCardFormat, deck.id, hero.Key, 1));
                }

                insertSql.AppendLine(string.Format(insertDeckSqlFormat, deck.id, hero.Key, 1));
            }

            foreach (var card in deck.slots)
            {
                if (_options.Verbose)
                {
                    Console.WriteLine(string.Format(deckCardFormat, deck.id, card.Key, card.Value));
                }

                insertSql.AppendLine(string.Format(insertDeckSqlFormat, deck.id, card.Key, card.Value));
            }

            if (deck.sideslots != null && deck.sideslots.Count > 0)
            {
                foreach (var card in deck.sideslots)
                {
                    if (_options.Verbose)
                    {
                        Console.WriteLine(string.Format(sideboardCardFormat, deck.id, card.Key, card.Value));
                    }

                    insertSql.AppendLine(string.Format(insertSideboardSqlFormat, deck.id, card.Key, card.Value));
                }
            }

            ExecuteSql(insertSql.ToString());
        }
    }
}
