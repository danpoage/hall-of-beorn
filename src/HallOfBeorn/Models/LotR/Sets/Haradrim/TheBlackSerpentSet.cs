/* Generated CardSet class: The Black Serpent */

using System;

namespace HallOfBeorn.Models.LotR.Sets.Haradrim
{
    public class TheBlackSerpentSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Black Serpent";
            Abbreviation = "TBS";
            Number = 46;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            addHero("Fastred", 9, Sphere.Spirit, 1, 2, 3, 3)
                .WithTraits("Rohan.", "Warrior.")
                .WithTextLine("Response: After Fastred defends an enemy attack, return that enemy to the staging area to reduce your threat by 2. (Limit once per phase.)")
                .WithFlavorLine("\"King's man! King's man!\" his heart cried within him.")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(81, 1, Artist.Lukasz_Jaskolski);
            addAttachment("Song of Hope", 0, Sphere.Leadership, false)
                .WithTraits("Song.")
                .WithTextLine("Attach to a hero. Limit 1 per hero.")
                .WithTextLine("Action: Spend 1 resource from attached hero's pool to give attached hero +1 Willpower until the end of the phase. (Limit 3 times per phase.)")
                .WithFlavorLine("\"I will not say the Day is done.")
                .WithFlavorLine("nor bid the Stars farewell.\"")
                .WithFlavorLine("-Sam Gamgee, The Return of the King")
                .WithInfo(82, 3, Artist.Micah_Epstein);
            addEvent("Burst into Song", 2, Sphere.Leadership)
                .WithTextLine("Action: Ready each hero with a Song attachment.")
                .WithFlavorLine("And then all the host of Rohan burst into song, and they sang as they slew, for the joy of battle was on them, and the sound of their singing that was fair and terrible came even to the City.")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(83, 3, Artist.Javier_Charro_Martinez);
            addAlly("Defender of Cair Andros", 4, Sphere.Tactics, false, 1, 1, 0, 3)
                .WithTraits("Gondor.", "Warrior.")
                .WithTextLine("Defender of Cair Andros gets +X Defense, where X is the tens digit of your threat. (Limit +4 Defense.)")
                .WithTextLine("Valour Response: After Defender of Cair Andros is declared as a defender, deal 1 damage to the attacking enemy.")
                .WithInfo(84, 3, Artist.Kim_Sokol);
            addEvent("Oath of Eorl", 3, Sphere.Tactics)
                .WithTextLine("Play only if you control a unique character with the Rohan trait and another unique character with the Gondor trait.")
                .WithTextLine("Response: At the beginning of the combat phase, you resolve the step in which you attack enemies before resolving enemy attacks this phase. (Each other player resolves the combat phase as normal after you resolve your attacks.)")
                .WithInfo(85, 3, Artist.Rafal_Hrynkiewicz);
            addAttachment("Fearless Scout", 1, Sphere.Spirit, false)
                .WithTraits("Skill.")
                .WithTextLine("Attach to a hero. Limit 1 per hero.")
                .WithTextLine("Attached hero gains the Scout trait.")
                .WithTextLine("Response: After you play Fearless ~Scout from your hand, draw a card.")
                .WithFlavorLine("...he got right up to the fire-for fire it was-without disturbing anyone. -The Hobbit")
                .WithInfo(86, 3, Artist.Andreia_Ugrai);
            addPlayerSideQuest("Rally the West", 1, Sphere.Spirit, 6)
                .WithTextLine("Limit 1 copy of Rally the West in the victory display.")
                .WithTextLine("While this quest is in the victory display, each hero gets +1 Willpower.")
                .WithFlavorLine("\"Foes and fire are before you, and your homes far behind. Yet, though you fight upon an alien field, the glory that you reap there shall be your own for ever.\"")
                .WithFlavorLine("-Théoden, The Return of the King")
                .WithVictoryPoints(1)
                .WithInfo(87, 3, Artist.Stanislav_Dikolenko);
            addAttachment("Dúnedain Pipe", 1, Sphere.Lore, false)
                .WithTraits("Item.", "Pipe.")
                .WithTextLine("Attach to a ~Dúnedain character. Limit 1 per character.")
                .WithTextLine("Action: Exhaust ~Dúnedain ~Pipe and place a card from your hand on the bottom of your deck to draw a card.")
                .WithFlavorLine("He had a tall tankard in front of him, and was smoking a long-stemmed pipe curiously carved.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(88, 3, Artist.Dani_Hartel);
            addEvent("Old Toby", 2, Sphere.Lore)
                .WithTraits("Pipeweed.")
                .WithTextLine("Action: Draw 1 card for each Pipe you control. Heal 1 damage from each hero with a Pipe attachment.")
                .WithFlavorLine("How Old Toby came by the plant is not recorded, for to his dying day he would not tell.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(89, 3, Artist.Jason_Juta);
            addAlly("Southron Refugee", 2, Sphere.Neutral, false, 1, 1, 0, 2)
                .WithTraits("Harad.")
                .WithTextLine("Action: Exhaust Southron Refugee to reduce the cost of the next Harad ally you play this phase by 1.")
                .WithFlavorLine("...to the land of the Haradrim came only a tale from far off...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(90, 3, Artist.Nikolas_Hagialas);
            addObjective("Banner of the Serpent", EncounterSet.TheBlackSerpent)
                .WithTraits("Item.", "Harad.")
                .WithKeywords("Guarded (enemy or location).")
                .WithTextLine("Guarded (enemy or location).")
                .WithTextLine("While Banner of the Serpent is attached to an encounter card, each Harad enemy gets +1 Attack.")
                .WithTextLine("Action: Exhaust Banner of the Serpent and raise your threat by 1 to give each Harad enemy engaged with you -1 Attack until the end of the phase.")
                .WithInfo(91, 1, Artist.Maggie_Ivy);
            addObjective("The Serpent's Garb", EncounterSet.TheBlackSerpent)
                .WithTraits("Item.", "Harad.")
                .WithKeywords("Guarded (enemy).")
                .WithTextLine("Guarded (enemy).")
                .WithTextLine("Attached encounter card gets +2 Threat and is immune to player card effects.")
                .WithTextLine("Action: Exhaust The Serpent's Garb and raise your threat by 1 to give a Harad enemy in the staging area -2 Threat until the end of the phase.")
                .WithInfo(92, 1, Artist.Christine_Mitzuk);
            addObjective("Summons from Mordor", EncounterSet.TheBlackSerpent)
                .WithTraits("Item.", "Harad.")
                .WithKeywords("Guarded (location).")
                .WithTextLine("GUarded (location).")
                .WithTextLine("While Summons from Mordor is attached to an encounter card, each player’s threat cannot be reduced.")
                .WithTextLine("Action: Exhaust Summons from Mordor and raise your threat by 1 to add 1 resource to attached hero's pool.")
                .WithInfo(93, 1, Artist.Kamila_Szutenberg);
            addEnemy("The Black Serpent", EncounterSet.TheBlackSerpent, 50, 0, 2, 1, 8)
                .WithUnique()
                .WithTraits("Harad.")
                .WithTextLine("Cannot leave the staging area or take damage. X is the stage number of the main quest.")
                .WithTextLine("The Black Serpent gets +X Threat, +X Attack and +X Defense.")
                .WithTextLine("Forced: At the end of the encounter phase, either remove X progress from the main quest, or The Black Serpent makes an immediate attack against the first player.")
                .WithInfo(94, 1, Artist.Alexandr_Elichev);
            addEnemy("Serpent Guard", EncounterSet.TheBlackSerpent, 28, 2, 3, 1, 4)
                .WithTraits("Harad.")
                .WithTextLine("Forced: After The Serpent's Guard engages you, either remove 2 progress from the main quest, or enemies engaged with you cannot take damage until the end of the round.")
                .WithShadow("Shadow: Either remove 2 progress from main quest, or attacking enemy cannot take damage this round.")
                .WithInfo(95, 4, Artist.Kim_Sokol);
            addLocation("The Serpent's Redoubt", EncounterSet.TheBlackSerpent, 4, 4)
                .WithTraits("Desert.", "Ruins.")
                .WithTextLine("While The Serpent's Redoubt is in the staging area, it gains: \"Forced: After a player plays an ally from his hand, either remove 1 progress from the main quest, or exhaust that ally.\"")
                .WithTextLine("Travel: The first player searches the encounter deck and discard pile for an enemy and puts it into play engaged with him. Shuffle the encounter deck.")
                .WithEasyModeQuantity(1)
                .WithInfo(96, 2, Artist.Sergey_Glushakov);
            addLocation("Roofless Tower", EncounterSet.TheBlackSerpent, 2, 4)
                .WithTraits("Desert.", "Ruins.")
                .WithTextLine("While Roofless Tower is in the staging area, it gains: \"Forced: When a player plays an event, either remove 1 progress from the main quest, or cancel the effects of that event.\"")
                .WithTextLine("Travel: Exhaust a hero to travel here.")
                .WithEasyModeQuantity(1)
                .WithInfo(97, 2, Artist.Jokubas_Uoginitas);
            addLocation("Desert Bastion", EncounterSet.TheBlackSerpent, 1, 5)
                .WithTraits("Desert.", "Ruins.")
                .WithTextLine("Desert Bastion gets +1 Threat for each Harad objective attached to a hero.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each Harad objective the players control.")
                .WithInfo(98, 3, Artist.Jokubas_Uoginitas);
            addLocation("Southron Camp", EncounterSet.TheBlackSerpent, 3, 3)
                .WithTraits("Desert.", "Ruins.")
                .WithTextLine("While Southron Camp is in the staging area, it gains: \"Forced: At the end of the round, remove all progress from each location in play.\"")
                .WithTextLine("Travel: Raise each player’s threat by 1 to travel here.")
                .WithInfo(99, 3, Artist.Davis_Engel);
            addLocation("Broken Courtyard", EncounterSet.TheBlackSerpent, 1, 3)
                .WithTraits("Desert.", "Ruins.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("While Broken Courtyard is in the staging area, the main quest cannot have progress tokens beyond its printed quest points value.")
                .WithShadow("Shadow: Either remove 2 progress from main quest, or return attacking enemy to staging area after this attack.")
                .WithEasyModeQuantity(2)
                .WithInfo(100, 3, Artist.Jokubas_Uoginitas);
            addTreachery("Bold and Grim", EncounterSet.TheBlackSerpent)
                .WithKeywords("Surge.", "Doomed 1.")
                .WithTextLine("Surge. Doomed 1.")
                .WithTextLine("When Revealed: Deal 1 damage to each hero with an objective attached.")
                .WithShadow("Shadow: If attacking enemy is non-unique, either attach a Harad objective you control to attacking enemy, or it makes an additional attack after this one.")
                .WithEasyModeQuantity(2)
                .WithInfo(101, 3, Artist.Rafal_Hrynkiewicz);
            addTreachery("No Quarter", EncounterSet.TheBlackSerpent)
                .WithTextLine("When Revealed: Either reveal 2 encounter cards, or detach a Harad objective from a hero, reveal it, and add it to the staging area.")
                .WithShadow("Shadow: If this attack destroys a character, attach a Harad objective you control to a non-unique encounter card in the staging area.")
                .WithEasyModeQuantity(1)
                .WithInfo(102, 2, Artist.Dimitri_Bielak);
            addTreachery("Chaos in the Night", EncounterSet.TheBlackSerpent)
                .WithTextLine("When Revealed: The first player must choose: either raise each player's threat by 3, or progress cannot be placed on quest cards until the end of the round.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, remove all progress from the main quest.")
                .WithInfo(103, 2, Artist.Lukasz_Jaskolski);
            addEncounterSideQuest("Don't Let Them Escape!", EncounterSet.TheBlackSerpent, 6)
                .WithTextLine("Forced: At the end of the round, discard all progress from the main quest.")
                .WithTextLine("Forced: After this quest is chosen as the current quest, reveal an encounter card.")
                .WithFlavorLine("Some of the Serpent’s men are trying to flee on horseback. If you don’t act quickly they could escape and bring news to Cirith Gurat.")
                .WithVictoryPoints(10)
                .WithInfo(104, 1, Artist.Rafal_Hrynkiewicz);
            addQuest("The Crossroads Fort", EncounterSet.TheBlackSerpent, 1, 'A', 6)
                .WithTextLine("Setup: Set each Harad objective aside, out of play. Add The Black Serpent to the staging area. Shuffle the encounter deck. The first player randomly selects 1 set aside Harad objective, reveals it, and adds it to the staging area.")
                .WithFlavorLine("The Black Serpent’s caravan has taken shelter in a dilapidated desert fortress on their way to Mordor. Their wagons are loaded with tribute for the Dark Lord. Your plan is to seize the wagons and use the caravan to infiltrate Cirith Gurat.")
                .WithOppositeTextLine("If a Harad objective is not attached, the first player claims it and attaches it to a hero he controls.")
                .WithOppositeTextLine("This stage cannot be defeated unless each Harad objective in play is attached to a hero.")
                .WithOppositeFlavorLine("In order for your plan to work, you must capture several important tokens from the Serpent's Camp.")
                .WithIncludedEncounterSets(EncounterSet.HaradSoldiers)
                .WithInfo(106, 1, Artist.Jon_Bosco);
            addQuest("Battle in the Camp", EncounterSet.TheBlackSerpent, 2, 'A', 6)
                .WithTextLine("When Revealed: Shuffle the encounter discard pile into the encounter deck. The first player randomly selects 1 set aside Harad objective, reveals it, and adds it to the staging area.")
                .WithFlavorLine("Your initial attack was a success, but the enemy has been alerted to your presence and the whole camp is astir. The fighting soon spills into every corner of the crossroads fort.")
                .WithOppositeTextLine("If a Harad objective is not attached, the first player claims it and attaches it to a hero he controls.")
                .WithOppositeTextLine("The Black Serpent is considered to be engaged with each player who controls a Harad objective.")
                .WithOppositeTextLine("This stage cannot be defeated unless each Harad objective in play is attached to a hero.")
                .WithIncludedEncounterSets(EncounterSet.HaradSoldiers)
                .WithInfo(107, 1, Artist.Alexander_Gustafson);
            addQuest("Defeat the Serpent", EncounterSet.TheBlackSerpent, 3, 'A', 6)
                .WithTextLine("When Revealed: Randomly select 1 set aside Harad objective and attach it to The Black Serpent. Shuffle the encounter discard pile into the encounter deck and reveal 1 encounter card per player.")
                .WithFlavorLine("Your plan is working. You’ve nearly succeeded in capturing the Southron caravan, but The Black Serpent himself holds the last token you need to infiltrate Cirith Gurat. He will not surrender it willingly...")
                .WithOppositeTextLine("If a Harad objective is not attached, the first player claims it and attaches it to a hero he controls.")
                .WithOppositeTextLine("While there are at least 6 progress tokens on this stage, the Black Serpent loses the text: \"Cannot leave the staging area or take damage.\"")
                .WithOppositeTextLine("This stage cannot be defeated unless each Harad objective in play is attached to a hero. If the players defeat this stage, they win the game.")
                .WithIncludedEncounterSets(EncounterSet.HaradSoldiers)
                .WithInfo(108, 1, Artist.Joshua_Cairos);
        }
    }
}
