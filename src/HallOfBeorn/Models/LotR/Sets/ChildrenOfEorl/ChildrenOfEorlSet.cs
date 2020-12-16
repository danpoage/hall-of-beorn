using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.ChildrenOfEorl
{
    public class ChildrenOfEorlSet
        : CardSet
    {
        private const string setName = "Children of Eorl";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "CoE";
            Number = 10001;
            SetType = Models.SetType.A_Long_extended_Party;

            IsSpoiler = true;

            addHero("Thengel", 11, Sphere.Spirit, 3, 1, 3, 4)
                .WithTraits("Rohan.", "Noble.", "Warrior.")
                .WithTextLine("Response: After a player discards an ally from play, that player searches the top 5 cards of their deck for an ally that shares a Trait with the discarded ally, puts it into play exhausted, and shuffles their deck. (Limit once per round.)")
                .WithFlavorLine("\"My friend,\" said Gandalf, \"you had horses, and deeds of arms, and the free fields.\"")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(3, 1, Artist.Unknown);
            addAlly("Morwen Steelsheen", 4, Sphere.Lore, true, 2, 0, 2, 2)
                .WithTraits("Rohan.", "Gondor.", "Noble.")
                .WithTextLine("Action: Put Morwen Steelsheen into play from your hand. Then, discard a Rohan or Gondor ally you control.")
                .WithTextLine("Response: After a Rohan or Gondor ally leaves play, exhaust Morwen Steelsheen to either heal 2 damage from a character or reduce your threat by 1.")
                .WithFlavorLine("She was clad now in mail and shone like silver in the sun.")
                .WithFlavorLine("-The Two Towers")
                .WithInfo(10, 3, Artist.Howard_Lyon);
        }
    }
}