using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class GandalfCharacter : Character
    {
        public GandalfCharacter()
            : base("Gandalf", "Gandalf", "Maia")
        {
            Bio =
@"<p>Gandalf /ˈɡændɑːlf/[2] is a fictional character and one of the protagonists in J. R. R. Tolkien's novels The Hobbit and The Lord of the Rings. He is a wizard, member of the Istari order, as well as leader of the Fellowship of the Ring and the army of the West. In The Lord of the Rings, he is initially known as Gandalf the Grey, but returns from death as Gandalf the White.</p>
<p>Tolkien discusses Gandalf in his essay on the Istari, which appears in the work Unfinished Tales. He describes Gandalf as the last of the wizards to appear in Middle-earth, one who: 'seemed the least, less tall than the others, and in looks more aged, grey-haired and grey-clad, and leaning on a staff'. Yet the Elf Círdan who met him on arrival nevertheless considered him 'the greatest spirit and the wisest' and gave him the elven Ring of power called Narya, the Ring of Fire, containing a 'red' stone for his aid and comfort. Tolkien explicitly links Gandalf to the element Fire later in the same essay:</p>
<blockquote>Warm and eager was his spirit (and it was enhanced by the ring Narya), for he was the Enemy of Sauron, opposing the fire that devours and wastes with the fire that kindles, and succours in wanhope and distress; but his joy, and his swift wrath, were veiled in garments grey as ash, so that only those that knew him well glimpsed the flame that was within. Merry he could be, and kindly to the young and simple, yet quick at times to sharp speech and the rebuking of folly; but he was not proud, and sought neither power nor praise... Mostly he journeyed tirelessly on foot, leaning on a staff, and so he was called among Men of the North Gandalf 'the Elf of the Wand'. For they deemed him (though in error) to be of Elven-kind, since he would at times work wonders among them, loving especially the beauty of fire; and yet such marvels he wrought mostly for mirth and delight, and desired not that any should hold him in awe or take his counsels out of fear. ... Yet it is said that in the ending of the task for which he came he suffered greatly, and was slain, and being sent back from death for a brief while was clothed then in white, and became a radiant flame (yet veiled still save in great need).[3]</blockquote>";

            BioSourceUrl = "https://en.wikipedia.org/wiki/Gandalf";
            ImageArtist = Artist.Magali_Villeneuve;

            TheFellowshipOfTheRing();
            TheTwoTowers();
            TheReturnOfTheKing();

            Alias("Greyhame");
            Alias("Tharkûn");
            Alias("The Grey Pilgrim");
            Alias("Stormcrow");
            Alias("Gandalf the Grey");
            Alias("The White Rider");
            Alias("Olórin");
            Alias("Gandalf the White");
            Alias("Láthspell");
            Alias("Incánus");
            Alias("Mithrandir", "Mithrandir's-Advice-TSF");

            Card("Gandalf-Core");
            Card("Gandalf-THOHaUH");
            Card("Gandalf-RD");

            addFriend("Aragorn", "Aragorn");
            addFriend("Bilbo Baggins", "Bilbo-Baggins");
            addFriend("Radagast", "Radagast");
            addFriend("Galadriel", "Galadriel");

            addItem("Glamdring", "Glamdring-RD");
            addItem("Narya", "Narya-TGH");
            addItem("Shadowfax", "Shadowfax-ToS");

            addGroup("The Fellowship", "The-Fellowship");
            addGroup("Thorin's Company", "Thorin's-Company");
            addGroup("The White Council", "The-White-Council");
        }
    }
}