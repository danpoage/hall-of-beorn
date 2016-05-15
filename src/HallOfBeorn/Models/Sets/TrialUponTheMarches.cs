using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TrialUponTheMarches : CardSet
    {
        private const string setName = "Trial Upon the Marches";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TUtM";
            Number = 9002;
            SetType = Models.SetType.CUSTOM;
            Cycle = "Doom Mastered";

            Cards.Add(Card.Enemy("Colossal Orc", "", setName, 35, 1, 4, 2, 6)
                .WithTraits("Orc.")
                .WithKeywords("Raid.")
                .WithText("Colossal Orc gets +1 Threat for each damage token on him.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if the attacking enemy has at least 1 damage token.)")
                .WithInfo(192, 1, Artist.Anssiart));
            Cards.Add(Card.Enemy("Angband Assassin", "", setName, 20, 2, 3, 2, 3)
                .WithTraits("Orc.")
                .WithKeywords("Raid.")
                .WithText("Forced: After Angband Assassin engages you, discard an ally you control, if able.")
                .WithShadow("Shadow: If the defending character is an ally, discard if after the attack resolves.")
                .WithInfo(195, 1, Artist.Alex_Ruiz));
            Cards.Add(Card.Enemy("Azrat", "", setName, 38, 3, 6, 4, 9)
                .WithUnique()
                .WithTraits("Orc.", "Veteran.")
                .WithKeywords("Raid.", "Relentless.")
                .WithText("Forced: When Azrat is damaged by an attack, discard the top card of the attacking player's deck. Reduce the damage by the cost of the discarded card and deal that damage to one attacking character instead.")
                .WithInfo(196, 1, Artist.Aleksi_Briclot));

            Cards.Add(Card.Location("Burning Abode", "", setName, 3, 4)
                .WithTraits("Forest.", "Dwelling.")
                .WithText("Forced: At the end of the round, each player must discard the top card of his deck. If the discarded card is an ally, deal 1 Corruption to a hero controlled by that player.")
                .WithFlavor("...and the Orcs passwed on to the homesteads, and sacked and burned them.\r\n-The Children of Húrin")
                .WithInfo(201, 1, Artist.Unknown));
            Cards.Add(Card.Treachery("Crooked Blades", "", setName)
                .WithKeywords("Surge.")
                .WithText("When Revealed: Deal 1 damage to all characters with at least 1 damage.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. (+3 Attack instead if the defending character has at least 1 damage.)")
                .WithInfo(203, 1, Artist.Sean_O_Daniels));

            Cards.Add(Card.Treachery("An Ill Fate", "", setName)
                .WithText("When Revealed: Each player must discard an ally from his hand, if able, and discard X cards from the top of his deck. X is the cost of the discarded ally. If any player did not discard an ally, An Ill Fate gains surge.")
                .WithShadow("Shadow: If this attack destroys an ally, discard the top X cards of the defending player's deck. X is the cost of that ally.")
                .WithInfo(205, 1, Artist.Katerina_Konstantinoudi));

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

            Cards.Add(Card.Objective("Curse of Morgoth", "", setName)
                .WithBurden()
                .WithTraits("Curse.")
                .WithKeywords("Permanent.")
                .WithText("Setup: Attach to a hero.\r\nForced: After the attached hero takes Corruption, discard the top card of the encounter deck. If it is a treachery card, the attached hero becomes corrupted until the end of the round.\r\nIf the attached hero leaves play, the players have lost the game.")
                .WithInfo(229, 1, Artist.Alan_Lee));
        }
    }
}