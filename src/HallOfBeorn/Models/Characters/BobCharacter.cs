using System;

namespace HallOfBeorn.Models.Characters
{
    public class BobCharacter
        : Character
    {
        public BobCharacter()
            : base("Bob", "Bob", "Hobbit")
        {
            Bio =
@"<p><b>Bob</b> was a Hobbit of Bree.</p>
<h4>History</h4>
<p>Bob worked as an ostler in the Prancing Pony.[1] After the Ruffians entered Bree, Bob stopped working evenings, so he could be home before nightfall.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Bob";
            ImageArtist = Artist.Anna_Kulisz;

            addGroup("Bree");
            addFriend("Nob", "Nob");
            addFriend("Barliman Butterbur", "Barliman-Butterbur");

            DisableAutoLinks = true;
            LotRCard("Bob-TGoR");
        }
    }
}