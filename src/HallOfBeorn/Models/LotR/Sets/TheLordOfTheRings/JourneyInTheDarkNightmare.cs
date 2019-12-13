using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheLordOfTheRings
{
    public class JourneyInTheDarkNightmare : CardSet
    {
        private const string setName = "Journey in the Dark Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "JitDN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2066;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nEach hero in each player's discard pile cannot leave the discard pile.\r\nThe players cannot defeat stage 3B unless The Balrog is in the victory display.")
                .WithFlavor("\"And I say to you: if you pass the doors of Moria, beware!\" -Aragorn, The Fellowship of the Ring")
                .WithOppositeText("Begin with the standard and encounter deck for The Journey in the ~Dark scenario.\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:\r\n3x Moria ~Archer\r\n4x Mines of Moria\r\n1x We Cannot Get Out\r\n3x Deep Fissure\r\nThen, shuffle the encounter cards in this Nightmare ~Deck into the remainder of the standard Joruney in the ~Dark encounter deck.\r\nFinally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Javier_Charro_Martinez));
            addCard(LotRCard.Enemy("Slab-bearer", string.Empty, setName, 32, 4, 5, 3, 4)
                .WithTraits("Troll.")
                .WithText("Cannot have attachments.\r\nForced: When Slab-bearer is destroyed, discard the top card of the encounter deck. If the discarded card is an enemy, add it to the staging area.")
                .WithFlavor("...they bore great slabs of stone, and flung them down to serve as gangways over the fire.\r\n-The Fellowship of the Ring")
                .WithInfo(2, 2, Artist.Rafal_Hrynkiewicz));
            addCard(LotRCard.Enemy("Zirakzigil Archer", string.Empty, setName, 42, 3, 4, 3, 4)
                .WithTraits("Orc.")
                .WithKeywords("Peril.", "Archery 2.")
                .WithTextLine("Peril. Archery 2.")
                .WithTextLine("When Revealed: Discard a randome card from your hand. Assign X damage among characters you control, where X is the cost of the discarded card.")
                .WithInfo(3, 4, Artist.Javier_Charro_Martinez));
            addCard(LotRCard.Location("Glowing Fissure", string.Empty, setName, 254, 4)
                .WithTraits("Underground.")
                .WithText("X is 1 more than the number of damaged characters.\r\nForced: After a player commits characters to the quest, he deals 1 damage to a character he controls.")
                .WithFlavor("Out of it a fierce red light came, and now and again flames licked at the brink... -The Fellowship of the Ring")
                .WithInfo(4, 3, Artist.Pavel_Kolomeyets));
            addCard(LotRCard.Location("Darkened Mine", string.Empty, setName, 3, 5)
                .WithTraits("Underground.")
                .WithText("While Darkened Mine is in the staging area, progress cannot be placed on locations in the staging area.")
                .WithShadow("Shadow: Discard 1 random card from your hand.")
                .WithInfo(5, 3, Artist.Igor_Burlakov));
            addCard(LotRCard.Treachery("Fiery Whip", string.Empty, setName)
                .WithUnique()
                .WithText("When Revealed: Attach Fiery Whip to The Balrog (even if out of play) as a Weapon attachment with the text: \"Attached enemy gets +1 Defense and gains Archery 4.\"")
                .WithShadow("Shadow: If attacking enemy is The Balrog, attach Fiery Whip to it.")
                .WithInfo(6, 1, Artist.Florian_Devos));
            addCard(LotRCard.Treachery("Flaming Sword", string.Empty, setName)
                .WithUnique()
                .WithText("When Revealed: Attach Fiery Whip to The Balrog (even if out of play) as a Weapon attachment with the text: \"Attached enemy gets +1 Attack and gains Regenerate 4. (At the end of the refresh phase, remove 4 damage from the attached enemy.)\"")
                .WithShadow("Shadow: If attacking enemy is The Balrog, attach Flaming Sword to it.")
                .WithInfo(7, 1, Artist.Florian_Devos));
            addCard(LotRCard.Treachery("Very Weary", string.Empty, setName)
                .WithText("When Revealed: Each player deals 1 damage to a questing character he controls. Until the end of the phase, each damaged character gets -2 Willpower.")
                .WithShadow("Shadow: Deal 1 damage to the defending character.")
                .WithInfo(8, 3, Artist.Dleoblack));
            addCard(LotRCard.Treachery("Cut Off", string.Empty, setName)
                .WithKeywords("Peril.")
                .WithTextLine("Peril.")
                .WithTextLine("When Revealed: Either deal 1 damage to each character you control, or progress cannot be placed on the quest until the end of the round.")
                .WithShadow("Shadow: If this attack destroys a character, remove all progress from the quest.")
                .WithInfo(9, 2, Artist.Javier_Charro_Martinez));
        }
    }
}