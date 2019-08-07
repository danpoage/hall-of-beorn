using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class BeechboneCharacter : Character
    {
        public BeechboneCharacter()
            : base("Beechbone", "Beechbone", "Ent")
        {
            Bio =
@"<p>Beechbone was an Ent.</p>
<h4>History</h4>
<p>Beechbone was a notably tall and handsome Ent. On 3 March T.A. 3019 he was caught in a burning spray sent up by Saruman from the beneath the Ring of Isengard, but his fiery end brought his fellow Ents to the peak of their destructive anger.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Beechbone";
            ImageArtist = Artist.John_Howe;

            addFriend("Treebeard", "Treebeard");

            addGroup("The Ents", "The-Ents");
            addPlace("Fangorn Forest", "Fangorn-Forest");

            LotRCard("Beechbone-TBoCD");
        }
    }
}