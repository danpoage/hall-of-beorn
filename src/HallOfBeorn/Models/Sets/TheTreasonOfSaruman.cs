using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheTreasonOfSaruman : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Treason of Saruman";
            Abbreviation = "ToS";
            Number = 1005;
            SetType = Models.SetType.Saga_Expansion;
            Cycle = "The Lord of the Rings";

            Cards.Add(Card.Hero("Aragorn", "913A68C4-876B-4AD4-AF08-A291B2E3D053", Sphere.Fellowship, 0, 2, 3, 2, 5)
                .WithTraits("Dúnedain.", "Noble.", "Ranger.")
                .WithText("The first player gains control of Aragorn. If Aragorn leaves play, the players lose the game.\r\nAction: Spend 2 resources from Aragorn's resource pool to ready a hero.")
                .WithInfo(1, 1, Artist.Mark_Behm));
            Cards.Add(Card.Hero("Théoden", "F4529F02-EE47-4FA4-A5E3-F755E3620CF3", Sphere.Spirit, 12, 2, 3, 2, 4)
                .WithTraits("Noble.", "Rohan.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Reduce the cost of the first Rohan ally you play from your hand each round by 1 (to a minimum of 0).")
                .WithFlavor("\"Arise now, arise, Riders of Théoden!\" -The Two Towers")
                .WithInfo(2, 1, Artist.Tiziano_Baracchi));
            Cards.Add(Card.Hero("Treebeard", "A9CD7B5C-39B9-4446-9075-636E5F69761F", Sphere.Lore, 13, 2, 3, 3, 5)
                .WithTraits("Ent.")
                .WithText("Action: Deal 1 damage to Treebeard to give him +1 Willpower and +1 Attack until the end of the phase. (Limit 5 times per phase.)")
                .WithInfo(3, 1, Artist.Unknown));
            Cards.Add(Card.Ally("Gimli", "", Sphere.Leadership, 4, 2, 2, 2, 3)
                .WithUnique()
                .WithTraits("Dwarf.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After an enemy is revealed from the encounter deck, ready Gimli.")
                .WithInfo(4, 3, Artist.Lukasz_Jaskolski));
            //Cards.Add(Card.Ally("Legolas", "", Sphere.Tactics
            Cards.Add(Card.Event("The Three Hunters", "207FB055-CAF4-4AA0-804D-7009922CA67B", Sphere.Fellowship, 3)
                .WithText("Play only if you control Fellowship Aragorn.\r\nQuest Action: Choose 3 heroes committed to the quest. Until the end of the round, each of the chosen heroes gets +1 Willpower, +1 Attack and +1 Defense.")
                .WithFlavor("\"We shall makes such a chase as shall be accounted a marvel among the Three Kindreds: Elves, Dwarves, and Men. Forth the Three Hunters!\" -Aragorn, The Two Towers")
                .WithInfo(13, 3, Artist.Nicholas_Gregory));
        }
    }
}