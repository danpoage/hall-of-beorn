using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheTreasonOfSaruman : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Treason of Saruman";
            Abbreviation = "ToS";
            Number = 1005;
            SetType = Models.SetType.Saga_Expansion;
            Cycle = "The Lord of the Rings";

            Cards.Add(Card.Hero("Aragorn", "913A68C4-876B-4AD4-AF08-A291B2E3D053", Sphere.Fellowship, 0, 2, 3, 2, 5)
                .WithTraits("Dúnedain.", "Noble.", "Ranger.")
                .WithText("The first player gains control of Aragorn. If Aragorn leaves play, the players lose the game.\r\nAction: Spend 2 resources from Aragorn's resource pool to ready a hero.")
                .WithInfo(1, 1, Artist.Mark_Behm));
            Cards.Add(Card.Hero("Théoden", "F4529F02-EE47-4FA4-A5E3-F755E3620CF3", Sphere.Spirit, 12, 2, 3, 2, 4)
                .WithTraits("Noble.", "Rohan.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Reduce the cost of the first Rohan ally you play from your hand each round by 1 (to a minimum of 0).")
                .WithFlavor("\"Arise now, arise, Riders of Théoden!\" -The Two Towers")
                .WithInfo(2, 1, Artist.Tiziano_Baracchi));
            Cards.Add(Card.Hero("Treebeard", "A9CD7B5C-39B9-4446-9075-636E5F69761F", Sphere.Lore, 13, 2, 3, 3, 5)
                .WithTraits("Ent.")
                .WithText("Action: Deal 1 damage to Treebeard to give him +1 Willpower and +1 Attack until the end of the phase. (Limit 5 times per phase.)")
                .WithInfo(3, 1, Artist.Unknown));
            Cards.Add(Card.Ally("Gimli", "8C4FBDC9-60C4-446D-B7E9-14AECD7DC0C6", Sphere.Leadership, 4, 2, 2, 2, 3)
                .WithUnique()
                .WithTraits("Dwarf.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After an enemy is revealed from the encounter deck, ready Gimli.")
                .WithInfo(4, 3, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Ally("Legolas", "7727D4B3-D23D-403D-8BC2-2C77665CBE93", Sphere.Tactics, 4, 1, 3, 1, 3)
                .WithUnique()
                .WithTraits("Silvan.", "Warrior.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Legolas participates in an attack that destroys an enemy, draw 1 card.")
                .WithFlavor("\"He stands not alone,\" said Legolas, bending his bow and fitting an arrow with hands that moved quicker than sight. -The Two Towers")
                .WithInfo(5, 3, Artist.Sebastian_Giacobino));
            Cards.Add(Card.Ally("Quickbeam", "84910290-AC5D-4904-8998-9851A598B9AB", Sphere.Lore, 2, 2, 3, 1, 3)
                .WithUnique()
                .WithTraits("Ent.")
                .WithText("Cannot have restricted attachments. Enters play exhausted.\r\nResponse: After Quickbeam enters play, deal 1 damage to him to ready him.")
                .WithFlavor("\"I am Bregalad, that is Quickbeam in your language. But it is only a nickname, of course.\" -The Two Towers")
                .WithInfo(6, 3, Artist.Mike_Nash));
            Cards.Add(Card.Ally("Háma", "7EFDF1B5-E3B9-4563-8E12-A2E0C60845F7", Sphere.Spirit, 3, 1, 2, 2, 2)
                .WithNormalizedTitle("Hama")
                .WithUnique()
                .WithTraits("Rohan.", "Warrior.")
                .WithText("Combat Action: Ready Háma. He gets +3 Defense until the end of the phase. At the end of the phase, discard Háma. (Limit once per round.)")
                .WithFlavor("\"I am the Doorward of Théoden,\" he said. \"Háma is my name.\" -The Two Towers")
                .WithInfo(7, 3, Artist.Sara_Betsy));
            Cards.Add(Card.Attachment("Arod", "4CED4D30-CEDD-4FB4-8291-7C93980A2F74", Sphere.Tactics, 1)
                .WithUnique()
                .WithTraits("Mount.")
                .WithText("Attach to a hero or Legolas.\r\nResponse: After attached character participates in an attack that destroys an enemy, exhaust Arod to place 1 progress token on any location.")
                .WithFlavor("\"A smaller and lighter horse, but restive and fiery, was brought to Legolas. Arod was his name.\" -The Two Towers")
                .WithInfo(8, 3, Artist.Smirtouille));
            Cards.Add(Card.Attachment("Ent Draught", "1FE6699C-7753-4A5B-9A1D-EDF59F1D23F0", Sphere.Lore, 1)
                .WithTraits("Item.", "Ent.")
                .WithText("Play only if you control at least 1 Ent character.\r\nAttach to a character. Limit 1 per character.\r\nAttached character gets +2 hit points.")
                .WithFlavor("The effect of the draught began at the toes, and rose steadily through every limb, bringing refreshment and vigour as it coursed upwards, right to the tips of the hair. -The Two Towers")
                .WithInfo(9, 3, Artist.Aurelien_Hubert));
            Cards.Add(Card.Attachment("Herugrim", "0E512381-7B67-45D3-BAE5-6CF0DDA4176B", Sphere.Spirit, 3)
                .WithUnique()
                .WithTraits("Item.", "Weapon.")
                .WithText("Attach to a Rohan hero. Restricted.\r\nReduce the cost to play Herugrim on Théoden by 1.\r\nResponse: Aftr attached hero is declared as an attacker, exhaust Herugrim to add attached hero's Willpower to its Attack for this attack.")
                .WithFlavor("\"Here, lord, is Herugrim, your ancient blade.\" -Háma, The Two Towers")
                .WithInfo(10, 3, Artist.Jason_Ward));
            Cards.Add(Card.Event("Entmoot", "7A734E97-BADA-48B5-BF62-561C578B6791", Sphere.Lore, 0)
                .WithTraits("Ent.")
                .WithText("Play only if you control at least 1 Ent character.\r\nAction: Search the top 5 cards of your deck for any number of Ent cards and add them to your hand. Shuffle the other cards back into your deck.")
                .WithFlavor("\"...it is a gathering of Ents - which does not often happen nowadays.\" -Treebeard, The Two Towers")
                .WithInfo(11, 3, Artist.Anthony_Devine));
            Cards.Add(Card.Event("Helm! Helm!", "4CDEC2D8-3B35-4BD1-BAF5-F18E7641B308", Sphere.Spirit, 2)
                .WithText("Play only after the resolving enemy attacks step is complete.\r\nCombat Action: Exhaust and discard a Rohan ally you control to choose and discard a non-unique enemy engaged with you.")
                .WithFlavor("\"Helm is arisen and comes back to war. Helm for Théoden King!\" -Riders of Rohan, The Two Towers")
                .WithInfo(12, 3, Artist.Smirtouille));
            Cards.Add(Card.Event("The Three Hunters", "207FB055-CAF4-4AA0-804D-7009922CA67B", Sphere.Fellowship, 3)
                .WithText("Play only if you control Fellowship Aragorn.\r\nQuest Action: Choose 3 heroes committed to the quest. Until the end of the round, each of the chosen heroes gets +1 Willpower, +1 Attack and +1 Defense.")
                .WithFlavor("\"We shall makes such a chase as shall be accounted a marvel among the Three Kindreds: Elves, Dwarves, and Men. Forth the Three Hunters!\" -Aragorn, The Two Towers")
                .WithInfo(13, 3, Artist.Nicholas_Gregory));
            Cards.Add(Card.Attachment("Shadowfax", "2DA7519D-4C7F-44A5-9E6E-413A28B5B4FD", Sphere.Neutral, 3)
                .WithUnique()
                .WithTraits("Mount.", "Mearas.")
                .WithText("Attach to Gandalf.\r\nGandalf gains ranged and sentinel.\r\nAction: Exhaust Shadowfax to ready Gandalf.")
                .WithFlavor("\"He is the chief of the Mearas, lords of horses, and not even Théoden, King of Rohan, has ever looked on a better.\" -Gandalf, The Two Towers")
                .WithInfo(14, 3, Artist.Smirtouille));
            Cards.Add(Card.Attachment("Intimidation", "11AD2994-C7E7-4A23-99BA-E6FCA169BA48", Sphere.Neutral, 0)
                .WithBoon()
                .WithTraits("Skill.")
                .WithKeywords("Permanent.")
                .WithText("Setup: Attach to a Warrior hero.\r\nResponse: After attached hero is declared as the only attacker against a non-unique enemy, exhaust Intimidation to give that enemy -2 Defense for this attack.")
                .WithFlavor("\"None knows what the new day shall bring him,\" said Aragorn. \"Get you gone, ere it turn to your evil!\" -Aragorn, The Two Towers")
                .WithInfo(15, 1, Artist.Matt_Stawicki));
            Cards.Add(Card.Attachment("Forewarned", "BE84A618-AD39-4480-BCE2-B210C210C537", Sphere.Neutral, 0)
                .WithBoon()
                .WithTraits("Skill.")
                .WithKeywords("Permanent.")
                .WithText("Setup: Attach to a Ranger hero.\r\nResponse: After attached hero is declared as a defender against a non-unique enemy, exhaust Forewarned to discard 1 shadow card from that enemy.")
                .WithFlavor("\"Faint and far are the feet of our enemies.\"\r\n-Aragorn, The Two Towers")
                .WithInfo(17, 1, Artist.Carly_Janine_Mazur));
            Cards.Add(Card.Attachment("Leader of Men", "FA99DB78-E091-44D8-B3BB-F1379E9BAE27", Sphere.Neutral, 0)
                .WithBoon()
                .WithTraits("Skill.")
                .WithKeywords("Permanent.")
                .WithText("Setup: Attach to a Noble hero.\r\nResponse: After attached hero quests successfully, exhaust Leader of Men to add 1 resource to attached hero's pool.")
                .WithFlavor("\"Take this, dear lord!\" said a clear voice. \"It was ever at your service.\" -The Two Towers")
                .WithInfo(18, 1, Artist.Arden_Beckwith));
            Cards.Add(Card.Attachment("Beyond All Hope", "42EA5106-88D6-4E4B-B806-8684458AD7D9", Sphere.Neutral, 0)
                .WithBoon()
                .WithTraits("Favor.")
                .WithKeywords("Permanent.")
                .WithText("Setup: Attach to a hero.\r\nAttached hero gets +1 Willpower, +1 Attack, +1 Defense and cannot have treachery card attachments.")
                .WithFlavor("\"Beyond all hope you return to us in our need!\" -Aragorn, The Two Towers")
                .WithInfo(19, 1, Artist.Ilich_Henriquez));
            Cards.Add(Card.Attachment("Palantír of Orthanc", "8D9A389B-C84A-48B4-9DBE-29076536B52C", Sphere.Neutral, 0)
                .WithNormalizedTitle("Palantir of Orthanc")
                .WithBoon()
                .WithTraits("Artifact.", "Item.")
                .WithText("Attach to Fellowship Aragorn.\r\nQuest Action: Exhaust Aragorn and Palantír of Orthanc to discard the top card of the encounter deck. If Aragorn's Willpower is greater than the discarded card's Threat, you may add Palantír of Orthanc to the victory display and remove it from the campaign pool to choose a player. That player reveals 1 fewer encounter card this phase (to a minimum of 0).")
                .WithVictoryPoints(5)
                .WithInfo(20, 1, Artist.Magali_Villeneuve));
            Cards.Add(Card.Treachery("Poisoned Counsels", "C02E58E7-85D8-4CD1-A67C-09D3505B1BB0", "Helm's Deep")
                .WithBurden()
                .WithTraits("Corruption.")
                .WithText("Poisoned Counsels functions like a player card.\r\nForced: After you draw this card, discard all other cards in your hand.")
                .WithFlavor("\"And ever Wormtongue's whispering was in your ears, poisoning your thought, chilling your heart, weakening your limbs...\" -Gandalf, The Two Towers")
                .WithInfo(21, 4, Artist.John_Gravato));
            Cards.Add(Card.Objective("To Isengard!", "F3206311-AC23-4F14-A8F5-74D01E228F87", "The Uruk-hai")
                .WithText("Treat each Captive's text box as blank. Captives are in play but are not under any player's control. If there are no Captives in play, the players lose the game.\r\nForced: At the end of the refresh phase, increase the pursuit value by 1. Then, if the pursuit value is 30 or greater, the players lose the game.")
                .WithInfo(22, 1, Artist.Niten));
            Cards.Add(Card.Enemy("Uglúk", "BA97CFE3-1F65-4497-8A29-EEF290EFF967", "The Uruk-hai", 10, 3, 5, 1, 6)
                .WithNormalizedTitle("Ugluk")
                .WithUnique()
                .WithTraits("Orc.", "Uruk-hai.")
                .WithKeywords("Toughness 3.")
                .WithText("Cannot have attachments.\r\nAllies cannot be declared as attackers or defenders against Uglúk.")
                .WithFlavor("\"I am Uglúk. I command.\" -The Two Towers")
                .WithVictoryPoints(5)
                .WithInfo(23, 1, Artist.Sebastian_Giacobino));
            Cards.Add(Card.Enemy("Grishnákh", "0B7B42C9-EBD0-4FF2-81E2-50C331FBA1F3", "The Uruk-hai", 40, 4, 3, 4, 5)
                .WithNormalizedTitle("Grishnakh")
                .WithUnique()
                .WithTraits("Orc.", "Mordor.")
                .WithText("Forced: After Grishnákh enters play, the first player attached 1 of the Captives to him. If Grishnákh is defeated, place the attached Captive faceup underneath To Isengard!\r\nForced: At the end of the quest phase, deal 1 damage to the attached Captive.")
                .WithVictoryPoints(5)
                .WithInfo(24, 1, Artist.Claudio_Pozas));
            Cards.Add(Card.Enemy("Uglúk's Uruk-hai", "BB6D77FC-4F47-48B2-B8FE-08FBDB5CDD83", "The Uruk-hai", 38, 2, 4, 2, 5)
                .WithNormalizedTitle("Ugluk's Uruk-hai")
                .WithTraits("Orc.", "Uruk-hai")
                .WithKeywords("Peril.", "Toughness 1.", "Archery 1.")
                .WithText("When Revealed: Either increase the pursuit value by 3, or reveal an additional encounter card.")
                .WithFlavor("Uglúk shouted, and a number of other Orcs of nearly his own size ran up. -The Two Towers")
                .WithInfo(25, 3, Artist.Aurelien_Hubert)
                .WithEasyModeQuantity(1));
            Cards.Add(Card.Location("The Wold", "C6D201E5-18DB-4FA9-8DA8-EF55E9A75F4D", "The Uruk-hai", 2, 2)
                .WithTraits("Plains.", "Hills.")
                .WithText("While the Wold is the active location, it gains: \"Response: After The Wold is explored, each player draws 1 card.\"\r\nTravel: Increase the pursuit value by 1.")
                .WithFlavor("Ahead and eastward they saw the windy uplands of the Wold of Rohan that they had already glimpsed many days ago from the Great River. -The Two Towers")
                .WithInfo(26, 3, Artist.Jake_Bullock));
            Cards.Add(Card.Location("Eastemnet", "51E29BBB-3554-4051-BFFE-4FB2D2347BAB", "The Uruk-hai", 2, 3)
                .WithTraits("Plains.")
                .WithText("While Eastemnet is the active location, it gains: \"Response: After Eastemnet is explored, add 1 resource to each hero's resource pool.\"\r\nTravel: Increase the pursuit value by 1.")
                .WithFlavor("...the Horse-lords had formerly kept many herds and studs in the Eastemnet, this easterly region of their realm... -The Two Towers")
                .WithInfo(27, 3, Artist.Katy_Grierson));
            Cards.Add(Card.Location("Plains of Rohan", "4F078A73-FD2E-4FAA-A720-6381C0FA35EC", "The Uruk-hai", 254, 4)
                .WithTraits("Plains.")
                .WithText("X is the number of locations in the staging area.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, increase the pursuit value by 1.")
                .WithFlavor("...the green plains of the Rohirrim stretched away before them to the edge of sight. -The Two Towers")
                .WithInfo(28, 4, Artist.Lino_Drieghe)
                .WithEasyModeQuantity(3));
            Cards.Add(Card.Location("Banks of Entwash", "4783FD54-EF89-4E03-80BE-38FB0F053484", "The Uruk-hai", 3, 5)
                .WithTraits("Plains.", "River.")
                .WithText("Forced: After any amount of progress is placed on Banks of Entwash, increase the pursuit value by 1.")
                .WithShadow("Shadow: Either increase the pursuit value by 1, or this attack is considered undefended.")
                .WithFlavor("\"...north-west to the issuing of the Entwash there lies still a wide land.\" -Aragorn, The Two Towers")
                .WithInfo(29, 2, Artist.Katy_Grierson));
            Cards.Add(Card.Treachery("Rest by Night?", "64C6F006-2121-4C80-BB94-FAC5ECB987BD", "The Uruk-hai")
                .WithText("When Revealed: Either immediately end the quest phase and increase the pursuit value by 3, or deal 1 damage to each character commited to the quest. This effect cannot be canceled.")
                .WithFlavor("\"We have come at last to a hard choice,\" he said. \"Shall we rest by night, or shall we go on while our will and strength hold?\" -Aragorn, The Two Towers")
                .WithInfo(30, 2, Artist.Tey_Bartolome));
            Cards.Add(Card.Treachery("Strange Weariness", "1B560500-2F4A-4271-9511-D018A358E52A", "The Uruk-hai")
                .WithTraits("Enchantment.")
                .WithText("When Revealed: Each character commited to the quest gets -1 Willpower until the end of the round.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithFlavor("\"I am weary as I have seldom been before, weary as no Ranger should be with a clear trail to follow.\" -Aragorn, The Two Towers")
                .WithInfo(31, 2, Artist.Romana_Kendelic)
                .WithEasyModeQuantity(1));
            Cards.Add(Card.Treachery("Unseen Barrier", "C150E16B-74EF-4363-BA93-3F2A5CFBF32D", "The Uruk-hai")
                .WithTraits("Enchantment.")
                .WithText("When Revealed: The players cannot place more than 3 progress on the current quest this round. (The does not count progress placed on the active location.)")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, increase the pursuit value by 1.")
                .WithInfo(32, 2, Artist.Arden_Beckwith));

            Cards.Add(Card.Quest("Follow the Orcs", "1AD0CFEB-9A20-4802-A2F9-6D8137967E53", 7, 1, "The Uruk-hai", 254)
                .WithFlavor("The Orcs that attached the Fellowship at Amon Hen captured several members of the Company and are carrying them to Isengard. Aragorn and his companions decide to chase the Uruk-hai in an effort to rescue their friends...")
                .WithText("Setup: Make Estemnet the active location. Add Uglúk and To Isengard! to the staging area. Each player chooses 1 non-Fellowship hero he controls to be a Captive and places it faceup underneath to Isengard! (If playing campaign mode, choose each \"captive\" from the Campaign Log instead). Set the pursuit value to 10.")
                .WithOppositeFlavor("\"With hope or without hope we will follow the trail of our enemies. And woe to them, if we prove the swifter!\" -Aragorn, The Two Towers")
                .WithOppositeText("X is the Pursuit value.\r\nUglúk cannot leave the staging area or take damage.\r\nForced: At the end of the combat phase, increase the pursuit value by 1 for each enemy in the staging area.")
                .WithInfo(69, 1, Artist.Nicholas_Gregory));
            Cards.Add(Card.Quest("Rescue the Captives", "76744E42-56C0-4B65-B13F-1984F9EAF248", 7, 2, "The Uruk-hai", 254)
                .WithFlavor("As their pursuers close in on them, the Uruk-hai race towards the forest of Fangorn with redoubled speed. If the Orcs reach its borders, they will escape into the woods, taking their captives with them...")
                .WithText("When Revealed: Each player searches the encounter deck and discard pile for an Uruk-hai enemy, reveals it, and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("\"Run! There's the forest,\" he shouted, pointing ahead. \"Get to it! It's your best hope. Off you go!\" -Uglúk, The Two Towers")
                .WithOppositeText("X is the pursuit value.\r\nResponse: After an enemy is defeated, reduce the pursuit value by 1.\r\nThe players cannot defeat this stage while Uglúk is in play. If the players defeat this stage, they have rescued each Captive hero and won the game.")
                .WithInfo(70, 1, Artist.Romana_Kendelic));
            Cards.Add(Card.Campaign("The Uruk-hai", "188132B7-CFF0-4803-8055-848343033A2D", 7, "The Uruk-hai", "The Lord of the Rings Part 7")
                .WithText("You are playing campaign mode.\r\nSetup: Remove Gildor Inglorion and Mr. Underhill from the Campaign Pool. Remove each burder with the following burden set icons from the encounter deck:\r\nA ~Shadow of the Past, Flight to the Ford, The ~Ring Goes South")
                .WithFlavor("They followed their enemies now by the clear light of day. It seemed that the Orcs had pressed on with all possible speed. -The Two Towers")
                .WithOppositeText("Resolution: If the pursuit value is 25 or lower, the players must choose: either each player earns one of the Skill boons (Intimidation, Hands of a Healer, Forewarned, or Leader of Men) and attached it to a hero he controls, or one player ears the boon Beyond All Hope and chooses a hero from the list of fallen heroes. That player takes control of the chosen hero (removing it from the list of fallen heroes) and attaches Beyond All Hope to it. If a player controls more than 3 non-Fellowship heroes, he must remove heroes from the Campaign Log until he controls only 3 heroes. Changing heroes as a result of earning Beyond All Hope does not incur a +1 threat penalty. Add the earned cards to the Campaign Pool.")
                .WithOppositeFlavor("Then when they had laid their fallen comrades in a mound and had sung their praises, the Riders made a great fire and scattered the ashes of their enemies. So ended the raid, and no news of it came ever back either to Mordor or Isengard; but the smoke of the burning rose hight ot heaven and was seen by many watchful eyes. -The Two Towers")
                .WithInfo(71, 1, Artist.Nicholas_Gregory));
            Cards.Add(Card.Quest("The King of the Golden Hall", "F80E3197-33B4-4132-8A2D-9203AB1CA181", 8, 1, "Helm's Deep", 255)
                .WithFlavor("The pursuit of the Uruk-hai has brought the Heir of Elendil to Rohan just as Saruman declares war on that land. Aragorn and his companions travel to Edoras to aid King Théoden, but their arrival is met with suspicion...")
                .WithText("Setup: Set The Defense of Helm's Deep and 1 copy of Deeping Wall aside, out of play. Each player sets 1 copy of Soldier of Isengard aside, out of play. Then, the players must choose: either each player shuffles 1 copy of Poisoned Counsels into his deck, or advance to stage 2A (bypassing stage 1B).")
                .WithOppositeFlavor("\"Hail, Théoden son of Thengel! I have returned. For behold! the storm comes, and now all friends should gather together...\" -Gandalf, The Two Towers")
                .WithOppositeText("When Revealed: Each player chooses 1 ally in his hand that matches the sphere of a hero he controls and puts it into play under his control.\r\nSkip the quest phase and combat phase.\r\nForced: At the end of the round, advance to stage 2A.")
                .WithInfo(72, 1, Artist.Katy_Grierson));
            Cards.Add(Card.Quest("Assault on Helm's Deep", "15F98A94-520E-4774-BBFF-9E331511A8BD", 8, 2, "Helm's Deep", 8)
                .WithKeywords("Defense.")
                .WithFlavor("At the behest of Gandalf, Aragorn and his companions ride to Helm's Deep with the men of Rohan and their King. As the sun goes down, the valley below the Deeping Wall fills with the approaching army of Isengard...")
                .WithText("When Revealed: Add the Defense of Helm's Deep and each set aside copy of Soldier of Isengard to the staging area. Make Deeping Wall the active location. Shuffle the encounter deck. Then, each player reveals 1 encounter card.")
                .WithOppositeText("Forced: At the end of the combat phase, if the number of enemies in the staging area is less than the number of players in the game, the first player reveals an encounter card.\r\nForced: At the end of the round place 1 progress here for each enemy in the staging area (bypassing the active location).")
                .WithInfo(73, 1, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(Card.Quest("The Hosts of Isengard", "58BD7102-7CCB-4EA8-BE69-04C94081E1D9", 8, 3, "Helm's Deep", 8)
                .WithKeywords("Defense.")
                .WithFlavor("Against the Deeping Wall the hosts of Isengard roared like a sea. Orcs and hillmen swarmed about its feet from end to end. -The Two Towers")
                .WithText("When Revealed: Search the encounter deck, discard pile, and victory display for Helm's Gate and add it to the staging area. Shuffle the encounter deck. Make Helm's Gate the active location, returning any previous active location to the staging area.")
                .WithOppositeFlavor("Hundreds of long ladders were lifted up. Many were cast down in ruin, but many more replaced them... -The Two Towers")
                .WithOppositeText("Forced: After resolving the quest, if the encounter deck did not place at least 1 progress on this stage as the result of questing, the first player reveals 1 encounter card.")
                .WithInfo(74, 1, Artist.Jason_Ward));
            Cards.Add(Card.Quest("The Wall is Breached!", "00995C4A-E4D7-487A-B1AA-084B9C2BE75C", 8, 4, "Helm's Deep", 8)
                .WithKeywords("Defense.")
                .WithFlavor("Then there was a crash and a flash of flame and smoke. The waters of the Deeping-stream poured out hissing and foaming: they were choked no longer, a gaping hole was blasted in the wall. A host of dark shapes poured in. -The Two Towers")
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck. Discard cards from the encounter deck until X enemies are discarded. X is the number of players. Add each enemy discarded this way to the staging area.")
                .WithOppositeFlavor("Over the wall and under the wall the last assault came sweeping like a dark wave upon a hill of sand. -The Two Towers")
                .WithOppositeText("Forced: After a character is destroyed, place 1 progress on this stage (bypassing any active location).\r\nIf this stage is defeated, the players lose the game.")
                .WithInfo(75, 1, Artist.Anthony_Devine));
            Cards.Add(Card.Quest("The King Rides Out", "AC1A3051-5820-427D-AD95-B0858D52B264", 8, 5, "Helm's Deep", 255)
                .WithFlavor("As dawn breaks in the East, a blast from Helm's Horn echoes in the valley and the Riders of Rohan charge out from Helm's Gate with King Théoden and Aragorn at their head.")
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck. Discard cards from the encounter deck until X enemies are discarded. X is the number of players. Add each enemy discarded this way to the staging area.")
                .WithOppositeFlavor("With a cry and a great noise they charged. Down from the gates they roared, over the causeway they swept, and they drove through the hosts of Isengard as a wind among grass. -The Two Towers")
                .WithOppositeText("Skip the quest phase. Players cannot reduce their threat.\r\nIf there are no enemies in play, the players win the game.")
                .WithInfo(76, 1, Artist.Smirtouille));
            Cards.Add(Card.Campaign("Helm's Deep", "B0A17346-311F-4A71-A68F-EDBBD10493B9", 8, "Helm's Deep", "The Lord of the Rings Part 8")
                .WithText("You are playing campaign mode.\r\nSetup: Each player may change hero cards without incurring the +1 threat penalty. Remove each burden with the following burden set icons from the encounter deck:\r\nA ~Shadow of the Past, Flight to the Ford, The ~Ring Goes South")
                .WithFlavor("\"The shield-wall was broken. Erkenbrand of Westfold has drawn off those men he could gather towards his fastness in Helm's Deep.\" -Ceorl, The Two Towers")
                .WithOppositeText("Resolution: Each player with a copy of Poisoned Counsels in his hand, deck or discard pile has earned that burden. Add the earned cards to the campaign pool.")
                .WithOppositeFlavor("Down through the breach of the Dike charged the king's company. Down from the hills leaped Erkenbrand, lord of Westfold. Down leaped Shadowfax, like a deer that runs surefooted in the mountains. The White Rider was upon them, and the terror of his coming filled the enemy with madness. The wild men fell on their faces before him. The Orcs reeled and screamed and cast aside both sword and spear. Like a black smoke driven by a mounting wind they fled. -The Two Towers")
                .WithInfo(77, 1, Artist.Katy_Grierson));
            Cards.Add(Card.Quest("Rouse the Ents", "CA1724AC-2257-448A-A7E9-95DC747C875F", 9, 1, "The Road to Isengard", 255)
                .WithFlavor("Saruman's army has been defeated at Helm's Deep, but the Wizard's fortress is beyond Rohan's power to capture. However, the Ents of Fangorn have also suffered great injury because of Saruman and his Orcs. They have the strength to break Isengard, but only if they can be roused to attack.")
                .WithText("Setup: Set Gates of Isengard, Orthanc, Saruman, and Saruman's Staff aside, out of play. Add each copy of Ent of Fangorn to the staging area. Shuffle the encounter deck.")
                .WithOppositeText("Players cannot draw cards or gain resources. Do not commit to the quest or reveal encounter cards during the quest phase.\r\nForced: At the end of the round, place 1 resource here. Then, the players may advance to stage 2. If the players advance, the first player shuffle the encounter discard pile into the encounter deck and reveals 1 encounter card for each resource here. Then, remove each Ent objective in the staging area from the game.")
                .WithInfo(78, 1, Artist.Adam_Lane));
            Cards.Add(Card.Quest("Breaking Isengard", "227838F9-061E-4A76-89DD-B471B67C01E1", 9, 2, "The Road to Isengard", 255)
                .WithFlavor("\"To Isengard! Though Isengard be ringed and barred with doors of stone;\r\nThough Isengard be strong and hard, as cold as stone and bare as bone,\r\nWe go, we go, we go to war, to hew the stone and break the door;\r\nFor bole and bough are burning now, the furnace roars - we go to war!\"\r\n-The Ents, The Two Towers")
                .WithText("When Revealed: Make Gates of Isengard the active location. Add Saruman and Orthanc to the staging area.")
                .WithOppositeFlavor("The power of Saruman must be broken and the fortress of Isengard destroyed!")
                .WithOppositeText("The players cannot travel to Orthanc.\r\nForced: After a non-unique location is explored, place 1 damage here. Then, if there are 5 damage tokens here, advance to stage 3A.\r\nQuest Action: Exhaust Ent of Fangorn to place 2 progress on a non-unique location.")
                .WithInfo(79, 1, Artist.Mark_Behm));
            Cards.Add(Card.Quest("The Voice of Saruman", "3D397200-CBF9-4195-A444-B4F4B8DE40EA", 9, 3, "The Road to Isengard", 15)
                .WithFlavor("Suddenly another voice spoke, low and melodious, its very sound an enchantment. Those who listened unwarily to that voice could seldom report the words that they heard... -The Two Towers")
                .WithText("When Revealed: Each player draws 6 cards. Each player witth more than 6 cards in his hand discards cards from his hand until he has only 6.\r\nAttach Saruman's Staff to Saruman.")
                .WithText("While Orthanc is the active location, Saruman is considered to be engaged with the first player.\r\nForced: When Orthanc is explored, cancel any progress placed on the quest this phase and return Orthanc to the staging area.\r\nIf a player has 0 cards in his hand, he is eliminated from the game. If the players defeat this stage, they win the game.")
                .WithInfo(80, 1, Artist.Tiziano_Baracchi));
            Cards.Add(Card.Campaign("The Road to Isengard", "B0DE0027-1DAE-46E6-B6D4-E5BC123BB445", 9, "The Road to Isengard", "The Lord of the Rings Part 9")
                .WithText("You are playing campaign mode.\r\nSetup: Shuffle Saruman's Voice into the encounter deck. Remove each burden with these burden set icons from the encounter deck:\r\nA ~Shadow of the Past, Flight to the Ford, The ~Ring Goes South")
                .WithFlavor("\"Only lately did I guess that Saruman was to blame, and that long ago he had been spying out all the ways, and discovering my secrets. He and his folk are making havoc now.\" -Treebeard, The Two Towers")
                .WithOppositeText("Resolution: If any player has 3 or fewer cards in his hand, the players have earned the Saruman's Voice burden card. If any player has 3 or more cards in his hand, the first player has earned the Palantír of Orthanc boon card. Add the earned cards to the Campaign Pool.")
                .WithOppositeFlavor("\"You have become a fool, Saruman, and yet pitiable. You might still have turned away from folly and evil, and have been of service. But you choose to stay and gnaw the ends of your old plots. Stay then! But I warn you, you will not easily come out again. Not unless the dark hands of the East stretch out to take you.\"\r\n-Gandalf, The Two Towers")
                .WithInfo(81, 1, Artist.Adam_Lane));
        }
    }
}