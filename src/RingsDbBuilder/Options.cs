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

            //Format change: 2969
            //Sideboards as Dictionary 3463

            MinimumDeckId = 1; // 22660; //1; // 21079; //1; //3463; //1; //2969; 25158-30172
            MaximumDeckId = 30194; //2022-07-23
                //30172; //2022-07-22
                //24851; //2022-01-21
                //22660; //21079; //20304; //20233; //19321; //18307; //16078;

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
