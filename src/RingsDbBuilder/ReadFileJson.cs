using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingsDbBuilder
{
    public class ReadFileJson
    {
        public ReadFileJson(Options options)
        {
            _options = options;
        }

        private readonly Options _options;

        private const string errorFormat = "Error reading Deck ID {0}: {1}";

        public bool Execute(DeckInfo info)
        {
            if (!string.IsNullOrEmpty(info.Json))
                return true;

            try
            {
                info.Json = File.ReadAllText(info.Path);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format(errorFormat, info.DeckId, ex.Message));
                return false;
            }
        }
    }
}
