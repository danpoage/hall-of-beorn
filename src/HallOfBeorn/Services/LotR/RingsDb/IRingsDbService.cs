using System;
using System.Collections.Generic;
using HallOfBeorn.Models.RingsDb;

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
        RingsDbDeckList GetDeckList(string deckId);
    }
}
