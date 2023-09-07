//CardSet: The Siege of Erebor
/* Generated CardSet class: The Siege of Erebor */

using System;

namespace HallOfBeorn.Models.LotR.Sets.TheSiegeOfErebor
{
    public class TheSiegeOfEreborSet : CardSet
    {
        private const string setName = "The Siege of Erebor";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TSoE";
            Number = 10009;
            SetType = Models.SetType.A_Long_extended_Party;

            addQuest("The Siege of Erebor", EncounterSet.TheSiegeOfErebor, 1, 'A', Card.VALUE_NA)
                .WithTextLine("Setup: Create 4 “stages” from right (east) to left (west), and create a staging area in each. Assign the main quest cards 2A, 3A, 4A, and 5A to the stages from east to west, in that order (so that The Eastern Defenses is assigned to the eastmost stage). Resolve the “when revealed” effects on quest cards 2A, 3A, 4A, and 5A, in that order, and then turn them over. Then, turn this card over.")
                .WithOppositeTextLine("When Revealed: Reveal 1 PerPlayer encounter cards. Then, remove this card from the game.")
                .WithOppositeFlavorLine("“When you think of the great Battle of the Pelennor, do not forget the battles in Dale and the valour of Durin’s Folk. Think of what might have been. Dragon-fire and savage swords in Eriador! There might be no Queen in Gondor.” —Gandalf, The Return of the King")
                .WithInfo(1, 1, Artist.Midjourney);
            addQuest("The Eastern Defenses", EncounterSet.TheSiegeOfErebor, 2, 'A', Card.VALUE_NA)
                .WithTextLine("When Revealed: Put Hold the North and Eastern Assault (Normal side faceup) into play in their own area, outside of the 4 stages. If you are playing in easy mode, flip Eastern Assault to its Easy side.")
                .WithFlavorLine("At the same time as the great armies besieged Minas Tirith…")
                .WithOppositeTextLine("Response: After the players quest successfully at this stage, each player at this stage may draw 1 card.")
                .WithOppositeTextLine("Forced: After The Eastern Defenses is added to the victory display, reveal 2 encounter cards.")
                .WithOppositeFlavorLine("A great pallisade protects the verdant farmlands to the east.")
                .WithInfo(2, 1, Artist.Midjourney);
            addQuest("The Riverlands", EncounterSet.TheSiegeOfErebor, 3, 'A', Card.VALUE_NA)
                .WithTextLine("When Revealed: Make 1 copy of The Desolation of Smaug this stage’s active location.")
                .WithFlavorLine("…a host of the allies of Sauron that had long threatened the borders of King Brand crossed the River Carnen…")
                .WithOppositeTextLine("Response: After the players quest successfully at this stage, choose a main quest and heal 1 damage from it.")
                .WithOppositeTextLine("Forced: After The Riverlands is added to the victory display, each player in the game discards the ally they control with the highest printed cost.")
                .WithOppositeFlavorLine("Many settlements dot the shores of the Celduin River and its tributaries.")
                .WithInfo(3, 1, Artist.Midjourney);
            addQuest("Dale", EncounterSet.TheSiegeOfErebor, 4, 'A', Card.VALUE_NA)
                .WithTextLine("When Revealed: If there is only 1 player in the game, add 1 Iron Hills Reinforcements to this stage’s staging area. If there are 4 players in the game, add 1 City Walls to this stage’s staging area.")
                .WithFlavorLine("…and Brand was driven back to Dale. There he had the aid of the Dwarves of Erebor; and there was a great battle at the Mountain’s feet…")
                .WithOppositeTextLine("During the quest phase, characters at this stage get +1 Attack.")
                .WithOppositeTextLine("Response: After the players quest successfully at this stage, either deal 4 damage to an enemy at this stage, or deal 2 damage to an enemy at any stage.")
                .WithOppositeTextLine("Forced: After Dale is added to the victory display, each player in the game discards 1 hero they control. Until the end of the game, heroes cannot be healed or leave a player’s discard pile.")
                .WithOppositeFlavorLine("The great city of Dale rests at the foot of the Lonely Mountain.")
                .WithInfo(4, 1, Artist.Midjourney);
            addQuest("Erebor", EncounterSet.TheSiegeOfErebor, 5, 'A', Card.VALUE_NA)
                .WithTextLine("When Revealed: Set Gate of Erebor aside, out of play. If there are 1 or 2 players in the game, add 1 Iron Hills Reinforcements to this stage’s staging area. Remove all remaining copies of Iron Hills Reinforcements in the encounter deck from the game and shuffle the encounter deck.")
                .WithFlavorLine("…and many, both Dwarves and Men, took refuge in Erebor, and there withstood a siege. —The Return of the King")
                .WithOppositeTextLine("During the quest phase, characters at this stage get +1 Defense.")
                .WithOppositeTextLine("Response: After the players quest successfully at this stage, add Gate of Erebor to this stage’s staging area.")
                .WithOppositeTextLine("Forced: When Erebor is abandoned, the players lose the game.")
                .WithOppositeFlavorLine("The Dwarvish stronghold of Erebor lies deep within the mountain.")
                .WithInfo(5, 1, Artist.Midjourney);
            addObjective("Hold the North", EncounterSet.TheSiegeOfErebor)
                .WithTextLine("Forced: After resolving the end of the round step at all of the stages, deal damage to each stage’s main quest (from west to east) equal to the number of enemies in that stage’s staging area. Then, deal 2 damage to the eastmost stage’s main quest and place 1 progress token here.")
                .WithTextLine("If there are at least 8 progress tokens here and fewer enemies in play than remaining stages, the players win the game.")
                .WithInfo(6, 1, Artist.Midjourney);
            addObjective("Eastern Assault", EncounterSet.TheSiegeOfErebor)
                .WithTraits("Normal.")
                .WithTextLine("Instead of each stage revealing cards during the staging step, the first player reveals 1+1 PerPlayer encounter cards.")
                .WithTextLine("If a main quest has at least 8+1 PerPlayer damage on it, abandon it.")
                .WithTextLine("Forced: After a card effect is canceled by a player at any stage, deal 1 damage to the eastmost stage’s main quest.")
                .WithSideA()
                .WithSlugSuffix("Normal")
                .WithInfo(7, 1, Artist.Midjourney);
            addObjective("Eastern Assault", EncounterSet.TheSiegeOfErebor)
                .WithTraits("Easy.")
                .WithTextLine("Instead of each stage revealing cards during the staging step, the first player reveals 1+1 PerPlayer encounter cards.")
                .WithTextLine("If a main quest has at least 10+1 PerPlayer damage on it, abandon it.")
                .WithSlugSuffix("Easy")
                .WithSideB()
                .WithInfo(7, 1, Artist.Midjourney);
            addObjective("Iron Hills Reinforcements", EncounterSet.TheSiegeOfErebor)
                .WithTraits("Dwarf.")
                .WithTextLine("Iron Hills Reinforcements readies at the beginning of the refresh phase.")
                .WithTextLine("Action: Exhaust Iron Hills Reinforcements to (choose 1): place 2 progress on a location at this stage, heal 1 damage from the main quest, or move Iron Hills Reinforcements east or west. Any player at any stage can trigger this effect.")
                .WithInfo(8, 2, Artist.Midjourney);
            addObjective("Gate of Erebor", EncounterSet.TheSiegeOfErebor)
                .WithTextLine("Response: After an enemy enters this stage’s staging area, deal 1 damage to that enemy.")
                .WithTextLine("Response: When X damage would be dealt to Erebor, deal X damage to 1 hero you control instead. Any player at this stage may trigger this effect.")
                .WithFlavorLine("In the end both King Brand and King Dáin Ironfoot were slain, and the Easterlings had the victory. But they could not take the Gate…")
                .WithFlavorLine("—The Return of the King")
                .WithInfo(9, 1, Artist.Midjourney);
            addEnemy("Dale Besieger", EncounterSet.TheSiegeOfErebor, 40, 3, 7, 2, 6)
                .WithUnique()
                .WithTraits("Besieger.")
                .WithKeywords("Toughness 2.")
                .WithTextLine("Toughness 2.")
                .WithTextLine("Forced: At the end of the round, deal 1 damage to the main quest.")
                .WithTextLine("Response: When Dale Besieger is destroyed, remove it from the game and heal 1 damage from the main quest of the stage it was at.")
                .WithInfo(10, 1, Artist.Midjourney);
            addEnemy("Erebor Besieger", EncounterSet.TheSiegeOfErebor, 40, 3, 7, 2, 6)
                .WithUnique()
                .WithTraits("Besieger.")
                .WithKeywords("Toughness 2.")
                .WithTextLine("Toughness 2.")
                .WithTextLine("Forced: At the end of the round, deal 1 damage to the main quest.")
                .WithTextLine("Response: When Erebor Besieger is destroyed, remove it from the game and heal 1 damage from the main quest of the stage it was at.")
                .WithInfo(11, 1, Artist.Midjourney);
            addEnemy("Rhûn Vanguard", EncounterSet.TheSiegeOfErebor, 30, 2, 3, 3, 3)
                .WithTraits("Easterling.")
                .WithTextLine("While in a staging area, Rhûn Vanguard gains: “Forced: After an enemy with a name other than Rhûn Vanguard enters this stage’s staging area, Rhûn Vanguard moves west.”")
                .WithShadow("Shadow: Either engage Rhûn Vanguard or add it to the eastmost staging area.")
                .WithInfo(12, 4, Artist.Midjourney);
            addEnemy("Wainriders", EncounterSet.TheSiegeOfErebor, 42, 2, 5, 2, 4)
                .WithTraits("Easterling.")
                .WithTextLine("Forced: After Wainriders enters a staging area, deal 1 damage to the main quest.")
                .WithTextLine("Forced: At the end of the round, if Wainriders is in a staging area, it moves west.")
                .WithInfo(13, 4, Artist.Midjourney);
            addEnemy("Rhûn Rearguard", EncounterSet.TheSiegeOfErebor, 48, Card.VALUE_X, Card.VALUE_X, Card.VALUE_X, 5)
                .WithTraits("Easterling.")
                .WithTextLine("X is the stage number of the main quest.")
                .WithFlavorLine("…the Easterlings were strong and war-hardened and asked for no quarter.")
                .WithFlavorLine("—The Return of the King")
                .WithInfo(14, 4, Artist.Midjourney);
            addEnemy("Balchoth Avenger", EncounterSet.TheSiegeOfErebor, 29, 3, 4, 2, 5)
                .WithTraits("Easterling.")
                .WithTextLine("Forced: After Balchoth Avenger attacks and damages a character you control, choose 1: Balchoth Avenger moves west, or deal 4 damage to 1 hero you control.")
                .WithFlavorLine("…between Mirkwood and the River Running, a fierce people now dwelt, wholly under the shadow of Dol Guldur.")
                .WithFlavorLine("—The Return of the King")
                .WithInfo(15, 3, Artist.Midjourney);
            addEnemy("Easterling Archer", EncounterSet.TheSiegeOfErebor, 25, 3, 3, 1, 4)
                .WithTraits("Easterling.")
                .WithKeywords("Archery X.")
                .WithTextLine("Archery X. (Must be assigned to characters at this stage.)")
                .WithTextLine("X is the stage number of the main quest.")
                .WithShadow("Shadow: Deal X damage among characters you control. X is the stage number of the main quest.")
                .WithInfo(16, 3, Artist.Midjourney);
            addLocation("Esgaroth", EncounterSet.TheSiegeOfErebor, 2, 5)
                .WithUnique()
                .WithTraits("City.", "River.")
                .WithTextLine("Travel: Reveal 1 encounter card.")
                .WithTextLine("Response: After Esgaroth is explored as the active location, add it to the victory display. Then, The Riverlands cannot take damage until the beginning of the next round.")
                .WithFlavorLine("Every vessel in the town was filled with water, every warrior was armed, every arrow and dart was ready…")
                .WithFlavorLine("—The Hobbit")
                .WithInfo(17, 1, Artist.Midjourney);
            addLocation("Ravenhill", EncounterSet.TheSiegeOfErebor, 4, 5)
                .WithUnique()
                .WithTraits("Erebor.", "Mountain.")
                .WithTextLine("Travel: Reveal 1 encounter card.")
                .WithTextLine("Response: When Ravenhill is explored as the active location, add it to the victory display. Then, heal 1 damage from each main quest.")
                .WithShadow("Shadow: Choose a main quest and heal 1 damage from it.")
                .WithInfo(18, 1, Artist.Midjourney);
            addLocation("City Walls", EncounterSet.TheSiegeOfErebor, 2, 3)
                .WithTraits("Dale.", "City.")
                .WithTextLine("Forced: At the end of the round, deal 1 damage to City Walls. Then, if City Walls has 3 damage on it, discard it and deal 2 damage to Dale.")
                .WithShadow("Shadow: Either deal 1 damage to the main quest or the attacking enemy gets +2 Attack.")
                .WithInfo(19, 3, Artist.Midjourney);
            addLocation("Easterling Supply Camp", EncounterSet.TheSiegeOfErebor, 3, 4)
                .WithTraits("Plains.")
                .WithTextLine("Forced: At the end of the round, deal 1 damage to The Eastern Defenses.")
                .WithTextLine("Response: After Easterling Supply Camp is explored, heal 2 damage from The Eastern Defenses.")
                .WithFlavorLine("Eärnil stormed the camp and set fire to the wains, and drove the enemy in a great rout…")
                .WithFlavorLine("—The Return of the King")
                .WithInfo(20, 3, Artist.Midjourney);
            addLocation("The River Running", EncounterSet.TheSiegeOfErebor, 3, 3)
                .WithTraits("River.")
                .WithTextLine("When Revealed: Deal 1 damage to The Riverlands. Deal it 1 additional damage for each other copy of The River Running in The Riverlands’ staging area.")
                .WithTextLine("Travel: Discard 1 random card from the hand of each player at this stage.")
                .WithShadow("Shadow: Deal 1 damage to the eastmost main quest.")
                .WithInfo(21, 3, Artist.Midjourney);
            addLocation("Eaves of Mirkwood", EncounterSet.TheSiegeOfErebor, 4, 2)
                .WithTraits("Forest.")
                .WithTextLine("Travel: Choose a main quest and deal 1 damage to it.")
                .WithTextLine("Forced: After Eaves of Mirkwood leaves play from the staging area, deal 2 damage among main quests in play.")
                .WithFlavorLine("…they could see the forest coming as it were to meet them, or waiting for them like a black and frowning wall…")
                .WithFlavorLine("—The Hobbit")
                .WithInfo(22, 2, Artist.Midjourney);
            addLocation("The Desolation of Smaug", EncounterSet.TheSiegeOfErebor, 4, 4)
                .WithTraits("Wasteland.")
                .WithTextLine("Forced: After another location enters this stage’s staging area, deal 1 damage to The Riverlands. A player at this stage may discard an ally they control to cancel this effect.")
                .WithShadow("Shadow: Deal 1 damage to either the defending character or the main quest.")
                .WithInfo(23, 2, Artist.Midjourney);
            addLocation("City Gates", EncounterSet.TheSiegeOfErebor, 5, 3)
                .WithTraits("Dale.", "City.")
                .WithTextLine("Response: After City Gates is explored, 1 player at this stage may spend 1 resource to place 1 resource token on Dale. The next time Dale would take damage, remove that resource token to decrease the damage dealt to Dale by 1.")
                .WithFlavorLine("A deep boom rumbled through the City like thunder running in the clouds. But the doors of iron and posts of steel withstood the stroke.")
                .WithFlavorLine("—The Return of the King")
                .WithInfo(24, 2, Artist.Midjourney);
            addLocation("City Streets", EncounterSet.TheSiegeOfErebor, 3, 2)
                .WithTraits("Dale.", "City.")
                .WithTextLine("When Revealed: Deal 1 damage to Dale.")
                .WithShadow("Shadow: Defending character uses its Attack instead of its Defense for this attack.")
                .WithInfo(25, 2, Artist.Midjourney);
            addLocation("Treasure Hoard", EncounterSet.TheSiegeOfErebor, 4, 5)
                .WithTraits("Erebor.", "Underground.")
                .WithTextLine("Response: When Treasure Hoard is explored as the active location, attach it to Erebor. Counts as an attachment with the text: “Response: After questing successfully at this stage, each player at this stage adds 2 resources to the pool of 1 hero they control.”")
                .WithShadow("Shadow: Add 2 resources to the pool of a hero you control.")
                .WithInfo(26, 1, Artist.Midjourney);
            addLocation("Lonely Mountain Armoury", EncounterSet.TheSiegeOfErebor, 4, 5)
                .WithTraits("Erebor.", "Underground.")
                .WithTextLine("Response: When Lonely Mountain Armoury is explored as the active location, attach it to Erebor. Counts as an attachment with the text: “During the combat phase, characters at this stage get +1 Attack and +1 Defense.”")
                .WithShadow("Shadow: Deal 2 damage to the attacking enemy.")
                .WithInfo(27, 1, Artist.Midjourney);
            addTreachery("Flanked!", EncounterSet.TheSiegeOfErebor)
                .WithTextLine("When Revealed: Discard cards from the encounter deck until an enemy is discarded. Add that enemy to either Erebor’s staging area or Dale’s staging area.")
                .WithShadow("Shadow: After this attack, the attacking enemy either moves west or makes an additional attack against you.")
                .WithInfo(28, 3, Artist.Midjourney);
            addTreachery("The North Burns", EncounterSet.TheSiegeOfErebor)
                .WithTextLine("When Revealed: Deal 3 damage among main quests in play (spread as evenly as possible). At least 1 damage must be assigned to the eastmost main quest. This effect cannot be canceled.")
                .WithShadow("Shadow: Deal 1 damage to the main quest. This effect cannot be canceled.")
                .WithInfo(29, 2, Artist.Midjourney);
            addTreachery("Driven by the Eye", EncounterSet.TheSiegeOfErebor)
                .WithTextLine("When Revealed: Discard cards from the encounter deck until an enemy is discarded. Reveal that enemy. Then, starting with the westmost quest stage, the enemy in each staging area with the lowest engagement cost moves west.")
                .WithShadow("Shadow: If there are no enemies in the eastmost staging area, reveal an encounter card.")
                .WithInfo(30, 2, Artist.Midjourney);
            addTreachery("Fight or Flight", EncounterSet.TheSiegeOfErebor)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Each player in the game must choose: either deal 1 damage to each exhausted character you control, or deal 1 damage to your stage’s main quest.")
                .WithInfo(31, 2, Artist.Midjourney);
            addTreachery("Focused Onslaught", EncounterSet.TheSiegeOfErebor)
                .WithTextLine("While attached to a quest, counts as a Condition attachment with the text: “Forced: At the end of the round, deal 1 damage to the attached quest.”")
                .WithTextLine("When Revealed: Attach Focused Onslaught to the eastmost main quest without a copy of Focused Onslaught attached.")
                .WithShadow("Shadow: Resolve this card’s “when revealed” effect.")
                .WithInfo(32, 2, Artist.Midjourney);
            addTreachery("News from the South", EncounterSet.TheSiegeOfErebor)
                .WithTextLine("When Revealed: If Erebor is the only main quest in play, all enemies in play get –2 Attack and –2 Defense until the end of the round. Otherwise, News from the South gains doomed 2 and surge.")
                .WithFlavorLine("When news came of the great victories in the South, then Sauron’s northern army was filled with dismay; and the besieged came forth and routed them…")
                .WithFlavorLine("—The Return of the King")
                .WithInfo(33, 2, Artist.Midjourney);
            addHero("Brand son of Bain", 10, Sphere.Tactics, 2, 3, 2, 3)
                .WithTraits("Dale.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged. Response: After Brand son of Bain attacks and defeats an enemy engaged with another player, choose and ready one of that player’s characters.")
                .WithInfo(72, 1, Artist.Surya_Prasetya);
            addHero("Brand son of Bain", 10, Sphere.Tactics, 2, 3, 2, 3)
                .WithTraits("Dale.", "Noble.", "Warrior.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged. Response: After Brand son of Bain attacks and destroys an enemy engaged with a player, ready one of that player’s characters. (Limit once per phase.)")
                .WithSlugSuffix("Noble")
                .WithInfo(72, 1, Artist.Surya_Prasetya);
            addHero("Dáin Ironfoot", 11, Sphere.Spirit, 1, 2, 3, 5)
                .WithTraits("Dwarf.", "Noble.", "Warrior.")
                .WithTextLine("While Dáin Ironfoot is defending, he gains: “Action: Discard the top card of your deck to give Dáin Ironfoot +1 Defense for this attack. (Limit 3 times per phase.)”")
                .WithInfo(84, 1, Artist.Surya_Prasetya);
            /*
            addGenConSetup("Back Card", EncounterSet.TheScouringOfTheShire)
                .WithTextLine("Credits")
                .WithTextLine("CEO & Game Design: SeastanArt: banania")
                .WithTextLine("COO & Software: A.R.Rules: alonewolf87")
                .WithTextLine("Playtesting: Shellin & The Purple WizardCommunity: Shellin")
                .WithTextLine("Graphic Design & Printing: thaurdirLore: Bobbymcbobface")
                .WithTextLine("Storytelling & Editing: Darkling Door")
                .WithTextLine("Scenario Design: Seastan")
                .WithTextLine("Assistants: [DTP]Anzu, abstein, ALeP Cron Bot, alinktothezack, Annaeru, Arahael, Argonui, AudlyLiminal, Baloosh, Barbarossa41, Beleg489, Ben or Break, Beorn, BeornBot, bgamerjoe (Joseph Forster), bigfomlof, Birdman137, Brewer Bear, Bullroarer Took, Bundeswill, CamMitchell, Celia, cowZarific, Crabble, DavidJMartin, DEER PARK, DieterVanHertz, Dimitri, divinityofnumber, Doc_H, doomguard, Ekika, Emilius, Emmental, Emotional Support Honey Badger, Emreis, Feniks, filgonfin, Filippo, frama, Franlag, funkymonkeymonk, Fuzzzyslippers, Glamcrist (JeffTheJeff), Gorthaur, granny.sheep, GreenWizard#1040, Greyjoy, Helena, Ipswatch, Ira, Jasmine_Mickey, JasonRed3, Jaywana, JoshuaK, KingDom, klarlack, kokatrix, Krakua, KYpatzer, Levanthalas, LifeCrow, Lorunks, madslaust, Mag, McDog3, migal, mikkisaur, miklemas, Minoso, MisunderstoodConqueror, Mogra, Mormegil, MrSpaceBear, MrThomnas, munchula dbeer, nelloianiro, Nuls, oldoly, Pabs, Palantir Record Keeper, Polak, Rambokc, rduda, Rimogard, RogueThirteen, rouxxor, Salted Pork, secondhandtook, skurvy5, Splice, Stavroguin, tamhas, Taudir, Teodorondor, TheChap, theokyle, tiocadu, Tom/Kilie, TritonWreck, Truck, Tuhma, VeggieGollum, Verwegner (Jan), Vyntares, Watch-Captain Alain, Watcher in the Water, wlk, xavdu92, xaviermutant, Xenon, Xi, ycarium, Zapier, Zarkanth, zoomboy, Zuzzuk")
                .WithTextLine("Special thanks to HeavyKaragh for his work on the Strange Eons plugin, RiddermarkLord for his work on the card templates, and Troy L for the ALeP logo and encounter set icon designs. We credit Marko Manev for the ALeP encounter card back art.")
                .WithOppositeTextLine("Just as Sauron’s armies are invading Gondor in the south, so too do the drums of war beat in the twin cities of Dale and Erebor in the north. A horde of Easterlings approaches to lay siege to the Kingdom under the Mountain. Can you hold the line, or will the free settlements of the north be lost?")
                .WithInfo(999, 1, Artist.None);
             * */
        }
    }
}
