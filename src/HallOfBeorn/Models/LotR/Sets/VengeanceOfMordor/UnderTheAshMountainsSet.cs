using System;

namespace HallOfBeorn.Models.LotR.Sets.VengeanceOfMordor
{
    public class UnderTheAshMountainsSet : CardSet
    {
        public const string setName = "Under the Ash Mountains";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "UtAM";
            Number = 60;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Vengeance of Mordor";

            IsSpoiler = true;

            addHero("Gildor Inglorion", 9, Sphere.Leadership, 3, 2, 1, 3)
                .WithTraits("Noldor.", "Noble.")
                .WithTextLine("Action: Pay 1 resource from Gildor Inglorion's resource pool to choose a player to draw 1 card (Limit once per round.)")
                .WithFlavorLine("\"Gildor Inglorion of the House of Finrod. We are Exiles, and most of our kindred have long ago departed...\"")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithCommunityVersion("Gildor-Inglorion-Grimbeorn's-Path")
                .WithCommunityVersion("Autumn/Gildor-Inglorion-Leadership-Hero")
                .WithInfo(81, 1, Artist.Jason_Jenicke);
            addAlly("Wandering Exile", 3, Sphere.Leadership, false, 2, 2, 0, 2)
                .WithTraits("Noldor.")
                .WithTextLine("Response: After Wandering Exile commits to a quest, discard a card from your hand to ready Wandering Exile.")
                .WithFlavorLine("\"The Elves have their own labours and their own sorrows...")
                .WithFlavorLine("-Gildor, The Fellowship of the Ring")
                .WithInfo(82, 3, Artist.Drazenka_Kimpel);
            addAttachment("Valiant Sword", 1, Sphere.Leadership, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Noble hero. Limit 1 per hero.")
                .WithTextLine("Restricted.")
                .WithTextLine("Attached hero gets +1 Attack (+2 Attack if your threat is 40 or higher).")
                .WithFlavorLine("...his sword of steel was valiant...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(83, 3, Artist.Nikolas_Hagialas);
            addAttachment("Stone of Elostirion", 1, Sphere.Lore, true)
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Guarded (location).", "Restricted.")
                .WithTextLine("Guarded (location). Restricted.")
                .WithTextLine("Attach to a hero. Attached hero gets +2 Willpower.")
                .WithTextLine("You draw 1 additional card during the resource phase.")
                .WithFlavorLine("Looking up he saw before him a tall white tower, standing alone on a high ridge. A great desire came over him to climb the tower and see the Sea.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(84, 3, Artist.Federico_Musetti);
            addAttachment("Well Preserved", 1, Sphere.Lore, false)
                .WithTraits("Master.")
                .WithTextLine("Attach to the hero with The One Ring.")
                .WithTextLine("Limit 1 per hero. Attached hero gets + 1 hit point.")
                .WithTextLine("Response: At the beginning of the round, exhaust The One Ring and raise your threat by 1 to heal all damage from attached hero.")
                .WithInfo(85, 3, Artist.Torbjorn_Kallstrom);
            addAlly("Northern Bowmaster", 1, Sphere.Tactics, false, 0, 2, 0, 1)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("You cannot play Northern Bowmaster from your hand unless you are engaged with an enemy.")
                .WithInfo(86, 3, Artist.Aleksander_Karcz);
            addEvent("Reckless Attack", 0, Sphere.Tactics)
                .WithKeywords("Doomed 2.")
                .WithTextLine("Doomed 2.")
                .WithTextLine("Action: Each player deals 2 damage to an enemy engaged with him.")
                .WithFlavorLine("Down, heedless of order, rushed all the dwarves of Dain to his help.")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(87, 3, Artist.David_Keen);
            addAlly("Odo Proudfoot", 2, Sphere.Spirit, true, 1, 1, 1, 2)
                .WithTraits("Hobbit.")
                .WithTextLine("Response: After Odo Proudfoot enters play, search the top 5 cards of your deck for a Hobbit ally and add it to your hand. Shuffle the other cards back into your deck.")
                .WithFlavorLine("\"ProudFEET! shouted an elderly hobbit from the back of the pavilion.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(88, 3, Artist.Torbjorn_Kallstrom);
            addEvent("Defiant Challenge", 0, Sphere.Spirit)
                .WithKeywords("Doomed 2.")
                .WithTextLine("Doomed 2.")
                .WithTextLine("Action: Each player may ready a characer he controls.")
                .WithFlavorLine("\"Go back to the Shadow!\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithInfo(89, 3, Artist.Greg_Opalinski);
            addEvent("Helm of Secrecy", 4, Sphere.Neutral)
                .WithTextLine("Limit 1 per deck.")
                .WithTextLine("Action: Choose a hero you control and discard all tokens from it. Select a different non-Fellowship, non-Baggins hero from your collection with a threat cost less than or equal to the chosen hero. Swap those heroes, moving all eligible attachments to the hero from your collection.")
                .WithLimitOnePerDeck()
                .WithErrata(1)
                .WithInfo(90, 3, Artist.Andreia_Ugrai);
            addContract("Council of the Wise")
                .WithTextLine("You cannot include more than 1 copy of a card, by title, in your deck.")
                .WithTextLine("Response: After you play an event from your hand, choose one: reduce your threat by 1, draw 1 card, or add 1 resource to your hero's resource pool. You can only choose each option once per round.")
                .WithFlavorLine("\"I must go to this lords' council and learn what I can.\"\r\n-Gandalf, The Return of the King")
                .WithInfo(91, 1, Artist.Aleksander_Karcz);
            addEncounterSideQuest("The Tunnels of Torech Gorgor", setName, 3)
                .WithFlavorLine("The tunnels under the Ash Mountains are a vast, dark maze.")
                .WithTextLine("During the travel phase, the players must travel to a location, if able.")
                .WithTextLine("Forced: When the active location is explored, place 1 resource here.")
                .WithTextLine("Progress cannot be placed on this quest unless there are at least 3 resources here.")
                .WithVictoryPoints(10)
                .WithInfo(92, 1, Artist.Sam_White);
            addEncounterSideQuest("A Haunt for Beasts", setName, 4)
                .WithFlavorLine("Within the tunnels of Torech Gorgor are a host of fell creatures.")
                .WithTextLine("Each enemy cannot take more than 4 damage each round.")
                .WithTextLine("While there is at least one enemy in the staging area, this stage cannot be chosen as the current quest.")
                .WithVictoryPoints(10)
                .WithInfo(93, 1, Artist.Sarah_Lindstrom);
            addEncounterSideQuest("Overwhelming Darkness", setName, 6)
                .WithFlavorLine("As you draw closer to Mordor, the darkness around you seeps into your thought, and despair begins to take hold...")
                .WithTextLine("Forced: After a player players a card, he discards the top card of his deck.")
                .WithTextLine("Response: When this stage is defeated, each player shuffles the top 3 cards of his discard pile into his deck.")
                .WithInfo(94, 1, Artist.Guillaume_Ducos);
            addEnemy("Nameless Beast", setName, 30, 3, 3, 3, 6)
                .WithTraits("Nameless.")
                .WithTextLine("Forced: When Nameless Beast attacks you, discard the top card of your deck. Nameless Beast gets +X Attack for this attack, where X is that card's cost.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack, where X is the cost of the top card of your discard pile.")
                .WithInfo(95, 2, Artist.Jon_Bosco);
            addEnemy("Mordor Cave Troll", setName, 33, 3, 6, 3, 8)
                .WithTraits("Troll.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Forced: After Mordor Cave Troll attacks and destroys a character, discard the top card of your deck for each point of excess damage dealt by this attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(96, 2, Artist.Ivan_Dixon);
            addEnemy("Ash Mountain Werewolf", setName, 28, 2, 4, 1, 5)
                .WithTraits("Creature.", "Werewolf.")
                .WithTextLine("Forced: After Ash Mountain Werewolf attacks you, discard the top card of your deck (top 2 cards instead if this attack destroyed a character).")
                .WithShadow("Shadow: If this attack destroys a character, discard the top 2 cards of your deck.")
                .WithInfo(97, 3, Artist.Sarah_Lindstrom);
            addEnemy("Spawn of Shelob", setName, 12, 1, 2, 1, 2)
                .WithTraits("Creature.", "Spider.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Forced: After Spawn of Shelob engages you, either discard the top card of your deck, or Spawn of Shelob gets +2 Attack until the end of the round.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithEasyModeQuantity(2)
                .WithInfo(98, 3, Artist.Guillaume_Ducos);
            addEnemy("Torech Gorgor Patrol", setName, 45, Card.VALUE_X, 5, 4, 9)
                .WithTraits("Orc.", "Uruk.")
                .WithTextLine("X is 1 more than the number of quest cards in play.")
                .WithTextLine("While Torech Gorgor Patrol is in the staging area, no more than 5 progress can be placed on the main quest each round.")
                .WithTextLine("Forced: After Torech Gorgor Patrol engages a player, it makes an attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(99, 2, Artist.Matthew_Cowdery);
            addLocation("Fiery Chasm", setName, Card.VALUE_X, 5)
                .WithTraits("Underground.")
                .WithTextLine("X is 1 more than the number of quest cards in play.")
                .WithTextLine("Forced: When Fiery Chasm is explored, discard the top X cards of your deck.")
                .WithFlavorLine("...its floor and walls on either side were cloven by a great fissure, out of which the red glare came, now leaping up, now dying down into darkness...")
                .WithFlavorLine("-The Return of the King")
                .WithEasyModeQuantity(2)
                .WithInfo(100, 3, Artist.Daria_Khlebnikova);
            addLocation("Hideous Deeps", setName, 3, 6)
                .WithTraits("Underground.")
                .WithTextLine("When Revealed: Each player places the top 3 cards of his deck facedown under Hideous Deeps.")
                .WithTextLine("Forced: When Hideous Deeps is explored as the active location, shuffle each facedown card under it into its owner's deck.")
                .WithInfo(101, 2, Artist.Sam_White);
            addLocation("Orc Passage", setName, 4, 4)
                .WithTraits("Underground.")
                .WithTextLine("While Orc Passage is in the staging area, encounter card effects cannot be canceled.")
                .WithTextLine("Forced: When Orc Passage is explored, search the encounter deck and discard pile for a copy of Torech Gorgor Patrol and add it to the staging area.")
                .WithEasyModeQuantity(1)
                .WithInfo(102, 2, Artist.Stanislav_Dikolenko);
            addTreachery("Ransacked Supplies", setName)
                .WithTextLine("When Revealed: Each player discards the top card of his deck. Until the end of the phase, add the total cost of each card discarded this way to the Threat in the staging area.")
                .WithShadow("Shadow: Discard an attachment you control. If this attack destroys a character, discard another attachment you control.")
                .WithInfo(103, 3, Artist.Alex_Brock);
            addTreachery("Burning Reek", setName)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Each player discard 1 card from the top of his deck for each character he controls.")
                .WithShadow("Shadow: Either discard the top 2 cards of your deck, or return attacking enemy to the staging area after this attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(104, 2, Artist.Greg_Bobrowski);
            addTreachery("Writhing Shadows", setName)
                .WithTextLine("When Revealed: Each player assigns X damage among character he controls, where X is 1 more than the number of quest cards in play. Exhaust each character damaged by this effect.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithEasyModeQuantity(1)
                .WithInfo(105, 2, Artist.Matthew_Cowdery);
            addQuest("Passage into Mordor", setName, 1, 'A', 25)
                .WithFlavorLine("The tunnels of Torech Gorgor run beneath the Ash Mountains into Mordor.")
                .WithTextLine("Setup: Each player with more than 40 cards in his deck discards cards from the top of his deck until he has 40 cards left. The first player adds a copy of Torech Gorgor Patrol to the staging area. Each other player adds 1 different location to the staging area. Shuffle the encounter deck and discard cards from the top until a side quest is discarded. Reveal that side quest. Shuffle the encounter discard pile into the encounter deck.")
                .WithOppositeFlavorLine("The dark passage offers you a way into Mordor, but only if you can navigate the intersecting maze of tunnels before running out of provisions.")
                .WithOppositeTextLine("Event cards cannot shuffle cards from a player's discard pile into his deck.")
                .WithOppositeTextLine("Forced: At the end of the round, each player discards X cards from the top of his deck, where X is 1 more than the number of quest cards in play. If a player has no cards left in his deck, he is eliminated from the game.")
                .WithIncludedEncounterSets(EncounterSet.TwistedTunnels)
                .WithInfo(106, 1, Artist.Guillaume_Ducos);
            addQuest("An Evil Place", setName, 2, 'A', 25)
                .WithFlavorLine("Hope and supplies begin to run low the longer you wander through the oppresive dark of Torch Gordor. You need to find the exit before it's too late.")
                .WithTextLine("When Revealed: Search the encounter deck and discard pile for an encounter side quest and reveal it. Shuffle the encounter discard pile into the encounter deck and discard cards from the top until X enemies are discarded, where X is the number of players. Add each enemy discarded this way to the staging area.")
                .WithOppositeTextLine("Event cards cannot shuffle cards from a player's discard pile into his deck.")
                .WithOppositeTextLine("Forced: At the end of the round, each player discards X cards from the top of his deck, where X is 1 more than the number of quest cards in play. If a player has no cards left in his deck, he is eliminated from the game.")
                .WithOppositeTextLine("If the player defeat this stage, they win the game.")
                .WithIncludedEncounterSets(EncounterSet.TwistedTunnels)
                .WithInfo(107, 1, Artist.Stanislav_Dikolenko);
        }
    }
}
