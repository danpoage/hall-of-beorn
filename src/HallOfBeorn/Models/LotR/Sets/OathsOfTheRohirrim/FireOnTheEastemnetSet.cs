using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.OathsOfTheRohirrim
{
    public class FireOnTheEastemnetSet
        : CardSet
    {
        protected override void Initialize()
        {
            Name = "Fire on the Eastemnet";
            Abbreviation = "FotE";
            Number = 10003;
            SetType = Models.SetType.A_Long_extended_Party;
            Cycle = "Oaths of the Rohirrim";

            addHero("Alagos", 12, Sphere.Leadership, 3, 3, 1, 4)
                .WithTraits("Creature", "Eagle")
                .WithTextLine("Cannot have restricted attachments.")
                .WithTextLine("Response: After an Eagle ally enters a player’s play area, add 1 resource to the pool of a hero that player controls. (Limit once per round.)")
                .WithFlavorLine("“What is all this uproar in the forest tonight?”")
                .WithFlavorLine("The Lord of the Eagles, The Hobbit")
                .WithInfo(38, 1, Artist.Ted_Nasmith);
            addHero("Faunith", 8, Sphere.Tactics, 2, 2, 1, 3)
                .WithTraits("Creature", "Eagle")
                .WithTextLine("Cannot have restricted attachments.")
                .WithTextLine("Quest Action: Play an Eagle ally from your hand. Then, you may exhaust that ally to either commit it to the quest or deal 1 damage to an enemy in the staging area.")
                .WithFlavorLine("Straight down upon the Nazgûl they bore, stooping suddenly out of the high airs…")
                .WithFlavorLine("The Return of the King")
                .WithInfo(39, 1, Artist.Snowblind_Studios);
            addAlly("Messenger of Manwë", 2, Sphere.Leadership, false, 1, 1, 0, 1)
                .WithTraits("Creature", "Eagle")
                .WithTextLine("Cannot defend or have restricted attachments.")
                .WithTextLine("Response: After Messenger of Manwë enters your play area, give an Eagle or Noble hero you control +1 Willpower until the end of the round.")
                .WithTextLine("Response: After Messenger of Manwë commits to the quest, give control of it to another player.")
                .WithInfo(40, 3, Artist.Ilya_Nazarov);
            addAlly("Veteran Eagle", 2, Sphere.Leadership, false, 1, 1, 1, 2)
                .WithTraits("Creature", "Eagle", "Warrior")
                .WithTextLine("Cannot have restricted attachments.")
                .WithTextLine("Response: After Veteran Eagle enters your play area, each copy of Veteran Eagle you control gets +1 Willpower, +1 Attack and +1 Defense until the end of the round.")
                .WithFlavorLine("But eagles have keen eyes and can see small things at a great distance.")
                .WithFlavorLine("The Hobbit")
                .WithInfo(41, 3, Artist.Gus_Hunter);
            addAlly("Chieftain of the Skies", 3, Sphere.Leadership, false, 0, 1, 3, 2)
                .WithTraits("Creature", "Eagle")
                .WithKeywords("Devoted")
                .WithTextLine("Devoted.")
                .WithTextLine("Cannot have restricted attachments.")
                .WithTextLine("Response: After Chieftain of the Skies enters your play area, ready an ally you control.")
                .WithFlavorLine("Behind them in long swift lines came all their vassals from the northern mountains.")
                .WithFlavorLine("The Return of the King")
                .WithInfo(42, 3, Artist.Oscar_Perez);
            addAttachment("Box of Earth", 1, Sphere.Lore, true)
                .WithTraits("Item", "Gift")
                .WithTextLine("Play only if you control a Noldor or Silvan hero.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Action: Exhaust Box of Earth to choose a location. Place 1 progress on that location and give it the Forest trait until the end of the round.")
                .WithFlavorLine("“It will not keep you on your road, nor defend you against any peril; but if you keep it… it may reward you.”")
                .WithFlavorLine("Galadriel, The Fellowship of the Ring")
                .WithInfo(43, 3, Artist.Edward_Beard_Jr);
            addAlly("Roving Herbmaster", 2, Sphere.Spirit, false, 1, 0, 0, 1)
                .WithTraits("Dúnedain", "Healer")
                .WithTextLine("Response: After a player reduces their threat, heal 1 damage from a character you control. Then, you may give control of Roving Herbmaster to another player. (Limit once per round.)")
                .WithFlavorLine("“Crush one in the water, and wash the wound clean, and I will bind it. Now it is your turn.”")
                .WithFlavorLine("Aragorn, The Fellowship of the Ring")
                .WithInfo(44, 3, Artist.Cubicle_7);
            addAlly("Grip", 2, Sphere.Tactics, true, 1, 1, 1, 1)
                .WithTraits("Creature")
                .WithTextLine("Limit 1 per deck. Cannot have attachments. Each enemy in play gets +1 engagement cost.")
                .WithTextLine("Response: After Grip enters play, search your deck for a Creature ally and add it to your hand. Until the end of the phase, that ally does not require a resource match. Shuffle your deck.")
                .WithInfo(45, 1, Artist.Damian_Audino);
            addAlly("Fang", 2, Sphere.Tactics, true, 1, 1, 1, 1)
                .WithTraits("Creature")
                .WithTextLine("Limit 1 per deck. Cannot have attachments. Each enemy in play gets +1 engagement cost.")
                .WithTextLine("Response: After Fang enters play, search your deck for a Creature ally and add it to your hand. Until the end of the phase, that ally does not require a resource match. Shuffle your deck.")
                .WithInfo(46, 1, Artist.Bethesda_Softworks);
            addAlly("Wolf", 2, Sphere.Tactics, true, 1, 2, 0, 1)
                .WithTraits("Creature")
                .WithTextLine("Limit 1 per deck. Cannot have attachments. Each enemy in play gets +1 engagement cost.")
                .WithTextLine("Response: After Wolf enters play, search your deck for a Creature ally and add it to your hand. Until the end of the phase, that ally does not require a resource match. Shuffle your deck.")
                .WithFlavorLine("…most ferocious of the three…")
                .WithFlavorLine("The Fellowship of the Ring")
                .WithInfo(47, 1, Artist.Bethesda_Softworks);
            addEvent("Hidden Roosts", 0, Sphere.Tactics)
                .WithTraits("Eagle")
                .WithTextLine("Response: When an Eagle ally leaves play, that ally’s controller reduces their threat by X, where X is the printed cost of the ally. If X is 2 or less, that player also draws 1 card.")
                .WithFlavorLine("“May the wind under your wings bear you where the sun sails and moon walks.”")
                .WithFlavorLine("Gandalf, The Hobbit")
                .WithInfo(48, 3, Artist.John_Howe);
            addEvent("Breath of Arda", 254, Sphere.Tactics)
                .WithTraits("Eagle")
                .WithTextLine("Encounter Action: Return X Eagle allies you own (under any player’s control) to your hand. Then, put each of those allies into play under any player’s control, one at a time. Remove Breath of Arda from the game.")
                .WithFlavorLine("“For we have need of speed greater than any wind.”")
                .WithFlavorLine("Gandalf, The Return of the King")
                .WithInfo(49, 3, Artist.Ted_Nasmith);
            addAttachment("Golden Crown", 1, Sphere.Neutral, true)
                .WithTraits("Item", "Artifact", "Eagle")
                .WithTextLine("Attach to an Eagle hero. Attached hero gains the Noble trait.")
                .WithTextLine("Action: Exhaust Golden Crown to choose an Eagle ally you own under any player’s control. Either discard that ally from play to add 1 resource to attached hero’s pool, or give control of that ally to a different player.")
                .WithInfo(50, 3, Artist.Jose_Derivaldo_Junior);
            addAttachment("Guided by Fate", 1, Sphere.Neutral, true)
                .WithTraits("Condition")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Response: When you would shuffle a set-aside card with the encounter keyword into the encounter deck, shuffle it into the top 5 cards instead.")
                .WithTextLine("Action: If the encounter deck has 5 or more cards in it, exhaust Guided by Fate and raise your threat by 1 to shuffle the top card of the encounter discard pile into the top 5 cards of the encounter deck.")
                .WithInfo(51, 3, Artist.Detlef_Ott);
            addObjective("Wild Steeds", EncounterSet.FireOnTheEastemnet)
                .WithTextLine("Forced: After an enemy enters play, place a steed from Wild Steeds on that enemy.")
                .WithTextLine("At the end of the round, if there are no steeds on Wild Steeds, the players lose the game.")
                .WithFlavorLine("“I’ll bet there’s all sorts of good things running wild in this country.”")
                .WithFlavorLine("Sam, The Two Towers")
                .WithInfo(52, 1, Artist.Behzat_Feyzullah);
            addObjective("Captured Steeds", EncounterSet.FireOnTheEastemnet)
                .WithTextLine("Forced: When an enemy leaves play by any means other than being defeated, move all steeds from that enemy onto Captured Steeds.")
                .WithTextLine("Forced: When a location leaves play by any means other than being explored, move all steeds from that location onto Captured Steeds.")
                .WithFlavorLine("Their horses were of great stature, strong and clean-limbed…")
                .WithFlavorLine("The Two Towers")
                .WithInfo(53, 1, Artist.Ken_Stroud);
            addEnemy("Morgahk", EncounterSet.FireOnTheEastemnet, 50, 3, 6, 4, 8)
                .WithUnique()
                .WithTraits("Orc", "Mordor")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Forced: At the beginning of the quest phase, Morgahk makes an immediate attack against the first player.")
                .WithTextLine("Forced: After Morgahk attacks and destroys a character, each enemy in the staging area captures its steeds.")
                .WithVictoryPoints(5)
                .WithInfo(54, 1, Artist.Dane_Madgwick);
            addLocation("Shores of Anduin", EncounterSet.FireOnTheEastemnet, 4, 8)
                .WithTraits("River")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("While Shores of Anduin is in the victory display, the current quest gains “Response: When an enemy is destroyed, move X steeds from Captured Steeds to Wild Steeds. X is the destroyed enemy’s printed Threat.”")
                .WithTextLine("Travel: Each enemy in the staging area captures its steeds.")
                .WithVictoryPoints(5)
                .WithInfo(55, 1, Artist.Unknown);
            addEnemy("White Mountain Beastmaster", EncounterSet.FireOnTheEastemnet, 45, 2, 5, 2, 6)
                .WithTraits("Orc")
                .WithTextLine("Forced: After White Mountain Beastmaster engages you, either it makes an immediate attack, or it captures its steeds.")
                .WithShadow("Shadow: Either the attacking enemy makes an additional attack after this one, or it captures its steeds.")
                .WithEasyModeQuantity(1)
                .WithInfo(56, 2, Artist.Turbine);
            addEnemy("Orc Lookout", EncounterSet.FireOnTheEastemnet, 30, 3, 3, 2, 4)
                .WithTraits("Orc", "Snaga")
                .WithTextLine("Forced: At the end of the combat phase, Orc Lookout captures its steeds.")
                .WithShadow("Shadow: Either the attacking enemy cannot take damage this round, or it captures its steeds.")
                .WithInfo(57, 2, Artist.Bethesda_Softworks);
            addEnemy("Orcish Wrangler", EncounterSet.FireOnTheEastemnet, 28, 1, 2, 3, 2)
                .WithTraits("Orc")
                .WithKeywords("Surge")
                .WithTextLine("Surge.")
                .WithTextLine("Forced: When Orcish Wrangler attacks, move a steed from the active location to Orcish Wrangler.")
                .WithShadow("Shadow: If there are more steeds on Wild Steeds than on Captured Steeds, attacking enemy captures its steeds.")
                .WithEasyModeQuantity(2)
                .WithInfo(58, 3, Artist.Leo_Li);
            addLocation("Open Meadows", EncounterSet.FireOnTheEastemnet, 1, 3)
                .WithTraits("Plains")
                .WithKeywords("Steeds 2")
                .WithTextLine("Steeds 2.")
                .WithTextLine("While Open Meadows is in the staging area, it gains: “Forced: At the end of the combat phase, add the topmost enemy in the encounter discard pile to the staging area.”")
                .WithVictoryPoints(1)
                .WithInfo(59, 3, Artist.Johannes_Voss);
            addLocation("Entwash Crossings", EncounterSet.FireOnTheEastemnet, 3, 3)
                .WithTraits("Plains", "River")
                .WithKeywords("Steeds 3")
                .WithTextLine("Steeds 3.")
                .WithTextLine("Travel: Search the encounter discard pile for an enemy and put it into play engaged with the first player.")
                .WithFlavorLine("There the herdsmen had wandered much, living in camp and tent, even in winter-time. But now all the land was empty.")
                .WithFlavorLine("The Two Towers")
                .WithVictoryPoints(1)
                .WithInfo(60, 2, Artist.Ferdinand_Ladera);
            addLocation("Eastemnet Pasture", EncounterSet.FireOnTheEastemnet, 2, 2)
                .WithTraits("Plains", "Hills")
                .WithKeywords("Steeds 1 Per Player")
                .WithTextLine("Steeds 1Per Player.")
                .WithTextLine("Progress cannot be placed on locations in the staging area.")
                .WithFlavorLine("The swelling grass-lands rose and fell like a wide grey sea.")
                .WithFlavorLine("The Two Towers")
                .WithVictoryPoints(1)
                .WithInfo(61, 3, Artist.Michael_Komarck);
            addLocation("Pillaged Stables", EncounterSet.FireOnTheEastemnet, 2, 3)
                .WithTraits("Plains", "Village")
                .WithKeywords("Steeds 4")
                .WithTextLine("Steeds 4.")
                .WithTextLine("Forced: At the end of the round, if there are any steeds remaining on Pillaged Stables, move 1 steed from Pillaged Stables to Captured Steeds. The first player may raise their threat by 2 to cancel this effect.")
                .WithShadow("Shadow: If this attack destroys a character, the attacking enemy captures its steeds.")
                .WithVictoryPoints(1)
                .WithInfo(62, 3, Artist.Marta_Grajper);
            addLocation("Hidden Orc Camp", EncounterSet.FireOnTheEastemnet, 2, 5)
                .WithTraits("Camp")
                .WithKeywords("Steeds 1")
                .WithTextLine("Steeds 1.")
                .WithTextLine("Hidden Orc Camp gets +1 Threat for each steed on it.")
                .WithTextLine("Forced: At the end of the combat phase, move a steed from a non-Camp location to Hidden Orc Camp.")
                .WithTextLine("Travel: Each player exhausts a character they control.")
                .WithVictoryPoints(1)
                .WithEasyModeQuantity(1)
                .WithInfo(63, 2, Artist.James_Paick);
            addTreachery("Panicked Horses", EncounterSet.FireOnTheEastemnet)
                .WithTextLine("When Revealed: Move a steed from Wild Steeds to each enemy in play. If there are less than 1Per Player enemies in play, search the encounter deck and discard pile for an enemy and add it to the staging area. Shuffle the encounter deck if searched.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if there are more steeds on Wild Steeds than on Captured Steeds).")
                .WithInfo(64, 2, Artist.Willem_Haenraets);
            addTreachery("Cracking Horse Whip", EncounterSet.FireOnTheEastemnet)
                .WithTextLine("When Revealed: For each ready character a player controls, they must choose: either exhaust that character, or deal 1 damage to it. If there are more steeds on Wild Steeds than on Captured Steeds, Cracking Horse Whip gains surge.")
                .WithFlavorLine("“Where there’s a whip there’s a will, my slugs.”")
                .WithFlavorLine("The Return of the King")
                .WithEasyModeQuantity(1)
                .WithInfo(65, 2, Artist.Ubisoft);
            addTreachery("Exhausted Pursuit", EncounterSet.FireOnTheEastemnet)
                .WithTextLine("When Revealed: Either each enemy in play captures its steeds, or exhaust each damaged character.")
                .WithShadow("Shadow: Exhaust a damaged character you control.")
                .WithFlavorLine("Dazed as he was with pain and weariness, Sam woke up…")
                .WithFlavorLine("The Return of the King")
                .WithInfo(66, 2, Artist.Rob_Joseph);
            addEncounterSideQuest("Expanded Search", EncounterSet.FireOnTheEastemnet, 6)
                .WithTextLine("Forced: After an enemy is engaged, either move a steed from Wild Steeds to Captured Steeds or that enemy gets +3 Attack until the end of the round.")
                .WithFlavorLine("The orcs seem to have picked up some scent, and have begun searching the ground near a place where you once stopped to rest.")
                .WithVictoryPoints(10)
                .WithInfo(67, 1, Artist.Veli_Nystrom);
            addQuest("Poachers in the Night", EncounterSet.FireOnTheEastemnet, 1, 'A', 8)
                .WithTextLine("Setup: Set Shores of Anduin, Orc Battalion, and Morgahk aside, out of play. Make a copy of Pillaged Stables the active location. Add Wild Steeds, Captured Steeds, and 1 copy of Eastemnet Pastures to the staging area. Place 1 plus 3Per Player steeds on Wild Steeds. Each player searches the encounter deck for a different enemy and adds it to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("Side A: With fire and whip, the orc-host has regrouped to rob Rohan of its prized steeds. Side B: Setting out from the stables, you attack the horse-thieves head on! Push them back from the fields before they make away with their stolen beasts.")
                .WithOppositeTextLine("Steeds 3Per Player.")
                .WithOppositeTextLine("Forced: At the end of the round, move 1Per Player steed from this stage to Captured Steeds. If there are no steeds remaining here, advance to the next stage.")
                .WithIncludedEncounterSets(EncounterSet.OrcHost)
                .WithInfo(68, 1, Artist.Brian_Vadell);
            addQuest("Relentless Forces", EncounterSet.FireOnTheEastemnet, 2, 'A', 12)
                .WithTextLine("When Revealed: Shuffle the encounter discard pile into the encounter deck. The first player adds Orc Battalion to the staging area. Each other player discards cards from the top of the encounter deck until an enemy is discarded and adds that enemy to the staging area.")
                .WithFlavorLine("Side A: Raging after the defeat of warchief Thruk, the orc-host masses over the countryside, wreaking havoc. “On, on!” they cry, baying for horse-meat. Side B: The orcs will not be satisfied until they reap the fields of stallion and mare. Flank them and scatter them to the east!")
                .WithOppositeTextLine("Steeds 3Per Player.")
                .WithOppositeTextLine("Forced: At the end of the round, if there are any enemies in play, move 1Per Player steeds from this stage to Captured Steeds.")
                .WithOppositeTextLine("This stage cannot be defeated while Orc Battalion is in play.")
                .WithIncludedEncounterSets(EncounterSet.OrcHost)
                .WithInfo(69, 1, Artist.Borkur_Eiriksson);
            addQuest("To the River!", EncounterSet.FireOnTheEastemnet, 3, 'A', 15)
                .WithTextLine("When Revealed: Shuffle the encounter discard pile into the encounter deck. The first player adds Shores of Anduin and Morgahk to the staging area. Each other player discards cards from the top of the encounter deck until an enemy is discarded and adds that enemy to the staging area.")
                .WithFlavorLine("The last of the orcs rally to their leader, the warchief Morgahk. Now is the moment to break their formation and press them with force of arms and strength of will.")
                .WithOppositeTextLine("Morgahk cannot leave the staging area unless there are at least 15 progress tokens here.")
                .WithOppositeTextLine("Forced: At the end of the round, return each engaged enemy to the staging area. If there are more steeds on Wild Steeds than on Captured Steeds, each enemy in the staging area captures its steeds.")
                .WithOppositeTextLine("The players cannot defeat this stage while Morgahk is in play. After Morgahk is destroyed, if there are more steeds on Wild Steeds than on Captured Steeds, the players win the game. Otherwise, the players lose the game.")
                .WithIncludedEncounterSets(EncounterSet.OrcHost)
                .WithInfo(70, 1, Artist.Wouter_Florusse);
        }
    }
}