using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheLandOfShadow : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Land of Shadow";
            Abbreviation = "TLoS";
            Number = 1006;
            SetType = Models.SetType.Saga_Expansion;
            Cycle = "The Lord of the Rings";

            Cards.Add(new Card()
            {
                Title = "Frodo Baggins",
                IsUnique = true,
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Hero,
                Sphere = Models.Sphere.Fellowship,
                ThreatCost = 0,
                Willpower = 2,
                Attack = 1,
                Defense = 2,
                HitPoints = 2,
                Traits = new List<string> { "Hobbit.", "Ring-bearer." },
                Text = "Action: Spend 1 Fellowship resource and exhaust The One ~Ring to give Frodo Baggins +2 Willpower and +2 Attack until the end of the round.",
                FlavorText = "\"It's my doom, I think, to go to that Shadow yonder, so that a way will be found.\" -The Two Towers",
                Number = 1,
                Quantity = 1,
                Artist = Artist.Melanie_Maier
            });
            Cards.Add(Card.Hero("Faramir", "", Sphere.Leadership, 11, 2, 2, 2, 5)
                .WithTraits("Gondor.", "Noble.", "Ranger.")
                .WithKeywords("Ranged.")
                .WithText("Response: After you engage an enemy, ready an ally you control. (Limit once per phase.)")
                .WithFlavor("\"That will be the Captain: he can master both beasts and men\" -Beregond, The Return of the King")
                .WithInfo(2, 1, Artist.Jason_Cheeseman_Meyer));
            Cards.Add(Card.Hero("Damrod", "", Sphere.Lore, 9, 2, 2, 1, 4)
                .WithTraits("Gondor.", "Ranger.")
                .WithText("Reduce the cost of the first Trap card you play each round by 1 (to a minimum of 0).\r\nResponse: After a Trap card you control is attached to an enemy, draw 1 card.")
                .WithFlavor("\"See! Some of the Southrons have broken from the trap and are flying from the road.\" -The Two Towers")
                .WithInfo(3, 1, Artist.Joshua_Cairos));
            Cards.Add(Card.Ally("Anborn", "", Sphere.Leadership, 4, 1, 3, 1, 3)
                .WithTraits("Gondor.", "Ranger.")
                .WithText("Response: After an enemy is added to the staging area, exhaust Anborn to give that enemy +5 enagement cost until the end of the round. Then, deal 1 damage to that enemy.")
                .WithFlavor("\"Now I have him at arrow-point.\" -The Two Towers")
                .WithInfo(4, 3, Artist.Owen_William_Weber));
            Cards.Add(Card.Ally("Mablung", "", Sphere.Lore, 2, 2, 1, 0, 2)
                .WithTraits("Gondor.", "Ranger.")
                .WithText("Response: After Mablung enters play, choose an enemy to get +5 engagement cost until the end of the round. Then, you may engage that enemy, or return it to the staging area.")
                .WithFlavor("\"But still we will not sit idle and let Him do all as He would.\" -The Two Towers")
                .WithInfo(5, 3, Artist.Beth_Sobel));
            Cards.Add(Card.Ally("Skinbark", "", Sphere.Tactics, 3, 0, 4, 2, 3)
                .WithTraits("Ent.")
                .WithText("Cannot have restricted attachments. Enters play exhausted.\r\nWhile Skinbark is attacking alone against an Orc enemy, that enemy does not count its Defense.")
                .WithFlavor("\"He was wounded by the Orcs, and many of his folk and his tree-herds have been murdered and destroyed.\" -Treebeard, The Two Towers")
                .WithInfo(6, 3, Artist.Dimitri_Bielak));
            Cards.Add(Card.Ally("Gamling", "", Sphere.Spirit, 3, 1, 1, 2, 2)
                .WithTraits("Rohan.", "Warrior.")
                .WithText("Response: After a Rohan ally you control is discarded from play, exhaust Gamling to return that ally to your hand.")
                .WithFlavor("\"...we have a thousand fit to fight on foot,\" said Gamling, an old man, the leader of those that watched the Dike. -The Two Towers")
                .WithInfo(7, 3, Artist.Melanie_Maier));
            Cards.Add(Card.Attachment("Staff of Lebethron", "", Sphere.Leadership, 1)
                .WithTraits("Item.")
                .WithText("Attach to a Gondor or Hobbit hero. Restricted.\r\nResponse: After attached hero exhausts to defend an attack from an enemy with engagement cost higher than your threat, exhaust Staff of Lebethron to discard a shadow card from that enemy.")
                .WithFlavor("\"They are made of the fair tree lebethron, beloved of the woodwrights of Gondor...\" -Faramir, The Two Towers")
                .WithInfo(8, 3, Artist.Kara_Williams));
            Cards.Add(Card.Attachment("Ambush", "", Sphere.Lore, 2)
                .WithTraits("Condition.", "Trap.")
                .WithText("Play Ambush into the staging area unattached. If unattached, attach Ambush to the next eligible enemy that enters the staging area.\r\nCombat Action: The engaged player discards Ambush to declare an attack against the attached enemy.")
                .WithFlavor("\"But we have a new errand on this journey: we come to ambush the Men of Harad.\" -Mablung, The Two Towers")
                .WithInfo(9, 3, Artist.Cristina_Vela));
            Cards.Add(Card.Attachment("Snowmane", "", Sphere.Spirit, 1)
                .WithUnique()
                .WithTraits("Mount.")
                .WithText("Attach to a Rohan hero. Restricted.\r\nIf attached hero is Theoden, Snowmane loses the restricted keyword.\r\nResponse: After attached hero quests successfully, ready attached hero.")
                .WithFlavor("Suddenly the king cried to Snowmane and the horse sprang away. -The Return of the King")
                .WithInfo(10, 3, Artist.Julepe));
            Cards.Add(Card.Event("Taste it Again!", "", Sphere.Leadership, 1)
                .WithText("Response: After a hero you control defends an attack made by an enemy with engagement cost higher than your threat, ready that hero. Until the end of the phase, that hero gets +2 Attack while attacking that enemy.")
                .WithFlavor("\"We're going on; but we'll settle with you first. Come on, and taste it again!\" -Sam Gamgee, The Two Towers")
                .WithInfo(11, 3, Artist.Piya_Wannachaiwong));
            Cards.Add(Card.Event("In the Shadows", "", Sphere.Lore, 3)
                .WithText("Lower the cost to play In the Shadows by 1 for each Hobbit or Ranger hero you control.\r\nCombat Action: Each enemy engaged with you with engagement cost higher than your threat gets -1 Attack and -1 Defense until the end of the phase.")
                .WithFlavor("He could see them stealing up the slopes, singly or in long files, keeping always to the shade of grove or thicket... -The Two Towers")
                .WithInfo(12, 3, Artist.Piya_Wannachaiwong));
            Cards.Add(Card.Event("Speak Your Promise!", "", Sphere.Fellowship, 1)
                .WithText("Action: Ready the Ring-bearer to choose an enemy engaged with you. If the Ring-bearer's Willpower is greater than that enemy’s Threat, lower its Attack and Defense by the difference until the end of the phase.")
                .WithFlavor("For a moment it appeared to Sam that his master had grown and Gollum had shrunk... -The Two Towers")
                .WithInfo(13, 3, Artist.Cristina_Vela));
        }
    }
}