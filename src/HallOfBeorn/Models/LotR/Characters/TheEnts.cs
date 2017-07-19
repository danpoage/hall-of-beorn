using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class TheEnts : Character
    {
        public TheEnts()
            : base("The Ents", "The Ents", string.Empty)
        {
            Bio =
@"<p>Ents are a race of beings in J. R. R. Tolkien's fantasy world Middle-earth who closely resemble trees. They are similar to the talking trees in folklore around the world. Their name is derived from the Anglo-Saxon word for giant.</p>
<p>The Ents appear in The Lord of the Rings as ancient shepherds of the forest and allies of the free peoples of Middle-earth during the War of the Ring. The Ent who figures most prominently in the book is Treebeard, who (credibly) claims to be the oldest creature in Middle-earth. At the time The Lord of the Rings takes place, there are no young Ents (Entings) because the Entwives (female Ents) were lost. The Ents are akin to Huorns, whom Treebeard describes as a transitional form of trees which become animated or, conversely, as Ents who grow more 'treelike' over time.</p>
<p>Inspired by Tolkien and similar traditions, animated or anthropomorphic tree creatures appear in a variety of media and works of fantasy.</p>
<p>The word 'Ent' was taken from the Anglo-Saxon (Old English) word ent, meaning 'giant'. Tolkien borrowed the word from the Anglo-Saxon phrases orþanc enta geweorc ('work of cunning giants') and eald enta geweorc ('old work of giants', which describes Roman ruins). In this sense, Ents are probably the most ubiquitous of all creatures in fantasy and folklore, perhaps second only to dragons, for the word can refer to a variety of large, roughly humanoid creatures, such as giants, trolls, or even the monster Grendel from the poem Beowulf.</p>
<p>Along with Old Norse jǫtunn (Jötunn), 'ent' came from Common Germanic *etunaz.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Ent";

            addLeader("Treebeard", "Treebeard");
        }
    }
}