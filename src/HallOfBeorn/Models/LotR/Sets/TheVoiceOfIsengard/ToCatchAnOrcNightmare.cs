using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheVoiceOfIsengard
{
    public class ToCatchAnOrcNightmare : CardSet
    {
        const string setName = "To Catch an Orc Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TCaON";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2066;

            Cards.Add(new LotRCard()
            {
                Title = setName,
                CardType = CardType.Nightmare_Setup,
                Text = "You are playing Nightmare mode.\r\nSetup: Each player shuffles 1 copy of Vigilant Orc into his out of play deck. Set both copiues of Mugash's Rage and any remaining copies of Vigilant Orc aside, out of play.\r\nForced: When the players advance to stage 3A, shuffle both copies of Mugash's Rage into the encounter deck.",
                FlavorText = "There they picked up the trail of the Orcs. It needed little skill to find. -The Two Towers",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for the To Catch an Orc scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

1x Methedras ~Orc
1x ~Orc Skirmisher
1x ~Orc Hunter
3x Prowling Wolf
2x Methedras
1x ~Orc ~Cave
2x ~Orc Hunting Party

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard To Catch an Orc encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = setName,
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Mariusz_Gandzel
            });
            Cards.Add(LotRCard.Enemy("Vigilant Orc", "", setName, 1, 2, 4, 3, 4)
                .WithTraits("Orc.")
                .WithText("Forced: After Vigilant Orc enters the staging area, it makes an immediate attack against the first player. If this attack destroys a character, remove 1 time counter from the current quest.")
                .WithFlavor("Fierce and shrill rose the yells of the Orcs, and suddenly horn-calls ceased. -The Two Towers")
                .WithVictoryPoints(4)
                .WithInfo(2, 4, Artist.Anthony_Feliciano));
            Cards.Add(LotRCard.Enemy("Methedras Lookout", "", setName, 44, 3, 5, 4, 5)
                .WithTraits("Orc.")
                .WithText("While Methedras Lookout is in the staging area, it gains: \"Forced: At the end of the refresh phase, remove 1 time counter from the current quest.\"")
                .WithShadow("Shadow: Either exhaust a character you control, or return attacking enemy to the staging area.")
                .WithInfo(3, 3, Artist.Chris_Grun));
            Cards.Add(LotRCard.Enemy("Guard Wolf", "", setName, 25, 4, 3, 3, 3)
                .WithTraits("Creature.")
                .WithText("Forced: After the engaged player discards any number of cards from his out-of-play deck, Guard Warg makes an immediate attack.")
                .WithShadow("Shadow: Deal 1 damage to the defending character.")
                .WithInfo(4, 2, Artist.Joel_Hustak));
            Cards.Add(LotRCard.Location("Methedras Peak", "", setName, Card.VALUE_X, 5)
                .WithTraits("Mountain.")
                .WithText("X is the number of characters controlled by the first player.\r\nForced: After Methedras Peak leaves play as an explored location, each player searches 3.")
                .WithFlavor("...they had come to the feet of the mountains, and to the green roots of tall Methedras. -The Two Towers")
                .WithInfo(5, 2, Artist.Katy_Grierson));
            Cards.Add(LotRCard.Location("Orc Trail", "", setName, 4, 2)
                .WithTraits("Mountain.")
                .WithText("Forced: After Orc Trail leaves play as an explored location, choose an out of play Orc enemy, either set aside or in the victory display, and add it to the staging area. Then, the first player searches 4.")
                .WithFlavor("\"No other folk make such a trampling.\"\r\n-Legolas, The Two Towers")
                .WithInfo(6, 2, Artist.Rafal_Hrynkiewicz));
            Cards.Add(LotRCard.Treachery("Mugash's Cunning", "", setName)
                .WithText("When Revealed: Each player discard the top 3 cards of his out-of-play deck. Add each enemy discarded this way to the staging area. If no enemies are added to the staging area this way, Mugash's Cunning gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +3 Attack and +3 Defense until the end of the round.")
                .WithInfo(7, 2, Artist.Suzanne_Helmigh));
            Cards.Add(LotRCard.Treachery("Patrolling Orcs", "", setName)
                .WithKeywords("Surge.", "Doomed 1.")
                .WithText("Surge. Doomed 1.\r\nWhen Revealed: Attach to the current quest. (Counts as a Condition attachment with the text: \"Forced: After a player engages an enemy, he must either exhaust a character he controls, or remove 1 time counter from the current quest.\")")
                .WithInfo(8, 2, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Treachery("Mugash's Rage", "", setName)
                .WithText("When Revealed: If Mugash is attached to a hero, the player who controls that hero unattaches Mugash and engages it. Then, Mugash makes an immediate attack.")
                .WithShadow("Shadow: Attacking enemy cannot take damage until the end of the round.")
                .WithInfo(9, 2, Artist.Rafal_Hrynkiewicz));
        }
    }
}