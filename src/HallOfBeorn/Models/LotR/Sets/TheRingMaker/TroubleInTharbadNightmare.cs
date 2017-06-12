using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheRingMaker
{
    public class TroubleInTharbadNightmare : CardSet
    {
        private const string setName = "Trouble in Tharbad Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TiTN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2070;

            Cards.Add(new LotRCard()
            {
                Title = setName,
                CardType = CardType.Nightmare_Setup,
                Text = "You are playing Nightmare mode.\r\nSetup: Raise each player's starting threat by 5.\r\nProgress cannot be placed on Crossing at Tharbad while Bellach is in play.",
                FlavorText = "The houses looked large and strange to them. Sam stared up at the inn with its three storeys and many windows, and felt his heart sink.\r\n-The Fellowship of the Ring",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for Trouble in Tharbad scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

1x ~Orc ~Hunter
2x ~Orc Skirmisher
2x Tharbad ~Hideout
2x Hidden Alleyway
1x Decrepit Rooftops
2x ~Orc Hunting Party

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Trouble in Tharbad encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = setName,
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(LotRCard.Enemy("Bellach's Hunter", "", setName, 50, 3, 6, 4, 6)
                .WithTraits("Orc.", "Spy.")
                .WithText("While a player controls 5 or more allies, Bellach's Hunter gets -20 engagement cost.\r\nForced: When Bellach's Hunter engages a player, that player must either remove all time counters from the current quest or deal 5 damage to a hero he controls.")
                .WithInfo(2, 2, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Enemy("Orc Seeker", "", setName, 20, 2, 4, 3, 4)
                .WithTraits("Orc.")
                .WithText("When Revealed: Either reduce each player's threat elimination level by 2, or Orc Seeker engages the first player and makes an immediate attack.")
                .WithShadow("Shadow: Reduce each player's threat elimination level by 2 (5 instead if undefended).")
                .WithInfo(3, 3, Artist.Nicholas_Gregory));
            Cards.Add(LotRCard.Enemy("Blood Hound", "", setName, 0, 2, 2, 2, 3)
                .WithTraits("Creature.")
                .WithText("Forced: When Blood Hound engages you, raise your threat by 5.")
                .WithShadow("Shadow: Either raise your threat by 10, or attacking enemy makes an additional attack against you after this one.")
                .WithInfo(4, 3, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Location("City of Spies", "", setName, 2, 5)
                .WithTraits("City.", "Ruins.")
                .WithText("While City of Spies is in the staging area, it gains: \"Forced: When you commit a character to the quest, raise your threat by 1. This effect does not stack with other copies of City of Spies.\"")
                .WithInfo(5, 3, Artist.Davis_Engel));
            Cards.Add(LotRCard.Location("Dark Pathway", "", setName, 5, 4)
                .WithTraits("City.")
                .WithText("While Dark Pathway is the active location, the first treachery card without the printed surge keyword revealed during the quest phase gains surge.")
                .WithShadow("Shadow: Either remove 1 time counter from the current quest or treat this attack as undefended.")
                .WithInfo(6, 3, Artist.Yoann_Boissonnet));
            Cards.Add(LotRCard.Treachery("Waylaid by Agents", "", setName)
                .WithText("When Revealed: Each player must choose: either remove 1 time counter from the quest or discard an ally he controls from play. Then, if any player's threat is 20 or less, Waylaid by Agents gains doomed 3.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if your threat is 20 or less).")
                .WithInfo(7, 2, Artist.Taylor_Ingvarsson));
            Cards.Add(LotRCard.Treachery("Tharbad Patrol", "", setName)
                .WithKeywords("Surge.")
                .WithText("When Revealed: Attach Tharbad Patrol to a non-unique location in the staging area without a copy of Tharbad Patrol attached. (Counts as a Condition attachment with the text: \"Forced: After the players travel to attached location, each player must discard the top 2 cards from the encounter deck and engage each enemy he discarded in this way.\")")
                .WithInfo(8, 3, Artist.Mariusz_Gandzel));
        }
    }
}