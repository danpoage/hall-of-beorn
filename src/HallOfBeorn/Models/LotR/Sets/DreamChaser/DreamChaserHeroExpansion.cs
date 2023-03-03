using System;

namespace HallOfBeorn.Models.LotR.Sets.DreamChaser
{
    public static class DreamChaserHeroExpansion
    {
        public static CardSet Create()
        {
            var cs = CardSet.Create("Dream-chaser Hero Expansion", "DCH", SetType.Hero_Expansion, Cycles.DreamChaser, 401);

            cs.addHero("Círdan the Shipwright", 12, Sphere.Spirit, 4, 2, 2, 4)
                .WithTraits("Noldor.", "Noble.")
                .WithTextLine("Draw 1 additional card at the beginning of the resource phase.")
                .WithTextLine("Forced: After drawing cards at the beginning of the resource phase, choose and discard 1 of those cards.")
                .WithFlavorLine("Very tall he was, and his beard was long, and he was grey and old, save that his eyes were keen as stars...")
                .WithFlavorLine("-The Return of the King")
                .WithCommunityVersion("RiddermarkLord/Cirdan-the-Shipwright")
                .WithAges(Age.First_Age, Age.Second_Age, Age.Third_Age)
                .WithInfo(1, 1, Artist.Aleksander_Karcz);
            cs.addHero("Galdor of the Havens", 9, Sphere.Lore, 2, 2, 1, 4)
                .WithTraits("Noldor.")
                .WithTextLine("Response: After drawing your setup hand, instead of taking a mulligan, you may discard any number of cards from your hand. Then, draw that many cards.")
                .WithTextLine("Action: If you have no cards in your hand, draw 6 cards. (Limit once per game.)")
                .WithFlavorLine("\"What power still remains lies with us...\"")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithCommunityVersion("Autumn/Galdor-of-the-Havens-Lore-Hero")
                .WithAges(Age.Second_Age, Age.Third_Age)
                .WithInfo(2, 1, Artist.Lukasz_Jaskolski);

            return cs;
        }
    }
}