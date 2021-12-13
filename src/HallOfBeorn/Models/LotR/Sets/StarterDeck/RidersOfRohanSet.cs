using System;

namespace HallOfBeorn.Models.LotR.Sets.StarterDeck
{
    public class RidersOfRohanSet
        : CardSet
    {
        public const string setName = "Riders of Rohan";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "RoR";
            SetType = Models.SetType.Starter_Deck;
            Cycle = "Starter Deck";
            Number = 5006;

            addHero("Éomer", 10, Sphere.Tactics, 1, 3, 2, 4)
                .WithTraits("Rohan.", "Noble.", "Warrior.")
                .WithTextLine("Response: After a character leaves play, Éomer gets +2 Attack until the end of the round. (Limit once per round.)")
                .WithFlavorLine("\"I am named Éomer son of Éomund, and am called the Third Marshal of Riddermark.\" -The Two Towers")
                .WithCommunityVersion("RiddermarkLord/Eomer-Tactics-Hero-1")
                .WithCommunityVersion("RiddermarkLord/Eomer-Tactics-Hero-2")
                .WithInfo(1, 1, Artist.Magali_Villeneuve);
            addHero("Lothíriel", 8, Sphere.Spirit, 3, 1, 1, 3)
                .WithTraits("Gondor.", "Noble.")
                .WithTextLine("If Éomer is in play, Lothíriel gains the Rohan trait.")
                .WithTextLine("Response: After Lothíriel commits to a quest, choose an ally in your hand. If that ally shares a Trait with her, put that ally into play exhausted and committed to the quest. At the end of the phase, if that ally is still in play, shuffle it into your deck.")
                .WithCommunityVersion("Autumn/Lothiriel")
                .WithInfo(3, 1, Artist.Alvaro_Calvo_Escudero);
        }
    }
}