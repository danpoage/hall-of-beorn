using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;

namespace HallOfBeorn.Models.Sets
{
    public class TheDruadanForest : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Drúadan Forest";
            NormalizedName = "The Druadan Forest";
            Abbreviation = "TDF";
            Number = 17;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Against the Shadow";

            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Mirlonde",
                Id = "536c80ba-ad8b-447e-b378-1684508eb0f9",
                CardType = CardType.Hero,
                Sphere = Sphere.Lore,
                ThreatCost = 8,
                IsUnique = true,
                Attack = 2,
                Defense = 1,
                Willpower = 2,
                HitPoints = 3,
                Traits = new List<string>() { "Silvan." },
                Text = "Each hero you control with a printed Lore resource icon gets -1 threat cost.",
                FlavorText = "\"...the Elves feared and distrusted the world outside...\"\r\n-The Fellowship of the Ring",
                Quantity = 1,
                Number = 32,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Forlong",
                Id = "c6ae1840-dd7d-46ea-baf8-6d30614506de",
                CardType = CardType.Ally,
                Sphere = Sphere.Leadership,
                ResourceCost = 3,
                IsUnique = true,
                Attack = 1,
                Defense = 1,
                Willpower = 1,
                HitPoints = 3,
                Traits = new List<string>() { "Outlands." },
                Text = "While you control Outlands allies that belong to 4 different spheres, ready Forlong at the beginning of each phase.",
                FlavorText = "\"Forlong!\" men shouted. \"True heart, true friend!\" -The Return of the King",
                Quantity = 3,
                Number = 33,
                Artist = Artist.Emile_Denis
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Strength of Arms",
                Id = "91f28bdf-4b78-4750-9853-65e783e4cb15",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                ResourceCost = 2,
                Text = "Play only if each hero you control has a printed Leadership resource icon.\r\nAction: Ready each ally in play.",
                FlavorText = "And so the companies came and were hailed and cheered and passed through the Gate, men of the Outlands marching to defend the City of Gondor in a dark hour... -The Return of the King",
                Quantity = 3,
                Number = 34,
                Artist = Artist.Jon_Bosco
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Mighty Prowess",
                Id = "4ed8bd53-0453-4490-a4bb-20a7d793c17f",
                CardType = CardType.Attachment,
                Sphere = Sphere.Tactics,
                ResourceCost = 1,
                Traits = new List<string>() { "Skill." },
                Text = "Attach to a Tactics hero. Limit 1 per hero.\r\nResponse: After attached hero attacks and destroys an enemy, deal 1 damage to another enemy that shares a Trait with the enemy just destroyed.",
                FlavorText = "He slew many of them and the rest fled. -The Two Towers",
                Quantity = 3,
                Number = 35,
                Artist = Artist.Blake_Henriksen
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Trained for War",
                Id = "5c7a6b89-0439-4b46-b9f1-09189f981a0d",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                ResourceCost = 2,
                Text = "Play only if each hero you control has the printed Tactics resource icon.\r\nAction: Until the end of the phase, if the current quest does not have Siege, it gains Battle.",
                Quantity = 3,
                Number = 36,
                Artist = Artist.Magali_Villeneuve,
                HasErrata = true
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Silvan Refugee",
                Id = "e4fd6e25-982a-464f-82d8-812269864d46",
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                ResourceCost = 1,
                Attack = 0,
                Defense = 0,
                Willpower = 2,
                HitPoints = 1,
                Traits = new List<string>() { "Silvan." },
                Text = "Forced: After a character leaves play, discard Silvan Refugee from play.",
                HtmlTemplate = "<p><b>Forced:</b> After a character leaves play, discard {self} from play.</p><p class='flavor-text'>&quot;The Elves have their own labours and their own sorrows...&quot;<br/>&ndash;Gildor, The Fellowship of the Ring</p>",
                FlavorText = "\"The Elves have their own labours and their own sorrows...\" -Gildor, The Fellowship of the Ring",
                Quantity = 3,
                Number = 37,
                Artist = Artist.Lorraine_Schleter
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Against the Shadow",
                Id = "0801c2c0-2bf7-4a0a-838a-13740f6cdbaf",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                ResourceCost = 2,
                Text = "Play only if each hero you control has the printed Spirit resource icon.\r\nAction: Until the end of the phase, Spirit characters use their Willpower instead of Defense.",
                FlavorText = "\"Courage will now be your best defense against the storm that is at hand...\" -Gandalf, The Return of the King",
                Quantity = 3,
                Number = 38,
                Artist = Artist.Andrew_Ryan
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Harbor Master",
                Id = "b7f8b82b-c448-4f43-a025-bf6b7e6f0310",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                ResourceCost = 3,
                Attack = 2,
                Defense = 0,
                Willpower = 1,
                HitPoints = 2,
                Traits = new List<string>() { "Noldor." },
                Text = "Response: After a card effect adds any number of resources to the resource pool of a hero you control, Harbor Master gains +1 Defense until the end of the round.",
                FlavorText = "For the Elves of the High Kindred had not yet forsaken Middle-earth, and they dwelt still at that time at the Grey Havens...-The Fellowship of the Ring",
                Quantity = 3,
                Number = 39,
                Artist = Artist.Kristina_Gehrmann
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Advance Warning",
                Id = "e678be7e-8048-458d-b4f9-25c2a718fabb",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                ResourceCost = 2,
                Text = "Play only if each hero you control has a printed Lore resource icon.\r\nAction: Until the end of the phase, enemies do not make engagement checks",
                FlavorText = "Suddenly he halted and listened. Had he heard a whistle or not? Or was it the call of some strange bird? -The Two Towers",
                Quantity = 3,
                Number = 40,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "White Tower Watchman",
                Id = "31cd848b-a1bc-4ccd-af0c-eb3cc3ba593b",
                CardType = CardType.Ally,
                Sphere = Sphere.Neutral,
                ResourceCost = 3,
                Attack = 0,
                Defense = 2,
                Willpower = 1,
                HitPoints = 3,
                Traits = new List<string>() { "Gondor." },
                Text = "If each hero you control belongs to the same sphere of influence, you may assign damage from undefended enemy attacks to White Tower Watchman instead of a hero you control.",
                FlavorText = "The watchmen cried aloud, and all men in the City stood to arms. -The Return of the King",
                Quantity = 3,
                Number = 41,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Drû-buri-Drû",
                NormalizedTitle = "Dru-buri-Dru",
                Id = "19b732b9-a26a-4535-a438-7dd83cd4ecf2",
                CardType = CardType.Enemy,
                EngagementCost = 1,
                IsUnique = true,
                Attack = 5,
                Defense = 3,
                HitPoints = 6,
                Traits = new List<string>() { "Wose." },
                Text = "Allies cannot defend against Drû-buri-Drû.\r\nWhile Drû-buri-Drû is in the victory display, characters get +1 Willpower and +1 Defense.\r\nUnless Drû-buri-Drû is in the victory display, the players cannot win.",
                Threat = 4,
                EncounterSet = "The Drúadan Forest",
                Quantity = 1,
                Number = 45,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Drúadan Drummer",
                NormalizedTitle = "Druadan Drummer",
                Id = "e2c02f11-fdfb-402b-89de-1729d1364e4c",
                CardType = CardType.Enemy,
                EngagementCost = 40,
                Attack = 1,
                Defense = 2,
                HitPoints = 2,
                Traits = new List<string>() { "Wose." },
                Text = "Each Wose enemy in the staging area gets +2 Threat.",
                Shadow = "Shadow: Each Wose enemy engaged with the defending player gets +1 Attack.",
                Threat = 0,
                EncounterSet = "The Drúadan Forest",
                Quantity = 3,
                EasyModeQuantity = 1,
                Number = 46,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Drúadan Elite",
                NormalizedTitle = "Druadan Elite",
                Id = "607c3e44-5add-4c80-bb3b-55b016b6cd0e",
                CardType = CardType.Enemy,
                EngagementCost = 35,
                Attack = 3,
                Defense = 2,
                HitPoints = 4,
                Traits = new List<string>() { "Wose." },
                Shadow = "Shadow: Return attacking enemy to the staging area after it attacks unless any player pays 1 resource.",
                Keywords = new List<string>() { "Archery 2.", " Prowl X." },
                Text = "X is the number of players in the game.",
                Threat = 2,
                EncounterSet = "The Drúadan Forest",
                Quantity = 3,
                Number = 47,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Drúadan Hunter",
                NormalizedTitle = "Druadan Hunter",
                Id = "809ff5de-8273-4491-adfb-3a27d4b316f3",
                CardType = CardType.Enemy,
                EngagementCost = 25,
                Attack = 4,
                Defense = 3,
                HitPoints = 3,
                Traits = new List<string>() { "Wose." },
                Shadow = "Shadow: Attacking enemy gets +2 Attack.",
                Keywords = new List<string>() { "Prowl 1.", " Archery X." },
                Text = "X is the number of heroes in play with no resources in their resource pool.",
                Threat = 2,
                EncounterSet = "The Drúadan Forest",
                Quantity = 4,
                EasyModeQuantity = 2,
                Number = 48,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Drúadan Thief",
                NormalizedTitle = "Druadan Thief",
                Id = "85045e14-3abc-4d58-824f-249b1fb3643d",
                CardType = CardType.Enemy,
                EngagementCost = 5,
                Attack = 2,
                Defense = 1,
                HitPoints = 2,
                Traits = new List<string>() { "Wose." },
                Shadow = "Shadow: Return attacking enemy to the staging area after it attacks unless any player pays 1 resource.",
                Keywords = new List<string>() { "Surge.", " Prowl 1." },
                Threat = 2,
                EncounterSet = "The Drúadan Forest",
                Quantity = 3,
                Number = 49,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Ancestral Clearing",
                Id = "0ebedc5b-fd8b-46b8-a2a1-1a6f739e8819",
                CardType = CardType.Location,
                Traits = new List<string>() { "Forest." },
                Text = "The cost to play each player card is increased by 1.\r\nTravel: Exhaust a hero to travel here.",
                FlavorText = "\"They still haunt The Drúadan Forest...\" -Elfhelm, The Return of the King",
                Threat = 4,
                QuestPoints = 3,
                EncounterSet = "The Drúadan Forest",
                Quantity = 1,
                EasyModeQuantity = 0,
                Number = 50,
                Artist = Artist.Grzegorz_Pedrycz
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Garden of Poisons",
                Id = "41c3779a-a28a-44db-8b9b-bc5e81d1111a",
                CardType = CardType.Location,
                Traits = new List<string>() { "Forest." },
                Text = "Heroes cannot gain resources from card effects.\r\nTravel: Each player must pay 1 resource to travel here.",
                FlavorText = "\"...they use poisoned arrows, it is said...\" - Elfhelm, The Return of the King",
                Threat = 2,
                QuestPoints = 3,
                EncounterSet = "The Drúadan Forest",
                Quantity = 3,
                Number = 51,
                Artist = Artist.Simon_Dominic
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Glade of Cleansing",
                Id = "801078c6-56a9-45f2-b5a4-7e38cb5bc507",
                CardType = CardType.Location,
                Traits = new List<string>() { "Forest." },
                Text = "Each Wose enemy gains Archery 1.\r\nX is equal to the total archery value of the highest archery Wose enemy in play.",
                FlavorText = "\"...they are woodcrafty beyond compare.\" -Elfhelm, The Return of the King",
                Threat = 0,
                IsVariableThreat = true,
                QuestPoints = 5,
                EncounterSet = "The Drúadan Forest",
                Quantity = 3,
                EasyModeQuantity = 1,
                Number = 52,
                Artist = Artist.Titus_Lunter
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Men in the Dark",
                Id = "24e431be-cde9-4f93-943a-de5e5ca9108b",
                CardType = CardType.Treachery,
                Text = "When Revealed: Each hero must pay 1 resource or take 1 damage. If no hero takes damage from this effect, Men in the Dark gains surge.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack for each hero the defending player controls with no resources.",
                EncounterSet = "The Drúadan Forest",
                Quantity = 3,
                Number = 53,
                Artist = Artist.Marcia_George_Bogdan
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Stars in Sky",
                Id = "7cbf23fd-28c4-494c-97aa-b7fed050ad8b",
                CardType = CardType.Treachery,
                Text = "When Revealed: Each questing hero must pay 1 resource or it is removed from the quest.",
                Shadow = "Shadow: Discard all resources from the defending character's resource pool.",
                Keywords = new List<string>() { "Prowl 2." },
                EncounterSet = "The Drúadan Forest",
                Quantity = 3,
                Number = 54,
                Artist = Artist.Blake_Henriksen
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Leaves on Tree",
                Id = "9dda3cf1-e5bd-4cab-8c3b-b29db1220249",
                CardType = CardType.Treachery,
                Text = "When Revealed: Each player must pay 1 resource for each attachment he controls or discard all attachments he controls.",
                Shadow = "Shadow: Discard an attachment from the defending character.",
                Keywords = new List<string>() { "Surge." },
                EncounterSet = "The Drúadan Forest",
                Quantity = 2,
                Number = 55,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "The Pursuit",
                StageNumber = 1,
                Id = "71079813-3afe-41b7-8746-92dcc1f91084",
                CardType = CardType.Quest,
                Text = "Setup: Search the encounter deck for Drû-buri-Drû and set him aside, out of play. Shuffle the encounter deck.",
                FlavorText = "The leader of the underworld cabal from Minas Tirith has fled with his remaining henchmen. You have followed his trail to The Drúadan Forest, hoping to bring the nameless villain to justice.",
                OppositeText = "When Revealed: Reveal 1 card from the encounter deck per player and add it to the staging area.",
                OppositeFlavorText = "The Drúadan Forest is a wild and dangerous place. It is said that Woses, reclusive forest dwellers, still reside among the trees. You wonder if your quarry has considered the dangers of this course.",
                EncounterSet = "The Drúadan Forest",
                Quantity = 1,
                QuestPoints = 11,
                Number = 42,
                Artist = Artist.Emile_Denis,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.BroodingForest }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "An Untimely End",
                StageNumber = 2,
                Id = "346fda89-94df-410a-8027-41eacbf27238",
                CardType = CardType.Quest,
                EncounterSet = "The Drúadan Forest",
                FlavorText = "As you move deeper into the forest, the wilderness quickly swallows all trace of civilization. Pushing through a dense patch of undergrowth, you came upon a dark and tangled grove. The scent of death strikes you.",
                OppositeText = "Archery damage must be assigned to allies, if able.",
                OppositeFlavorText = "In the grove, the fleeing traitors lie slain, pierced by poisoned arrows. As you search the pain-wracked corpses for the body of their leader, the ominous echo of drums begins to sound among the trees. You desperately begin to retrace your steps from the woods, lest the fate of the traitors becomes your own.",
                Quantity = 1,
                QuestPoints = 17,
                Number = 43,
                Artist = Artist.Adam_Lane,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.BroodingForest }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "The Passage Out",
                StageNumber = 3,
                Id = "f6578eb7-1b94-458b-aba1-82b406507a4d",
                CardType = CardType.Quest,
                Keywords = new List<string> { "Siege." },
                Text = "When Revealed: Add Drû-buri-Drû to the staging area.",
                FlavorText = "You sense that the edge of the forest must be near at hand, but Woses are master huntsmen and a band of them block your path. your situation seems hopeless: there are simply too many of them. As they begin their attack, you realize your only hope of survival is to convince the Pukel-men that you are not their enemy.",
                OppositeText =
@"Characters use their Willpower instead of Attack when attacking enemies. If an enemy would be damaged this way, place progress tokens on it instead of damage tokens. When an enemy has progress equal to its hit points, add it to the victory display and place those progress tokens on the quest.

If the players defeat this stage, they have won the game.",
                EncounterSet = "The Drúadan Forest",
                Quantity = 1,
                QuestPoints = 14,
                Number = 44,
                Artist = Artist.Jason_Ward,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.BroodingForest }
            });
        }
    }
}
