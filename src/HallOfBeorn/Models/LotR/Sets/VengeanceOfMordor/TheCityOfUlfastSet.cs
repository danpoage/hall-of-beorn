using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.VengeanceOfMordor
{
    public class TheCityOfUlfastSet : CardSet
    {
        public const string setName = "The City of Ulfast";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TCoU";
            Number = 58;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Vengeance of Mordor";

            IsSpoiler = true;

            addHero("Lothíriel", 8, Sphere.Spirit, 3, 1, 1, 3)
                .WithTraits("Gondor.", "Noble.")
                .WithTextLine("If Éomer is in play, Lothíriel gains the Rohan trait.")
                .WithTextLine("Response: After Lothíriel commits to a quest, choose an ally in your hand. If that ally shares a Trait with her, put that ally into play exhausted and committed to the quest. At the end of the phase, if that ally is still in play, shuffle it into your deck.")
                .WithInfo(27, 1, Artist.Alvaro_Calvo_Escudero);

            addAlly("Angbor the Fearless", 2, Sphere.Leadership, true, 2, 1, 0, 2)
                .WithTraits("Gondor.", "Warrior.")
                .WithTextLine("While your threat is 40 or higher, Angbor the Fearless gets +2 Attack and does not exhaust to quest.")
                .WithFlavorLine("\"Four thousands I sent marching from Pelargir through Lossarnach two days ago; and Angbor the fearless rides before them.\"")
                .WithFlavorLine("-Aragorn, The Return of the King")
                .WithInfo(28, 3, Artist.Unknown);
            addEvent("Need Drives Them", 3, Sphere.Leadership)
                .WithTextLine("Action: Each player whose threat is 40 or higher readies all characters he controls.")
                .WithInfo(29, 3, Artist.Unknown);
            addAlly("Woodland Sentry", 3, Sphere.Lore, false, 1, 1, 1, 2)
                .WithTraits("Silvan.")
                .WithTextLine("Response: After you play Woodland Sentry from your hand, choose an enemy or location in play. If there is a copy of that card in the victory display, discard the chosen card.")
                .WithFlavorLine("In the Wide World the Wood-elves lingered in the twilight of our Sun and Moon but loved best the stars...")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(30, 3, Artist.Sara_Biddle);
            addAttachment("Keen Longbow", 2, Sphere.Lore, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Lore hero. Limit 1 per hero.")
                .WithTextLine("Restricted.")
                .WithTextLine("Attached hero gains ranged.")
                .WithTextLine("Response: After attached hero is declared an as attacker against an enemy, discard up to 3 cards from your hand to deal 1 damage to that enemy for each card discarded this way.")
                .WithInfo(31, 3, Artist.Unknown);
            addAttachment("War Axe", 1, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Tactics character. Limit 1 per character. Restricted.")
                .WithTextLine("Attached characters gets +1 Attack for each attachment it has with the restricted keyword.")
                .WithFlavorLine("\"Gimli Glóin's son, have you your axe ready?\"")
                .WithFlavorLine("-Éomer, The Return of the King")
                .WithInfo(32, 3, Artist.Unknown);
            addAttachment("Strength and Courage", 1, Sphere.Tactics, false)
                .WithTraits("Master.")
                .WithTextLine("Attach to the hero with The One Ring.")
                .WithTextLine("Limit 1 per hero. Attached hero gets +1 Attack.")
                .WithTextLine("Response: After attached hero is declared as an attacker, exhaust The One Ring and raise your threat by 1 to double attached hero's printed Attack for this attack.")
                .WithInfo(33, 3, Artist.Unknown);
            addAlly("Knight of Belfalas", 2, Sphere.Spirit, false, 1, 2, 0, 2)
                .WithTraits("Gondor.", "Warrior.")
                .WithTextLine("Response: After Knight of Belfalas enters play, return a Gondor ally from your discard pile to your hand.")
                .WithFlavorLine("The mounted knights returned, and at their rear the banner of Dol Amroth...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(34, 3, Artist.Unknown);
            addAttachment("Horn of the Mark", 1, Sphere.Spirit, true)
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Rohan hero or Merry. Restricted.")
                .WithTextLine("Response: When a character leaves play, if that character shares at least one trait with the attached hero, exhaust Horn of the AMark to draw 1 card.")
                .WithFlavorLine("Then Éowyn gave to Merry an ancient horn, small but cunningly wrought all of fair silver with a baldric of green.")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(35, 3, Artist.Unknown);
            addEvent("Host of Galadhrim", 4, Sphere.Neutral)
                .WithTextLine("Planning Action: Return each Silvan ally you control to your hand. Then, play each of those allies from your hand one at a time at no cost.")
                .WithFlavorLine("Celeborn came forth and led the host of Lórien...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(36, 3, Artist.Leanna_Crossan);
            addContract("Forth, The Three Hunters!")
                .WithTextLine("Your deck cannot include ally cards.")
                .WithTextLine("Each of your heroes can have 1 additional restricted attachment. Reduce the cost of the first restricted attachment you play on each of your heroes each round by 1.")
                .WithTextLine("Refresh Action: If each of your heroes has at least 2 restricted attachments, flip this card over.")
                .WithFlavorLine("\"...we that remain cannot forsake our companions while we have strength left.\"")
                .WithFlavorLine("-Aragorn, The Two Towers")
                .WithOppositeTextLine("Each of your heroes can have 1 additional restricted attachment and gets +1 Willpower for each restricted attachment on it.")
                .WithOppositeTextLine("Action: Exhaust this card to heal 1 damage from each of your heroes.")
                .WithOppositeFlavorLine("\"With hope or without hope we will follow the trail of our enemies. And woe to them, if we prove the swifter!\"")
                .WithOppositeFlavorLine("-Aragorn, The Two Towers")
                .WithInfo(49, 1, Artist.Justin_Gerard);
        }
    }
}
