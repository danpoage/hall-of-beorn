using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class ThengelCharacter
        : Character
    {
        public ThengelCharacter()
            : base("Thengel", "Thengel the Thrice-renowned", "Man")
        {
            Bio = 
@"<p><b>Thengel the Thrice-renowned</b> (Third Age 2905 – 2980, aged 75 years) was the sixteenth King of Rohan. Thengel was the only son of Fengel, and became king after the death of his father in T.A. 2953.</p>
<h4>History</h4>
<p>Fengel was a greedy and quarrelsome man, and Thengel left Rohan in his youth to live in Gondor, where he won great renown in the service of Turgon. Eventually he met and married Morwen Steelsheen of Lossarnach in 2943, and he lived with her there for a while. Morwen bore him five children in total, including his only son (his second child) Théoden in 2948 and a daughter Théodwyn in T.A. 2963, who would be the mother of Éomer and Éowyn.</p>
<p>After Fengel died in T.A. 2953, Thengel was called upon to return to Rohan, which he reluctantly did. During his reign Saruman took Isengard for himself and began to fortify it.[1] Around 2957 or later, a mysterious Northerner calling himself Thorongil entered his service, and rode with him for some time; later Thorongil heard the summons of Ecthelion II and went to Gondor.</p>
<p>Thengel had learned Sindarin while living in Gondor, and in his house it was the daily tongue, together with Westron, the common speech. Even after his return, he continued to use Westron,[4] and Rohirric was not spoken by him or his heirs.</p>
<h4>Etymology</h4>
<p>Þengel in Old English means 'lord' and derives from þeġen, þegn. This word is also related to Thain.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Thengel";
            ImageArtist = Artist.Warren_Mahy;

            addFamily("Fengel (Father)");
            addFamily("Morwen Steelsheen (Wife)", "Morwen-Steelsheen");
            addFamily("Théoden (Son)", "Theoden");
            addFamily("Théodwyn (Daughter)", "Theodwyn");

            addGroup("Rohan", "Rohan");

            Alias("Thrice-renowned");

            LotRCard("Thengel-CoE");
        }
    }
}