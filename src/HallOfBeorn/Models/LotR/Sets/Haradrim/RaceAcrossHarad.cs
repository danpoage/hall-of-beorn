using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.Haradrim
{
    public class RaceAcrossHarad : CardSet
    {
        private const string setName = "Race Across Harad";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "RaH";
            Number = 44;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            addCard(LotRCard.Hero("Thurindir", string.Empty, Sphere.Lore, 8, 2, 2, 0, 4)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithText("Thurindir gets +1 Willpower for each side quest in the victory display.\r\nSetup: Search your deck for a side quest and add it to your hand. Shuffle your deck.")
                .WithFlavor("\"He is one of the wandering folk - Rangers we call them.\"\r\n-Barliman Butterbur, The Fellowship of the Ring")
                .WithInfo(28, 1, Artist.Alvaro_Calvo_Escudero));
            addCard(LotRCard.Ally("Kahliel's Tribesman", Sphere.Leadership, 2, 1, 1, 1, 2)
                .WithTraits("Harad.")
                .WithText("Action: Exhaust Kahliel’s Tribesman to choose another Harad character. That character gets +1 Willpower, +1 Attack, and +1 Defense until the end of the phase.")
                .WithFlavor("But the Haradrim, being now driven to the brink, turned at bay, and they were fierce in despair...\r\n-The Return of the King")
                .WithInfo(29, 3, Artist.Ryan_Valle));
            addCard(LotRCard.Attachment("Steed of the North", string.Empty, Sphere.Leadership, 1)
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Dúnedain or Ranger hero.\r\nResponse: After you engage an enemy, exhaust Steed of the North to ready attached hero.")
                .WithFlavor("Their horses were strong and of proud bearing, but rough-haired...\r\n-The Return of the King")
                .WithInfo(30, 3, Artist.Alvaro_Calvo_Escudero));
            addCard(LotRCard.Attachment("Mighty Warrior", string.Empty, Sphere.Tactics, 1)
                .WithTraits("Skill.")
                .WithText("Attach to a hero. Limit 1 per hero.\r\nAttached hero gains the Warrior trait.\r\nResponse: After you play Mighty Warrior from your hand, draw a card.")
                .WithFlavor("Gimli hewed the legs from another that had sprung up on Balin’s tomb.\r\n-The Fellowship of the Ring")
                .WithInfo(31, 3, Artist.Marius_Bota));
            addCard(LotRCard.Event("Proud Hunters", string.Empty, Sphere.Tactics, 0)
                .WithText("Play only if you control a unique character with the Noble trait and another unique character with the Ranger trait.\r\nResponse: After a hero you control participates in an attack that destroys an enemy, add X resources to that hero’s pool. X is the just destroyed enemy’s printed Threat.")
                .WithInfo(32, 3, Artist.Rafal_Hrynkiewicz));
            addCard(LotRCard.Ally("Dúnedain Pathfinder", Sphere.Spirit, 0, 2, 1, 0, 2)
                .WithTraits("Dúnedain.", "Scout.")
                .WithText("Forced: After this ally enters play, search the top 5 cards of the encounter deck for a non-unique location and add it to the staging area. If no location enters play by this effect, discard Dúnedain Pathfinder. Shuffle the encounter deck.")
                .WithInfo(33, 3, Artist.Michele_Frigo));
            addCard(LotRCard.Event("Backtrack", string.Empty, Sphere.Spirit, 1)
                .WithText("Play only if the main quest has no keywords.\r\nAction: Remove X progress from the main quest to place X progress on a location in the staging area.")
                .WithFlavor("\"Well,\" said Boromir, \"when heads are at a loss bodies must serve...\"\r\n-The Fellowship of the Ring")
                .WithInfo(34, 3, Artist.John_Pacer));
            addCard(LotRCard.Ally("Eryn Galen Settler", Sphere.Lore, 2, 1, 2, 0, 2)
                .WithTraits("Woodman.")
                .WithText("Response: When the active location leaves play as an explored location, discard Eryn Galen Settler to discard a location in the staging with the same title as the just explored location.")
                .WithInfo(35, 3, Artist.Michele_Frigo));
            addCard(LotRCard.PlayerSideQuest("Explore Secret Ways", string.Empty, Sphere.Lore, 1, 6)
                .WithText("Limit 1 copy of Explore Secret Ways in the victory display.\r\nWhile Explore Secret Ways is in the victory display, each location in the staging area with the same title as the active location does not contribute its Threat to the total Threat in the staging area.")
                .WithFlavor("\"I myself dared to pass the doors of the Necromancer in Dul Guldur, and secretly explored his ways...\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithVictoryPoints(1)
                .WithInfo(36, 3, Artist.Andreia_Ugrai));
            addCard(LotRCard.Ally("Steward of Orthanc", Sphere.Neutral, 3, 2, 0, 0, 2)
                .WithTraits("Isengard.")
                .WithText("Response: When you play an event, give it Doomed 1 to draw a card. You cannot trigger this ability if you have already triggered the ability of a Steward of Orthanc this round.")
                .WithFlavor("\"...the power of Orthanc cannot be lightly thrown aside...\"\r\n-Saruman, The Two Towers")
                .WithInfo(37, 3, Artist.Aleksander_Karcz));
            addCard(LotRCard.ObjectiveAlly("Tamed Mûmak", string.Empty, setName, 2, 5, 2, 8)
                .WithTraits("Harad.", "Creature.")
                .WithText("Immune to player card effects.\r\nDamage from undefended attacks against you must be assigned to Tamed Mûmak.\r\nIf Tamed Mûmak leaves play, the controlling player is eliminated.")
                .WithInfo(38, 4, Artist.Piya_Wannachaiwong));
            addCard(LotRCard.Location("River Harnen", string.Empty, setName, 4, 10)
                .WithUnique()
                .WithTraits("Desert.", "River.")
                .WithText("Immune to player card effects.\r\nThe players cannot travel here unless there are at least 20 progress tokens on stage 4B.\r\nTravel: Reveal 1 encounter card per player.\r\nStage 4B cannot be defeated while River Harnen is in play.")
                .WithInfo(39, 1, Artist.Jokubas_Uoginitas));
            addCard(LotRCard.Location("Expanse of Harad", string.Empty, setName, 2, 5)
                .WithTraits("Desert.")
                .WithText("While the players are not at the same stage as the Orc's stage, Expanse of Harad gets +2 Threat.\r\nForced: After Expanse of Harad becomes the active location, raise each player’s threat by 2.")
                .WithFlavor("The wide plains opened grey before them.\r\n-The Two Towers")
                .WithInfo(40, 2, Artist.DinoDrawing));
            addCard(LotRCard.Location("Blistering Erg", string.Empty, setName, 255, 4)
                .WithTraits("Desert.")
                .WithText("X is the stage number of the main quest.\r\nForced: After Blistering Erg becomes the active location, each player assigns X damage among characters he controls.")
                .WithFlavor("It seemed a long way, and he grew hot and very hungry...\r\n-The Return of the King")
                .WithInfo(41, 3, Artist.DinoDrawing));
            addCard(LotRCard.Location("Harad Road", string.Empty, setName, 5, 5)
                .WithTraits("Desert.", "Road.")
                .WithText("When Revealed: Add Harad Road to the Orc's area.")
                .WithShadow("Shadow: If the players are not at the same stage as the Orcs, move attacking enemy to the Orc's area after this attack.")
                .WithInfo(42, 2, Artist.Jokubas_Uoginitas));
            addCard(LotRCard.Enemy("Uruk Pursuer", string.Empty, setName, 20, 2, 3, 2, 3)
                .WithTraits("Orc.", "Uruk.")
                .WithText("When Revealed: Add Uruk Pursuer to the Orc's area. If the players are not at the same stage as the Orcs, Uruk Pursuer gains surge.")
                .WithShadow("Shadow: If the players are not at the same stage as the Orcs, put Uruk Pursuer into play engaged with you.")
                .WithInfo(43, 4, Artist.Lukasz_Jaskolski));
            addCard(LotRCard.Enemy("Racing Warg", string.Empty, setName, 10, 1, 1, 1, 1)
                .WithTraits("Creature.")
                .WithKeywords("Surge.")
                .WithText("When Revealed: Attach to an Orc enemy. Limit 1 per enemy. (Counts as a Mount attachment with the text: \"Attached enemy gets +1 Threat, +1 Attack, +1 Defense, and +1 hit point. Forced: When attached enemy leaves play, return Racing Warg to the staging area.\")")
                .WithInfo(44, 3, Artist.Alexander_Gustafson));
            addCard(LotRCard.Treachery("Pursuers from Mordor", string.Empty, setName)
                .WithKeywords("Doomed 2.")
                .WithText("When Revealed: Discard cards from the top of the encounter deck until an Orc enemy is discarded. Add that enemy to the Orc's area.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, place 2 progress on the Orc's stage.")
                .WithInfo(45, 2, Artist.Stanislav_Dikolenko));
            addCard(LotRCard.Treachery("Howling at their Heels", string.Empty, setName)
                .WithText("When Revealed: If the players are not at the same stage as the Orcs, add the total Threat of each card in the Orc's area to the total Threat in the staging area until the end of the phase. If the players are at the same stage as the Orcs, each enemy gets +1 Threat until the end of the phase.")
                .WithShadow("Shadow: Raise your threat by 1.")
                .WithInfo(46, 3, Artist.Alexander_Gustafson));
            addCard(LotRCard.Quest("Setting Out", 1, setName, 0)
                .WithStageLetter('A')
                .WithFlavor("Emerging from your hunt in the great jungle of the south, you set out across the vast desert of Harad on your long journey north to Gondor.")
                .WithText("Setup: Set Ford of Harnen and 1 copy of Uruk Warg-rider aside, out of play. Each player takes control of a Tamed Mumak. Remove each remaining Tamed Mumak from the game. Create the Orc’s area with a second quest deck consisting of stage 1C, 2C, 3C, and 4C as well as Uruk Chieftain.")
                .WithOppositeFlavor("Riding atop the Oliphaunts that you captured in the jungle, you set an easy pace.")
                .WithOppositeText("When Revealed: Each player searches the encounter deck for 1 different location and adds it to the staging area. Shuffle the encounter deck. Advance to stage 2A.")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.DesertSands)
                .WithInfo(47, 1, Artist.Sebastian_Zakrzewski));
            addCard(LotRCard.Quest("Racing North", 2, setName, 15)
                .WithFlavor("During the night, you hear the howls of distant Wargs drawing nearer. The riders of Mordor are scouring the sandy plains for you and the remnant of Kahlie’s tribe. You give the Mumak’s reigns a hard shake and quicken the pace.")
                .WithText("When Revealed: Choose the staging area or the Orc's area. Add the set aside Uruk Warg-rider to the chosen area.")
                .WithOppositeText("Uruk Chieftain cannot take damage.\r\nForced: After characters are committed to quest, no more than 5 progress can be placed here this round (10 progress instead if each Tamed Mumak in play is committed to the quest).")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.DesertSands)
                .WithInfo(48, 1, Artist.Alexandr_Elichev));
            addCard(LotRCard.Quest("Hunted in Harad", 3, setName, 20)
                .WithFlavor("The hounds of Mordor have caught your scent and they close in on you from the south. Even riding on the tall Mumakil you are not safe from the barbed arrows of the Warg-riders. Your only hope is to reach the River Harnen before you are cut off.")
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck and discard cards from the top until an Orc enemy is discarded. Add that enemy to the Orc's area.")
                .WithOppositeText("Uruk Chieftain cannot take damage.\r\nReveal an additional encounter card during the quest phase if Uruk Chieftain is at stage 2D.\r\nForced: After characters are committed to quest, no more than 5 progress can be placed here this round (10 progress instead if each Tamed Mumak in play is committed to the quest).")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.DesertSands)
                .WithInfo(49, 1, Artist.S_C_Watson));
            addCard(LotRCard.Quest("The Ford of Harnen", 4, setName, 20)
                .WithFlavor("You can see the river on the horizon. Your pursuers won't dare to cross the water where it's deep, but the large Mumakil can manage easily. If only you can reach the river in time...")
                .WithText("When Revealed: Add River Harnen to the staging area. Shuffle the encounter discard pile into the encounter deck and discard cards from the top until an Orc enemy is discarded. Add that enemy to the Orc's area.")
                .WithOppositeText("Forced: After characters are committed to quest, no more than 5 progress can be placed here this round (10 progress instead if each Tamed Mumak in play is committed to the quest).\r\nForced: After an enemy attacks and destroys a character, place 1 progress on the Orc's stage.\r\nIf you defeat this stage, you have escaped the Orcs and win the game.")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.DesertSands)
                .WithInfo(50, 1, Artist.Uriah_Voth));
            addCard(LotRCard.Quest("Setting Out", 1, setName, 10, 'C')
                .WithFlavor("The Orcs that attacked Kahliel's village patrol the desert in search of survivors.")
                .WithOppositeText("Uruk Chieftain cannot leave the Orc's area.\r\nForced: At the end of the quest phase, discard the top card of the encounter deck. Place X progress on this stage, where X is the discarded card's Threat plus the total Threat in the Orc's area.")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.DesertSands)
                .WithInfo(51, 1, Artist.Sebastian_Zakrzewski));
            addCard(LotRCard.Quest("Racing North", 2, setName, 15, 'C')
                .WithFlavor("The Wargs have caught the scent and they race north with the Orc riders on their backs.")
                .WithText("When Revealed: If the players have already defeated stage 2B, discard cards from the top of the encounter deck until an Orc enemy is discarded. Add that enemy to the Orc's area.")
                .WithOppositeText("While the players are at stage 3B, Uruk Chieftain cannot leave the Orc's area.\r\nForced: At the end of the quest phase, return Uruk Chieftain to the Orc’s area and discard the top card of the encounter deck. Place X progress on this stage, where X is the discarded card's Threat plus the total Threat in the Orc's area.\r\nIf you are at stage 2B when this stage is defeated, you lose the game.")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.DesertSands)
                .WithInfo(52, 1, Artist.Alexandr_Elichev));
            addCard(LotRCard.Quest("Hunted in Harad", 3, setName, 20, 'C')
                .WithFlavor("The Orcs and their mounts move with great speed across the sandy waste. They can smell their prey on the air as they narrow the distance between them.")
                .WithText("When Revealed: If the players have already defeated stage 3B, discard cards from the top of the encounter deck until an Orc enemy is discarded. Add that enemy to the Orc's area.")
                .WithOppositeText("While the players are at stage 4B, Uruk Chieftain cannot leave the Orc's area and each enemy at this stage gets +1 Threat.\r\nForced: At the end of the quest phase, return Uruk Chieftain to the Orc's area and discard the top card of the encounter deck. Place X progress on this stage, where X is the total Threat of the discarded card plus the total Threat in the Orc's area.\r\nIf you are at stage 3B when this stage is defeated, you lose the game.")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.DesertSands)
                .WithInfo(53, 1, Artist.S_C_Watson));
            addCard(LotRCard.Quest("The Ford of Harnen", 4, setName, 20, 'C')
                .WithFlavor("The Harnen cuts a line across the horizon and the Wargs race to reach its shore ahead of their prey. Their Orc riders urge them on with shouts and savage kicks. If they let their quarry cross the river, they will not be able to pursue, so they set a frenzied pace and tear across the sand.")
                .WithOppositeText("Uruk Chieftain cannot take damage while River Harnen is in the staging area.\r\nForced: At the end of the quest phase, discard the top card of the encounter deck. Place X progress on this stage, where X is the discarded card's Threat plus the total Threat of each engaged enemy.\r\nIf the Orcs defeat this stage, the Orcs have caught you and you lose the game.")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.DesertSands)
                .WithInfo(54, 1, Artist.Uriah_Voth));
        }
    }
}