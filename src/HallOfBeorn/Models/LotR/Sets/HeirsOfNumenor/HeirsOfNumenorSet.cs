using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;

namespace HallOfBeorn.Models.LotR.Sets.HeirsOfNumenor
{
    public class HeirsofNumenorSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Heirs of Númenor";
            Abbreviation = "HoN";
            Number = 15;
            SetType = Models.SetType.Deluxe_Expansion;

            Cards.Add(new LotRCard() {
                
                Title = "Alcaron's Scroll",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9001",
                CardType = CardType.Objective,
                IsUnique = true,
                Quantity = 1,
                Text = "If unattached, return Alcaron's Scroll to the staging area and it gains: 'Action: Exhaust a hero to attach Alcaron's Scroll to that hero.'Forced: When the hero with Alcaron's Scroll attached is damaged by an enemy attack, attach Alcaron's Scroll to that enemy.",
                EncounterSet = "Peril in Pelargir",
                CardNumber = 19,
                Artist = Artist.Jason_Ward
            }.WithTraits("Scroll."));
            Cards.Add(new LotRCard() {
                
                Title = "A Watchful Peace",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9002",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                ResourceCost = 1,
                Quantity = 3,
                Text = "Response: After a location worth no victory points leaves play as an explored location, return it to the top of the encounter deck.",
                CardNumber = 12,
                Artist = Artist.Titus_Lunter,
                HasErrata = true
            });
            Cards.Add(new LotRCard() {
                Title = "Battering Ram",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9003",
                CardType = CardType.Enemy,
                Quantity = 3,
                EasyModeQuantity = 2,
                HitPoints = 5,
                Attack = 7,
                Defense = 3,
                Text = "When Revealed: If the active location is a Battleground, deal 3 damage to it.",
                EncounterSet = "The Siege of Cair Andros",
                EngagementCost = 33,
                Shadow = "Shadow: Deal 2 damage to The Approach if it is in play. Otherwise, attacking enemy gets +2 Attack.",
                Threat = 2,
                CardNumber = 31,
                Artist = Artist.Lin_Bo
            }.WithTraits("Besieger.")
            .WithKeywords("Doomed 2."));
            Cards.Add(new LotRCard() {
                Title = "Behind Strong Walls",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9004",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                ResourceCost = 1,
                Quantity = 3,
                Text = "Action: Ready a defending Gondor character. That character gets +1 Defense until the end of the phase.",
                FlavorText = "...seven walls of stone so strong and old that it seemed to have been not builded by carven by giants out of the bones of the earth. -The Return of the King",
                CardNumber = 8,
                Artist = Artist.Matt_Smith
            });
            Cards.Add(new LotRCard() {
                
                Title = "Beregond",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9005",
                CardType = CardType.Hero,
                Sphere = Sphere.Tactics,
                IsUnique = true,
                Keywords = new List<string>() { "Sentinel." },
                ThreatCost = 10,
                Quantity = 1,
                Traits = new List<string>() { "Gondor.", " Warrior." },
                Willpower = 0,
                HitPoints = 4,
                Attack = 1,
                Defense = 4,
                Text = "Lower the cost to play Weapon and Armor attachments on Beregond by 2.",
                FlavorText = "\"It is over-late to send for aid when you are already besieged.\" -The Return of the King",
                HtmlTemplate = "<p>{keyword:Sentinel.}</p><p>Lower the cost to play {traits-attachment:Weapon,Armor@attachments} on {self} by 2.</p><p class='flavor-text'>&quot;It is over-late to send for aid when you are already besiged.&quot; &ndash;The Return of the King</p>",
                CardNumber = 1,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Blocking Wargs",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9006",
                CardType = CardType.Treachery,
                Keywords = new List<string>() { "Surge." },
                Quantity = 4,
                EasyModeQuantity = 2,
                Text = "When Revealed: Deal 1 damage to each character committed to the quest.",
                EncounterSet = "Into Ithilien",
                Shadow = "Shadow: Deal 1 damage to the defending character.",
                CardNumber = 29,
                Artist = Artist.Marcia_George_Bogdan,
                HasErrata = true
            });
            Cards.Add(new LotRCard() {
                
                Title = "Blood of Númenor",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9007",
                CardType = CardType.Attachment,
                Sphere = Sphere.Spirit,
                ResourceCost = 0,
                Quantity = 3,
                Traits = new List<string>() { "Condition." },
                Text = "Attach to a Gondor or Dúnedain hero.\r\nAction: Spend 1 resource from attached hero's resource pool to give attached hero +1 Defense for each resource in its resource pool until the end of the phase. (Limit once per phase.)",
                FlavorText = "\"Believe not that in the land of Gondor the blood of Numenor is spent, nor all its pride and dignity forgotten.\" -Boromir, The Fellowship of the Ring",
                CardNumber = 13,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Boromir",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9008",
                CardType = CardType.Hero,
                Sphere = Sphere.Leadership,
                IsUnique = true,
                ThreatCost = 11,
                Quantity = 1,
                Traits = new List<string>() { "Gondor.", " Warrior.", " Noble." },
                Willpower = 1,
                HitPoints = 5,
                Attack = 3,
                Defense = 2,
                Text = "While Boromir has at least 1 resource in his resource pool, Gondor allies get +1 Attack.",
                FlavorText = "\"By our valour the wild fold of the East are still restrained, and the terror of Morgul kept at bay...\" -The Fellowship of the Ring",
                CardNumber = 2,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Celador",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9009",
                CardType = CardType.Objective,
                IsUnique = true,
                Quantity = 1,
                Traits = new List<string>() { "Gondor.", " Ranger." },
                Willpower = 2,
                HitPoints = 3,
                Attack = 2,
                Defense = 2,
                Text = "While Celador is in the staging area, he is committed to the current quest.\r\nForced: After players quest unsuccessfully or a character leaves play, deal 1 damage to Celador.\r\nIf Celador leaves play, remove him from the game.",
                EncounterSet = "Into Ithilien",
                CardNumber = 25,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Citadel Custodian",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9010",
                CardType = CardType.Ally,
                Sphere = Sphere.Leadership,
                ResourceCost = 5,
                Quantity = 3,
                Traits = new List<string>() { "Gondor." },
                Willpower = 1,
                HitPoints = 3,
                Attack = 0,
                Defense = 1,
                Text = "Lower the cost to play Citadel Custodian by 1 for each Gondor ally in play.",
                CardNumber = 4,
                Artist = Artist.Lorraine_Schleter
            });
            Cards.Add(new LotRCard() {
                
                Title = "City Street",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9011",
                CardType = CardType.Location,
                Keywords = new List<string>() { "Surge." },
                Quantity = 3,
                Traits = new List<string>() { "City." },
                Text = "While City Street is in the staging area, players cannot travel to a location that does not have the title City Street.",
                QuestPoints = 2,
                EncounterSet = "Streets of Gondor",
                Shadow = "Shadow: attacking enemy gets +2 Attack.",
                Threat = 2,
                CardNumber = 38,
                Artist = Artist.Stu_Barnes
            });
            Cards.Add(new LotRCard() {
                
                Title = "Collateral Damage",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9012",
                CardType = CardType.Treachery,
                Quantity = 4,
                Text = "When Revealed: Discard 2 cards from the top of the encounter deck. Discard an additional 2 cards for each copy of Collateral Damage in the discard pile. Then, raise each player's threat by 2 for each location discarded by this effect.",
                EncounterSet = "Peril in Pelargir",
                Shadow = "Shadow: Any damage dealt by this attack is dealt to the hero with Alcaron's Scroll attached, if able.",
                CardNumber = 24,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new LotRCard() {
                
                Title = "Damrod",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9013",
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                IsUnique = true,
                ResourceCost = 4,
                Quantity = 3,
                Traits = new List<string>() { "Gondor.", " Ranger." },
                Willpower = 1,
                HitPoints = 2,
                Attack = 2,
                Defense = 2,
                Text = "Action: Discard Damrod from play to lower your threat by 1 for each enemy in the staging area.",
                CardNumber = 10,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Defender of Rammas",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9014",
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                ResourceCost = 2,
                Quantity = 3,
                Traits = new List<string>() { "Gondor.", " Warrior." },
                Willpower = 0,
                HitPoints = 1,
                Attack = 1,
                Defense = 4,
                CardNumber = 7,
                FlavorText = "\"And the Enemy must pay dearly for the crossing of the River.\" -Denethor, The Return of the King",
                Artist = Artist.Marcia_George_Bogdan
            });
            Cards.Add(new LotRCard() {
                
                Title = "Envoy of Pelargir",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9015",
                CardType = CardType.Ally,
                Sphere = Sphere.Neutral,
                ResourceCost = 2,
                Quantity = 3,
                Traits = new List<string>() { "Gondor." },
                Willpower = 1,
                HitPoints = 1,
                Attack = 1,
                Defense = 0,
                Text = "Response: After Envoy of Pelargir enters play, add 1 resource to a Gondor or Noble hero's resource pool.",
                CardNumber = 18,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Errand-rider",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9016",
                CardType = CardType.Ally,
                Sphere = Sphere.Leadership,
                ResourceCost = 1,
                Quantity = 3,
                Traits = new List<string>() { "Gondor." },
                Willpower = 0,
                HitPoints = 2,
                Attack = 0,
                Defense = 0,
                Text = "Action: Exhaust Errand-rider to move 1 resource from the resource pool of a hero you control to another hero's resource pool.",
                FlavorText = "For the people of the City used horses very little and they were seldom seen in their streets, save only those ridden by the errand-riders of their lord. -The Return of the King",
                CardNumber = 3,
                Artist = Artist.Anna_Steinbauer
            });
            Cards.Add(new LotRCard() {
                
                Title = "Forest Bat",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9017",
                CardType = CardType.Enemy,
                Quantity = 3,
                Traits = new List<string>() { "Creature." },
                HitPoints = 1,
                Attack = 1,
                Defense = 1,
                Text = "When Revealed: The first player deals 2 damage to a questing hero and removes that hero from the quest.",
                EncounterSet = "Creatures of the Forest",
                EngagementCost = 18,
                Shadow = "Shadow: Defending player raises his threat by X where X is the attacking enemy's Threat.",
                Threat = 1,
                CardNumber = 50,
                Artist = Artist.Aurelien_Hubert
            });
            Cards.Add(new LotRCard() {
                
                Title = "Haradrim Elite",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9018",
                CardType = CardType.Enemy,
                Quantity = 2,
                Traits = new List<string>() { "Harad." },
                HitPoints = 3,
                Attack = 4,
                Defense = 3,
                Text = "Forced: When Haradrim Elite enters play, it makes an immediate attack from the staging area against the first player.",
                EncounterSet = "Southrons",
                EngagementCost = 27,
                Shadow = "Shadow: This enemy attacks again after this attack resolves. (Deal a new shadow card for that attack.)",
                Threat = 3,
                CardNumber = 53,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new LotRCard() {
                
                Title = "Harbor Storehouse",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9019",
                CardType = CardType.Location,
                Quantity = 2,
                Traits = new List<string>() { "City." },
                Text = "Forced: Each time a location is discarded from the top of the encounter deck, raise each player's threat by 1.",
                QuestPoints = 4,
                EncounterSet = "Peril in Pelargir",
                Shadow = "Shadow: Deal attacking enemy an additional shadow card for each Thug enemy in play.",
                Threat = 1,
                CardNumber = 23,
                Artist = Artist.Titus_Lunter
            });
            Cards.Add(new LotRCard() {
                
                Title = "Harbor Thug",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9020",
                CardType = CardType.Enemy,
                Quantity = 5,
                Traits = new List<string>() { "Thug." },
                HitPoints = 3,
                Attack = 3,
                Defense = 1,
                Text = "Forced: When the player whose hero has Alcaron's Scroll attached raises his threat, Harbor Thug engages that player.",
                EncounterSet = "Peril in Pelargir",
                EngagementCost = 25,
                Shadow = "Shadow: Any damage dealt by this attack is dealt to the hero with Alcaron's Scroll attached, if able.",
                Threat = 2,
                CardNumber = 20,
                Artist = Artist.Ellyson_Ferrari_Lifante
            });
            Cards.Add(new LotRCard() {
                Title = "The Leaping Fish",
                StageNumber = 1,
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9021",
                CardType = CardType.Quest,
                Quantity = 1,
                QuestPoints = 6,
                Keywords = new List<string> { "Battle." },
                Text = "Setup: Search the encounter deck for The Leaping Fish and Alcaron's ~Scroll. Make The Leaping Fish the active location and attach Alcaron's ~Scroll to a hero.",
                FlavorText = "The White Council has sent you by ship to Gondor to help fight the threat of Mordor. Upon arrival in the port city of Pelargir, you are greeted by Lord Alcaron who takes you to The Leaping Fish where you can speak privately.",
                OppositeText = "When Revealed: Each player must search the encounter deck for a copy of Harbor Thug and add it to the staging area. Shuffle the encounter deck.",
                OppositeFlavorText = "Inside the tavern, Lord Alcaron looks nervously toward the door as he hands you a scroll bearing the seal of Gondor. He asks that you deliver it to Faramir in Ithilen, but the brigands who just entered look intent on taking it from you",
                EncounterSet = "Peril in Pelargir",
                CardNumber = 65,
                Artist = Artist.Darek_Zabrocki,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.StreetsOfGondor, EncounterSet.Brigands }
            }.WithSuffix("Quest"));
            Cards.Add(new LotRCard() {
                
                Title = "Fighting in the Streets",
                StageNumber = 2,
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9023",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = 13,
                EncounterSet = "Peril in Pelargir",
                Keywords = new List<string> { "Battle." },
                FlavorText = "During the fight in the tavern, one of your adversaries managed to grab Alcaron's Scroll and flee outside. You chase the thief into the street where you are surrounded by a gang of his fellow brigands. You must fight your way through the mob and recover the scroll!",
                OppositeText = "When Revealed: Attach Alcaron's ~Scroll to the highest engagement cost enemy in play, if able. Otherwise, add Alcaron's Scroll to the staging area.",
                CardNumber = 66,
                Artist = Artist.Ben_Zweifel,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.StreetsOfGondor, EncounterSet.Brigands }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Escape to the Quays",
                StageNumber = 3,
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9025",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = 15,
                Text = "When Revealed: Each player searches the encounter deck and discard pile for 1 enemy and adds it to the staging area.",
                FlavorText = "You've recovered the scroll but are still outnumbered by your determined foes. Lord Alcaron shouts for you to escape and deliver the scroll before he flees to summon the city guard. If you can get to your ship, you can escape the clutches of these desperate thugs...",
                OppositeText = 
@"Enemies cannot be optionally engaged.

Forced: The first enemy revealed from the encounter deck each round makes an immediate attack against the player who controls Alcaron's Scroll from the staging area.

The players cannot defeat this stage unless Alcaron's ~Scroll is attached to a hero. If the players defeat this stage, they have won the game.",
                EncounterSet = "Peril in Pelargir",
                CardNumber = 67,
                Artist = Artist.Jeff_Lee_Johnson,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.StreetsOfGondor, EncounterSet.Brigands }
            });
            Cards.Add(new LotRCard() {
                Title = "Ambush in Ithilien",
                StageNumber = 1,
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9027",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = 15,
                Keywords = new List<string> { "Battle." },
                Text = "Setup: Add Celador to the staging area. Search the encounter deck for a copy of Ithilien Road and make it the active location. Each player must search the encounter deck for a copy of Southron Company and add it to the staging area. Shuffle the encounter deck.",
                FlavorText = "You've arrived in Ithilien with a sealed message for Faramir, only to learn that he has gone north to defend Cair Andros from massing enemy forces.",
                OppositeText = "If the players complete this stage with Celador in the staging area, advance to stage 3A (bypassing stage 2).",
                OppositeFlavorText = "Faramir has left a company of rangers in Ithilien, tasked on ambushing Southrons as the march toward Cair Andros. Their captain, Celador, offers to lead you to Cair Andros after the approaching enemy is destroyed...",
                EncounterSet = "Into Ithilien",
                CardNumber = 68,
                Artist = Artist.Jeff_Lee_Johnson,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.BroodingForest, EncounterSet.CreaturesOfTheForest, EncounterSet.Southrons }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Southron Counter-attack",
                StageNumber = 2,
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9029",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = 9,
                EncounterSet = "Into Ithilien",
                Keywords = new List<string> { "Siege.", "Archery X." },
                FlavorText = "The Southron army was larger and better prepared than the rangers anticipated, and now your dwindling company is painfully overmatched. Your only option is a disciplined withdrawl to Cair Andros, before being overwhelmed by the enemy reinforcements hurrying up the road to join the fight.",
                OppositeText = 
@"X is the number of players in the game.

After this stage is completed advance to stage 4A (bypassing stage 3).",
                CardNumber = 69,
                Artist = Artist.Magali_Villeneuve,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.BroodingForest, EncounterSet.CreaturesOfTheForest, EncounterSet.Southrons }
            });
            Cards.Add(new LotRCard() {
                
                Title = "The Hidden Way",
                StageNumber = 3,
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9031",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = 12,
                EncounterSet = "Into Ithilien",
                OppositeText = 
@"When Revealed: The first player takes contorl of all Ranger objectives in the staging area.

Enemies do not make engagement checks and cannot be optionally engaged.",
                CardNumber = 70,
                Artist = Artist.Ilich_Henriquez,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.BroodingForest, EncounterSet.CreaturesOfTheForest, EncounterSet.Southrons }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Approaching Cair Andros",
                StageNumber = 4,
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9033",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = 15,
                EncounterSet = "Into Ithilien",
                FlavorText = "The island fortress of Cair Andros rises from the middle of the Anduin. From a distance all is quiet, but as you near the island and night approaches a raucous cry is heard on the wind. The horns of Mordor sound in response. The enemy is moving on Cair Andros, and the assault will soon begin. You must reach it before all hope is lost.",
                OppositeText = 
@"If any players threat is 37 or higher, Approaching Cair Andros gains Siege.

Forced: At the end of each round, raise each player's threat by 2.

If the players defeat this stage, they have won the game.",
                CardNumber = 71,
                Artist = Artist.Emrah_Elmasli,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.BroodingForest, EncounterSet.CreaturesOfTheForest, EncounterSet.Southrons }
            });
            Cards.Add(new LotRCard() {
                Title = "The Defense",
                StageNumber = 1,
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9035",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = 9,
                Keywords = new List<string> { "Siege." },
                Text = "Setup: Add The Approach, The Citadel, and The Banks to the staging area. Shuffle the encounter deck.",
                FlavorText = "The island fortress of Cair Andros, which guards Gondor's northernmost causeways over the river Anduin, is under siege! Battering rams rumble up the eastern causeway and rafts filled with Orcs float across the river toward the lightly defended northern banks.",
                OppositeText = "Players must deal damage from undefended attacks to the lowest Threat Battleground location in play. If there are no Battleground locations in play, immediate advance to the next stage.",
                OppositeFlavorText = "The assault is relentless, and the defenders grow weary. The tide is slowly but surely turning against you...",
                EncounterSet = "The Siege of Cair Andros",
                CardNumber = 72,
                Artist = Artist.Lin_Bo,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Southrons, EncounterSet.RavagingOrcs, EncounterSet.MordorElite }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Reinforcing the Banks",
                StageNumber = 2,
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9037",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = 9,
                EncounterSet = "The Siege of Cair Andros",
                FlavorText = "As smoke and rending cries fill the air, rafts of Orcs beach their crafts all along the northern banks. You must reach the shore and drive them back into the river before a solid foothold can be established.",
                OppositeText = "Reveal 1 additional card from the encounter deck and add it to the staging area during the staging step each round.",
                CardNumber = 73,
                Artist = Artist.Timo_Karhula,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Southrons, EncounterSet.RavagingOrcs, EncounterSet.MordorElite }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Breakthrough at the Approach",
                StageNumber = 3,
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9039",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = 7,
                EncounterSet = "The Siege of Cair Andros",
                Keywords = new List<string> { "Battle." },
                FlavorText = "With a crashing boom the eastern gate shatters. A ram has broken through, and the pressing host of Orcs pour into the courtyard beyond. Engage them in hand-to-hand combat and secure the gate!",
                OppositeText = "Forced: After the players quest unsuccessfully, instead of raising threat each player must choose and discard 1 character he controls.",
                CardNumber = 74,
                Artist = Artist.Lin_Bo,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Southrons, EncounterSet.RavagingOrcs, EncounterSet.MordorElite }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Breakthrough at the Citadel",
                StageNumber = 4,
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9041",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = 5,
                EncounterSet = "The Siege of Cair Andros",
                Keywords = new List<string> { "Siege." },
                FlavorText = "Orc scramblers have infiltrated the island and climbed over the walls. They fought to the western gate, and the gate fell. Now a new host of enemies that were lying in wait are breaching the Citadel itself!",
                OppositeText = "Breakthrough at the Citadel adds 5 Threat to the staging area.",
                CardNumber = 75,
                Artist = Artist.Darek_Zabrocki,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Southrons, EncounterSet.RavagingOrcs, EncounterSet.MordorElite }
            });
            Cards.Add(new LotRCard() {
                
                Title = "The Last Battle",
                StageNumber = 5,
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9043",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = 15,
                EncounterSet = "The Siege of Cair Andros",
                Keywords = new List<string> { "Siege." },
                OppositeText =
@"When Revealed: Reveal 1 card per player from the encounter deck and add it to the staging area.

If the players have collected 4 or more victory points, The Last Battle gains Battle and loses Siege.

If the players defeat this stage, they have won the game.",
                CardNumber = 76,
                Artist = Artist.Darek_Zabrocki,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Southrons, EncounterSet.RavagingOrcs, EncounterSet.MordorElite }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Hunter of Lamedon",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9045",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                ResourceCost = 2,
                Quantity = 3,
                Traits = new List<string>() { "Gondor.", " Outlands." },
                Willpower = 1,
                HitPoints = 1,
                Attack = 1,
                Defense = 1,
                Text = "Response: After you play Hunter of Lamedon from your hand, reveal the top card of your deck. If it is an Outlands card, add it to your hand. Otherwise, discard it.",
                FlavorText = "From Lamedon, a few grim hillmen without a captain. -The Return of the King",
                CardNumber = 14,
                Artist = Artist.Lorraine_Schleter
            });
            Cards.Add(new LotRCard() {
                
                Title = "Ithilien Guardian",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9046",
                CardType = CardType.Objective,
                Quantity = 2,
                Traits = new List<string>() { "Gondor.", " Ranger." },
                Willpower = 2,
                HitPoints = 2,
                Attack = 2,
                Defense = 1,
                Text = "While ~Ithilien ~Guardian is in the staging area, he is committed to the current quest.\r\nWhen Revealed: Add ~Ithilien ~Guardian to the staging area and ~Ithilien ~Guardian gains surge.",
                EncounterSet = "Into Ithilien",
                Shadow = "Shadow: Deal 2 damage to the attacking enemy.",
                CardNumber = 26,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Ithilien Road",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9047",
                CardType = CardType.Location,
                Quantity = 2,
                Traits = new List<string>() { "Forest.", " Road." },
                Text = "While Ithilien Road is the active location, the engagement cost of each enemy in the staging area is 0.",
                QuestPoints = 4,
                EncounterSet = "Into Ithilien",
                Shadow = "Shadow: Return attacking enemy to the staging area after it attacks.",
                Threat = 4,
                CardNumber = 28,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new LotRCard() {
                
                Title = "Ithilien Tracker",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9048",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                ResourceCost = 2,
                Quantity = 3,
                Traits = new List<string>() { "Gondor.", " Ranger." },
                Willpower = 0,
                HitPoints = 3,
                Attack = 1,
                Defense = 0,
                Text = "Action: Exhaust Ithilien Tracker to lower the Threat of the next enemy added to the staging area to 0 until the end of the phase.",
                FlavorText = "Green gauntlets covered their hands, and their faces were hooded and masked with green, except for their eyes, which were very keen and bright. -The Two Towers",
                CardNumber = 15,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new LotRCard() {
                
                Title = "Lieutenant of Mordor",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9049",
                CardType = CardType.Enemy,
                Quantity = 1,
                Traits = new List<string>() { "Mordor." },
                HitPoints = 5,
                Attack = 5,
                Defense = 2,
                Text = "Allies cannot defend against Lieutenant of Mordor.When Revealed: Resolve the 'when revealed' effect on the topmost treachery card in the encounter discard pile, if able. This effect cannot be canceled.",
                EncounterSet = "Mordor Elite",
                EngagementCost = 33,
                Threat = 2,
                VictoryPoints = 3,
                CardNumber = 56,
                Artist = Artist.Jim_Pavelec
            });
            Cards.Add(new LotRCard() {
                
                Title = "Light the Beacons",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9050",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                ResourceCost = 5,
                Quantity = 3,
                Text = "Action: All characters get +2 Defense and do not exhaust to defend until the end of the round.",
                FlavorText = "\"The beacons of Gondor are alight, calling for aid.\" -Gandalf, The Return of the King",
                CardNumber = 11,
                Artist = Artist.Titus_Lunter
            });
            Cards.Add(new LotRCard() {
                
                Title = "Local Trouble",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9051",
                CardType = CardType.Treachery,
                Quantity = 2,
                EasyModeQuantity = 1,
                Text = "When Revealed: Attach this card to the hero with the highest threat cost without a copy of Local Trouble attached. (Counts as a Condition attachment with the text: 'When attached hero exhausts, readies, or triggers an ability, raise its controller's threat by 1.')",
                FlavorText = "...they all got an uncomfortable feeling that they were being watched with disapproval, deepening to dislike and even enmity. -The Fellowship of the Ring",
                EncounterSet = "Streets of Gondor",
                CardNumber = 41,
                Artist = Artist.Ryan_Barger
            });
            Cards.Add(new LotRCard() {
                
                Title = "Lossarnach Bandit",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9052",
                CardType = CardType.Enemy,
                Quantity = 2,
                Traits = new List<string>() { "Brigand." },
                HitPoints = 3,
                Attack = 3,
                Defense = 3,
                Text = "Forced: When Lossarnach Bandit engages a player, that player discards 1 resource from each of his heroes' resource pools. (2 resources instead if Lossarnach Bandit was not optionally engaged.)",
                EncounterSet = "Brigands",
                EngagementCost = 24,
                Threat = 3,
                CardNumber = 43,
                Artist = Artist.Dan_Masso
            });
            Cards.Add(new LotRCard() {
                
                Title = "Lost Companion",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9053",
                CardType = CardType.Treachery,
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "When Revealed: Each player removes 1 character he controls from the quest, if able. Then, if any player has no characters committed to the quest, remove all characters from the quest.",
                FlavorText = "\"Seven companions we had: one we lost at Moria, the others we left at Parth Galen above Rauros...\" -Frodo Baggins, The Two Towers",
                EncounterSet = "Brooding Forest",
                CardNumber = 48,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Lost in the City",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9054",
                CardType = CardType.Treachery,
                Quantity = 1,
                EasyModeQuantity = 0,
                Text = "When Revealed: Each player must search the encounter deck and discard pile for 1 City location and add it to the staging area, if able. Shuffle the encounter deck. This effect cannot be canceled.",
                EncounterSet = "Streets of Gondor",
                Shadow = "Shadow: Defending player discards his hand.",
                CardNumber = 40,
                Artist = Artist.Dleoblack
            });
            Cards.Add(new LotRCard() {
                
                Title = "Lurking in Shadows",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9055",
                CardType = CardType.Treachery,
                Quantity = 2,
                Text = "When Revealed: Return all Brigand enemies engaged with players to the staging area. If this effect returned no Brigand enemies to the staging area, Lurking in Shadows gains surge.",
                EncounterSet = "Brigands",
                Shadow = "Shadow: Return attacking enemy to the staging area after it attacks.",
                CardNumber = 45,
                Artist = Artist.Sabin_Boykinov
            });
            Cards.Add(new LotRCard() {
                
                Title = "Market Square",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9056",
                CardType = CardType.Location,
                Quantity = 2,
                Traits = new List<string>() { "City." },
                Text = "Immune to player card effects.\r\nTravel: Each player must spend 1 resource from one of his heroes' resource pools to travel here.",
                QuestPoints = 1,
                EncounterSet = "Streets of Gondor",
                Shadow = "Shadow: Defending player discards all resources in his heroes' resource pools.",
                Threat = 3,
                CardNumber = 39,
                Artist = Artist.Sara_Biddle
            });
            Cards.Add(new LotRCard() {
                
                Title = "Master of Lore",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9057",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                ResourceCost = 3,
                Quantity = 3,
                Traits = new List<string>() { "Gondor." },
                Willpower = 1,
                HitPoints = 1,
                Attack = 0,
                Defense = 1,
                Text = "Action: Exhaust Master of ~Lore to name a card type. Lower the cost for you to play the next Lore card of that type by 1 until the end of the phase (to a minimum of 1).",
                FlavorText = "\"If Cirith Ungol is named, old men and masters of lore will blanch and fall silent.\" -Faramir, The Two Towers",
                CardNumber = 16,
                Artist = Artist.Ilich_Henriquez,
                HasErrata = true
            });
            Cards.Add(new LotRCard() {
                
                Title = "Morgul Spider",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9058",
                CardType = CardType.Enemy,
                Quantity = 3,
                EasyModeQuantity = 1,
                Traits = new List<string>() { "Creature.", " Spider." },
                HitPoints = 5,
                Attack = 4,
                Defense = 1,
                Text = "When Revealed: Until the end of the round, Morgul Spider gets +1 Attack for each character not currently committed to a quest.",
                FlavorText = "Far and wide her lesser broods, bastards of the miserable mates, her own offspring, that she slew, spread from glen to glen... -The Two Towers",
                EncounterSet = "Creatures of the Forest",
                EngagementCost = 25,
                Threat = 3,
                CardNumber = 49,
                Artist = Artist.Dean_Spencer
            });
            Cards.Add(new LotRCard() {
                Title = "Mûmak",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9059",
                CardType = CardType.Enemy,
                Quantity = 1,
                EasyModeQuantity = 0,
                Traits = new List<string>() { "Harad.", " Creature." },
                HitPoints = 12,
                Attack = 7,
                Defense = 3,
                Text = "No attachments can be attached to Mûmak.\r\nMûmak cannot take more than 3 damage each round.",
                FlavorText = "\"His upturned hornlike tusks were bound with bands of gold and dripped with blood.\" -The Two Towers",
                EncounterSet = "Southrons",
                EngagementCost = 38,
                Threat = 4,
                CardNumber = 54,
                Artist = Artist.Piya_Wannachaiwong
            });
            Cards.Add(new LotRCard() {
                
                Title = "Mutual Accord",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9060",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                ResourceCost = 0,
                Quantity = 3,
                Text = "Action: Until the end of the phase, each Gondor card in play gains the Rohan trait, and each Rohan card in play gains the Gondor trait.",
                FlavorText = "\"These are the Rohirrim, as we name them, masters of horses... and have ever proved true to us, aiding us at need, and guarding our northern marches and the Gap of Rohan.\" -Faramir, The Two Towers",
                CardNumber = 5,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new LotRCard() {
                
                Title = "Orc Arbalesters",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9061",
                CardType = CardType.Enemy,
                Keywords = new List<string>() { "Archery X." },
                Quantity = 3,
                Traits = new List<string>() { "Mordor.", " Orc." },
                HitPoints = 5,
                Attack = 1,
                Defense = 2,
                Text = "X is the number of different resource icons (Leadership, Tactics, Spirit, or Lore) on heroes in play.",
                EncounterSet = "Mordor Elite",
                EngagementCost = 35,
                Shadow = "Shadow: attacking enemy gets +2 Attack.",
                Threat = 2,
                CardNumber = 57,
                Artist = Artist.Timo_Karhula
            });
            Cards.Add(new LotRCard() {
                
                Title = "Orc Arsonist",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9062",
                CardType = CardType.Enemy,
                Quantity = 3,
                Traits = new List<string>() { "Mordor.", " Orc." },
                HitPoints = 3,
                Attack = 3,
                Defense = 2,
                Text = "Forced: When Orc Arsonist engages a player, deal 1 shadow card to each enemy engaged with that player.",
                EncounterSet = "Ravaging Orcs",
                EngagementCost = 30,
                Shadow = "Shadow: attacking enemy gets +1 Attack. Deal it another shadow card.",
                Threat = 3,
                CardNumber = 63,
                Artist = Artist.David_Kegg
            });
            Cards.Add(new LotRCard() {
                
                Title = "Orc Assault",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9063",
                CardType = CardType.Treachery,
                Quantity = 2,
                Text = "When Revealed: Each character gets -2 Attack and -2 Defense until the end of the round.",
                EncounterSet = "The Siege of Cair Andros",
                Shadow = "Shadow: Deal 2 damage to all Battleground locations in play.",
                CardNumber = 36,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new LotRCard() {
                
                Title = "Orc Rabble",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9064",
                CardType = CardType.Enemy,
                Quantity = 3,
                EasyModeQuantity = 0,
                Traits = new List<string>() { "Mordor.", " Orc." },
                HitPoints = 3,
                Attack = 1,
                Defense = 1,
                Text = "Forced: When Orc Rabble is dealt a shadow card, it gets +2 Attack until the end of the phase.",
                EncounterSet = "Ravaging Orcs",
                EngagementCost = 28,
                Shadow = "Shadow: Deal the attacking enemy an additional shadow card for each player in the game.",
                Threat = 2,
                CardNumber = 62,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new LotRCard() {
                
                Title = "Orc Scramblers",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9065",
                CardType = CardType.Enemy,
                Keywords = new List<string>() { "Surge." },
                Quantity = 3,
                EasyModeQuantity = 2,
                Traits = new List<string>() { "Orc.", " Besieger." },
                HitPoints = 2,
                Attack = 2,
                Defense = 1,
                Text = "When Revealed: Deal 1 damage to each Battleground location in play, if able.",
                EncounterSet = "The Siege of Cair Andros",
                EngagementCost = 15,
                Shadow = "Shadow: Deal 2 damage to The Citadel if it is in play. Otherwise, attacking enemy gets +2 Attack.",
                Threat = 1,
                CardNumber = 30,
                Artist = Artist.Anton_Kokarev
            });
            Cards.Add(new LotRCard() {
                
                Title = "Orc Vanguard",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9066",
                CardType = CardType.Enemy,
                Quantity = 2,
                EasyModeQuantity = 0,
                Traits = new List<string>() { "Mordor.", " Orc." },
                HitPoints = 5,
                Attack = 8,
                Defense = 3,
                Text = "While Orc Vanguard is in the staging area, resources cannot be spent from the resource pools of heroes who have a Leadership, Spirit, or Lore resource icon.",
                EncounterSet = "Mordor Elite",
                EngagementCost = 40,
                Shadow = "Shadow: Deal the attacking enemy two additional shadow cards.",
                Threat = 2,
                CardNumber = 58,
                Artist = Artist.Lin_Bo
            });
            Cards.Add(new LotRCard() {
                
                Title = "Orc War Camp",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9067",
                CardType = CardType.Location,
                Quantity = 2,
                EasyModeQuantity = 0,
                Traits = new List<string>() { "Mordor." },
                Text = "If an Orc enemy is in play, progress tokens cannot be placed on Orc War Camp while it is in the staging area.",
                QuestPoints = 2,
                EncounterSet = "Mordor Elite",
                Shadow = "Shadow: attacking enemy gets +1 Attack for each shadow card dealt to it.",
                Threat = 5,
                CardNumber = 59,
                Artist = Artist.Emilio_Rodriguez
            });
            Cards.Add(new LotRCard() {
                
                Title = "Overgrown Trail",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9068",
                CardType = CardType.Location,
                Quantity = 3,
                EasyModeQuantity = 1,
                Traits = new List<string>() { "Forest." },
                Text = "Action: Exhaust a Ranger character to place 3 progress tokens on Overgrown Trail.",
                QuestPoints = 6,
                EncounterSet = "Brooding Forest",
                Shadow = "Shadow: Remove X progress tokens from the current quest, where X is the attacking enemy's Threat.",
                Threat = 4,
                CardNumber = 46,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new LotRCard() {
                
                Title = "Pelargir Docks",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9069",
                CardType = CardType.Location,
                Quantity = 2,
                EasyModeQuantity = 0,
                Traits = new List<string>() { "City.", " River." },
                Text = "While Pelargir Docks is the active location, enemies get +1 Attack and +1 Defense.",
                FlavorText = "...they saw the River like a ribbon laid down to Pelargir, and beyond that was a light on the hem of the sky that spoke of the Sea. -The Return of the King",
                QuestPoints = 3,
                EncounterSet = "Peril in Pelargir",
                Threat = 4,
                CardNumber = 22,
                Artist = Artist.Emilio_Rodriguez
            });
            Cards.Add(new LotRCard() {
                
                Title = "Pickpocket",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9070",
                CardType = CardType.Enemy,
                Quantity = 3,
                Traits = new List<string>() { "Brigand." },
                HitPoints = 2,
                Attack = 1,
                Defense = 0,
                Text = "Forced: When Pickpocket attacks, the defending player discards 1 resource from one of his heroes' resource pools and 1 card at random from his hand.",
                EncounterSet = "Streets of Gondor",
                EngagementCost = 28,
                Shadow = "Shadow: Defending player discards 1 of his attachments. (Discard all of his attachments instead if undefended.)",
                Threat = 3,
                CardNumber = 37,
                Artist = Artist.Asahi
            });
            Cards.Add(new LotRCard() {
                
                Title = "Ranger Spikes",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9071",
                CardType = CardType.Attachment,
                Sphere = Sphere.Lore,
                ResourceCost = 2,
                Quantity = 3,
                Traits = new List<string>() { "Trap." },
                Text = "Play Ranger Spikes into the staging area unattached.If unattached, attach Ranger Spikes to the next eligible enemy that enters the staging area.Players do not make engagement checks against attached enemy. Attached enemy gets -2 Threat.",
                CardNumber = 17,
                Artist = Artist.Titus_Lunter,
                SecondArtist = Artist.Suzanne_Helmigh
            });
            Cards.Add(new LotRCard() {
                
                Title = "Scourge of Mordor",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9072",
                CardType = CardType.Treachery,
                Quantity = 2,
                Text = "When Revealed: Each player discards the top card of his deck. Until the end of the phase, raise the total Threat in the staging area by X, where X is the total cost of all cards discarded by this effect.",
                EncounterSet = "Ravaging Orcs",
                Shadow = "Shadow: attacking enemy gets +1 Attack. Deal it another shadow card.",
                CardNumber = 64,
                Artist = Artist.Caravan_Studio
            });
            Cards.Add(new LotRCard() {
                
                Title = "Secluded Glade",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9073",
                CardType = CardType.Location,
                Quantity = 3,
                Traits = new List<string>() { "Forest." },
                Text = "Immune to player card effects.",
                FlavorText = "\"...the garden of Gondor now desolate kept still a dishevelled dryad loveliness.\" -The Two Towers",
                QuestPoints = 3,
                EncounterSet = "Brooding Forest",
                Shadow = "Shadow: Remove X progress tokens from the current quest, where X is the attacking enemy's Threat.",
                Threat = 3,
                CardNumber = 47,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new LotRCard() {
                
                Title = "Siege Raft",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9074",
                CardType = CardType.Enemy,
                Quantity = 2,
                EasyModeQuantity = 1,
                Traits = new List<string>() { "Besieger." },
                HitPoints = 6,
                Attack = 4,
                Defense = 1,
                Text = "When Revealed: Deal 2 damage to the lowest Threat Battleground location in play, if able.",
                EncounterSet = "The Siege of Cair Andros",
                EngagementCost = 30,
                Shadow = "Shadow: Deal 2 damage to The Banks if it is in play. Otherwise, attacking enemy gets +2 Attack.",
                Threat = 3,
                CardNumber = 32,
                Artist = Artist.Marco_Caradonna
            });
            Cards.Add(new LotRCard() {
                
                Title = "Southron Company",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9075",
                CardType = CardType.Enemy,
                Quantity = 4,
                Traits = new List<string>() { "Harad." },
                HitPoints = 5,
                Attack = 3,
                Defense = 1,
                Text = "Southron Company gets +2 Threat and +2 Attack while the current quest card has the battle or siege keyword.",
                EncounterSet = "Into Ithilien",
                EngagementCost = 34,
                Shadow = "Shadow: attacking enemy gets +1 Attack. (+2 Attack instead if the current quest card has a keyword.)",
                Threat = 1,
                CardNumber = 27,
                Artist = Artist.Ignacio_Bazan_Lazcano
            });
            Cards.Add(new LotRCard() {
                
                Title = "Southron Mercenaries",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9076",
                CardType = CardType.Enemy,
                Keywords = new List<string>() { "Archery X." },
                Quantity = 3,
                Traits = new List<string>() { "Harad." },
                HitPoints = 4,
                Attack = 3,
                Defense = 2,
                Text = "X is the number of players in the game.",
                EncounterSet = "Southrons",
                EngagementCost = 35,
                Shadow = "Shadow: attacking enemy gets +1 Attack. (+3 Attack instead if it has the Harad trait.)",
                Threat = 2,
                CardNumber = 52,
                Artist = Artist.Emile_Denis
            });
            Cards.Add(new LotRCard() {
                
                Title = "Southron Support",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9077",
                CardType = CardType.Treachery,
                Keywords = new List<string>() { "Doomed 3." },
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "When Revealed: Each player must search the encounter deck and discard pile for 1 Harad enemy and add it to the staging area, if able. Shuffle the encounter deck.",
                FlavorText = "... wild Southron men with red banners, shouting with harsh tongues, surging up, overtaking the retreat. -The Return of the King",
                EncounterSet = "Southrons",
                CardNumber = 55,
                Artist = Artist.C_B_Sorge
            });
            Cards.Add(new LotRCard() {
                
                Title = "Spear of the Citadel",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9078",
                CardType = CardType.Attachment,
                Sphere = Sphere.Tactics,
                Keywords = new List<string>() { "Restricted." },
                ResourceCost = 2,
                Quantity = 3,
                Traits = new List<string>() { "Item.", " Weapon." },
                Text = "Attach to a Tactics character. Limit 1 per character.\r\nResponse: After attached character is declared as a defender, deal 1 damage to the attacking enemy.",
                CardNumber = 9,
                Artist = Artist.Dan_Masso
            });
            Cards.Add(new LotRCard() {
                
                Title = "The Approach",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9079",
                CardType = CardType.Location,
                Quantity = 1,
                Traits = new List<string>() { "Cair Andros.", " Battleground." },
                Text = "If the Approach has 7 or more damage, remove it from the game (do not collect its victory points).\r\nResponse: After The Approach leaves play as an explored location, remove stage 3 from the quest deck, if able.",
                QuestPoints = 7,
                EncounterSet = "The Siege of Cair Andros",
                Threat = 2,
                VictoryPoints = 2,
                CardNumber = 34,
                Artist = Artist.Titus_Lunter
            });
            Cards.Add(new LotRCard() {
                
                Title = "The Banks",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9080",
                CardType = CardType.Location,
                Quantity = 1,
                Traits = new List<string>() { "Cair Andros.", " Battleground." },
                Text = "If The Banks has 3 or more damage, remove it from the game (do not collect its victory points).\r\nResponse: After The Banks leaves play as an explored location, remove stage 2 from the quest deck, if able.",
                QuestPoints = 3,
                EncounterSet = "The Siege of Cair Andros",
                Threat = 1,
                VictoryPoints = 1,
                CardNumber = 35,
                Artist = Artist.David_Lecossu
            });
            Cards.Add(new LotRCard() {
                
                Title = "The Citadel",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9081",
                CardType = CardType.Location,
                Quantity = 1,
                Traits = new List<string>() { "Cair Andros.", " Battleground." },
                Text = "If The Citadel has 11 or more damage, remove it from the game (do not collect its victory points).\r\nResponse: After The Citadel leaves play as an explored location, remove stage 4 from the quest deck, if able.",
                QuestPoints = 11,
                EncounterSet = "The Siege of Cair Andros",
                Threat = 3,
                VictoryPoints = 3,
                CardNumber = 33,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard() {
                Title = "The Leaping Fish",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9082",
                CardType = CardType.Location,
                IsUnique = true,
                Quantity = 1,
                Traits = new List<string>() { "City." },
                Text = "If Alcaron's Scroll is attached to a hero, The Leaping Fish gains: 'Forced: At the beginning of the quest phase discard X cards from the top of the encounter deck where X is the number of players in the game. Add each enemy discarded by this effect to the staging area.'",
                QuestPoints = 6,
                EncounterSet = "Peril in Pelargir",
                Threat = 2,
                VictoryPoints = 3,
                CardNumber = 21,
                Artist = Artist.Darek_Zabrocki
            }.WithSuffix("Location"));
            Cards.Add(new LotRCard() {
                
                Title = "The Master's Malice",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9083",
                CardType = CardType.Treachery,
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "When Revealed: Each player chooses 1 sphere of influence (Leadership, Tactics, Spirit, or Lore). Each character a player controls that does not belong to his chosen sphere takes 3 damage.",
                FlavorText = "\"I doubt not that the days of Gondor are numbered, and the walls of Minas Tirith are doomed, so great is His strength and malice.\" -Damrod, The Two Towers",
                EncounterSet = "Mordor Elite",
                CardNumber = 60,
                Artist = Artist.Marcia_George_Bogdan
            });
            Cards.Add(new LotRCard() {
                
                Title = "The Power of Mordor",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9084",
                CardType = CardType.Treachery,
                Keywords = new List<string>() { "Doomed 3." },
                Quantity = 1,
                Text = "When Revealed: Count the number of encounter cards in the staging area and shuffle them into the encounter deck. Reveal an equal number of cards from the encounter deck and add them to the staging area. This effect cannot be canceled.",
                EncounterSet = "Mordor Elite",
                CardNumber = 61,
                Artist = Artist.Ryan_Barger,
                HasErrata = true
            });
            Cards.Add(new LotRCard() {
                
                Title = "Umbar Assassin",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9085",
                CardType = CardType.Enemy,
                Keywords = new List<string>() { "Archery 2." },
                Quantity = 1,
                EasyModeQuantity = 0,
                Traits = new List<string>() { "Brigand." },
                HitPoints = 5,
                Attack = 5,
                Defense = 1,
                Text = "Forced: When Umbar Assassin engages a player, that player must deal 3 damage to a hero he controls. (Discard that hero instead if Umbar Assassin was not optionally engaged.)",
                EncounterSet = "Brigands",
                EngagementCost = 40,
                Threat = 4,
                CardNumber = 44,
                Artist = Artist.Greg_Opalinski
            });
            Cards.Add(new LotRCard() {
                
                Title = "Watcher in the Wood",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9086",
                CardType = CardType.Treachery,
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "When Revealed: Raise each player's threat by the number of questing characters. (If the current quest has the battle or siege keyword, Watcher in the Wood gains surge.)",
                EncounterSet = "Creatures of the Forest",
                Shadow = "Shadow: Each player raises his threat by the number of enemies engaged with him.",
                CardNumber = 51,
                Artist = Artist.Igor_Kieryluk
            });
            Cards.Add(new LotRCard() {
                
                Title = "Wealth of Gondor",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9087",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                ResourceCost = 0,
                Quantity = 3,
                Text = "Action: Choose a Gondor hero. Add 1 resource to that hero's resource pool.",
                FlavorText = "Kings made tombs more splendid than houses of the living, and counted old names in the rolls of their descent dearer than the names of sons. -The Two Towers",
                CardNumber = 6,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new LotRCard() {
                
                Title = "Zealous Traitor",
                Id = "4823aae3-46ef-4a75-89f9-cbd3aa1b9088",
                CardType = CardType.Enemy,
                Quantity = 3,
                Traits = new List<string>() { "Brigand." },
                HitPoints = 2,
                Attack = 3,
                Defense = 2,
                Text = "Forced: When Zealous Traitor engages a player, that player must deal 1 damage to each ally he controls. (2 damage instead if Zealous Traitor was not optionally engaged.)",
                EncounterSet = "Brigands",
                EngagementCost = 17,
                Threat = 2,
                CardNumber = 42,
                Artist = Artist.David_Gaillet
            });
        }
    }
}
