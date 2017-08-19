using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class TheodenCharacter : Character
    {
        public TheodenCharacter()
            : base("Théoden", "Théoden, son of Thengel", "Man")
        {
            Bio =
@"<blockquote>
&ldquo;Out of doubt, out of dark, to the day's rising<br>
he rode singing in the sun, sword unsheathing.<br>
Hope he rekindled, and in hope ended;<br>
over death, over dread, over doom lifted<br>
out of loss, out of life, unto long glory.&rdquo;<br>
― Gléowine
</blockquote>
<p><b>Théoden</b> (Third Age 2948 – March 15, 3019, aged 71 years) was the seventeenth King of Rohan, ruling for 39 years, from T.A. 2980 until his death. He was the last of the Second Line.</p>
<h3>History</h3>
<h4>Early Life</h4>
<p>Théoden was the only son of Thengel, and became king after the death of his father in T.A. 2980. Théoden spoke Sindarin and Westron rather than Rohirric, for he had been born in Gondorand spent his youth there.</p>
<p>Théoden loved his sister Théodwyn most of all. After she and her husband both died he adopted her children Éomer and Éowyn as his own. He had a son, Théodred, whose mother Elfhild died in childbirth.</p>
<p>In T.A. 3014 Théoden's health began to fail. This may have been due to natural causes (he was sixty-six) or it may have been induced or increased by subtle poisons administered by Gríma. Gríma (or Wormtongue as most others in the Mark called him), was secretly in the employ of Saruman the White.</p>
<h4>War of the Ring</h4>
<p>As the war approached Théoden was increasingly misled by his chief adviser Gríma. In the last years before the War of the Ring, Théoden let his rule slip out of his hands completely, and Gríma became increasingly powerful. Rohan was troubled again by Orcs and Dunlendings, who operated under the will of Saruman, ruling from Isengard. On Gríma's orders Éomer had been arrested and imprisoned after Éomer's foray to destroy the Orcs that had crossed Rohan.</p>
<p>When Gandalf and Aragorn appeared before him, the Wizard healed the king. He then restored his nephew, took up his sword, and led the Riders of Rohan to the Fords of Isen.</p>
<p>On their way, they got news that the border was lost and he retreated into battle at Helm's Deep. After this he became known as Théoden Ednew, the Renewed,[1] because he had thrown off the yoke of Saruman.</p>
<p>After the battle he visited Isengard where he witnessed as Gandalf deposed Saruman from their order. On their way back to Rohan, they stopped by the Helm's Deep, where he noticed that the lonely Hobbit of their company, Meriadoc Brandybuck felt out of place, and offered to ride with him for the rest of the journey. The hobbit was delighted, as he felt useless among the Riders and offered Théoden his sword in service of Rohan.</p>
<p>Aragorn left the Rohirrim's company for Dunharrow, and Théoden and the Riders took a safer path to Edoras. Near the outer hills of Rohan, Théoden dismissed Éomer's urge not to go to the war, and with the remaining Riders he rode to the Hold at Dunharrow, where his people took shelter.</p>
<h4>Fulfilling the Oath of Eorl</h4>
<p>After reuniting with Éowyn and while resting, a Gondorian named Hirgon entered his tent, bringing the Red Arrow from Denethor II. Théoden responded to him that 6000 Riders would reach Minas Tirith in the week. Indeed they set off the next morning (the Dawnless Day); before leaving he ordered his squire, Meriadoc, to stay behind at Edoras.</p>
<p>On their way to Minas Tirith, Théoden's forces were alerted to a host of Orcs upon the road from the city moving towards them. A leader of the Woses, Ghân-buri-Ghân, offered to lead the Rohirrim by secret paths through the Drúadan Forest so they could avoid the Orcs. Taking the forgotten road down Stonewain Valley the riders of Rohan were able to come to the Pelennor Fields undetected.</p>
<p>To his dismay, they found Hirgon dead and understood that the Gondorians were unaware of their arrival; Minas Tirith was being destroyed. Théoden was reinvigorated by a sudden great flash of light from the city. He ordered to charge as the Darkness was fading. He led the Rohirrim to the aid of Gondor at the Battle of the Pelennor Fields. In that battle he challenged the Black Serpent of the Haradrim, and slew him and his standard-bearer.</p>
<p>The Lord of the Nazgûl attacked him, and he was mortally wounded when his horse Snowmane fell upon him after being frightened by the Ringwraith's Fell beast.</p>
<p>He was immediately avenged by Éowyn and the Hobbit Meriadoc Brandybuck, both of whom had ridden to war in secret. He claimed to Merry at his death on the field that he was satisfied, for he had felled the Black Serpent.</p>
<h4>Legacy</h4>
<p>After Théoden's death his body remained in the Hallows of Minas Tirith while Snowmane was buried where they fell.
His nephew Éomer succeeded him as King of Rohan. In July he returned to Minas Tirith and brought Théoden's body back to Edoras. On 10 August the funeral of Théoden took place. Gléowine composed a poem for him and other Kings of the line of Eorl.</p>
<h4>Etymology</h4>
<p>The Old English word þeoden, means 'lord, king', and contains the element þeod 'people' (éothéod 'horse-people'). It is related to the Old Norse word þjóðann, meaning 'Leader of the People' (i.e. 'King').</p>
<p>In Tolkien's fictional etymology, the name Théoden is an Old English translation of the original Rohirric Tûrac, an old word for King.</p>
<h4>Other Versions of the Legendarium</h4>
<p>In one of Tolkien's early drafts, Théoden also had a daughter by the name of Idis, but she was eventually removed when her character was eclipsed by that of Éowyn.</p>";

            BioSourceUrl = "http://tolkiengateway.net/wiki/Theoden";
            ImageArtist = Artist.Magali_Villeneuve;

            Alias("Tûrac");
            Alias("Ednew");
            Alias("Lord of the Mark");
            Alias("King of Rohan");

            addFamily("Thengel (Father)");
            addFamily("Morwen (Mother)");
            addFamily("Elfhild (Wife)");
            addFamily("Théodred (Son)", "Theodred");
            addFamily("Théodwyn (Sister)");
            addFamily("Éomund (Brother-in-Law)", "Eomund");
            addFamily("Éomer (Nephew)", "Eomer");
            addFamily("Éowyn (Niece)", "Eowyn");

            addFriend("Gríma", "Grima");
            addFriend("Gandalf", "Gandalf");
            addFriend("Háma", "Hama");
            addFriend("Merry", "Merry");

            addItem("Snowmane", "Snowmane-TLoS");
            addItem("Herugrim", "Herugrim-ToS");
            addItem("Golden Shield", "Golden-Shield-TFotW");

            addGroup("The Rohirrim", "The-Rohirrim");

            Card("Theoden-TMV");
            Card("Theoden-ToS");
        }
    }
}