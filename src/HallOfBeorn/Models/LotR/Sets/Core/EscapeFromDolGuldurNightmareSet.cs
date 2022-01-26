using System;

namespace HallOfBeorn.Models.LotR.Sets.Core
{
    public class EscapeFromDolGuldurNightmareSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Escape from Dol Guldur Nightmare";
            Abbreviation = "EFDGN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2002;

            addNightmareSetup(EncounterSet.EscapeFromDolGuldurNightmare.Name)
                .WithTextLine("You are playing Nightmare mode.")
                .WithTextLine("Forced: When stage 1B is revealed, the number of random heroes captured is determined by the number of players, as follows: 1-2 players = 1 hero captured, 3 players = 2 heroes captured, 4 players = 3 heroes captured. All captured heroes are turned face down and considered \"the prisoner,\" cannot be used, cannot be damaged, and do not collect resources until they are rescued, (A single player cannot have more than 1 hero captured by this effect.)")
                .WithOppositeTextLine("Begin with the standard quest deck and encounter deck for the Escape from Dol Guldur scenario found in the LOTR LCG core set.")
                .WithOppositeTextLine("Remove the following cards, in the specified quantities, from the standard encounter deck:")
                .WithOppositeTextLine("2x Dol Guldur Orcs")
                .WithOppositeTextLine("2x Enchanted ~Stream")
                .WithOppositeTextLine("1x Great ~Forest Web")
                .WithOppositeTextLine("3x Mountains of ~Mirkwood")
                .WithOppositeTextLine("2x Caught in a Web")
                .WithOppositeTextLine("1x The Necromancer's Reach")
                .WithOppositeTextLine("1x Necromancer's Pass")
                .WithOppositeTextLine("2x Under the ~Shadow")
                .WithOppositeTextLine("2x Tower ~Gate")
                .WithOppositeTextLine("1x Iron Shackles")
                .WithOppositeTextLine("Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Escape from Dol Guldur encounter deck.")
                .WithOppositeTextLine("Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Jim_Pavelec);
            addEnemy("Torture Master", EncounterSet.EscapeFromDolGuldurNightmare.Name, 45, 5, 1, 2, 4)
                .WithTraits("Dol Guldur.", "Orc.")
                .WithTextLine("When Revealed: Add 1 resource token to each Dol Guldur location in play.")
                .WithShadow("Shadow: Any hero damaged but not defeated by this attack is turned face down, as a \"prisoner.\" Then, if the players are on stage 3, return to stage 2B of the quest.")
                .WithInfo(2, 3, Artist.Rafal_Hrynkiewicz);
            addEnemy("Crazed Captive", EncounterSet.EscapeFromDolGuldurNightmare.Name, 13, 2, 1, 3, 1)
                .WithTraits("Captive.")
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("Forced: If Crazed Captive is defeated, raise each players threat by 7.")
                .WithShadow("Shadow: If attacking enemy is not defeated this phase, raise defending player's threat by 7 at the end of the phase.")
                .WithInfo(3, 2, Artist.Magali_Villeneuve);
            addEnemy("Spider of Dol Guldur", EncounterSet.EscapeFromDolGuldurNightmare.Name, 28, 3, 3, 3, 6)
                .WithTraits("Creature.", "Spider.", "Dol Guldur.")
                .WithTextLine("If there are any unclaimed objectives in play, Spider of ~Dol Guldur gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +3 Attack for each unclaimed objective in play.")
                .WithInfo(4, 3, Artist.Andrew_Ryan);
            addLocation("Torture Chamber", EncounterSet.EscapeFromDolGuldurNightmare.Name, 3, 6)
                .WithTraits("Dol Guldur.")
                .WithTextLine("If Torture Chamber has 4 or more resource tokens on it, all \"prisoners\" were killed, and the players have lost the game.\r\n\r\nForced: At the end of each round, place 1 resource token on each Dol Guldur location in play.")
                .WithInfo(5, 2, Artist.Ben_Zweifel);
            addLocation("Dungeon Labyrinth", EncounterSet.EscapeFromDolGuldurNightmare.Name, 1, 4)
                .WithTraits("Dol Guldur.")
                .WithTextLine("Dungeon Labyrinth gets +1 Threat and +1 quest point for each resource token on it.")
                .WithTextLine("Forced: At the end of each round, place 1 resource token on Dungeon Labyrinth for each player in the game.")
                .WithFlavorLine("\"Some here will remember that many years ago I myself dared to pass the doors of the Necromancer in Dol Guldur...\" -Gandalf, The Fellowship of the Ring")
                .WithInfo(6, 3, Artist.S_C_Watson);
            addTreachery("Sentinel of Shadow", EncounterSet.EscapeFromDolGuldurNightmare.Name)
                .WithTextLine("When Revealed: The staging area gets +X Threat until the end of the phase, where X is twice the number of players in the game. If the players quest unsuccessfully this phase, put the ~Nazgûl of ~Dol Guldur into play (from any out of play area), engaged with the first player. (Cannot be canceled.)")
                .WithInfo(7, 2, Artist.Rafal_Hrynkiewicz);
            addTreachery("Catacomb Inspection", EncounterSet.EscapeFromDolGuldurNightmare.Name)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Add 1 resource token to each Dol Guldur location in play.")
                .WithShadow("Shadow: If there is a Dol Guldur location in the staging area, move 1 resource token from each of your heroes' resource pools to that location. (Resolve this effect for each Dol Guldur location.)")
                .WithInfo(8, 2, Artist.Rafal_Hrynkiewicz);
            addTreachery("Dark Interrogation", EncounterSet.EscapeFromDolGuldurNightmare.Name)
                .WithTextLine("When Revealed: Each player must choose and discard cards from hand until he has only 2 cards in hand. (Each player with 2 or fewer cards in hand must instead reveal 1 card from the encounter deck.)")
                .WithShadow("Shadow: Discard each card you control that has at least 1 copy of itself in your discard pile. (If this attack is undefended, each player must resolve this effect.)")
                .WithInfo(9, 2, Artist.Magali_Villeneuve);
        }
    }
}