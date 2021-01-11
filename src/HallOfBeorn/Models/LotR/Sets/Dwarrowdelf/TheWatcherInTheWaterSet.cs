/* Generated CardSet class: The Watcher in the Water */

using System;

namespace HallOfBeorn.Models.LotR.Sets.Dwarrowdelf
{
    public class TheWatcherInTheWaterSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Watcher in the Water";
            Abbreviation = "TWitW";
            Number = 11;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dwarrowdelf";

            addHero("Aragorn", 12, Sphere.Lore, 2, 3, 2, 5)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Refresh Action: Reduce your threat to your starting threat level. (Limit once per game.)")
                .WithFlavorLine("\"I am older than I look, I might prove useful.\"")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithTemplate("<p>{keyword:Sentinel.}</p><p><b>Refresh Action:</b> Reduce your threat to your starting threat level. (Limit once per game.)</p><p class='flavor-text'>&quot;I am older than I look, I might prove useful.&quot;<br/>&ndash;The Fellowship of the Ring</p>")
                .WithCommunityVersion("RiddermarkLord/Aragorn-Lore")
                .WithInfo(53, 1, Artist.Tony_Foti);
            addEvent("Grave Cairn", 1, Sphere.Leadership)
                .WithTextLine("Response: After a character leaves play, add its Attack to another character's Attack until the end of the round.")
                .WithTemplate("<p><b>Response:</b> After a character leaves play, add its {Attack} to another character's {Attack} until the end of the round.</p><p class='flavor-text'>&quot;We have not the time or the tools to bury our comrade fitly, or to raise a mound up over him. A cairn we might build.&quot;<br>&ndash;Legolas, The Two Towers</p>")
                .WithInfo(54, 3, Artist.Trudi_Castle);
            addAttachment("Sword that was Broken", 3, Sphere.Leadership, true)
                .WithTraits("Artifact.")
                .WithTextLine("Attach to a hero. Attached hero gains a Leadership resource icon.")
                .WithTextLine("If attached hero is Aragorn, each character you control gets +1 Willpower.")
                .WithTemplate("<p>Attach to a hero.</p><p>Attached hero gains a {sphere:Leadership} resource icon.</p><p>If attached hero is <a title='Aragorn Hero Search' href='/Cards/Search?Query=%2Btitle%3AAragorn&CardType=Hero' target='_blank'>Aragorn</a>, each character you control gets +1 {Willpower}.</p><p class='flavor-text'>&quot;For the Sword that was Broken is the Sword of Elendil that broke beneath him when he fell.&quot;<br>&ndash;Aragorn, The Fellowship of the Ring</p>")
                .WithInfo(55, 3, Artist.Sara_Biddle);
            addAlly("Watcher of the Bruinen", 2, Sphere.Tactics, false, 0, 1, 2, 2)
                .WithTraits("Noldor.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Watcher of the Bruinen does not exhaust to defend.Forced: After Watcher of the Bruinen defends, either discard it from play or discard 1 card from your hand.")
                .WithTemplate("<p>{keyword:Sentinel.}</p><p>{self} does not exhaust to defend.</p><p><b>Forced:</b> After {self} defends, either discard it from play or discard 1 card from your hand.</p>")
                .WithInfo(56, 3, Artist.Kristina_Carroll);
            addAttachment("Rivendell Bow", 1, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithTextLine("Attach to a Noldor or Silvan character, or to Aragorn. Limit 1 per character.Attached character gains ranged.If attached character has a printed ranged keyword, it gets +1 Attack during a ranged attack.")
                .WithTemplate("<p>Attach to a {traits-character:Noldor,Silvan}, or to <a title='Aragorn Character' href='/Cards/Search?CardType=Character&Query=%2Btitle%3AAragorn' target='_blank'>Aragorn</a>. Limit 1 per character.</p><p>Attached character gains {keyword:Ranged.@ranged.}</p><p>If attached character has the printed {keyword:Ranged.@ranged} keyword, it gets +1 {Attack} during a ranged attack.</p>")
                .WithInfo(57, 3, Artist.Sara_Biddle);
            addAlly("Arwen Undómiel", 2, Sphere.Spirit, true, 2, 0, 1, 2)
                .WithTraits("Noldor.", "Noble.")
                .WithTextLine("Response: After Arwen Undómiel exhausts, choose a character. That character gains sentinel and gets +1 Defense until the end of the round.")
                .WithFlavorLine("\"...in whom it was said that the likeness of Lúthien had come on earth again...she was the Evenstar of her people.\"")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithTemplate("<p><b>Response:</b> After {self} exhausts, choose a character. That character gains {keyword:Sentinel.@sentinel} and gets +1 {Defense} until the end of the round.</p><p class='flavor-text'>...in whom it was said that the likeness of Lúthien had come on earth again...for she was the Evenstar of her people.<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(58, 3, Artist.Magali_Villeneuve);
            addEvent("Elrond's Counsel", 0, Sphere.Spirit)
                .WithTextLine("Action: If you control a unique Noldor character, give another character +1 Willpower until the end of the phase and lower your threat by 3.")
                .WithTemplate("<p><b>Action:</b> If you control a {unique-trait-character:Noldor.@Noldor}, give another character +1 {Willpower} until the end of the phase and lower your threat by 3.</p><p class='flavor-text'>&quot;Believe rather that it is so ordered that we, who sit here, and none others, must now find counsel for the peril of the world.&quot;<br>&ndash;Elrond, The Fellowship of the Ring</p>")
                .WithInfo(59, 3, Artist.Anthony_Palumbo);
            addEvent("Short Cut", 1, Sphere.Lore)
                .WithTextLine("Response: After a location enters play, exhaust a Hobbit character to shuffle that location back into the encounter deck. Then, reveal 1 card from the encounter deck and add it to the staging area.")
                .WithTemplate("<p><b>Response:</b> After a location enters play, exhaust a {trait-character:Hobbit.@Hobbit} to shuffle that location back into the encounter deck. Then, reveal 1 card from the encounter deck and add it to the staging area.</p><p class='flavor-text'>&quot;I suppose we haven't lost more than two days by my short cut through the Forest!&quot;<br>&ndash;Frodo, The Fellowship of the Ring</p>")
                .WithInfo(60, 3, Artist.Igor_Kieryluk);
            addAttachment("Legacy of Durin", 1, Sphere.Lore, true)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a Dwarf hero.")
                .WithTextLine("Response: After you play a Dwarf character from your hand, exhaust Legacy of Durin to draw 1 card.")
                .WithErrata(1)
                .WithInfo(61, 3, Artist.Ilich_Henriquez);
            addAttachment("Resourceful", 4, Sphere.Neutral, false)
                .WithKeywords("Secrecy 3.")
                .WithTextLine("Secrecy 3.")
                .WithTextLine("Attach to a hero you control.")
                .WithTextLine("Attached hero collects 1 additional resource during the resource phase each round.")
                .WithInfo(62, 3, Artist.Magali_Villeneuve);
            addQuest("To the West-door", "The Watcher in the Water", 1, 'A', 13)
                .WithTextLine("Setup: Remove The Watcher and Doors of Durin from the encounter deck and set them aside, out of play.")
                .WithFlavorLine("Elrond has asked you to scout the Mines of Moria on your return to Lorien, hoping to discover if it is the source of increased Orc activity along the Misty Mountains.")
                .WithTemplate("<p class='flavor-text'>Elrond has asked you to scout the Mines of Moria on your return to Lorien, hoping to discover if it is the source of increased Orc activity along the Misty Mountains.</p><p><b>Setup:</b> Remove <a title='The Watcher (The Watcher in the Water)' href='/Cards/Details/The-Watcher-TWitW' target='_blank'>The Watcher</a> and <a title='Doors of Durin (The Watcher in the Water)' href='/Cards/Details/Doors-of-Durin-TWitW' target='_blank'>Doors of Durin</a> from the encounter deck and set them aside, out of play.</p>")
                .WithOppositeTextLine("When Revealed: Reveal cards from the encounter deck and add them to the staging area until there is at least X threat in the staging area. X is twice the number of players in the game.")
                .WithOppositeFlavorLine("Your approach is blocked by a dark lake that slumbers beneath the face of the cliff. You must search for a way around the water.")
                .WithTemplate2("<p class='flavor-text'>Your approach is blocked by a dark lake that slumbers beneath the face of the cliff. You must search for a way around the water.</p><p><b>When Revealed:</b> Reveal cards from the encounter deck and add them to the staging area until there is at least X {Threat} in the staging area. X is twice the number of players in the game.</p>")
                .WithIncludedEncounterSets(EncounterSet.MistyMountains)
                .WithInfo(63, 1, Artist.Jason_Juta);
            addQuest("The Seething Lake", "The Watcher in the Water", 2, 'A', 5)
                .WithFlavorLine("The others swung round and saw the waters of the lake seething, as if a host of snakes were swimming up from the southern end. - The Fellowship of the Ring")
                .WithFlavorLine("The Doors of Durin are blocked by an ancient spell. You must figure out a way into the mines before the Seething bog and its Watcher consumes you all.")
                .WithTemplate("<p class='flavor-text'>The others swung round and saw the waters of the lake seething, as if a host of snakes were swimming up from the southern end.<br>&ndash;The Fellowship of the Ring</p><p class='flavor-text'>The Doors of Durin are blocked by an ancient spell. You must figure out a way into the mines before the Seething bog and its Watcher consumes you all.</p>")
                .WithOppositeTextLine("When Revealed: Add The Watcher to the staging area. Doors of Durin becomes the active location, moving any previous active location to the staging area. Shuffle all Tentacle cards in the encounter discard pile back into the encounter deck.")
                .WithOppositeTextLine("If the players have at least 3 victory points and defeat this stage, they have won the game.")
                .WithTemplate2("<p><b>When Revealed:</b> Add <a title='The Watcher (The Watcher in the Water)' href='/Cards/Details/The-Watcher-TWitW' target='_blank'>The Watcher</a> to the staging area. <a title='Doors of Durin (The Watcher in the Water)' href='/Cards/Details/Doors-of-Durin-TWitW' target='_blank'>Doors of Durin</a> becomes the active location, moving any previous active location to the staging area. Shuffle all {trait:Tentacle.@Tentacle} cards in the encounter discard pile back into the encounter deck.</p><p><b>If the players have at least 3 victory points and defeat this stage, they have won the game.</b></p>")
                .WithIncludedEncounterSets(EncounterSet.MistyMountains)
                .WithInfo(64, 1, Artist.Adam_Schumpert);
            addLocation("Doors of Durin", "The Watcher in the Water", 2, Card.VALUE_NA)
                .WithUnique()
                .WithTraits("Gate.")
                .WithTextLine("Progress tokens that would be placed on Doors of Durin are instead placed on the current quest card.")
                .WithTextLine("Action: Each player may discard any number of cards from his hand. Then, discard the top card of the encounter deck. If the first letter of the encounter card's title matches that of one of the discarded player cards, add Doors of Durin to your victory display. (Limit once per round.)")
                .WithTemplate("<p>Progress tokens that would be placed on {self} are instead placed on the current quest card.</p><p><b>Action:</b> Each player may discard any number of cards from his hand. Then, discard the top card of the encounter deck. If the first letter of the encounter card's title matches that of one of the discarded player cards, add {self} to your victory display. (Limit once per round.)</p>{victory:3}")
                .WithVictoryPoints(3)
                .WithInfo(65, 1, Artist.Ben_Zweifel);
            addLocation("Stair Falls", "The Watcher in the Water", 2, 4)
                .WithUnique()
                .WithTraits("Stair.")
                .WithTextLine("Travel: The first player must exhaust 2 characters to travel here.")
                .WithShadow("Shadow: Remove 1 progress token from the current quest.")
                .WithInfo(66, 1, Artist.Lin_Bo);
            addLocation("Perilous Swamp", "The Watcher in the Water", 4, 2)
                .WithTraits("Swamp.")
                .WithTextLine("No more than 1 progress token can be placed on Perilous Swamp each round.")
                .WithShadow("Shadow: Remove 1 progress token from the current quest.")
                .WithTemplate("<p>No more than 1 progress token can be placed on {self} each round</p><p class='flavor-text'><b>Shadow:</b> Remove 1 progress token from the current quest.</p>")
                .WithInfo(67, 2, Artist.Trudi_Castle);
            addLocation("Makeshift Passage", "The Watcher in the Water", 1, 5)
                .WithTraits("Swamp.")
                .WithTextLine("Forced: After you travel to Makeshift Passage, place 2 progress tokens on the current quest card, bypassing any active location.")
                .WithFlavorLine("They reached the strip of dry land between the lake and the cliffs: it was narrow, often hardly a dozen yards across, and encumbered with fallen rock and stones; but they found a way, hugging the cliff, and keeping as far from the dark water as they might. - The Fellowship of the Ring")
                .WithTemplate("<p><b>Forced:</b> After you travel to {self}, place 2 progress tokens on the current quest card, bypassing any active location.</p><p class='flavor-text'>They reached the strip of dry land between the lake and the cliffs: it was narrow, often hardly a dozen yards across, and encumbered with fallen rock and stones; but they found a way, hugging the cliff, and keeping as far from the dark water as they might.<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(68, 2, Artist.Ben_Zweifel);
            addLocation("Stagnant Creek", "The Watcher in the Water", 3, 3)
                .WithTraits("Swamp.")
                .WithTextLine("When Revealed: Discard the top card of the encounter deck. If the discarded card is a Tentacle enemy, add that card to the staging area and raise each player's threat by 5.")
                .WithTemplate("<p><b>When Revealed:</b> Discard the top card of the encounter deck. If the discarded card is a {trait:Tentacle.@Tentacle} enemy, add that card to the staging area and raise each player's threat by 5.</p><p class='flavor-text'>When they came to the northernmost corner of the lake they found a narrow creek that barreed their way. It was green and stagnant, thrust out like a slimy arm towards the enclosing hills.<br>&ndash;The Fellowship of the Ring</p>")
                .WithEasyModeQuantity(1)
                .WithInfo(69, 3, Artist.David_Lecossu);
            addTreachery("Ill Purpose", "The Watcher in the Water")
                .WithTextLine("When Revealed: All enemies in the staging area engage the player with the highest threat. Then, each player raises his threat by the total Threat of all cards in the staging area.")
                .WithShadow("Shadow: attacking enemy gets +1 Attack. (+3 Attack instead if it is a Tentacle.)")
                .WithTemplate("<p><b>When Revealed:</b> All enemies in the staging area engage the player with the highest threat. Then, each player raises his threat by the total {Threat} of all cards in the staging area.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Attacking enemy gets +1 {Attack}. (+3 {Attack} instead if it is a {trait:Tentacle.})</p>")
                .WithEasyModeQuantity(0)
                .WithInfo(70, 1, Artist.Cristi_Balanescu);
            addTreachery("Disturbed Waters", "The Watcher in the Water")
                .WithKeywords("Doomed 5.")
                .WithTextLine("Doomed 5.")
                .WithTemplate("<p>{keyword:Doomed+5.@Doomed 5.}</p><p class='flavor-text'>...there came a soft sound: a swish, followed by a plop, as if a fish had disturbed the still surface of the water. Turning quickly they saw ripples, black-edged with shadow in the waning light: great rings were widening outwards from a point far out in the lake. There was a bubbling noise, and then silence<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(71, 3, Artist.Cristi_Balanescu);
            addEnemy("The Watcher", "The Watcher in the Water", 48, 4, 5, 7, 9)
                .WithUnique()
                .WithTraits("Creature.", "Tentacle.")
                .WithKeywords("Regenerate 2.")
                .WithTextLine("Regenerate 2.")
                .WithTextLine("While there is another Tentacle enemy in play, The Watcher cannot be optionally engaged.")
                .WithTextLine("If The Watcher is in the staging area at the end of the combat phase, each player must deal 3 damage to 1 character he controls.")
                .WithTemplate("<p>{keyword:Regenerate+2.@Regenerate 2}. While there is another {trait:Tentacle.@Tentacle} enemy in play, {self} cannot be optionally engaged.</p><p>If {self} is in the staging area at the end of the combat phase, each player must deal 3 damage to 1 character he controls.</p>{victory:3}")
                .WithVictoryPoints(3)
                .WithInfo(72, 1, Artist.Matthew_Starbuck);
            addEnemy("Grasping Tentacle", "The Watcher in the Water", 12, 2, 3, 0, 3)
                .WithTraits("Tentacle.")
                .WithTextLine("Forced: When Grasping Tentacle is attacked, discard the top card of the encounter deck. If that card has a shadow effect or is a Tentacle enemy, attach this card to an attacking character as a Tentacle attachment with the text: 'Attached character's Attack and Defense are reduced to 0.'")
                .WithTemplate("<p><b>Forced:</b> When {self} is attacked, discard the top card of the encounter deck. If that card has a shadow effect or is a {trait:Tentacle.@Tentacle} enemy, attach this card to an attacking character as a {trait:Tentacle.@Tentacle} attachment with the text: &quot;Attached character's {Attack} and {Defense} are reduced to 0.&quot;</p>")
                .WithEasyModeQuantity(3)
                .WithInfo(73, 4, Artist.Mark_Tarrisse);
            addEnemy("Thrashing Tentacle", "The Watcher in the Water", 12, 2, 3, 0, 3)
                .WithTraits("Tentacle.")
                .WithTextLine("Forced: When Thrashing Tentacle is attacked, discard the top card of the encounter deck. If that card has a shadow effect or is a Tentacle enemy, deal the damage from the attack to 1 character an attacking player controls (ignoring defense).")
                .WithTemplate("<p><b>Forced:</b> When {self} is attacked, discard the top card of the encounter deck. If that card has a shadow effect or is a {trait:Tentacle.@Tentacle} enemy, deal the damage from the attack to 1 character an attacking player controls <i>(ignoring defense)</i>.</p>")
                .WithEasyModeQuantity(3)
                .WithInfo(74, 4, Artist.Cristi_Balanescu);
            addEnemy("Striking Tentacle", "The Watcher in the Water", 18, 2, 4, 1, 3)
                .WithTraits("Tentacle.")
                .WithTextLine("Forced: When Striking Tentacle attacks, discard the top card of the encounter deck. If that card has a shadow effect or is a Tentacle enemy, this attack is considered undefended.")
                .WithTemplate("<p><b>Forced:</b> When {self} attacks, discard the top card of the encounter deck. If that card has a shadow effect or is a {trait:Tentacle.@Tentacle} enemy, this attack is considered undefended.</p>")
                .WithEasyModeQuantity(3)
                .WithInfo(75, 4, Artist.Cristi_Balanescu);
            addTreachery("Wrapped!", "The Watcher in the Water")
                .WithTraits("Tentacle.")
                .WithTextLine("When Revealed: The first player attaches Wrapped! to a hero he controls. (Counts as a Tentacle attachment with the text: 'Limit 1 per hero. Attached hero cannot exhaust or ready. At the end of the round, discard attached hero from play. Combat Action: Exhaust a hero you control without a Tentacle attachment to discard Wrapped!.')")
                .WithTemplate("<p><b>When Revealed:</b> The first player attaches {self} to a hero he controls. Counts as a {trait:Tentacle.@Tentacle} attachment with the text: <blockquote>Limit 1 per hero. Attached hero cannot exhaust or ready. At the end of the round, discard attached hero from play.<br><b>Combat Action:</b> Exhaust a hero you control without a {trait:Tentacle.@Tentacle} attachment to discard {self}.</blockquote></p>")
                .WithEasyModeQuantity(2)
                .WithInfo(76, 4, Artist.Cristi_Balanescu);
        }
    }
}
