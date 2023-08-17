/* Generated CardSet class: Celebrimbor's Secret */

using System;

namespace HallOfBeorn.Models.LotR.Sets.TheRingMaker
{
    public class CelebrimborsSecretSet : CardSet
    {
        public const string setName = "Celebrimbor's Secret";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "CS";
            Number = 27;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "The Ring-maker";

            addHero("Galadriel", 9, Sphere.Spirit, 4, 0, 0, 4)
                .WithTraits("Noldor.", "Noble.")
                .WithTextLine("Galadriel cannot quest, attack, or defend. Allies you control do not exhaust to commit to the quest during the round they enter play.")
                .WithTextLine("Action: Exhaust Galadriel to choose a player. That player reduces his threat by 1 and draws 1 card. (Limit once per round.)")
                .WithCommunityVersion("Galadriel-Grey-Company-Gen-Con-2015")
                .WithCommunityVersion("Galadriel-Whispers-in-the-Trees")
                .WithCommunityVersion("Galadriel-Nouveau-Hunters")
                .WithCommunityVersion("RiddermarkLord/Galadriel-Spirit-Hero-1")
                .WithCommunityVersion("RiddermarkLord/Galadriel-Spirit-Hero-2")
                .WithCommunityVersion("Hrodebert/Galadriel-Spirit-Hero-1")
                .WithCommunityVersion("Hrodebert/Galadriel-Spirit-Hero-2")
                .WithAges(Age.First_Age, Age.Second_Age, Age.Third_Age)
                .WithInfo(112, 1, Artist.Magali_Villeneuve);
            addAttachment("Heir of Mardil", 1, Sphere.Leadership, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a Noble hero.")
                .WithTextLine("Response: After attached hero gains any number of resources from a card effect, exhaust Heir of Mardil to ready attached hero.")
                .WithFlavorLine("\"...in my turn I bore it, and so did each eldest son of our house, far back into the vanished years before the failing of the kings...\"")
                .WithFlavorLine("-Denethor, The Return of the King")
                .WithInfo(113, 3, Artist.Alexandre_Dainche);
            addAlly("Orophin", 3, Sphere.Leadership, true, 2, 2, 0, 2)
                .WithTraits("Silvan.", "Scout.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Response: After Orophin enters play, return a Silvan ally from your discard pile to your hand.")
                .WithFlavorLine("\"Orophin has now gone in haste back to our dwellings to warn our people.\"")
                .WithFlavorLine("-Haldir, The Fellowship of the Ring")
                .WithCommunityVersion("RiddermarkLord/Orophin-MotK-Leadership-Hero")
                .WithInfo(114, 3, Artist.Magali_Villeneuve);
            addAlly("Henneth Annûn Guard", 3, Sphere.Tactics, false, 0, 2, 2, 2)
                .WithTraits("Gondor.", "Warrior.")
                .WithTextLine("You may give Henneth Annûn Guard doomed 1 when you play it from your hand. If you do, it gains :\"Response: After you play Henneth Annûn Guard, choose a character. Until the end of the round, that character gets +2 Defense and gains sentinel.\"")
                .WithFlavorLine("\"Does he think that men sleep without watch all night?\" -Faramir, The Two Towers")
                .WithInfo(115, 3, Artist.Kristina_Carroll);
            addEvent("Charge of the Rohirrim", 2, Sphere.Tactics)
                .WithTextLine("Action: Until the end of the phase, each Rohan character with a Mount attachment gets +3 Attack.")
                .WithFlavorLine("\"Arise, arise, riders of Théoden!\" -Théoden, The Return of the King")
                .WithInfo(116, 3, Artist.Igor_Kieryluk);
            addAlly("Galadriel's Handmaiden", 2, Sphere.Spirit, false, 2, 0, 1, 1)
                .WithTraits("Silvan.")
                .WithTextLine("Response: After Galadriel's Handmaiden enters play, choose a player. That player reduces his threat by 1.")
                .WithFlavorLine("Her maidens stood silent about her, and a while she looked upon her guests. -The Fellowship of the Ring")
                .WithInfo(117, 3, Artist.Nathalia_Gomes);
            addAttachment("Mirror of Galadriel", 1, Sphere.Spirit, true)
                .WithTraits("Artifact.", "Item.")
                .WithTextLine("Attach to Galadriel.")
                .WithTextLine("Action: Exhaust Mirror of Galadriel to search the top 10 cards of your deck for a card and add it to your hand. Shuffle the rest back into your deck. Then, discard a random card from your hand.")
                .WithFlavorLine("\"What you will see, if you leave the Mirror free to work, I cannot tell. For it shows things that were, things that are, things that yet may be.\"")
                .WithFlavorLine("-Galadriel, The Fellowship of the Ring")
                .WithCommunityVersion("Mirror-of-Galadriel-Nouveau-Hunters")
                .WithAges(Age.Second_Age, Age.Third_Age)
                .WithInfo(118, 3, Artist.Jose_Vega);
            addAlly("Wandering Ent", 2, Sphere.Lore, false, 2, 2, 2, 3)
                .WithTraits("Ent.")
                .WithTextLine("Cannot have restricted attachments.")
                .WithTextLine("Enters play exhausted.")
                .WithFlavorLine("There were songs about the hunt of the Ents for the Entwives sung among Elves and Men from Mirkwood to Gondor. -The Two Towers")
                .WithInfo(119, 3, Artist.Dmitry_Prosvirnin);
            addAttachment("Cloak of Lórien", 1, Sphere.Lore, false)
                .WithTraits("Item.")
                .WithTextLine("Attach to a Noldor or Silvan character.")
                .WithTextLine("Limit 1 per character.")
                .WithTextLine("Attached character gets +1 Defense (+2 Defense instead if the active location has the Forest trait).")
                .WithFlavorLine("It was hard to say what colour they were: grey with the hue of twilight under the trees they seemed to be; and yet if they were moved, or set in another light, they were green as shadowed leaves... -The Fellowship of the Ring")
                .WithInfo(120, 3, Artist.Sara_K_Diesel);
            addAttachment("Nenya", 1, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Ring.")
                .WithTextLine("Attach to Galadriel. She gains a Lore resource icon.")
                .WithTextLine("Quest Action: Exhaust Nenya and Galadriel to add her Willpower to another character's Willpower until the end of the phase.")
                .WithFlavorLine("\"The is Nenya, the Ring of Adamant, and I am its keeper.\" -Galadriel, The Fellowship of the Ring")
                .WithAges(Age.Second_Age, Age.Third_Age)
                .WithInfo(121, 3, Artist.Mike_Nash);
            addQuest("The Ruins of Ost-in-Edhil", EncounterSet.CelebrimborsSecret, 1, 'A', 14)
                .WithKeywords("Time 3.")
                .WithTextLine("Setup: Add Bellach, The Orcs' Search, and The Secret Chamber to the staging area. Attach Celebrimbor's Mould to The Secret Chamber. Each player adds a different Ost-in-Edhil location to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("You have finally reached the ruins of Ost-in-Edhil, but Bellach and his Orcs have arrived before you. They appear to be searching for the hidden chamber. If you want to reach it first, you will have to move quickly and carefully...")
                .WithOppositeTextLine("Time 3.")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, trigger each Scour effect currently in play. Place 3 time counters on this stage.")
                .WithOppositeTextLine("Ballach is immune to player card effects and cannot be engaged.")
                .WithOppositeTextLine("The players cannot advance unless Celebrimbor's Mould is attached to a hero.")
                .WithIncludedEncounterSets(EncounterSet.MistyMountainOrcs, EncounterSet.BrokenLands)
                .WithInfo(122, 1, Artist.Ben_Zweifel);
            addQuest("The Enemy's Servant", EncounterSet.CelebrimborsSecret, 2, 'A', 12)
                .WithKeywords("Time 3.")
                .WithTextLine("When Revealed: Trigger each Scour effect currently in play. Bellach makes an attack against the player who controls Celebrimbor's Mould. Then, attach Celebrimbor's Mould to Bellach.")
                .WithFlavorLine("You have just recovered a partial ring-mould from Celebrimbor's secret forge when you are struck from behind. You look up to see Bellach holding the mould and gloating, \"Fools! My master will be pleased.\" As he turns to leave, he shouts to his servants, \"Kill them!\" You must escape the Orcs and recapture the mould!")
                .WithOppositeTextLine("Time 3.")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, trigger each scour effect currently in play. Place 3 time counters on this stage.")
                .WithOppositeTextLine("Unless there is at last 12 progress on this stage, Bellach is immune to player card effects and cannot be engaged.The players cannot win unless Celebrimbor's Mould is attached to a hero. If the players defeat this stage, they win the game.")
                .WithIncludedEncounterSets(EncounterSet.MistyMountainOrcs, EncounterSet.BrokenLands)
                .WithInfo(123, 1, Artist.Rafal_Hrynkiewicz);
            addEnemy("Bellach", EncounterSet.CelebrimborsSecret, 50, Card.VALUE_X, 5, 4, 7)
                .WithUnique()
                .WithTraits("Mordor.", "Spy.")
                .WithTextLine("X is the number of cards underneath The Orcs' Search.")
                .WithTextLine("Scour: Each player must search the encounter deck and discard pile for an Orc enemy and add it to the staging area.")
                .WithVictoryPoints(5)
                .WithInfo(124, 1, Artist.Rafal_Hrynkiewicz);
            addObjective("The Orcs' Search", EncounterSet.CelebrimborsSecret)
                .WithTextLine("When a location has damage equal to its printed quest points, place it facedown underneath The Orcs' Search.")
                .WithTextLine("Forced: At the end of the refresh phase, raise each player's threat by 1 for each card underneath The Orcs' Search.")
                .WithInfo(125, 1, Artist.Rafal_Hrynkiewicz);
            addLocation("The Secret Chamber", EncounterSet.CelebrimborsSecret, Card.VALUE_X, 6)
                .WithUnique()
                .WithTraits("Ost-in-Edhil.", "Ruins")
                .WithTextLine("X is the number of players in the game. Immune to player card effects.")
                .WithTextLine("Travel: Remove 3 progress from the current quest to travel here.")
                .WithTextLine("If the Secret Chamber is placed underneath The Orcs' Search, the players lose the game.")
                .WithVictoryPoints(3)
                .WithInfo(126, 1, Artist.Jose_Vega);
            addObjective("Celebrimbor's Mould", EncounterSet.CelebrimborsSecret)
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithTextLine("If Celebrimbor's Mould is free of encounters, the first player claims it and attaches it to a hero he controls.")
                .WithTextLine("If the attached hero leaves play, the players lose the game.")
                .WithFlavorLine("\"Celebrimbor of Hollin drew these signs.\" -Gandalf, The Fellowship of the Ring")
                .WithInfo(127, 1, Artist.Michael_Rasmussen);
            addEnemy("Bellach's Scout", EncounterSet.CelebrimborsSecret, 40, 2, 3, 2, 4)
                .WithTraits("Mordor.", "Orc.")
                .WithTextLine("When Revealed: Either place 3 damage on the active location, or reveal an additional encounter card.")
                .WithTextLine("")
                .WithTextLine("Scour: Place 1 damage on the active location.")
                .WithShadow("Shadow: Place 1 damage on the active location.")
                .WithEasyModeQuantity(3)
                .WithInfo(128, 4, Artist.Florian_Devos);
            addEnemy("Prowling Orc", EncounterSet.CelebrimborsSecret, 45, 3, 5, 3, 5)
                .WithTraits("Mordor.", "Orc.")
                .WithTextLine("Forced: After Prowling ~Orc attacks, place 1 damage on the active location.")
                .WithTextLine("Scour: Prowling ~Orc engages the player with the highest threat and makes an immediate attack.")
                .WithFlavorLine("\"Garn! You don't even know what you're looking for.\" -Orc, The Return of the King")
                .WithEasyModeQuantity(1)
                .WithInfo(129, 2, Artist.Ilich_Henriquez);
            addLocation("Ruined Plaza", EncounterSet.CelebrimborsSecret, 2, 2)
                .WithTraits("Ost-in-Edhil.", "Ruins.")
                .WithTextLine("Forced: After Ruined Plaza enters the staging area, place 1 damage here.")
                .WithShadow("Shadow: Defending player assigns X damage amoung characters he controls. X is the number of cards underneath The Orcs' Search.")
                .WithInfo(130, 3, Artist.Joel_Hustak);
            addLocation("Collapsed Tower", EncounterSet.CelebrimborsSecret, 1, 4)
                .WithTraits("Ost-in-Edhil.", "Ruins.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Scour: Return this location to the staging area and place 2 damage here.")
                .WithShadow("Shadow: Excess damage from this attack must be placed on the active location, if able.")
                .WithInfo(131, 2, Artist.Anthony_Feliciano);
            addLocation("Ancient Foundation", EncounterSet.CelebrimborsSecret, 2, 4)
                .WithTraits("Ost-in-Edhil.", "Ruins.")
                .WithTextLine("Scour: Assign X damage amoung locations in play. X is the number of locations in play. This ability does not stack with other copies of Ancient Foundation.")
                .WithTextLine("Travel: Place 1 damage on this location to travel here.")
                .WithFlavorLine("...deep they delved us, fair they wrought us, hight they builded us; but they are gone. -Legolas, The Fellowship of the Ring")
                .WithInfo(132, 4, Artist.Titus_Lunter);
            addLocation("City Remains", EncounterSet.CelebrimborsSecret, 3, 3)
                .WithTraits("Ost-in-Edhil.", "Ruins.")
                .WithTextLine("Forced: After placing any amount of progress here, trigger the topmost **Scour** effect in the discard pile, if able.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, raise each player's threat by 1 for each card underneath The Orcs' Search.")
                .WithEasyModeQuantity(2)
                .WithInfo(133, 4, Artist.Ben_Zweifel);
            addTreachery("Discovered!", EncounterSet.CelebrimborsSecret)
                .WithTextLine("When Revealed: Either trigger ech Scour effect currently in play, or each player places a random card from his hand facedown underneath The Orcs' Search.")
                .WithShadow("Shadow: If this attack destroy's a character, place that character facedown underneath The Orcs' Search.")
                .WithEasyModeQuantity(0)
                .WithInfo(134, 2, Artist.Louis_Green);
            addTreachery("Desecrated Ruins", EncounterSet.CelebrimborsSecret)
                .WithTextLine("When Revealed: Place 3 damage on the active location. If there is no active location, Desecrated ~Ruins gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys an ally, place X damage on the active location. X is that ally's cost.")
                .WithInfo(135, 3, Artist.David_Hammond);
            addTreachery("Spies from Mordor", EncounterSet.CelebrimborsSecret)
                .WithTextLine("When Revealed: Each player must exhaust X characters he controls. X is the number of cards underneath The Orcs' Search. If no characters are exhausted this way, Spies from ~Mordor gains surge.")
                .WithShadow("Shadow: Defending player discards a non-objective attachment he controls.")
                .WithInfo(136, 2, Artist.Florian_Devos);
        }
    }
}
