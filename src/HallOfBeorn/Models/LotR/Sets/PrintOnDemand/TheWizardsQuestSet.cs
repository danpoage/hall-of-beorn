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

            addHero("Glorfindel", 12, Sphere.Lore, 3, 3, 1, 5)
                .WithTraits("Noble.", "Noldor.", "Warrior.")
                .WithText("Action: Pay 1 resource from Glorfindel's pool to heal 1 damage on any character. (Limit once per round.)")
                .WithFlavor("\"You saw him for a moment as he is upon the other side: one of the mighty of the firstborn.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithTemplate("<p class='main-text'><b>Action:</b> Pay 1 resource from {self}'s pool to heal 1 damage on any character. (Limit once per round.)</p>")
                .WithYear(2018)
                .WithInfo(11, 1, Artist.Audrey_Hotte);
        }
    }
}