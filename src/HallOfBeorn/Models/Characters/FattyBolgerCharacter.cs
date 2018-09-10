using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class FattyBolgerCharacter : Character
    {
        public FattyBolgerCharacter()
            : base("Fatty Bolger", "Fredegar 'Fatty' Bolger", "Hobbit")
        {
            Bio =
@"<p>Fredegar 'Fatty' Bolger was a Hobbit of the Shire. He was one of the close friends of Frodo who knew that he had the Ring and helped him with his mission to leave the Shire.</p>
<h4>Ancestry</h4>
<p>Fatty was a descendant of Hildibrand Took (T.A. 2849 - T.A. 2934), one of the many sons of the Old Took. He was the son of Odovacar Bolger and Rosamunda Took. Fatty was born in T.A. 2980 and his family was from Budgeford in Bridgefields of the Eastfarthing. He also had a younger sister, Estella Bolger (b. T.A. 2985), who would eventually marry Meriadoc Brandybuck.</p>
<p>Fredegar was a good friend of Frodo Baggins. In T.A. 3001 he was a guest at Bilbo's Farewell Party.</p>
<h4>Conspiracy</h4>
<p>Fatty was one of the Conspirators, the friends of Frodo who knew that he was in an important mission to leave the Shire, and they assisted him without his knowledge. Fatty, along with Folco Boffin and Frodo's close circle, celebrated Frodo's last birthday in T.A. 3018 before his departure from Hobbiton. Fatty and Merry then left for the house that Frodo had bought in Crickhollow, in order to prepare it to be ready and habitable for his arrival.</p>
<p>Frodo eventually came to his house, along with Sam and Pippin. It was there when the conspirators revealed themselves to Frodo, and expressed their will to follow him in his mission. Fatty however was a typical hobbit who had never left the Shire and was unwilling to do so, but would play his role; he stayed behind to keep up the pretense that Frodo was there, by wearing his clothes and keep the house occupied, and deal with any 'inquisitive folk'.</p>
<p>After hearing that Frodo was pursued by the Black Riders, Fatty was given the option to flee with the others into the Old Forest, which however didn't seem more inviting to him (although Merry tried to persuade him that the Riders were far more terrifying than the stories about the Old Forest). Fredegar therefore opted to remain behind as a decoy for the Nazgûl and as a messenger for Gandalf in case he showed up.</p>
<p>The Ringwraiths did eventually come in the night of 30 September to Crickhollow for Frodo and the Ring. But Fatty, though frightened nearly witless, escaped to raise the alarm of Buckland, causing the Brandybucks to sound the Horn-call of Buckland. This caused the Nazgûl to flee, but they had learned that the Ring was gone.</p>
<h4>Resistance</h4>
<p>During Saruman's rule of the Shire, Fatty led a group of partisans fighting against the Ruffians in the Brockenbores around the hills of Scary before eventually being captured. He was imprisoned in the Lockholes and starved, (and could no longer be called 'Fatty') but was rescued after the victory of the Battle of Bywater.</p>
<h4>Etymology</h4>
<p>The name contains ferdi 'peace' and gar 'spear'.</p>
<h4>Other versions of the Legendarium</h4>
<p>In The Return of the Shadow, Fatty Bolger is said to have played a much larger role, but this was later abandoned. His role survives as a minor anomaly in the published The Lord of the Rings - before the Hobbits go into the Old Forest, they have five ponies prepared - but only take four. Fatty was originally supposed to go with them.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Fatty_Bolger";
            ImageArtist = Artist.Sebastian_Giacobino;

            addFriend("Frodo Baggins", "Frodo-Baggins");

            addGroup("The Shire", "The-Shire");
            addGroup("The Conspiracy");

            LotRCard("Fatty-Bolger-TBR");
        }
    }
}