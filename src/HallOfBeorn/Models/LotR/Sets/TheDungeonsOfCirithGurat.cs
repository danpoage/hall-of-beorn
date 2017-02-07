using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheDungeonsOfCirithGurat : CardSet
    {
        private const string setName = "The Dungeons of Cirith Gurat";

        protected override void Initialize()
        {
            Name = "The Dungeons of Cirith Gurat";
            Abbreviation = "DoCG";
            Number = 47;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            addCard(LotRCard.Attachment("Legacy Blade", string.Empty, Sphere.Lore, 0)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a hero.\r\nAttached hero gets +1 Attack for each side quest in the victory display. (Limit +3 Attack.)")
                .WithFlavor("...glad would he have been to know its fate who wrought it slowly long ago in the North-kingdom when the Dúnedain were young...\r\n-The Return of the King")
                .WithInfo(117, 3, Artist.Lucas_Durham));
            addCard(LotRCard.Event("Open the Armory", string.Empty, Sphere.Neutral, 1)
                .WithText("Action: Search the top 10 cards of your deck for a Weapon or Armor attachment and add it to your hand. Shuffle your deck.\r\nValour Action: Search the top 5 cards of your deck for a Weapon or Armor attachment and put it into play. Shuffle your deck.")
                .WithInfo(118, 3, Artist.Sabin_Boykinov));
        }
    }
}