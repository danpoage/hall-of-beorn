using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class FaramirCharacter : Character
    {
        public FaramirCharacter()
            : base("Faramir", "Faramir", "Man")
        {
            Bio =
@"<p> J. R. R. Tolkien's Middle-earth legendarium, Faramir is a fictional character appearing in The Lord of the Rings. He is introduced as the younger brother of Boromir of the Fellowship of the Ring and second son of Denethor II, the Steward of the realm of Gondor. The relationships between the three men are revealed over the course of the book and are elaborated in the appendices.</p>
<p>Faramir first enters the narrative in person in The Two Towers, where, upon meeting Frodo Baggins, he is presented with a temptation to take possession of the One Ring. In The Return of the King, he led the forces of Gondor during the War of the Ring, coming near to death, and eventually succeeded his father as the Steward and won the love of Éowyn of Rohan.</p>
<p>In The History of The Lord of the Rings series Christopher Tolkien recorded that his father had not foreseen the emergence of Faramir during the writing of the book, only inventing him at the actual point of his appearance in The Two Towers.[1] J. R. R. Tolkien noted that the introduction of Faramir had led to postponement of the book's dénouement and to further development of the background for Gondor and Rohan.[2] Long after completing The Lord of the Rings, Tolkien would write that of all characters Faramir resembles the author most, and that he had deliberately bestowed upon the character several traits of his own.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Faramir";
            ImageArtist = Artist.Magali_Villeneuve;

            Alias("Steward of Gondor", "Steward-of-Gondor-Core");
            Alias("Prince of Ithilien");
            Alias("Lord of Emyn Arnen");

            addFamily("Denethor (Father)", "Denethor");
            addFamily("Finduilas (Mother)");
            addFamily("Boromir (Brother)", "Boromir");
            addFamily("Éowyn (Wife)", "Eowyn");

            addFriend("Mablung", "Mablung");
            addFriend("Damrod", "Damrod");
            addFriend("Anborn", "Anborn");
            addFriend("Frodo Baggins", "Frodo-Baggins");
            addFriend("Sam Gamgee", "Sam-Gamgee");

            addGroup("Gondor", "Gondor");
            addGroup("Rangers of Ithilien", "Rangers-of-Ithilien");

            Card("Faramir-AoO");
            Card("Faramir-TLoS");
            Card("Faramir-Core");
            Card("Faramir-TBoG");
        }
    }
}