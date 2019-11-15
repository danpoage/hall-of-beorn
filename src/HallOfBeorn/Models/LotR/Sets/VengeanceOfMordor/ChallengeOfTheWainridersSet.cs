using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.VengeanceOfMordor
{
    public class ChallengeOfTheWainridersSet 
        : CardSet
    {
        public const string setName = "Challenge of the Wainriders";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "CotW";
            Number = 59;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Vengeance of Mordor";

            IsSpoiler = true;

            addHero("Saruman", 13, Sphere.Lore, 3, 4, 2, 4)
                .WithTraits("Istari.", "Isengard.")
                .WithText("When a player card effect would lower your threat by any amount, reduce that amount to 1 instead.\r\nWhen you play an event with the Doomed keyword, Saruman is considered to the have Leadership, Spirit, and Tactics resource icons.\r\nResponse: When you play an event with the Doomed keyword, ready Saruman.")
                .WithInfo(54, 1, Artist.Martin_de_Diego_Sadaba);
            addAlly("Rohirrim Scout", 2, Sphere.Spirit, false, 1, 1, 0, 2)
                .WithTraits("Rohan.", "Scout.")
                .WithText("Action: Discard Rohirrim Scout to choose a non-unique enemy in the staging area. Until the end of the round, the chosen enemy does not make engagement checks.")
                .WithInfo(61, 3, Artist.Unknown);
            addAttachment("Saruman's Staff", 2, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Item.", "Staff.")
                .WithKeywords("Restricted.")
                .WithText("Attach to Saruman. Restricted.\r\nAction: Exhaust Saruman's Staff to (choose 1): Lower the value of X by 2, where X is the Doomed value of the next event you play this phase; or search the top 5 cards of your deck for a Doomed event and add it to your hand. Shuffle your deck.")
                .WithInfo(63, 3, Artist.Nikolas_Hagialas);
        }
    }
}