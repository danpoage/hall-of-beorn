using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctgnBuilder
{
    public class Options
    {
        private const string gameDirectory = "a21af4e8-be4b-4cda-a6b6-534f9717391f";
        private const string directoryDecks = "Decks";
        private const string directoryQuest = "Quest";
        private const string directorySets = "Sets";

        public Options()
        {
            HomeDirectory = "C:\\Users\\Dan\\Documents\\OCTGN\\GameDatabase\\a21af4e8-be4b-4cda-a6b6-534f9717391f\\";
            DecksDirectory = Path.Combine(HomeDirectory, directoryDecks);
            QuestDirectory = Path.Combine(DecksDirectory, directoryQuest);
            SetsDirectory = Path.Combine(HomeDirectory, directorySets);
        }

        public string HomeDirectory { get; set; }
        public string DecksDirectory { get; private set; }
        public string QuestDirectory { get; private set; }
        public string SetsDirectory { get; private set; }
    }
}
