using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class EomerCharacter : Character
    {
        public EomerCharacter()
            : base("Éomer", "Éomer, son of Éomund", "Man")
        {
            Bio =
@"<p>Éomer is a fictional character in J. R. R. Tolkien's legendarium. He appears in The Two Towers and The Return of the King, the second and third volumes of Tolkien's fantasy novel The Lord of the Rings.</p>
<p>The name Éomer, literally translating to 'Horse-famous', can be found in Beowulf, an Anglo-Saxon poem Tolkien had studied extensively and drew from while creating his characters.</p>
<p>The son of Théodwyn and Éomund, belonging to the House of Eorl, Éomer is the third Marshal of the Riddermark at the start of the Lord of the Rings. Both he and his sister, Éowyn, were adopted by their uncle Théoden, king of the Rohirrim, after their parents' death. His first appearance in the story is in The Two Towers, as the leader of the éored who attacked and killed the Uruk-hai who had kidnapped the Hobbits Meriadoc Brandybuck and Peregrin Took as they camped near Fangorn forest. He helps Aragorn, Gimli and Legolas by providing them two horses, Hasufel and Arod, and guiding them to the spot where the attack had taken place.</p>
<p>On his return to Edoras, Éomer reports to Théoden on his meeting the Ranger and his friends, and is promptly imprisoned on the orders of Gríma Wormtongue, Théoden's sinister advisor, who was keeping the king in a sickly stupor on the orders of the wizard Saruman. Soon thereafter, Aragorn, Gimli and Legolas arrive in Edoras themselves with Gandalf the White, another powerful wizard, who releases the king from Gríma's spell. Éomer is released and restored in honour, in which role he contributes to success at the battle of the Hornburg, where he and his éored, led by Théoden and Aragorn, drive Saruman's army of Orcs and Dunlendings from the walls of the Hornburg, buying valuable time for Gandalf's reinforcements to arrive.</p>
<p>Éomer has a major role in the Battle of the Pelennor Fields, the pivotal battle of The Return of the King. After fighting bravely for Rohan and Gondor, he is dismayed to find Théoden mortally wounded in the battle. Théoden appoints him King of Rohan with his dying breath. Then, seeing an unconscious Eowyn seemingly dead on the battlefield, Éomer decides to throw himself and the remaining Rohirrim at the enemy, all the while cries of 'Death!' have replaced the traditional songs of slaying with which the Rohirrim had initially entered the battle. Aragorn saves them when he arrives unexpectedly from Pelargir, fulfilling his prediction that they would fight together again. Aragorn's arrival and reinforcements provoke a rout among the Orcs, and he and Éomer win the battle. Aragorn's healing hands later restore Éowyn to perfect health.</p>
<p>At the climax of The Return of the King, Éomer accompanies Aragorn to the Gates of Mordor for the final stand against Sauron, distracting him long enough for the One Ring to be destroyed in Mount Doom, leading to Sauron's downfall. After Théoden's funeral, he stays on in Minas Tirith to help Aragorn, now crowned King Elessar of the Reunited Kingdom, rebuild his kingdom.</p>
<p>Éomer had met Princess Lothíriel of Dol Amroth, during his stay in Gondor, and they were soon wed. She bore him a son named Elfwine, known as 'Elfwine the Fair'.</p>
<p>Éomer's sword was called Gúthwinë (Old English: gūð wine, 'battle friend'), and was a gift from his father, Éomund.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/%C3%89omer";
            ImageArtist = Artist.Magali_Villeneuve;

            TheTwoTowers();
            TheReturnOfTheKing();

            Alias("Éadig");
            Alias("Third Marshal of the Riddermark");
            Alias("King of Rohan");

            addFamily("Éomund (Father)", "Eomund");
            addFamily("Théodwyn (Mother)");
            addFamily("Lothíriel (Wife)");
            addFamily("Éowyn (Sister)", "Eowyn");
            addFamily("Théoden (Uncle)", "Theoden");
            addFamily("Théodred (Cousin)", "Theodred");

            addGroup("The Rohirrim", "The-Rohirrim");

            addItem("Firefoot", "Firefoot-TDT");
            addItem("Gúthwinë", "Guthwine-TMoF");

            Card("Eomer-VoI");
            Card("Eomer-TMoF");
        }
    }
}