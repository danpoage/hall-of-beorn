using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class TheodenCharacter : Character
    {
        public TheodenCharacter()
            : base("Théoden", "Théoden, son of Thengel", "Man")
        {
            Bio =
@"<p>Théoden is a fictional character in J. R. R. Tolkien's fantasy novel, The Lord of the Rings. The King of Rohan, he appears as a major supporting character in The Two Towers and The Return of the King.</p>
<p>Théoden is introduced in The Two Towers, the second volume of The Lord of the Rings, as the King of Rohan. By the time of the War of the Ring, Théoden had grown weak with age, and was largely controlled by his chief advisor Gríma (or Wormtongue as most others in the Riddermark called him), who was secretly in the employ of the corrupt wizard Saruman. In Unfinished Tales, it is implied that the failure of the king's health was '...induced or increased by subtle poisons, administered by Gríma'.[1] As Théoden sat powerless, Rohan was troubled by Orcs and Dunlendings, who operated under the will of Saruman, ruling from Isengard.</p>
<p>When his son Théodred was mortally wounded at a battle at the Fords of Isen, Théoden's nephew Éomer became his heir. However, Éomer was out of favour with Wormtongue, who eventually had him arrested.</p>
<p>When Gandalf the White and Aragorn, along with Legolas and Gimli, appeared before him in The Two Towers, Théoden initially rebuffed the wizard's advice to oppose Saruman. When Gandalf revealed Wormtongue for what he was, however, Théoden returned to his senses. He restored his nephew, took up his sword Herugrim, and in spite of his age, led the Riders of Rohan into the Battle of the Hornburg. After this he became known as Théoden Ednew, the Renewed.</p>
<p>In The Return of the King, Théoden led the Rohirrim to the aid of Gondor at the Battle of the Pelennor Fields. In that battle he routed the Harad cavalry, personally killing their chieftain and banner-bearer in the process. He challenged the Witch-king of Angmar, the leader of the Nazgûl, and was mortally wounded when his horse Snowmane fell upon him. He was avenged by his niece Éowyn and the hobbit Meriadoc 'Merry' Brandybuck, who had ridden to war in secret; together, they destroyed the Witch-king. Before mustering the Rohirrim to ride to Gondor's aid, Théoden enlisted Merry into his army, but did not let the hobbit ride into battle at Pelennor. In his last moments, he bid farewell to Merry and appointed Éomer the next king.</p>
<p>Théoden's body lay in Minas Tirith until it was buried in Rohan after the defeat of Sauron. He was the last of the Second Line of the kings, judging from direct descent from Eorl the Young.</p>
<p>The appendices of The Return of the King explain that Théoden was the only son of King Thengel and Morwen of Lossarnach (a region of Gondor). He was the second-born of five children, and the only boy. Théoden was closest to his youngest sister, Théodwyn. He was born in Gondor, where his family lived until Thengel became king of Rohan.</p>
<p>He became king after the death of his father. Théodwyn lived with him in Edoras. He married Elfhild, but she died giving birth to their son, Théodred. After Théodwyn and her husband Éomund also died, he adopted their children, Éomer and Éowyn.</p>
<p>In his prime, Théoden was a strong and vital king, highly respected by his subjects. As with other Men of the Riddermark, Théoden was a skilled horseman.</p>
<p>He acted as the First Marshal of the Mark after the death of Éomund, who had filled that position; as First Marshal he commanded the Muster of Edoras (Théodred and Éomer were respectively the Second and Third Marshal). His sword was called Herugrim.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Th%C3%A9oden";
            ImageArtist = Artist.Magali_Villeneuve;

            Alias("Tûrac");
            Alias("Ednew");
            Alias("Lord of the Mark");
            Alias("King of Rohan");

            addFamily("Thengel (Father)");
            addFamily("Morwen (Mother)");
            addFamily("Elfhild (Wife)");
            addFamily("Théodred (Son)", "Theodred");
            addFamily("Théodwyn (Sister)");
            addFamily("Éomund (Brother-in-Law)", "Eomund");
            addFamily("Éomer (Nephew)", "Eomer");
            addFamily("Éowyn (Niece)", "Eowyn");

            addFriend("Gríma", "Grima");
            addFriend("Gandalf", "Gandalf");
            addFriend("Háma", "Hama");
            addFriend("Merry", "Merry");

            addItem("Snowmane", "Snowmane-TLoS");
            addItem("Herugrim", "Herugrim-ToS");
            addItem("Golden Shield", "Golden-Shield-TFotW");

            addGroup("The Rohirrim", "The-Rohirrim");

            Card("Theoden-TMV");
            Card("Theoden-ToS");
        }
    }
}