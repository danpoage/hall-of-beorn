using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TempleOfTheDeceived : CardSet
    {
        private const string setName = "Temple of the Deceived";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TotD";
            Number = 38;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dream-chaser";

            Cards.Add(Card.Hero("Elfhelm", "", Sphere.Leadership, 10, 2, 2, 2, 4)
                .WithTraits("Rohan.", "Scout.", "Warrior.")
                .WithText("Each Spirit hero with an attached Mount gets +1 Willpower.\r\nEach Tactics hero with an attached Mount gets +1 Attack.\r\nEach Leadership hero with an attached Mount gets +1 Defense.")
                .WithFlavor("Ahead nearer the walls Elfhelm's men were among the siege-engines, hewing, slaying, driving their foes into the fire-pits.\r\n-The Return of the King")
                .WithInfo(57, 1, Artist.DinoDrawing));
            Cards.Add(Card.Ally("Ceorl", "", Sphere.Leadership, 2, 1, 2, 0, 2)
                .WithUnique()
                .WithTraits("Rohan.", "Scout.")
                .WithText("Action: Spend 1 Spirit resource to ready Ceorl. Then, you may give control of Ceorl to another player. Any player may trigger this action. (Limit once per phase).")
                .WithFlavor("He drew himself up. Then he knelt, offering his notched sword to the king. \"Command me, lord!\" he cried.\r\n-The Two Towers")
                .WithInfo(58, 3, Artist.Aleksander_Karcz));
            Cards.Add(Card.Attachment("Armored Destrier", "", Sphere.Leadership, 2)
                .WithGeneric()
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Leadership or sentinel hero.\r\nResponse: After attached hero defends against an attack, exhaust Armored Destrier to ready attached hero. Then, discard a shadow card from another enemy engaged with the defending player.")
                .WithInfo(59, 3, Artist.Sandara_Tang));
            Cards.Add(Card.Ally("Déorwine", "", Sphere.Tactics, 4, 0, 1, 3, 3)
                .WithNormalizedTitle("Deorwine")
                .WithUnique()
                .WithTraits("Rohan.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: While Déorwine is defending, spend 1 Leadership resource to cancel a shadow effect dealt to the attacking enemy. Any player may trigger this action.") 
                .WithInfo(60, 3, Artist.Aleksander_Karcz));
            Cards.Add(Card.Event("Revealed in Wrath", "", Sphere.Tactics, 1)
                .WithText("Play only if you controla  Noldor hero.\r\nAction: Choose a non-unique enemy. Until the end of the phase, treat the chosen enemy's printed text box as if it were blank (except for Traits).")
                .WithFlavor("\"...seeing an Elf-lord revealed in his wrath, they were dismayed, and their horses were stricken with madness.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(61, 3, Artist.Sebastian_Giacobino));
            Cards.Add(Card.Ally("Rhovanion Outrider", "", Sphere.Spirit, 3, 1, 2, 1, 2)
                .WithGeneric()
                .WithTraits("Dale.", "Scout.")
                .WithText("Response: After Rhovanion Outrider coomits to the quest, place 1 progress on a location in the staging area. If that location is not explored by this effect, give Rhovanion Outrider +1 Willpower until the end of the phase.")
                .WithInfo(62, 3, Artist.Beth_Sobel));
            Cards.Add(Card.Event("Scouting Party", "", Sphere.Spirit, 2)
                .WithText("Response: After you commit characters to the quest, if each character you have commited to the quest is a Scout, each of these characters gets +2 Willpower until the end of the phase.")
                .WithInfo(63, 3, Artist.Guillaume_Ducos));
            Cards.Add(Card.Attachment("Entangling Nets", "", Sphere.Lore, 1)
                .WithGeneric()
                .WithTraits("Trap.")
                .WithText("Play Entagling Nets into the staging area, unattached.\r\nIf unattached, attach Entangling Nets to the next eligible enemy that enters the staging area.\r\nAttached enemy gets -2 Attack and -2 Defense.")
                .WithInfo(64, 3, Artist.Sam_Lamont));
            Cards.Add(Card.Event("Arrows from the Trees", "", Sphere.Lore, 1)
                .WithText("Play only after making engagement checks.\r\nEncounter Action: If no enemies were engaged this phase, deal 1 damage to each enemy in the staging area. Then, the players as a group may spend 3 Tactics resources to deal 2 additional damage to each enemy in the staging area.")
                .WithInfo(65, 3, Artist.Tristan_Denecke));
            Cards.Add(Card.Ally("Ered Luin Miner", "", Sphere.Neutral, 3, 1, 1, 1, 2)
                .WithGeneric()
                .WithTraits("Dwarf.")
                .WithText("Response: After Ered Luin Miner is discarded from the top of your deck, put it into play under your control.")
                .WithFlavor("Tools were to be found in plenty that the miners and quarriers and builders of old had used; and at such work the dwarves were still very skilled.\r\n-The Hobbit")
                .WithInfo(66, 3, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Quest("Searching the Island", "", 3, 1, setName, null)
                .WithText("Setup: Prepare the Island Map (see insert). Flip over the top-left and bottom-left locations of the Island Map (without resolving their Forced effects, if any), and choose one as the player's starting active location, using a resource token to represent which location is active. The first player takes control of Captain Sahír, and the last player takes control of Na'asiyah (objective-ally side faceup). Add Temple Guardian to the staging area and attach Gate Key to it, guarded. Shuffle the encounter deck.")
                .WithOppositeFlavor("Sahír has led you to an uncharted isle, and has agreed to help you find a chest he claims the black key will open. First, you must find the Gate Key that opens the way to the grand temple on the eastern side of the island.")
                .WithKeywords("Exploration.")
                .WithOppositeText("For each progress that would be placed on Searching the Island, you may place it on a location in the staging area, instead.")
                .WithIncludedEncounterSets(EncounterSet.RuinsOfNumenor, EncounterSet.DrownedDead, EncounterSet.TheStormcallerElite)
                .WithInfo(67, 1, Artist.Sara_Winters));
            Cards.Add(Card.Location("The Grotto's Entrance", "", setName, 2, 8)
                .WithSecondImage("Temple-of-the-Deceived")
                .WithUnique()
                .WithTraits("Ruins.")
                .WithKeywords("Uncharted.")
                .WithText("Forced: When The Grotto's Entrance is flipped over while active, put Temple ~Guardian into play from the victory display, engaged with the player with the highest threat.\r\nWhen the 8th progress is placed on The Grotto's Entrance, the players have found the sunken ruins and win the game.")
                .WithOppositeText("Uncharted. Immune to player card effects.\r\nTravel: Exhaust the ~Gate ~Key to travel here.\r\nForced: After Temple of the Deceived becomes the active location, flip it over.")
                .WithInfo(68, 1, Artist.Sara_Winters));
            Cards.Add(Card.Location("Temple Halls", "", setName, 5, 5)
                .WithSecondImage("Temple-of-the-Deceived")
                .WithTraits("Ruins.")
                .WithKeywords("Uncharted.")
                .WithText("While Temple Halls is the active location, each character gets -1 Attack and -1 Defense.\r\nForced: When Temple Halls is flipped over while active, put Temple ~Guardian into play from the victory display, engaged with the player with the highest threat.")
                .WithOppositeText("Uncharted. Immune to player card effects.\r\nTravel: Exhaust the ~Gate ~Key to travel here.\r\nForced: After Temple of the Deceived becomes the active location, flip it over.")
                .WithInfo(69, 2, Artist.Nicholas_Gregory));
            Cards.Add(Card.Enemy("Temple Guardian", "", setName, 50, 255, 6, 4, 10)
                .WithUnique()
                .WithTraits("Undead.")
                .WithText("X is the number of players in the game.\r\nImmune to player card effects. Cannot be optionally engaged.\r\nTemple ~Guardian gets -50 engagement cost while Cursed Temple is the active location.")
                .WithVictoryPoints(4)
                .WithInfo(70, 1, Artist.Chris_Grun));
            Cards.Add(Card.Objective("Gate Key", "", setName)
                .WithUnique()
                .WithTraits("Item.", "Artifact.")
                .WithText("If unattached, return ~Gate ~Key to the staging area and it gains: \"Action: Exhaust a hero to claim ~Gate ~Key and attach it to that hero.\"\r\nAction: Exhaust ~Gate ~Key and attached hero and spend 3 resources from attached hero's resource pool to look at the facedown side of a Temple of the Deceived.")
                .WithInfo(71, 1, Artist.Katy_Grierson));
            Cards.Add(Card.Location("Jagged Cliffs", "", setName, 4, 4)
                .WithTraits("Mountain.")
                .WithSecondImage("Lost-Island")
                .WithKeywords("Uncharted.")
                .WithOppositeText("Uncharted.\r\nCannot have player card attachments.\r\nForced: After Lost Island becomes the active location, flip it over.\r\nAction: Remove 4 progress from Lost Island to look at its facedown side.")
                .WithText("While Jagged Cliffs is the active location, the location to its right is not considered to be in the staging area.\r\nForced: When Jagged Cliffs is flipped over while active, look at the facedown side of each adjacent copy of Lost Island.")
                .WithInfo(72, 2, Artist.Katy_Grierson));
            Cards.Add(Card.Location("Winding Caverns", "", setName, 2, 6)
                .WithTraits("Underground.")
                .WithSecondImage("Lost-Island")
                .WithKeywords("Uncharted.")
                .WithOppositeText("Uncharted.\r\nCannot have player card attachments.\r\nForced: After Lost Island becomes the active location, flip it over.\r\nAction: Remove 4 progress from Lost Island to look at its facedown side.")
                .WithText("While Winding Caverns is the active location, each enemy gets +10 engagement cost.\r\nWhen you travel from Winding Caverns to another location, you may travel to a location up to 3 locations away. (You must still pay that location's Travel cost in order to travel there.)")
                .WithInfo(73, 2, Artist.Katy_Grierson));
            Cards.Add(Card.Location("Jungle Path", "", setName, 4, 4)
                .WithTraits("Underground.")
                .WithSecondImage("Lost-Island")
                .WithKeywords("Uncharted.")
                .WithOppositeText("Uncharted.\r\nCannot have player card attachments.\r\nForced: After Lost Island becomes the active location, flip it over.\r\nAction: Remove 4 progress from Lost Island to look at its facedown side.")
                .WithText("While Jungle Path is the active location, the locations immediately above and below it are not considered to be in the staging area.\r\nForced: When Jungle Path is flipped over while active, each player must exhaust a character with at least 2 Attack.")
                .WithInfo(74, 2, Artist.Katy_Grierson));
            Cards.Add(Card.Enemy("Faithless Desecrator", "", setName, 25, 2, 2, 2, 4)
                .WithGeneric()
                .WithTraits("Undead.")
                .WithText("While engaged with a player, Faithless Desecrator contributes its Threat to the total Threat in the staging area.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the active location is a Ruins location).")
                .WithInfo(75, 3, Artist.Chris_Grun));
            Cards.Add(Card.Enemy("Island Watcher", "", setName, 46, 3, 4, 1, 5)
                .WithGeneric()
                .WithTraits("Undead.")
                .WithText("Island Watcher cannot be optionally engaged.\r\nWhile Island Watcher is in the staging area, it gains: \"Forced: At the beginning of the encounter phase, if the active location has the Ruins trait, Island Watcher engages the player with the highest treat. Then, deal it 2 shadow cards.\"")
                .WithEasyModeQuantity(0)
                .WithInfo(76, 2, Artist.Chris_Grun));
            Cards.Add(Card.Enemy("Profane Dead", "", setName, 35, 1, 2, 3, 3)
                .WithGeneric()
                .WithTraits("Undead.")
                .WithText("Forced: When you travel to the riight, Profane Dead makes an immediate attack against the engaged player.")
                .WithShadow("Shadow: Attacking enemy gets +3 Attack if the players control the Gate Key.")
                .WithInfo(77, 2, Artist.Guillaume_Ducos));
            Cards.Add(Card.Treachery("Deeper into the Ruins", "", setName)
                .WithText("When Revealed: Until the end of the phase, add X Threat to the total Threat in the staging area. X is the total Threat of all locations to the left of the active location (in its row). If X is 0, Deeper into the Ruins gains Doomed 1.")
                .WithInfo(78, 4, Artist.Leanna_Teneycke));
            Cards.Add(Card.Treachery("Furious Rainstorm", "", setName)
                .WithText("When Revealed: Each player must choose: raise his threat by the number of his characters commited to the quest, or deal 1 damage to each of his characters committed to the quest.")
                .WithShadow("Shadow: If this attack destroys a character, raise your threat by the attacking enemy's Threat.")
                .WithEasyModeQuantity(2)
                .WithInfo(79, 3, Artist.Dallas_Williams));
            Cards.Add(Card.Treachery("Dwindling Supplies", "", setName)
                .WithText("When Revealed: Each player must randomly discard cards from his hand until he has no more than 3 cards in his hand. If no cards were discarded by this effect, Dwindling Supplies gains doomed 2.")
                .WithShadow("Shadow: Defending characters gets -2 Defense for this attack.")
                .WithInfo(80, 3, Artist.Mariusz_Gandzel));
            Cards.Add(Card.Treachery("Sunken Ruins", "", setName)
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Each Uncharted location in the staging area gets +1 Threat until the end of the phase. If the active location has the Ruins trait, discard 1 resource from each hero and objective-ally in play.")
                .WithInfo(81, 3, Artist.DinoDrawing));
        }
    }
}