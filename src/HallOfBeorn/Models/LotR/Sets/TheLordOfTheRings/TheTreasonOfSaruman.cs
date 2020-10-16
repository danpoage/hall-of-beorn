using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheLordOfTheRings
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

            Cards.Add(LotRCard.Hero("Aragorn", "913A68C4-876B-4AD4-AF08-A291B2E3D053", Sphere.Fellowship, 0, 2, 3, 2, 5)
                .WithTraits("Dúnedain.", "Noble.", "Ranger.")
                .WithText("The first player gains control of Aragorn. If Aragorn leaves play, the players lose the game.\r\nAction: Spend 2 resources from Aragorn's resource pool to ready a hero.")
                .WithTemplate("<p>The first player gains control of {self}. If {self} leaves play, the players lose the game.</p><p><b>Action:</b> Spend 2 resources from {self}'s resource pool to ready a {type:Hero@hero}.</p><p class='flavor-text'>&quot;I am Aragorn son of Arathorn and am called Elessar, the Elfstone, Dunadan, the heir of Isildur Elendil’s son of Gondor.&quot;<br>&ndash;The Two Towers</p>")
                .WithInfo(1, 1, Artist.Mark_Behm));
            addHero("Théoden", 12, Sphere.Spirit, 2, 3, 2, 4)
                .WithAlternateSlug("Santa-Theoden")
                .WithTraits("Noble.", "Rohan.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Reduce the cost of the first Rohan ally you play from your hand each round by 1 (to a minimum of 0).")
                .WithFlavorLine("\"Arise now, arise, Riders of Théoden!\"")
                .WithFlavorLine("-The Two Towers")
                .WithCommunityVersion("Théoden-Grey-Company-Gen-Con-2015")
                .WithInfo(2, 1, Artist.Tiziano_Baracchi);
            /*
            Cards.Add(LotRCard.Hero("Théoden", "F4529F02-EE47-4FA4-A5E3-F755E3620CF3", Sphere.Spirit, 12, 2, 3, 2, 4)
                .WithTraits("Noble.", "Rohan.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Reduce the cost of the first Rohan ally you play from your hand each round by 1 (to a minimum of 0).")
                .WithFlavor("\"Arise now, arise, Riders of Théoden!\" -The Two Towers")
                .WithInfo(2, 1, Artist.Tiziano_Baracchi));
            */
            Cards.Add(LotRCard.Hero("Treebeard", "A9CD7B5C-39B9-4446-9075-636E5F69761F", Sphere.Lore, 13, 2, 3, 3, 5)
                .WithTraits("Ent.")
                .WithText("Cannot have restricted attachments.\r\nAction: Deal 1 damage to Treebeard to give him +1 Willpower and +1 Attack until the end of the phase. (Limit 5 times per phase.)")
                //.WithTemplate("<p><b>Action:</b> Deal 1 damage to {self} to give him +1 {Willpower} and +1 {Attack} until the end of the phase. (Limit 5 times per phase.)</p><p class='flavor-text'>&quot;I am not altogether on anybody's side, because nobody is altogether on my side...&quot;<br>&ndash;The Two Towers</p>")
                .WithInfo(3, 1, Artist.Guillaume_Ducos));
            Cards.Add(LotRCard.Ally("Gimli", Sphere.Leadership, 4, 2, 2, 2, 3)
                .WithUnique()
                .WithTraits("Dwarf.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After an enemy is revealed from the encounter deck, ready Gimli.")
                .WithInfo(4, 3, Artist.Lukasz_Jaskolski));
            Cards.Add(LotRCard.Ally("Legolas", Sphere.Tactics, 4, 1, 3, 1, 3)
                .WithUnique()
                .WithTraits("Silvan.", "Warrior.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Legolas participates in an attack that destroys an enemy, draw 1 card.")
                .WithFlavor("\"He stands not alone,\" said Legolas, bending his bow and fitting an arrow with hands that moved quicker than sight. -The Two Towers")
                .WithInfo(5, 3, Artist.Sebastian_Giacobino));
            Cards.Add(LotRCard.Ally("Quickbeam", Sphere.Lore, 2, 2, 3, 1, 3)
                .WithUnique()
                .WithTraits("Ent.")
                .WithText("Cannot have restricted attachments. Enters play exhausted.\r\nResponse: After Quickbeam enters play, deal 1 damage to him to ready him.")
                .WithFlavor("\"I am Bregalad, that is Quickbeam in your language. But it is only a nickname, of course.\" -The Two Towers")
                .WithInfo(6, 3, Artist.Mike_Nash));
            Cards.Add(LotRCard.Ally("Háma", Sphere.Spirit, 3, 1, 2, 2, 2)
                .WithUnique()
                .WithTraits("Rohan.", "Warrior.")
                .WithText("Combat Action: Ready Háma. He gets +3 Defense until the end of the phase. At the end of the phase, discard Háma. (Limit once per round.)")
                .WithFlavor("\"I am the Doorward of Théoden,\" he said. \"Háma is my name.\" -The Two Towers")
                .WithInfo(7, 3, Artist.Sara_Betsy));
            Cards.Add(LotRCard.Attachment("Arod", "4CED4D30-CEDD-4FB4-8291-7C93980A2F74", Sphere.Tactics, 1)
                .WithUnique()
                .WithTraits("Mount.")
                .WithText("Attach to a hero or Legolas.\r\nResponse: After attached character participates in an attack that destroys an enemy, exhaust Arod to place 1 progress token on any location.")
                .WithFlavor("\"A smaller and lighter horse, but restive and fiery, was brought to Legolas. Arod was his name.\" -The Two Towers")
                .WithInfo(8, 3, Artist.Smirtouille));
            Cards.Add(LotRCard.Attachment("Ent Draught", "1FE6699C-7753-4A5B-9A1D-EDF59F1D23F0", Sphere.Lore, 1)
                .WithTraits("Item.", "Ent.")
                .WithText("Play only if you control at least 1 Ent character.\r\nAttach to a character. Limit 1 per character.\r\nAttached character gets +2 hit points.")
                .WithFlavor("The effect of the draught began at the toes, and rose steadily through every limb, bringing refreshment and vigour as it coursed upwards, right to the tips of the hair. -The Two Towers")
                .WithInfo(9, 3, Artist.Aurelien_Hubert));
            addAttachment("Herugrim", 3, Sphere.Spirit, true)
                .WithKeywords("Restricted.")
                .WithTraits("Item.", "Weapon.")
                .WithTextLine("Attach to a Rohan hero. Restricted.")
                .WithTextLine("Reduce the cost to play Herugrim on Théoden by 1.")
                .WithTextLine("Response: After attached hero is declared as an attacker, exhaust Herugrim to add attached hero's Willpower to its Attack for this attack.")
                .WithFlavor("\"Here, lord, is Herugrim, your ancient blade.\" -Háma, The Two Towers")
                .WithInfo(10, 3, Artist.Jason_Ward);
            Cards.Add(LotRCard.Event("Entmoot", "7A734E97-BADA-48B5-BF62-561C578B6791", Sphere.Lore, 0)
                .WithTraits("Ent.")
                .WithText("Play only if you control at least 1 Ent character.\r\nAction: Search the top 5 cards of your deck for any number of Ent cards and add them to your hand. Shuffle the other cards back into your deck.")
                .WithFlavor("\"...it is a gathering of Ents - which does not often happen nowadays.\" -Treebeard, The Two Towers")
                .WithInfo(11, 3, Artist.Anthony_Devine));
            Cards.Add(LotRCard.Event("Helm! Helm!", "4CDEC2D8-3B35-4BD1-BAF5-F18E7641B308", Sphere.Spirit, 2)
                .WithText("Play only after the resolving enemy attacks step is complete.\r\nCombat Action: Exhaust and discard a Rohan ally you control to choose and discard a non-unique enemy engaged with you.")
                .WithFlavor("\"Helm is arisen and comes back to war. Helm for Théoden King!\" -Riders of Rohan, The Two Towers")
                .WithInfo(12, 3, Artist.Smirtouille));
            Cards.Add(LotRCard.Event("The Three Hunters", "207FB055-CAF4-4AA0-804D-7009922CA67B", Sphere.Fellowship, 3)
                .WithText("Play only if you control Fellowship Aragorn.\r\nQuest Action: Choose 3 heroes committed to the quest. Ready those heroes. Until the end of the round, each of the chosen heroes gets +1 Willpower, +1 Attack and +1 Defense.")
                .WithFlavor("\"We shall makes such a chase as shall be accounted a marvel among the Three Kindreds: Elves, Dwarves, and Men. Forth the Three Hunters!\" -Aragorn, The Two Towers")
                .WithInfo(13, 3, Artist.Nicholas_Gregory));
            Cards.Add(LotRCard.Attachment("Shadowfax", "2DA7519D-4C7F-44A5-9E6E-413A28B5B4FD", Sphere.Neutral, 3)
                .WithUnique()
                .WithTraits("Mount.", "Mearas.")
                .WithText("Attach to Gandalf.\r\nGandalf gains ranged and sentinel.\r\nAction: Exhaust Shadowfax to ready Gandalf.")
                .WithFlavor("\"He is the chief of the Mearas, lords of horses, and not even Théoden, King of Rohan, has ever looked on a better.\" -Gandalf, The Two Towers")
                .WithAlternateSlug("🐎")
                .WithInfo(14, 3, Artist.Smirtouille));
            Cards.Add(LotRCard.Attachment("Intimidation", "11AD2994-C7E7-4A23-99BA-E6FCA169BA48", Sphere.Neutral, 0)
                .WithBoon()
                .WithTraits("Skill.")
                .WithKeywords("Permanent.")
                .WithText("Setup: Attach to a Warrior hero.\r\nResponse: After attached hero is declared as the only attacker against a non-unique enemy, exhaust Intimidation to give that enemy -2 Defense for this attack.")
                .WithFlavor("\"None knows what the new day shall bring him,\" said Aragorn. \"Get you gone, ere it turn to your evil!\" -Aragorn, The Two Towers")
                .WithInfo(15, 1, Artist.Matt_Stawicki));
            Cards.Add(LotRCard.Attachment("Hands of a Healer", "FBD87A4E-DCE0-47DB-82D5-5D94B5741467", Sphere.Neutral, 0)
                .WithBoon()
                .WithTraits("Skill.")
                .WithKeywords("Permanent.")
                .WithText("Setup: Attach to a Healer hero.\r\nAction: Exhaust attached hero and Hands of a ~Healer to heal up to 3 damage from a hero.")
                .WithFlavor("\"Life to the dying\r\nIn the king's hand lying!\"\r\n-Herb-master, The Return of the King")
                .WithInfo(16, 1, Artist.Kristina_Gehrmann));
            Cards.Add(LotRCard.Attachment("Forewarned", "BE84A618-AD39-4480-BCE2-B210C210C537", Sphere.Neutral, 0)
                .WithBoon()
                .WithTraits("Skill.")
                .WithKeywords("Permanent.")
                .WithText("Setup: Attach to a Ranger hero.\r\nResponse: After attached hero is declared as a defender against a non-unique enemy, exhaust Forewarned to discard 1 shadow card from that enemy.")
                .WithFlavor("\"Faint and far are the feet of our enemies.\"\r\n-Aragorn, The Two Towers")
                .WithInfo(17, 1, Artist.Carly_Janine_Mazur));
            Cards.Add(LotRCard.Attachment("Leader of Men", "FA99DB78-E091-44D8-B3BB-F1379E9BAE27", Sphere.Neutral, 0)
                .WithBoon()
                .WithTraits("Skill.")
                .WithKeywords("Permanent.")
                .WithText("Setup: Attach to a Noble hero.\r\nResponse: After attached hero quests successfully, exhaust Leader of Men to add 1 resource to attached hero's pool.")
                .WithFlavor("\"Take this, dear lord!\" said a clear voice. \"It was ever at your service.\" -The Two Towers")
                .WithInfo(18, 1, Artist.Arden_Beckwith));
            Cards.Add(LotRCard.Attachment("Beyond All Hope", "42EA5106-88D6-4E4B-B806-8684458AD7D9", Sphere.Neutral, 0)
                .WithBoon()
                .WithTraits("Favor.")
                .WithKeywords("Permanent.")
                .WithText("Setup: Attach to a hero.\r\nAttached hero gets +1 Willpower, +1 Attack, +1 Defense and cannot have treachery card attachments.")
                .WithFlavor("\"Beyond all hope you return to us in our need!\" -Aragorn, The Two Towers")
                .WithInfo(19, 1, Artist.Ilich_Henriquez));
            Cards.Add(LotRCard.Attachment("Palantír of Orthanc", "8D9A389B-C84A-48B4-9DBE-29076536B52C", Sphere.Neutral, 0)
                .WithUnique()
                .WithBoon()
                .WithTraits("Artifact.", "Item.")
                .WithText("Attach to Fellowship Aragorn.\r\nQuest Action: Exhaust Aragorn and Palantír of Orthanc to discard the top card of the encounter deck. If Aragorn's Willpower is greater than the discarded card's Threat, you may add Palantír of Orthanc to the victory display and remove it from the campaign pool to choose a player. That player reveals 1 fewer encounter card this phase (to a minimum of 0).")
                .WithVictoryPoints(5)
                .WithInfo(20, 1, Artist.Magali_Villeneuve));
            Cards.Add(LotRCard.Treachery("Poisoned Counsels", "C02E58E7-85D8-4CD1-A67C-09D3505B1BB0", "Helm's Deep")
                .WithBurden()
                .WithTraits("Corruption.")
                .WithText("Poisoned Counsels functions like a player card.\r\nForced: After you draw this card, discard all other cards in your hand.")
                .WithFlavor("\"And ever Wormtongue's whispering was in your ears, poisoning your thought, chilling your heart, weakening your limbs...\" -Gandalf, The Two Towers")
                .WithInfo(21, 4, Artist.John_Gravato));
            Cards.Add(LotRCard.Objective("To Isengard!", "F3206311-AC23-4F14-A8F5-74D01E228F87", "The Uruk-hai")
                .WithText("Treat each Captive's text box as blank. Captives are in play but are not under any player's control. If there are no Captives in play, the players lose the game.\r\nForced: At the end of the refresh phase, increase the pursuit value by 1. Then, if the pursuit value is 30 or greater, the players lose the game.")
                .WithInfo(22, 1, Artist.Niten));
            Cards.Add(LotRCard.Enemy("Uglúk", "BA97CFE3-1F65-4497-8A29-EEF290EFF967", "The Uruk-hai", 10, 3, 5, 1, 6)
                .WithUnique()
                .WithTraits("Orc.", "Uruk-hai.")
                .WithKeywords("Toughness 3.")
                .WithText("Cannot have attachments.\r\nAllies cannot be declared as attackers or defenders against Uglúk.")
                .WithFlavor("\"I am Uglúk. I command.\" -The Two Towers")
                .WithVictoryPoints(5)
                .WithInfo(23, 1, Artist.Sebastian_Giacobino));
            Cards.Add(LotRCard.Enemy("Grishnákh", "0B7B42C9-EBD0-4FF2-81E2-50C331FBA1F3", "The Uruk-hai", 40, 4, 3, 4, 5)
                .WithUnique()
                .WithTraits("Orc.", "Mordor.")
                .WithText("Forced: After Grishnákh enters play, the first player attached 1 of the Captives to him. If Grishnákh is defeated, place the attached Captive faceup underneath To Isengard!\r\nForced: At the end of the quest phase, deal 1 damage to the attached Captive.")
                .WithVictoryPoints(5)
                .WithInfo(24, 1, Artist.Claudio_Pozas));
            Cards.Add(LotRCard.Enemy("Uglúk's Uruk-hai", "BB6D77FC-4F47-48B2-B8FE-08FBDB5CDD83", "The Uruk-hai", 38, 2, 4, 2, 5)
                .WithTraits("Orc.", "Uruk-hai")
                .WithKeywords("Peril.", "Toughness 1.", "Archery 1.")
                .WithText("When Revealed: Either increase the pursuit value by 3, or reveal an additional encounter card.")
                .WithFlavor("Uglúk shouted, and a number of other Orcs of nearly his own size ran up. -The Two Towers")
                .WithInfo(25, 3, Artist.Aurelien_Hubert)
                .WithEasyModeQuantity(1));
            Cards.Add(LotRCard.Location("The Wold", "C6D201E5-18DB-4FA9-8DA8-EF55E9A75F4D", "The Uruk-hai", 2, 2)
                .WithTraits("Plains.", "Hills.")
                .WithText("While the Wold is the active location, it gains: \"Response: After The Wold is explored, each player draws 1 card.\"\r\nTravel: Increase the pursuit value by 1.")
                .WithFlavor("Ahead and eastward they saw the windy uplands of the Wold of Rohan that they had already glimpsed many days ago from the Great River. -The Two Towers")
                .WithInfo(26, 3, Artist.Jake_Bullock));
            Cards.Add(LotRCard.Location("Eastemnet", "51E29BBB-3554-4051-BFFE-4FB2D2347BAB", "The Uruk-hai", 2, 3)
                .WithTraits("Plains.")
                .WithText("While Eastemnet is the active location, it gains: \"Response: After Eastemnet is explored, add 1 resource to each hero's resource pool.\"\r\nTravel: Increase the pursuit value by 1.")
                .WithFlavor("...the Horse-lords had formerly kept many herds and studs in the Eastemnet, this easterly region of their realm... -The Two Towers")
                .WithInfo(27, 3, Artist.Katy_Grierson));
            Cards.Add(LotRCard.Location("Plains of Rohan", "4F078A73-FD2E-4FAA-A720-6381C0FA35EC", "The Uruk-hai", Card.VALUE_X, 4)
                .WithTraits("Plains.")
                .WithText("X is the number of locations in the staging area.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, increase the pursuit value by 1.")
                .WithFlavor("...the green plains of the Rohirrim stretched away before them to the edge of sight. -The Two Towers")
                .WithInfo(28, 4, Artist.Lino_Drieghe)
                .WithEasyModeQuantity(3));
            Cards.Add(LotRCard.Location("Banks of Entwash", "4783FD54-EF89-4E03-80BE-38FB0F053484", "The Uruk-hai", 3, 5)
                .WithTraits("Plains.", "River.")
                .WithText("Forced: After any amount of progress is placed on Banks of Entwash, increase the pursuit value by 1.")
                .WithShadow("Shadow: Either increase the pursuit value by 1, or this attack is considered undefended.")
                .WithFlavor("\"...north-west to the issuing of the Entwash there lies still a wide land.\" -Aragorn, The Two Towers")
                .WithInfo(29, 2, Artist.Katy_Grierson));
            Cards.Add(LotRCard.Treachery("Rest by Night?", "64C6F006-2121-4C80-BB94-FAC5ECB987BD", "The Uruk-hai")
                .WithText("When Revealed: Either immediately end the quest phase and increase the pursuit value by 3, or deal 1 damage to each character commited to the quest. This effect cannot be canceled.")
                .WithFlavor("\"We have come at last to a hard choice,\" he said. \"Shall we rest by night, or shall we go on while our will and strength hold?\" -Aragorn, The Two Towers")
                .WithInfo(30, 2, Artist.Tey_Bartolome));
            Cards.Add(LotRCard.Treachery("Strange Weariness", "1B560500-2F4A-4271-9511-D018A358E52A", "The Uruk-hai")
                .WithTraits("Enchantment.")
                .WithText("When Revealed: Each character commited to the quest gets -1 Willpower until the end of the round.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithFlavor("\"I am weary as I have seldom been before, weary as no Ranger should be with a clear trail to follow.\" -Aragorn, The Two Towers")
                .WithInfo(31, 2, Artist.Romana_Kendelic)
                .WithEasyModeQuantity(1));
            Cards.Add(LotRCard.Treachery("Unseen Barrier", "C150E16B-74EF-4363-BA93-3F2A5CFBF32D", "The Uruk-hai")
                .WithTraits("Enchantment.")
                .WithText("When Revealed: The players cannot place more than 3 progress on the current quest this round. (The does not count progress placed on the active location.)")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, increase the pursuit value by 1.")
                .WithInfo(32, 2, Artist.Arden_Beckwith));
            Cards.Add(LotRCard.Objective("The Defense of Helm's Deep", "84C8BB39-EABC-47FF-8F1E-E87C68B11395", "Helm's Deep")
                .WithTraits("Siege.")
                .WithText("Add 1 to the total Threat in the staging area for each resource token here.\r\nForced: At the end of the quest phase, place 1 resource token here.\r\nIf there are 8 resource tokens here, add The Defense of Helm's Deep to the victory display and advance to stage 5A.")
                .WithVictoryPoints(8)
                .WithInfo(33, 1, Artist.Jose_Vega));
            Cards.Add(LotRCard.Enemy("Wild Hillman", "3D3119FE-674C-4F7C-AE5B-4DC646565787", "Helm's Deep", 24, 3, 3, 2, 3)
                .WithTraits("Dunland.")
                .WithText("Forced: After Wild Hillman attacks, place 1 progress on the active location.")
                .WithShadow("Shadow: Place 1 progress on the active location. Attacking enemy gets +1 Attack for each progress on the active location.")
                .WithInfo(34, 3, Artist.Anthony_Devine));
            Cards.Add(LotRCard.Enemy("Warrior of Dunland", "07052600-1902-45B6-A502-EF82C106C951", "Helm's Deep", 44, 4, 5, 1, 5)
                .WithTraits("Dunland.")
                .WithKeywords("Peril.", "Archery 1.")
                .WithText("When Revealed: Warrior of Dunland makes an immediate attack against you.\r\nForced: After Warrior of Dunland attacks and destroys a character, place 3 progress on the active location.")
                .WithInfo(35, 2, Artist.Claudio_Pozas)
                .WithEasyModeQuantity(0));
            Cards.Add(LotRCard.Enemy("Soldier of Isengard", "F4D452F8-86C4-47F1-B362-5B32E73EC0A5", "Helm's Deep", 39, 4, 4, 1, 4)
                .WithTraits("Orc.", "Uruk-hai.")
                .WithKeywords("Toughness 1.", "Archery 1.")
                .WithText("Forced: After Soldier of Isengard attacks and destroys a character, place 1 progress on the current quest.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithInfo(36, 4, Artist.Guillaume_Ducos));
            Cards.Add(LotRCard.Location("The Hornburg", "9E26553F-F2EA-4A27-BDB5-1DA6C2ADB791", "Helm's Deep", 3, 3)
                .WithTraits("Helm's Deep.")
                .WithText("While The Hornburg is the active location, reduce the archery total by 1 for each player in the game.\r\nForced: When The Hornburg is explored, assign X damage among characters in play. X is the number of enemies in play.")
                .WithFlavor("But the Hornburg still held fast, like an island in the sea. -The Two Towers")
                .WithInfo(37, 3, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Location("Deeping Wall", "D46BCD9B-D1FE-421E-BA27-9F48D2267754", "Helm's Deep", 4, 4)
                .WithTraits("Helm's Deep.")
                .WithText("While Deeping Wall is the active location, each hero gets +1 Defense.\r\nForced: When Deeping Wall is explored, raise each player's threat by 4.")
                .WithFlavor("The Deeping Wall was twenty feet high, and so thick that four men could walk abreast along the top, sheltered by a parapet over which only a tall man could look. -The Two Towers")
                .WithInfo(38, 4, Artist.Jose_Vega));
            Cards.Add(LotRCard.Location("Deeping Culvert", "26D3320F-F710-478A-BBE6-EE8CBC3E61E6", "Helm's Deep", Card.VALUE_X, 2)
                .WithTraits("Helm's Deep.")
                .WithText("X is the 1 more than the number of allies controlled by the first player.\r\nForced: When Deeping Culvert is explored, each player searches the encounter deck and discard pile for an enemy, reveals it, and adds it to the staging area. Shuffle the encounter deck.")
                .WithFlavor("Orcs had crept like rats through the culvert through which the stream flowed out. -The Two Towers")
                .WithInfo(39, 2, Artist.Mariusz_Gandzel)
                .WithEasyModeQuantity(1));
            Cards.Add(LotRCard.Location("Postern Door", "65FAEBB5-E1B0-46F5-ADDE-C90CF17565DD", "Helm's Deep", 3, 2)
                .WithTraits("Helm's Deep.")
                .WithText("While Postern Door is the active location, each hero gets +1 Attack.\r\nForced: When Postern Door is explored, until the end of the round, players cannot declare attacks.")
                .WithFlavor("There was a small postern-door that opened in an angle of the burg-wall on the west, where the cliff stretched out to meet it. -The Two Towers")
                .WithInfo(40, 2, Artist.Jose_Vega));
            Cards.Add(LotRCard.Location("Helm's Gate", "9035733E-1686-4A19-94B1-5241ED68FFA9", "Helm's Deep", 5, 3)
                .WithTraits("Helm's Deep.")
                .WithText("While Helm's Gate is the active location, if any player is not engaged with an enemy, the first player reveals an encounter card at the end of each staging step.\r\nForced: When Helm's Gate is explored, each enemy gets -20 engagement cost and +2 Attack until the end of the round.")
                .WithInfo(41, 2, Artist.Ed_Mattinian)
                .WithEasyModeQuantity(1));
            Cards.Add(LotRCard.Treachery("Scaling Ladders", "4E69C4A6-39DE-4269-82D5-243FB257AB3D", "Helm's Deep")
                .WithKeywords("Surge.")
                .WithText("When Revealed: Attach to the active location. (Counts a Siege attachment with the text: \"Each enemy gets +1 Threat.\")")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, place 1 progress on the current quest.")
                .WithInfo(42, 3, Artist.Alvaro_Calvo_Escudero)
                .WithEasyModeQuantity(1));
            Cards.Add(LotRCard.Treachery("Devilry of Saruman", "41E4197E-0CA0-49FC-9D8C-EBB911EDC18A", "Helm's Deep")
                .WithText("When Revealed: Place 3 progress on the main quest (bypassing any active location). Until the end of the round, treat each character's text box as if it was blank (except for Traits).")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack and gains Toughness 2 until the end of the round.")
                .WithInfo(43, 3, Artist.Alvaro_Calvo_Escudero)
                .WithErrata(1)
                .WithEasyModeQuantity(2));
            Cards.Add(LotRCard.Treachery("Reckless Hate", "DA50FA48-D71B-4557-A4CA-DD27305FCFF9", "Helm's Deep")
                .WithKeywords("Peril.")
                .WithText("When Revealed: The enemy in the staging area with the highest Attack makes an immediate attack against you. If no attack is made this way, Reckless Hate gains surge.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithInfo(44, 2, Artist.Sebastian_Giacobino));
            Cards.Add(LotRCard.Treachery("Night Without End", "FC5B7B75-8850-4A63-9B5F-4918FAE039CC", "Helm's Deep")
                .WithKeywords("Peril.", "Doomed 2.")
                .WithText("When Revealed: Either remove 1 resource token from The Defense of Helm's Deep, or reveal 2 additional encounter cards.")
                .WithShadow("Shadow: Return attacking enemy to the staging area after this attack.")
                .WithInfo(45, 2, Artist.Arden_Beckwith)
                .WithEasyModeQuantity(1));
            Cards.Add(LotRCard.ObjectiveAlly("Ent of Fangorn", "DF3BA169-E96C-4FAB-8A55-3FE37E15EB00", "The Road to Isengard", 2, 4, 3, 4)
                .WithTraits("Ent.")
                .WithText("While Ent of Fangorn is in the staging area, it gains: \"Quest Action: Exhaust a hero you control to discard the top card of the encounter deck. If that hero's Willpower is greater than the discarded card's Threat, place 1 resource here. Then, if there are 3 resources here, discard them to take control of Ent of Fangorn. Any player may trigger this effect.\"")
                .WithInfo(46, 4, Artist.Mark_Bulahao));
            Cards.Add(LotRCard.Enemy("Saruman", "F43AB6C2-C388-4BE9-97A8-5B77E1487006", "The Road to Isengard", 50, 4, 6, 4, 6)
                .WithUnique()
                .WithTraits("Istari.", "Traitor.")
                .WithKeywords("Indestructible.")
                .WithText("Immune to player card effects. Cannot leave the staging area.\r\nForced: When Saruman is dealt a shadow card with a Wizardry effect, the defending player resolves that Wizardry effect as if he is the only player in the game.")
                .WithInfo(47, 1, Artist.Sebastian_Giacobino));
            Cards.Add(LotRCard.Objective("Saruman's Staff", "8A3DAD61-F086-4812-BE4F-18CD1CCAAFB3", "The Road to Isengard")
                .WithUnique()
                .WithTraits("Artifact.", "Item.", "Staff.")
                .WithText("Forced: After a player draws any number of cards, Saruman attacks that player. Deal and resolve 2 shadow cards for this attack. Then, remove 1 damage from Saruman.\r\nWhile Saruman has any hit points remaining, the players cannot win the game.")
                .WithInfo(48, 1, Artist.Alexandr_Elichev));
            Cards.Add(LotRCard.Enemy("Gríma", "0A8093E8-3972-4794-9130-536038AD50B7", "The Road to Isengard", 1, 3, 2, 3, 3)
                .WithUnique()
                .WithKeywords("Doomed 2.")
                .WithText("Forced: After Gríma attacks a player, that player shuffles Gríma back into the encounter deck and reveals an encounter card.")
                .WithShadow("Shadow: This attack is considered undefended.")
                .WithInfo(49, 1, Artist.Dleoblack)
                .WithEasyModeQuantity(0));
            Cards.Add(LotRCard.Enemy("Lieutenant of Orthanc", "E803F5CF-C81A-4849-ADF9-B335D186A140", "The Road to Isengard", 36, 3, 4, 3, 5)
                .WithTraits("Isengard.")
                .WithText("Forced: After Lieutenant of Orthanc attacks and destroys a character, that character's controller discards 1 random card from his hand.")
                .WithFlavor("\"Saruman kept enough wisdom not to trust his Orcs. He had Men to guard his gates...\" -Merry, The Two Towers")
                .WithInfo(50, 2, Artist.Anthony_Devine));
            Cards.Add(LotRCard.Enemy("Isengard Orc", "B3971C60-FA49-4794-B6D1-C183FE5EA445", "The Road to Isengard", 29, 1, 2, 1, 3)
                .WithTraits("Orc.")
                .WithKeywords("Peril.", "Archery 1.")
                .WithText("When Revealed: Either discard 1 random card from your hand, or reveal an encounter card.")
                .WithShadow("Shadow: Until the end of the round, attacking enemy gets +2 Defense.")
                .WithInfo(51, 2, Artist.Romana_Kendelic));
            Cards.Add(LotRCard.Enemy("Wolf of Isengard", "F019467F-5D25-4B93-8832-088C592A24AF", "The Road to Isengard", 25, 2, 3, 1, 4)
                .WithTraits("Creature.")
                .WithText("Forced: When Wolf of Isengard is dealt a shadow card with a Wizardry effect, either discard 1 card from your hand, or Wolf of Isengard makes an additional attack against you after this one.")
                .WithShadow("Shadow: Deal 1 damage to the defending character.")
                .WithInfo(52, 2, Artist.Piya_Wannachaiwong)
                .WithEasyModeQuantity(1));
            Cards.Add(LotRCard.Location("Orthanc", "FDB4BC16-FC9D-4156-9285-78F728661AE8", "The Road to Isengard", 2, 1)
                .WithUnique()
                .WithTraits("Isengard.")
                .WithText("Immune to player card effects.\r\nWhile Orthanc is in the staging area, it gains: \"Forced: After the players quest successfully, the first player looks at the top 3 cards of the encounter deck, reveals 1, and discards the others.\"")
                .WithFlavor("Still dark and tall, unbroken by the storm, the tower of Orthanc stood. -The Two Towers")
                .WithInfo(53, 1, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Location("Gates of Isengard", "2A16EB91-C479-4685-B813-E601D576339E", "The Road to Isengard", 3, 1)
                .WithUnique()
                .WithTraits("Isengard.")
                .WithText("Immune to player card effects.\r\nForced: When the Gates of Isengard is explored, each player searches the encounter deck and discard pile for an enemy and puts it into play engaged with him. Shuffle the encounter deck.")
                .WithFlavor("Here through the black rock a long tunnel had been hewn, close at either end with mighty doors of iron. -The Two Towers")
                .WithVictoryPoints(1)
                .WithInfo(54, 1, Artist.Lino_Drieghe));
            Cards.Add(LotRCard.Location("Ring-wall of Isengard", "C9CCDCBE-0ABB-44D6-B212-30DA75B0D285", "The Road to Isengard", 2, 2)
                .WithTraits("Isengard.")
                .WithText("While Ring-wall of Isengard is in the staging area, it gains: \"Forced: After any amount of damage is healed from a character, its owner discards 1 card from his hand.\"\r\nWizardry: Each player discards 1 random card from his hand.")
                .WithInfo(55, 3, Artist.Ed_Mattinian));
            Cards.Add(LotRCard.Location("Underground Armoury", "4E53A901-DE33-47A3-87E4-CEDF50DE717B", "The Road to Isengard", 4, 3)
                .WithTraits("Isengard.")
                .WithText("While Underground Armoury is in the staging area, it gains: \"Forced: After an enemy engages a player, deal it a shadow card.\"\r\nWizardry: Each player exhausts a character he controls.")
                .WithFlavor("The shafts ran down by many slopes and spiral stairs to caverns far under; there Saruman had treasuries, store-houses, armouries, smithies, and great furnaces. -The Two Towers")
                .WithInfo(56, 2, Artist.Niten)
                .WithEasyModeQuantity(1));
            Cards.Add(LotRCard.Location("Steaming Vent", "6E1D56E1-891D-4DA5-A91B-B9DD37351DAF", "The Road to Isengard", 3, 4)
                .WithTraits("Isengard.")
                .WithText("While Steaming Vent is in the staging area, it gains: \"Forced: After a player commits characters to the quest, he deals 1 damage to a questing character he controls.\"\r\nWizardry: Assign X damage among characters in play. X is 1 more than the number of players in the game.")
                .WithInfo(57, 3, Artist.Mariusz_Gandzel)
                .WithEasyModeQuantity(1));
            Cards.Add(LotRCard.Location("Plain of Isengard", "A70F9342-518C-4B97-B0D1-ACA88DD2B501", "The Road to Isengard", Card.VALUE_X, 3)
                .WithTraits("Isengard.")
                .WithText("X is the number of players in the game.\r\nWhile Plain of Isengard is in the staging area, archery damage must be assigned to allies, if able.\r\nWizardry: Each player discards 1 ally he controls.")
                .WithInfo(58, 2, Artist.Jose_Vega)
                .WithEasyModeQuantity(1));
            Cards.Add(LotRCard.Location("Open Pit", "FACD13AB-F9E7-4C43-9816-4809361F6320", "The Road to Isengard", 2, 3)
                .WithTraits("Isengard.")
                .WithText("While Open Pit is in the staging area, it gains: \"Forced: After a player draws any number of cards from a player card effect, he raises his threat by 2.\"\r\nWizardry: Each player raises his threat by 2.")
                .WithInfo(59, 2, Artist.Julian_Kok));
            Cards.Add(LotRCard.Treachery("Blast of Sorcery", "86676105-F496-4C63-878D-3B644DB0011C", "The Road to Isengard")
                .WithText("When Revealed: Assign X damage among characters committed to the quest. X is one more than the number of players in the game.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending player has 1 or fewer cards in his hand).")
                .WithInfo(60, 3, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Treachery("Poisoned Vapour", "BB0B9FEA-7127-46DD-850B-0E74F5849E03", "The Road to Isengard")
                .WithKeywords("Surge.")
                .WithText("When Revealed: Exhaust each damaged character. Until the end of the combat phase, treat each damaged character's text box as if it were blank (except for Traits).")
                .WithShadow("Shadow: Discard a non-objective attachment you control.")
                .WithInfo(61, 2, Artist.Romana_Kendelic)
                .WithEasyModeQuantity(0));
            Cards.Add(LotRCard.Treachery("Machines of Isengard", "BD941241-91BA-434E-A0F3-E6138214703E", "The Road to Isengard")
                .WithText("When Revealed: Trigger the Wizardry effect on the active location. If no Wizardry effect is triggered this way, Machines of Isengard gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, discard 1 random card from your hand.")
                .WithInfo(62, 3, Artist.Julian_Kok));
            Cards.Add(LotRCard.Enemy("Isengard Uruk", "163EC4D2-49F5-470D-AD11-22BEDE7028F4", "Orcs of the White Hand", 34, 2, 3, 1, 4)
                .WithTraits("Orc.", "Uruk-hai")
                .WithKeywords("Peril.", "Toughness 1.", "Archery 2.")
                .WithText("When Revealed: Either assign 3 damage among characters you control, or reveal an additional encounter card.")
                .WithFlavor("\"Seldom will Orcs journey in the open under the sun, yet these have done so.\" -Legolas, The Two Towers")
                .WithInfo(63, 3, Artist.Tey_Bartolome)
                .WithEasyModeQuantity(2));
            Cards.Add(LotRCard.Enemy("Uruk-hai Fighter", "932CB527-A2B5-4F10-B116-CCBEAAAB109E", "Orcs of the White Hand", 29, 3, 3, 2, 3)
                .WithTraits("Orc.", "Uruk-hai")
                .WithKeywords("Toughness 2.")
                .WithText("Forced: After Uruk-hai Fighter attacks and destroys a character, return it to the staging area.")
                .WithShadow("Shadow: Discard a non-objective attachment you control.")
                .WithInfo(64, 3, Artist.JB_Casacop));
            Cards.Add(LotRCard.Treachery("Fighting Uruk-hai", "B4944214-09A6-4C50-8E08-5730B1C2523F", "Orcs of the White Hand")
                .WithKeywords("Peril.")
                .WithText("When Revealed: Search the encounter deck and discard pile for an Uruk-hai enemy, reveal it, and put it into play engaged with you. Shuffle the encounter deck. Until the end of the round, each enemy engaged with you adds its Threat to the total Threat in the staging area.")
                .WithInfo(65, 2, Artist.Anthony_Devine)
                .WithEasyModeQuantity(1));
            Cards.Add(LotRCard.Enemy("Snaga", "F6632E8B-1E39-45CD-A67D-361CCED2A8AD", "Snaga Orcs", 44, 1, 3, 1, 3)
                .WithTraits("Orc.")
                .WithKeywords("Peril.", "Archery 1.")
                .WithText("When Revealed: Discard 1 random card from your hand. Snaga gets +X Threat until the end of the round, where X is the discarded card's printed cost.")
                .WithFlavor("Round them were many smaller goblins. -The Two Towers")
                .WithInfo(66, 3, Artist.Jake_Bullock)
                .WithEasyModeQuantity(2));
            Cards.Add(LotRCard.Treachery("Saruman's Orders", "EA6C6B8F-2E95-4A48-8DF1-0ACB0D0DB1C1", "Snaga Orcs")
                .WithText("When Revealed: Each player must choose: either return an enemy engaged with him to the staging area, or reveal an encounter card.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, return attacking enemy to the staging area.")
                .WithInfo(67, 2, Artist.Niten)
                .WithEasyModeQuantity(1));
            Cards.Add(LotRCard.Treachery("Saruman's Voice", "021B05CB-0498-44B2-BF15-31F3FF150042", "The Road to Isengard")
                .WithBurden()
                .WithTraits("Enchantment.")
                .WithKeywords("Peril.", "Doomed 2.")
                .WithText("Peril. Doomed 2.\r\nWhen Revealed: Remove a hero from the quest and attach Saruman's Voice to that hero. (Counts as a Condition attachment with the text: \"Forced: When attached hero commits to a quest, is declared and attacker or defender, or triggers its ability, its controller must discard 1 card from his hand.\")")
                .WithInfo(68, 1, Artist.Ilich_Henriquez));
            Cards.Add(LotRCard.Quest("Follow the Orcs", 1, "The Uruk-hai", Card.VALUE_X)
                .WithFlavor("The Orcs that attached the Fellowship at Amon Hen captured several members of the Company and are carrying them to Isengard. Aragorn and his companions decide to chase the Uruk-hai in an effort to rescue their friends...")
                .WithText("Setup: Make Estemnet the active location. Add Uglúk and To Isengard! to the staging area. Each player chooses 1 non-Fellowship hero he controls to be a Captive and places it faceup underneath to Isengard! (If playing campaign mode, choose each \"captive\" from the Campaign Log instead). Set the pursuit value to 10.")
                .WithOppositeFlavor("\"With hope or without hope we will follow the trail of our enemies. And woe to them, if we prove the swifter!\" -Aragorn, The Two Towers")
                .WithOppositeText("X is the Pursuit value.\r\nUglúk cannot leave the staging area or take damage.\r\nForced: At the end of the combat phase, increase the pursuit value by 1 for each enemy in the staging area.")
                .WithIncludedEncounterSets(EncounterSet.OrcsOfTheWhiteHand, EncounterSet.SnagaOrcs)
                .WithInfo(69, 1, Artist.Nicholas_Gregory));
            Cards.Add(LotRCard.Quest("Rescue the Captives", 2, "The Uruk-hai", Card.VALUE_X)
                .WithFlavor("As their pursuers close in on them, the Uruk-hai race towards the forest of Fangorn with redoubled speed. If the Orcs reach its borders, they will escape into the woods, taking their captives with them...")
                .WithText("When Revealed: Each player searches the encounter deck and discard pile for an Uruk-hai enemy, reveals it, and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("\"Run! There's the forest,\" he shouted, pointing ahead. \"Get to it! It's your best hope. Off you go!\" -Uglúk, The Two Towers")
                .WithOppositeText("X is the pursuit value.\r\nResponse: After an enemy is defeated, reduce the pursuit value by 1.\r\nThe players cannot defeat this stage while Uglúk is in play. If the players defeat this stage, they have rescued each Captive hero and won the game.")
                .WithIncludedEncounterSets(EncounterSet.OrcsOfTheWhiteHand, EncounterSet.SnagaOrcs)
                .WithInfo(70, 1, Artist.Romana_Kendelic));
            Cards.Add(LotRCard.Campaign("The Uruk-hai", "The Uruk-hai", "The Lord of the Rings Part 7")
                .WithText("You are playing campaign mode.\r\nSetup: Remove Gildor Inglorion and Mr. Underhill from the Campaign Pool. Remove each burder with the following burden set icons from the encounter deck:\r\nA ~Shadow of the Past, Flight to the Ford, The ~Ring Goes South")
                .WithFlavor("They followed their enemies now by the clear light of day. It seemed that the Orcs had pressed on with all possible speed. -The Two Towers")
                .WithOppositeText("Resolution: If the pursuit value is 25 or lower, the players must choose: either each player earns one of the Skill boons (Intimidation, Hands of a Healer, Forewarned, or Leader of Men) and attached it to a hero he controls, or one player ears the boon Beyond All Hope and chooses a hero from the list of fallen heroes. That player takes control of the chosen hero (removing it from the list of fallen heroes) and attaches Beyond All Hope to it. If a player controls more than 3 non-Fellowship heroes, he must remove heroes from the Campaign Log until he controls only 3 heroes. Changing heroes as a result of earning Beyond All Hope does not incur a +1 threat penalty. Add the earned cards to the Campaign Pool.")
                .WithOppositeFlavor("Then when they had laid their fallen comrades in a mound and had sung their praises, the Riders made a great fire and scattered the ashes of their enemies. So ended the raid, and no news of it came ever back either to Mordor or Isengard; but the smoke of the burning rose hight ot heaven and was seen by many watchful eyes. -The Two Towers")
                .WithInfo(71, 1, Artist.Nicholas_Gregory));
            Cards.Add(LotRCard.Quest("The King of the Golden Hall", 1, "Helm's Deep", Card.VALUE_NA)
                .WithFlavor("The pursuit of the Uruk-hai has brought the Heir of Elendil to Rohan just as Saruman declares war on that land. Aragorn and his companions travel to Edoras to aid King Théoden, but their arrival is met with suspicion...")
                .WithText("Setup: Set The ~Defense of Helm's Deep and 1 copy of Deeping Wall aside, out of play. Each player sets 1 copy of Soldier of ~Isengard aside, out of play. Then, the players must choose: either each player shuffles 1 copy of Poisoned Counsels into his deck, or advance to stage 2A (bypassing stage 1B).")
                .WithOppositeFlavor("\"Hail, Théoden son of Thengel! I have returned. For behold! the storm comes, and now all friends should gather together...\" -Gandalf, The Two Towers")
                .WithOppositeText("When Revealed: Each player chooses 1 ally in his hand that matches the sphere of a hero he controls and puts it into play under his control.\r\nSkip the quest phase and combat phase.\r\nForced: At the end of the round, advance to stage 2A.")
                .WithIncludedEncounterSets(EncounterSet.OrcsOfTheWhiteHand)
                .WithInfo(72, 1, Artist.Katy_Grierson));
            Cards.Add(LotRCard.Quest("Assault on Helm's Deep", 2, "Helm's Deep", 8)
                .WithKeywords("Defense.")
                .WithFlavor("At the behest of Gandalf, Aragorn and his companions ride to Helm's Deep with the men of Rohan and their King. As the sun goes down, the valley below the Deeping Wall fills with the approaching army of Isengard...")
                .WithText("When Revealed: Add the Defense of Helm's Deep and each set aside copy of Soldier of Isengard to the staging area. Make Deeping Wall the active location. Shuffle the encounter deck. Then, each player reveals 1 encounter card.")
                .WithOppositeText("Forced: At the end of the combat phase, if the number of enemies in the staging area is less than the number of players in the game, the first player reveals an encounter card.\r\nForced: At the end of the round place 1 progress here for each enemy in the staging area (bypassing the active location).")
                .WithIncludedEncounterSets(EncounterSet.OrcsOfTheWhiteHand)
                .WithInfo(73, 1, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Quest("The Hosts of Isengard", 3, "Helm's Deep", 8)
                .WithKeywords("Defense.")
                .WithFlavor("Against the Deeping Wall the hosts of Isengard roared like a sea. Orcs and hillmen swarmed about its feet from end to end. -The Two Towers")
                .WithText("When Revealed: Search the encounter deck, discard pile, and victory display for Helm's Gate and add it to the staging area. Shuffle the encounter deck. Make Helm's Gate the active location, returning any previous active location to the staging area.")
                .WithOppositeFlavor("Hundreds of long ladders were lifted up. Many were cast down in ruin, but many more replaced them... -The Two Towers")
                .WithOppositeText("Forced: After resolving the quest, if the encounter deck did not place at least 1 progress on this stage as the result of questing, the first player reveals 1 encounter card.")
                .WithIncludedEncounterSets(EncounterSet.OrcsOfTheWhiteHand)
                .WithInfo(74, 1, Artist.Jason_Ward));
            Cards.Add(LotRCard.Quest("The Wall is Breached!", 4, "Helm's Deep", 8)
                .WithKeywords("Defense.")
                .WithFlavor("Then there was a crash and a flash of flame and smoke. The waters of the Deeping-stream poured out hissing and foaming: they were choked no longer, a gaping hole was blasted in the wall. A host of dark shapes poured in. -The Two Towers")
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck. Discard cards from the encounter deck until X enemies are discarded. X is the number of players. Add each enemy discarded this way to the staging area.")
                .WithOppositeFlavor("Over the wall and under the wall the last assault came sweeping like a dark wave upon a hill of sand. -The Two Towers")
                .WithOppositeText("Forced: After a character is destroyed, place 1 progress on this stage (bypassing any active location).\r\nIf this stage is defeated, the players lose the game.")
                .WithIncludedEncounterSets(EncounterSet.OrcsOfTheWhiteHand)
                .WithInfo(75, 1, Artist.Anthony_Devine));
            Cards.Add(LotRCard.Quest("The King Rides Out", 5, "Helm's Deep", Card.VALUE_NA)
                .WithFlavor("As dawn breaks in the East, a blast from Helm's Horn echoes in the valley and the Riders of Rohan charge out from Helm's Gate with King Théoden and Aragorn at their head.")
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck. Discard cards from the encounter deck until X enemies are discarded. X is the number of players. Add each enemy discarded this way to the staging area.")
                .WithOppositeFlavor("With a cry and a great noise they charged. Down from the gates they roared, over the causeway they swept, and they drove through the hosts of Isengard as a wind among grass. -The Two Towers")
                .WithOppositeText("Skip the quest phase. Players cannot reduce their threat.\r\nIf there are no enemies in play, the players win the game.")
                .WithIncludedEncounterSets(EncounterSet.OrcsOfTheWhiteHand)
                .WithInfo(76, 1, Artist.Smirtouille));
            Cards.Add(LotRCard.Campaign("Helm's Deep", "Helm's Deep", "The Lord of the Rings Part 8")
                .WithText("You are playing campaign mode.\r\nSetup: Each player may change hero cards without incurring the +1 threat penalty. Remove each burden with the following burden set icons from the encounter deck:\r\nA ~Shadow of the Past, Flight to the Ford, The ~Ring Goes South")
                .WithFlavor("\"The shield-wall was broken. Erkenbrand of Westfold has drawn off those men he could gather towards his fastness in Helm's Deep.\" -Ceorl, The Two Towers")
                .WithOppositeText("Resolution: Each player with a copy of Poisoned Counsels in his hand, deck or discard pile has earned that burden. Add the earned cards to the campaign pool.")
                .WithOppositeFlavor("Down through the breach of the Dike charged the king's company. Down from the hills leaped Erkenbrand, lord of Westfold. Down leaped Shadowfax, like a deer that runs surefooted in the mountains. The White Rider was upon them, and the terror of his coming filled the enemy with madness. The wild men fell on their faces before him. The Orcs reeled and screamed and cast aside both sword and spear. Like a black smoke driven by a mounting wind they fled. -The Two Towers")
                .WithInfo(77, 1, Artist.Katy_Grierson));
            Cards.Add(LotRCard.Quest("Rouse the Ents", 1, "The Road to Isengard", Card.VALUE_NA)
                .WithFlavor("Saruman's army has been defeated at Helm's Deep, but the Wizard's fortress is beyond Rohan's power to capture. However, the Ents of Fangorn have also suffered great injury because of Saruman and his Orcs. They have the strength to break Isengard, but only if they can be roused to attack.")
                .WithText("Setup: Set Gates of Isengard, Orthanc, Saruman, and Saruman's Staff aside, out of play. Add each copy of Ent of Fangorn to the staging area. Shuffle the encounter deck.")
                .WithOppositeText("Players cannot draw cards or gain resources. Do not commit to the quest or reveal encounter cards during the quest phase.\r\nForced: At the end of the round, place 1 resource here. Then, the players may advance to stage 2. If the players advance, the first player shuffle the encounter discard pile into the encounter deck and reveals 1 encounter card for each resource here. Then, remove each Ent objective in the staging area from the game.")
                .WithIncludedEncounterSets(EncounterSet.SnagaOrcs)
                .WithInfo(78, 1, Artist.Adam_Lane));
            Cards.Add(LotRCard.Quest("Breaking Isengard", 2, "The Road to Isengard", Card.VALUE_NA)
                .WithFlavor("\"To Isengard! Though Isengard be ringed and barred with doors of stone;\r\nThough Isengard be strong and hard, as cold as stone and bare as bone,\r\nWe go, we go, we go to war, to hew the stone and break the door;\r\nFor bole and bough are burning now, the furnace roars - we go to war!\"\r\n-The Ents, The Two Towers")
                .WithText("When Revealed: Make Gates of Isengard the active location. Add Saruman and Orthanc to the staging area.")
                .WithOppositeFlavor("The power of Saruman must be broken and the fortress of Isengard destroyed!")
                .WithOppositeText("The players cannot travel to Orthanc.\r\nForced: After a non-unique location is explored, place 1 damage here. Then, if there are 5 damage tokens here, advance to stage 3A.\r\nQuest Action: Exhaust Ent of Fangorn to place 2 progress on a non-unique location.")
                .WithIncludedEncounterSets(EncounterSet.SnagaOrcs)
                .WithInfo(79, 1, Artist.Mark_Behm));
            Cards.Add(LotRCard.Quest("The Voice of Saruman", 3, "The Road to Isengard", 15)
                .WithFlavor("Suddenly another voice spoke, low and melodious, its very sound an enchantment. Those who listened unwarily to that voice could seldom report the words that they heard... -The Two Towers")
                .WithText("When Revealed: Each player draws 6 cards. Each player with more than 6 cards in his hand discards cards from his hand until he has only 6. Attach Saruman's ~Staff to Saruman.")
                .WithOppositeText("While Orthanc is the active location, Saruman is considered to be engaged with the first player.\r\nForced: When Orthanc is explored, cancel any progress placed on the quest this phase and return Orthanc to the staging area.\r\nIf a player has 0 cards in his hand, he is eliminated from the game. If the players defeat this stage, they win the game.")
                .WithIncludedEncounterSets(EncounterSet.SnagaOrcs)
                .WithInfo(80, 1, Artist.Tiziano_Baracchi));
            Cards.Add(LotRCard.Campaign("The Road to Isengard", "The Road to Isengard", "The Lord of the Rings Part 9")
                .WithText("You are playing campaign mode.\r\nSetup: Shuffle Saruman's Voice into the encounter deck. Remove each burden with these burden set icons from the encounter deck:\r\nA ~Shadow of the Past, Flight to the Ford, The ~Ring Goes South")
                .WithFlavor("\"Only lately did I guess that Saruman was to blame, and that long ago he had been spying out all the ways, and discovering my secrets. He and his folk are making havoc now.\" -Treebeard, The Two Towers")
                .WithOppositeText("Resolution: If any player has 3 or fewer cards in his hand, the players have earned the Saruman's Voice burden card. If any player has 3 or more cards in his hand, the first player has earned the Palantír of Orthanc boon card. Add the earned cards to the Campaign Pool.")
                .WithOppositeFlavor("\"You have become a fool, Saruman, and yet pitiable. You might still have turned away from folly and evil, and have been of service. But you choose to stay and gnaw the ends of your old plots. Stay then! But I warn you, you will not easily come out again. Not unless the dark hands of the East stretch out to take you.\"\r\n-Gandalf, The Two Towers")
                .WithInfo(81, 1, Artist.Adam_Lane));
        }
    }
}