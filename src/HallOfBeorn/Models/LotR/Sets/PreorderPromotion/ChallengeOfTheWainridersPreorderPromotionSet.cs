using System;

namespace HallOfBeorn.Models.LotR.Sets.PreorderPromotion
{
    public class ChallengeOfTheWainridersPreorderPromotionSet
    {
        private const string setName = "Challenge of the Wainriders Preorder Promotion";

        public static CardSet Create()
        {
            var cs = CardSet.Create(setName, "CotW-PRM", Models.SetType.Preorder_Promotion, "Vengeance of Mordor", 3);

            cs.addHero("Saruman", 13, Sphere.Lore, 3, 4, 2, 4)
                .WithTraits("Istari.", "Isengard.")
                .WithTextLine("When a player card effect would reduce your threat by any amount, reduce that amount to 1.")
                .WithTextLine("While playing an event with the printed doomed keyword, Saruman gains the printed Leadership, Spirit, and Tactics icons.")
                .WithTextLine("Response: After you play a card with the doomed keyword, ready Saruman.")
                .WithPromotion()
                .WithInfo(54, 1, Artist.Martin_de_Diego_Sadaba);

            cs.addAttachment("Power of Command", 1, Sphere.Leadership, false)
                .WithTraits("Master.")
                .WithTextLine("Attach to the hero with The One Ring.")
                .WithTextLine("Limit 1 per hero. Attached hero gets +1 Willpower.")
                .WithTextLine("Response: After attached hero commits to the quest, exhaust The One Ring and raise your threat by 1 to give each other unique character you control +1 Willpower until the end of the phase.")
                .WithPromotion()
                .WithInfo(55, 1, Artist.Borja_Pindado);

            cs.addAttachment("Golden Belt", 0, Sphere.Tactics, false)
                .WithTraits("Item.")
                .WithTextLine("Attach to a hero. Limit 1 per hero.")
                .WithTextLine("Attached hero can have 1 additional restricted attachment.")
                .WithFlavorLine("The lady bowed her head, and she turned to Boromir and to him she gave a belt of gold...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithPromotion()
                .WithInfo(60, 1, Artist.Nino_Vecia);

            return cs;
        }

        /*
        protected void Initialize()
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
                .WithPromotion()
                .WithInfo(54, 1, Artist.Martin_de_Diego_Sadaba);
            addAttachment("Power of Command", 1, Sphere.Leadership, false)
                .WithTraits("Master.")
                .WithTextLine("Attach to the hero with The One Ring.")
                .WithTextLine("Limit 1 per hero. Attached hero gets +1 Willpower.")
                .WithTextLine("Response: After attached hero commits to the quest, exhaust The One Ring and raise your threat by 1 to give each other unique character you control +1 Willpower until the end of the phase.")
                .WithPromotion()
                .WithInfo(55, 1, Artist.Borja_Pindado);
            addAttachment("Golden Belt", 0, Sphere.Tactics, false)
                .WithTraits("Item.")
                .WithTextLine("Attach to a hero. Limit 1 per hero.")
                .WithTextLine("Attached hero can have 1 additional restricted attachment.")
                .WithFlavorLine("The lady bowed her head, and she turned to Boromir and to him she gave a belt of gold...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithPromotion()
                .WithInfo(60, 1, Artist.Nino_Vecia);
        }*/
    }
}
