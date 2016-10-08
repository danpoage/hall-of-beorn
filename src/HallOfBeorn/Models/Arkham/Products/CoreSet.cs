using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham.Products
{
    public class CoreSet : ArkhamProduct
    {
        public CoreSet()
            : base("Core Set", "Core", 1, new DateTime(2016, 10, 31))
        {
        }

        protected override void init()
        {
            addCard(ArkhamCard.Investigator("Roland Banks", "The Fed", ArkhamClass.Guardian, 9, 5)
                .WithWillpower(3).WithIntellect(3).WithCombat(4).WithAgility(2)
                .WithTraits("Agency.", "Investigator.")
                .WithText("Response - After you defeat an enemy: Discover 1 clue at your location. (Limit once per round.)\r\nEldritch Effect: +1 for each clue on your location.")
                .WithFlavor("Everything by the book: every \"i\" dotted, every \"t\" crossed. It had worked, until now")
                .WithInfo(1, 1, Artist.Magali_Villeneuve));

            addCard(ArkhamCard.Investigator("Agnes Baker", "The Waitress", ArkhamClass.Mystic, 6, 8)
                .WithWillpower(5).WithIntellect(2).WithCombat(2).WithAgility(3)
                .WithTraits("Sorcerer.")
                .WithText("Response - After 1 or more horror is placed on Agnes Baker: Deal 1 damage to an enemy at your location. (Limit once per phase.)\r\nEldritch Effect: +1 for each horror on Agnes Baker.")
                .WithFlavor("\"I remember another life, one of sorcery and conquest.\"")
                .WithInfo(4, 1, Artist.Magali_Villeneuve));

            addCard(ArkhamCard.Asset("Roland's .38 Special", ArkhamClass.Guardian, ArkhamCardCost.Three, ArkhamItemSlot.One_Hand)
                .WithUnique()
                .WithTraits("Item.", "Weapon.", "Firearm.")
                .WithCombat(0).WithAgility(0).WithWild(0)
                .WithText("Roland Banks deck only.\r\nUses (4 ammo).\r\nAction - Spend 1 ammo: Fight. You get +1 Combat for this attack (if there are 1 or more clues on this location, you get +3 combat instead). This attack deals +1 damage.")
                .WithInfo(6, 1, Artist.Tiziano_Baracchi));

        }
    }
}