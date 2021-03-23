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
            return card.CardType.IsPlayerCard() 
                && card.Sphere != Sphere.Baggins && card.Sphere != Sphere.Fellowship 
                && card.CardSubtype != Models.CardSubtype.Boon;
        }

        protected override List<Func<LotRCard, Archetype>> GetCategoryFilters()
        {
            var aragornVoltron = new CardPredicate<Archetype>(Archetype.Aragorn_Voltron)
                .Hero("Aragorn")
                .AnyText("Aragorn")
                .Titles("Wingfoot", "Heir of Mardil", "Steward of Gondor", "Gondorian Fire", "Blood of Numenor", "Sword of Numenor", "Steed of the North");

            var caldaraSwarm = new CardPredicate<Archetype>(Archetype.Caldara_Swarm)
                .Hero("Caldara", Sphere.Spirit)
                .Hero("Eowyn", Sphere.Spirit)
                .Hero("Arwen Undomiel", Sphere.Spirit)
                .Hero("Cirdan the Shipwright", Sphere.Spirit)
                .Hero("Galadriel", Sphere.Spirit)
                .Ally("Prince Imrahil", Sphere.Spirit)
                .Titles("Light the Beacons", "Map of Earnil", "Zigil Miner", "Imladris Stargazer", "Sword-thain", "Shadows Give Way")
                .Or(c => c.CardType == CardType.Ally && c.Sphere == Sphere.Spirit &&
                    (c.Willpower >= 2 || c.ResourceCost >= 3))
                .Not(c => c.Title == "Silvan Refugee" || c.Title == "Misty Mountain Journeyman");

            var daleArmory = new CardPredicate<Archetype>(Archetype.Dale_Armory)
                .Titles("King of Dale")
                .Trait("Dale.")
                .Trait("Esgaroth.")
                .Trait("Item.");
            
            var dunedainSidequest = new CardPredicate<Archetype>(Archetype.Dunedain_Side_Quest)
                .Or(c => c.CardType == CardType.Player_Side_Quest)
                .AnyText("side quest");

            var dunedainSiege = new CardPredicate<Archetype>(Archetype.Dunedain_Siege)
                .Trait("Dunedain.")
                .AnyText("each enemy engaged", "put it into play engaged with you", "number of enemies engaged with you");

            var dwarfMining = new CardPredicate<Archetype>(Archetype.Dwarf_Mining)
                .Hero("Dain Ironfoot", Sphere.Spirit)
                .AnyText("cards from the top of your deck", "card from the top of your deck", "discarded from the top of your deck",
                    "discard the top 3 cards from your deck ",
                    "discard the top 2 cards of your deck", "discard the top card of your deck")
                .TraitAndAnyText("Dwarf.", "Discard Pile")
                .Titles("Will of the West", "Hidden Cache", "Ered Luin Miner", "Zigil Miner", "Well-equipped", "Dwarven Tomb", "Reforged")
                .Not(c => c.Title == "Taking Initiative"); //This line is for you, Terence

            var dwarfSwarm = new CardPredicate<Archetype>(Archetype.Dwarf_Swarm)
                .AnyText("5 Dwarf characters")
                .Titles("Lure of Moria", "Fili", "Kili", "Nori", "Legacy of Durin", "To Me! O my kinsfolk!");

            var eagleAmbush = new CardPredicate<Archetype>(Archetype.Eagle_Ambush)
                .Trait("Eagle.")
                .Hero("Radagast", Sphere.Lore)
                .Hero("Gwaihir")
                .Ally("Radagast", Sphere.Neutral)
                .Titles("Radagast's Staff", "Gwiahir's Debt", "Support of the Eagles", "Flight of the Eagles")
                .AnyText("Eagle");

            var entRetaliation = new CardPredicate<Archetype>(Archetype.Ent_Retaliation)
                .Trait("Ent.")
                .AllText(" Ent ", "Damage");

            var gandalfVoltron = new CardPredicate<Archetype>(Archetype.Gandalf_Voltron)
                .Hero("Gandalf")
                .AnyText("Istari", "Gandalf")
                .Titles("Unexpected Courage", "Hidden Cache", "Expert Treasure-hunter")
                .Not(c => c.Slug == "Gandalf-Core" || c.Slug == "Gandalf-1-TPLES" || c.Slug == "Gandalf-2-TPLES");

            var gloinVoltron = new CardPredicate<Archetype>(Archetype.Gloin_Voltron)
                .Hero("Gloin", Sphere.Leadership)
                .Hero("Elrond", Sphere.Lore)
                .Titles("Warden of Healing", "Song of Healing", "Self Preservation", "Citadel Plate", "Boots of Erebor", "Well Preserved", "Vigilant Guard", "Song of Mocking", "Lore of Imladris", "Golden Belt", "Mighty Warrior")
                .Titles("Master of the Forge", "Heed the Dream", "Open the Armory", "Elven-light", "Ent Draught");

            var gondorAmbush = new CardPredicate<Archetype>(Archetype.Gondor_Ambush)
                .Hero("Prince Imrahil", Sphere.Tactics)
                .Hero("Hirgon", Sphere.Tactics)
                .Hero("Lothiriel", Sphere.Spirit)
                .TraitAndAnyText("Gondor.", "Enters play", "Leaves play", "Discard")
                .Titles("Defender of Rammas", "Gondorian Spearman", "Defender of Cair Andros", "Knight of Minas Tirith", "Knight of the White Tower", "White Tower Watchman", "Red Arrow")
                .Not(c => c.Title == "Master Ironsmith" || c.Title == "Emery" || c.Title == "Eleanor");

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
                .Hero("Denethor", Sphere.Leadership)
                .Hero("Hirgon")
                .AnyText("Valour", "40")
                .Or(c => c.NormalizedTraits.Any(t => t == "Gondor.") && c.Text.ContainsLower("doomed "))
                .Not(c => c.Title == "Knight of Dale");

            var grimbeornVoltron = new CardPredicate<Archetype>(Archetype.Grimbeorn_Voltron)
                .Hero("Grimbeorn", Sphere.Tactics)
                .Titles("Orcrist", "Steward of Gondor", "War Axe", "Armored Destrier", "Support of the Eagles", "Raiment of War", "Gondorian Shield", "Captain of Gondor", "Gondorian Fire", "Firefoot", "The Day's Rising", "Rohan Warhorse", "Dagger of Westernesse", "Round Shield", "Hauberk of Mail")
                .Titles("Open the Armory", "Beorn's Rage", "Swift and Strong", "Foe-hammer")
                .Not(c => c.CardType == CardType.Treasure);

            var haradChampions = new CardPredicate<Archetype>(Archetype.Harad_Champions)
                .Trait("Harad.")
                .Titles("Kahliel's Headdress", "Haradrim Spear", "Peace, and Thought", "The Storm Comes", "A Good Harvest");

            var hobbitAmbush = new CardPredicate<Archetype>(Archetype.Hobbit_Ambush)
                .Hero("Tom Cotton", Sphere.Tactics)
                .Titles("Rosie Cotton", "Raise the Shire", "Drinking Song", "Halfling Determination")
                .TraitAndAnyText("Hobbit.", "enters play");

            var hobbitPipesAndSongs = new CardPredicate<Archetype>(Archetype.Hobbit_Pipes_and_Songs)
                .Trait("Hobbit.")
                .Trait("Pipe.")
                .Trait("Song.")
                .AnyText("Pipe", "Song");

            var hobbitSecrecy = new CardPredicate<Archetype>(Archetype.Hobbit_Secrecy)
                .Hero("Merry")
                .Hero("Frodo Baggins", Sphere.Leadership)
                .TraitAndAnyText("Hobbit.", "Engagement cost")
                .Titles("Timely Aid", "Resourceful", "Leaf Brooch", "The Shirefolk", "Drinking Song", "Gaffer Gamgee", "Peace, and Thought", "A Very Good Tale")
                .AnyText("engagement cost higher than your threat", "enemy's engagement cost");

            var isengardDoomed = new CardPredicate<Archetype>(Archetype.Isengard_Doomed)
                .Hero("Aragorn.", Sphere.Lore)
                .Trait("Isengard.")
                .Titles("Saruman", "Grima", "Keys of Orthanc", "Favor of the Valar")
                .Or(c => c.Keywords.Any(k => k.StartsWith("Doomed")));

            var noldorDiscard = new CardPredicate<Archetype>(Archetype.Noldor_Discard)
                .Hero("Arwen Undomiel", Sphere.Spirit)
                .Hero("Erestor", Sphere.Lore)
                .Hero("Cirdan the Shipwright", Sphere.Spirit)
                .Hero("Galdor from the Havens", Sphere.Lore)
                .Titles("Will of the West")
                .AnyText("Discard 1 card from your hand", "Discard a card from your hand", "Discard X cards from your hand", "Discard 2 cards from you hand", 
                    "you do not have cards", "less than 3 cards in your hand", "can only be played from your discard pile");

            var outlandsSwarm = new CardPredicate<Archetype>(Archetype.Outlands_Swarm)
                .Hero("Hirluin the Fair")
                .Hero("Prince Imrahil")
                .Hero("Denethor", Sphere.Leadership)
                .Ally("Faramir", Sphere.Leadership)
                .Titles("Steward of Gondor", "Squire of the Citadel", "Errand-rider", "Envoy of Pelargir", "Warden of Healing", "Ioreth", "Gaining Strength", "Wealth of Gondor", "A Very Good Tale")
                .Trait("Outlands.")
                .AnyText("Outlands");

            var radagastCreatures = new CardPredicate<Archetype>(Archetype.Radagast_Creatures)
                .Hero("Radagast", Sphere.Lore)
                .Titles("Radagast's Staff", "Word of Command", "Wizard Pipe", "Gwaihir's Debt", "The Eagles Are Coming!")
                .Trait("Creature.");

            var rohanMount = new CardPredicate<Archetype>(Archetype.Rohan_Mounts)
                .Hero("Elfhelm", Sphere.Leadership)
                .Trait("Mount.")
                .Titles("Westfold Horse-breeder", "Charge of the Rohirrim")
                .Not(c => c.Title == "Asfaloth");

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

            var victoryDisplay = new CardPredicate<Archetype>(Archetype.Victory_Display)
                .AnyText("Victory display")
                .Not(c => c.CardType != CardType.Player_Side_Quest && c.Text.ContainsLower("side quest"))
                .Not(c => c.CardType == CardType.Player_Side_Quest && c.Title != "Scout Ahead")
                .Not(c => c.VictoryPoints > 0 && c.Title != "Scout Ahead");

            var vilyaChampion = new CardPredicate<Archetype>(Archetype.Vilya_Champions)
                .Hero("Elrond", Sphere.Lore)
                .Hero("Gandalf")
                .Titles("Imladris Stargazer", "Master of the Forge", "Gildor Inglorion", "Light of Valinor", "Unexpected Courage", "Heed the Dream")
                .Or(c => c.CardType == CardType.Ally && c.ResourceCost >= 4);

            return new List<Func<LotRCard, Archetype>> {
                CreateArchetypeFilter(aragornVoltron),
                CreateArchetypeFilter(caldaraSwarm),
                CreateArchetypeFilter(daleArmory),
                CreateArchetypeFilter(dunedainSidequest),
                CreateArchetypeFilter(dunedainSiege),
                CreateArchetypeFilter(dwarfMining),
                CreateArchetypeFilter(dwarfSwarm),
                CreateArchetypeFilter(eagleAmbush),
                CreateArchetypeFilter(entRetaliation),
                CreateArchetypeFilter(gandalfVoltron),
                CreateArchetypeFilter(gloinVoltron),
                CreateArchetypeFilter(gondorAmbush),
                CreateArchetypeFilter(gondorSwarm),
                CreateArchetypeFilter(gondorTraps),
                CreateArchetypeFilter(gondorValour),
                CreateArchetypeFilter(grimbeornVoltron),
                CreateArchetypeFilter(haradChampions),
                CreateArchetypeFilter(hobbitAmbush),
                CreateArchetypeFilter(hobbitSecrecy),
                CreateArchetypeFilter(isengardDoomed),
                CreateArchetypeFilter(noldorDiscard),
                CreateArchetypeFilter(outlandsSwarm),
                CreateArchetypeFilter(radagastCreatures),
                CreateArchetypeFilter(rohanMount),
                CreateArchetypeFilter(rohanSacrifice),
                CreateArchetypeFilter(rohanStagingAttack),
                CreateArchetypeFilter(silvanAmbush),
                CreateArchetypeFilter(victoryDisplay),
                CreateArchetypeFilter(vilyaChampion),
            };
        }
    }
}