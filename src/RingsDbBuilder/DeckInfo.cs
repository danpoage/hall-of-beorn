using System;
using System.IO;

using HallOfBeorn.Models.RingsDb;

namespace RingsDbBuilder
{
    public class DeckInfo
    {
        public DeckInfo(Options options, int deckId)
        {
            DeckId = deckId;
            Path = options.GetFilePath(deckId);
            Url = options.GetDownloadUrl(deckId);
            FileExists = File.Exists(Path);
        }

        public int DeckId { get; private set; }
        public string Path { get; private set; }
        public string Url { get; private set; }
        public bool FileExists { get; private set; }

        public string Json { get; set; }
        public RingsDbDeckList Deck { get; set; }
    }
}
