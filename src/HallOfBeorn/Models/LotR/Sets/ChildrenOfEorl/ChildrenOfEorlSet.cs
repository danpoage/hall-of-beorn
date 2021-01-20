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

            addHero("Ingold", 10, Sphere.Leadership, 3, 1, 2, 4)
                .WithTraits("Gondor.", "Warrior.")
                .WithTextLine("Response: After a Gondor or Warrior ally enters play under your control, draw 1 card. Then, either spend 1 resource from Ingold's pool or raise your threat by 1. (Limit once per phase.)")
                .WithFlavorLine("\"We wish for no strangers in the land at this time, unless they be mighty men of arms in whose faith and help we can trust.\"")
                .WithTextLine("-The Return of the King")
                .WithInfo(1, 1, Artist.Agni_Interactive);

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

            addEvent("Worthy of Remembrance", 0, Sphere.Tactics)
                .WithTextLine("Combat Action: Discard a Rohan ally you control to choose an enemy. Deal 2 damage to that enemy (4 damage instead if the ally was unique).")
                .WithFlavorLine("Then the heart of Éowyn changed... suddenly her winter passed, and the sun shone on her.")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(18, 3, Artist.Anato_Finnstark);

            addContract("The Last Alliance")
                .WithTextLine("Choose two traits, A and B. Each of your starting heroes and each ally in your deck must have either the printed A or B trait (but not both). You must have at last 1 starting hero and 10 allies in your deck with each trait.")
                .WithTextLine("Setup: Flip this card over.")
                .WithFlavorLine("\"The strength of the Elves to resits him was greater long ago; and not all Men were estranged to them.\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithOppositeTextLine("While you control more A character than B characters, reduce the cost of the first B ally you play this round by 1, and vice versa.")
                .WithOppositeTextLine("Action: Exhaust The Last Alliance to choose a card in your hand or a card in play under you control. Replace each printed instance of \"A\" or \"B\" in that card's ability text with \"A or B\" until the end of the round.")
                .WithInfo(85, 1, Artist.Unknown);
        }
    }
}