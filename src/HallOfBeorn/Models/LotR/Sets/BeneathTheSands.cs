using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class BeneathTheSands : CardSet
    {
        protected override void Initialize()
        {
            Name = "Beneath the Sands";
            Abbreviation = "BtS";
            Number = 45;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            Cards.Add(LotRCard.Ally("Dúnedain Lookout", Sphere.Lore, 2, 1, 1, 1, 2)
                .WithTraits("Dúnedain.")
                .WithText("Response: Discard Dúnedain Lookout to cancel the 'When Revealed' effects of an enemy just revealed from the encounter deck.")
                .WithFlavor("\"Travellers scowl at us, and countrymen gives us scornful names.\"\r\n-Aragorn, The Fellowship of the Ring")
                .WithInfo(52, 3, Artist.Unknown));
            Cards.Add(LotRCard.PlayerSideQuest("Keep Watch", string.Empty, Sphere.Tactics, 1, 6)
                .WithText("Limit 1 copy of Keep Watch in the victory display.\r\nWhile Keep Watch is in the victory display, each non-unique enemy engaged with a player gets -1 Attack.")
                .WithFlavor("\"I called for the help of the Dúnedain, and their watch was doubled...\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithVictoryPoints(1)
                .WithInfo(59, 3, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Event("The Free Peoples", string.Empty, Sphere.Neutral, 5)
                .WithText("Play only if the characters you control have a total of at least 9 different Traits between them.\r\nAction: Ready each character in play. Until the end of the phase, each character you control gets +1 Willpower.")
                .WithFlavor("\"For the rest, they shall represent the other Free Peoples of the World: Elves, Dwarves and Men.\"\r\n-Elrond, The Fellowship of the Ring")
                .WithInfo(61, 3, Artist.Uriah_Voth));
        }
    }
}