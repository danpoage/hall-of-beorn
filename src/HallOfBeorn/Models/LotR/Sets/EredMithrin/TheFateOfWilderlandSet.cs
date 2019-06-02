using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.EredMithrin
{
    public class TheFateOfWilderlandSet : CardSet
    {
        private const string setName = "The Fate of Wilderland";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TFoW";
            Number = 55;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Ered Mithrin";

            addHero("Radagast", 11, Sphere.Lore, 2, 2, 3, 4)
                .WithTraits("Istari.")
                .WithText("You may use resources from Radagast's pool to pay for Creature allies of any sphere.\r\nResponse: After you play a Creature card, Radagast does not exhaust to quest this round.")
                .WithFlavor("\"..he has much lore of herbs and beasts, and birds are especially his friends.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(145, 1, Artist.Aleksander_Karcz);
            addAlly("Messenger Raven", 1, Sphere.Leadership, false, 1, 0, 0, 1)
                .WithTraits("Creature.")
                .WithText("Cannot attack, defend, of have attachments.\r\nRefresh Action: Return Messenger ~Raven to it's owner's hand and name a card type. Choose a player to look at the top card of his deck. If that card is the named type, add it to its owner's hand. If it is not, discard it.")
                .WithInfo(146, 3, Artist.Derek_D_Edgell);
            addEvent("The King's Return", 1, Sphere.Leadership)
                .WithTraits("Song.")
                .WithText("Action: Search your deck for a Guarded attachment and put it into play. Shuffle your deck.")
                .WithFlavor("His crown shall be upholden,\r\nHis harp shall be restrung,\r\nHis halls shall echo golden\r\nTo songs of yore re-sung\r\n-The Hobbit")
                .WithInfo(147, 3, Artist.Tyler_Edlin);
            addAlly("Loyal Hound", 2, Sphere.Lore, false, 1, 2, 0, 2)
                .WithTraits("Creature.")
                .WithText("Cannot have attachments.\r\nResponse: Discard Loyal ~Hound to cancel up to 2 damage just dealt to a hero you control.")
                .WithInfo(148, 3, Artist.Alvaro_Calvo_Escudero);
            addEvent("The Great Hunt", 3, Sphere.Lore)
                .WithText("You must use resources from 3 different heroes' pools to pay for this card.\r\nCombat Action: Choose and discard a non-unique enemy in the staging area.")
                .WithFlavor("...it seemed they could hear the noise of a great hunt going by to the north of the path...\r\n-The Hobbit")
                .WithInfo(149, 3, Artist.Carlos_Palma_Cruchaga);
            addAlly("Bywater Shirriff", 2, Sphere.Tactics, false, 1, 1, 1, 2)
                .WithTraits("Hobbit.", "Shirriff.")
                .WithText("Bywater ~Shirriff gets +1 Willpower, +1 Attack, and +1 Defense while you are engaged with an enemy with engagement cost higher than your threat.")
                .WithFlavor("The Shirriffs was the name that the Hobbits gave to their police, or the nearest equivalent that they possessed.\r\n-The Hobbit")
                .WithInfo(150, 3, Artist.Romana_Kendelic);
            addEvent("Gwaihir's Debt", 1, Sphere.Tactics)
                .WithText("Play only if you control a unique character with the Istari trait and another unique character with the Eagle trait.\r\nAction: ~Search the top 5 cards of your deck for an Eagle or Istari ally and put it into play. Shuffle your deck. At the end of the round, if that ally is still in play, return it to your hand.")
                .WithInfo(151, 3, Artist.Justin_Gerard);
            addAttachment("Mithril Shirt", 1, Sphere.Spirit, true)
                .WithTraits("Artifact.", "Item.", "Armor.")
                .WithKeywords("Guarded (location).")
                .WithText("Guarded (location).\r\nAttach to a hero.\r\nResponse: When attached hero is dealt any amount of damage, reduce that damage by 1.")
                .WithFlavor("It was of silver-steel which the Elves call mithril, and with it went a belt of pearls and crystals.\r\n-The Hobbit")
                .WithTemplate("<p class='main-text'>{keyword:Guarded (location).}</p><p class='main-text;'>Attach to a hero.</p><p class='main-text'><b>Response:</b> When attached hero is dealt any amount of damage, reduce that damage by 1.</p><p class='flavor-text'>It was of silver-steel which the Elves call mithril, and with it went a belt of pearls and crystals. &ndash;The Hobbit</p>")
                .WithInfo(152, 3, Artist.Sebastian_Zakrzewski);
            addEvent("Reforged", Card.VALUE_X, Sphere.Spirit)
                .WithText("Action: Choose an attachment with a printed cost of X in any player's discard pile and play that attachment for no cost. (The chosen attachment can belong to any sphere of influence.)")
                .WithFlavor("The Sword of Elendil was forged anew by Elvish smiths... -The Fellowship of the Ring")
                .WithInfo(153, 3, Artist.Sebastian_Zakrzewski);
            addAttachment("Radagast's Staff", 2, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Item.", "Staff.")
                .WithText("Attach to Radagast.\r\nAction: Exhaust Radagast's ~Staff to choose one: Reduce the cost of the next Creature ally you play this phase by 2, ready a Creature ally, or return a non-unique Creature enemy engaged with you to the staging area.")
                .WithInfo(154, 3, Artist.Sebastian_Zakrzewski);
        }
    }
}