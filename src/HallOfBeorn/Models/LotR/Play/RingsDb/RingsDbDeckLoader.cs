using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.RingsDb;

namespace HallOfBeorn.Models.LotR.Play.RingsDb
{
    public class RingsDbDeckLoader
    {
        public RingsDbDeckLoader(
            IRingsDbService service,
            Func<string, LotRCard> lookupCard)
        {
            this.service = service;
            this.lookupCard = lookupCard;
        }

        private readonly IRingsDbService service;
        private readonly Func<string, LotRCard> lookupCard;

        public Deck LoadRingsDbDeck(string deckId)
        {
            var deckList = service.GetDeckList(deckId);
            if (deckList == null)
            {
                return null;
            }

            var deck = new Deck { DeckId = deckId, Name = deckList.name };

            deck.Load(deckList.heroes.Select(h => new Tuple<LotRCard, byte>(lookupCard(h.Key), h.Value)));
            deck.Load(deckList.slots.Select(c => new Tuple<LotRCard, byte>(lookupCard(c.Key), c.Value)));

            //deck.LoadSideboard(deckList.

            return deck;
        }
    }
}
