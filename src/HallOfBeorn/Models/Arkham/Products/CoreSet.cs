using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham.Products
{
    public class CoreSet : ArkhamProduct
    {
        public CoreSet()
            : base("Core Set", "Core", "AHC01", 1, new DateTime(2016, 10, 31))
        {
        }

        protected override void init()
        {
            addCard(ArkhamCard.Investigator("Roland Banks", "The Fed", ClassSymbol.Guardian, 9, 5)
                .WithSkills(3, 3, 4, 2)
                .WithTraits("Agency.", "Detective.")
                .WithFrontText("Response - After you defeat an enemy: Discover 1 clue at your location. (Limit once per round.)\r\nElder Sign Effect: +1 for each clue on your location.")
                .WithFrontFlavor("Everything by the book: every \"i\" dotted, every \"t\" crossed. It had worked, until now")
                .WithInfo(1, 1, Artist.Magali_Villeneuve));

            addCard(ArkhamCard.Investigator("Agnes Baker", "The Waitress", ClassSymbol.Mystic, 6, 8)
                .WithSkills(5, 2, 2, 3)
                .WithTraits("Sorcerer.")
                .WithFrontText("Response - After 1 or more horror is placed on Agnes Baker: Deal 1 damage to an enemy at your location. (Limit once per phase.)\r\nElder Sign Effect: +1 for each horror on Agnes Baker.")
                .WithFrontFlavor("\"I remember another life, one of sorcery and conquest.\"")
                .WithInfo(4, 1, Artist.Magali_Villeneuve));

            addCard(ArkhamCard.Asset("Roland's .38 Special", ClassSymbol.Guardian, Number.Three, AssetSlot.One_Hand)
                .WithUnique()
                .WithTraits("Item.", "Weapon.", "Firearm.")
                .WithSkillTestIcons(SkillIcon.Combat, SkillIcon.Agility, SkillIcon.Wild)
                .WithFrontText("Roland Banks deck only.\r\nUses (4 ammo).\r\nAction - Spend 1 ammo: Fight. You get +1 Combat for this attack (if there are 1 or more clues on this location, you get +3 combat instead). This attack deals +1 damage.")
                .WithInfo(6, 1, Artist.Tiziano_Baracchi));

            addCard(ArkhamCard.Event("Lucky!", ClassSymbol.Survivor, Number.One, Level.Zero)
                .WithTraits("Fortune.")
                .WithKeywords("Fast.")
                .WithFrontText("Fast. Play when you would fail a skill test. Get +2 to your skill value for that test.")
                .WithInfo(80, 1, Artist.David_A_Nash));
            addCard(ArkhamCard.Event("Lucky!", ClassSymbol.Survivor, Number.One, Level.Two)
                .WithTraits("Fortune.")
                .WithKeywords("Fast.")
                .WithFrontText("Fast. Play when you would fail a skill test. Get +2 to your skill value for that test. Draw 1 card.")
                .WithInfo(84, 1, Artist.David_A_Nash));

            addCard(ArkhamCard.Location("Attic", ConnectionSymbol.Attic, Shroud.Of(1), ClueValue.Of(2).PerInvestigator())
                .WithVictoryPoints(1)
                .WithFrontFlavor("The smell of rotten meat assaults your nostrils as you approach the attic stairs.")
                .WithBackText("Forced - After you enter the Attic: Take 1 horror.")
                .WithConnections(ConnectionSymbol.Hallway)
                .WithInfo(113, 1, Artist.Yoann_Boissonnet));
            addCard(ArkhamCard.Location("Cellar", ConnectionSymbol.Cellar, Shroud.Of(4), ClueValue.Of(2).PerInvestigator())
                .WithVictoryPoints(1)
                .WithFrontFlavor("The stairs leading down to your cellar are slick, and they glisten with a thin layer of ice...")
                .WithBackText("Forced - After you enter the Cellar: Take 1 damage.")
                .WithBackFlavor("Your cellar seems to have been replaced with an underground network of icy tunnels and caverns.\r\nThe cold chills you to the core.")
                .WithConnections(ConnectionSymbol.Hallway)
                .WithInfo(114, 1, Artist.Yoann_Boissonnet));
        }
    }
}