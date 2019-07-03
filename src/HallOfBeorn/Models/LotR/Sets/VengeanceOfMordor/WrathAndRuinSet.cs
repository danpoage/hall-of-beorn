using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.VengeanceOfMordor
{
    public class WrathAndRuinSet : CardSet
    {
        private const string setName = "Wrath and Ruin";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "WaR";
            Number = 57;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Vengeance of Mordor";

            IsSpoiler = true;

            addEvent("Tom Bombadillo!", 2, Sphere.Lore)
                .WithTraits("Song.")
                .WithText("Play only if you control a Hobbit hero. You cannot play this card if there is a copy of Tom Bombadillo! in the victory display.\r\nPlanning Action: Add Tom Bombadillo the the victory display to shuffle a set-aside copy of Tom Bombadil into the encounter deck.")
                .WithInfo(5, 3, Artist.David_Keen);
            addAlly("Cautious Halfling", 2, Sphere.Lore, false, 1, 0, 1, 2)
                .WithTraits("Hobbit.")
                .WithText("Response: After Cautious Halfling enters play, look at the top card of the encounter deck. If that card is not an enemy, draw a card.")
                .WithFlavor("\"I thought I had been both careful and clever.\"\r\n-Frodo, The Fellowship of the Ring")
                .WithInfo(6, 3, Artist.Sara_Biddle);
            addAlly("Tom Bombadil", Card.VALUE_NA, Sphere.Neutral, true, 3, 3, 3, 6)
                .WithTraits("Legend.")
                .WithKeywords("Encounter.")
                .WithText("When Revealed: Choose a player. That player gains control of Tom Bombadil, ready and committed to the quest. At the end of the round, remove Tom Bombadil and a copy of Tom Bombadillo! in the victory display from the game. This effect cannot be cancelled.")
                .WithTemplate("<p class='main-text'>{keyword:Encounter.}</p><p class='main-text'><b>When Revealed:</b> Choose a player. That player gains control of Tom Bombadil, ready and committed to the quest. At the end of the round, remove {self} and a copy of {title:Tom_Bombadillo!@Tom Bombadillo!} in the victory display from the game. This effect cannot be cancelled.</p>")
                .WithInfo(10, 3, Artist.Borja_Pindado);
        }
    }
}