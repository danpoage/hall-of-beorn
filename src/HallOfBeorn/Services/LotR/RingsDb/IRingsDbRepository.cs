using System.Collections.Generic;
using HallOfBeorn.Models.RingsDb;

namespace HallOfBeorn.Services.LotR.RingsDb
{
    public interface IRingsDbRepository
    {
        RingsDbDeckList GetDeckList(string deckId);
        IEnumerable<RingsDbDeckList> GetUserDeckLists(int userId);
    }
}
