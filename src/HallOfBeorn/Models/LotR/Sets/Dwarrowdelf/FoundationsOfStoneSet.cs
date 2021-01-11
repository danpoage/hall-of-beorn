/* Generated CardSet class: Foundations of Stone */

using System;

namespace HallOfBeorn.Models.LotR.Sets.Dwarrowdelf
{
    public class FoundationsOfStoneSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Foundations of Stone";
            Abbreviation = "FoS";
            Number = 13;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dwarrowdelf";

            addHero("Glorfindel", 5, Sphere.Spirit, 3, 3, 1, 5)
                .WithTraits("Noldor.", "Noble.", "Warrior.")
                .WithTextLine("Forced: After Glorfindel exhausts to commit to a quest, raise your threat by 1.")
                .WithFlavorLine("Glorfindel was tall and straight; his hair was of shining gold, his face fair and young and fearless and full of joy; his eyes were bright and keen, and has voice like music; on his brow sat wisdom, and in his hand was strength.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithCommunityVersion("Hrodebert/Glorfindel-Spirit-Hero")
                .WithInfo(101, 1, Artist.Magali_Villeneuve);
            addAlly("Longbeard Elder", 3, Sphere.Leadership, false, 2, 1, 1, 2)
                .WithTraits("Dwarf.")
                .WithTextLine("Response: After Longbeard Elder commits to a quest, look at the top card of the encounter deck. If that card is a location, place 1 progress token on the current quest. Otherwise, Longbeard Elder gets -1 Willpower until the end of the phase.")
                .WithInfo(102, 3, Artist.Eric_Braddock);
            addAttachment("Path of Need", 4, Sphere.Leadership, false)
                .WithTraits("Condition.")
                .WithTextLine("Limit 1 per deck. Attach to a location.")
                .WithTextLine("Heroes do not exhaust to attack, defend, or commit to a quest while attached location is the active location.")
                .WithFlavorLine("\"However it may prove, one must tread the path that need chooses!\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithLimitOnePerDeck()
                .WithInfo(103, 3, Artist.Magali_Villeneuve);
            addAlly("Trollshaw Scout", 2, Sphere.Tactics, false, 0, 2, 1, 2)
                .WithTraits("Noldor.", "Scout.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Trollshaw Scout does not exhaust to attack.Forced: After Trollshaw Scout attacks, either discard it from play or discard 1 card from your hand.")
                .WithTemplate("<p>{keyword:Ranged.}</p><p>{self} does not exhaust to attack.</p><p><b>Forced:</b> After {self} attacks, either discard it from play or discard 1 card from your hand.</p>")
                .WithInfo(104, 3, Artist.Anna_Steinbauer);
            addEvent("Heavy Stroke", 1, Sphere.Tactics)
                .WithTextLine("Response: After a Dwarf deals X damage to an enemy during combat, deal an additional X damage to that enemy. (Limit once per phase.)")
                .WithFlavorLine("\"Beside them Gimli stood with his stout legs apart, wielding his dwarf-axe.\" -The Fellowship of the Ring")
                .WithInfo(105, 3, Artist.Adam_Schumpert);
            addAlly("Imladris Stargazer", 2, Sphere.Spirit, false, 0, 0, 1, 1)
                .WithTraits("Noldor.")
                .WithTextLine("Action: Exhaust Imladris Stargazer to choose a player. That player looks at the top 5 cards of his deck and then returns them to the top of his deck in any order.")
                .WithInfo(106, 3, Artist.Magali_Villeneuve);
            addAttachment("Light of Valinor", 1, Sphere.Spirit, true)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a Noldor or Silvan hero.")
                .WithTextLine("Attached hero does not exhaust to commit to a quest.")
                .WithFlavorLine("\"... those who have dwelt in the Blessed Realm live at once in both worlds, and against both the Seen and Unseen they have great power.\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithInfo(107, 3, Artist.Lin_Bo);
            addEvent("Daeron's Runes", 0, Sphere.Lore)
                .WithTextLine("Action: Draw 2 cards. Then, discard 1 card from your hand.")
                .WithFlavorLine("\"These are Daeron's Runes, such as were used of old in Moria...\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithInfo(108, 3, Artist.Carolina_Eade);
            addAttachment("Healing Herbs", 0, Sphere.Lore, false)
                .WithTextLine("Attach to a Lore hero.")
                .WithTextLine("Action: Discard Healing Herbs and exhaust attached hero to heal all damage on 1 character.")
                .WithInfo(109, 3, Artist.Sara_Biddle);
            addAttachment("Asfaloth", 2, Sphere.Lore, true)
                .WithTraits("Mount.")
                .WithTextLine("Attach to a Noldor or Silvan hero.")
                .WithTextLine("Action: Exhaust Asfaloth to place 1 progress token on any location. (2 tokens instead if attached hero is Glorfindel.)")
                .WithFlavorLine("Suddenly into view below came a white horse, gleaming in the shadows, running swiftly. In the dusk its headstall flickered and flashed as if it were studded with gems like living stars. -The Fellowship of the Ring")
                .WithTemplate("<p>Attach to a {traits-hero:Noldor,Silvan}.</p><b>Action:</b> Exhaust {self} to place 1 progress token on any location. (2 tokens instead if attached hero is <a title='Glorfindel Hero' href='/Cards/Search?Query=%2Btitle%3DGlorfindel&CardType=Hero' target='_blank'>Glorfindel</a>.)<p></p><p class='flavor-text'>Suddenly into view below came a white horse, gleaming in the shadows, running swiftly. In the dusk its headstall flickered and flashed as if it were studded with gems like living stars. &ndash;The Fellowship of the Ring</p>")
                .WithInfo(110, 3, Artist.Sandara_Tang);
            addQuest("The Dripping Walls", "Foundations of Stone", 1, 'A', 9)
                .WithTextLine("Setup: Place the Foundations of Stone encounter set aside, out of play. The first player attaches Cave Torch to a hero of his choice.")
                .WithFlavorLine("Your journey has led to a decrepit portion of the mines, untouched by Dwarven pick for many a year. The air grows thick with moisture, and the walls almost appear to be weeping.")
                .WithTemplate("<p class='flavor-text'>Your journey has led to a decrepit portion of the mines, untouched by Dwarven pick for many a year. The air grows thick with moisture, and the walls almost appear to be weeping.</p><p><b>Setup:</b> Place the <a title='Foundations of Stone Encounter Set' href='/Cards/Search?CardType=Encounter&EncounterSet=Foundations+of+Stone' target='_blank'>Foundations of Stone</a> encounter set aside, out of play. The first player attaches <a title='Cave Torch (Khazad-dûm)' href='/Cards/Details/Cave-Torch-KD' target='_blank'>Cave Torch</a> to a hero of his choice.</p>")
                .WithOppositeTextLine("When Revealed: Reveal 1 card from the encounter deck per player, and add it to the staging area.")
                .WithOppositeFlavorLine("A low rumble sounds from below. There are a variety of underground waterways in Moria, but they should not be disturbed.")
                .WithTemplate2("<p class='flavor-text'>A low rumble sounds from below. There are a variety of underground waterways in Moria, but they should not be disturbed.</p><p><b>When Revealed:</b> Reveal 1 card from the encounter deck per player, and add it to the staging area.</p>")
                .WithIncludedEncounterSets(EncounterSet.GoblinsOfTheDeep, EncounterSet.HazardsOfThePit, EncounterSet.TwistsAndTurns)
                .WithInfo(111, 1, Artist.Ilich_Henriquez);
            addQuest("The Water's Edge", "Foundations of Stone", 2, 'A', 12)
                .WithFlavorLine("Small rivers cut their way across your path. Some are not much more than a trickle, and recent looking too. Another rumble shakes the walls, this time it seems to be above you.")
                .WithOppositeTextLine("Forced: After a player commits characters to the quest, he must discard the top 2 cards of his deck.")
                .WithIncludedEncounterSets(EncounterSet.GoblinsOfTheDeep, EncounterSet.HazardsOfThePit, EncounterSet.TwistsAndTurns)
                .WithInfo(112, 1, Artist.Trudi_Castle);
            addQuest("Washed Away!", "Foundations of Stone", 3, 'A', 0)
                .WithFlavorLine("With a groan the ground crumbles under your feet, the entire section of the tunnel giving way to a deep darkness and the rush of water. There is a feeling of weightlessness, followed by the icy wet clutches of an underground river.")
                .WithOppositeTextLine("When Revealed: Discard all Item, Armor, Weapon, Light cards and all encounter deck cards from play, Shuffle all enemy and treachery cards in the encounter discard pile together with the Foundations of Stone encounter set. This deck becomes the new encounter deck. remove all other encounter deck cards from the game. Then, starting with the first player, each player draws a random stage 4 quest card. Remove all other stage 4 quest cards from the game.")
                .WithIncludedEncounterSets(EncounterSet.GoblinsOfTheDeep, EncounterSet.HazardsOfThePit, EncounterSet.TwistsAndTurns)
                .WithInfo(113, 1, Artist.Marco_Caradonna);
            addQuest("Below the Mines", "Foundations of Stone", 4, 'A', 11)
                .WithOppositeTitle("Sheltered Rocks")
                .WithSlugSuffix("Sheltered Rocks")
                .WithFlavorLine("The river has deposited you at...")
                .WithOppositeTextLine("When Revealed: Create your own staging area. Reveal 2 cards from the encounter deck and add them to your staging area.")
                .WithOppositeTextLine("Forced: After the 11th progress token is placed on Sheltered Rocks, join another player at the beginning of the travel phase. If you cannot join another player, all players continue to stage 5 together.")
                .WithBackArtist(Artist.David_Lecossu)
                .WithIncludedEncounterSets(EncounterSet.GoblinsOfTheDeep, EncounterSet.HazardsOfThePit, EncounterSet.TwistsAndTurns)
                .WithInfo(114, 1, Artist.Cristi_Balanescu);
            addQuest("Below the Mines", "Foundations of Stone", 4, 'A', 17)
                .WithOppositeTitle("The Endless Caves")
                .WithSlugSuffix("The Endless Caves")
                .WithFlavorLine("The river has deposited you at...")
                .WithOppositeTextLine("When Revealed: Create your own staging area. Discard all resources from your heroes.")
                .WithOppositeTextLine("Forced: After the 17th progress token is placed on The Endless Caves, join another player at the beginning of the travel phase. If you cannot join another player, all players continue on to stage 5 together.")
                .WithBackArtist(Artist.Cristi_Balanescu)
                .WithIncludedEncounterSets(EncounterSet.GoblinsOfTheDeep, EncounterSet.HazardsOfThePit, EncounterSet.TwistsAndTurns)
                .WithInfo(115, 1, Artist.Cristi_Balanescu);
            addQuest("Below the Mines", "Foundations of Stone", 4, 'A', 7)
                .WithOppositeTitle("The Shivering Bank")
                .WithSlugSuffix("The Shivering Bank")
                .WithFlavorLine("The river has deposited you at...")
                .WithOppositeTextLine("When Revealed: Create your own staging area. Discard your hand. Reveal 2 cards from the encounter deck and add them to your staging area.")
                .WithOppositeTextLine("Forced: After the 7th progress token is placed on The Shivering Bank, join another player at the beginning of the travel phase. If you cannot join another player, all players continue on to stage 5 together.")
                .WithBackArtist(Artist.Cristi_Balanescu)
                .WithIncludedEncounterSets(EncounterSet.GoblinsOfTheDeep, EncounterSet.HazardsOfThePit, EncounterSet.TwistsAndTurns)
                .WithInfo(116, 1, Artist.Cristi_Balanescu);
            addQuest("Below the Mines", "Foundations of Stone", 4, 'A', 5)
                .WithOppositeTitle("Old One Lair")
                .WithSlugSuffix("Old One Lair")
                .WithFlavorLine("The river has deposited you at...")
                .WithOppositeTextLine("When Revealed: Create you own staging area. Reveal 4 cards from the encounter deck and add them to your staging area.")
                .WithOppositeTextLine("Forced: After the 5th progress token is placed on Old One Lair, join another player at the beginning of the travel phase. If you cannot join another player, all players continue on to stage 5 together.")
                .WithBackArtist(Artist.Cristi_Balanescu)
                .WithIncludedEncounterSets(EncounterSet.GoblinsOfTheDeep, EncounterSet.HazardsOfThePit, EncounterSet.TwistsAndTurns)
                .WithInfo(117, 1, Artist.Cristi_Balanescu);
            addQuest("Out of the Depths", "Foundations of Stone", 5, 'A', 11)
                .WithFlavorLine("The shaft shoots upwards, the glimmering lines of mithril illuminating your way out of the depths of the mountain. The makeshift ladder is narrow, but you cannot linger in the realm of those things of darkness, who gnaw at the roots of the world.")
                .WithOppositeTextLine("When Revealed: Reveal 1 card from the encounter deck per player, and add it to the staging area.")
                .WithOppositeTextLine("Each player cannot commit more allies to the quest than the number of heroes he is also committing to the quest.")
                .WithOppositeTextLine("If the players defeat this stage, they have won the game.")
                .WithIncludedEncounterSets(EncounterSet.GoblinsOfTheDeep, EncounterSet.HazardsOfThePit, EncounterSet.TwistsAndTurns)
                .WithInfo(118, 1, Artist.Anthony_Palumbo);
            addObjective("Durin's Axe", "Foundations of Stone")
                .WithUnique()
                .WithTraits("Weapon.", "Artifact.")
                .WithKeywords("Surge.", "Restricted.")
                .WithTextLine("Surge. Restricted.")
                .WithTextLine("Attached hero gets +3 Attack. If attached hero is a Dwarf, it gets +1 Willpower.")
                .WithTextLine("Action: Exhaust a hero to claim this objective. Then, attach Durin's Axe to that hero as an attachment.")
                .WithInfo(119, 1, Artist.Stephen_M_Mabee);
            addObjective("Durin's Helm", "Foundations of Stone")
                .WithUnique()
                .WithTraits("Armor.", "Artifact.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Attached hero gets +1 Defense. If attached hero is a Dwarf, it gets +2 hit points.")
                .WithTextLine("Action: Exhaust a hero to claim this objective. Then, attach Durin's Helm to that hero as an attachment.")
                .WithInfo(120, 1, Artist.Stephen_M_Mabee);
            addLocation("Drowned Treasury", "Foundations of Stone", 2, 3)
                .WithTraits("Underground.", "Underwater.")
                .WithTextLine("If Drowned Treasury is the active location at the end of the quest phase, each player must discard 1 character he controls.")
                .WithTextLine("Response: After Drowned Treasury leaves play as an explored location, each player may draw 2 cards or claim 1 objective in play.")
                .WithTemplate("<p>If {self} is the active location at the end of the quest phase, each player must discard 1 character he controls.</p><p><b>Response:</b> After {self} leaves play as an explored location, each player may draw 2 cards or claim 1 objective in play.</p>")
                .WithInfo(121, 3, Artist.Carolina_Eade);
            addLocation("Mithril Lode", "Foundations of Stone", 2, 5)
                .WithTraits("Underground.")
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("While Mithril Lode is the active location, it gains: 'Refresh Action: Exhaust a character you control to place X progress tokens on the current quest card, bypassing any active location. X is the exhausted character's Willpower. (Limit once per round.)'")
                .WithTemplate("<p>{keyword:Doomed 1.}</p><p>While {self} is the active location, it gains: <blockquote><b>Refresh Action:</b> Exhaust a character you control to place X progress tokens on the current quest card, bypassing any active location. X is the exhausted character's {Willpower}. (Limit once per round.)</blockquote></p>")
                .WithInfo(122, 1, Artist.Cristi_Balanescu);
            addTreachery("Deep Deep Dark", "Foundations of Stone")
                .WithKeywords("Doomed 1.", "Surge.")
                .WithTextLine("Doomed 1. Surge.")
                .WithTextLine("When Revealed: Attach 1 card from the top of the first player's deck to each Nameless enemy in play, if able.")
                .WithShadow("Shadow: If attacking enemy is Nameless, the defending player must discard his hand.")
                .WithTemplate("<p>{keyword:Doomed 1.} {keyword:Surge.}</p><p><b>When Revealed:</b> Attach 1 card from the top of the first player's deck to each {trait:Nameless.@Nameless} enemy in play, if able.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> If attacking enemy is {trait:Nameless.@Nameless}, the defending player must discard his hand.</p>")
                .WithInfo(123, 4, Artist.Rafal_Hrynkiewicz);
            addTreachery("Lost and Alone", "Foundations of Stone")
                .WithTextLine("When Revealed: Each player chooses and shuffles a hero he controls into his deck. When he draws that hero, he puts it into play.")
                .WithShadow("Shadow: If attacking enemy is Nameless, the defending player must discard his hand.")
                .WithTemplate("<p><b>When Revealed:</b> Each player chooses and shuffles a hero he controls into his deck. When he draws that hero, he puts it into play.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> If attacking enemy is {trait:Nameless.@Nameless}, the defending player must discard his hand.</p>")
                .WithEasyModeQuantity(0)
                .WithInfo(124, 2, Artist.David_Chen);
            addEnemy("Nameless Thing", "Foundations of Stone", 27, 3, Card.VALUE_X, 3, Card.VALUE_X)
                .WithTraits("Nameless.")
                .WithTextLine("Forced: After ~Nameless Thing engages a player, attach the top 2 cards of that player's deck to it.")
                .WithTextLine("X is the printed cost of all attached cards on this card. If there are no cards attached, X is 3.")
                .WithVictoryPoints(1)
                .WithEasyModeQuantity(3)
                .WithInfo(125, 5, Artist.Timo_Karhula);
            addEnemy("Elder Nameless Thing", "Foundations of Stone", 40, 4, Card.VALUE_X, 4, Card.VALUE_X)
                .WithTraits("Nameless.")
                .WithTextLine("Forced: After Elder ~Nameless Thing engages a player, attach the top 3 cards of that player's deck to it.")
                .WithTextLine("X is the printed cost of all attached cards on this card. If there are no cards attached, X is 4.")
                .WithVictoryPoints(3)
                .WithEasyModeQuantity(1)
                .WithInfo(126, 3, Artist.Allison_Theus);
            addEnemy("Moria Bats", "Foundations of Stone", 33, 1, 1, 2, 1)
                .WithTraits("Creature.")
                .WithTextLine("Only characters with ranged can attack or defend against Moria Bats.")
                .WithTextLine("While Moria Bats is engaged with a player, it gets +1 Attack for each other enemy engaged with that player.")
                .WithInfo(127, 4, Artist.Cristi_Balanescu);
        }
    }
}
