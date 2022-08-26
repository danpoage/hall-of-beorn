/* Generated CardSet class: The Withered Heath */

using System;

namespace HallOfBeorn.Models.LotR.Sets.EredMithrin
{
    public class TheWitheredHeathSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Withered Heath";
            Abbreviation = "TWH";
            Number = 50;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Ered Mithrin";

            addHero("Grimbeorn the Old", 11, Sphere.Tactics, 0, 3, 3, 5)
                .WithTraits("Beorning.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Response: After Grimbeorn the Old defends an attack, spend 1 resource from his pool to declare him as an attacker against that enemy (and resolve his attack). The defending enemy gets -2 Defense for this attack.")
                .WithCommunityVersion("Grimbeorn-the-Old-Lure-2019")
                .WithCommunityVersion("Grimbeorn-the-Old-HoB-Alt-Art")
                .WithCommunityVersion("Grimbeorn-the-Old-Grimbeorn's-Path")
                .WithCommunityVersion("Grimbeorn-the-Old-All-the-Pretty-Horses")
                .WithCommunityVersion("RiddermarkLord/Grimbeorn-the-Old-1")
                .WithInfo(1, 1, Artist.Jason_Jenicke);
            addAlly("Guardian of Esgaroth", 2, Sphere.Leadership, false, 1, 1, 1, 1)
                .WithTraits("Dale.")
                .WithTextLine("Guardian of Esgaroth gets +1 Willpower, +1 Attack, +1 Defense, and +1 hit point for each different player card attachment it has. (Limit +3 to each.)")
                .WithFlavorLine("The men of the lake-town Esgaroth were mostly indoors, for the breeze was from the black East and chill, but a few were walking on the quays, and watching...")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(2, 3, Artist.Guillaume_Ducos);
            addAttachment("Squire's Helm", 1, Sphere.Leadership, false)
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to an ally. Restricted.")
                .WithTextLine("Limit 1 per ally.")
                .WithTextLine("Attached ally gets +2 hit points.")
                .WithFlavorLine("\"There are no great weapon-hoards here, lord,\" answered Éomer. \"Maybe a light helm might be found to fit him...\"")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(3, 3, Artist.Sara_Biddle);
            addAttachment("Woodmen's Clearing", 0, Sphere.Lore, false)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a location. Limit 1 per location.")
                .WithTextLine("Response: When attached location leaves play as an explored location, the first player reduces his threat by 3.")
                .WithInfo(4, 3, Artist.Mariusz_Gandzel);
            addEvent("The Hidden Way", 2, Sphere.Lore)
                .WithTextLine("Response: At the beginning of the quest phase, search the top 5 cards of the encounter deck for a location and make it the active location, returning any previous active location to the staging area. Then, reveal 1 less encounter card this phase (to a minimum of 0). Shuffle the encounter deck.")
                .WithInfo(5, 3, Artist.Preston_Stone);
            addAlly("Beorning Skin-changer", 2, Sphere.Tactics, false, 1, 1, 1, 3)
                .WithTraits("Beorning.")
                .WithTextLine("Combat Action: Choose a Beorning ally with printed cost 3 or more in your hand or discard pile. Discard ~Beorning Skin-changer to put that ally into play.")
                .WithFlavorLine("\"...sometimes he is a huge black bear, sometimes he is a great strong black-haired man with huge arms and a great beard.\"")
                .WithFlavorLine("-Gandalf, The Hobbit")
                .WithInfo(6, 3, Artist.Jason_Jenicke);
            addEvent("Beorn's Rage", 1, Sphere.Tactics)
                .WithTextLine("Response: After a Beorning character is declared as an attacker or defender against an enemy, that enemy gets -2 Attack and -2 Defense until the end of the phase.")
                .WithFlavorLine("Swiftly he returned and his wrath was redoubled, so that nothing could withstand him, and no weapon seemed to bite upon him. -The Hobbit")
                .WithInfo(7, 3, Artist.Guillaume_Ducos);
            addAlly("Long Lake Fisherman", 2, Sphere.Spirit, false, 1, 1, 0, 2)
                .WithTraits("Dale.")
                .WithTextLine("Response: After Long Lake Fisherman enters play, name a number. Then, search the top 5 cards of your deck for a card whose printed cost is equal to that number and add it to your hand. Shuffle your deck.")
                .WithInfo(8, 3, Artist.Tropa_Entertainment);
            addAttachment("Grey Cloak", 0, Sphere.Spirit, false)
                .WithTraits("Item.")
                .WithTextLine("Attach to a Spirit or Scout character. Limit 1 per character.")
                .WithTextLine("Encounter Action: Exhaust attached character and discard Grey Cloak to choose a non-unique enemy in the staging area. That enemy does not make engagement checks against you this phase.")
                .WithInfo(9, 3, Artist.Tropa_Entertainment);
            addAttachment("The Arkenstone", 1, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Guarded (enemy or location).")
                .WithTextLine("Guarded (enemy or location).")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Each unique character you control gains +1 Willpower.")
                .WithTextLine("Action: Reduce your threat by 2 to attach The Arkenstone to a hero controlled by another player and raise that player's threat by 2. (Limit once per round.)")
                .WithInfo(10, 3, Artist.Emilio_Rodriguez);
            addEnemy("Cold-Drake", EncounterSet.TheWitheredHeath, 10, 1, 6, 1, 18)
                .WithUnique()
                .WithTraits("Dragon.")
                .WithTextLine("Cannot have attachments or take non-combat damage.")
                .WithTextLine("Cold-Drake gets +1 Threat and +1 Defense for each ~Dragon ~Sign in the victory display.")
                .WithTextLine("Forced: After Cold-Drake is dealt a shadow card with no shadow effect, the defending character cannot ready until the end of the round.")
                .WithVictoryPoints(6)
                .WithInfo(11, 1, Artist.Matthew_Cowdery);
            addObjective("Dragon Sign", EncounterSet.TheWitheredHeath)
                .WithTraits("Clue.")
                .WithKeywords("Guarded (enemy).")
                .WithTextLine("Guarded (enemy).")
                .WithTextLine("Attached enemy or location is immune to player card effects.")
                .WithTextLine("When ~Dragon ~Sign is free of encounters, add it to the victory display.")
                .WithInfo(12, 4, Artist.Kamila_Szutenberg);
            addEnemy("Snow-troll", EncounterSet.TheWitheredHeath, 35, 3, 5, 3, 9)
                .WithTraits("Troll.")
                .WithTextLine("Cannot have player card attachments.")
                .WithTextLine("Forced: After Snow-troll attacks and destroys a character, return it to the staging area.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithEasyModeQuantity(1)
                .WithInfo(13, 2, Artist.Alex_Boca);
            addEnemy("Dragon Hatchling", EncounterSet.TheWitheredHeath, 20, 2, 2, 0, 4)
                .WithTraits("Dragon.")
                .WithTextLine("~Dragon Hatchling gets +1 Attack and +1 Defense for each ~Dragon ~Sign in the victory display.")
                .WithShadow("Shadow: Until the end of the phase, attacking enemy gets +1 Attack and +1 Defense for each ~Dragon ~Sign in the victory display.")
                .WithEasyModeQuantity(2)
                .WithInfo(14, 3, Artist.Mariusz_Gandzel);
            addLocation("Mountain Pass", EncounterSet.TheWitheredHeath, 2, 4)
                .WithTraits("Mountain.")
                .WithTextLine("While ~Mountain Pass is in the staging area, the 'when revealed' effects of Weather treachery cards cannot be canceled.")
                .WithFlavorLine("\"We may well be seen by watchers on that narrow path, and waylaid by some evil; but the weather may prove a more deadly enemy than any.\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithInfo(15, 3, Artist.Mariusz_Gandzel);
            addLocation("Dwarven Door", EncounterSet.TheWitheredHeath, 3, 3)
                .WithTraits("Mountain.")
                .WithKeywords("Deep.")
                .WithTextLine("Deep.")
                .WithTextLine("Progress cannot be placed on Dwarven Door while it is in the staging area.")
                .WithFlavorLine("\"Dwarf-doors are not made to be seen when shut.\"")
                .WithFlavorLine("-Gimli, The Fellowship of the Ring")
                .WithInfo(16, 3, Artist.Igor_Burlakov);
            addLocation("Cave Entrance", EncounterSet.TheWitheredHeath, 1, 5)
                .WithTraits("Mountain.")
                .WithKeywords("Deep.")
                .WithTextLine("Deep.")
                .WithTextLine("~Cave Entrance gets +1 Threat for each ~Dragon ~Sign in the victory display.")
                .WithTextLine("Travel: Raise each player’s threat by 1.")
                .WithFlavorLine("That, of course, is the dangerous part about caves: you don’t know how far they go back, sometimes, or where a passage behind may lead to, or what is waiting for you inside.")
                .WithFlavorLine("-The Hobbit")
                .WithEasyModeQuantity(2)
                .WithInfo(17, 3, Artist.Kamila_Szutenberg);
            addLocation("Creature Den", EncounterSet.TheWitheredHeath, 4, 4)
                .WithTraits("Mountain.")
                .WithTextLine("Response: After the players travel to ~Creature Den, search the Caves deck for a ~Dragon Sign and attach it to ~Creature Den as a guarded objective. Shuffle the Caves deck.")
                .WithTextLine("Travel: Shuffle the encounter discard pile into the encounter deck and discard cards from the top until an enemy is discarded. Add that enemy to the staging area.")
                .WithVictoryPoints(4)
                .WithInfo(18, 2, Artist.Nele_Diel);
            addLocation("High Falls", EncounterSet.TheWitheredHeath, Card.VALUE_X, 6)
                .WithTraits("Mountain.")
                .WithKeywords("Deep.")
                .WithTextLine("Deep.")
                .WithTextLine("X is the number of locations in the staging area.")
                .WithTextLine("Travel: Assign X damage among characters in play.")
                .WithFlavorLine("The roar of the great falls drew nearer.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithEasyModeQuantity(1)
                .WithInfo(19, 2, Artist.Leanna_Crossan);
            addTreachery("Heavy Snow", EncounterSet.TheWitheredHeath)
                .WithTraits("Weather.")
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Exhaust a character. Until the end of the round, characters cannot be readied by player card effect.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithEasyModeQuantity(1)
                .WithInfo(20, 2, Artist.Jose_Vega);
            addTreachery("Deadly Cold", EncounterSet.TheWitheredHeath)
                .WithTraits("Weather.")
                .WithTextLine("When Revealed: For each ready character a player controls, he must choose: either exhaust that character, or deal 1 damage to it.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if defending character is damaged).")
                .WithEasyModeQuantity(2)
                .WithInfo(21, 3, Artist.Davis_Engel);
            addQuest("Searching for Dragon Sign", EncounterSet.TheWitheredHeath, 1, 'A', 6)
                .WithTextLine("Setup: Set Cold-Drake and all four copies of ~Dragon ~Sign aside, out of play. Create the Caves deck (see insert) and set it next to the quest deck. Shuffle 2 set aside ~Dragon ~Sign objectives into the Caves deck. Shuffle the encounter deck and discard cards from the top until X locations are discarded, where X is the number of players. Add each discarded location to the staging area.")
                .WithFlavorLine("You have journeyed to the Withered Heath in search of a giant Dragon. There you discover tracks that lead you to the cold heights of the Grey Mountains.")
                .WithOppositeTextLine("Forced: After the active location is explored, look at the top 3 cards of the encounter deck. Reveal 1 of those cards and discard the rest.")
                .WithOppositeTextLine("The players cannot defeat this stage unless at least 1 ~Dragon ~Sign is in the victory display.")
                .WithOppositeFlavorLine("The Grey Mountains are a cold and untamed wilderness where nothing friendly dwells, and the weather is as real a danger to you as Dragons.")
                .WithIncludedEncounterSets(EncounterSet.LostCaves, EncounterSet.WildCreatures, EncounterSet.LostInWilderland)
                .WithInfo(22, 1, Artist.Anthony_Devine);
            addQuest("The Cold-Drake Attacks!", EncounterSet.TheWitheredHeath, 2, 'A', 3)
                .WithTextLine("When Revealed: Add the set-aside Cold-Drake to the staging area.")
                .WithFlavorLine("You've followed the Dragon tracks high up the Ered Mithrin mountain range to a sheltered hollow where you find the beast waiting for you. It lets out a roar that shakes the mountain, and rocks tumble down as it charges toward you in a rage!")
                .WithOppositeTextLine("Ignore the Deep keyword.")
                .WithOppositeTextLine("Cold-Drake cannot leave the staging area (even if it has damage equal to its hit points), but it is considered to be engaged with each player.")
                .WithOppositeTextLine("No more than 6 damage can be placed on Cold-Drake each round and it cannot have more than 18 damage.")
                .WithOppositeTextLine("This stage cannot be defeated while Cold-Drake has any hit points remaining.")
                .WithInfo(23, 1, Artist.Alvaro_Calvo_Escudero);
            addQuest("Hunting the Beast", EncounterSet.TheWitheredHeath, 3, 'A', 9)
                .WithTextLine("When Revealed: Shuffle 2 set-aside Dragon Sign objectives into the Caves deck. Set Cold-Drake aside, out of play. (Do not remove damage tokens from it.) Shuffle the encounter discard pile into the encounter deck and discard cards from the top until X locations are discarded, where X is the number of players. Add each discarded location to the staging area.")
                .WithFlavorLine("The injured drake retreats among the rising slopes of Ered Mithrin and you chase afterit, carefully searching each potential hiding place.")
                .WithOppositeTextLine("Forced: After the active location is explored, look at the top 3 cards of the encounter deck. Reveal 1 of those cards and discard the rest.")
                .WithOppositeTextLine("Forced: At the end of the round, remove 3 damage tokens from the set-aside Cold-Drake.")
                .WithOppositeTextLine("The players cannot defeat this stage unless at least 3 Dragon Signs are in the victory display.")
                .WithIncludedEncounterSets(EncounterSet.LostCaves, EncounterSet.WildCreatures, EncounterSet.LostInWilderland)
                .WithInfo(24, 1, Artist.Marius_Bota);
            addQuest("A Cornered Dragon", EncounterSet.TheWitheredHeath, 4, 'A', 0)
                .WithTextLine("When Revealed: Add Cold-Drake to the staging area. It makes an immediate attack against each player in turn order. (Deal and resolve a shadow card for each attack.)")
                .WithFlavorLine("At last you have cornered the injured Dragon. But with nowhere left to run, it attacks you with desperate fury. The men of Dale will make songs of this battle, if you survive to tell the story...")
                .WithOppositeTextLine("Cold-Drake cannot take more than X damage each round, where X is the number of Dragon Signs in the victory display.")
                .WithOppositeTextLine("Forced: At the beginning of the quest phase, return Cold-Drake to the staging area. It makes an immediate attack against each player in turn order.")
                .WithOppositeTextLine("This stage cannot be defeated while Cold-Drake is in play. When Cold-Drake is defeated, the players win the game.")
                .WithIncludedEncounterSets(EncounterSet.LostCaves, EncounterSet.WildCreatures, EncounterSet.LostInWilderland)
                .WithInfo(25, 1, Artist.Jokubas_Uoginitas);
        }
    }
}
