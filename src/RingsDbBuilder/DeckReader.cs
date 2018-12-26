using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using HallOfBeorn.Models.RingsDb;

namespace RingsDbBuilder
{
    public class DeckReader
    {
        private const string errorFormat = "Error deserializing Deck ID {0}: {1}";

        public bool Execute(DeckInfo info)
        {
            try
            {
                info.Deck = JsonConvert.DeserializeObject<RingsDbDeckList>(info.Json);
                return info.Deck != null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format(errorFormat, info.DeckId, ex.Message));
                return false;
            }
        }
    }
}
