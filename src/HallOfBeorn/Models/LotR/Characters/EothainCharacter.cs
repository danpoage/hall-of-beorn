using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class EothainCharacter : Character
    {
        public EothainCharacter()
            : base("Éothain", "Éothain", "Man")
        {
            Bio =
@"<p>Éothain was a rider of Rohan.</p>
<h4>History</h4>
<p>Éothain was a member of Éomer's éored that overran the orcs who had captured Merry and Pippin at the fringe of Fangorn Forest, and encountered Aragorn, Legolas and Gimli on 30 February, T.A. 3019. Éothain scoffed at the idea that Hobbits even existed, believing them to be nothing but a child's tale, and argued against the gift of horses to the three companions.</p>
<h4>Other versions of the legendarium</h4>
<p>In one of the last drafts of The Riders of Rohan, Éothain was Éomer's squire, whereas in a later draft of The Ride of the Rohirrim, he was the captain of Éomer's household éored.[3] No reference to Éothain's rank in Éomer's éored is made in The Lord of the Rings.</p>
<h4>Etymology</h4>
<p>Éothain contains the Old English elements Éoh ('warhorse') and thegn ('warrior, chieftain'). It was a rendition of a Rohirric name that was never recorded, though the first element is likely translated from lô/loh, 'war-horse'.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Eothain";
            ImageArtist = Artist.Angus_McBride;

            addFriend("Éomer", "Eomer");

            addGroup("The Rohirrim", "The-Rohirrim");

            Card("Eothain-TDR");
        }
    }
}