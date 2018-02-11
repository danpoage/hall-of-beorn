using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.Haradrim
{
    public class TheCrossingsOfPoros : CardSet
    {
        private const string setNameCrossings = "The Crossings of Poros";
        private const string setNameMountains = "Mountains of Shadow";

        protected override void Initialize()
        {
            Name = setNameCrossings;
            Abbreviation = "CoP";
            Number = 48;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            addCard(LotRCard.Hero("Quickbeam", string.Empty, Sphere.Tactics, 12, 2, 4, 1, 5)
                .WithText("Cannot have restricted attachments.\r\nAction: Deal 2 damage to Quickbeam to ready him. (Limit once per phase.)")
                .WithFlavor("\"...he can move like a wind when he is roused.\"\r\n-Pippin, The Two Towers")
                .WithInfo(135, 1, Artist.Guillaume_Ducos));
            addCard(LotRCard.Ally("Halfast Gamgee", Sphere.Leadership, 3, 2, 1, 0, 2)
                .WithUnique()
                .WithTraits("Hobbit.")
                .WithText("Reduce the cost to play Halfast Gamgee by 1 for each side quest in the victory display.\r\nResponse: After Halfast Gamgee enters play, add 1 resource to a hero's resource pool.")
                .WithFlavor("\"He works for Mr. Boffin at Overhill and goes up to the Northfarthing for the hunting.\"\r\n-Sam Gamgee, The Fellowship of the Ring")
                .WithInfo(136, 3, Artist.Stanislav_Dikolenko));
            addCard(LotRCard.Event("Bulwark of the West", string.Empty, Sphere.Leadership, 0)
                .WithText("Action: Discard an ally you control to choose and discard a Condition attachment.")
                .WithFlavor("\"By our valour the wildfolk of the East are still restrained, and the terror of Morgul kept at bay; and thus alone are peace and freedom maintained in the lads behind us...\r\n-Boromir, The Fellowship of the Ring")
                .WithInfo(137, 3, Artist.Stanislav_Dikolenko));
            addCard(LotRCard.Ally("Beorning Guardian", Sphere.Tactics, 3, 0, 3, 1, 3)
                .WithTraits("Beorning.")
                .WithText("Response: After ~Beorning ~Guardian participates in an attack that destroys an enemy, discard ~Beorning ~Guardian to place X progress on a location, where X is the destroyed enemy's printed Threat.")
                .WithFlavor("\"...if it were not for the Beornings, the passage from Dale to Rivendell would long ago have become impossible.\"\r\n-Glóin, The Fellowship of the Ring")
                .WithInfo(138, 3, Artist.Marius_Bota));
            addCard(LotRCard.Attachment("Followed", string.Empty, Sphere.Tactics, 1)
                .WithTraits("Condition.", "Trap.")
                .WithText("Play into your play area unattached.\r\nWhile unattached, attach to the next eligible enemy that engages you.\r\nWhile attached enemy is engaged with you, reduce the total Threat in the staging area by X, where X is attached enemy's printed Threat.")
                .WithInfo(139, 3, Artist.Unknown));
            addCard(LotRCard.Event("Flight to the Sea", string.Empty, Sphere.Spirit, 2)
                .WithText("Play only if you control a Noldor or Silvan hero.\r\nPlanning Action: Shuffle a set aside ~Wind from the ~Sea into the encounter deck. Then, remove Flight to the Sea from the game.")
                .WithFlavor("\"...they may pass to the Sea unhindered and leave the Middle-earth forever.\"\r\n-Haldir, The Two Towers")
                .WithInfo(140, 3, Artist.Alexander_Gustafson));
            addCard(LotRCard.Ally("Emyn Arnen Ranger", Sphere.Lore, 2, 0, 1, 1, 2)
                .WithTraits("Gondor.", "Ranger.")
                .WithText("Response: After Emyn Arnen ~Ranger commits to the quest, choose an enemy with a Trap attachment. Until the end of the phase, Emyn Arnen ~Ranger gets +X Willpower, where X is the chosen enemy's printed Threat.")
                .WithInfo(141, 3, Artist.Aleksander_Karcz));
            addCard(LotRCard.Event("The Dam Bursts", string.Empty, Sphere.Lore, 2)
                .WithText("Play only if you control a unique character with the Ent trait and another unique character with the Hobbit trait.\r\nAction: Ready each damaged Ent character you control.")
                .WithInfo(142, 3, Artist.DinoDrawing));
            addCard(LotRCard.Attachment("Magic Ring", string.Empty, Sphere.Neutral, 2)
                .WithTraits("Artifact.", "Item.", "Ring.")
                .WithText("Attach to a hero. Limit 1 per hero and 1 per deck.\r\nAction: Exhaust Magic ~Ring and raise your threat by 1 to (choose 1): heal 1 damage from attached hero, add 1 resource to attached hero's pool, or ready attached hero.")
                .WithFlavor("\"In Eregion long ago many Elven-rings were made, magic rings as you call them, and they were, of course, of various kinds...\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(143, 3, Artist.Lucas_Durham));
            addCard(LotRCard.Event("Wind from the Sea", string.Empty, Sphere.Neutral, byte.MaxValue)
                .WithKeywords("Encounter.")
                .WithText("When Revealed: Ready each hero committed to the quest and remove Wind from the Sea from the game.")
                .WithShadow("Shadow: Ready the defending character.")
                .WithInfo(144, 3, Artist.Davis_Engel));
            addObjectiveAlly("Poros Garrison", setNameCrossings, 3, 4, 3, 6)
                .WithUnique().WithTraits("Gondor.")
                .WithText("The first player gains control of Poros Garrison.\r\nImmune to player card effects.\r\nYou can optionally engage an additional enemy during the encounter phase.\r\nIf Poros Garrison leaves play, the players lose the game.")
                .WithInfo(145, 1, Artist.S_C_Watson);
            addEnemy("The Black Serpent", setNameCrossings, 50, 0, 2, 1, 8)
                .WithUnique().WithTraits("Harad.")
                .WithText("Cannot leave the staging area or take damage. X is the stage number of the main quest.\r\nThe Black Serpent gets +X Threat, +X Attack and +X Defense.\r\nForced: At the end of the encounter phase, either remove X progress from the main quest, or The Black Serpent makes an attack against the first player.")
                .WithInfo(146, 1, Artist.Alexandr_Elichev);
            addEnemy("Southron Outrider", setNameCrossings, 28, 2, 3, 1, 4)
                .WithTraits("Harad.")
                .WithText("Forced: After Southron Outrider engages you, either place a random enemy from the set aside Harad Soldiers set into the encounter discard pile, or Southron Outrider gets +3 Attack this round.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithInfo(147, 2, Artist.Carlos_Palma_Cruchaga);
            addEnemy("Uruk Prowler", setNameCrossings, 45, 3, 4, 2, 5)
                .WithTraits("Orc.", "Uruk.")
                .WithText("When Revealed: Either place a random enemy from the set aside Mordor Orcs set into the encounter discard pile, or Uruk Prowler makes an immediate attack against the first player.")
                .WithShadow("Shadow: Discard a random card from your hand.")
                .WithInfo(148, 2, Artist.Guillaume_Ducos);
            addEnemy("Desert Warg", setNameCrossings, 34, 2, 5, 2, 3)
                .WithTraits("Creature.")
                .WithText("When Revealed: Either place a random enemy from the set aside Desert Creatures set into the encounter discard pile, or Desert Warg gains surge.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithInfo(149, 2, Artist.Aurelien_Hubert);
            addLocation("Desolate Land", setNameCrossings, 254, 4)
                .WithTraits("Desert.", "Hills.")
                .WithText("X is the highest number of characters controlled by a single player.\r\nForced: After Desolate Land becomes the active location, choose 1 random card from the set aside encounter set with the most cards remaining. Reveal that card as if it was part of the encounter deck.")
                .WithEasyModeQuantity(1)
                .WithInfo(150, 3, Artist.DinoDrawing);
            addLocation("Harondor Waste", setNameCrossings, 2, 3)
                .WithTraits("Desert.", "Hills.")
                .WithText("Forced: After Harondor Waste becomes the active location, choose 1 random card from the set aside encounter set with the most cards remaining and place it in the encounter discard pile. Then, shuffle the encounter discard pile into the encounter deck.")
                .WithShadow("Shadow: Return the attacking enemy to the staging area after this attack.")
                .WithInfo(151, 4, Artist.DinoDrawing);
            addTreachery("Danger Close Behind", setNameCrossings)
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Choose 1 random card from the set aside encounter set with the most cards remaining, Reveal that card as if it was the top card of the encounter deck.")
                .WithShadow("Shadow: If this attack destroys a character, resolve the 'when revealed' effect of this card.")
                .WithEasyModeQuantity(1)
                .WithInfo(152, 2, Artist.Drazenka_Kimpel);
            addLocation("Foothills of Mordor", setNameMountains, 3, 3)
                .WithTraits("Hills.")
                .WithText("While Foothills of Mordor is in the staging area, 'when revealed' effects cannot be canceled.\r\nForced: After Foothills of Mordor becomes the active location, raise each player's threat by 2.")
                .WithFlavor("...there lay dark thickets, and a tumbled land of rocky ghylls and crags, behind which the long grim slopes of the Ephel Dúath clambered up.\r\n-The Return of the King")
                .WithEasyModeQuantity(2)
                .WithInfo(153, 3, Artist.DinoDrawing);
            addLocation("Shadowy Vale", setNameMountains, 2, 5)
                .WithTraits("Hills.")
                .WithText("While any player has threat of 35 or higher, Shadowy Vale gets +3 Threat.\r\nForced: After Shadowy Vale becomes the active location, reveal the top card of the encounter deck.")
                .WithFlavor("...nothing could waft away the glooms and the sad mists that clung about the Mountains of Shadow...\r\n-The Return of the King")
                .WithEasyModeQuantity(1)
                .WithInfo(154, 2, Artist.DinoDrawing);
            addTreachery("Mountains of Shadow", setNameMountains)
                .WithText("When Revealed: Raise each player's threat by X, where X is the printed quest points of the active location. If there is no active location, Mountains of Shadow gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, raise your threat by 2.")
                .WithEasyModeQuantity(1)
                .WithInfo(155, 2, Artist.Kamila_Tzutenberg);
            addEncounterSideQuest("Find a Way Down", setNameMountains, 6)
                .WithFlavor("The path through the hills has led too far up, and now you walk along exposed heights where there's nowhere to hide. You need to find a way down.")
                .WithKeywords("Surge.")
                .WithText("Each player's threat cannot be reduced.\r\nResponse: When Find a Way Down is defeated, each player reduces his threat by 3.")
                .WithVictoryPoints(10)
                .WithInfo(156, 1, Artist.Carlos_Palma_Cruchaga);
            addQuest("Flight to Gondor", setNameCrossings, 1, 'A', 255)
                .WithFlavor("You have escaped the dungeons of Cirith Gurat with the rescued members of Kahliel's tribe, but it's still a long way to Gondor.")
                .WithText("Setup: Set Poros Garrison and each of the following encounter sets aside, out of play: Mountains of Shadow, Desert Sands, Desert Creatures, Harad Soldiers, and Mordor Orcs. The first player adds The Black Serpent to the staging area and shuffles the encounter deck. Each other player reveals an encounter card.")
                .WithOppositeFlavor("By now the Orcs will be seatching for their escaped prisoners, and The Black Serpent will be seeking revenge against the outlaws who ambushed his caravan. You cannot hope to outrun your enemies with the exhausted refugees in your care, so you consult with Kahliel to decide the safest way north.")
                .WithOppositeText("Allies enter play exhausted.\r\nForced: At the end of the planning phase, advance to a random stage 2.")
                .WithIncludedEncounterSets(EncounterSet.MountainsOfShadow, EncounterSet.DesertSands, EncounterSet.DesertCreatures, EncounterSet.HaradSoldiers, EncounterSet.MordorOrcs)
                .WithInfo(157, 1, Artist.Alexander_Gustafson);
            addQuest("The Desert Path", setNameCrossings, 2, 'A', 10)
                .WithFlavor("You ask Kahliel which way you should take and he says: \"My people are weary. Climbing the rocky hills of the Ephel Dúath will be too difficult for them. We will journey to Gondor across the desert.\"")
                .WithText("When Revealed: Shuffle the Desert Sands encounter set into the encounter deck. Remove the Mountains of Shadow encounter set and the other stage 2A from the game.")
                .WithOppositeFlavor("You set out across the desert of Harondor, but it isn't long before the heat begins to take its toll.")
                .WithOppositeText("Forced: After a player plays an ally, he must either exhaust that ally or deal 1 damage to it.")
                .WithIncludedEncounterSets(EncounterSet.MountainsOfShadow, EncounterSet.DesertSands, EncounterSet.DesertCreatures, EncounterSet.HaradSoldiers, EncounterSet.MordorOrcs)
                .WithInfo(158, 1, Artist.Kamila_Tzutenberg);
            addQuest("The Ephel Dúath", setNameCrossings, 2, 'A', 10)
                .WithFlavor("You ask Kahliel which way you should take and he says: \"The desert offers us no place to hide, and I fear my people cannot endure another desert crossing. We will take the rocky path through the hills to Gondor.\"")
                .WithText("When Revealed: Shuffle the Mountains of Shadow encounter set into the encounter deck. Remove the Desert Sands encounter set and the other stage 2A from the game.")
                .WithOppositeFlavor("As you travel along the edge of Mordor a feeling of unease sets in and you fear that you are being watched.")
                .WithOppositeText("Forced: After a player plays an ally, he must exhaust that ally or raise his threat by 1.\r\nForced: When this stage is defeated, advance to a random stage 3.")
                .WithIncludedEncounterSets(EncounterSet.MountainsOfShadow, EncounterSet.DesertSands, EncounterSet.DesertCreatures, EncounterSet.HaradSoldiers, EncounterSet.MordorOrcs)
                .WithInfo(159, 1, Artist.DinoDrawing);
            addQuest("Deadly Creatures", setNameCrossings, 3, 'A', 15)
                .WithFlavor("Orcs and Southrons are not the only things to fear in the wild; the wastes of Harondor are home to many deadly creatures.")
                .WithText("When Revealed: Set each other stage 3A aside, out of play. Shuffle the encounter discard pile and the Desert Creatures encounter set into the encounter deck. Then, each player reveals an encounter card.")
                .WithOppositeFlavor("Venomous animals strike at you when you stumble too close. Weary as you are from your long journey, it is difficult to see them before it's too late.")
                .WithOppositeText("Enemies in the staging area cannot take damage.\r\nForced: After an enemy engages a player, deal 1 damage to a hero that player controls.")
                .WithIncludedEncounterSets(EncounterSet.MountainsOfShadow, EncounterSet.DesertSands, EncounterSet.DesertCreatures, EncounterSet.HaradSoldiers, EncounterSet.MordorOrcs)
                .WithInfo(160, 1, Artist.Dimitri_Bielak);
            addQuest("Southron Pursuit", setNameCrossings, 3, 'A', 15)
                .WithFlavor("Driven by his desire for revenge, The Black Serpent has ordered his soldiers to scour all Harondor for your company.")
                .WithText("When Revealed: Set each other stage 3A aside, out of play. Shuffle the discard pile and the Harad Soldiers encounter set into the encounter deck. Then, each player reveals an encounter card.")
                .WithOppositeFlavor("Slowed by the refugees in your care and hounded by the Serpent's outriders, you struggle to make progress towards Gondor.")
                .WithOppositeText("Each enemy in the staging area gets -10 engagement cost.\r\nForced: After an enemy engages a player, remove 1 progress from this stage.")
                .WithIncludedEncounterSets(EncounterSet.MountainsOfShadow, EncounterSet.DesertSands, EncounterSet.DesertCreatures, EncounterSet.HaradSoldiers, EncounterSet.MordorOrcs)
                .WithInfo(161, 1, Artist.S_C_Watson);
            addQuest("Orc Patrols", setNameCrossings, 3, 'A', 15)
                .WithFlavor("The Orcs of Cirith Gurat sent their swiftest Warg-riders to track you down after you escaped from their dungeons.")
                .WithText("When Revealed: Set each other stage 3A aside, out of play. Shuffle the encounter discard pile and the Mordor Orcs encounter set into the encounter deck. Then, each player reveals an encounter card.")
                .WithOppositeText("Orc Patrols gets +2 quest points for each enemy in the staging area.\r\nForced: After an enemy engages a player, raise that player's threat by 1.")
                .WithIncludedEncounterSets(EncounterSet.MountainsOfShadow, EncounterSet.DesertSands, EncounterSet.DesertCreatures, EncounterSet.HaradSoldiers, EncounterSet.MordorOrcs)
                .WithInfo(162, 1, Artist.Guillaume_Ducos);
            addQuest("Battle at the Crossings", setNameCrossings, 4, 'A', 20)
                .WithFlavor("You've reached the Crossings of Poros, but the enemy is hot on your heels. Desperate, you blow a loud note on your horn. From the northern shore you hear horns answer, and the soldiers of Gondor rush to your aid.")
                .WithText("When Revealed: The first player takes control of Poros Garrison. Search the encounter deck and discard pile for each enemy that belongs to an encounter set denoted by the first icon on each set aside stage 3 and add them to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("The Back Serpent leads your pursuers in a final, savage attack. You must hold the crossings against them or fail at the last leg of your journey.")
                .WithOppositeText("Forced: After an enemy attacks and destroys a character, remove X progress from this stage. X is the attcking enemy's printed Threat.\r\nThis stage cannot be defeated except at the end of the combat phase. If the players defeat this stage, they win the game.")
                .WithIncludedEncounterSets(EncounterSet.MountainsOfShadow, EncounterSet.DesertSands, EncounterSet.DesertCreatures, EncounterSet.HaradSoldiers, EncounterSet.MordorOrcs)
                .WithInfo(163, 1, Artist.Alexander_Gustafson);
        }
    }
}