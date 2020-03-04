using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class GrimboldCharacter : Character
    {
        public GrimboldCharacter()
            : base("Grimbold", "Grimbold", "Man")
        {
            Bio =
@"<p>Grimbold was a rider of Rohan, who dwelt in Grimslade. He fought in the Battles of the Fords of Isen, and fell in the Battle of the Pelennor Fields.</p>
<h4>History</h4>
<p>Grimbold was a valiant captain under the Second Marshal. He was instrumental in the defense of the Fords of Isen; after his Marshal Théodred fell, he managed to hold the eyot in the river until Elfhelm arrived. Soon after, the troops of Isengard left; their mission was over with the death of the Marshal.</p>
<p>Grimbold and his company were scattered after the Second Battle of the Fords of Isen, though most of his troops survived. When Gandalf arrived, he sent Elfhelm to protect Edoras and Grimbold to join Erkenbrand, who was making his way to the Hornburg in an attempt to lift the siege.</p>
<p>After the victory at Helm's Deep and the lighting of the warning beacons of Gondor, Théoden had to quickly reorganize his troops. The elderly Erkenbrand commanded the defense of Rohan, while Grimbold was elected to take over command of the muster of the Westfold based on the valour he had shown at earlier battles.[1] At the battle, Grimbold fought on the eastern side of the Pelennor Fields, where he was slain. He was remembered in the Song of the Mounds of Mundburg as 'doughty'.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Grimbold";
            ImageArtist = Artist.Lucas_Durham;

            addFriend("Théodred", "Theodred");
            addFriend("Théoden", "Theoden");

            addGroup("The Rohirrim", "The-Rohirrim");
        }
    }
}
