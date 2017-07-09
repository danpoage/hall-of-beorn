using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class EowynCharacter : Character
    {
        public EowynCharacter()
            : base("Éowyn", "Éowyn", "Man")
        {
            Bio =
@"<p>Éowyn is a fictional character in Tolkien's legendarium who appears in his most famous work, The Lord of the Rings. She is a noblewoman of Rohan who is described as a shieldmaiden.</p>
<p>In The Two Towers, Éowyn, a daughter of the House of Eorl and the goddaughter of King Théoden of Rohan, is introduced in Meduseld, the king's hall at Edoras.[1] She was the daughter of Théodwyn (Théoden's sister) and Éomund and the sister of Éomer. When she was only seven years old, her father was killed fighting orcs and her mother died of grief. Éowyn and Éomer were raised in her uncle's household as if they were his own children.</p>
<p>Tolkien writes that she longed to win renown in battle—especially since she was royal—but being female, her duties were reckoned to be at Edoras.[2] When Théoden's mind was poisoned by his adviser Gríma Wormtongue, Éowyn was obliged to care for her uncle, and his deterioration pained her deeply. To make matters worse, she was constantly harassed by Gríma, who lusted after her. However, when Gandalf arrived, he freed Théoden from Wormtongue's influence.</p>
<p>Éowyn fell in love with Aragorn, but it soon became clear that he could not return her love although he did not mention his betrothal to Arwen, except by indirect allusion, and would not allow her to join him in going to war.[3] As Aragorn pointed out,[3] her duty was with her people; she had to shoulder the responsibility of ruling Rohan in Théoden's stead when the war-host of Rohan went to war,[1] a duty he deemed no less valiant.[3] Likening her situation to a 'cage', Éowyn said she feared '[t]o stay behind bars, until use and old age accept them, and all chance of great deeds is gone beyond recall or desire.'</p>
<p>In The Return of the King, she disguised herself as a man and, under the alias of Dernhelm (from Old English dern meaning 'secret, concealed'), traveled with the Riders of Rohan to the Battle of the Pelennor Fields outside the White City of Minas Tirith in Gondor, carrying with her Meriadoc Brandybuck, who had also been ordered to remain behind, on her horse Windfola.</p>
<p>During the battle of the Pelennor Fields, she confronted the Witch-king of Angmar, Lord of the Nazgûl, after Théoden was injured. The Witch-king threatened to 'bear [her] away to the houses of lamentation, beyond all darkness, where [her] flesh shall be devoured, and [her] shriveled mind be left naked to the Lidless Eye.'[4] The Witch-king further boasted that '[n]o living man may hinder me,'[4] referring to the 1,000-year-old prophecy by the Elf-lord Glorfindel, foretelling that the Witch-king would not fall 'by the hand of man'.[5] Éowyn then removed her helmet and declared:</p>
<blockquote>But no living man am I! You look upon a woman. Éowyn I am, Éomund’s daughter. You stand between me and my lord and kin. Begone, if you be not deathless! For living or dark undead, I will smite you, if you touch him.</blockquote>
<p>The Witch-king attacked Éowyn with his steed, but she slew it with her sword. He then shattered her shield and broke her shield-arm with his mace, but was distracted by Merry, who stabbed him behind the knee with a barrow-blade. Éowyn seized the opportunity to strike the Witch-king with a killing thrust 'between crown and mantle'.[4] Then, as her sword shattered, his withering form collapsed and he vanished with a final cry of anguish.</p>
<p>Éowyn soon passed out from the pain in her arm, and was believed dead until Prince Imrahil of Dol Amroth realized she still lived. Éowyn was brought to the Houses of Healing, hovering near death from the effects of having struck the Witch-king.[2] There Éowyn met Faramir, with whom she soon fell in love. Her outlook on life also changed: 'Then the heart of Éowyn changed, or else at last she understood it. [...] I will be a shieldmaiden no longer, nor vie with the great Riders, nor take joy only in the songs of slaying. I will be a healer, and love all things that grow and are not barren.'</p>
<p>After the demise of Sauron, Éowyn and Faramir married and settled in Ithilien, of which Faramir was made the ruling Prince by King Elessar, the name with which Aragorn ascended the throne of the Reunited Kingdom. Faramir and Éowyn had at least one son, Elboron, and their grandson was Barahir, who wrote The Tale of Aragorn and Arwen in the Fourth Age.</p>";

            BioSourceUrl = "https://en.wikipedia.org/wiki/%C3%89owyn";
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

            Card("Eowyn-Core");
            Card("Eowyn-TFotW");
        }
    }
}