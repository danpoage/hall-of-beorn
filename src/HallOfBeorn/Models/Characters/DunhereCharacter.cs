using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class DunhereCharacter : Character
    {
        public DunhereCharacter()
            : base("Dúnhere", "Dúnhere", "Man")
        {
            Bio =
@"<p>Dúnhere was the chieftain of the folk of Harrowdale, and a valiant captain who fought in the First Battle of the Fords of Isen and the Battle of the Pelennor Fields.</p>
<h4>History</h4>
<p>Dúnhere was a nephew of Erkenbrand.[1] He served under Grimbold during the First Battle of the Fords of Isen, where his skill as a horseman proved important to the Rohirrim's weakened defenses.</p>
<p>Dúnhere did not accompany Gandalf and Erkenbrand to the Battle of the Hornburg; instead, they sent him to oversee the muster of the Rohirrim in his native Harrowdale. Several days later, Théoden and the rest of the riders gathered there to set out to Minas Tirith.</p>
<p>At the Battle of the Pelennor Fields, Dúnhere was slain. He was remembered in the Song of the Mounds of Mundburg.</p>
<h4>Etymology</h4>
<p>The name Dúnhere means 'hill warrior' in Old English, consisting of dūn ('hill') + here ('army, host').</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Dunhere";
            ImageArtist = Artist.Jeff_Himmelman;

            TheReturnOfTheKing();
            UnfinishedTales();

            Alias("Lord of Harrowdale");
            Alias("Chieftain of the folk of Harrowdale");

            addFamily("Erkenbrand (Uncle)", "Erkenbrand");

            addFriend("Théodred", "Theodred");
            addFriend("Grimbold", "Grimbold");

            addGroup("The Rohirrim", "The-Rohirrim");
        }
    }
}