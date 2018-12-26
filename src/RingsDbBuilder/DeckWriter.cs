using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingsDbBuilder
{
    public class DeckWriter
    {
        public DeckWriter(Options options)
        {
            _options = options;
        }

        private readonly Options _options;

        private const string successFormat = "Success writing Deck ID {0} to {1}";
        private const string errorFormat = "Error writing Deck ID {0} to {1}: {2}";

        public bool Execute(DeckInfo info)
        {
            if (info.FileExists)
                return true;

            try
            {
                File.WriteAllText(info.Path, info.Json);
                Console.WriteLine(string.Format(successFormat, info.DeckId, info.Path));
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format(errorFormat, info.DeckId, info.Path, ex.Message));
                return false;
            }
        }
    }
}
