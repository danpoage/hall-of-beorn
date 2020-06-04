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

        public Tuple<Deck, IEnumerable<LotRCard>> LoadRingsDbDeck(string deckId)
        {
            var deckList = service.GetDeckList(deckId);
            if (deckList == null)
            {
                return null;
            }

            var deck = new Deck(deckList.name) { RingsDbDeckId = deckId };

            deck.Load(deckList.slots.Select(c => new Tuple<LotRCard, byte>(lookupCard(c.Key), c.Value)));

            var heroes = deckList.heroes.Select(h => lookupCard(h.Key));
            //deck.LoadSideboard(deckList.

            return new Tuple<Deck,IEnumerable<LotRCard>>(deck, heroes);
        }
    }
}
