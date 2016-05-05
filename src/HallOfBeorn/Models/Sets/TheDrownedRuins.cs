using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheDrownedRuins : CardSet
    {
        private string setName = "The Drowned Ruins";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TDRu";
            Number = 39;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dream-chaser";

            Cards.Add(Card.Ally("Dwarven Sellsword", "", Sphere.Leadership, 1, 2, 2, 2, 3)
                .WithGeneric()
                .WithTraits("Dwarf.", "Warrior.")
                .WithText("Forced: At the end of the round, discard Dwarven Sellsword unless the players as a group spend 1 Leadership resource.")
                .WithFlavor("...he did not altogether approve of dwarves and their love of gold...\r\n-The Hobbit")
                .WithInfo(83, 3, Artist.Unknown));
            Cards.Add(Card.Ally("Marksman of Lórien", "", Sphere.Tactics, 3, 0, 3, 0, 2)
                .WithGeneric()
                .WithTraits("Silvan.", "Warrior.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Marksman of Lórien enters play, choose an enemy. That enemy gets -2 Defense until the end of the round.")
                .WithFlavor("\"Keen are the eyes of the Elves.\"\r\n-Aragorn, The Two Towers")
                .WithInfo(85, 3, Artist.Drazenka_Kimpel));
            Cards.Add(Card.Ally("Woodland Courier", "", Sphere.Spirit, 2, 1, 1, 0, 1)
                .WithGeneric()
                .WithTraits("Silvan.", "Scout.")
                .WithText("Response: After Woodland Courier enters play, place 1 progress on a location (2 progress instead if that location has the Forest trait).")
                .WithInfo(87, 3, Artist.Drazenka_Kimpel));
            Cards.Add(Card.Attachment("Hithlain", "", Sphere.Spirit, 1)
                .WithTraits("Item.")
                .WithText("Attach to a location. Limit 1 per location.\r\nResponse: After a player plays a Silvan ally from his hand, place 1 progress on attached location.")
                .WithFlavor("He made his end of the rope fast about another tree, and then ran lightly along it, over the river and back again, as if he were on a round.\r\n-The Fellowship of the Ring")
                .WithInfo(88, 3, Artist.Mariusz_Gandzel));
            Cards.Add(Card.Attachment("Strider", "", Sphere.Neutral, 1)
                .WithUnique()
                .WithText("Attach to a hero.\r\nWhile you control 2 or fewer heroes, attached hero does not exhaust to commit to the quest.\r\nWhile you control 5 or fewer characters, attached hero gets +2 Willpower.")
                .WithFlavor("\"Strider can take you by paths that are seldom tridden. Will you have him?\"\r\n-Aragorn, The Fellowship of the Ring")
                .WithInfo(91, 3, Artist.Unknown));
        }
    }
}