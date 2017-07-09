using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class SamGamgeeCharacter : Character
    {
        public SamGamgeeCharacter()
            : base("Sam Gamgee", "Samwise Gamgee", "Hobbit")
        {
            Bio =
@"<p>Samwise 'Sam' Gamgee /ˈsæmˌwaɪz ˈɡæmˌdʒiː/ (later known as Samwise Gardner)[1] is a fictional character in J. R. R. Tolkien's legendarium. Samwise is one of the main characters of The Lord of the Rings, in which he fills an archetypical role as the sidekick of the primary protagonist, Frodo Baggins. Sam is a member of the Fellowship of the Ring.</p>
<p>At the beginning of the story, Sam is Frodo's gardner, and is drawn into Frodo's adventure by Gandalf while eavesdropping on a private conversation. Throughout the story, Sam is Frodo's steadfast companion, portrayed as both physically and emotionally strong, often pushing Frodo through difficult parts of the journey, and at times physically carrying him when Frodo was too weak to go on. Sam even serves as ring-bearer for a short time when Frodo is captured; Sam's emotional strength is again on display as he willingly gives the ring up when Frodo is capable of carrying it again, the only character besides Bilbo Baggins known to resist its pull. Following the War of the Ring Sam returned to the Shire, and returned to his role as gardener, helping to replant the trees which had been destroyed during The Scouring of the Shire. He was elected Mayor of the Shire for seven consecutive terms, and in his old age was one of the last denizens of Middle Earth to be transported to The Undying Lands, an honor accorded to him as one of the ring-bearers.</p>";
            BioSourceUrl = "";
            ImageArtist = Artist.Magali_Villeneuve;

            Alias("Samwise Gardner");

            addFamily("Gaffer Gamgee (Father)");

            addGroup("The Fellowship", "The-Fellowship");

            addFriend("Frodo Baggins", "Frodo-Baggins");
            addFriendCard("Bill the Pony", "Bill-the-Pony-TBR");

            addItem("Lórien Rope", "Lorien-Rope-RD");

            Card("Sam-Gamgee-TBR");
            Card("Sam-Gamgee-TTiTD");
        }
    }
}