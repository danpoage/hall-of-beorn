using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.Starter
{
    public class TwoPlayerLimitedEditionStarterSet : CardSet
    {
        private const string setOath = "The Oath";
        private const string setGoblins = "The Goblins";
        private const string setCaves = "The Caves of Nibin-Dûm";

        protected override void Initialize()
        {
            Name = "Two-Player Limited Edition Starter";
            AlternateName = "Two-Player Starter";
            Abbreviation = "TPLES";
            Number = 201;
            SetType = Models.SetType.Starter;

            addHero("Aragorn", 12, Sphere.Leadership, 2, 3, 2, 5)
                .WithTraits("Dúnedain.", "Noble.", "Ranger.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After Aragorn commits to a quest, spend 1 resource from his resource pool to ready him.")
                .WithFlavor("\"I am Aragorn son of Arathorn; and if by life or death I can save you, I will.\"\r\n-The Fellowship of the Ring")
                .WithTemplate("<p class='main-text'>{keyword:Sentinel.}</p><p class='main-text'><b>Response:</b> After {self} commits to a quest, spend 1 resource from his resource pool to ready him.</p><p class='flavor-text'>&quot;I am Aragorn son of Arathorn; and if by life or death I can save you, I will.&quot;<br>&ndash;The Fellowship of the Ring</p>")
                .WithYear(2018)
                .WithInfo(1, 1, Artist.John_Stanko);
            addHero("Gildor Inglorion", 9, Sphere.Leadership, 3, 2, 1, 3)
                .WithTraits("Noldor.", "Noble.")
                .WithText("Action: Pay 1 resource from Gildor Inglorion's resource pool to choose a player to draw 1 card (Limit once per round.)")
                .WithFlavor("\"Gildor Inglorion of the House of Finrod. We are Exiles, and most of our kindred have long ago departed...\r\n-The Fellowship of the Ring")
                .WithYear(2018)
                .WithInfo(2, 1, Artist.Jason_Jenicke);
            addHero("Nori", 9, Sphere.Spirit, 2, 1, 2, 4)
                .WithTraits("Dwarf.")
                .WithText("Response: After you play a Dwarf character from your hand, reduce your threat by 1.")
                .WithFlavor("\"Nori, at your service.\" -Nori, The Hobbit")
                .WithYear(2018)
                .WithInfo(3, 1, Artist.Blake_Henriksen);
            addAlly("Gandalf", 5, Sphere.Neutral, true, 4, 4, 4, 4)
                .WithTraits("Istari.")
                .WithText("At the end of the round, discard Gandalf from play.\r\nResponse: After Gandalf enters play, (choose 1): draw 3 cards, deal 4 damage to 1 enemy in play, or reduce your threat by 5.")
                .WithSuffix("1")
                .WithInfo(4, 2, Artist.Lucas_Graciano);
            addAlly("Galadriel", 3, Sphere.Leadership, true, 3, 0, 0, 3)
                .WithTraits("Noldor.", "Noble.")
                .WithText("At the end of the round, discard Galadriel from play.\r\nResponse: After you play Galadriel from your hand, search the top 5 cards of your deck for an attachment of cost 3 or less and put it into play. Put the remaining cards back in any order.")
                .WithInfo(5, 2, Artist.Sebastian_Giacobino);
            addAlly("Gimli", 4, Sphere.Leadership, true, 2, 2, 2, 3)
                .WithTraits("Dwarf.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After an enemy is revealed from the encounter deck, ready Gimli.")
                .WithFlavor("\"Give me a row of orc-necks and room to swing and all weariness will fall from me!\"\r\n-The Two Towers")
                .WithInfo(6, 1, Artist.Lukasz_Jaskolski);
            addAlly("Faramir", 4, Sphere.Leadership, true, 2, 1, 2, 3)
                .WithTraits("Gondor.", "Noble.", "Ranger.")
                .WithText("Action: Exhaust Faramir to choose a player. Each character controlled by that player gets +1 Willpower until the end of the phase.")
                .WithFlavor("\"He leads now in all perilous ventures.\"\r\n-Mablung, The Two Towers")
                .WithInfo(7, 1, Artist.Jeff_Himmelman);
            addAlly("Arwen Undómiel", 2, Sphere.Spirit, true, 2, 0, 1, 2)
                .WithTraits("Noldor.", "Noble.")
                .WithText("Response: After Arwen Undómiel exhausts, choose a character. That character gains sentinel and gets +1 Defense until the end of the round.")
                .WithFlavor("\"...she was the Evenstar of her people.\"\r\n-The Fellowship of the Ring")
                .WithTemplate("<p><b>Response:</b> After {self} exhausts, choose a character. That character gains {keyword:Sentinel.@sentinel} and gets +1 {Defense} until the end of the round.</p><p class='flavor-text'>...in whom it was said that the likeness of Lúthien had come on earth again...for she was the Evenstar of her people.<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(8, 1, Artist.Magali_Villeneuve);
            addAlly("Orophin", 3, Sphere.Leadership, true, 2, 2, 0, 2)
                .WithTraits("Silvan.", "Scout.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Orophin enters play, return a Silvan ally from your discard pile to your hand.")
                .WithFlavor("\"Orophin has now gone in haste back to our dwellings to warn our people.\"\r\n-Haldir, The Fellowship of the Ring")
                .WithInfo(9, 1, Artist.Magali_Villeneuve);
            addAlly("Bofur", 3, Sphere.Spirit, true, 2, 1, 1, 3)
                .WithTraits("Dwarf.")
                .WithText("Quest Action: Spend 1 Spirit resource to put Bofur into play from your hand, exhausted and commited to a quest. If you quest successfully this phase and Bofur is still in play, return him to your hand.")
                .WithFlavor("\"Get up lazy-bones...\"\r\n-The Hobbit")
                .WithInfo(10, 1, Artist.Ilich_Henriquez);
            addAlly("Fili", 3, Sphere.Leadership, true, 1, 1, 1, 2)
                .WithTraits("Dwarf.")
                .WithText("Response: After you play Fili from your hand during the planning phase, seach your deck for Kili and put him into play under your control. Then shuffle your deck.")
                .WithFlavor("\"Fili is the youngest and still has the best sight.\"\r\n-Thorin, The Hobbit")
                .WithInfo(11, 1, Artist.Carmen_Cianelli);
            addAlly("Kili", 3, Sphere.Spirit, true, 1, 1, 1, 2)
                .WithTraits("Dwarf.")
                .WithText("Response: After you play Kili from your hand during the planning phase, seach your deck for Fili and put him into play under your control. Then shuffle your deck.")
                .WithFlavor("\"Let us join the throng!\"\r\n-The Hobbit")
                .WithInfo(12, 1, Artist.Carmen_Cianelli);
            addAlly("Silverlode Archer", 3, Sphere.Leadership, false, 1, 2, 0, 1)
                .WithTraits("Archer.", "Silvan.")
                .WithKeywords("Ranged.")
                .WithFlavor("\"We have been keeping watch on the rivers, ever since we saw a great troop of Orcs going north towards Moria, along the skirts of the mountains, many days ago.\"\r\n-Haldir, The Fellowship of the Ring")
                .WithInfo(13, 2, Artist.A_M_Sartor);
            addAlly("Defender of the Naith", 3, Sphere.Neutral, false, 0, 1, 2, 2)
                .WithTraits("Silvan.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After a Silvan ally you control leaves play, ready Defender of the Naith.")
                .WithFlavor("\"You cannot cross the rivers again, and behind you there are now secret sentinels that you cannot pass.\"\r\n-Haldir, The Fellowship of the Ring")
                .WithInfo(14, 2, Artist.Christine_Griffin);
            addAlly("Andrath Guardsman", 2, Sphere.Leadership, false, 1, 0, 1, 2)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithText("Response: After you play Andrath Guardsman from your hand, choose a non-unique enemy engaged with you. That enemy cannot attack you this round.")
                .WithFlavor("They forgot or ignored what little they had ever known of the Guardians...\r\n-The Fellowship of the Ring")
                .WithInfo(15, 2, Artist.Adam_Lane);
            addAlly("Woodland Courier", 2, Sphere.Spirit, false, 1, 1, 0, 1)
                .WithTraits("Silvan.", "Scout.")
                .WithText("Response: After Woodland Courier enters play, place 1 progress on a location (2 progress instead if that location has the Forest trait.")
                .WithInfo(16, 2, Artist.Drazenka_Kimpel);
            addAlly("Naith Guide", 2, Sphere.Leadership, false, 1, 1, 0, 1)
                .WithTraits("Silvan.", "Scout.")
                .WithText("Response: After Naith Guide enters play, choose a hero. That hero does not exhaust to quest this round.")
                .WithFlavor("\"I shall lead you well...\"\r\n-Haldir, The Fellowship of the Ring")
                .WithInfo(17, 2, Artist.Magali_Villeneuve);
            addAlly("Blue Mountain Trader", 2, Sphere.Spirit, false, 1, 0, 1, 2)
                .WithTraits("Dwarf.")
                .WithText("Action: Choose another player. That player gains control of Blue Mountain Trader. Then, the player moves 1 resource from the resource pool of a hero he controls to the resource pool of a hero you control, or Blue Mountain Trader is discarded. (Limit once per round.)")
                .WithInfo(18, 2, Artist.Sara_Biddle);
            addAlly("Dwarven Sellsword", 1, Sphere.Leadership, false, 2, 2, 2, 3)
                .WithTraits("Dwarf.", "Warrior.")
                .WithText("Forced: At the end of the round, discard Dwarven Sellsword unless the players as a group spend 1 Leadership resource.")
                .WithFlavor("...he did not altogether approve of the dwarves and their love of gold...\r\n-The Hobbit")
                .WithInfo(19, 2, Artist.Marius_Bota);
            addAttachment("Celebrían's Stone", 2, Sphere.Leadership, true)
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a hero.\r\nAttached hero gains +2 Willpower. If attached hero is Aragorn, he also gains a Spirit resource icon.")
                .WithTemplate("<p class='main-text'>Attach to a hero. {keyword:Restricted.}</p><p class='main-text'>Attached hero gains +2 {Willpower}</p><p class='main-text'>If attached hero is Aragorn, he also gains a {sphere:Spirit} resource icon.</p>")
                .WithInfo(20, 2, Artist.Sara_Biddle);
            addAttachment("Steward of Gondor", 2, Sphere.Leadership, true)
                .WithTraits("Gondor.", "Title.")
                .WithText("Attach to a hero.\r\nAttached hero gains the Gondor trait.\r\nAction: Exhaust Steward of Gondor to add 2 resources to attached hero's resource pool.")
                .WithInfo(21, 2, Artist.Empty_Room_Studios);
            addAttachment("Light of Valinor", 1, Sphere.Spirit, true)
                .WithTraits("Condition.")
                .WithText("Attach to a Nolder or Silvan hero.\r\nAttached hero does not exhaust to commit to a quest.")
                .WithFlavor("\"...those who have dwelt in the Blessed Ralm live at once in both worlds, and against both the Seen and Unseen they have great power.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(22, 1, Artist.Lin_Bo);
            addAttachment("Unexpected Courage", 2, Sphere.Spirit, false)
                .WithTraits("Condition.")
                .WithText("Attach to a hero.\r\nAction: Exhaust Unexpected Courage to ready attached hero.")
                .WithFlavor("\"You cannot trap me, though you try,\r\nin your cobwebs crazy.\"\r\n-Bilbo Baggins, The Hobbit")
                .WithInfo(23, 2, Artist.Angela_Sung);
            addAttachment("Ancient Mathom", 1, Sphere.Spirit, false)
                .WithTraits("Mathom.")
                .WithText("Attach to a location.\r\nResponse: After attached location is explored, the first player draws 3 cards.")
                .WithFlavor("...anything that Hobbits had no immediate use for, but were unwilling to throw away, they called mathom.\r\nThe Fellowship of the Ring")
                .WithInfo(24, 2, Artist.Anna_Mohrbacher);
            addAttachment("Cram", 0, Sphere.Leadership, false)
                .WithTraits("Item.")
                .WithText("Attach to a hero.\r\nAction: Discard Cram to ready attached hero.")
                .WithFlavor("If you want to know what cram is, I can only say that I don't know the recipe; but it is biscuitish, keeps good indefinitely, is supposed to be sustaining, and is certainly not entertaining...\r\n-The Hobbit")
                .WithInfo(25, 2, Artist.Adam_Lane);
            addEvent("Grim Resolve", 5, Sphere.Leadership)
                .WithText("Action: Ready all characters in play.")
                .WithFlavor("\"If there is only one way, then I muse take it. What comes after must come.\"\r\n-Frodo Baggins, The Two Towers")
                .WithInfo(26, 1, Artist.Daarken);
            addEvent("Sneak Attack", 1, Sphere.Leadership)
                .WithText("Action: Put 1 ally card into play from your hand. At the end of the phase, if that ally is still in play, return it to your hand.")
                .WithFlavor("There is a seed of courage hidden (often deeply, it is true) in the heart of the fattest and most timid hobbit...\r\n-The Fellowship of the Ring")
                .WithInfo(27, 2, Artist.Winona_Nelson);
            addEvent("A Test of Will", 1, Sphere.Spirit)
                .WithText("Response: Cancel the 'when revealed' effects of a card that was just revealed from the encounter deck.")
                .WithFlavor("\"There is naught that you can do, other than resist, with hope or without it.\"\r\n-Elrond, The Fellowship of the Ring")
                .WithInfo(28, 2, Artist.Ryan_Barger);
            addEvent("Ever Vigilant", 1, Sphere.Leadership)
                .WithText("Action: Choose and ready 1 ally card.")
                .WithFlavor("\"...no road looks toward safety any longer. Be vigilant!\"\r\n-Gandalf, The Return of the King")
                .WithInfo(29, 2, Artist.Daarken);
            addEvent("Hasty Stroke", 1, Sphere.Spirit)
                .WithText("Response: Cancel a shadow effect just triggered during combat.")
                .WithFlavor("\"The hasty stroke goes oft astray,\" said Aragorn. \"We must press our Enemy, and no longer wait upon him for the move.\"\r\n-The Return of the King")
                .WithInfo(30, 2, Artist.Lius_Lasahido);
            addEvent("Desperate Defense", 1, Sphere.Spirit)
                .WithText("Response: After a sentinel character is declared as a defender, it gets +2 Defense for this attack. If this attack deals no damage, ready the defending character.")
                .WithFlavor("...but along in the porch upon the topmost step stood Beregond...\r\n-The Return of the King")
                .WithInfo(31, 2, Artist.Adam_Lane);
            addEvent("Dwarven Tomb", 1, Sphere.Spirit)
                .WithText("Action: Return a Spirit card from your discard pile to your hand.")
                .WithFlavor("The dwarves of yore made might spells,\r\nWhile hammers fell like rining bells\r\nIn places deep, where dark things sleep...\r\n-The Hobbit")
                .WithInfo(32, 1, Artist.Kaya);
            addEvent("Feigned Voices", 0, Sphere.Leadership)
                .WithText("Combat Action: Return a Silvan ally you control to your hand to choose an enemy engaged with a player. That enemy cannot attack that player this phase.")
                .WithFlavor("\"...we went ahead and spoke with feigned voices...\"\r\n-Haldir, The Fellowship of the Ring")
                .WithInfo(33, 2, Artist.Sara_Betsy);

            addHero("Glorfindel", 12, Sphere.Lore, 3, 3, 1, 5)
                .WithTraits("Noble.", "Noldor.", "Warrior.")
                .WithText("Action: Pay 1 resource from Glorfindel's pool to heal 1 damage on any character. (Limit once per round.)")
                .WithFlavor("\"You saw him for a moment as he is upon the other side: one of the mighty of the firstborn.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithTemplate("<p class='main-text'><b>Action:</b> Pay 1 resource from {self}'s pool to heal 1 damage on any character. (Limit once per round.)</p><p class='flavor-text'>&quot;You saw him for a moment as he is upon the other side: one of the mighty of the firstborn.&quot;<br>&ndash;Gandalf, The Fellowship of the Ring</p>")
                .WithYear(2018)
                .WithInfo(34, 1, Artist.Katherine_Dinger);
            addHero("Bifur", 7, Sphere.Lore, 2, 1, 2, 3)
                .WithTraits("Dwarf.")
                .WithText("Action: Pay 1 resource from a hero's resource pool to add 1 resource to Bifur's resource pool. Any player may trigger this ability. (Limit once per round.)")
                .WithFlavor("\"And winter comes after autumn.\" - Bifur, The Hobbit")
                .WithYear(2018)
                .WithInfo(35, 1, Artist.Magali_Villeneuve);
            addHero("Thorin Stonehelm", 9, Sphere.Tactics, 1, 3, 1, 4)
                .WithTraits("Dwarf.", "Noble.", "Warrior.")
                .WithText("Response: After Thorin Stonehelm is declared as an attacker, discard the top card of your deck to deal 1 damage to an enemy engaged with you.")
                .WithFlavor("Thorin III Stonehelm, Dain's son, became King under the mountain.\r\n-The Return of the King")
                .WithYear(2018)
                .WithInfo(36, 1, Artist.Rafal_Hrynkiewicz);
            addAlly("Gandalf", 5, Sphere.Neutral, true, 4, 4, 4, 4)
                .WithTraits("Istari.")
                .WithText("At the end of the round, discard Gandalf from play.\r\nResponse: After Gandalf enters play, (choose 1): draw 3 cards, deal 4 damage to 1 enemy in play, or reduce your threat by 5.")
                .WithSuffix("2")
                .WithInfo(37, 2, Artist.Lucas_Graciano);
            addAlly("Legolas", 4, Sphere.Tactics, true, 1, 3, 1, 3)
                .WithTraits("Silvan.", "Warrior.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Legolas participates in an attack that destroys an enemy, draw 1 card.")
                .WithFlavor("\"He stands not alone,\" said Legolas, bending his bow and fitting an arrow with hands that moved quicker than sight.\r\n-The Two Towers")
                .WithInfo(38, 1, Artist.Sebastian_Giacobino);
            addAlly("Haldir of Lórien", 4, Sphere.Lore, true, 2, 2, 2, 3)
                .WithKeywords("Ranged.", "Sentinel.")
                .WithFlavor("\"But there are some of use who still go abroad for the gathering of news and the watching of our enemies, and they speak the languages of other lands.\"\r\n-The Fellowship of the Ring")
                .WithInfo(39, 1, Artist.Magali_Villeneuve);
            addAlly("Elrond", 3, Sphere.Lore, true, 3, 2, 3, 3)
                .WithTraits("Noldor.", "Healer.")
                .WithText("At the end of the round, discard Elrond from play.\r\nResponse: After Elrond enters play, choose one: heal all damage on a hero, discard a Condition attachment, or each player draws 1 card.")
                .WithInfo(40, 2, Artist.Allen_Douglas);
            addAlly("Azain Silverbeard", 3, Sphere.Tactics, true, 0, 3, 2, 2)
                .WithTraits("Dwarf.", "Warrior.")
                .WithText("Response: After Azain Silverbeard participates in an attack that destroys an enemy, spend 1 Tactics resource to deal 2 damage to another enemy that shares a Trait with the destroyed enemy. Any player may trigger this response.")
                .WithInfo(41, 1, Artist.Marius_Bota);
            addAlly("Mablung", 2, Sphere.Lore, true, 2, 1, 0, 2)
                .WithTraits("Gondor.", "Ranger.")
                .WithText("Response: After Mablung enters play, choose an enemy to get +5 enagement cost until the end of the round. Then, you may engage that enemy, or return it to the staging area")
                .WithFlavor("\"But still we will not sit idle and let Him do all as He would.\"\r\n-The Two Towers")
                .WithInfo(42, 1, Artist.Beth_Sobel);
            addAlly("Henamarth Riversong", 1, Sphere.Lore, true, 1, 1, 0, 1)
                .WithTraits("Silvan.")
                .WithText("Action: Exhaust Henamarth Riversong to look at the top card of the encounter deck.")
                .WithFlavor("\"And I reckon there's Elves and Elves. They're all elvish enough, but they're not all the same.\"\r\n-Sam Gamgee, The Fellowship of the Ring")
                .WithInfo(43, 1, Artist.Jen_Zee);
            addAlly("Ioreth", 0, Sphere.Lore, true, 0, 0, 0, 1)
                .WithTraits("Gondor.", "Healer.")
                .WithText("Cannot attack or defend.\r\nAction: Spend 1 Lore resource to exhaust Ioreth. Then, heal 3 points of damage from a character. Any player may trigger this action.")
                .WithInfo(44, 1, Artist.Aleksander_Karcz);
            addAlly("Sarn Ford Sentry", 3, Sphere.Lore, false, 2, 1, 0, 2)
                .WithTraits("Dúnedain.", "Scout.")
                .WithText("Response: After Sarn Ford Sentry enters play, draw 1 card for each enemy engaged with you.")
                .WithFlavor("\"Lonely men are we, Rangers of the wild, hunters but hunters ever of the servants of the Enemy...\"\r\n-Aragorn, The Fellowship of the Ring")
                .WithInfo(45, 2, Artist.Smirtouille);
            addAlly("Erebor Hammersmith", 2, Sphere.Lore, false, 1, 1, 1, 3)
                .WithTraits("Dwarf.", "Craftsman.")
                .WithText("Response: After you play Erebor Hammersmith, return the topmost attachment in any player's discard pile to his hand.")
                .WithFlavor("\"In Erebor in the Kingdom of Dain there is such skill...\"\r\n-Aragorn, The Return of the King")
                .WithInfo(46, 2, Artist.Empty_Room_Studios);
            addAlly("Galadhon Archer", 2, Sphere.Tactics, false, 0, 2, 0, 1)
                .WithTraits("Silvan.", "Warrior.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Galadhon Archer enters play, deal 1 damage to an enemy not engaged with you.")
                .WithFlavor("\"...you breathe so loud that they could shoot you in the dark.\"\r\n-Legolas, The Fellowship of the Ring")
                .WithInfo(47, 2, Artist.Sara_K_Diesel);
            addAlly("Galadhrim Minstrel", 2, Sphere.Lore, false, 1, 0, 0, 1)
                .WithTraits("Silvan.", "Minstrel.")
                .WithText("Response: After Galadhrim Minstrel enters play, search the top 5 cards of your deck for an event card and add it to your hand. Shuffle the other cards back into your deck.")
                .WithFlavor("...the language was of Elven-song and spoke of things little now in Middle-earth.\r\n-The Fellowship of the Ring")
                .WithInfo(48, 2, Artist.Arden_Beckwith);
            addAlly("Defender of Rammas", 2, Sphere.Tactics, false, 0, 1, 4, 1)
                .WithTraits("Gondor.", "Warrior.")
                .WithFlavor("\"And the Enemy must pay dearly for the crossing of the River.\"\r\n-Denethor, The Return of the King")
                .WithInfo(49, 2, Artist.Marcia_George_Bogdan);
            addAlly("Dúnedain Lookout", 2, Sphere.Lore, false, 1, 1, 1, 2)
                .WithTraits("Dúnedain.")
                .WithText("Response: Discard Dúnedain Lookout to cancel the 'when revealed' effects of an enemy just revealed from the encounter deck.")
                .WithFlavor("\"Travellers scowl at us and countrymen give us scornful names.\"\r\n-Aragorn, The Fellowship of the Ring")
                .WithInfo(50, 2, Artist.Aleksander_Karcz);
            addAlly("Envoy of Pelargir", 2, Sphere.Neutral, false, 1, 1, 0, 1)
                .WithTraits("Gondor.")
                .WithText("Response: After Envoy of Pelargir enters play, add 1 resource to a Gondor or Noble hero's resource pool.")
                .WithInfo(51, 2, Artist.Magali_Villeneuve);
            addAttachment("Horn of Gondor", 1, Sphere.Tactics, true)
                .WithTraits("Item.", "Artifact.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a hero.\r\nResponse: After a character is destroyed, add 1 resource to attached hero's pool.")
                .WithFlavor("\"Slow should you be to wind that horn again, Boromir,\" said Elrond, \"until you stand once more on the border of your land, and dire need is on you.\"\r\n-The Fellowship of the Ring")
                .WithInfo(52, 2, Artist.Mark_Winters);
            addAttachment("Elf-stone", 1, Sphere.Lore, true)
                .WithTraits("Artifact.", "Item.")
                .WithText("Attach to the active location. Attached location gets +1 quest point.\r\nResponse: After attached location leaves play as an explored location, the first player puts 1 ally into play from his hand.")
                .WithInfo(53, 2, Artist.Sandara_Tang);
            addAttachment("Dwarrowdelf Axe", 1, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Dwarf character.\r\nAttached hero gains +1 Attack.\r\nResponse: After attached character attacks, deal 1 damage to the defending character.")
                .WithInfo(54, 2, Artist.Carolina_Eade);
            addAttachment("Blade of Gondolin", 1, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithText("Attach to a hero.\r\nAttached hero gets +1 Attack when attacking an Orc.\r\nResponse: After attached hero attacks and destroys an enemy, place 1 progress token on the current quest.")
                .WithInfo(55, 2, Artist.David_Lecossu);
            addAttachment("Lembas", 1, Sphere.Lore, false)
                .WithTraits("Item.")
                .WithText("Play only if you control a Noldor or Silvan hero.\r\nAttach to a hero.\r\nAction: Discard Lembas to ready attached hero and heal 3 damage from it.")
                .WithInfo(56, 2, Artist.Sara_Biddle);
            addAttachment("The Long Defeat", 1, Sphere.Lore, false)
                .WithTraits("Condition.")
                .WithText("Attach to a quest card in play. Limit 1 per quest.\r\nResponse: After attached quest is defeated, each player either draws 2 cards or heals up to 5 damage from among characters he controls.")
                .WithFlavor("\"...through the ages of the world we have fought the long defeat.\"\r\n-Galadriel, The Fellowship of the Ring")
                .WithInfo(57, 1, Artist.Jose_Vega);
            addEvent("Gildor's Counsel", 3, Sphere.Lore)
                .WithText("Play during the Quest phase, before characters are commited to the Quest.\r\nAction: Reveal 1 less card from the encounter deck this phase. (To a minimum of 1.)")
                .WithInfo(58, 1, Artist.Magali_Villeneuve);
            addEvent("Feint", 1, Sphere.Tactics)
                .WithText("Combat Action: Choose an enemy engaged with a player. That enemy cannot attack that player this phase.")
                .WithFlavor("A few brave men were strung before them to make a feint of resistance, and many there fell before the rest drew back and fled to either side.\r\n-The Hobbit")
                .WithInfo(59, 2, Artist.Lius_Lasahido);
            addEvent("Secret Paths", 1, Sphere.Lore)
                .WithText("Quest Action: Choose a location in the staging area. Until the end of the phase, that location does not contribute its Threat.")
                .WithFlavor("...Beorn advised them to take this way; for at a place a few days' ride due north of the Carrock was the gate of a little-known pathway through Mirkwood... -The Hobbit")
                .WithInfo(60, 2, Artist.Empty_Room_Studios);
            addEvent("Quick Strike", 1, Sphere.Tactics)
                .WithText("Action: Exhaust a character you control to immediately declare it as an attacker (and resolve its attack) against any eligible enemy target.")
                .WithFlavor("\"...for he that strikes the first blow, if he strikes it hard enough, may need to strike no more.\" -Gandalf, The Two Towers")
                .WithInfo(61, 2, Artist.Sara_Biddle);
            addEvent("Ancestral Knowledge", 1, Sphere.Lore)
                .WithText("Action: Exhaust a Dwarf character to place 2 progress tokens on the active location. (4 progress tokens instead if it is an Underground or Mountain location.)")
                .WithFlavor("\"There is a land where our fathers worked of old...\"\r\nGimli, The Fellowship of the Ring")
                .WithInfo(62, 2, Artist.Cristi_Balanescu);
            addEvent("Khazâd! Khazâd!", 0, Sphere.Tactics)
                .WithText("Action: Choose a Dwarf character. Until the end of the phase, that character gets +3 Attack.")
                .WithFlavor("Down from the wall leapt Gimli with a fierce cry the echoed in the cliffs. \"Khazâd! Khazâd!\" He soon had work enough.\r\n-The Two Towers")
                .WithTemplate("<p><b>Action:</b> Choose a {trait-character:Dwarf.@Dwarf} character. Until the end of the phase, that character gets +3 {Attack}.</p><p class='flavor-text'>Down from the wall leapt Gimli with a fierce cry the echoed in the cliffs. &quot;Khazâd! Khazâd!&quot; He soon had work enough.<br>&ndash;The Two Towers</p>")
                .WithInfo(63, 2, Artist.Igor_Kieryluk);
            addEvent("Daeron's Runes", 0, Sphere.Lore)
                .WithText("Action: Draw 2 cards. Then, discard 1 card for your hand.")
                .WithFlavor("\"These are Daeron's Runes, such as were used of old in Moria...\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(64, 2, Artist.Carolina_Eade);
            addEvent("Pursuing the Enemy", 0, Sphere.Tactics)
                .WithText("Action: Return a Silvan ally you control to your hand to choose a player. Deal 1 damage to each enemy engaged with that player.")
                .WithFlavor("The marauding orcs had been waylaid and almost all destroyed...\r\n-The Fellowship of the Ring")
                .WithInfo(65, 2, Artist.Cristi_Balanescu);
            addEnemy("Spiders of Mirkwood", setOath, 18, 3, 2, 2, 4)
                .WithTraits("Spider.")
                .WithText("While it is engaged with you, Spiders of Mirkwood gets +1 Attack for each exhausted character you control.")
                .WithShadow("Shadow: Choose and exhaust 1 character you control. If this attack was undefended, also deal that character 2 damage.")
                .WithEasyModeQuantity(0)
                .WithInfo(66, 2, Artist.Andrew_Ryan);
            addEnemy("Great Spider", setOath, 34, 2, 3, 1, 3)
                .WithTraits("Spider.")
                .WithText("Forced: After Gret Spider engages you, exhaust a character you control.")
                .WithShadow("Shadow: Deal 1 damage to an exhausted character you control.")
                .WithInfo(67, 2, Artist.Matt_Stewart);
            addLocation("The Eaves of Mirkwood", setOath, 2, 2)
                .WithTraits("Forest.")
                .WithText("While The Eaves of Mirkwood is the active location, encounter card effects cannot be canceled.")
                .WithFlavor("By the afternoon they had reached the eaves of Mirkwood, and were resting almost beneath the great overhanging boughs of its outer trees.\r\n-The Hobbit")
                .WithInfo(68, 2, Artist.Timo_Karhula);
            addLocation("Tangled Grove", setOath, Card.VALUE_X, 3)
                .WithTraits("Forest.")
                .WithText("X is the number of locations in the staging area.\r\nTravel: Each player must discard 1 random card from his hand to travel here.")
                .WithEasyModeQuantity(0)
                .WithInfo(69, 2, Artist.John_Howe);
            addLocation("Forest Gate", setOath, 2, 4)
                .WithTraits("Forest.")
                .WithText("Response: After you travel to Forest Gate, the first player draws 2 cards.")
                .WithFlavor("Soon the light in the gate was like a little bright hole far behind, and the quiet was so deep that their feet seemed to thump along while the trees leaned over them and listened.\r\n-The Hobbit")
                .WithInfo(70, 2, Artist.Ben_Zweifel);
            addLocation("Spider Den", setOath, 4, 4)
                .WithTraits("Forest.")
                .WithText("Quest Action: Search the encounter deck and discard pile for a Spider enemy and put it into play engaged with you to discard Spider Den. (Any player may trigger this effect.)")
                .WithInfo(71, 2, Artist.Jokubas_Uoginitas);
            addLocation("Goblin Trail", setOath, 3, 6)
                .WithTraits("Forest.")
                .WithText("Travel: Reveal the top card of the encounter deck to travel here.\r\nResponse: When Goblin Trail leaves play as an explored location, place 6 progress on the current quest.")
                .WithVictoryPoints(3)
                .WithInfo(72, 2, Artist.Jokubas_Uoginitas);
            addTreachery("Driven by Shadow", setOath)
                .WithText("When Revealed: Each enemy and each location currently in the staging area gets +1 Threat until the end of the phase. If there are no cards in the staging area, Driven by Shadow gains surge.")
                .WithShadow("Shadow: Choose and discard 1 attachment from the defending character. (If this attack is undefended, discard all attachments you control.)")
                .WithInfo(73, 2, Artist.Alexandru_Sabo);
            addTreachery("Surprising Speed", setOath)
                .WithText("When Revealed: Each player returns 1 enemy engaged with him to the staging area. If no enemy was returned to the staging area this way, Surprising Speed gains surge and doomed 1.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. Return attacking enemy to the staging area after this attack.")
                .WithInfo(74, 2, Artist.Matthew_Cowdery);
            addTreachery("Caught in a Web", setOath)
                .WithText("When Revealed: The player with the highest threat level attached this card to one of his heroes. (Counts as a Condition attachment with the text: \"Attached hero does not ready during the refresh phase unless you pay 2 resources from that hero's pool.\")")
                .WithEasyModeQuantity(0)
                .WithInfo(75, 1, Artist.Daryl_Mandryk);
            addEnemy("Goblin Troop", setGoblins, 35, 3, 5, 3, 6)
                .WithTraits("Goblin.", "Orc.")
                .WithText("Cannot have attachments.\r\nWhile Goblin Troop is engaged with you, each other Goblin enemy engaged with you gets +1 Attack and +1 Defense.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack.")
                .WithInfo(76, 1, Artist.Matt_Stewart);
            addEnemy("Goblin Sniper", setGoblins, 48, 2, 2, 0, 2)
                .WithTraits("Goblin.", "Orc.")
                .WithText("During the encounter phase, players cannot optionally engage Goblin Sniper if there are other enemies in the staging area.\r\nForced: If Goblin Sniper is in the staging area at the end of the combat phase, each player deals 1 point of damage to 1 character he controls.")
                .WithInfo(77, 2, Artist.Alexandr_Shaldin);
            addEnemy("Goblin Runners", setGoblins, 20, 1, 3, 1, 2)
                .WithTraits("Goblin.", "Orc.")
                .WithKeywords("Surge.")
                .WithFlavor("Shadow: Attacking enemy makes an additional attack immediately after this one. (Deal a new shadow card for that attack.)")
                .WithEasyModeQuantity(0)
                .WithInfo(78, 2, Artist.Stephane_Gantiez);
            addEnemy("Goblintown Scavengers", setGoblins, 12, 1, 1, 0, 3)
                .WithTraits("Goblin.", "Orc.")
                .WithText("When Revealed: Discard the top card of each player's deck. Until the end of the phase, increase Goblintown Savengers' Threat by the total printed cost of all cards discarded in this way.")
                .WithInfo(79, 2, Artist.Jarreau_Wimberly);
            addTreachery("Goblins are Upon You!", setGoblins)
                .WithText("When Revealed: Each player must search the encounter deck and discard pile for a Goblin enemy and put it into play, engaged with him. Then, shuffle the encounter deck. (This effect cannot be canceled.)")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each Goblin enemy engaged with you.")
                .WithEasyModeQuantity(0)
                .WithInfo(80, 1, Artist.Diego_Gisbert_Llorens);
            addTreachery("Eyes in the Dark", setGoblins)
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Each player must choose: Either raise your threat by 1 for each questing character you control, or discard a questing character you control.")
                .WithShadow("Shadow: If this attack is undefended, discard an ally you control.")
                .WithInfo(81, 2, Artist.Sam_Lamont);
            addEnemy("Goblin Chieftain", setCaves, 40, Card.VALUE_X, Card.VALUE_X, Card.VALUE_X, 8)
                .WithUnique()
                .WithTraits("Goblin.", "Orc.")
                .WithText("X is the stage number of the quest.\r\nCannot take damage. Cannot have attachments.\r\nForced: After Goblin Chieftain attacks, either remove X progress from the quest, or return it to the staging area.")
                .WithInfo(82, 1, Artist.Alexander_Kozachenko);
            addLocation("Cracked Pillar", setCaves, 2, 2)
                .WithUnique()
                .WithTraits("Underground.")
                .WithText("While Cracked Pillar is in the staging area, it gains: \"The first player may declare an attack against Cracked Pillar during the combat phase as if it was an enemy engaged with him. Use Cracked Pillar's Threat as its Defense during this attack.\"\r\nTravel: Remove 4 damage from Cracked Pillar to travel here.")
                .WithInfo(83, 1, Artist.Leanna_Crossan);
            addObjective("Cave Torch", setCaves)
                .WithTraits("Light.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a hero.\r\nAction: Exhause Cave Torch to place up to 3 progress tokens on a Dark location.\r\nForced: After Cave Torch exhausts, discard the top card of the encounter deck. If that card is an enemy, add it to the staging area.")
                .WithInfo(84, 1, Artist.David_Lecossu);
            addEnemy("Great Cave-troll", setCaves, 36, 3, 6, 4, 6)
                .WithTraits("Troll.")
                .WithText("Cannot have attachments.\r\nFor each point of excess combat damage dealt by Great Cave-troll (damage that is dealt beyond the remaining hit points of the character damaged by its attack) remove 1 progress from the current quest.")
                .WithEasyModeQuantity(0)
                .WithInfo(85, 2, Artist.Nicholas_Gregory);
            addEnemy("Cavern Warg", setCaves, 33, 2, 3, 2, 3)
                .WithTraits("Creature.", "Warg.")
                .WithText("Response: When Cavern Warg attacks you, exhaust Cave Torch to cancel the attack and return Cavern Warg to the staging area.")
                .WithShadow("Shadow: If this attack destroys a character, return attacking enemy to the staging area after this attack.")
                .WithInfo(86, 2, Artist.Stanislav_Dikolenko);
            addLocation("Goblin Tunnels", setCaves, 2, 7)
                .WithTraits("Underground.", "Dark.")
                .WithText("While Goblin Tunnels is in the staging area, it gains: \"Forced: After a Goblin is revealed from the encounter deck, remove a progress token from the current quest card.\"")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. (+3 Attack instead if attacking enemy is a Goblin.)")
                .WithInfo(87, 2, Artist.Michael_Rasmussen);
            addLocation("Lightless Passage", setCaves, 4, 4)
                .WithTraits("Underground.", "Dark.")
                .WithText("Travel: Players must exhaust a Cave Torch to travel here.")
                .WithShadow("Shadow: Cancel all combat damage dealt to attacking enemy.")
                .WithInfo(88, 2, Artist.Stu_Barnes);
            addLocation("Branching Paths", setCaves, 1, 3)
                .WithTraits("Underground.", "Dark.")
                .WithText("While Branching Paths is in the staging area, each Dark location gets +1 Threat.\r\nForced: After Branching Paths leaves play as an explored location, look at the top 3 cards of the encounter deck. Players must choose 1 of those to reveal and add to the staging area, moving the other 2 to the bottom of the deck.")
                .WithEasyModeQuantity(0)
                .WithInfo(89, 2, Artist.David_A_Nash);
            addLocation("Collapsed Mine", setCaves, 2, 6)
                .WithTraits("Underground.", "Dark.")
                .WithText("While Collapsed Mine is in the staging area, no more than 4 progress can be placed on the quest each round.")
                .WithShadow("Shadow: Raise your threat by 1 for each point of damage dealt by this attack.")
                .WithInfo(90, 2, Artist.Leanna_Crossan);
            addLocation("Goblin Dungeon", setCaves, 3, 5)
                .WithTraits("Underground.")
                .WithText("Travel: Reveal the top card of the encounter deck to travel here.\r\nResponse: After Goblin Dungeon leaves play as an explored location, the first player searches the top 5 cards of his deck for an ally and puts it into play under his control. Shuffle the rest of the searched cards back into his deck.")
                .WithInfo(91, 2, Artist.Leanna_Crossan);
            addTreachery("Crumbling Ruin", setCaves)
                .WithText("When Revealed: Each player must exhaust a character and discard the top card of his deck, if able. If the printed cost of the discarded card is equal to or higher than the remaining hit points of the exhausted character, discard the exhausted character.")
                .WithInfo(92, 2, Artist.Magali_Villeneuve);
            addTreachery("Lost in the Dark", setCaves)
                .WithText("When Revealed: The player who controls Cave Torch must choose: Either exhaust Cave Torch, or progress cannot be placed on the quest until the end of the phase. (Progress can still be placed on the active location.)")
                .WithShadow("Shadow: Deal 1 damage to the defending character.")
                .WithInfo(93, 2, Artist.Nicholas_Gregory);
            addTreachery("Watchful Eyes", setCaves)
                .WithText("When Revealed: The first player attaches Watchful Eyes to one of his heroes. (Counts as a Condition attachment with the text: \"Limit 1 per hero. Forced: If attached hero is exhausted at the end of the combat phase, reveal 1 card from the encounter deck and add it to the staging area.\")")
                .WithEasyModeQuantity(0)
                .WithInfo(94, 1, Artist.Tiziano_Baracchi);
            addQuest("After the Raid", setOath, 1, 'A', 9)
                .WithFlavor("Marauding Goblins have raided a woodman village on the eaves of Mirkwood forest. The Goblins killed the guards and took many of the villages captive. Those left behind beg you to rescue their loved ones.")
                .WithText("Setup: ~Search the encounter deck for 1 copy of The Eaves of ~Mirkwood and ~Goblin Troop. Add The Eaves of ~Mirkwood to the staging area and set ~Goblin Troop aside, out of play. Shuffle of the encounter deck.")
                .WithOppositeFlavor("You swear an oath to the survivors that you will rescue the captured woodmen and bring justice to the Goblins who attacked them, then you enter Mirkwood forest to find their trail.")
                .WithIncludedEncounterSets(EncounterSet.TheGoblins)
                .WithInfo(95, 1, Artist.Stanislav_Dikolenko);
            addQuest("Mirkwood Forest", setOath, 2, 'A', 12)
                .WithFlavor("The Goblins' trail leads you deeper into the dark forest of Mirkwood. The enemy has a significant lead, but the sign of their passing is easy to follow. You may yet overtake them if you press on.")
                .WithOppositeText("When Revealed: Each player searches the encounter deck and discard pile for a Forest location and adds it to the staging area. Shuffle the encounter deck. This stage cannot be defeated unless at least 1 copy of ~Goblin Trail is in the vitory display.")
                .WithIncludedEncounterSets(EncounterSet.TheGoblins)
                .WithInfo(96, 1, Artist.Jeff_Lee_Johnson);
            addQuest("The Rearguard", setOath, 3, 'A', 6)
                .WithText("When Revealed: The first player adds the set-aside ~Goblin Troop to the staging area. Each other player searches the encounter deck and discard pile for a Goblin enemy and adds it to the staging area.")
                .WithOppositeFlavor("The Goblins are aware of your pursuit and form a rearguard to confront you while the others retreat to their secret hideaway. You must defeat this troop before you can continue your chanse.")
                .WithOppositeText("This stage cannot be defeated while Goblin Troop is in play. When this stage is defeated, the heroes discover the trail to the Goblins' secret lair and the players win the game.")
                .WithIncludedEncounterSets(EncounterSet.TheGoblins)
                .WithInfo(97, 1, Artist.Stanislav_Dikolenko);
            addQuest("The Dark of Nibin-Dûm", setCaves, 1, 'A', 8)
                .WithFlavor("You have pursued the Goblins that attacked a woodman village to the mountains of Mirkwood. The trail leads over a steep ridge where you discover the forgotten Dwarf home of Nibin-Dûm. You light a torch and enter in.")
                .WithText("Setup: ~Search the encounter deck for ~Goblin ~Chieftain, Cracked Pillar, and ~Cave ~Torch. Set ~Goblin ~Chieftain and Cracked Pillar aside, out of play. The first player attached ~Cave ~Torch to one of his heroes. Shuffle the encounter deck.")
                .WithOppositeFlavor("The Dwarves abandonded Nibin-Dûm after an earthquake collapsed part of the mine, but it seems these Goblins have since adopted it as their home. The flickering light of your torch reveals a network of dark passages and you set about searching for signs of the enemy.")
                .WithOppositeText("When Revealed: Each player searches the encounter deck for a different location and adds it to the staging area. Shuffle the encounter deck.")
                .WithIncludedEncounterSets(EncounterSet.TheGoblins)
                .WithInfo(98, 1, Artist.Jason_Jenicke);
            addQuest("Surprise Attack", setCaves, 2, 'A', 0)
                .WithFlavor("As you search the caves of Nibin-Dûm you are ambushed by Goblins!")
                .WithText("When Revealed: Add ~Goblin Chieftain to the staging area. Each player searches the encounter deck and discard pile for a different enemy of his choice and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("The Goblins are led by a large chieftain who whips them into a frenzy. His soldiers attack you with reckless savagery and you struggle to gain the upper hand.")
                .WithOppositeText("During the encounter phase, treat each enemy's engagement cost as if it were 0.\r\nThe stage gets +4 quest points for each enemy in play.")
                .WithIncludedEncounterSets(EncounterSet.TheGoblins)
                .WithInfo(99, 1, Artist.Stanislav_Dikolenko);
            addQuest("The Chasm", setCaves, 3, 'A', Card.VALUE_NA)
                .WithFlavor("The Goblins retreat down a dark tunnel, and you chase them into a large hall of many pillars. A wide chasm runs the width of the hall and the Goblins race across on a large plank. Their chieftain casts the plan into the depths of the chasm and disappeats, leaving you stranded on the other side.")
                .WithText("When Revealed: Set ~Goblin ~Chieftain aside, out of play. Add Cracked Pillar to the staging area.")
                .WithOppositeFlavor("As you search for a way across, you see that one tall pillar near the edge of the chasm has cracked where it meets the ceiling. If you topple the pillar, it could serve to bridge the gap.")
                .WithOppositeText("Forced: Reveal an additional encounter card during the quest phase.\r\nProgress cannot be placed on Cracked Pillar while it is in the staging area.\r\nAfter Cracked Pillar leaves play as an explored location, advance to stage 4A.")
                .WithIncludedEncounterSets(EncounterSet.TheGoblins)
                .WithInfo(100, 1, Artist.Stanislav_Dikolenko);
            addQuest("Oathkeepers", setCaves, 4, 'A', 8)
                .WithFlavor("You've made it across the chasm and resumed the chase. The Goblins rally around their chieftain outside the dungeons where the woodmen villagers are being held. You must defeat the big Goblin if you are to fulfill your oath and rescue the captives.")
                .WithText("When Revealed: Add ~Goblin ~Chieftain to the staging area.")
                .WithOppositeText("While there are at least 8 progress tokens on this stage, ~Goblin ~Chieftain loses the text: \"Cannot take damage.\"\r\nThis stage cannot be defeated while ~Goblin ~Chieftain is in play. When this stage is defeated, the heroes rescue the captives, fulfilling their oaths, and the players win the game!")
                .WithIncludedEncounterSets(EncounterSet.TheGoblins)
                .WithInfo(101, 1, Artist.Alexander_Kozachenko);
        }
    }
}