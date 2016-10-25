using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheCityOfCorsairs : CardSet
    {
        private const string setName = "The City of Corsairs";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TCoC";
            Number = 40;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dream-chaser";

            Cards.Add(Card.Hero("Prince Imrahil", "", Sphere.Tactics, 11, 2, 3, 2, 4)
                .WithTraits("Gondor.", "Noble.", "Warrior.")
                .WithText("Combat Action: Spend 1 resource from Prince Imrahil's resource pool to search the top 5 cards of your deck for an ally who shares at least 1 Trait with him, and put that ally into play. Shuffle your deck. At the end of the phase, if that ally is still in play, shuffle it into your deck. (Limit once per round.)")
                .WithInfo(138, 1, Artist.Unknown));
            Cards.Add(Card.Ally("Knight of the White Tower", string.Empty, Sphere.Leadership, 4, 2, 2, 3, 3)
                .WithGeneric()
                .WithTraits("Gondor.", "Warrior.")
                .WithText("Knight of the White Tower's resource cost must be paid from a single hero’s resource pool.")
                .WithFlavor("\"...to be only a man of arms of the Guard of the Tower of Gondor is held worthy in the City, and such men have honour in the land.\" -Beregond, The Return of the King")
                .WithInfo(139, 3, Artist.Owen_William_Weber));
            Cards.Add(Card.Event("Hold the Line", string.Empty, Sphere.Leadership, 0)
                .WithText("Response: When an enemy attacks a player, that player may declare up to 3 eligible characters as defenders against this attack. Then, the players as a group may spend 2 Tactics resources to ready each defending character that takes no damage from this attack.")
                .WithInfo(140, 3, Artist.Guillaume_Ducos));
            Cards.Add(Card.Ally("Soldier of Dol Amroth", string.Empty, Sphere.Tactics, 2, 0, 1, 1, 2)
                .WithGeneric()
                .WithTraits("Gondor.", "Warrior.")
                .WithText("Response: After Soldier of Dol Amroth enters play, reduce the cost of the next Tactics card you play this phase by 1.")
                .WithFlavor("...he and his knights still held themselves like lords in whom the race of Númenor ran true\r\n-The Return of the King")
                .WithInfo(141, 3, Artist.Mariusz_Gandzel));
            Cards.Add(Card.Ally("Súlien", string.Empty, Sphere.Spirit, 4, 3, 0, 2, 2)
                .WithNormalizedTitle("Sulien")
                .WithUnique()
                .WithTraits("Dúnedain.", "Scout.")
                .WithText("Action: Spend 1 Lore resource to exhaust Súlien. Then, each location in the staging area gets –1 [Threat] until the end of the phase. Any player may trigger this action.")
                .WithInfo(142, 3, Artist.Andreia_Ugrai));
            Cards.Add(Card.Event("Inspiring Presence", string.Empty, Sphere.Spirit, 2)
                .WithText("Action: Choose a hero you control. Each hero with lower threat cost than the chosen hero gets +2 Defense until the end of the phase. Then, the players as a group may spend 2 Leadership resources to give +2 Attack to each hero with lower threat cost than the chosen hero until the end of the phase.")
                .WithFlavor("Wherever he came men's hearts would lift again, and the winged shadows pass from memory.\r\n-The Return of the King")
                .WithInfo(143, 3, Artist.Dmitry_Prosvirnin));
            Cards.Add(Card.Ally("Guardian of Ithilien", string.Empty, Sphere.Lore, 1, 0, 1, 0, 1)
                .WithGeneric()
                .WithTraits("Gondor.", "Ranger.")
                .WithText("Response: After Guardian of Ithilien enters play, return an enemy engaged with you to the staging area.")
                .WithFlavor("From such men the Lord Denethor chose his forayers…to harry the Orcs and other enemies that roamed between the Ephel Dúath and the River.\r\n-The Two Towers")
                .WithInfo(144, 3, Artist.Taylor_Ingvarsson));
            Cards.Add(Card.Attachment("Ranger Spear", string.Empty, Sphere.Lore, 1)
                .WithGeneric()
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Ranger character.\r\nAttached character gets +1 [Attack] (+2 [Attack] instead when attacking an enemy with an attachment on it).")
                .WithFlavor("Two had spears in their hands with broad bright heads.\r\n-The Two Towers")
                .WithInfo(145, 3, Artist.Marius_Bota));
            Cards.Add(Card.Attachment("Prince of Dol Amroth", "", Sphere.Neutral, 3)
                .WithUnique()
                .WithTraits("Title.")
                .WithText("Attach to Prince Imrahil.\r\nPrice Imrahil gains the Outlands trait.\r\nWhile you control Outlands allies that belong to 4 different spheres, add 1 additional resource to Prince Imrahil's resource pool when you collect resources during the resource phase (if Prince Imrahil is a hero).")
                .WithInfo(146, 3, Artist.Drazenka_Kimpel));
        }
    }
}