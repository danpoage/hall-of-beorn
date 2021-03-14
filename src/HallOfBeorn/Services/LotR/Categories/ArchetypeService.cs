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

        private Func<LotRCard, Archetype> CreateArchetypeFilter(CardPredicate<Archetype> predicate)
        {
            return new Func<LotRCard, Archetype>((card) => {
                return predicate.Eval(card) ? predicate.Category : Archetype.None;
            });
        }

        protected override bool IsCategorizable(LotRCard card)
        {
            return card.CardType.IsPlayerCard();
        }

        protected override List<Func<LotRCard, Archetype>> GetCategoryFilters()
        {
            var gondorSwarm = new CardPredicate<Archetype>(Archetype.Gondor_Swarm)
                .Hero("Boromir", Sphere.Leadership)
                .Hero("Denethor", Sphere.Leadership)
                .Hero("Prince Imrahil")
                .Hero("Lothiriel")
                .Hero("Hirgon")
                .Ally("Faramir", Sphere.Leadership)
                .Titles("Steward of Gondor", "Visionary Leadership", "For Gondor")
                .Or(c => c.CardType == CardType.Ally
                    && c.NormalizedTraits.Any(t => t == "Gondor.")
                    && !c.NormalizedTraits.Any(t => t == "Ranger.")
                    && c.ResourceCost <= 2);

            var gondorTraps = new CardPredicate<Archetype>(Archetype.Gondor_Traps)
                .Hero("Damrod", Sphere.Lore)
                .Hero("Mablung", Sphere.Tactics)
                .Hero("Denethor", Sphere.Lore)
                .Hero("Faramir", Sphere.Lore)
                .Ally("Faramir", Sphere.Lore)
                .Titles("Ranger Spear", "Ranger Bow", "Arrows from the Trees", "Take No Notice")
                .Trait("Trap")
                .AllTraits("Gondor.", "Ranger.")
                .Or(c => c.Text.ContainsLower("attached trap"));

            var gondorValour = new CardPredicate<Archetype>(Archetype.Gondor_Valour)
                .Hero("Boromir", Sphere.Tactics)
                .Hero("Hirgon")
                .AnyText("Valour", "40")
                .Or(c => c.NormalizedTraits.Any(t => t == "Gondor.") && c.Text.ContainsLower("doomed "))
                .Not(c => c.Title == "Knight of Dale");

            var entRetaliation = new CardPredicate<Archetype>(Archetype.Ent_Retaliation)
                .Trait("Ent.")
                .AllText(" Ent ", "Damage");

            return new List<Func<LotRCard, Archetype>> {
                CreateArchetypeFilter(entRetaliation),
                CreateArchetypeFilter(gondorSwarm),
                CreateArchetypeFilter(gondorTraps),
                CreateArchetypeFilter(gondorValour),
            };
        }
    }
}