using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TrialUponTheMarches : CardSet
    {
        protected override void Initialize()
        {
            Name = "Trial Upon the Marches";
            Abbreviation = "TUtM";
            Number = 9002;
            SetType = Models.SetType.CUSTOM;
            Cycle = "Doom Mastered";

            Cards.Add(Card.Hero("Beleg Strongbow", "", Sphere.Lore, 10, 2, 3, 1, 5)
                .WithTraits("Teleri.", "Ranger.", "Scout.")
                .WithKeywords("Ranged.")
                .WithText("Action: Remove a progress token from a location in play or the current quest stage to lower the cost of the next card your play from your hand this round by 1. (Limit once per round.)")
                .WithFlavor("...for he dwelt ever on the marches of Doriath, and he was the greatest woodsman of those days.\r\n-The Children of Húrin")
                .WithInfo(218, 1, Artist.Elena_Kukanova));
            Cards.Add(Card.Ally("Outlaw Scout", "", Sphere.Mastery, 0, 0, 2, 1, 2)
                .WithGeneric()
                .WithTraits("Gaurwaith.", "Scout.")
                .WithKeywords("Ransom 2.")
                .WithText("Action: Discard Outlaw Scout to look at the top 2 cards of the encounter deck. You may discard 1 of them.")
                .WithInfo(219, 3, Artist.Maria_Nikolopoulou));
            Cards.Add(Card.Ally("Knight of the Sword", "", Sphere.Tactics, 2, 0, 2, 1, 2)
                .WithGeneric()
                .WithTraits("Teleri.", "Warrior.")
                .WithText("Knight of the Sword gets +1 Attack when attacking an enemy with an engagement cost lower than your threat.")
                .WithInfo(220, 3, Artist.Ali_Kasapoglu));
            Cards.Add(Card.Ally("Doriath Messenger", "", Sphere.Lore, 1, 1, 0, 1, 1)
                .WithGeneric()
                .WithTraits("Teleri.")
                .WithText("Action: Spend 1 Lore resource to give control of Doriath Messenger to another player. That player draws 1 card. (Limit once per round.)")
                .WithInfo(221, 3, Artist.Blake_Henriksen));
            Cards.Add(Card.Ally("Household Guard", "", Sphere.Leadership, 3, 1, 2, 2, 2)
                .WithGeneric()
                .WithTraits("Edain.", "House of Hador.")
                .WithText("While a character with the Noble trait is defending, Household Guard gains: \"Response: Deal 1 damage to Household Guard to cancel a shadow effect just triggered. (Limit one per game.)\"")
                .WithInfo(222, 3, Artist.Jake_Bullock));
            Cards.Add(Card.Ally("Petty-dwarf Survivor", "", Sphere.Mastery, 0, 1, 0, 0, 1)
                .WithGeneric()
                .WithTraits("Dwarf.")
                .WithText("Raise the cost to play Petty-dwarf Survivor by 1 for each Noldor hero you control.")
                .WithFlavor("Nonetheless, as all the Dwarf-kind, they were far stronger than their stature promised, and they could cling to life in great hardship.\r\n-The Children of Húrin")
                .WithInfo(223, 3, Artist.Jerad_S_Marantz));
            Cards.Add(Card.Attachment("Elven Training", "", Sphere.Lore, 0)
                .WithTraits("Condition.")
                .WithText("Attach to a hero. Limit 1 per hero.\r\nAttached hero gets +1 Attack for each resource token on Elven Training.\r\nPlanning Action: Exhaust attached hero and discard a card from your hand to add 1 resource token to Elven Training. (Limit once per round.)")
                .WithInfo(224, 3, Artist.Elena_Kukanova));
            Cards.Add(Card.Attachment("Camp of the Faithful", "", Sphere.Spirit, 0)
                .WithUnique()
                .WithTraits("Refuge.")
                .WithText("Attach to a hero.\r\nAction: Exhaust attached hero to attach Camp of the Faithful to a non-unique location in play. While attached to a location, Camp of the Faithful gains: \"Treat attached location's printed text box as blank, except for traits.\"")
                .WithInfo(225, 3, Artist.Neerachar_Sophol));
            Cards.Add(Card.Attachment("Hardened", "", Sphere.Mastery, 0)
                .WithTraits("Condition.")
                .WithText("Attach to a hero with Corruption equal to his Willpower. Limit 1 per hero.\r\nCorruption cannot be removed from attached hero.\r\nResponse: After a treachery resolves, exhaust Hardened to draw one card.")
                .WithInfo(226, 3, Artist.Thomas_Rouillard));
            Cards.Add(Card.Event("A Dangerous Man", "", Sphere.Tactics, 1)
                .WithText("Action: Exhaust a hero you control to choose a non-unique enemy worth no victory points engaged with you. If the Attack of that enemy is lower than the Attack of the exhausted hero, add A Dangerous Man to the victory display to add that enemy to the victory display.")
                .WithFlavor("\"I am not a chicken-heart, as men know; but I am not your match\"\r\n-Androg, The Children of Húrin")
                .WithVictoryPoints(1)
                .WithInfo(227, 3, Artist.Catherine_Karina_Chmiel));
            
        }
    }
}