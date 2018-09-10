using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class DeorwineCharacter : Character
    {
        public DeorwineCharacter()
            : base("Déorwine", "Déorwine", "Man")
        {
            Bio =
@"<p>Déorwine was the Chief of the King's Riders during the War of the Ring.
<h4>History</h4>
<p>An outstanding warrior, Déorwine and six of his knights were slain at the Battle of the Pelennor Fields.</p>
<h4>Etymology</h4>
<p>The name Déorwine probably means 'brave-friend' in Old English, consisting of dēor ('brave, bold (as a wild beast)' + wine ('friend').</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Deorwine";
            ImageArtist = Artist.Aleksander_Karcz;

            addFriend("Théoden", "Theoden");

            addGroup("The Rohirrim", "The-Rohirrim");

            LotRCard("Deorwine-TotD");
        }
    }
}