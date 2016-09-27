using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class AStormOnCobasHaven : CardSet
    {
        private const string setName = "A Storm on Cobas Haven";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "ASoCH";
            Number = 39;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dream-chaser";

            Cards.Add(Card.Hero("Na'asiyah", string.Empty, Sphere.Tactics, 8, 1, 2, 2, 4)
                .WithTraits("Corsair.", "Warrior.")
                .WithText("Resources in Na'asiyah's resource pool cannot be used to pay for allies.\r\nAction: While Na'asiyah is attacking or defending, pay 1 resource from her resource pool to give her +2 Attack or +2 Defense for this attack.")
                .WithInfo(109, 1, Artist.Sara_Winters));
            Cards.Add(Card.Attachment("Rune-master", string.Empty, Sphere.Leadership, 1)
                .WithUnique()
                .WithTraits("Title.")
                .WithText("Attach to a Ranger or Leadership hero.\r\nResponse: After a Signal attachment is attached to a hero, exhaust Rune-master to add 1 resource to that hero's resource pool.")
                .WithInfo(110, 3, Artist.Kim_Sokol));
            Cards.Add(Card.Event("Terrible to Behold", string.Empty, Sphere.Leadership, 1)
                .WithText("Response: After you declare a Noble character as a defender against an attack made by an engaged enemy, return that enemy to the staging area. Then, cancel the attack.")
                .WithFlavor("So great a power and royalty was revealed in Aragorn...that many of the wild men paused, and looked back over their shoulders to the valley, and some looked up doubtfully at the sky.\r\n-The Two Towers")
                .WithInfo(111, 3, Artist.Jason_Cheeseman_Meyer));
            Cards.Add(Card.Ally("Veteran Sword-elf", string.Empty, Sphere.Tactics, 3, 1, 1, 1, 3)
                .WithGeneric()
                .WithTraits("Noldor.", "Warrior.")
                .WithText("~Veteran Sword-elf gets +1 Attack and +1 Defense for each copy of ~Veteran Sword-elf in your discard pile.")
                .WithFlavor("The elves were the first to charge. Their hatred for the goblins is cold and bitter.\r\n-The Hobbit")
                .WithInfo(112, 3, Artist.Unknown));
            Cards.Add(Card.Attachment("Vigilant Guard", string.Empty, Sphere.Tactics, 3)
                .WithGeneric()
                .WithTraits("Skill.")
                .WithText("Attach to a Warrior character. Limit 1 per character.\r\nAttached character gets +2 hit points.\r\nResponse: When another character would be assigned any amount of damage, place 1 of that damage on attached character instead.")
                .WithInfo(113, 3, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Event("Knife-work", "", Sphere.Tactics, 1)
                .WithText("Action: Choose a player. Each enemy engaged with that player gets -1 Defense until the end of the phase. Then, the players as a group may spend 2 Lore resources to have the chosen player draw 1 card each time he attacks and destroys an enemy this phase.")
                .WithFlavor("\"Good!\" said Legolas. \"But my count is now two dozen. It has been knife-work up here.\" -The Two Towers")
                .WithInfo(114, 3, Artist.Joshua_Cairos));
            Cards.Add(Card.Ally("Linhir Sea-captain", string.Empty, Sphere.Spirit, 3, 2, 0, 1, 2)
                .WithGeneric()
                .WithTraits("Gondor.")
                .WithText("Response: After you play Linhir Sea-captain from your hand, if you paid all of its resouce cost from a single hero's resource pool, both that hero and Linhir Sea-captain do not exhaust to quest this round.")
                .WithInfo(115, 3, Artist.Kim_Sokol));
            Cards.Add(Card.Attachment("Windfola", string.Empty, Sphere.Spirit, 1)
                .WithUnique()
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Spirit hero, or to Éowyn.\r\nAttached character gets +1 Willpower.\r\nResponse: After attached character is removed from the quest, exhaust Windfola to commit attached hero to the quest.")
                .WithFlavor("...the great grey steed Windfola made little of the burden; for Dernhelm was less in weight than many men, though lithe and well-knit in frame. -The Return of the King")
                .WithInfo(116, 3, Artist.Sandara_Tang));
            Cards.Add(Card.Ally("Ioreth", "", Sphere.Lore, 0, 0, 0, 0, 1)
                .WithUnique()
                .WithTraits("Gondor.", "Healer.")
                .WithText("Cannot attack or defend.\r\nAction: Spend 1 Lore resource and exhaust Ioreth. Then, heal 3 points of damage on a character. Any player may trigger this action.")
                .WithFlavor("Thus spake Ioreth, wise-woman of Gondor: The hands of the king are the hands of a healer, and so shall the rightful king be known. -The Return of the King")
                .WithInfo(117, 3, Artist.Aleksander_Karcz));
            Cards.Add(Card.Event("The Houses of Healing", string.Empty, Sphere.Lore, 5)
                .WithText("Response: You may exhaust any number of Healer characters you control as part of this card's cost. Reduce the cost to play this card by 1 for each Healer character you exhaust in this way.\r\nRefresh Action: Choose a hero in any player's discard pile. Put that hero into play under its owner's control, with 1 damage token on it.")
                .WithInfo(118, 3, Artist.Mariusz_Gandzel));
            Cards.Add(Card.Event("Justice Shall Be Done", "", Sphere.Neutral, 0)
                .WithText("Limit 1 per deck.\r\nPlanning Action: Add Justice Shall Be Done to the victory display to draw 3 cards and add 3 resources to the resource pool of each hero you control. At the end of the round, you are eliminated from the game.")
                .WithFlavor("\"...it is the last move in a great jeopardy, and for one side or the other it will bring the end of the game.\"\r\n-Aragorn, The Return of the King")
                .WithVictoryPoints(1)
                .WithInfo(119, 3, Artist.Dmitry_Prosvirnin));
        }
        
    }
}