/* Generated CardSet class: The Crossings of Poros */

using System;

namespace HallOfBeorn.Models.LotR.Sets.Haradrim
{
    public class TheCrossingsOfPorosSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Crossings of Poros";
            Abbreviation = "CoP";
            Number = 48;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            addHero("Quickbeam", 12, Sphere.Tactics, 2, 4, 1, 5)
                .WithTraits("Ent.")
                .WithTextLine("Cannot have restricted attachments.")
                .WithTextLine("Action: Deal 2 damage to Quickbeam to ready him. (Limit once per phase.)")
                .WithFlavorLine("\"...he can move like a wind when he is roused.\"")
                .WithFlavorLine("-Pippin, The Two Towers")
                .WithAges(Age.Second_Age, Age.Third_Age)
                .WithInfo(135, 1, Artist.Guillaume_Ducos);
            addAlly("Halfast Gamgee", 3, Sphere.Leadership, true, 2, 1, 0, 2)
                .WithTraits("Hobbit.")
                .WithTextLine("Reduce the cost to play Halfast Gamgee by 1 for each side quest in the victory display.")
                .WithTextLine("Response: After Halfast Gamgee enters play, add 1 resource to a hero's resource pool.")
                .WithFlavorLine("\"He works for Mr. Boffin at Overhill and goes up to the Northfarthing for the hunting.\"")
                .WithFlavorLine("-Sam Gamgee, The Fellowship of the Ring")
                .WithInfo(136, 3, Artist.Stanislav_Dikolenko);
            addEvent("Bulwark of the West", 0, Sphere.Leadership)
                .WithTextLine("Action: Discard an ally you control to choose and discard a Condition attachment.")
                .WithFlavorLine("\"By our valour the wildfolk of the East are still restrained, and the terror of Morgul kept at bay; and thus alone are peace and freedom maintained in the lads behind us...")
                .WithFlavorLine("-Boromir, The Fellowship of the Ring")
                .WithInfo(137, 3, Artist.Stanislav_Dikolenko);
            addAlly("Beorning Guardian", 3, Sphere.Tactics, false, 0, 3, 1, 3)
                .WithTraits("Beorning.")
                .WithTextLine("Response: After ~Beorning ~Guardian participates in an attack that destroys an enemy, discard ~Beorning ~Guardian to place X progress on a location, where X is the destroyed enemy's printed Threat.")
                .WithFlavorLine("\"...if it were not for the Beornings, the passage from Dale to Rivendell would long ago have become impossible.\"")
                .WithFlavorLine("-Glóin, The Fellowship of the Ring")
                .WithInfo(138, 3, Artist.Marius_Bota);
            addAttachment("Followed", 1, Sphere.Tactics, false)
                .WithTraits("Condition.", "Trap.")
                .WithTextLine("Play into your play area unattached.")
                .WithTextLine("While unattached, attach to the next eligible enemy that engages you.")
                .WithTextLine("While attached enemy is engaged with you, reduce the total Threat in the staging area by X, where X is attached enemy's printed Threat.")
                .WithInfo(139, 3, Artist.Dimitri_Bielak);
            addEvent("Flight to the Sea", 2, Sphere.Spirit)
                .WithTextLine("Play only if you control a Noldor or Silvan hero.")
                .WithTextLine("Planning Action: Shuffle a set aside ~Wind from the ~Sea into the encounter deck. Then, remove Flight to the Sea from the game.")
                .WithFlavorLine("\"...they may pass to the Sea unhindered and leave the Middle-earth forever.\"")
                .WithFlavorLine("-Haldir, The Two Towers")
                .WithInfo(140, 3, Artist.Alexander_Gustafson);
            addAlly("Emyn Arnen Ranger", 2, Sphere.Lore, false, 0, 1, 1, 2)
                .WithTraits("Gondor.", "Ranger.")
                .WithTextLine("Response: After Emyn Arnen ~Ranger commits to the quest, choose an enemy with a Trap attachment. Until the end of the phase, Emyn Arnen ~Ranger gets +X Willpower, where X is the chosen enemy's printed Threat.")
                .WithInfo(141, 3, Artist.Aleksander_Karcz);
            addEvent("The Dam Bursts", 2, Sphere.Lore)
                .WithTextLine("Play only if you control a unique character with the Ent trait and another unique character with the Hobbit trait.")
                .WithTextLine("Action: Ready each damaged Ent character you control.")
                .WithInfo(142, 3, Artist.Sergey_Glushakov);
            addAttachment("Magic Ring", 2, Sphere.Neutral, false)
                .WithTraits("Artifact.", "Item.", "Ring.")
                .WithTextLine("Attach to a hero. Limit 1 per hero and 1 per deck.")
                .WithTextLine("Action: Exhaust Magic ~Ring and raise your threat by 1 to (choose 1): heal 1 damage from attached hero, add 1 resource to attached hero's pool, or ready attached hero.")
                .WithFlavorLine("\"In Eregion long ago many Elven-rings were made, magic rings as you call them, and they were, of course, of various kinds...\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithInfo(143, 3, Artist.Lucas_Durham);
            addEvent("Wind from the Sea", 255, Sphere.Neutral)
                .WithKeywords("Encounter.")
                .WithTextLine("Encounter.")
                .WithTextLine("When Revealed: Ready each hero committed to the quest and remove Wind from the Sea from the game.")
                .WithShadow("Shadow: Ready the defending character.")
                .WithInfo(144, 3, Artist.Davis_Engel);
            addObjectiveAlly("Poros Garrison", EncounterSet.TheCrossingsOfPoros, 3, 4, 3, 6)
                .WithUnique()
                .WithTraits("Gondor.")
                .WithTextLine("The first player gains control of Poros Garrison.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("You can optionally engage an additional enemy during the encounter phase.")
                .WithTextLine("If Poros Garrison leaves play, the players lose the game.")
                .WithInfo(145, 1, Artist.S_C_Watson);
            addEnemy("The Black Serpent", EncounterSet.TheCrossingsOfPoros, 50, 0, 2, 1, 8)
                .WithUnique()
                .WithTraits("Harad.")
                .WithTextLine("Cannot leave the staging area or take damage. X is the stage number of the main quest.")
                .WithTextLine("The Black Serpent gets +X Threat, +X Attack and +X Defense.")
                .WithTextLine("Forced: At the end of the encounter phase, either remove X progress from the main quest, or The Black Serpent makes an attack against the first player.")
                .WithInfo(146, 1, Artist.Alexandr_Elichev);
            addEnemy("Southron Outrider", EncounterSet.TheCrossingsOfPoros, 28, 2, 3, 1, 4)
                .WithTraits("Harad.")
                .WithTextLine("Forced: After Southron Outrider engages you, either place a random enemy from the set aside Harad Soldiers set into the encounter discard pile, or Southron Outrider gets +3 Attack this round.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithInfo(147, 2, Artist.Carlos_Palma_Cruchaga);
            addEnemy("Uruk Prowler", EncounterSet.TheCrossingsOfPoros, 45, 3, 4, 2, 5)
                .WithTraits("Orc.", "Uruk.")
                .WithTextLine("When Revealed: Either place a random enemy from the set aside Mordor Orcs set into the encounter discard pile, or Uruk Prowler makes an immediate attack against the first player.")
                .WithShadow("Shadow: Discard a random card from your hand.")
                .WithInfo(148, 2, Artist.Guillaume_Ducos);
            addEnemy("Desert Warg", EncounterSet.TheCrossingsOfPoros, 34, 2, 5, 2, 3)
                .WithTraits("Creature.")
                .WithTextLine("When Revealed: Either place a random enemy from the set aside Desert Creatures set into the encounter discard pile, or Desert Warg gains surge.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithInfo(149, 2, Artist.Aurelien_Hubert);
            addLocation("Desolate Land", EncounterSet.TheCrossingsOfPoros, Card.VALUE_X, 4)
                .WithTraits("Desert.", "Hills.")
                .WithTextLine("X is the highest number of characters controlled by a single player.")
                .WithTextLine("Forced: After Desolate Land becomes the active location, choose 1 random card from the set aside encounter set with the most cards remaining. Reveal that card as if it was part of the encounter deck.")
                .WithEasyModeQuantity(1)
                .WithInfo(150, 3, Artist.Sergey_Glushakov);
            addLocation("Harondor Waste", EncounterSet.TheCrossingsOfPoros, 2, 3)
                .WithTraits("Desert.", "Hills.")
                .WithTextLine("Forced: After Harondor Waste becomes the active location, choose 1 random card from the set aside encounter set with the most cards remaining and place it in the encounter discard pile. Then, shuffle the encounter discard pile into the encounter deck.")
                .WithShadow("Shadow: Return the attacking enemy to the staging area after this attack.")
                .WithInfo(151, 4, Artist.Sergey_Glushakov);
            addTreachery("Danger Close Behind", EncounterSet.TheCrossingsOfPoros)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Choose 1 random card from the set aside encounter set with the most cards remaining, Reveal that card as if it was the top card of the encounter deck.")
                .WithShadow("Shadow: If this attack destroys a character, resolve the 'when revealed' effect of this card.")
                .WithEasyModeQuantity(1)
                .WithInfo(152, 2, Artist.Drazenka_Kimpel);
            addLocation("Foothills of Mordor", EncounterSet.MountainsOfShadow, 3, 3)
                .WithTraits("Hills.")
                .WithTextLine("While Foothills of Mordor is in the staging area, 'when revealed' effects cannot be canceled.")
                .WithTextLine("Forced: After Foothills of Mordor becomes the active location, raise each player's threat by 2.")
                .WithFlavorLine("...there lay dark thickets, and a tumbled land of rocky ghylls and crags, behind which the long grim slopes of the Ephel Dúath clambered up.")
                .WithFlavorLine("-The Return of the King")
                .WithEasyModeQuantity(2)
                .WithInfo(153, 3, Artist.Sergey_Glushakov);
            addLocation("Shadowy Vale", EncounterSet.MountainsOfShadow, 2, 5)
                .WithTraits("Hills.")
                .WithTextLine("While any player has threat of 35 or higher, Shadowy Vale gets +3 Threat.")
                .WithTextLine("Forced: After Shadowy Vale becomes the active location, reveal the top card of the encounter deck.")
                .WithFlavorLine("...nothing could waft away the glooms and the sad mists that clung about the Mountains of Shadow...")
                .WithFlavorLine("-The Return of the King")
                .WithEasyModeQuantity(1)
                .WithInfo(154, 2, Artist.Sergey_Glushakov);
            addTreachery("Mountains of Shadow", EncounterSet.MountainsOfShadow)
                .WithTextLine("When Revealed: Raise each player's threat by X, where X is the printed quest points of the active location. If there is no active location, Mountains of Shadow gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, raise your threat by 2.")
                .WithEasyModeQuantity(1)
                .WithInfo(155, 2, Artist.Kamila_Szutenberg);
            addEncounterSideQuest("Find a Way Down", EncounterSet.MountainsOfShadow, 6)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Each player's threat cannot be reduced.")
                .WithTextLine("Response: When Find a Way Down is defeated, each player reduces his threat by 3.")
                .WithFlavorLine("The path through the hills has led too far up, and now you walk along exposed heights where there's nowhere to hide. You need to find a way down.")
                .WithVictoryPoints(10)
                .WithInfo(156, 1, Artist.Carlos_Palma_Cruchaga);
            addQuest("Flight to Gondor", EncounterSet.TheCrossingsOfPoros, 1, 'A', Card.VALUE_NA)
                .WithTextLine("Setup: Set Poros Garrison and each of the following encounter sets aside, out of play: Mountains of Shadow, Desert Sands, Desert Creatures, Harad Soldiers, and Mordor Orcs. The first player adds The Black Serpent to the staging area and shuffles the encounter deck. Each other player reveals an encounter card.")
                .WithFlavorLine("You have escaped the dungeons of Cirith Gurat with the rescued members of Kahliel's tribe, but it's still a long way to Gondor.")
                .WithOppositeTextLine("Allies enter play exhausted.")
                .WithOppositeTextLine("Forced: At the end of the planning phase, advance to a random stage 2.")
                .WithOppositeFlavorLine("By now the Orcs will be searching for their escaped prisoners, and The Black Serpent will be seeking revenge against the outlaws who ambushed his caravan. You cannot hope to outrun your enemies with the exhausted refugees in your care, so you consult with Kahliel to decide the safest way north.")
                .WithIncludedEncounterSets(EncounterSet.MountainsOfShadow, EncounterSet.DesertSands, EncounterSet.DesertCreatures, EncounterSet.HaradSoldiers, EncounterSet.MordorOrcs)
                .WithInfo(157, 1, Artist.Alexander_Gustafson);
            addQuest("The Desert Path", EncounterSet.TheCrossingsOfPoros, 2, 'A', 10)
                .WithTextLine("When Revealed: Shuffle the Desert Sands encounter set into the encounter deck. Remove the Mountains of Shadow encounter set and the other stage 2A from the game.")
                .WithFlavorLine("You ask Kahliel which way you should take and he says: \"My people are weary. Climbing the rocky hills of the Ephel Dúath will be too difficult for them. We will journey to Gondor across the desert.\"")
                .WithOppositeTextLine("Forced: After a player plays an ally, he must either exhaust that ally or deal 1 damage to it.")
                .WithOppositeFlavorLine("You set out across the desert of Harondor, but it isn't long before the heat begins to take its toll.")
                .WithIncludedEncounterSets(EncounterSet.MountainsOfShadow, EncounterSet.DesertSands, EncounterSet.DesertCreatures, EncounterSet.HaradSoldiers, EncounterSet.MordorOrcs)
                .WithInfo(158, 1, Artist.Kamila_Szutenberg);
            addQuest("The Ephel Dúath", EncounterSet.TheCrossingsOfPoros, 2, 'A', 10)
                .WithTextLine("When Revealed: Shuffle the Mountains of Shadow encounter set into the encounter deck. Remove the Desert Sands encounter set and the other stage 2A from the game.")
                .WithFlavorLine("You ask Kahliel which way you should take and he says: \"The desert offers us no place to hide, and I fear my people cannot endure another desert crossing. We will take the rocky path through the hills to Gondor.\"")
                .WithOppositeTextLine("Forced: After a player plays an ally, he must exhaust that ally or raise his threat by 1.")
                .WithOppositeTextLine("Forced: When this stage is defeated, advance to a random stage 3.")
                .WithOppositeFlavorLine("As you travel along the edge of Mordor a feeling of unease sets in and you fear that you are being watched.")
                .WithIncludedEncounterSets(EncounterSet.MountainsOfShadow, EncounterSet.DesertSands, EncounterSet.DesertCreatures, EncounterSet.HaradSoldiers, EncounterSet.MordorOrcs)
                .WithInfo(159, 1, Artist.Sergey_Glushakov);
            addQuest("Deadly Creatures", EncounterSet.TheCrossingsOfPoros, 3, 'A', 15)
                .WithTextLine("When Revealed: Set each other stage 3A aside, out of play. Shuffle the encounter discard pile and the Desert Creatures encounter set into the encounter deck. Then, each player reveals an encounter card.")
                .WithFlavorLine("Orcs and Southrons are not the only things to fear in the wild; the wastes of Harondor are home to many deadly creatures.")
                .WithOppositeTextLine("Enemies in the staging area cannot take damage.")
                .WithOppositeTextLine("Forced: After an enemy engages a player, deal 1 damage to a hero that player controls.")
                .WithOppositeFlavorLine("Venomous animals strike at you when you stumble too close. Weary as you are from your long journey, it is difficult to see them before it's too late.")
                .WithIncludedEncounterSets(EncounterSet.MountainsOfShadow, EncounterSet.DesertSands, EncounterSet.DesertCreatures, EncounterSet.HaradSoldiers, EncounterSet.MordorOrcs)
                .WithInfo(160, 1, Artist.Dimitri_Bielak);
            addQuest("Southron Pursuit", EncounterSet.TheCrossingsOfPoros, 3, 'A', 15)
                .WithTextLine("When Revealed: Set each other stage 3A aside, out of play. Shuffle the discard pile and the Harad Soldiers encounter set into the encounter deck. Then, each player reveals an encounter card.")
                .WithFlavorLine("Driven by his desire for revenge, The Black Serpent has ordered his soldiers to scour all Harondor for your company.")
                .WithOppositeTextLine("Each enemy in the staging area gets -10 engagement cost.")
                .WithOppositeTextLine("Forced: After an enemy engages a player, remove 1 progress from this stage.")
                .WithOppositeFlavorLine("Slowed by the refugees in your care and hounded by the Serpent's outriders, you struggle to make progress towards Gondor.")
                .WithIncludedEncounterSets(EncounterSet.MountainsOfShadow, EncounterSet.DesertSands, EncounterSet.DesertCreatures, EncounterSet.HaradSoldiers, EncounterSet.MordorOrcs)
                .WithInfo(161, 1, Artist.S_C_Watson);
            addQuest("Orc Patrols", EncounterSet.TheCrossingsOfPoros, 3, 'A', 15)
                .WithTextLine("When Revealed: Set each other stage 3A aside, out of play. Shuffle the encounter discard pile and the Mordor Orcs encounter set into the encounter deck. Then, each player reveals an encounter card.")
                .WithFlavorLine("The Orcs of Cirith Gurat sent their swiftest Warg-riders to track you down after you escaped from their dungeons.")
                .WithOppositeTextLine("Orc Patrols gets +2 quest points for each enemy in the staging area.")
                .WithOppositeTextLine("Forced: After an enemy engages a player, raise that player's threat by 1.")
                .WithIncludedEncounterSets(EncounterSet.MountainsOfShadow, EncounterSet.DesertSands, EncounterSet.DesertCreatures, EncounterSet.HaradSoldiers, EncounterSet.MordorOrcs)
                .WithInfo(162, 1, Artist.Guillaume_Ducos);
            addQuest("Battle at the Crossings", EncounterSet.TheCrossingsOfPoros, 4, 'A', 20)
                .WithTextLine("When Revealed: The first player takes control of Poros Garrison. Search the encounter deck and discard pile for each enemy that belongs to an encounter set denoted by the first icon on each set aside stage 3 and add them to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("You've reached the Crossings of Poros, but the enemy is hot on your heels. Desperate, you blow a loud note on your horn. From the northern shore you hear horns answer, and the soldiers of Gondor rush to your aid.")
                .WithOppositeTextLine("Forced: After an enemy attacks and destroys a character, remove X progress from this stage. X is the attcking enemy's printed Threat.")
                .WithOppositeTextLine("This stage cannot be defeated except at the end of the combat phase. If the players defeat this stage, they win the game.")
                .WithOppositeFlavorLine("The Back Serpent leads your pursuers in a final, savage attack. You must hold the crossings against them or fail at the last leg of your journey.")
                .WithIncludedEncounterSets(EncounterSet.MountainsOfShadow, EncounterSet.DesertSands, EncounterSet.DesertCreatures, EncounterSet.HaradSoldiers, EncounterSet.MordorOrcs)
                .WithInfo(163, 1, Artist.Alexander_Gustafson);
        }
    }
}
