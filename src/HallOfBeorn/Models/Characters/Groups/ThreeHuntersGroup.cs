namespace HallOfBeorn.Models.Characters.Groups
{
    public class ThreeHuntersGroup
        : CharacterGroup
    {
        public ThreeHuntersGroup()
            : base("Three Hunters", "Three Hunters")
        {
            Bio = 
@"<blockquote>
&ldquo;With hope or without hope we will follow the trail of our enemies. And woe to them, if we prove the swifter! We will make such a chase as shall be accounted a marvel among the Three Kindreds: Elves, Dwarves, and Men. Forth the Three Hunters!&rdquo;
<br>― Aragorn in The Two Towers, &ldquo;The Departure of Boromir&rdquo;
</blockquote>
<p>The &ldquo;Three Hunters&rdquo; was the name Aragorn gave to himself, Legolas, and Gimli as they began pursuing the Uruk-hai who had captured Meriadoc Brandybuck and Peregrin Took by Nen Hithoel at the Breaking of the Fellowship.</p>
<h4>History</h4>
<p>The Three Hunters set out from Nen Hithoel on the evening of 26 February T.A. 3019. With Aragorn's tracking skill, they followed the Uruks' trail through the night across the Emyn Muil, where they found five dead Orcs who Aragorn guessed had been killed by their own company. At dawn, they reached the East Wall of Rohan and descended into the Eastemnet. There, Aragorn found Pippin's Elven brooch, which the hobbit had dropped as a sign to whomever of the fellowship might follow them.</p>
<p>The companions continued swiftly across the plains of Rohan till nightfall, when they faced the dilemma of losing the trail in the dark or losing time by waiting for morning. Troubled by doubt, Aragorn chose to rest for the night. When they rose, they found the Uruks had gained much distance on them. They tirelessly pursued their quarry north-westward the rest of that day, but felt the will of Saruman slowing them down and giving speed to the Uruks. They slept another night and marched another day, growing weary and losing hope.</p>
<p>The next day, on 30 February[1], they encountered Éomer and his éored, who were returning to Edoras after slaughtering the Orc-band outside Fangorn Forest the day before. Suspicious of the travellers, Éomer questioned them sternly and almost came to blows with Gimli and Legolas. Aragorn intervened, and gave Éomer an account of their journey, including the capture of the two hobbits and the passing of Gandalf and Boromir. When Aragorn recounted their pursuit, Éomer remarked with awe that they had travelled forty-five leagues[note 1] in fewer than four days, and gave Aragorn the title Wingfoot. Éomer told them about Rohan's troubles and requested their help, but Aragorn refused to desert Merry and Pippin while hope of finding them remained. Acting against Rohan's law by letting strangers wander the land without the king's consent, Éomer lent them two horses, Hasufel and Arod, and asked them to prove his trust by bringing them back to Edoras.</p>
<p>With their horses, the Three Hunters reached the eaves of Fangorn at evening. Finding no trace of the hobbits before dark, they camped there to wait for daylight. During the night they encountered an old man who vanished as soon as Aragorn approached him, and they discovered their horses missing also. The next morning, on 1 March[1], they found signs of the hobbits that led them into Fangorn, where they met Gandalf the White. Gandalf shared news and insight with them, among which was that the hobbits were safe with Treebeard. The three companions discovered that Hasufel and Arod met Gandalf's horse Shadowfax in the night, and they rode with Gandalf to the aid of Rohan at Edoras.</p>
<p>Later, after the Battle of the Hornburg and the Ents' destruction of Isengard, the Three Hunters, in the company of Gandalf and the Rohirrim, reunited with Merry and Pippin at Isengard on 5 March.[1] The Fellowship's paths diverged afterwards, but Aragorn, Legolas, and Gimli remained constant companions to the end of the War of the Ring.</p>";

            BioSourceUrl = "http://tolkiengateway.net/wiki/Three_Hunters";
            ImageArtist = Artist.Nicholas_Gregory;

            addLeader("Aragorn", "Aragorn");

            addMember("Legolas", "Legolas");
            addMember("Gimli", "Gimli");

            addFriend("Merry", "Merry");
            addFriend("Pippin", "Pippin");

            LotRCard("Forth-the-Three-Hunters-TCoU");
            LotRCard("The-Three-Hunters-ToS");
        }
    }
}
