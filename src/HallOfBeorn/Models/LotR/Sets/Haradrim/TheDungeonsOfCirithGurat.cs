using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.Haradrim
{
    public class TheDungeonsOfCirithGurat : CardSet
    {
        private const string setName = "The Dungeons of Cirith Gurat";

        protected override void Initialize()
        {
            Name = "The Dungeons of Cirith Gurat";
            Abbreviation = "DoCG";
            Number = 47;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            addCard(LotRCard.Hero("Folco Boffin", string.Empty, Sphere.Lore, 7, 2, 2, 0, 2)
                .WithTraits("Hobbit.")
                .WithText("The threat cost of Folco Boffin is reduced by 1 for each Hobbit hero you control.\r\nAction: Discard Folco Boffin to reduce your threat by 7. (Limit once per game for the group.)")
                .WithFlavor("...he had many friends, especially among the younger generation of Hobbits (descendants mostly from Old Took)\r\n-The Fellowship of the Ring")
                .WithInfo(109, 1, Artist.Unknown));
            addCard(LotRCard.Ally("Knight of Dale", Sphere.Leadership, 4, 2, 2, 1, 3)
                .WithTraits("Dale.", "Warrior.")
                .WithText("Action: Spend 1 Leadership Resource to ready the Knight of Dale. (limit once per round).\r\nValor Action: Ready the Dale Knight (limit once per round.).")
                .WithInfo(110, 3, Artist.Unknown));
            addCard(LotRCard.Ally("Knight of the Riddermark", Sphere.Tactics, 2, 0, 2, 0, 2)
                .WithTraits("Rohan.", "Warrior.")
                .WithText("Response: When the Knight of the Riddermark is declared as an attacker, he gains +2 Attack for that attack. At the end of this attack, discard the Knight of the Riddermark.")
                .WithInfo(111, 3, Artist.Unknown));
            addCard(LotRCard.Ally("Survivor of Eregion", Sphere.Spirit, 2, 1, 1, 1, 3)
                .WithTraits("Noldor.")
                .WithText("As long as you do not have cards in your hand, Survivor of Eregion gains +1 Willpower, +1 Attack and +1 Defense.")
                .WithInfo(112, 3, Artist.Unknown));
            addCard(LotRCard.Ally("Leaflock", Sphere.Lore, 3, 0, 2, 2, 3)
                .WithUnique()
                .WithTraits("Ent.")
                .WithText("Cannot have restricted attachments. Enters play exhausted.\r\nLeaflock gets +1 Willpower for each damaged Ent you control (limit +4 Willpower).")
                .WithInfo(113, 3, Artist.Unknown));
            addCard(LotRCard.Attachment("Diligent Noble", string.Empty, Sphere.Leadership, 1)
                .WithTraits("Skill.")
                .WithText("Attach to a hero. Limit 1 per hero.\r\nAttached hero gains the Noble trait.\r\nResponse: After you play Diligent Noble from your hand, draw a card.")
                .WithInfo(114, 3, Artist.Unknown));
            addCard(LotRCard.Attachment("Legacy Blade", string.Empty, Sphere.Lore, 0)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a hero.\r\nAttached hero gets +1 Attack for each side quest in the victory display. (Limit +3 Attack.)")
                .WithFlavor("...glad would he have been to know its fate who wrought it slowly long ago in the North-kingdom when the Dúnedain were young...\r\n-The Return of the King")
                .WithInfo(115, 3, Artist.Lucas_Durham));
            addCard(LotRCard.Event("Tough Defense", string.Empty, Sphere.Tactics, 3)
                .WithText("Combat Action: Deal 3 damage to a non-unique enemy engaged with you.\r\nValour Combat Action: Discard a non-unique enemy engaged with you.")
                .WithInfo(116, 3, Artist.Unknown));
            addCard(LotRCard.Event("Heir of Eärendil", string.Empty, Sphere.Spirit, 1)
                .WithText("Play only if you control a unique character with the Noldor trait and another unique character with the Dúnedain trait.\r\nAction: Choose a non-unique location in the staging area and increase your threat by X to discard it. X is the number of quest points printed on the chosen location.")
                .WithInfo(117, 3, Artist.Unknown));
            addCard(LotRCard.Event("Open the Armory", string.Empty, Sphere.Neutral, 1)
                .WithText("Action: Search the top 10 cards of your deck for a Weapon or Armor attachment and add it to your hand. Shuffle your deck.\r\nValour Action: Search the top 5 cards of your deck for a Weapon or Armor attachment and put it into play. Shuffle your deck.")
                .WithInfo(118, 3, Artist.Sabin_Boykinov));
        }
    }
}