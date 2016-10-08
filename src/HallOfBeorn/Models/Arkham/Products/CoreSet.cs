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
            addCard(Investigator.New("Roland Banks", "The Fed", ArkhamClass.Guardian, 9, 5)
                .WithWillpower(3).WithIntellect(3).WithCombat(4).WithAgility(2)
                .WithTraits("Agency.", "Investigator.")
                .WithText("Response - After you defeat an enemy: Discover 1 clue at your location. (Limit once per round.)\r\nEldritch Effect: +1 for each clue on your location.")
                .WithFlavor("Everything by the book: every \"i\" dotted, every \"t\" crossed. It had worked, until now")
                .WithInfo(1, 1, "Magali Villeneuve"));

            addCard(Investigator.New("Agnes Baker", "The Waitress", ArkhamClass.Mystic, 6, 8)
                .WithWillpower(5).WithIntellect(2).WithCombat(2).WithAgility(3)
                .WithTraits("Sorcerer.")
                .WithText("Response - After 1 or more horror is placed on Agnes Baker: Deal 1 damage to an enemy at your location. (Limit once per phase.)\r\nEldritch Effect: +1 for each horror on Agnes Baker.")
                .WithFlavor("\"I remember another life, one of sorcery and conquest.\"")
                .WithInfo(4, 1, "Magali Villeneuve"));
        }
    }
}