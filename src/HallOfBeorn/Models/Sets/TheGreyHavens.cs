using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheGreyHavens : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Grey Havens";
            Abbreviation = "TGH";
            Number = 35;
            SetType = Models.SetType.Deluxe_Expansion;

            Cards.Add(Card.Hero("Círdan the Shipwright", "", Sphere.Spirit, 12, 4, 2, 2, 4)
                .WithNormalizedTitle("Cirdan the Shipwright")
                .WithTraits("Noldor.", "Noble.")
                .WithText("Draw 1 additional card at the beginning of the resource phase.\r\nForced: After drawing cards at the beginning of the resource phase, choose and discard 1 of those cards.")
                .WithFlavor("Very tall he was, and his beard was long, and he was grey and old, save that his eyes were keen as stars...\r\n-The Return of the King")
                .WithInfo(1, 1, Artist.Aleksander_Karcz));
            Cards.Add(Card.Hero("Galdor of the Havens", "", Sphere.Lore, 9, 2, 2, 1, 4)
                .WithTraits("Noldor.")
                .WithText("Response: After drawing your setup hand, instead of taking a mulligan, you may discard any number of cards from your hand. Then, draw that many cards.\r\nAction: If you have no cards in your hand, draw 6 cards. (Limit once per game.)")
                .WithFlavor("\"What power still remains lies with us...\"\r\n-The Fellowship of the Ring")
                .WithInfo(2, 1, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Ally("Mithlond Sea-watcher", "", Sphere.Tactics, 2, 1, 1, 0, 2)
                .WithGeneric()
                .WithTraits("Noldor.", "Warrior.")
                .WithText("While the top card of your discard pile is an ally, Mithlond Sea-watcher gets +2 Attack and gains ranged.")
                .WithFlavor("But it was an old tradition that away over there stood the Grey Havens, from which at times elven-ships set sail, never to return.\r\n-The Fellowship of the Ring")
                .WithInfo(3, 3, Artist.Owen_William_Weber));
            Cards.Add(Card.Event("Skyward Volley", "", Sphere.Tactics, 2)
                .WithText("As an additional cost to play Skyward Volley, exhaust a ranged character you control.\r\nCombat Action: Deal 2 damage to an enemy engaged with a player. Resolve that effect again for each copy of Skyward Volley currently in your discard pile (you may choose different targets).")
                .WithInfo(4, 3, Artist.Christina_Davis));
            Cards.Add(Card.Attachment("Grappling Hook", "", Sphere.Tactics, 1)
                .WithTraits("Item.")
                .WithText("Attach to a character.\r\nQuest Action: Discard Grappling Hook and exhaust attached character to commit attached character to the quest, using its Attack instead of its Willpower (or instead of its Defense if the current quest has the siege keyword).")
                .WithInfo(5, 3, Artist.Kara_Williams));
            Cards.Add(Card.Ally("Warden of the Havens", "", Sphere.Leadership, 2, 0, 1, 1, 3)
                .WithGeneric()
                .WithTraits("Noldor.", "Warrior.")
                .WithText("While the top card of your discard pile is an attachment, Warden of the Havens gets +2 Defense and gains sentinel.")
                .WithFlavor("\"...and if he comes, assailing the White Towers and the Havens, hereafter the Elves may have no escape from the lengthening shadows of Middle-earth.\"\r\n-Galdor, The Fellowship of the Ring")
                .WithInfo(6, 3, Artist.Dleoblack));
            Cards.Add(Card.Event("Anchor Watch", "", Sphere.Leadership, 2)
                .WithText("Response: After an enemy is declared as an attacker against you, declare an exhausted character you control as the defender. Resolve that effect again for each copy of Anchor Watch currently in your discard pile (all chosen characters are defending against this attack).")
                .WithInfo(7, 3, Artist.Adam_Schumpert));
            Cards.Add(Card.Attachment("Mariner's Compass", "", Sphere.Leadership, 1)
                .WithTraits("Item.")
                .WithText("Attach to a Leadership or a Scout character.\r\nResponse: At the beginning of the travel phase, exhaust Mariner's Compass and attached character to search the top 5 cards of the encounter deck for a location. Switch that location with a location in the staging area. Shuffle the encounter deck.")
                .WithInfo(8, 3, Artist.Lucas_Durham));
            Cards.Add(Card.Ally("Lindon Navigator", "", Sphere.Lore, 2, 2, 1, 1, 2)
                .WithGeneric()
                .WithTraits("Noldor.", "Scout.")
                .WithText("Lindon Navigator does not exhaust to commit to a quest, and can commit to quests while exhausted.\r\nForced: After resolving a quest to which Lindon Navigator was committed, either discard it from play or discard 1 card from your hand.")
                .WithInfo(9, 3, Artist.Tiziano_Baracchi));
            Cards.Add(Card.Event("The Evening Star", "", Sphere.Lore, 2)
                .WithText("Action: Place 2 progress on any location. Resolve that effect again for each copy of The Evening Star currently in your discard pile (you may choose new targets).")
                .WithFlavor("...for ever still a herald on\r\nar errand that should never rest\r\nto bear his shining lamp afar,\r\nthe Flammifer of Westernesse.\r\n-The Fellowship of the Ring")
                .WithInfo(10, 3, Artist.Katy_Grierson));
            Cards.Add(Card.Attachment("Explorer's Almanac", "", Sphere.Lore, 0)
                .WithGeneric()
                .WithTraits("Item.")
                .WithText("Attach to a location in the staging area.\r\nProgress from questing successfully may be placed on the attached location before it is placed on the current quest.")
                .WithInfo(11, 3, Artist.Ed_Mattinian));
            Cards.Add(Card.Ally("Sailor of Lune", "", Sphere.Spirit, 2, 1, 1, 0, 2)
                .WithGeneric()
                .WithTraits("Noldor.", "Scout.")
                .WithText("While the top card of your discard pile is an event, Sailor of Lune gets +1 Willpower and gains: \"Cannot be damaged while committed to the quest.\"")
                .WithFlavor("\"They are sailing, sailing, sailing over the Sea, they are going into the West and leaving us,\" said Sam, half chanting the words, shaking his head sadly and solemnly.\r\n-The Fellowship of the Ring")
                .WithInfo(12, 3, Artist.Owen_William_Weber));
            Cards.Add(Card.Event("Elwing's Flight", "", Sphere.Spirit, 2)
                .WithText("Quest Action: Ready a questing character and give that character +1 Willpower until the end of the phase. Resolve that effect again for each copy of Elwing's Flight currently in your discard pile (you may choose different targets).")
                .WithFlavor("There flying Elwing came to him\r\nand flame was in the darkness lit;\r\nmore bright than light of diamond\r\nthe fire upon her carcanet.\r\n-The Fellowship of the Ring")
                .WithInfo(13, 3, Artist.A_M_Sartor));
            Cards.Add(Card.Attachment("To the Sea, to the Sea!", "", Sphere.Spirit, 1)
                .WithUnique()
                .WithTraits("Song.")
                .WithText("Attach to a Noldor character.\r\nAction: Exhaust To the Sea, to the Sea! and discard X cards from your hand to reduce the cost of the next Noldor ally played this phase by X (to a minimum of 1).")
                .WithFlavor("To the Sea, to the Sea! The white gulls are crying,\r\nThe wind is blowing, and the white foam is flying.\r\n-The Return of the King")
                .WithInfo(14, 3, Artist.Tawny_Fritzinger));
            Cards.Add(Card.Attachment("Narya", "", Sphere.Neutral, 2)
                .WithUnique()
                .WithTraits("Ring.", "Artifact.")
                .WithText("Attach to Círdan the Shipwright or Gandalf.\r\nAttached character gains a Leadership resource icon.\r\nAction: Exhaust Narya and attached character to choose and ready up to 2 allies. Each of those allies gets +1 Attack and +1 Defense until the end of the phase.")
                .WithFlavor("\"For this is the Ring of Fire, and with it you may rekindle hearts in a world that grows chill.\"\r\n-Círdan, The Return of the King")
                .WithInfo(15, 3, Artist.Lucas_Durham));


            Cards.Add(Card.ShipEnemy("Scouting Ship", string.Empty, 35, 2, 5, 2, 7)
                .WithGeneric()
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 1.")
                .WithText("Cannot have attachments. Scouting Ship gets -15 engagement cost while you are off course (Cloudy, Rainy, or Stormy).")
                .WithFlavor("All too well they could see for themselves the black sails.\r\n-The Return of the King")
                .WithInfo(22, 3, Artist.Michael_Rasmussen));
            Cards.Add(Card.Location("Starlit Sea", "", "Voyage Across Belegaer", 3, 2)
                .WithTraits("Ocean.")
                .WithText("While you are off-course (Cloudy, Rainy, or Stormy), Starlit Sea gains: \"Travel: Raise each player’s threat by 3.\"")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if you are off-course).")
                .WithInfo(23, 2, Artist.Mateusz_Ozminski));

            Cards.Add(Card.ObjectiveAlly("Calphon", "", "The Fate of Númenor", 1, 0, 1, 3)
                .WithUnique()
                .WithTraits("Gondor.", "Noble.")
                .WithText("The first player gains control of Calphon.\r\nAction: Exhaust Calphon to look at the bottom card of your deck. Then, you may switch that card with a card in your hand.\r\nIf Calphon leaves play, the players lose the game.")
                .WithInfo(28, 1, Artist.Ilich_Henriquez));

            Cards.Add(Card.Location("Steep Plateau", "", "The Fate of Númenor", 1, 3)
                .WithTraits("Hills.")
                .WithText("Response: After Steep Plateau is explored, peek at the facedown side of an Uncharted location in the staging area.")
                .WithShadow("Shadow: Discard the bottom card of the defending player’s deck. If that card’s printed cost is 2 or less, attacking enemy gets +2 Attack.")
                .WithInfo(32, 3, Artist.Florian_Devos));

            Cards.Add(Card.Objective("The Havens Burn", "", "Raid on the Grey Havens")
                .WithText("Forced: When a card is placed underneath The Havens Burn, reveal the top card of the encounter deck.\r\nIf there are X or more cards underneath The Havens Burn, the Corsairs have destroyed the Elven fleet and the players lose the game. X is 3 more than the number of players in the game.")
                .WithInfo(38, 1, Artist.Nate_Abell));
            Cards.Add(Card.Location("Dream-chaser", "", "Raid on the Grey Havens", 2, 254)
                .WithUnique()
                .WithSlugIncludesType()
                .WithTraits("Grey Havens.", "Ship.")
                .WithKeywords("Aflame 12.")
                .WithText("Immune to player card effects.\r\nThe players cannot travel to the Dream-chaser.\r\nWhen the Dream-chaser is placed underneath The Havens Burn, the players lose the game.")
                .WithInfo(39, 1, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Enemy("Corsair Arsonist", "", "Raid on the Grey Havens", 28, 2, 2, 1, 3)
                .WithTraits("Corsair.")
                .WithText("When Revealed: Either deal 2 damage to an Aflame location in play, or search the encounter deck and discard pile for an Aflame location with the highest Aflame X value, and add it to the staging area.")
                .WithInfo(40, 3, Artist.Leanna_Teneycke));

            Cards.Add(Card.Location("Burning Piers", "", "Raid on the Grey Havens", 1, 3)
                .WithTraits("Grey Havens.")
                .WithKeywords("Aflame 5.")
                .WithText("Burning Piers gets +1 Threat for each damage on it.\r\nForced: When Burning Piers is placed underneath The Havens Burn, deal 3 damage to The Dream-chaser.")
                .WithShadow("Shadow: Add Burning Piers to the staging area.")
                .WithInfo(43, 2, Artist.Lukasz_Jaskolski));

            Cards.Add(Card.Location("Elven Wave-runner", "", " Raid on the Grey Havens", 3, 3)
                .WithTraits("Grey Havens.", "Ship.")
                .WithKeywords("Aflame 3.")
                .WithText("Response: After Elven Wave-runner is added to the victory display, each player draws 1 card.")
                .WithShadow("Shadow: If attacking enemy is a Raider, discard a card at random from your hand and place 1 resource on attacking enemy.")
                .WithInfo(46, 2, Artist.Katy_Grierson));
            Cards.Add(Card.Location("Elven Caravel", "", "Raid on the Grey Havens", 3, 5)
                .WithTraits("Grey Havens.", "Ship.")
                .WithKeywords("Aflame 4.")
                .WithText("Travel: Each player must assign damage among characters he controls equal to the amount of damage on Elven Caravel.\r\nForced: When Elven Caravel is placed underneath The Havens Burn, deal 1 damage to each character in play.")
                .WithInfo(47, 2, Artist.Nate_Abell));

            Cards.Add(Card.Treachery("The Fires Spread", "", "Raid on the Grey Havens")
                .WithKeywords("Doomed 2.")
                .WithText("When Revealed: Deal 1 damage to each Aflame location in play. If less than 3 total damage is dealt by this effect, The Fires Spread gains surge.")
                .WithShadow("Shadow: If this attack destroys a character, deal 1 damage to each Aflame location in play.")
                .WithInfo(49, 2, Artist.Michael_Rasmussen));
            Cards.Add(Card.Location("Calm Waters", "", "Vast Oceans", 1, 4)
                .WithTraits("Ocean.")
                .WithText("While Calm Waters is the active location, look at 2 additional cards from the top of the encounter deck during each Sailing test.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if attacking enemy is a Ship Enemy).")
                .WithInfo(50, 2, Artist.Lukasz_Jaskolski));

            Cards.Add(Card.Location("Waterspout", "", "", 2, 4)
                .WithTraits("Ocean.")
                .WithText("While your heading is at the worst setting (Stormy), when faced with the option to travel, the players must travel to Waterspout, if able.\r\nForced: After traveling to Waterspout, deal 4 damage to each Ship objective.")
                .WithInfo(54, 2, Artist.Unknown));
            Cards.Add(Card.Treachery("Sudden Storm", "", "Stormy Weather")
                .WithTraits("Weather.")
                .WithText("When Revealed: Either shift your heading off-course or deal 1 damage to each exhausted character.")
                .WithShadow("Shadow: Excess damage from this attack is dealt to a Ship objective you control.")
                .WithInfo(55, 3, Artist.Simon_Dominic));
            Cards.Add(Card.Treachery("Winds of Wrath", "", "Stormy Weather")
                .WithTraits("Weather.")
                .WithText("When Revealed: If you are off-course, deal 1 damage to each character in play. If your heading is at the worst setting (Stormy), this effect cannot be canceled.")
                .WithShadow("Shadow: Either shift your heading off-course or treat this attack as undefended.")
                .WithInfo(56, 3, Artist.Nate_Abell));

            Cards.Add(Card.ShipEnemy("Corsair Warship", "Umbar Navy", 44, 3, 8, 4, 9)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 3.")
                .WithText("Cannot have attachments.\r\nWhile Corsair Warship is in the staging area, it cannot be damaged and gains archery 4.")
                .WithFlavor("...ships of great draught with many oars, and with black sails bellying in the breeze. —The Return of the King")
                .WithInfo(58, 2, Artist.Michael_Rasmussen));
            Cards.Add(Card.Treachery("Boarding Party", "", "Umbar Navy")
                .WithText("When Revealed: Each player reveals the top card of the Corsair deck and puts it into play, engaged with him.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if you control an exhausted Ship objective).")
                .WithInfo(59, 2, Artist.Darek_Zabrocki));
            Cards.Add(Card.Enemy("Southron Sailor", "", "Corsair Pirates", 28, 0, 2, 1, 4)
                .WithTraits("Corsair.")
                .WithText("While Southron Sailor is engaged with you, each Ship enemy engaged with you contributes its Threat to the total Threat in the staging area.")
                .WithFlavor("\"There is a great fleet drawing near to the mouths of Anduin, manned by the corsairs of Umbar in the South.\" —Beregond, The Return of the King")
                .WithInfo(60, 2, Artist.Leanna_Teneycke));
            Cards.Add(Card.Enemy("Cunning Pirate", "", "Corsair Pirates", 36, 1, 2, 2, 4)
                .WithTraits("Corsair.", "Raider.")
                .WithText("Cunning Pirate gets +1 Attack and +1 Defense for each resource on it.\r\nForced: When Cunning Pirate engages you, discard an attachment you control and place resources on Cunning Pirate equal to that attachment's printed cost.")
                .WithInfo(61, 3, Artist.Adam_Lane));

            Cards.Add(Card.Enemy("Corsair Infiltrator", "", "Corsair Raiders", 16, 2, 3, 3, 2)
                .WithTraits("Corsair.", "Raider.")
                .WithText("Forced: When Corsair Infiltrator attacks, deal it 1 additional shadow card for each resource on it.\r\nForced: After the engaged player collects resources at the beginning of the resource phase, that player moves 1 resource from one of his heroes' pools to Corsair Infiltrator.")
                .WithInfo(65, 2, Artist.Adam_Lane));

            Cards.Add(Card.Treachery("Battle-Hardened", "", "Corsair Raiders")
                .WithText("When Revealed: Place 1 resource on each Raider enemy in play. Each engaged non-Ship enemy makes an immediate attack. If there are no engaged non-Ship enemies, Battle-Hardened gains surge.")
                .WithShadow("Shadow: If the attacking enemy is a Raider, place 2 resources on it.")
                .WithInfo(67, 2, Artist.Emile_Denis));
            Cards.Add(Card.Enemy("Drowned Dead", "", "Drowned Dead", 32, 2, 4, 3, 3)
                .WithTraits("Undead.")
                .WithText("Forced: When Drowned Dead attacks and destroys an ally by an attack, place that ally on the bottom of your deck.")
                .WithShadow("Shadow: If this attack destroys an ally, place that ally on the bottom of your deck.")
                .WithInfo(68, 3, Artist.Chris_Grun));
            Cards.Add(Card.Enemy("Soulless Cadaver", "", "Drowned Dead", 38, 3, 3, 2, 4)
                .WithTraits("Undead.")
                .WithText("While you are engaged with Soulless Cadaver, your deck cannot be searched.\r\nForced: When Soulless Cadaver engages you, place each card in your hand with printed cost 2 or less on the bottom of your deck.")
                .WithInfo(69, 2, Artist.Helge_C_Balzer));
            Cards.Add(Card.Enemy("Throngs of Unfaithful", "", "Drowned Dead", 26, 1, 2, 0, 4)
                .WithTraits("Undead.")
                .WithKeywords("Surge.")
                .WithText("Forced: When Throngs of Unfaithful is defeated, discard the bottom card of the engaged player's deck. If that card’s printed cost is 2 or less, return Throngs of the Unfaithful to the top of the encounter deck.")
                .WithInfo(70, 2, Artist.Helge_C_Balzer));
            Cards.Add(Card.Treachery("Curse of the Downfallen", "", "Drowned Dead")
                .WithText("When Revealed: Deal 1 damage to each ally with printed cost 2 or less. Place each ally that is destroyed by this effect on the bottom of its owner's deck.")
                .WithShadow("Shadow: Discard the bottom card of your deck. If that card's printed cost is 2 or less, attacking enemy makes an additional attack after this one.")
                .WithInfo(71, 2, Artist.Piya_Wannachaiwong));

            Cards.Add(Card.Location("Drowned Graves", "", "Ruins of Númenor", 2, 2)
                .WithTraits("Ruins.")
                .WithText("Forced: After Drowned Graves is flipped to this side while active, discard the top X cards of the encounter deck. Each player adds an Undead enemy discarded from this effect to the staging area. X is 2 more than the number of players in the game.")
                .WithFlavor("...their years lessened as their fear of death grew, and their joy departed. –The Return of the King")
                .WithInfo(73, 2, Artist.Juan_Carlos_Barquet));
            Cards.Add(Card.Location("Cursed Temple", "", "Ruins of Númenor", 1, 3)
                .WithTraits("Ruins.")
                .WithText("While Cursed Temple is the active location, characters with less than 2 Willpower do not ready during the refresh phase.")
                .WithFlavor("It was not long before he had bewitched the King and was master of his counsel... –The Return of the King")
                .WithInfo(74, 2, Artist.Davis_Engel));
            Cards.Add(Card.Treachery("Aimless Wandering", "", "Ruins of Númenor")
                .WithText("When Revealed: The players, as a group, must remove characters with a total of at least X [Willpower] from the quest. X is the number of Uncharted locations in the staging area. The first player may give Aimless Wandering doomed 2 to look at the facedown side of an Uncharted location in the staging area.")
                .WithInfo(75, 3, Artist.David_Ogilvie));
            Cards.Add(Card.Enemy("Captain Sahír", "", "The Stormcaller Elite", 4, 6, 6, 2, 5)
                .WithTypeBasedSlug()
                .WithUnique()
                .WithNormalizedTitle("Captain Sahir")
                .WithTraits("Corsair.", "Raider.")
                .WithText("Captain Sahír engages the first player.\r\nFor each point of damage Captain Sahír would take, discard 1 resource from him and cancel that damage.\r\nForced: After Captain Sahír attacks, place 2 resource tokens on him (4 instead if his attack destroyed a character).")
                .WithVictoryPoints(6)
                .WithInfo(76, 1, Artist.Sara_Winters));
            Cards.Add(Card.ObjectiveAlly("Captain Sahír", "", "The Stormcaller Elite", 0, 0, 2, 5)
                .WithTypeBasedSlug()
                .WithUnique()
                .WithNormalizedTitle("Captain Sahir")
                .WithTraits("Corsair.", "Raider.")
                .WithText("The first player gains control of Captain Sahír.\r\nCaptain Sahír gets +1 Willpower and +1 Attack for each resource on him (max +6).\r\nAction: Spend 1 resource from a hero you control to place 1 resource on Captain Sahír. (Limit once per round).\r\nIf Captain Sahír leaves play, the players lose.")
                .WithInfo(77, 1, Artist.Sara_Winters));

            Cards.Add(Card.ShipObjective("Dream-chaser", "The Dream-chaser's Fleet", 5, 4, 4, 18)
                .WithSlugIncludesType()
                .WithTraits("Grey Havens.", "Ship.")
                .WithKeywords("Sentinel.")
                .WithText("Immune to player card effects. Sentinel.\r\nThe Dream-chaser can always be committed to sailing tests (even if you are not the first player), and counts as 2 characters when committed to a Sailing test.\r\nIf the Dream-chaser is destroyed, the players lose the game.")
                .WithInfo(80, 1, Artist.Unknown));
            Cards.Add(Card.ShipObjective("Dawn Star", "The Dream-chaser's Fleet", 3, 3, 4, 16)
                .WithTraits("Gondor.", "Ship.")
                .WithKeywords("Sentinel.")
                .WithText("Immune to player card effects. Sentinel.\r\nRaise your starting threat by 3.\r\nDraw 1 additional card during the resource phase.\r\nIf the Dawn Star is destroyed, its controller is eliminated from the game.")
                .WithInfo(81, 1, Artist.Titus_Lunter));
            Cards.Add(Card.ShipObjective("Nárelenya", "The Dream-chaser's Fleet", 3, 3, 5, 15)
                .WithNormalizedTitle("Narelenya")
                .WithTraits("Grey Havens.", "Ship.")
                .WithKeywords("Sentinel.")
                .WithText("Immune to player card effects.\r\nReduce the cost of the first ally you play each round by 1.\r\nIf the Nárelenya is destroyed, its controller is eliminated from the game.")
                .WithInfo(82, 1, Artist.Nele_Klumpe));
            Cards.Add(Card.ShipObjective("Silver Wing", "The Dream-chaser's Fleet", 2, 4, 2, 14)
                .WithTraits("Gondor.", "Ship.")
                .WithKeywords("Sentinel.", "Ranged.")
                .WithText("Immune to player card effects. Sentinel. Ranged.\r\nReduce your starting threat by 3.\r\nEach hero you control gets +1 Attack.\r\nIf the Silver Wing is destroyed, its controller is eliminated from the game.")
                .WithInfo(83, 1, Artist.Unknown));
        }
    }
}