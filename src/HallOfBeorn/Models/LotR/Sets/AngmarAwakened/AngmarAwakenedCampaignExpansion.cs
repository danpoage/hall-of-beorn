﻿using System;

namespace HallOfBeorn.Models.LotR.Sets.AngmarAwakened
{
    public class AngmarAwakenedCampaignExpansion
    {
        public static CardSet Create()
        {
            var cs = CardSet.Create("Angmar Awakened Campaign Expansion", "AAC", SetType.Campaign_Expansion, Cycles.AngmarAwakened, 302);

            cs.addCampaign("Intruders in Chetwood", EncounterSet.IntrudersInChetwoodCampaign, "Angmar Awakened Part 1")
                .WithTextLine("You are playing campaign mode.")
                .WithTextLine("Setup: Attach Iârion's Pendant to Iârion and add the Protect the Innocent side quest to the staging area. Starting with the first player, each player may place 4 damage on Protect the Innocent to add 1 resource to each of their heroes' resource pools.")
                .WithFlavorLine("\"Orcs have been discovered west of the Weather Hills in greater number than we have seen them in many years. They are spying out the land, and we believe they plan to attack.\"")
                .WithFlavorLine("-Iârion")
                .WithOppositeTextLine("Resolution: Note the amount of damage on Protect the Innocent in the Campaign Log and add Protect the Innocent to the Campaign Pool.")
                .WithOppositeFlavorLine("\"I'm afraid our work is not yet finished, my friends,\" said Iârion, gazing into the distance. \"There is to be a gathering of the Dúnedain at Fornost in a few days to celebrate the Autumnal Equinox. I must go thither with news of this attack for I fear it is but a prelude of things to come, and the Rangers must be ready for what follows. However, we cannot allow those Orcs that fled to escape, or they may return again in even greater numbers. Since I must go to Fornost, I ask you: will you track them in my stead?\"")
                .WithOppositeFlavorLine("From the strained look in his eyes, the heroes could see how hard it was for the honorable ranged to burden them with this dangerous task, so they made him an oath that none of the Orcs who had ventured so close to Bree would live to return again.")
                .WithOppositeFlavorLine("\"Well said,\" replied Iârion. Then, he raised his sword in salute and spoke, \"May the spirit of Oromë guide you on your hunt!\"")
                .WithInfo(156, 1, Artist.Nicholas_Gregory);
            cs.addAttachment("Iârion's Pendant", 1, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Artifact.", "Item.")
                .WithTextLine("Attached character gets +1 Willpower.")
                .WithTextLine("Response: Add Iârion's Pendant to the victory display to cancel the 'when revealed' effects of a card that was just revaled from the encounter deck, or to cancel a shadow effect just triggered.")
                .WithFlavorLine("\"That is just what the Rangers are: the last remnant in the North of the great people.\"")
                .WithFlavorLine("-Gandalf, The Lord of the Rings")
                .WithVictoryPoints(1)
                .WithInfo(157, 1, Artist.Martin_de_Diego_Sadaba);
            cs.addEncounterSideQuest("Protect the Innocent", EncounterSet.IntrudersInChetwoodCampaign, Card.VALUE_NA)
                .WithTextLine("Forced: After an attack damages a character, place 1 damage on Protect the Innocent.")
                .WithTextLine("When progress would be placed on Protect the Innocent, remove that much damage from it instead.")
                .WithTextLine("If Protect the Innocent has 10 or more damage on it (20 or more if there are 3 or 4 players in the game), the players lose the game.")
                .WithSideA()
                .WithInfo(158, 1, Artist.Juan_Carlos_Barquet);
            cs.addObjective("Arnor Ravaged", EncounterSet.IntrudersInChetwoodCampaign)
                .WithBurden()
                .WithTraits("Doom.")
                .WithTextLine("Setup: Add Arnor Ravaged to the staging area with damage on it equal to the amount of damage marked for it in the Campaign Log.")
                .WithTextLine("Forced: After an attack damages a character but does not destroy it, move 1 damage from Arnor Ravaged to that character.")
                .WithSideB()
                .WithInfo(158, 1, Artist.Borja_Pindado);
            cs.addCampaign("The Weather Hills", EncounterSet.TheWeatherHillsCampaign, "Angmar Awakened Part 2")
                .WithTextLine("You are playing campaign mode.")
                .WithTextLine("Setup: Add the Myterious Omens side quest to the Campaign Log and shuffle it into the encounter deck. Add the Protect the Innocent side quest to the staging area and place damage on it equal to the amount of damage noted for it in the Campaign Log.")
                .WithFlavorLine("There was some murmur of agreement among the company. \"It matters not whence the rain comes or if the trail ends; our quarry hides somewhere in these hills, and we must find them or forsake their captives and our oath.\"")
                .WithOppositeTextLine("Resolution: Note the amount of damage on Protect the Innocent in the Campaign Log (replacing the previous number).")
                .WithOppositeFlavorLine("The heroes forced the door open and thrust a torch inside. The flickering orange light revealed a small group of survivors huddled together in a corner. They appeared half-starved, and they shivered in the cold dungeon. The heroes removed their cloaks and placed them around the unfortunate prisoners to help warm them.")
                .WithOppositeFlavorLine("\"Who has done this?\" asked one of the heroes, but they were too distraught to answer.")
                .WithOppositeFlavorLine("At length, an older man named Thaurdir spoke, \"We could hear the harsh voices of Orcs, but there was another voice that commanded them. I don't know what kind of creature it was, but it was terrifying to hear.\"")
                .WithOppositeFlavorLine("\"We found none but Orcs when we arrived here,\" spoke one of the heroes.")
                .WithOppositeFlavorLine("\"Then it must have escaped,\" answered the old man.")
                .WithOppositeFlavorLine("The hero turned to their companions and said, \"We should take these people to Fornost where the Rangers are gathered. Iârion will want to hear what they can tell him of their capture.\"")
                .WithInfo(159, 1, Artist.Juan_Carlos_Barquet);
            cs.addEncounterSideQuest("Mysterious Omens", EncounterSet.TheWeatherHillsCampaign, 9)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Forced: After Mysterious Omens becomes the current quest, each player discards 1 random card from their hand.")
                .WithTextLine("Forced: When Mysterious Omens is defeated, remove it from the Campaign Pool. Then, each player may choose 1 of the following boons and attach it to a hero they control: Cunning, Hardy, Resolute, Ruthless, or Stalwart.")
                .WithVictoryPoints(5)
                .WithInfo(160, 1, Artist.Lucas_Staniec);
            cs.addAttachment("Cunning", 0, Sphere.Neutral, false)
                .WithBoon()
                .WithTraits("Condition.")
                .WithKeywords("Permanent.")
                .WithTextLine("Permanent.")
                .WithTextLine("Setup: Attach to a hero. Add 2 resources to that hero's resource pool.")
                .WithTextLine("Action: Attached hero gets +2 Willpower, +2 Attack, and +2 Defense until the end of the phase. (Limit once per game.)")
                .WithInfo(161, 1, Artist.Lin_Hsiang);
            cs.addAttachment("Hardy", 0, Sphere.Neutral, false)
                .WithBoon()
                .WithTraits("Condition.")
                .WithKeywords("Permanent.")
                .WithTextLine("Permanent.")
                .WithTextLine("Setup: Attach to a hero.")
                .WithTextLine("Attached hero gets +2 hit points.")
                .WithTextLine("Action: Ready attached hero. (Limit once per game.)")
                .WithInfo(162, 1, Artist.Lin_Hsiang);
            cs.addAttachment("Resolute", 0, Sphere.Neutral, false)
                .WithBoon()
                .WithTraits("Condition.")
                .WithKeywords("Permanent.")
                .WithTextLine("Permanent.")
                .WithTextLine("Setup: Attach to a hero.")
                .WithTextLine("Attached hero gets +1 Willpower.")
                .WithTextLine("Response: Cancel up to 2 points of damage just dealt to attached hero. (Limit once per game.)")
                .WithInfo(163, 1, Artist.Drazenka_Kimpel);
            cs.addAttachment("Ruthless", 0, Sphere.Neutral, false)
                .WithBoon()
                .WithTraits("Condition.")
                .WithKeywords("Permanent.")
                .WithTextLine("Setup: Attach to a hero.")
                .WithTextLine("Attached hero gets +1 Attack.")
                .WithTextLine("Action: Move any amount of damage from attached hero to an enemy engaged with you. (Limit once per game.)")
                .WithInfo(164, 1, Artist.JB_Casacop);
            cs.addAttachment("Stalwart", 0, Sphere.Neutral, false)
                .WithBoon()
                .WithTraits("Condition.")
                .WithKeywords("Permanent.")
                .WithTextLine("Permanent.")
                .WithTextLine("Setup: Attach to a hero.")
                .WithTextLine("Attached hero gets +1 Defense.")
                .WithTextLine("Planning Action: Play an attachment from your discard pile on attached hero. (LImit once per game.)")
                .WithInfo(165, 1, Artist.Drazenka_Kimpel);
            cs.addCampaign("Deadmen's Dike", EncounterSet.DeadmensDikeCampaign, "Angmar Awakened Part 3")
                .WithTextLine("You are playing campaign mode.")
                .WithTextLine("Setup: Attach Iârion's Pendant to Iârion. Add the Protect the Innocent side quest to the staging area and place damage on it equal to the amount of damage noted in the Campaign Log.")
                .WithTextLine("Forced: After Thaurdir enters play, randomly select one of the following burdens and attach it to Thaurdir: Thaurdir's Legacy, Thaurdir's Majesty, or Thaurdir's Spite. Add that card to the Campaign Pool.")
                .WithFlavorLine("\"To arms, Dúnedain! The wraiths of Angmart are upon us!\"")
                .WithFlavorLine("-Aragorn")
                .WithOppositeText("Resolution: Note the amount of damafge on Protect the Innocent in the Campaign Log (replacing the previous number) and remove Protect the Innocent from the Campaign Pool. Add Arnor Ravaged to the Campaign Pool in its place (found on the opposite side of Protect the Innocent). The players as a group must select either Iârion's Pendant or Amarthiúl's Courage to add to the Campaign Pool. Any player may add Iârion's Pendant to their deck if it is chosen.")
                .WithOppositeFlavorLine("\"The wraith that attacked us was a powerful sorcerer. It was he that took Iârion.\"")
                .WithOppositeFlavorLine("\"Why?\", asked Amarthiúl, but none could answer. On the ground, the young Ranger found the hawk pendant of Iârion and regarded it in his hand. \"It matters not,\", said the Dúnadan clutching the pendant and rising to his feet. \"Thaurdir has taken my friend, so I will pursue him.\"")
                .WithOppositeFlavorLine("\"We will aid you in this quest,\" spoke the heroes with one voice. \"We cannot abandon Iârion to the same fate as those village people.\"")
                .WithInfo(166, 1, Artist.Joel_Hustak);
            cs.addAttachment("Amarthiúl's Courage", 0, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Condition.")
                .WithTextLine("Setup: Attach to Amarthiúl. Otherwise, remove Amarthiúl's Courage from the game.")
                .WithTextLine("Amarthiúl gets +1 Willpower and +1 hit point.")
                .WithTextLine("Action: Ready Amarthiúl. (Limit once per game.)")
                .WithInfo(167, 1, Artist.Martin_de_Diego_Sadaba);
            cs.addObjective("Thaurdir's Legacy", EncounterSet.DeadmensDikeCampaign)
                .WithUnique()
                .WithBurden()
                .WithTraits("Thaurdir.")
                .WithTextLine("Setup: Attach to Thaurdir (even if he is out of play). Otherwise, remove this card from the game.")
                .WithTextLine("Forced: After a Sorcery treachery is revealed, move Thaurdir's Legacy to the hero with the most resources. (Counts as a Sorcery attachment with the text: \"Attached hero gets -2 Willpower and is treated as if its printed text box were blank.\")")
                .WithInfo(168, 1, Artist.Guillaume_Ducos);
            cs.addObjective("Thaurdir's Majesty", EncounterSet.DeadmensDikeCampaign)
                .WithUnique()
                .WithBurden()
                .WithTraits("Thaurdir.")
                .WithTextLine("Setup: Attach to Thaurdir (even if he is out of play). Otherwise, remove this card from the game.")
                .WithTextLine("Forced: After a Sorcery treachery is revealed, move Thaurdir's Majests to the hero with the most non-objective attachments. (Counts as a Sorcery attachment with the text: \"Attached hero gets -2 Attack and cannot commit to the quest.\")")
                .WithInfo(169, 1, Artist.Alex_Boca);
            cs.addObjective("Thaurdir's Spite", EncounterSet.DeadmensDikeCampaign)
                .WithUnique()
                .WithBurden()
                .WithTraits("Thaurdir.")
                .WithTextLine("Setup: Attach to Thaurdir (even if he is out of play). Otherwise, remove this card from the game.")
                .WithTextLine("Forced: After a Sorcery treachery is revealed, move Thaurdir's Spite to the hero with the most damage. (Counts as a Sorcery attachment with the text: \"Attached hero gets -2 Defense and cannot be healed.\")")
                .WithInfo(170, 1, Artist.Monztre);
            cs.addCampaign("The Wastes of Eriador", EncounterSet.TheWastesOfEriadorCampaign, "Angmar Awakened Part 4")
                .WithTextLine("You are playing campaign mode.")
                .WithTextLine("Setup: Each player may change hero cards without incurring the +1 threat penalty. Each player adds 1 copy of Determination to their starting hand. Add each of those events to the Campaign Pool. Shuffle the Fend Off Despair side quest into the encounter deck.")
                .WithFlavorLine("\"We cannot tarry. The wolves here are evil and vicious, and the darkness of night is their hunting ground. I fear our hunt has just become theirs...\"")
                .WithFlavorLine("-Amarthiúl")
                .WithOppositeTextLine("Resolution: Add Fend Off Despair to the Campaign Pool.")
                .WithOppositeFlavorLine("The Goblins emerged under the cover darkness, clad in white fur that blended with the snow. The sentries that kept watch were taken from behind, pulled to the ground and gagged. One spotted the approaching Goblins and called out, but was immediately struck by Goblin-arrows. The sentry's shouts woke the rest of the company, but taken by surprise and outnumbered nearly ten to one, the odds were grim. TYhe largest of the Goblins stepped forward and grinned wickedly. \"Surround them! Don't let any escape!\" if bellowed, \"Gornákh wants them alive!\"")
                .WithOppositeFlavorLine("The heroes were forced to submit, disarmed of their weapons, and bound. They looked amongst themselves for a moment before they realized that Amarthiúl was no longer standing among them. They weren't sure if his body was among the slaim.")
                .WithOppositeFlavorLine("\"Come alonmg now, lads,\" the larger Goblin growled, pulling one of the heroes to his feet and forcing him to march at spear-point. \"Mount Gram awaits.\"")
                .WithInfo(171, 1, Artist.Ilich_Henriquez);
            cs.addEvent("Determination", 1, Sphere.Neutral)
                .WithBoon()
                .WithTextLine("Action: Attach Determination to a unique character. Then ready each character with a copy of Dtermination attached, as well as each character who is \"determined\" in the Campaign Log. (Counts as a Condition attachment with the text: \"Forced: If you win this scenario, mark in the Campaign Log that attached character is 'determined'\")")
                .WithInfo(172, 4, Artist.Michele_Frigo);
            cs.addEncounterSideQuest("Fend Off Despair", EncounterSet.TheWastesOfEriadorCampaign, 8)
                .WithFlavorLine("The loss of Iârion at the hands of the wraith weighs upon you and your companions, sapping your resolve and making you question every decision you make in your pursuit. Yet if you give in, there will surely be no rescue for him from the foul sorcery of Angmar...")
                .WithTextLine("Each event card gains doomed 1.")
                .WithTextLine("Forced: When Fend Off Despair is defeated, mark in the Campaign Log that each player's starting threat by 2. (This reduction is cumulative.)")
                .WithVictoryPoints(10)
                .WithInfo(173, 1, Artist.Michele_Frigo);
            cs.addCampaign("Escape from Mount Gram", EncounterSet.EscapeFromMountGramCampaign, "Angmar Awakened Part 5")
                .WithTextLine("You are playing campaign mode.")
                .WithTextLine("Setup: Set aside any permanent boon attachments on heroes that are added to a player's captured deck. Add the Loot the Dungeons side querst to the staging area, capturing the bottom 5 cards of each player's captured deck underneath it. Flip this card over.")
                .WithFlavorLine("\"There are many more of our company imprisoned here. Find them and make your way to the southern gate. I will try to find Iârion, and meet you there.\"")
                .WithFlavorLine("-Amarthiúl")
                .WithOppositeTextLine("Forced: Instead of raising their threat by 1 during the refresh phase, each player raises their threat by the number of completed quest cards plus the number of side quests in the victory display.")
                .WithOppositeTextLine("Forced: After a hero enters play, attach to that hero each set-aside permanent boon attachment assigned to that character in the Campaign Log.")
                .WithOppositeTextLine("Resolution: Each player must make note of which unique cards are still in their captured deck and not in play at the end of the game. Those cards cannot be included in that player's deck for the rest of the campaign.")
                .WithOppositeFlavorLine("\"Thaurdir is aware of our escape. Our fortunes have turned. Now we are the ones being pursued.\"")
                .WithOppositeFlavorLine("-Amarthiúl")
                .WithInfo(174, 1, Artist.Tomasz_Jedruszek);
            cs.addEncounterSideQuest("Loot the Dungeons", EncounterSet.EscapeFromMountGramCampaign, 4)
                .WithTextLine("Loot the Dungeons is considered to be in each player's staging area and gets +4 quest points for each player in the game at every staging area.")
                .WithTextLine("Forced: When Loot the Dungeons is defeated, each player (at every staging area) may choose one of the following boons and add it to their hand: Berelind, Chieftain's Brooch, Coruhaer, Laermuin, Mail of Eärnur, or Silverthorn. Add the chosen cards to the Campaign Pool.")
                .WithVictoryPoints(10)
                .WithInfo(175, 1, Artist.Mariusz_Gandzel);
            cs.addAlly("Berelind", 1, Sphere.Neutral, true, 1, 3, 0, 2)
                .WithBoon()
                .WithTraits("Dúnedain.", "Ranger.")
                .WithTextLine("Response: After Berelind attacks and destroys an enemy, place 1 progress on a quest card in play.")
                .WithFlavorLine("A light fell about her, and her hair shone in the sunrise.")
                .WithFlavorLine("-The Lord of the Rings")
                .WithInfo(176, 1, Artist.Borja_Pindado);
            cs.addAttachment("Chieftain's Brooch", 2, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("Each ally that shares a Trait with attached hero gets +1 Willpower.")
                .WithFlavorLine("When the kingdom ended the Dúnedain passed into the shadows and became a secret and wandering people, and their deeds and labours were seldom sung or recorded.")
                .WithFlavorLine("-The Lord of the Rings")
                .WithInfo(177, 1, Artist.Carlos_Palma_Cruchaga);
            cs.addAlly("Coruhaer", 0, Sphere.Neutral, true, 0, 1, 1, 2)
                .WithBoon()
                .WithTraits("Dúnedain.", "Ranger.")
                .WithTextLine("Response: After Coruhaer defends an attack, spend 1 resource to deal 2 damage to the attacking enemy.")
                .WithFlavorLine("A dread fell on them, even as they passed between the lines of ancient stones.")
                .WithFlavorLine("-The Lord of the Rings")
                .WithInfo(178, 1, Artist.Lin_Hsiang);
            cs.addAlly("Laermuin", 2, Sphere.Neutral, true, 2, 2, 0, 4)
                .WithBoon()
                .WithTraits("Dúnedain.", "Ranger.")
                .WithTextLine("Response: After Laermuin commits to a quest, heal 1 damage from a character.")
                .WithFlavorLine("Ancient of days he seemed and yet in the flower of manhood; and wisdom sat upon his brow.")
                .WithFlavorLine("-The Lord of the Rings")
                .WithInfo(179, 1, Artist.Drazenka_Kimpel);
            cs.addAttachment("Mail of Eärnur", 1, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Artifact.", "Armor.", "Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("Attached hero gets +2 hit points.")
                .WithTextLine("Response: After a player's threat is reduced, heal 1 damage from attached hero.")
                .WithFlavorLine("So ended the evil realm of Angmar; and so Eärnur, Captain of Gondor, earned the chief hatred of the Witch-King.")
                .WithFlavorLine("-The Lord of the Rings")
                .WithInfo(180, 1, Artist.Martin_de_Diego_Sadaba);
            cs.addAttachment("Silverthorn", 0, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Artifact.", "Weapon.", "Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("While attacking or defending against an enemy, attached hero gets +1 Attack and +1 Defense if that enemy shares a Trait with an enemy in the victory display.")
                .WithTextLine("Response: After attached hero attacks and destroys an enemy, add that enemy to the victory display. (Limit once per game.)")
                .WithInfo(181, 1, Artist.Carlos_Palma_Cruchaga);
            cs.addCampaign("Across the Ettenmoors", EncounterSet.AcrossTheEttenmoorsCampaign, "Angmar Awakened Part 6")
                .WithTextLine("You are playing campaign mode.")
                .WithTextLine("Setup: Set all 5 Losing Time treacheries aside, out of play.")
                .WithTextLine("Forced: At the beginning of the quest phase, place 1 resource on this card. Then, if there are 3 or more resources on it, remove 3 resources from it to reveal 1 set-aside copy of Losing Time and place it in the encounter discard pile.")
                .WithFlavorLine("Heading south from Mount Gram, the company foundthe return to Rivendell fraught with peril at every turn. The need for haste forced them to travel into the wildlands of the Ettermoors, a decision they quickly regretted.")
                .WithOppositeTextLine("Resolution: Add each copy of Losing Time in the encounter deck or encounter discard pile to the Campaign Pool.")
                .WithOppositeFlavorLine("\"This is the land of Rhudaur; one of the three kingdoms of old Arnor. The line of Isildur did not survive in Rhudair; and over time the number of Dúnedain here dwindled. The elders tell us that evil men, hillmen in league with the realm of Angmar; usurped the last king of Rhudaur many hundreds of years ago. From that moment on, Rhudaur was a vassal of the Witch-king and those Dúnedain still remaining in this land were either slain in cold blood, or fled west.\"")
                .WithOppositeFlavorLine("-Amarthiúl")
                .WithInfo(182, 1, Artist.Alvaro_Calvo_Escudero);
            cs.addTreachery("Losing Time", EncounterSet.AcrossTheEttenmoorsCampaign)
                .WithBurden()
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Each player must either raise their threat by 3 or exhaust a hero they control.")
                .WithShadow("Shadow: Attacking enemy either gets +3 Attack or +3 Defense until the end of the phase.")
                .WithInfo(183, 4, Artist.Anthony_Devine);
            cs.addCampaign("The Treachery of Rhudaur", EncounterSet.TheTreacheryOfRhudaurCampaign, "Angmar Awakened Part 7")
                .WithTextLine("You are playing campaign mode.")
                .WithFlavorLine("The company exchanged anxious glances. \"If Amarthiúl is right and the Wraith was after Iârion in particular; these ruins might hold the answer to this mystery.\"")
                .WithOppositeTextLine("Resolution: For each Clue a player controls, that player may add the book with the same name to the Campaign Pool and their deck.")
                .WithOppositeFlavorLine("\"Look!\" the hero holding the tome shouted, pointing to the tree. \"I recognize this name: Daechanar. That is the same name as the one who commands Thaurdir - the 'lord of Angmar' mentioned in the Goblin dungeons!\"")
                .WithOppositeFlavorLine("One of the companions shook her head, pondering what they had learned. \"It cannot be the same person. It's been over a century. The Dúnedain are long-lived, but they are not immortal. The Daechanar in this family tree should be long dead by now...\"")
                .WithOppositeFlavorLine("\"We should continue to Rivendell,\" one of the heroes declared at last. \"Even Thaurdir cannot pursue us there, and we can consult Elrond about these matters. If there is anyone who will understand what we are dealing with, it is he.\"")
                .WithInfo(184, 1, Artist.Eva_Maria_Toker);
            cs.addAttachment("Daechanar's Brand", 0, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Artifact.", "Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("Attached hero gets +1 Attack (+2 Attack instead when attacking an Undead enemy).")
                .WithTextLine("Response: After you play Daechnar's Brand, search the top 5 cards of the encounter deck for a Sorcery treachery and add it to the victory display. Shuffle the encounter deck.")
                .WithInfo(185, 1, Artist.Preston_Stone);
            cs.addAttachment("Heirloom of Iârchon", 0, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("Attached hero gets +1 Willpower.")
                .WithTextLine("Response: After you play Heirloom of Iârchon, heal all damage from attached character.")
                .WithFlavorLine("\"Iârchon, may this pendant guide you away from the shadow that dwells within us all.\"")
                .WithFlavorLine("-Pendant Inscription")
                .WithInfo(186, 1, Artist.Romana_Kendelic);
            cs.addAttachment("Orders from Angmar", 0, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("Attached hero gets +1 Defense (+2 Defense instead while defending against an Undead enemy).")
                .WithTextLine("Response: After you play Orders from Angmar, discard a non-unique Undead enemy with 2 or less remaining hit points.")
                .WithInfo(187, 1, Artist.Chris_Metcalf);
            cs.addCampaign("The Battle of Carn Dûm", EncounterSet.TheBattleOfCarnDumCampaign, "Angmar Awakened Part 8")
                .WithTextLine("You are playing campaign mode.")
                .WithTextLine("Setup: Each player may change hero cards without incurring the +1 threat penalty, and Amarthiúl may be included among a player's heroes. Then, each player in turn order may select one of the following boons and add it to their opening hand: Elrond's Champion, Lore of Ancient Arnor, Raiment of the Second Age, or Rivendell Skirmishers. Add the chosen cards to the Campaign Pool.")
                .WithOppositeTextLine("Resolution: Note the amount of damage on each hero at the end of the game.")
                .WithOppositeFlavorLine("As the heroes slew Thaurdir, his remains crumbled and decayed into ash before their very eyes, and his armor and weapon clattered to the ground harmlessly. But before they could rejoice in their victory, the howling of wolves sounded in the air, as if all around them.")
                .WithOppositeFlavorLine("\"Goblins!\" one of the Rangers in the rear ranks shouted, \"Goblins from Mount Gram!\" The company found themselves assaulted from the south by Goblins while the Orcs of Carn Dûm rallied their defenses once more. They had but a moment to slip into the fortress before they were surrounded on all sides. One of the Elves that had accompanied them from Rivendell turned to the heroes with a grim expression and shouted over the clamour of battle, \"You must make your way into the fortress and stop Daechanar's ritual!\"")
                .WithInfo(188, 1, Artist.Wibben);
            cs.addAlly("Elrond's Champion", 3, Sphere.Neutral, false, 2, 3, 1, 5)
                .WithBoon()
                .WithTraits("Noldor.", "Warrior.")
                .WithTextLine("Response: After an enemy engages you, ready Elrond's Champion.")
                .WithFlavorLine("\"That is a chapter of ancient history which it might be good to recall: for there was sorrow then too, and gathering dark, but great valour, and great deeds that were not wholly vain.\"")
                .WithFlavorLine("-Gandalf, The Lord of the Rings")
                .WithInfo(189, 1, Artist.JB_Casacop);
            cs.addEvent("Lore of Ancient Arnor", 3, Sphere.Neutral)
                .WithBoon()
                .WithTextLine("Action: Each player returns 1 card from their discard pile to their hand (2 cards instead if you are the only player in the game) and shuffles the rest of their discard pile back into their deck. Then, remove this card from the game.")
                .WithInfo(190, 1, Artist.Lin_Hsiang);
            cs.addAttachment("Raiment of the Second Age", 3, Sphere.Neutral, false)
                .WithBoon()
                .WithTraits("Armor.", "Weapon.", "Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a character. Restricted.")
                .WithTextLine("Attached character gets +2 Attack and +2 hit points.")
                .WithTextLine("Response: After attached character attacks and destroys an enemy, draw 1 card.")
                .WithFlavorLine("\"It recalled to me the glory of the Eldar Days and the hosts of Beleriand.\"")
                .WithFlavorLine("-Elrond, The Lord of the Rings")
                .WithInfo(191, 1, Artist.Carlos_Palma_Cruchaga);
            cs.addAlly("Rivendell Skirmishers", 3, Sphere.Neutral, false, 2, 2, 3, 3)
                .WithBoon()
                .WithTraits("Noldor.", "Warrior.")
                .WithTextLine("Response: After Rivendell Skirmishers exhausts to defend an attack from a non-unique enemy, discard each shadow card from that enemy.")
                .WithFlavorLine("It was said that Angmar was for a time subdued by the Elvenfolk coming from Lindon and from Rivendell.")
                .WithFlavorLine("-The Lord of the Rings")
                .WithInfo(192, 1, Artist.JB_Casacop);
            cs.addCampaign("The Dread Realm", EncounterSet.TheDreadRealmCampaign, "Angmar Awakened Part 9")
                .WithTextLine("You are playing campaign mode.")
                .WithTextLine("Setup: Each player may search their deck for a boon card and add it to their opening hand. Each hero begins the game with damage on them equal to the amount noted for them in the Campaign Log.")
                .WithFlavorLine("Somewhere within these catacombs, surrounded by the watchful dead, Iârion was struggling in torment. Spurred onward by steely resolve, the heroes began their search...")
                .WithOppositeTextLine("Resolution: The players win the campaign!")
                .WithOppositeFlavorLine("The dark clouds above the fortress scattered, and the light of day washed over the battlefield. With the defeat of their master and the sun glaring down at them, the Goblins fled south to their mountain refuge. The remaining Elves and Rangers, rallied by the turning tide, drove the Orcs into full rout. The battle was won... but the victory was bittersweet. As the heroes emerged from the fortress carrying Iârion's body, their company was filled with a great sorrow. Though they were able to defeat Daechanar and stop his plans from coming to fruition, they were too late to save their friend. The tragedy of slaying the Ranger with their own hand was something the heroes would never forget, although they had his final words to comfort them.")
                .WithInfo(193, 1, Artist.Logan_Feliciano);

            return cs;
        }
    }
}