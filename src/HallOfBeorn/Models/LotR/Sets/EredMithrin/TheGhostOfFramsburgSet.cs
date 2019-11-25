using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.EredMithrin
{
    public class TheGhostOfFramsburgSet : CardSet
    {
        private const string setName = "The Ghost of Framsburg";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TGoF";
            Number = 53;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Ered Mithrin";

            addHero("Dáin Ironfoot", 11, Sphere.Spirit, 1, 2, 3, 5)
                .WithTraits("Dwarf.", "Noble.", "Warrior.")
                .WithText("While Dáin Ironfoot is defending, he gains, \"Action: Discard the top card of your deck to give Dáin Ironfoot +1 Defense for this attack. (Limit 3 times per phase.)\"")
                .WithFlavor("\"The time of my thought is my own to spend.\"\r\n-The Fellowship of the Ring")
                .WithInfo(84, 1, Artist.Alexander_Kozachenko);
            addAlly("Soldier of Erebor", 5, Sphere.Leadership, false, 0, 3, 3, 3)
                .WithTraits("Dwarf.", "Warrior.")
                .WithText("Action: Discard the top 3 cards from your deck to ready Soldier of ~Erebor. (Limit once per round.)")
                .WithInfo(85, 3, Artist.Matthew_Cowdery);
            addEvent("Man the Walls", 0, Sphere.Leadership)
                .WithText("Play only if no other copies of Man the Walls have been played this round.\r\nPlanning Action: Reduce the cost of the next ally played by each player this phase by 1. Those allies cannot quest this round.")
                .WithInfo(86, 3, Artist.Unknown);
            addAlly("Mirkwood Hunter", 4, Sphere.Lore, false, 2, 2, 2, 3)
                .WithTraits("Woodman.", "Ranger.")
                .WithKeywords("Ranged.")
                .WithText("Reduce the cost to play Mirkwood Hunter by 1 for each attachment on the active location.")
                .WithFlavor("...they were brave and well-armed and even the Wargs dared not attack them if there were many together...\r\n-The Hobbit")
                .WithInfo(87, 3, Artist.Unknown);
            addEvent("Familiar Lands", 1, Sphere.Lore)
                .WithText("Action: Each location with an attachment gets -2 Threat until the end of the phase.")
                .WithInfo(88, 3, Artist.Leanna_Crossan);
            addAttachment("Warrior Sword", 1, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Tactics or Warrior character.\r\nLimit 1 per character.\r\nAttached character gets +1 Attack for each enemy engaged with you. (Limit +3 Attack.)")
                .WithFlavor("He gripped tighter on the hilt of his sword and went on doggedly.-The Fellowship of the Ring")
                .WithInfo(89, 3, Artist.Aleksander_Karcz);
            addEvent("Swift and Strong", 1, Sphere.Tactics)
                .WithTraits("Song.")
                .WithText("Response: After a character you control attacks and destroys an enemy, exhaust a Weapon attached to that character to ready that character and give it +2 Attack for its next attack this phase.")
                .WithFlavor("The sword is sharp, the spear is long,\r\nThe arrow swift, the Gate is strong.\r\n-The Hobbit")
                .WithInfo(90, 3, Artist.JB_Casacop);
            addAlly("Descendant of Girion", 4, Sphere.Spirit, false, 2, 2, 2, 2)
                .WithTraits("Dale.")
                .WithText("Reduce the cost to play Item attachments on Descendant of Girion by 1.")
                .WithFlavor("-Glóin, The Fellowship of the Ring")
                .WithInfo(91, 3, Artist.Unknown);
            addAttachment("Valiant Determination", 2, Sphere.Spirit, false)
                .WithTraits("Condition.")
                .WithText("Attach to an ally.\r\nAttached ally does not exhaust to quest.")
                .WithFlavor("-The Hobbit")
                .WithInfo(92, 3, Artist.Unknown);
            addAttachment("Ring of Thrór", 1, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Ring.")
                .WithKeywords("Guarded (enemy or location).")
                .WithText("Attach to a Dwarf hero.\r\nAction: Exhaust ~Ring of Thrór and discard the top card of your deck to ready attached hero. If the discarded card is an attachment, put it into play.")
                .WithInfo(93, 3, Artist.Unknown);
            addObjective("Crypt Key", setName)
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Loot.")
                .WithTextLine("If unattached, the first player claims Crypt Key and attaches it to a hero he controls.")
                .WithTextLine("Response: When the players travel to a Discover location, exhaust Crypt Key to either increase or decrease its Discover value by 1 before resolving it.")
                .WithInfo(94, 1, Artist.Unknown);
            addObjective("Old Lantern", setName)
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Loot.")
                .WithTextLine("If unattached, the first player claims Old Lantern and attaches it to a hero he controls.")
                .WithTextLine("Action: Exhaust Old Lantern to choose a player to look at the top X cards of his deck, where X is the Discover value of the active location. He adds one of those cards to his hand and places the rest on the bottom of his deck.")
                .WithInfo(95, 1, Artist.Lukasz_Jaskolski);
            addObjective("Scatha's Teeth", setName)
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Loot.")
                .WithTextLine("If unattached, the first player claims Scatha's Teeth and attached it to a hero he controls.")
                .WithTextLine("Action: Exhaust Scatha's Teeth and attached hero to choose a player. That player reduces his threat by 2.")
                .WithInfo(96, 1, Artist.Brendan_C_Murphy);
            addLocation("The Cursed Tomb", setName, 5, 5)
                .WithUnique()
                .WithTraits("Ruins.", "Dark.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("The players cannot travel to The Cursed Tomb unless they control 3 Loot objectives.")
                .WithTextLine("Forced: After the player travel to The Cursed Tomb, search the encounter deck and discard pile for Fram's Shade and add it to the staging area. Shuffle the encounter deck. Fram's Shade makes an immediate attack against each player in turn order.")
                .WithVictoryPoints(5)
                .WithInfo(97, 1, Artist.Mariusz_Gandzel);
            addEnemy("Fram's Shade", setName, 30, 3, 3, 3, 6)
                .WithUnique()
                .WithTraits("Undead.", "Wight.", "Hazard.")
                .WithTextLine("Cannot have non-objective attachments.")
                .WithTextLine("Fram's Shade gets +1 Threat, +1 Attack, and +1 Defense for each Loot objective the players control.")
                .WithTextLine("When Fram's Shade is dealt shadow cards, deal it a number of shadow cards equal to the number of Loot objectives the players control (to a minimum of 1).")
                .WithInfo(98, 1, Artist.Guillaume_Ducos);
            addEnemy("Crypt Stalker", setName, 40, Card.VALUE_X, Card.VALUE_X, Card.VALUE_X, 5)
                .WithTraits("Undead.", "Hazard.")
                .WithTextLine("X is the tens digit of the first player's threat.")
                .WithTextLine("Forced: When Crypt Stalker attacks, raise the defending player's threat by 1.")
                .WithShadow("Either raise your threat by 2, or return attacking enemy to the staging area.")
                .WithEasyModeQuantity(1)
                .WithInfo(99, 2, Artist.Brendan_C_Murphy);
            addEnemy("Evil Spectre", setName, 35, 2, 4, 2, 4)
                .WithTraits("Undead.", "Hazard.")
                .WithText("Forced: When Evil Spectre is destroyed, shuffle it back into the encounter deck if the active location has the Dark trait.")
                .WithShadow("Attacking enemy gets +1 Attack (+2 Attack instead if the active location has the Dark trait.)")
                .WithEasyModeQuantity(2)
                .WithInfo(100, 3, Artist.Alex_Boca);
            addLocation("Forgotten Crypt", setName, 2, 2)
                .WithTraits("Ruins.", "Dark.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Forced: After Forgotten Crypt becomes the active location, discard cards from the top of the encounter deck until an Undead enemy is discarded and add it to the staging area. Then, attach a Loot objective in the encounter discard pile to that enemy as a guarded objective.")
                .WithVictoryPoints(2)
                .WithInfo(101, 2, Artist.Matthew_Cowdery);
            addLocation("Haunted Hall", setName, 4, 4)
                .WithTraits("Ruins.", "Dark.")
                .WithKeywords("Discover 4.")
                .WithText("While Haunted Hall is in the staging area, it gains, \"Forced: After a player places any amount of progress on a Dark location in the staging area, he raises his threat by 1.\"")
                .WithFlavor("Nothing assailed the company nor withstood their passage, and yet steadily fear grew...", "The Return of the King")
                .WithEasyModeQuantity(1)
                .WithInfo(102, 2, Artist.Jose_Vega);
            addLocation("Hidden Staircase", setName, Card.VALUE_X, 4)
                .WithTraits("Ruins.", "Dark.", "Hazard.")
                .WithKeywords("Discover X.")
                .WithTextLine("X is the tens digit of the first player's threat.")
                .WithTextLine("Forced: After resolving the Discover keyword on Hidden Staircase, reduce each player's threat by X is no Hazard cards were revealed by it.")
                .WithInfo(103, 2, Artist.Unknown);
            addLocation("Moonlit Passage", setName, 2, 4)
                .WithTraits("Ruins.")
                .WithKeywords("Discover 2.")
                .WithText("While Moonlit Passage is in the staging area, each player's threat cannot be reduced by more than 1 via player card effects each round.")
                .WithShadow("Raise your threat by 1.")
                .WithEasyModeQuantity(2)
                .WithInfo(104, 3, Artist.Jose_Vega);
            addLocation("Cursed Tower", setName, 3, 3)
                .WithTraits("Ruins.", "Dark.")
                .WithKeywords("Discover 3.")
                .WithText("While Cursed Tower is in the staging area, it gains: \"Forced: After a player plays an event, raise his threat by 1.\"")
                .WithShadow("Discard a non-objective attachment you control.")
                .WithEasyModeQuantity(2)
                .WithInfo(105, 3, Artist.Matthew_Cowdery);
            addTreachery("Abandoned Ruins", setName)
                .WithText("When Revealed: Each player resolves the Discover keyword of the active location in turn order. If they cannot, Abandoned ~Ruins gains surge and doomed 2.")
                .WithEasyModeQuantity(1)
                .WithShadow("Attacking enemy makes an additional attack against you after this one.")
                .WithInfo(106, 2, Artist.Matthew_Cowdery);
            addTreachery("Terrible Shadows", setName)
                .WithTraits("Hazard.")
                .WithText("When Revealed: Each character gets -1 Willpower, -1 Attack, and -1 Defense until the end of the round.")
                .WithShadow("Attacking enemy gets +1 Attack. If this attack destroys a character, raise the defending player's threat by 3.")
                .WithEasyModeQuantity(0)
                .WithInfo(107, 2, Artist.Greg_Opalinski);
            addTreachery("Slammed Shut", setName)
                .WithTraits("Hazard.")
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Each player chooses and exhausts a character he controls. Until the end of the round, character cannot be readied by player card effects.")
                .WithInfo(108, 3, Artist.David_Keen);
            addQuest("The Haunted Keep", setName, 1, 'A', 6)
                .WithFlavor("The search for the legendary sword of Fram has led you to the long-forgotten city of Framsburg. There is an evil air inside the keep, and you wonder what dangers wait for you in the darkness within.")
                .WithText("Setup: Set The Cursed Tomb aside, out of play. Each player searches the encounter deck for a different location and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("A curse lays on the keep and foul creatures prowl through the night, but you will not be deterred from your search.")
                .WithOppositeText("This stage cannot be defeated unless the players control at least 1 Loot objective.")
                .WithIncludedEncounterSets(EncounterSet.WildCreatures, EncounterSet.AfraidOfTheDark)
                .WithInfo(109, 1, Artist.Alyn_Spiller);
            addQuest("Searching the Ruins", setName, 2, 'A', 12)
                .WithFlavor("Night deepends outside and a sense of dread grows with each passing hour you spend inside the haunted keep. You fear that if you don't find Fram's sword and escape quickly, you will lose yourself to the darkness.")
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck. Then, each player reveals an encounter card.")
                .WithOppositeTextLine("Forced: At the beginning of the quest phase, the first player must choose: either raise each player's threat by 2, or discard cards from the top of the encounter deck until a location is discarded and add that location to the staging area.")
                .WithOppositeTextLine("This stage cannot be defeated unless the players control at least 2 Loot objectives.")
                .WithIncludedEncounterSets(EncounterSet.WildCreatures, EncounterSet.AfraidOfTheDark)
                .WithInfo(110, 1, Artist.Unknown);
            addQuest("The Cursed Shade", setName, 3, 'A', 6)
                .WithFlavor("You've found Fram's Tomb in the catacombs below the keep, but it is guarded by the ghastly shade of Fram himself. You must defeat him in order to win his blade, but you're not sure you can face the terror of his cold gaze.")
                .WithText("When Revealed: The first player adds The Cursed Tomb to the staging area. Each other player searches the encounter deck and discard pile for a non-unique Undead enemy and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeTextLine("Fram's Shade is immune to player card effects.")
                .WithOppositeTextLine("While The Cursed Tomb is in the victory display, Fram's Shade gains victory 6.")
                .WithOppositeTextLine("This stage cannot be defeated unless Fram's Shadw is in the victory display. When player defeat this stage, they win the game.")
                .WithIncludedEncounterSets(EncounterSet.WildCreatures, EncounterSet.AfraidOfTheDark)
                .WithInfo(111, 1, Artist.Guillaume_Ducos);
        }
    }
}
