using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheLordOfTheRings
{
    public class TheMountainOfFire : CardSet
    {
        private const string setTower = "The Tower of Cirith Ungol";
        private const string setOrcsOfMordor = "Orcs of Mordor";
        private const string setDeepShadows = "Deep Shadows";

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
            addCard(LotRCard.Objective("Last of the Company", string.Empty, setTower)
                .WithTraits("Fellowship.")
                .WithText("Attached hero gains the Ring-bearer trait and the Fellowship sphere. You cannot lose control of the first player token.\r\nAction: Exhaut The One Ring and raise your threat by 1 to choose an enemy. Until the end of the phase, that enemy gets -X Threat, where X is the attached hero's Willpower.")
                .WithInfo(14, 1, Artist.Nicholas_Gregory));
            addCard(LotRCard.Location("Topmost Chamber", string.Empty, setTower, 1, 1)
                .WithUnique()
                .WithTraits("Cirith Ungol.")
                .WithText("Immune to player card effect.\r\nThe players cannot travel here unless there is at least 18 progress on stage 2B.\r\nTravel: Add Shagrat to the staging area to travel here.")
                .WithFlavor("\"That's what I'm going to do,\" said Shagrat in angry tones. \"Put him up in the top chamber.\"\r\n-The Return of the King")
                .WithVictoryPoints(2)
                .WithInfo(15, 1, Artist.Leanna_Crossan));
            addCard(LotRCard.Location("Echoing Passage", string.Empty, setTower, 1, 5)
                .WithTraits("Cirith Ungol.")
                .WithText("Echoing Passage gets +1 Threat for each enemy in the staging area.\r\nWhile Echoing Passage is the active location, each enemy gets +2 Defense.")
                .WithFlavor("Many doors and openings could be seen on this side and that; but it was empty save for two or three more bodies sprawling on the floor.\r\n-The Return of the King")
                .WithEasyModeQuantity(1)
                .WithInfo(16, 3, Artist.Leanna_Crossan));
            addCard(LotRCard.Location("Bloodied Courtyard", string.Empty, setTower, 3, 4)
                .WithTraits("Cirith Ungol.")
                .WithText("While Bloodied Courtyard is the active location, it gains: \"Forced: After an enemy enters the staging area, deal 1 damage to it.\"\r\nTravel: Raise each player's threat by 1 to travel here.")
                .WithFlavor("At once he saw that up here the fighting has been fiercest. All the court was choked with dead orcs or their severed and scattered heads and limbs. The place stank of death.\r\n-The Return of the King")
                .WithInfo(17, 3, Artist.DinoDrawing));
            addCard(LotRCard.Location("Winding Stairs", string.Empty, setTower, 2, 4)
                .WithTraits("Cirith Ungol.")
                .WithText("While Winding Stairs is the active location, each enemy in the staging area gets +10 engagement cost.\r\nTravel: Each player must exhaust a character he controls to travel here.")
                .WithFlavor("The stairs were high and steep and winding.\r\n-The Return of the King")
                .WithInfo(18, 3, Artist.Stanislav_Dikolenko));
            addCard(LotRCard.Location("Torch-lit Hall", string.Empty, setTower, 2, 3)
                .WithTraits("Cirith Ungol.")
                .WithText("Forced: After the players travel to Torch-lit Hall, discard cards from the top of the encounter deck until an enemy is discarded. If there is a copy of that enemy in the staging area, discard that copy as well. If there is not, add the just discarded enemy to the staging area.")
                .WithFlavor("It was dimly lit with torches flaring in brackets on the walls, but its distant end was lost in gloom.\r\n-The Return of the King")
                .WithInfo(19, 3, Artist.Leanna_Crossan));
            addCard(LotRCard.Enemy("Shagrat", string.Empty, setTower, 46, 4, 5, 4, 6)
                .WithUnique()
                .WithTraits("Orc.", "Uruk.")
                .WithText("Cannot have attachments. Cannot take non-combat damage.\r\nAllies cannot attack or defend against Shagrat.\r\nForced: After progress is placed on the quest, Shagrat gets -X engagement cost until the end of the round. X is the amount of progress just placed.")
                .WithVictoryPoints(4)
                .WithInfo(20, 1, Artist.Stanislav_Dikolenko));
            addCard(LotRCard.Enemy("Gorbag", string.Empty, setTower, 36, 3, 4, 3, 5)
                .WithUnique()
                .WithTraits("Orc.", "Uruk.")
                .WithText("Cannot have attachments.\r\nForced: After Gorbag engages you, it makes an immediate attack.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithVictoryPoints(3)
                .WithEasyModeQuantity(0)
                .WithInfo(21, 1, Artist.Sebastian_Rodriguez));
            addCard(LotRCard.Enemy("Wounded Uruk", string.Empty, setTower, 34, 2, 3, 2, 4)
                .WithTraits("Orc.", "Uruk.")
                .WithText("Wounded Uruk enters play with 2 damage on it.\r\nForced: After Wounded Uruk engages you, it gets +2 Attack until the end of the round.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each damage on it.")
                .WithInfo(22, 3, Artist.Alexander_Kozachenko));
            addCard(LotRCard.Treachery("Orcish Howls", string.Empty, setTower)
                .WithText("When Revealed: Deal 1 damage to each enemy in the staging area. Until the end of the phase, each enemy gets +1 Threat for each damage on it. If there are no enemies in the staging area, Orcish Howls gains surge.")
                .WithShadow("Shadow: If you are engaged with another enemy, resolve this attack against that enemy.")
                .WithInfo(23, 3, Artist.Borja_Pindado));

            addCard(LotRCard.Objective("The One Ring", string.Empty, null)
                .WithUnique()
                .WithTraits("Artifact.", "Item.", "Ring.")
                .WithText("Setup: The first player claims The One ~Ring and attaches it to the Ring-bearer.\r\nAttached hero does not count against the hero limit. The first player gains control of attached hero.\r\nIf The One ~Ring leaves play, the players lose the game.")
                .WithInfo(65, 1, Artist.Mike_Nash));

            addCard(LotRCard.Campaign("The Tower of Cirith Ungol", setTower, "The Lord of the Rings - Part 16")
                .WithText("Setup: Each player may change heroes he controls without incurring the +1 threat penalty. Attach A Heavy Burden to the hero with Last of the Company attached. Each player chooses an Item boon (excluding Andúril) from the campaign pool and sets it aside, out of play. Remove each burden with the following burden set icons from the encounter deck, then flip this card over: Helm's Deep, The Road to Isengard, and The Passing of the Grey Company")
                .WithOppositeText("Forced: When the players advance to stage 3A, attach A Heavy Burden to the Ring-bearer. Attach each set aside Item boon to Shagrat as a guarded objective. When Shagrat is defeated, return each guarded boon to its owner's hand.\r\nResolution: If Shagrat is in play, remove each Item boon attached to it from the campaign pool. (The players have lost those boons.)")
                .WithOppositeFlavor("The will of the Watchers was broken with a suddenness like the snapping of a cord, and Frodo and Sam stumbled forward. Then they ran. Through the gate and past the great seated figures with their glittering eyes. There was a crack. The keystone of the arch crashed almost on their heels, and the wall above crumbled, and fell in ruin. Only by a hair did they escape.\r\n-The Return of the King")
                .WithInfo(69, 1, Artist.Sebastian_Giacobino));
            addCard(LotRCard.Location("The Two Watchers", string.Empty, setTower, 254, 255)
                .WithSuffix("Location")
                .WithUnique()
                .WithTraits("Mordor.")
                .WithText("Immune to player card effects.\r\nX is twice the stage number of the main quest.\r\nForced: After the players travel here, flip The Two Watchers to its enemy side and move it to the staging area.")
                .WithFlavor("They were like great figures seated upon thrones. Each had three joined bodies, and three heads facing outward, and inward, and across the gateway.\r\n-The Return of the King")
                .WithInfo(70, 1, Artist.DinoDrawing));
            addCard(LotRCard.Enemy("The Two Watchers", string.Empty, setTower, 50, 2, 5, 2, 4)
                .WithSuffix("Enemy")
                .WithUnique()
                .WithTraits("Mordor.")
                .WithText("Immune to player card effects. Cannot be optionally engaged.\r\nForced: When The Two Watchers deals any amount of damage, cancel that damage and raise the defending player's threat by X instead. X is the amount of damage just canceled.")
                .WithVictoryPoints(5)
                .WithInfo(71, 1, Artist.DinoDrawing));
        }
    }
}