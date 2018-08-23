using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.PrintOnDemand
{
    public class TheWizardsQuestSet : CardSet
    {
        private const string setName = "The Wizard's Quest";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TWQ";
            SetType = Models.SetType.Fellowship_Deck;
            Cycle = "GenCon";
            Number = 3009;

            IsSpoiler = true;

            addTreachery("Under the Shadow", string.Empty)
                .WithSetNumberAndCost(18, 1)
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Attach to the main quest. (Counts as a condition attachment with the text: \"Each player cannot play more than 1 card each phase.\")")
                .WithInfo(23, 0, Artist.Igor_Kieryluk);

            addLocation("Twilight Hall", string.Empty, 0, 6)
                .WithSetNumberAndCost(17, 3)
                .WithUnique()
                .WithTraits("Forest.")
                .WithText("Cannot have attachments.\r\nTwilight Hall gets +1 Threat for each character controlled by the first player.\r\nForced: When Twilight Hall is explored, reveal 1 encounter card per player.")
                .WithInfo(25, 0, Artist.Katy_Grierson);
            addLocation("Watched Path", string.Empty, 3, 1)
                .WithSetNumberAndCost(19, 0)
                .WithTraits("Forest.")
                .WithText("Forced: When Watched Path is explored, discard the top card of the encounter deck. If the discarded card is an enemy, add it to the staging area.")
                .WithInfo(26, 0, Artist.Jose_Vega);

            addLocation("The Wargs' Glade", string.Empty, 3, 5)
                .WithSetNumberAndCost(28, 2)
                .WithUnique()
                .WithTraits("Forest.")
                .WithText("While The Wargs' Glade is in the staging area, the first Warg enemy revealed each round gains surge.\r\nForced: When The Wargs' Glade is explored, the opposing team searches the encounter deck and discard pile for a non-unique Warg enemy and adds it to the staging area. Shuffle the encounter deck.")
                .WithInfo(25, 0, Artist.Michael_Rasmussen);

            addTreachery("Treacherous Fog", string.Empty)
                .WithSetNumberAndCost(27, 1)
                .WithTraits("Weather.")
                .WithText("When Revealed: Until the end of the phase, each enemy and location in the staging area gets +2 Threat.")
                .WithShadow("Shadow: Each enemy engaged with you gets +1 Attack and +1 Defense until the end of the phase.")
                .WithInfo(31, 0, Artist.David_Lecossu);
            addTreachery("Weighed Down", string.Empty)
                .WithSetNumberAndCost(28, 1)
                .WithText("When Revealed: Exhaust each character with an attachment. If no character is exhausted this way, Weighed Down gains surge.")
                .WithShadow("Shadow: Discard an attachment from the defending character.")
                .WithInfo(34, 0, Artist.Unknown);
            addLocation("Troll Cave", string.Empty, 3, 5)
                .WithSetNumberAndCost(22, 1)
                .WithTraits("Forest.", "Cave.")
                .WithText("Response: After the players travel to Troll Cave, each player draws 1 card.\r\nTravel: The opposing team searches the top 5 cards of the encounter deck for a Hill Troll and adds it to the staging area, if able. Shuffle the encounter deck.")
                .WithInfo(35, 0, Artist.Unknown);

            addEnemy("Venomous Spider", string.Empty, 28, 2, 3, 2, 4)
                .WithSetNumberAndCost(26, 1)
                .WithTraits("Spider.")
                .WithText("Forced: After Venomous Spider attacks and damages a character, that character cannot ready until the end of the round.")
                .WithShadow("Shadow: Defending character cannot ready until the end of the round.")
                .WithInfo(36, 0, Artist.Florian_Devos);

            addHero("Glorfindel", 12, Sphere.Lore, 3, 3, 1, 5)
                .WithTraits("Noble.", "Noldor.", "Warrior.")
                .WithText("Action: Pay 1 resource from Glorfindel's pool to heal 1 damage on any character. (Limit once per round.)")
                .WithFlavor("\"You saw him for a moment as he is upon the other side: one of the mighty of the firstborn.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithTemplate("<p class='main-text'><b>Action:</b> Pay 1 resource from {self}'s pool to heal 1 damage on any character. (Limit once per round.)</p>")
                .WithYear(2018)
                .WithInfo(211, 1, Artist.Audrey_Hotte);
        }
    }
}