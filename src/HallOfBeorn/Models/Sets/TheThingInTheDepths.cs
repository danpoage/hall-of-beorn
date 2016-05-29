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

            Cards.Add(Card.Hero("Lanwyn", "", Sphere.Spirit, 9, 2, 3, 1, 3)
                .WithTraits("Dale.", "Scout.")
                .WithKeywords("Ranged.")
                .WithText("Response: After an encounter card with surge is revealed, either ready Lanwyn or give her +2 Willpower until the end of the phase. (Limit twice per phase.)")
                .WithFlavor("\"The Men of Dale used to have the trick of understanding their language, and used them for messengers to fly to the Men of the Lake...\"\r\n-Thorin, The Hobbit")
                .WithInfo(30, 1, Artist.Aleksander_Karcz));
            Cards.Add(Card.Ally("Eldahir", "", Sphere.Leadership, 4, 1, 2, 2, 3)
                .WithUnique()
                .WithTraits("Dúnedain.", "Noble.")
                .WithKeywords("Sentinel.")
                .WithText("Action: Spend 1 Lore resource to look at a facedown shadow card dealt to an engaged enemy. If that card has a shadow effect, Eldahir gets +2 Defense until the end of the phase. Any player may trigger this action. (Limit once per phase.)")
                .WithInfo(31, 3, Artist.Kim_Sokol));
            Cards.Add(Card.Event("Captain's Wisdom", "", Sphere.Leadership, 0)
                .WithText("Resource Action: Exhaust a Noble hero you control to add 2 resources to that hero's resource pool.")
                .WithFlavor("...in these days men are slow to believe that a captain can be wise and learned in the scrolls of lore and song, as he is, and yet man of hardihood and swift judgement in the field.\r\n-Beregond, The Return of the King")
                .WithInfo(32, 3, Artist.Titus_Lunter));
            Cards.Add(Card.Ally("Master Ironsmith", "", Sphere.Tactics, 3, 1, 1, 1, 2)
                .WithGeneric()
                .WithTraits("Gondor.", "Craftsman.")
                .WithText("Response: After you play Master Ironsmith from your hand, if you paid all of its resource cost from a single hero's resource pool, attach a Weapon or Armor attachment from your hand or discard pile to that hero without paying its resource cost.")
                .WithInfo(33, 3, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Attachment("Raiment of War", "", Sphere.Tactics, 2)
                .WithGeneric()
                .WithTraits("Item.", "Armor.", "Weapon.")
                .WithText("Attach to a Warrior character. Raiment of War counts as 2 Restricted attachments.\r\nAttached character gets +1 Attack, +1 Defense and +2 hit points.")
                .WithFlavor("Now men came bearing raiment of war from the king's hoard...\r\n-The Two Towers")
                .WithInfo(34, 3, Artist.Beth_Sobel));
            Cards.Add(Card.Ally("Sam Gamgee", "", Sphere.Spirit, 3, 2, 1, 1, 2)
                .WithUnique()
                .WithTraits("Hobbit.")
                .WithText("Reduce the cost to play Sam Gamgee by 2 if you control Frodo ~Baggins.\r\nResponse: After a player raises his threat, that player may spend 1 Spirit resource to ready Sam Gamgee. He gets +1 Willpower, +1 Attack and +1 Defense until the end of the round. (Limit once per round.)")
                .WithInfo(35, 3, Artist.Andrew_Johanson));
            Cards.Add(Card.Event("Elevenses", "", Sphere.Spirit, 1)
                .WithText("Play only after the staging step.\r\nQuest Action: Choose X questing Hobbit characters you control. Ready each chosen character and remove them from the quest. Then, reduce your threat by X.")
                .WithFlavor("\"The road goes on for ever,\" said Pippin; \"but I can't without a rest. It is high time for lunch.\"\r\n-The Fellowship of the Ring")
                .WithInfo(36, 3, Artist.Craig_Maher));
            Cards.Add(Card.Ally("Mirkwood Explorer", "", Sphere.Lore, 3, 2, 1, 0, 2)
                .WithGeneric()
                .WithTraits("Woodman.", "Scout.")
                .WithText("Response: After ~Mirkwood Explorer quests successfully, place 1 progress on it.\r\nAction: Exhaust ~Mirkwood Explorer to move all progress from it to a location in play.")
                .WithInfo(37, 3, Artist.Kim_Sokol));
            Cards.Add(Card.Attachment("Guarded Ceaselessly", "", Sphere.Lore, 0)
                .WithGeneric()
                .WithTraits("Condition.")
                .WithText("Attach to a location.\r\nAction: Exhaust a Ranger or Scout character to give attached location -2 Threat until the end of the phase.")
                .WithFlavor("\"In this high play you may see the two powers that are opposed to one another; and ever they strive now in thought...\"\r\n-The Fellowship of the Ring")
                .WithInfo(38, 3, Artist.Leanna_Teneycke));
        }
    }
}