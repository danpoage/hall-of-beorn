using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class EowynCharacter : Character
    {
        public EowynCharacter()
            : base("Éowyn", "Éowyn", "Man")
        {
            Bio =
@"<blockquote>
&ldquo;Then, Éowyn of Rohan, I say to you that you are beautiful. In the valleys of our hills there are flowers fair and bright, and maidens fairer still; but neither flower nor lady have I seen till now in Gondor so lovely, and so sorrowful. It may be that only a few days are left ere darkness falls upon our world, and when it comes I hope to face it steadily; but it would ease my heart, if while the Sun yet shines, I could see you still. For you and I have both passed under the wings of the Shadow, and the same hand drew us back.&rdquo;
<br>― Faramir
</blockquote>
<br>
<blockquote>
&ldquo;Do what you will; but I will hinder it, if I may.&rdquo;
<br>- Éowyn - The Two Towers
</blockquote>
<p>Éowyn (T.A. 2995 – Fourth Age ?), the Lady of Rohan, was also known as the Lady of the Shield-arm, the White Lady of Rohan, and Lady of Ithilien. She was a member of the House of Eorl and the niece of King Théoden of Rohan. She was the daughter of Théoden's sister, Théodwyn, and Éomund of Eastfold. Her brother was Éomer Éadig. Following the end of the War of the Ring, she and Faramir were married and bore one son, Elboron.</p>
<h4>History</h4>
<p>Following the death of her parents in T.A. 3002, Éowyn and Éomer were brought into Théoden's house and there raised. Éowyn grew to be tall and slender, with a grace and pride that came from her mother.</p>
<p>Prior to the Battle of the Hornburg, Éowyn was left to care for Meduseld when Théoden and Éomer led the remaining Rohirrim to the west. King Théoden in fact named her ruler of Rohan in his and Éomer's absence when the Doorward Háma recommended that one of 'The House of Eorl' should rule. At first, Théoden only thought of male members, and he and Éomer were the last males of the House, but Háma reminded them of Éowyn, who 'is fearless' and that 'all love her'.</p>
<p>Éowyn revealed her temperament when Aragorn was about to ride into the mountains to attempt to take the Paths of the Dead. Unable to dissuade him, she offered to accompany him, declaring herself 'weary of skulking in the hills, and wish to face peril and battle.' The only thing she feared was a cage. However, Aragorn reminded her of her charge to govern the people until the king's return and left without her.</p>
<p>Later, when the forces of Rohan were mustered to go to Gondor, Éowyn disguised herself as a man, and under the alias of Dernhelm, traveled with the Riders of Rohan, carrying with her Merry, who was also ordered to remain behind.</p>
<p>During the Battle of the Pelennor Fields, she fought by King Théoden, and when he was injured during combat with the Witch-king of Angmar, she and Merry scrambled to help him. Confronting the Witch-king, who boasted that 'no living man may hinder me,' she removed her helmet, exposing her long golden hair and declaring:</p>
<blockquote>
&ldquo;No living man am I! You look upon a woman.&rdquo;
</blockquote>
<p>Lady Éowyn slew the Witch-king after Merry stabbed him behind the knee. Merry's stab made the Witch-king vulnerable while Éowyn's slash actually resulted in death. She was granted the title 'Lady of the Shield-arm' after the Battle in recognition of her triumph over the Witch-king.</p>
<p>Lady Éowyn was severely injured in this fight, and because of the poisonous effect of the Nazgûl, she faced near-certain death; however, she was treated in time by Aragorn during his brief rest in Minas Tirith. Since she didn't yet recover completely, she couldn't join Aragorn's army on their way to Mordor. However, while recuperating in the Houses of Healing, she met Faramir, with whom she fell in love.</p>
<p>After the demise of Sauron, the happily wed couple settled in Ithilien, of which Faramir was made the ruling Prince. Éowyn was known as the Lady of Ithilien. They married, and dwelt together in the hills of Emyn Arnen in Ithilien. They had at least one son (likely Elboron), and their grandson was Barahir, who wrote The Tale of Aragorn and Arwen in the Fourth Age.</p>
<h4>Etymology</h4>
<p>Éowyn means 'Horse-joy' in Old English (being a combination of her parents' names: Éomund and Théodwyn), the language Tolkien adapted to represent Rohirric.</p>
<p>Éo- sounds like 'eh-ah' with the 'ah' just barely pronounced, while y is the same sound as German ü or French u.</p>
<h4>Other Names</h4>
<p>The 'White Lady of Rohan' title given by Faramir to Éowyn of Rohan when they were together looking out from the walls of Minas Tirith and saw the huge cloud that rose above Mordor at the fall of Sauron[2] on 25 March T.A. 3019.</p>
<h4>Analysis</h4>
<p>Just as MacDuff disconcerted Macbeth by revealing he was not 'of woman born', Lady Éowyn found the loophole in the 1,000-year-old prophecy by Glorfindel, fulfilling that the Witch-king would not be slain by a man. However, the Witch-king actually recited the prophecy incorrectly: he said that 'no living man may hinder me,' though the prophecy actually said that 'not by the hand of man will he fall.' Glorfindel's prophecy, unlike his own version, implies that the Witch-king will not fall to a man. In Tolkien's writing, man and woman applies simply to the gender of any Middle-earth race. Only when he capitalized Man did it denote the race of Men. The Witch-king may not have realized that the prophecy meant only a male, thus, his moment of doubt and hesitation when he faced Éowyn.</p>";

            BioSourceUrl = "http://tolkiengateway.net/wiki/Eowyn";
            ImageArtist = Artist.Magali_Villeneuve;

            Alias("Dernhelm");
            Alias("Shieldmaiden of Rohan");

            addFamily("Éomund (Father)", "Eomund");
            addFamily("Théodwyn (Mother)");
            addFamily("Faramir (Husband)", "Faramir");
            addFamily("Éomer (Brother)", "Eomer");
            addFamily("Théoden (Uncle)", "Theoden");
            addFamily("Théodred (Cousin)", "Theodred");

            addFriend("Gríma", "Grima"); 
            addFriend("Merry", "Merry");
            addFriend("Prince Imrahil", "Prince-Imrahil");

            addItem("Windfola", "Windfola-ASoCH");

            addGroup("The Rohirrim", "The-Rohirrim");

            LotRCard("Eowyn-Core");
            LotRCard("Eowyn-TFotW");
            DigitalCard("Eowyn-EW");
        }
    }
}