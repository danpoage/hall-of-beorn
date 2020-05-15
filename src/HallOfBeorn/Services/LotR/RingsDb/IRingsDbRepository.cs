using HallOfBeorn.Models.RingsDb;

namespace HallOfBeorn.Services.LotR.RingsDb
{
    public interface IRingsDbRepository
    {
        RingsDbDeckList GetDeckList(string deckId);
    }
}
