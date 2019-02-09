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

            IsSpoiler = true;

            addHero("Radagast", 11, Sphere.Lore, 2, 2, 3, 4)
                .WithTraits("Istari.")
                .WithText("You may use resources from Radagast's pool to pay for Creature allies of any sphere.\r\nResponse: After you play a Creature card, Radagast does not exhaust to quest this round.")
                .WithFlavor("\"..he has much lore of herbs and beasts, and birds are especially his friends.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(145, 1, Artist.Aleksander_Karcz);
            addAlly("Messenger Raven", 1, Sphere.Leadership, false, 1, 0, 0, 1)
                .WithTraits("Creature.")
                .WithText("Cannot attack, defend, of have attachments.\r\nAction: Return Messenger ~Raven to your hand and name a card type. Choose a player to look at the top card of his deck. If the looked at card is of the named type, add it to its owners hand. If not, discard it.")
                .WithInfo(146, 3, Artist.Unknown);

            addAlly("Loyal Hound", 2, Sphere.Lore, false, 1, 2, 0, 2)
                .WithTraits("Creature.")
                .WithText("Cannot have attachments.\r\nResponse: Discard Loyal ~Hound to cancel up to 2 damage just dealt to a hero you control.")
                .WithInfo(149, 3, Artist.Alvaro_Calvo_Escudero);
            addAttachment("Mithril Shirt", 1, Sphere.Spirit, true)
                .WithTraits("Artifact.", "Item.", "Armor.")
                .WithKeywords("Guarded (location).")
                .WithText("Attach to a hero.\r\nResponse: When attached hero would take any amount of damage, reduce that damage by 1.")
                .WithInfo(151, 3, Artist.Unknown); 
            addEvent("Gwaihir's Debt", 1, Sphere.Tactics)
                .WithText("Play only if you control a unique character with the Istari trait and another unique character with the Eagle trait.\r\nAction: ~Search the top 5 cards your deck for an Eagle or Istari ally and put it into play. Shuffle your deck. At the end of the round, if that ally is still in play, return it to your hand.")
                .WithInfo(153, 3, Artist.Unknown);

            addAttachment("Radagast's Staff", 2, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Item.", "Staff.")
                .WithText("Attach to Radagast.\r\nAction: Exhaust Radagast's ~Staff to choose one: Reduce the cost of the next Creature ally you play this phase by 2, ready a Creature ally, or return a non-unique Creature enemy engaged with you to the staging area.")
                .WithInfo(154, 3, Artist.Sebastian_Zakrzewski);
        }
    }
}