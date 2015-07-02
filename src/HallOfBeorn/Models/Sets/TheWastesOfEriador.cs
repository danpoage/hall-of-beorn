using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheWastesOfEriador : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Wastes of Eriador";
            Abbreviation = "TWoE";
            Number = 30;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Angmar Awakened";

            Cards.Add(Card.Hero("Merry", "E4DD7F3E-0CD2-4330-A7D4-80487202C437", Sphere.Spirit, 6, 2, 1, 1, 2)
                .WithTraits("Hobbit.")
                .WithText("Response: After an enemy is revealed from the top of the encounter deck, exhaust Merry to reduce your threat by that enemy's Threat.")
                .WithFlavor("\"We have come a long way with you and been through some stiff times. We want to go on.\" —The Fellowship of the Ring")
                .WithTemplate("<b>Response:</b> After an enemy is revealed from the top of the encounter deck, exhaust {self} to reduce your threat by that enemy's {Threat}.</p><p style='text-align:center'><i>&quot;We have come a long way with you and been through some stiff times. We want to go on.&quot;<br/>&ndash;The Fellowship of the Ring</i></p>")
                .WithInfo(1, 1, Artist.Romana_Kendelic));
            Cards.Add(Card.Ally("Ingold", "", Sphere.Leadership, 3, 0, 1, 1, 3)
                .WithTraits("Gondor.")
                .WithText("Ingold gets +1 Willpower for each hero you control with at least 1 resource in its resource pool.")
                .WithFlavor("\"We wish for no strangers in the land at this time, unless they be mighty men of arms in whose faith and help we can trust.\" —The Return of the King") 
                .WithInfo(2, 3, Artist.Tiziano_Baracchi));
            Cards.Add(Card.Event("Rallying Cry", "", Sphere.Leadership, 2)
                .WithText("Response: After an ally leaves play, add it to its owner’s hand instead of placing it in the discard pile.\r\nValour Action: Until the end of the phase, add each ally that leaves play to its owner's hand instead of placing it in the discard pile.")
                .WithTemplate("<p><b>Response:</b> After an ally leaves play, add it to its owner's hand instead of placing it in the discard pile.</p><p><b>Valour Action:</b> Until the end of the phase, add each ally that leaves play to its owner's hand instead of placing it in the discard pile.</p><p style='text-align:center'><i>He let blow the horns to rally all men to his banner that could come thither...<br/>&ndash;The Return of the King</i></p>")
                .WithInfo(3, 3, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Ally("Honour Guard", "", Sphere.Tactics, 2, 0, 0, 1, 3)
                .WithGeneric()
                .WithTraits("Gondor.", "Warrior.")
                .WithText("Response: Exhaust Honour Guard to cancel the first point of damage just dealt to a character.\r\nValour Response: Exhaust and discard Honour Guard to cancel up to 5 damage just dealt to a character.")
                .WithInfo(4, 3, Artist.Owen_William_Weber));
            Cards.Add(Card.Attachment("Raven-winged Helm", "", Sphere.Tactics, 2)
                .WithTraits("Item.", "Armor.")
                .WithText("Attach to a hero with sentinel. Limit 1 per hero.\r\nResponse: Exhaust Raven-winged Helm to prevent 1 point of damage just dealt to attached character.")
                .WithFlavor("He had a small hauberk, its rings of forged of steel, maybe, yet black as jet; and a high-crowned helm with small raven-wings on either side, set with a silver star in the centre of the circlet. -The Return of the King")
                .WithTemplate("<p>Attach a {keyword-hero:Sentinel.} Limit 1 per hero.</p><p><b>Response:</b> Exhaust {self} to prevent 1 point of damage just dealt to attached character.</p><p style='text-align:center'><i>He had a small hauberk, its rings of forged of steel, maybe, yet black as jet; and a high-crowned helm with small raven-wings on either side, set with a silver star in the centre of the circlet.<br/>&ndash;The Return of the King</i><p>")
                .WithInfo(5, 3, Artist.Blake_Henriksen));
            Cards.Add(Card.Ally("Curious Brandybuck", "", Sphere.Spirit, 2, 2, 0, 0, 2)
                .WithGeneric()
                .WithTraits("Hobbit.")
                .WithText("Forced: After the active location is explored, place Curious Brandybuck on the bottom of its owner's deck.\r\nResponse: After you travel to a location, put Curious Brandybuck into play from your hand, under any player's control.") 
                .WithInfo(6, 3, Artist.Matthew_Starbuck));
            Cards.Add(Card.Attachment("Hobbit Pony", "", Sphere.Spirit, 0)
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Hobbit hero.\r\nQuest Action: If attached hero is not committed to the quest, exhaust Hobbit Pony and attached hero to commit attached hero to the quest.")
                .WithFlavor("He was riding a pony, and a scarf was swathed round his neck and over his chin to keep out the fog. —The Fellowship of the Ring") 
                .WithInfo(7, 3, Artist.Unknown));
            Cards.Add(Card.Ally("East Road Ranger", "", Sphere.Lore, 3, 1, 2, 1, 3)
                .WithGeneric()
                .WithTraits("Dúnedain", "Scout.")
                .WithText("East Road Ranger gets +2 Willpower while committed to a side quest.")
                .WithFlavor("\"If you bring a Ranger with you, it is well to pay attention to him...\" -Gandalf, the Fellowship of the Ring")
                .WithTemplate("<p>{self} gets +2 {willpower} while committed to a side quest.</p><p style='text-align:center'><i>&quot;If you bring a Ranger with you, it is well to pay attention to him...&quot;<br/>&ndash;Gandalf, the Fellowship of the Ring</i></p>")
                .WithInfo(8, 3, Artist.Beth_Sobel));
            Cards.Add(Card.PlayerSideQuest("Scout Ahead", "", Sphere.Lore, 0, 4)
                .WithText("Limit 1 per deck.\r\nResponse: When this stage is defeated, the first player searches the top X cards of the encounter deck for 1 non-objective card worth no victory points and adds it to the victory display. Put the remaining cards back in any order. X is the number of players in the game plus 4.")
                .WithFlavor("Strider made them take cover in a thicket at the side of the Road, while he went forward to explore. -The Fellowship of the Ring ")
                .WithInfo(9, 3, Artist.Tomasz_Jedruszek));
            Cards.Add(Card.Ally("Ranger of Cardolan", "", Sphere.Neutral, 4, 2, 2, 2, 3)
                .WithTraits("Dúnedain", "Ranger.")
                .WithText("Response: After you engage an enemy, if you control at least 1 Dúnedain hero, spend 1 resource to put Ranger of Cardolan into play from your hand, under your control. At the end of the round, if Ranger of Cardolan is still in play, shuffle it into its owner's deck.")
                .WithInfo(10, 3, Artist.Lukasz_Jaskolski));
        }
    }
}