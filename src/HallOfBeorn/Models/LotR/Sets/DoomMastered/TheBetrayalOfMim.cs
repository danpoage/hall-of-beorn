using System;

namespace HallOfBeorn.Models.LotR.Sets.DoomMastered
{
    public class TheBetrayalOfMim
        : CardSet
    {
        private const string setName = "The Betrayal of Mîm";
        private const string cycleName = "Doom Mastered";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TBoM";
            Number = 9004;
            SetType = Models.SetType.First_Age;
            Cycle = cycleName;

            addEnemy("Angband Spy", EncounterSet.TheBetrayalOfMim, 35, 3, 3, 3, 4)
                .WithTraits("Orc.")
                .WithTextLine("Forced: After an ally is played from hand, either add 1 encounter card to the staging area of a random non-unique location or raise each player's threat by 1.")
                .WithFlavorLine("...and ere long Amon Rûdh was surrounded by spies, lurking unobserved in the wilderness...")
                .WithFlavorLine("-The Children of Húrin")
                .WithInfo(175, 0, Artist.Unknown); //Omer88 (4/23)
            addEnemy("Wolf-sentinel", EncounterSet.TheBetrayalOfMim, 30, Card.VALUE_X, 5, 1, 6)
                .WithTraits("Creature.", "Wold.")
                .WithTextLine("X is equal to the number of characters committed to the quest by the first player.")
                .WithFlavorLine("...the Orcs made their encampment in a bare dale, and set wolf-sentinels all about its rim.")
                .WithFlavorLine("-The Children of Húrin")
                .WithInfo(176, 0, Artist.Unknown); //Fleurdelyse (5/23)
            addEnemy("Angband Warrior", EncounterSet.TheBetrayalOfMim, 28, 2, 4, 3, 5)
                .WithTraits("Orc.")
                .WithTextLine("Forced: After Angband Warrior destroys a character, either add 1 encounter card to the staging area of a random non-unique location or reveal an encounter card.")
                .WithShadow("Shadow: The attacking enemy gets +1 Attack (+2 Attack instead if the quest stage is 2B).")
                .WithInfo(177, 0, Artist.Unknown); //Kikie Ianjur (6/23)
            addLocation("Amon Rûdh", EncounterSet.TheBetrayalOfMim, 5, Card.VALUE_NA)
                .WithUnique()
                .WithSlugSuffix("Discovered")
                .WithTraits("Discovered.", "Dor-Cúarthol.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Forced: At the beginning of the encounter phase, discard the top X cards of the encounter deck. Each player adds an enemy discarded from this effect to the staging area. X is 2 more than the number of players in the game.")
                .WithFlavorLine("...but that steep as were its sides men could reach the summit by climbing a stair cut into the rock...")
                .WithFlavorLine("-The Children of Húrin") //(7/23)
                .WithInfo(178, 1, Artist.Anke_Eissmann);
            addLocation("Amon Rûdh", EncounterSet.TheBetrayalOfMim, 2, Card.VALUE_NA)
                .WithUnique()
                .WithSlugSuffix("Hidden")
                .WithTraits("Hidden.", "Dor-Cúarthol.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("While Amon Rûdh is the active location, it gains: \"After a character readies during the refresh phase, heal 1 damage from the character.\"")
                .WithFlavorLine("\"We have seen it, but never nearer...\"")
                .WithFlavorLine("-Androg, The Children of Húrin")
                .WithInfo(178, 1, Artist.Unknown); //(7/23)

            addObjective("Bound", EncounterSet.TheBetrayalOfMim)
                .WithTraits("Grievance.")
                .WithTextLine("While Bound is attached to Mîm, it gains, \"Ignore the forced effect on the attached character. The attached character cannot ready.\"")
                .WithTextLine("Action: Attach Bound to Mîm and exhaust him, if able. Any player may trigger this action.")
                .WithFlavorLine("Then Mîm opened his eyes and pointed to his bonds; and when he was released he spoke fiercely. 'Learn this, fools!' he said. 'Do not put bonds on a Dwarf! He will not forgive it.'")
                .WithFlavorLine("-The Children of Húrin")
                .WithInfo(193, 1, Artist.Anke_Eissmann); //(22/23)

            addTreachery("Unfading Grief", EncounterSet.TheBetrayalOfMim)
                .WithTraits("Doom.")
                .WithTextLine("When Revealed: Attach to the hero with Curse of Morgoth attached. (Counts as a Condition attachment with the text: \"The cost of the first card you play each round is increased by one.\")")
                .WithFlavorLine("...and that grief was graven on the face of Túrin and never faded.")
                .WithFlavorLine("-The Children of Húrin")
                .WithInfo(195, 1, Artist.Steamey);

            addQuest("The Wrath of Angband", EncounterSet.TheBetrayalOfMim, 2, 'A', Card.VALUE_NA)
                .WithFlavorLine("By fate or treachery, the Orcs of Morgoth have discovered the location of Bar-en-Danwedh, the House of Random. Now you must fight for your very life against the tide of foes suddenly at your door.")
                .WithTextLine("When Revealed: Flip Amon Rûdh and make it the active location. If Mîm's objective side is faceup, flip him.")
                .WithOppositeTextLine("Skip the staging step of the quest phase. Encounter cards cannot be added to the staging area of non-unique locations. Players cannot travel.")
                .WithOppositeTextLine("Forced: At the beginning of the quest phase, move all cards in a location's staging are one location to the left, if able.")
                .WithOppositeTextLine("If there are no encounter cards in a staging area and non enemies engaged with a player, the players have won the game.")
                .WithInfo(199, 1, Artist.Unknown);

            addAlly("Ulfang the Black", 2, Sphere.Mastery, true, 1, 3, 3, 3)
                .WithTraits("Easterling.")
                .WithTextLine("Forced: At the end of the round, discard the top card of your deck. Then, if the top card of your discard pile is an ally, deal 1 Corruption to Ulfang the Black.")
                .WithFlavorLine("In this hour the plots of Ulfang were revealed.")
                .WithFlavorLine("-The Silmarillion")
                .WithInfo(207, 3, Artist.Unknown); //Frank Frazetta

            addEvent("Trained to Wariness", 0, Sphere.Lore)
                .WithTextLine("Quest Action: Exhaust a character with the Ranger trait. Then, until the end of the phase, after the first enemy is revealed from the encounter deck, lower your threat by X, where X is the Threat of the revealed enemy.")
                .WithFlavorLine("But Túrin, trained in the wild to wariness, saw him from the corner of his eye...")
                .WithFlavorLine("-The Children of Húrin")
                .WithInfo(211, 3, Artist.Unknown); //AlMaNeGrA

            addEvent("Arts of the Enemy", 1, Sphere.Mastery)
                .WithTextLine("Response: Deal 1 Corruption to a hero to cancel a shadow effect just triggered during combat. Move that shadow card to a character. When that character attacks, apply the shadow effect, applying any text that refers to \"attacking enemy\" to the attacking character and any text that refers to the \"defending character\" to the defending enemy, if able.")
                .WithInfo(213, 3, Artist.Unknown); //Ethalen Skye
                
        }
    }
}