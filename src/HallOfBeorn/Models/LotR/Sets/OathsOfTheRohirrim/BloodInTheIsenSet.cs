//CardSet: Blood in the Isen
/* Generated CardSet class: Blood in the Isen */

using System;

namespace HallOfBeorn.Models.LotR.Sets.OathsOfTheRohirrim
{
    public class BloodInTheIsenSet
    {
        private const string setName = "Blood in the Isen";

        public static CardSet Create()
        {
            var cs = CardSet.Create(setName, "BitI", SetType.A_Long_extended_Party, Cycles.OathsOfTheRohirrim, 10007);

            cs.addHero("Gilraen", 9, Sphere.Spirit, 2, 1, 2, 3)
                .WithTraits("Dúnedain.", "Noble.")
                .WithTextLine("Setup: You may choose to give Gilraen –2 Willpower and up to 2 other Dúnedain heroes +2 Willpower until the end of the game.")
                .WithTextLine("Action: Turn a shadow card dealt to an enemy faceup. Then, you may deal that enemy 1 additional faceup shadow card to draw 1 card. (Limit once per phase.)")
                .WithFlavorLine("“I gave Hope to the Dúnedain, I have kept no hope for myself.”")
                .WithFlavorLine("—The Return of the King")
                .WithInfo(182, 1, Artist.Magali_Villeneuve);
            cs.addHero("Aragorn", 12, Sphere.Neutral, 2, 3, 2, 5)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithTextLine("Aragorn gains a resource icon matching each Title attachment attached to him.")
                .WithTextLine("Setup: Search your collection for a Title attachment with a printed cost of 1 and attach it to Aragorn.")
                .WithTextLine("Action: Ready a Title attachment with a printed cost of 1 attached to Aragorn. (Limit once per round.)")
                .WithInfo(183, 1, Artist.Jan_Pospisil);
            cs.addEvent("A Fair Exchange", 0, Sphere.Leadership)
                .WithTextLine("Action: Discard a unique card from your hand that shares a title with a card in play to search your deck for a different unique card and add it to your hand. Shuffle your deck.")
                .WithFlavorLine("“There is nothing like looking, if you want to find something…”")
                .WithFlavorLine("—Thorin Oakenshield, The Hobbit")
                .WithInfo(184, 3, Artist.Tim_Lochner);
            cs.addAttachment("Elessar", 1, Sphere.Leadership, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a Noble hero or Aragorn. Attached character gains the Gondor trait. If attached character is Aragorn, he gains the Noble trait.")
                .WithTextLine("Action: Exhaust Elessar to choose an ally that is defending an attack and shares a Trait with the attached character. Either ready that ally or give it +1 Defense for that attack.")
                .WithFlavorLine("“Say not The Lords of Gondor. Say The King Elessar.”")
                .WithFlavorLine("—Prince Imrahil, The Return of the King")
                .WithInfo(185, 3, Artist.Leone_Fabio);
            cs.addAttachment("The Renewer", 1, Sphere.Lore, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a Gondor hero or Aragorn. Attached character gains the Healer trait.")
                .WithTextLine("Action: Exhaust The Renewer to choose a questing ally that shares a Trait with the attached character. Either ready that ally and heal 1 damage from it or give it +1 Willpower until the end of the phase.")
                .WithFlavorLine("“The hands of the king are the hands of a healer.”")
                .WithFlavorLine("—Ioreth, The Return of the King")
                .WithInfo(186, 3, Artist.The_Brothers_Hildebrandt);
            cs.addAttachment("Elendilmir", 1, Sphere.Spirit, true)
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Guarded (location).")
                .WithTextLine("Guarded (location).")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Replace each instance of “once per phase” or “once per round” in the attached character’s text box with “twice per phase” or “twice per round” respectively.")
                .WithTextLine("Action: Exhaust Aragorn to discard the location guarding Elendilmir. Then, attach Elendilmir to Aragorn.")
                .WithInfo(187, 3, Artist.Chris_Stanford);
            cs.addAttachment("Estel", 1, Sphere.Spirit, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a Dúnedain hero or Aragorn. Attached character gains the Noldor trait.")
                .WithTextLine("Action: Exhaust Estel and discard 1 card from your hand to search the top X cards of your deck for 1 card and add it to your hand. Shuffle your deck. X is the number of Traits on the attached character.")
                .WithInfo(188, 3, Artist.Elaureanar);
            cs.addAttachment("Chieftain of the North", 1, Sphere.Tactics, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a Ranger hero or Aragorn. Attached character gains the Warrior trait.")
                .WithTextLine("Action: Exhaust Chieftain of the North to choose an attacking ally that shares a Trait with the attached character. Either ready that ally or give it +1 Attack for that attack.")
                .WithFlavorLine("“Here is Aragorn son of Arathorn, chieftain of the Dúnedain…”")
                .WithFlavorLine("—Faramir, The Return of the King")
                .WithInfo(189, 3, Artist.Wouter_Florusse);
            cs.addAlly("Grey Companion", 5, Sphere.Neutral, false, 1, 2, 3, 3)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Response: When you play Grey Companion from your hand, exhaust X Title attachments you control to reduce its cost by X.")
                .WithFlavorLine("“But I did not summon you,” said Aragorn, “save only in wish.”")
                .WithFlavorLine("—The Return of the King")
                .WithInfo(190, 3, Artist.Vladimir_Rikowski);
            cs.addAttachment("Andúril", 4, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero with 4 or more Traits.")
                .WithTextLine("Restricted. If attached hero is Aragorn, he gains a Leadership resource icon.")
                .WithTextLine("Attached hero gets +1 Willpower, +1 Attack, and +1 Defense.")
                .WithTextLine("Action: Exhaust Andúril to ready attached hero.")
                .WithFlavorLine("“You shall not be sheathed again until the last battle is fought.”")
                .WithFlavorLine("—Aragorn, The Return of the King")
                .WithInfo(191, 3, Artist.Torbjorn_Kallstrom);
            cs.addEnemy("Ealdwulf", EncounterSet.BloodInTheIsen, 50, 5, 5, 4, 8)
                .WithUnique()
                .WithTraits("Rohan.", "Noble.", "Traitor.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Ealdwulf gets +2 hit points for each resource token on him.")
                .WithTextLine("Forced: When a resource token would be removed from Hasty Pursuit, move it to Ealdwulf instead.")
                .WithVictoryPoints(15)
                .WithInfo(192, 1, Artist.Min_Gyu_Lee);
            cs.addObjective("Narrow Crossing", EncounterSet.BloodInTheIsen)
                .WithTraits("Fords.")
                .WithTextLine("Forced: At the end of the planning phase, the first player places 3 resource tokens on Narrow Crossing.")
                .WithTextLine("Forced: After resolving the above Forced effect, if the total printed cost of all cards you control is greater than the number of resource tokens here, raise your threat by the difference. (Each player must resolve this effect.)")
                .WithInfo(193, 1, Artist.Alan_Lee);
            cs.addObjective("Hasty Pursuit", EncounterSet.BloodInTheIsen)
                .WithTraits("Fords.")
                .WithTextLine("Forced: At the end of the planning phase, the first player removes 1 resource token from Hasty Pursuit.")
                .WithTextLine("Forced: After resolving the above Forced effect, if the total printed cost of all cards you control is greater than the number of resource tokens here, raise your threat by the difference. (Each player must resolve this effect.)")
                .WithInfo(193, 1, Artist.Zhihui_Su);
            cs.addEnemy("Grimrede", EncounterSet.BloodInTheIsen, 50, Card.VALUE_X, 5, 3, 6)
                .WithUnique()
                .WithTraits("Dunland.", "Raven Clan.")
                .WithTextLine("X is 1Per Player. Immune to player card effects. Each player’s threat cannot be reduced by more than 1 each round.")
                .WithTextLine("Forced: When any number of resource tokens would be placed on the Fords objective, reduce that number by 1 unless each player deals 1 damage to an undamaged character they control.")
                .WithVictoryPoints(5)
                .WithInfo(194, 1, Artist.Yama_Orce);
            cs.addLocation("West Bank", EncounterSet.BloodInTheIsen, 2, 6)
                .WithUnique()
                .WithTraits("Riverland.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Narrow Crossing cannot have more than 10 resource tokens on it.")
                .WithTextLine("Forced: At the end of the round, raise each player’s threat by 1.")
                .WithFlavorLine("“Go not to the Fords of Isen, and do not tarry in the plain!”")
                .WithFlavorLine("—Gandalf, The Two Towers")
                .WithVictoryPoints(1)
                .WithInfo(195, 1, Artist.Cyril_Tahmassebi);
            cs.addEnemy("Rohan Renegade", EncounterSet.BloodInTheIsen, 40, 2, 3, 2, 5)
                .WithTraits("Rohan.", "Traitor.")
                .WithTextLine("While a hero is defending against Rohan Renegade, that hero does not count its Defense.")
                .WithShadow("Shadow: After this attack, attacking enemy engages the next player, then makes an immediate attack.")
                .WithInfo(196, 3, Artist.Ufuk_Can);
            cs.addEnemy("Dunland Axe-hand", EncounterSet.BloodInTheIsen, 38, 2, 4, 3, 3)
                .WithTraits("Dunland.", "Raven Clan.")
                .WithTextLine("Forced: After Dunland Axe-hand engages you, either remove 1 resource token from the Fords objective, or deal 2 damage among characters you control.")
                .WithShadow("Shadow: Attacking enemy gets +3 Attack. You may discard X cards from your hand to reduce this amount by X.")
                .WithEasyModeQuantity(2)
                .WithInfo(197, 3, Artist.Barbara_Golebiewska);
            cs.addEnemy("Fleet-footed Dunlending", EncounterSet.BloodInTheIsen, 31, 2, 3, 1, 3)
                .WithTraits("Dunland.", "Wolf Clan.")
                .WithTextLine("Forced: After Fleet-footed Dunlending engages you, discard an attachment you control.")
                .WithShadow("Shadow: Discard the highest cost attachment attached to the defending character.")
                .WithEasyModeQuantity(2)
                .WithInfo(198, 4, Artist.Caglayan_Kaya_Goksoy);
            cs.addEnemy("Spurned Hillman", EncounterSet.BloodInTheIsen, 28, 1, 3, 1, 3)
                .WithTraits("Dunland.", "Boar Clan.")
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("Forced: After Spurned Hillman engages you, raise your threat by 1.")
                .WithFlavorLine("“Death to the Forgoil!”")
                .WithFlavorLine("—The Two Towers")
                .WithEasyModeQuantity(1)
                .WithInfo(199, 3, Artist.Bethesda_Softworks);
            cs.addLocation("Contested Battleground", EncounterSet.BloodInTheIsen, 3, 3)
                .WithTraits("Plains.", "Battleground.")
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("Forced: After Contested Battleground becomes the active location, either remove 1 resource token from the Fords objective, or the current quest gains battle until Contested Battleground leaves play.")
                .WithShadow("Shadow: After this attack, raise your threat by X, where X is the amount of damage dealt by this attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(200, 2, Artist.Serban_Gabriel);
            cs.addLocation("Defensive Outcrop", EncounterSet.BloodInTheIsen, 2, 4)
                .WithTraits("Hill.")
                .WithTextLine("Dunland enemies get +1 Defense. This ability does not stack with other copies of Defensive Outcrop.")
                .WithTextLine("While Defensive Outcrop is the active location, Dunland enemies get +1 Attack.")
                .WithShadow("Shadow: Until the end of the phase, when a character is declared as an attacker against this enemy, deal 1 damage to that character.")
                .WithEasyModeQuantity(1)
                .WithInfo(201, 3, Artist.Yohann_Schepacz);
            cs.addLocation("North-South Road", EncounterSet.BloodInTheIsen, 2, 4)
                .WithTraits("Road.")
                .WithTextLine("Travel: Each player deals 1 damage to a character they control.")
                .WithTextLine("Response: After North-South Road leaves play as an explored location, place 1 resource token on the Fords objective.")
                .WithFlavorLine("…the stream from above passed out, and the road beside it ran down…")
                .WithFlavorLine("—The Two Towers")
                .WithEasyModeQuantity(1)
                .WithInfo(202, 3, Artist.Benoit_Audibert);
            cs.addTreachery("Coordinated Assault", EncounterSet.BloodInTheIsen)
                .WithTextLine("When Revealed: The first player must choose 3 different things they control to discard: 1 resource, 1 ally, 1 character attachment, 1 enemy attachment, 1 location attachment, 1 player side quest in the staging area, or 1 random card from their hand.")
                .WithEasyModeQuantity(1)
                .WithInfo(203, 3, Artist.Daarken);
            cs.addTreachery("Heavy Losses", EncounterSet.BloodInTheIsen)
                .WithTextLine("When Revealed: Each player may discard any number of characters they control. Then, each player raises their threat by 1 for each damaged character they control. Each player that did not raise their threat this way must deal 1 damage to 3 different characters they control.")
                .WithEasyModeQuantity(2)
                .WithInfo(204, 3, Artist.Imperia_Online_JSC);
            cs.addTreachery("Open Rebellion", EncounterSet.BloodInTheIsen)
                .WithTextLine("When Revealed: The first player deals 1 damage to each hero they control with at least 1 resource in its pool, then raises their threat by 1 for each Noble hero damaged this way.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending character is Noble).")
                .WithEasyModeQuantity(1)
                .WithInfo(205, 2, Artist.Darek_Zabrocki);
            cs.addEncounterSideQuest("Chaos and Confusion", EncounterSet.BloodInTheIsen, 6)
                .WithTextLine("Forced: After engaging a Dunland enemy causes its Forced effect to trigger, resolve that Forced effect a second time. (Limit once per enemy per phase.)")
                .WithFlavorLine("The voices and the clink of weapons and harness were very close. Frodo and Sam loosened their small swords in their sheaths. Flight was impossible.")
                .WithFlavorLine("—The Two Towers")
                .WithVictoryPoints(10)
                .WithInfo(206, 1, Artist.Imad_Awan);
            cs.addQuest("Crossing the Fords", EncounterSet.BloodInTheIsen, 1, 'A', 0)
                .WithTextLine("Setup: Set Ealdwulf aside, out of play. Add the Fords objective to the staging area, Narrow Crossing side faceup. The first player adds Grimrede and West Bank to the staging area. Each other player searches the encounter deck for a different enemy and adds it to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("The traitor Ealdwulf has manipulated a host of Dunlendings and traitorous Rohirrim in a bid for the throne of Rohan. His armies have massed on the banks of the Isen where the Dunlendings prepare to ford.")
                .WithOppositeTextLine("Grimrede cannot be optionally engaged or take damage.")
                .WithOppositeTextLine("This stage cannot be defeated while West Bank is in play.")
                .WithOppositeFlavorLine("Ealdwulf must be stopped. Now is the time to cross the river and put an end to this foolhardy campaign, lest Rohan be drowned in blood.")
                .WithIncludedEncounterSets(EncounterSet.DunlendingWarriors)
                .WithInfo(207, 1, Artist.Wouter_Florusse);
            cs.addQuest("The Battle is Joined", EncounterSet.BloodInTheIsen, 2, 'A', 10)
                .WithTextLine("When Revealed: Shuffle the encounter discard pile into the encounter deck and discard cards until X enemies are discarded. X is 1 less than the number of players. Add each enemy discarded this way to the staging area.")
                .WithFlavorLine("As you wade into the river, your foes attempt to repel you with sling and spear. The Dunlending chieftain Grimrede shoulders his axe and steps before you, growling. “The land of green hills shall be ours again. It was taken from us by iron and flame. So will we reclaim it.”")
                .WithOppositeTextLine("Grimrede engages the first player. Enemies get –10 engagement cost and cannot be optionally engaged.")
                .WithOppositeTextLine("Narrow Crossing cannot have more than 15 resource tokens on it.")
                .WithOppositeTextLine("Grimrede cannot be defeated while this stage has any quest points remaining. This stage cannot be defeated unless Grimrede is in the victory display.")
                .WithIncludedEncounterSets(EncounterSet.DunlendingWarriors)
                .WithInfo(208, 1, Artist.James_Rinere);
            cs.addQuest("The Flight of Ealdwulf", EncounterSet.BloodInTheIsen, 3, 'A', 12)
                .WithTextLine("When Revealed: End the current phase. The first player adds Ealdwulf to the staging area. Each other player searches the encounter deck and discard pile for a copy of Rohan Renegade and engages it, if able. Shuffle the encounter deck. Flip Narrow Crossing over, keeping any resource tokens on it.")
                .WithFlavorLine("As the tide of battle turns, the traitor Ealdwulf wheels in retreat. The warlord rushes toward the wilderness, leaving his men to fight and die for their master’s hopeless crusade.")
                .WithOppositeTextLine("Ealdwulf cannot be optionally engaged while this stage has any quest points remaining.")
                .WithOppositeTextLine("Forced: After a player reduces their threat by any amount, that player must distribute an equal amount of damage among characters they control.")
                .WithOppositeTextLine("This stage cannot be defeated while Ealdwulf is in play. When Ealdwulf is defeated, the players have thwarted the traitor’s plot and win the game.")
                .WithOppositeFlavorLine("The traitor’s horse is fleet of foot, and battle spills across both banks of the river. Ealdwulf must be captured and brought before King Thengel to face justice.")
                .WithIncludedEncounterSets(EncounterSet.DunlendingWarriors)
                .WithInfo(209, 1, Artist.Marta_Nael);
            /*
            addGenConSetup("Back Card", EncounterSet.TheScouringOfTheShire)
                .WithTextLine("Credits")
                .WithTextLine("CEO & Game Design: SeastanArt: banania")
                .WithTextLine("COO & Software: A.R.Rules: alonewolf87")
                .WithTextLine("Playtesting: Shellin & The Purple WizardStorytelling: John Leo")
                .WithTextLine("Graphic Design & Printing: thaurdirEditing: Darkling Door")
                .WithTextLine("Lore: BobbymcbobfaceCommunity: Shellin")
                .WithTextLine("Scenario Design: Seastan & Shellin")
                .WithTextLine("Assistants: [DTP]Anzu, Admiral Polaris, ALeP Cron Bot, Annaeru, argonui, AstroSnail (Stephen), Baloosh, Barthadra, Beleg489, Ben or Break, Beorn, BeornBot, bgamerjoe, Brewer Bear, Brinx, Bullroarer Took, Bundeswill, CamMitchell, carlosm88, ceciltettledeer, Celia, Comtedelafere, cowZarific, croatoan, Cryoshark, d20woodworking, DavidJMartin, DEER PARK, deiseach, Dieter, Dimitri, divinityofnumber, doomguard, du, dwaynek, Edmund, EdY, Emilius, Emmental, Emreis, estel_edain, filgonfin, Franlag, fuzzyslippers, Glamcrist (JeffTheJeff), Gorthaur, granny.sheep, Great Glorfindel, GreenWizard, Greyjoy, Gu Xi, Helena, Ipswatch, Ira, JasonRed3, Jaywana, JoshuaK, KingDom, klarlack, kokatrix, Krakua, KYpatzer, LeeA, Levanthalas, Lively, Lorunks, madslaust, Mag, Makoshark13, Mazdaist, McDog3, migal, miklemas, Minoso, Mormegil, MrSpaceBear, MrThomnas, MurstonThor, nelloianiro, Nuls, oldoly, Onidsen, Pablo, Palantir Record Keeper, Pining For Fimbrethil, rduda, RegisF, Rimogard, RogueThirteen, rouxxor, Salted Pork, secondhandtook, Speder, Splice, tamhas, Taudir, Tegyrius, Thaimor, thanatopsis, The Purple Wizard, TheChap, thorsome, tlawrence, Trialus, TritonWreck, Truck, Tuhma, VeggieGollum, Verwegner (Jan), Vyntares, Watch-Captain Alain, Watcher in the Water, wlk, wolframius, xavdu92, xaviermutant, Xenon, ycarium, Zapier, Zarkanth, zoomboy")
                .WithTextLine("Special thanks to HeavyKaragh for his work on the Strange Eons plugin, RiddermarkLord for his work on the card templates, and Troy L for the ALeP logo and encounter set icon designs. We credit Marko Manev for the ALeP encounter card back art.")
                .WithOppositeTextLine("The traitor of Rohan rallies his armies on the banks of the Isen, and the Dunlendings crave battle against their ancestral enemies. If this invasion is successful, Ealdwulf will pitch the kingdom into bloody civil war. Now, clash with your foes upon the Fords of Isen and win the war for Rohan’s soul.")
                .WithInfo(999, 1, Artist.None);
            */

            return cs;
        }
    }
}
