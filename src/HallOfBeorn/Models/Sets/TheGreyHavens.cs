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
                .WithTraits("Noldor.", "Warrior.")
                .WithText("While the top card of your discard pile is an ally, Mithlond Sea-watcher gets +2 Attack and gains ranged.")
                .WithFlavor("But it was an old tradition that away over there stood the Grey Havens, from which at times elven-ships set sail, never to return.\r\n-The Fellowship of the Ring")
                .WithInfo(5, 3, Artist.Owen_William_Weber));
            Cards.Add(Card.Ally("Lindon Navigator", "", Sphere.Lore, 2, 2, 1, 1, 2)
                .WithTraits("Noldor.", "Scout.")
                .WithText("Lindon Navigator does not exhaust to commit to a quest, and can commit to quests while exhausted.\r\nForced: After resolving a quest to which Lindon Navigator was committed, either discard it from play or discard 1 card from your hand.")
                .WithInfo(9, 3, Artist.Tiziano_Baracchi));
            Cards.Add(Card.Event("Elwing's Flight", "", Sphere.Spirit, 2)
                .WithText("Quest Action: Ready a questing character and give that character +1 Willpower until the end of the phase. Resolve that effect again for each copy of Elwing's Flight currently in your discard pile (you may choose different targets).")
                .WithFlavor("There flying Elwing came to him\r\nand flame was in the darkness lit;\r\nmore bright than light of diamond\r\nthe fire upon her carcanet.\r\n-The Fellowship of the Ring")
                .WithInfo(13, 3, Artist.A_M_Sartor));
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