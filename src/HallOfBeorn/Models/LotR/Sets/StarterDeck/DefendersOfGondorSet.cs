using System;

namespace HallOfBeorn.Models.LotR.Sets.StarterDeck
{
    public class DefendersOfGondorSet
        : CardSet
    {
        public const string setName = "Defenders of Gondor";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "DoG";
            SetType = Models.SetType.Starter_Deck;
            Cycle = "Starter Deck";
            Number = 5005;

            addHero("Boromir", 11, Sphere.Leadership, 1, 3, 2, 5)
                .WithTraits("Gondor.", "Warrior.", "Noble.")
                .WithTextLine("While Boromir has at least 1 resource in his resource pool, Gondor allies get +1 Attack.")
                .WithFlavorLine("\"By our valour the wild fold of the East are still restrained, and the terror of Morgul kept at bay...\" -The Fellowship of the Ring")
                .WithCommunityVersion("RiddermarkLord/Boromir-Leadership-Hero")
                .WithInfo(1, 1, Artist.Magali_Villeneuve);
            addHero("Mablung", 10, Sphere.Tactics, 2, 2, 2, 4)
                .WithTraits("Gondor.", "Ranger.")
                .WithTextLine("Response: After you engage an enemy, add 1 resource to Mablung's resource pool. (Limit once per phase.)")
                .WithFlavorLine("But the Captains of the West were well warned by their scouts, skilled men from Henneth Annûn led by Mablung...")
                .WithFlavorLine("-The Return of the King")
                .WithCommunityVersion("RiddermarkLord/Mablung-Tactics-Hero-1")
                .WithInfo(3, 1, Artist.Sebastian_Giacobino);
        }
    }
}