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
                .WithTextLine("Action: Choose a hero you control and discard all tokens from it. Select a different non-Fellowship, non-Baggins hero from your collection with a threat cost less than or equal to the chosen hero. Swap those heroes, moving all eligible attachments and damage tokens to the hero from your collection.")
                .WithInfo(90, 3, Artist.Unknown);
            addContract("Council of the Wise")
                .WithTextLine("You cannot include more than 1 copy of a card, by title, in your deck.")
                .WithTextLine("Response: After you play an event from your hand, choose one: reduce your threat by 1, draw 1 card, or add 1 resource to your hero's resource pool. You can only choose each option once per round.")
                .WithFlavorLine("\"I must go to this lords' council and learn what I can.\"\r\n-Gandalf, The Return of the King")
                .WithInfo(91, 1, Artist.Aleksander_Karcz);


            addEncounterSideQuest("A Haunt for Beasts", setName, 4)
                .WithFlavorLine("Within the tunnels of Torech Gorgor are a host of fell creatures.")
                .WithTextLine("Each enemy cannot take more than 4 damage each round.")
                .WithTextLine("While there is at least one enemy in the staging area, this stage cannot be chosen as the current quest.")
                .WithVictoryPoints(10)
                .WithInfo(93, 1, Artist.Unknown);

            addEnemy("Ash Mountain Werewolf", setName, 28, 2, 4, 1, 5)
                .WithTraits("Creature.", "Werewolf.")
                .WithTextLine("Forced: After Ash Mountain Werewolf attacks you, discard the top card of your deck (top 2 cards instead if this attack destroyed a character).")
                .WithShadow("Shadow: If this attack destroys a character, discard the top 2 cards of your deck.")
                .WithInfo(97, 1, Artist.Sarah_Lindstrom);

            addLocation("Fiery Chasm", setName, Card.VALUE_X, 5)
                .WithTraits("Underground.")
                .WithTextLine("X is 1 more than the number of quest cards in play.")
                .WithTextLine("Forced: When Fiery Chasm is explored, discard the top X cards of your deck.")
                .WithFlavorLine("...its floor and walls on either side were cloven by a great fissure, out of which the red glare came, now leaping up, now dying down into darkness...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(100, 1, Artist.Unknown);

            addTreachery("Burning Reek", setName)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Each player discard 1 card from the top of his deck for each character he controls.")
                .WithShadow("Shadow: Either discard the top 2 cards of your deck, or return attacking enemy to the staging area after this attack.")
                .WithInfo(104, 1, Artist.Greg_Bobrowski);

            addQuest("An Evil Place", setName, 2, 'A', 25)
                .WithFlavorLine("Hope and supplies begin to run low the longer you wander through the oppresive dark of Torch Gordor. You need to find the exit before it's too late.")
                .WithTextLine("When Revealed: Search the encounter deck and discard pile for an encounter side quest and reveal it. Shuffle the encounter discard pile into the encounter deck and discard cards from the top until X enemies are discarded, where X is the number of players. Add each enemy discarded this way to the staging area.")
                .WithOppositeTextLine("Event cards cannot shuffle cards from a player's discard pile into his deck.")
                .WithOppositeTextLine("Forced: At the end of the round, each player discards X cards from the top of his deck, where X is 1 more than the number of quest cards in play. If a player has no cards left in his deck, he is eliminated from the game.")
                .WithOppositeTextLine("If the player defeat this stage, they win the game.")
                .WithInfo(107, 1, Artist.Stanislav_Dikolenko);
        }
    }
}