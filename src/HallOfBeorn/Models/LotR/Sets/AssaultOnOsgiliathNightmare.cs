using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class AssaultOnOsgiliathNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "Assault on Osgiliath Nightmare";
            Abbreviation = "AoON";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2059;

            Cards.Add(new LotRCard()
            {
                Title = "Assault on Osgiliath Nightmare",
                HasSecondImage = true,
                Id = "0D18C8EE-8B52-4114-AB43-28CF4CC7E796",
                CardType = CardType.Nightmare_Setup,
                Text = "You are playing Nightmare mode.\r\nSetup: Add Palace Remains to the staging area.\r\nIf there are more Osgiliath locations in the staging area than players in the game, this card gains: \"Response: At the beginning of the quest phase, choose 1 non-unique location. If the players quest successfully this phase, remaining progress made beyond the active location's quest points is placed on the chosen location",
                FlavorText = "\"This great array of spears and swords is going to Osgiliath.\" -Frodo, The Two Towers",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for the Assault on ~Osgiliath scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

4x ~Uruk Soldier
3x Southron Phalanx
2x West Quarter
2x East Quarter
1x Ruined Tower
1x Ruined Square
2x The Master's Malice
2x Street Fighting
3x Southron Mercenaries
1x ~Uruk Lieutenant
1x ~Orc Arbalasters
1x The Power of ~Mordor

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard the Assault on ~Osgiliath encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = "Assault on Osgiliath Nightmare",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Mariusz_Gandzel
            });
            Cards.Add(LotRCard.Enemy("Invading Orc", "4C4A8641-6C80-4BDD-9536-ECCA4B294F65", "Assault on Osgiliath Nightmare", 20, 2, 5, 3, 3)
                .WithTraits("Orc.", "Mordor.")
                .WithEffect(CardEffectType.Forced, "Forced: After Invading ~Orc attacks and destroys a character, that character's controller returns a location he controls to the staging area.")
                .WithShadow("Shadow: If this attack destroys a character, return a location you control to the staging area.").WithInfo(2, 3, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Enemy("Haradrim Warrior", "39BF7B4D-81F2-404F-8F7D-4F10D8C32BE0", "Assault on Osgiliath Nightmare", 30, 255, 3, 3, 4)
                .WithTraits("Harad.")
                .WithKeywords("Archery X.")
                .WithEffect(CardEffectType.Passive, "X is the number of locations controlled by the first player.")
                .WithEffect(CardEffectType.Forced, "Forced: After Haradrim ~Warrior engages a player, it gets +X Attack and +X Defense until the end of the round.")
                .WithShadow("Shadow: Deal 1 damage to defending character.")
                .WithInfo(3, 3, Artist.Smirtouille));
            Cards.Add(LotRCard.Location("Palace Remains", "3EAC42AA-A834-4590-9ED6-FAD6386B0641", "Assault on Osgiliath Nightmare", 0, 5)
                .WithTraits("Osgiliath.")
                .WithEffect(CardEffectType.Passive, "Immune to player card effects. Palace Remains gets +1 Threat for each resource token on it.")
                .WithEffect(CardEffectType.Passive, "The players cannot travel here unless there are at least 5 resource tokens on Palace Remains.")
                .WithEffect(CardEffectType.Passive, "While Palace Remains is in the staging area, it gains \"Forced: After a player takes control of a location, place 1 resource token here.\"")
                .WithInfo(4, 1, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Location("Crumbled Battlements", "EBB34447-9755-472D-B9BB-29C47B90ACE0", "Assault on Osgiliath Nightmare", 3, 2)
                .WithTraits("Osgiliath.")
                .WithEffect(CardEffectType.Forced, "Forced: When you take control of Crumbled Battlements, shuffle the encounter discard pile into the encounter deck and discard cards from the encounter deck until an enemy is discarded. Put the discarded enemy into play engaged with you.")
                .WithEffect(CardEffectType.Flavor_Text, "\"Here they come pouring through the breaches!\" -Man of Gondor, The Return of the King")
                .WithInfo(5, 2, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Location("Eastern Quarter", "E15B0465-A247-4330-A96A-B9BC652665F1", "Assault on Osgiliath Nightmare", 3, 3)
                .WithTraits("Osgiliath.")
                .WithEffect(CardEffectType.Forced, "Forced: When you take control of Eastern Quarter, discard each event card in your hand.")
                .WithEffect(CardEffectType.Passive, "While a player controls Eastern Quarter it gains: \"Forced: After the 'when revealed' effect of a treachery is canceled, return Easter Quarter to the staging area.\"")
                .WithInfo(6, 2, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Location("Western Quarter", "40943618-9421-44B2-A863-F7D4D919DBD7", "Assault on Osgiliath Nightmare", 2, 4)
                .WithTraits("Osgiliath.")
                .WithEffect(CardEffectType.Forced, "Forced: When you take control of Western Quarter, discard the highest cost attachment you control.")
                .WithEffect(CardEffectType.Passive, "While a player controls Western Quarter it gains: \"Forced: After the 'when revealed' effect of a treachery is canceled, return Western Quarter to the staging area.\"")
                .WithInfo(7, 2, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Treachery("Relentless Attack", "CA61D58F-1E87-486B-857B-2DC220727E80", "Assault on Osgiliath Nightmare")
                .WithKeywords("Doomed 1.")
                .WithEffect(CardEffectType.When_Revealed, "When Revealed: Attach to the current quest. (Counts as a Condition attachment with the text: \"Each enemy gets -X engagement cost. X is the number of locations controlled by players. Forced: At the beginning of the encounter phase, if there are fewer than X enemies in the staging area, reveal an encounter card.\")")
                .WithInfo(8, 2, Artist.Jon_Bosco));
            Cards.Add(LotRCard.Treachery("Overrun Defenses", "17B586BC-A20A-4A86-A8CE-96620E3A1835", "Assault on Osgiliath Nightmare")
                .WithEffect(CardEffectType.When_Revealed, "When Revealed: Add X to the total Threat in the staging area this phase. X is the number of locations the players control. If X is less than 4, Overrun Defenses gains doomed 2.")
                .WithShadow("Shadow: Exhaust a character you control (2 characters instead of you control 4 or more locations).")
                .WithInfo(9, 2, Artist.Guillaume_Ducos));
            Cards.Add(LotRCard.Treachery("Pressed on All Sides", "30A55F5C-5921-4F6A-A6E7-78DF6217321D", "Assault on Osgiliath Nightmare")
                .WithEffect(CardEffectType.When_Revealed, "When Revealed: If the total Threat of locations controlled by players is greater than the total Threat in the staging area, raise each player's threat by 2 and immediately end the quest phase without resolving the quest.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each location you control.")
                .WithInfo(10, 2, Artist.Jose_Vega));
        }
    }
}