using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class ErkenbrandCharacter : Character
    {
        public ErkenbrandCharacter()
            : base("Erkenbrand", "Erkenbrand", "Man")
        {
            Bio =
@"<p>Erkenbrand is a fictional character in J. R. R. Tolkien's legendarium. He appears in The Two Towers, the second volume of Tolkien's fantasy novel The Lord of the Rings.</p>
<p>The name Erkenbrand comes presumably from two Old English words: eorcan (meaning 'precious') and brand (meaning 'sword').</p>
<p>Erkenbrand was lord of the Westfold of Rohan during the War of the Ring. He plays a critical role in the Battle of the Hornburg when he and Gandalf lead Riders of the Rohirrim in a counter-attack against Saruman's Uruk-hai who had besieged Théoden.</p>
<p>When Théoden rides to the Battle of the Pelennor Fields with Éomer, Grimbold, and Elfhelm, Erkenbrand remains in Rohan in charge of its defence, overseeing the Dunlending prisoners and the repairs to the Hornburg. After the war, Éomer makes Erkenbrand Marshal of the West-mark.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Erkenbrand";
            ImageArtist = Artist.Sebastian_Giacobino;

            TheTwoTowers();

            Alias("Lord of the Westfold");
            Alias("Marshal of thw West-mark");

            addFriend("Éomer", "Eomer");
            addFriend("Grimbold", "Grimbold");
            addFriend("Elfhelm", "Elfhelm");

            addGroup("The Rohirrim", "The-Rohirrim");

            Card("Erkenbrand-TAC");
        }
    }
}