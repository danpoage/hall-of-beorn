using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class BrandSonOfBainCharacter : Character
    {
        public BrandSonOfBainCharacter()
            : base("Brand son of Bain", "Brand, son of Bain", "Man")
        {
            Bio =
@"<p>Brand was the son of Bain and grandson of Bard the Bowman[1] who killed the dragon Smaug.[2] He was the king of Dale during the War of the Ring, by which time he had extended the realm of Dale far south and east of Esgaroth.[1]</p>
<p>At the Council of Elrond the dwarf Glóin reported that a year earlier (in T.A. 3017) a messenger from Mordor had come to speak to Dáin. He also said that messengers had spoken to King Brand and that he was afraid, for war appeared to be gathering on his eastern borders.[3]</p>
<p>King Brand remained steadfast though. In T.A. 3019 when a host of Sauron's allies crossed the River Carnen he retreated into Dale. There the Men of Dale and the Dwarves of Erebor fought for three days. Brand was slain at the side of Dáin II Ironfoot during the Battle of Dale, at the end of which the victorious Easterlings drove the allies into the Mountain where they were besieged. However, when news of Sauron's defeat came his northern army was dismayed and the siege was lifted. King Brand was succeeded by his son, Bard II.[4]</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Brand";
            ImageArtist = Artist.Donato_Giancola;

            Alias("King of Dale", "King-of-Dale-TWoR");

            addFamily("Bard the Bowman (Grandfather)", "Bard-the-Bowman");
            addFamily("Bain (Father)");
            addFamily("Bard son of Brand (Son)", "Bard-son-of-Brand");

            addFriend("Dain Ironfoot", "Dain-Ironfoot");
            addFriend("Glóin", "Gloin");

            addItem("Great Yew Bow", "Great-Yew-Bow-THOHaUH");
            addItem("Bow of Yew", "Bow-of-Yew-TWoR");
            addItem("Necklace of Girion", "Necklace-of-Girion-TWoR");

            Card("Brand-son-of-Bain-THoEM");
            Card("Brand-son-of-Bain-TWoR");
        }
    }
}