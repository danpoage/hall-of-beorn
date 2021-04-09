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
        public DeckReader(Options options)
        {
            this.options = options;
        }

        private readonly Options options;
        
        private readonly JsonSerializerSettings settings 
            = new JsonSerializerSettings { MissingMemberHandling = MissingMemberHandling.Ignore };

        private const string errorFormat = "Error deserializing Deck ID {0}: {1}";

        public bool Execute(DeckInfo info)
        {
            try
            {
                info.Json = info.Json.Replace("\"sideslots\":[]", "\"sideslots\":{}");

                info.Deck = JsonConvert.DeserializeObject<RingsDbDeckList>(info.Json, settings);
                return info.Deck != null;
            }
            catch (Exception ex)
            {
                if (options.Verbose)
                {
                    Console.WriteLine(string.Format(errorFormat, info.DeckId, ex.Message));
                }
                return false;
            }
        }
    }
}
