using System;

namespace HallOfBeorn.Models.LotR.Sets.StarterDeck
{
    public class ElvesOfLorienSet
        : CardSet
    {
        public const string setName = "Elves of Lórien";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "EoL";
            SetType = Models.SetType.Starter_Deck;
            Cycle = "Starter Deck";
            Number = 5004;

            addHero("Celeborn", 11, Sphere.Leadership, 3, 2, 2, 4)
                .WithTraits("Silvan.", "Noble.")
                .WithTextLine("Response: After a Silvan ally enters play, that ally gets +1 Willpower, +1 Attack and +1 Defense until the end of the round.")
                .WithFlavorLine("\"...the lord of the Galadhrim is accounted wisest of the Elves of Middle-earth, and a giver of gifts beyond the power of kings.\" -Galadriel, The Fellowship of the Ring")
                .WithCommunityVersion("RiddermarkLord/Celeborn-1")
                .WithCommunityVersion("RiddermarkLord/Celeborn-2")
                .WithAges(Age.First_Age, Age.Second_Age, Age.Third_Age)
                .WithInfo(1, 1, Artist.Magali_Villeneuve);
            addHero("Galadriel", 9, Sphere.Spirit, 4, 0, 0, 4)
                .WithTraits("Noldor.", "Noble.")
                .WithTextLine("Galadriel cannot quest, attack, or defend. Allies you control do not exhaust to commit to the quest during the round they enter play.")
                .WithTextLine("Action: Exhaust Galadriel to choose a player. That player reduces his threat by 1 and draws 1 card. (Limit once per round.)")
                .WithCommunityVersion("Galadriel-Grey-Company-Gen-Con-2015")
                .WithCommunityVersion("Galadriel-Whispers-in-the-Trees")
                .WithCommunityVersion("Galadriel-Nouveau-Hunters")
                .WithCommunityVersion("RiddermarkLord/Galadriel-Spirit-Hero-1")
                .WithCommunityVersion("RiddermarkLord/Galadriel-Spirit-Hero-2")
                .WithCommunityVersion("Hrodebert/Galadriel-Spirit-Hero-1")
                .WithCommunityVersion("Hrodebert/Galadriel-Spirit-Hero-2")
                .WithAges(Age.First_Age, Age.Second_Age, Age.Third_Age)
                .WithInfo(2, 1, Artist.Magali_Villeneuve);
        }
    }
}