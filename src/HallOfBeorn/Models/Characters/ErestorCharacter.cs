using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class ErestorCharacter : Character
    {
        public ErestorCharacter()
            : base("Erestor", "Erestor", "Noldor Elf")
        {
            Bio =
@"<p>Erestor was an Elf of Rivendell. He was the chief counsellor of Elrond's household at the time of the War of the Ring; as such, he took part in the Council of Elrond. He did not support the idea of destroying The Ring, and preferred instead the notion of guarding it from Sauron, perhaps with the aid of Iarwain ben-adar (Tom Bombadil). His suggestion was countered by Glorfindel, as well as Galdor, as they didn't believe that Iarwain had the power to defy Sauron.</p>
<p>Erestor accompanied Arwen to her marriage to Gondor in T.A. 3019.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Erestor";
            ImageArtist = Artist.Magali_Villeneuve;

            addFriend("Elrond", "Elrond");
            addFriend("Arwen Undómiel", "Arwen-Undomiel");
            addFriend("Glorfindel", "Glorfindel");

            addGroup("The Council of Elrond", "The-Council-of-Elrond");
            addGroup("Rivendell", "Rivendell");
        }
    }
}