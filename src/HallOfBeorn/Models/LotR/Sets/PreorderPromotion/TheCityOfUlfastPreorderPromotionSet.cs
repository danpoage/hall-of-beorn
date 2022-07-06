using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.PreorderPromotion
{
    public class TheCityOfUlfastPreorderPromotionSet
        : CardSet
    {
        public const string setName = "The City of Ulfast Preorder Promotion";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TCoU-PRM";
            Number = 2;
            SetType = Models.SetType.Preorder_Promotion;
            Cycle = "Vengeance of Mordor";

            addHero("Lothíriel", 8, Sphere.Spirit, 3, 1, 1, 3)
                .WithTraits("Gondor.", "Noble.")
                .WithTextLine("If Éomer is in play, Lothíriel gains the Rohan trait.")
                .WithTextLine("Response: After Lothíriel commits to a quest, choose an ally in your hand. If that ally shares a Trait with her, put that ally into play exhausted and committed to the quest. At the end of the phase, if that ally is still in play, shuffle it into your deck.")
                .WithPromotion()
                .WithInfo(27, 1, Artist.Alvaro_Calvo_Escudero);
            addAlly("Angbor the Fearless", 2, Sphere.Leadership, true, 2, 1, 0, 2)
                .WithTraits("Gondor.", "Warrior.")
                .WithTextLine("While your threat is 40 or higher, Angbor the Fearless gets +2 Attack and does not exhaust to quest.")
                .WithFlavorLine("\"Four thousands I sent marching from Pelargir through Lossarnach two days ago; and Angbor the fearless rides before them.\"")
                .WithFlavorLine("-Aragorn, The Return of the King")
                .WithPromotion()
                .WithInfo(28, 1, Artist.Vilius_Petrauskas);
            addEvent("Host of Galadhrim", 4, Sphere.Neutral)
                .WithTextLine("Planning Action: Return each Silvan ally you control to your hand. Then, play each of those allies from your hand one at a time at no cost.")
                .WithFlavorLine("Celeborn came forth and led the host of Lórien...")
                .WithFlavorLine("-The Return of the King")
                .WithPromotion()
                .WithInfo(36, 1, Artist.Leanna_Crossan);
        }
    }
}
