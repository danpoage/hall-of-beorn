using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheSiegeOfAnnuminas : CardSet
    {
        private const string setName = "The Siege of Annúminas";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TSoA";
            SetType = Models.SetType.Fellowship_Deck;
            Cycle = "GenCon";
            Number = 3007;

            Cards.Add(Card.Hero("Boromir", "", Sphere.Tactics, 11, 1, 3, 2, 5)
                .WithTraits("Gondor.", "Noble.", "Warrior.")
                .WithText("Action: Raise your threat by 1 to ready Boromir.\r\nAction: Discard Boromir to deal 2 damage to each enemy engaged with a single player.")
                .WithInfo(95, 1, Artist.Unknown));
        }
    }
}