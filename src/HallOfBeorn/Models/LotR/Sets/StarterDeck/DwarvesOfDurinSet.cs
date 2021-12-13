using System;

namespace HallOfBeorn.Models.LotR.Sets.StarterDeck
{
    public class DwarvesOfDurinSet
        : CardSet
    {
        public const string setName = "Dwarves of Durin";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "DoD";
            SetType = Models.SetType.Starter_Deck;
            Cycle = "Starter Deck";
            Number = 5003;

            addHero("Dáin Ironfoot", 11, Sphere.Leadership, 1, 2, 3, 5)
                .WithTraits("Dwarf.", "Noble.")
                .WithTextLine("While Dáin Ironfoot is ready, Dwarf characters get +1 Attack and +1 Willpower.")
                .WithFlavorLine("\"You have not heard of Dáin and the dwarves of the Iron Hills?\"")
                .WithFlavorLine("-Bilbo Baggins, The Hobbit")
                .WithCommunityVersion("Autumn/Dain-Ironfoot-Leadership")
                .WithCommunityVersion("RiddermarkLord/Dain-Ironfoot-Leadership-Hero-1")
                .WithCommunityVersion("RiddermarkLord/Dain-Ironfoot-Leadership-Hero-2")
                .WithCommunityVersion("RiddermarkLord/Dain-Ironfoot-Leadership-Hero-3")
                .WithCommunityVersion("Hrodebert/Dain-Ironfoot-Leadership-Hero-1")
                .WithCommunityVersion("Hrodebert/Dain-Ironfoot-Leadership-Hero-2")
                .WithCommunityVersion("Hrodebert/Dain-Ironfoot-Leadership-Hero-3")
                .WithInfo(1, 1, Artist.Tiziano_Baracchi);
            addHero("Ori", 8, Sphere.Lore, 2, 2, 1, 3)
                .WithTraits("Dwarf.")
                .WithTextLine("If you control at least 5 Dwarf characters, draw 1 additional card at the beginning of the resource phase.")
                .WithFlavorLine("\"He could write well and speedily, and often used the Elvish characters.\"")
                .WithFlavorLine("-Gimli, The Fellowship of the Ring")
                .WithCommunityVersion("RiddermarkLord/Ori-Lore-Hero-1")
                .WithCommunityVersion("RiddermarkLord/Ori-Lore-Hero-2")
                .WithCommunityVersion("Hrodebert/Ori-Lore-Hero")
                .WithInfo(2, 1, Artist.Blake_Henriksen);
        }
    }
}