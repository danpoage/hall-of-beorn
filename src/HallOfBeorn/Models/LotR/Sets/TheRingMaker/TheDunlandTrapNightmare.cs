using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheRingMaker
{
    public class TheDunlandTrapNightmare : CardSet
    {
        private const string setName = "The Dunland Trap Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TDTN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2068;

            Cards.Add(new LotRCard()
            {
                Title = setName,
                CardType = CardType.Nightmare_Setup,
                Text = "You are playing Nightmare mode.",
                FlavorText = "\"I hear them,\" said Éomer; \"but they are only the screams of birds and the bellowing of beasts to my ears.\"\r\n-The Two Towers",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for The Dunland Trap scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

4x ~Boar Clan ~Warrior
4x Hithaeglir Stream
3x ~Plains of ~Enedwaith
1x ~Dunlending Ambush
1x Frenzied Attack
1x Low on Provisions

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Dunland Trap encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                HtmlTemplate = "<p>You are playing Nightmare mode.</p><p class='flavor-text'>&quot;I hear them,&quot; said Éomer; &quot;but they are only the screams of birds and the bellowing of beasts to my ears.&quot;<br>&ndash;The Two Towers</p>",
                HtmlTemplate2 = "<p>Begin with the standard quest deck and encounter deck for <a href='/Cards/Scenarios/The-Dunland-Trap' target='_blank'>The Dunland Trap scenario</a>.</p><p>Remove the following cards, in the specified quantities, from the standard encounter deck:</p><p><ul class='no-style-list'><li>4x {card:Boar-Clan-Warrior-TDT@Boar Clan Warrior}</li><li>4x {card:Hithaeglir-Stream-TDT@Hithaeglir Stream}</li><li>3x {card:Plains-of-Enedwaith-TDT@Plains of Enedwaith}</li><li>1x {card:Dunlending-Ambush-TDT@Dunlending-Ambush}</li><li>1x {card:Frenzied-Attack-TDT@Frenzied Attack}</li><li>1x {card:Low-on-Provisions-VoI@Low on Provisions}</li></ul><p>Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard <a href='/Cards/Search?EncounterSet=The+Dunland+Trap' target='_blank'>The Dunland Trap encounter deck</a>.</p><p>Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.</p>",
                EncounterSet = setName,
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Mariusz_Gandzel
            });
            Cards.Add(LotRCard.Enemy("Boar Clan Ambusher", "", setName, 30, 3, 5, 2, 5)
                .WithTraits("Dunland.", "Boar Clan.")
                .WithText("Forced: After Boar Clan Ambusher attacks and destroys a character, discard a random card from your hand.")
                .WithShadow("Shadow: If this attack destroys a character, discard a random card from your hand.")
                .WithInfo(2, 3, Artist.Jessica_Savard));
            Cards.Add(LotRCard.Enemy("Boar Clan Skirmisher", "", setName, 20, 2, 3, 2, 4)
                .WithTraits("Dunland.", "Boar Clan.")
                .WithText("Forced: After the engaged player draws any number of cards, deal 1 damage to a hero he controls.")
                .WithShadow("Shadow: Deal 1 damage to a hero you control (2 damage instead if undefended).")
                .WithInfo(3, 4, Artist.Tiziano_Baracchi));
            Cards.Add(LotRCard.Location("Plains of Dunland", "", setName, 4, 5)
                .WithTraits("Enedwaith.", "Plains.")
                .WithText("Whiles Plains of Dunland is in the staging area, each Dunland enemy gets -20 engagement cost and cannot be optionally engaged.\r\nTravel: The first player engages the highest Attack enemy in the staging area to travel here.")
                .WithInfo(4, 2, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Location("Munuv Dûv River", "", setName, 2, 3)
                .WithTraits("Enedwaith.", "Hills.", "River.")
                .WithText("While Munuv Dûv River is in the staging area, it gainst: \"Forced: After a player draws any number of cards, he deals 1 shadow card to an enemy engaged with him.\"")
                .WithShadow("Shadow: Raise your threat by 1 for each enemy engaged with you.")
                .WithInfo(5, 3, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Location("Hithaeglir Woods", "", setName, 3, 4)
                .WithTraits("Enedwaith.", "Forest.", "Hills.")
                .WithText("While Hithaeglir Woods is in the staging area, each Dunland enemy in the staging area cannot take damage.\r\nTravel: Deal each Dunland enemy a shadow card to travel here.")
                .WithInfo(6, 3, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Treachery("Boar Clan Assault", "", setName)
                .WithText("When Revealed: Each engaged enemy makes an immediate attack. If no attacks are made this way, Boar Clan Assault gains surge.")
                .WithShadow("Shadow: Each enemy engaged with you gets +1 Attack until the end of the phase.")
                .WithInfo(7, 2, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Treachery("Stalked by Dunlendings", "", setName)
                .WithText("When Revealed: Each player draws 1 card. Until the end of the round, add X Threat to the total Threat in the staging area. X is the number of card in the first player's hand.")
                .WithShadow("Shadow: Put the topmost enemy in the discard pile into play engaged with you and deal it a shadow card.")
                .WithInfo(8, 2, Artist.Mariusz_Gandzel));
        }
    }
}