/* Generated CardSet class: The Glittering Caves */

using System;

namespace HallOfBeorn.Models.LotR.Sets.OathsOfTheRohirrim
{
    public class TheGlitteringCavesSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Glittering Caves";
            Abbreviation = "TGC";
            Number = 10005;
            SetType = Models.SetType.A_Long_extended_Party;
            Cycle = "Oaths of the Rohirrim";

            addHero("Gaeronel", 8, Sphere.Leadership, 1, 1, 1, 4)
                .WithTraits("Noldor.", "Warrior.")
                .WithTextLine("While there is a top card of your discard pile,")
                .WithTextLine("Gaeronel gets +2 Willpower if it is an event;")
                .WithTextLine("Gaeronel gets +2 Attack if it is an ally;")
                .WithTextLine("Gaeronel gets +2 Defense if it is an attachment.")
                .WithFlavorLine("“I will dwell by the grey shores, guarding the Havens until the last ship sails.”")
                .WithFlavorLine("—Círdan, The Silmarillion")
                .WithInfo(101, 1, Artist.Melanie_Stanford);
            addHero("Glorfindel", 12, Sphere.Tactics, 3, 3, 1, 5)
                .WithTraits("Noldor.", "Noble.", "Warrior.")
                .WithTextLine("Glorfindel gets +2 Attack while attacking alone.")
                .WithTextLine("Glorfindel gets +2 Attack while attacking a unique enemy.")
                .WithFlavorLine("Then Glorfindel leapt forward upon him and his golden armour gleamed strangely in the moon…")
                .WithFlavorLine("—The Fall of Gondolin")
                .WithInfo(102, 1, Artist.Steven_Shan);
            addAlly("Harlond Lookout", 2, Sphere.Leadership, false, 1, 0, 0, 2)
                .WithTraits("Noldor.", "Scout.")
                .WithKeywords("Devoted.")
                .WithTextLine("Devoted.")
                .WithTextLine("Response: After Harlond Lookout is destroyed, ready a character you control.")
                .WithFlavorLine("The fleets passed out of the sight of the watchers in the havens, and their lights faded.")
                .WithFlavorLine("—The Silmarillion")
                .WithInfo(103, 3, Artist.Aleksander_Karcz);
            addAlly("Balin", 3, Sphere.Leadership, true, 2, 0, 2, 3)
                .WithTraits("Dwarf.")
                .WithKeywords("Devoted.")
                .WithTextLine("Devoted.")
                .WithTextLine("Response: After a card is discarded from the top of your deck, ready Balin. (Limit once per round.)")
                .WithFlavorLine("The others made no pretense of offering – except old Balin.")
                .WithFlavorLine("—The Hobbit")
                .WithInfo(104, 3, Artist.Daniel_Zrom);
            addEvent("Salvaged Supplies", 0, Sphere.Leadership)
                .WithTraits("Item.")
                .WithTextLine("Response: At the end of the refresh phase, if none of your heroes gained any resources from player card effects this round, add 1 resource to the pool of a hero you control.")
                .WithTextLine("Action: Exhaust a character you control to return Salvaged Supplies from your discard pile to your hand.")
                .WithInfo(105, 3, Artist.Kieran_Yanner);
            addEvent("Lay of the Nauglamír", 5, Sphere.Lore)
                .WithTraits("Noldor.", "Dwarf.", "Song.")
                .WithKeywords("Devoted.")
                .WithTextLine("Devoted.")
                .WithTextLine("Action: Discard the top 10 cards of your deck. Choose up to 2 different Noldor or Dwarf allies discarded by this effect and put them into play. Each chosen ally must have a printed cost of 2 or less. You may shuffle any number of the other cards discarded by this effect back into your deck. Remove Lay of the Nauglamír from the game.")
                .WithInfo(106, 3, Artist.Steamey);
            addAlly("Wandering Spirit", 0, Sphere.Spirit, false, 0, 0, 0, 0)
                .WithTraits("Noldor.", "Spirit.")
                .WithTextLine("Cannot enter play.")
                .WithTextLine("Action: If Wandering Spirit is in your discard pile, move it up or down by 1 or 2 cards. Then, if it is next to a Noldor ally with a printed cost of 2 or less, you may spend 1 Spirit resource and remove Wandering Spirit from the game to put that ally into play. (Limit once per round.)")
                .WithInfo(107, 3, Artist.Julian_Bauer);
            addAttachment("Relic of Nargothrond", 1, Sphere.Tactics, false)
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Noldor or Dwarf character. Restricted. Limit 1 per character. Relic of Nargothrond can be played from your discard pile.")
                .WithTextLine("Attached character gets +1 Defense.")
                .WithTextLine("Action: Discard Relic of Nargothrond to give attached character +2 Defense until the end of the phase.")
                .WithFlavorLine("In that labour Finrod was aided by the Dwarves of the Blue Mountains.")
                .WithFlavorLine("—The Silmarillion")
                .WithInfo(108, 3, Artist.Katerina_Poliakova);
            addAttachment("Onward Into Battle", 2, Sphere.Tactics, false)
                .WithTraits("Skill.")
                .WithTextLine("Attach to a Warrior hero.")
                .WithTextLine("Encounter Action: Exhaust Onward Into Battle to ready attached hero.")
                .WithFlavorLine("“…and though we still hold that a warrior should have more skills and knowledge than only the craft of weapons and slaying, we esteem a warrior, nonetheless, above men of other crafts. Such is the need of our days.”")
                .WithFlavorLine("—Faramir, The Two Towers")
                .WithInfo(109, 3, Artist.Rob_Joseph);
            addAttachment("Legacy of Gondolin", 1, Sphere.Neutral, false)
                .WithTraits("Song.")
                .WithTextLine("Attach to a Noldor hero you control. Limit 1 per hero.")
                .WithTextLine("You cannot play allies or attachments from your hand unless you have 2 or fewer cards in your hand.")
                .WithTextLine("Action: Exhaust Legacy of Gondolin to either draw 1 card or discard Legacy of Gondolin.")
                .WithInfo(110, 3, Artist.Ted_Nasmith);
            addObjective("Helm's Horn", EncounterSet.TheGlitteringCaves)
                .WithUnique()
                .WithTextLine("Player tokens cannot move.")
                .WithTextLine("When Revealed: Shuffle the encounter discard pile into the encounter deck. If Helm Hammerhand is not at the undamaged cave, move him there. Then, flip Helm Hammerhand over.")
                .WithFlavorLine("One night men heard the horn blowing, but Helm did not return.")
                .WithFlavorLine("—The Return of the King")
                .WithInfo(111, 1, Artist.Bogna_Gawronska);
            addEnemy("Helm Hammerhand", EncounterSet.TheGlitteringCaves, 50, 2, 7, 2, 10)
                .WithSideA()
                .WithSlugSuffix("A")
                .WithUnique()
                .WithTraits("Rohan.", "Wraith.", "Stalking.")
                .WithTextLine("Immune to player card effects. Cannot be engaged.")
                .WithTextLine("Forced: At the end of the combat phase, move Helm Hammerhand 1 adjacent cave toward the nearest player, if able. Then, he makes an immediate attack against each player at his cave. Players at other caves cannot use sentinel characters to defend these attacks.")
                .WithInfo(112, 1, Artist.Leanna_Crossan);
            addEnemy("Helm Hammerhand", EncounterSet.TheGlitteringCaves, 50, 2, 7, 2, 10)
                .WithSideB()
                .WithSlugSuffix("B")
                .WithUnique()
                .WithTraits("Rohan.", "Wraith.", "Summoned.")
                .WithTextLine("Immune to player card effects. Cannot leave the staging area (except by being destroyed) but is considered to be engaged with each player. Deal Helm Hammerhand an additional shadow card when he attacks.")
                .WithTextLine("Forced: When Helm Hammerhand is dealt a Dunland enemy as a shadow card, cancel its shadow effect (if any) and deal Helm Hammerhand another shadow card.")
                .WithVictoryPoints(10)
                .WithInfo(112, 1, Artist.Leanna_Crossan);
            addEnemy("Lurking Ghûl", EncounterSet.TheGlitteringCaves, 40, 2, 4, 3, 2)
                .WithTraits("Creature.")
                .WithTextLine("While in the staging area, Lurking Ghûl gains: “Forced: After a player moves, Lurking Ghûl makes an immediate attack from the staging area against that player. (Limit once per round.)”")
                .WithFlavorLine("“Begone, foul dwimmerlaik, lord of carrion! Leave the dead in peace!”")
                .WithFlavorLine("—Éowyn, The Return of the King")
                .WithEasyModeQuantity(1)
                .WithInfo(113, 2, Artist.Maciej_Laszkiewicz);
            addLocation("Small Stream", EncounterSet.TheGlitteringCaves, 3, 3)
                .WithTraits("Underground.", "River.")
                .WithTextLine("Travel: Each player must discard a card at random from their hand to travel here.")
                .WithTextLine("Travel Action: If this card is in the victory display, a player at a Stream cave may remove this card from the game to move to an adjacent cave.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If you did not move this round, deal it another shadow card.")
                .WithVictoryPoints(1)
                .WithInfo(114, 3, Artist.Dinesh_Kumar);
            addLocation("Wonders of Aglarond", EncounterSet.TheGlitteringCaves, 3, 4)
                .WithTraits("Underground.")
                .WithTextLine("Forced: After Wonders of Aglarond leaves play, place 4 progress on any cave without a player token and reveal an encounter card.")
                .WithShadow("Shadow: Either move Helm Hammerhand 1 adjacent cave toward the nearest player, or raise the defending player's threat by 2.")
                .WithEasyModeQuantity(1)
                .WithInfo(115, 2, Artist.Ted_Nasmith);
            addLocation("Alluring Paths", EncounterSet.TheGlitteringCaves, 2, 3)
                .WithTraits("Underground.")
                .WithTextLine("When faced with the option to travel, the players must travel to Alluring Paths if there is no active location.")
                .WithTextLine("Forced: After Alluring Paths leaves play, if Helm Hammerhand is at a player's cave, move him to the next player's cave.")
                .WithShadow("Shadow: If you did not move this round, attacking enemy makes an additional attack against you after this one.")
                .WithInfo(116, 2, Artist.Paul_Lasaine);
            addTreachery("Guard the Entrance!", EncounterSet.TheGlitteringCaves)
                .WithTextLine("When Revealed: Each player raises their threat by X, where X is the number of caves connected to their cave.")
                .WithShadow("Shadow: Discard a resource from each of your heroes' pools.")
                .WithEasyModeQuantity(1)
                .WithInfo(117, 2, Artist.Rene_Aigner);
            addEnemy("Forgotten Shade", EncounterSet.SearchForTheHorn, 45, 4, 4, 3, 4)
                .WithSlugSuffix("Fork")
                .WithCaveDirection("Fork")
                .WithTraits("Undead.", "Wraith.")
                .WithTextLine("While making engagement checks against a player that has not moved this round, Forgotten Shade gets –30 engagement cost.")
                .WithTextLine("While engaged with a player that has not moved this round, Forgotten Shade cannot take damage.")
                .WithInfo(118, 1, Artist.Bethesda_Softworks);
            addEnemy("Forgotten Shade", EncounterSet.SearchForTheHorn, 45, 4, 4, 3, 4)
                .WithSlugSuffix("Dead-End")
                .WithCaveDirection("Dead End")
                .WithTraits("Undead.", "Wraith.")
                .WithTextLine("While making engagement checks against a player that has not moved this round, Forgotten Shade gets –30 engagement cost.")
                .WithTextLine("While engaged with a player that has not moved this round, Forgotten Shade cannot take damage.")
                .WithInfo(119, 1, Artist.Bethesda_Softworks);
            addEnemy("Forgotten Shade", EncounterSet.SearchForTheHorn, 45, 4, 4, 3, 4)
                .WithSlugSuffix("Tunnel")
                .WithCaveDirection("Tunnel")
                .WithTraits("Undead.", "Wraith.")
                .WithTextLine("While making engagement checks against a player that has not moved this round, Forgotten Shade gets –30 engagement cost.")
                .WithTextLine("While engaged with a player that has not moved this round, Forgotten Shade cannot take damage.")
                .WithInfo(120, 1, Artist.Bethesda_Softworks);
            addLocation("Radiant Caverns", EncounterSet.SearchForTheHorn, 5, 1)
                .WithSlugSuffix("Jewelled-Cavern")
                .WithCaveDirection("Jewelled Cavern")
                .WithTraits("Underground.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Forced: After Radiant Caverns is explored, deal it facedown as a shadow card to Helm Hammerhand.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each shadow card dealt to it. If this attack destroys a character, raise your threat by 2.")
                .WithInfo(121, 1, Artist.Ted_Nasmith);
            addLocation("Radiant Caverns", EncounterSet.SearchForTheHorn, 5, 1)
                .WithSlugSuffix("Vast-Cave")
                .WithCaveDirection("Vast Cave")
                .WithTraits("Underground.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Forced: After Radiant Caverns is explored, deal it facedown as a shadow card to Helm Hammerhand.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each shadow card dealt to it. If this attack destroys a character, raise your threat by 2.")
                .WithInfo(122, 1, Artist.Ted_Nasmith);
            addLocation("Radiant Caverns", EncounterSet.SearchForTheHorn, 5, 1)
                .WithSlugSuffix("Crossroads")
                .WithCaveDirection("Crossroads")
                .WithTraits("Underground.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Forced: After Radiant Caverns is explored, deal it facedown as a shadow card to Helm Hammerhand.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each shadow card dealt to it. If this attack destroys a character, raise your threat by 2.")
                .WithInfo(123, 1, Artist.Ted_Nasmith);
            addTreachery("Killing With Fear", EncounterSet.SearchForTheHorn)
                .WithSlugSuffix("Guarded-Hall")
                .WithCaveDirection("Guarded Hall")
                .WithTextLine("When Revealed: Each player that is 1 or fewer adjacent caves away from Helm Hammerhand deals 1 damage to each exhausted character they control and each Dunland enemy engaged with them. Move Helm Hammerhand 1 adjacent cave toward the nearest player.")
                .WithInfo(124, 1, Artist.WB_Games);
            addTreachery("Killing With Fear", EncounterSet.SearchForTheHorn)
                .WithSlugSuffix("Stairwell")
                .WithCaveDirection("Stairwell")
                .WithTextLine("When Revealed: Each player that is 1 or fewer adjacent caves away from Helm Hammerhand deals 1 damage to each exhausted character they control and each Dunland enemy engaged with them. Move Helm Hammerhand 1 adjacent cave toward the nearest player.")
                .WithInfo(125, 1, Artist.WB_Games);
            addTreachery("Killing With Fear", EncounterSet.SearchForTheHorn)
                .WithSlugSuffix("Cave-Opening")
                .WithCaveDirection("Cave Opening")
                .WithTextLine("When Revealed: Each player that is 1 or fewer adjacent caves away from Helm Hammerhand deals 1 damage to each exhausted character they control and each Dunland enemy engaged with them. Move Helm Hammerhand 1 adjacent cave toward the nearest player.")
                .WithInfo(126, 1, Artist.WB_Games);
            addTreachery("Echoes in the Deep", EncounterSet.SearchForTheHorn)
                .WithSlugSuffix("Dark-Pit")
                .WithCaveDirection("Dark Pit")
                .WithTextLine("When Revealed: Move Helm Hammerhand 1 adjacent cave toward the nearest player, if able. Then, Helm Hammerhand makes an immediate attack against the player at his cave with the highest threat. If no attack is made this way, Echoes in the Deep gains surge.")
                .WithInfo(127, 1, Artist.Calvin_Streeting);
            addTreachery("Echoes in the Deep", EncounterSet.SearchForTheHorn)
                .WithSlugSuffix("Secret-Passage")
                .WithCaveDirection("Secret Passage")
                .WithTextLine("When Revealed: Move Helm Hammerhand 1 adjacent cave toward the nearest player, if able. Then, Helm Hammerhand makes an immediate attack against the player at his cave with the highest threat. If no attack is made this way, Echoes in the Deep gains surge.")
                .WithInfo(128, 1, Artist.Calvin_Streeting);
            addTreachery("Twisting Paths", EncounterSet.SearchForTheHorn)
                .WithCaveDirection("Locked Door")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Attach faceup to a cave in play. Counts as an attachment with the text: “Travel Action: A player at the attached cave may discard Twisting Paths to swap the attached cave (along with its tokens and attachments) with an adjacent cave.”")
                .WithShadow("Shadow: Resolve this card's “when revealed” effect.")
                .WithInfo(129, 1, Artist.Calvin_Streeting);
            addCave("Fork", EncounterSet.ExploringTheCaves)
                .WithTextLine("Forced: After you move to this cave, discard cards from the top of the encounter deck until an enemy is discarded. Engage that enemy.")
                .WithTextLine("Travel Action: Discard the ally or attachment you control with the highest printed cost to search this cave.")
                .WithInfo(130, 1, Artist.Calvin_Streeting);
            addCave("Dead End", EncounterSet.ExploringTheCaves)
                .WithTextLine("While you are at this cave, you cannot draw cards and your heroes cannot gain resources.")
                .WithTextLine("Travel Action: Remove all events in your hand and discard pile from the game to search this cave.")
                .WithInfo(131, 1, Artist.Calvin_Streeting);
            addCave("Tunnel", EncounterSet.ExploringTheCaves)
                .WithTraits("Stream.")
                .WithTextLine("Forced: After you move to this cave, discard characters you control until you control 6 or fewer characters.")
                .WithTextLine("Travel Action: Exhaust each ready character you control to search this cave.")
                .WithInfo(132, 1, Artist.Calvin_Streeting);
            addCave("Jewelled Cavern", EncounterSet.ExploringTheCaves)
                .WithTraits("Stream.")
                .WithTextLine("While you are at this cave, cards you play cost 1 additional matching resource.")
                .WithTextLine("Travel Action: Discard all resources from each of your heroes' pools to search this cave.")
                .WithInfo(133, 1, Artist.Calvin_Streeting);
            addCave("Vast Cave", EncounterSet.ExploringTheCaves)
                .WithTraits("Stream.")
                .WithTextLine("Characters at this cave cannot be readied by player card effects.")
                .WithTextLine("Travel Action: Remove 8 progress tokens from this cave to search this cave.")
                .WithInfo(134, 1, Artist.Calvin_Streeting);
            addCave("Crossroads", EncounterSet.ExploringTheCaves)
                .WithTraits("Stream.")
                .WithTextLine("Forced: After you move to this cave, raise your threat by 3.")
                .WithTextLine("Travel Action: Raise your threat by 3 to search this cave.")
                .WithInfo(135, 1, Artist.Calvin_Streeting);
            addCave("Dark Pit", EncounterSet.ExploringTheCaves)
                .WithTextLine("Characters at this cave get –1 Attack and –1 Defense and are removed from the game when they leave play.")
                .WithTextLine("Travel Action: Reveal an encounter card to search this cave.")
                .WithInfo(136, 1, Artist.Calvin_Streeting);
            addCave("Locked Door", EncounterSet.ExploringTheCaves)
                .WithTextLine("Forced: After you move to this cave, exhaust 2 characters you control.")
                .WithTextLine("Travel Action: Name a card type and sphere and discard a card at random from your hand. If the discarded card has the named type and sphere, search this cave.")
                .WithInfo(137, 1, Artist.Calvin_Streeting);
            addCave("Secret Passage", EncounterSet.ExploringTheCaves)
                .WithTextLine("Forced: After you move to this cave, choose a treachery in the discard pile and reveal it.")
                .WithTextLine("Travel Action: Remove 6 progress tokens from this cave to either search this cave or move directly to a cave up to 2 adjacent caves away.")
                .WithInfo(138, 1, Artist.Calvin_Streeting);
            addCave("Guarded Hall", EncounterSet.ExploringTheCaves)
                .WithTextLine("While you are at this cave, enemies engaged with you are dealt an additional shadow card when they attack.")
                .WithTextLine("Travel Action: Engage the topmost enemy in the encounter discard pile to search this cave.")
                .WithInfo(139, 1, Artist.Calvin_Streeting);
            addCave("Stairwell", EncounterSet.ExploringTheCaves)
                .WithTextLine("Forced: After you move to this cave, discard attachments you control until no character you control has more than 2 attachments.")
                .WithTextLine("Travel Action: Discard 1 attachment from each character you control with an attachment, if able. Then, search this cave.")
                .WithInfo(140, 1, Artist.Calvin_Streeting);
            addCave("Cave Opening", EncounterSet.ExploringTheCaves)
                .WithTextLine("Forced: After you move to this cave, discard an ally or attachment you control with a printed cost of 2 or more.")
                .WithTextLine("Travel Action: Raise your threat by 1 for each clue in play to search this cave.")
                .WithInfo(141, 1, Artist.Calvin_Streeting);
            addQuest("Search the Caves", EncounterSet.TheGlitteringCaves, 1, 'A', Card.VALUE_NA)
                .WithTextLine("When Revealed: Set Helm's Horn aside, out of play. Add Helm Hammerhand to the staging area, Stalking side faceup. Set up the Caves Map and Clues (see insert).")
                .WithFlavorLine("Fleeing the violent blizzard, you are pursued by the wraith of Helm Hammerhand. He follows inexorably, seeking to claim the bones of your Dunlending captives. You must navigate the caverns below Helm's Deep to find Helm's great warhorn. Sounding it may be your only hope of restoring the wraith's mind.")
                .WithOppositeTextLine("Progress that would be placed here is instead distributed among caves that contain player tokens.")
                .WithOppositeTextLine("Travel Action: Any player may remove 4 progress tokens from their current cave to move to a connected cave. There is no limit to the number of times a player may trigger this effect.")
                .WithOppositeTextLine("When there is exactly 1 undamaged cave remaining, immediately advance to stage 2.")
                .WithIncludedEncounterSets(EncounterSet.DunlendingWarriors, EncounterSet.SearchForTheHorn)
                .WithInfo(142, 1, Artist.Jon_Hodgson);
            addQuest("The Horn's Discovery", EncounterSet.TheGlitteringCaves, 2, 'A', Card.VALUE_NA)
                .WithTextLine("When Revealed: Attach Helm's Horn facedown as a clue to the remaining undamaged cave.")
                .WithFlavorLine("Yet men said that the horn was still heard at times in the Deep and the wraith of Helm would walk among the foes of Rohan and kill men with fear.")
                .WithFlavorLine("—The Return of the King")
                .WithOppositeTextLine("All players must be at the undamaged cave before a player can search that cave. Progress that would be placed here is instead distributed among any caves in play (even those without player tokens).")
                .WithOppositeTextLine("Travel Action: Any player may remove 4 progress tokens from their current cave to move to a connected cave. There is no limit to the number of times a player may trigger this effect.")
                .WithOppositeTextLine("When Helm Hammerhand is defeated, the players win the game.")
                .WithIncludedEncounterSets(EncounterSet.DunlendingWarriors, EncounterSet.SearchForTheHorn)
                .WithInfo(143, 1, Artist.R_Adrian_Z);           /*
            addGenConSetup("Back Card", EncounterSet.TheScouringOfTheShire)
                .WithTextLine("Credits")
                .WithTextLine("CEO & Game Design: Seastan Art: banania")
                .WithTextLine("COO & Software: A.R. Rules: alonewolf87")
                .WithTextLine("Playtesting & Community: Shellin Storytelling: John Leo")
                .WithTextLine("Graphic Design & Printing: thaurdir Editing: Darkling Door")
                .WithTextLine("Lore: Bobbymcbobface")
                .WithTextLine("Scenario Design: Seastan")
                .WithTextLine("Assistants: [DTP]Anzu, Admiral Polaris, ALeP Cron Bot, Annaeru, argonui, AstroSnail (Stephen), Baloosh, Barthadra, Beleg489, Beorn, BeornBot, bgamerjoe, Brewer Bear, Brinx, Bullroarer Took, Bundeswill, CamMitchell, carlosm88, ceciltettledeer, Celia, Comtedelafere, croatoan, Cryoshark, d20woodworking, DavidJMartin, deiseach, Dieter, Dimitri, divinityofnumber, doomguard, du, dwaynek, Edmund, EdY, Emilius, Emmental, Emreis, estel_edain, filgonfin, Franlag, fuzzyslippers, Glamcrist (JeffTheJeff), Gorthaur, granny.sheep, Great Glorfindel, GreenWizard, Greyjoy, Helena Real, Ira, JasonRed3, Jaywana, JoshuaK, KingDom, kokatrix, KYpatzer, LeeA, Levanthalas, Lively, Lorunks, Mag, Magus, Makoshark13, Mazdaist, McDog3, Minoso, Mormegil, MrSpaceBear, MrThomnas, MurstonThor, nelloianiro, Nesnaj, Nuls, oldoly, Onidsen, Palantir Record Keeper, Pawlo, Pining For Fimbrethil, rduda, RegisF, Rimogard, RogueThirteen, Salted Pork, secondhandtook, Speder, Splice, Stavo343, tamhas, Taudir, Tegyrius, Thaimor, thanatopsis, The Purple Wizard, TheChap, thorsome, tlawrence, Trialus, TritonWreck, Truck, Tuhma, VeggieGollum, Verwegner (Jan), Watch-Captain Alain, Watcher in the Water, wlk, wolframius, xavdu92, xaviermutant, Xenon, ycarium, Zapier, zoomboy")
                .WithTextLine("Special thanks to HeavyKaragh for his work on the Strange Eons plugin, RiddermarkLord for his work on the card templates, and Troy L for the ALeP logo and encounter set icon designs. We credit Marko Manev for the ALeP encounter card back art.")
                .WithOppositeTextLine("In your pursuit of the traitor, you have stumbled into a supernatural blizzard, at the heart of which stalks the wraith of Helm Hammerhand, a fallen king of Rohan. Cursed to bloodlust and undeath, he has stalked you to the shelter of the Glittering Caves beneath his old fortress. Here you must make your way to safety, your steps hounded at each turn by the peril of a monstrous king.")
                .WithInfo(999, 1, Artist.None);
             * */
        }
    }
}
