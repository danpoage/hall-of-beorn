using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingsDbBuilder
{
    public class Options
    {
        public Options(string[] args)
        {
            DownloadDelay = 3000;
            DownloadDirectory = ".\\json\\";
            DatabaseName = "RingsDB.data";

            MinimumDeckId = 1; //2969;
            MaximumDeckId = 15598;

            Verbose = false;
        }

        private const string _deckFormat = "json";
        private const string _downloadUrl = "http://ringsdb.com/api/public/decklist/";
        private const string _pathFormat = "{0}{1}.{2}";

        public int DownloadDelay { get; set; }
        public string DownloadDirectory { get; set; }
        public string DatabaseName { get; set; }

        public int MinimumDeckId { get; set; }
        public int MaximumDeckId { get; set; }

        public bool Verbose { get; set; }

        public string GetDownloadUrl(int deckId)
        {
            return string.Format(_pathFormat, _downloadUrl, deckId, _deckFormat);
        }

        public string GetFilePath(int deckId)
        {
            return string.Format(_pathFormat, DownloadDirectory, deckId, _deckFormat);
        }
    }
}
