using System;

namespace HallOfBeorn.Models.LotR.Sets.PreorderPromotion
{
    public class UnderTheAshMountainsPreorderPromotionSet
    {
        private const string setName = "Under the Ash Mountains Preorder Promotion";

        public static CardSet Create() {

            var cs = CardSet.Create(setName, "UtAM-PRM", Models.SetType.Preorder_Promotion, "Vengeance of Mordor", 4);

            cs.addHero("Gildor Inglorion", 9, Sphere.Leadership, 3, 2, 1, 3)
                .WithTraits("Noldor.", "Noble.")
                .WithTextLine("Action: Pay 1 resource from Gildor Inglorion's resource pool to choose a player to draw 1 card (Limit once per round.)")
                .WithFlavorLine("\"Gildor Inglorion of the House of Finrod. We are Exiles, and most of our kindred have long ago departed...\"")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithCommunityVersion("Autumn/Gildor-Inglorion-Leadership-Hero")
                .WithPromotion()
                .WithInfo(81, 1, Artist.Jason_Jenicke);
            cs.addAlly("Wandering Exile", 3, Sphere.Leadership, false, 2, 2, 0, 2)
                .WithTraits("Noldor.")
                .WithTextLine("Response: After Wandering Exile commits to a quest, discard a card from your hand to ready Wandering Exile.")
                .WithFlavorLine("\"The Elves have their own labours and their own sorrows...")
                .WithFlavorLine("-Gildor, The Fellowship of the Ring")
                .WithPromotion()
                .WithInfo(82, 1, Artist.Drazenka_Kimpel);
            cs.addAlly("Northern Bowmaster", 1, Sphere.Tactics, false, 0, 2, 0, 1)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("You cannot play Northern Bowmaster from your hand unless you are engaged with an enemy.")
                .WithPromotion()
                .WithInfo(86, 1, Artist.Aleksander_Karcz);

            return cs;
        }

        /*
        protected void Initialize()
        {
            Name = setName;
            Abbreviation = "UtAM-PRM";
            Number = 4;
            SetType = Models.SetType.Preorder_Promotion;
            Cycle = "Vengeance of Mordor";

            addHero("Gildor Inglorion", 9, Sphere.Leadership, 3, 2, 1, 3)
                .WithTraits("Noldor.", "Noble.")
                .WithTextLine("Action: Pay 1 resource from Gildor Inglorion's resource pool to choose a player to draw 1 card (Limit once per round.)")
                .WithFlavorLine("\"Gildor Inglorion of the House of Finrod. We are Exiles, and most of our kindred have long ago departed...\"")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithCommunityVersion("Autumn/Gildor-Inglorion-Leadership-Hero")
                .WithPromotion()
                .WithInfo(81, 1, Artist.Jason_Jenicke);
            addAlly("Wandering Exile", 3, Sphere.Leadership, false, 2, 2, 0, 2)
                .WithTraits("Noldor.")
                .WithTextLine("Response: After Wandering Exile commits to a quest, discard a card from your hand to ready Wandering Exile.")
                .WithFlavorLine("\"The Elves have their own labours and their own sorrows...")
                .WithFlavorLine("-Gildor, The Fellowship of the Ring")
                .WithPromotion()
                .WithInfo(82, 1, Artist.Drazenka_Kimpel);
            addAlly("Northern Bowmaster", 1, Sphere.Tactics, false, 0, 2, 0, 1)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("You cannot play Northern Bowmaster from your hand unless you are engaged with an enemy.")
                .WithPromotion()
                .WithInfo(86, 1, Artist.Aleksander_Karcz);
        }*/
    }
}
