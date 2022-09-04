using System;

namespace HallOfBeorn.Models.LotR.Sets.AgainstTheShadow
{
    public class AssaultOnOsgiliathNightmare : CardSet
    {
        public const string setName = "Assault on Osgiliath Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "AoON";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2059;

            addNightmareSetup(setName)
                .WithTextLine("You are playing Nightmare mode.\r\nSetup: Add Palace Remains to the staging area.")
                .WithTextLine("If there are more Osgiliath locations in the staging area than players in the game, this card gains: \"Response: At the beginning of the quest phase, choose 1 non-unique location. If the players quest successfully this phase, remaining progress made beyond the active location's quest points is placed on the chosen location")
                .WithFlavorLine("\"This great array of spears and swords is going to Osgiliath.\"")
                .WithFlavorLine("-Frodo, The Two Towers")
                .WithOppositeTextLine("Begin with the standard quest deck and encounter deck for the Assault on Osgiliath scenario.")
                .WithOppositeTextLine("Remove the following cards, in the specified quantities, from the standard encounter deck:")
                .WithOppositeTextLine("4x Uruk Soldier")
                .WithOppositeTextLine("3x Southron Phalanx")
                .WithOppositeTextLine("2x West Quarter")
                .WithOppositeTextLine("2x East Quarter")
                .WithOppositeTextLine("1x Ruined Tower")
                .WithOppositeTextLine("1x Ruined Square")
                .WithOppositeTextLine("2x The Master's Malice")
                .WithOppositeTextLine("2x Street Fighting")
                .WithOppositeTextLine("3x Southron Mercenaries")
                .WithOppositeTextLine("1x Uruk Lieutenant")
                .WithOppositeTextLine("1x Orc Arbalasters")
                .WithOppositeTextLine("1x The Power of Mordor")
                .WithOppositeTextLine("Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard the Assault on ~Osgiliath encounter deck.")
                .WithOppositeTextLine("Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Mariusz_Gandzel);
            addEnemy("Invading Orc", setName, 20, 2, 5, 3, 3)
                .WithTraits("Orc.", "Mordor.")
                .WithTextLine("Forced: After Invading Orc attacks and destroys a character, that character's controller returns a location he controls to the staging area.")
                .WithShadow("Shadow: If this attack destroys a character, return a location you control to the staging area.")
                .WithInfo(2, 3, Artist.Alvaro_Calvo_Escudero);
            addEnemy("Haradrim Warrior", setName, 30, Card.VALUE_X, 3, 3, 4)
                .WithTraits("Harad.")
                .WithKeywords("Archery X.")
                .WithTextLine("Archery X.")
                .WithTextLine("X is the number of locations controlled by the first player.")
                .WithTextLine("Forced: After Haradrim Warrior engages a player, it gets +X Attack and +X Defense until the end of the round.")
                .WithShadow("Shadow: Deal 1 damage to defending character.")
                .WithInfo(3, 3, Artist.Smirtouille);
            addLocation("Palace Remains", setName, 0, 5)
                .WithTraits("Osgiliath.")
                .WithTextLine("Immune to player card effects. Palace Remains gets +1 Threat for each resource token on it.")
                .WithTextLine("The players cannot travel here unless there are at least 5 resource tokens on Palace Remains.")
                .WithTextLine("While Palace Remains is in the staging area, it gains \"Forced: After a player takes control of a location, place 1 resource token here.\"")
                .WithInfo(4, 1, Artist.Mariusz_Gandzel);
            addLocation("Crumbled Battlements", setName, 3, 2)
                .WithTraits("Osgiliath.")
                .WithTextLine("Forced: When you take control of Crumbled Battlements, shuffle the encounter discard pile into the encounter deck and discard cards from the encounter deck until an enemy is discarded. Put the discarded enemy into play engaged with you.")
                .WithFlavorLine("\"Here they come pouring through the breaches!\"")
                .WithFlavorLine("-Man of Gondor, The Return of the King")
                .WithInfo(5, 2, Artist.Mariusz_Gandzel);
            addLocation("Eastern Quarter", setName, 3, 3)
                .WithTraits("Osgiliath.")
                .WithTextLine("Forced: When you take control of Eastern Quarter, discard each event card in your hand.")
                .WithTextLine("While a player controls Eastern Quarter it gains: \"Forced: After the 'when revealed' effect of a treachery is canceled, return Easter Quarter to the staging area.\"")
                .WithInfo(6, 2, Artist.Mariusz_Gandzel);
            addLocation("Western Quarter", setName, 2, 4)
                .WithTraits("Osgiliath.")
                .WithTextLine("Forced: When you take control of Western Quarter, discard the highest cost attachment you control.")
                .WithTextLine("While a player controls Western Quarter it gains: \"Forced: After the 'when revealed' effect of a treachery is canceled, return Western Quarter to the staging area.\"")
                .WithInfo(7, 2, Artist.Mariusz_Gandzel);
            addTreachery("Relentless Attack", setName)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Attach to the current quest. (Counts as a Condition attachment with the text: \"Each enemy gets -X engagement cost. X is the number of locations controlled by players. Forced: At the beginning of the encounter phase, if there are fewer than X enemies in the staging area, reveal an encounter card.\")")
                .WithInfo(8, 2, Artist.Jon_Bosco);
            addTreachery("Overrun Defenses", setName)
                .WithTextLine("When Revealed: Add X to the total Threat in the staging area this phase. X is the number of locations the players control. If X is less than 4, Overrun Defenses gains doomed 2.")
                .WithShadow("Shadow: Exhaust a character you control (2 characters instead of you control 4 or more locations).")
                .WithInfo(9, 2, Artist.Guillaume_Ducos);
            addTreachery("Pressed on All Sides", setName)
                .WithTextLine("When Revealed: If the total Threat of locations controlled by players is greater than the total Threat in the staging area, raise each player's threat by 2 and immediately end the quest phase without resolving the quest.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each location you control.")
                .WithInfo(10, 2, Artist.Jose_Vega);
        }
    }
}