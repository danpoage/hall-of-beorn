using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheCityOfCorsairs : CardSet
    {
        private const string setName = "The City of Corsairs";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TCoC";
            Number = 40;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dream-chaser";

            Cards.Add(Card.Hero("Prince Imrahil", "", Sphere.Tactics, 11, 2, 3, 2, 4)
                .WithTraits("Gondor.", "Noble.", "Warrior.")
                .WithText("Combat Action: Spend 1 resource from Prince Imrahil's resource pool to search the top 5 cards of your deck for an ally who shares at least 1 Trait with him, and put that ally into play. Shuffle your deck. At the end of the phase, if that ally is still in play, shuffle it into your deck. (Limit once per round.)")
                .WithInfo(138, 1, Artist.Unknown));

            Cards.Add(Card.Attachment("Prince of Dol Amroth", "", Sphere.Neutral, 3)
                .WithUnique()
                .WithTraits("Title.")
                .WithText("Attach to Prince Imrahil.\r\nPrice Imrahil gains the Outlands trait.\r\nWhile you control Outlands allies that belong to 4 different spheres, add 1 additional resource to Prince Imrahil's resource pool when you collect resources during the resource phase (if Prince Imrahil is a hero).")
                .WithInfo(146, 3, Artist.Drazenka_Kimpel));
        }
    }
}