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
        private const string setMountainOfFireEpicMultiplayer = "Mountain of Fire Epic Multiplayer";
        private const string setBlackGate = "The Black Gate Opens";

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
            addCard(LotRCard.Location("The Black Gate", string.Empty, setBlackGate, 0, 254)
                .WithUnique()
                .WithTraits("Mordor.")
                .WithText("Immune to player card effects. The players cannot travel here.\r\nThe Black Gate gets +1 Threat for each resource on it.\r\nForced: At the beginning of the quest phase, place 1 resource here and raise each player's threat by 1.")
                .WithFlavor("The great doors of the Black Gate swung back wide. Out of it streamed a great host as swiftly as swirling waters when a sluice is lifted.\r\n-The Return of the King")
                .WithInfo(24, 1, Artist.Igor_Artyomenko));
            addCard(LotRCard.Location("Towers of the Teeth", string.Empty, setBlackGate, 255, 8)
                .WithTraits("Plains.")
                .WithText("Immune to player card effects.\r\nX is the number of characters controlled by the player with the most characters.\r\nWhile Towers of the Teeth is the active location, players cannot play allies.")
                .WithFlavor("...now near loomed the great rampart of Cirith Gorgor, and the Black Gate amidmost, and the Two Towers of the Teeth tall and dark upon either side.\r\n-The Return of the King")
                .WithEasyModeQuantity(1)
                .WithInfo(25, 2, Artist.Igor_Artyomenko));
            addCard(LotRCard.Location("Beleaguered Hills", string.Empty, setBlackGate, 2, 3)
                .WithTraits("Hills.")
                .WithText("While Beleaguered Hills is the active location, reduce the total Threat in the staging area by X, where X is the total Threat of each engaged enemy.\r\nForced: After Beleaguered Hills becomes the active location, each player engages a non-unique enemy in the staging area.")
                .WithFlavor("The onslaught of Mordor broke like a wave on the beleaguered hills... -The Return of the King")
                .WithInfo(26, 2, Artist.Carlos_Palma_Cruchaga));
            addCard(LotRCard.Location("Waste of Dagorlad", string.Empty, setBlackGate, 3, 6)
                .WithTraits("Plains.")
                .WithText("While Waste of Dagorlad is the active location, treat the printed text box of each ally as if it were blank (except for Traits).")
                .WithFlavor("SO desolate were those places and so deep the horror that lay on them that some of the host were unmanned.\r\n-The Return of the King")
                .WithInfo(27, 3, Artist.Kamila_Tzutenberg));
            addCard(LotRCard.Location("Slopes of Cirith Gorgor", string.Empty, setBlackGate, 4, 1)
                .WithTraits("Hills.")
                .WithText("Forced: When Slopes of Cirith Gorgor leaves play. the first player shuffles the encounter discard pile into the encounter deck and discards cards from the top until an enemy is discarded. Then, he puts that enemy into play engaged with him.")
                .WithFlavor("...they knew that all the hills and rocks about the Morannon were filled with hidden foes...\r\n-The Return of the King")
                .WithEasyModeQuantity(1)
                .WithInfo(28, 2, Artist.Kamila_Tzutenberg));
            addCard(LotRCard.Location("Reeking Moat", string.Empty, setBlackGate, 2, 4)
                .WithTraits("Plains.")
                .WithText("Forced: After Reeking Moat becomes the active location, choose a non-unique, non-Nazgûl enemy in the staging area and place it facedown under Reeking Moat.\r\nForced: When Reeking Moat leaves play, put each enemy under it into play engaged with the first player.")
                .WithFlavor("...towards Mordor lay like a moat a great mire of reeking mud and foul-smelling pools.\r\n-The Return of the King")
                .WithInfo(29, 3, Artist.Leanna_Crossan));
            addCard(LotRCard.Location("Wall of Morannon", string.Empty, setBlackGate, 5, 5)
                .WithTraits("Plains.")
                .WithText("While Wall of Morannon is the active location, each enemy and location in the staging area is immune to player card effects.\r\nForced: After Wall of Morannon becomes of the active location, return each enaged enemy to the staging area.")
                .WithFlavor("...behind the Morannon were the tunnels and deep armouries that the servants of Mordor had made for the defence of the Black Gate...\r\n-The Return of the King")
                .WithEasyModeQuantity(1)
                .WithInfo(30, 2, Artist.Kamila_Tzutenberg));
            addCard(LotRCard.Enemy("The Mouth of Sauron", string.Empty, setBlackGate, 99, 4, 6, 5, 11)
                .WithUnique()
                .WithTraits("Mordor.")
                .WithText("Immune to player card effects. Cannot leave the staging area.\r\nForced: After a player cancels a 'when revealed' effect, The Mouth of Sauron makes an immediate attack against that player.")
                .WithFlavor("The Lieutenant of the Tower of Barad-dûr he was...\r\n-The Return of the King")
                .WithInfo(31, 1, Artist.Jason_Jenicke));

            addCard(LotRCard.ObjectiveAlly("Gwaihir", string.Empty, string.Empty, 3, 3, 3, 5)
                .WithBoon()
                .WithUnique()
                .WithTraits("Creature.", "Eagle.")
                .WithKeywords("Ranged.", "Sentinel.")
                .WithText("When Revealed: The first player must choose: either take control of Gwaihir, or spend 1 Fellowship resource and discard Gwahir to discard a non-unique enemy in the staging area.")
                .WithShadow("Shadow: This attack deals no damage.")
                .WithInfo(41, 1, Artist.Dmitry_Prosvirnin));

            addCard(LotRCard.Enemy("Orc of Mordor", string.Empty, setOrcsOfMordor, 28, 1, 3, 1, 3)
                .WithTraits("Orc.")
                .WithKeywords("Surge.")
                .WithText("Forced: After Orc of Mordor engages you, exhaust a character you control.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithEasyModeQuantity(2)
                .WithInfo(58, 3, Artist.Martin_de_Diego_Sadaba));
            addCard(LotRCard.Enemy("Snaga Archer", string.Empty, setOrcsOfMordor, 44, 2, 4, 2, 3)
                .WithTraits("Orc.", "Snaga.")
                .WithKeywords("Archery 2.")
                .WithText("Forced: After Snaga Archer engages you, deal 2 damage to a character you control.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending character is damaged).")
                .WithInfo(59, 3, Artist.Alexander_Kozachenko));
            addCard(LotRCard.Enemy("Uruk Soldier", string.Empty, setOrcsOfMordor, 38, 3, 5, 2, 5)
                .WithTraits("Orc.", "Uruk.")
                .WithText("Forced: After Uru Soldier engages you, raise your threat by 2.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, return attacking enemy to the staging area.")
                .WithInfo(60, 3, Artist.Nicholas_Gregory));
            addCard(LotRCard.Treachery("Drawn to the Ring", string.Empty, setDeepShadows)
                .WithText("When Revealed: The first player must choose: either exhaust The One Ring and reveal an encounter card, or discard cards from the top of the encounter deck until an enemy is discarded and put it into play engaged with him.")
                .WithShadow("Shadow: Discard a non-objective attachment you control.")
                .WithEasyModeQuantity(2)
                .WithInfo(61, 3, Artist.Alexander_Kozachenko));
            addCard(LotRCard.Treachery("Deep Shadows", string.Empty, setDeepShadows)
                .WithKeywords("Doomed 2.")
                .WithText("When Revealed: Each player must choose: either discard your hand (with at least 3 cards in it), or reveal and encounter card.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack after this one.")
                .WithEasyModeQuantity(1)
                .WithInfo(62, 2, Artist.Igor_Artyomenko));
            addCard(LotRCard.Treachery("Evil Vigilance", string.Empty, setDeepShadows)
                .WithText("When Revealed: Each player must choose: either discard a questing character you control, or raise your threat by 1 for each questing character you control.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, reveal the top card of the encounter deck.")
                .WithInfo(63, 3, Artist.Martin_de_Diego_Sadaba));
            addCard(LotRCard.Treachery("In Darkness Bind Them", string.Empty, setMountainOfFireEpicMultiplayer)
                .WithText("When Revealed: Each player exhausts a character he controls. If The Eye of Sauron is in the staging area, characters cannot be readied by player card effects this round.")
                .WithShadow("Shadow: If The Eye of Sauron is in the staging area, attacking enemy gets +2 Attack and returns to the staging area after this attack.")
                .WithInfo(64, 2, Artist.Gabriela_Birchal));
            addCard(LotRCard.Objective("The One Ring", string.Empty, null)
                .WithUnique()
                .WithTraits("Artifact.", "Item.", "Ring.")
                .WithText("Setup: The first player claims The One ~Ring and attaches it to the Ring-bearer.\r\nAttached hero does not count against the hero limit. The first player gains control of attached hero.\r\nIf The One ~Ring leaves play, the players lose the game.")
                .WithInfo(65, 1, Artist.Mike_Nash));
            addCard(LotRCard.Quest("Pass the Two Towers", 1, setTower, 0)
                .WithFlavor("Frodo has been captured by the Orcs of Cirith Ungol and imprisoned at the top of their tower, but Sam is determined to rescue his master.")
                .WithText("Setup: Set Shagrat aside, out of play. Add The Two Wachers (location side faceup) and Topmost Chamber to the staging area. The first player loses control of the Ring-bearer and place it faceup under Topmost Chamber as a guarded objective. Then, the first player attaches Last of the Company to a hero he controls and attaches The One Ring to that hero.")
                .WithOppositeFlavor("He could see no obstacle, but something too strong for his will to overcome barred the way. -The Return of the King")
                .WithOppositeText("Each non-unique location gets -1 Threat and cannot leave the staging area.\r\nWhile The Two Watchers is in the staging area (enemy side faceup), it is considered to be engaged with each player.\r\nThe stage cannot be defeated while The Two Watchers is in play.")
                .WithIncludedEncounterSets(EncounterSet.OrcsOfMordor, EncounterSet.DeepShadows)
                .WithInfo(66, 1, Artist.Stanislav_Dikolenko));
            addCard(LotRCard.Quest("Fighting in the Tower", 2, setTower, 18)
                .WithFlavor("There could not be much doubt: there was fighting in the tower, the orcs must be at war among themselves, Shagrat and Gorbag had come to blows.\r\n-The Return of the King")
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck and discard cards from the top until X enemies are discarded, where X is the number of players in the game. Add each enemy discarded by this effect to the staging area.")
                .WithOppositeText("Forced: At the beginning of the quest phase, discard cards from the top of the encounter deck until an enemy is discarded. If there is a copy of that enemy in the staging area, discard that copy as well. If there is not, add the discarded enemy to the staging area.\r\nThis stage cannot be defeated unless Topmost Chamber is in the victory display. When the Ring-bearer is free of encounters, this first player gains control of it.")
                .WithIncludedEncounterSets(EncounterSet.OrcsOfMordor, EncounterSet.DeepShadows)
                .WithInfo(67, 1, Artist.Stanislav_Dikolenko));
            addCard(LotRCard.Quest("Escape from Cirith Ungol", 3, setTower, 12)
                .WithFlavor("\"It's the gate. There's some devilry there. But I got through, and I'm going to get out. It can't be more dangerous than before. Now for it!\"\r\n-Sam Gamgee, The Return of the King")
                .WithText("When Revealed: Add Last of the Company to the victory display. Attach The One Ring to the Ring-bearer and exhaust the Ring-bearer. The first player moves The Two Watchers from the victory display to the staging area (location side faceup). Each other player reveals an encounter card.")
                .WithOppositeText("The players cannot travel to The Two Watchers unless there is at least 12 progress on this stage.\r\nWhile The Two Watchers is in the staging area (enenmy side faceup), it gets +3 Threat and +3 Defense and is considered to be engaged with each player.\r\nThe stage cannot be defeated while The Two Watchers is in play. If this stage is defeated, the players win the game.")
                .WithIncludedEncounterSets(EncounterSet.OrcsOfMordor, EncounterSet.DeepShadows)
                .WithInfo(68, 1, Artist.Ryan_Valle));
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
            addCard(LotRCard.Quest("Embassy from the Dark Tower", 1, setBlackGate, 0)
                .WithKeywords("Dire.")
                .WithFlavor("Aragorn has led the Men of the West to the very Gate of Mordor in a perilous gamble to keep the Eye of Sauron focused on him. After challenging the Dark Lord to come forth and face judgement, the Black Gate opens and an embassy from Barad-dûr rides out led by The Mouth of Sauron.")
                .WithText("Setup: Add The Black Gate and The Mouth of Sauron to the staging area. Set Gwaihir aside, out of play. Shuffle the encounter deck.")
                .WithOppositeText("When Revealed: In player order, each player places the top card of his deck faceup in front of him until their are a total of 4 faceup player cards between the players. Place the top 4 cards of the encounter deck faceup. Starting with the highest cost player card, pair each player card with the highest threat encounter card remaining until their are 4 pairs. For each pair, the first player must choose: either discard both cards in the pair, or reveal the encounter card to play the player card at no cost.")
                .WithIncludedEncounterSets(EncounterSet.OrcsOfMordor)
                .WithInfo(72, 1, Artist.Rafal_Hrynkiewicz));
            addCard(LotRCard.Quest("The Battle of the Morannon", 2, setBlackGate, 254)
                .WithKeywords("Dire.")
                .WithFlavor("He gave a great cry, and turned, leaded upon his steed, and with his company galloped madly back to Cirith Gorgor. But as they went his soldiers blew their horns in signal long arranged: and even before they came to the gate Sauron sprang his trap. -The Return of the King")
                .WithText("When Revealed: Each player searches the encounter deck and discard pile for a different Orc, Troll, or Nazgûl enemy and adds it to the staging area. Shuffle Gwaihir into the encounter deck.")
                .WithOppositeText("Dire. During the staging step, the first player does not reveal an encounter card as normal. Instead, he reveals 1 encounter card for each resource on The Black Gate.\r\nForced: After the players quest unsuccessfully, discard the active location.\r\nThis stage cannot be defeated. Each round the players survive gives the Ring-bearer more time to fulfill the quest to Mount Doom.")
                .WithIncludedEncounterSets(EncounterSet.OrcsOfMordor)
                .WithInfo(73, 1, Artist.Stanislav_Dikolenko));
            addCard(LotRCard.Campaign(setBlackGate, setBlackGate, "The Lord of the Rings - Part 17")
                .WithText("Setup: Each player may change heroes he controls without incurring the +1 threat penalty. The first player may raise each player's threat by 1 to search his deck for Anduril and add it to his hand. Remove each burden with the following burden set icons from the encounter deck: A Shadow of the Past, Flight to the Ford, The Ring Goes South, The Passage of the Marshes, Shelob's Lair")
                .WithFlavor("They were come to the last end of their folly, and stood forlorn and chill in the grey light of early day before towers and walls which their army could not assault with hope...\r\n-The Return of the King")
                .WithOppositeText("Resolution: Record the number of resource tokens on The Black Gate in the notes section of the campaign log. If a Wraith on Wings is in the victory display, remove that copy from the campaign pool. If the first player controls Gwaihir, add him to the campaign pool. The players have earned that boon. If a hero is in its controller's discard pile, do not add that hero's name to the list of fallen heroes.")
                .WithOppositeFlavor("\"So it ends as I guessed it would,\" his thought said, even as it fluttered away; and it laughed a little within him ere it fled, almost gay it seemed to be casting off at last all doubt and care and fear. And then even as it winged away into forgetfulness it heard voices, and they seemed to be crying in some forgotten world far above: \"The Eagles are coming! The Eagles are coming!\"\r\n-The Return of the King")
                .WithInfo(74, 1, Artist.Rafal_Hrynkiewicz));
        }
    }
}