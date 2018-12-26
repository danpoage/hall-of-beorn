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

        private const string contentDefault = "";
        private const string errorFormat = "Error reading Deck ID {0}: {1}";

        public string GetDeckString(int deckId)
        {
            try
            {
                var path = _options.GetFilePath(deckId);

                return File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format(errorFormat, deckId, ex.Message));
                return contentDefault;
            }
        }
    }
}
