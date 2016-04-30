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

            Cards.Add(Card.Ally("Imladris Caregiver", "", Sphere.Lore, 2, 1, 0, 1, 2)
                .WithGeneric()
                .WithTraits("Noldor.", "Healer.")
                .WithText("Action: Discard a card from your hand to heal 1 damage on any characer. (Limit twice per round).")
                .WithFlavor("\"You are in Rivendell, and you need not worry about anything for the present.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(8, 3, Artist.Aleksander_Karcz));

            Cards.Add(Card.Ally("Guardian of Rivendell", "", Sphere.Neutral, 3, 1, 2, 3, 3)
                .WithGeneric()
                .WithTraits("Noldor.", "Warrior.")
                .WithText("As an additional cost to play ~Guardian of Rivendell from your hand, you must discard 2 cards from your hand.")
                .WithFlavor("\"Indeed there is a power in Rivendell to withstand the might of Mordor, for a while.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(10, 3, Artist.Tawny_Fritzinger));

        }
    }
}