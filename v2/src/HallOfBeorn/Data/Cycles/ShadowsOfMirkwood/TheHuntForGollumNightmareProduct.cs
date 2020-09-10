using System;

namespace HallOfBeorn.Data.Cycles.ShadowsOfMirkwood
{
    public static class TheHuntForGollumNightmareProduct
    {
        public static ProductBuilder Builder()
        {
            var builder = new ProductBuilder(ProductNames.TheHuntForGollumNightmareDeck, ProductCodes.TheHuntForGollumNightmareDeck, new DateTime(2013, 12, 30));

            var nm = builder.NightmareDeck(CardSetNames.TheHuntForGollumNightmare, "THfGN", 1);

            var es = nm.EncounterSet(EncounterSetNames.TheHuntForGollumNightmare);

            es.addNightmareSetup()
                .WithTextLine("You are playing Nightmare mode.")
                .WithTextLine("Forced: At the end of the refresh phase, choose an unclaimed Clue card not attached to a Mordor enemy and attach it to a Mordor enemy, if able. (If it was guarded, detach the encounter guarding it first. The newly attached Mordor enemy is now guarding it.)")
                .WithTextLine("If at any point there are four or more Clue cards attached to Mordor enemies, the players lose the game.")
                .WithFlavor("\"Through Mirkwood and back again it led them, though they never caught him.\"")
                .WithFlavor("-Gandalf, The Fellowship of the Ring")
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
                .WithInfo(1, 1, Artists.Ignacio_Bazan_Lazcano);
            es.addEnemy("Ravenous Hawk", 42, 2, 3, 3, 4)
                .WithTraits("Creature.")
                .WithTextLine("Forced: When a card effect instructs a player to \"look\" at cards in the encounter deck and Ravenous Hawk is among those cards, that player must put Ravenous Hawk into play engaged with him. (This does not satisfy the Forced effect of stage 1B or 2B).")
                .WithInfo(2, 3, Artists.Nacho_Molina);
            es.addEnemy("Hunting Warg", 15, 1, 3, 2, 3)
                .WithTraits("Creature.", "Mordor.")
                .WithTextLine("Forced: At the beginning of the refresh phase, if Hunting Warg entered play this round, search the encounter deck and discard pile for 1 copy of Hunters from Mordor and add it to the staging area, if able. Shuffle the encounter deck.")
                .WithFlavor("\"...where the warg howls, there also the orc prowls.\"")
                .WithFlavor("-Aragorn, The Fellowship of the Ring")
                .WithInfo(3, 2, Artists.Aurelien_Hubert);
            es.addLocation("Watched Path", 3, 4)
                .WithTraits("Forest.", "Road.")
                .WithTextLine("Each player who does not control at least 1 Clue card cannot draw cards through card effects.")
                .WithShadow("Shadow: If you do not control at least 1 Clue card, discard all cards from your hand.")
                .WithFlavor("\"The Road is watched, but we should have to cross it...\"")
                .WithFlavor("-Aragorn, The Fellowship of the Ring")
                .WithInfo(4, 2, Artists.Jose_Vega);
            es.addLocation("Hunter's Lookout", 2, 6)
                .WithTraits("Riverland.")
                .WithTextLine("Each Mordor enemy with at least 1 Clue card attached gets +2 Defense.")
                .WithShadow("Shadow: Attacking enemy gets +1 Defense for each Clue card in play until the end of the round.")
                .WithInfo(5, 2, Artists.Jose_Vega);
            es.addLocation("Dark Pools", 3, 2)
                .WithTraits("Marshland.")
                .WithTextLine("Progress cannot be placed on Dark Pools while it is in the staging area.")
                .WithTextLine("Forced: After Dark Pools becomes the active location, each player must discard an ally with the highest printed cost among the allies he controls.")
                .WithFlavor("\"And there in the dark pools amid the Gladden Fields,\" he said, \"the Ring passed out of knowledge and legend...\"")
                .WithFlavor("-The Fellowship of the Ring")
                .WithInfo(6, 3, Artists.Jose_Vega);
            es.addTreachery("The Enemy's Trail")
                .WithTextLine("When Revealed: Search the encounter discard pile for a Clue card and attach it to a Mordor enemy in play, if able. If no card is attached by this effect, The Enemy's Trail gains surge.")
                .WithShadow("Shadow: Search the encounter discard pile for a Clue card and attach it to a Mordor enemy in play, if able.")
                .WithInfo(7, 2, Artists.Cristi_Balanescu);
            es.addTreachery("Restless Hunters")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: The first player chooses a Clue card attached to a hero and attaches it to a Mordor enemy in play, if able.")
                .WithShadow("Shadow: Damage from this attack must be applied to a hero you control with a Clue card attached, if able.")
                .WithInfo(8, 3, Artists.Adam_Lane);
            es.addTreachery("The Trail Goes Cold")
                .WithTextLine("When Revealed: Attach to the active location and remove all progress from that location. (Counts as a Condition attachment with the text: \"Limit 1 per location. Attached location contributes its Threat during the quest phase as if it were in the staging area.\")")
                .WithTextLine("If The Trail Goes Cold does not attach to a location as a result of this effect, it gains surge.")
                .WithInfo(9, 2, Artists.Christine_Mitzuk);

            return builder;
        }
    }
}
