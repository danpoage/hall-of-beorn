using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class BardTheBowmanCharacter : Character
    {
        public BardTheBowmanCharacter()
            : base("Bard the Bowman", "Bard The Bowman", "Man")
        {
            Bio =
@"<p>Bard the Bowman (died Third Age 2977), was a man of Lake-town, and later the restored King of Dale.</p>
<h4>History</h4>
<p>Bard served as a soldier in Lake-town, and was one of the most skilled archers among Men. He was the heir of Girion, the last lord of Dale. Noted for his grim face and spirit, he was an able archer and inherited his Black Arrow from his ancestors. Considering it a lucky heirloom, he always used it last.</p>
<p>Bard organized the defense of the town when the Dragon Smaug attacked. When the old thrush (who had overheard Bilbo Baggins' description of Smaug) revealed an unarmoured spot on the Dragon's underside to Bard, he shot the dragon's heart with the Black Arrow. Because of his miraculous shot he was given the epithet 'the Bowman' and 'the Dragon-slayer'.</p>
<p>After the disaster, he led the Lake-men to the Lonely Mountain demanding a part of the treasure from the Dwarves. The Wood-elves and Thranduil came to demand their own shares. Seeing Thorin's reluctancy to help, Bilbo Baggins delivered the Arkenstone to them to bargain with. Afterwards, when the Orcs and Wargs came, Bard led his Men in the Battle of Five Armies.</p>
<p>The victors divided the treasure and Bard took Bilbo's fourteenth share of the gold and silver in return for the Arkenstone, whereupon he shared his reward with the Master of Lake-town to rebuild the town, and gave Thranduil the emeralds of Girion. However, the Master stole the money and ran off into the wild where he died.</p>
<p>Three years later, after the rebuilding of the city, Bard became the first King of restored Dale as a wise and able ruler. He was succeeded by his son, Bain.</p>
<h4>Etymology</h4>
<p>As a Lake-man, Bard's name was in the language of Dale, which is represented by Old Norse in the book. In other Germanic names (such as Isembard), bard refers to beard. This could be either the facial hair, or more likely 'Battle-Axe' (beard is also a term for a part of an axe).</p>
<p>Robert Ireland and Ruth S. Noel, who perhaps overlooked the connection to Old Norse, provide as translations the Celtic words, bárd ('guardian') and bard ('poet').</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Bard";
            ImageArtist = Artist.Magali_Villeneuve;

            Alias("King of Dale");
            Alias("The Dragon-slayer");

            addFamily("Bain (Son)");
            addFamily("Brand (Grandson)", "Brand-son-of-Bain");

            addFriend("Bilbo Baggins", "Bilbo-Baggins");

            addItem("Great Yew Bow", "Great-Yew-Bow-THOtD");
            addItem("Black Arrow", "Black-Arrow-THOtD");
        }
    }
}