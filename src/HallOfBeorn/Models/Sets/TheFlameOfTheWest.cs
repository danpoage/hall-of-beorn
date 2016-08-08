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
            Cards.Add(Card.Ally("Grimbold", "", Sphere.Tactics, 3, 2, 1, 1, 2)
                .WithUnique()
                .WithTraits("Rohan.", "Warrior.")
                .WithText("Combat Action: Discard Grimbold to choose an enemy engaged with a player. That enemy cannot attack that player this phase.")
                .WithFlavor("Grimbold's men turned aside and passed round to a great gap in the wall further eastward.\r\n-The Return of the King")
                .WithInfo(4, 3, Artist.Lucas_Durham));
            Cards.Add(Card.Ally("Prince Imrahil", "", Sphere.Spirit, 4, 2, 2, 2, 3)
                .WithUnique()
                .WithTraits("Gondor.", "Noble.")
                .WithText("While there is a hero in your discard pile, Prince Imrahil loses the ally card type and gains the hero card type.")
                .WithFlavor("\"We must gather all of the strength that we can find.\r\n-The Return of the King")
                .WithNote("Hi Benjamin,<br>Prince Imrahil’s text is a passive effect that is constantly checking the game state to see if there is a hero in your discard pile, so the instant that Caldara is placed in your discard pile he becomes a hero. As for Caldara, the cost to trigger her effect is to place her in the discard pile, and you cannot trigger an effect without paying the cost first. So, you must discard Caldara before you can resolve the rest of her effect. That means Imrahil is a hero at the time that you calculate how many allies you put into play, which means you can get up to 3 allies into play with Caldara’s effect (or even 4 if you make a unique spirit ally a hero with Sword-thain first).<br>Cheers,<br>Caleb", new DateTime(2016, 7, 25), 0m, "https://community.fantasyflightgames.com/topic/225784-prince-imrahil-the-flame-of-the-west-ally-and-caldara/")
                .WithInfo(5, 3, Artist.Gabriel_Verdon));
            Cards.Add(Card.Ally("Halbarad", "", Sphere.Leadership, 4, 2, 2, 2, 3)
                .WithUnique()
                .WithTraits("Dúnedain.", "Ranger.")
                .WithText("Reduce the cost to play Halbarad by 1 for each enemy engaged with you.\r\nEach enemy engaged with you gets +10 engagement cost.")
                .WithFlavor("\"Halbarad Dunadan, Ranger of the North I am...\"\r\n-The Return of the King")
                .WithInfo(6, 3, Artist.Adam_Lane));
            Cards.Add(Card.Ally("Ghân-buri-Ghân", "", Sphere.Lore, 2, 254, 1, 1, 2)
                .WithNormalizedTitle("Ghan-buri-Ghan")
                .WithUnique()
                .WithTraits("Wose.")
                .WithText("X is the Threat of the active location.\r\nTravel Action: Discard Ghân-buri-Ghân to travel to a location without resolving its Travel effect.")
                .WithInfo(7, 3, Artist.Piya_Wannachaiwong));
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
            Cards.Add(Card.Attachment("Roheryn", "", Sphere.Leadership, 2)
                .WithUnique()
                .WithTraits("Mount.")
                .WithText("Attach to a Dúnedain hero.\r\nIf the attached hero is Aragorn, he gains a Tactics icon.\r\nResponse: After you optionally engage an enemy, exhaust Roheryn and attached hero to declare attached hero as an attacker (and resolve its attack) against that eneny.")
                .WithFlavor("\"Aragorn's own horse that they had brought from the North; Roheryn was his name.\"\r\n-The Return of the King")
                .WithInfo(12, 3, Artist.Eva_Maria_Toker));
            Cards.Add(Card.Attachment("Banner of Elendil", "", Sphere.Fellowship, 3)
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithText("Attach to Aragorn.\r\nWhile Aragorn is questing, each other questing character you control gets +1 Willpower.\r\nWhile Aragorn is attacking, each other attacking character you control gets +1 Attack.")
                .WithFlavor("Seven stars were about it, and a high crown above it, the signs of Elendil that no lord had borne for years beyond count.\r\n-The Return of the King")
                .WithInfo(13, 3, Artist.Jenn_Tran));
            Cards.Add(Card.Attachment("Esquire of Rohan", "", Sphere.Neutral, 0)
                .WithUnique()
                .WithBoon()
                .WithTraits("Title.")
                .WithText("Setup: Attach to a hero.\r\nAttached hero gains the Rohan trait.\r\nAttached hero gets +1 Attack while attacking with another Rohan character.")
                .WithFlavor("\"Rise now, Meriadoc, esquire of Rohan of the household of Meduseld!\"\r\n-Théoden, The Return of the King")
                .WithInfo(14, 1, Artist.Romana_Kendelic));
            Cards.Add(Card.Attachment("Esquire of Gondor", "", Sphere.Neutral, 0)
                .WithUnique()
                .WithBoon()
                .WithTraits("Title.")
                .WithText("Setup: Attach to a hero.\r\nAttached hero gains the Gondor trait.\r\nAttached hero gets +1 Willpower while commited to the quest with another Gondor character.")
                .WithFlavor("\"Here do I swear fealty and service to Gondor, and to the Lord and Steward of the realm...\"\r\n-Pippin, The Return of the King")
                .WithInfo(15, 1, Artist.Romana_Kendelic));
        }
    }
}