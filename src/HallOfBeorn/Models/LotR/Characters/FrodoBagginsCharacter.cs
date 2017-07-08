using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class FrodoBagginsCharacter : Character
    {
        public FrodoBagginsCharacter()
            : base("Frodo Baggins", "Frodo Baggins", "Hobbit")
        {
            Bio =
@"<p>Frodo Baggins is a fictional character in J. R. R. Tolkien's legendarium, and one of the main protagonists of The Lord of the Rings. Frodo is a hobbit of the Shire who inherits the One Ring from his cousin Bilbo Baggins and undertakes the quest to destroy it in the fires of Mount Doom. He is also mentioned in Tolkien's posthumously published works, The Silmarillion and Unfinished Tales.</p>
<p>Frodo did not appear until the third draft of A Long-Expected Party (the first chapter of The Lord of the Rings), when he was named Bingo (after a family of toy koala owned by Tolkien's children), son of Bilbo Baggins and Primula Brandybuck.[1] In the fourth draft, he was renamed Bingo Bolger-Baggins, son of Rollo Bolger and Primula Brandybuck.[2] Tolkien did not change the name to Frodo until the third phase of writing, when much of the narrative, as far as the hobbits' arrival in Rivendell, had already taken shape.[3] Prior to this, the name 'Frodo' had been used for the character who eventually became Peregrin Took.</p>
<p>Frodo is introduced in The Fellowship of the Ring as the adoptive heir of Bilbo Baggins. The chapter 'A Long-expected Party' relates that Frodo's parents Drogo Baggins and Primula Brandybuck had been killed in a boating accident when Frodo was 12; Frodo subsequently spent the next nine years living with his maternal family, the Brandybucks in Brandy Hall. At the age of 21 he was adopted by his cousin,[nb 1] Bilbo, who brought him to live at Bag End. He and Bilbo shared the same birthday, the 22nd of 'September'. It was Bilbo who introduced the Elvish languages to Frodo, and they often shared long walking trips together.</p>";

            BioSourceUrl = "https://en.wikipedia.org/wiki/Frodo_Baggins";
            ImageArtist = Artist.Jake_Murray;

            TheFellowshipOfTheRing();
            TheTwoTowers();
            TheReturnOfTheKing();

            Alias("Mr. Underhill", "Mr-Underhill-TBR");

            addFamily("Bilbo Baggins (Cousin)", "Bilbo-Baggins");

            addFriend("Merry", "Merry");
            addFriend("Pippin", "Pippin");
            addFriendCard("Farmer Maggot", "Farmer-Maggot-TBR");
            addFriendCard("Barliman Butterbur", "Barliman-Butterbur-TBR");

            addGroup("The Fellowship", "The-Fellowship");

            addItem("Sting", "Sting-RD");
            addItem("Mithril Shirt", "Mithril-Shirt-RD");
            addItem("The One Ring", "The-One-Ring-TBR");
            addItem("Phial of Galadriel", "Phial-of-Galadriel-RD");

            Card("Frodo-Baggins-CatC");
            Card("Frodo-Baggins-TBR");
            Card("Frodo-Baggins-RD");
            Card("Frodo-Baggins-ToS");
            Card("Frodo-Baggins-TMoF");
        }
    }
}