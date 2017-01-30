using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheMumakil : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Mûmakil";
            Abbreviation = "TMk";
            Number = 43;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            addCard(LotRCard.Hero("Kahliel", string.Empty, Sphere.Leadership, 10, 2, 2, 2, 4)
                .WithTraits("Harad.", "Noble.")
                .WithText("You may use resources from Kahliel's resource pool to pay for Harad ally cards of any sphere.\r\nAction: Discard a Harad ally card from your hand to ready a Harad character in play. (Limit once per phase.)")
                .WithFlavor("...the Southrons were bold men and grim...\r\n-The Return of the King")
                .WithInfo(1, 1, Artist.Ryan_Valle));
            addCard(LotRCard.Ally("Andrath Guardsman", Sphere.Leadership, 2, 1, 0, 1, 2)
                .WithTraits("Dúnedain", "Ranger")
                .WithText("Response: After you play Andrath Guardsman from your hand, choose a non-unique enemy engaged with you. That enemy cannot attack you this round.")
                .WithFlavor("They forgot or ignored what little they had known of the Guardians, and of the labours of those that made possible the long peace of the Shire.\r\n-The Fellowship of the Ring")
                .WithInfo(2, 3, Artist.Adam_Lane));
            addCard(LotRCard.PlayerSideQuest("Prepare for Battle", string.Empty, Sphere.Leadership, 1, 6)
                .WithFlavor("\"Soon there will be battle on the fields. A sortie must be made ready.\"\r\n-Gandalf, The Return of the King")
                .WithText("Limit 1 copy of Prepare for Battle in the victory display.\r\nWhile this quest is in the victory display, the first player draws an additional card during the resource phase.")
                .WithVictoryPoints(1)
                .WithInfo(3, 3, Artist.Sebastian_Zakrzewski));
            addCard(LotRCard.Ally("Yazan", Sphere.Tactics, 5, 2, 3, 1, 3)
                .WithUnique()
                .WithTraits("Harad.", "Ranger.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Yazan is declared as an attacker, deal 1 damage to a non-unique enemy in play. (Limit once per phase.)")
                .WithInfo(4, 3, Artist.David_A_Nash));
            addCard(LotRCard.Event("Wait no Longer", string.Empty, Sphere.Tactics, 2)
                .WithText("Response: At the beginning of the quest phase, search the top 5 cards of the encounter deck for an enemy and put it into play engaged with you. Then, reveal one less encounter card this phase (to a minimum of 0). Shuffle the encounter deck.")
                .WithFlavor("\"We must press our Enemy, and no longer wait upon him for the move.\"\r\n-Aragorn, The Return of the King")
                .WithInfo(5, 3, Artist.John_Pacer));
            addCard(LotRCard.Ally("Jubayr", Sphere.Spirit, 5, 1, 2, 3, 3)
                .WithUnique()
                .WithTraits("Harad.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After Jubayr exhausts to defend an attack, discard 1 facedown shadow card from a non-unique enemy. (Limit once per phase.)")
                .WithInfo(6, 3, Artist.Colin_Boyer));
            addCard(LotRCard.Attachment("Dwarf Pipe", string.Empty, Sphere.Spirit, 1)
                .WithTraits("Item.", "Pipe.")
                .WithText("Attach to a Dwarf character. Limit 1 per character.\r\nResponse: After a card is discarded from the top of your deck, exhaust ~Dwarf ~Pipe to place that card on the bottom of your deck.")
                .WithFlavor("He held a small pipe with a wide flattened bowl...\r\n-The Two Towers")
                .WithInfo(7, 3, Artist.Mark_Bulahao));
            addCard(LotRCard.Ally("Firyal", Sphere.Lore, 5, 3, 1, 2, 3)
                .WithUnique()
                .WithTraits("Harad.", "Scout.")
                .WithText("Response: After Firyal commits to the quest, look at the top card of the encounter deck. Then, you may discard the looked at card.")
                .WithInfo(8, 3, Artist.Tawny_Fritzinger));
            addCard(LotRCard.Event("Coney in a Trap", string.Empty, Sphere.Lore, 1)
                .WithText("Play only if you control a unique character with the Ranger trait and another unique character with the Warrior trait.\r\nResponse: After you engage an enemy, that enemy cannot attack you until the end of the round.")
                .WithInfo(9, 3, Artist.Jon_Bosco));
            addCard(LotRCard.Attachment("Khaliel's Headdress", string.Empty, Sphere.Neutral, 3)
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Restricted.")
                .WithText("Each Harad character gets +1 Willpower.\r\nRefresh Action: Exhaust Khaliel's Headdress to shuffle the topmost Harad ally in your discard pile into your deck.")
                .WithInfo(10, 3, Artist.Lucas_Durham));
        }
    }
}