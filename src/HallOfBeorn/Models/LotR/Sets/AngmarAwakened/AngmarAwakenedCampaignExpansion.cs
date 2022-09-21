using System;

namespace HallOfBeorn.Models.LotR.Sets.AngmarAwakened
{
    public class AngmarAwakenedCampaignExpansion
    {
        public static CardSet Create()
        {
            var cs = CardSet.Create("Angmar Awakened Campaign Expansion", "AAC", SetType.Campaign_Expansion, Cycles.AngmarAwakened, 302);

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
                .WithInfo(100, 1, Artist.Joel_Hustak);

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

            cs.addAttachment("Amarthiúl's Courage", 0, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Condition.")
                .WithTextLine("Setup: Attach to Amarthiúl. Otherwise, remove Amarthiúl's Courage from the game.")
                .WithTextLine("Amarthiúl gets +1 Willpower and +1 hit point.")
                .WithTextLine("Action: Ready Amarthiúl. (Limit once per game.)")
                .WithInfo(167, 1, Artist.Martin_de_Diego_Sadaba);

            cs.addEvent("Determination", 1, Sphere.Neutral)
                .WithBoon()
                .WithTextLine("Action: Attach Determination to a unique character. Then ready each character with a copy of Dtermination attached, as well as each character who is \"determined\" in the Campaign Log. (Counts as a Condition attachment with the text: \"Forced: If you win this scenario, mark in the Campaign Log that attached character is 'determined'\")")
                .WithInfo(172, 4, Artist.Michele_Frigo);
            cs.addEncounterSideQuest("Fend off Despair", EncounterSet.TheWastesOfEriadorCampaign, 8)
                .WithFlavorLine("The loss of Iârion at the hands of the wraith weighs upon you and your companions, sapping your resolve and making you question every decision you make in your pursuit. Yet if you give in, there will surely be no rescue for him from the foul sorcery of Angmar...")
                .WithTextLine("Each event card gains doomed 1.")
                .WithTextLine("Forced: When Fend off Despair is defeated, mark in the Campaign Log that each player's starting threat by 2. (This reduction is cumulative.)")
                .WithVictoryPoints(10)
                .WithInfo(173, 1, Artist.Michele_Frigo);

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

            cs.addAttachment("Silverthorn", 0, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Artifact.", "Weapon.", "Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("While attacking or defending against an enemy, attached hero gets +1 Attack and +1 Defense if that enemy shares a Trait with an enemy in the victory display.")
                .WithTextLine("Response: After attached hero attacks and destroys an enemy, add that enemy to the victory display. (Limit once per game.)")
                .WithInfo(181, 1, Artist.Carlos_Palma_Cruchaga);

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

            return cs;
        }
    }
}