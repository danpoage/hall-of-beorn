using System;

namespace HallOfBeorn.Models.LotR.Sets.ShadowsOfMirkwood
{
    public class TheHuntForGollumNightmareSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Hunt for Gollum Nightmare";
            Abbreviation = "THfGN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2003;

            addNightmareSetup(EncounterSet.TheHuntForGollumNightmare.Name)
                .WithTextLine("You are playing Nightmare mode.")
                .WithTextLine("Forced: At the end of the refresh phase, choose an unclaimed Clue card not attached to a Mordor enemy and attach it to a Mordor enemy, if able. (If it was guarded, detach the encounter guarding it first. The newly attached Mordor enemy is now guarding it.)")
                .WithTextLine("If at any point there are four or more Clue cards attached to Mordor enemies, the players lose the game.")
                .WithFlavorLine("\"Through Mirkwood and back again it led them, though they never caught him.\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithOppositeTextLine("Begin with the standard quest deck and encounter deck for The Hunt for ~Gollum scenario.")
                .WithOppositeTextLine("Remove the following cards, in the specified quantities, from the standard encounter deck:")
                .WithOppositeTextLine("2x ~River Ninglor")
                .WithOppositeTextLine("1x The Eaves of ~Mirkwood")
                .WithOppositeTextLine("2x False Lead")
                .WithOppositeTextLine("2x Misty ~Mountain Goblins")
                .WithOppositeTextLine("2x Banks of the Anduin")
                .WithOppositeTextLine("3x Gladden Fields")
                .WithOppositeTextLine("3x Eastern Crows")
                .WithOppositeTextLine("2x Treacherous Fog")
                .WithOppositeTextLine("3x Evil Storm")
                .WithOppositeTextLine("Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Hunt for ~Gollum encounter deck.")
                .WithOppositeTextLine("Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Ignacio_Bazan_Lazcano);
            addEnemy("Ravenous Hawk", EncounterSet.TheHuntForGollumNightmare.Name, 42, 2, 3, 3, 4)
                .WithTraits("Creature.")
                .WithTextLine("Forced: When a card effect instructs a player to \"look\" at cards in the encounter deck and Ravenous Hawk is among those cards, that player must put Ravenous Hawk into play engaged with him. (This does not satisfy the Forced effect of stage 1B or 2B).")
                .WithInfo(2, 3, Artist.Nacho_Molina);
            addEnemy("Hunting Warg", EncounterSet.TheHuntForGollumNightmare.Name, 15, 1, 3, 2, 3)
                .WithTraits("Creature.", "Mordor.")
                .WithTextLine("Forced: At the beginning of the refresh phase, if Hunting Warg entered play this round, search the encounter deck and discard pile for 1 copy of Hunters from Mordor and add it to the staging area, if able. Shuffle the encounter deck.")
                .WithFlavorLine("\"...where the warg howls, there also the orc prowls.\"")
                .WithFlavorLine("-Aragorn, The Fellowship of the Ring")
                .WithInfo(3, 2, Artist.Aurelien_Hubert);
            addLocation("Watched Path", EncounterSet.TheHuntForGollumNightmare.Name, 3, 4)
                .WithTraits("Forest.", "Road.")
                .WithTextLine("Each player who does not control at least 1 Clue card cannot draw cards through card effects.")
                .WithShadow("Shadow: If you do not control at least 1 Clue card, discard all cards from your hand.")
                .WithFlavorLine("\"The Road is watched, but we should have to cross it...\"")
                .WithFlavorLine("-Aragorn, The Fellowship of the Ring")
                .WithInfo(4, 2, Artist.Jose_Vega);
            addLocation("Hunter's Lookout", EncounterSet.TheHuntForGollumNightmare.Name, 2, 6)
                .WithTraits("Riverland.")
                .WithTextLine("Each Mordor enemy with at least 1 Clue card attached gets +2 Defense.")
                .WithShadow("Shadow: Attacking enemy gets +1 Defense for each Clue card in play until the end of the round.")
                .WithInfo(5, 2, Artist.Jose_Vega);
            addLocation("Dark Pools", EncounterSet.TheHuntForGollumNightmare.Name, 3, 2)
                .WithTraits("Marshland.")
                .WithTextLine("Progress cannot be placed on Dark Pools while it is in the staging area.")
                .WithTextLine("Forced: After Dark Pools becomes the active location, each player must discard an ally with the highest printed cost among the allies he controls.")
                .WithFlavorLine("'And there in the dark pools amid the Gladden Fields,'he said, 'the Ring passed out of knowledge and legend...'")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(6, 3, Artist.Jose_Vega);
            addTreachery("The Enemy's Trail", EncounterSet.TheHuntForGollumNightmare.Name)
                .WithTextLine("When Revealed: Search the encounter discard pile for a Clue card and attach it to a Mordor enemy in play, if able. If no card is attached by this effect, {self} gains surge.")
                .WithShadow("Shadow: Search the encounter discard pile for a Clue card and attach it to a Mordor enemy in play, if able.")
                .WithInfo(7, 2, Artist.Cristi_Balanescu);
            addTreachery("Restless Hunters", EncounterSet.TheHuntForGollumNightmare.Name)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: The first player chooses a Clue card attached to a hero and attaches it to a Mordor enemy in play, if able.")
                .WithShadow("Shadow: Damage from this attack must be applied to a hero you control with a Clue card attached, if able.")
                .WithInfo(8, 3, Artist.Adam_Lane);
            addTreachery("The Trail Goes Cold", EncounterSet.TheHuntForGollumNightmare.Name)
                .WithTextLine("When Revealed: Attach to the active location and remove all progress from that location. (Counts as a Condition attachment with the text:\"Limit 1 per location. Attached location contributes its Threat during the quest phase as if it were in the staging area.\")")
                .WithTextLine("If The Trail Goes Cold does not attach to a location as a result of this effect, it gains surge.")
                .WithInfo(9, 2, Artist.Christine_Mitzuk);
        }
    }
}