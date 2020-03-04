using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class TheodredCharacter : Character
    {
        public TheodredCharacter()
            : base("Théodred", "Théodred, son of Théoden", "Man")
        {
            Bio =
@"<p><b>Théodred</b> (T.A. 2978-3019) was the only son and heir of King Théoden of Rohan who died in battle at the Fords of Isen during the War of the Ring.</p>
<h4>History</h4>
<p>Théodred was born to King Théoden and Elfhild, who died in childbirth. Because of his state as prince of Rohan, Théodred also held the title of Second Marshal of the Riddermark.
While his father's health began to fail and Gríma gained more influence, Gríma considered Théodred and Éomer his chief opponents. He tried to bring the two cousins into discredit with Théoden, but their steadfast loyalty even in his apparent dotage. Gríma therefore tried to play them one against the other in the mind of Théoden, representing Éomer as ever eager to increase his authority.</p>
<p>In the beginning of 3019, due to the threat of invasion by the forces of the wizard Saruman, Théodred established himself at Helm's Deep to command the military strength of the Westfold. When actual war began Théodred added to the Muster of Westfold by summoning the Muster of Edoras.</p>
<p>Meanwhile Saruman planned to have the Prince killed. He sent forces against Rohan on February 25, T.A. 3019 with explicit orders to kill the Second Marshall at all costs.
Théodred was warned by his scouts of a mustering of troops at the Gate of Isengard and he reinforced the approaches. He passed over the Isen with the main strength of his cavalry to overthrow Saruman's apparent army before it was fully prepared. He scattered the vanguard, but then discovered the main host prepared for assault and ordered a retreat while the rearguard under Grimbold had to turn and drive back their pursuers.
Retreating, he appointed Grimbold in command of the western bank garrison while himself attempted to man the eyot in the midst of the river. Then a van came and with unexpected speed soon took control of the eastern end of the fords; the fiercest of Saruman's warriors and Orc-men abandoned the rest of the battle and directed their full might around the Prince. As Grimbold came to his defense, Théodred was hewn down by a great orc-man, whom Grimbold slew.</p>
<p>Elfhelm arrived to his support and they lifted the body. Théodred still breathed, only long enough to speak his last words.[2] The news of Théodred's death caused Erkenbrand of Westfold to assume command of the West-mark. With no siblings, this made his cousin, Éomer, heir to the throne of Rohan.</p>
<h4>Etymology</h4>
<p>Théodred's name is probably taken from the Anglo-Saxon words þēod ('folk', 'people', 'nation') and rǣd ('counsel').</p>";

            BioSourceUrl = "http://tolkiengateway.net/wiki/Theodred";
            ImageArtist = Artist.Jarreau_Wimberly;

            Alias("Second Marshal of the Riddermark");

            addFamily("Théoden (Father)", "Theoden");
            addFamily("Elfhild (Mother)");
            addFamily("Éomund (Uncle)", "Eomund");
            addFamily("Théodwyn (Aunt)");
            addFamily("Éomer (Cousin)", "Eomer");
            addFamily("Éowyn (Cousin)", "Eowyn");

            addGroup("The Rohirrim", "The-Rohirrim");
        }
    }
}