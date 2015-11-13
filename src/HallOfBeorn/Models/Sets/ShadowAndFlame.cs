using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;

namespace HallOfBeorn.Models.Sets
{
    public class ShadowandFlame : CardSet
    {
        protected override void Initialize()
        {
            Name = "Shadow and Flame";
            Abbreviation = "SaF";
            Number = 14;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dwarrowdelf";

            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Counter-Spell",
                Id = "51223bd0-ffd1-11df-a976-0801213c9001",
                CardType = CardType.Treachery,
                EncounterSet = "Shadow and Flame",
                Traits = new List<string>() { "Shadow." },
                Quantity = 3,
                EasyModeQuantity = 1,
                Text = "When Revealed: Attach Counter-spell to Durin's Bane. (Counts as a Condition attachment with the text: 'Forced: When a player plays an event, discard the top card of the encounter deck. If that card is a treachery card, cancel the effects of the event, discard the event player's hand, and discard Counter-spell from play.')",
                HtmlTemplate = "<p><b>When Revealed:</b> Attach {self} to {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane}. Counts as a {trait:Condition.@Condition} attachment with the text:<blockquote><b>Forced:</b> When a player plays an {type:Event@event}, discard the top card of the encounter deck. If that card is a treachery card, cancel the effects of the event, discard the event player's hand, and discard Counter-spell from play.</blockquote></p>",
                Number = 145,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Dark Pit",
                Id = "51223bd0-ffd1-11df-a976-0801213c9002",
                CardType = CardType.Location,
                EncounterSet = "Shadow and Flame",
                Traits = new List<string>() { "Underground.", " Dark." },
                Quantity = 1,
                Text = "While Dark Pit is the active location it gains: 'Refresh Action: Exhaust X characters (maximum 3) you control to discard the top X cards of your deck. If all discarded cards have a higher combined printed cost than the remaining hit points of Durin's Bane, discard Durin's Bane from play.'",
                HtmlTemplate = "<p>While {self} is the active location it gains:<blockquote><b>Refresh Action:</b> Exhaust X characters (maximum 3) you control to discard the top X cards of your deck. If all discarded cards have a higher combined printed cost than the remaining hit points of {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane}, discard {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} from play.</blockquote></p>",
                Threat = 0,
                QuestPoints = 11,
                Number = 141,
                Artist = Artist.Igor_Kieryluk
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Durin's Bane",
                Id = "51223bd0-ffd1-11df-a976-0801213c9003",
                CardType = CardType.Enemy,
                EncounterSet = "Shadow and Flame",
                Traits = new List<string>() { "Balrog.", " Flame.", " Shadow." },
                Quantity = 1,
                EngagementCost = 1,
                IsUnique = true,
                Attack = 6,
                Defense = 3,
                HitPoints = 27,
                Text = "Players cannot play attachments on Durin's Bane.Durin's Bane cannot leave the staging area, is considered to be engaged with each player whose threat is 1 or greater, and attacks each of those players in turn during the combat phase (deal and discard a new shadow card each attack).",
                Keywords = new List<string>() { "Regenerate 3.", " Indestructible." },
                HtmlTemplate = "<p>{keyword:Regenerate 3.} {keyword:Indestructible.} Players cannot play attachments on {self}.</p><p>{self} cannot leave the staging area, is considered to be engaged with each player whose threat is 1 or greater, and attacks each of those players in turn during the combat phase <i>(deal and discard a new shadow card each attack)</i>.</p>",
                Threat = 4,
                Number = 150,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Elrond",
                Id = "51223bd0-ffd1-11df-a976-0801213c9004",
                CardType = CardType.Hero,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Noldor.", " Noble." },
                Quantity = 1,
                ThreatCost = 13,
                IsUnique = true,
                Attack = 2,
                Defense = 3,
                Willpower = 3,
                HitPoints = 4,
                Text = "You may spend resources from Elrond's resource pool to pay for Spirit, Leadership, and Tactics allies.\r\nResponse: After a character is healed by another card effect, heal 1 damage on it.",
                FlavorText = "\"But you do not stand alone.\"\r\n-The Fellowship of the Ring",
                HtmlTemplate = "<p>You may spend resources from {self}'s resource pool to pay for {sphere:Spirit}, {sphere:Leadership}, and {sphere:Tactics} {type:Ally@allies.}</p><p><b>Response:</b> After a character is healed by another card effect, heal 1 damage on it.</p><p class='flavor-text'>&quot;But you do not stand alone.&quot;<br>&ndash;The Fellowship of the Ring</p>",
                Number = 128,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Fiery Sword",
                Id = "51223bd0-ffd1-11df-a976-0801213c9005",
                CardType = CardType.Treachery,
                EncounterSet = "Shadow and Flame",
                Traits = new List<string>() { "Weapon.", " Flame." },
                Quantity = 2,
                IsUnique = true,
                Text = "When Revealed: Attach Fiery Sword to Durin's Bane as a Weapon attachment with the text: 'Attached enemy gets +3 Attack.'",
                HtmlTemplate = "<p><b>When Revealed:</b> Attach {self} to {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} as a {trait:Weapon.@Weapon} attachment with the text:<blockquote>Attached enemy gets +3 {Attack}.</blockquote></p><p class='flavor-text'>In its right hand was a blade like a stabbing tongue of fire...<br>&ndash;The Fellowship of the Ring</p>",
                Number = 152,
                Artist = Artist.Timo_Karhula
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Fires in the Deep",
                Id = "51223bd0-ffd1-11df-a976-0801213c9006",
                CardType = CardType.Treachery,
                EncounterSet = "Shadow and Flame",
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "When Revealed: Each player must discard 1 ally he controls, if able. If Fires in the Deep discarded no allies, it gains surge.",
                Shadow = "Shadow: The defending player discards 1 ally he controls, if able.",
                Number = 144,
                Artist = Artist.Nick_Deligaris
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Hands Upon the Bow",
                Id = "51223bd0-ffd1-11df-a976-0801213c9007",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                Quantity = 3,
                ResourceCost = 1,
                Text = "Action: Exhaust a character you control with ranged to immediately declare it as an attacker (and resolve its attack) against an enemy in the staging area. It gets +1 Attack during this attack.",
                HtmlTemplate = "<p><b>Action:</b> Exhaust a character you control with {keyword:Ranged.@ranged} to immediately declare it as an attacker (and resolve its attack) against an enemy in the staging area. It gets +1 {attack} during this attack.</p><p class='flavor-text'>&quot;We live now upon an island amid perils, and our hands are more often upon thr bowstring than upon the harp.&quot;<br/>&ndash;Haldir, The Fellowship of the Ring</p>",
                Number = 131,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Hardy Leadership",
                Id = "51223bd0-ffd1-11df-a976-0801213c9008",
                CardType = CardType.Attachment,
                Sphere = Sphere.Leadership,
                Quantity = 3,
                ResourceCost = 2,
                IsUnique = true,
                Text = "Attach to a Leadership hero.\r\nEach Dwarf character gets +1 hit point.",
                HtmlTemplate = "<p>Attach to a {sphere-hero:Leadership}.</p><p>Each {trait-character:Dwarf.@Dwarf} gets +1 hit point.</p><p class='flavor-text'>&quot;We will seek the hidden door together. And we will come through. In the ruins of of the Dwarves, a dwarf's head will be less easy to bewilder than Elves or Men or Hobbits.&quot;<br>&ndash;Gandalf, The Fellowship of the Ring</p>",
                Number = 130,
                Artist = Artist.Jake_Murray
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Inner Flame",
                Id = "51223bd0-ffd1-11df-a976-0801213c9009",
                CardType = CardType.Treachery,
                EncounterSet = "Shadow and Flame",
                Quantity = 3,
                Text = "When Revealed: Durin's Bane gets +3 Attack until the end of the round. The first player may remove 1 questing hero he controls from the quest to cancel this effect.",
                Shadow = "Shadow: If attacking enemy is Durin's Bane, it gets +3 Attack.",
                HtmlTemplate = "<p><b>When Revealed:</b> {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} gets +3 {Attack} until the end of the round. The first player may remove 1 questing hero he controls from the quest to cancel the effect.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> If attacking enemy is {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane}, it gets +3 {Attack}.</p>",
                Number = 146,
                Artist = Artist.Matthew_Starbuck
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Inner Shadow",
                Id = "51223bd0-ffd1-11df-a976-0801213c9010",
                CardType = CardType.Treachery,
                EncounterSet = "Shadow and Flame",
                Quantity = 3,
                Text = "When Revealed: Heal 5 damage from Durin's Bane, if able. The first player may remove 1 questing hero he controls from the quest to cancel this effect.",
                Keywords = new List<string>() { "Surge." },
                HtmlTemplate = "<p>{keyword:Surge.}</p><p><b>When Revealed:</b> Heal 5 damage from {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane}, if able. The first player may remove 1 questing hero he controls from the quest to cancel this effect.</p><p class='flavor-text'>The fire in it seemed to die, but the darkness grew.<br>&ndash;The Fellowship of the Ring</p>",
                Number = 147,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Last Lord of Moria",
                StageNumber = 3,
                Id = "51223bd0-ffd1-11df-a976-0801213c9011",
                CardType = CardType.Quest,
                EncounterSet = "Shadow and Flame",
                FlavorText = "There is a crumbling pile of boulders on the edge of a teetering cliff, and it gives you a sudden idea. There are chasms and pits along the path you are traveling, and perhaps a well-timed rockslide could send the Balrog down into the depths below...",
                OppositeText = "When Revealed: Durin's Bane makes an immediate attack on the first player. Add Dark Pit to the staging area.\r\nPlayers cannot win the game while Durin's Bane is in play. If Durin's Bane leaves play by the effect on Dark Pit, the players have won the game.",
                HtmlTemplate = "<p class='flavor-text'>There is a crumbling pile of boulders on the edge of a teetering cliff, and it gives you a sudden idea. There are chasms and pits along the path you are traveling, and perhaps a well-timed rockslide could send the Balrog down into the depths below...</p>",
                HtmlTemplate2 = "<p><b>When Revealed:</b> {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} makes an immediate attack on the first player. Add {card:Dark-Pit-SaF@Dark Pit} to the staging area.</p><p><b>Players cannot win the game while {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} is in play. If {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} leaves play by the effect on {card:Dark-Pit-SaF@Dark Pit}, the players have won the game.</b></p>",
                Quantity = 1,
                QuestPoints = 1,
                Number = 140,
                Artist = Artist.Dmitry_Burmak,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.GoblinsOfTheDeep, EncounterSet.DeepsOfMoria }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Leaping Flame",
                Id = "51223bd0-ffd1-11df-a976-0801213c9013",
                CardType = CardType.Treachery,
                EncounterSet = "Shadow and Flame",
                Quantity = 3,
                EasyModeQuantity = 1,
                Text = "When Revealed: Durin's Bane makes an immediate attack against the first player (deal and resolve a shadow card).",
                Shadow = "Shadow: If attacking enemy is Durin's Bane, it gets +3 Attack.",
                HtmlTemplate = "<p><b>When Revealed:</b> {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} makes an immediate attack against the first player <i>(deal and resolve a shadow card).</i></p>{shadow}</p class='shadow-text'><b>Shadow:</b> If attacking enemy is {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane}, it gets +3 {Attack}.</p>",
                Number = 149,
                Artist = Artist.Timo_Karhula
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Many Thonged Whip",
                Id = "51223bd0-ffd1-11df-a976-0801213c9014",
                CardType = CardType.Treachery,
                EncounterSet = "Shadow and Flame",
                Traits = new List<string>() { "Weapon.", " Flame." },
                Quantity = 2,
                IsUnique = true,
                Text = "When Revealed: Attach Many Thonged Whip to Durin's Bane as a Weapon attachment with the text: 'Forced: When Durin's Bane attacks, the defending player must discard 1 card at random from his hand.'",
                HtmlTemplate = "<p><b>When Revealed:</b> Attach {self} to {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} as a {trait:Weapon.@Weapon} attachment with the text:<blockquote><b>Forced:</b> When {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} attacks, the defending player must discard 1 card at random from his hand.</blockquote></p><p class='flavor-text'>...in its left it held a whip of many thongs.<br>&ndash;The Fellowship of the Ring</p>'",
                Number = 153,
                Artist = Artist.Timo_Karhula
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Master of the Forge",
                Id = "51223bd0-ffd1-11df-a976-0801213c9015",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Noldor.", " Craftsman." },
                Quantity = 3,
                ResourceCost = 2,
                Attack = 0,
                Defense = 1,
                Willpower = 0,
                HitPoints = 1,
                Text = "Action: Exhaust Master of the Forge to search the top 5 cards of your deck for any 1 attachment and add it to your hand. Shuffle the other cards back into your deck.",
                Number = 134,
                Artist = Artist.Paul_Guzenko
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Miruvor",
                Id = "51223bd0-ffd1-11df-a976-0801213c9016",
                CardType = CardType.Attachment,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Item." },
                Quantity = 3,
                ResourceCost = 1,
                Text = "Attach to a hero.\r\nAction: Discard Miruvor to (choose two): ready attached hero, add 1 resource to attached hero's resource pool, attached hero gets +1 Willpower until the end of the round, or put Miruvor on the top of your deck.",
                Number = 133,
                Artist = Artist.Sara_Biddle
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Nearing the Gate",
                StageNumber = 1,
                Id = "51223bd0-ffd1-11df-a976-0801213c9017",
                CardType = CardType.Quest,
                EncounterSet = "Shadow and Flame",
                Quantity = 1,
                QuestPoints = 9,
                FlavorText = "As you reach the eastern realm of Darrowdelf the craftsmanship of the Dwarves is proudly displayed. But the sound of drums sound in the deep, and it appears that these halls are infested with Orcs.",
                OppositeFlavorText = "A crack like lightning sounds before you, and a creature of shadow and flame blocks your way. It is an ancient demon of Morgoth, and its presence explains the massing in Moria.",
                Setup = "ts",
                Text = "Setup: Remove Dark Pit from the encounter deck and place it aside, out of play. Add Durin's Bane to the staging area. Shuffle the encounter deck.",
                OppositeText = "When Revealed: Reduce each player's threat to 0. Reveal X cards from the encounter deck, where X is one less than the number of players in the game, and add them to the staging area.",
                HtmlTemplate = "<p class='flavor-text'>As you reach the eastern realm of Darrowdelf the craftsmanship of the Dwarves is proudly displayed. But the sound of drums sound in the deep, and it appears that these halls are infested with Orcs.</p><p><b>Setup:</b> Remove {card:Dark-Pit-SaF@Dark Pit} from the encounter deck and place it aside, out of play. Add {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} to the staging area. Shuffle the encounter deck.</p>",
                HtmlTemplate2 = "<p class='flavor-text'>A crack like lightning sounds before you, and a creature of shadow and flame blocks your way. It is an ancient demon of Morgoth, and its presence explains the massing in Moria.</p><p><b>When Revealed:</b> Reduce each player's threat to 0. Reveal X cards from the encounter deck, where X is one less than the number of players in the game, and add them to the staging area.</p>",
                Number = 138,
                Artist = Artist.Ben_Zweifel,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.GoblinsOfTheDeep, EncounterSet.DeepsOfMoria }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "O Elbereth! Gilthonial!",
                Id = "51223bd0-ffd1-11df-a976-0801213c9019",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                Quantity = 3,
                ResourceCost = 4,
                Text = "Response: After an enemy attacks you, put that enemy on the bottom of the encounter deck. If your threat is lower than that enemy's engagement cost, set your threat equal to the engagement cost of that enemy.",
                Keywords = new List<string>() { "Secrecy 4." },
                Number = 132,
                Artist = Artist.Aaron_B_Miller,
                HasErrata = true
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Peace, and Thought",
                NormalizedTitle = "Peace and Thought",
                Id = "51223bd0-ffd1-11df-a976-0801213c9020",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                Quantity = 3,
                ResourceCost = 1,
                Text = "Refresh Action: Exhaust 2 heroes to draw 5 cards.",
                HtmlTemplate = "<p><b>Refresh Action:</b> Exhaust 2 heroes to draw 5 cards.</p><p class='flavor-text'>&quot;Here you will hear many songs and tales-if you can keep awake. But except on high days it usually stands empty and quiet. and people come here who wish for peace, and thought. There is always a fire here, all the year round, but there is little other light.&quot;<br>&ndash;Gandalf, The Fellowship of the Ring</p>",
                Number = 135,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Ranging Goblin",
                Id = "51223bd0-ffd1-11df-a976-0801213c9021",
                CardType = CardType.Enemy,
                EncounterSet = "Shadow and Flame",
                Traits = new List<string>() { "Goblin.", " Orc." },
                Quantity = 3,
                EngagementCost = 35,
                Attack = 1,
                Defense = 1,
                HitPoints = 2,
                Text = "When Revealed: Each player must deal 1 damage to a hero he controls.\r\nForced: After a character leaves play, shuffle Ranging Goblin and the top card in the encounter discard pile back into the encounter deck.",
                HtmlTemplate = "<p><b>When Revealed:</b> Each player must deal 1 damage to a hero he controls.</p><p><b>Forced:</b> After a character leaves play, shuffle {self} and the top card in the encounter discard pile back into the encounter deck.</p>",
                Threat = 2,
                Number = 151,
                Artist = Artist.Jasper_Sandner
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Risk Some Light",
                Id = "51223bd0-ffd1-11df-a976-0801213c9022",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                Quantity = 3,
                ResourceCost = 3,
                Text = "Action: Look at the top 3 cards of the encounter deck. You may select 1 card and move it to the bottom of the encounter deck. Return any unselected cards to the top of the encounter deck, in any order.",
                Keywords = new List<string>() { "Secrecy 3." },
                Number = 136,
                Artist = Artist.Dmitry_Burmak
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Second Deep",
                Id = "51223bd0-ffd1-11df-a976-0801213c9023",
                CardType = CardType.Location,
                EncounterSet = "Shadow and Flame",
                Traits = new List<string>() { "Underground." },
                Quantity = 3,
                Text = "While Durin's Bane has no damage on it, progress tokens cannot be placed on Second Deep.",
                HtmlTemplate = "<p>While {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} has no damage on it, progress tokens cannot be placed on {self}.</p>",
                Threat = 3,
                QuestPoints = 3,
                Number = 143,
                Artist = Artist.Nick_Deligaris
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Second Hall",
                Id = "51223bd0-ffd1-11df-a976-0801213c9024",
                CardType = CardType.Location,
                EncounterSet = "Shadow and Flame",
                Traits = new List<string>() { "Underground." },
                Quantity = 1,
                IsUnique = true,
                Text = "While Second Hall is the active location, it gains: 'Forced: After a character leaves play, reveal 1 card from the encounter deck and add it to the staging area.'",
                FlavorText = "Down the centre stalked a double line of towering pillars. They were carved like boles of mighty trees whose boughs upheld the roof with a branching tracery of stone. -The Fellowship of the Ring",
                HtmlTemplate = "<p>While {self} is the active location, it gains:<blockquote><b>Forced:</b> After a character leaves play, reveal 1 card from the encounter deck and add it to the staging area.</blockquote></p><p class='flavor-text'>Down the centre stalked a double line of towering pillars. They were carved like boles of mighty trees whose boughs upheld the roof with a branching tracery of stone.<br>&ndash;The Fellowship of the Ring</p>",
                Threat = 4,
                QuestPoints = 2,
                Number = 142,
                Artist = Artist.Ben_Zweifel
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "The Rear Guard",
                StageNumber = 2,
                Id = "51223bd0-ffd1-11df-a976-0801213c9025",
                CardType = CardType.Quest,
                EncounterSet = "Shadow and Flame",
                FlavorText = "The fire-demon is Durin's Bane, doom of the Dwarves and the new Lord of Moria. It cannot be destroyed by mere strength of arms. You must find another way to deal with this Balrog as it relentlessly attacks, sword and whip weaving a deadly pattern of flame.",
                OppositeText = "Forced: If at least 1 hero committed to the quest this round, place 4 progress tokens on The Rear Guard (bypassing any active location) at the end of the quest phase.\r\nIf Durin's Bane has 0 hit points, advance to the next stage of the scenario immediately.",
                HtmlTemplate = "<p class='flavor-text'>The fire-demon is Durin's Bane, doom of the Dwarves and the new Lord of Moria. It cannot be destroyed by mere strength of arms. You must find another way to deal with this Balrog as it relentlessly attacks, sword and whip weaving a deadly pattern of flame.</p>",
                HtmlTemplate2 = "<p><b>Forced:</b> If at least 1 hero committed to the quest this round, place 4 progress tokens on {self} <i>(bypassing the active location)</i> at the end of the quest phase.</p><p><b>If {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane} has 0 hit points, advance to {card:Last-Lord-of-Moria-SaF@the next stage} of the scenario immediately.</b></p>",
                Quantity = 1,
                QuestPoints = 16,
                Number = 139,
                Artist = Artist.Jason_Juta,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.GoblinsOfTheDeep, EncounterSet.DeepsOfMoria }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Vilya",
                Id = "51223bd0-ffd1-11df-a976-0801213c9027",
                CardType = CardType.Attachment,
                Sphere = Sphere.Neutral,
                Traits = new List<string>() { "Ring.", " Artifact." },
                Quantity = 3,
                ResourceCost = 2,
                IsUnique = true,
                Text = "Attach to Elrond. He gains a Spirit resource icon.\r\nAction: Exhaust Elrond and Vilya to reveal the top card of your deck. You can immediately play or put into play the revealed card for no cost, if able. Otherwise, move the revealed card to the bottom of your deck.",
                FlavorText = "...mightiest of the Three. -Return of the King",
                HtmlTemplate = "<p>Attach to {title:Elrond}. He gains a {sphere:Spirit} resource icon.</p><p><b>Action:</b> Exhaust {title:Elrond} and {self} to reveal the top card of your deck. You can immediately play or put into play the revealed card for no cost, if able. Otherwise, move the revealed card to the bottom of your deck.</p><p class='flavor-text'>...mightiest of the Three. &ndash;The Return of the King</p>",
                Number = 137,
                Artist = Artist.Sara_Biddle
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "We Are Not Idle",
                Id = "51223bd0-ffd1-11df-a976-0801213c9028",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                Quantity = 3,
                ResourceCost = 0,
                Text = "Action: Exhaust X Dwarf characters to add X resources to a hero's resource pool and draw 1 card.",
                FlavorText = "\"You should see the stone-paved roads of many colours! And the halls and cavernous streets under the earth with arches carved like trees; and the terraces and towers upon the Mountain's sides! Then you would see that we have not been idle.\" -Glóin, The Fellowship of the Ring",
                Number = 129,
                Artist = Artist.Charles_Urbach
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Whip Lash",
                Id = "51223bd0-ffd1-11df-a976-0801213c9029",
                CardType = CardType.Treachery,
                EncounterSet = "Shadow and Flame",
                Quantity = 2,
                Text = "When Revealed: Each player must discard 1 attachment he controls, if able.",
                Shadow = "Shadow: If attacking enemy is Durin's Bane, the defending player discards all attachments he controls.",
                HtmlTemplate = "<p><b>When Revealed:</b> Each player must discard 1 attachment he controls, if able.</p>{shadow}<p><b>Shadow:</b> If attacking enemy is {card:Durin&#39;s-Bane-SaF@Durin&#39;s Bane}, the defending player discards all attachments he controls.</p>",
                Number = 148,
                Artist = Artist.Timo_Karhula
            });
        }
    }
}
