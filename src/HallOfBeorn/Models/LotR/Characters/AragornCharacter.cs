using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class AragornCharacter : Character
    {
        public AragornCharacter()
            : base("Aragorn", "Aragorn II Elessar", "Man")
        {
            Bio = "<p>Aragorn II, son of Arathorn is a fictional character from J. R. R. Tolkien's legendarium. He is one of the main protagonists of The Lord of the Rings. Aragorn was a Ranger of the North, first introduced with the name Strider at Bree, as the Hobbits continued to call him throughout The Lord of the Rings. He was eventually discovered to be the heir of Isildur and rightful claimant to the thrones of Arnor and Gondor. He was also a confidant of Gandalf and an integral part of the quest to destroy the One Ring and defeat the Dark Lord Sauron.</p><p>Aragorn led the Fellowship of the Ring following the loss of Gandalf in the Mines of Moria while fighting the Balrog. When the Fellowship was broken, he tracked the hobbits Meriadoc Brandybuck and Peregrin Took with the help of Legolas the elf and Gimli the dwarf to Fangorn Forest. Then he fought in the battle at Helm's Deep and the Battle of the Pelennor Fields. After defeating Sauron's forces in Gondor, he led an army of Gondor and Rohan against the Black Gate of Mordor to distract Sauron's attention so that Frodo Baggins and Samwise Gamgee could have a chance to destroy the One Ring.</p><p>At the end of The Lord of the Rings, Aragorn was crowned King Elessar Telcontar ('Elfstone Strider') of Gondor. He married Elrond's daughter, Arwen, and assumed the Sceptre of Annúminas as King of Arnor, uniting the two kingdoms for the first time since the reign of Isildur.</p>";

            TheFellowshipOfTheRing();
            TheTwoTowers();
            TheReturnOfTheKing();

            Alias("Heir of Valandil", "Heir-of-Valandil-TLR");
            Alias("The Dúnadan");
            Alias("Longshanks");
            Alias("Strider", "Strider-TDRu");
            Alias("Wingfoot", "Wingfoot-NiE");
            Alias("Telcontar");
            Alias("Elessar Telcontar");
            Alias("Envinyatar");
            Alias("Estel");
            Alias("Thorongil");

            Card("Aragorn-Core");
            Card("Aragorn-TWitW");
            Card("Aragorn-TLR");
            Card("Aragorn-ToS");
            Card("Aragorn-TLoS");
            Card("Aragorn-TFotW");
            Card("Aragorn-TMoF");
            Card("Aragorn-ToF");
            Card("Aragorn-FotBD");

            addFamily("Arathorn (Father)", string.Empty);
            addFamily("Arwen Undomiel (Wife)", "Arwen-Undomiel");
            addFamily("Elrond (Father-in-Law)", "Elrond");
            addFamily("Elladan (Brother-in-Law)", "Elladan");
            addFamily("Elrohir (Brother-in-Law)", "Elrohir");
        }
    }
}