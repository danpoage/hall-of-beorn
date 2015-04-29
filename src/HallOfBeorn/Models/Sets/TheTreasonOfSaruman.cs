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
            Cards.Add(Card.Ally("Gimli", "8C4FBDC9-60C4-446D-B7E9-14AECD7DC0C6", Sphere.Leadership, 4, 2, 2, 2, 3)
                .WithUnique()
                .WithTraits("Dwarf.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After an enemy is revealed from the encounter deck, ready Gimli.")
                .WithInfo(4, 3, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Ally("Legolas", "7727D4B3-D23D-403D-8BC2-2C77665CBE93", Sphere.Tactics, 4, 1, 3, 1, 3)
                .WithUnique()
                .WithTraits("Silvan.", "Warrior.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Legolas participates in an attack that destroys an enemy, draw 1 card.")
                .WithFlavor("\"He stands not alone,\" said Legolas, bending his bow and fitting an arrow with hands that moved quicker than sight. -The Two Towers")
                .WithInfo(5, 3, Artist.Sebastian_Giacobino));
            Cards.Add(Card.Ally("Quickbeam", "84910290-AC5D-4904-8998-9851A598B9AB", Sphere.Lore, 2, 2, 3, 1, 3)
                .WithUnique()
                .WithTraits("Ent.")
                .WithText("Cannot have restricted attachments. Enters play exhausted.\r\nResponse: After Quickbeam enters play, deal 1 damage to him to ready him.")
                .WithFlavor("\"I am Bregalad, that is Quickbeam in your language. But it is only a nickname, of course.\" -The Two Towers")
                .WithInfo(6, 3, Artist.Mike_Nash));
            Cards.Add(Card.Ally("Háma", "7EFDF1B5-E3B9-4563-8E12-A2E0C60845F7", Sphere.Spirit, 3, 1, 2, 2, 2)
                .WithNormalizedTitle("Hama")
                .WithUnique()
                .WithTraits("Rohan.", "Warrior.")
                .WithText("Combat Action: Ready Háma. He gets +3 Defense until the end of the phase. At the end of the phase, discard Háma. (Limit once per round.)")
                .WithFlavor("\"I am the Doorward of Théoden,\" he said. \"Háma is my name.\" -The Two Towers")
                .WithInfo(7, 3, Artist.Sara_Betsy));
            Cards.Add(Card.Attachment("Arod", "4CED4D30-CEDD-4FB4-8291-7C93980A2F74", Sphere.Tactics, 1)
                .WithUnique()
                .WithTraits("Mount.")
                .WithText("Attach to a hero or Legolas.\r\nResponse: After attached character participates in an attack that destroys an enemy, exhaust Arod to place 1 progress token on any location.")
                .WithFlavor("\"A smaller and lighter horse, but restive and fiery, was brought to Legolas. Arod was his name.\" -The Two Towers")
                .WithInfo(8, 3, Artist.Smirtouille));
            Cards.Add(Card.Attachment("Ent Draught", "1FE6699C-7753-4A5B-9A1D-EDF59F1D23F0", Sphere.Lore, 1)
                .WithTraits("Item.", "Ent.")
                .WithText("Play only if you control at least 1 Ent character.\r\nAttach to a character. Limit 1 per character.\r\nAttached character gets +2 hit points.")
                .WithFlavor("The effect of the draught began at the toes, and rose steadily through every limb, bringing refreshment and vigour as it coursed upwards, right to the tips of the hair. -The Two Towers")
                .WithInfo(9, 3, Artist.Aurelien_Hubert));
            Cards.Add(Card.Attachment("Herugrim", "0E512381-7B67-45D3-BAE5-6CF0DDA4176B", Sphere.Spirit, 3)
                .WithUnique()
                .WithTraits("Item.", "Weapon.")
                .WithText("Attach to a Rohan hero. Restricted.\r\nReduce the cost to play Herugrim on Théoden by 1.\r\nResponse: Aftr attached hero is declared as an attacker, exhaust Herugrim to add attached hero's Willpower to its Attack for this attack.")
                .WithFlavor("\"Here, lord, is Herugrim, your ancient blade.\" -Háma, The Two Towers")
                .WithInfo(10, 3, Artist.Jason_Ward));
            Cards.Add(Card.Event("Entmoot", "7A734E97-BADA-48B5-BF62-561C578B6791", Sphere.Lore, 0)
                .WithTraits("Ent.")
                .WithText("Play only if you control at least 1 Ent character.\r\nAction: Search the top 5 cards of your deck for any number of Ent cards and add them to your hand. Shuffle the other cards back into your deck.")
                .WithFlavor("\"...it is a gathering of Ents - which does not often happen nowadays.\" -Treebeard, The Two Towers")
                .WithInfo(11, 3, Artist.Anthony_Devine));
            Cards.Add(Card.Event("Helm! Helm!", "4CDEC2D8-3B35-4BD1-BAF5-F18E7641B308", Sphere.Spirit, 2)
                .WithText("Play only after the resolving enemy attacks step is complete.\r\nCombat Action: Exhaust and discard a Rohan ally you control to choose and discard a non-unique enemy engaged with you.")
                .WithFlavor("\"Helm is arisen and comes back to war. Helm for Théoden King!\" -Riders of Rohan, The Two Towers")
                .WithInfo(12, 3, Artist.Smirtouille));
            Cards.Add(Card.Event("The Three Hunters", "207FB055-CAF4-4AA0-804D-7009922CA67B", Sphere.Fellowship, 3)
                .WithText("Play only if you control Fellowship Aragorn.\r\nQuest Action: Choose 3 heroes committed to the quest. Until the end of the round, each of the chosen heroes gets +1 Willpower, +1 Attack and +1 Defense.")
                .WithFlavor("\"We shall makes such a chase as shall be accounted a marvel among the Three Kindreds: Elves, Dwarves, and Men. Forth the Three Hunters!\" -Aragorn, The Two Towers")
                .WithInfo(13, 3, Artist.Nicholas_Gregory));
            Cards.Add(Card.Attachment("Shadowfax", "2DA7519D-4C7F-44A5-9E6E-413A28B5B4FD", Sphere.Neutral, 3)
                .WithUnique()
                .WithTraits("Mount.", "Mearas.")
                .WithText("Attach to Gandalf.\r\nGandalf gains ranged and sentinel.\r\nAction: Exhaust Shadowfax to ready Gandalf.")
                .WithFlavor("\"He is the chief of the Mearas, lords of horses, and not even Théoden, King of Rohan, has ever looked on a better.\" -Gandalf, The Two Towers")
                .WithInfo(14, 3, Artist.Smirtouille));
        }
    }
}