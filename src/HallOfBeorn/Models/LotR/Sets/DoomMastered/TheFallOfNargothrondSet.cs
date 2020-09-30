using System;

namespace HallOfBeorn.Models.LotR.Sets.DoomMastered
{
    public class TheBetrayalOfMim
        : CardSet
    {
        private const string setName = "The Fall of Nargothrond";
        private const string cycleName = "Doom Mastered";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TFoN";
            Number = 9005;
            SetType = Models.SetType.First_Age;
            Cycle = cycleName;

            addLocation("Deep River", EncounterSet.TheFallOfNargothrond, 1, Card.VALUE_NA)
                .WithTraits("Nargothrond.", "River.")
                .WithTextLine("Immune to player card effects. The players cannot travel to Deep River.")
                .WithTextLine("Forced: When any number of damage tokens would be placed on the quest stage, cancel that damage and remove Deep River from the game instead.")
                .WithFlavorLine("The doors of Nargothrond opened onto the gorge of the river...")
                .WithFlavorLine("-The Children of Húrin")
                .WithInfo(323, 1, Artist.Alan_Lee); //(6/24)
            addObjective("The Hopes of Nargothrond", EncounterSet.TheFallOfNargothrond)
                .WithUnique()
                .WithTraits("Nargothrond.")
                .WithTextLine("Action: Remove 10 progress from the main quest to reveal the top card of the innocent deck and place it beneath The Hopes of Nargothrond. Any player may trigger this effect.")
                .WithTextLine("If there are 6 or more Innocent objective under The Hopes of Nargothrond, the players win the game.")
                .WithInfo(324, 1, Artist.Unknown); //(7/24)

            addLocation("Besieged Defenses", EncounterSet.TheFallOfNargothrond, 4, 4)
                .WithTraits("Nargothrond.", "Battleground.")
                .WithTextLine("Response: After Besieged Defenses is explored as the active location, each character gets +2 Defense until the end of the round.")
                .WithFlavorLine("...and they were even then ransacking the great halls and chambers, plundering and destroying...")
                .WithFlavorLine("-The Children of Húrin")
                .WithInfo(328, 3, Artist.Unknown); //(11/26)
            addTreachery("Coiling Swiftly", EncounterSet.TheFallOfNargothrond)
                .WithTraits("Glaurung.")
                .WithTextLine("When Revealed: Glaurung gets +2 Defense until the end of the phase.")
                .WithFlavorLine("But Túrin drawing back his sword stabbed at his eyes, and Glaurung coiling back swiftly toward above him...")
                .WithFlavorLine("-The Children of Húrin")
                .WithInfo(337, 2, Artist.Unknown); //(20/24)

            addHero("Finarfin", 11, Sphere.Leadership, 3, 1, 4, 4)
                .WithTraits("Noldor.", "House of Finarfin.", "Noble.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("While Finarfin is defending, he gains: \"Response: Cancel a shadow effect just triggered. Then, cancel all damage dealt to the attacking enemy until the end of the round. (Limit once per round.)\"")
                .WithFlavorLine("But Finarfin spoke softly, as was his wont, and sought to calm the Noldor, persuading them to pause and ponder ere deeds were done that could not be undone...")
                .WithFlavorLine("-The Silmarillion")
                .WithInfo(343, 1, Artist.Elena_Kukanova);
            addAlly("Amon Ethir Sentry", 3, Sphere.Tactics, false, 0, 2, 2, 3)
                .WithTraits("Noldor.", "Warrior.")
                .WithTextLine("Response: After Amon Ethir Sentry enters play, choose an enemy in the staging area. Then, you may either engage that enemy or that enemy does not make engagement checks until the end of the round.")
                .WithInfo(347, 3, Artist.Unknown);
            addAlly("Andvir", 0, Sphere.Mastery, true, 1, 1, 1, 2)
                .WithTraits("Gaurwaith.")
                .WithKeywords("Ransom 3.")
                .WithTextLine("Ransom 3.")
                .WithTextLine("Response: After a treachery is revealed, exhaust Andvir to choose an ally. That ally readies and gets +1 Willpower until the end of the round.")
                .WithInfo(348, 3, Artist.Andreia_Ugrai);
            addAttachment("Gilded Mask", 2, Sphere.Mastery, true)
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("While the attached hero is committed to the quest, Gilded Mask gains, \"Response: When an enemy with lower Threat than the number of Corruption tokens on the attached hero is revealed from the encounter deck, exhaust Gilded Mask to discard that enemy (canceling all of its effects). Reveal the next card of the encounter deck instead.\"")
                .WithInfo(349, 3, Artist.Unknown); //Peet
            addAlly("Guard of the Drúedain", 2, Sphere.Lore, false, 1, 1, 2, 3)
                .WithTraits("Drúedain.")
                .WithTextLine("Response: After an enemy engages you, exhaust Guard of the Drúedain to lower that enemy's Attack by 1 until the end of the phase (lower its Attack by 2 instead if the attacking enemy is an Orc.) The targeted enemy cannot be targeted again by the ability of a Guard of the Drúedain this round.")
                .WithFlavorLine("...nothing passed or came near that was not marked and remembered.")
                .WithFlavorLine("-Unfinished Tales")
                .WithInfo(344, 3, Artist.Unknown);
            addAlly("Shieldmaiden of Haleth", 3, Sphere.Spirit, 2, 1, 2, 2)
                .WithTraits("Edain.", "House of Haleth.")
                .WithTextLine("Response: After Shieldmaiden of Haleth quests successfully, place 1 resource token on it.")
                .WithTextLine("Response: After a hero is damaged by an enemy attack, exhaust Shieldmaiden of Haleth and remove 3 progress tokens from it to cancel all damage from that attack.")
                .WithInfo(345, 3, Artist.Unknown);
            addAttachment("Hidden Way", 2, Sphere.Spirit, false)
                .WithTraits("Path.")
                .WithTextLine("Attach to a location.")
                .WithTextLine("Response: After attached location is explored, reduce the first player's threat by X, where X is the attached location's printed quest points (up to a limit of 5.)")
                .WithInfo(350, 3, Artist.John_Howe);
            addEvent("Kingly Judgement", 1, Sphere.Mastery)
                .WithTraits("Doom.")
                .WithTextLine("Action: Choose a character with at least 1 Corruption and choose one: deal 1 damage to that character to remove 1 Corruption from that character to play an attachment of X cost or lower on that character for free, where X is the number of Corruption tokens on that character.") 
                .WithInfo(354, 3, Artist.Steamey);
            addAlly("Noldor Oathkeeper", 4, Sphere.Mastery, false, 1, 1, 2, 3)
                .WithTextLine("If each hero you control has at least 1 Corruption, Noldor Oathkeeper does not exhaust to defend.")
                .WithTextLine("Response: When you play Noldor Oathkeeper from your hand, place 1 Corruption on a hero you control to reduce its cost by 1.")
                .WithInfo(346, 3, Artist.Unknown);
            addAttachment("Seal of the Queen", 2, Sphere.Leadership, true)
                .WithTraits("Item.", "Boom.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Attached hero gets +1 Willpower.")
                .WithTextLine("Action: Exhaust Seal of the Queen and name a number to search the top 3 cards of your deck. You may choose one of those cards with cost equal to the named number and add it to your hand. Shuffle the rest back into your deck.")
                .WithInfo(351, 3, Artist.Elena_Kukanova);
            addAttachment("Silmaril of the Sky", 2, Sphere.Neutral, true)
                .WithTraits("Item.", "Artifact.")
                .WithTextLine("Attach to a hero with at least 1 Corruption. Limit 1 per deck.")
                .WithTextLine("Action: Exhaust Silmaril of the Sky and deal 1 Corruption to a character you control to (choose 1): discard a shadow card from a non-unique enemy, choose an enemy to get -2 Attack until the end of the phase, or ready attached hero.")
                .WithInfo(355, 3, Artist.Steamey);
            addEvent("Unnumbered Tears", 2, Sphere.Tactics)
                .WithTextLine("Response: After a character is destroyed, ready each character you control that shares a trait with that character.")
                .WithFlavorLine("Then in the plain of...")
                .WithFlavorLine("-The Simlarillion")
                .WithInfo(352, 3, Artist.Unknown);
            addEvent("Friend of Birds and Beasts", 1, Sphere.Lore)
                .WithTextLine("Action: Place the top 3 cards of the encounter deck facedown under this card. Each facedown card acts as an ally with 1 Willpower, 1 Attack, 1 Defense, 1 hit point, and the Creature trait. Discard this card and call facedown cards underneath it at the end of the round.")
                .WithInfo(353, 3, Artist.Unknown);
            addAttachment("Favor of Indis", 0, Sphere.Leadership, false)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a House of Fingolfin or House of Finarfin hero. Limit 1 per hero.")
                .WithTextLine("Attached hero gains +1 Defense for each resource on Favor of Indis.")
                .WithTextLine("Response: At the end of the combat phase, add 1 resource to Favor of Indis if you are engaged with an enemy and did not destroy an enemy this phase. (Limit 3 resources on Favor of Indis.)")
                .WithTextLine("Forced: After you destroy an enemy, remove 1 resource from Favor of Indis.")
                .WithInfo(359, 3, Artist.Unknown); //Cale
        }
    }
}
