using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class GondorGroup : CharacterGroup
    {
        public GondorGroup()
            : base("Gondor", "The People of Gondor")
        {
            Bio =
@"<p>Gondor is a fictional kingdom in J. R. R. Tolkien's writings, described as the greatest realm of Men in the west of Middle-earth by the end of the Third Age. The third volume of The Lord of the Rings, The Return of the King, is largely concerned with the events in Gondor during the War of the Ring and with the restoration of the realm afterward. The history of the kingdom is outlined in the appendices of the book.</p>
<p>According to the narrative, Gondor was founded by the brothers Isildur and Anárion, exiles from the downfallen island kingdom of Númenor. Along with Arnor in the north, Gondor, the South-kingdom, served as a last stronghold of the Men of the West. After an early period of growth, Gondor gradually declined as the Third Age progressed, being continually weakened by internal strife and conflict with the allies of the Dark Lord Sauron. The kingdom's ascendancy was restored only with Sauron's final defeat and the crowning of Aragorn.</p>
<p>Based upon early conceptions, the history and geography of Gondor were developed in stages as a part of the major extension of Tolkien's legendarium that he undertook during the writing of The Lord of the Rings. The role of the kingdom emerged gradually, when a side adventure in the plot became the focus of later writings. The textual history was traced by Christopher Tolkien in The History of Middle-earth, and the subject has gained attention from later researchers and fans.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Gondor";
            ImageArtist = Artist.Ted_Nasmith;

            addLeader("Denethor", "Denethor");

            addMember("Boromir", "Boromir");
            addMember("Faramir", "Faramir");
            addMember("Beregond", "Beregond");
            addMember("Prince Imrahil", "Prince-Imrahil");
            addMember("Mablung", "Mablung");
            addMember("Damrod", "Damrod");
            addMember("Hirgon", "Hirgon");
            addMember("Anborn", "Anborn");
            addMember("Ingold", "Ingold");
            addMember("Hirluin the Fair", "Hirluin-the-Fair");
            addMember("Forlong", "Forlong");
            
            Card("For-Gondor-Core");
            Card("Light-the-Beacons-HoN");
        }
    }
}