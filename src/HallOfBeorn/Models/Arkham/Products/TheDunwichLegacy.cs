using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham.Products
{
    public class TheDunwichLegacy : ArkhamProduct
    {
        private ArkhamEncounterSet extra = ArkhamEncounterSet.ExtracurricularActivity;
        private ArkhamEncounterSet house = ArkhamEncounterSet.TheHouseAlwaysWins;
        private ArkhamEncounterSet beast = ArkhamEncounterSet.BeastThralls;
        private ArkhamEncounterSet sorcery = ArkhamEncounterSet.Sorcery;
        private ArkhamEncounterSet hideous = ArkhamEncounterSet.HideousAbominations;
        private ArkhamEncounterSet badLuck = ArkhamEncounterSet.BadLuck;
        private ArkhamEncounterSet whippoorwills = ArkhamEncounterSet.Whippoorwills;

        public TheDunwichLegacy()
            : base("The Dunwich Legacy", "TDL", "AHC02", 2, new DateTime(2016, 12, 31))
        {
        }

        protected override void init()
        {
            addCard(ArkhamCard.Investigator("Zoey Samaras", "The Chef", ClassSymbol.Guardian, 9, 6)
                .WithSkills(4, 2, 4, 2)
                .WithTraits("Believer.", "Hunter.")
                .WithText("{Reaction} After you become engaged with an enemy: Gain 1 resource.\r\n{Elder Sign} effect: +1. If this skill test is successful during an attack, that attack deals +1 damage.")
                .WithFlavor("\"God has spoken. I will do His work without hesitation.\"")
                .WithInfo(1, 1, Artist.Magali_Villeneuve));

            addCard(ArkhamCard.Investigator("\"Ashcan\" Pete", "The Drifter", ClassSymbol.Survivor, 6, 5)
                .WithSkills(4, 2, 2, 3)
                .WithTraits("Drifter.")
                .WithText("You begin the game with Duke in play.\r\n{Free Action} Discard a card from your hand: Ready an asset you control. (Limit once per round.)\r\n{Elder Sign} effect: +2. Ready Duke.")
                .WithFlavor("\"C'mere, boy. We got work to do.\"")
                .WithBackText("Deck Size: 30.\r\nDeckbuilding Options: Survivor cards ([Survivor]) level 0-5, Neutral cards level 0-5, up to five level 0 cards from any other class.\r\nDeckbuilding Requirements (do not count towards deck size): Duke, Wracked by Nightmares, 1 random basic weakness.")
                .WithInfo(5, 1, Artist.Jake_Murray));

            addCard(ArkhamCard.Asset("Duke", ClassSymbol.None, 2)
                .WithUnique()
                .WithTraits("Ally.", "Companion.")
                .WithHealth(2).WithSanity(3)
                .WithText("\"Ashcan\" Pete deck only.\r\n{Action} Exhaust Duke: {Fight}. You attack with a base {Combat} skill of 4. This attack deals +1 damage.\r\n{Action} Exhaust Duke: Investigate. You investigate with a base {Intellect} skill of 4. You may move to a connecting location immediately before investigating with this effect.")
                .WithInfo(14, 1, Artist.Owen_William_Weber));

            addCard(ArkhamCard.Asset("Blackjack", ClassSymbol.Guardian, 1)
                .WithIcons(SkillIcon.Combat)
                .WithTraits("Item.", "Weapon.", "Melee.")
                .WithText("{Action}: {Fight}. You get +1 {Combat} for this attack. If you perform this attack against an enemy engaged with another investigator and you fail, you deal no damage.")
                .WithAssetSlot(AssetSlot.One_Hand)
                .WithInfo(16, 2, Artist.Matthew_Cowdery));

            addCard(ArkhamCard.Skill("Double or Nothing", ClassSymbol.Rogue, 0)
                .WithTraits("Fortune.")
                .WithText("Max 1 committed per skill test.\r\nDouble the difficulty of this skill test. If this skill test is successful, resolve the effects of the successful test twice.")
                .WithInfo(26, 2, Artist.Mark_Molnar));

            addCard(ArkhamCard.Asset("Clarity of Mind", ClassSymbol.Mystic, 2)
                .WithAssetSlot(AssetSlot.Arcane)
                .WithTraits("Spell.")
                .WithKeywords("Uses 3.")
                .WithText("Uses (3 charges).\r\n{Action} Spend 1 charge: Heal 1 horror from an investigator at your location.")
                .WithInfo(30, 2, Artist.Aaron_B_Miller));
            addCard(ArkhamCard.Event("Bind Monster", ClassSymbol.Mystic, 3)
                .WithLevel(2)
                .WithIcons(SkillIcon.Willpower, SkillIcon.Intellect)
                .WithTraits("Spell.")
                .WithText("{Evade}. This evasion attempt uses {Willpower} instead of {Agility}. If you succeed and the enemy is non-{t:Elite}, evade it and attach Bind Monster to it.\r\n{Reaction} When attached enemy would ready: Test {Willpower} (3). If you succeed, attached enemy does not ready. If you fail, discard Bind Monster.")
                .WithInfo(31, 2, Artist.Christina_Davis));

            addCard(ArkhamCard.Event("Bait and Switch", ClassSymbol.Survivor, 1)
                .WithIcons(SkillIcon.Intellect, SkillIcon.Agility)
                .WithTraits("Tactic.")
                .WithText("{Evade}. If you succeed, if the enemy is non-{t:Elite}, evade the enemy and move it to a connecting location.")
                .WithInfo(34, 2, Artist.Rafal_Hrynkiewicz));

            addCard(ArkhamCard.Treachery("Chronophobia", ArkhamCardSubtype.Basic_Weakness)
                .WithTraits("Madness.")
                .WithText("{Revelation} – Put Chronophobia into play in your threat area.\r\n{Forced} – At the end of your turn: Take 1 direct horror.\r\n{Action} {Action}: Discard Chronophobia.")
                .WithInfo(39, 2, Artist.Sara_Biddle));
            addCard(ArkhamCard.Asset("Dr. Henry Armitage", ClassSymbol.None, 2, AssetSlot.Ally)
                .WithUnique()
                .WithHealth(2).WithSanity(2)
                .WithIcons(SkillIcon.Wild, SkillIcon.Wild)
                .WithTraits("Ally.", "Miskatonic.")
                .WithText("{Reaction} After you draw a card, discard that card and exhaust Dr. Henry Armitage: Gain 3 resources.")
                .WithFlavor("Armitage knew he would be meddling with terrible powers, yet saw that there was no other way to annul the deeper and more malign meddling which others had done before him.<br>–H. P. Lovecraft, \"The Dunwich Horror\"")
                .WithInfo(40, 1, Artist.Anders_Finer));
            addCard(ArkhamCard.ScenarioReference("Extracurricular Activity", "Scenario Reference", extra)
                .WithText("{Skull}: –1. If you fail, discard the top 3 cards of your deck.\r\n{Cultist}: –1 (–3 instead if there are 10 or more cards in your discard pile).\r\n{Elder Thing}: –X. Discard the top 2 cards of your deck. X is the total printed cost of those discarded cards.")
                .WithBackText("{Skull}: –2. If you fail, discard the top 5 cards of your deck.\r\n{Cultist}: –1 (–5 instead if there are 10 or more cards in your discard pile).\r\n{Elder Thing}: –X. Discard the top 3 cards of your deck. X is the total printed cost of those discarded cards.")
                .WithInfo(41, 1, Artist.None));

            addCard(ArkhamCard.Agenda("Dead of Night", "An Experiment Gone Wrong", 2, Number.Of(3), extra)
                .WithFlavor("Professor Rice’s disappearance isn’t the only thing amiss at the university. You’re unsure exactly what is going on, but you’re starting to believe Armitage was right in asking for your help.")
                .WithText("Each investigator’s maximum hand size is reduced by 3 while checking his or her hand size during the upkeep phase.")
                .WithBackFlavor("A cry of fear echoes through the campus, and several students flee from the eastern side of the university, where the Science building can be found. Could this commotion be linked to Professor Rice’s disappearance?")
                .WithBackText("If the Dormitories location is not in play, put it into play.\r\nIf The Experiment is in play, move it 1 location towards the Dormitories.\r\nIf The Experiment is not in play, spawn it in the Science Building.")
                .WithInfo(43, 1, Artist.Yoann_Boissonnet));

            addCard(ArkhamCard.Act("After Hours", "The Head Janitor", 1, Number.Of(3).PerInvestigator(), ArkhamEncounterSet.ExtracurricularActivity)
                .WithFlavor("Professor Rice was last seen several hours ago by one of Armitage's students, in the Humanities building.")
                .WithBackFlavor("You were unable to find Professor Rice, but one of the students you spoke with mentioned a strange man entering Rice’s office. Unfortunately, the door leading to the faculty offices is locked at this late hour. The student says that the head janitor, \"Jazz\", might be able to let you in, if you can find him.")
                .WithBackText("Shuffle the encounter discard pile and the set-aside \"Jazz\" Mulligan into the encounter deck.")
                .WithInfo(45, 1, Artist.Tomasz_Jedruszek));

            addCard(ArkhamCard.Act("Campus Safety", "The Beast's Death", 3, Number.NA, extra)
                .WithFlavor("You have only moments to react. You could warn the students in the dormitories and escort them to safety, or continue your task of searching the faculty offices for Professor Rice. Or, perhaps you could try to slay the beast that threatens the campus.")
                .WithText("{Objective} – Find and complete an objective on another encounter card.")
                .WithBackFlavor("The monstrous creature lets out a terrible shriek as it succumbs to its wounds and collapses onto the ground. A foul odor emanates from the corpse as its flesh begins to bubble and froth. Your relief turns to disgust as the body begins to shrink and disintegrate. Minutes later, the body has almost entirely evaporated into a sticky mass, and the awful odor has vanished. Inside the remnants of the creature’s body, all you can find is a set of bones – the skeletal structure of a canine.")
                .WithBackText("<b>(&rarr;R3)</b>")
                .WithInfo(47, 1, Artist.Tomasz_Jedruszek));

            addCard(ArkhamCard.Location("Dormitories", ConnectionSymbol.Dormitories, Number.Of(1), Number.Of(3).PerInvestigator(), extra)
                .WithTraits("Miskatonic.")
                .WithText("The door leading into the Dormitories is locked. You cannot move into the Dormitories.")
                .WithFlavor("The red brick form of the west dormitory could be seen through the trees...<br>–Graham McNeill, Ghouls of the Miskatonic")
                .WithBackText("{Objective} – If investigators in the Dormitories spend 3 {Per Investigator} clues, as a group: <b>(&rarr;R2)</b>")
                .WithBackFlavor("As you explore these old, well-kept buildings, you find yourself wondering whether the beds are comfortable...")
                .WithVictoryPoints(1)
                .WithInfo(52, 1, Artist.Ignacio_Bazan_Lazcano));
            addCard(ArkhamCard.Location("Administration", ConnectionSymbol.Administration, Number.Of(4), Number.Of(1).PerInvestigator(), extra)
                .WithTraits("Miskatonic.")
                .WithFlavor("Around the aged administration building, creepers of ivy climb from the ground in an effort to claim it. The old hall stands alone in an isolated section of the campus, apart from the day-to-day bustle of students.")
                .WithBackText("Forced – After Administration is revealed: Put the set-aside Faculty Offices into play.\r\nForced – At the end of your turn, if you are in Administration: Discard the top card of your deck.")
                .WithInfo(53, 1, Artist.Tomasz_Jedruszek));
            addCard(ArkhamCard.Location("Faculty Offices", ConnectionSymbol.Faculty_Offices, Number.Of(2), Number.Of(2).PerInvestigator(), extra)
                .WithSubtitle("The Night is Still Young")
                .WithTraits("Miskatonic.")
                .WithText("The door leading into the Faculty Offices is locked. You cannot move into the Faculty Offices.")
                .WithFlavor("You come to a locked door at the top of the stairs leading to the third floor of the administration building. Through its frosted window, you glimpse a shadow darting across the hall.")
                .WithBackText("{Forced} – After Faculty Offices is revealed: Search the encounter deck and discard pile for a {t:Humanoid} enemy and spawn it here. Shuffle the encounter deck.\r\n{Objective} – If investigators in the Faculty Offices spend 2 {Per Investigator} clues, as a group: <b>(&rarr;R1)</b>")
                .WithVictoryPoints(1)
                .WithInfo(54, 1, Artist.Tomasz_Jedruszek));

            addCard(ArkhamCard.Location("Alchemy Labs", ConnectionSymbol.Alchemy_Labs, Number.Of(5), Number.Of(0), extra)
                .WithTraits("Miskatonic.")
                .WithText("The door leading into the Alchemy Labs is locked. You cannot move into the Alchemy Labs.")
                .WithFlavor("A pungent stench rises from the laboratory downstairs. The silence of the hall is broken by the unmistakable hiss of a burner.")
                .WithBackText("{Action}: {Investigate}. If you are successful, instead of discovering clues, take the Alchemical Concoction from underneath this location if able.")
                .WithBackFlavor("Peculiar concoctions and obscure reagents line the shelves of the laboratory. What manner of science is going on down here?")
                .WithInfo(57, 1, Artist.Ignacio_Bazan_Lazcano));

            addCard(ArkhamCard.Asset("Alchemical Concoction", ClassSymbol.None, 0)
                .WithTraits("Item.", "Science.")
                .WithText("{Action}: {Fight}. This attack uses {Intellect} instead of {Combat}. If used to attack The Experiment, this attack deals +6 damage. If you succeed, remove Alchemical Concoction from the game.")
                .WithInfo(59, 1, Artist.Dani_Hartel));
            addCard(ArkhamCard.Asset("\"Jazz\" Mulligan", ClassSymbol.None, 0)
                .WithTraits("Ally.", "Miskatonic.")
                .WithHealth(2).WithSanity(2)
                .WithText("{Revelation} – Put \"Jazz\" Mulligan into play at your location.\r\nWhile \"Jazz\" Mulligan is not controlled by a player, he gains: \"{Action}: {Parley}. Test {Intellect} (3). If successful, take control of 'Jazz' Mulligan.\"\r\nWhile you control \"Jazz\" Mulligan, you ignore the text on each unrevealed {t:Miskatonic} location.")
                .WithInfo(60, 1, Artist.Nicholas_Elias));

            addCard(ArkhamCard.Agenda("Chaos in the Clover Club", "The Building Collapses", 3, Number.Of(7), house)
                .WithFlavor("Amidst the chaos and confusion, the strange abominations attack everyone in the club. Screams echo through the halls as the blood begins to spray.")
                .WithText("{Forced} – At the start of the enemy phase: Discard each {t:Criminal} enemy in the same location as an {t:Abomination} enemy.")
                .WithBackFlavor("As the strange abominations continue to rampage through the club, the building’s foundations shake and tremble. You flee toward the exit, but you are caught in the collapsing rubble as the club is destroyed.")
                .WithBackText("<b>(&rarr;R4)</b>")
                .WithInfo(65, 1, Artist.Matthew_Cowdery));

            addCard(ArkhamCard.Act("Beginner's Luck", "High Roller", 1, Number.Of(4).PerInvestigator(), house)
                .WithFlavor("You need to find Dr. Morgan. The club is packed; perhaps somebody knows where he is.")
                .WithText("{Reaction} When you reveal a chaos token: You may treat that token as if it were any other token in the chaos bag. If you do, remember that you have \"cheated.\" (Group limit once per round.)\r\n{Objective} – When the investigators have collected the requisite number of clues, they must immediately spend them and advance.")
                .WithBackFlavor("After speaking to a number of gamblers and servers, it seems as though Dr. Morgan has had quite the run lately. Instead of cashing out his winnings, he was convinced to double down. He was last seen entering the guarded hall near the back of the cardroom.")
                .WithBackText("Put the set-aside Darkened Hall into play.\r\nIf it is Agenda 1, discard cards from the top of the encounter deck until a {t:Criminal} enemy is discarded, and spawn that enemy in the Darkened Hall.")
                .WithInfo(66, 1, Artist.Chris_Peuler));

            addCard(ArkhamCard.Act("All In", "Safe... For Now", 3, Number.NA, house)
                .WithFlavor("With or without Dr. Morgan, you have to get out of here. Fast.")
                .WithText("While Dr. Morgan is not controlled by a player, he gains \"{Action}: {Parley}. Test {Willpower} (3) to shake Dr. Morgan out of his daze. If you succeed, place 1 clue from the token bank on him. If there are 1 {Per Investigator} clues on Dr. Morgan, take control of him.\"\r\n{Objective} – If each undefeated investigator has resigned, advance.")
                .WithBackFlavor("You escape the club, doing your best to look inconspicuous as several cars pull up near the street. A handful of grim-faced men and women exit, running toward the restaurant’s entrance to take control of the situation. One of them catches your eye, his hand on the grip of his .38, but thankfully he turns his attention back to the rest of his crew and follows them into the club. You breathe a sigh of relief...")
                .WithBackText("– If an investigator resigned with Dr. Francis Morgan under his or her control, <b>(&rarr; R2)</b>– Otherwise, <b>(&rarr; R1)</b>")
                .WithInfo(68, 1, Artist.Chris_Peuler));

            addCard(ArkhamCard.Location("Clover Club Lounge", ConnectionSymbol.Clover_Club_Lounge, Number.Of(2), Number.Of(0), house)
                .WithTraits("Clover Club.")
                .WithFlavor("Comfortable leather couches, mahogany furniture, and an array of beautiful art greets gamblers, tempting them into the life of the would-be affluent.")
                .WithText("While it is Act 1, Clover Club Lounge gains: \"{Action} Discard an {t:Ally} asset from your hand: Gain 2 clues from the token pool. (Limit once per game.)\"")
                .WithInfo(71, 1, Artist.Yoann_Boissonnet));
            addCard(ArkhamCard.Location("Clover Club Bar", ConnectionSymbol.Clover_Club_Bar, Number.Of(3), Number.Of(0), house)
                .WithTraits("Clover Club.")
                .WithFlavor("The shelves behind the bar sag beneath the weight of all manner of bootlegged drinks: cheap ales, moonshine, expensive bottles of wine, aged whiskey. If only you had a couple hours to kill...")
                .WithBackText("While it is Act 1, Clover Club Bar gains: \"{Action} Spend 2 resources: Gain 2 clues from the token pool and draw 2 cards. Remember that you have ‘had a drink.’ (Limit once per game.)\"")
                .WithInfo(72, 1, Artist.Romana_Kendelic));
            addCard(ArkhamCard.Location("Clover Club Cardroom", ConnectionSymbol.Clover_Club_Cardroom, Number.Of(3), Number.Of(0), house)
                .WithTraits("Clover Club.")
                .WithFlavor("As you approach the cardroom, the clinking of poker chips and the shuffling of cards is punctuated by shouts of revelry and frustration. Your thoughts are nearly drowned out by the racket.")
                .WithBackText("While it is Act 1, Clover Club Cardroom gains: \"{Action} Spend 2 resources: Reveal a random chaos token.<br>If it is a {Elder Sign} symbol, gain 2 clues and 2 resources from the token bank.<br>If it is an even number, gain 2 clues from the token bank.<br>If it is an odd number or a {Skull}, {Cultist}, {Tablet}, [Elder Thing], or {Tentacle} symbol, nothing happens.\"")
                .WithInfo(73, 1, Artist.Jonny_Klein));
            addCard(ArkhamCard.Location("Darkened Hall", ConnectionSymbol.Darkened_Hall, Number.Of(4), Number.Of(0), house)
                .WithTraits("Clover Club.")
                .WithFlavor("A heavy oak door stands in a secluded corner of the club. As you approach it, the air grows heavy and the clamor of the cardroom fades behind you.")
                .WithBackText("{Forced} – When Darkened Hall is revealed: Put into play the 3 set-aside Back Hall Doorway locations.")
                .WithBackFlavor("The door slams shut behind you, and you stand in sudden silence. This area of the club is lonesome and devoid of warmth and color. Somehow, the spotless floor and walls seem more sinister than inviting.")
                .WithInfo(74, 1, Artist.Mark_Molnar));
            addCard(ArkhamCard.Location("Back Hall Doorway", ConnectionSymbol.Back_Hall_Doorway, Number.Of(2), Number.Of(1).PerInvestigator(), house)
                .WithSubtitle("Art Gallery")
                .WithTraits("Clover Club.")
                .WithFlavor("You approach an unmarked door toward the back of the Clover Club.")
                .WithBackText("Forced – After you fail a skill test while investigating the Art Gallery: Lose 2 resources.")
                .WithBackFlavor("Exotic art and antiques adorn the walls of Peter Clover's private gallery. An evening breeze rustles the worn pages of a ledger back and forth.")
                .WithVictoryPoints(1)
                .WithBackArtist(Artist.Vlad_Ricean)
                .WithInfo(75, 1, Artist.Yoann_Boissonnet));
            addCard(ArkhamCard.Location("Back Hall Doorway", ConnectionSymbol.Back_Hall_Doorway, Number.Of(3), Number.Of(1).PerInvestigator(), house)
                .WithSubtitle("VIP Area")
                .WithTraits("Clover Club.")
                .WithFlavor("You approach an unmarked door toward the back of the Clover Club.")
                .WithBackText("While you are in the VIP Area, you cannot draw cards or gain resource during the upkeep phase.")
                .WithBackFlavor("The coppery smell of blood assaults your senses. The floor is littered with broken glass, and the upholstery has been torn to shreds. Where is Dr. Morgan?")
                .WithVictoryPoints(1)
                .WithBackArtist(Artist.Mark_Molnar)
                .WithInfo(76, 1, Artist.Yoann_Boissonnet));
            addCard(ArkhamCard.Location("Back Hall Doorway", ConnectionSymbol.Back_Hall_Doorway, Number.Of(1), Number.Of(1).PerInvestigator(), house)
                .WithSubtitle("Back Alley")
                .WithTraits("Clover Club.")
                .WithFlavor("You approach an unmarked door toward the back of the Clover Club.")
                .WithBackText("{Action}: {Resign} We can get out this way!")
                .WithBackFlavor("A steep, narrow staircase ascends to a second unmarked door. To your surprise, it leads into a back alley behind La Bella Luna. This must be where they smuggle in their \"goods.\"")
                .WithVictoryPoints(1)
                .WithBackArtist(Artist.Mark_Molnar)
                .WithInfo(77, 1, Artist.Yoann_Boissonnet));
            addCard(ArkhamCard.Enemy("Clover Club Pit Boss", Number.Of(3), Number.Of(4), Number.Of(3), Number.Of(2), Number.Of(0), house)
                .WithTraits("Criminal.", "Elite.")
                .WithKeywords("Hunter.")
                .WithText("Prey – Highest {Intellect}.\r\n{k:Hunter}\r\n{Forced} – After an investigator at Clover Club Pit Boss’s location gains any number of clues: Clover Club Pit Boss readies, engages that investigator, and makes an immediate attack.")
                .WithInfo(78, 1, Artist.Bryce_Cook));

            addCard(ArkhamCard.Asset("Dr. Francis Morgan", ClassSymbol.None, 3, AssetSlot.Ally)
                .WithIcons(SkillIcon.Combat, SkillIcon.Wild)
                .WithUnique()
                .WithHealth(4).WithSanity(1)
                .WithTraits("Ally.", "Miskatonic.")
                .WithText("You get +1 {Combat}.\r\n{Reaction} After you defeat an enemy, exhaust Dr. Francis Morgan: Draw 1 card.")
                .WithInfo(80, 1, Artist.Falk));

            addCard(ArkhamCard.Treachery("Arousing Suspicions", house)
                .WithText("{Revelation} – Place 1 doom on each {t:Criminal} enemy at your location. If no doom was placed by this effect, lose 2 resources.")
                .WithFlavor("Eyes are all around you, watching your every move.")
                .WithInfo(82, 2, Artist.Clark_Huggins));

            addCard(ArkhamCard.Treachery("Beyond the Veil", sorcery)
                .WithTraits("Hex.")
                .WithKeywords("Surge.")
                .WithText("Surge.\r\n{Revelation} – Put Beyond the Veil into play in your threat area if there is no copy of Beyond the Veil in your threat area.\r\n{Forced} – If your deck has no cards in it: Take 10 damage and discard Beyond the Veil.")
                .WithInfo(84, 3, Artist.Brian_Valenzuela));

            addCard(ArkhamCard.Treachery("Eager for Death", whippoorwills)
                .WithTraits("Omen.")
                .WithText("{Revelation} - Test {Willpower} (2). Increase this skill test’s difficulty by 1 for each damage on you. If you fail, take 2 horror.")
                .WithFlavor("If they can catch the fleeing soul when it leaves the body, they instantly flutter away chittering in daemonic laughter... –H. P. Lovecraft, “The Dunwich Horror”")
                .WithInfo(91, 2, Artist.Unknown)); //Artist.Frej_Agelii));
            addCard(ArkhamCard.Treachery("Cursed Luck", badLuck)
                .WithTraits("Omen.")
                .WithText("{Revelation} – Put Cursed Luck into play in your threat area.\r\nYou get –1 skill value during skill tests.\r\n{Forced} – After you succeed at a skill test by 1 or more: Discard Cursed Luck.")
                .WithInfo(92, 3, Artist.Adam_Lane));

            addCard(ArkhamCard.Enemy("Avian Thrall", Number.Of(5), Number.Of(4), Number.Of(3), Number.Of(1), Number.Of(1), beast)
                .WithTraits("Creature.", "Monster.", "Abomination.")
                .WithKeywords("Hunter.")
                .WithText("{Prey} – Lowest {Intellect}.\r\n{k:Hunter}.\r\nWhile Avian Thrall is being attacked using a {t:Ranged}, {t:Firearm} or {t:Spell} asset, it gets –3 fight.")
                .WithInfo(94, 2, Artist.Chun_Lo));

            addCard(ArkhamCard.Treachery("Altered Beast", beast)
                .WithTraits("Power.")
                .WithText("{Revelation} – If there are no {t:Abomination} enemies in play, Altered Beast gains surge. Otherwise, choose an {t:Abomination} enemy. Heal all damage from that enemy and attached Altered Beast to it.\r\n{Forced} – When you enter attached enemy's location (or vice-versa): Take 1 horror.")
                .WithInfo(96, 2, Artist.Chun_Lo));

            addCard(ArkhamCard.Enemy("Conglomeration of Spheres", Number.Of(1), Number.Of(6), Number.Of(4), Number.Of(1), Number.Of(1), hideous)
                .WithTraits("Monster.", "Abomination.")
                .WithKeywords("Hunter.")
                .WithText("Prey – Lowest {Willpower}.\r\n{k:Hunter}\r\n{Forced} – After you perform an attack against the Conglomeration of Spheres using a Melee card: Discard that card.")
                .WithInfo(103, 2, Artist.Stephen_Somers));
        }
    }
}