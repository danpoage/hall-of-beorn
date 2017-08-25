using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheLordOfTheRings
{
    public class TheMountainOfFire : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Mountain of Fire";
            Abbreviation = "TMoF";
            Number = 1008;
            SetType = Models.SetType.Saga_Expansion;
            Cycle = "The Lord of the Rings";

            addCard(LotRCard.Hero("Frodo Baggins", string.Empty, Sphere.Fellowship, 0, 2, 1, 2, 2)
                .WithTraits("Hobbit.", "Ring-bearer.")
                .WithText("Planning Action: Exhaust The One Ring to add 1 resource to a hero's pool.")
                .WithFlavor("\"I must carry the burden to the end.\"\r\n-The Return of the King")
                .WithInfo(1, 1, Artist.Aleksander_Karcz));
            addCard(LotRCard.Hero("Aragorn", string.Empty, Sphere.Fellowship, 0, 2, 3, 2, 5)
                .WithTraits("Dúnedain.", "Gondor.", "Noble.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("The first player gains control of Aragorn.\r\nAction: Spend 1 resource from Aragorn's pool to ready him. (Limit once per phase.)\r\nIf Aragorn leaves play the players lose the game.")
                .WithFlavor("\"As I have begun, so I will go on.\"\r\n-The Return of the King")
                .WithInfo(2, 1, Artist.David_A_Nash));
            addCard(LotRCard.Hero("Éomer", string.Empty, Sphere.Leadership, 10, 1, 3, 2, 4)
                .WithTraits("Rohan.", "Noble.", "Warrior.")
                .WithText("Response: After Éomer commits to the quest, spend 1 resource from his resource pool to immediately declare him as an attacker (and resolve his attack) against an enemy in the staging area.")
                .WithFlavor("...he was young, and he was king; the lord of a fell people.\r\n-The Return of the King")
                .WithInfo(3, 1, Artist.Ryan_Valle));
            addCard(LotRCard.Hero("Tom Cotton", string.Empty, Sphere.Tactics, 8, 1, 1, 3, 3)
                .WithTraits("Hobbit.")
                .WithText("While you are engaged with an enemy with an engagement cost higher than your threat, the first Hobbit ally you play each round does not require a resource match.\r\nResponse: After a Hobbit ally enters play, it gets +2 Attack until the end of the round.")
                .WithInfo(4, 1, Artist.Nicholas_Gregory));
            addCard(LotRCard.Ally("Rosie Cotton", Sphere.Leadership, 2, 2, 0, 0, 2)
                .WithUnique()
                .WithTraits("Hobbit.")
                .WithText("Action: Exhaust Rosie Cotton to choose a Hobbit hero and an attribute (Willpower, Attack, Defense). Add Rosie Cotton's Willpower to that hero's chosen attribute until the end of the phase. (Limit once per phase.)")
                .WithInfo(5, 3, Artist.Gabriela_Birchal));
            addCard(LotRCard.Ally("Elfhelm", Sphere.Tactics, 4, 1, 2, 2, 3)
                .WithUnique()
                .WithTraits("Rohan.", "Warrior.")
                .WithText("Action: Spend 1 resource from a Rohan hero's resource pool to put Elfhelm into play from your hand under your control. At the end of the phase, discard Elfhelm if he is still in play.")
                .WithFlavor("\"...my lord sends word that we must set ourselves in readiness; orders may come for a sudden move.\"\r\n-The Return of the King")
                .WithInfo(6, 3, Artist.Javier_Charro_Martinez));
            addCard(LotRCard.Ally("Elladan", Sphere.Lore, 3, 2, 1, 1, 3)
                .WithUnique()
                .WithTraits("Noldor.", "Ranger.")
                .WithText("While Elrohir is in play, Elladan gets +2 Attack.\r\nResponse: After you optionally engage an Orc enemy, ready Elladan.")
                .WithFlavor("...they rode often far afield with the Rangers of the North, forgetting never their mother's torment in the dens of the Orcs. -The Return of the King")
                .WithInfo(7, 3, Artist.Jason_Jenicke));
            addCard(LotRCard.Ally("Elrohir", Sphere.Spirit, 3, 2, 1, 1, 3)
                .WithUnique()
                .WithTraits("Noldor.", "Ranger.")
                .WithText("While Elladan is in play, Elrohir gets +2 Defense.\r\nResponse: After you optionally engage an Orc enemy, ready Elrohir.")
                .WithFlavor("\"From the North we came with this purpose, and from Elrond our father we brought this very counsel.\"\r\n-The Return of the King")
                .WithInfo(8, 3, Artist.Jason_Jenicke));
            addCard(LotRCard.Event("Captains of the West", string.Empty, Sphere.Leadership, 3)
                .WithText("Quest Action: Until the end of the phase, each Noble hero gets +1 Willpower and does not exhaust to commit to the quest.")
                .WithInfo(9, 3, Artist.Igor_Artyomenko));
            addCard(LotRCard.Event("Raise the Shire", string.Empty, Sphere.Tactics, 1)
                .WithText("Response: After you engage an enemy, search the top 5 cards of your deck for a Hobbit ally and put it into play (search you entire deck instead if that enemy's engagement cost is higher than your threat). Shuffle your deck. At the end of the round, if that ally is still in play, return it to your hand.")
                .WithInfo(10, 3, Artist.Nikolas_Hagialas));
            addCard(LotRCard.Attachment("Gúthwinë", string.Empty, Sphere.Leadership, 2)
                .WithUnique()
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Rohan hero.\r\nResponse: After attached hero is declared as an attacker, exhaust Gúthwinë to give that hero +2 Attack for this attack. If this attack destroys an enemy, return a Rohan ally from your discard pile to your hand.")
                .WithFlavor("\"Gúthwinë!\" cried Éomer. \"Gúthwinë for the Mark!\"\r\n-The Two Towers")
                .WithInfo(11, 3, Artist.Kamila_Tzutenberg));
            addCard(LotRCard.Attachment("Friend of Friends", string.Empty, Sphere.Neutral, 1)
                .WithTraits("Condition.")
                .WithText("Attach to a Hobbit hero. Limit 2 copies of Friend of Friends in play.\r\nWhile another hero has Friend of Friends attached, attached hero gets +1 Willpower, +1 Attack, +1 Defense and +1 hit point.")
                .WithFlavor("\"Come, Mr. Frodo!\" he cried, \"I can't carry it for you, but I can carry you and it as well\"\r\n-Sam Gamgee, The Return of the King")
                .WithInfo(12, 3, Artist.Aleksander_Karcz));
            addCard(LotRCard.Attachment("Orc Disguise", string.Empty, Sphere.Fellowship, 1)
                .WithTraits("Item.", "Armor.")
                .WithText("Attach to the Ring-bearer. Limit 1 per hero.\r\nWhile an Orc is making an enagement check with you, it gets +5 engagement cost.\r\nResponse: After an Orc engages you, discard Orc Disguise. Until the end of the round, that enemy cannot attack you.")
                .WithInfo(13, 3, Artist.Borja_Pindado));
        }
    }
}