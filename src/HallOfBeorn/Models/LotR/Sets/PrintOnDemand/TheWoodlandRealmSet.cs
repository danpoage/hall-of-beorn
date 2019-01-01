using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.PrintOnDemand
{
    public class TheWoodlandRealmSet : CardSet
    {
        private const string setName = "The Woodland Realm";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TWR";
            SetType = Models.SetType.Fellowship_Deck;
            Cycle = "GenCon";
            Number = 3010;

            addHero("Éowyn", 9, Sphere.Spirit, 4, 1, 1, 3)
                .WithTraits("Noble.", "Rohan.")
                .WithText("Action: Discard 1 card from your hand to give Éowyn +1 Willpower until the end of the phase. This effect may be triggered by each player once each round.")
                .WithInfo(7, 1, Artist.Audrey_Hotte);

            addQuest("Captured by Spiders", setName, 1, 'B', 10)
                .WithFlavor("You are traveling through Mirkwood forest in search of The Elvenking's hidden halls, when you hear a desperate cry for help from a dark path of woods.")
                .WithText("Setup: Add Spider Den to the staging area. The opposing team searches the encounter deck for one different 0 cost enemy or 0 cost location per player and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("The cries are those of an Elf who has been captured within a spider den. You must rescue him!")
                .WithOppositeText("Forced: When Spider Den is explored, flip it over and put Mendor into play under the first player's control, ready.\r\nThis stage cannot be defeated unless the first player controls Mendor.")
                .WithInfo(1, 1, Artist.Ben_Zweifel);
            addQuest("A Chosen Path", setName, 3, 'S', 20)
                .WithOppositeTitle("Lost in the Dark")
                .WithFlavor("The Elf you rescued is Mendor, a servant of the Elvenking. He offers to guide you to the hidden kingdom, yet even Mendor struggles to keep his way as night settles over Mirkwood.")
                .WithText("When Revealed: The opposing teach searches the top 5 cards of the encounter deck for a card with cost 1 or less (2 or less if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithOppositeText("The first treachery revealed each round gains Doomed 1 and its 'when revealed' effects cannot be canceled.\r\nForced: After characters are committed to the quest, no more than 5 progress can be placed here this round (10 progress instead if Mendor is committed to the quest).")
                .WithBackArtist(Artist.Adam_Lane)
                .WithInfo(2, 1, Artist.Yoann_Boissonnet);
            addQuest("A Chosen Path", setName, 2, 'B', 20)
                .WithOppositeTitle("\"Don't Leave the Path\"")
                .WithBackArtist(Artist.Ben_Zweifel)
                .WithInfo(4, 1, Artist.Yoann_Boissonnet);
        }
    }
}