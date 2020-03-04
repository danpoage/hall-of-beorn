using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class CeorlCharacter : Character
    {
        public CeorlCharacter()
            : base("Ceorl", "Ceorl", "Man")
        {
            Bio =
@"<blockquote>&ldquo;Come, stand before me, Ceorl!&rdquo;
<br>― Théoden
</blockquote>
<p>Ceorl was a rider of Rohan at the end of the Third Age.</p>
<h4>Life</h4>
<p>After the loss of the Second Battle of the Fords of Isen, Erkenbrand withdrew his Riders to Helm's Deep, and sent Ceorl south as a messenger to warn Éomer.[2] He was surprised to come across King Théoden's army riding north, ready to launch their own defence of the Fords. The news brought by Ceorl caused Théoden to reconsider his strategy, and he rode instead to join Erkenbrand at Helm's Deep, so setting the stage for the mighty Battle of the Hornburg.</p>
<h4>Etymology</h4>
<p>Like other Rohirrim, Ceorl's name comes from Old English. It refers to a particular rank in Anglo-Saxon society (also known as Carl and Churl), in fact the lowest rank possible while remaining a freeman. Historically, these people would not normally have been professional soldiers, so if Ceorl's background follows his name, we might guess that he was a farmer or tradesman who had been pressed into military service to help deal with the imminent threat to Rohan.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Ceorl";
            ImageArtist = Artist.Aleksander_Karcz;

            addFriend("Théoden", "Theoden");
            addFriend("Erkenbrand", "Erkenbrand");

            addGroup("The Rohirrim", "The-Rohirrim");
        }
    }
}
