/* Generated CardSet class: Race Across Harad */

using System;

namespace HallOfBeorn.Models.LotR.Sets.Haradrim
{
    public class RaceAcrossHaradSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Race Across Harad";
            Abbreviation = "RaH";
            Number = 44;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            addHero("Thurindir", 8, Sphere.Lore, 2, 2, 0, 4)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithTextLine("Thurindir gets +1 Willpower for each side quest in the victory display.")
                .WithTextLine("Setup: Search your deck for a side quest and add it to your hand. Shuffle your deck.")
                .WithFlavorLine("\"He is one of the wandering folk - Rangers we call them.\"")
                .WithFlavorLine("-Barliman Butterbur, The Fellowship of the Ring")
                .WithInfo(28, 1, Artist.Alvaro_Calvo_Escudero);
            addAlly("Kahliel's Tribesman", 2, Sphere.Leadership, false, 1, 1, 1, 2)
                .WithTraits("Harad.")
                .WithTextLine("Action: Exhaust Kahliel’s Tribesman to choose another Harad character. That character gets +1 Willpower, +1 Attack, and +1 Defense until the end of the phase.")
                .WithFlavorLine("But the Haradrim, being now driven to the brink, turned at bay, and they were fierce in despair...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(29, 3, Artist.Ryan_Valle);
            addAttachment("Steed of the North", 1, Sphere.Leadership, false)
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Dúnedain or Ranger hero. Restricted.")
                .WithTextLine("Response: After you engage an enemy, exhaust Steed of the North to ready attached hero.")
                .WithFlavorLine("Their horses were strong and of proud bearing, but rough-haired...")
                .WithFlavorLine("-The Return of the King")
                .WithTemplate("<p class='main-text'>Attach to a {trait:Dúnedain.@Dúnedain} or {trait:Ranger.@Ranger} hero. {keyword:Restricted.}</p><p class='main-text'><b>Response:</b> After you engage an enemy, exhaust {self} to ready attached hero.</p><p class='flavor-text'>Their horses were strong and of proud bearing, but rough-haired...<br>&ndash;The Return of the King</p>")
                .WithInfo(30, 3, Artist.Alvaro_Calvo_Escudero);
            addAttachment("Mighty Warrior", 1, Sphere.Tactics, false)
                .WithTraits("Skill.")
                .WithTextLine("Attach to a hero. Limit 1 per hero.")
                .WithTextLine("Attached hero gains the Warrior trait.")
                .WithTextLine("Response: After you play Mighty Warrior from your hand, draw a card.")
                .WithFlavorLine("Gimli hewed the legs from another that had sprung up on Balin’s tomb.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(31, 3, Artist.Marius_Bota);
            addEvent("Proud Hunters", 0, Sphere.Tactics)
                .WithTextLine("Play only if you control a unique character with the Noble trait and another unique character with the Ranger trait.")
                .WithTextLine("Response: After a hero you control participates in an attack that destroys an enemy, add X resources to that hero’s pool. X is the just destroyed enemy’s printed Threat.")
                .WithInfo(32, 3, Artist.Rafal_Hrynkiewicz);
            addAlly("Dúnedain Pathfinder", 0, Sphere.Spirit, false, 2, 1, 0, 2)
                .WithTraits("Dúnedain.", "Scout.")
                .WithTextLine("Forced: After this ally enters play, search the top 5 cards of the encounter deck for a non-unique location and add it to the staging area. If no location enters play by this effect, discard Dúnedain Pathfinder. Shuffle the encounter deck.")
                .WithInfo(33, 3, Artist.Michele_Frigo);
            addEvent("Backtrack", 1, Sphere.Spirit)
                .WithTextLine("Play only if the main quest has no keywords.")
                .WithTextLine("Action: Remove X progress from the main quest to place X progress on a location in the staging area.")
                .WithFlavorLine("\"Well,\" said Boromir, \"when heads are at a loss bodies must serve...\"")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(34, 3, Artist.John_Pacer);
            addAlly("Eryn Galen Settler", 2, Sphere.Lore, false, 1, 2, 0, 2)
                .WithTraits("Woodman.")
                .WithTextLine("Response: When the active location leaves play as an explored location, discard Eryn Galen Settler to discard a location in the staging with the same title as the just explored location.")
                .WithInfo(35, 3, Artist.Michele_Frigo);
            addPlayerSideQuest("Explore Secret Ways", 1, Sphere.Lore, 6)
                .WithTextLine("Limit 1 copy of Explore Secret Ways in the victory display.")
                .WithTextLine("While Explore Secret Ways is in the victory display, each location in the staging area with the same title as the active location does not contribute its Threat to the total Threat in the staging area.")
                .WithFlavorLine("\"I myself dared to pass the doors of the Necromancer in Dul Guldur, and secretly explored his ways...\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithVictoryPoints(1)
                .WithInfo(36, 3, Artist.Andreia_Ugrai);
            addAlly("Steward of Orthanc", 3, Sphere.Neutral, false, 2, 0, 0, 2)
                .WithTraits("Isengard.")
                .WithTextLine("Response: When you play an event, give it Doomed 1 to draw a card. You cannot trigger this ability if you have already triggered the ability of a Steward of Orthanc this round.")
                .WithFlavorLine("\"...the power of Orthanc cannot be lightly thrown aside...\"")
                .WithFlavorLine("-Saruman, The Two Towers")
                .WithInfo(37, 3, Artist.Aleksander_Karcz);
            addObjectiveAlly("Tamed Mûmak", EncounterSet.RaceAcrossHarad, 2, 5, 2, 8)
                .WithTraits("Harad.", "Creature.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Damage from undefended attacks against you must be assigned to Tamed Mûmak.")
                .WithTextLine("If Tamed Mûmak leaves play, the controlling player is eliminated.")
                .WithInfo(38, 4, Artist.Piya_Wannachaiwong);
            addLocation("River Harnen", EncounterSet.RaceAcrossHarad, 4, 10)
                .WithUnique()
                .WithTraits("Desert.", "River.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("The players cannot travel here unless there are at least 20 progress tokens on stage 4B.")
                .WithTextLine("Travel: Reveal 1 encounter card per player.")
                .WithTextLine("Stage 4B cannot be defeated while River Harnen is in play.")
                .WithVictoryPoints(4)
                .WithInfo(39, 1, Artist.Jokubas_Uoginitas);
            addLocation("Expanse of Harad", EncounterSet.RaceAcrossHarad, 2, 5)
                .WithTraits("Desert.")
                .WithTextLine("While the players are not at the same stage as the Orc's stage, Expanse of Harad gets +2 Threat.")
                .WithTextLine("Forced: After Expanse of Harad becomes the active location, raise each player’s threat by 2.")
                .WithFlavorLine("The wide plains opened grey before them.")
                .WithFlavorLine("-The Two Towers")
                .WithInfo(40, 2, Artist.Sergey_Glushakov);
            addLocation("Blistering Erg", EncounterSet.RaceAcrossHarad, Card.VALUE_NA, 4)
                .WithTraits("Desert.")
                .WithTextLine("X is the stage number of the main quest.")
                .WithTextLine("Forced: After Blistering Erg becomes the active location, each player assigns X damage among characters he controls.")
                .WithFlavorLine("It seemed a long way, and he grew hot and very hungry...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(41, 3, Artist.Sergey_Glushakov);
            addLocation("Harad Road", EncounterSet.RaceAcrossHarad, 5, 5)
                .WithTraits("Desert.", "Road.")
                .WithTextLine("When Revealed: Add Harad Road to the Orc's area.")
                .WithShadow("Shadow: If the players are not at the same stage as the Orcs, move attacking enemy to the Orc's area after this attack.")
                .WithInfo(42, 2, Artist.Jokubas_Uoginitas);
            addEnemy("Uruk Pursuer", EncounterSet.RaceAcrossHarad, 20, 2, 3, 2, 3)
                .WithTraits("Orc.", "Uruk.")
                .WithTextLine("When Revealed: Add Uruk Pursuer to the Orc's area. If the players are not at the same stage as the Orcs, Uruk Pursuer gains surge.")
                .WithShadow("Shadow: If the players are not at the same stage as the Orcs, put Uruk Pursuer into play engaged with you.")
                .WithInfo(43, 4, Artist.Lukasz_Jaskolski);
            addEnemy("Racing Warg", EncounterSet.RaceAcrossHarad, 10, 1, 1, 1, 1)
                .WithTraits("Creature.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Attach to an Orc enemy. Limit 1 per enemy. (Counts as a Mount attachment with the text: \"Attached enemy gets +1 Threat, +1 Attack, +1 Defense, and +1 hit point. Forced: When attached enemy leaves play, return Racing Warg to the staging area.\")")
                .WithEasyModeQuantity(2)
                .WithInfo(44, 3, Artist.Alexander_Gustafson);
            addTreachery("Pursuers from Mordor", EncounterSet.RaceAcrossHarad)
                .WithKeywords("Doomed 2.")
                .WithTextLine("Doomed 2.")
                .WithTextLine("When Revealed: Discard cards from the top of the encounter deck until an Orc enemy is discarded. Add that enemy to the Orc's area.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, place 2 progress on the Orc's stage.")
                .WithInfo(45, 2, Artist.Stanislav_Dikolenko);
            addTreachery("Howling at their Heels", EncounterSet.RaceAcrossHarad)
                .WithTextLine("When Revealed: If the players are not at the same stage as the Orcs, add the total Threat of each card in the Orc's area to the total Threat in the staging area until the end of the phase. If the players are at the same stage as the Orcs, each enemy gets +1 Threat until the end of the phase.")
                .WithShadow("Shadow: Raise your threat by 1.")
                .WithEasyModeQuantity(2)
                .WithInfo(46, 3, Artist.Alexander_Gustafson);
            addQuest("Setting Out", EncounterSet.RaceAcrossHarad, 1, 'A', 0)
                .WithTextLine("Setup: Set Ford of Harnen and 1 copy of Uruk Warg-rider aside, out of play. Each player takes control of a Tamed Mumak. Remove each remaining Tamed Mumak from the game. Create the Orc’s area with a second quest deck consisting of stage 1C, 2C, 3C, and 4C as well as Uruk Chieftain.")
                .WithFlavorLine("Emerging from your hunt in the great jungle of the south, you set out across the vast desert of Harad on your long journey north to Gondor.")
                .WithOppositeTextLine("When Revealed: Each player searches the encounter deck for 1 different location and adds it to the staging area. Shuffle the encounter deck. Advance to stage 2A.")
                .WithOppositeFlavorLine("Riding atop the Oliphaunts that you captured in the jungle, you set an easy pace.")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.DesertSands)
                .WithInfo(47, 1, Artist.Sebastian_Zakrzewski);
            addQuest("Racing North", EncounterSet.RaceAcrossHarad, 2, 'A', 15)
                .WithTextLine("When Revealed: Choose the staging area or the Orc's area. Add the set aside Uruk Warg-rider to the chosen area.")
                .WithFlavorLine("During the night, you hear the howls of distant Wargs drawing nearer. The riders of Mordor are scouring the sandy plains for you and the remnant of Kahlie’s tribe. You give the Mumak’s reigns a hard shake and quicken the pace.")
                .WithOppositeTextLine("Uruk Chieftain cannot take damage.")
                .WithOppositeTextLine("Forced: After characters are committed to quest, no more than 5 progress can be placed here this round (10 progress instead if each Tamed Mumak in play is committed to the quest).")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.DesertSands)
                .WithInfo(48, 1, Artist.Alexandr_Elichev);
            addQuest("Hunted in Harad", EncounterSet.RaceAcrossHarad, 3, 'A', 20)
                .WithTextLine("When Revealed: Shuffle the encounter discard pile into the encounter deck and discard cards from the top until an Orc enemy is discarded. Add that enemy to the Orc's area.")
                .WithFlavorLine("The hounds of Mordor have caught your scent and they close in on you from the south. Even riding on the tall Mumakil you are not safe from the barbed arrows of the Warg-riders. Your only hope is to reach the River Harnen before you are cut off.")
                .WithOppositeTextLine("Uruk Chieftain cannot take damage.")
                .WithOppositeTextLine("Reveal an additional encounter card during the quest phase if Uruk Chieftain is at stage 2D.")
                .WithOppositeTextLine("Forced: After characters are committed to quest, no more than 5 progress can be placed here this round (10 progress instead if each Tamed Mumak in play is committed to the quest).")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.DesertSands)
                .WithInfo(49, 1, Artist.S_C_Watson);
            addQuest("The Ford of Harnen", EncounterSet.RaceAcrossHarad, 4, 'A', 20)
                .WithTextLine("When Revealed: Add River Harnen to the staging area. Shuffle the encounter discard pile into the encounter deck and discard cards from the top until an Orc enemy is discarded. Add that enemy to the Orc's area.")
                .WithFlavorLine("You can see the river on the horizon. Your pursuers won't dare to cross the water where it's deep, but the large Mumakil can manage easily. If only you can reach the river in time...")
                .WithOppositeTextLine("Forced: After characters are committed to quest, no more than 5 progress can be placed here this round (10 progress instead if each Tamed Mumak in play is committed to the quest).")
                .WithOppositeTextLine("Forced: After an enemy attacks and destroys a character, place 1 progress on the Orc's stage.")
                .WithOppositeTextLine("If you defeat this stage, you have escaped the Orcs and win the game.")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.DesertSands)
                .WithInfo(50, 1, Artist.Uriah_Voth);
            addQuest("Setting Out", EncounterSet.RaceAcrossHarad, 1, 'C', 10)
                .WithSlugSuffix("C")
                .WithFlavorLine("The Orcs that attacked Kahliel's village patrol the desert in search of survivors.")
                .WithOppositeTextLine("Uruk Chieftain cannot leave the Orc's area.")
                .WithOppositeTextLine("Forced: At the end of the quest phase, discard the top card of the encounter deck. Place X progress on this stage, where X is the discarded card's Threat plus the total Threat in the Orc's area.")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.DesertSands)
                .WithInfo(51, 1, Artist.Sebastian_Zakrzewski);
            addQuest("Racing North", EncounterSet.RaceAcrossHarad, 2, 'C', 15)
                .WithSlugSuffix("C")
                .WithTextLine("When Revealed: If the players have already defeated stage 2B, discard cards from the top of the encounter deck until an Orc enemy is discarded. Add that enemy to the Orc's area.")
                .WithFlavorLine("The Wargs have caught the scent and they race north with the Orc riders on their backs.")
                .WithOppositeTextLine("While the players are at stage 3B, Uruk Chieftain cannot leave the Orc's area.")
                .WithOppositeTextLine("Forced: At the end of the quest phase, return Uruk Chieftain to the Orc’s area and discard the top card of the encounter deck. Place X progress on this stage, where X is the discarded card's Threat plus the total Threat in the Orc's area.")
                .WithOppositeTextLine("If you are at stage 2B when this stage is defeated, you lose the game.")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.DesertSands)
                .WithInfo(52, 1, Artist.Alexandr_Elichev);
            addQuest("Hunted in Harad", EncounterSet.RaceAcrossHarad, 3, 'C', 20)
                .WithSlugSuffix("C")
                .WithTextLine("When Revealed: If the players have already defeated stage 3B, discard cards from the top of the encounter deck until an Orc enemy is discarded. Add that enemy to the Orc's area.")
                .WithFlavorLine("The Orcs and their mounts move with great speed across the sandy waste. They can smell their prey on the air as they narrow the distance between them.")
                .WithOppositeTextLine("While the players are at stage 4B, Uruk Chieftain cannot leave the Orc's area and each enemy at this stage gets +1 Threat.")
                .WithOppositeTextLine("Forced: At the end of the quest phase, return Uruk Chieftain to the Orc's area and discard the top card of the encounter deck. Place X progress on this stage, where X is the total Threat of the discarded card plus the total Threat in the Orc's area.")
                .WithOppositeTextLine("If you are at stage 3B when this stage is defeated, you lose the game.")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.DesertSands)
                .WithInfo(53, 1, Artist.S_C_Watson);
            addQuest("The Ford of Harnen", EncounterSet.RaceAcrossHarad, 4, 'C', 20)
                .WithSlugSuffix("C")
                .WithFlavorLine("The Harnen cuts a line across the horizon and the Wargs race to reach its shore ahead of their prey. Their Orc riders urge them on with shouts and savage kicks. If they let their quarry cross the river, they will not be able to pursue, so they set a frenzied pace and tear across the sand.")
                .WithOppositeTextLine("Uruk Chieftain cannot take damage while River Harnen is in the staging area.")
                .WithOppositeTextLine("Forced: At the end of the quest phase, discard the top card of the encounter deck. Place X progress on this stage, where X is the discarded card's Threat plus the total Threat of each engaged enemy.")
                .WithOppositeTextLine("If the Orcs defeat this stage, the Orcs have caught you and you lose the game.")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.DesertSands)
                .WithInfo(54, 1, Artist.Uriah_Voth);
        }
    }
}
