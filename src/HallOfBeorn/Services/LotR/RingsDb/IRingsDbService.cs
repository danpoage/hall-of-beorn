using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallOfBeorn.Services.LotR.RingsDb
{
    public interface IRingsDbService
    {
        string GetSlug(string cardId);
        string GetCardId(string slug);
        byte GetPopularity(string slug);
        ushort GetVotes(string slug);
        IEnumerable<KeyValuePair<string, int>> GetLinks(string slug);
        bool DeckIncludesCard(string deckId, string slug);
    }
}
