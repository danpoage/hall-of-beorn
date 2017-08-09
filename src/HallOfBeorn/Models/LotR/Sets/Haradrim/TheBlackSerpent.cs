using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.Haradrim
{
    public class TheBlackSerpent : CardSet
    {
        private const string setName = "The Black Serpent";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TBS";
            Number = 46;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            addCard(LotRCard.Hero("Fastred", string.Empty, Sphere.Spirit, 9, 1, 2, 3, 3)
                .WithTraits("Rohan.", "Warrior.")
                .WithText("Response: After Fastred defends an enemy attack, return that enemy to the staging area to reduce your threat by 2. (Limit once per phase.)")
                .WithFlavor("\"King's man! King's man!\" his heart cried within him.\r\n-The Return of the King")
                .WithInfo(81, 1, Artist.Lukasz_Jaskolski));
            addCard(LotRCard.Attachment("Song of Hope", string.Empty, Sphere.Leadership, 0)
                .WithTraits("Song.")
                .WithText("Attach to a hero. Limit 1 per hero.\r\nAction: Spend 1 resource from attached hero's pool to give attached hero +1 Willpower until the end of the phase. (Limit 3 times per phase.)")
                .WithFlavor("\"I will not say the Day is done.\r\nnor bid the Stars farewell.\"\r\n-Sam Gamgee, The Return of the King")
                .WithInfo(82, 3, Artist.Micah_Epstein));
            addCard(LotRCard.Event("Burst into Song", string.Empty, Sphere.Leadership, 2)
                .WithText("Action: Ready each hero with a Song attachment.")
                .WithFlavor("And then all the host of Rohan burst into song, and they sang as they slew, for the joy of battle was on them, and the sound of their singing that was fair and terrible came even to the City.\r\n-The Return of the King")
                .WithInfo(83, 3, Artist.Javier_Charro_Martinez));
            addCard(LotRCard.Ally("Defender of Cair Andros", Sphere.Tactics, 4, 1, 1, 0, 3)
                .WithTraits("Gondor.", "Warrior.")
                .WithText("Defender of Cair Andros gets +X Defense, where X is the tens digit of your threat. (Limit +4 Defense.)\r\nValour Response: After Defender of Cair Andros is declared as a defender, deal 1 damage to the attacking enemy.")
                .WithInfo(84, 3, Artist.Kim_Sokol));
            addCard(LotRCard.Event("Oath of Eorl", string.Empty, Sphere.Tactics, 3)
                .WithText("Play only if you control a unique character with the Rohan trait and another unique character with the Gondor trait.\r\nResponse: At the beginning of the combat phase, you resolve the step in which you attack enemies before resolving enemy attacks this phase. (Each other player resolves the combat phase as normal after you resolve your attacks.)")
                .WithInfo(85, 3, Artist.Rafal_Hrynkiewicz));
            addCard(LotRCard.Attachment("Fearless Scout", string.Empty, Sphere.Spirit, 1)
                .WithTraits("Skill.")
                .WithText("Attach to a hero. Limit 1 per hero.\r\nAttached hero gains the Scout trait.\r\nResponse: After you play Fearless ~Scout from your hand, draw a card.")
                .WithFlavor("...he got right up to the fire-for fire it was-without disturbing anyone. -The Hobbit")
                .WithInfo(86, 3, Artist.Andreia_Ugrai));
            addCard(LotRCard.PlayerSideQuest("Rally the West", string.Empty, Sphere.Spirit, 1, 6)
                .WithFlavor("\"Foes and fire are before you, and your homes far behind. Yet, though you fight upon an alien field, the glory that you reap there shall be your own for ever.\"\r\n-Théoden, The Return of the King")
                .WithText("Limit 1 copy of Rally the West in the victory display.\r\nWhile this quest is in the victory display, each hero gets +1 Willpower.")
                .WithVictoryPoints(1)
                .WithInfo(87, 3, Artist.Stanislav_Dikolenko));
            addCard(LotRCard.Attachment("Dúnedain Pipe", string.Empty, Sphere.Lore, 1)
                .WithTraits("Item.", "Pipe.")
                .WithText("Attach to a ~Dúnedain character. Limit 1 per character.\r\nAction: Exhaust ~Dúnedain ~Pipe and place a card from your hand on the bottom of your deck to draw a card.")
                .WithFlavor("He had a tall tankard in front of him, and was smoking a long-stemmed pipe curiously carved.\r\n-The Fellowship of the Ring")
                .WithInfo(88, 3, Artist.Dani_Hartel));
            addCard(LotRCard.Event("Old Toby", string.Empty, Sphere.Lore, 2)
                .WithTraits("Pipeweed.")
                .WithText("Action: Draw 1 card for each Pipe you control. Heal 1 damage from each hero with a Pipe attachment.")
                .WithFlavor("How Old Toby came by the plant is not recorded, for to his dying day he would not tell.\r\n-The Fellowship of the Ring")
                .WithInfo(89, 3, Artist.Jason_Juta));
            addCard(LotRCard.Ally("Southron Refugee", Sphere.Neutral, 2, 1, 1, 0, 2)
                .WithTraits("Harad.")
                .WithText("Action: Exhaust Southron Refugee to reduce the cost of the next Harad ally you play this phase by 1.")
                .WithFlavor("...to the land of the Haradrim came only a tale from far off...\r\n-The Return of the King")
                .WithInfo(90, 3, Artist.Nikolas_Hagialas));
            addCard(LotRCard.Objective("Banner of the Serpent", string.Empty, setName)
                .WithTraits("Item.", "Harad.")
                .WithKeywords("Guarded (enemy or location).")
                .WithText("While Banner of the Serpent is attached to an encounter card, each Harad enemy gets +1 Attack.\r\nAction: Exhaust Banner of the Serpent and raise your threat by 1 to give each Harad enemy engaged with you -1 Attack until the end of the phase.")
                .WithInfo(91, 1, Artist.Maggie_Ivy));
            addCard(LotRCard.Objective("The Serpent's Garb", string.Empty, setName)
                .WithTraits("Item.", "Harad.")
                .WithKeywords("Guarded (enemy).")
                .WithText("Attached encounter card gets +2 Threat and is immune to player card effects.\r\nAction: Exhaust The Serpent's Garb and raise your threat by 1 to give a Harad enemy in the staging area -2 Threat until the end of the phase.")
                .WithInfo(92, 1, Artist.Christine_Mitzuk));
            addCard(LotRCard.Objective("Summons from Mordor", string.Empty, setName)
                .WithTraits("Item.", "Harad.")
                .WithKeywords("Guarded (location).")
                .WithText("While Summons from Mordor is attached to an encounter card, each player’s threat cannot be reduced.\r\nAction: Exhaust Summons from Mordor and raise your threat by 1 to add 1 resource to attached hero's pool.")
                .WithInfo(93, 1, Artist.Kamila_Tzutenberg));
            addCard(LotRCard.Enemy("The Black Serpent", string.Empty, setName, 50, 0, 2, 1, 8)
                .WithUnique()
                .WithTraits("Harad.")
                .WithText("Cannot leave the staging area or take damage. X is the stage number of the main quest.\r\nThe Black Serpent gets +X Threat, +X Attack and +X Defense.\r\nForced: At the end of the encounter phase, either remove X progress from the main quest, or The Black Serpent makes an immediate attack against the first player.")
                .WithInfo(94, 1, Artist.Alexandr_Elichev));
            addCard(LotRCard.Enemy("Serpent Guard", string.Empty, setName, 28, 2, 3, 1, 4)
                .WithTraits("Harad.")
                .WithText("Forced: After The Serpent's Guard engages you, either remove 2 progress from the main quest, or enemies engaged with you cannot take damage until the end of the round.")
                .WithShadow("Shadow: Either remove 2 progress from main quest, or attacking enemy cannot take damage this round.")
                .WithInfo(95, 4, Artist.Kim_Sokol));
            addCard(LotRCard.Location("The Serpent's Redoubt", string.Empty, setName, 4, 4)
                .WithTraits("Desert.", "Ruins.")
                .WithText("While The Serpent's Redoubt is in the staging area, it gains: \"Forced: After a player plays an ally from his hand, either remove 1 progress from the main quest, or exhaust that ally.\"\r\nTravel: The first player searches the encounter deck and discard pile for an enemy and puts it into play engaged with him. Shuffle the encounter deck.")
                .WithEasyModeQuantity(1)
                .WithInfo(96, 2, Artist.DinoDrawing));
            addCard(LotRCard.Location("Roofless Tower", string.Empty, setName, 2, 4)
                .WithTraits("Desert.", "Ruins.")
                .WithText("While Roofless Tower is in the staging area, it gains: \"Forced: When a player plays an event, either remove 1 progress from the main quest, or cancel the effects of that event.\"\r\nTravel: Exhaust a hero to travel here.")
                .WithEasyModeQuantity(1)
                .WithInfo(97, 2, Artist.Jokubas_Uoginitas));
            addCard(LotRCard.Location("Desert Bastion", string.Empty, setName, 1, 5)
                .WithTraits("Desert.", "Ruins.")
                .WithText("Desert Bastion gets +1 Threat for each Harad objective attached to a hero.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each Harad objective the players control.")
                .WithInfo(98, 3, Artist.Jokubas_Uoginitas));
            addCard(LotRCard.Location("Southron Camp", string.Empty, setName, 3, 3)
                .WithTraits("Desert.", "Ruins.")
                .WithText("While Southron Camp is in the staging area, it gains: \"Forced: At the end of the round, remove all progress from each location in play.\"\r\nTravel: Raise each player’s threat by 1 to travel here.")
                .WithInfo(99, 3, Artist.Davis_Engel));
            addCard(LotRCard.Location("Broken Courtyard", string.Empty, setName, 1, 3)
                .WithTraits("Desert.", "Ruins.")
                .WithKeywords("Surge.")
                .WithText("While Broken Courtyard is in the staging area, the main quest cannot have progress tokens beyond its printed quest points value.")
                .WithShadow("Shadow: Either remove 2 progress from main quest, or return attacking enemy to staging area after this attack.")
                .WithEasyModeQuantity(2)
                .WithInfo(100, 3, Artist.Jokubas_Uoginitas));
            addCard(LotRCard.Treachery("Bold and Grim", string.Empty, setName)
                .WithKeywords("Surge.", "Doomed 1.")
                .WithText("When Revealed: Deal 1 damage to each hero with an objective attached.")
                .WithShadow("Shadow: If attacking enemy is non-unique, either attach a Harad objective you control to attacking enemy, or it makes an additional attack after this one.")
                .WithEasyModeQuantity(2)
                .WithInfo(101, 3, Artist.Rafal_Hrynkiewicz));
            addCard(LotRCard.Treachery("No Quarter", string.Empty, setName)
                .WithText("When Revealed: Either reveal 2 encounter cards, or detach a Harad objective from a hero, reveal it, and add it to the staging area.")
                .WithShadow("Shadow: If this attack destroys a character, attach a Harad objective you control to a non-unique encounter card in the staging area.")
                .WithEasyModeQuantity(1)
                .WithInfo(102, 2, Artist.Dimitri_Bielak));
            addCard(LotRCard.Treachery("Chaos in the Night", string.Empty, setName)
                .WithText("When Revealed: The first player must choose: either raise each player's threat by 3, or progress cannot be placed on quest cards until the end of the round.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, remove all progress from the main quest.")
                .WithInfo(103, 2, Artist.Lukasz_Jaskolski));
            addCard(LotRCard.EncounterSideQuest("Don't Let Them Escape!", string.Empty, setName, 6)
                .WithFlavor("Some of the Serpent’s men are trying to flee on horseback. If you don’t act quickly they could escape and bring news to Cirith Gurat.")
                .WithText("Forced: At the end of the round, discard all progress from the main quest.\r\nForced: After this quest is chosen as the current quest, reveal an encounter card.")
                .WithInfo(104, 1, Artist.Rafal_Hrynkiewicz));

            addCard(LotRCard.Quest("The Crossroads Fort", 1, setName, 6)
                .WithFlavor("The Black Serpent’s caravan has taken shelter in a dilapidated desert fortress on their way to Mordor. Their wagons are loaded with tribute for the Dark Lord. Your plan is to seize the wagons and use the caravan to infiltrate Cirith Gurat.")
                .WithText("Setup: Set each Harad objective aside, out of play. Add The Black Serpent to the staging area. Shuffle the encounter deck. The first player randomly selects 1 set aside Harad objective, reveals it, and adds it to the staging area.")
                .WithOppositeFlavor("In order for your plan to work, you must capture several important tokens from the Serpent's Camp.")
                .WithOppositeText("If a Harad objective is not attached, the first player claims it and attaches it to a hero he controls.\r\nThis stage cannot be defeated unless each Harad objective in play is attached to a hero.")
                .WithIncludedEncounterSets(EncounterSet.HaradSoldiers)
                .WithInfo(106, 1, Artist.Jon_Bosco));
            addCard(LotRCard.Quest("Battle in the Camp", 2, setName, 6)
                .WithFlavor("Your initial attack was a success, but the enemy has been alerted to your presence and the whole camp is astir. The fighting soon spills into every corner of the crossroads fort.")
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck. The first player randomly selects 1 set aside Harad objective, reveals it, and adds it to the staging area.")
                .WithOppositeText("If a Harad objective is not attached, the first player claims it and attaches it to a hero he controls.\r\nThe Black Serpent is considered to be engaged with each player who controls a Harad objective.\r\nThis stage cannot be defeated unless each Harad objective in play is attached to a hero.")
                .WithIncludedEncounterSets(EncounterSet.HaradSoldiers)
                .WithInfo(107, 1, Artist.Alexander_Gustafson));
            addCard(LotRCard.Quest("Defeat the Serpent", 3, setName, 6)
                .WithFlavor("Your plan is working. You’ve nearly succeeded in capturing the Southron caravan, but The Black Serpent himself holds the last token you need to infiltrate Cirith Gurat. He will not surrender it willingly...")
                .WithText("When Revealed: Randomly select 1 set aside Harad objective and attach it to The Black Serpent. Shuffle the encounter discard pile into the encounter deck and reveal 1 encounter card per player.")
                .WithOppositeText("If a Harad objective is not attached, the first player claims it and attaches it to a hero he controls.\r\nWhile there are at least 6 progress tokens on this stage, the Black Serpent loses the text: \"Cannot leave the staging area or take damage.\"\r\nThis stage cannot be defeated unless each Harad objective in play is attached to a hero. If the players defeat this stage, they win the game.")
                .WithIncludedEncounterSets(EncounterSet.HaradSoldiers)
                .WithInfo(108, 1, Artist.Joshua_Cairos));
        }
    }
}