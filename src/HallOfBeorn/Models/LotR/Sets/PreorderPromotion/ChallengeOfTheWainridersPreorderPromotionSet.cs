using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.PreorderPromotion
{
    public class ChallengeOfTheWainridersPreorderPromotionSet
        : CardSet
    {
        public const string setName = "Challenge of the Wainriders Preorder Promotion";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "CotW-PRM";
            Number = 3;
            SetType = Models.SetType.Preorder_Promotion;
            Cycle = "Vengeance of Mordor";

            addHero("Saruman", 13, Sphere.Lore, 3, 4, 2, 4)
                .WithTraits("Istari.", "Isengard.")
                .WithTextLine("When a player card effect would reduce your threat by any amount, reduce that amount to 1.")
                .WithTextLine("While playing an event with the printed doomed keyword, Saruman gains the printed Leadership, Spirit, and Tactics icons.")
                .WithTextLine("Response: After you play a card with the doomed keyword, ready Saruman.")
                .WithTemplate("<p class='main-text'>When a player card effect would reduce your threat by any amount, reduce that amount to 1.</p><p class='main-text'>While playing <a href='/LotR?Query=%2Bkeyword%3ADoomed&CardType=Event' target='_blank' title='Doomed Events'>an event with the printed doomed keyword</a>, {self} gains the printed {sphere:Leadership}, {sphere:Spirit}, and {sphere:Tactics} icons.<p><p class='main-text'><b>Response:</b> After you play a card with the doomed keyword, ready {self}.</p>")
                .WithInfo(54, 1, Artist.Martin_de_Diego_Sadaba);
            addAttachment("Power of Command", 1, Sphere.Leadership, false)
                .WithTraits("Master.")
                .WithTextLine("Attach to the hero with The One Ring.")
                .WithTextLine("Limit 1 per hero. Attached hero gets +1 Willpower.")
                .WithTextLine("Response: After attached hero commits to the quest, exhaust The One Ring and raise your threat by 1 to give each other unique character you control +1 Willpower until the end of the phase.")
                .WithInfo(55, 1, Artist.Borja_Pindado);
            addAttachment("Golden Belt", 0, Sphere.Tactics, false)
                .WithTraits("Item.")
                .WithTextLine("Attach to a hero. Limit 1 per hero.")
                .WithTextLine("Attached hero can have 1 additional restricted attachment.")
                .WithFlavorLine("The lady bowed her head, and she turned to Boromir and to him she gave a belt of gold...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(60, 1, Artist.Nino_Vecia);
        }
    }
}
