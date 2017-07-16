using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class BeregondCharacter : Character
    {
        public BeregondCharacter()
            : base("Beregond", "Beregond", "Man")
        {
            Bio =
@"<p>Beregond is a fictional characters in J. R. R. Tolkien's Middle-earth legendarium, appearing in The Return of the King.<p>
<p>Beregond is the first Captain of the White Company; the guard of Faramir, Prince of Ithilien; and previously, a member of the Third Company of the Guard of the Citadel in Minas Tirith. He is appointed to this rank after he saves Faramir's life during the Siege of Minas Tirith. In the novel, he and his son Bergil were also noted for being the guides of Pippin Took in Minas Tirith. The two form a deep friendship and talk about their various troubles. In later battle, Beregond and Pippin are stunned and crushed by the bodies of oncoming enemies. Both are saved when Gimli notices the familiar shape of Pippin's foot and digs for him. He has two children, Bergil and Borlas.</p>
<p>During the Siege of Gondor, Beregond received news from Pippin that Denethor intended to kill both himself and the seemingly-dead Faramir. Leaving his post, he fought the door guards of the place where Denethor had taken Faramir in order to reach him, until the arrival of Gandalf and Pippin, whereupon Faramir was saved. After protecting Faramir, he carried him to the Houses of Healing and stood guard over him until he awoke.</p>
<p>Beregond traveled with Aragorn's army to the Gates of Morannon to challenge the forces of Sauron. They served under Prince Imrahil, and during the Battle of the Morannon, Beregond was nearly killed by a Troll.</p>
<p>After the War of the Ring, Beregond was brought before the newly crowned Aragorn II Elessar to answer for the abandonment of his post, as well as the murders of those who stood in his way as he raced to rescue Faramir. Recognizing that what he did was out of love for his lord, he did not impose the death penalty upon him; the newly crowned king's largesse allowed for Beregond to simply be banished from Minas Tirith and live in Ithilien to serve Faramir, for whom he had broken the laws to rescue. He was then promoted to the rank of Captain of the White Company.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Beregond_and_Bergil";
            ImageArtist = Artist.Magali_Villeneuve;

            addFamily("Bergil (Son)");

            addFriend("Denethor", "Denethor");
            addFriend("Boromir", "Boromir");
            addFriend("Faramir", "Faramir");
            addFriend("Pippin", "Pippin");

            addItem("Gondorian Shield", "Gondorian-Shield-TSF");
            addItem("Livery of the Tower", "Livery-of-the-Tower-TFotW");

            Card("Beregond-HoN");
            Card("Beregond-TFotW");
        }
    }
}