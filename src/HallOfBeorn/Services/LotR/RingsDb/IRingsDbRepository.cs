using System.Collections.Generic;
using HallOfBeorn.Models.RingsDb;

namespace HallOfBeorn.Services.LotR.RingsDb
{
    public interface IRingsDbRepository
    {
        IEnumerable<RingsDbDeckList> AllDecks(HashSet<string> cardIds);
        RingsDbDeckList GetDeckList(string deckId);
        IEnumerable<RingsDbDeckList> GetUserDeckLists(int userId);
    }
}
