using System;

namespace HallOfBeorn.Models.LotR.Sets.AngmarAwakened
{
    public class AngmarAwakenedHeroExpansionCardSet
        : CardSet
    {
        protected override void Initialize()
        {
            Name = "Angmar Awakened Hero Expansion";
            Abbreviation = "AAH";
            Number = 301;
            SetType = Models.SetType.Hero_Expansion;
            Cycle = "Angmar Awakened";

            addHero("Aragorn", 12, Sphere.Tactics, 2, 3, 2, 5)
                .WithTraits("Dúnedain.", "Ranger.", "Warrior.")
                .WithTextLine("Each enemy engaged with you gets -1 Defense.")
                .WithTextLine("Response: After Aragorn participates in an attack that destroys an enemy, choose an enemy not engaged with you and engage that enemy.")
                .WithFlavorLine("\"I serve no man,\" said Aragorn; \"but the servants of Sauron I pursue into whatever land they may go.\" -The Two Towers")
                .WithCommunityVersion("Aragorn-Grey-Company-Gen-Con-2015")
                .WithCommunityVersion("RiddermarkLord/Aragorn-Tactics")
                .WithInfo(1, 1, Artist.Sebastian_Giacobino);
            addHero("Halbarad", 10, Sphere.Leadership, 2, 2, 2, 4)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithTextLine("While you are engaged with any enemy, Halbarad does not exhaust to commit to a quest.")
                .WithTextLine("You may optionally engage 1 additional enemy during the encounter phase.")
                .WithFlavorLine("\"Little do they know of our long labour for the safekeeping of their borders, and yet I grudge it not.\" -The Return of the King")
                .WithCommunityVersion("Halbarad-Grey-Company-Gen-Con-2015")
                .WithInfo(2, 1, Artist.Smirtouille);
        }
    }
}