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
            Cards.Add(Card.Attachment("Grappling Hook", "", Sphere.Tactics, 1)
                .WithTraits("Item.")
                .WithText("Attach to a character.\r\nQuest Action: Discard Grappling Hook and exhaust attached character to commit attached character to the quest, using its Attack instead of its Willpower (or instead of its Defense if the current quest has the siege keyword).")
                .WithInfo(3, 3, Artist.Unknown));
            Cards.Add(Card.Attachment("Mariner's Compass", "", Sphere.Leadership, 1)
                .WithTraits("Item.")
                .WithText("Attach to a Leadership or a Scout character.\r\nResponse: At the beginning of the travel phase, exhaust Mariner's Compass and attached character to search the top 5 cards of the encounter deck for a location. Switch that location with a location in the staging area. Shuffle the encounter deck.")
                .WithInfo(4, 3, Artist.Unknown));
            Cards.Add(Card.Ally("Mithlond Sea-watcher", "", Sphere.Tactics, 2, 1, 1, 0, 2)
                .WithGeneric()
                .WithTraits("Noldor.", "Warrior.")
                .WithText("While the top card of your discard pile is an ally, Mithlond Sea-watcher gets +2 Attack and gains ranged.")
                .WithFlavor("But it was an old tradition that away over there stood the Grey Havens, from which at times elven-ships set sail, never to return.\r\n-The Fellowship of the Ring")
                .WithInfo(5, 3, Artist.Owen_William_Weber));
            Cards.Add(Card.Ally("Warden of the Havens", "", Sphere.Leadership, 2, 0, 1, 1, 3)
                .WithGeneric()
                .WithTraits("Noldor.", "Warrior.")
                .WithText("While the top card of your discard pile is an attachment, Warden of the Havens gets +2 Defense and gains sentinel.")
                .WithFlavor("\"...and if he comes, assailing the White Towers and the Havens, hereafter the Elves may have no escape from the lengthening shadows of Middle-earth.\"\r\n-Galdor, The Fellowship of the Ring")
                .WithInfo(6, 3, Artist.Dleoblack));
            Cards.Add(Card.Event("Skyward Volley", "", Sphere.Tactics, 2)
                .WithText("As an additional cost to play Skyward Volley, exhaust a ranged character you control.\r\nCombat Action: Deal 2 damage to an enemy engaged with a player. Resolve that effect again for each copy of Skyward Volley currently in your discard pile (you may choose different targets).")
                .WithInfo(7, 3, Artist.Unknown));
            Cards.Add(Card.Event("Anchor Watch", "", Sphere.Leadership, 2)
                .WithText("Response: After an enemy is declared as an attacker against you, declare an exhausted character you control as the defender. Resolve that effect again for each copy of Anchor Watch currently in your discard pile (all chosen characters are defending against this attack).")
                .WithInfo(8, 3, Artist.Unknown));
            Cards.Add(Card.Ally("Lindon Navigator", "", Sphere.Lore, 2, 2, 1, 1, 2)
                .WithGeneric()
                .WithTraits("Noldor.", "Scout.")
                .WithText("Lindon Navigator does not exhaust to commit to a quest, and can commit to quests while exhausted.\r\nForced: After resolving a quest to which Lindon Navigator was committed, either discard it from play or discard 1 card from your hand.")
                .WithInfo(9, 3, Artist.Tiziano_Baracchi));
            Cards.Add(Card.Event("The Evening Star", "", Sphere.Lore, 2)
                .WithText("Action: Place 2 progress on any location. Resolve that effect again for each copy of The Evening Star currently in your discard pile (you may choose new targets).")
                .WithFlavor("...for ever still a herald on\r\nar errand that should never rest\r\nto bear his shining lamp afar,\r\nthe Flammifer of Westernesse.\r\n-The Fellowship of the Ring")
                .WithInfo(10, 3, Artist.Unknown));
            Cards.Add(Card.Attachment("Explorer's Almanac", "", Sphere.Lore, 0)
                .WithGeneric()
                .WithTraits("Item.")
                .WithText("Attach to a location in the staging area.\r\nProgress from questing successfully may be placed on the attached location before it is placed on the current quest.")
                .WithInfo(11, 3, Artist.Unknown));
            Cards.Add(Card.Ally("Sailor of Lune", "", Sphere.Spirit, 2, 1, 1, 0, 2)
                .WithGeneric()
                .WithTraits("Noldor.", "Scout.")
                .WithText("While the top card of your discard pile is an event, Sailor of Lune gets +1 Willpower and gains: \"Cannot be damaged while committed to the quest.\"")
                .WithFlavor("\"They are sailing, sailing, sailing over the Sea, they are going into the West and leaving us,\" said Sam, half chanting the words, shaking his head sadly and solemnly.\r\n-The Fellowship of the Ring")
                .WithInfo(12, 3, Artist.Unknown));
            Cards.Add(Card.Event("Elwing's Flight", "", Sphere.Spirit, 2)
                .WithText("Quest Action: Ready a questing character and give that character +1 Willpower until the end of the phase. Resolve that effect again for each copy of Elwing's Flight currently in your discard pile (you may choose different targets).")
                .WithFlavor("There flying Elwing came to him\r\nand flame was in the darkness lit;\r\nmore bright than light of diamond\r\nthe fire upon her carcanet.\r\n-The Fellowship of the Ring")
                .WithInfo(13, 3, Artist.A_M_Sartor));
            Cards.Add(Card.Attachment("To the Sea, to the Sea!", "", Sphere.Spirit, 1)
                .WithUnique()
                .WithTraits("Song.")
                .WithText("Attach to a Noldor character.\r\nAction: Exhaust To the Sea, to the Sea! and discard X cards from your hand to reduce the cost of the next Noldor ally played this phase by X (to a minimum of 1).")
                .WithFlavor("To the Sea, to the Sea! The white gulls are crying,\r\nThe wind is blowing, and the white foam is flying.\r\n-The Return of the King")
                .WithInfo(14, 3, Artist.Unknown));
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
            Cards.Add(Card.Location("Waterspout", "", "", 2, 4)
                .WithTraits("Ocean.")
                .WithText("While your heading is at the worst setting (Stormy), when faced with the option to travel, the players must travel to Waterspout, if able.\r\nForced: After traveling to Waterspout, deal 4 damage to each Ship objective.")
                .WithInfo(54, 2, Artist.Unknown));
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
                .WithTraits("Grey Havens.", "Ship.")
                .WithText("Immune to player card effects. Sentinel.\r\nThe Dream-chaser can always be committed to sailing tests (even if you are not the first player), and counts as 2 characters when committed to a Sailing test.\r\nIf the Dream-chaser is destroyed, the players lose the game.")
                .WithInfo(80, 1, Artist.Unknown));
            Cards.Add(Card.ShipObjective("Dawn Star", "The Dream-chaser's Fleet", 3, 3, 4, 16)
                .WithTraits("Grey Havens.", "Ship.")
                .WithText("Immune to player card effects. Sentinel.\r\nRaise your starting threat by 3.\r\nDraw 1 additional card during the resource phase.\r\nIf the Dawn Star is destroyed, the players lose the game.")
                .WithInfo(81, 1, Artist.Titus_Lunter));
            Cards.Add(Card.ShipObjective("Silver Wing", "The Dream-chaser's Fleet", 5, 4, 4, 18)
                .WithTraits("Grey Havens.", "Ship.")
                .WithText("Immune to player card effects. Sentinel. Ranged.\r\nReduce your starting threat by 3.\r\nEach hero you control gets +1 Attack.\r\nIf the Silver Wing is destroyed, the players lose the game.")
                .WithInfo(82, 1, Artist.Unknown));
        }
    }
}