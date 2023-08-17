/* Generated CardSet class: Wrath and Ruin */

using System;

namespace HallOfBeorn.Models.LotR.Sets.VengeanceOfMordor
{
    public class WrathAndRuinSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Wrath and Ruin";
            Abbreviation = "WaR";
            Number = 57;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Vengeance of Mordor";

            addHero("Thorin Stonehelm", 9, Sphere.Tactics, 1, 3, 1, 4)
                .WithTraits("Dwarf.", "Noble.", "Warrior.")
                .WithTextLine("Response: After Thorin Stonehelm is declared as an attacker, discard the top card of your deck to deal 1 damage to an enemy engaged with you.")
                .WithFlavorLine("Thorin III Stonehelm, Dain's son, became King under the mountain.")
                .WithFlavorLine("-The Return of the King")
                .WithYear(2019)
                .WithCommunityVersion("Autumn/Thorin-Stonehelm")
                .WithCommunityVersion("RiddermarkLord/Thorin-Stonehelm-1")
                .WithCommunityVersion("RiddermarkLord/Thorin-Stonehelm-2")
                .WithInfo(1, 1, Artist.Rafal_Hrynkiewicz);
            addAlly("Soldier of Gondor", 2, Sphere.Leadership, false, 1, 1, 1, 2)
                .WithTraits("Gondor.")
                .WithTextLine("Response: After Soldier of ~Gondor enters play, seach the top 5 cards of your deck for a Gondor ally and add it to your hand (any number of Gondor allies instead if your threat is 40 or higher). Shuffle your deck.")
                .WithInfo(2, 3, Artist.Stanislav_Dikolenko);
            addEvent("Pillars of the Kings", 4, Sphere.Leadership)
                .WithTextLine("While your threat is less than 40, reduce the cost to play Pillars of the Kings by 4.")
                .WithTextLine("Action: Set your threat to 40. If this effect raised your threat, draw a card (draw 4 cards instead if it raised your threat by 10 or more).")
                .WithFlavorLine("\"Behold the Argonath, the Pillars of the Kings!\"")
                .WithFlavorLine("-Aragorn, The Fellowship of the Ring")
                .WithInfo(3, 3, Artist.Sam_White);
            addAlly("Cautious Halfling", 2, Sphere.Lore, false, 1, 0, 1, 2)
                .WithTraits("Hobbit.")
                .WithTextLine("Response: After Cautious Halfling enters play, look at the top card of the encounter deck. If that card is not an enemy, draw a card.")
                .WithFlavorLine("\"I thought I had been both careful and clever.\"")
                .WithFlavorLine("-Frodo, The Fellowship of the Ring")
                .WithInfo(4, 3, Artist.Sara_Biddle);
            addEvent("Tom Bombadillo!", 2, Sphere.Lore)
                .WithTraits("Song.")
                .WithTextLine("Play only if you control a Hobbit hero. You cannot play this card if there is a copy of Tom Bombadillo! in the victory display.")
                .WithTextLine("Planning Action: Add Tom Bombadillo the the victory display to shuffle a set-aside copy of Tom Bombadil into the encounter deck.")
                .WithInfo(5, 3, Artist.David_Keen);
            addAttachment("Durin's Axe", 1, Sphere.Tactics, true)
                .WithTraits("Artifact.", "Item.", "Weapon.")
                .WithKeywords("Guarded (enemy).", "Restricted.")
                .WithTextLine("Guarded (enemy). Restricted.")
                .WithTextLine("Attach to a hero. Attached hero gets +2 Attack.")
                .WithTextLine("Response: After attach hero attacks and destroys an enemy, deal 1 damage to an enemy engaged with you.")
                .WithInfo(6, 3, Artist.Nino_Vecia);
            addEvent("Charge into Battle", 5, Sphere.Tactics)
                .WithTextLine("Play only after staging step.")
                .WithTextLine("Quest Action: You may declare and resolve an attack against each non-unique enemy in the staging area as if it were engaged with you.")
                .WithFlavorLine("Panic came upon the Goblins; and even as they turned to meet this new attack, the elves charged again with renewed numbers.")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(7, 3, Artist.Vilius_Petrauskas);
            addAttachment("Silver Circlet", 2, Sphere.Spirit, false)
                .WithTraits("Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Spirit hero. Limit 1 per hero.")
                .WithTextLine("Restricted.")
                .WithTextLine("Attached hero gets +2 Willpower.")
                .WithFlavorLine("His hair was dark as the shadows of twilight, and upon it was set a circlet of silver...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(8, 3, Artist.David_Keen);
            addAttachment("Inner Strength", 1, Sphere.Spirit, false)
                .WithTraits("Master.")
                .WithTextLine("Attach to the hero with The One Ring.")
                .WithTextLine("Limit 1 per hero. Attached hero gets +1 Defense.")
                .WithTextLine("Response: Exhaust The One Ring and raise your threat by 1 to cancel a shadow effect just triggered during an attack that attached hero is defending.")
                .WithInfo(9, 3, Artist.Justin_Gerard);
            addAlly("Tom Bombadil", 255, Sphere.Neutral, true, 3, 3, 3, 6)
                .WithTraits("Legend.")
                .WithKeywords("Encounter.")
                .WithTextLine("Encounter.")
                .WithTextLine("When Revealed: Choose a player. That player gains control of Tom Bombadil, ready and committed to the quest. At the end of the round, remove Tom Bombadil and a copy of Tom Bombadillo! in the victory display from the game. This effect cannot be cancelled.")
                .WithInfo(10, 3, Artist.Borja_Pindado);
            addEnemy("Thane Ulchor", EncounterSet.WrathAndRuin, 50, 1, 6, 4, 9)
                .WithUnique()
                .WithTraits("Mordor.")
                .WithTextLine("Immune to player card effects. Cannot leave the staging area.")
                .WithTextLine("Forced: After the active location is explored, the first player must choose: either discard cards from the top of the encounter deck until a location is discarded and add it to the staging area, or Thane Ulchor attacks you.")
                .WithVictoryPoints(6)
                .WithInfo(11, 1, Artist.Antonio_Jose_Manzanedo);
            addEnemy("Champion of Rhûn", EncounterSet.WrathAndRuin, 36, 2, 5, 2, 5)
                .WithTraits("Easterling.")
                .WithTextLine("Forced: After Champion of Rhûn engages you, either return a location you control to the staging area, or Champion of Rhûn makes an attack.")
                .WithShadow("Shadow: Deal 1 damage to defending character.")
                .WithInfo(12, 2, Artist.Martin_de_Diego_Sadaba);
            addEnemy("Easterling Skirmisher", EncounterSet.WrathAndRuin, 30, 1, 4, 1, 3)
                .WithTraits("Easterling.")
                .WithKeywords("Surge.", "Archery 1.")
                .WithTextLine("Surge. Archery 1.")
                .WithTextLine("Forced: After Easterling Skirmisher attacks and destroys a character, that character's controller must return the location he controls with the highest Threat to the staging area.")
                .WithEasyModeQuantity(2)
                .WithInfo(13, 4, Artist.Stanislav_Dikolenko);
            addLocation("Gate of Dorwinion", EncounterSet.WrathAndRuin, Card.VALUE_X, 5)
                .WithUnique()
                .WithTraits("City.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("X is 1 more than the number of locations controlled by the players.")
                .WithTextLine("The players cannot travel here unless stage 2B has at least 12 progress on it.")
                .WithTextLine("Travel: Thane Ulchor attacks each player in turn order.")
                .WithVictoryPoints(5)
                .WithInfo(14, 1, Artist.Emilio_Rodriguez);
            addLocation("Contested Square", EncounterSet.WrathAndRuin, 1, 3)
                .WithTraits("City.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Forced: After an enemy is defeated, place 1 progress on Contested Square if it is in the staging area.")
                .WithTextLine("While you control Contested Square, it gains: \"Forced: After a character you control is destroyed, if you control Contested Square, returns Contested Square to the staging area.\"")
                .WithEasyModeQuantity(2)
                .WithInfo(15, 3, Artist.Kevin_Zamir_Goeke);
            addLocation("Ransacked House", EncounterSet.WrathAndRuin, 2, 4)
                .WithTraits("City.")
                .WithTextLine("Encounter Action: Put the topmost enemy in the encounter discard pile into play engaged with you to take control of Ransacked House.")
                .WithTextLine("While you control Ransacked House, it gains: \"Forced: After the player who controls Ransacked House loses control of a location, return Ransacked House to the staging area.\"")
                .WithInfo(16, 3, Artist.Davis_Engel);
            addLocation("Makeshift Fortification", EncounterSet.WrathAndRuin, 3, 3)
                .WithTraits("City.")
                .WithTextLine("While Makeshift Fortification is the active location, it gains archery 3.")
                .WithTextLine("Forced: After a player takes control of Makeshift Fortification, return the topmost enemy in the encounter discard pile to the staging area.")
                .WithEasyModeQuantity(2)
                .WithInfo(17, 3, Artist.Davis_Engel);
            addLocation("Captured Tower", EncounterSet.WrathAndRuin, 4, 4)
                .WithTraits("City.")
                .WithTextLine("While Captured Tower is the active location, encounter card effects cannot be canceled.")
                .WithTextLine("Forced: After a player takes control of Captured Tower, he shuffles the encounter discard pile into the encounter deck and discards cards from the top until he discards an enemy and puts that enemy into play engaged with him.")
                .WithEasyModeQuantity(1)
                .WithInfo(18, 2, Artist.Emilio_Rodriguez);
            addTreachery("Fury", EncounterSet.WrathAndRuin)
                .WithTraits("Easterling.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("While attached to an enemy, counts as a Condition attachment with the text: \"Forced: When attached enemy would be destroyed, heal all damage from it and discard Fury instead.\"")
                .WithTextLine("When Revealed: Attach to the lowest engagement cost Easterling enemy without Fury.")
                .WithEasyModeQuantity(1)
                .WithInfo(19, 2, Artist.Martin_de_Diego_Sadaba);
            addTreachery("Caught Off Guard", EncounterSet.WrathAndRuin)
                .WithTextLine("When Revealed: Each player must choose: either return a location you control to the staging area, or discard cards from the top of the encounter deck until an enemy is discarded and put it into play engaged with you.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithEasyModeQuantity(1)
                .WithInfo(20, 2, Artist.Monztre);
            addTreachery("Street Fighting", EncounterSet.WrathAndRuin)
                .WithTextLine("When Revealed: Each player assigns X damage among characters he controls, where X is 1 more than the number of locations he controls.")
                .WithShadow("Shadow: Assign X damage among characters you control, where X is 1 more than the number of locations you control.")
                .WithInfo(21, 2, Artist.Chris_Grun);
            addTreachery("Under Siege", EncounterSet.WrathAndRuin)
                .WithTextLine("When Revealed: Until the end of the phase, add X Threat to the staging area, where X is 1 more than the number of locations the players control.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, return the highest Threat location you control to the staging area.")
                .WithInfo(22, 2, Artist.Vilius_Petrauskas);
            addTreachery("Ulchor's Revenge", EncounterSet.WrathAndRuin)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Thane Ulchor makes an immediate attack against each player that controls a location (in turn order).")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each location you control.")
                .WithEasyModeQuantity(1)
                .WithInfo(23, 2, Artist.Imad_Awan);
            addContract("The Burglar's Turn")
                .WithTextLine("You cannot include attachments in your deck.")
                .WithTextLine("Setup: Choose 14 different Item or Artifact attachments from your collection and shuffle them together. This is your loot deck. Flip this card over and place your loot deck facedown under it.")
                .WithFlavorLine("\"And I assure you there is a mark on this door - the usual one in the trade, or used to be. Burglar wants a good job, plenty of Excitement and reasonably Reward, that's how it is usually read.")
                .WithFlavorLine("-Glóin, The Hobbit")
                .WithOppositeTextLine("The active location gets +1 quest point for each attachment attached to it.")
                .WithOppositeTextLine("Forced: After you travel to a location, attach the top card of your loot deck faceup to that location as a guarded objective. If that attachment has the guarded X keyword, ignore it.")
                .WithOppositeTextLine("Forced: When the active location is explored, you may put each guarded attachment on that location into play at no cost, or add it to your hand.")
                .WithInfo(24, 1, Artist.Greg_Bobrowski);
            addQuest("Inside the Walls", EncounterSet.WrathAndRuin, 1, 'A', 4)
                .WithTextLine("Setup: Add Thane Ulchor and Gate of Dorwinion to the staging area. Each player adds a different location to the staging area. Make a copy of Makeshift Fortification the active location. Shuffle the enocounter deck.")
                .WithFlavorLine("Thane Ulchor has returned to Dorwinion at night with an army of Easterlings. His agents within the city slew the guards and opened the gate to let them in. You wake to find battle already raging in the streets.")
                .WithOppositeTextLine("The stage gets +4 quest points per player. Progess cannot be placed on locations in the staging area by player card effects.")
                .WithOppositeTextLine("Forced: When a location is explored, the first player takes control of it.")
                .WithOppositeTextLine("The stage cannot be defeated unless there are more locations under the players' control than in the staging area at the end of the round.")
                .WithIncludedEncounterSets(EncounterSet.EasterlingRaiders, EncounterSet.CityOfRhun)
                .WithInfo(25, 1, Artist.Imad_Awan);
            addQuest("Drive them Out", EncounterSet.WrathAndRuin, 2, 'A', 12)
                .WithTextLine("When Revealed: Each player returns the highest Threat location he controls to the staging area. Shuffle the encounter discard pile into the encounter deck. Starting with the first player, each player discards cards from the top of the encounter deck until he discards an enemy and puts that enemy into play engaged with him.")
                .WithFlavorLine("After hours of hard fighting, you have gained the upper hand, but the battle will not be won until Ulchor and his army are driven out of the city.")
                .WithOppositeTextLine("Progress cannot be placed on locations in the staging area by player card effects.")
                .WithOppositeTextLine("The players cannot travel to Gate of Dorwinion unless there are more locations under the players control than in the staging area.")
                .WithOppositeTextLine("Forced: When a location is explored, the first player takes control of it.")
                .WithOppositeTextLine("At the end of the round, if the players control Gate of Dorwinion, they win the game.")
                .WithIncludedEncounterSets(EncounterSet.EasterlingRaiders, EncounterSet.CityOfRhun)
                .WithInfo(26, 1, Artist.Martin_de_Diego_Sadaba);
        }
    }
}
