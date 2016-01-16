using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheVoiceOfIsengardNightmareProduct : Product
    {
        public TheVoiceOfIsengardNightmareProduct()
            : base("The Voice of Isengard Nightmare Decks", "MEN28", ImageType.Jpg, new DateTime(2015, 7, 17))
        {
            IsPremier = true;
            IsNewSubGroup = true;
            AddCardSet(CardSet.TheFordsOfIsenNightmare);
            AddCardSet(CardSet.ToCatchAnOrcNightmare);
            AddCardSet(CardSet.IntoFangornNightmare);
        }
    }
}