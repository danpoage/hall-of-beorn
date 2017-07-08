using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class ElrohirCharacter : Character
    {
        public ElrohirCharacter()
            : base("Elrohir", "Elrohir", "Half-elven")
        {
                        Bio =
@"<p>Born in Third Age, 130, they have one younger sister, Arwen. Though Tolkien never specifically states that Elrohir and Elladan were twins, many clues were given to prove this possibility. First, they are described as being so similar that 'few could tell them apart: dark-haired, grey-eyed, and their faces elven-fair, clad alike in bright mail beneath cloaks of silver-grey'.[1] Second, one is rarely mentioned without the other and their names are only separated when they are speaking. Third, they were born in the same year, while most Elves wait at least ten years between children.[2] We are not told which brother is older.</p>
<p>The brothers were friends and companions-in-arms of the Rangers of the North, and helped defend the remnants of Arnor from evil after the fracturing and fall of the Northern Kingdom. Five centuries before the War of the Ring, Celebrían was captured by Orcs and tortured. Elladan and Elrohir rescued her and their father healed her wounds, but she lost all joy and departed Middle-earth. Ever since, they held a special grudge against the Orcs because of their mother's suffering at the Orcs' hands. During the War of the Ring, they fought alongside Aragorn in the battle of the Pelennor Fields in Gondor.</p>
<p>Like their sister and father, the brothers were faced with a choice between mortality and immortality, expressed by whether they would follow their father to Valinor at the time of his own departure at the end of the Third Age. As the brothers are explicitly described as remaining in Rivendell for a time with Celeborn after their father's departure, it is believed that they may also have chosen to live life as mortal men. However, Tolkien never wrote what their choices were, but noted that they were allowed to 'delay' their choices.[3] Others believe they chose to be immortal, perhaps as they are never described as marrying a mortal, in contrast to their sister Arwen which forced her to choose mortality. In Appendix A of The Lord of The Rings, (Part V: Here Follows a Part of the Tale of Aragorn and Arwen), it is expressly spoken by Aragorn 'the hour is indeed hard, yet it was made even in that day when we met under the white birches in the garden of Elrond where none now walk'. As Arwen's brothers are not mentioned in her leave-taking from Minas Tirith in this same Tale and clearly were then permanently not in Rivendell, it would suggest that they did indeed follow their father across the sea, perhaps accompanied by their grandfather, Celeborn. However, many other options exist which could still involve either choice, such as a role in supporting the Northern Kingdom of Arnor as regents. But it is the very ambiguity and lack of mention of such details for which Tolkien is well known, and it is this which lends pathos and romance to the bigger picture. Thus the reader's brief contact with these brethren with such little definition and detail about their future life is consistent with Tolkien's intentions</p>";

            BioSourceUrl = "https://en.wikipedia.org/wiki/Elladan_and_Elrohir";
            ImageArtist = Artist.Magali_Villeneuve;

            TheFellowshipOfTheRing();
            TheReturnOfTheKing();

            addFamily("Elrond (Father)", "Elrond");
            addFamily("Elladan (Brother)", "Elladan");
            addFamily("Arwen Undómiel (Sister)", "Arwen-Undomiel");
            addFamily("Aragorn (Brother-in-Law)", "Aragorn");
            
            Card("Elrohir-TRG");
            Card("Elrohir-TMoF");
        }
    }
}