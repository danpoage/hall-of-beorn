﻿using System;
using HallOfBeorn.Models;

namespace HallOfBeorn.Data.Core
{
    public static class CoreSetProduct
    {
        public static ProductBuilder Builder()
        {
            var builder = new ProductBuilder(ProductNames.CoreSet, ProductCodes.CoreSet, new DateTime(2020, 4, 20));

            var core = builder.Core(CardSetNames.CoreSet, CardSetAbbreviations.CoreSet, 1);
            
            core.addHero("Aragorn", 12, Sphere.Leadership, 2, 3, 2, 5)
                .WithThumbnail()
                .WithTraits("Dúnedain.", "Noble.", "Ranger.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Response: After Aragorn commits to a quest, spend 1 resource from his resource pool to ready him.")
                .WithFlavor("\"I am Aragorn son of Arathorn; and if by life or death I can save you, I will.\"\r\n-The Fellowship of the Ring")
                .WithTemplate("<p class='main-text'>{keyword:Sentinel.}</p><p class='main-text'><b>Response:</b> After {self} commits to a quest, spend 1 resource from his resource pool to ready him.</p><p class='flavor-text'>&quot;I am Aragorn son of Arathorn; and if by life or death I can save you, I will.&quot;<br>&ndash;The Fellowship of the Ring</p>")
                .WithYear(2010)
                .WithInfo(1, 1, Artists.John_Stanko);
            core.addHero("Théodred", 8, Sphere.Leadership, 1, 2, 1, 4)
                .WithThumbnail()
                .WithTraits("Noble.", "Rohan.", "Warrior.")
                .WithTextLine("Response: After Théodred commits to a quest, choose a hero committed to that quest. Add 1 resource to that hero's resource pool.")
                .WithFlavor("\"Not all is dark. Take courage, Lord of the Mark...\"\r\n-Gandalf, The Two Towers")
                .WithTemplate("<p class='main-text'><b>Response:</b> After {self} commits to a quest, choose a hero committed to that quest. Add 1 resource to that hero's resource pool.</p><p class='flavor-text'>&quot;Not all is dark. Take courage, Lord of the Mark...&quot;<br>&ndash;Gandalf, The Two Towers</p>")
                .WithYear(2010)
                .WithInfo(2, 1, Artists.Jeff_Himmelman);
            core.addHero("Glóin", 9, Sphere.Leadership, 2, 2, 1, 4)
                .WithThumbnail()
                .WithTraits("Dwarf.", "Noble.")
                .WithTextLine("Response: After Glóin suffers damage, add 1 resource to his resource pool for each point of damage he just suffered.")
                .WithFlavor("His beard, very long and forked, was white, nearly as white as the snow-white cloth of his garments.\r\n-The Fellowship of the Ring")
                .WithTemplate("<p class='main-text'><b>Response:</b> After {self} suffers damage, add 1 resource to his resource pool for each point of damage he just suffered.</p><p class='flavor-text'>His beard, very long and forked, was white, nearly as white as the snow-white cloth of his garments.<br>&ndash;The Fellowship of the Ring</p>")
                .WithYear(2010)
                .WithInfo(3, 1, Artists.Tom_Garden);
            core.addHero("Gimli", 11, Sphere.Tactics, 2, 2, 2, 5)
                .WithThumbnail()
                .WithTraits("Dwarf.", "Noble.", "Warrior.")
                .WithTextLine("Gimli gets +1 Attack for each damage token on him.")
                .WithFlavor("\"Men need many words before deeds. My axe is restless in my hands\"\r\n-The Two Towers")
                .WithTemplate("<p class='main-text'>{self} gets +1 {Attack} for each damage token on him.</p><p class='flavor-text'>&quot;Men need many words before deeds. My axe is restless in my hands.&quot<br>&ndash;The Two Towers</p>")
                .WithYear(2010)
                .WithInfo(4, 1, Artists.Tony_Foti);
            core.addHero("Legolas", 9, Sphere.Tactics, 1, 3, 1, 4)
                .WithThumbnail()
                .WithTraits("Noble.", "Silvan.", "Warrior.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Response: After Legolas participates in an attack that destroys an enemy, place 2 progress tokens on the current quest.")
                .WithFlavor("\"I can walk this path, but others have not this skill.\"\r\n-The Fellowship of the Ring")
                .WithTemplate("<p class='main-text'>{keyword:Ranged.}</p><p class='main-text'><b>Response:</b> After {self} participates in an attack that destroys an enemy, place 2 progress tokens on the current quest.</p><p class='flavor-text'>&quot;I can walk this path, but others have not this skill.&quot;<br>&ndash;The Fellowship of the Ring</p>")
                .WithYear(2010)
                .WithInfo(5, 1, Artists.Magali_Villeneuve);
            core.addHero("Thalin", 9, Sphere.Tactics, 1, 2, 2, 4)
                .WithThumbnail()
                .WithTraits("Dwarf.", "Warrior.")
                .WithTextLine("While Thalin is committed to a quest, deal 1 damage to each enemy as it is revealed by the encounter deck.")
                .WithFlavor("There hammer on the anvil smote,\r\nThere chisel clove, and graver wrote;\r\nThere forged was blade, and bound was hilt;\r\nThe delver mined, the mason built.\r\n-The Fellowship of the Ring")
                .WithTemplate("<p>While {self} is committed to a quest, deal 1 damage to each enemy as it is revealed by the encounter deck.</p><p class='flavor-text'>There hammer on the anvil smote,<br>There chisel clove, and graver wrote;<br>There forged was blade, and bound was hilt;<br>The delver mined, the mason built.<br>&ndash;The Fellowship of the Ring</p>")
                .WithErrata()
                .WithYear(2010)
                .WithInfo(6, 1, Artists.Jen_Zee);
            core.addHero("Éowyn", 9, Sphere.Spirit, 4, 1, 1, 3)
                .WithThumbnail()
                .WithTraits("Noble.", "Rohan.")
                .WithTextLine("Action: Discard 1 card from your hand to give Éowyn +1 Willpower until the end of the phase. This effect may be triggered by each player once each round.")
                .WithTemplate("<p class='main-text'><b>Action:</b> Discard 1 card from your hand to give {self} +1 {Willpower} until the end of the phase. This effect may be triggered by each player once each round.</p><p class='flavor-text'>Slender and tall she was in her white robe girt with silver; but strong she seemed and stern as steel, a daughter of kings.<br>&ndash;The Two Towers</p>")
                .WithYear(2010)
                .WithInfo(7, 1, Artists.Gabrielle_Portal);
            core.addHero("Eleanor", 7, Sphere.Spirit, 1, 1, 2, 3)
                .WithThumbnail()
                .WithTraits("Gondor.", "Noble.")
                .WithTextLine("Response: Exhaust Eleanor to cancel the 'when revealed' effects of a treachery card just revealed by the encounter deck. Then, discard that card, and replace it with the next card from the encounter deck.")
                .WithFlavor("\"Gondor wanes, you say. But Gondor stands, and even the end of its strength is very strong.\"\r\n-Boromir, The Fellowship of the Ring")
                .WithTemplate("<p class='main-text'><b>Response:</b> Exhaust {self} to cancel the &quot;when revealed&quot; effects of a treachery card just revealed by the encounter deck. Then, discard that card, and replace it with the next card from the encounter deck.</p><p class='flavor-text'>&quot;Gondor wanes, you say. But Gondor stands, and even the end of its strength is very strong.&quot;<br>&ndash;Boromir, The Fellowship of the Ring</p>")
                .WithErrata()
                .WithYear(2010)
                .WithInfo(8, 1, Artists.Magali_Villeneuve);
            core.addHero("Dúnhere", 8, Sphere.Spirit, 1, 2, 1, 4)
                .WithThumbnail()
                .WithTraits("Rohan.", "Warrior.")
                .WithTextLine("Dúnhere can target enemies in the staging area when he attacks alone. When doing so, he gets +1 Attack.")
                .WithFlavor("Captains rode to meet him at the ford, bearing messages from Gandalf. Dúnhere, chieftain of the folk of Harrowdale, was at their head.\r\n-The Return of the King")
                .WithTemplate("<p class='main-text'>{self} can target enemies in the staging area when he attacks alone. When doing so, he gets +1 {Attack}.</p><p class='flavor-text'>Captains rode to meet him at the ford, bearing messages from Gandalf. Dúnhere, chieftain of the folk of Harrowdale, was at their head.<br>&ndash;The Return of the King</p>")
                .WithYear(2010)
                .WithInfo(9, 1, Artists.Jeff_Himmelman);
            core.addHero("Denethor", 8, Sphere.Lore, 1, 1, 3, 3)
                .WithThumbnail()
                .WithTraits("Gondor.", "Noble.", "Steward.")
                .WithTextLine("Action: Exhaust Denethor to look at the top card of the encounter deck. You may move that card to the bottom of the deck.")
                .WithFlavor("\"And the lord Denethor is unlike other men: he sees far.\"\r\n-Beregond, The Return of the King")
                .WithTemplate("<p><b>Action:</b> Exhaust {self} to look at the top card of the encounter deck. You may move that card to the bottom of the deck.</p><p class='flavor-text'>&quot;And the lord Denethor is unlike other men: he sees far.&quot;<br>&ndash;Beregond, The Return of the King</p>")
                .WithYear(2010)
                .WithInfo(10, 1, Artists.Tiziano_Baracchi);
            core.addHero("Glorfindel", 12, Sphere.Lore, 3, 3, 1, 5)
                .WithThumbnail()
                .WithTraits("Noble.", "Noldor.", "Warrior.")
                .WithTextLine("Action: Pay 1 resource from Glorfindel's pool to heal 1 damage on any character. (Limit once per round.)")
                .WithFlavor("\"You saw him for a moment as he is upon the other side: one of the mighty of the firstborn.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithTemplate("<p class='main-text'><b>Action:</b> Pay 1 resource from {self}'s pool to heal 1 damage on any character. (Limit once per round.)</p><p class='flavor-text'>&quot;You saw him for a moment as he is upon the other side: one of the mighty of the firstborn.&quot;<br>&ndash;Gandalf, The Fellowship of the Ring</p>")
                .WithYear(2010)
                .WithInfo(11, 1, Artists.Katherine_Dinger);
            core.addHero("Beravor", 10, Sphere.Lore, 2, 2, 2, 4)
                .WithThumbnail()
                .WithTraits("Dúnedain.", "Ranger.")
                .WithTextLine("Action: Exhaust Beravor to choose a player. That player draws 2 cards. Limit once per round.")
                .WithFlavor("But in the wild lands beyond Bree there were mysterious wanderers. The Bree-folk called them Rangers, and knew nothing of their origin.\r\n-The Fellowship of the Ring")
                .WithTemplate("<p><b>Action:</b> Exhaust {self} to choose a player. That player draws 2 cards. Limit once per round.</p><p class='flavor-text'>But in the wild lands beyond Bree there were mysterious wanderers. The Bree-folk called them Rangers, and knew nothing of their origin.<br>&ndash;The Fellowship of the Ring</p>")
                .WithErrata()
                .WithYear(2010)
                .WithInfo(12, 1, Artists.Tiziano_Baracchi);
            core.addAlly("Guard of the Citadel", 2, Sphere.Leadership, false, 1, 1, 0, 2)
                .WithTraits("Gondor.", "Warrior.")
                .WithFlavor("\"But the Lords of Minas Tirith still fight on, defying our enemies, keeping the passage of the River from Argonath to the Sea.\"\r\n-Elrond, The Fellowship of the Ring")
                .WithTemplate("<p class='flavor-text'>&quot;But the Lords of Minas Tirith still fight on, defying our enemies, keeping the passage of the River from Argonath to the Sea.&quot;<br>&ndash;Elrond, The Fellowship of the Ring</p>")
                .WithInfo(13, 3, Artists.Leonardo_Borazio);
            core.addAlly("Faramir", 4, Sphere.Leadership, true, 2, 1, 2, 3)
                .WithTraits("Gondor.", "Noble.", "Ranger.")
                .WithTextLine("Action: Exhaust Faramir to choose a player. Each character controlled by that player gets +1 Willpower until the end of the phase.")
                .WithFlavor("\"He leads now in all perilous ventures. But his life is charmed, or fate spares him for some other end.\"\r\n-Mablung, Ranger of Ithilien,\r\nThe Two Towers")
                .WithTemplate("<p class='main-text'><b>Action:</b> Exhaust {self} to choose a player. Each character controlled by that player gets +1 {Willpower} until the end of the phase.</p><p class='flavor-text'>&quot;He leads now in all perilous ventures. But his life is charmed, or fate spares him for some other end.&quot;<br>&ndash;Mablung, Ranger of Ithilien,<br>The Two Towers</p>")
                .WithInfo(14, 2, Artists.Jeff_Himmelman);
            core.addAlly("Son of Arnor", 3, Sphere.Leadership, false, 0, 2, 0, 2)
                .WithTraits("Dúnedain.")
                .WithTextLine("Response: After Son of Arnor enters play, choose an enemy card in the staging area or currently engaged with another player. Engage that enemy.")
                .WithFlavor("...and the North-realm they made in Arnor, and the South-realm in Gondor above the mouths of Anduin.\r\n-The Fellowship of the Ring")
                .WithTemplate("<p class='main-text'><b>Response:</b> After {self} enters play, choose an enemy card in the staging area or currently engaged with another player. Engage that enemy.</p><p class='flavor-text'>...and the North-realm they made in Arnor, and the South-realm in Gondor above the mouths of Anduin.<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(15, 2, Artists.Ryan_Barger);
            core.addAlly("Snowbourn Scout", 1, Sphere.Leadership, false, 0, 0, 1, 1)
                .WithTraits("Rohan.", "Scout.")
                .WithTextLine("Response: After Snowbourn Scout enters play, choose a location. Place 1 progress token on that location.")
                .WithFlavor("...he saw not a shadow, nor a blur, but the small figures of horsemen, many horsemen, and the glint of morning on the tips of their spears was like the twinkle of minute stars beyond the edge of mortal sight.\r\n-The Two Towers")
                .WithTemplate("<p><b>Response:</b> After {self} enters play, choose a location. Place 1 progress token on that location.</p><p class='flavor-text'>...he saw not a shadow, nor a blur, but the small figures of horsemen, many horsemen, and the glint of morning on the tips of their spears was like the twinkle of minute stars beyond the edge of mortal sight.<br>&ndash;The Two Towers</p>")
                .WithInfo(16, 3, Artists.David_Horne);
            core.addAlly("Silverlode Archer", 3, Sphere.Leadership, false, 1, 2, 0, 1)
                .WithTraits("Archer.", "Silvan.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithFlavor("\"We have been keeping watch on the rivers, ever since we saw a great troop of Orcs going north towards Moria, along the skirts of the mountains, many days ago.\"\r\n-Haldir of Lórien, The Fellowship of the Ring")
                .WithTemplate("<p class='main-text'>{keyword:Ranged.}</p><p class='flavor-text'>&quot;We have been keeping watch on the rivers, ever since we saw a great troop of Orcs going north towards Moria, along the skirts of the mountains, many days ago.&quot;<br>&ndash;Haldir of Lórien, The Fellowship of the Ring</p>")
                .WithInfo(17, 2, Artists.A_M_Sartor);
            core.addAlly("Longbeard Orc Slayer", 4, Sphere.Leadership, false, 0, 2, 1, 3)
                .WithTraits("Dwarf.", "Warrior.")
                .WithTextLine("Response: After Longbeard Orc Slayer enters play, deal 1 damage to each Orc enemy in play.")
                .WithFlavor("Five dead Orcs lay there. They had been hewn with many cruel strokes, and two had been beheaded. The ground was wet with their dark blood.\r\n-The Two Towers")
                .WithTemplate("<p class='main-text'><b>Response:</b> After {self} enters play, deal 1 damage to each Orc enemy in play.</p><p class='flavor-text'>Five dead Orcs lay there. They had been hewn with many cruel strokes, and two had been beheaded. The ground was wet with their dark blood.<br>&ndash;The Two Towers</p>")
                .WithInfo(18, 2, Artists.Kaya);
            core.addAlly("Brok Ironfist", 6, Sphere.Leadership, true, 2, 2, 1, 4)
                .WithTraits("Dwarf.", "Warrior.")
                .WithTextLine("Response: After a Dwarf hero you control leaves play, put Brok Ironfist into play from your hand.")
                .WithFlavor("...there is no knowing what a Dwarf will not dare and do for revenge and the recovery of his own.\r\n-The Hobbit")
                .WithTemplate("<p class='main-text'><b>Response:</b> After a {trait-hero:Dwarf.@Dwarf} hero you control leaves play, put {self} into play from your hand.</p><p class='flavor-text'>...there is no knowing what a Dwarf will not dare and do for revenge and the recovery of his own.<br>&ndash;The Hobbit</p>")
                .WithInfo(19, 1, Artists.Even_Mehl_Amundsen);
            core.addEvent("Ever Vigilant", 1, Sphere.Leadership)
                .WithTextLine("Action: Choose and ready 1 ally card.")
                .WithFlavor("\"...no road looks toward safety any longer. Be vigilant!\"\r\n-Gandalf, The Return of the King")
                .WithInfo(20, 2, Artists.Daarken);
            core.addEvent("Common Cause", 0, Sphere.Leadership)
                .WithTextLine("Action: Exhaust 1 hero you control to choose and ready a different hero.")
                .WithFlavor("\"We will make such a chase as shall be accounted a marvel among the Three Kindreds: Elves, Dwarves, and Men.\"\r\n-Aragorn, The Two Towers")
                .WithInfo(21, 2, Artists.Tony_Foti);
            core.addEvent("For Gondor!", 2, Sphere.Leadership)
                .WithTextLine("Action: Until the end of the phase, all characters get +1 Attack. All Gondor characters also get +1 Defense until the end of the phase.")
                .WithFlavor("And the tree that was withered shall be renewed,\r\nand he shall plant it in high places,\r\n\r\nand the City shall be blessed.\r\n-The Return of the King")
                .WithTemplate("<p class='main-text'><b>Action:</b> Until the end of the phase, all characters get +1 {Attack}. All {trait:Gondor.@Gondor} characters also get +1 {Defense} until the end of the phase.</p><p class='flavor-text'>And the tree that was withered shall be renewed,<br>and he shall plant it in high places,<br>and the City shall be blessed.<br>&ndash;The Return of the King</p>")
                .WithInfo(22, 2, Artists.Margaret_Hardy);
            core.addEvent("Sneak Attack", 1, Sphere.Leadership)
                .WithTextLine("Action: Put 1 ally card into play from your hand. At the end of the phase, if that ally is still in play, return it to your hand.")
                .WithFlavor("There is a seed of courage hidden (often deeply, it is true) in the heart of the fattest and most timid hobbit, waiting for some final and desperate danger to make it grow.\r\n-The Fellowship of the Ring")
                .WithTemplate("<p class='main-text'><b>Action:</b> Put 1 {type:Ally@ally} card into play from your hand. At the end of the phase, if that ally is still in play, return it to your hand.</p><p class='flavor-text'>There is a seed of courage hidden (often deeply, it is true) in the heart of the fattest and most timid hobbit, waiting for some final and desperate danger to make it grow.<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(23, 2, Artists.Winona_Nelson);
            core.addEvent("Valiant Sacrifice", 1, Sphere.Leadership)
                .WithTextLine("Response: After an ally card leaves play, that card's controller draws 2 cards.")
                .WithFlavor("\"He fell defending the Hobbits, while I was away upon the hill.\"\r\n-Aragorn, The Two Towers")
                .WithInfo(24, 2, Artists.David_A_Nash);
            core.addEvent("Grim Resolve", 5, Sphere.Leadership)
                .WithTextLine("Action: Ready all character cards in play.")
                .WithFlavor("\"If there is only one way, then I must take it. What comes after must come.\"\r\n-Frodo Baggins, The Two Towers")
                .WithInfo(25, 1, Artists.Daarken);
            core.addAttachment("Steward of Gondor", 2, Sphere.Leadership, true)
                .WithTraits("Gondor.", "Title.")
                .WithTextLine("Attach to a hero. Attached hero gains the Gondor trait.")
                .WithTextLine("Action: Exhaust Steward of Gondor to add 2 resources to attached hero's resource pool.")
                .WithFlavor("\"It was commanded yesterday.\" -Denethor, The Return of the King")
                .WithTemplate("<p class='main-text'>Attach to a hero.</p><p>Attached hero gains the {trait:Gondor.@Gondor} trait.</p><p><b>Action:</b> Exhaust {self} to add 2 resources to attached hero's resource pool.</p><p class='flavor-text'>&quot;It was commanded yesterday.&quot;<br>&ndash;Denethor, The Return of the King</p>")
                .WithInfo(26, 2, Artists.Empty_Room_Studios);
            core.addAttachment("Celebrían's Stone", 2, Sphere.Leadership, true)
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("Attached hero gains +2 Willpower.")
                .WithTextLine("If attached hero is Aragorn, he also gains a Spirit resource icon.")
                .WithFlavor("\"You needn't,\" said Bilbo. \"As a matter of fact it was all mine. Except that Aragorn insisted on my putting in a green stone. He seemed to think it important. I don't know why.\"\r\n-The Fellowship of the Ring")
                .WithInfo(27, 1, Artists.Sara_Biddle);
            core.addAlly("Veteran Axehand", 2, Sphere.Tactics, false, 0, 2, 1, 2)
                .WithTraits("Dwarf.", "Warrior.")
                .WithFlavor("\"I am glad to have you standing nigh with your stout legs and your hard axe.\" -Legolas, The Two Towers")
                .WithInfo(28, 3, Artists.Loren_Fetterman);
            core.addAlly("Gondorian Spearman", 2, Sphere.Tactics, false, 0, 1, 1, 1)
                .WithTraits("Gondor.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Response: After Gondorian Spearman is declared as a defender, deal 1 damage to the attacking enemy.")
                .WithFlavor("More than a thousand were there mustered. Their spears were like a springing wood. -The Two Towers")
                .WithInfo(29, 3, Artists.Winona_Nelson);
            core.addAlly("Horseback Archer", 3, Sphere.Tactics, false, 0, 2, 1, 2)
                .WithTraits("Rohan.", "Archer.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithFlavor("A few of the riders appeared to be bowmen, skilled at shooting from a running horse. -The Two Towers")
                .WithInfo(30, 2, Artists.Loren_Fetterman);
            core.addAlly("Beorn", 6, Sphere.Tactics, true, 1, 3, 3, 6)
                .WithAlternateSlug("Bjorn-Core")
                .WithTraits("Beorning.", "Warrior.")
                .WithTextLine("Action: Beorn gains +5 Attack until the end of the phase. At the end of the phase in which you trigger this effect, shuffle Beorn back into your deck. (Limit once per round.)")
                .WithFlavor("\"I don't need your service, thank you...but I expect you need mine.\" -The Hobbit")
                .WithInfo(31, 1, Artists.Tiziano_Baracchi);
            core.addEvent("Blade Mastery", 1, Sphere.Tactics)
                .WithTextLine("Action: Choose a character. Until the end of the phase, that character gains +1 Attack and +1 Defense.")
                .WithFlavor("Throwing back his cloak, he laid his hand on the hilt of a sword that had hung concealed by his side. They did not dare to move. -The Fellowship of the Ring")
                .WithInfo(32, 3, Artists.Leonardo_Borazio);
            core.addEvent("Rain of Arrows", 1, Sphere.Tactics)
                .WithTextLine("Action: Exhaust a character you control with the ranged keyword to choose a player. Deal 1 damage to each enemy engaged with that player.")
                .WithFlavor("Arrows thick as the rain came whistling over the battlements, and fell clinking and glancing on the stones. Many found their mark. -The Two Towers")
                .WithInfo(33, 2, Artists.Frank_Walls);
            core.addEvent("Feint", 1, Sphere.Tactics)
                .WithTextLine("Combat Action: Choose an enemy engaged with a player. That enemy cannot attack that player this phase.")
                .WithFlavor("A few brave men were strung before them to make a feint of resistance, and many there fell before the rest drew back and fled to either side. -The Hobbit")
                .WithErrata()
                .WithInfo(34, 2, Artists.Lius_Lasahido);
            core.addEvent("Quick Strike", 1, Sphere.Tactics)
                .WithTextLine("Action: Exhaust a character you control to immediately declare it as an attacker (and resolve its attack) against any eligible enemy target.")
                .WithFlavor("\"...for he that strikes the first blow, if he strikes it hard enough, may need to strike no more.\" -Gandalf, The Two Towers")
                .WithInfo(35, 2, Artists.Sara_Biddle);
            core.addEvent("Thicket of Spears", 3, Sphere.Tactics)
                .WithTextLine("You must use resources from 3 different heroes' pools to pay for this card.")
                .WithTextLine("Action: Choose a player. That player's engaged enemies cannot attack that player this phase.")
                .WithFlavor("Without a word or cry, suddenly, the Riders halted. A thicket of spears were pointed towards the strangers...\r\n-The Two Towers")
                .WithErrata()
                .WithInfo(36, 2, Artists.David_Horne);
            core.addEvent("Swift Strike", 2, Sphere.Tactics)
                .WithTextLine("Response: After a character is declared as a defender, deal 2 damage to the attacking enemy.")
                .WithFlavor("A swift stroke she dealt, skilled and deadly.\r\n-The Return of the King")
                .WithInfo(37, 1, Artists.Ijur);
            core.addEvent("Stand Together", 0, Sphere.Tactics)
                .WithTextLine("Action: Choose a player. That player may declare any number of his eligible characters as defenders against each enemy attacking him this phase.")
                .WithFlavor("...and when the task was done, there they would come to an end, alone, houseless, foodless in the midst of a terrible desert. There could be no return. -The Return of the King")
                .WithInfo(38, 1, Artists.Daarken);
            core.addAttachment("Blade of Gondolin", 1, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("Attached hero gets +1 Attack when attacking an Orc.")
                .WithTextLine("Response: After attached hero attacks and destroys an enemy, place 1 progress token on the current quest.")
                .WithFlavor("It was rather splendid to be wearing a blade made in Gondolin for the goblin-wars of which so many songs had sung...\r\n-The Hobbit")
                .WithInfo(39, 2, Artists.David_Lecossu);
            core.addAttachment("Citadel Plate", 4, Sphere.Tactics, false)
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("Attached hero gets +4 Hit Points.")
                .WithFlavor("\"Go to the armouries of the Citadel, and get you there the livery and gear of the Tower.\"\r\n-Denethor, The Return of the King")
                .WithInfo(40, 2, Artists.Fredrik_Dahl_Tyskerud);
            core.addAttachment("Dwarven Axe", 2, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("Attached hero gains +1 Attack. (+2 Attack instead if attached hero is a Dwarf.)")
                .WithFlavor("\"But keep your bow ready to hand, and I will keep my axe loose in my belt.\"\r\n-Gimli, The Two Towers")
                .WithInfo(41, 2, Artists.Drew_Whitmore);
            core.addAttachment("Horn of Gondor", 1, Sphere.Tactics, true)
                .WithTraits("Item.", "Artifact.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("Response: After a character is destroyed, add 1 resource to attached hero's pool.")
                .WithFlavor("'Slow should you be to wind that horn again, Boromir,' said Elrond, 'until you stand once more on the borders of your land, and dire need is on you.'\r\n-The Fellowship of the Ring")
                .WithErrata()
                .WithInfo(42, 1, Artists.Mark_Winters);
            core.addAlly("Wandering Took", 2, Sphere.Spirit, false, 1, 1, 1, 2)
                .WithTraits("Hobbit.")
                .WithTextLine("Action: Reduce your threat by 3 to give control of Wandering Took to another player. Raise that player's threat by 3. (Limit once per round.)")
                .WithFlavor("...but certainly there was something not entirely hobbit-like about them, and once in a while members of the Took-clan would go and have adventures. -The Hobbit")
                .WithErrata()
                .WithInfo(43, 2, Artists.Tony_Foti);
            core.addAlly("Lórien Guide", 3, Sphere.Spirit, false, 1, 1, 0, 2)
                .WithTraits("Silvan.", "Scout.")
                .WithTextLine("Response: After Lórien Guide commits to a quest, place 1 progress token on the active location.")
                .WithFlavor("\"Indeed deep in the wood they dwell...\" -Aragorn, The Fellowship of the Ring")
                .WithInfo(44, 3, Artists.Kristina_Gehrmann);
            core.addAlly("Northern Tracker", 4, Sphere.Spirit, false, 1, 2, 2, 3)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithTextLine("Response: After Northern Tracker commits to a quest, place 1 progress token on each location in the staging area.")
                .WithFlavor("\"What roads would any dare to tread, what safety would there be in quiet lands, or in the homes of simple men at night, if the Dúnedain were asleep, or were all gone into the grave?\" -Aragorn, The Fellowship of the Ring")
                .WithInfo(45, 2, Artists.Kristina_Gehrmann);
            core.addEvent("The Galadhrim's Greeting", 3, Sphere.Spirit)
                .WithTextLine("Action: Reduce one player's threat by 6, or reduce each player's threat by 2.")
                .WithFlavor("\"Welcome to Caras Galadhan!\" he said. \"Here is the city of the Galadhrim where dwell the Lord Celeborn and Galadriel the Lady of Lórien.\" -The Fellowship of the Ring")
                .WithInfo(46, 2, Artists.Magali_Villeneuve);
            core.addEvent("Strength of Will", 0, Sphere.Spirit)
                .WithTextLine("Response: After you travel to a location, exhaust a Spirit character to place 2 progress tokens on that location.")
                .WithFlavor("Then Aragorn lead the way, and such was the strength of his will in that hour that all the Dúnedain and their horses followed him. -The Return of the King")
                .WithInfo(47, 2, Artists.Ryan_Barger);
            core.addEvent("Hasty Stroke", 1, Sphere.Spirit)
                .WithTextLine("Response: Cancel a shadow effect just triggered during combat.")
                .WithFlavor("'The hasty stroke goes oft astray,' said Aragorn. 'We must press our Enemy, and no longer wait on him for the next move.' -The Return of the King")
                .WithInfo(48, 2, Artists.Lius_Lasahido);
            core.addEvent("Will of the West", 1, Sphere.Spirit)
                .WithTextLine("Action: Choose a player. Shuffle that player's discard pile back into his deck. Remove Will of the West from the game.")
                .WithFlavor("\"If Gondor has such men still in these days of fading, great must have been its glory in the days of its rising.\" -Legolas, The Return of the King")
                .WithTemplate("<p><b>Action:</b> Choose a player. Shuffle that player's discard pile back into his deck. Remove Will of the West from the game.</p><p class='flavor-text'>&quot;If Gondor has such men still in these days of fading, great must have been its glory in the days of its rising.&quot;<br>&ndash;Legolas, The Return of the King</p>")
                .WithErrata()
                .WithInfo(49, 2, Artists.Erfian_Asafat);
            core.addEvent("A Test of Will", 1, Sphere.Spirit)
                .WithTextLine("Response: Cancel the 'when revealed' effects of a card that was just revealed from the encounter deck.")
                .WithFlavor("\"There is naught that you can do, other than to resist, with hope or without it\"\r\n-Elrond, The Fellowship of the Ring")
                .WithTemplate("<p><b>Response:</b> Cancel the &ldquo;when revealed&rdquo; effects of a card that was just revealed from the encounter deck.</p><p class='flavor-text'>&quot;There is naught that you can do, other than to resist, with hope or without it&quot;<br>&ndash;Elrond, The Fellowship of the Ring</p>")
                .WithInfo(50, 2, Artists.Ryan_Barger);
            core.addEvent("Stand and Fight", 254, Sphere.Spirit)
                .WithTextLine("Action: Choose an ally with a printed cost of X in any player's discard pile. Put that ally into play under your control. (The chosen ally can belong to any sphere of influence.)")
                .WithFlavor("\"...we will fight on.\" -Boromir, The Fellowship of the Ring")
                .WithErrata()
                .WithInfo(51, 3, Artists.Rio_Sabda);
            core.addEvent("A Light in the Dark", 2, Sphere.Spirit)
                .WithTextLine("Action: Choose an enemy engaged with a player. Return that enemy to the staging area.")
                .WithFlavor("The light of the torches and the fire flickered about them...\r\n-The Hobbit")
                .WithInfo(52, 2, Artists.Erfian_Asafat);
            core.addEvent("Dwarven Tomb", 1, Sphere.Spirit)
                .WithTextLine("Action: Return 1 Spirit card from your discard pile to your hand.")
                .WithFlavor("The dwarves no more shall suffer wrong,\r\nThe dwarves of yore made mighty spells,\r\nWhile hammers fell like ringing bells\r\nIn places deep, where dark things sleep,\r\nIn hollow halls beneath the fells.\r\n-The Hobbit")
                .WithInfo(53, 1, Artists.Kaya);
            core.addEvent("Fortune or Fate", 5, Sphere.Spirit)
                .WithTextLine("Action: Choose a hero in any player's discard pile. Put that card into play, under its owner's control.")
                .WithFlavor("'Yes, fortune or fate have helped you,' said Gandalf, 'not to mention courage.'\r\n-The Fellowship of the Ring")
                .WithInfo(54, 1, Artists.Igor_Kieryluk);
            core.addAttachment("The Favor of the Lady", 2, Sphere.Spirit, false)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Attached hero gains +1 Willpower.")
                .WithFlavor("\"You are indeed high in the favor of the Lady!\"\r\n-Unnamed Elf of Lórien,\r\nThe Fellowship of the Ring")
                .WithTemplate("<p>Attach to a hero.</p><p>Attached hero gains +1 {Willpower}.</p><p class='flavor-text'>&quot;You are indeed high in the favor of the Lady!&quot;<br>&ndash;Unnamed Elf of Lórien,<br>The Fellowship of the Ring</p>")
                .WithInfo(55, 2, Artists.Magali_Villeneuve);
            core.addAttachment("Power in the Earth", 1, Sphere.Spirit, false)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a location.")
                .WithTextLine("Attached location gets -1 Threat.")
                .WithFlavor("\"Power to defy our Enemy is not in him, unless shuch power is in the earth itself.\" -Gandalf, The Fellowship of the Ring")
                .WithTemplate("<p>Attach to a location.</p><p>Attached location gets -1 {Threat}.</p><p class='flavor-text'>&quot;Power to defy our Enemy is not in him, unless such power is in the earth itself.&quot;<br>&ndash;Gandalf, The Fellowship of the Ring</p>")
                .WithInfo(56, 2, Artists.Soul_Core);
            core.addAttachment("Unexpected Courage", 2, Sphere.Spirit, false)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Action: Exhaust Unexpected Courage to ready attached hero.")
                .WithFlavor("\"Here am I, naughty little fly;\r\nyou are fat and lazy.\r\nYou cannot trap me, though you try,\r\nin your cobwebs crazy.\"\r\n-Bilbo Baggins, The Hobbit")
                .WithTemplate("<p>Attach to a hero.</p><p><b>Action:</b> Exhaust {self} to ready attached hero.</p><p class='flavor-text'>&quot;Here am I, naughty little fly;<br>you are fat and lazy.<br>You cannot trap me, though you try,<br>in your cobwebs crazy.&quot;<br>&ndash;Bilbo Baggins, The Hobbit</p>")
                .WithInfo(57, 1, Artists.Angela_Sung);
            core.addAlly("Daughter of the Nimrodel", 3, Sphere.Lore, false, 1, 0, 0, 1)
                .WithTraits("Silvan.")
                .WithTextLine("Action: Exhaust Daughter of the Nimrodel to heal up to 2 damage on any 1 hero.")
                .WithFlavor("\"Here is Nimrodel! Of this stream the Silvan Elves made many songs long ago, and still we sing them in the North...I will bathe my feet, for it is said that the water is healing to the weary.\" -Legolas, The Fellowship of the Ring")
                .WithInfo(58, 3, Artists.Magali_Villeneuve);
            core.addAlly("Erebor Hammersmith", 2, Sphere.Lore, false, 1, 1, 1, 3)
                .WithTraits("Dwarf.", "Craftsman.")
                .WithTextLine("Response: After you play Erebor Hammersmith, return the topmost attachment in any player's discard pile to his hand.")
                .WithFlavor("\"In Erebor in the Kingdom of Dain there is such skill...\" -Aragorn, The Return of the King")
                .WithInfo(59, 2, Artists.Empty_Room_Studios);
            core.addAlly("Henamarth Riversong", 1, Sphere.Lore, true, 1, 1, 0, 1)
                .WithTraits("Silvan.")
                .WithTextLine("Action: Exhaust Henamarth Riversong to look at the top card of the encounter deck.")
                .WithFlavor("\"And I reckon there's Elves and Elves. They're all elvish enough, but they're not all the same.\"\r\n-Sam Gamgee,\r\nThe Fellowship of the Ring")
                .WithInfo(60, 1, Artists.Jen_Zee);
            core.addAlly("Miner of the Iron Hills", 2, Sphere.Lore, false, 0, 1, 1, 2)
                .WithTraits("Dwarf.")
                .WithTextLine("Response: After Miner of the Iron ~Hills enters play, choose and discard 1 Condition attachment from play.")
                .WithFlavor("...while the four dwarves sat around the table, and talked about mines and gold and troubles with goblins...\r\n-The Hobbit")
                .WithInfo(61, 2, Artists.Loren_Fetterman);
            core.addAlly("Gléowine", 2, Sphere.Lore, true, 1, 0, 0, 2)
                .WithTraits("Minstrel.", "Rohan.")
                .WithTextLine("Action: Exhaust Gléowine to choose a player. That player draws 1 card.")
                .WithFlavor("Then the Riders of the King's House upon white horses rode round about the barrow and sang together a song of Théoden Thengel's son that Gléowine his minstrel made...\r\n-The Return of the King")
                .WithInfo(62, 2, Artists.Tony_Foti);
            core.addEvent("Lore of Imladris", 2, Sphere.Lore)
                .WithTextLine("Action: Choose a character. Heal all damage from that character.")
                .WithFlavor("\"...understanding, making and healing...These things the Elves of Middle-earth have in some measure gained, though with sorrow.\"\r\n-Elrond, The Fellowship of the Ring")
                .WithInfo(63, 3, Artists.Ryan_Barger);
            core.addEvent("Lórien's Wealth", 3, Sphere.Lore)
                .WithTextLine("Action: Choose a player. That player draws 3 cards.")
                .WithFlavor("\"That is the fairest of all the dwellings of my people. There are no trees like the tress of that land.\"\r\n-Legolas, The Fellowship of the Ring")
                .WithInfo(64, 2, Artists.Magali_Villeneuve);
            core.addEvent("Radagast's Cunning", 1, Sphere.Lore)
                .WithTextLine("Quest Action: Choose an enemy in the staging area. Until the end of the phase, that enemy does not contribute its Threat.")
                .WithFlavor("\"Radagast is, of course, a worthy Wizard, a master of shapes and changes of hue; and he has much lore of herbs and beasts, and birds are especially his friends.\" -Gandalf, The Fellowship of the Ring")
                .WithInfo(65, 2, Artists.Lucas_Graciano);
            core.addEvent("Secret Paths", 1, Sphere.Lore)
                .WithTextLine("Quest Action: Choose a location in the staging area. Until the end of the phase, that location does not contribute its Threat.")
                .WithFlavor("...Beorn advised them to take this way; for at a place a few days' ride due north of the Carrock was the gate of a little-known pathway through Mirkwood... -The Hobbit")
                .WithInfo(66, 2, Artists.Empty_Room_Studios);
            core.addEvent("Gandalf's Search", 254, Sphere.Lore)
                .WithTextLine("Action: Look at the top X cards of any player's deck, add 1 of those cards to its owner's hand, and return the rest to the top of the deck in any order.")
                .WithFlavor("\"Less welcome did the Lord Denethor show me then than of old, and grudgingly he permitted me to search among his hoarded scrolls and books.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(67, 2, Artists.Mike_Nash);
            core.addEvent("Beorn's Hospitality", 5, Sphere.Lore)
                .WithTextLine("Action: Choose a player. Heal all damage on each hero controlled by that player.")
                .WithFlavor("\"...and my house is open to you, if ever you come back this way again.\"\r\n-Beorn, The Hobbit")
                .WithInfo(68, 1, Artists.David_A_Nash);
            core.addAttachment("Forest Snare", 3, Sphere.Lore, false)
                .WithTraits("Item.", "Trap.")
                .WithTextLine("Attach to an enemy engaged with a player.")
                .WithTextLine("Attached enemy cannot attack.")
                .WithFlavor("\"We shall have it like a coney in a trap. Then we shall learn what kind of thing it is.\"\r\n-Unidentified Man of Gondor,\r\nThe Two Towers")
                .WithInfo(69, 2, Artists.Alexandru_Sabo);
            core.addAttachment("Protector of Lórien", 1, Sphere.Lore, false)
                .WithTraits("Title.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Action: Discard a card from your hand to give attached hero +1 Defense or +1 Willpower until the end of the phase. Limit 3 times per phase.")
                .WithFlavor("'Speak no evil of the lady Galadriel!' said Aragorn sternly. 'There is in her and in this land no evil, unless a man bring it hither himself. Then let him beware.'\r\n-The Fellowship of the Ring")
                .WithErrata()
                .WithInfo(70, 2, Artists.Magali_Villeneuve);
            core.addAttachment("Dark Knowledge", 1, Sphere.Lore, false)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a hero. Attached hero gets -1 Willpower.")
                .WithTextLine("Response: Exhaust ~Dark Knowledge to look at 1 shadow card that was just dealt to an enemy attacking you.")
                .WithFlavor("'Go on then!' said Frodo. 'What do you know?'\r\n'Too much; too many dark things,' said Strider grimly.\r\n-The Fellowship of the Ring")
                .WithInfo(71, 1, Artists.Empty_Room_Studios);
            core.addAttachment("Self Preservation", 3, Sphere.Lore, false)
                .WithTraits("Skill.")
                .WithTextLine("Attach to a character.")
                .WithTextLine("Action: Exhaust Self Preservation to heal 2 points of damage from attached character.")
                .WithFlavor("...how much more of this would they have to endure, or could they endure?\r\n-The Two Towers")
                .WithInfo(72, 2, Artists.Empty_Room_Studios);
            core.addAlly("Gandalf", 5, Sphere.Neutral, true, 4, 4, 4, 4)
                .WithTraits("Istari.")
                .WithTextLine("At the end of the round, discard Gandalf from play.")
                .WithTextLine("Response: After Gandalf enters play, (choose 1): draw 3 cards, deal 4 damage to 1 enemy in play, or reduce your threat by 5.")
                .WithInfo(73, 4, Artists.Lucas_Graciano);

            var spiders = core.EncounterSet(EncounterSetNames.SpidersOfMirkwood);
            spiders.addEnemy("King Spider", 20, 2, 3, 1, 3)
                .WithTraits("Creature.", "Spider.")
                .WithTextLine("When Revealed: Each player must choose and exhaust 1 character he controls.")
                .WithShadow("Shadow: Defending player must choose and exhaust 1 character he controls. (2 characters instead if this attack is undefended.)")
                .WithInfo(74, 2, Artists.John_Wigley);
            spiders.addEnemy("Hummerhorns", 40, 1, 2, 0, 3)
                .WithTraits("Creature.", "Insect.")
                .WithTextLine("Forced: After Hummerhorns engages you, deal 5 damage to a single hero you control.")
                .WithShadow("Shadow: Deal 1 damage to each character the defending player controls. (2 damage instead if this attack is undefended.)")
                .WithVictoryPoints(5)
                .WithEasyModeQuantity(0)
                .WithInfo(75, 1, Artists.David_Lecossu);
            spiders.addEnemy("Ungoliant's Spawn", 32, 3, 5, 2, 9)
                .WithTraits("Creature.", "Spider.")
                .WithTextLine("When Revealed: Each character currently committed to a quest gets -1 Willpower until the end of the phase.")
                .WithShadow("Shadow: Raise defending player's threat by 4. (Raise defending player's threat by 8 instead if this attack is undefended.)")
                .WithInfo(76, 1, Artists.Andrew_Olson);
            spiders.addLocation("Great Forest Web", 2, 2)
                .WithTraits("Forest.")
                .WithTextLine("Travel: Each player must exhaust 1 hero he controls to travel here.")
                .WithFlavor("As he drew nearer, he saw that it was made with spider-webs one behind and over and tangled with another.\r\n-The Hobbit")
                .WithInfo(77, 2, Artists.Jason_Ward);
            spiders.addLocation("Mountains of Mirkwood", 2, 3)
                .WithTraits("Forest.", "Mountain.")
                .WithTextLine("Travel: Reveal the top card of the encounter deck and add it to the staging area to travel here.Response: After Mountains of Mirkwood leaves play as an explored location, each player may search the top 5 cards of his deck for 1 card and add it to his hand. Shuffle the rest of the searched cards back into their owners' decks.")
                .WithInfo(78, 3, Artists.Ben_Zweifel);
            spiders.addTreachery("Eyes of the Forest")
                .WithTextLine("When Revealed: Each player discards all event cards in his hand.")
                .WithFlavor("...he would see gleams in the darkness around them, and sometimes pairs of yellow or red or green eyes would stare at him from a little distance, and then slowly fade and disappear and slowly shine out again in another place.\r\n-The Hobbit")
                .WithEasyModeQuantity(0)
                .WithInfo(79, 1, Artists.Yoann_Boissonnet);
            spiders.addTreachery("Caught in a Web")
                .WithTextLine("When Revealed: The player with the highest threat level attaches this card to one of his heroes. (Counts as a Condition attachment with the text: 'Attached hero does not ready during the refresh phase unless you pay 2 resources from that hero's pool.')")
                .WithEasyModeQuantity(0)
                .WithInfo(80, 2, Artists.Daryl_Mandryk);

            var wilder = core.EncounterSet(EncounterSetNames.Wilderlands);
            wilder.addEnemy("Wolf Rider", 10, 1, 2, 0, 2)
                .WithTraits("Goblin.", "Orc.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithShadow("Shadow: Wolf Rider attacks the defending player. That player may declare 1 character as a defender. Deal Wolf Rider its own Shadow card. After combat, return Wolf Rider to the top of the encounter deck.")
                .WithInfo(81, 1, Artists.Alexandru_Sabo);
            wilder.addEnemy("Hill Troll", 30, 1, 6, 3, 9)
                .WithTraits("Troll.")
                .WithTextLine("Excess combat damage dealt by Hill Troll (damage that is dealt beyond the remaining hit points of the character damaged by its attack) must be assigned as an increase to your threat.")
                .WithFlavor("\"Mutton yesterday, mutton today, and blimey, if it don't look like mutton again tomorrow.\"\r\n-Troll, The Hobbit")
                .WithVictoryPoints(4)
                .WithEasyModeQuantity(1)
                .WithInfo(82, 2, Artists.Florian_Stitz);
            wilder.addEnemy("Goblin Sniper", 48, 2, 2, 0, 2)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("During the encounter phase, players cannot optionally engage Goblin Sniper if there are other enemies in the staging area.Forced: If Goblin Sniper is in the staging area at the end of the combat phase, each player deals 1 point of damage to 1 character he controls.")
                .WithInfo(83, 2, Artists.Alexandr_Shaldin);
            wilder.addEnemy("Marsh Adder", 40, 3, 4, 1, 7)
                .WithTraits("Creature.")
                .WithTextLine("Forced: Each time Marsh Adder attacks you, raise your threat by 1.")
                .WithFlavor("Under the boughs of Mirkwood there was deadly strife of Elves and Men and fell beasts.\r\n-The Fellowship of the Ring")
                .WithVictoryPoints(3)
                .WithEasyModeQuantity(0)
                .WithInfo(84, 1, Artists.Sandara_Tang);
            wilder.addEnemy("Wargs", 20, 2, 3, 1, 3)
                .WithTraits("Creature.")
                .WithTextLine("Forced: If Wargs is dealt a shadow card with no effect, return Wargs to the staging area after it attacks.")
                .WithShadow("Shadow: attacking enemy gets 1 Attack. (2 Attack instead if this attack is undefended.)")
                .WithInfo(85, 2, Artists.Ryan_Barger);
            wilder.addTreachery("Despair")
                .WithTextLine("When Revealed: Remove 4 progress tokens from the current quest card. (If there are fewer than 4 progress tokens on the quest, remove all progress tokens from that quest.)")
                .WithShadow("Shadow: Defending character does not count its Defense.")
                .WithEasyModeQuantity(0)
                .WithInfo(86, 2, Artists.Marc_Scheff);
            wilder.addLocation("The Brown Lands", 5, 1)
                .WithTraits("Wasteland.")
                .WithTextLine("Forced: After the players travel to The Brown Lands, place 1 progress token on it.")
                .WithFlavor("They had come to the Brown Lands that lay, vast and desolate, between Southern Mirkwood and the hills of the Emyn Muil. What pestilence or war or evil deed of the Enemy had so blasted all that region even Aragorn could not tell.\r\n-The Fellowship of the Ring")
                .WithInfo(87, 2, Artists.Ben_Zweifel);
            wilder.addLocation("The East Bight", 1, 6)
                .WithTraits("Wasteland.")
                .WithTextLine("When faced with the option to travel, the players must travel to The East Bight if there is no active location.")
                .WithFlavor("\"...to the east the lands are waste, and full of Sauron's creatures...\"\r\n-Haldir, The Fellowship of the Ring")
                .WithInfo(88, 2, Artists.Santiago_Villa);

            var dol = core.EncounterSet(EncounterSetNames.DolGuldurOrcs);
            dol.addEnemy("Dol Guldur Orcs", 10, 2, 2, 0, 3)
                .WithTraits("Dol Guldur.", "Orc.")
                .WithTextLine("When Revealed: The first player chooses 1 character currently committed to a quest. Deal 2 damage to that character.")
                .WithShadow("Shadow: attacking enemy gets 1 Attack. (3 Attack instead if this attack is undefended.)")
                .WithSlugSuffix("Enemy")
                .WithInfo(89, 3, Artists.Anna_Christenson);
            dol.addEnemy("Chieftan Ufthak", 35, 2, 3, 3, 6)
                .WithTraits("Dol Guldur.", "Orc.")
                .WithTextLine("Chieftain Ufthak get 2 Attack for each resource token on him.")
                .WithTextLine("Forced: After Chieftain Ufthak attacks, place 1 resource token on him.")
                .WithVictoryPoints(4)
                .WithEasyModeQuantity(0)
                .WithInfo(90, 1, Artists.Mathias_Kollros);
            dol.addEnemy("Dol Guldur Beastmaster", 35, 2, 3, 1, 5)
                .WithTraits("Dol Guldur.", "Orc.")
                .WithTextLine("Forced: When Dol Guldur Beastmaster attacks, deal it 1 additional shadow card.")
                .WithErrata()
                .WithEasyModeQuantity(1)
                .WithInfo(91, 2, Artists.David_Lecossu);
            dol.addTreachery("Driven by Shadow")
                .WithTextLine("When Revealed: Each enemy and each location currently in the staging area gets 1 Threat until the end of the phase. If there are no cards in the staging area, Driven by Shadow gains surge.")
                .WithShadow("Shadow: Choose and discard 1 attachment from the defending character. (If this attack is undefended, discard all attachments you control.)")
                .WithInfo(92, 1, Artists.Alexandru_Sabo);
            dol.addTreachery("The Necromancer's Reach")
                .WithTextLine("When Revealed: Deal 1 damage to each exhausted character.")
                .WithFlavor("There was an eye in the Dark Tower that did not sleep. He knew that it had become aware of his gaze. A fierce eager will was there. - The Fellowship of the Ring")
                .WithEasyModeQuantity(1)
                .WithInfo(93, 3, Artists.Anna_Christenson);
            dol.addLocation("Necromancer's Pass", 3, 2)
                .WithTraits("Stronghold.", "Dol Guldur.")
                .WithTextLine("Travel: The first player must discard 2 cards from his hand at random to travel here.")
                .WithFlavor("\"It is clad in a forest of dark fir, where the trees strive one against another and their branches rot and wither. In the midst upon a stony height stands Dol Guldur, where long the hidden Enemy had his dwelling.\"\r\n-Haldir, The Fellowship of the Ring")
                .WithEasyModeQuantity(1)
                .WithInfo(94, 2, Artists.Daryl_Mandryk);
            dol.addLocation("Enchanted Stream", 2, 2)
                .WithTraits("Forest.")
                .WithTextLine("While Enchanted Stream is the active location, players cannot draw cards.")
                .WithFlavor("\"There is one stream, I know, black and strong which crosses the path. That you should neither drink of, nor bathe in; for I have heard that it carries enchantment and a great drowsiness and forgetfulness.\"\r\n-Beorn, The Hobbit")
                .WithInfo(95, 2, Artists.Ben_Zweifel);

            var passage = core.EncounterSet(EncounterSetNames.PassageThroughMirkwood);
            passage.addEnemy("Forest Spider", 25, 2, 2, 1, 4)
                .WithTraits("Creature.", "Spider.")
                .WithTextLine("Forced: After Forest Spider engages a player, it gets 1 Attack until the end of the round.")
                .WithShadow("Shadow: Defending player must choose and discard 1 attachment he controls.")
                .WithInfo(96, 4, Artists.Marco_Caradonna);
            passage.addEnemy("East Bight Patrol", 5, 3, 3, 1, 2)
                .WithTraits("Goblin.", "Orc.")
                .WithShadow("Shadow: attacking enemy gets 1 Attack. (If this attack is undefended, also raise your threat by 3.)")
                .WithInfo(97, 1, Artists.Nikolay_Stoyanov);
            passage.addEnemy("Black Forest Bats", 15, 1, 1, 0, 2)
                .WithTraits("Creature.")
                .WithTextLine("When Revealed: Each player must choose 1 character currently committed to a quest, and remove that character from the quest. (The chosen character does not ready.)")
                .WithFlavor("They could not stand that, nor the huge bats, black as a top-hat, either...\r\n-The Hobbit")
                .WithInfo(98, 1, Artists.David_Lecossu);
            passage.addLocation("Old Forest Road", 1, 3)
                .WithTraits("Forest.")
                .WithTextLine("Response: After you travel to Old Forest Road, the first player may choose and ready 1 character he controls.")
                .WithFlavor("...Beorn had warned them that that way was now often used by the goblins, while the forest-road itself, he had heard, was overgrown and disused on the eastern end and led to impassable marshes where the path had long been lost.\r\n-The Hobbit")
                .WithInfo(99, 2, Artists.Ben_Zweifel);
            passage.addLocation("Forest Gate", 2, 4)
                .WithTraits("Forest.")
                .WithTextLine("Response: After you travel to Forest Gate, the first player may draw 2 cards.")
                .WithFlavor("The path itself was narrow and wound in and out among the trunks. Soon the light in the gate was like a little bright hole far behind, and the quiet was so deep that their feet seemed to thump along while the trees leaned over them and listened.\r\n-The Hobbit")
                .WithInfo(100, 2, Artists.Ben_Zweifel);

            var escape = core.EncounterSet(EncounterSetNames.EscapeFromDolGuldur);
            escape.addEnemy("Dungeon Jailor", 38, 1, 2, 3, 5)
                .WithTraits("Dol Guldur.", "Orc.")
                .WithTextLine("Forced: If Dungeon Jailor is in the staging area after the players have just quested unsuccessfully, shuffle 1 unclaimed objective card from the staging area back into the encounter deck.")
                .WithVictoryPoints(5)
                .WithEasyModeQuantity(0)
                .WithInfo(101, 2, Artists.Tiziano_Baracchi);
            escape.addEnemy("Nazgûl of Dol Guldur", 40, 5, 4, 3, 9)
                .WithTraits("Nazgûl.")
                .WithTextLine("No attachments.")
                .WithTextLine("Forced: When the prisoner is 'rescued', move Nazgûl of Dol Guldur into the staging area.")
                .WithTextLine("Forced: After a shadow effect dealt to Nazgûl of Dol Guldur resolves, the engaged player must choose and discard 1 character he controls.")
                .WithErrata()
                .WithInfo(102, 1, Artists.David_A_Nash);
            escape.addEnemy("Cavern Guardian", 8, 2, 2, 1, 2)
                .WithTraits("Undead.")
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithShadow("Shadow: Choose and discard 1 attachment you control. Discarded  objective cards are returned to the staging area. (If this attack is  undefended, discard all attachments you control.)")
                .WithInfo(103, 2, Artists.Mark_Winters);
            escape.addTreachery("Under the Shadow")
                .WithTextLine("When Revealed: Until the end of the phase, raise the total Threat in the  staging area by X, where X is the number of players in the game.")
                .WithShadow("Shadow: Defending player raises his threat by the number of enemies  with which he is engaged.")
                .WithInfo(104, 2, Artists.Igor_Kieryluk);
            escape.addTreachery("Iron Shackles")
                .WithTextLine("When Revealed: Attach Iron Shackles to the top of the first player's deck. (Counts as a Condition attachment with the text: 'The next time a player would draw 1 or more cards from attached deck, discard Iron Shackles instead.')")
                .WithShadow("Shadow: Resolve the 'When Revealed' effect of Iron Shackles.")
                .WithInfo(105, 1, Artists.Drew_Whitmore);
            escape.addLocation("Endless Caverns", 1, 3)
                .WithTraits("Dungeon.")
                .WithKeywords("Doomed 1.", "Surge.")
                .WithTextLine("Doomed 1. Surge.")
                .WithFlavor("\"I alone of you have ever been in the dungeons of the Dark Lord, and only in his older and lesser dwelling in Dol Guldur.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(106, 2, Artists.Even_Mehl_Amundsen);
            escape.addLocation("Tower Gate", 2, 1)
                .WithTraits("Dungeon.")
                .WithTextLine("Forced: After travelling to Tower Gate, each player places the top card of his deck, face down in front of him, as if it just engaged him from the staging area. These cards are called 'Orc Guard', and act as enemies with: 1 hit point, 1 Attack, and 1 Defense.")
                .WithFlavor("\"I myself dared to pass the doors of the Necromancer in Dol Guldur, and secretly explored his ways.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(107, 2, Artists.West_Clendinning);
            escape.addObjective("Gandalf's Map")
                .WithTraits("Item.")
                .WithKeywords("Guarded.", "Restricted.")
                .WithTextLine("Guarded. Restricted.")
                .WithTextLine("Action: Raise your threat by 2 to claim this objective when it is free of encounters. When claimed, attach Gandalf's Map to a hero you control. (Counts as an attachment. If detached, return Gandalf's Map to the staging area.) Attached hero cannot attack or defend.")
                .WithInfo(108, 1, Artists.Mike_Nash);
            escape.addObjective("Dungeon Torch")
                .WithTraits("Item.")
                .WithKeywords("Guarded.", "Restricted.")
                .WithTextLine("Guarded. Restricted.")
                .WithTextLine("Action: Raise your threat by 2 to claim this objective when it is free of encounters. When claimed, attach Dungeon Torch to a hero you control. (Counts as an attachment. If detached, return Dungeon Torch to the staging area.)Forced: At the end of each round, raise attached hero's controller's threat by 2.")
                .WithInfo(109, 1, Artists.David_Lecossu);
            escape.addObjective("Shadow Key")
                .WithTraits("Item.")
                .WithKeywords("Guarded.", "Restricted.")
                .WithTextLine("Guarded. Restricted.")
                .WithTextLine("Action: Raise your threat by 2 to claim this objective when it is free of encounters. When claimed, attach Shadow Key to a hero you control. (Counts as an attachment. If detached, return Shadow Key to the staging area.)Forced: At the end of each round, attached hero suffers 1 damage.")
                .WithInfo(110, 1, Artists.Nicholas_Cloister);

            var journey = core.EncounterSet(EncounterSetNames.JourneyAlongTheAnduin, EncounterSetNames.JourneyDownTheAnduin);
            journey.addEnemy("Misty Mountain Goblins", 15, 2, 2, 1, 3)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("Forced: After Misty Mountain Goblins attacks, remove 1 progress token from the current quest.")
                .WithShadow("Shadow: Remove 1 progress token from the current quest. (3 progress tokens instead if this attack is undefended.)")
                .WithInfo(111, 3, Artists.Nikolay_Stoyanov);
            journey.addTreachery("Massing at Night")
                .WithTextLine("When Revealed: Reveal X additional cards from the encounter deck. X is the number of players in the game.")
                .WithShadow("Shadow: Deal X shadow cards to this attacker. X is the number of players in the game.")
                .WithEasyModeQuantity(0)
                .WithInfo(112, 1, Artists.Mathias_Kollros);
            journey.addLocation("Banks of the Anduin", 1, 3)
                .WithTraits("Riverland.")
                .WithTextLine("Forced: If Banks of the Anduin leaves play, return it to the top of the encounter deck instead of placing it in the discard pile.")
                .WithFlavor("Here and there through openings Frodo could catch sudden glimpses of rolling mounds, and far beyond them hills in the sunset, and away on the edge of sight a dark line, where marches the southernmost ranks of the Misty Mountains.\r\n-The Fellowship of the Ring")
                .WithInfo(113, 2, Artists.Ben_Zweifel);
            journey.addLocation("Gladden Fields", 3, 3)
                .WithTraits("Marshland.")
                .WithTextLine("Forced: While Gladden Fields is the active location, each player must raise his threat by an additional point during the refresh phase.")
                .WithFlavor("\"On a time they took a boat and went down to the Gladden Fields, where there were great beds of iris and flowering reeds.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithVictoryPoints(3)
                .WithEasyModeQuantity(1)
                .WithInfo(114, 3, Artists.Ben_Zweifel);

            var reach = core.EncounterSet(EncounterSetNames.SauronsReach);
            reach.addEnemy("Eastern Crows", 30, 1, 1, 0, 1) 
                .WithTraits("Creature.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Forced: After Eastern Crows is defeated, shuffle it back into the encounter deck.")
                .WithShadow("Shadow: attacking enemy gets +1 Attack. (+2 Attack instead if defending player's threat is 35 or higher.)")
                .WithEasyModeQuantity(1)
                .WithInfo(115, 3, Artists.Matthew_Starbuck);
            reach.addTreachery("Evil Storm")
                .WithTextLine("When Revealed: Deal 1 damage to each character controlled by each player with a threat of 35 or higher.")
                .WithFlavor("\"They say in my land he can govern the storms in the Mountains of Shadow...\"\r\n-Boromir, The Fellowship of the Ring")
                .WithEasyModeQuantity(2)
                .WithInfo(116, 3, Artists.Tom_Garden);
            reach.addTreachery("Pursued by Shadow")
                .WithTextLine("When Revealed: Each player raises his threat by 1 for each character he controls that is not currently committed to a quest.")
                .WithShadow("Shadow: Defending player chooses and returns 1 exhausted ally he controls to its owner's hand. If he controls no exhausted allies, raise his threat by 3.")
                .WithInfo(117, 2, Artists.Matthew_Starbuck);
            reach.addTreachery("Treacherous Fog")
                .WithTextLine("When Revealed: Each location in the staging area gets +1 Threat until the end of the phase. Then, each player with a threat of 35 or higher chooses and discards 1 card from his hand.")
                .WithFlavor("\"But it will be hard to find the path unless the fog lifts a little later on.\"\r\n-Aragorn, The Fellowship of the Ring")
                .WithInfo(118, 2, Artists.David_Lecossu);

            passage.addQuest("Flies and Spiders", 1, 'A', 8)
                .WithIncludedEncounterSets(EncounterSetNames.DolGuldurOrcs, EncounterSetNames.SpidersOfMirkwood)
                .WithTextLine("Setup: Search the encounter deck for 1 copy of the ~Forest ~Spider and 1 copy of the Old ~Forest ~Road, and add them to the staging area. Then, shuffle the encounter deck.")
                .WithFlavor("You are traveling through Mirkwood forest, carrying an urgent message from King Thanduil to the Lady Galadriel of Lorien. As you move along the dark trail, the spiders gather around you...")
                .WithOppositeFlavor("The nastiest things they saw were the cobwebs; dark dense cobwebs, with threads extradionairly thick, often stretched from tree to tree, or tangled in the lower branches on either side of them. There were none stretched across the path, but whether because some magic kept it clear, or for what other reasons they could not guess. - The Hobbit")
                .WithInfo(119, 1, Artists.Ben_Zweifel);
            passage.addQuest("A Fork in the Road", 2, 'A', 2)
                .WithIncludedEncounterSets(EncounterSetNames.DolGuldurOrcs, EncounterSetNames.SpidersOfMirkwood)
                .WithFlavor("As you move through Mirkwood, hounded by spiders, the forest path forks before you...")
                .WithOppositeTextLine("Forced: When you defeat this stage, proceed to one of the 2 \"A Chosen ~Path\" stages, at random.")
                .WithOppositeFlavor("Unsure of what lies ahead but spurred by the urgency of your message, you choose a path and proceed... ")
                .WithInfo(120, 1, Artists.Ben_Zweifel);
            passage.addQuest("A Chosen Path", "Don't Leave the Path", 3, null, 'A', 0)
                .WithIncludedEncounterSets(EncounterSetNames.DolGuldurOrcs, EncounterSetNames.SpidersOfMirkwood)
                .WithFlavor("The trail winds into one of the darkest, most tangled parts of the forest...\r\n\r\nYou sense that foul, dark presence is hunting you, and you move quickly in an attempt to avoid its evil.")
                .WithOppositeTextLine("When Revealed: Each player must search the encounter deck and discard pile for 1 Spider card of his choice, and add it to the staging area.")
                .WithOppositeTextLine("The players must find and defeat Ungoliant's Spawn to win this game.")
                .WithOppositeFlavor("The shadows grow darker, and you realize that a foul presence is aiming to draw you from the path. You must defeat it to pass this way.")
                .WithSlugSuffix("Don't Leave the Path")
                .WithBackArtist(Artists.Ben_Zweifel)
                .WithInfo(121, 1, Artists.Yoann_Boissonnet);
            passage.addQuest("A Chosen Path", "Beorn's Path", 3, null, 'A', 10)
                .WithIncludedEncounterSets(EncounterSetNames.DolGuldurOrcs, EncounterSetNames.SpidersOfMirkwood)
                .WithFlavor("The trail winds into one of the darkest, most tangled parts of the forest...\r\n\r\nYou sense that foul, dark presence is hunting you, and you move quickly in an attempt to avoid its evil.")
                .WithOppositeTextLine("Players cannot defeat this stage while Ungoliant's Spawn is in play. If players defeat this stage, they have won the game.")
                .WithOppositeFlavor("You attempt to follow a secret, hidden trail to avoid the enemy...")
                .WithSlugSuffix("Beorn's Path")
                .WithBackArtist(Artists.David_Lecossu)
                .WithInfo(122, 1, Artists.Yoann_Boissonnet);

            escape.addQuest("The Necromancer's Tower", 1, 'A', 9)
                .WithIncludedEncounterSets(EncounterSetNames.DolGuldurOrcs, EncounterSetNames.SpidersOfMirkwood)
                .WithTextLine("Setup: Search the encounter deck for the 3 objective cards, reveal and place them in the staging area. Also, place the Nazgul of Dol Guldur face up but out of play, alongside the quest deck. Then, shuffle the encounter deck, and attach 1 encounter to each objective card.")
                .WithFlavor("The Lady Galadriel of Lorien has asked you to investigate the area in the vicinity of Dol Guldar. While doing so, one of your allies was ambushed by Orcs, captured, and is now held in a dungeon cell...")
                .WithOppositeTextLine("When Revealed: Randomly select 1 hero card (among all the heroes controlled by the players) and turn it facedown. The hero is now considered a \"prisoner\", cannot be used, cannot be damaged, and does not collect resources, until it is \"rescued\" (as instructed by card effects) later in this quest.")
                .WithOppositeTextLine("The players, as a group, cannot play more than 1 ally card each round.")
                .WithOppositeTextLine("Players cannot advance to the next stage of this quest unless they have at least 1 objective card.")
                .WithErrata()
                .WithInfo(123, 1, Artists.Ben_Zweifel);
            escape.addQuest("Through the Caverns", 2, 'A', 15)
                .WithIncludedEncounterSets(EncounterSetNames.DolGuldurOrcs, EncounterSetNames.SpidersOfMirkwood)
                .WithFlavor("Finding a hidden entrance to the dungeons of Dol Guldur at last, you attempt to make your way through the caverns beneath the hill, searching for your imprisoned friend. The denizens of this labyrinth stand in your way, while the jailors protect the prisoner.")
                .WithOppositeTextLine("Response: After placing any number of progress tokens on this card, flip the \"prisoner\" hero card face-up, and place 1 damage toke on it. The hero has been \"rescued\" and may now be used by its controller.")
                .WithOppositeTextLine("The players, as a group, cannot play more than 1 ally card each round.")
                .WithOppositeTextLine("Players cannot advance to the next stage of the quest unless they have rescued the prisoner and have all 3 \"Escape from Dol Guldur\" objective cards.")
                .WithInfo(124, 1, Artists.Kaya);
            escape.addQuest("Out of the Dungeons", 3, 'A', 7)
                .WithIncludedEncounterSets(EncounterSetNames.DolGuldurOrcs, EncounterSetNames.SpidersOfMirkwood)
                .WithFlavor("Following a thread of sunlight, you discover a cavern opening leading out through the side of the hill. Stationed outside the cave-mouth, however, is a large group of Orcs.")
                .WithOppositeTextLine("Forced: At the beginning of each quest phase, each player places the top card of his deck, face down in front of him as if it just engaged him from the staging area. These cards are called \"Orc Guard\" and act as enemies with: 1 hit point, 1 Attack, and 1 Defense.")
                .WithOppositeTextLine("Players cannot defeat this stage while Nazgul of Dol Guldur is in play. If this stage is defeated and Nazgul of Dol Guldur is not in play, the players have won the game.")
                .WithErrata()
                .WithInfo(125, 1, Artists.Kaya);

            journey.addQuest("To the River...", 1, 'A', 8)
                .WithIncludedEncounterSets(EncounterSetNames.DolGuldurOrcs, EncounterSetNames.SauronsReach, EncounterSetNames.Wilderlands)
                .WithTextLine("Setup: Each player reveals 1 card from the top of the encounter deck, and adds it to the staging area.")
                .WithFlavor("Emerging from Mirkwood Forest with an urgent message from Lady Galadriel, you must make your way south along the Anduin River in order to reach the forst of Lórien. As you leave the forest behind, you notice that you are being pursued, and thus quicken your pace...")
                .WithOppositeTextLine("When Revealed: Search the encounter deck for 1 Hill Troll is one is not already in play, and place it in the staging area. Shuffle the encounter deck.")
                .WithOppositeTextLine("Players cannot defeat this stage while any Hill Troll cards are in play.")
                .WithOppositeFlavor("As you approach the location of a small raft stashed on the riverbank, a fearsome Hill Troll emerges from behind a grouping of rocks, and attacks!")
                .WithInfo(126, 1, Artists.Ben_Zweifel);
            journey.addQuest("Anduin Passage", 2, 'A', 16)
                .WithIncludedEncounterSets(EncounterSetNames.DolGuldurOrcs, EncounterSetNames.SauronsReach, EncounterSetNames.Wilderlands)
                .WithTextLine("Reveal 1 additional card from the encounter deck each quest phase. Do not make engagement checks during the encounter phase. (Each player may still optionally engage 1 enemy each encounter phase.)")
                .WithFlavor("After defeating the Troll, you are able to board the raft and embark upon a river voyage. As you depart, your enemies pursue, harassing the small vessel as you attempt to navigate the river...")
                .WithOppositeFlavor("As your enemies harass the raft, it is difficult to maintain balance and effectively fight them off.")
                .WithInfo(127, 1, Artists.Ben_Zweifel);
            journey.addQuest("Ambush on the Shore", 3, 'A', 0)
                .WithIncludedEncounterSets(EncounterSetNames.DolGuldurOrcs, EncounterSetNames.SauronsReach, EncounterSetNames.Wilderlands)
                .WithTextLine("When Revealed: Reveal 2 encounter cards per player, and add them to the staging area.")
                .WithTextLine("Skip the staging step of the quest phase for the remainder of the game.")
                .WithTextLine("Once there are no enemies in play, the players have won the game.")
                .WithFlavor("The ongoing harassment from your enemies has forced your raft to the shore, and you must now confront their ambush head on. If you survive this attack, your path to the Golden Wood should be open before you...")
                .WithInfo(128, 1, Artists.David_A_Nash);
            
            return builder;
        }
    }
}
