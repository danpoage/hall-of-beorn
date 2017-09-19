using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.PrintOnDemand
{
    public class AssaultOnDolGuldurSet : CardSet
    {
        private const string setName = "Assault on Dol Guldur";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "AoDG";
            SetType = Models.SetType.Fellowship_Deck;
            Cycle = "GenCon";
            Number = 3008;

            addCard(LotRCard.Hero("Celeborn", string.Empty, Sphere.Leadership, 11, 3, 2, 2, 4)
                .WithTraits("Silvan.", "Noble.")
                .WithText("Response: After a Silvan ally enters play, that ally gets +1 Willpower, +1 Attack, and +1 Defense until the end of the round.")
                .WithInfo(1, 1, Artist.Drazenka_Kimpel));
        }
    }
}