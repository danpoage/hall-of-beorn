/* Generated CardSet class: Shadow and Flame */

using System;

namespace HallOfBeorn.Models.LotR.Sets.Dwarrowdelf
{
    public class ShadowAndFlameSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Shadow and Flame";
            Abbreviation = "SaF";
            Number = 14;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dwarrowdelf";

            addHero("Elrond", 13, Sphere.Lore, 3, 2, 3, 4)
                .WithTraits("Noldor.", "Noble.")
                .WithTextLine("You may spend resources from Elrond's resource pool to pay for Spirit, Leadership, and Tactics allies.")
                .WithTextLine("Response: After a character is healed by another card effect, heal 1 damage on it.")
                .WithFlavorLine("\"But you do not stand alone.\"")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithTemplate("<p>You may spend resources from {self}'s resource pool to pay for {sphere:Spirit}, {sphere:Leadership}, and {sphere:Tactics} {type:Ally@allies.}</p><p><b>Response:</b> After a character is healed by another card effect, heal 1 damage on it.</p><p class='flavor-text'>&quot;But you do not stand alone.&quot;<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(128, 1, Artist.Magali_Villeneuve);
            addEvent("We Are Not Idle", 0, Sphere.Leadership)
                .WithTextLine("Action: Exhaust X Dwarf heroes to add X resources to a hero's resource pool and draw 1 card.")
                .WithFlavorLine("\"You should see the stone-paved roads of many colours! And the halls and cavernous streets under the earth with arches carved like trees; and the terraces and towers upon the Mountain's sides! Then you would see that we have not been idle.\" -Glóin, The Fellowship of the Ring")
                .WithErrata()
                .WithInfo(129, 3, Artist.Charles_Urbach);
            addAttachment("Hardy Leadership", 2, Sphere.Leadership, true)
                .WithTextLine("Attach to a Leadership hero.")
                .WithTextLine("Each Dwarf character gets +1 hit point.")
                .WithTemplate("<p>Attach to a {sphere-hero:Leadership}.</p><p>Each {trait-character:Dwarf.@Dwarf} gets +1 hit point.</p><p class='flavor-text'>&quot;We will seek the hidden door together. And we will come through. In the ruins of of the Dwarves, a dwarf's head will be less easy to bewilder than Elves or Men or Hobbits.&quot;<br>&ndash;Gandalf, The Fellowship of the Ring</p>")
                .WithInfo(130, 3, Artist.Jake_Murray);
            addEvent("Hands Upon the Bow", 1, Sphere.Tactics)
                .WithTextLine("Action: Exhaust a character you control with ranged to immediately declare it as an attacker (and resolve its attack) against an enemy in the staging area. It gets +1 Attack during this attack.")
                .WithTemplate("<p><b>Action:</b> Exhaust a character you control with {keyword:Ranged.@ranged} to immediately declare it as an attacker (and resolve its attack) against an enemy in the staging area. It gets +1 {attack} during this attack.</p><p class='flavor-text'>&quot;We live now upon an island amid perils, and our hands are more often upon thr bowstring than upon the harp.&quot;<br/>&ndash;Haldir, The Fellowship of the Ring</p>")
                .WithInfo(131, 3, Artist.Magali_Villeneuve);
            addEvent("A Elbereth! Gilthoniel!", 4, Sphere.Spirit)
                .WithAlternateSlug("O-Elbereth-Gilthonial-SaF")
                .WithKeywords("Secrecy 4.")
                .WithTextLine("Response: After a non-unique enemy attacks you, put that enemy on the bottom of the encounter deck. If your threat is lower than that enemy's engagement cost, set your threat equal to the engagement cost of that enemy.")
                .WithErrata()
                .WithInfo(132, 3, Artist.Aaron_B_Miller);
            addAttachment("Miruvor", 1, Sphere.Spirit, false)
                .WithTraits("Item.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Action: Discard Miruvor to (choose two): ready attached hero, add 1 resource to attached hero's resource pool, attached hero gets +1 Willpower until the end of the round, or put Miruvor on the top of your deck.")
                .WithInfo(133, 3, Artist.Sara_Biddle);
            addAlly("Master of the Forge", 2, Sphere.Lore, false, 0, 0, 1, 1)
                .WithTraits("Noldor.", "Craftsman.")
                .WithTextLine("Action: Exhaust Master of the Forge to search the top 5 cards of your deck for any 1 attachment and add it to your hand. Shuffle the other cards back into your deck.")
                .WithInfo(134, 3, Artist.Paul_Guzenko);
            addEvent("Peace, and Thought", 1, Sphere.Lore)
                .WithTextLine("Refresh Action: Exhaust 2 heroes to draw 5 cards.")
                .WithTemplate("<p><b>Refresh Action:</b> Exhaust 2 heroes to draw 5 cards.</p><p class='flavor-text'>&quot;Here you will hear many songs and tales-if you can keep awake. But except on high days it usually stands empty and quiet. and people come here who wish for peace, and thought. There is always a fire here, all the year round, but there is little other light.&quot;<br>&ndash;Gandalf, The Fellowship of the Ring</p>")
                .WithInfo(135, 3, Artist.Magali_Villeneuve);
            addEvent("Risk Some Light", 3, Sphere.Lore)
                .WithKeywords("Secrecy 3.")
                .WithTextLine("Action: Look at the top 3 cards of the encounter deck. You may select 1 card and move it to the bottom of the encounter deck. Return any unselected cards to the top of the encounter deck, in any order.")
                .WithTemplate("<p class='main-text'>{keyword:Secrecy 3.}</p><p class='main-text'><b>Action:</b> Look at the top 3 cards of the encounter deck. You may select 1 card and move it to the bottom of the encounter deck. Return any unselected cards to the top of the encounter deck, in any order.</p>")
                .WithInfo(136, 3, Artist.Dmitry_Burmak);
            addAttachment("Vilya", 2, Sphere.Neutral, true)
                .WithTraits("Ring.", "Artifact.")
                .WithTextLine("Attach to Elrond. He gains a Spirit resource icon.")
                .WithTextLine("Action: Exhaust Elrond and Vilya to reveal the top card of your deck. You can immediately play or put into play the revealed card for no cost, if able. Otherwise, move the revealed card to the bottom of your deck.")
                .WithFlavorLine("...mightiest of the Three. -Return of the King")
                .WithTemplate("<p>Attach to {title:Elrond}. He gains a {sphere:Spirit} resource icon.</p><p><b>Action:</b> Exhaust {title:Elrond} and {self} to reveal the top card of your deck. You can immediately play or put into play the revealed card for no cost, if able. Otherwise, move the revealed card to the bottom of your deck.</p><p class='flavor-text'>...mightiest of the Three. &ndash;The Return of the King</p>")
                .WithInfo(137, 3, Artist.Sara_Biddle);
            addQuest("Nearing the Gate", "Shadow and Flame", 1, 'A', 9)
                .WithTextLine("Setup: Remove Dark Pit from the encounter deck and place it aside, out of play. Add Durin's Bane to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("As you reach the eastern realm of Darrowdelf the craftsmanship of the Dwarves is proudly displayed. But the sound of drums sound in the deep, and it appears that these halls are infested with Orcs.")
                .WithTemplate("<p class='flavor-text'>As you reach the eastern realm of Darrowdelf the craftsmanship of the Dwarves is proudly displayed. But the sound of drums sound in the deep, and it appears that these halls are infested with Orcs.</p><p><b>Setup:</b> Remove {card:Dark-Pit-SaF@Dark Pit} from the encounter deck and place it aside, out of play. Add {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} to the staging area. Shuffle the encounter deck.</p>")
                .WithOppositeTextLine("When Revealed: Reduce each player's threat to 0. Reveal X cards from the encounter deck, where X is one less than the number of players in the game, and add them to the staging area.")
                .WithOppositeFlavorLine("A crack like lightning sounds before you, and a creature of shadow and flame blocks your way. It is an ancient demon of Morgoth, and its presence explains the massing in Moria.")
                .WithTemplate2("<p class='flavor-text'>A crack like lightning sounds before you, and a creature of shadow and flame blocks your way. It is an ancient demon of Morgoth, and its presence explains the massing in Moria.</p><p><b>When Revealed:</b> Reduce each player's threat to 0. Reveal X cards from the encounter deck, where X is one less than the number of players in the game, and add them to the staging area.</p>")
                .WithIncludedEncounterSets(EncounterSet.GoblinsOfTheDeep, EncounterSet.DeepsOfMoria)
                .WithInfo(138, 1, Artist.Ben_Zweifel);
            addQuest("The Rear Guard", "Shadow and Flame", 2, 'A', 16)
                .WithFlavorLine("The fire-demon is Durin's Bane, doom of the Dwarves and the new Lord of Moria. It cannot be destroyed by mere strength of arms. You must find another way to deal with this Balrog as it relentlessly attacks, sword and whip weaving a deadly pattern of flame.")
                .WithTemplate("<p class='flavor-text'>The fire-demon is Durin's Bane, doom of the Dwarves and the new Lord of Moria. It cannot be destroyed by mere strength of arms. You must find another way to deal with this Balrog as it relentlessly attacks, sword and whip weaving a deadly pattern of flame.</p>")
                .WithOppositeTextLine("Forced: If at least 1 hero committed to the quest this round, place 4 progress tokens on The Rear Guard (bypassing any active location) at the end of the quest phase.")
                .WithOppositeTextLine("If Durin's Bane has 0 hit points, advance to the next stage of the scenario immediately.")
                .WithTemplate2("<p><b>Forced:</b> If at least 1 hero committed to the quest this round, place 4 progress tokens on {self} <i>(bypassing the active location)</i> at the end of the quest phase.</p><p><b>If {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} has 0 hit points, advance to {card:Last-Lord-of-Moria-SaF@the next stage} of the scenario immediately.</b></p>")
                .WithIncludedEncounterSets(EncounterSet.GoblinsOfTheDeep, EncounterSet.DeepsOfMoria)
                .WithInfo(139, 1, Artist.Jason_Juta);
            addQuest("Last Lord of Moria", "Shadow and Flame", 3, 'A', 1)
                .WithFlavorLine("There is a crumbling pile of boulders on the edge of a teetering cliff, and it gives you a sudden idea. There are chasms and pits along the path you are traveling, and perhaps a well-timed rockslide could send the Balrog down into the depths below...")
                .WithTemplate("<p class='flavor-text'>There is a crumbling pile of boulders on the edge of a teetering cliff, and it gives you a sudden idea. There are chasms and pits along the path you are traveling, and perhaps a well-timed rockslide could send the Balrog down into the depths below...</p>")
                .WithOppositeTextLine("When Revealed: Durin's Bane makes an immediate attack on the first player. Add Dark Pit to the staging area.")
                .WithOppositeTextLine("Players cannot win the game while Durin's Bane is in play. If Durin's Bane leaves play by the effect on Dark Pit, the players have won the game.")
                .WithTemplate2("<p><b>When Revealed:</b> {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} makes an immediate attack on the first player. Add {card:Dark-Pit-SaF@Dark Pit} to the staging area.</p><p><b>Players cannot win the game while {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} is in play. If {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} leaves play by the effect on {card:Dark-Pit-SaF@Dark Pit}, the players have won the game.</b></p>")
                .WithIncludedEncounterSets(EncounterSet.GoblinsOfTheDeep, EncounterSet.DeepsOfMoria)
                .WithInfo(140, 1, Artist.Dmitry_Burmak);
            addLocation("Dark Pit", "Shadow and Flame", 0, 11)
                .WithTraits("Underground.", "Dark.")
                .WithTextLine("While Dark Pit is the active location it gains: 'Refresh Action: Exhaust X characters (maximum 3) you control to discard the top X cards of your deck. If all discarded cards have a higher combined printed cost than the remaining hit points of Durin's Bane, discard Durin's Bane from play.'")
                .WithTemplate("<p>While {self} is the active location it gains:<blockquote><b>Refresh Action:</b> Exhaust X characters (maximum 3) you control to discard the top X cards of your deck. If all discarded cards have a higher combined printed cost than the remaining hit points of {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane}, discard {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} from play.</blockquote></p>")
                .WithInfo(141, 1, Artist.Igor_Kieryluk);
            addLocation("Second Hall", "Shadow and Flame", 4, 2)
                .WithUnique()
                .WithTraits("Underground.")
                .WithTextLine("While Second Hall is the active location, it gains: 'Forced: After a character leaves play, reveal 1 card from the encounter deck and add it to the staging area.'")
                .WithFlavorLine("Down the centre stalked a double line of towering pillars. They were carved like boles of mighty trees whose boughs upheld the roof with a branching tracery of stone. -The Fellowship of the Ring")
                .WithTemplate("<p>While {self} is the active location, it gains:<blockquote><b>Forced:</b> After a character leaves play, reveal 1 card from the encounter deck and add it to the staging area.</blockquote></p><p class='flavor-text'>Down the centre stalked a double line of towering pillars. They were carved like boles of mighty trees whose boughs upheld the roof with a branching tracery of stone.<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(142, 1, Artist.Ben_Zweifel);
            addLocation("Second Deep", "Shadow and Flame", 3, 3)
                .WithTraits("Underground.")
                .WithTextLine("While Durin's Bane has no damage on it, progress tokens cannot be placed on Second Deep.")
                .WithTemplate("<p>While {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} has no damage on it, progress tokens cannot be placed on {self}.</p>")
                .WithInfo(143, 3, Artist.Nick_Deligaris);
            addTreachery("Fires in the Deep", "Shadow and Flame")
                .WithTextLine("When Revealed: Each player must discard 1 ally he controls, if able. If Fires in the Deep discarded no allies, it gains surge.")
                .WithShadow("Shadow: The defending player discards 1 ally he controls, if able.")
                .WithEasyModeQuantity(0)
                .WithInfo(144, 2, Artist.Nick_Deligaris);
            addTreachery("Counter-Spell", "Shadow and Flame")
                .WithTraits("Shadow.")
                .WithTextLine("When Revealed: Attach Counter-spell to Durin's Bane. (Counts as a Condition attachment with the text: 'Forced: When a player plays an event, discard the top card of the encounter deck. If that card is a treachery card, cancel the effects of the event, discard the event player's hand, and discard Counter-spell from play.')")
                .WithTemplate("<p><b>When Revealed:</b> Attach {self} to {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane}. Counts as a {trait:Condition.@Condition} attachment with the text:<blockquote><b>Forced:</b> When a player plays an {type:Event@event}, discard the top card of the encounter deck. If that card is a treachery card, cancel the effects of the event, discard the event player's hand, and discard Counter-spell from play.</blockquote></p>")
                .WithEasyModeQuantity(1)
                .WithInfo(145, 3, Artist.Magali_Villeneuve);
            addTreachery("Inner Flame", "Shadow and Flame")
                .WithTextLine("When Revealed: Durin's Bane gets +3 Attack until the end of the round. The first player may remove 1 questing hero he controls from the quest to cancel this effect.")
                .WithShadow("Shadow: If attacking enemy is Durin's Bane, it gets +3 Attack.")
                .WithTemplate("<p><b>When Revealed:</b> {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} gets +3 {Attack} until the end of the round. The first player may remove 1 questing hero he controls from the quest to cancel the effect.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> If attacking enemy is {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane}, it gets +3 {Attack}.</p>")
                .WithInfo(146, 3, Artist.Matthew_Starbuck);
            addTreachery("Inner Shadow", "Shadow and Flame")
                .WithKeywords("Surge.")
                .WithTextLine("When Revealed: Heal 5 damage from Durin's Bane, if able. The first player may remove 1 questing hero he controls from the quest to cancel this effect.")
                .WithTemplate("<p>{keyword:Surge.}</p><p><b>When Revealed:</b> Heal 5 damage from {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane}, if able. The first player may remove 1 questing hero he controls from the quest to cancel this effect.</p><p class='flavor-text'>The fire in it seemed to die, but the darkness grew.<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(147, 3, Artist.Rafal_Hrynkiewicz);
            addTreachery("Whip Lash", "Shadow and Flame")
                .WithTextLine("When Revealed: Each player must discard 1 attachment he controls, if able.")
                .WithShadow("Shadow: If attacking enemy is Durin's Bane, the defending player discards all attachments he controls.")
                .WithTemplate("<p><b>When Revealed:</b> Each player must discard 1 attachment he controls, if able.</p>{shadow}<p><b>Shadow:</b> If attacking enemy is {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane}, the defending player discards all attachments he controls.</p>")
                .WithInfo(148, 2, Artist.Timo_Karhula);
            addTreachery("Leaping Flame", "Shadow and Flame")
                .WithTextLine("When Revealed: Durin's Bane makes an immediate attack against the first player (deal and resolve a shadow card).")
                .WithShadow("Shadow: If attacking enemy is Durin's Bane, it gets +3 Attack.")
                .WithTemplate("<p><b>When Revealed:</b> {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} makes an immediate attack against the first player <i>(deal and resolve a shadow card).</i></p>{shadow}</p class='shadow-text'><b>Shadow:</b> If attacking enemy is {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane}, it gets +3 {Attack}.</p>")
                .WithEasyModeQuantity(1)
                .WithInfo(149, 3, Artist.Timo_Karhula);
            addEnemy("Durin's Bane", "Shadow and Flame", 1, 4, 6, 3, 27)
                .WithUnique()
                .WithTraits("Balrog.", "Flame.", "Shadow.")
                .WithKeywords("Regenerate 3.", "Indestructible.")
                .WithTextLine("Players cannot play attachments on Durin's Bane.Durin's Bane cannot leave the staging area, is considered to be engaged with each player whose threat is 1 or greater, and attacks each of those players in turn during the combat phase (deal and discard a new shadow card each attack).")
                .WithTemplate("<p>{keyword:Regenerate 3.} {keyword:Indestructible.} Players cannot play attachments on {self}.</p><p>{self} cannot leave the staging area, is considered to be engaged with each player whose threat is 1 or greater, and attacks each of those players in turn during the combat phase <i>(deal and discard a new shadow card each attack)</i>.</p>")
                .WithInfo(150, 1, Artist.Magali_Villeneuve);
            addEnemy("Ranging Goblin", "Shadow and Flame", 35, 2, 1, 1, 2)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("When Revealed: Each player must deal 1 damage to a hero he controls.")
                .WithTextLine("Forced: After a character leaves play, shuffle Ranging Goblin and the top card in the encounter discard pile back into the encounter deck.")
                .WithTemplate("<p><b>When Revealed:</b> Each player must deal 1 damage to a hero he controls.</p><p><b>Forced:</b> After a character leaves play, shuffle {self} and the top card in the encounter discard pile back into the encounter deck.</p>")
                .WithInfo(151, 3, Artist.Jasper_Sandner);
            addTreachery("Fiery Sword", "Shadow and Flame")
                .WithTraits("Weapon.", "Flame.")
                .WithTextLine("When Revealed: Attach Fiery Sword to Durin's Bane as a Weapon attachment with the text: 'Attached enemy gets +3 Attack.'")
                .WithTemplate("<p><b>When Revealed:</b> Attach {self} to {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} as a {trait:Weapon.@Weapon} attachment with the text:<blockquote>Attached enemy gets +3 {Attack}.</blockquote></p><p class='flavor-text'>In its right hand was a blade like a stabbing tongue of fire...<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(152, 2, Artist.Timo_Karhula);
            addTreachery("Many Thonged Whip", "Shadow and Flame")
                .WithTraits("Weapon.", "Flame.")
                .WithTextLine("When Revealed: Attach Many Thonged Whip to Durin's Bane as a Weapon attachment with the text: 'Forced: When Durin's Bane attacks, the defending player must discard 1 card at random from his hand.'")
                .WithTemplate("<p><b>When Revealed:</b> Attach {self} to {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} as a {trait:Weapon.@Weapon} attachment with the text:<blockquote><b>Forced:</b> When {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} attacks, the defending player must discard 1 card at random from his hand.</blockquote></p><p class='flavor-text'>...in its left it held a whip of many thongs.<br>&ndash;The Fellowship of the Ring</p>'")
                .WithInfo(153, 2, Artist.Timo_Karhula);
        }
    }
}
