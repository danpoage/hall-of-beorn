using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class HamaCharacter : Character
    {
        public HamaCharacter()
            : base("Háma", "Háma", "Man")
        {
            Bio =
@"<p>Háma is a fictional character in J. R. R. Tolkien's legendarium. He is the doorward of King Théoden of Rohan and captain of the King's guard. He appears in the second volume, The Two Towers.</p>
<p>On March 2, 3019 T.A., Háma greeted Gandalf, Aragorn, Legolas and Gimli when they arrived at Meduseld. He told the travellers that they must leave their weapons outside the door before entering the King's hall. Aragorn was reluctant to part with his sword, but Háma said that it was the will of King Théoden and that Aragorn must put aside his sword or fight with all the Men of Edoras. At last, Aragorn agreed but commanded Háma to prevent anyone from touching Andúril. The others left their weapons, but Gandalf kept his staff. Háma allowed this, saying:</p>
<blockquote>
'The staff in the hand of a wizard may be more than a prop for age. Yet in doubt a man of worth will trust to his own wisdom. I believe you are friends and folk worthy of honour, who have no evil purpose.'
— The Two Towers, 'The King of the Golden Hall'
</blockquote>
<p>With the aid of his staff, Gandalf was able to free Théoden from the influence of his counsellor Gríma Wormtongue, who worked for Saruman. Háma was summoned to release Théoden's nephew Éomer from imprisonment and bring him before the King. Éomer asked Háma to bring him his sword, Gúthwinë, and Háma did as he was asked, for he was overjoyed that the young Marshal of the Mark was freed. Théoden was surprised to see Éomer armed and Háma confessed that it was his doing, but at length Théoden accepted Éomer's sword and his pledge of loyalty.</p>
<p>Háma was then sent to retrieve Théoden's own sword, Herugrim, from Gríma and to bring the traitorous counsellor before the King. Gríma was reluctant to give Háma the keys to the chest where Herugrim was stored, and when Háma opened it he found many other stolen items besides the sword. Two guards escorted Gríma to Théoden and Háma knelt and presented the King with Herugrim.</p>
<p>Háma accompanied King Théoden into battle at the fortress of the Hornburg at Helm's Deep. During the Battle of the Hornburg on the night of March 3–4, Háma was killed while defending the Gate. The attackers hewed Háma's body after he was dead. Háma was buried in a solitary grave in the shadow of the Hornburg. Théoden himself cast the first earth upon Háma's grave.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/H%C3%A1ma_(Middle-earth)";
            ImageArtist = Artist.Magali_Villeneuve;

            Alias("Captain of the King's Guard");
            Alias("Doorwarden of Meduseld");

            addFriend("Théoden", "Theoden");
            addFriend("Éomer", "Eomer");

            addGroup("The Rohirrim", "The-Rohirrim");

            Card("Hama-TLD");
            Card("Hama-ToS");
        }
    }
}