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

            addCard(ArkhamCard.Event("Lucky!", ClassSymbol.Survivor, Number.One, 0)
                .WithTraits("Fortune.")
                .WithKeywords("Fast.")
                .WithFrontText("Fast. Play when you would fail a skill test. Get +2 to your skill value for that test.")
                .WithInfo(80, 1, Artist.David_A_Nash));
            addCard(ArkhamCard.Event("Lucky!", ClassSymbol.Survivor, Number.One, 2)
                .WithTraits("Fortune.")
                .WithKeywords("Fast.")
                .WithFrontText("Fast. Play when you would fail a skill test. Get +2 to your skill value for that test. Draw 1 card.")
                .WithInfo(84, 1, Artist.David_A_Nash));

            addCard(ArkhamCard.Event("Emergency Cache", ClassSymbol.None, Number.Of(0), 0)
                .WithTraits("Supply.")
                .WithFrontText("Gain 3 resources.")
                .WithFrontFlavor("You can never be too prepared.")
                .WithInfo(88, 1, Artist.Vincent_Dutrait));

            addCard(ArkhamCard.Agenda("What's Going On?!", "A Lapse in Time", 1, Number.Of(3))
                .WithFrontFlavor("It is late at night, You are holed up in your study, researching the bloody disappearances that have been taking place in the region. A few hours into your research, you hear the sound of strange chanting coming from your parlor down the hall. At the same time, you hear dirt churning, as if something were digging beneath the floor.")
                .WithBackFlavor("Your house continues to change before your very eyes. The walls have decayed, and the ground in many rooms has turned to dirt. It is almost as if you have been transported somewhere else entirely, although every now and again you recognize elements of your former home.")
                .WithBackText("The lead investigator must decide (choose one): Either each investigator discards 1 card at random from his or her hand, or the lead investigator takes 2 horror.")
                .WithInfo(105, 1, Artist.Mark_Molnar));

            addCard(ArkhamCard.Act("Trapped", "The Door on the Floor", 1, Number.Of(2).PerInvestigator())
                .WithFrontFlavor("As you leap to investigate, the door to your study vanishes before you eyes, leaving behind only a solid wall. You're trapped inside your study until you can find another way out.")
                .WithBackFlavor("You notice that the edges of your newly purchased rug are tattered and mud-stained. Finding this odd, you shift the furniture aside and pull back the rug. To your surprise, you see the door leading out of your study. You slowly turn the knob, and the door swings open, revealing your hallway below.\r\nYou jump through the doorway, landing on your feet on soft dirt. The door to the study slams shut above you. The smell of burning wood fills the narrow hall, intermingled with the scent of rot and decay.")
                .WithBackText("Put into play the set-aside Hallway, Cellar, Attic and Parlor.\r\nDiscard each enemy in the Study.\r\nPlace each investigator in the Hallway.\r\nRemove the Study from the game.")
                .WithInfo(108, 1, Artist.Jose_Vega));

            addCard(ArkhamCard.Location("Study", ConnectionSymbol.Study, Shroud.Of(2), ClueValue.Of(2).PerInvestigator())
                .WithFrontFlavor("You've been investigating the strange events occurring in Arkham for several years now. Your desk is covered in newspaper articles, police reports, and witness accounts.")
                .WithBackFlavor("The door to your study has vanished")
                .WithInfo(111, 1, Artist.Yoann_Boissonnet));
            addCard(ArkhamCard.Location("Hallway", ConnectionSymbol.Hallway, Shroud.Of(1), ClueValue.Of(0))
                .WithFrontFlavor("A moment of panic and disorientation strikes as you land upon the floor of the hallway. The world spins, as if turned on its head.")
                .WithConnections(ConnectionSymbol.Attic, ConnectionSymbol.Cellar, ConnectionSymbol.Parlor)
                .WithBackFlavor("The walls of your house are splattered with mud, and your hardwood floor is gone, replaced with a dirt path.")
                .WithInfo(112, 1, Artist.Yoann_Boissonnet));
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
            addCard(ArkhamCard.Location("Parlor", ConnectionSymbol.Parlor, Shroud.Of(2), ClueValue.Of(0))
                .WithFrontText("The entrance to the Parlor is blocked by a darkly glowing unfathomable barrier. You cannot move into the Parlor.")
                .WithFrontFlavor("You're unsure what would happen if you tried to corss the threshold of the strange barrier, but based on its extreme heat, you sure as hell don't want to try.")
                .WithBackText("Action: Resign. \"This is too much for me!\" You run out the front door, fleeing in panic.\r\nWhile Lita Chantler is not controlled by a player, she gains: \"Action: Parley. Test Intellect (4). If you succeed, take contro of Lita Chantler.")
                .WithConnections(ConnectionSymbol.Hallway)
                .WithInfo(115, 1, Artist.Yoann_Boissonnet));

            addCard(ArkhamCard.Enemy("Ghoul Priest", Number.Of(4), Number.Of(5).PerInvestigator(), Number.Of(4), Number.Of(2), Number.Of(2))
                .WithTraits("Humanoid.", "Monster.", "Ghoul.", "Elite.")
                .WithKeywords("Hunter.", "Retaliate.")
                .WithFrontText("Prey - Highest Combat.")
                .WithFrontFlavor("A figure in red robes wearing a bone mask. It gibbers and snarls before leaping to attack.")
                .WithVictoryPoints(2)
                .WithInfo(116, 1, Artist.Chun_Lo));
        }
    }
}