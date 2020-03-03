using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class BarlimanButterburCharacter : Character
    {
        public BarlimanButterburCharacter()
            : base("Barliman Butterbur", "Barliman Butterbur", "Man")
        {
            Bio =
@"<p>Barliman Butterbur was a Man from Bree, the owner of The Prancing Pony.</p>
<p>A short, fat, red-faced Man, he appeared to have had a rather bad memory, 'One thing drives out another' he says.</p>
<h4>History</h4>
<p>The Prancing Pony in Bree was kept by the Butterbur Family for many generations and Barliman inherited it before the War of the Ring. He had two hobbit employees: Bob, who worked in the stables, and Nob, a servant.</p>
<p>During the War, Gandalf wrote a letter to Frodo and told Barliman to send it to Hobbiton. Barliman could not find anyone for the task, and eventually forgot the letter altogether, leaving Frodo uncertain as to Gandalf's fate and causing him to start his journey much later than the letter indicated.</p>
<p>He did not remember it until autumn, when Frodo and his companions arrived to stay at the inn, and even then it was long before the connection was made. He did, however, remember to produce Strider's credentials.</p>
<p>When Gandalf finally arrived at The Prancing Pony, he was furious with Barliman's forgetfulness, but quickly forgave him when he found out the Hobbits were alive. He even went so far as to put a blessing on his beer.</p>
<p>After the War of the Ring, Barliman was amazed to learn that Strider, a former patron of the Prancing Pony, had become king of Gondor and Arnor.</p>
<h4>Other Versions of the Legendarium</h4>
<p>In the first version of the events at the Prancing Pony, written in pencil, the name of the innkeeper was 'Timothy Titus', a name from an old incomplete story by Tolkien (in which the character bore no resemblance to Mr. Butterbur). 'Timothy Titus' was written over in ink with the name 'Barnabas Butterbur' in Tolkien's manuscript and was created as a very fat Hobbit before he was subsequently changed into the man called 'Barliman'.</p>
<h4>Etymology</h4>
<p>Barliman means 'barley-man', a suitable name for an ale-brewer.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Barliman_Butterbur";
            ImageArtist = Artist.Owen_William_Weber;

            addFriend("Gandalf", "Gandalf");
            addFriend("Tom Bombadil");
            addFriend("Nob");
            addFriend("Bob");

            addGroup("Bree");

            DigitalCard("Barliman-Butterbur-Valor");
        }
    }
}