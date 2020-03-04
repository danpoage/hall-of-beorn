using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class GildorInglorionCharacter: Character
    {
        public GildorInglorionCharacter()
            : base("Gildor Inglorion", "Gildor Inglorion", "Noldor Elf")
        {
            Bio =
@"<blockquote>
&ldquo;Elves seldom give unguarded advice, for advice is a dangerous gift, even from the wise to the wise, and all courses may run ill.&rdquo;
<br>― Gildor Inglorion
</blockquote>
<p>Gildor Inglorion was a Noldorin Elf of the House of Finrod, who in the Third Age lived in Rivendell.</p>
<h4>History</h4>
<p>Gildor was probably the son of some Inglor[2] and one of the Exiles of the House of Finrod. It's possible that he was from around Rivendell.</p>
<p>Elven Wandering Companies crossed the Shire every Spring and Autumn. Around September T.A. 3001, as Bilbo Baggins was leaving the Shire for Rivendell, Gildor met the hobbit as he waved them farewell in Woody End. The following years he met him once more, perhaps at Rivendell.</p>
<p>In September T.A. 3018, he traveled eastwards with a company of Elves of Rivendell. They were returning from the Emyn Beraid, where they went to see Elbereth in the palantír that was kept there. On the 24th, they met Frodo Baggins, Samwise Gamgee and Peregrin Took on the road near the Woody End. They ate and sang, and Gildor discussed the peril that haunted the three hobbits. This peril, a Black Rider, was near, but fled as he heard the Elves chant of Elbereth. Because of Frodo's ability to speak Elvish, Gildor gave him the title Elf-friend.</p>
<p>After separating from the hobbits, he sent word to the house of Tom Bombadil, probably before the 26th.[4] He also spoke with Aragorn[5] and sent a message to Elrond.</p>
<p>Two years later, on September 22, T.A. 3021, he met the Hobbits once again. He accompanied a riding of great Lords and Ladies, that planned to sail West on board the White Ship and probably he was among the Elves who sailed to the West.</p>
<h4>Ancestry</h4>
<p>Gildor is one of the less prominently featured Elves, yet he seems important enough to raise questions concerning his lineage, or the identity of this character. Gildor calls himself 'Gildor Inglorion of the House of Finrod'. He also says: 'We are Exiles, and most of our kindred have long departed and we too are only tarrying here a while, ere we return over the Great Sea.'</p>
<p>It should be noted that Tolkien initially used names from his (unpublished) The Silmarillion writings rather at random in The Hobbit and the first drafts of the sequel which would become The Lord of the Rings: other examples are the mention of Gondolin and the appearance of Elrond in The Hobbit, which were only later brought into alignment with The Lord of the Rings and the unpublished mythology by a third edition of the book.[9] This therefore is the case of the reference to the name 'Finrod'.</p>
<p>The name 'Gildor' first appeared in the outlines of The Lord of the Rings in February 1938, and in Tolkien's notes of that time, 'Finrod' still meant the character later known as Finarfin[11] and his son had the older name 'Inglor'.</p>
<h4>Connection to Finarfin</h4>
<p>However the name Inglor reappeared, in Quenya form, for Finarfin (who in the earlier legendarium, was named Finrod). Finarfin's mother-name was Ingalaurë.[12] If Ingalaurë is to be translated in Sindarin according to the sound-changing rules, this would become Inglor. Thus, the connection of Gildor to the house of Finrod/Finarfin still remains in the updated legendarium.</p>
<p>This all suggests that, while Gildor might have been initially intended to be Felagund's son, in the final version he probably became a member of the House of Finrod as one of its servants, not one of its sons — perhaps one of the knights of Nargothrond.</p>
<p>It is also possible that he was a son of a supposed 'Inglor' — a character unconnected to Finrod Felagund.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Gildor";
            ImageArtist = Artist.Magali_Villeneuve;

            Alias("of the House of Finrod");

            addFriend("Gandalf", "Gandalf");
            addFriend("Aragorn", "Aragorn");
            addFriend("Frodo Baggins", "Frodo-Baggins");

            addGroup("Rivendell", "Rivendell");
        }
    }
}
