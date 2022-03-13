using System;

namespace HallOfBeorn.Models.LotR.Sets.StarterDeck
{
    public class ElvesOfLorienSet
        : CardSet
    {
        public const string setName = "Elves of Lórien";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "EoL";
            SetType = Models.SetType.Starter_Deck;
            Cycle = "Starter Deck";
            Number = 5004;

            addHero("Celeborn", 11, Sphere.Leadership, 3, 2, 2, 4)
                .WithTraits("Silvan.", "Noble.")
                .WithTextLine("Response: After a Silvan ally enters play, that ally gets +1 Willpower, +1 Attack and +1 Defense until the end of the round.")
                .WithFlavorLine("\"...the lord of the Galadhrim is accounted wisest of the Elves of Middle-earth, and a giver of gifts beyond the power of kings.\" -Galadriel, The Fellowship of the Ring")
                .WithCommunityVersion("RiddermarkLord/Celeborn-1")
                .WithCommunityVersion("RiddermarkLord/Celeborn-2")
                .WithAges(Age.First_Age, Age.Second_Age, Age.Third_Age)
                .WithInfo(1, 1, Artist.Magali_Villeneuve);
            addHero("Galadriel", 9, Sphere.Spirit, 4, 0, 0, 4)
                .WithTraits("Noldor.", "Noble.")
                .WithTextLine("Galadriel cannot quest, attack, or defend. Allies you control do not exhaust to commit to the quest during the round they enter play.")
                .WithTextLine("Action: Exhaust Galadriel to choose a player. That player reduces his threat by 1 and draws 1 card. (Limit once per round.)")
                .WithCommunityVersion("Galadriel-Grey-Company-Gen-Con-2015")
                .WithCommunityVersion("Galadriel-Whispers-in-the-Trees")
                .WithCommunityVersion("Galadriel-Nouveau-Hunters")
                .WithCommunityVersion("RiddermarkLord/Galadriel-Spirit-Hero-1")
                .WithCommunityVersion("RiddermarkLord/Galadriel-Spirit-Hero-2")
                .WithCommunityVersion("Hrodebert/Galadriel-Spirit-Hero-1")
                .WithCommunityVersion("Hrodebert/Galadriel-Spirit-Hero-2")
                .WithAges(Age.First_Age, Age.Second_Age, Age.Third_Age)
                .WithInfo(2, 1, Artist.Magali_Villeneuve);
            addHero("Haldir of Lórien", 9, Sphere.Lore, 2, 3, 1, 3)
                .WithTraits("Silvan.", "Ranger.", "Scout.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Combat Action: If you have not engaged an enemy this round, exhaust Haldir of Lórien to declare him as an attacker (and resolve his attack) against an enemy not engaged with you. Limit once per round.")
                .WithFlavorLine("\"We allow no strangers to spy out the secrets of the Naith...\"")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithCommunityVersion("RiddermarkLord/Haldir-of-Lorien-Lore-Hero-1")
                .WithInfo(3, 1, Artist.Sebastian_Giacobino);
            addAlly("Defender of the Naith", 3, Sphere.Neutral, false, 0, 1, 2, 2)
                .WithTraits("Silvan.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Response: After a Silvan ally you control leaves play, ready Defender of the Naith.")
                .WithFlavorLine("\"We have been keeping watch on the rivers, ever since we saw a great troop of Orcs going North toward Moria...\" -Haldir, The Fellowship of the Ring")
                .WithInfo(4, 3, Artist.Christine_Griffin);
            addAlly("Galadhrim Minstrel", 2, Sphere.Lore, false, 1, 0, 0, 1)
                .WithTraits("Silvan.", "Minstrel.")
                .WithTextLine("Response: After Galadhrim Minstrel enters play, search the top five cards of your deck for an event card and add it to your hand. Shuffle the other cards back into your deck.")
                .WithFlavorLine("...the language was that of Elven-song and spoke of things little known on Middle-earth. -The Fellowship of the Ring")
                .WithInfo(5, 3, Artist.Arden_Beckwith);            
            addAlly("Galadriel's Handmaiden", 2, Sphere.Spirit, false, 2, 0, 1, 1)
                .WithTraits("Silvan.")
                .WithTextLine("Response: After Galadriel's Handmaiden enters play, choose a player. That player reduces his threat by 1.")
                .WithFlavorLine("Her maidens stood silent about her, and a while she looked upon her guests. -The Fellowship of the Ring")
                .WithInfo(6, 3, Artist.Nathalia_Gomes);
            addAlly("Gandalf", 5, Sphere.Neutral, true, 4, 4, 4, 4)
                .WithTraits("Istari.")
                .WithTextLine("At the end of the round, discard Gandalf from play.")
                .WithTextLine("Response: After Gandalf enters play, (choose 1): draw 3 cards, deal 4 damage to 1 enemy in play, or reduce your threat by 5.")
                .WithCommunityVersion("Gandalf-Core-Set-Completion")
                .WithInfo(7, 2, Artist.Lucas_Graciano);
            addAlly("Greenwood Archer", 2, Sphere.Leadership, false, 0, 2, 0, 1)
                .WithTraits("Silvan.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Response: After Greenwood Archer enters play, ready a hero.")
                .WithFlavorLine("They dwelt most often by the edges of the woods, from which they could escape at times to hunt...")
                .WithFlavorLine("-The Hobbit")
                .WithTemplate("<p class='main-text'>{keyword:Ranged.}</p><p class='main-text'><b>Response:</b> After {self} enters play, ready a hero.</p><p class='flavor-text'>They dwelt most often by the edges of the woods, from which they could escape at times to hunt...<br>&ndash;The Hobbit</p>")
                .WithInfo(8, 3, Artist.Tawny_Fritzinger);
            addAlly("Henamarth Riversong", 1, Sphere.Lore, true, 1, 1, 0, 1)
                .WithTraits("Silvan.")
                .WithTextLine("Action: Exhaust Henamarth Riversong to look at the top card of the encounter deck.")
                .WithFlavorLine("\"And I reckon there's Elves and Elves. They're all elvish enough, but they're not all the same.\"")
                .WithFlavorLine("-Sam Gamgee,")
                .WithFlavorLine("The Fellowship of the Ring")
                .WithInfo(9, 2, Artist.Jen_Zee);
            addAlly("Mirkwood Runner", 3, Sphere.Lore, false, 1, 2, 0, 2)
                .WithTraits("Silvan.", "Scout.")
                .WithTextLine("While Mirkwood Runner is attacking alone, the defending enemy does not count its Defense.")
                .WithFlavor("\"...let a ploughman plough, but choose an otter for swimming, and for running light over grass and leaf or over snow-an Elf.\" -Legolas, The Fellowship of the Ring")
                .WithTemplate("<p>While {self} is attacking alone, the defending enemy does not count its {Defense}.</p><p class='flavor-text-smaller'>&quot;...let a ploughman plough, but choose an otter for swimming, and for running light over grass and leaf or over snow-an Elf.&quot;<br>&ndash;Legolas, The Fellowship of the Ring</p>")
                .WithInfo(10, 3, Artist.Magali_Villeneuve);
            addAlly("Naith Guide", 2, Sphere.Leadership, false, 1, 1, 0, 1)
                .WithTraits("Silvan.", "Scout.")
                .WithTextLine("Response: After Naith Guide enters play, choose a hero. That hero does not exhaust to quest this round.")
                .WithFlavorLine("\"...I shall lead you well...\" -Haldir, The Fellowship of the Ring")
                .WithInfo(11, 3, Artist.Magali_Villeneuve);
            addAlly("Orophin", 3, Sphere.Leadership, true, 2, 2, 0, 2)
                .WithTraits("Silvan.", "Scout.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Response: After Orophin enters play, return a Silvan ally from your discard pile to your hand.")
                .WithFlavorLine("\"Orophin has now gone in haste back to our dwellings to warn our people.\"")
                .WithFlavorLine("-Haldir, The Fellowship of the Ring")
                .WithCommunityVersion("RiddermarkLord/Orophin-MotK-Leadership-Hero")
                .WithInfo(12, 3, Artist.Magali_Villeneuve);
            addAlly("Silvan Refugee", 1, Sphere.Spirit, false, 2, 0, 0, 1)
                .WithTraits("Silvan.", "Scout.")
                .WithTextLine("Forced: After a character leaves play, discard Silvan Refugee from play.")
                .WithFlavorLine("\"The Elves have their own labours and their own sorrows...\" -Gildor, The Fellowship of the Ring")
                .WithTemplate("<p><b>Forced:</b> After a character leaves play, discard {self} from play.</p><p class='flavor-text'>&quot;The Elves have their own labours and their own sorrows...&quot;<br/>&ndash;Gildor, The Fellowship of the Ring</p>")
                .WithErrata(1)
                .WithInfo(13, 3, Artist.Lorraine_Schleter);
            addAlly("Silvan Tracker", 3, Sphere.Lore, false, 1, 1, 1, 3)
                .WithTraits("Silvan.")
                .WithTextLine("Response: After a Silvan character readies during the refresh phase, heal 1 damage from that character.")
                .WithFlavor("\"The Wood-elves tracked him first, an easy task for them, for his trail was still fresh then.\" -Gandalf, The Fellowship of the Rings")
                .WithInfo(14, 3, Artist.Magali_Villeneuve);
            addAttachment("Lembas", 1, Sphere.Lore, false)
                .WithTraits("Item.")
                .WithTextLine("Play only if you control a Noldor or Silvan hero. Attach to a hero.")
                .WithTextLine("Action: Discard Lembas to ready attached hero and heal 3 damage from it.")
                .WithFlavorLine("\"...it is more strengthing than any food made by Men, and it is more pleasant than cram, by all accounts. -Lórien Elf, The Fellowship of the Ring")
                .WithInfo(15, 3, Artist.Sara_Biddle);
            addAttachment("Nenya", 1, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Ring.")
                .WithTextLine("Attach to Galadriel. She gains a Lore resource icon.")
                .WithTextLine("Quest Action: Exhaust Nenya and Galadriel to add her Willpower to another character's Willpower until the end of the phase.")
                .WithFlavorLine("\"The is Nenya, the Ring of Adamant, and I am its keeper.\" -Galadriel, The Fellowship of the Ring")
                .WithAges(Age.Second_Age, Age.Third_Age)
                .WithInfo(16, 3, Artist.Mike_Nash);
            addAttachment("O Lórien!", 1, Sphere.Leadership, true)
                .WithTraits("Song.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Action: Exhaust O Lorien! to lower the cost of the next Silvan ally played this phase by 1 (to a minimum of 1).")
                .WithFlavorLine("\"I sang of leaves, of leaves of gold, and")
                .WithFlavorLine("leaves of gold there grew:")
                .WithFlavorLine("Of wind I sang, a wind there came and in the")
                .WithFlavorLine("branches blew.\" -Galadriel, The Fellowship of the Ring")
                .WithInfo(17, 3, Artist.Carolina_Eade);
            addAttachment("Wingfoot", 1, Sphere.Lore, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a Ranger hero.")
                .WithTextLine("Response: After attached hero commits to a quest, name enemy, location or treachery. If a card of the named type is revealed during this quest phase, exhaust Wingfoot to ready attached hero.")
                .WithFlavorLine("\"Wingfoot I name you. This deed of the three friends should be sung in many a hall. Forty leagues and five you have measured ere the forth day is ended!\"")
                .WithFlavorLine("-Éomer, The Two Towers")
                .WithErrata(1)
                .WithInfo(18, 3, Artist.Gabriel_Verdon);
            addEvent("A Test of Will", 1, Sphere.Spirit)
                .WithTextLine("Response: Cancel the 'when revealed' effects of a card that was just revealed from the encounter deck.")
                .WithFlavor("\"There is naught that you can do, other than to resist, with hope or without it\"\r\n-Elrond, The Fellowship of the Ring")
                .WithTemplate("<p><b>Response:</b> Cancel the &ldquo;when revealed&rdquo; effects of a card that was just revealed from the encounter deck.</p><p class='flavor-text'>&quot;There is naught that you can do, other than to resist, with hope or without it&quot;<br>&ndash;Elrond, The Fellowship of the Ring</p>")
                .WithCommunityVersion("A-Test-of-Will-Core-Set-Completion")
                .WithCommunityVersion("A-Test-of-Will-Nouveau-Hunters")
                .WithCommunityVersion("Autumn/Test-of-Will")
                .WithInfo(19, 2, Artist.Ryan_Barger);
            addEvent("Daeron's Runes", 0, Sphere.Lore)
                .WithTextLine("Action: Draw 2 cards. Then, discard 1 card from your hand.")
                .WithFlavorLine("\"These are Daeron's Runes, such as were used of old in Moria...\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithInfo(20, 3, Artist.Carolina_Eade);            
            addEvent("Elrond's Counsel", 0, Sphere.Spirit)
                .WithTextLine("Action: If you control a unique Noldor character, give another character +1 Willpower until the end of the phase and lower your threat by 3.")
                .WithTemplate("<p><b>Action:</b> If you control a {unique-trait-character:Noldor.@Noldor}, give another character +1 {Willpower} until the end of the phase and lower your threat by 3.</p><p class='flavor-text'>&quot;Believe rather that it is so ordered that we, who sit here, and none others, must now find counsel for the peril of the world.&quot;<br>&ndash;Elrond, The Fellowship of the Ring</p>")
                .WithInfo(21, 3, Artist.Anthony_Palumbo);
            addEvent("Feigned Voices", 0, Sphere.Leadership)
                .WithTextLine("Combat Action: Return a Silvan ally you control to your hand to choose an enemy engaged with a player. That enemy cannot attack that player this phase.")
                .WithFlavorLine("\"The three of us could not challenge a hundred, so we went ahead and spoke with feigned voices, leading them on into the wood.\" -Haldir, The Fellowship of the Ring")
                .WithInfo(22, 3, Artist.Sara_Betsy);
            addEvent("Host of Galadhrim", 4, Sphere.Neutral)
                .WithTextLine("Planning Action: Return each Silvan ally you control to your hand. Then, play each of those allies from your hand one at a time at no cost.")
                .WithFlavorLine("Celeborn came forth and led the host of Lórien...")
                .WithFlavorLine("-The Return of the King")
                .WithCommunityVersion("Autumn/Host-of-Galadhrim")
                .WithInfo(23, 3, Artist.Leanna_Crossan);
            addEvent("The Tree People", 0, Sphere.Lore)
                .WithTextLine("Action: Return a Silvan ally you control to your hand to search the top 5 cards of your deck for a Silvan ally. Put that ally into play and shuffle the other cards back into your deck. You can only play 1 copy of The Tree People each phase.")
                .WithFlavorLine("No folk could they see, nor hear any feet upon the paths; but there were many voices, about them, and in the air above. –The Fellowship of the Ring")
                .WithInfo(24, 3, Artist.Stacey_Diana_Clark);

            //Sideboard
            addAlly("Galadhon Archer", 2, Sphere.Tactics, false, 0, 2, 0, 1)
                .WithTraits("Silvan.", "Warrior.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Response: After Galadhon Archer enters play, deal 1 damage to an enemy not engaged with you.")
                .WithFlavorLine("\"...they say that you breathe so loud that they could shoot you in the dark.\" -Legolas, The Fellowship of the Ring")
                .WithInfo(25, 3, Artist.Sara_K_Diesel);
            addAlly("Rúmil", 4, Sphere.Tactics, true, 2, 2, 1, 2)
                .WithTraits("Silvan.", "Scout.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Response: After you play Rúmil from your hand, choose an enemy engaged with a player. Deal X damage to that enemy where X is the number of ranged characters you control.")
                .WithFlavorLine("...the Company set out again, guided now by Haldir and his brother Rúmil. -The Fellowship of the Ring")
                .WithInfo(26, 3, Artist.Melanie_Maier);
            addAttachment("Bow of the Galadhrim", 1, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Silvan character with the ranged keyword. Restricted.")
                .WithTextLine("Attached character gets +1 Attack. (+2 Attack instead if attacking an enemy not engaged with you.)")
                .WithFlavorLine("...longer and stronger than the bows of Mirkwood, and strung with a string of elf-hair. -The Fellowship of the Ring")
                .WithInfo(27, 3, Artist.Sara_Biddle);
            addEvent("Hands Upon the Bow", 1, Sphere.Tactics)
                .WithTextLine("Action: Exhaust a character you control with ranged to immediately declare it as an attacker (and resolve its attack) against an enemy in the staging area. It gets +1 Attack during this attack.")
                .WithTemplate("<p><b>Action:</b> Exhaust a character you control with {keyword:Ranged.@ranged} to immediately declare it as an attacker (and resolve its attack) against an enemy in the staging area. It gets +1 {attack} during this attack.</p><p class='flavor-text'>&quot;We live now upon an island amid perils, and our hands are more often upon thr bowstring than upon the harp.&quot;<br/>&ndash;Haldir, The Fellowship of the Ring</p>")
                .WithInfo(28, 3, Artist.Magali_Villeneuve);
            addEvent("Pursuing the Enemy", 0, Sphere.Tactics)
                .WithTextLine("Action: Return a Silvan ally you control to your hand to choose a player. Deal 1 damage to each enemy engaged with that player.")
                .WithFlavorLine("The marauding orcs had been waylaid and almost all destroyed; the remnant had fled westward towards the mountains, and were being pursued. -The Fellowship of the Ring")
                .WithInfo(29, 3, Artist.Cristi_Balanescu);
            addAttachment("Vilya", 2, Sphere.Neutral, true)
                .WithTraits("Ring.", "Artifact.")
                .WithTextLine("Attach to Elrond. He gains a Spirit resource icon.")
                .WithTextLine("Action: Exhaust Elrond and Vilya to reveal the top card of your deck. You can immediately play or put into play the revealed card for no cost, if able. Otherwise, move the revealed card to the bottom of your deck.")
                .WithFlavorLine("...mightiest of the Three. -Return of the King")
                .WithTemplate("<p>Attach to {title:Elrond}. He gains a {sphere:Spirit} resource icon.</p><p><b>Action:</b> Exhaust {title:Elrond} and {self} to reveal the top card of your deck. You can immediately play or put into play the revealed card for no cost, if able. Otherwise, move the revealed card to the bottom of your deck.</p><p class='flavor-text'>...mightiest of the Three. &ndash;The Return of the King</p>")
                .WithAges(Age.Second_Age, Age.Third_Age)
                .WithInfo(30, 3, Artist.Sara_Biddle);
            addHero("Elrond", 31, Sphere.Lore, 3, 2, 3, 4)
                .WithTraits("Noldor.", "Noble.")
                .WithTextLine("You may spend resources from Elrond's resource pool to pay for Spirit, Leadership, and Tactics allies.")
                .WithTextLine("Response: After a character is healed by another card effect, heal 1 damage on it.")
                .WithFlavorLine("\"But you do not stand alone.\"")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithTemplate("<p>You may spend resources from {self}'s resource pool to pay for {sphere:Spirit}, {sphere:Leadership}, and {sphere:Tactics} {type:Ally@allies.}</p><p><b>Response:</b> After a character is healed by another card effect, heal 1 damage on it.</p><p class='flavor-text'>&quot;But you do not stand alone.&quot;<br>&ndash;The Fellowship of the Ring</p>")
                .WithCommunityVersion("Autumn/Elrond-Lore-Hero")
                .WithCommunityVersion("RiddermarkLord/Elrond-Lore-Hero-1")
                .WithCommunityVersion("RiddermarkLord/Elrond-Lore-Hero-2")
                .WithCommunityVersion("RiddermarkLord/Elrond-Lore-Hero-3")
                .WithCommunityVersion("Hrodebert/Elrond-Jon-Hodgson-1")
                .WithCommunityVersion("Hrodebert/Elrond-Jon-Hodgson-2")
                .WithCommunityVersion("Hrodebert/Elrond-Magali")
                .WithAges(Age.First_Age, Age.Second_Age, Age.Third_Age)
                .WithInfo(31, 1, Artist.Magali_Villeneuve);
        }
    }
}