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

        public void WriteDeckFile(int deckId, string json)
        {
            var path = string.Empty;

            try
            {
                path = _options.GetFilePath(deckId);
                File.WriteAllText(path, json);
                Console.WriteLine(string.Format(successFormat, deckId, path));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format(errorFormat, deckId, path, ex.Message));
            }
        }
    }
}
