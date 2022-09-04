using System;

namespace HallOfBeorn.Models.LotR.Sets.PreorderPromotion
{
    public class WrathAndRuinPreorderPromotionSet
    {
        private const string setName = "Wrath and Ruin Preorder Promotion";

        public static CardSet Create() {

            var cs = CardSet.Create(setName, "WaR-PRM", Models.SetType.Preorder_Promotion, "Vengeance of Mordor", 1);

            cs.addHero("Thorin Stonehelm", 9, Sphere.Tactics, 1, 3, 1, 4)
                .WithTraits("Dwarf.", "Noble.", "Warrior.")
                .WithTextLine("Response: After Thorin Stonehelm is declared as an attacker, discard the top card of your deck to deal 1 damage to an enemy engaged with you.")
                .WithFlavorLine("Thorin III Stonehelm, Dain's son, became King under the mountain.")
                .WithFlavorLine("-The Return of the King")
                .WithYear(2019)
                .WithCommunityVersion("Autumn/Thorin-Stonehelm")
                .WithPromotion()
                .WithInfo(1, 1, Artist.Rafal_Hrynkiewicz);
            cs.addAlly("Soldier of Gondor", 2, Sphere.Leadership, false, 1, 1, 1, 2)
                .WithTraits("Gondor.")
                .WithTextLine("Response: After Soldier of ~Gondor enters play, seach the top 5 cards of your deck for a Gondor ally and add it to your hand (any number of Gondor allies instead if your threat is 40 or higher). Shuffle your deck.")
                .WithPromotion()
                .WithInfo(2, 1, Artist.Stanislav_Dikolenko);
            cs.addAlly("Tom Bombadil", 255, Sphere.Neutral, true, 3, 3, 3, 6)
                .WithTraits("Legend.")
                .WithKeywords("Encounter.")
                .WithTextLine("Encounter.")
                .WithTextLine("When Revealed: Choose a player. That player gains control of Tom Bombadil, ready and committed to the quest. At the end of the round, remove Tom Bombadil and a copy of Tom Bombadillo! in the victory display from the game. This effect cannot be cancelled.")
                .WithPromotion()
                .WithInfo(10, 1, Artist.Borja_Pindado);

            return cs;
        }

        /*
        protected void Initialize()
        {
            Name = setName;
            Abbreviation = "WaR-PRM";
            Number = 1;
            SetType = Models.SetType.Preorder_Promotion;
            Cycle = "Vengeance of Mordor";

            addHero("Thorin Stonehelm", 9, Sphere.Tactics, 1, 3, 1, 4)
                .WithTraits("Dwarf.", "Noble.", "Warrior.")
                .WithTextLine("Response: After Thorin Stonehelm is declared as an attacker, discard the top card of your deck to deal 1 damage to an enemy engaged with you.")
                .WithFlavorLine("Thorin III Stonehelm, Dain's son, became King under the mountain.")
                .WithFlavorLine("-The Return of the King")
                .WithYear(2019)
                .WithCommunityVersion("Autumn/Thorin-Stonehelm")
                .WithPromotion()
                .WithInfo(1, 1, Artist.Rafal_Hrynkiewicz);
            addAlly("Soldier of Gondor", 2, Sphere.Leadership, false, 1, 1, 1, 2)
                .WithTraits("Gondor.")
                .WithTextLine("Response: After Soldier of ~Gondor enters play, seach the top 5 cards of your deck for a Gondor ally and add it to your hand (any number of Gondor allies instead if your threat is 40 or higher). Shuffle your deck.")
                .WithPromotion()
                .WithInfo(2, 1, Artist.Stanislav_Dikolenko);
            addAlly("Tom Bombadil", 255, Sphere.Neutral, true, 3, 3, 3, 6)
                .WithTraits("Legend.")
                .WithKeywords("Encounter.")
                .WithTextLine("Encounter.")
                .WithTextLine("When Revealed: Choose a player. That player gains control of Tom Bombadil, ready and committed to the quest. At the end of the round, remove Tom Bombadil and a copy of Tom Bombadillo! in the victory display from the game. This effect cannot be cancelled.")
                .WithPromotion()
                .WithInfo(10, 1, Artist.Borja_Pindado);
        }*/
    }
}
