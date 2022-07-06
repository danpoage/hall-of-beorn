using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.PrintOnDemand
{
    public class TheRuinsOfBelegost : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Ruins of Belegost";
            Abbreviation = "TRoB";
            Number = 3006;
            SetType = Models.SetType.GenCon_Expansion;
            Cycle = "GenCon";

            Cards.Add(new LotRCard()
            {
                Title = "The Ruins of Belegost Scenario Rules (1)",
                CardType = CardType.GenCon_Setup,
                Text = 
@"... in the ancient cities of Nogrod and Belegost
in the Blue Mountains were ruined at the 
breaking of Thangorodrim.
            -The Return of the King

Explore flooded ruins and encounter ancient evils in The Ruins of Belegost, a scenario designed for The Lord of the ~Rings: The Card Game special event at Gen Con 2015. This scenario can be played in both standard mode and easy mode, remove each card with a gold-bordered encounter set icon from the encounter deck and add 1 resource to each hero's resource pool when setting up the game.

Expansion Symbol

The cards in The Ruins of Belegost scenario can be identified by this symbol before each card's collector number.

Page 1/4",
                CardNumber = 0,
                Quantity = 1
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Ruins of Belegost Scenario Rules (2-3)",
                CardType = CardType.GenCon_Setup,
                Text = 
@"SCENARIO RULES
Discover X
Discover is a new keyword in The Ruins of Belegost. The Discover keyword represents the heroes' search for lost treasure, as well as the unexpected dangers they encounter as they travel to the different locations in Belegost. When a location with the Discover keyword becomes the active location, the first player resolves the following steps in order:

1. Look at the top X cards of the encounter deck, where X is the active locations Discover value.

2. Choose 1 looked at objective with the Loot keyword and attach it to the active location as a guarded objective.

3. Randomly select 1 looked at card with the Hazard trait, reveal it and add it to the staging area.

4. Place any remaining looked at cards in the encounter discard pile.

Page 2/4",
                OppositeText = 
@"Discover X (continued)

If there are less than X cards remaining in the encounter deck when resolving the Discover keyword, shuffle the encounter discard pile into the encounter deck and continue resolving the Discover keyword.

Loot

Loot is a new keyword that appears on some objective cards in The Ruins of Belegost. Objectives with the Loot keyword are valuable treasures that can only be discovered by exploring the different locations in Belegost. A Loot card can only enter play by resolving the Discover keyword on a location.

If a card with the Loot keyword is revealed from the encounter deck, discard it and reveal another card from the top of the encounter deck.

Page 3/4",
                CardNumber = 0
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Ruins of Belegost Scenario Rules (4)",
                CardType = CardType.GenCon_Setup,
                Text = 
@"Taking Control of Loot

When the encounter card guarding a Loot objective leaves play, the first player must immediately attach that Loot objective to a hero he controls. If a Loot objective is attached to the active location when the players make enough progress to explore the active location and advance to the next stage, the first player takes control of the Loot objective before advancing to the next stage.

Immune to player card effects

Cards with the text 'Immune to player card effects' ignore the effects of all player cards. Additionally, cards that are immune to player card effects cannot be chosen as targets of player card effects.

Page 4/4",
                CardNumber = 0
            });
            addHero("Gimli", 11, Sphere.Tactics, 2, 2, 2, 5)
                .WithTraits("Dwarf.", "Noble.", "Warrior.")
                .WithText("Gimli gets +1 Attack for each damage token on him.")
                .WithTemplate("<p>{self} gets +1 {Attack} for each damage token on him.</p>")
                .WithPromotion()
                .WithInfo(4, 1, Artist.Sebastian_Giacobino);
            Cards.Add(LotRCard.Quest("Ruins of the First Age", 1, "The Ruins of Belegost", 6)
                .WithText("Setup: Add Stalking the Ruins and 1 copy of Abandoned Mine per player to the staging area. Set Lurker of the Depths, Naurlhûg, Naurlhûg's Lair, and Sword of Belegost aside, out of play. Randomly select 1 of the 5 remaining Loot objectives and place it facedown underneath Stalking the Ruins (without looking). Shuffle the others into the encounter deck (without looking at them).")
                .WithFlavor("You have entered the dark, half-sunken ruins of Belegost in search of powerful artifacts and ancient treasure.")
                .WithOppositeText("The player cannot advance unless they control at least 1 Loot objective.\r\nForced: At the beginning of the travel phase, if there are no locations in play, return the topmost location in the encounter discard pile to the staging area.\r\nForced: When this stage is defeated, if Keys of Belegost is attached to a hero, advace to stage 2C. Otherwise, advance to Stage 2A.")
                .WithOppositeFlavor("Inside the Dwarven city, you can feel an evil presence stalking you...")
                .WithInfo(1, 1, Artist.Wibben));
            Cards.Add(LotRCard.Quest("Ancient Evils Disturbed", 2, "The Ruins of Belegost", 9)
                .WithText("When Revealed: Add Lurker of the Depths to the staging area.")
                .WithFlavor("As you explore the partially flooded ruins of Belegost, you feel something wet and leathery brush past your leg. The sound of thrashing water echoes from somewhere in the darkness ahead of you, when suddenly a horde of slimy, black tentacles strike at you!")
                .WithOppositeFlavor("Some hideous creature of a forgotten age attacks your party. You must defeat it if you hope to leave Belegost alive.")
                .WithOppositeText("The players cannot advance unless they control at least 2 Loot objectives and Lurker of the Depths is in the victory display.\r\nForced: When this stage is defeated, if Book of Aulë's Children is attached to a hero, advance to stage 3C. Otherwise, advance to stage 3A.")
                .WithInfo(2, 1, Artist.Ethan_Patrick_Harris));
            Cards.Add(LotRCard.Quest("Deeper into the Past", 2, "The Ruins of Belegost", 9, 'C')
                .WithText("When Revealed: Shuffle Lurker of the Depths and the encounter discard pile into the encounter deck. Discard cards from the top of the encounter deck until a location is discarded. Add the discarded location to the staging area.")
                .WithFlavor("The keys you discovered unlock a passage that leads deeper into the mines of Belegost. As you descend further into the Dwarven city, you marvel at the enormity of its size and the complexity of its design.")
                .WithOppositeText("The player cannot advance unless they control at least 2 Loot objectives and there are at least 3 resources here.\r\nForced: After the active location is explored, place 1 resource here.\r\nForced: When this stage is defeated, if Book of Aulë's Children is attached to a hero, advance to stage 3E. Otherwise, advance to stage 3C.")
                .WithOppositeFlavor("You must carefully explore the ruins to ensure you don't miss anything.")
                .WithInfo(3, 1, Artist.Yoann_Boissonnet));
            Cards.Add(LotRCard.Quest("The Servants of Morgoth", 3, "The Ruins of Belegost", 6)
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck and reveal 1 encounter card per player.")
                .WithFlavor("Your journey into Belegost has captured the attention of the many foul creatures that now dwell there. Evil creatures that lay hidden for countless years now stir in the darkness around you. You need a light to ward them off.")
                .WithOppositeText("The first Hazard card revealed each round gains surge.\r\nDuring the travel phase, the players must travel to a location, if able.\r\nForced: When this stage is defeated, if Dwarven Torch is attached to a hero, advance to stage 4A. Otherwise advance to stage 3C.")
                .WithInfo(4, 1, Artist.Wibben));
            Cards.Add(LotRCard.Quest("The Roots of Ered Luin", 3, "The Ruins of Belegost", 6, 'C')
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck and reveal 1 encounter card per player.")
                .WithFlavor("Your exploration of Belegost has brought you down to the very roots of the Ered Luin mountain range. Here, in the utter black, a patchwork of tunnels and pitfalls create an impassable labyrith. You need a map to find your way...")
                .WithOppositeText("The Discover value on the active location is increased by 1.\r\nDuring the travel phase, the players must travel to a location, if able.\r\nForced: When this stage is defeated, if Map of Ered Luin is attached to a hero advance to stage 4A. Otherwise, advance to stage 3E.")
                .WithInfo(5, 1, Artist.Yoann_Boissonnet));
            Cards.Add(LotRCard.Quest("The Mines of Belegost", 3, "The Ruins of Belegost", 6, 'E')
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck and reveal 1 encounter card per player.")
                .WithFlavor("The book you recovered explains how the Dwarves kept their treasure in secret vaults: each one marked by a stone guardian. As you explore the mines, you find what looks like a doorway blocked by the statue of a Dwarf sentry. One of the guard's eyes is a glittering gem, but the other socket is empty. Perhaps if you can find the missing gem you could open the hidden passageway...")
                .WithOppositeText("During the travel phase, the players must travel to a location, if able.\r\nForced: After resolving the Discover keyword, if no Hazard card was revealed by that effect, reveal the top card of the encounter deck.\r\nForced: When this stage is defeated, if Blue Mountain Gem is attached to a hero advance to stage 4A. Otherwise, advance to stage 3A.")
                .WithInfo(6, 1, Artist.Yoann_Boissonnet));
            Cards.Add(LotRCard.Quest("The Beast of Belegost", 4, "The Ruins of Belegost", Card.VALUE_NA)
                .WithText("When Revealed: Add Naurlhûg and Naurlhûg's Lair to the staging area. Shuffle the Sword of Belegost, and the encounter discard pile into the encounter deck.")
                .WithFlavor("After fleeing the breaking of Thangorodrim, the great worm Naurlhûg hid itself in the ruins of Belegost. The fire dragon hoarded the wealth it found there into a giant, golden bed at the center of a large, underground lake. If you wish to claim the treasure for yourself, then you must slay Naurlhûg.")
                .WithOppositeText("While Naurlhûg's Lair is in the victory display, Naurlhûg loses the text: \"Cannot take damage.\"\r\nForced: After Naurlhûg attacks, if it was dealt a shadow card with no shadow effect, it engages the next player. Then, it makes an immediate attack. Do not deal it a shadow card for this attack.\r\nWhen Naurlhûg is defeated, the players win the game.")
                .WithInfo(7, 1, Artist.Sergey_Glushakov));
            Cards.Add(LotRCard.Objective("Stalking the Ruins", "", "The Ruins of Belegost")
                .WithTraits("Dragon.")
                .WithText("Forced: At the beginning of the quest phase, place 1 progress token on Stalking the Ruins. Then, if there are at least 3 resources here, add or return Naurlhûg to the staging area.\r\nForced: When the players advance to a new quest stage, discard all tokens from Stalking the Ruins. Then, set Naurlhûg aside, out of play.")
                .WithInfo(8, 1, Artist.Sergey_Glushakov));
            Cards.Add(LotRCard.Objective("Sword of Belegost", "", "The Ruins of Belegost")
                .WithUnique()
                .WithTraits("Artifact.", "Item.", "Weapon.")
                .WithKeywords("Loot.", "Restricted.")
                .WithTextLine("Loot. Restricted.")
                .WithTextLine("If unattached, the first player claims Sword of Belegost and attaches it to a hero he controls.\r\nAttached hero gets +4 Attack.\r\nResponse: Exhaust Sword of Belegost to cancel a shadow effect just triggered.")
                .WithInfo(9, 1, Artist.Lucas_Durham));
            Cards.Add(LotRCard.Objective("Map of Ered Luin", "", "The Ruins of Belegost")
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Loot.")
                .WithTextLine("Loot.")
                .WithTextLine("If unattached, the fist player claims Map of Ered Luin and attaches it to a hero he controls.\r\nAction: Exhaust Map of Ered Luin to choose a non-unique location. That location gets -2 Threat until the end of the phase.")
                .WithInfo(10, 1, Artist.Lucas_Durham));
            Cards.Add(LotRCard.Objective("Keys of Belegost", "", "The Ruins of Belegost")
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Loot.")
                .WithTextLine("Loot.")
                .WithTextLine("If unattached, the fist player claims Keys of Belegost and attaches it to a hero he controls.\r\nAction: Exhaust Keys of Belegost to choose a hero. Add 1 resource to that hero's resource pool.")
                .WithInfo(11, 1, Artist.Lucas_Durham));
            Cards.Add(LotRCard.Objective("Book of Aulë's Children", "", "The Ruins of Belegost")
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Loot.")
                .WithTextLine("Loot.")
                .WithTextLine("If unattached, the fist player claims Book of Aulë's Children and attaches it to a hero he controls.\r\nAction: Exhaust Book of Aulë's Children to choose a player. That player draws 1 card.")
                .WithInfo(12, 1, Artist.Lucas_Durham));
            Cards.Add(LotRCard.Objective("Dwarven Torch", "", "The Ruins of Belegost")
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Loot.")
                .WithTextLine("Loot.")
                .WithTextLine("If unattached, the fist player claims Dwarven Torch and attaches it to a hero he controls.\r\nAction: Exhaust Dwarven Torch to choose a non-unique enemy. That enemy gets -1 Attack and -1 Defense until the end of the phase.")
                .WithInfo(13, 1, Artist.Lucas_Durham));
            Cards.Add(LotRCard.Objective("Blue Mountain Gem", "", "The Ruins of Belegost")
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Loot.")
                .WithTextLine("Loot.")
                .WithTextLine("If unattached, the fist player claims Blue Mountain Gem and attaches it to a hero he controls.\r\nAction: Exhaust Blue Mountain Gem to choose a player. Reduce that player's threat by 1.")
                .WithInfo(14, 1, Artist.Lucas_Durham));
            Cards.Add(LotRCard.Enemy("Naurlhûg", "", "The Ruins of Belegost", 20, Card.VALUE_X, 7, 5, 20)
                .WithUnique()
                .WithTraits("Dragon.")
                .WithText("Immune to player card effects, Cannot take damage.\r\nX is the number of resources on Stalking the Ruins.\r\nForced: When Naurlhûg makes an attack, the defending player assigns X damage among characters he controls.")
                .WithVictoryPoints(7)
                .WithInfo(15, 1, Artist.Sergey_Glushakov));
            Cards.Add(LotRCard.Enemy("Lurker of the Depths", "", "The Ruins of Belegost", 50, 4, 5, 2, 12)
                .WithUnique()
                .WithTraits("Creature.")
                .WithText("Cannot have attachments.\r\nLurker of the Depths cannot be engaged or take more than 4 damage each round.\r\nWhile Lurker of the Depths is in the staging area, it is considered to be engaged with each player.")
                .WithVictoryPoints(5)
                .WithInfo(16, 1, Artist.Ethan_Patrick_Harris));
            Cards.Add(LotRCard.Enemy("Nameless Cave Dweller", "", "The Ruins of Belegost", 35, Card.VALUE_X, Card.VALUE_X, Card.VALUE_X, 5)
                .WithTraits("Nameless.", "Hazard.")
                .WithText("Cannot have player card attachments.\r\nX is 1 more than the Discover value on the active location.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if you control a Loot objective).")
                .WithInfo(17, 4, Artist.Dimitri_Bielak));
            Cards.Add(LotRCard.Enemy("Old Stone Troll", "", "The Ruins of Belegost", 50, 3, 6, 3, 8)
                .WithTraits("Troll.", "Hazard.")
                .WithText("Cannot have player card attachments.\r\nOld Stone Troll gets -10 engagement cost for each Loot objective attached to a hero.\r\nOnly the engaged player can declare attackers against Old Stone Troll.")
                .WithEasyModeQuantity(0)
                .WithInfo(18, 2, Artist.Sandara_Tang));
            Cards.Add(LotRCard.Enemy("Orc of Ered Luin", "", "The Ruins of Belegost", 30, 2, 4, 2, 4)
                .WithTraits("Orc.")
                .WithText("When Revealed: Orc of Ered Luin makes an immediate attack against each player that controls at least 1 Loot objective (in turn order).")
                .WithShadow("Shadow: After this attack, attacking enemy engages the next player, then makes an immediate attack.")
                .WithInfo(19, 3, Artist.Sam_Lamont));
            Cards.Add(LotRCard.Enemy("Blue Mountain Goblin", "", "The Ruins of Belegost", 25, 1, 3, 2, 3)
                .WithTraits("Orc.", "Goblin.")
                .WithText("While a Loot objective is attached to a hero, Blue Mountain Goblin gains surge.")
                .WithShadow("Shadow: If you control a Loot objective, put Blue Mountain Goblin into play engaged with you and deal it a shadow card.")
                .WithInfo(20, 3, Artist.Sam_Lamont));
            Cards.Add(LotRCard.Location("Naurlhûg's Lair", "", "The Ruins of Belegost", 4, 6)
                .WithUnique()
                .WithTraits("Underground.")
                .WithKeywords("Discover 5.")
                .WithTextLine("Discover 5.")
                .WithTextLine("Immune to player card effects.\r\nForced: When Naurlhûg's Lair is explored, add the Loot objective from underneath Stalking the Ruins to the staging area faceup.\r\nTravel: Place X resources on Stalking the Ruins, where X is the number of players.")
                .WithVictoryPoints(4)
                .WithInfo(21, 1, Artist.Jokubas_Uoginitas));
            Cards.Add(LotRCard.Location("Abandoned Mine", "", "The Ruins of Belegost", 2, 3)
                .WithTraits("Underground.")
                .WithKeywords("Discover 2.")
                .WithTextLine("Discover 2.")
                .WithTextLine("While Abandoned Mine is in the staging area, progress cannot be placed on locations in the staging area not named Abandoned Mine.\r\nForced: When resolving the Discover keyword on Abandoned Mine, look at X additional cards where X is the number of players in the game.")
                .WithInfo(22, 4, Artist.Yoann_Boissonnet));
            Cards.Add(LotRCard.Location("Flooded Hall", "", "The Ruins of Belegost", 4, 4)
                .WithTraits("Underground.")
                .WithKeywords("Discover 4.")
                .WithTextLine("Discover 4.")
                .WithTextLine("While Flooded Hall is in the staging area, increase the cost to play each ally by 1.\r\nForced: When resolving the Discover keyword on Flooded Hall, the first player reveals an additional looked at Hazard card for each other player in the game.")
                .WithEasyModeQuantity(0)
                .WithInfo(23, 2, Artist.Leanna_Crossan));
            Cards.Add(LotRCard.Location("Darkened Tunnel", "", "The Ruins of Belegost", 3, 3)
                .WithTraits("Underground.")
                .WithKeywords("Discover 2.")
                .WithTextLine("Discover 2.")
                .WithTextLine("While Darkened Tunnel is in the staging area, it gains: \"Forced: After a 'when revealed' effect is canceled, discard the top card of the encounter deck. If the discarded card has the Hazard trait, resolve its staging as if it was just revealed from the encounter deck.\"\r\nTravel: Place 1 resource on Stalking the Ruins.")
                .WithInfo(24, 2, Artist.Yoann_Boissonnet));
            Cards.Add(LotRCard.Location("Sunken Treasury", "", "The Ruins of Belegost", 1, 4)
                .WithTraits("Underground.")
                .WithKeywords("Discover 3.")
                .WithTextLine("Discover 3.")
                .WithTextLine("Sunken Treasury gets +1 Threat for each Loot objective attached to a hero.\r\nTravel: Each player discards 1 random card from his hand.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithInfo(25, 3, Artist.Leanna_Crossan));
            Cards.Add(LotRCard.Location("Secret Chamber", "", "The Ruins of Belegost", 3, 2)
                .WithTraits("Underground.", "Hazard.")
                .WithKeywords("Discover 3.")
                .WithTextLine("Discover 3.")
                .WithTextLine("Response: After the players travel to Secret Chamber, if no Loot objective is attached to Secret Chamber, search the encounter discard pile for a Loot objective and attach it to Secret Chamber as a guarded objective.\r\nTravel: Raise each player's threat by 2.")
                .WithInfo(26, 3, Artist.Jokubas_Uoginitas));
            Cards.Add(LotRCard.Treachery("Echoes in the Dark", "", "The Ruins of Belegost")
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Add 1 to the total Threat in the staging area for each character controlled by the first player until the end of the phase.")
                .WithShadow("Shadow: Discard 1 random card from your hand. If the discarded card is an event, attacking enemy gets +2 Attack.")
                .WithInfo(27, 3, Artist.Adam_Lane));
            Cards.Add(LotRCard.Treachery("Spawn of Thangorodrim", "", "The Ruins of Belegost")
                .WithText("When Revealed: If Naurlhûg is in play, it makes an immediate attack against the first player. If Naurlhûg is not in play, place 1 resource on Stalking the Ruins. Then, if there are at least 3 resources on Stalking the Ruins, add Naurlhûg to the staging area.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithEasyModeQuantity(0)
                .WithInfo(28, 2, Artist.Jokubas_Uoginitas));
            Cards.Add(LotRCard.Treachery("Concealed Spikes", "", "The Ruins of Belegost")
                .WithTraits("Hazard.")
                .WithText("When Revealed: Each player assigns X damage among characters he controls. X is 1 more than the Discover value on the active location.")
                .WithShadow("Shadow: Assign X damage among characters you control. X is the number of attachments you control. You may discard the highest cost attachment you control to cancel this effect.")
                .WithInfo(29, 2, Artist.Dimitri_Bielak));
            Cards.Add(LotRCard.Treachery("Covered Pit", "", "The Ruins of Belegost")
                .WithTraits("Hazard.")
                .WithText("When Revealed: Each player discards an ally he controls.")
                .WithShadow("Shadow: If attacking enemy is non-unique, attach a Loot objective you control to it as a guarded objective. If this attack destroys a character, return attacking enemy to the staging area.")
                .WithInfo(30, 2, Artist.Dimitri_Bielak));
        }
    }
}