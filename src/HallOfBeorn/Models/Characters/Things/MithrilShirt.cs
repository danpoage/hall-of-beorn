using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters.Things
{
    public class MithrilShirt : CharacterThing
    {
        public MithrilShirt()
            : base("Mithril Shirt", "Mitril Shirt", "Armor")
        {
            Bio =
@"<p>The <b>Mithril Shirt</b> was a coat of mail take from the hoard of Smaug and given by Thorin Oakenshielf to Bilbo Baggins.</p>
<h3>History</h3>
<p>Of all items made of mithril, the most famous is the &lquo;small shirt of mail&rdquo; retrieved from the hoard of the dragon Smaug, and given to Bilbo Baggins by Thorin.</p>
<p>A kingly gift, the mithril-coat was actually worth more than the entire worth of the Shire (Bilbo probably knew this, but he didn't care). Bilbo had it decorated on a stand-in Bag End until he donated it to Mathom-house[6] but he took it back before leaving the Shire for Rivendell. Years later, he gave it to his nephew Frodo, who wore it during the Quest to Mount Doom. It saved Frodo's life several times; the first when he was nearly skewered by an Orc in the Mines of Moria and the second when he was hit by an arrow while on the river Anduin. It was later taken by the Orcs who captured him in the pass above Cirith Ungol, and passed on to the Dark Lord's servants at Barad-dûr. When the coat was displayed before the hosts of Aragorn at the Gates of Mordor, many despaired, thinking Frodo had been captured or killed, and the Ring taken. Gandalf reclaimed it from Sauron's lieutenant and was later able to return it to Frodo after the battles were won. After the Battle of Bywater, the coat once again saved Frodo's life after Saruman attempted to assassinate him at Bag End</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Mithril#The_Mithril_Coat";
            ImageArtist = Artist.Tiziano_Baracchi;

            addFriend("Bilbo Baggins", "Bilbo-Baggins");
            addFriend("Frodo Baggins", "Frodo-Baggins");

            LotRCard("Mithril-Shirt-TFoW");
            LotRCard("Mithril-Shirt-THotD");
            LotRCard("Mithril-Shirt-RD");
        }
    }
}