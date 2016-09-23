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

            Cards.Add(Card.Event("Terrible to Behold", string.Empty, Sphere.Leadership, 1)
                .WithText("Response: After you declare a Noble character as a defender against an attack made by an engaged enemy, return that enemy to the staging area. Then, cancel the attack.")
                .WithFlavor("So great a power and royalty was revealed in Aragorn...that many of the wild men paused, and looked back over their shoulders to the valley, and some looked up doubtfully at the sky.\r\n-The Two Towers")
                .WithInfo(111, 3, Artist.Jason_Cheeseman_Meyer));

            Cards.Add(Card.Attachment("Vigilant Guard", string.Empty, Sphere.Tactics, 3)
                .WithGeneric()
                .WithTraits("Skill.")
                .WithText("Attach to a Warrior character. Limit 1 per character.\r\nAttached character gets +2 hit points.\r\nResponse: When another character would be assigned any amount of damage, place 1 of that damage on attached character instead.")
                .WithInfo(113, 3, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Event("Knife-work", "", Sphere.Tactics, 1)
                .WithText("Action: Choose a player. Each enemy engaged with that player gets -1 Defense until the end of the phase. Then, the players as a group may spend 2 Lore resources to have the chosen player draw 1 card each time he attacks and destroys an enemy this phase.")
                .WithFlavor("\"Good!\" said Legolas. \"But my count is now two dozen. It has been knife-work up here.\" -The Two Towers")
                .WithInfo(114, 3, Artist.Joshua_Cairos));

            Cards.Add(Card.Ally("Ioreth", "", Sphere.Lore, 0, 0, 0, 0, 1)
                .WithUnique()
                .WithTraits("Gondor.", "Healer.")
                .WithText("Cannot attack or defend.\r\nAction: Spend 1 Lore resource and exhaust Ioreth. Then, heal 3 points of damage on a character. Any player may trigger this action.")
                .WithFlavor("Thus spake Ioreth, wise-woman of Gondor: The hands of the king are the hands of a healer, and so shall the rightful king be known. -The Return of the King")
                .WithInfo(117, 3, Artist.Aleksander_Karcz));

            Cards.Add(Card.Event("Justice Shall Be Done", "", Sphere.Neutral, 0)
                .WithText("Limit 1 per deck.\r\nPlanning Action: Add Justice Shall Be Done to the victory display to draw 3 cards and add 3 resources to the resource pool of each hero you control. At the end of the round, you are eliminated from the game.")
                .WithFlavor("\"...it is the last move in a great jeopardy, and for one side or the other it will bring the end of the game.\"\r\n-Aragorn, The Return of the King")
                .WithVictoryPoints(1)
                .WithInfo(119, 3, Artist.Dmitry_Prosvirnin));
        }
        
    }
}