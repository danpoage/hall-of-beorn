using System;
using System.IO;
using System.Security.Cryptography;

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

        public bool FileMatchesJson()
        {
            if (!File.Exists(Path) || string.IsNullOrWhiteSpace(Json))
            {
                return false;
            }

            var jsonHash = DeckComparer.GetHashFromJson(Json);
            var fileHash = DeckComparer.GetHashFromFile(Path);

            return jsonHash == fileHash;
        }
    }
}
