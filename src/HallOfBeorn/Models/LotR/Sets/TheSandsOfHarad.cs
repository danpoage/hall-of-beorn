﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheSandsOfHarad : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Sands of Harad";
            Abbreviation = "TSoH";
            Number = 42;
            SetType = Models.SetType.Deluxe_Expansion;

            addCard(LotRCard.Hero("Gimli", string.Empty, Sphere.Leadership, 11, 2, 2, 2, 5)
                .WithTraits("Dwarf.", "Noble.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After Gimli is declared as a defender, spend 1 resource from his pool to ready another hero. If that hero is Legolas, he gets +1 Attack until the end of the phase. (Limit once per phase.)")
                .WithFlavor("\"Faithless is he that says farewell when the road darkens...\"\r\n-The Fellowship of the Ring")
                .WithInfo(1, 1, Artist.Owen_William_Weber));
            addCard(LotRCard.Hero("Legolas", string.Empty, Sphere.Spirit, 9, 1, 3, 1, 4)
                .WithTraits("Silvan.", "Noble.", "Scout.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Legolas commits to a quest, discard a card from your hand to ready another hero. If that hero is Gimli, he gets +1 Willpower until the end of the phase. (Limit once per phase.)")
                .WithFlavor("\"I go to find the Sun!\"\r\n-The Fellowship of the Ring")
                .WithInfo(2, 1, Artist.Aleksander_Karcz));
            addCard(LotRCard.Ally("Greenwood Archer", string.Empty, Sphere.Leadership, 2, 0, 2, 0, 1)
                .WithTraits("Silvan.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Greenwood Archer enters play, ready a hero.")
                .WithFlavor("They dwelt most often by the edges of the woods, from which they could escape at times to hunt...\r\n-The Hobbit")
                .WithInfo(3, 3, Artist.Unknown));
            addCard(LotRCard.Ally("Erebor Guard", string.Empty, Sphere.Spirit, 4, 0, 1, 2, 3)
                .WithTraits("Dwarf.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: When you play Erebor Guard from your hand, discard the top 2 cards of your deck to reduce its cost by 2.")
                .WithFlavor("...the fortress of the dwarves could not be taken by surprise.\r\n-The Hobbit")
                .WithInfo(4, 3, Artist.Unknown));
            addCard(LotRCard.Ally("Halfling Bounder", string.Empty, Sphere.Lore, 2, 1, 1, 0, 2)
                .WithTraits("Hobbit.")
                .WithText("While there is a side quest in the victory display, Halfling Bounder gains: \"Response: Discard Halfling Bounder to cancel the 'when revealed' effects of an encounter card that was just revealed from the encounter deck.\"")
                .WithFlavor("\"The Bounders have never been so busy before.\"\r\n-Sam Gamgee, The Fellowship of the Ring")
                .WithInfo(5, 3, Artist.Aleksander_Karcz));
            addCard(LotRCard.Ally("Vigilant Dúnadan", string.Empty, Sphere.Tactics, 4, 1, 3, 2, 3)
                .WithNormalizedTitle("Vigilant Dunadan")
                .WithGeneric()
                .WithTraits("Dúnedain.", "Ranger.")
                .WithText("While there is a side quest in the victory display, Vigilant Dúnadan does not exhaust to defend.")
                .WithFlavor("\"I don't think we've rightly understood till now what they did for us.\"\r\n-Barliman Butterbur, The Return of the King")
                .WithInfo(6, 3, Artist.JB_Casacop));
            addCard(LotRCard.Event("Unlikely Friendship", string.Empty, Sphere.Leadership, 0)
                .WithText("Play only if you control a unique character with the Silvan trait and another unique character with the Dwarf trait.\r\nAction: Draw 1 card and add 1 resource to the resource pool of a hero you control.")
                .WithFlavor("...folk that saw them pass marvelled to see such companions...\r\n-The Return of the King")
                .WithInfo(7, 3, Artist.Aleksander_Karcz));
            addCard(LotRCard.Event("Well Warned", string.Empty, Sphere.Spirit, 0)
                .WithText("Play only if you control a unique character with the Noble trait and another unique character with the Scout trait.\r\nResponse: After a player engages an enemy, reduce his threat by X, where X is that enemy's printed Threat.")
                .WithFlavor("...the Captains of the West were well warned by their scouts...\r\n-The Return of the King")
                .WithInfo(8, 3, Artist.Unknown));
            addCard(LotRCard.Event("Dour-handed", string.Empty, Sphere.Tactics, 1)
                .WithText("Action: Deal X damage to an enemy engaged with you. X is the number of side quests in the victory display.")
                .WithFlavor("...the tides of fate had turned against them and their doom was at hand. -The Return of the King")
                .WithInfo(9, 3, Artist.JB_Casacop));
            addCard(LotRCard.Attachment("Dwarven Shield", string.Empty, Sphere.Leadership, 2)
                .WithGeneric()
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Dwarf hero.\r\nAttached hero gets +1 Defense.\r\nResponse: After attached hero takes damage from an enemy attack, exhaust Dwarven Shield to add 1 resource to attached hero's pool.")
                .WithFlavor("...each of them had also a short broad sword at his side and a round shield slung at his back.\r\n-The Hobbit")
                .WithInfo(10, 3, Artist.Mariusz_Gandzel));
            addCard(LotRCard.Attachment("Mirkwood Long-knife", string.Empty, Sphere.Spirit, 2)
                .WithGeneric()
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Silvan hero.\r\nAttached hero gets +1 Willpower and +1 Attack.")
                .WithFlavor("Legolas had a bow and a quiver, and at his belt a long white knife.\r\n-The Fellowship of the Ring")
                .WithInfo(11, 3, Artist.Alexandr_Elichev));
            addCard(LotRCard.Attachment("The Road Goes Ever On", string.Empty, Sphere.Lore, 0)
                .WithTraits("Song.")
                .WithText("Attach to a quest card in play.\r\nResponse: When attached quest is defeated, the first player chooses a player. That player searches his deck for a side quest, adds it to his hand, and shuffles his deck.")
                .WithFlavor("\"Now far ahead the Road has gone,\r\nAnd I must follow, if I can...\"\r\n-Frodo Baggins, The Fellowship of the Ring")
                .WithInfo(12, 3, Artist.Unknown));
            addCard(LotRCard.PlayerSideQuest("The Storm Comes", string.Empty, Sphere.Neutral, 0, 5)
                .WithText("Limit 1 copy of The Storm Comes in the victory display.\r\nWhile this quest is in the victory display, the first ally played by each player each round does not require a resource match.")
                .WithFlavor("\"For behold! The storm comes, and now all friends should gather together, lest each singly be destroyed.\"\r\n-Gandalf, The Two Towers")
                .WithVictoryPoints(1)
                .WithInfo(13, 3, Artist.Tomasz_Jedruszek));
        }
    }
}