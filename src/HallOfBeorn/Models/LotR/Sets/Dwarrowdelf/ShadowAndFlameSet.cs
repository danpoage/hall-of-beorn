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
                .WithCommunityVersion("Autumn/Elrond-Lore-Hero")
                .WithCommunityVersion("RiddermarkLord/Elrond-Lore-Hero-1")
                .WithCommunityVersion("RiddermarkLord/Elrond-Lore-Hero-2")
                .WithCommunityVersion("RiddermarkLord/Elrond-Lore-Hero-3")
                .WithCommunityVersion("Hrodebert/Elrond-Jon-Hodgson-1")
                .WithCommunityVersion("Hrodebert/Elrond-Jon-Hodgson-2")
                .WithCommunityVersion("Hrodebert/Elrond-Magali")
                .WithAges(Age.First_Age, Age.Second_Age, Age.Third_Age)
                .WithInfo(128, 1, Artist.Magali_Villeneuve);
            addEvent("We Are Not Idle", 0, Sphere.Leadership)
                .WithTextLine("Action: Exhaust X Dwarf heroes to add X resources to a hero's resource pool and draw 1 card.")
                .WithFlavorLine("\"You should see the stone-paved roads of many colours! And the halls and cavernous streets under the earth with arches carved like trees; and the terraces and towers upon the Mountain's sides! Then you would see that we have not been idle.\"")
                .WithFlavorLine("-Glóin, The Fellowship of the Ring")
                .WithErrata(1)
                .WithInfo(129, 3, Artist.Charles_Urbach);
            addAttachment("Hardy Leadership", 2, Sphere.Leadership, true)
                .WithTextLine("Attach to a Leadership hero.")
                .WithTextLine("Each Dwarf character gets +1 hit point.")
                .WithInfo(130, 3, Artist.Jake_Murray);
            addEvent("Hands Upon the Bow", 1, Sphere.Tactics)
                .WithTextLine("Action: Exhaust a character you control with ranged to immediately declare it as an attacker (and resolve its attack) against an enemy in the staging area. It gets +1 Attack during this attack.")
                .WithInfo(131, 3, Artist.Magali_Villeneuve);
            addEvent("A Elbereth! Gilthoniel!", 4, Sphere.Spirit)
                .WithAlternateSlug("O-Elbereth-Gilthonial-SaF")
                .WithKeywords("Secrecy 4.")
                .WithTextLine("Secrecy 4.")
                .WithTextLine("Response: After a non-unique enemy attacks you, put that enemy on the bottom of the encounter deck. If your threat is lower than that enemy's engagement cost, set your threat equal to the engagement cost of that enemy.")
                .WithErrata(1)
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
                .WithInfo(135, 3, Artist.Magali_Villeneuve);
            addEvent("Risk Some Light", 3, Sphere.Lore)
                .WithKeywords("Secrecy 3.")
                .WithTextLine("Secrecy 3.")
                .WithTextLine("Action: Look at the top 3 cards of the encounter deck. You may select 1 card and move it to the bottom of the encounter deck. Return any unselected cards to the top of the encounter deck, in any order.")
                .WithInfo(136, 3, Artist.Dmitry_Burmak);
            addAttachment("Vilya", 2, Sphere.Neutral, true)
                .WithTraits("Ring.", "Artifact.")
                .WithTextLine("Attach to Elrond. He gains a Spirit resource icon.")
                .WithTextLine("Action: Exhaust Elrond and Vilya to reveal the top card of your deck. You can immediately play or put into play the revealed card for no cost, if able. Otherwise, move the revealed card to the bottom of your deck.")
                .WithFlavorLine("...mightiest of the Three. -Return of the King")
                .WithAges(Age.Second_Age, Age.Third_Age)
                .WithInfo(137, 3, Artist.Sara_Biddle);
            addQuest("Nearing the Gate", "Shadow and Flame", 1, 'A', 9)
                .WithTextLine("Setup: Remove Dark Pit from the encounter deck and place it aside, out of play. Add Durin's Bane to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("As you reach the eastern realm of Darrowdelf the craftsmanship of the Dwarves is proudly displayed. But the sound of drums sound in the deep, and it appears that these halls are infested with Orcs.")
                .WithOppositeTextLine("When Revealed: Reduce each player's threat to 0. Reveal X cards from the encounter deck, where X is one less than the number of players in the game, and add them to the staging area.")
                .WithOppositeFlavorLine("A crack like lightning sounds before you, and a creature of shadow and flame blocks your way. It is an ancient demon of Morgoth, and its presence explains the massing in Moria.")
                .WithIncludedEncounterSets(EncounterSet.GoblinsOfTheDeep, EncounterSet.DeepsOfMoria)
                .WithInfo(138, 1, Artist.Ben_Zweifel);
            addQuest("The Rear Guard", "Shadow and Flame", 2, 'A', 16)
                .WithFlavorLine("The fire-demon is Durin's Bane, doom of the Dwarves and the new Lord of Moria. It cannot be destroyed by mere strength of arms. You must find another way to deal with this Balrog as it relentlessly attacks, sword and whip weaving a deadly pattern of flame.")
                .WithOppositeTextLine("Forced: If at least 1 hero committed to the quest this round, place 4 progress tokens on The Rear Guard (bypassing any active location) at the end of the quest phase.")
                .WithOppositeTextLine("If Durin's Bane has 0 hit points, advance to the next stage of the scenario immediately.")
                .WithIncludedEncounterSets(EncounterSet.GoblinsOfTheDeep, EncounterSet.DeepsOfMoria)
                .WithInfo(139, 1, Artist.Jason_Juta);
            addQuest("Last Lord of Moria", "Shadow and Flame", 3, 'A', 1)
                .WithFlavorLine("There is a crumbling pile of boulders on the edge of a teetering cliff, and it gives you a sudden idea. There are chasms and pits along the path you are traveling, and perhaps a well-timed rockslide could send the Balrog down into the depths below...")
                .WithOppositeTextLine("When Revealed: Durin's Bane makes an immediate attack on the first player. Add Dark Pit to the staging area.")
                .WithOppositeTextLine("Players cannot win the game while Durin's Bane is in play. If Durin's Bane leaves play by the effect on Dark Pit, the players have won the game.")
                .WithIncludedEncounterSets(EncounterSet.GoblinsOfTheDeep, EncounterSet.DeepsOfMoria)
                .WithInfo(140, 1, Artist.Dmitry_Burmak);
            addLocation("Dark Pit", "Shadow and Flame", 0, 11)
                .WithTraits("Underground.", "Dark.")
                .WithTextLine("While Dark Pit is the active location it gains: 'Refresh Action: Exhaust X characters (maximum 3) you control to discard the top X cards of your deck. If all discarded cards have a higher combined printed cost than the remaining hit points of Durin's Bane, discard Durin's Bane from play.'")
                .WithInfo(141, 1, Artist.Igor_Kieryluk);
            addLocation("Second Hall", "Shadow and Flame", 4, 2)
                .WithUnique()
                .WithTraits("Underground.")
                .WithTextLine("While Second Hall is the active location, it gains: 'Forced: After a character leaves play, reveal 1 card from the encounter deck and add it to the staging area.'")
                .WithFlavorLine("Down the centre stalked a double line of towering pillars. They were carved like boles of mighty trees whose boughs upheld the roof with a branching tracery of stone. -The Fellowship of the Ring")
                .WithInfo(142, 1, Artist.Ben_Zweifel);
            addLocation("Second Deep", "Shadow and Flame", 3, 3)
                .WithTraits("Underground.")
                .WithTextLine("While Durin's Bane has no damage on it, progress tokens cannot be placed on Second Deep.")
                .WithInfo(143, 3, Artist.Nick_Deligaris);
            addTreachery("Fires in the Deep", "Shadow and Flame")
                .WithTextLine("When Revealed: Each player must discard 1 ally he controls, if able. If Fires in the Deep discarded no allies, it gains surge.")
                .WithShadow("Shadow: The defending player discards 1 ally he controls, if able.")
                .WithEasyModeQuantity(0)
                .WithInfo(144, 2, Artist.Nick_Deligaris);
            addTreachery("Counter-Spell", "Shadow and Flame")
                .WithTraits("Shadow.")
                .WithTextLine("When Revealed: Attach Counter-spell to Durin's Bane. (Counts as a Condition attachment with the text: 'Forced: When a player plays an event, discard the top card of the encounter deck. If that card is a treachery card, cancel the effects of the event, discard the event player's hand, and discard Counter-spell from play.')")
                .WithEasyModeQuantity(1)
                .WithInfo(145, 3, Artist.Magali_Villeneuve);
            addTreachery("Inner Flame", "Shadow and Flame")
                .WithTextLine("When Revealed: Durin's Bane gets +3 Attack until the end of the round. The first player may remove 1 questing hero he controls from the quest to cancel this effect.")
                .WithShadow("Shadow: If attacking enemy is Durin's Bane, it gets +3 Attack.")
                .WithInfo(146, 3, Artist.Matthew_Starbuck);
            addTreachery("Inner Shadow", "Shadow and Flame")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Heal 5 damage from Durin's Bane, if able. The first player may remove 1 questing hero he controls from the quest to cancel this effect.")
                .WithInfo(147, 3, Artist.Rafal_Hrynkiewicz);
            addTreachery("Whip Lash", "Shadow and Flame")
                .WithTextLine("When Revealed: Each player must discard 1 attachment he controls, if able.")
                .WithShadow("Shadow: If attacking enemy is Durin's Bane, the defending player discards all attachments he controls.")
                .WithInfo(148, 2, Artist.Timo_Karhula);
            addTreachery("Leaping Flame", "Shadow and Flame")
                .WithTextLine("When Revealed: Durin's Bane makes an immediate attack against the first player (deal and resolve a shadow card).")
                .WithShadow("Shadow: If attacking enemy is Durin's Bane, it gets +3 Attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(149, 3, Artist.Timo_Karhula);
            addEnemy("Durin's Bane", "Shadow and Flame", 1, 4, 6, 3, 27)
                .WithUnique()
                .WithTraits("Balrog.", "Flame.", "Shadow.")
                .WithKeywords("Regenerate 3.", "Indestructible.")
                .WithTextLine("Regenerate 3. Indestructible.")
                .WithTextLine("Players cannot play attachments on Durin's Bane. Durin's Bane cannot leave the staging area, is considered to be engaged with each player whose threat is 1 or greater, and attacks each of those players in turn during the combat phase (deal and discard a new shadow card each attack).")
                .WithAges(Age.First_Age, Age.Second_Age, Age.Third_Age)
                .WithInfo(150, 1, Artist.Magali_Villeneuve);
            addEnemy("Ranging Goblin", "Shadow and Flame", 35, 2, 1, 1, 2)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("When Revealed: Each player must deal 1 damage to a hero he controls.")
                .WithTextLine("Forced: After a character leaves play, shuffle Ranging Goblin and the top card in the encounter discard pile back into the encounter deck.")
                .WithInfo(151, 3, Artist.Jasper_Sandner);
            addTreachery("Fiery Sword", "Shadow and Flame")
                .WithUnique()
                .WithTraits("Weapon.", "Flame.")
                .WithTextLine("When Revealed: Attach Fiery Sword to Durin's Bane as a Weapon attachment with the text: 'Attached enemy gets +3 Attack.'")
                .WithInfo(152, 2, Artist.Timo_Karhula);
            addTreachery("Many Thonged Whip", "Shadow and Flame")
                .WithUnique()
                .WithTraits("Weapon.", "Flame.")
                .WithTextLine("When Revealed: Attach Many Thonged Whip to Durin's Bane as a Weapon attachment with the text: 'Forced: When Durin's Bane attacks, the defending player must discard 1 card at random from his hand.'")
                .WithInfo(153, 2, Artist.Timo_Karhula);
        }
    }
}
