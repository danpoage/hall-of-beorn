using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheScouringOfTheShire
{
    public class TheScouringOfTheShireCardSet
        : CardSet
    {
        private const string setName = "The Scouring of the Shire";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TSotS";
            Number = 10008;
            SetType = Models.SetType.A_Long_extended_Party;

            addHero("Frodo Baggins", 7, Sphere.Leadership, 2, 1, 2, 2)
                .WithTraits("Hobbit.")
                .WithTextLine("Response: After Frodo Baggins commits to the quest, spend 1 resource from his resource pool to ready another unique character committed to the quest. If you quest successfully this phase, reduce your threat by 1.")
                .WithInfo(2, 1, Artist.Lukasz_Jaskolski);
        }
    }
}