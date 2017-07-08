using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class TheFellowshipOfTheRingCharacter : Character
    {
        public TheFellowshipOfTheRingCharacter()
            : base("The Fellowship", "The Fellowship of the Ring", string.Empty)
        {
            Bio =
@"<p>The Fellowship was formed at Rivendell in late T.A. 3018 following the Council of Elrond. It was decided that it should be a relatively small company; the number was set at nine to symbolically oppose the nine Nazgûl. In order of announcement the members of the Fellowship were:</p>
<table style='border-collapse:separate;border-spacing:0 10px;'>
<tr><th>Member</th><th>Race</th><th>Age</th><th>Notes</th></tr>
<tr><td>Frodo Baggins</td><td>Hobbit</td><td>50</td><td>Adopted heir of Bilbo and the Ring-bearer.</td></tr>
<tr><td>Samwise 'Sam' Gamgee</td><td>Hobbit</td><td>38</td><td>Frodo's gardener; becomes Frodo's companion on the quest.</td></tr>
<tr><td>Gandalf the Grey</td><td>Istari</td><td>primeval</td><td>Wizard who leads the Fellowship until the Bridge of Khazad-dûm in Moria, where he falls in combat with a Balrog.</td></tr>
<tr><td>Legolas</td><td>Elf</td><td>500+</td><td>Son of Thranduil, king of the Silvan Elves of Mirkwood. He came to inform Elrond of the escape of Gollum.</td></tr>
<tr><td>Gimli</td><td>Dwarf</td><td>139</td><td>Son of Glóin. He came to Rivendell from the Lonely Mountain with his father to seek advice on the disappearance of Balin, and to warn Bilbo that Sauron's agents are seeking him.</td></tr>
<tr><td>Aragorn (Strider)</td><td>Man</td><td>87</td><td>Chief Ranger of the North and heir of Isildur and Elendil; he had accompanied the hobbits from Bree to Rivendell.</td></tr>
<tr><td>Boromir</td><td>Man</td><td>40</td><td>Son and heir of Denethor II, Steward of Gondor. He came to Rivendell seeking the meaning of a prophetic dream.</td></tr>
<tr><td>Meriadoc 'Merry' Brandybuck</td><td>Hobbit</td><td>36</td><td>Son and heir of the Master of Buckland, cousin to both Pippin and Frodo. He is particularly close to Pippin.</td></tr>
<tr><td>Peregrin 'Pippin' Took</td><td>Hobbit</td><td>28</td><td>Son and heir of the Thain in Tookland, he is the youngest member of the group and cousin to both Merry and Frodo.</td></tr>
</table>
<p>In The Lord of the Rings, Tolkien speaks more often of the 'Company' of the Ring rather than the 'Fellowship', as reflected in the page references in Robert Foster's The Complete Guide to Middle-earth. However, as it appears in the title of the book, 'Fellowship' has become the familiar term.</p>";
            
            BioSourceUrl = "https://en.wikipedia.org/wiki/The_Fellowship_of_the_Ring#Members_of_the_Fellowship_of_the_Ring";
            ImageArtist = Artist.Michael_Komarck;

            Alias("The Company of the Ring");
            Alias("The Nine Walkers");
            
            addMember("Frodo Baggins", "Frodo-Baggins");
            addMember("Sam Gamgee", "Sam-Gamgee");
            addMember("Gandalf", "Gandalf");
            addMember("Legolas", "Legolas");
            addMember("Gimli", "Gimli");
            addMember("Aragorn", "Aragorn");
            addMember("Boromir", "Boromir");
            addMember("Merry", "Merry");
            addMember("Pippin", "Pippin");

            Card("Fellowship-of-the-Ring-RD");
        }
    }
}