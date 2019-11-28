using System;

namespace HallOfBeorn.Models.LotR.Sets.DreamChaser
{
    public class TheDrownedRuinsNightmareSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Drowned Ruins Nightmare";
            Abbreviation = "TDRN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2087;

            addNightmareSetup(EncounterSet.TheDrownedRuinsNightmare)
                .WithTextLine("You are playing Nightmare mode.")
                .WithTextLine("While the active location is Underwater, encounter card effects cannot be canceled.")
                .WithTextLine("Forced: When the 'when revealed' effect on state 2A resolves, Captain Sahír makes an immediate attack against each player in turn order, instead of only the first player.")
                .WithOppositeTextLine("Begin with the standard quest deck and encounter deck for The Drowned Ruins scenario.")
                .WithOppositeTextLine("Remove the following card, in the specified quantities, from the standard encounter deck:")
                .WithOppositeTextLine("1x Cursed Caverns / Twisting Hollow")
                .WithOppositeTextLine("1x Undersea Grotto / Dark Abyss")
                .WithOppositeTextLine("2x Throngs of Unfaithful")
                .WithOppositeTextLine("2x Soulless Cadaver")
                .WithOppositeTextLine("2x Drowned Cave")
                .WithOppositeTextLine("3x Into the Abyss")
                .WithOppositeTextLine("1x Tangling and Grasping")
                .WithOppositeTextLine("2x Sea-scorpion")
                .WithOppositeTextLine("2x Cave Eel")
                .WithOppositeTextLine("Then, shuffle the encounter card in this Nightmare Deck into the remainder of the standard The Drowned Ruins encounter deck.")
                .WithOppositeTextLine("Finally, flip this setup card over and placr it next to the quest deck. Its effect remains active throughout the game, which is now ready to being.")
                .WithInfo(1, 1, Artist.Nicholas_Gregory);
            addLocation("Overgrown Passage", EncounterSet.TheDrownedRuinsNightmare, 5, 5)
                .WithTraits("Underground.", "Grotto.")
                .WithTextLine("While Overgrown Passage is the active location, heroes cannot gain resources.")
                .WithTextLine("Response: After you travel to Overgrown Passage, you may flip it to its Underwater side.")
                .WithInfo(2, 2, Artist.Jordan_Saia);
            addLocation("Sharp Precipice", EncounterSet.TheDrownedRuinsNightmare, 2, 3)
                .WithTraits("Underground.", "Grotto.")
                .WithTextLine("Forced: When faced with the option to travel, if you do not choose to travel to a location name Sharp Precipice, you must raise each player's threat by 3.")
                .WithTextLine("Forced: After you travel to Sharp Precipice, flip it to its Underwater side.")
                .WithInfo(3, 2, Artist.Federico_Musetti);
            addLocation("Jagged Cavern", EncounterSet.TheDrownedRuinsNightmare, 6, 8)
                .WithTraits("Underground.", "Underwater.")
                .WithTextLine("While Jagged Cavern is the active location, the first treachery card revealed each round gains doomed 1 and surge.")
                .WithTextLine("Forced: If Jagged Cavern is the active location at the end of the quest phase, each player must discard each card in his or her hand. Then, you may flip Jagged Cavern to it Grotto side.")
                .WithVictoryPoints(2)
                .WithInfo(4, 2, Artist.Federico_Musetti);
            addLocation("Submerged Crawlway", EncounterSet.TheDrownedRuinsNightmare, 2, 16)
                .WithTraits("Underground.", "Underwater.")
                .WithTextLine("While Submerged Crawlway is the active location, deal each engaged enemy 1 additional shadow card at the beginning of the combat phase.")
                .WithTextLine("Forced: If Submerged Crawlway is the active location at the end of the quest phase, each player must search the encounter deck and discard pile for an enemy and add it to the staging area. Then, you may flip Submerged Crawlway to its Grotto side.")
                .WithVictoryPoints(2)
                .WithInfo(5, 2, Artist.Federico_Musetti);
            addEnemy("Submerged Dead", EncounterSet.TheDrownedRuinsNightmare, 26, 2, 3, 2, 3)
                .WithTraits("Undead.")
                .WithTextLine("When Revealed: If the active location is Underwater, return each other Submerged Dead in the encounter discard pule to the staging area.")
                .WithShadow("Shadow: If the active location is Underwater, put Submerged Dead into play in the staging area.")
                .WithInfo(6, 4, Artist.Monztre);
            addEnemy("Great Shark", EncounterSet.TheDrownedRuinsNightmare, 34, 4, 4, 4, 6)
                .WithTraits("Creature.")
                .WithTextLine("Great Shark gets +1 Threat, +1 Attack, and +1 Defense for each Underwater location in the victory display.")
                .WithTextLine("Great Shark cannot be engaged or damaged unless the active location is Underwater.")
                .WithTextLine("Forced: At the beginning of the encounter phase, return Great Shark to the staging area unless the active location is Underwater.")
                .WithInfo(7, 2, Artist.Nicholas_Gregory);
            addEnemy("Undersea Cave Troll", EncounterSet.TheDrownedRuinsNightmare, 36, 3, 7, 1, 10)
                .WithTraits("Troll.")
                .WithTextLine("")
                .WithVictoryPoints(1)
                .WithInfo(8, 1, Artist.Guillaume_Ducos);
            addLocation("Flooded Caverns", EncounterSet.TheDrownedRuinsNightmare, 2, 6)
                .WithTraits("Underground.", "Underwater.")
                .WithTextLine("If Flooded Caverns is in the staging area and the active location is Underwater, add that location's Threat to the Threat of Flooded Caverns.")
                .WithTextLine("Forced: If Flooed Caverns is the active location at the end of the quest phase, return an Underwater location from the victory display to the bottom of the ~Grotto deck, Grotto side faceup. Then, return Flooded Caverns to the staging area.")
                .WithInfo(9, 2, Artist.Jordan_Saia);
            addTreachery("Pit Into the Depths", EncounterSet.TheDrownedRuinsNightmare)
                .WithTraits("Hazard.")
                .WithTextLine("When Revealed: Until the end of the quest phase, each ally gets -1 Willpower. If the active location has the Grotto trait, remove all progress from it and flip it to its Underwater side.")
                .WithShadow("Shadow: If the active location is Underwater, treat this attack as if it were undefended.")
                .WithInfo(10, 3, Artist.Carlos_Palma_Cruchaga);
            addTreachery("Sulfur Cloud", EncounterSet.TheDrownedRuinsNightmare)
                .WithTraits("Hazard.")
                .WithTextLine("When Revealed: If the active location is Underwater, choose a number and raise each player's threat by that number. No more than X progress can be placed on Underwater locations this phase, where X is twice the chosen number. If the active location is not Underwater, Sulfur Cloud gains surge.")
                .WithInfo(11, 2, Artist.Logan_Feliciano);
        }
    }
}