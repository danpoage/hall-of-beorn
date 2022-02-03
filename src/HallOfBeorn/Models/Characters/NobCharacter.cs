using System;

namespace HallOfBeorn.Models.Characters
{
    public class NobCharacter
        : Character
    {
        public NobCharacter()
            : base("Nob", "Nob", "Hobbit")
        {
            Bio =
@"<blockquote>Hi! Nob! ... Where are you, you wolly-footed slow-coach?<br>
―Barliman Butterbur
</blockquote>
<p><b>Nob</b> was a hobbit of Bree.</p>
<h4>History</h4>
<p>Nob lived at the end of the Third Age and probably the beginning of the Fourth. He worked for Barliman Butterbur at The Prancing Pony with Bob, where he served food and tended to any other needs guests might have.</p>
<p>On September 29, T.A. 3018, four Shire-hobbits came to The Prancing Pony. When one of them, Meriadoc Brandybuck, went missing after a night stroll, Nob found him near the house of Bill Ferny. Realizing the danger, Nob helped the Hobbits to disguise their beds, and kept watch at night. Nonetheless, the Inn was attacked.</p>
<p>When those four hobbits returned on October 28 the following year, Nob still worked at The Prancing Pony.</p>
<h4>Etymology</h4>
<p>In historical English nob is slang to denote disrespect for a high society person, cf. knob &ldquo;head&rdquo;.</p>
<p>Hammond and Scull think that Nob was perhaps chosen rhyme with Bob, and that it does not appear to be recognized diminutive or nickname. It is also possible that Nob was a nickname of a person named Robert; Tolkien's review of M. Förster's Die Französierung des englischen Personennamenschatzes mentions the name Nob in one line with better known names as Hob and Rob.<p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Nob";
            ImageArtist = Artist.Francesco_Amadio;

            addGroup("Bree");
            addFriend("Bob", "Bob");
            addFriend("Barliman Butterbur", "Barliman-Butterbur");

            DisableAutoLinks = true;
            LotRCard("Nob-TGoR");
        }
    }
}