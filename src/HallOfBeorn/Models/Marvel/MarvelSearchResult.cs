using System;

namespace HallOfBeorn.Models.Marvel
{
    public class MarvelSearchResult
    {
        public MarvelSearchResult(MarvelCard card)
            : this(card, 1)
        {
        }

        public MarvelSearchResult(MarvelCard card, float score)
        {
            Card = card;
            Score = score;
        }

        public MarvelCard Card { get; private set; }
        public float Score { get; private set; }
    }
}