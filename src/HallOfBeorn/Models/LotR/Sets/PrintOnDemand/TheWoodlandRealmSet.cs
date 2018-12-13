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
        }
    }
}