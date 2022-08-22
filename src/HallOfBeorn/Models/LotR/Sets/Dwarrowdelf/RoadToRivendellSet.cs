/* Generated CardSet class: Road to Rivendell */

using System;

namespace HallOfBeorn.Models.LotR.Sets.Dwarrowdelf
{
    public class RoadToRivendellSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Road to Rivendell";
            Abbreviation = "RtR";
            Number = 10;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dwarrowdelf";

            addHero("Elladan", 10, Sphere.Tactics, 2, 1, 2, 4)
                .WithTraits("Noldor.", "Noble.", "Ranger.")
                .WithTextLine("While Elrohir is in play, Elladan gets +2 Attack.")
                .WithTextLine("Response: After Elladan is declared as an attacker, pay 1 resource from his resource pool to ready him.")
                .WithCommunityVersion("RiddermarkLord/Elladan-Tactics-Hero")
                .WithInfo(28, 1, Artist.Magali_Villeneuve);
            addAlly("Dúnedain Wanderer", 5, Sphere.Leadership, false, 1, 2, 2, 2)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithKeywords("Ranged.", "Sentinel.", "Secrecy 3.")
                .WithTextLine("Ranged. Sentinel. Secrecy 3.")
                .WithInfo(29, 3, Artist.Ilich_Henriquez);
            addEvent("Lure of Moria", 3, Sphere.Leadership)
                .WithTextLine("Action: Ready all Dwarf characters.")
                .WithInfo(30, 3, Artist.Mike_Nash);
            addAttachment("Rivendell Blade", 1, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Noldor or Silvan character. Restricted.")
                .WithTextLine("When attached character attacks an enemy, that enemy gets -2 Defense until the end of the phase.")
                .WithInfo(31, 3, Artist.Sara_Biddle);
            addEvent("Hail of Stones", 1, Sphere.Tactics)
                .WithTextLine("Action: Exhaust X characters to deal X damage to an enemy in the staging area.")
                .WithInfo(32, 3, Artist.Stu_Barnes);
            addAlly("Rider of the Mark", 3, Sphere.Spirit, false, 2, 1, 1, 2)
                .WithTraits("Rohan.")
                .WithTextLine("Action: Spend 1 Spirit resource to give control of Rider of the Mark to another player. (Limit once per round.)Response: After Rider of the Mark changes control, discard a shadow card dealt to an enemy you are engaged with.")
                .WithInfo(33, 3, Artist.David_Horne);
            addAttachment("Song of Eärendil", 1, Sphere.Spirit, false)
                .WithTraits("Song.")
                .WithTextLine("Attach to a Spirit hero.")
                .WithTextLine("Response: After ~Song of Eärendil enters play, draw 1 card.")
                .WithTextLine("Response: After another player raises his threat, raise your threat by 1 to reduce that player's threat by 1.")
                .WithInfo(34, 3, Artist.K_R_Harris);
            addAlly("Bombur", 3, Sphere.Lore, true, 0, 0, 1, 3)
                .WithTraits("Dwarf.")
                .WithTextLine("Action: Exhaust Bombur to choose a location. That location gets -1 Threat until the end of the phase. (That location does not contribute its Threat instead if it is an Underground location.)")
                .WithCommunityVersion("RiddermarkLord/Bombur-MotK-Lore-Hero")
                .WithInfo(35, 3, Artist.Winona_Nelson);
            addEvent("Out of the Wild", 3, Sphere.Lore)
                .WithKeywords("Secrecy 2.")
                .WithTextLine("Secrecy 2.")
                .WithTextLine("Action: Search the top 5 cards of the encounter deck for any 1 non-objective card worth no victory points and add it to your victory display. Shuffle the encounter deck. Add Out of the Wild to the victory display.")
                .WithErrata(1)
                .WithInfo(36, 3, Artist.Magali_Villeneuve);
            addEvent("The End Comes", 0, Sphere.Neutral)
                .WithTextLine("Response: After a Dwarf character leaves play, shuffle the encounter discard pile back into the encounter deck.")
                .WithInfo(37, 3, Artist.Ryan_Barger);
            addQuest("Along the Misty Mountains", "Road to Rivendell", 1, 'A', 20)
                .WithTextLine("Setup: Put Arwen Undómiel into play under the control of the first player. Shuffle the encounter deck. Reveal 1 card from the encounter deck per player, and add them to the staging area.")
                .WithIncludedEncounterSets(EncounterSet.MistyMountains, EncounterSet.PlunderingGoblins)
                .WithInfo(38, 1, Artist.Ben_Zweifel);
            addQuest("Orc Outpost", "Road to Rivendell", 2, 'A', 7)
                .WithFlavorLine("Heavy rain drives you to seek shelter among the caves of the mountains. They are dry, and the fire you start seeps into your bones and restores your spirit. Your eyes are heavy when teh soft clatter of falling pebbles reaches your ears. Perhaps you are not alone.")
                .WithOppositeTextLine("When Revealed: Search the encounter deck and discard pile for Goblin Gate and add it to the staging area, if able. Then, if there is no active location, Goblin Gate becomes the active location.")
                .WithIncludedEncounterSets(EncounterSet.MistyMountains, EncounterSet.PlunderingGoblins)
                .WithInfo(39, 1, Artist.Nick_Deligaris);
            addQuest("Approaching Rivendell", "Road to Rivendell", 3, 'A', 13)
                .WithFlavorLine("Orcs and other creatures have hounded you since fighting your way free of the orc outpost. Soon you will reach the safety of Rivendell's borders, but supplies have dwindled and you are dead weary from sleepless nights of keeping watch, as dark forms shadow your camp.")
                .WithOppositeTextLine("When Revealed: Reveal 1 card from the encounter deck per player, and add it to the staging area.")
                .WithOppositeTextLine("Characters cannot be healed.")
                .WithOppositeTextLine("If the players defeat this stage, they have won the game.")
                .WithIncludedEncounterSets(EncounterSet.MistyMountains, EncounterSet.PlunderingGoblins)
                .WithInfo(40, 1, Artist.Noah_Bradley);
            addObjectiveAlly("Arwen Undómiel", "Road to Rivendell", 2, 0, 1, 2)
                .WithUnique()
                .WithTraits("Noldor.", "Noble.", "Ally.")
                .WithTextLine("The first player gains control of Arwen Undómiel, as an ally.Response: After Arwen Undómiel exhausts, choose a hero. Add 1 resource to that hero's resource pool.")
                .WithTextLine("If Arwen Undómiel leaves play, the players are defeated.")
                .WithInfo(41, 1, Artist.Magali_Villeneuve);
            addLocation("Ruined Road", "Road to Rivendell", 1, 5)
                .WithTraits("Road.")
                .WithTextLine("Response: After you travel to Ruined Road, the first player places 2 progress tokens on it or readies 1 hero he controls.")
                .WithShadow("Shadow: Return attacking enemy to the staging area after it attacks.")
                .WithInfo(42, 2, Artist.Trudi_Castle);
            addLocation("Goblin Gate", "Road to Rivendell", 5, 4)
                .WithTraits("Gate.")
                .WithTextLine("While Goblin Gate is the active location, the first enemy revealed from the encounter deck each round gains ambush. If that enemy engages a player, it makes an immediate attack (deal and resolve a shadow card).")
                .WithInfo(43, 1, Artist.Trudi_Castle);
            addLocation("Pathless Country", "Road to Rivendell", 3, 5)
                .WithTraits("Hills.")
                .WithTextLine("Forced: After at least 1 progress token is placed on Pathless Country, remove 1 progress token from it.")
                .WithShadow("Shadow: Deal 1 damage to each ally in play.")
                .WithInfo(44, 3, Artist.Trudi_Castle);
            addLocation("Barren Hills", "Road to Rivendell", 2, 4)
                .WithTraits("Hills.")
                .WithTextLine("While Barren Hills is the active location, ignore ambush.")
                .WithShadow("Shadow: Return attacking enemy to the staging area after it attacks.")
                .WithInfo(45, 2, Artist.David_Lecossu);
            addTreachery("Sleeping Sentry", "Road to Rivendell")
                .WithTextLine("When Revealed: Deal 1 damage to each exhausted character. Then, exhaust all ready characters.")
                .WithShadow("Shadow: Defending player must discard all exhausted characters he controls.")
                .WithEasyModeQuantity(0)
                .WithInfo(46, 2, Artist.Tiziano_Baracchi);
            addTreachery("Followed by Night", "Road to Rivendell")
                .WithTextLine("When Revealed: The first player (choose 1): deals 1 damage to all allies in play and Followed by Night gains surge, or all enemies engaged with players make an immediate attack, if able.")
                .WithShadow("Shadow: Return attacking enemy to the staging area after it attacks.")
                .WithEasyModeQuantity(1)
                .WithInfo(47, 3, Artist.Jasper_Sandner);
            addTreachery("Orc Ambush", "Road to Rivendell")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: All Orc enemies in the staging area engage the first player. If there are no Orc enemies in the staging area, return all Orc enemies in the encounter discard pile to the staging area, if able.")
                .WithEasyModeQuantity(0)
                .WithInfo(48, 2, Artist.Anton_Kolyukh);
            addEnemy("Goblin Taskmaster", "Road to Rivendell", 27, 2, 2, 2, 4)
                .WithTraits("Goblin.", "Orc.")
                .WithKeywords("Ambush.")
                .WithTextLine("Ambush.")
                .WithTextLine("Forced: After Goblin Taskmaster engages a player, that player deals 2 damage to 1 character he controls.")
                .WithInfo(49, 4, Artist.Mike_Nash);
            addEnemy("Orc Raiders", "Road to Rivendell", 21, 1, 3, 1, 3)
                .WithTraits("Orc.")
                .WithKeywords("Ambush.")
                .WithTextLine("Ambush.")
                .WithTextLine("Forced: After Orc Raiders engages a player, that player discards 2 attachments he controls, if able.")
                .WithInfo(50, 3, Artist.Mark_Tarrisse);
            addEnemy("Crebain", "Road to Rivendell", 35, 2, 0, 0, 3)
                .WithTraits("Creature.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("While Crebain is in the staging area, encounter card effects cannot be canceled.")
                .WithShadow("Shadow: Return attacking enemy to the staging area after it attacks.")
                .WithInfo(51, 3, Artist.Allison_Theus);
            addEnemy("Wild Bear", "Road to Rivendell", 34, 0, 2, 3, 5)
                .WithTraits("Creature.")
                .WithKeywords("Ambush.")
                .WithTextLine("Ambush.")
                .WithTextLine("Forced: After Wild Bear engages a player, it makes an immediate attack.")
                .WithInfo(52, 3, Artist.Salvador_Trakal);
        }
    }
}
