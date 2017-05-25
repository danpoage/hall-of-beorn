using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class BeneathTheSands : CardSet
    {
        protected override void Initialize()
        {
            Name = "Beneath the Sands";
            Abbreviation = "BtS";
            Number = 45;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            addCard(LotRCard.Hero("Hirgon", string.Empty, Sphere.Tactics, 9, 2, 2, 1, 4)
                .WithTraits("Gondor.", "Scout.")
                .WithText("Response: After Hirgon quests successfully, play a Tactics ally from your hand, reducing its cost by 1 (to a minimum of 1). Then, you may raise your threat by 1 to give that ally +1 Attack and +1 Defense until the end of the round.")
                .WithFlavor("\"Hirgon I am, errand-rider of Denethor, who bring you this token of war.\"\r\n-The Return of the King")
                .WithInfo(55, 1, Artist.Aleksander_Karcz));
            addCard(LotRCard.Attachment("Haradrim Spear", string.Empty, Sphere.Leadership, 2)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Haradrim character.\r\nAttached character gets +1 Attack.\r\nResponse: After attached character is declared as an attacker, it gets +3 Attack for this attack. After this attack resolves, discard Haradrim Spear.")
                .WithInfo(56, 3, Artist.Lucas_Durham));
            addCard(LotRCard.Event("Hunting Party", string.Empty, Sphere.Leadership, 1)
                .WithText("Play only if you control a unique character with the Warrior trait and another unique character with the Scout trait.\r\nResponse: After the players have committed characters to the quest, discard a non-unique enemy in the staging area. Then, reveal an encounter card.")
                .WithInfo(57, 3, Artist.Andreia_Ugrai));
            addCard(LotRCard.Attachment("The Red Arrow", string.Empty, Sphere.Tactics, 1)
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithText("Limit 1 per deck. Attach to a Gondor hero.\r\nAttached hero gets +1 Willpower.\r\nValour Response: After attached hero quests successfully, add The Red Arrow to the victory display to search the top 5 cards of your deck for an ally and put it into play.")
                .WithFlavor("\"The Red Arrow has not been seen in the Mark in all my years!\"\r\n-Théoden, The Return of the King")
                .WithVictoryPoints(1)
                .WithInfo(58, 3, Artist.Stanislav_Dikolenko));
            addCard(LotRCard.PlayerSideQuest("Keep Watch", string.Empty, Sphere.Tactics, 1, 6)
                .WithText("Limit 1 copy of Keep Watch in the victory display.\r\nWhile Keep Watch is in the victory display, each non-unique enemy engaged with a player gets -1 Attack.")
                .WithFlavor("\"I called for the help of the Dúnedain, and their watch was doubled...\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithVictoryPoints(1)
                .WithInfo(59, 3, Artist.Alvaro_Calvo_Escudero));
            addCard(LotRCard.Ally("Rider of Rohan", Sphere.Spirit, 3, 2, 2, 0, 2)
                .WithTraits("Rohan.", "Scout.")
                .WithText("While a side quest is in the victory display, Rider of Rohan does not exaust to quest.")
                .WithFlavor("\"Who are you, and what are you doing in this land?\" said the Rider, using the Common Speech of the West...\r\n-The Two Towers")
                .WithInfo(60, 3, Artist.Javier_Charro_Martinez));
            addCard(LotRCard.Attachment("Fireside Song", string.Empty, Sphere.Spirit, 2)
                .WithTraits("Song.")
                .WithText("Attach to a Hobbit hero. Limit 1 per hero.\r\nAttached hero gets +1 Willpower for each Song attached to it.")
                .WithFlavor("\"I sit beside the fire and think\r\nof how the world will be\r\nwhen winter comes without a spring\r\nthat I shall ever see.\"\r\n-Bilbo Baggins, The Fellowship of the Ring")
                .WithInfo(61, 3, Artist.Jake_Murray));
            addCard(LotRCard.Ally("Dúnedain Lookout", Sphere.Lore, 2, 1, 1, 1, 2)
                .WithTraits("Dúnedain.")
                .WithText("Response: Discard Dúnedain Lookout to cancel the 'When Revealed' effects of an enemy just revealed from the encounter deck.")
                .WithFlavor("\"Travellers scowl at us, and countrymen gives us scornful names.\"\r\n-Aragorn, The Fellowship of the Ring")
                .WithInfo(62, 3, Artist.Aleksander_Karcz));
            addCard(LotRCard.Attachment("Doughty Ranger", string.Empty, Sphere.Lore, 1)
                .WithTraits("Skill.")
                .WithText("Attach to a hero. Limit 1 per hero.\r\nAttached hero gains the Ranger trait.\r\nResponse: After you play Doughty Ranger from your hand, draw a card.")
                .WithFlavor("...he went forth clad only in rusty green and brown, as a Ranger of the wilderness.\r\n-The Fellowship of the Ring")
                .WithInfo(63, 3, Artist.Aleksander_Karcz));
            addCard(LotRCard.Event("The Free Peoples", string.Empty, Sphere.Neutral, 5)
                .WithText("Play only if the characters you control have a total of at least 9 different Traits between them.\r\nAction: Ready each character in play. Until the end of the phase, each character you control gets +1 Willpower.")
                .WithFlavor("\"For the rest, they shall represent the other Free Peoples of the World: Elves, Dwarves and Men.\"\r\n-Elrond, The Fellowship of the Ring")
                .WithInfo(64, 3, Artist.Uriah_Voth));
            
        }
    }
}