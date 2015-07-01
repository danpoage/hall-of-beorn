using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheWastesOfEriador : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Wastes of Eriador";
            Abbreviation = "TWoE";
            Number = 30;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Angmar Awakened";

            Cards.Add(Card.Hero("Merry", "E4DD7F3E-0CD2-4330-A7D4-80487202C437", Sphere.Spirit, 6, 2, 1, 1, 2)
                .WithTraits("Hobbit.")
                .WithText("Response: After an enemy is revealed from the top of the encounter deck, exhaust Merry to reduce your threat by that enemy's Threat.")
                .WithFlavor("\"We have come a long way with you and been through some stiff times. We want to go on.\" —The Fellowship of the Ring")
                .WithTemplate("<b>Response:</b> After an enemy is revealed from the top of the encounter deck, exhaust {self} to reduce your threat by that enemy's {Threat}.</p><p style='text-align:center'><i>&quot;We have come a long way with you and been through some stiff times. We want to go on.&quot;<br/>&ndash;The Fellowship of the Ring</i></p>")
                .WithInfo(1, 1, Artist.Romana_Kendelic));
        }
    }
}