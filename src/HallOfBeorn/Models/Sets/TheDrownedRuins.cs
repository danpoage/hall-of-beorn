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

            Cards.Add(Card.Hero("Argalad", string.Empty, Sphere.Lore, 9, 2, 2, 1, 4)
                .WithTraits("Silvan.", "Scout.")
                .WithKeywords("Ranged.")
                .WithText("Action: Exhaust Argalad to choose an enemy in the staging area. Until the end of the phase, that enemy gets -X Threat, where X is Argalad's Attack. If this effect reduces the enemy's Threat to 0, deal 1 damage to it. (Limit once per round.)")
                .WithInfo(82, 1, Artist.Andreia_Ugrai));
            Cards.Add(Card.Ally("Dwarven Sellsword", "", Sphere.Leadership, 1, 2, 2, 2, 3)
                .WithGeneric()
                .WithTraits("Dwarf.", "Warrior.")
                .WithText("Forced: At the end of the round, discard Dwarven Sellsword unless the players as a group spend 1 Leadership resource.")
                .WithFlavor("...he did not altogether approve of dwarves and their love of gold...\r\n-The Hobbit")
                .WithInfo(83, 3, Artist.Unknown));
            Cards.Add(Card.Attachment("Dúnedain Remedy", string.Empty, Sphere.Leadership, 0)
                .WithNormalizedTitle("Dunedain Remedy")
                .WithGeneric()
                .WithTraits("Signal.")
                .WithText("Attach to a hero.\r\nResponse: After ~Dúnedain Remedy is attached to a hero, heal 1 damage on that hero.\r\nAction: Pay 1 resource from attached hero's resource pool to attach ~Dúnedain Remedy to another hero.")
                .WithInfo(84, 3, Artist.Drazenka_Kimpel));
            Cards.Add(Card.Ally("Marksman of Lórien", "", Sphere.Tactics, 3, 0, 3, 0, 2)
                .WithGeneric()
                .WithTraits("Silvan.", "Warrior.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Marksman of Lórien enters play, choose an enemy. That enemy gets -2 Defense until the end of the round.")
                .WithFlavor("\"Keen are the eyes of the Elves.\"\r\n-Aragorn, The Two Towers")
                .WithInfo(85, 3, Artist.Drazenka_Kimpel));
            Cards.Add(Card.Event("Battle-fury", string.Empty, Sphere.Tactics, 1)
                .WithText("Play only before the staging step.\r\nQuest Action: Exhaust a hero you control to immediately declare it as an attacker (and resolve its attack) against any eligible enemy target. Then, the players as a group may spend 1 Spirit resource to commit that hero to the quest.")
                .WithFlavor("Fey he seemed, or the battle-fury of his fathers ran like new fire in his veins...\r\n-The Return of the King")
                .WithInfo(86, 3, Artist.Guillaume_Ducos));
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
            Cards.Add(Card.Ally("Robin Smallburrow", string.Empty, Sphere.Lore, 2, 2, 0, 1, 2)
                .WithUnique()
                .WithTraits("Hobbit.", "Shirriff.")
                .WithText("Response: After you travel to a location, spend 1 Spirit resource to raise the engagement cost of each enemy in play by X until the end of the round, where X is that location's quest points. Any player may trigger this response.")
                .WithFlavor("\"Gave me a chance of walking round the country and seeing folk, and hearing the news, and knowing where the good beer was.\"\r\n-The Return of the King")
                .WithInfo(89, 3, Artist.Aleksander_Karcz));
            Cards.Add(Card.Event("Interrogation", string.Empty, Sphere.Lore, 1)
                .WithText("Action: Choose an enemy with an attached Trap card. Look at the top X cards of the encounter deck, where X is that enemy's printed Threat. You may discard 1 of those cards. Return the rest to the top of the deck, in the same order.")
                .WithInfo(90, 3, Artist.Joshua_Cairos));
            Cards.Add(Card.Attachment("Strider", "", Sphere.Neutral, 1)
                .WithUnique()
                .WithText("Attach to a hero.\r\nWhile you control 2 or fewer heroes, attached hero does not exhaust to commit to the quest.\r\nWhile you control 5 or fewer characters, attached hero gets +2 Willpower.")
                .WithFlavor("\"Strider can take you by paths that are seldom tridden. Will you have him?\"\r\n-Aragorn, The Fellowship of the Ring")
                .WithInfo(91, 3, Artist.Unknown));
        }
    }
}