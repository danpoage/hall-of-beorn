using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class BifurCharacter : Character
    {
        public BifurCharacter()
            : base("Bifur", "Bifur", "Dwarf")
        {
            Bio = "<p>Bifur was one of the twelve companions of Thorin and Bilbo on the Quest of Erebor. Like other members of the company, his name comes directly from the Old Norse poem 'Völuspá', part of the Poetic Edda. The forefathers of Bifur and his cousins Bofur and Bombur, who unlike the rest of Thorin's company are not of the royal line of Durin, come from Moria. Bifur was fond of raspberry jam and apple-tart at the unexpected party in Bag End, where he wore a yellow hood and played the clarinet. He gave the trolls quite a fight before getting sacked and helped trying to rescue Bilbo, and was set down uncomfortably near the fire as a reward. In The Fellowship of the Ring Glóin tells Frodo that Bifur and his cousins were all alive and well before the Council of Elrond.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Middle-earth_dwarf_characters#Bifur";
            ImageArtist = Artist.Magali_Villeneuve;

            addFamily("Bofur (Cousin)", "Bofur");
            addFamily("Bombur (Cousin)", "Bombur");

            addFriend("Thorin Oakenshield", "Thorin-Oakenshield");
            addFriend("Glóin", "Gloin");

            addGroup("Thorin's Company", "Thorin's-Company");

            Card("Bifur-KD");
            Card("Bifur-THOtD");
        }
    }
}