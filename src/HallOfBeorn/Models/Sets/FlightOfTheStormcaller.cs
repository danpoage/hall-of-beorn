using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class FlightOfTheStormcaller : CardSet
    {
        protected override void Initialize()
        {
            Name = "Flight of the Stormcaller";
            Abbreviation = "FotS";
            Number = 36;
            SetType = Models.SetType.Adventure_Pack;

            Cards.Add(Card.Hero("Denethor", "", Sphere.Leadership, 8, 1, 1, 3, 3)
                .WithTraits("Gondor.", "Noble.", "Steward.")
                .WithText("Setup: Add 2 resources to Denethor's resource pool.\r\nAction: Move 1 resource from Denethor's resource pool to another Gondor hero's resource pool. (Limit once per round.)")
                .WithFlavor("\"...why should I sit here in my tower and think, and watch, and wait, spending even my sons? For I can still wield a brand.\"\r\n-The Return of the King")
                .WithInfo(1, 1, Artist.Joshua_Cairos));
            Cards.Add(Card.Attachment("Rod of the Steward", "", Sphere.Leadership, 0)
                .WithUnique()
                .WithTraits("Item.")
                .WithText("Attach to a Gondor hero.\r\nAction: Spend 2 resources from attached hero's resource pool to draw 1 card.")
                .WithFlavor("\"The last Steward of Gondor begs leave to surrender his office.\" And he held out a white rod.\r\n-The Return of the King")
                .WithInfo(2, 3, Artist.Unknown));
            Cards.Add(Card.Attachment("In Service of the Steward", "", Sphere.Leadership, 1)
                .WithGeneric()
                .WithTraits("Title.")
                .WithText("Attach to a character.\r\nAttached character gains the Gondor trait.")
                .WithFlavor("But be it know that I have sworn him to my service...\r\n-The Return of the King")
                .WithInfo(3, 3, Artist.Jason_Cheeseman_Meyer));
            Cards.Add(Card.Ally("Azain Silverbeard", "", Sphere.Tactics, 3, 0, 3, 2, 2)
                .WithTraits("Dwarf.", "Warrior.")
                .WithText("Response: After Azain Silverbeard participates in an attack that destroys and enemy, spend 1 Tactics resource to deal 2 damage to another enemy that shares a Trait with the destroyed enemy. Any player may trigger this response.")
                .WithInfo(4, 3, Artist.Unknown));
            Cards.Add(Card.Event("Last Stand", "", Sphere.Tactics, 0)
                .WithText("Response: After a Warrior character is destroyed while defending against an enemy attack, deal damage to the attacking enemy equal to that character's printed Attack.")
                .WithFlavor("In a grave along under the shadow of the Hornburg lay Háma, captain of the King's guard. He fell before the Gate.\r\n-The Two Towers")
                .WithInfo(5, 3, Artist.Arden_Beckwith));
            Cards.Add(Card.Ally("Glorfindel", "", Sphere.Spirit, 5, 3, 3, 1, 4)
                .WithTraits("Noldor.", "Noble.", "Warrior.")
                .WithText("Glorfindel can be played from your discard pile.\r\nAction: Discard a card to ready Glorfindel. (Limit once per phase.)")
                .WithFlavor("\"Glorfindel is an Elf-lord of a house of princes.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(6, 3, Artist.Aleksander_Karcz));
            Cards.Add(Card.Event("Tides of Fate", "", Sphere.Spirit, 0)
                .WithText("Response: When a shadow card increases an enemy's Attack by any amount, increase the defending character's Defense by 3 for that attack. Then, the players as a group may spend 2 Tactics resources to ready the defending character and give it +3 Attack for its next attack this phase.")
                .WithFlavor("...the tides of fate had turned against them and their doom was at hand.\r\n-The Return of the King")
                .WithInfo(7, 3, Artist.Sam_Lamont));
            Cards.Add(Card.Ally("Imladris Caregiver", "", Sphere.Lore, 2, 1, 0, 1, 2)
                .WithGeneric()
                .WithTraits("Noldor.", "Healer.")
                .WithText("Action: Discard a card from your hand to heal 1 damage on any characer. (Limit twice per round).")
                .WithFlavor("\"You are in Rivendell, and you need not worry about anything for the present.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(8, 3, Artist.Aleksander_Karcz));
            Cards.Add(Card.Event("Heed the Dream", "", Sphere.Lore, 1)
                .WithText("Action: Choose a player. That player searches the top 5 cards of his deck for a card, adds it to his hand, and shuffles his deck. Then, players as a group may spend 3 Leadership resources to have that player search his deck for another card, add it to his hand, and shuffle his deck.")
                .WithInfo(9, 3, Artist.Joshua_Cairos));
            Cards.Add(Card.Ally("Guardian of Rivendell", "", Sphere.Neutral, 3, 1, 2, 3, 3)
                .WithGeneric()
                .WithTraits("Noldor.", "Warrior.")
                .WithText("As an additional cost to play ~Guardian of Rivendell from your hand, you must discard 2 cards from your hand.")
                .WithFlavor("\"Indeed there is a power in Rivendell to withstand the might of Mordor, for a while.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(10, 3, Artist.Tawny_Fritzinger));
            Cards.Add(Card.Event("Vanish from Sight", "", Sphere.Neutral, 0)
                .WithText("Play only if you control 2 or fewer heroes.\r\nAction: Until the end of the phase, if your threat is higher than 20, treat your threat as if it is 20.")
                .WithFlavor("\"I see now little hope, if we do not soon vanish from sight for a while, and cover our trail.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(11, 3, Artist.Nikolas_Hagialas));
        }
    }
}