using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class SkinbarkCharacter : Character
    {
        public SkinbarkCharacter()
            : base("Skinbark", "Skinbark", "Ent")
        {
            Bio =
@"<p>Skinbark (also known as Fladrif) was, with Treebeard and Leaflock, one of the three oldest Ents of Fangorn Forest. He lived on the slopes above and to the west of Isengard, and so he and his people suffered the most at the hands of Saruman's despoiling Orcs. After many of his folk and tree-herds had been destroyed and he had been wounded, Skinbark moved high up the slopes to be with the birches he most loved and would not come down.</p>
<h4>Etymology</h4>
<p>Tolkien wrote that Skinbark is the Common Speech (or English) translation of Fladrif. It appears like Fladrif is intended to be Sindarin; the name is mentioned together with the Sindarin name Nindalf as acquiring the /v/ sound by the final -f. Didier Willis has suggested that Fladrif is composed of the otherwise unattested words *flâd ('skin') and *rîf ('bark').</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Skinbark";
            ImageArtist = Artist.John_Howe;

            addPlace("Fangorn Forest", "Fangorn-Forest");

            addFriend("Treebeard", "Treebeard");
            addFriend("Leaflock");

            addGroup("The Ents", "The-Ents");
        }
    }
}
