using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class BillThePonyCharacter : Character
    {
        public BillThePonyCharacter()
            : base("Bill the Pony", "Bill the Pony", "Pony")
        {
            Bio =
@"<p>'Bill' was Samwise Gamgee's pony, named for its original owner Bill Ferny.</p>
<h4>History</h4>
<p>Bill (who probably had not even a name then) was owned by Bill Ferny in Bree, mistreated and half-starved. He was the only animal in town, since Bill or his allies had opened the stables of The Prancing Pony and all the mounts went loose.</p>
<p>The next day Bill sold the pony to the Frodo Baggins for twelve silver pennies (more than three times his worth). This proved the best thing for Bill, as Sam Gamgee dearly loved him and fed him back to health.</p>
<p>Bill the Pony travelled with Strider and the Hobbits through the leagues of Eriador,[2] at one point carrying Frodo on their way to Rivendell.[3] Then he accompanied the Fellowship of the Ring, carrying their rations. Outside the West-gate of Moria, for fear of his safety, Bill was released into the wild, encouraged to make his way back to Bree.</p>
<p>On the homeward journey of the hobbits, Sam, who was fond of the pony, was reunited with Bill at the Prancing Pony.[5] When the returning hobbits came to the gate upon the bridge across the Brandywine and Bill Ferny threw the keys at Merry, it was Bill the pony who kicked Bill Ferny as he ran off into the night.</p>
<p>Finally, Sam rode Bill when he accompanied Frodo on his trip to the Grey Havens.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Bill_the_Pony";
            ImageArtist = Artist.Mary_Sanche;

            addFriend("Sam Gamgee", "Sam-Gamgee");

            addGroup("The Fellowship", "The-Fellowship");

            LotRCard("Bill-the-Pony-TBR");
        }
    }
}