using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.VengeanceOfMordor
{
    public class WrathAndRuinSet : CardSet
    {
        private const string setName = "Wrath and Ruin";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "WaR";
            Number = 57;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Vengeance of Mordor";

            addHero("Thorin Stonehelm", 9, Sphere.Tactics, 1, 3, 1, 4)
                .WithTraits("Dwarf.", "Noble.", "Warrior.")
                .WithText("Response: After Thorin Stonehelm is declared as an attacker, discard the top card of your deck to deal 1 damage to an enemy engaged with you.")
                .WithFlavor("Thorin III Stonehelm, Dain's son, became King under the mountain.\r\n-The Return of the King")
                .WithYear(2019)
                .WithInfo(1, 1, Artist.Rafal_Hrynkiewicz);
            addAlly("Soldier of Gondor", 2, Sphere.Leadership, false, 1, 1, 1, 2)
                .WithTraits("Gondor.")
                .WithText("Response: After Soldier of Gondor enters play, seach the top 5 cards of your deck for a Gondor ally and add it to your hand (any number of Gondor allies instead if your threat is 40 or higher). Shuffle your deck.")
                .WithInfo(2, 3, Artist.Stanislav_Dikolenko);
            addEvent("Pillars of the Kings", 4, Sphere.Leadership)
                .WithText("While your threat is less than 40, reduce the cost to play Pillars of the Kings by 4.\r\nAction: Set your threat to 40. If this effect raised your threat, draw a card (draw 4 cards instead if it raised your threat by 10 or more).")
                .WithFlavor("\"Behold the Argonath, the Pillars of the Kings!\"\r\n-Aragorn, The Fellowship of the Ring")
                .WithInfo(3, 3, Artist.Sam_White);
            addAlly("Cautious Halfling", 2, Sphere.Lore, false, 1, 0, 1, 2)
                .WithTraits("Hobbit.")
                .WithText("Response: After Cautious Halfling enters play, look at the top card of the encounter deck. If that card is not an enemy, draw a card.")
                .WithFlavor("\"I thought I had been both careful and clever.\"\r\n-Frodo, The Fellowship of the Ring")
                .WithInfo(4, 3, Artist.Sara_Biddle);
            addEvent("Tom Bombadillo!", 2, Sphere.Lore)
                .WithTraits("Song.")
                .WithText("Play only if you control a Hobbit hero. You cannot play this card if there is a copy of Tom Bombadillo! in the victory display.\r\nPlanning Action: Add Tom Bombadillo the the victory display to shuffle a set-aside copy of Tom Bombadil into the encounter deck.")
                .WithInfo(5, 3, Artist.David_Keen);
            addAttachment("Durin's Axe", 1, Sphere.Tactics, true)
                .WithTraits("Artifact.", "Item.", "Weapon.")
                .WithKeywords("Guarded (enemy).", "Restricted.")
                .WithText("Guarded (enemy). Restricted.\r\nAttach to a hero. Attached hero gets +2 Attack.\r\nResponse: After attach hero attacks and destroys an enemy, deal 1 damage to an enemy engaged with you.")
                .WithInfo(6, 3, Artist.Nino_Vecia);
            addEvent("Charge into Battle", 5, Sphere.Tactics)
                .WithText("Play only after staging step.\r\nQuest Action: You may declare and resolve an attack against each non-unique enemy in the staging are as if it were engaged with you.")
                .WithFlavor("Panic came upon the Goblins; and even as they turned to meet this new attack, the elves charged again with renewed numbers.\r\n-The Hobbit")
                .WithInfo(7, 3, Artist.Vilius_Petrauskas);
            addAttachment("Silver Circlet", 2, Sphere.Spirit, false)
                .WithTraits("Item.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Spirit hero. Limit 1 per hero.\r\nRestricted.\r\nAttached hero gets +2 Willpower.")
                .WithFlavor("His hair was dark as the shadows of twilight, and upon it was set a circlet of silver...\r\n-The Fellowship of the Ring")
                .WithInfo(8, 3, Artist.David_Keen);
            addAttachment("Inner Strength", 1, Sphere.Spirit, false)
                .WithTraits("Master.")
                .WithText("Attach to the hero with The One Ring.\r\nLimit 1 per hero. Attached hero gets +1 Defense.\r\nResponse: Exhaust The One Ring and raise your threat by 1 to cancel a shadow effect just triggered during an attack that attached hero is defending.")
                .WithInfo(9, 3, Artist.Justin_Gerard);
            addAlly("Tom Bombadil", Card.VALUE_NA, Sphere.Neutral, true, 3, 3, 3, 6)
                .WithTraits("Legend.")
                .WithKeywords("Encounter.")
                .WithText("When Revealed: Choose a player. That player gains control of Tom Bombadil, ready and committed to the quest. At the end of the round, remove Tom Bombadil and a copy of Tom Bombadillo! in the victory display from the game. This effect cannot be cancelled.")
                .WithTemplate("<p class='main-text'>{keyword:Encounter.}</p><p class='main-text'><b>When Revealed:</b> Choose a player. That player gains control of Tom Bombadil, ready and committed to the quest. At the end of the round, remove {self} and a copy of {title:Tom_Bombadillo!@Tom Bombadillo!} in the victory display from the game. This effect cannot be cancelled.</p>")
                .WithInfo(10, 3, Artist.Borja_Pindado);
            addContract("The Burglar's Turn")
                .WithText("You cannot include attachments in your deck.\r\nSetup: Choose 14 different Item or Artifact attachments from your collection and shuffle them together. This is your loot deck. Flip this card over and place your loot deck facedown under it.")
                .WithFlavor("\"And I assure you there is a mark on this door - the usual one in the trade, or used to be. Burglar wants a good job, plenty of Excitement and reasonably Reward, that's how it is usually read.\r\n-Glóin, The Hobbit")
                .WithOppositeText("The active location gets +1 quest point for each attachment attached to it.\r\nForced: After you travel to a location, attach the top card of your loot deck faceup to that location as a guarded objective. If that attachment has the guarded X keyword, ignore it.\r\nForced: When the active location is explored, you may put each guarded attachment on that location into play at no cost, or add it to your hand.")
                .WithInfo(24, 1, Artist.Greg_Bobrowski);
        }
    }
}