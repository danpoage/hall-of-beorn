/* Generated CardSet class: The Antlered Crown */

using System;

namespace HallOfBeorn.Models.LotR.Sets.TheRingMaker
{
    public class TheAntleredCrownSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Antlered Crown";
            Abbreviation = "TAC";
            Number = 28;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "The Ring-maker";

            addHero("Erkenbrand", 10, Sphere.Leadership, 1, 2, 3, 4)
                .WithTraits("Rohan.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("While Erkenbrand is defending, he gains: \"Response: Deal 1 damage to Erkenbrand to cancel a shadow effect just triggered.\"")
                .WithFlavorLine("Down from the hills leaped Erkenbrand, lord of Westfold. -The Two Towers")
                .WithInfo(137, 1, Artist.Sebastian_Giacobino);
            addAlly("Warden of Helm's Deep", 3, Sphere.Leadership, false, 0, 1, 3, 2)
                .WithTraits("Rohan.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithFlavorLine("They now learned to their joy that Erkenbrand had left many men to hold Helm's Gate, and more had since escaped thither. -The Two Towers")
                .WithInfo(138, 3, Artist.Jarreau_Wimberly);
            addAttachment("The Day's Rising", 1, Sphere.Leadership, true)
                .WithTraits("Song.")
                .WithTextLine("Attach to a hero with sentinel.")
                .WithTextLine("Response: After attached hero defends against an attack and takes no damage while defending that attack, exhaust Day's Rising to add 1 resource to the attached hero's resource pool.")
                .WithFlavorLine("Out of doubt, out of dark to the day's rising")
                .WithFlavorLine("I came singing in the sun, sword unsheathing.")
                .WithFlavorLine("-Éomer, The Return of the King")
                .WithInfo(139, 3, Artist.Jarreau_Wimberly);
            addAttachment("Captain of Gondor", 1, Sphere.Tactics, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a Warrior hero.")
                .WithTextLine("Response: After you optionally engage an enemy, exhaust ~Captain of ~Gondor to give attached hero +1 Attack and +1 Defense until the end of the round.")
                .WithFlavorLine("\"Boromir it was that drove the enemy at last back from this western shore...\" -Beregond, The Return of the King")
                .WithInfo(140, 3, Artist.Jarreau_Wimberly);
            addAlly("Booming Ent", 2, Sphere.Tactics, false, 0, 2, 2, 3)
                .WithTraits("Ent.")
                .WithTextLine("Cannot have restricted attachments. Enters play exhausted.")
                .WithTextLine("Booming ~Ent gets +1 Attack for each damaged Ent character you control.")
                .WithFlavorLine("\"...a man that hacks once at an Ent never gets a chance of a second blow.\" -Merry, The Two Towers")
                .WithInfo(141, 3, Artist.Jarreau_Wimberly);
            addEvent("Ride Them Down", 2, Sphere.Spirit)
                .WithTextLine("Quest Action: Choose a non-unique enemy in the staging area. Until the end of the phase, progress that would be placed on the quest from questing successfully is instead assigned as damage to the chosen enemy. (Progress must still be placed on any active location first.)")
                .WithFlavorLine("Like thunder they broke upon the enemy... -The Return of the King")
                .WithInfo(142, 3, Artist.Emile_Denis);
            addEvent("Shadows Give Way", 3, Sphere.Spirit)
                .WithTextLine("You must use resources from 3 different heroes' pools to pay for this card.")
                .WithTextLine("Action: Discard each shadow card from each enemy in play.")
                .WithFlavorLine("At that moment he caught a flash of white and silver coming from the North, like a small star down on the dusky fields. -The Return of the King")
                .WithInfo(143, 3, Artist.Jordy_Lakiere);
            addEvent("Don't Be Hasty!", 0, Sphere.Lore)
                .WithTextLine("Response: When an encounter card is revealed but before resolving any of that card's keywords or \"when revealed\" effects, choose a character comited to the quest. Ready that character and remove it from the quest.")
                .WithFlavorLine("\"Don't be hasty, that is my motto.\" -Treebeard, The Two Towers")
                .WithInfo(144, 3, Artist.Mike_Nash);
            addEvent("Waters of Nimrodel", 3, Sphere.Lore)
                .WithKeywords("Doomed 3.")
                .WithTextLine("Doomed 3.")
                .WithTextLine("Action: Heal all damage on each character in play.")
                .WithFlavorLine("For a moment Frodo stood near the brink and let the water flow over his tired feet. It was cold but its touch was clean, and as he went on and it mounted to his knees, he felt that the strain of travel and all weariness was washed from his limbs. -The Fellowship of the Ring")
                .WithInfo(145, 3, Artist.Jose_Vega);
            addAlly("Treebeard", 4, Sphere.Neutral, true, 2, 4, 3, 5)
                .WithTraits("Ent.")
                .WithTextLine("Cannot have restricted attachments. Treebeard enters play exhausted and collects 1 resource each resource phase. These resources can be used to pay for Ent cards played from your hand.")
                .WithTextLine("Action: Pay 2 resources from Treebeard's pool to ready an Ent character.")
                .WithInfo(146, 3, Artist.Mike_Nash);
            addQuest("Battle for Dunland", EncounterSet.TheAntleredCrown, 1, 'A', 10)
                .WithKeywords("Time 3.")
                .WithTextLine("Setup: The first player takes control of Chief Turch. Set ~Raven Chief and ~Raven Chief's Camp aside, out of play. Reveal 1 copy of ~Dunland Battlefield and make it the active location. Reveal 1 copy of ~Raven War-camp and add it to the staging area. Create the ~Raven deck (see insert) and set it next to the quest deck. Each player chooses 1 different enemy from the ~Raven deck and adds it to the staging area. Shuffle the encounter deck and ~Raven deck.")
                .WithOppositeTextLine("Time 3.")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, remove 1 time counter from each location in play. Place 3 time counters on this stage.")
                .WithOppositeFlavorLine("On your return journey to Isengard, you find war in Dunland. The Raven Clan has refused the Boar's claim to The Antlered Crown, and chief Turch asks you to join his Clan as they march to battle. Seeing an opportunity to earn Saruman the friendship of a unified Dunland, you agree to join forces and fight...")
                .WithIncludedEncounterSets(EncounterSet.DunlandRaiders, EncounterSet.DunlandWarriors)
                .WithInfo(147, 1, Artist.Darek_Zabrocki);
            addQuest("The Raven Clan", EncounterSet.TheAntleredCrown, 2, 'A', 15)
                .WithKeywords("Time 3.")
                .WithTextLine("When Revealed: Shuffle the ~Raven deck discard pile into the ~Raven deck. Then, starting with the first player, each player takes the top card of the ~Raven deck and adds it to the staging area.")
                .WithFlavorLine("Chief Turch's goal is to defeat the Raven Clan before they can marshal their full strength, but Dunland is a vast country and there is much ground to cover. The longer it takes to subdue the enemy, the more time they have to gather...")
                .WithOppositeTextLine("Time 3.")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, reveal the top card of the ~Raven deck and add it to the staging area. Place 3 time counters on this stage.")
                .WithOppositeTextLine("Each location in the staging area gets +2 quest points.")
                .WithIncludedEncounterSets(EncounterSet.DunlandRaiders, EncounterSet.DunlandWarriors)
                .WithInfo(148, 1, Artist.Darek_Zabrocki);
            addQuest("The Last Stage", EncounterSet.TheAntleredCrown, 3, 'A', null)
                .WithKeywords("Time 2.")
                .WithTextLine("When Revealed: Add ~Raven Chief and ~Raven Chief's Camp to the staging area. Take the top X cards from the ~Raven deck and add them to the staging area. X is the number of players minus 1.")
                .WithFlavorLine("The warriors of the Raven Clan won't stop figting as long as their leader spurs them on. You must find the Raven Chief and defeat him in order to break the spirit of his men and bring and end to this conflict...")
                .WithOppositeTextLine("Time 2.")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, each engaged enemy makes an attack. Place 2 time counter on this stage.")
                .WithOppositeTextLine("At the end of the round, if ~Raven Chief is in the victory display, the players win the game.")
                .WithIncludedEncounterSets(EncounterSet.DunlandRaiders, EncounterSet.DunlandWarriors)
                .WithInfo(149, 1, Artist.Darek_Zabrocki);
            addObjectiveAlly("Chief Turch", EncounterSet.TheAntleredCrown, 1, 3, 2, 5)
                .WithUnique()
                .WithTraits("Dunland.", "Boar Clan.")
                .WithTextLine("The first player gains control of Chief Turch.")
                .WithTextLine("Immune to player card effects. Chief Turch does not exhaust to defend.")
                .WithTextLine("If Chief Tuch leaves play, the players lose the game.")
                .WithInfo(150, 1, Artist.Alvaro_Calvo_Escudero);
            addEnemy("Raven Chief", EncounterSet.TheAntleredCrown, 15, 4, 5, 5, 9)
                .WithUnique()
                .WithTraits("Dunland.", "Raven Clan.")
                .WithTextLine("Cannot have attachments. While ~Raven Chief's Camp is in play, ~Raven Chief cannot be damaged.")
                .WithTextLine("Forced: When ~Raven Chief attacks, remove 1 time counter from the active location, if able.")
                .WithVictoryPoints(3)
                .WithInfo(151, 1, Artist.Scott_Murphy);
            addLocation("Raven Chief's Camp", EncounterSet.TheAntleredCrown, 4, 9)
                .WithUnique()
                .WithTraits("Dunland.")
                .WithKeywords("Time 3.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Time 3. Forced: After the last time counter is removed from this location, exhaust each damaged character. Place 3 time counters on this location.")
                .WithVictoryPoints(3)
                .WithInfo(152, 1, Artist.Victor_Garcia);
            addEnemy("Raven Warrior", EncounterSet.TheAntleredCrown, 36, 3, 4, 2, 5)
                .WithTraits("Dunland.", "Raven Clan.")
                .WithTextLine("Forced: After ~Raven Warrior engages a player. remove X time counters from locations in play. X is the number of cards in engaged player's hand.")
                .WithShadow("Shadow: Defending player discards an attachment he controls.")
                .WithEasyModeQuantity(3)
                .WithInfo(153, 4, Artist.Nicholas_Gregory);
            addEnemy("Raven Skirmisher", EncounterSet.TheAntleredCrown, 26, 2, 3, 2, 2)
                .WithTraits("Dunland.", "Raven Clan.")
                .WithTextLine("When Revealed: Either remove 1 time counter from the active location, or reveal an additional encounter card.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack, where X is the Time X value on the active location.")
                .WithEasyModeQuantity(2)
                .WithInfo(154, 3, Artist.Nicholas_Gregory);
            addLocation("Raven War-camp", EncounterSet.TheAntleredCrown, 2, 4)
                .WithTraits("Dunland.")
                .WithKeywords("Time 3.")
                .WithTextLine("Time 3. Forced: After the last time counter is removed from this location, starting with the first player, each player draws the top card of the ~Raven deck and puts it into play engaged with him.")
                .WithFlavorLine("All the camp was soon astir. -The Two Towers")
                .WithEasyModeQuantity(2)
                .WithInfo(155, 4, Artist.Ben_Zweifel);
            addLocation("Raven Village", EncounterSet.TheAntleredCrown, 2, 3)
                .WithTraits("Dunland.")
                .WithKeywords("Time 2.")
                .WithTextLine("Time 2. Forced: After the last time counter is removed from this location, reveal the top card of the ~Raven deck and add it to the staging area.")
                .WithShadow("Shadow: Deal attacking enemy 2 additional shadow cards from the Raven deck.")
                .WithInfo(156, 3, Artist.Lino_Drieghe);
            addLocation("Dunland Battlefield", EncounterSet.TheAntleredCrown, 3, 5)
                .WithTraits("Dunland.")
                .WithKeywords("Time 3.")
                .WithTextLine("Time 3. Forced: After the last time counter is removed from this location, each player assigns X damage among characters he controls, where X is the number of cards in his hand.")
                .WithShadow("Shadow: Deal 1 damage to the defending character.")
                .WithInfo(157, 3, Artist.Victor_Garcia);
            addLocation("Raven Country", EncounterSet.TheAntleredCrown, 3, 6)
                .WithTraits("Dunland.")
                .WithKeywords("Time 4.")
                .WithTextLine("Time 4. Forced: After the last time counter is removed from this location, each player raises his threat by the number of cards in his hand.")
                .WithShadow("Shadow: Defending player assigns X damage among characters he controls. X is the Time X value on the active location.")
                .WithInfo(158, 2, Artist.Victor_Garcia);
            addTreachery("Raising the Cry", EncounterSet.TheAntleredCrown)
                .WithTextLine("When Revealed: Remove 1 time counter from each location in play. Place X time counters on each location in play with no time counters on it. X is the \"Time X\" value on that location. If there are not locations in the staging area, Raising the Cry gains surge.")
                .WithFlavorLine("...a cry went up into the shuddering air...")
                .WithFlavorLine("-The Return of the King")
                .WithEasyModeQuantity(2)
                .WithInfo(159, 3, Artist.Nicholas_Gregory);
            addTreachery("Fierce Folk", EncounterSet.TheAntleredCrown)
                .WithKeywords("Doomed 3.")
                .WithTextLine("Doomed 3.")
                .WithTextLine("When Revealed: Each player draws 3 cards. Until the end of the round, players cannot play events.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, remove 1 time counter from the active location.")
                .WithEasyModeQuantity(1)
                .WithInfo(160, 2, Artist.Alvaro_Calvo_Escudero);
            addTreachery("Driven Back", EncounterSet.TheAntleredCrown)
                .WithTextLine("When Revealed: Remove all progress from each location in the staging area. Increase the total Threat in the staging area by 1 for each progress removed this way. If no progress was removed by this effect, Driven Back gains surge.")
                .WithFlavorLine("\"We are overmastered.\" -Ceorl, The Two Towers")
                .WithInfo(161, 2, Artist.Igor_Kieryluk);
        }
    }
}
