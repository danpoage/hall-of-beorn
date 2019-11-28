using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.DreamChaser
{
    public class AStormOnCobasHavenNightmareSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "A Storm on Cobas Haven Nightmare";
            Abbreviation = "ASoCHN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2088;

            addNightmareSetup(EncounterSet.AStormOnCobasHavenNightmare)
                .WithTextLine("You are playing Nightmare mode.")
                .WithTextLine("Setup: When choosing a Dol Amroth objective to put into play during setup, players must choose randomly among all 6 Dol Amroth objectives.")
                .WithTextLine("Raider Flagship cannot guard objectives.")
                .WithTextLine("While any player is engaged with Raider Flagship, no more than 5 progress can be placed on the current quest each round.")
                .WithFlavorLine("And in the morning the banner of Dol Amroth, a white ship like a swan upon blue water, floated from the Tower...")
                .WithFlavorLine("-The Return of the King")
                .WithOppositeTextLine("Begin with the standard quest deck and encounter deck for the A Storm on Cobas Haven scenario.")
                .WithOppositeTextLine("Remove the following card, in the specified quantities, from the standard encounter deck:")
                .WithOppositeTextLine("2x Belfalas Islet")
                .WithOppositeTextLine("2x Cobas Haven")
                .WithOppositeTextLine("2x Fog Bank")
                .WithOppositeTextLine("2x Corsair Skirmisher")
                .WithOppositeTextLine("1x Ramming Speed!")
                .WithOppositeTextLine("2x Corsair Infiltrator")
                .WithOppositeTextLine("1x Cunning Pirate")
                .WithOppositeTextLine("1x Umbar Raider")
                .WithOppositeTextLine("Then, shuffle the encounter card in this Nightmare Deck into the remainder of the standard A Storm on Cobas Haven encounter deck.")
                .WithOppositeTextLine("Finally, flip this setup card over and placr it next to the quest deck. Its effect remains active throughout the game, which is now ready to being.")
                .WithOppositeTextLine("Wheel*: Some cards in the A Storm on Cobas Haven Nightmare Deck have Sailing success symbols (Wheel) with an asterisk (*) next to them. This indicates that the card has a Forced effect which will trigger when the card is discarded during a Sailing test.")
                .WithInfo(1, 1, Artist.Logan_Feliciano);
            addObjective("Aearlang", EncounterSet.AStormOnCobasHavenNightmare)
                .WithUnique()
                .WithTraits("Dol Amroth.", "Besieged.")
                .WithKeywords("Guarded.")
                .WithTextLine("Guarded.")
                .WithTextLine("If Aearlang is free of encounters, add it to the staging area, controlled by the players.")
                .WithTextLine("Action: Exhaust Aearlang to ready a hero. Any player may trigger this action.")
                .WithFlavorLine("\"Then you would have us retreat... and there sit like children on sand-castles when the tide is flowing?\"")
                .WithFlavorLine("-Prince Imrahil, The Return of the King")
                .WithInfo(2, 1, Artist.Brenda_Bae);
            addObjective("Docks of Dol Amroth", EncounterSet.AStormOnCobasHavenNightmare)
                .WithUnique()
                .WithTraits("Dol Amroth.", "Besieged.")
                .WithKeywords("Guarded.")
                .WithTextLine("Guarded.")
                .WithTextLine("If Docks of Dol Amroth is free of encounters, add it to the staging area, controlled by the players.")
                .WithTextLine("Action: Exhaust Docks of Dol Amroth to heal 2 damage from a Ship objective. Any player may trigger this action.")
                .WithInfo(3, 1, Artist.Igor_Artyomenko);
            addEnemy("Ramming Ship", EncounterSet.AStormOnCobasHavenNightmare, 28, 4, 4, 3, 8)
                .WithTraits("Corsair.", "Ship.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Forced: After Ramming Ship engages you, it gets +4 Attack until the end of the round.")
                .WithShadow("Shadow: Put the top card of Corsair deck into play engaged with you and deal it a shadow card.")
                .WithInfo(4, 2, Artist.Igor_Artyomenko);
            addEnemy("Fang of Sahír", EncounterSet.AStormOnCobasHavenNightmare, 42, 2, 5, 3, 3)
                .WithTraits("Corsair.")
                .WithTextLine("Forced: When Fang of Sahír engages you, either deal 3 damage to a Ship objective you control, or Fang of Sahír makes an immediate attack.")
                .WithInfo(5, 3, Artist.Guillaume_Ducos);
            addLocation("City Under Siege", EncounterSet.AStormOnCobasHavenNightmare, 2, 6)
                .WithTraits("Coastland.", "Ocean.")
                .WithTextLine("While City Under Siege is in the staging area, it gains archery 2, and damage from the archery keyword must be applied to Ship objectives.")
                .WithShadow("Shadow: If attacking enemy is guarding an objective, return it to the staging area after this attack.")
                .WithInfo(6, 3, Artist.Chris_Grun);
            addLocation("Sea-wall", EncounterSet.AStormOnCobasHavenNightmare, 2, 2)
                .WithTraits("Coastland.", "Ocean.")
                .WithTextLine("Sea-wall gets +2 Threat and +2 quest points for each objective guarded by an encounter card.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each objective guarded by an encounter card.")
                .WithInfo(7, 3, Artist.Logan_Feliciano);
            addLocation("War-torn Waters", EncounterSet.AStormOnCobasHavenNightmare, 3, 5)
                .WithTraits("Coastland.", "Ocean.")
                .WithTextLine("While War-torn Waters is in the staging area, it gains: \"Forced: At the end of the quest phase, if War-torn Waters is not guarding an objective and there is an unguarded objective in the staging area, attach War-torn Waters to that objective, guarding it.")
                .WithTextLine("Travel: Deal 2 damage to each Ship objective to travel here.")
                .WithInfo(8, 2, Artist.Chris_Grun);
            addTreachery("Broken Rudder", EncounterSet.AStormOnCobasHavenNightmare)
                .WithTextLine("When Revealed: Attach to a Ship objective. (Counts as a Condition attachment with the text: \"During saling tests, for each Wheel symbol found, cancel it unless you deal 1 damage to the attached objective. Action: Exhaust 3 character you control to discard Broken Rudder.\")")
                .WithTextLine("*Forced: After this Sailing test ends, attach Broken Rudder to a Ship objective committed to that test.")
                .WithInfo(9, 2, Artist.Monztre);
            addTreachery("Grappled!", EncounterSet.AStormOnCobasHavenNightmare)
                .WithTextLine("When Revealed: Attach to a Ship objective. (Counts as a Condition attachment with the text: \"Attached objective cannot ready. Action: Exhaust 3 character you control to discard Grappled!\")")
                .WithShadow("Shadow: If defending character is a Ship, attach Grappled! to it.")
                .WithInfo(10, 2, Artist.Federico_Musetti);
        }
    }
}