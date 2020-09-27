using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.FirstAge
{
    public class AmongTheOutlawsSet : CardSet
    {
        private const string setName = "Among the Outlaws";
        private const string cycleName = "Doom Mastered";

        protected override void Initialize()
        {
            Name = "Among the Outlaws";
            Abbreviation = "AtO";
            Number = 9003;
            SetType = Models.SetType.First_Age;
            Cycle = cycleName;

            addScenario(EncounterSet.AmongTheOutlaws.Name, 2, cycleName)
                .WithTextLine("Dilemma Deck")
                .WithTextLine("The 9 objective cards with the Dilemma trait are set aside into a separate deck at the start of the game and shuffled. When players quest unsuccessfully, the top card of the dilemma deck is revealed. Each dilemma card gives the player two options. Carrying out the first option helps the Gaurwaith while carrying out the second option, which adds the card to the victory display, helps the woodmen.")
                .WithTextLine("Corruption and Objective Allies")
                .WithTextLine("Objective allies are immune to corruption and corruption cannot be placed on objective allies for any reason.")
                .WithOppositeTextLine("Ransom")
                .WithOppositeTextLine("When a character with the Ransom keyword enters play, the player who controls it may discard a number of resources from the resource pools of heroes they control equal to the Ransom value. If they choose not to satisfy this requirement, then that player card loses the \"ally\" card type and gains the \"enemy\" card type, immediately engaging the player who played it. Its threat is equal to its willpower and its engagement cost is 0. If this enemy is defeated, remove all damage from it and return it its owner's control as an ally.")
                .WithOppositeTextLine("Relentless")
                .WithOppositeTextLine("An enemy with the Relentless keyword cannot have its attack canceled or be prevented from attacking by player card effects. It can still be targeted by other effects which do no specifically prevent attacks.")
                .WithInfo(0, 1, Artist.Arman_Akopian);

            addLocation("Foret Clearing", EncounterSet.AmongTheOutlaws, 2, 4)
                .WithTraits("Forest.")
                .WithTextLine("(Stage 1B) Response: After Forst Clearing is explored, reduce each player's threat by 2.")
                .WithTextLine("(Stage 2B): While Forest Clearing is the active location, the first Gaurwaith enemy revealed each round gains surge.")
                .WithInfo(10, 0, Artist.Unknown);

            addTreachery("Horn-calls", EncounterSet.AmongTheOutlaws)
                .WithTraits("Woodmen.")
                .WithTextLine("When Revealed: Each player must search the encounter deck and discard pile for a Woodmen enemy and put it into play engaged with hum. Then, each engaged Woodmen enemy makes an immediate attack.")
                .WithFlavorLine("...and there were paths from stead to stead, and men could summon help at need by horn-calls.")
                .WithFlavorLine("-The Children of Húrin")
                .WithInfo(16, 0, Artist.Unknown);

            addTreachery("Wolf-men of the Winter", EncounterSet.AmongTheOutlaws)
                .WithTraits("Gaurwaith.")
                .WithTextLine("When Revealed: Each player engaged with a Gaurwaith enemy must discard all resources he controls. If a player did not discard at least 3 resources, deal 1 damage to each character he controls.")
                .WithShadow("Shadow: The defending player must pay 1 resource of the attacking enemy gets +3 Attack.")
                .WithInfo(18, 0, Artist.Unknown);

            addEnemy("Forweg", EncounterSet.AmongTheOutlaws, 0, 2, 4, 2, 5)
                .WithSlugSuffix("Enemy")
                .WithUnique()
                .WithTraits("Gaurwaith.", "Captain.")
                .WithKeywords("Relentless.")
                .WithTextLine("Relentless.")
                .WithTextLine("Allies cannot attack or defend against Forweg.")
                .WithTextLine("Forced: After Forweg makes his first attack each round, he engages the next player and makes an immediate attack (discard and deal a new shadow card for this attack.")
                .WithInfo(31, 1, Artist.Unknown); //Dragondude97
            addObjectiveAlly("Forweg", EncounterSet.AmongTheOutlaws, 2, 4, 2, 5)
                .WithSlugSuffix("Objective-Ally")
                .WithUnique()
                .WithTraits("Gaurwaith.", "Captian.")
                .WithTextLine("The first player gains control of Forweg.")
                .WithTextLine("Forced: Forweg declares and resolves an attack against a random Woodmen enemy engaged with the first player at the end of the combat phase.")
                .WithTextLine("If Forweb leaves play, the players lose the game.")
                .WithInfo(31, 1, Artist.Unknown); //Dragondude97
            addEnemy("Androg", setName, 0, 1, 3, 2, 5)
                .WithSlugSuffix("Enemy")
                .WithUnique()
                .WithTraits("Gaurwaith.")
                .WithKeywords("Relentless.")
                .WithText("Androg gets +1 Attack for each hero you control with at least 1 Corruption.")
                .WithFlavor("\"The hardest of heart was one named Androg...\"\r\n-The Children of Húrin")
                .WithVictoryPoints(1)
                .WithInfo(32, 1, Artist.Denman_Rooke);
            addObjectiveAlly("Androg", EncounterSet.AmongTheOutlaws, 1, 3, 2, 5)
                .WithSlugSuffix("Objective-Ally")
                .WithUnique()
                .WithTraits("Gaurwaith.")
                .WithTextLine("The first player gains control of Androg.")
                .WithTextLine("Each Woodmean enemy gets -5 engagemet cost for each Corruption on heroes the first player controls.")
                .WithTextLine("If Androg leaves play, the players lose the game.")
                .WithFlavorLine("\"Outlaws know no law but their needs. Look to your own, Neithan, and leave us to mind ours.\"")
                .WithFlavorLine("-Androg, The Children of Húrin")
                .WithInfo(32, 1, Artist.Denman_Rooke);
            addEnemy("Teiglin Hunter", EncounterSet.AmongTheOutlaws, 28, 2, 2, 1, 3)
                .WithTraits("Woodmen.")
                .WithTextLine("While Teiglin Hunter is engaged with a player, all enemies engaged with that player get +1 Attack.")
                .WithShadow("Shadow: All enemies engaged with the defending player get +1 Attack until the end of the phase.")
                .WithInfo(34, 0, Artist.Unknown);
            addEnemy("Hound of the Woodmen", EncounterSet.AmongTheOutlaws, 20, 1, 3, 2, 4)
                .WithTraits("Woodmen.", "Creature.")
                .WithTextLine("Forced: At the start of the encounter phase, discard cards from the top of the encounter deck until an enemy is discarded. Add that enemy to the staging area. This ability does not stack with other copies of Hound of the Woodmen.")
                .WithFlavorLine("But they earned less gratitude so from the outlaws than from beasts and birds, and they were saved rather by their dogs and their fences...")
                .WithFlavorLine("-The Children of Húrin")
                .WithInfo(35, 0, Artist.Unknown);

            addLocation("Scattered Homestead", EncounterSet.AmongTheOutlaws, 4, 6)
                .WithTraits("Homestead.")
                .WithTextLine("While Scattered Homestead is in the staging area, discard cards from the encounter deck at the end of the round until an enemy is discarded. Add that enemy to the staging area.")
                .WithFlavorLine("...they were of Haleth's folk for the most part, but owned no lord, and they lived both by hunting and husbandry...")
                .WithFlavorLine("-The Children of Húrin")
                .WithInfo(41, 0, Artist.Unknown);

            addTreachery("Dogs and Fenced", EncounterSet.AmongTheOutlaws)
                .WithTraits("Woodmen.")
                .WithTextLine("When Revealed: Each player must choose: Either deal X damage among heroes he controls, where X is equal to the number of engaged Woodmen enemies plus 2, or treat the printed text bost of each non-objective character he controls as if it were blank, except for keywords and Traits, until the end of the round.")
                .WithFlavorLine("But when spring was come it was perilous for the Gaurwaith to linger so near the houses of the woodmen...")
                .WithFlavorLine("-The Children of Húrin")
                .WithInfo(45, 0, Artist.Unknown); //Michael Ivan

            addTreachery("No Law But Their Needs", EncounterSet.AmongTheOutlaws)
                .WithTraits("Woodmen.")
                .WithTextLine("When Revealed: Either each player must immediately exhaust and commit 1 hero to the quest, or raise each player's threat by 4.")
                .WithShadow("Shadow: Deal 1 damage to the attacking enemy. If that enemy is destroyed, deal 1 Corruption to the defending character.")
                .WithInfo(47, 0, Artist.Winona_Nelson);

            addHero("Bór the Faithful", 6, Sphere.Spirit, 2, 1, 1, 3)
                .WithTraits("Easterling.")
                .WithText("Action: Discard 1 Corruption for Bór the Faithful to ready him. He gets +2 Attack and +1 Willpower until the end of the round. (Limit once per round.)")
                .WithFlavor("...and they followed Maedhros and Maglor, and cheated the hope of Morgoth, and were faithful.\r\n-The Silmarillion")
                .WithInfo(53, 1, Artist.Chris_Quilliams);
            addAlly("Brethil Hound", 3, Sphere.Spirit, false, 1, 2, 1, 2)
                .WithTraits("Hound.", "House of Haleth.")
                .WithText("Response: After Brethil Hound participates in an attack that destroys an enemy, choose a player. That player reduces his threat by 1. (Limit once per phase.)")
                .WithInfo(54, 3, Artist.K_LeCrone);
            addAlly("Algund", 0, Sphere.Mastery, true, 2, 1, 1, 3)
                .WithTraits("Gaurwaith.")
                .WithKeywords("Ransom 3.")
                .WithText("Response: When the discard pile is shuffled back into the encounter deck, deal X Corruption to Algund to choose X cards in the discard pile. These cards are not shuffled back into the encounter deck.")
                .WithFlavor("...and others also came from that land: old Algund, the oldest of the fellowship, who had fled from the Nirnaeth...\r\n-The Children of Húrin")
                .WithInfo(55, 3, Artist.J_Lantta);
            addAlly("Fostered Son", 1, Sphere.Leadership, false, 1, 0, 0, 1)
                .WithTraits("Edain.", "Noble.")
                .WithText("Action: Discard Fostered Son to reduce the cost of the next unique Edain character you play this phase by 2.")
                .WithFlavor("Thus it was that the sons of Galdor were fostered in Brethil by Haldir their uncle, according to the custom of Men in that time...\r\n-The Silmarillion")
                .WithInfo(56, 3, Artist.Andrew_Ryan);
            addAlly("Elder of the Realm", 3, Sphere.Lore, false, 2, 1, 1, 2)
                .WithTraits("Teleri.")
                .WithText("Response: After a treachery is revealed, discard a card from hand (spend 1 Lore to discard the top card of your deck instead). If the first letter of the treachery card's title matches that of the discarded card, cancel the \"when revealed\" effects of the revealed card. (Limit once per game.)")
                .WithInfo(56, 3, Artist.Unknown);
            addAlly("Wolf-man", 0, Sphere.Mastery, false, 0, 3, 1, 2)
                .WithTraits("Gaurwaith.")
                .WithKeywords("Ransom 4.")
                .WithText("Action: Exhaust Wolf-man to immediately declare him as an attacker (and resolve his attack) against an engaged enemy with one hit point remaining.")
                .WithInfo(57, 3, Artist.Lane);
            addAttachment("Neithan", 1, Sphere.Mastery, true)
                .WithTraits("Name.")
                .WithTextLine("Attach to Túrin Turambar. Limit 1 Name in play.")
                .WithTextLine("Resource on Neithan can be discard to satisfy the ransom keyword.\r\nResponse: When an enemy with the ransom keyword is defeated, add 2 resources to Neithan.")
                .WithInfo(58, 3, Artist.Thomas_Scholes);
            addAttachment("Forge of Belegost", 1, Sphere.Lore, true)
                .WithTraits("Item.", "Forge.")
                .WithTextLine("Attach to a Dwarf character.")
                .WithTextLine("Action: Exhaust Forge of Belegost and attached character to heal X damage on a character. X is the number of Item attachments on that character.")
                .WithFlavor("...yet in the tempering of steel alone of all crafts the Dwarves were never outmatched even by the Noldor...\r\n-The Silmarillion")
                .WithInfo(59, 3, Artist.Unknown);
            addAttachment("Angrist", 1, Sphere.Leadership, true)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a hero with the House of House of Bëor trait. Restricted.\r\nAttached hero gets +1 Attack.\r\nAction: Exhaust Angrist and the attached hero to choose a facedown enemy. Turn that enemy faceup and deal 4 damage to it.")
                .WithFlavor("...and from the iron claws that held it he cut a Silmaril.\r\n-The Silmarillion")
                .WithInfo(60, 3, Artist.Vadim);
            addEvent("Song of Parting", 1, Sphere.Leadership)
                .WithTraits("Song.")
                .WithText("Response: After an encounter card with at least 3 Threat is revealed from the encounter deck, choose and ready a character. That character gets +2 Willpower, +2 Attack, and +2 Defense until the end of the round.")
                .WithFlavor("...for he believed that he must now say farewell to both love and light.\r\n-The Silmarillion")
                .WithInfo(61, 3, Artist.Kip_Rasmussen);
            addEvent("None Shall Break", 2, Sphere.Mastery)
                .WithText("Action: Ready each character with an Oath attached. (Lower the cost of None Shall Break by 2 if each character that readies takes 1 Corruption.)")
                .WithFlavor("For so sworn, good or evil, an oath may not be broken, and it shall pursue oathkeeper and oathbreaker to the world's end.\r\n-The Silmarillion")
                .WithInfo(62, 3, Artist.Jenny_Dolfen);

            addObjective("Punish the Trespassers", EncounterSet.AmongTheOutlaws)
                .WithTraits("Dilemma.")
                .WithFlavorLine("The Gaurwaith do not allow outsiders to tread on their land. Will you join them in waylaying the trespasser or will you speak for mercy?")
                .WithTextLine("When Revealed: Either each player must exhaust a character he controls to discard a Woodmen enemy from play, or add Punish the Trespassers to the victory display and each player must search the encounter deck and discard pile for a Woodmen enemy and put it into play engaged with him. One of these must be Hound of the Woodmen, if able.")
                .WithVictoryPoints(1)
                .WithInfo(64, 1, Artist.Unknown);


            addObjective("Turn a Blind Eye", EncounterSet.AmongTheOutlaws)
                .WithTraits("Dilemma.")
                .WithFlavorLine("The Gaurwaith are hardened men and have committed deplorable acts in their latest ranging. Will you ignore their misdeeds or challenge them?")
                .WithTextLine("When Revealed: Either each player must deal 1 Corruption to a hero he controls to reduce his threat by 3, or add Turn a Blind Eye to the victory display and exhaust all heroes in play.")
                .WithVictoryPoints(1)
                .WithInfo(66, 1, Artist.Unknown);
            addTreachery("Cruel of Heart", EncounterSet.AmongTheOutlaws)
                .WithBurden()
                .WithTraits("Doom.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Attach to the hero with Curse of Morgoth attached. (Counts as a Condition attachment with the text: \"Forced: After an ally enters play, exhaust attached hero to deal 1 damage to that ally.\")")
                .WithFlavorLine("...but many took to robbert and became cruel.")
                .WithFlavorLine("-The Children of Húrin")
                .WithInfo(67, 1, Artist.Unknown);
            addTreachery("Bitterness of Exile", EncounterSet.AmongTheOutlaws)
                .WithBurden()
                .WithTraits("Doom.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Remove each character with at least 1 Corruption from the quest.")
                .WithShadow("Shadow: Reveal the top card of the encounter deck. It it is an eney or location, add it to the staging area.")
                .WithInfo(68, 1, Artist.Unknown);
            addAttachment("Craft in Wood and Field", 2, Sphere.Neutral, false)
                .WithBoon()
                .WithTraits("Skill.")
                .WithTextLine("Attach to the hero with Curse of Morgoth attached.")
                .WithTextLine("Response: After the players travel to a location, choose a player and exhaust attached hero to reduce that player's threat by the Threat of the active location.")
                .WithInfo(69, 1, Artist.Hector_Hanoteau);
            addAttachment("Hardship of the Wild", 0, Sphere.Neutral, false)
                .WithBoon()
                .WithTraits("Condition.")
                .WithKeywords("Permanent.")
                .WithTextLine("Permanent.")
                .WithTextLine("Setup: Attach to a hero.")
                .WithTextLine("Attached hero gets +1 Defense and +1 hit point.")
                .WithTextLine("Response: Add Hardship of the Wild to the victory display, and remove it from the campaign pool, to cancel 2 points of damage just deal to attached hero.")
                .WithInfo(70, 1, Artist.Unknown);
        }
    }
}