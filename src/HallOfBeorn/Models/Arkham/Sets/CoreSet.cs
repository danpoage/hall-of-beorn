using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham.Sets
{
    public class CoreSet : ArkhamCardSet
    {
        public CoreSet()
            : base("Core Set")
        {
        }

        protected override void Initialize()
        {
            AddCard(Investigator.New("Roland Banks", "The Fed", ArkhamClass.Guardian, 9, 5)
                .WithWillpower(3).WithIntellect(3).WithCombat(4).WithAgility(2)
                .WithTraits("Agency.", "Investigator.")
                .WithText("Response - After you defeat an enemy: Discover 1 clue at your location. (Limit once per round.)\r\nEldritch Effect: +1 for each clue on your location.")
                .WithFlavor("Everything by the book: every \"i\" dotted, every \"t\" crossed. It had worked, until now")
                .WithInfo(1, 1, "Magali Villeneuve"));
        }
    }
}