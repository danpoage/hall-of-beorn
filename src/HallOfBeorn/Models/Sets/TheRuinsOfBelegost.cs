using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
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

            Cards.Add(new Card()
            {
                Title = "The Ruins of Belegost Scenario Rules",
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
                Number = 0,
                Artist = Artist.Unknown
            });
            Cards.Add(Card.Hero("Gimli", "", Sphere.Tactics, 11, 2, 2, 2, 5)
                .WithTraits("Dwarf.", "Noble.", "Warrior.")
                .WithText("Gimli gets +1 Attack for each damage token on him.")
                .WithTemplate("<p>{self} gets +1 {Attack} for each damage token on him.</p>")
                .WithInfo(0, 1, Artist.Sebastian_Giacobino));
            Cards.Add(Card.Quest("Ruins of the First Age", "", 6, 1, "The Ruins of Belegost", 6)
                .WithText("Setup: Add Stalking the Ruins and 1 copy of Abandoned Mine per player to the staging area. Set Lurker of the Depths, Naurlhûg, Naurlhûg's Lair, and Sword of Belegost aside, out of play. Randomly select 1 of the 5 remaining Loot objectives and place it facedown underneath Stalking the Ruins (without looking). Shuffle the others into the encounter deck (without looking at them).")
                .WithFlavor("You have entered the dark, half-sunken ruins of Belegost in search of powerful artifacts and ancient treasure.")
                .WithOppositeText("The player cannot advance unless they control at least 1 Loot objective.\r\nForced: At the beginning of the travel phase, if there are no locations in play, return the topmost location in the encounter discard pile to the staging area.\r\nForced: When this stage is defeated, if Keys of Belegost is attached to a hero, advace to stage 2C. Otherwise, advance to Stage 2A.")
                .WithOppositeFlavor("Inside the Dwarven city, you can feel an evil presence stalking you...")
                .WithInfo(1, 1, Artist.Wibben));
            Cards.Add(Card.Quest("Ancient Evils Disturbed", "", 6, 2, "The Ruins of Belegost", 9)
                .WithText("When Revealed: Add Lurker of the Depths to the staging area.")
                .WithFlavor("As you explore the partially flooded ruins of Belegost, you feel something wet and leathery brush past your leg. The sound of thrashing water echoes from somewhere in the darkness ahead of you, when suddenly a horde of slimy, black tentacles strike at you!")
                .WithOppositeFlavor("Some hideous creature of a forgotten age attacks your party. You must defeat it if you hope to leave Belegost alive.")
                .WithOppositeText("The players cannot advance unless they control at least 2 Loot objectives and Lurker of the Depths is in the victory display.\r\nForced: When this stage is defeated, if Book of Aulë's Children is attached to a hero, advance to stage 3C. Otherwise, advance to stage 3A.")
                .WithInfo(2, 1, Artist.Ethan_Patrick_Harris));
            Cards.Add(Card.Quest("Deeper into the Past", "", 6, 2, "The Ruins of Belegost", 9, 'C')
                .WithText("When Revealed: Shuffle Lurker of the Depths and the encounter discard pile into the encounter deck. Discard cards from the top of the encounter deck until a location is discarded. Add the discarded location to the staging area.")
                .WithFlavor("The keys you discovered unlock a passage that leads deeper into the mines of Belegost. As you descend further into the Dwarven city, you marvel at the enormity of its size and the complexity of its design.")
                .WithOppositeText("The player cannot advance unless they control at least 2 Loot objectives and there are at least 3 resources here.\r\nForced: After the active location is explored, place 1 resource here.\r\nForced: When this stage is defeated, if Book of Aulë's Children is attached to a hero, advance to stage 3E. Otherwise, advance to stage 3C.")
                .WithOppositeFlavor("You must carefully explore the ruins to ensure you don't miss anything.")
                .WithInfo(3, 1, Artist.Yoann_Boissonnet));
            Cards.Add(Card.Quest("The Servants of Morgoth", "", 6, 3, "The Ruins of Belegost", 6)
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck and reveal 1 encounter card per player.")
                .WithFlavor("Your journey into Belegost has captured the attention of the many foul creatures that now dwell there. Evil creatures that lay hidden for countless years now stir in the darkness around you. You need a light to ward them off.")
                .WithOppositeText("The first Hazard card revealed each round gains surge.\r\nDuring the travel phase, the players must travel to a location, if able.\r\nForced: When this stage is defeated, if Dwarven Torch is attached to a hero, advance to stage 4A. Otherwise advance to stage 3C.")
                .WithInfo(4, 1, Artist.Wibben));
            Cards.Add(Card.Quest("The Roots of Ered Luin", "", 6, 3, "The Ruins of Belegost", 6, 'C')
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck and reveal 1 encounter card per player.")
                .WithFlavor("Your exploration of Belegost has brought you down to the very roots of the Ered Luin mountain range. Here, in the utter black, a patchwork of tunnels and pitfalls create an impassable labyrith. You need a map to find your way...")
                .WithOppositeText("The Discover value on the active location is increased by 1.\r\nDuring the travel phase, the players must travel to a location, if able.\r\nForced: When this stage is defeated, if Map of Ered Luin is attached to a hero advance to stage 4A. Otherwise, advance to stage 3E.")
                .WithInfo(5, 1, Artist.Yoann_Boissonnet));
            Cards.Add(Card.Quest("The Mines of Belegost", "", 6, 3, "The Ruins of Belegost", 6, 'E')
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck and reveal 1 encounter card per player.")
                .WithFlavor("The book you recovered explains how the Dwarves kept their treasure in secret vaults: each one marked by a stone guardian. As you explore the mines, you find what looks like a doorway blocked by the statue of a Dwarf sentry. One of the guard's eyes is a glittering gem, but the other socket is empty. Perhaps if you can find the missing gem you could open the hidden passageway...")
                .WithOppositeText("During the travel phase, the players must travel to a location, if able.\r\nForced: After resolving the Discover keyword, if no Hazard card was revealed by that effect, reveal the top card of the encounter deck.\r\nForced: When this stage is defeated, if Blue Mountain Gem is attached to a hero advance to stage 4A. Otherwise, advance to stage 3A.")
                .WithInfo(6, 1, Artist.Yoann_Boissonnet));
            Cards.Add(Card.Quest("The Beast of Belegost", "", 6, 4, "The Ruins of Belegost", 255)
                .WithText("When Revealed: Add Naurlhûg and Naurlhûg's Lair to the staging area. Shuffle the Sword of Belegost, and the encounter discard pile into the encounter deck.")
                .WithFlavor("After fleeing the breaking of Thangorodrim, the great worm Naurlhûg hid itself in the ruins of Belegost. The fire dragon hoarded the wealth it found there into a giant, golden bed at the center of a large, underground lake. If you wish to claim the treasure for yourself, then you must slay Naurlhûg.")
                .WithOppositeText("While Naurlhûg's Lair is in the victory display, Naurlhûg loses the text: \"Cannot take damage.\"\r\nForced: After Naurlhûg attacks, if it was dealt a shadow card with no shadow effect, it engages the next player. Then, it makes an immediate attack. Do not deal it a shadow card for this attack.\r\nWhen Naurlhûg is defeated, the players win the game.")
                .WithInfo(7, 1, Artist.Sergey_Glushakov));
            Cards.Add(Card.Objective("Stalking the Ruins", "", "The Ruins of Belegost")
                .WithTraits("Dragon.")
                .WithText("Forced: At the beginning of the quest phase, place 1 progress token on Stalking the Ruins. Then, if there are at least 3 resources here, add or return Naurlhûg to the staging area.\r\nForced: When the players advance to a new quest stage, discard all tokens from Stalking the Ruins. Then, set Naurlhûg aside, out of play.")
                .WithInfo(8, 1, Artist.Sergey_Glushakov));
            Cards.Add(Card.Objective("Sword of Belegost", "", "The Ruins of Belegost")
                .WithUnique()
                .WithTraits("Artifact.", "Item.", "Weapon.")
                .WithKeywords("Loot.", "Restricted.")
                .WithText("If unattached, the first player claims Sword of Belegost and attaches it to a hero he controls.\r\nAttached hero gets +4 Attack.\r\nResponse: Exhaust Sword of Belegost to cancel a shadow effect just triggered.")
                .WithInfo(9, 1, Artist.Lucas_Durham));
            Cards.Add(Card.Objective("Map of Ered Luin", "", "The Ruins of Belegost")
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Loot.")
                .WithText("If unattached, the fist player claims Map of Ered Luin and attaches it to a hero he controls.\r\nAction: Exhaust Map of Ered Luin to choose a non-unique location. That location gets -2 Threat until the end of the phase.")
                .WithInfo(10, 1, Artist.Lucas_Durham));
            Cards.Add(Card.Objective("Keys of Belegost", "", "The Ruins of Belegost")
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Loot.")
                .WithText("If unattached, the fist player claims Keys of Belegost and attaches it to a hero he controls.\r\nAction: Exhaust Keys of Belegost to choose a hero. Add 1 resource to that hero's resource pool.")
                .WithInfo(11, 1, Artist.Lucas_Durham));
            Cards.Add(Card.Objective("Book of Aulë's Childre", "", "The Ruins of Belegost")
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Loot.")
                .WithText("If unattached, the fist player claims Book of Aulë's Children and attaches it to a hero he controls.\r\nAction: Exhaust Book of Aulë's Children to choose a player. That player draws 1 card.")
                .WithInfo(12, 1, Artist.Lucas_Durham));
            Cards.Add(Card.Objective("Dwarven Torch", "", "The Ruins of Belegost")
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Loot.")
                .WithText("If unattached, the fist player claims Dwarven Torch and attaches it to a hero he controls.\r\nAction: Exhaust Dwarven Torch to choose a non-unique enemy. That enemy gets -1 Attack and -1 Defense until the end of the phase.")
                .WithInfo(13, 1, Artist.Lucas_Durham));
            Cards.Add(Card.Objective("Blue Mountain Gem", "", "The Ruins of Belegost")
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Loot.")
                .WithText("If unattached, the fist player claims Blue Mountain Gem and attaches it to a hero he controls.\r\nAction: Exhaust Blue Mountain Gem to choose a player. Reduce that player's threat by 1.")
                .WithInfo(14, 1, Artist.Lucas_Durham));
            Cards.Add(Card.Enemy("Naurlhûg", "", "The Ruins of Belegost", 20, 255, 7, 5, 20)
                .WithUnique()
                .WithTraits("Dragon.")
                .WithText("Immune to player card effects, Cannot take damage.\r\nX is the number of resources on Stalking the Ruins.\r\nForced: When Naurlhûg makes an attack, the defending player assigns X damage among characters he controls.")
                .WithVictoryPoints(7)
                .WithInfo(15, 1, Artist.Sergey_Glushakov));
            Cards.Add(Card.Enemy("Lurker of the Depths", "", "The Ruines of Belegost", 50, 4, 5, 2, 12)
                .WithUnique()
                .WithTraits("Creature.")
                .WithText("Cannot have attachments.\r\nLurker of the Depths cannot be engaged or take more than 4 damage each round.\r\nWhile Lurker of the Depths is in the staging area, it is considered to be engaged with each player.")
                .WithVictoryPoints(5)
                .WithInfo(16, 1, Artist.Ethan_Patrick_Harris));
        }
    }
}