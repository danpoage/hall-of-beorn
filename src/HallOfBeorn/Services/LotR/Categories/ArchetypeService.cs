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
            var dunedainSiege = new CardPredicate<Archetype>(Archetype.Dunedain_Siege)
                .Trait("Dunedain.")
                .Titles("Wait No Longer")
                .AnyText("each enemy engaged");

            var dwarfMining = new CardPredicate<Archetype>(Archetype.Dwarven_Mining)
                .AnyText("cards from the top of your deck", "card from the top of your deck", "discarded from the top of your deck")
                .Titles("Will of the West", "Hidden Cache", "Ered Luin Miner", "Zigil Miner", "Well-equipped");

            var dwarfSwarm = new CardPredicate<Archetype>(Archetype.Dwarven_Swarm)
                .AnyText("5 Dwarf characters")
                .Titles("Lure of Moria", "Fili", "Kili", "Nori", "Legacy of Durin");

            var entRetaliation = new CardPredicate<Archetype>(Archetype.Ent_Retaliation)
                .Trait("Ent.")
                .AllText(" Ent ", "Damage");

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

            var hobbitAmbush = new CardPredicate<Archetype>(Archetype.Hobbit_Ambush)
                .Hero("Tom Cotton", Sphere.Tactics)
                .Titles("Rosie Cotton", "Raise the Shire", "Drinking Song", "Halfling Determination")
                .TraitAndAnyText("Hobbit.", "enters play");

            var hobbitSecrecy = new CardPredicate<Archetype>(Archetype.Hobbit_Secrecy)
                .Hero("Merry")
                .Hero("Frodo Baggins", Sphere.Leadership)
                .TraitAndAnyText("Hobbit.", "Engagement cost")
                .Titles("Timely Aid", "Resourceful", "Leaf Brooch", "The Shirefolk", "Drinking Song", "Gaffer Gamgee", "Peace, and Thought", "A Very Good Tale")
                .AnyText("engagement cost higher than your threat", "enemy's engagement cost");

            var noldorDiscard = new CardPredicate<Archetype>(Archetype.Noldor_Discard)
                .Hero("Arwen Undomiel", Sphere.Spirit)
                .Hero("Erestor", Sphere.Lore)
                .Hero("Cirdan the Shipwright", Sphere.Spirit)
                .Hero("Galdor from the Havens", Sphere.Lore)
                .Titles("Will of the West")
                .AnyText("Discard a card from your hand", "Discard X cards from your hand");

            var rohanMount = new CardPredicate<Archetype>(Archetype.Rohan_Mounts)
                .Hero("Elfhelm", Sphere.Leadership)
                .Trait("Mount.")
                .Titles("Westfold Horse-breeder", "Wild Stallion", "Charge of the Rohirrim");

            var rohanStagingAttack = new CardPredicate<Archetype>(Archetype.Rohan_Staging_Attack)
                .Hero("Eomer", Sphere.Leadership)
                .Hero("Dunhere", Sphere.Spirit)
                .Hero("Fastred", Sphere.Spirit)
                .TraitAndAnyText("Rohan.", "staging area")
                .Titles("Spear of the Mark", "Battle-fury", "Helm! Helm!")
                .Not(c => c.Title == "West Road Traveller");

            var rohanSacrifice = new CardPredicate<Archetype>(Archetype.Rohan_Sacrifice)
                .Hero("Theoden", Sphere.Spirit)
                .Hero("Eomer", Sphere.Tactics)
                .TraitAndAnyText("Rohan.", "Discard")
                .Titles("Ride to Ruin", "Muster of Rohan", "Horn of the Mark")
                .AnyText("Discard a Rohan ally");

            var silvanAmbush = new CardPredicate<Archetype>(Archetype.Silvan_Ambush)
                .Hero("Celeborn", Sphere.Leadership)
                .Hero("Galadriel", Sphere.Spirit)
                .Hero("Thranduil", Sphere.Leadership)
                .TraitAndAnyText("Silvan.", "enters play", "leaves play")
                .AnyText("Return a Silvan ally to your hand");
            
            return new List<Func<LotRCard, Archetype>> {
                CreateArchetypeFilter(dunedainSiege),
                CreateArchetypeFilter(dwarfMining),
                CreateArchetypeFilter(dwarfSwarm),
                CreateArchetypeFilter(entRetaliation),
                CreateArchetypeFilter(gondorSwarm),
                CreateArchetypeFilter(gondorTraps),
                CreateArchetypeFilter(gondorValour),
                CreateArchetypeFilter(hobbitAmbush),
                CreateArchetypeFilter(hobbitSecrecy),
                CreateArchetypeFilter(noldorDiscard),
                CreateArchetypeFilter(rohanMount),
                CreateArchetypeFilter(rohanSacrifice),
                CreateArchetypeFilter(rohanStagingAttack),
                CreateArchetypeFilter(silvanAmbush),
            };
        }
    }
}