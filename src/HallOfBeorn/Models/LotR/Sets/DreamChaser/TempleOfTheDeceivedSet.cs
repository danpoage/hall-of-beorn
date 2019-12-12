/* Generated CardSet class: Temple of the Deceived */

using System;

namespace HallOfBeorn.Models.LotR.Sets.DreamChaser
{
    public class TempleOfTheDeceivedSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Temple of the Deceived";
            Abbreviation = "TotD";
            Number = 38;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dream-chaser";

            addHero("Elfhelm", 10, Sphere.Leadership, 2, 2, 2, 4)
                .WithTraits("Rohan.", "Scout.", "Warrior.")
                .WithTextLine("Each Spirit hero with an attached Mount gets +1 Willpower.")
                .WithTextLine("Each Tactics hero with an attached Mount gets +1 Attack.")
                .WithTextLine("Each Leadership hero with an attached Mount gets +1 Defense.")
                .WithFlavorLine("Ahead nearer the walls Elfhelm's men were among the siege-engines, hewing, slaying, driving their foes into the fire-pits.")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(57, 1, Artist.Sergey_Glushakov);
            addAlly("Ceorl", 2, Sphere.Leadership, true, 1, 2, 0, 2)
                .WithTraits("Rohan.", "Scout.")
                .WithTextLine("Action: Spend 1 Spirit resource to ready Ceorl. Then, you may give control of Ceorl to another player. Any player may trigger this action. (Limit once per phase).")
                .WithFlavorLine("He drew himself up. Then he knelt, offering his notched sword to the king. \"Command me, lord!\" he cried.")
                .WithFlavorLine("-The Two Towers")
                .WithInfo(58, 3, Artist.Aleksander_Karcz);
            addAttachment("Armored Destrier", 2, Sphere.Leadership, false)
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Leadership or sentinel hero. Restricted.")
                .WithTextLine("Response: After attached hero defends against an attack, exhaust Armored Destrier to ready attached hero. Then, discard a shadow card from another enemy engaged with the defending player.")
                .WithTemplate("<p class='main-text'>Attach to a {sphere:Leadership} or sentinel hero. {keyword:Restricted.}</p><p class='main-text'><b>Response:</b> After attached hero defends against an attack, exhaust {self} to ready attached hero. Then, discard a shadow card from another enemy engaged with the defending player.</p>")
                .WithInfo(59, 3, Artist.Sandara_Tang);
            addAlly("Déorwine", 4, Sphere.Tactics, true, 0, 1, 3, 3)
                .WithTraits("Rohan.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Response: While Déorwine is defending, spend 1 Leadership resource to cancel a shadow effect dealt to the attacking enemy. Any player may trigger this action.")
                .WithTemplate("<p class='main-text'>{keyword:Sentinel.}</p><p class='main-text'><b>Response:</b> While {self} is defending, spend 1 {sphere:Leadership} resource to cancel a shadow effect dealt to the attacking enemy. Any player may trigger this action.</p>")
                .WithInfo(60, 3, Artist.Aleksander_Karcz);
            addEvent("Revealed in Wrath", 1, Sphere.Tactics)
                .WithTextLine("Play only if you control a Noldor hero.")
                .WithTextLine("Action: Choose a non-unique enemy. Until the end of the phase, treat the chosen enemy's printed text box as if it were blank (except for Traits).")
                .WithFlavorLine("\"...seeing an Elf-lord revealed in his wrath, they were dismayed, and their horses were stricken with madness.\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithInfo(61, 3, Artist.Sebastian_Giacobino);
            addAlly("Rhovanion Outrider", 3, Sphere.Spirit, false, 1, 2, 1, 2)
                .WithTraits("Dale.", "Scout.")
                .WithTextLine("Response: After Rhovanion Outrider coomits to the quest, place 1 progress on a location in the staging area. If that location is not explored by this effect, give Rhovanion Outrider +1 Willpower until the end of the phase.")
                .WithInfo(62, 3, Artist.Beth_Sobel);
            addEvent("Scouting Party", 2, Sphere.Spirit)
                .WithTextLine("Response: After you commit characters to the quest, if each character you have commited to the quest is a Scout, each of these characters gets +2 Willpower until the end of the phase.")
                .WithInfo(63, 3, Artist.Guillaume_Ducos);
            addAttachment("Entangling Nets", 1, Sphere.Lore, false)
                .WithTraits("Trap.")
                .WithTextLine("Play Entagling Nets into the staging area, unattached.")
                .WithTextLine("If unattached, attach Entangling Nets to the next eligible enemy that enters the staging area.")
                .WithTextLine("Attached enemy gets -2 Attack and -2 Defense.")
                .WithInfo(64, 3, Artist.Sam_Lamont);
            addEvent("Arrows from the Trees", 1, Sphere.Lore)
                .WithTextLine("Play only after making engagement checks.")
                .WithTextLine("Encounter Action: If no enemies were engaged this phase, deal 1 damage to each enemy in the staging area. Then, the players as a group may spend 3 Tactics resources to deal 2 additional damage to each enemy in the staging area.")
                .WithInfo(65, 3, Artist.Tristan_Denecke);
            addAlly("Ered Luin Miner", 3, Sphere.Neutral, false, 1, 1, 1, 2)
                .WithTraits("Dwarf.")
                .WithTextLine("Response: After Ered Luin Miner is discarded from the top of your deck, put it into play under your control.")
                .WithFlavorLine("Tools were to be found in plenty that the miners and quarriers and builders of old had used; and at such work the dwarves were still very skilled.")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(66, 3, Artist.Lukasz_Jaskolski);
            addQuest("Searching the Island", EncounterSet.TempleOfTheDeceived, 1, 'A', null)
                .WithKeywords("Exploration.")
                .WithTextLine("Setup: Prepare the Island Map (see insert). Flip over the top-left and bottom-left locations of the Island Map (without resolving their Forced effects, if any), and choose one as the player's starting active location, using a resource token to represent which location is active. The first player takes control of Captain Sahír, and the last player takes control of Na'asiyah (objective-ally side faceup). Add Temple Guardian to the staging area and attach Gate Key to it, guarded. Shuffle the encounter deck.")
                .WithOppositeTextLine("Exploration.")
                .WithOppositeTextLine("For each progress that would be placed on Searching the Island, you may place it on a location in the staging area, instead.")
                .WithOppositeFlavorLine("Sahír has led you to an uncharted isle, and has agreed to help you find a chest he claims the black key will open. First, you must find the Gate Key that opens the way to the grand temple on the eastern side of the island.")
                .WithIncludedEncounterSets(EncounterSet.RuinsOfNumenor, EncounterSet.DrownedDead, EncounterSet.TheStormcallerElite)
                .WithInfo(67, 1, Artist.Sara_Winters);
            addLocation("The Grotto's Entrance", EncounterSet.TempleOfTheDeceived, 2, 8)
                .WithUnique()
                .WithOppositeTitle("Temple of the Deceived")
                .WithSlugSuffix("Temple of the Deceived")
                .WithTraits("Ruins.")
                .WithKeywords("Uncharted.")
                .WithTextLine("Forced: When The Grotto's Entrance is flipped over while active, put Temple ~Guardian into play from the victory display, engaged with the player with the highest threat.")
                .WithTextLine("When the 8th progress is placed on The Grotto's Entrance, the players have found the sunken ruins and win the game.")
                .WithOppositeTextLine("Uncharted. Immune to player card effects.")
                .WithOppositeTextLine("Travel: Exhaust the ~Gate ~Key to travel here.")
                .WithOppositeTextLine("Forced: After Temple of the Deceived becomes the active location, flip it over.")
                .WithInfo(68, 1, Artist.Sara_Winters);
            addLocation("Temple Halls", EncounterSet.TempleOfTheDeceived, 5, 5)
                .WithOppositeTitle("Temple of the Deceived")
                .WithSlugSuffix("Temple of the Deceived")
                .WithTraits("Ruins.")
                .WithKeywords("Uncharted.")
                .WithTextLine("While Temple Halls is the active location, each character gets -1 Attack and -1 Defense.")
                .WithTextLine("Forced: When Temple Halls is flipped over while active, put Temple ~Guardian into play from the victory display, engaged with the player with the highest threat.")
                .WithOppositeTextLine("Uncharted. Immune to player card effects.")
                .WithOppositeTextLine("Travel: Exhaust the ~Gate ~Key to travel here.")
                .WithOppositeTextLine("Forced: After Temple of the Deceived becomes the active location, flip it over.")
                .WithInfo(69, 2, Artist.Nicholas_Gregory);
            addEnemy("Temple Guardian", EncounterSet.TempleOfTheDeceived, 50, Card.VALUE_X, 6, 4, 10)
                .WithUnique()
                .WithTraits("Undead.")
                .WithTextLine("X is the number of players in the game.")
                .WithTextLine("Immune to player card effects. Cannot be optionally engaged.")
                .WithTextLine("Temple ~Guardian gets -50 engagement cost while Cursed Temple is the active location.")
                .WithVictoryPoints(4)
                .WithInfo(70, 1, Artist.Chris_Grun);
            addObjective("Gate Key", EncounterSet.TempleOfTheDeceived)
                .WithUnique()
                .WithTraits("Item.", "Artifact.")
                .WithTextLine("If unattached, return ~Gate ~Key to the staging area and it gains: \"Action: Exhaust a hero to claim ~Gate ~Key and attach it to that hero.\"")
                .WithTextLine("Action: Exhaust ~Gate ~Key and attached hero and spend 3 resources from attached hero's resource pool to look at the facedown side of a Temple of the Deceived.")
                .WithInfo(71, 1, Artist.Katy_Grierson);
            addLocation("Jagged Cliffs", EncounterSet.TempleOfTheDeceived, 4, 4)
                .WithOppositeTitle("Lost Island")
                .WithSlugSuffix("Lost Island")
                .WithTraits("Mountain.")
                .WithKeywords("Uncharted.")
                .WithTextLine("While Jagged Cliffs is the active location, the location to its right is not considered to be in the staging area.")
                .WithTextLine("Forced: When Jagged Cliffs is flipped over while active, look at the facedown side of each adjacent copy of Lost Island.")
                .WithOppositeTextLine("Uncharted.")
                .WithOppositeTextLine("Cannot have player card attachments.")
                .WithOppositeTextLine("Forced: After Lost Island becomes the active location, flip it over.")
                .WithOppositeTextLine("Action: Remove 4 progress from Lost Island to look at its facedown side.")
                .WithInfo(72, 2, Artist.Katy_Grierson);
            addLocation("Winding Caverns", EncounterSet.TempleOfTheDeceived, 2, 6)
                .WithOppositeTitle("Lost Island")
                .WithSlugSuffix("Lost Island")
                .WithTraits("Underground.")
                .WithKeywords("Uncharted.")
                .WithTextLine("While Winding Caverns is the active location, each enemy gets +10 engagement cost.")
                .WithTextLine("When you travel from Winding Caverns to another location, you may travel to a location up to 3 locations away. (You must still pay that location's Travel cost in order to travel there.)")
                .WithOppositeTextLine("Uncharted.")
                .WithOppositeTextLine("Cannot have player card attachments.")
                .WithOppositeTextLine("Forced: After Lost Island becomes the active location, flip it over.")
                .WithOppositeTextLine("Action: Remove 4 progress from Lost Island to look at its facedown side.")
                .WithInfo(73, 2, Artist.Katy_Grierson);
            addLocation("Jungle Path", EncounterSet.TempleOfTheDeceived, 4, 4)
                .WithOppositeTitle("Lost Island")
                .WithSlugSuffix("Lost Island")
                .WithTraits("Underground.")
                .WithKeywords("Uncharted.")
                .WithTextLine("While Jungle Path is the active location, the locations immediately above and below it are not considered to be in the staging area.")
                .WithTextLine("Forced: When Jungle Path is flipped over while active, each player must exhaust a character with at least 2 Attack.")
                .WithOppositeTextLine("Uncharted.")
                .WithOppositeTextLine("Cannot have player card attachments.")
                .WithOppositeTextLine("Forced: After Lost Island becomes the active location, flip it over.")
                .WithOppositeTextLine("Action: Remove 4 progress from Lost Island to look at its facedown side.")
                .WithInfo(74, 2, Artist.Katy_Grierson);
            addEnemy("Faithless Desecrator", EncounterSet.TempleOfTheDeceived, 25, 2, 2, 2, 4)
                .WithTraits("Undead.")
                .WithTextLine("While engaged with a player, Faithless Desecrator contributes its Threat to the total Threat in the staging area.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the active location is a Ruins location).")
                .WithInfo(75, 3, Artist.Chris_Grun);
            addEnemy("Island Watcher", EncounterSet.TempleOfTheDeceived, 46, 3, 4, 1, 5)
                .WithTraits("Undead.")
                .WithTextLine("Island Watcher cannot be optionally engaged.")
                .WithTextLine("While Island Watcher is in the staging area, it gains: \"Forced: At the beginning of the encounter phase, if the active location has the Ruins trait, Island Watcher engages the player with the highest treat. Then, deal it 2 shadow cards.\"")
                .WithEasyModeQuantity(0)
                .WithInfo(76, 2, Artist.Chris_Grun);
            addEnemy("Profane Dead", EncounterSet.TempleOfTheDeceived, 35, 1, 2, 3, 3)
                .WithTraits("Undead.")
                .WithTextLine("Forced: When you travel to the riight, Profane Dead makes an immediate attack against the engaged player.")
                .WithShadow("Shadow: Attacking enemy gets +3 Attack if the players control the Gate Key.")
                .WithInfo(77, 2, Artist.Guillaume_Ducos);
            addTreachery("Deeper into the Ruins", EncounterSet.TempleOfTheDeceived)
                .WithTextLine("When Revealed: Until the end of the phase, add X Threat to the total Threat in the staging area. X is the total Threat of all locations to the left of the active location (in its row). If X is 0, Deeper into the Ruins gains Doomed 1.")
                .WithInfo(78, 4, Artist.Leanna_Teneycke);
            addTreachery("Furious Rainstorm", EncounterSet.TempleOfTheDeceived)
                .WithTextLine("When Revealed: Each player must choose: raise his threat by the number of his characters commited to the quest, or deal 1 damage to each of his characters committed to the quest.")
                .WithShadow("Shadow: If this attack destroys a character, raise your threat by the attacking enemy's Threat.")
                .WithEasyModeQuantity(2)
                .WithInfo(79, 3, Artist.Dallas_Williams);
            addTreachery("Dwindling Supplies", EncounterSet.TempleOfTheDeceived)
                .WithTextLine("When Revealed: Each player must randomly discard cards from his hand until he has no more than 3 cards in his hand. If no cards were discarded by this effect, Dwindling Supplies gains doomed 2.")
                .WithShadow("Shadow: Defending characters gets -2 Defense for this attack.")
                .WithInfo(80, 3, Artist.Mariusz_Gandzel);
            addTreachery("Sunken Ruins", EncounterSet.TempleOfTheDeceived)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Each Uncharted location in the staging area gets +1 Threat until the end of the phase. If the active location has the Ruins trait, discard 1 resource from each hero and objective-ally in play.")
                .WithInfo(81, 3, Artist.Sergey_Glushakov);
        }
    }
}
