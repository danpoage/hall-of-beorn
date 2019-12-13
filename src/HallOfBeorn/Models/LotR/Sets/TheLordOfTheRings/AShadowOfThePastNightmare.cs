using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheLordOfTheRings
{
    public class AShadowOfThePastNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "A Shadow of the Past Nightmare";
            Abbreviation = "ASotPN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2062;

            Cards.Add(new LotRCard()
            {
                Title = "A Shadow of the Past Nightmare",
                Id = "28724329-65BE-4799-A3E8-4A6FD4608748",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing Nightmare mode.

Forced: When stage 3A is revealed, if Khamûl the ~Easterling is not in play, the first player searches the encounter deck, discard pile, and victory display for Khamûl the ~Easterling and adds it to the staging area. Shuffle the encounter deck.",
                FlavorText = "\"I do not know for what reason the Enemy is purusing you,\" answered Gildor; \"but I perceive that he is - strange indeed though that seems to me. And I warn you that peril is now both before you and behind you, and upon either side.\" -The Fellowship of the Ring",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for the A ~Shadow of the Past scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

3x Evil Crow
1x Woody End
1x Bamfurlong
1x Stock-brook
3x Green Hill Country
3x Pathless Country
2x Rode Like a Gale

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard A ~Shadow of the Past encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = "A Shadow of the Past Nightmare",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Helge_C_Balzer
            });
            addCard(LotRCard.Enemy("Khamûl the Easterling", "53468A89-8BF6-4252-8B39-F525E30011EC", "A Shadow of the Past Nightmare", 40, 5, 6, 4, 8)
                .WithUnique()
                .WithTraits("Nazgûl.")
                .WithText("Cannot have non-Morgul attachments.\r\nKhamûl the ~Easterling gets -30 engagement cost while The One ~Ring is exhausted.\r\nForced: At the beginning of the refresh phase, the engaged player makes a Hide 2 test. If the engaged player fails the hide test, Khamûl the ~Easterling makes an immediate attack.")
                .WithInfo(2, 1, Artist.Smirtouille));
            Cards.Add(LotRCard.Enemy("Dark Horseman", "885855BB-4B46-4C1A-B96B-5D594D81EAFC", "A Shadow of the Past Nightmare", 25, 3, 3, 4, 6)
                .WithTraits("Nazgûl.")
                .WithKeywords("Peril.", "Hide 2.")
                .WithTextLine("Peril. Hide 2.")
                .WithTextLine("Cannot have non-Morgul attachments.\r\nWhile ~Dark Horseman is engaged with you, characters you control get -1 Willpower during Hide tests.")
                .WithTemplate("<p class='main-text'>{keyword:Peril.} {keyword:Hide 2.}</p><p class='main-text'>Cannot have non-{trait:Morgul.@Morgul} attachments.</p><p class='main-text'>While {self} is engaged with you, characters you control get -1 {Willpower} during Hide tests.</p><p class='flavor-text'>&ldquo;There&apos;s been a strange customer asking for Mr. Baggins of Bag End...&rdquo;<br>&ndash;The Gaffer, The Fellowship of the Ring</p>")
                .WithFlavor("\"There's been a strange customer asking for Mr. Baggins of Bag End...\" -THe Gaffer, The Fellowship of the Ring")
                .WithInfo(3, 2, Artist.Helge_C_Balzer));
            Cards.Add(LotRCard.Location("Eastfarthing", "546980BE-9E0F-46AB-ACD7-11658E7CAAFF", "A Shadow of the Past Nightmare", 2, 9)
                .WithTraits("Shire.")
                .WithText("Eastfarthing gets +2 Threat for each resource token on it.\r\nForced: After a player fails a Hide test, place 1 resource token here.")
                .WithFlavor("After a while they plunged into a deeply cloven track between tall trees that rustled their dry leaves in the night. -The Fellowship of the Ring")
                .WithInfo(4, 3, Artist.Katy_Grierson));
            Cards.Add(LotRCard.Location("Green-Hill Country", "8E2CA23F-AB7A-49B7-BE97-B4D39DBE4239", "A Shadow of the Past Nightmare", 3, 4)
                .WithTraits("Forest.")
                .WithText("While Green-Hill Country is in the staging area, add 1 to each Hide X value.\r\nTravel: The first player makes a Hide 1 test.")
                .WithShadow("Shadow: After this attack, attacking enemy engages the next player then makes an immediate attack.")
                .WithInfo(5, 3, Artist.Jake_Bullock));
            Cards.Add(LotRCard.Location("Stock Woods", "361033E6-C8D0-476C-AB89-6748AB56D5EF", "A Shadow of the Past Nightmare", 4, 5)
                .WithTraits("Forest.")
                .WithText("While Stock Woods is in the staging area, players cannot commit more than 2 characters to a Hide test.\r\nTravel: The first player makes a Hide 1 test.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack (+3 Attack instead if you have failed a Hide test this round).")
                .WithInfo(6, 3, Artist.Dimitri_Bielak));
            addTreachery("In the Name of Mordor!", "A Shadow of the Past Nightmare")
                .WithTraits("Mordor.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Attach to the current quest. (Counts as a Condition attachment with the text: \"Forced: After a player fails a Hide test, he discards a random card from his hand.\")")
                .WithInfo(7, 2, Artist.Piya_Wannachaiwong);
            addTreachery("Followed by Shadows", "A Shadow of the Past Nightmare")
                .WithTextLine("When Revealed: Starting with the first player, each player makes a Hide 2 test. Each player who fails this Hide test raises his threat by 5.")
                .WithShadow("Shadow: If the defending player has failed a Hide test this round, this attack is considered undefended.")
                .WithInfo(8, 3, Artist.Helge_C_Balzer);
            addTreachery("Sniffing and Hissing", "A Shadow of the Past Nightmare")
                .WithKeywords("Doomed 2.")
                .WithTextLine("Doomed 2.")
                .WithTextLine("When Revealed: The first player must either exhaust the One Ring and reveal an encounter card, or make a Hide 3 test.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack. If this attack destroys a character, raise your threat by 3.")
                .WithInfo(9, 2, Artist.Oleg_Saakyan);
        }
    }
}
