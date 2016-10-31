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
                .WithFrontText("Reaction - After you defeat an enemy: Discover 1 clue at your location. (Limit once per round.)\r\nElder Sign Effect: +1 for each clue on your location.")
                .WithFrontFlavor("Everything by the book: every \"i\" dotted, every \"t\" crossed. It had worked, until now")
                .WithBackText("Deck Size: 30.\r\nDeckbuiling Options: Guardian cards level 0-5, Seeker cards level 0-2, Neutral cards level 0-5.\r\nDeckbuiling Requirements (do not count towards deck size): Roland's .38 Special, Cover Up, 1 random basic weakness.")
                .WithInfo(1, 1, Artist.Magali_Villeneuve));
            addCard(ArkhamCard.Investigator("Daisy Walker", "The Librarian", ClassSymbol.Seeker, 5, 9)
                .WithSkills(3, 5, 2, 2)
                .WithTraits("Miskatonic.")
                .WithFrontText("You may take an additional action during your turn, which can only be used on Tome Action abilities.\r\nElder Sign effect: +0. If you succeed, draw 1 card for each Tome you control.")
                .WithFrontFlavor("\"I know of books so powerful, they can rewrite reality.\"")
                .WithBackText("Deck Size: 30.\r\nDeckbuilding Options: Seeker cards level 0-5, Mystic cards level 0-2, Neutral cards level 0-5.\r\nDeckbuilding Requirements (do not count toward deck size): Daisy's Tote Bag, The Necronomicon (John Dee Translation), 1 random basic weakness.")
                .WithInfo(2, 1, Artist.Magali_Villeneuve));
            addCard(ArkhamCard.Investigator("\"Skids\" O'Toole", "The Ex-Con", ClassSymbol.Rogue, 8, 6)
                .WithSkills(2, 3, 3, 4)
                .WithTraits("Criminal.")
                .WithFrontText("Free Ability - During your turn, spend 2 resources: You may take an additional action this turn. (Limit once per turn.)\r\nElder Sign effect: +2. If you succeed, gain 2 resources.")
                .WithFrontFlavor("\"I didn't get out of the joint just to watch the world end.\"")
                .WithBackText("Deck Size: 30.\r\nDeckbuilding Options: Rogue cards level 0-5, Guardian cards level 0-2, Neutral cards level 0-5.\r\nDeckbuilding Requirements (do not count toward deck size): On the Lam, Hospital Debts, 1 random basic weakness.")
                .WithInfo(3, 1, Artist.Magali_Villeneuve));
            addCard(ArkhamCard.Investigator("Agnes Baker", "The Waitress", ClassSymbol.Mystic, 6, 8)
                .WithSkills(5, 2, 2, 3)
                .WithTraits("Sorcerer.")
                .WithFrontText("Reaction - After 1 or more horror is placed on Agnes Baker: Deal 1 damage to an enemy at your location. (Limit once per phase.)\r\nElder Sign Effect: +1 for each horror on Agnes Baker.")
                .WithFrontFlavor("\"I remember another life, one of sorcery and conquest.\"")
                .WithBackText("Deck Size: 30.\r\nDeckbuilding Options: Mystic cards level 0-5, Survivor cards level 0-2, Neutral cards level 0-5.\r\nDeckbuilding Requirements (do not count toward deck size): Heirloom of Hyperborea, Dark Memory, 1 random basic weakness.")
                .WithInfo(4, 1, Artist.Magali_Villeneuve));
            addCard(ArkhamCard.Investigator("Wendy Adams", "The Urchin", ClassSymbol.Survivor, 7, 7)
                .WithSkills(4, 3, 1, 4)
                .WithTraits("Drifter.")
                .WithFrontText("Reaction - When you reveal a chaos token, choose and discard 1 card from your hand: Cancal that chaos token and return it to the bag. Reveal a new chaos token. (Limit once per test/ability.)\r\nElder Sign Effect: +0. If Wendy's Amulet is in play, you automatically succeed instead.")
                .WithBackText("Deck Size: 30.\r\nDeckbuilding Options: Survivor cards level 0-5, Rogue cards level 0-2, Neutral cards level 0-5.\r\nDeckbuilding Requirements (do not count toward deck size): Wendy's Amulet, Abandoned and Alone, 1 random basic weakness.")
                .WithInfo(5, 1, Artist.Jacob_Murray));
            addCard(ArkhamCard.Asset("Roland's .38 Special", ClassSymbol.Guardian, Number.Three, AssetSlot.One_Hand)
                .WithUnique()
                .WithTraits("Item.", "Weapon.", "Firearm.")
                .WithSkillTestIcons(SkillIcon.Combat, SkillIcon.Agility, SkillIcon.Wild)
                .WithFrontText("Roland Banks deck only.\r\nUses (4 ammo).\r\nAction - Spend 1 ammo: Fight. You get +1 Combat for this attack (if there are 1 or more clues on this location, you get +3 combat instead). This attack deals +1 damage.")
                .WithInfo(6, 1, Artist.Tiziano_Baracchi));
            addCard(ArkhamCard.Treachery("Hospital Debts", ArkhamCardSubtype.Weakness)
                .WithTraits("Task.")
                .WithFrontText("Revelation - Put Hospital Debts into play in your threat area.\r\nFree Action: Move 1 resource from your resource pool to Hospital Debts. (Limit twice per round.)\r\nForced - When the game ends, if Hospital Debts has fewer than 6 resources on it: You ear 2 fewer experience for this scenario.")
                .WithInfo(11, 1, Artist.Adam_Lane));
            addCard(ArkhamCard.Asset("Heirloom of Hyperborea", ClassSymbol.None, Number.Of(3), AssetSlot.Accessory)
                .WithUnique()
                .WithSkillTestIcons(SkillIcon.Willpower, SkillIcon.Combat, SkillIcon.Wild)
                .WithTraits("Item.", "Relic.")
                .WithFrontText("Agnes Baker deck only.\r\nReaction - After you play a Spell card: Draw 1 card.")
                .WithFrontFlavor("The etchings on its surface change from day to day, shifting and moving whenever I'm not looking.")
                .WithInfo(12, 1, Artist.Dani_Hartel));
            addCard(ArkhamCard.Event("Dark Memory", ClassSymbol.None, Number.Of(2), 0)
                .WithSubtype(ArkhamCardSubtype.Weakness)
                .WithTraits("Spell.")
                .WithFrontText("Place 1 doom on the current agenda. This effect can cause the current agenda to advance.\r\nForced - If Dark Memory is in your hand at the end of your turn: Reveal it and take 2 horror.")
                .WithFrontFlavor("No...not again!")
                .WithInfo(13, 1, Artist.Falk));
            addCard(ArkhamCard.Asset("Wendy's Amulet", ClassSymbol.None, Number.Of(2), AssetSlot.Accessory)
                .WithUnique()
                .WithTraits("Item.", "Relic.")
                .WithSkillTestIcons(SkillIcon.Wild, SkillIcon.Wild)
                .WithFrontText("Wendy Adams deck only.\r\nYou may play the topmost event in your discard pile as if it were in your hand.\r\nForced - After you play an event: Place it on the bottom of your deck instead of in your discard pile.")
                .WithInfo(14, 1, Artist.Linda_Tso));
            addCard(ArkhamCard.Treachery("Abandoned and Alone", ArkhamCardSubtype.Weakness)
                .WithTraits("Madness.")
                .WithFrontText("Revelation - Take 2 direct horror and remove all cards in your discard pile from the game.")
                .WithFrontFlavor("I don't need them. I don't need anyone.")
                .WithInfo(15, 1, Artist.Ben_Zweifel));
            addCard(ArkhamCard.Asset(".45 Automatic", ClassSymbol.Guardian, Number.Of(4), AssetSlot.One_Hand)
                .WithTraits("Item.", "Weapon.", "Firearm.")
                .WithSkillTestIcons(SkillIcon.Agility)
                .WithKeywords("Uses 4.")
                .WithFrontText("Uses (4 ammo).\r\nAction - Spend 1 ammo: Fight. You get +1 Combat for this attack. This attack deals +1 damage.")
                .WithInfo(16, 1, Artist.John_Pacer));
            addCard(ArkhamCard.Asset("Physical Training", ClassSymbol.Guardian, Number.Of(2), AssetSlot.None)
                .WithTraits("Talen.")
                .WithSkillTestIcons(SkillIcon.Willpower, SkillIcon.Combat)
                .WithFrontText("Free Action: Spend 1 resource: You get +1 Willpower for this skill test.\r\nFree Action: Spend 1 resource: You get +1 Combat for this skill test.")
                .WithInfo(17, 1, Artist.Lake_Hurwitz));
            addCard(ArkhamCard.Asset("Beat Cop", ClassSymbol.Guardian, Number.Of(4), AssetSlot.Ally)
                .WithTraits("Ally.", "Police.")
                .WithSkillTestIcons(SkillIcon.Combat)
                .WithFrontText("You get +1 Combat.\r\nFree Action - Discard Beat Cop - Deal 1 damage to an enemy at your location.")
                .WithHealth(2).WithSanity(2)
                .WithInfo(18, 1, Artist.Nicholas_Elias));
            addCard(ArkhamCard.Asset("First Aid", ClassSymbol.Guardian, Number.Of(2), AssetSlot.None)
                .WithTraits("Talent.", "Science.")
                .WithSkillTestIcons(SkillIcon.Willpower)
                .WithKeywords("Uses 3.")
                .WithFrontText("Uses (3 supplies). If First Aid has no supplies, discard it.\r\nAction - Spend 1 supply: Heal 1 damage or horror from an investigator at your location.")
                .WithInfo(19, 1, Artist.Sara_Biddle));
            addCard(ArkhamCard.Asset("Machete", ClassSymbol.Guardian, Number.Of(3), AssetSlot.One_Hand)
                .WithTraits("Item.", "Weapon.", "Melee.")
                .WithSkillTestIcons(SkillIcon.Combat)
                .WithFrontText("Action: Fight. You get +1 Combat for this attack. If the attacked enenmy is the only enemy engaged with you, this attack deals +1 damage.")
                .WithFrontFlavor("Cuts through vines, underbrush, and tentacles equally well.")
                .WithInfo(20, 1, Artist.Jason_Caffoe));
            addCard(ArkhamCard.Asset("Guard Dog", ClassSymbol.Guardian, Number.Of(3), AssetSlot.Ally)
                .WithTraits("Ally.", "Creature.")
                .WithSkillTestIcons(SkillIcon.Combat)
                .WithFrontText("Reaction - When an enemy attack dealt damager to Guard Dog: Deal 1 damage to the attacking enemy.")
                .WithFrontFlavor("Fiercely loyal, these trained canines make for perfect companions.")
                .WithHealth(3).WithSanity(1)
                .WithInfo(21, 1, Artist.Stephen_Somers));
            addCard(ArkhamCard.Event("Evidence!", ClassSymbol.Guardian, Number.Of(1), 0)
                .WithTraits("Insight.")
                .WithSkillTestIcons(SkillIcon.Intellect, SkillIcon.Intellect)
                .WithKeywords("Fast.")
                .WithFrontText("Fast. Play after you defeat an enemy.\r\nDiscover 1 clue at your location.")
                .WithFrontFlavor("Just as I suspected!")
                .WithInfo(22, 1, Artist.Mark_Behm));
            addCard(ArkhamCard.Event("Dodge", ClassSymbol.Guardian, Number.Of(1), 0)
                .WithTraits("Tactic.")
                .WithSkillTestIcons(SkillIcon.Willpower, SkillIcon.Agility)
                .WithKeywords("Fast.")
                .WithFrontText("Fast. Play when an enemy attacks an investigator at your location. Cancel that attack.")
                .WithInfo(23, 1, Artist.Dane_Cozens));
            addCard(ArkhamCard.Event("Dynamite Blast", ClassSymbol.Guardian, Number.Of(5), 0)
                .WithTraits("Tactic.")
                .WithSkillTestIcons(SkillIcon.Willpower)
                .WithFrontText("Choose either you location or a connecting location. Deal 3 damage to each enemy and to each investigator at the chosen location.")
                .WithInfo(24, 1, Artist.Dimitri_Bielak));
            addCard(ArkhamCard.Skill("Vicious Blow", ClassSymbol.Guardian, 0)
                .WithTraits("Practiced.")
                .WithSkillTestIcons(SkillIcon.Combat)
                .WithFrontText("If this skill test is successful during an attack, that attack deals +1 damage.")
                .WithFrontFlavor("With a sickening smack, he struck the abomination over and over... until at last, it stopped moving.")
                .WithInfo(25, 1, Artist.JB_Casacop));
            addCard(ArkhamCard.Event("Extra Ammunition", ClassSymbol.Guardian, Number.Of(2), 1)
                .WithTraits("Supply.")
                .WithSkillTestIcons(SkillIcon.Intellect)
                .WithFrontText("Place 3 ammo tokens on a Firearm asset controlled by an investigator at your location.")
                .WithFrontFlavor("I've never met a beast that could outsmart a bullet.")
                .WithInfo(26, 1, Artist.Michael_J_Williams));
            addCard(ArkhamCard.Asset("Police Badge", ClassSymbol.Guardian, Number.Of(3), AssetSlot.Accessory)
                .WithLevel(2)
                .WithTraits("Item.")
                .WithSkillTestIcons(SkillIcon.Willpower, SkillIcon.Wild)
                .WithFrontText("You get +1 Willpower.\r\nFree Action - While an investigator at your location is taking his or her turn, discard Police Badge: That investigator may take 2 additional actions this turn.")
                .WithInfo(27, 1, Artist.Stanislav_Dikolenko));
            addCard(ArkhamCard.Asset("Beat Cop", ClassSymbol.Guardian, Number.Of(4), AssetSlot.Ally)
                .WithLevel(2)
                .WithTraits("Ally.", "Police.")
                .WithSkillTestIcons(SkillIcon.Combat, SkillIcon.Agility)
                .WithFrontText("You get +1 Combat.\r\nFree Action - Exhaust Beat Cop and deal 1 damage to it: Deal 1 damage to an enemy at your location.")
                .WithHealth(3).WithSanity(2)
                .WithInfo(28, 1, Artist.Nicholas_Elias));
            addCard(ArkhamCard.Asset("Shotgun", ClassSymbol.Guardian, Number.Of(5), AssetSlot.Both_Hands)
                .WithLevel(4)
                .WithTraits("Item.", "Weapon.", "Firearm.")
                .WithSkillTestIcons(SkillIcon.Combat, SkillIcon.Combat)
                .WithKeywords("Uses 2.")
                .WithFrontText("Uses (2 ammo).\r\nAction - Spend 1 ammo: Fight. You get +3 Combat for this attack. Instead of its standard damage, this attack deals 1 damage for each point you succeed by (to a minimum of 1, to a maximum of 5). If you fail and would damage another investigator, this attack deals 1 damage for each point you fail by (to a minimum of 1, to a maximum of 5).")
                .WithInfo(29, 1, Artist.Tony_Foti));
            addCard(ArkhamCard.Asset("Magnifying Glass", ClassSymbol.Seeker, 1, AssetSlot.One_Hand)
                .WithTraits("Item.", "Tool.")
                .WithKeywords("Fast.")
                .WithSkillTestIcons(SkillIcon.Intellect)
                .WithText("Fast.\r\nYou get +1 Intellect while invetigating.")
                .WithFlavor("A lens into a world unseen can reveal things you wish it hadn't.")
                .WithInfo(30, 1, Artist.TBD));
            addCard(ArkhamCard.Asset("Old Book of Lore", ClassSymbol.Seeker, 3, AssetSlot.One_Hand)
                .WithTraits("Item.", "Tome.")
                .WithSkillTestIcons(SkillIcon.Willpower)
                .WithText("Action - Exhaust Old Book of Lore: Choose an investigator at your location. That investigator searches the top 3 cards of his or her deck for a card, draws it, and shuffles the remaining cards into his or her deck.")
                .WithInfo(31, 1, Artist.Dimitri_Bielak));
            addCard(ArkhamCard.Asset("Research Librarian", ClassSymbol.Seeker, 2, AssetSlot.Ally)
                .WithTraits("Ally.", "Miskatonic.")
                .WithSkillTestIcons(SkillIcon.Agility)
                .WithText("Reaction - After Research Librarian enters play: Search your deck for a Tome asset and add it to your hand. Shuffle your deck.")
                .WithFlavor("\"There have been problems at the Orne Library, as we both know, given poor Armitage's condition, and the other, unrelated... incidents of a few years ago...\"")
                .WithHealth(1).WithSanity(1)
                .WithInfo(32, 1, Artist.Tomasz_Jedruszek));
            addCard(ArkhamCard.Asset("Dr. Milan Christopher", ClassSymbol.Seeker, 4, AssetSlot.Ally)
                .WithUnique()
                .WithTraits("Ally.", "Miskatonic.")
                .WithSkillTestIcons(SkillIcon.Intellect)
                .WithText("You get +1 Intellect.\r\nReaction - After you successfully investigate: Gain 1 resource.")
                .WithFlavor("\"While I truly pray that this nightmare is just a singular abomination, I must admit that I am exhilarated by the possibility that this is but one speciment of a new genus!\"")
                .WithHealth(1).WithSanity(2)
                .WithInfo(33, 1, Artist.Anthony_Devine));
            addCard(ArkhamCard.Asset("Hyperawareness", ClassSymbol.Seeker, 2, AssetSlot.None)
                .WithTraits("Talent.")
                .WithSkillTestIcons(SkillIcon.Intellect, SkillIcon.Agility)
                .WithText("Free Action - Spend 1 resource: You get +1 Intellect for this skill test.\r\nFree Action - Spend 1 resource: You get +1 Agility for this skill test.")
                .WithInfo(34, 1, Artist.Aurore_Folay));
            addCard(ArkhamCard.Asset("Medical Texts", ClassSymbol.Seeker, 2, AssetSlot.One_Hand)
                .WithTraits("Item.", "Tome.")
                .WithSkillTestIcons(SkillIcon.Combat)
                .WithText("Action: Choose an investigator at your location and test Intellect (2). If you succeed, heal 1 damage from that investigator. If you fail, deal 1 damage to that investigator.")
                .WithInfo(35, 1, Artist.Anna_Christenson));
            addCard(ArkhamCard.Event("Mind over Matter", ClassSymbol.Seeker, 1)
                .WithTraits("Insight.")
                .WithSkillTestIcons(SkillIcon.Combat, SkillIcon.Agility)
                .WithKeywords("Fast.")
                .WithText("Fast. Play only during your turn.\r\nUntil the end of the round, you must use your Intellect in place of your Combat and Agility.")
                .WithInfo(36, 1, Artist.TBD));
            addCard(ArkhamCard.Event("Working a Hunch", ClassSymbol.Seeker, 2)
                .WithTraits("Insight.")
                .WithSkillTestIcons(SkillIcon.Intellect, SkillIcon.Intellect)
                .WithKeywords("Fast.")
                .WithText("Fast. Play only during your turn. Discover 1 clue at your location.")
                .WithInfo(37, 1, Artist.TBD));
            addCard(ArkhamCard.Event("Barricade", ClassSymbol.Seeker, 0)
                .WithTraits("Insight.", "Tactic.")
                .WithText("Attach to your location.\r\nNon-Elite enemies cannot move into attached location.\r\nForced - When an investigator leaves attached location: Discard Barricade.")
                .WithInfo(38, 1, Artist.Stephen_Somers));
            addCard(ArkhamCard.Skill("Deduction", ClassSymbol.Seeker, 0)
                .WithTraits("Practiced.")
                .WithText("If this skill test is successful while investigating a location, discover 1 additional clue at that location.")
                .WithFlavor("I knew I had seen this symbol before. I must warn the others before it is too late!")
                .WithInfo(39, 1, Artist.TBD));
            addCard(ArkhamCard.Asset("Magnifying Glass", ClassSymbol.Seeker, 0, AssetSlot.One_Hand)
                .WithLevel(1)
                .WithTraits("Item.", "Tool.")
                .WithKeywords("Fast.")
                .WithSkillTestIcons(SkillIcon.Intellect)
                .WithText("Fast.\r\nYou get +1 Intellect while investigating.\r\nFree Action - If there are no clues on your location: Return Magnifying Glass to your hand.")
                .WithFlavor("A lens into a world unseen can reveal things you wish it hadn't.")
                .WithInfo(40, 1, Artist.TBD));
            addCard(ArkhamCard.Asset("Disc of Itzamna", ClassSymbol.Seeker, 3, AssetSlot.Accessory)
                .WithLevel(2)
                .WithUnique()
                .WithTraits("Item.", "Relic.")
                .WithSkillTestIcons(SkillIcon.Willpower, SkillIcon.Intellect, SkillIcon.Combat)
                .WithText("Reaction - When a non-Elite enemy spawns at your location, discard Disc of Itzamna: Discard that enemy.")
                .WithFlavor("Do they fear it because of what it will do to them?\r\nOr, do they fear it because of what it will do to you?")
                .WithInfo(41, 1, Artist.TBD));
            addCard(ArkhamCard.Asset("Encyclopedia", ClassSymbol.Seeker, 2, AssetSlot.One_Hand)
                .WithLevel(2)
                .WithTraits("Item.", "Tome.")
                .WithSkillTestIcons(SkillIcon.Wild)
                .WithText("Action - Exhaust Encyclopedia: Choose an investigator at your location. That investigator gets +2 to a skill of your choice until the end of the phase.")
                .WithFlavor("It's supposed to be comprehensive, but the more I search through its pages, the more I realize we know nothing about the real truths of the cosmos.")
                .WithInfo(42, 1, Artist.TBD));
            addCard(ArkhamCard.Event("Cryptic Research", ClassSymbol.Seeker, 0)
                .WithLevel(4)
                .WithTraits("Insight.")
                .WithKeywords("Fast.")
                .WithText("Fast. Play only during your turn.\r\nChoose an investigator at your location. That investigator draws 3 cards.")
                .WithInfo(43, 1, Artist.Tomasz_Jedruszek));

            addCard(ArkhamCard.Event("Lucky!", ClassSymbol.Survivor, 1)
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