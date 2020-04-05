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
        }
    }
}