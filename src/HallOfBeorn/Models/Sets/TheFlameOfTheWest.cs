using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheFlameOfTheWest : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Flame of the West";
            Abbreviation = "TFotW";
            Number = 1007;
            SetType = Models.SetType.Saga_Expansion;
            Cycle = "The Lord of the Rings";

            Cards.Add(Card.Hero("Aragorn", "", Sphere.Fellowship, 0, 2, 3, 2, 5)
                .WithTraits("Dúnedain.", "Noble.", "Ranger.")
                .WithText("The first player gains control of Aragorn. If Aragorn leaves play, the players lose the game.\r\nWhile Aragorn has an Artifact attached, he gains sentinel and does not exhaust to quest.")
                .WithFlavor("\"I have no help to send, therefore I must go myself...\"\r\n-The Return of the King")
                .WithInfo(1, 1, Artist.Javier_Charro_Martinez));
            Cards.Add(Card.Hero("Éowyn", "", Sphere.Tactics, 9, 4, 1, 1, 3)
                .WithTraits("Rohan.", "Noble.")
                .WithText("Setup: Reduce your threat by 3.\r\nAction: Raise your threat by 3 to ready Éowyn. She gets +9 Attack until the end of the phase. (Limit once per game for the group.)")
                .WithFlavor("\"But no living man am I! You look upon a woman. Éowyn I am, Éomund's daughter.\"\r\n-The Return of the King")
                .WithInfo(2, 1, Artist.Magali_Villeneuve));
            Cards.Add(Card.Hero("Beregond", "", Sphere.Spirit, 10, 0, 1, 4, 4)
                .WithTraits("Gondor.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After Beregond defends an attack and takes no damage, reduce the defending player's threat by 1. (Limit once per round.)")
                .WithFlavor("\"The Lord does not permit those who wear the black and silver to leave their post for any cause...\"\r\n-The Return of the King")
                .WithInfo(3, 1, Artist.Adam_Lane));

            Cards.Add(Card.Ally("Prince Imrahil", "", Sphere.Spirit, 4, 2, 2, 2, 3)
                .WithUnique()
                .WithTraits("Gondor.", "Noble.")
                .WithText("While there is a hero in your discard pile, Prince Imrahil loses the ally card type and gains the hero card type.")
                .WithFlavor("\"We must gather all of the strength that we can find.\r\n-The Return of the King")
                .WithInfo(6, 3, Artist.Gabriel_Verdon));

            Cards.Add(Card.Event("Sterner than Steel", "", Sphere.Tactics, 0)
                .WithText("Response: Exhaust a Weapon or Armor card attached to the defending character to cancel a shadow effect just triggered in combat")
                .WithFlavor("\"Do what you will; but I will hinder it, if I may.\"\r\n-Éowyn, The Return of the King")
                .WithInfo(8, 3, Artist.Chris_Rahn));
            Cards.Add(Card.Event("Desperate Defense", "", Sphere.Spirit, 1)
                .WithText("Response: After a sentinel character is declared as a defender, it gets +2 Defense for this attack. If this attack deals no damage, ready the defending character.")
                .WithFlavor("...but alone in the porch upon the topmost step stood Beregond, clad in the black and silver of the Guard; and he held the door against them.\r\n-The Return of the King")
                .WithInfo(9, 3, Artist.Adam_Lane));
            Cards.Add(Card.Attachment("Golden Shield", "", Sphere.Tactics, 1)
                .WithUnique()
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Rohan hero. Response: After attached hero is declared as a defender, exhaust Golden Shield to add attached hero's Willpower to it's Defense for this attack.")
                .WithFlavor("His golden shield was uncovered, and lo! it shone like an image of the Sun...\r\n-The Return of the King")
                .WithInfo(10, 3, Artist.Unknown));
            Cards.Add(Card.Attachment("Livery of the Tower", "", Sphere.Spirit, 0)
                .WithGeneric()
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Gondor hero.\r\nResponse: Spend X resources from attached hero's pool to cancel X damage just dealt to attached hero.")
                .WithFlavor("This was the livery of the heirs of Elendil, and none wore it now in all Gondor, save the Guards of the Citadel...\r\n-The Return of the King")
                .WithInfo(11, 3, Artist.Suzanne_Helmigh));
        }
    }
}