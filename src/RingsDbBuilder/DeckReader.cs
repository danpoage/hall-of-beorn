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

        public RingsDbDeckList ReadDeck(int deckId, string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<RingsDbDeckList>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format(errorFormat, deckId, ex.Message));
                return null;
            }
        }
    }
}
