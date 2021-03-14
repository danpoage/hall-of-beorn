using System;
using System.Collections.Generic;
using System.Linq;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Categories
{
    public class ArchetypeService
        : CategoryServiceBase<Archetype>
    {
        public ArchetypeService(ICardRepository<LotRCard> cardRepository)
            : base(cardRepository)
        {
        }

        private Func<LotRCard, Archetype> CreateArchetypeFilter(Func<LotRCard, bool> predicate, Archetype archetype)
        {
            return new Func<LotRCard, Archetype>((card) => {
                return (predicate(card)) ? archetype : Archetype.None;
            });
        }

        protected override bool IsCategorizable(LotRCard card)
        {
            return card.CardType.IsPlayerCard();
        }

        protected override List<Func<LotRCard, Archetype>> GetCategoryFilters()
        {
            Func<LotRCard, bool> isGondorSwarm = c => c.NormalizedTitle.ContainsAny("guard of the citadel", "squire of the citadel", "defender of rammas",
                "steward of gondor", "rod of the steward", "for gondor", "visionary leadership",
                    "denethor", "boromir");

            return new List<Func<LotRCard, Archetype>> {
                CreateArchetypeFilter(isGondorSwarm, Archetype.Gondor_Swarm),
            };
        }
    }
}