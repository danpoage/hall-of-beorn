using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheThingInTheDepths : CardSet
    {
        private const string setName = "The Thing in the Depths";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TTiTD";
            Number = 37;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dream-chaser";

            Cards.Add(Card.Ally("Eldahir", "", Sphere.Leadership, 4, 1, 2, 2, 3)
                .WithUnique()
                .WithTraits("Dúnedain.", "Noble.")
                .WithKeywords("Sentinel.")
                .WithText("Action: Spend 1 Lore resource to look at a facedown shadow card dealt to an engaged enemy. If that card has a shadow effect, Eldahir gets +2 Defense until the end of the phase. Any player may trigger this action. (Limit once per phase.)")
                .WithInfo(31, 3, Artist.Kim_Sokol));
            Cards.Add(Card.Ally("Sam Gamgee", "", Sphere.Spirit, 3, 2, 1, 1, 2)
                .WithUnique()
                .WithTraits("Hobbit.")
                .WithText("Reduce the cost to play Sam Gamgee by 2 if you control Frodo ~Baggins.\r\nResponse: After a player raises his threat, that player may spend 1 Spirit resource to ready Sam Gamgee. He gets +1 Willpower, +1 Attack and +1 Defense until the end of the round. (Limit once per round.)")
                .WithInfo(35, 3, Artist.Andrew_Johanson));
            Cards.Add(Card.Ally("Mirkwood Explorer", "", Sphere.Lore, 3, 2, 1, 0, 2)
                .WithGeneric()
                .WithTraits("Woodman.", "Scout.")
                .WithText("Response: After ~Mirkwood Explorer quests successfully, place 1 progress on it.\r\nAction: Exhaust ~Mirkwood Explorer to move all progress from it to a location in play.")
                .WithInfo(37, 3, Artist.Kim_Sokol));
        }
    }
}