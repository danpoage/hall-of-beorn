using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.FirstAge
{
    public class FirstAgeSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "First Age";
            Abbreviation = "FA";
            Number = 9001;
            SetType = Models.SetType.COMMUNITY;

            Cards.Add(new LotRCard() {
                Title = "Aredhel",
                Id = "1d572e45-94ed-4563-96d5-1bcf358c775d",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Noldor.", "House of Fingolfin." },
                ResourceCost = 3,
                Willpower = 2,
                Attack = 1,
                Defense = 1,
                HitPoints = 2,
                Text = "Response: After the active location is explored, discard the top card of your deck. If it is an ally, take it into your hand.",
                EncounterSet = "First Age",
                CardNumber = 29,
                Artist = Artist.Miao_Yu
            });
            Cards.Add(new LotRCard() {
                Title = "Azaghâl",
                Id = "c10276a3-fc4d-4c05-9378-e22437febd30",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Dwarf.", "Warrior." },
                ResourceCost = 4,
                Willpower = 1,
                Attack = 3,
                Defense = 2,
                HitPoints = 4,
                Text = "Response: After Azaghâl is destroyed as the result of an enemy attack, deal 3 damage to the attacking enemy.",
                EncounterSet = "First Age",
                CardNumber = 42,
                Artist = Artist.Even_Mehl_Amundsen
            });
            Cards.Add(new LotRCard() {
                Title = "Barahir",
                Id = "ccb27322-b28f-4cec-8998-bc3a38da9d7a",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Leadership,
                ResourceCost = 3,
                Willpower = 1,
                Attack = 1,
                Defense = 3,
                HitPoints = 3,
                Text = "Response: After a shadow card is revealed, exhaust Barahir to add his Defense to the Defense of the defending character until the end of the phase.",
                EncounterSet = "First Age",
                CardNumber = 38,
                Artist = Artist.Saturnoarg
            }.WithTraits("Edain.", "House of Bëor.")
            .WithKeywords("Sentinel."));
            Cards.Add(new LotRCard() {
                Title = "Bëor",
                Id = "a71937a2-dd20-40d3-bfb6-a6cf7856011a",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Edain.", "House of Bëor." },
                ResourceCost = 2,
                Willpower = 1,
                Attack = 1,
                Defense = 1,
                HitPoints = 2,
                Text = "Action: Attach Bëor facedown to a character with the House of Finarfin trait. (Counts as a Vassal attachment with the text: 'Attached character gets +2 Willpower.')",
                EncounterSet = "First Age",
                CardNumber = 36,
                Artist = Artist.Stefan_Meisl
            });
            Cards.Add(new LotRCard() {
                Title = "Caranthir",
                
                Id = "f14eb968-2181-456e-97cf-3275af57d890",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Mastery,
                Traits = new List<string>() { "Noldor.", "House of Fëanor." },
                ResourceCost = 3,
                Willpower = 0,
                Attack = 2,
                Defense = 1,
                HitPoints = 3,
                Text = "Response: After a treachery is revealed and resolved, attach that card facedown to Caranthir. That attachment gains the Fury trait.(Limit once per round.)Action: Attach a Fury attachment to an enemy engaged with you. That enemy gets +1 Attack and -1 Defense.",
                EncounterSet = "First Age",
                CardNumber = 20,
                Artist = Artist.Lomacchi
            });
            Cards.Add(new LotRCard() {
                Title = "Celegorm",
                
                Id = "d0590810-8dfe-43e0-9b12-63ebcbaee153",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Mastery,
                Traits = new List<string>() { "Noldor.", "House of Fëanor." },
                ResourceCost = 3,
                Willpower = 1,
                Attack = 3,
                Defense = 1,
                HitPoints = 3,
                Text = "Celegorm gets +1 Attack for each non-unique location in the staging area.Action: Place 1 Corruption on Celegorm to search the top 10 cards of the encounter deck for a location and add it to the staging area.",
                EncounterSet = "First Age",
                CardNumber = 18,
                Artist = Artist.Lomacchi
            });
            Cards.Add(new LotRCard() {
                Title = "Chieftain of Men",
                
                Id = "1a6e1994-f32a-4241-9e0b-c4f4e43ae7a4",
                CardType = CardType.Ally,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Edain." },
                ResourceCost = 2,
                Willpower = 1,
                Attack = 2,
                Defense = 0,
                HitPoints = 2,
                Text = "Response: After your threat is raised by an encounter card effect, discard Chieftain of Men from play to cancel that effect.",
                EncounterSet = "First Age",
                CardNumber = 25,
                Artist = Artist.Unknown
            });
            Cards.Add(new LotRCard() {
                Title = "Curufin",
                
                Id = "6f13ed8d-8e7c-46c7-b65d-d26370409324",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Mastery,
                Traits = new List<string>() { "Noldor.", "House of Fëanor." },
                ResourceCost = 3,
                Willpower = 2,
                Attack = 2,
                Defense = 0,
                HitPoints = 3,
                Text = "While Fëanor is in play, Curufin gains: 'Action: Place 1 Corruption on Curufin. Until the end of the round, Curufin's Willpower, Attack and Defense are equal to the printed Willpower, Attack, and Defense of Fëanor.'",
                EncounterSet = "First Age",
                CardNumber = 43,
                Artist = Artist.Alan_Michael_S
            });
            Cards.Add(new LotRCard() {
                Title = "Daeron",
                
                Id = "611f6d5b-d1f6-49cb-b9e5-f2d5bf77a7ef",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Teleri.", "Minstrel." },
                ResourceCost = 2,
                Willpower = 2,
                Attack = 1,
                Defense = 1,
                HitPoints = 2,
                Text = "Action: Exhaust Daeron to draw 2 cards. Then discard 1 card from your hand.",
                EncounterSet = "First Age",
                CardNumber = 33,
                Artist = Artist.Ebe_Kastein
            });
            Cards.Add(new LotRCard() {
                Title = "Dwarf of the Blue Mountains",
                
                Id = "d8557f01-c6a5-4568-826f-70083fa6b98d",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Dwarf." },
                ResourceCost = 2,
                Willpower = 1,
                Attack = 1,
                Defense = 2,
                HitPoints = 2,
                Text = "Dwarf of the Blue Mountains gets +1 hit point for each unique attachment you control.",
                EncounterSet = "First Age",
                CardNumber = 30,
                Artist = Artist.David_Gaillet
            });
            Cards.Add(new LotRCard() {
                Title = "Elwing",
                
                Id = "7efcb2f7-e893-475c-8e60-001dc95ba430",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Half-elven." },
                ResourceCost = 3,
                Willpower = 3,
                Attack = 0,
                Defense = 0,
                HitPoints = 1,
                Text = "While Eärendil is in play, Elwing gains: 'Response: After Elwing is destroyed, you may immediately put her back into play for 1 Spirit resource. (Limit once per round.)'",
                EncounterSet = "First Age",
                CardNumber = 34,
                Artist = Artist.Miao_Yu
            });
            Cards.Add(new LotRCard() {
                Title = "Eöl",
                Id = "c12463e1-712b-4a77-8579-f9cafc7d9332",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Mastery,
                Traits = new List<string>() { "Teleri." },
                ResourceCost = 4,
                Willpower = 2,
                Attack = 1,
                Defense = 3,
                HitPoints = 2,
                Text = "Action: Place 1 Corruption on Eöl to search the top 15 cards of your deck for an attachment and add it to your hand.",
                EncounterSet = "First Age",
                CardNumber = 17,
                Artist = Artist.CS_Marks
            });
            Cards.Add(new LotRCard() {
                Title = "Finduilas",
                
                Id = "16ee9351-7842-400d-ba3a-0fe4d9f30634",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Noldor.", "House of Finarfin." },
                ResourceCost = 1,
                Willpower = 2,
                Attack = 0,
                Defense = 0,
                HitPoints = 2,
                Text = "Forced: Damage from undefended attacks must be assigned to Finduilas. After Finduilas leaves play, raise your threat by 2.",
                EncounterSet = "First Age",
                CardNumber = 41,
                Artist = Artist.Kuun_Suru
            });
            Cards.Add(new LotRCard() {
                Title = "Gondolin Guard",                
                Id = "4b61a531-071c-44a9-b569-261c41f182d7",
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                ResourceCost = 2,
                Willpower = 0,
                Attack = 1,
                Defense = 4,
                HitPoints = 1,
                EncounterSet = "First Age",
                CardNumber = 27,
                Artist = Artist.Unknown
            }.WithTraits("Noldor.")
            .WithKeywords("Sentinel."));
            Cards.Add(new LotRCard() {
                Title = "Green-elf Ranger",
                Id = "d9de0bc8-78fa-4f1d-b2a6-8d952daefe55",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                ResourceCost = 2,
                Willpower = 1,
                Attack = 1,
                Defense = 0,
                HitPoints = 2,
                Text = "Quest Action: Exhaust Green-elf Ranger to choose enemy or location. The next encounter card of the chosen type that is added to the staging area gets -3 Threat until the end of the phase.",
                EncounterSet = "First Age",
                CardNumber = 32,
                Artist = Artist.Paulo_Puggioni
            }.WithTraits("Nandor.", "Ranger.")
            .WithKeywords("Ranged."));
            Cards.Add(new LotRCard() {
                Title = "Hador",
                Id = "1490551a-e98f-4f75-b619-90c4c510eff0",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Leadership,
                ResourceCost = 3,
                Willpower = 1,
                Attack = 2,
                Defense = 1,
                HitPoints = 2,
                Text = "Action: Discard Hador to reveal the top 5 cards of your deck. Put up to 2 revealed allies with the Edain trait into play, if able. Shuffle all other revealed cards back into your deck.",
                EncounterSet = "First Age",
                CardNumber = 37,
                Artist = Artist.Unknown
            }.WithTraits("Edain.", "House of Hador."));
            Cards.Add(new LotRCard() {
                Title = "Haladin Woodsman",
                Id = "b1d66533-fa81-466a-a26c-eb0ddf3ea2a6",
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Edain.", "House of Haleth." },
                ResourceCost = 2,
                Willpower = 1,
                Attack = 1,
                Defense = 2,
                HitPoints = 2,
                Text = "Response: After a shadow effect resolves on an enemy engaged with you, Haladin Woodsman gets +1 Attack and +1 Defense until the end of the round. (Limit twice per round.)",
                EncounterSet = "First Age",
                CardNumber = 160,
                Artist = Artist.Deelane
            });
            Cards.Add(new LotRCard() {
                Title = "Huan",
                
                Id = "eea419ce-71ae-499b-a1fb-dd69a5633be4",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Hound." },
                ResourceCost = 4,
                Willpower = 1,
                Attack = 4,
                Defense = 1,
                HitPoints = 4,
                Text = "Action: Huan gets +5 Attack until the end of the phase. At the end of the phase in which you trigger this effect, discard Huan. (Limit once per round.)\r\n\r\nAction: Attach Huan to Beren or Lúthien. (Counts as a Mount attachment with the text: 'While attached hero is committed to the quest, deal 2 damage to each enemy revealed during staging.'",
                EncounterSet = "First Age",
                CardNumber = 28,
                Artist = Artist.Rick_Ritchie
            });
            Cards.Add(new LotRCard() {
                Title = "Huor",
                
                Id = "5ed2a83a-fb4d-48ed-847c-8e5e3a116cc6",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Edain.", "House of Hador.", "Warrior." },
                ResourceCost = 3,
                Willpower = 1,
                Attack = 1,
                Defense = 2,
                HitPoints = 3,
                Text = "Huor may be assigned damage from undefended attacks.",
                EncounterSet = "First Age",
                CardNumber = 35,
                Artist = Artist.Unknown
            });
            Cards.Add(new LotRCard() {
                Title = "Mablung",
                
                Id = "f59f2aa8-ce8a-4fbe-bfdf-420e6b330aed",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Teleri.", "Warrior." },
                ResourceCost = 4,
                Willpower = 2,
                Attack = 2,
                Defense = 2,
                HitPoints = 3,
                Text = "Response: After Mablung commits to a quest, choose a character. That character gets +1 Willpower and +1 Defense until the end of the round.",
                EncounterSet = "First Age",
                CardNumber = 23,
                Artist = Artist.Cherif_Fortin
            });
            Cards.Add(new LotRCard() {
                Title = "Maedhros",
                
                Id = "357b134b-1af6-4cb4-8fc5-1f7c3fc1cc05",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Mastery,
                Traits = new List<string>() { "Noldor.", "House of Fëanor." },
                ResourceCost = 5,
                Willpower = 3,
                Attack = 3,
                Defense = 2,
                HitPoints = 3,
                Text = "While Maedhros has no Corruption on him, all Noldor characters get +1 Willpower.While Maedhros has at least 1 Corruption on him, all characters with the House of Fëanor trait get +1 Attack.Action: Place 1 Corruption on Maedhros",
                EncounterSet = "First Age",
                CardNumber = 22,
                Artist = Artist.Jenny_Dolfen
            });
            Cards.Add(new LotRCard() {
                Title = "Maeglin",
                
                Id = "bdbcd9ef-ba0d-4136-a973-2ebc7215cd23",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Mastery,
                Traits = new List<string>() { "Noldor.", "Teleri." },
                ResourceCost = 3,
                Willpower = 0,
                Attack = 2,
                Defense = 1,
                HitPoints = 2,
                Text = "Response: After the active location is explored, add 1 resource to a hero's resource pool (2 resources instead if you place 1 Corruption on that hero).",
                EncounterSet = "First Age",
                CardNumber = 21,
                Artist = Artist.Virginie_Carquin
            });
            Cards.Add(new LotRCard() {
                Title = "Maglor",
                
                Id = "12651993-2955-4c4a-8695-5828b0f26f2a",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Mastery,
                Traits = new List<string>() { "Noldor.", "House of Fëanor." },
                ResourceCost = 4,
                Willpower = 3,
                Attack = 1,
                Defense = 1,
                HitPoints = 2,
                Text = "Response: When a Corruption token would be placed on a character you control by the encounter deck, exhaust Maglor to place that Corruption token on Maglor instead.",
                EncounterSet = "First Age",
                CardNumber = 19,
                Artist = Artist.Jenny_Dolfen
            });
            Cards.Add(new LotRCard() {
                Title = "Melian",
                
                Id = "a9b02bb6-4c38-4fb3-8f73-4d2c68a90a89",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Neutral,
                Traits = new List<string>() { "Maia." },
                ResourceCost = 3,
                Willpower = 4,
                Attack = 0,
                Defense = 0,
                HitPoints = 3,
                Text = "At the end of the round, discard Melian from play.\r\nMelian cannot attack or defend.\r\nResponse: After you play Melian from hand, choose a player and (choose 1): enemies do not make engagement checks against the chosen player until the end of the round, enemies cannot attack the chosen player this round, or the chosen player may look at the top 3 cards of the encounter deck.",
                EncounterSet = "First Age",
                CardNumber = 16,
                Artist = Artist.Andrew_Ryan
            });
            Cards.Add(new LotRCard() {
                Title = "Morwen",
                
                Id = "36eba031-02ff-4ea1-b127-aa1adf64bbac",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Edain.", "House of Bëor." },
                ResourceCost = 3,
                Willpower = 2,
                Attack = 0,
                Defense = 1,
                HitPoints = 2,
                Text = "Action: Raise your threat by 1 to give Morwen +1 Willpower until the end of the round. (Limit twice per round.)",
                EncounterSet = "First Age",
                CardNumber = 39,
                Artist = Artist.Ekaterina_Kovalevskaya
            });
            Cards.Add(new LotRCard() {
                Title = "Orodreth",
                
                Id = "c02cefa2-c4ed-4377-a2f4-113d4ed4cbfb",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Noldor.", "House of Finarfin.", "Noble." },
                ResourceCost = 4,
                Willpower = 2,
                Attack = 3,
                Defense = 1,
                HitPoints = 2,
                Text = "Response: After a unique character with the House of Finarfin trait leaves play, put Orodreth into play from your hand.",
                EncounterSet = "First Age",
                CardNumber = 24,
                Artist = Artist.Unknown
            });
            Cards.Add(new LotRCard() {
                Title = "Telchar the Smith",
                
                Id = "3e458f23-12fd-4192-a0f2-676f0aa91287",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Dwarf." },
                ResourceCost = 3,
                Willpower = 1,
                Attack = 1,
                Defense = 1,
                HitPoints = 3,
                Text = "Action: Exhaust Telchar the Smith to choose an Armor or Weapon attachment in play. Until the end of the round, if the chosen attachment is Armor, it gains: 'Attached character gets +1 Defense.' Until the end of the round, if the chosen attachment is a Weapon, it gains: 'Attached character gets +1 Attack.'",
                EncounterSet = "First Age",
                CardNumber = 31,
                Artist = Artist.Luc_de_Haan
            });
            Cards.Add(new LotRCard() {
                Title = "Thorondor",
                
                Id = "4989c17b-edde-4a5d-8438-5fcc23dd0271",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Creature.", "Eagle.", "Noble." },
                ResourceCost = 5,
                Willpower = 2,
                Attack = 4,
                Defense = 1,
                HitPoints = 4,
                Text = "Cannot have restricted attachments.\r\nResponse: After you play Thorondor from hand, put a character from any player's discard pile into play under its owner's control.",
                EncounterSet = "First Age",
                CardNumber = 26,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "Tuor",
                
                Id = "6317b5a1-6547-45de-85b9-f1c9798f4dd2",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Edain.", "House of Hador." },
                ResourceCost = 4,
                Willpower = 3,
                Attack = 1,
                Defense = 1,
                HitPoints = 3,
                Text = "Action: Exhaust Tuor to choose a player. That player looks at the top 3 cards of his deck. He may discard 1 to discard the top card of the encounter deck, returning the remaining cards to the top of his deck in any order.",
                EncounterSet = "First Age",
                CardNumber = 40,
                Artist = Artist.Luca_Michelucci
            });
            Cards.Add(new LotRCard() {
                Title = "Aranrúth",
                Id = "a4274bdd-ac5f-4ca6-8897-b7f4d3c683b7",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Mastery,
                ResourceCost = 2,
                Text = "Attach to a hero with a printed Mastery icon. Restricted.\r\nAction: Exhaust Aranrúth to give attached hero a Leadership, Lore, Tactics, or Spirit icon until the end of the phase.\r\nIf attached hero is Thingol, Aranrúth gains, 'Attached hero gets +2 Attack.'",
                EncounterSet = "First Age",
                CardNumber = 161,
                Artist = Artist.Mathieu_Degrotte
            }.WithTraits("Item.", "Weapon.")
            .WithKeywords("Restricted."));
            Cards.Add(new LotRCard() {
                Title = "Ard-galen Horse",
                Id = "b9ef5e42-ff98-4189-9d36-12d6d57a20ae",
                CardType = CardType.Attachment,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Mount." },
                ResourceCost = 3,
                Text = "Attach to a Noldor hero. Limit 1 per hero.\r\nAction: Exhaust Ard-galen Horse to place 1 progress token on each location in the staging area.",
                EncounterSet = "First Age",
                CardNumber = 57,
                Artist = Artist.Unknown
            });
            Cards.Add(new LotRCard() {
                Title = "Blue Shield",
                
                Id = "af4552f6-713a-4418-a3be-5388655d19f2",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Item.", "Armor." },
                ResourceCost = 1,
                Text = "Attach to a hero with the House of Fingolfin trait.\r\n\r\nAttached hero gets +1 Defense (+2 Defense if the attached hero is Fingolfin).",
                EncounterSet = "First Age",
                CardNumber = 63,
                Artist = Artist.Peter_Xavier_Pric
            });
            Cards.Add(new LotRCard() {
                Title = "Dragon-helm",                
                Id = "9288286a-a88b-41a8-889b-83e8f4c1e91d",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Tactics,
                ResourceCost = 3,
                Text = "Attach to a hero with the House of Hador trait. Restricted.\r\nResponse: After attached hero is damaged, exhaust Dragon-helm and raise your threat by 3 to cancel all damage from that attack.\r\nIf attached hero is Túrin, Dragon-helm gains, 'Response: After an enemy engages with you, it gets -1 Attack and -1 Defense until the end of the round.'",
                EncounterSet = "First Age",
                CardNumber = 64,
                Artist = Artist.Mahdi_Mehrnegar
            }.WithTraits("Item.", "Armor.", "Artifact.")
            .WithKeywords("Restricted."));
            Cards.Add(new LotRCard() {
                Title = "Elf-friend",
                Id = "9972048e-4e59-4444-8957-17d5b43164a7",
                CardType = CardType.Attachment,
                Sphere = Sphere.Spirit,
                ResourceCost = 1,
                Text = "Attach to an Edain hero.\r\nAttached hero gains the Noldor trait.",
                EncounterSet = "First Age",
                CardNumber = 45,
                Artist = Artist.Anke_Eissmann
            }.WithTraits("Title."));
            Cards.Add(new LotRCard() {
                Title = "Galvorn Armor",
                
                Id = "ed103684-c82e-4f33-933b-329fc1598b3f",
                CardType = CardType.Attachment,
                Sphere = Sphere.Mastery,
                Traits = new List<string>() { "Item.", "Armor." },
                ResourceCost = 2,
                Text = "Attach to a Mastery hero. Limit 1 per hero.Attached hero gets +1 Defense. Attached hero gets an additional +1 Defense for each Corruption on the attached hero.",
                EncounterSet = "First Age",
                CardNumber = 58,
                Artist = Artist.Unknown
            });
            addAttachment("Gurthang", 2, Sphere.Mastery, true)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero with a printed Mastery resource icon. Restricted.")
                .WithTextLine("Attached hero gets +1 Attack.")
                .WithTextLine("Response: After attached hero damages an enemy, shuffle the encounter deck and discard the top card. If it is a treachery, cancel all damage from the attack and discard a hero. Otherwise, the enemy is destroyed.")
                .WithInfo(65, 3, Artist.Elena_Kukanova);
            Cards.Add(new LotRCard() {
                Title = "Harp of Fingon",
                
                Id = "63d72bcd-bee5-4eaa-a2b4-8e5af8244d4e",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Instrument." },
                ResourceCost = 2,
                Text = "Attach to a hero with the House of Fingolfin trait.\r\nAction: After a Corruption token is removed from play, exhaust Harp of Fingon to add 1 resource to the attached hero's resource pool.",
                EncounterSet = "First Age",
                CardNumber = 48,
                Artist = Artist.Egor_Gafidov
            });
            Cards.Add(new LotRCard() {
                Title = "Haudh-en-Ndengin",
                
                Id = "56e3c47e-9fbe-4b86-92f5-05679788aa07",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Condition." },
                ResourceCost = 1,
                Text = "Attach to a location in play.While Haudh-en-Ndengin has at least one facedown attachment, the Threat of the attached location is reduced to 0.Response: After a character is destroyed, attach that card facedown to Haudh-en-Ndengin.",
                EncounterSet = "First Age",
                CardNumber = 53,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "Hidden House",
                
                Id = "47905ede-7cb1-4c1d-919a-af92f71fce5a",
                CardType = CardType.Attachment,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Hideout." },
                ResourceCost = 1,
                Text = "Attach to a location in play.While the attached location is the active location, enemies do not make engagement checks.",
                EncounterSet = "First Age",
                CardNumber = 54,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "High Kingship of the Noldor",
                
                Id = "1c20dbce-2c45-4c0b-8c3a-874e84908a25",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Title." },
                ResourceCost = 2,
                Text = "Attach to a Noldor hero.Action: Exhaust High Kingship of the Noldor to add 2 resources to attached hero's resource pool.",
                EncounterSet = "First Age",
                CardNumber = 44,
                Artist = Artist.Mathia_Arkoniel
            });
            Cards.Add(new LotRCard() {
                Title = "Mormegil",
                
                Id = "8a9a4961-146f-4f92-8372-c8f4ac733964",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Mastery,
                Traits = new List<string>() { "Name." },
                ResourceCost = 1,
                Text =
@"Attach to Túrin Turambar. Limit 1 Name in play.

Túrin Turambar gains a Tactics resource icon.
                
All enemies get -1 Threat and -10 engagement cost.",
                EncounterSet = "First Age",
                CardNumber = 66,
                Artist = Artist.Horhe_Soloma
            });
            Cards.Add(new LotRCard() {
                Title = "Nauglamír",
                //Id = "4186631e-c283-4a5e-b364-7a8ade2255ab",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Mastery,
                Traits = new List<string>() { "Item.", "Artifact.", "Silmaril." },
                ResourceCost = 5,
                Text = "Lower the cost to play Nauglamír by 1 for each Dwarf in play. Attach to a hero.Each hero you control gets +1 Willpower, +1 Attack, and +1 Defense.Forced: At the start of the combat phase, discard a resource from the attached hero's resource pool for each Dwarf in play. Any Dwarf for which you did not discard a resource immediately becomes corrupted.",
                EncounterSet = "First Age",
                CardNumber = 56,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "Nimphelos",
                
                Id = "8c871b05-b22c-41ac-8094-fb266dcc895b",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Item.", "Artifact." },
                ResourceCost = 0,
                Text = "Attach to a hero.\r\nAction: Pay 1 resource from attached hero's resource pool to give attached hero +1 Willpower until the end of the phase. (Limit three times per phase.)",
                EncounterSet = "First Age",
                CardNumber = 67,
                Artist = Artist.US_Pixelstory
            });
            Cards.Add(new LotRCard() {
                Title = "Oath of Fëanor",
                Id = "92602678-0802-4c45-971e-0eff7a57855a",
                CardType = CardType.Attachment,
                Sphere = Sphere.Mastery,
                Traits = new List<string>() { "Oath." },
                ResourceCost = 1,
                Text = "Attach to a character with the House of Fëanor trait. Limit 1 per character.\r\nCorruption on the attached character cannot be removed.\r\nPlanning Action: Exhaust Oath of Fëanor to switch the printed Attack and Willpower of the attached character until the end of the round.",
                EncounterSet = "First Age",
                CardNumber = 51,
                Artist = Artist.Jenny_Dolfen
            });
            Cards.Add(new LotRCard() {
                Title = "Oath of Friendship",
                
                Id = "d09ff424-b2df-4b1a-a343-2dafaf3d1d98",
                CardType = CardType.Attachment,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Oath." },
                ResourceCost = 1,
                Text = 
@"Attach to a hero. Limit 2 in play.

Action: Move any number of resources from the attached hero's resource pool to the resource pool of another hero with Oath of Friendship attached.

Response: After you play Oath of Friendship, you may immediately search your deck for another copy of Oath of Friendship and add it to your hand. Then, shuffle your deck.",
                EncounterSet = "First Age",
                CardNumber = 49,
                Artist = Artist.Catherine_Karina_Chmiel
            });
            Cards.Add(new LotRCard() {
                Title = "Oath of Silence",
                
                Id = "57bae876-e0f7-48e2-b626-8b53216ef26c",
                CardType = CardType.Attachment,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Oath." },
                ResourceCost = 0,
                Text = 
@"Attach to a hero. Limit 1 per hero.\r\nForced: Discard one card from your hand at the end of each round.
                
Response: After Oath of Silence is attached to a hero you control, search your deck for 2 cards and add them to your hand. Then, shuffle your deck.",
                EncounterSet = "First Age",
                CardNumber = 52,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "Oath of Vengeance",
                
                Id = "969445ff-0b61-4f68-b563-ae11d365e125",
                CardType = CardType.Attachment,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Oath." },
                ResourceCost = 2,
                Text = 
@"Attach to a hero. Limit 1 per hero.\r\nResponse: After a character you control is destroyed, place 1 resource on Oath of Vengeance.

Action: Spend 1 resource from Oath of Vengeance to give attached hero +1 Willpower or +1 Attack until the end of the phase.",
                EncounterSet = "First Age",
                CardNumber = 50,
                Artist = Artist.Meanor
            });
            addAttachment("Poisoned Javelin", 2, Sphere.Mastery, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Mastery character. Restricted.")
                .WithTextLine("Response: After attached character damages an enemy, attach Poisoned Javelin to that enemy.")
                .WithTextLine("Forced: At the end of each round, if Poisoned Javelin is attached to an enemy, deal 2 damage to that enemy. You may place 1 Corruption on a hero you control to increase this to 4 damage.")
                .WithInfo(59, 3, Artist.John_G);
            Cards.Add(new LotRCard() {
                Title = "Ring of Barahir",
                
                Id = "a9491de0-6e74-4f2f-bfee-1c8e5e441166",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Item.", "Artifact." },
                ResourceCost = 2,
                Text = "Attach to an Edain hero.\r\nAction: Discard Ring of Barahir to put a unique Noldor ally into play from your hand.",
                EncounterSet = "First Age",
                CardNumber = 60,
                Artist = Artist.Anke_Eissmann
            });
            Cards.Add(new LotRCard() {
                Title = "Ringil",                
                Id = "818a434c-d23a-4ec3-ac46-63e2665f4510",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Tactics,
                ResourceCost = 2,
                Text = "Attach to a hero with the House of Fingolfin trait. Restricted.\r\nAttached hero gets +1 Attack (+2 Attack if Fingolfin).\r\nIf the attached hero is Fingolfin, Ringil gains: 'Response: After the attached character attacks alone, cancel all damage from the attack and reduce your threat by that amount instead.'",
                EncounterSet = "First Age",
                CardNumber = 61,
                Artist = Artist.Sarafiel
            }.WithTraits("Item.", "Weapon.")
            .WithKeywords("Restricted."));
            Cards.Add(new LotRCard() {
                Title = "Rochallor",
                Id = "3d3a2ede-39f8-420d-a121-93f19d284253",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Tactics,
                ResourceCost = 2,
                Text = "Attach to Fingolfin.Combat Action: Choose an enemy in the staging area. Exhaust Rochallor and the attached hero to make an attack on that enemy. The attached hero gets +1 Attack (+2 Attack if the enemy is unique).",
                EncounterSet = "First Age",
                CardNumber = 62,
                Artist = Artist.Hector_Hanoteau
            }.WithTraits("Mount."));
            Cards.Add(new LotRCard() {
                Title = "Shadowy Cloak",
                Id = "3ae5e27e-a66a-43a1-a967-c102e9ab9da3",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Spirit,
                ResourceCost = 2,
                Text = "Attach to Lúthien.\r\nResources on Shadowy Cloak can only be used to pay for Lúthien's ability.\r\nAction: Exhaust Shadowy Cloak to either add 1 resource to Shadowy Cloak or ready Lúthien.",
                EncounterSet = "First Age",
                CardNumber = 46,
                Artist = Artist.Ted_Nasmith
            }.WithTraits("Enchantment."));
            Cards.Add(new LotRCard() {
                Title = "Solitary Outlaw",
                
                Id = "5ce97207-9317-4cd5-bb75-1df2c7f0cdb3",
                CardType = CardType.Attachment,
                Sphere = Sphere.Neutral,
                Traits = new List<string>() { "Condition." },
                ResourceCost = 0,
                Text = 
@"Limit 1 per hero.\r\nSetup: Attach to a hero. This hero must be the only hero you control.
                
Attached hero gets +2 Willpower, +2 Attack, +2 Defense, +2 hit points and does not exhaust to quest.",
                EncounterSet = "First Age",
                CardNumber = 55,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "Vingilot",
                
                Id = "1cd9af84-475d-4949-b0a0-6977601aaf86",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Ship." },
                ResourceCost = 2,
                Text = "Attach to a hero with the Half-elven trait.Action: Exhaust Vingilot to use the attached hero's Willpower instead of Defense (or Attack, if attached hero is Eärendil) until the end of the phase.",
                EncounterSet = "First Age",
                CardNumber = 47,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "...And Yet A Warning",
                
                Id = "bbcf552f-73cc-44c4-8d53-d16a926cc895",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                ResourceCost = 1,
                Text = "Response: After you attack and destroy an enemy, choose one: add 1 resource to the resource pool of a hero you control, draw 1 card, or lower your threat by 1.",
                EncounterSet = "First Age",
                CardNumber = 94,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "A Great Doom",
                
                Id = "533740a7-2348-4ef2-9c5d-1bf2b26a4daa",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Doom." },
                ResourceCost = 2,
                Text = "Response: After a player card is drawn or an encounter card is revealed (including a shadow effect), shuffle that card back into its deck and draw a new card.",
                EncounterSet = "First Age",
                CardNumber = 78,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "Arts of Felagund",
                
                Id = "7c6344c7-b769-4548-b64b-ade76bcd9c1c",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Enchantment." },
                ResourceCost = 3,
                VictoryPoints = 1,
                Text = "Quest Action: Until the end of the phase, each enemy revealed during staging is discarded and replaced with the next encounter card instead. Add this card to the victory display.",
                EncounterSet = "First Age",
                CardNumber = 73,
                Artist = Artist.Alan_Lee
            });
            Cards.Add(new LotRCard() {
                Title = "Banners and Horns",
                
                Id = "b3c1c5fd-56ca-4b9c-a9b5-d9796e090c76",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                ResourceCost = 1,
                Text = "Response: After a unique ally you control enters play, choose any non-unique enemy in play. That enemy gets -X Attack and -X Defense until the end of the round. (X is equal to the cost of that ally.)",
                EncounterSet = "First Age",
                CardNumber = 85,
                Artist = Artist.Jenny_Dolfen
            });
            Cards.Add(new LotRCard() {
                Title = "Dark Elf",
                
                Id = "e642bba0-dd93-4d9c-b714-113ab91480d2",
                CardType = CardType.Event,
                Sphere = Sphere.Mastery,
                ResourceCost = 0,
                Text = "Action: Place X Corruption on heroes you control to draw X cards. (X cannot be greater than the number of heroes you control.)",
                EncounterSet = "First Age",
                CardNumber = 159,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "Dark Heart of the Smith",
                
                Id = "6795405b-b28c-43bf-ae4d-318643d19d63",
                CardType = CardType.Event,
                Sphere = Sphere.Mastery,
                ResourceCost = 0,
                Text = "Action: Place 1 Corruption on a character with a unique Weapon attached. All damage dealt by that character is doubled this round. Only 1 copy of Dark Heart of the Smith may be played on a character each round.",
                EncounterSet = "First Age",
                CardNumber = 82,
                Artist = Artist.Noldomirwen
            });
            Cards.Add(new LotRCard() {
                Title = "Day Shall Come Again",
                
                Id = "7bbfe8f2-e9ed-430f-a01a-0b27b6eba9a4",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                ResourceCost = 1,
                Text = "Response: After a character you control destroys an enemy, ready that character. That character gets +1 Attack until the end of the round. You may pay 1 Tactics resource to return Day Shall Come Again to your hand.",
                EncounterSet = "First Age",
                CardNumber = 98,
                Artist = Artist.Julia_Alekseeva
            });
            Cards.Add(new LotRCard() {
                Title = "Defied and Mocked",
                
                Id = "96fa686b-dcae-426d-b002-9a4f45754117",
                CardType = CardType.Event,
                Sphere = Sphere.Mastery,
                ResourceCost = 1,
                Text = "Action: Choose an ally. That ally can be assigned damage from undefended attacks until the end of the phase.",
                EncounterSet = "First Age",
                CardNumber = 80,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "Dreadful Death",
                
                Id = "8bba480a-0306-4eb3-a577-99cdef1e1430",
                CardType = CardType.Event,
                Sphere = Sphere.Mastery,
                ResourceCost = 0,
                Text = "Response: After a corrupted character destroys a hero or ally, remove all Corruption from that character and place it under your control.",
                EncounterSet = "First Age",
                CardNumber = 81,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "Dreams from Ulmo",
                
                Id = "8cfb1da9-d041-44f4-acb7-42a872bd55e0",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Vala." },
                ResourceCost = 1,
                Text = "If the active location is a River or Water location, reduce the cost to play Dreams from Ulmo by 1.\r\nAction: Choose one character you control. Shuffle the encounter deck and look at its top card. Until the end of the phase, the chosen character gets +X Willpower. X is equal to the revealed card's Threat.",
                EncounterSet = "First Age",
                CardNumber = 90,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "Erchamion",
                
                Id = "0061b168-c37d-46bc-ac7b-2eedad688b80",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Condition." },
                ResourceCost = 3,
                Text = "Response: After a character is destroyed, put that character back into play under its owner's control. Attach Erchamion to that character. (Counts as a Condition attachment with the text: 'The attached character gets -1 Attack and -1 Defense.'",
                EncounterSet = "First Age",
                CardNumber = 69,
                Artist = Artist.Dylan_Palmer
            });
            Cards.Add(new LotRCard() {
                Title = "Feast of Reuniting",
                
                Id = "e8fd8691-39fe-49fe-9292-b47399d1153e",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                ResourceCost = 3,
                Text = "Action: All characters gain ranged and sentinel until the end of the phase.",
                EncounterSet = "First Age",
                CardNumber = 84,
                Artist = Artist.Pieter_Claesz
            });
            Cards.Add(new LotRCard() {
                Title = "Fire of Life",
                
                Id = "50166774-b3ac-425b-8662-8caf1986688e",
                CardType = CardType.Event,
                Sphere = Sphere.Mastery,
                Traits = new List<string>() { "Condition." },
                ResourceCost = 0,
                Text = "Response: After a character with the House of Fëanor trait is damaged, cancel 1 point of that damage and attach Fire of Life to that character. (Counts as a Condition attachment with the text: 'Limit 1 per character. Attached character gets +1 Attack.')",
                EncounterSet = "First Age",
                CardNumber = 79,
                Artist = Artist.Rick_Ritchie
            });
            Cards.Add(new LotRCard() {
                Title = "Flame Light! Flee Night!",
                
                Id = "600f25fa-0863-4f7c-baf2-e68677200988",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                ResourceCost = 1,
                Text = "Play only if you control a hero with the Edain trait.\r\nAction: Search your deck for a character with the Edain trait and put it into play. That character does not exhaust to quest, attack, or defend until the end of the round. Discard that character at the end of the round.",
                EncounterSet = "First Age",
                CardNumber = 96,
                Artist = Artist.John_Howe
            });
            Cards.Add(new LotRCard() {
                Title = "Friendship of Ulmo",
                
                Id = "92cc7a50-91b9-469b-8038-20d18807c29e",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Vala." },
                ResourceCost = 2,
                Text = "If the active location is a River or Water location, reduce the cost to play Friendship of Ulmo by 2.\r\nAction: Reveal all shadow cards in play. Then, choose two shadow cards from different enemies and switch them.",
                EncounterSet = "First Age",
                CardNumber = 91,
                Artist = Artist.John_Howe
            });
            Cards.Add(new LotRCard() {
                Title = "Hold to the Oath",
                
                Id = "eddac7bc-182e-4b80-9171-bfa48dbfa679",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Oath." },
                ResourceCost = 1,
                Text = "Action: Each character with an attached Oath gets +1 Willpower, +1 Attack, and +1 Defense until the end of the round.",
                EncounterSet = "First Age",
                CardNumber = 87,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "Hour of Need",
                
                Id = "94639ce3-19a2-41dc-92f5-e4a7b4d44b06",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                ResourceCost = 2,
                Text = "Response: If at least X enemies are engaged with players (X being equal to twice the number of players), each player may put 1 ally into play from his hand, if able.",
                EncounterSet = "First Age",
                CardNumber = 77,
                Artist = Artist.Justin_Gerard
            });
            Cards.Add(new LotRCard() {
                Title = "Leaguer",
                
                Id = "af32245f-be6f-4efc-87a2-e58ca08e8d42",
                CardType = CardType.Event,
                Sphere = Sphere.Neutral,
                ResourceCost = 0,
                Text = "Action: Exhaust characters with X points of total Defense to choose enemies with up to X points of total Attack. Those enemies cannot attack this round.",
                EncounterSet = "First Age",
                CardNumber = 75,
                Artist = Artist.John_Howe
            });
            Cards.Add(new LotRCard() {
                Title = "Madness of Rage",
                
                Id = "ddb7c844-c06b-453a-bbe9-5d4b9795859d",
                CardType = CardType.Event,
                Sphere = Sphere.Mastery,
                ResourceCost = 0,
                Text = "Action: Choose a character you control. Until the end of the phase, that character gets +3 Attack and must attack alone.",
                EncounterSet = "First Age",
                CardNumber = 76,
                Artist = Artist.Joel_M_Kilpatrick
            });
            Cards.Add(new LotRCard() {
                Title = "Manwë's Pity",
                Id = "b0356374-d811-4ebf-84e0-916262b4b8ac",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Vala." },
                ResourceCost = 0,
                Text = "Response: After a unique Noldor ally you control is destroyed by an enemy attack, immediately put into play another copy of that ally from your hand.",
                EncounterSet = "First Age",
                CardNumber = 88,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "No Better Hope",
                
                Id = "33c90530-7cef-4138-b6b5-0bbe5c997f1f",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                ResourceCost = 1,
                Text = "Action: Exhaust a hero you control to discard a corrupted character from play.",
                EncounterSet = "First Age",
                CardNumber = 86,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "Open Battle",                
                Id = "6cd143f3-4f7b-40c7-a09d-3f37b910676b",
                CardType = CardType.Event,
                Sphere = Sphere.Mastery,
                ResourceCost = 0,
                Text = "Action: Each player may search his deck for a Weapon or Armor attachment and add it to his hand.",
                EncounterSet = "First Age",
                CardNumber = 97,
                Artist = Artist.Unknown
            }.WithTraits("Plan.")
            .WithKeywords("Doomed 2."));
            Cards.Add(new LotRCard() {
                Title = "Passed in Peace",
                Id = "495c08de-1f3d-4d5c-9c27-2767c3dab2f3",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                ResourceCost = 1,
                Text = "Response: After a character with the Edain trait leaves play, play Passed in Peace to draw 2 cards.",
                EncounterSet = "First Age",
                CardNumber = 74,
                Artist = Artist.Rafael_Damiani
            });
            Cards.Add(new LotRCard() {
                Title = "Secret Toil",
                Id = "78970cd3-4c09-4c5d-83a7-261fb7dddfd6",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                ResourceCost = 1,
                Text = "Action: Exhaust 2 heroes you control to reveal the top 5 cards of your deck. Choose one attachment or ally and put it into play for no cost. Shuffle all other revealed cards back into your deck.",
                EncounterSet = "First Age",
                CardNumber = 93,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "Secrets of Craft",
                
                Id = "3840d489-587b-4ffb-8159-1040aa258f88",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                ResourceCost = 1,
                Text = "Action: Choose a player. That player draws 1 card for each Item attachment you control.",
                EncounterSet = "First Age",
                CardNumber = 89,
                Artist = Artist.Steamey
            });
            Cards.Add(new LotRCard() {
                Title = "Song of Gladness",
                
                Id = "44138d4e-bb5d-4413-b28e-e29a39d93bc5",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Song." },
                ResourceCost = 0,
                Text = 
@"Play only if there are no enemies engaged with you.
                
Action: Reduce your threat by 3.",
                EncounterSet = "First Age",
                CardNumber = 95,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "Song of Lúthien",
                Id = "0236a411-93bd-4865-99c7-afbbcf66e0a8",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Song." },
                ResourceCost = 2,
                Text = "Action: If you control Lúthien or a unique Maia character, reduce each player's threat by 3.",
                EncounterSet = "First Age",
                CardNumber = 71,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "Song of Staying",
                
                Id = "1e9fb582-1b63-4d5e-98a1-c95b4ea8d5b4",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Song." },
                ResourceCost = 1,
                Text = "Response: After a treachery with doomed or surge is revealed, cancel the effects of all keywords on that treachery.",
                EncounterSet = "First Age",
                CardNumber = 72,
                Artist = Artist.FangornSpirit
            });
            Cards.Add(new LotRCard() {
                Title = "Strength of Men",
                
                Id = "d2f9888e-31f9-42ef-b930-50d67ddcd2f8",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                ResourceCost = 3,
                Text = "Action: Exhaust an ally with the Edain trait. Add the Willpower, Attack, and Defense of that ally to all characters with the Noldor trait you control until the end of the round.",
                EncounterSet = "First Age",
                CardNumber = 68,
                Artist = Artist.Riyahd_Cassiem
            });
            Cards.Add(new LotRCard() {
                Title = "Strengthen the Watch",
                
                Id = "b03a4bd2-850f-4d18-b61b-28248537d448",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                ResourceCost = 0,
                Text = "Encounter Action: Exhaust a character. All enemies that engaged you this phase get -1 Attack until the end of the round.",
                EncounterSet = "First Age",
                CardNumber = 92,
                Artist = Artist.Felix_Sotomayor
            });
            Cards.Add(new LotRCard() {
                Title = "The Day Has Come!",
                
                Id = "64f09d1d-9421-449d-a121-9b572001e576",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                ResourceCost = 2,
                Text = "Action: Until the end of the phase, all Noldor characters get +1 Willpower.",
                EncounterSet = "First Age",
                CardNumber = 70,
                Artist = Artist.Lady_Elleth
            });
            Cards.Add(new LotRCard() {
                Title = "Undismayed",
                
                Id = "d2f9f10a-db5c-4aa0-ae0c-e9d33c244a69",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                ResourceCost = 1,
                Text = "Response: After a character is destroyed by an enemy attack, put that character back into play. That character gets +3 Attack and is discarded at the end of the phase.",
                EncounterSet = "First Age",
                CardNumber = 83,
                Artist = Artist.Carlo_Pagulayan
            });
            Cards.Add(new LotRCard() {
                Title = "Beren",
                
                Id = "a63323ae-29de-4368-b8c8-7fa8131d9224",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Edain.", "House of Bëor.", "Noble." },
                ThreatCost = 8,
                Willpower = 3,
                Attack = 2,
                Defense = 1,
                HitPoints = 4,
                Text = "While Beren is committed to the quest, he gains: 'Response: After an encounter card with at least 3 Threat is revealed from the encounter deck, add 1 resource to Beren's resource pool.'",
                EncounterSet = "First Age",
                CardNumber = 87,
                Artist = Artist.Anke_Eissmann
            });
            Cards.Add(new LotRCard() {
                Title = "Círdan",
                Id = "b47b0c9d-67d8-49cf-b481-e812cb6aa4df",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Teleri.", "Noble." },
                ThreatCost = 9,
                Willpower = 3,
                Attack = 1,
                Defense = 2,
                HitPoints = 4,
                Text = "Círdan gets +1 Defense for each attached character.Planning Action: Attach a character to Círdan. This character is considered to be out of play. At the end of the round, heal 3 damage on that character and put it back into play. (Limit twice per round.)",
                EncounterSet = "First Age",
                CardNumber = 13,
                Artist = Artist.MouMou38
            });
            Cards.Add(new LotRCard() {
                Title = "Eärendil",
                Id = "464a02c5-9a1c-4391-bbe8-ed2563a89ae5",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Half-elven.", "Noble." },
                ThreatCost = 8,
                Willpower = 4,
                Attack = 1,
                Defense = 1,
                HitPoints = 3,
                Text = "Response: After Eärendil commits to the quest, shuffle the encounter deck and discard the top card. If it is a treachery, deal 1 damage to Eärendil. Otherwise, reduce your threat by 1 and draw 1 card.",
                EncounterSet = "First Age",
                CardNumber = 5,
                Artist = Artist.Jenny_Dolfen
            });
            Cards.Add(new LotRCard() {
                Title = "Ecthelion",
                
                Id = "370caea5-4a48-4031-b416-608b66880dbb",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Noldor.", "Warrior." },
                ThreatCost = 11,
                Willpower = 1,
                Attack = 4,
                Defense = 3,
                HitPoints = 4,
                Text = "When Ecthelion attacks alone, the defending enemy does not count its Defense.",
                EncounterSet = "First Age",
                CardNumber = 12,
                Artist = Artist.Jan_Pospisil
            });
            Cards.Add(new LotRCard() {
                Title = "Fëanor",
                Id = "8147cf97-844f-41db-a6cb-456bb2d8d1bb",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Mastery,
                Traits = new List<string>() { "Noldor.", "House of Fëanor.", "Noble." },
                ThreatCost = 12,
                Willpower = 3,
                Attack = 4,
                Defense = 1,
                HitPoints = 5,
                Text = 
@"Action: Place 1 Corruption on Fëanor to place 3 progress tokens on the quest. (Limit once per round).
                
Action: Place 1 Corruption on Fëanor to play an attachment from any sphere of influence for no cost.",
                EncounterSet = "First Age",
                CardNumber = 7,
                Artist = Artist.Vishal
            });
            Cards.Add(new LotRCard() {
                Title = "Fingolfin",                
                //Id = "2aa57f53-97d0-45e9-9254-9c064889d1ea",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Tactics,
                ThreatCost = 11,
                Willpower = 1,
                Attack = 1,
                Defense = 4,
                HitPoints = 6,
                Text = "Action: Raise your threat by 3 to choose an enemy in play. Engage the chosen enemy. Until the end of the round, Fingolfin does not exhaust to defend against the chosen enemy.",
                EncounterSet = "First Age",
                CardNumber = 10,
                Artist = Artist.Murat_Calis
            }.WithTraits("Noldor.", "House of Fingolfin.", "Noble.")
            .WithKeywords("Sentinel."));
            Cards.Add(new LotRCard() {
                Title = "Fingon",
                Id = "69a4e781-151b-4d30-a24e-6137009bf22e",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Leadership,
                ThreatCost = 11,
                Willpower = 3,
                Attack = 1,
                Defense = 2,
                HitPoints = 5,
                Text = "Action: Exhaust Fingon to remove 1 Corruption from a character in play. (Limit once per round.)",
                EncounterSet = "First Age",
                CardNumber = 3,
                Artist = Artist.Venlian
            }.WithTraits("Noldor.", "House of Fingolfin.", "Noble."));
            Cards.Add(new LotRCard() {
                Title = "Finrod Felagund",
                Id = "cf173190-392e-47d7-8d04-b3401434296e",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Noldor.", "House of Finarfin.", "Noble." },
                ThreatCost = 10,
                Willpower = 3,
                Attack = 3,
                Defense = 1,
                HitPoints = 4,
                Text = "While Finrod Felagund is in play, each Edain character gets +1 Willpower.",
                EncounterSet = "First Age",
                CardNumber = 2,
                Artist = Artist.Niyochara
            });
            Cards.Add(new LotRCard() {
                Title = "Haleth",
                
                Id = "877ac60b-3a6d-48b0-8bb8-5a5ae8d5ff4c",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Edain.", "House of Haleth.", "Noble." },
                ThreatCost = 6,
                Willpower = 2,
                Attack = 1,
                Defense = 1,
                HitPoints = 4,
                Text = "Haleth gets +1 Willpower for each enemy engaged with you.If Haleth did not commit to the quest this round, she may use Willpower instead of Defense when defending.",
                EncounterSet = "First Age",
                CardNumber = 6,
                Artist = Artist.ZavgoSpb
            });
            Cards.Add(new LotRCard() {
                Title = "Húrin",
                Id = "612a0a90-b2d9-49c4-88af-8d99fbd00dab",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Tactics,
                ThreatCost = 8,
                Willpower = 2,
                Attack = 2,
                Defense = 2,
                HitPoints = 4,
                Traits = new List<string> { "Edain.", "House of Hador.", "Warrior." },
                Text = "Húrin gets +1 Attack for each enemy engaged with you.",
                EncounterSet = "First Age",
                CardNumber = 11,
                Artist = Artist.Kimberly80
            });
            Cards.Add(new LotRCard() {
                Title = "Idril Celebrindal",
                
                Id = "3944f3e6-15bc-4af6-8e50-b92a7f8d20d6",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Noldor.", "House of Fingolfin.", "Noble." },
                ThreatCost = 7,
                Willpower = 3,
                Attack = 1,
                Defense = 1,
                HitPoints = 3,
                Text = "Response: After the active location is explored, return 1 ally of X cost from your discard pile to your hand. X is the Threat of the active location.",
                EncounterSet = "First Age",
                CardNumber = 15,
                Artist = Artist.LigaMarta
            });
            Cards.Add(new LotRCard() {
                Title = "Lúthien",
                Id = "267a3597-c2d2-4de0-8121-4c3e71678b2f",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Teleri.", "Noble." },
                ThreatCost = 8,
                Willpower = 5,
                Attack = 0,
                Defense = 1,
                HitPoints = 3,
                Text = "Action: Exhaust Lúthien and pay 2 resources from her pool to place an enemy facedown (4 resources instead if the enemy is unique). That enemy is considered to be out of play for all purposes (except victory and advancement conditions) until the end of the phase.",
                EncounterSet = "First Age",
                CardNumber = 4,
                Artist = Artist.Miao_Yu
            });
            Cards.Add(new LotRCard() {
                Title = "Thingol",
                
                Id = "31de6df1-d605-4ad4-ac36-29f717bfc92e",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Mastery,
                Traits = new List<string>() { "Teleri.", "Noble." },
                ThreatCost = 7,
                Willpower = 3,
                Attack = 1,
                Defense = 2,
                HitPoints = 4,
                Text = "While at least 1 character with the House of Fëanor trait is in play, Thingol's Willpower is treated as 1 for the purposes of Corruption.Setup: Choose 10 different cards from your deck and shuffle them into a separate Menegroth deck. After an enemy engages you, draw 1 card from the Menegroth deck.",
                EncounterSet = "First Age",
                CardNumber = 8,
                Artist = Artist.Michael_Boatwright
            });
            Cards.Add(new LotRCard() {
                Title = "Turgon",
                
                Id = "6eae327e-c827-4f1a-97aa-01967e3c9051",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Noldor.", "House of Fingolfin.", "Noble." },
                ThreatCost = 11,
                Willpower = 2,
                Attack = 2,
                Defense = 3,
                HitPoints = 5,
                Text = "Response: After raising your threat, name an encounter card type. Look at the top card of the encounter deck. If it matches the type you named, draw 1 card. If not, shuffle the encounter deck. (Limit once per phase.)",
                EncounterSet = "First Age",
                CardNumber = 14,
                Artist = Artist.Sattarov
            });
            Cards.Add(new LotRCard() {
                Title = "Túrin Turambar",
                Id = "401c19ae-f7b8-4ce8-80ec-06c14ef6b323",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Mastery,
                Traits = new List<string>() { "Edain.", "House of Hador.", "Warrior." },
                ThreatCost = 9,
                Willpower = 1,
                Attack = 2,
                Defense = 2,
                HitPoints = 4,
                Text = "Action: Raise your threat by 1 to give Túrin Turambar +1 Attack until the end of the round.\r\nResponse: After Túrin Turambar is dealt any amount of damage, discard a character you control to cancel that damage. (Limit once per phase.)",
                EncounterSet = "First Age",
                CardNumber = 9,
                Artist = Artist.Alan_Lee
            });
            Cards.Add(new LotRCard() {
                Title = "Carcharoth the Wolf of Angband",
                Id = "0577b869-c00d-47dd-bb49-95e0b08022ec",
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 50,
                Threat = 6,
                Attack = 5,
                Defense = 8,
                HitPoints = 20,
                Quantity = 3,
                Text = "Immune to player card effects.\r\nForced: While Carcharoth the Wolf of Angband is in the staging area, he attacks a random location in play during the combat phase (the first player may declare a defender if it is the active location).\r\nWhen Revealed: Add 1 damage to the current quest stage.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 167,
                Artist = Artist.Razielmn
            }.WithTraits("Creature.", "Werewolf.")
            .WithKeywords("Indestructible."));
            Cards.Add(new LotRCard() {
                Title = "Carcharoth the Devouring Spirit",
                Id = "63ab237a-2da9-41a1-977a-9a64cd17cb74",
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 50,
                Threat = 4,
                Attack = 8,
                Defense = 6,
                HitPoints = 20,
                Quantity = 3,
                Text = "Immune to player card effects.\r\nForced: While Carcharoth the Devouring Spirit is in the staging area, he attacks a random location in play during the combat phase (the first player may declare a defender if it is the active location).\r\nWhen Revealed: Carcharoth the Devouring Spirit makes an immediate attack on the first player.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 168,
                Artist = Artist.Nasko_Moskov
            }.WithTraits("Creature.", "Werewolf.")
            .WithKeywords("Indestructible."));
            Cards.Add(new LotRCard() {
                Title = "Carcharoth the Red Maw",                
                Id = "b2fb8e22-c2c4-4cab-be7a-2fb1f30916bc",
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 50,
                Threat = 5,
                Attack = 6,
                Defense = 7,
                HitPoints = 20,
                Quantity = 3,
                Text = "Immune to player card effects.\r\nForced: While Carcharoth the Red Maw is in the staging area, he attacks a random location in play during the combat phase (the first player may declare a defender if it is the active location).\r\nForced: Caracharoth the Red Maw makes two attacks during the combat phase. (Deal a separate shadow card for each attack.)",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 166,
                Artist = Artist.WavingMonsterStudios
            }.WithTraits("Creature.", "Werewolf.")
            .WithKeywords("Indestructible."));
            Cards.Add(new LotRCard() {
                Title = "Carcharoth the Tormented",
                Id = "1b1b1030-6a1c-43dc-94d3-85a2515e4e81",
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 1,
                Threat = 6,
                Attack = 9,
                Defense = 9,
                HitPoints = 25,
                Quantity = 1,
                Text = "Cannot leave play.\r\nForced: Carcharoth the Tormented engages the first player during the encounter phase.\r\nForced: After an attack by Carcharoth the Tormented resolves, discard one character the defending player controls.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 169,
                Artist = Artist.Dechambo
            }.WithTraits("Creature.", "Werewolf.")
            .WithKeywords("Relentless."));
            Cards.Add(new LotRCard() {
                Title = "Banks of the Esgalduin",                
                Id = "20e151a1-5ed2-49c7-9d6c-f8fa7cea829d",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 5,
                Quantity = 2,
                Text = "Forced: If Banks of the Esgalduin is destroyed, remove 5 damage from Carcharoth.Travel: Each player must discard an attachment he controls.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 175,
                Artist = Artist.Ao_Yi_Chuan
            }.WithTraits("River.", "Water.")
            .WithKeywords("Hunt 1."));
            Cards.Add(new LotRCard() {
                Title = "Brethil Dwelling",
                Id = "e6eb53ee-ae0c-4cec-b221-10fbe03b6d91",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 5,
                Quantity = 3,
                Text = "Forced: After Brethil Dwelling is destroyed, each player must deal 3 Corruption among heroes he controls.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 173,
                Artist = Artist.Unknown
            }.WithTraits("Outpost.")
            .WithKeywords("Hunt 2."));
            Cards.Add(new LotRCard() {
                Title = "Dark Valley",                
                Id = "e24b29f1-50ac-4c3d-a844-a5d75298f1c7",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 6,
                Quantity = 2,
                Text = "While Dark Valley is the active location, you may choose which Carcharoth is revealed at the beginning of the quest phase. Shuffle the Carcharoth deck.\r\nTravel: Carcharoth makes an immediate attack against the first player.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 179,
                Artist = Artist.Albert_Bierstadt
            }.WithTraits("Valley.", "Water.")
            .WithKeywords("Hunt 3."));
            Cards.Add(new LotRCard() {
                Title = "Dimbar Field",                
                Id = "a89e2f4f-67fd-41e8-aae4-2635b066784c",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 5,
                Quantity = 2,
                Text = "While Dimbar Field is the active location, all heroes gain ranged.\r\nTravel: Discard all allies in each player's hand.",
                Shadow = "Shadow: The attacking enemy makes an additional attack after this one.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 172,
                Artist = Artist.Bobby_Fieldhouse
            }.WithTraits("Plain.")
            .WithKeywords("Hunt 1."));
            Cards.Add(new LotRCard() {
                Title = "Eaves of Region",
                Id = "2c2b1c05-919a-43a3-bccb-828d09d4a1f2",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 3,
                Quantity = 3,
                Text = "While Eaves of Region is the active location, Carcharoth takes 1 damage at the end of the round.\r\nTravel: Each player must discard 1 random card from his hand.",
                Shadow = "Shadow: Either destroy a location in play or choose a new defender. (You may choose a location that is the target of this attack.)",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 174,
                Artist = Artist.FrozenStocks
            }.WithTraits("Forest.")
            .WithKeywords("Hunt 1."));
            Cards.Add(new LotRCard() {
                Title = "Gates of Menegroth",                
                Id = "da73fa42-76b3-4ca0-8d93-339a6c503691",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 10,
                Quantity = 1,
                Text = "Forced: If Gates of Menegroth is destroyed, the players lose the game.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 178,
                Artist = Artist.Ilya_Nazarov
            }.WithTraits("Fortification."));
            Cards.Add(new LotRCard() {
                Title = "Iant Iaur",
                Id = "36475989-914f-4190-a619-6bc032c19034",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 5,
                QuestPoints = 4,
                Quantity = 1,
                Text = "Forced: After Iant Iaur is destroyed, add 1 damage to the current quest stage.Response: After Iant Iaur is added to the victory display, remove 1 damage from the current quest stage.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 177,
                Artist = Artist.Nimarra
            }.WithTraits("Bridge.", "Water.")
            .WithKeywords("Hunt 1."));
            Cards.Add(new LotRCard() {
                Title = "Neldoreth Settlement",
                Id = "f477641e-650d-4025-9abb-a5ef12bd9663",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 6,
                Quantity = 3,
                Text = "Forced: If Neldoreth Settlement is destroyed, deal 1 Corruption to each character in play.",
                Shadow = "Shadow: If the defending character or location is destroyed, exhausted characters do not ready at the end of the round.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 176,
                Artist = Artist.Ron_Crabb
            }.WithTraits("Outpost.")
            .WithKeywords("Hunt 2."));
            Cards.Add(new LotRCard() {
                Title = "Pass of Anach",
                Id = "5f09bd7b-f321-4531-81e3-58a8c1e4befb",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 4,
                Quantity = 1,
                Text = "Travel: Each player must discard 1 character he controls.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 171,
                Artist = Artist.Ferdinand_Dumago_Ladera
            }.WithTraits("Mountain.")
            .WithKeywords("Hunt 2."));
            Cards.Add(new LotRCard() {
                Title = "Taur-nu-Fuin",                
                Id = "a2ca8cfa-856d-43ab-bae7-fea5c55bb786",
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 2,
                Quantity = 2,
                Text = "Travel: Each player places the top card of his deck face down in front of him as if it just engaged him from the staging area. These cards are called 'Phantom' and act as enemies with: 3 hit points, 4 Attack, and 1 Defense.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 170,
                Artist = Artist.Darek_Zabrocki
            }.WithTraits("Forest.", "Dark.")
            .WithKeywords("Hunt 2."));
            Cards.Add(new LotRCard() {
                Title = "Beleg Strongbow",                
                Id = "cad9261a-140a-4aaf-82d3-07229e9f1fce",
                IsUnique = true,
                CardType = CardType.Objective,
                Traits = new List<string>() { "Teleri." },
                Willpower = 2,
                Attack = 2,
                Defense = 2,
                HitPoints = 4,
                Quantity = 1,
                Text = "The first player gains control of Beleg Strongbow.Action: Exhaust Beleg Strongbow to remove 2 damage from a location in play.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 165,
                Artist = Artist.BrokenMachine86
            });
            Cards.Add(new LotRCard() {
                Title = "At Last Upon the Wolf",
                StageNumber = 2,
                Id = "e0d350d5-742f-4924-863a-4db922a71a8a",
                CardType = CardType.Quest,
                Quantity = 1,
                QuestPoints = null,
                Text = "When Revealed: Remove Carcharoth from play and put the Carcharoth deck aside. Add Carcharoth the Tormented to the staging area. Remove half of the damage on Carcharoth (rounding up).",
                OppositeText = 
@"When Revealed: Discard all Hunt locations from the victory display.

Forced: If an ally is destroyed by Carcharoth, place 1 damage on this stage. After the 4th damage is placed on this stage, reset the quest deck to stage 1A and follow the setup instructions again.

If Carcharoth the Tormented is destroyed, you have recovered the Silmaril and won the game.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 163,
                Artist = Artist.Unknown
            });
            Cards.Add(new LotRCard() {
                Title = "Ride Forth in the Morning",
                StageNumber = 1,
                Id = "1187c127-c5ef-45fa-962f-ff3d54ac7fe9",
                CardType = CardType.Quest,
                QuestPoints = 20,
                Quantity = 1,
                Text = "Setup: Place Carcharoth the Tormented and Gates of Menegroth aside, out of play. Shuffle all other copies of Carcharoth into a Carcharoth deck. Each player must search the encounter deck for 1 different location and add it to the staging area. Put the Beleg Strongbow objective ally into play.",
                OppositeText = 
@"Forced: After a location is destroyed, place 1 damage on this quest stage. After the 10th damage is placed on this stage, advance to stage 3.

Forced: If there is no location in play at the end of the round, the first player must search the encounter deck and discard pile for 1 location and add it to the staging area.

Players cannot advance to stage 2 unless Carcharoth has at least 10 damage on him.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 162,
                Artist = Artist.Anke_Eissmann
            });
            Cards.Add(new LotRCard() {
                Title = "Ruin Upon the World",
                StageNumber = 3,
                Id = "444d39bf-aee8-488e-ad06-ee36445e5ec4",
                CardType = CardType.Quest,
                QuestPoints = null,
                Quantity = 1,
                Text = "When Revealed: Gates of Menegroth becomes the active location, moving any previous active location to the staging area.",
                OppositeText =
@"Siege.

Forced: Reveal 1 additional encounter card from the encounter deck each quest phase.

Forced: After Gates of Menegroth is explored as the active location, reset the quest deck to stage 1B.

If Gates of Menegroth is destroyed, the players lose the game.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 164,
                Artist = Artist.Steamey
            });
            Cards.Add(new LotRCard() {
                Title = "Hunting of the Wolf",
                Id = "db41eb04-4428-4b6f-8a7f-358cb4507a74",
                CardType = CardType.Campaign,
                Text = "Corruption\r\n\r\nWhen a character takes Corruption, place a progress token on it. If a character ever has Corruption greater than its willpower, it has become Corrupted. A Corrupted character loses the 'ally' or 'here' trait and gains the 'enemy' trait, immediately engaging the player that used to control it. The Willpower of the Corrupted character becomes its Threat and its engagement cost is 0.\r\n\r\nRelentless\r\n\r\nAn enemy with Relentless cannot have its attack canceled or be prevented from attacking by any player card effect.",
                OppositeText = "Carcharoth Deck\r\n\r\nDuring the quest phase, reveal the top card of the Carcharoth deck after characters have commited to the quest and before staging. Place this card in the staging area and discard any previous copies of Carcharoth into a separate discard pile for the Carcharoth deck. Transfer any damage and attachments to the new version of Carcharoth. If the Carcharoth deck is empty when you need to reveal a card from this deck, shuffle the discard pile for the Carcharoth deck to form a new Carcharoth deck.\r\n\r\nHunt\r\n\r\nWhen a location with the Hunt keyword is explored as the active location, add it to the victory display. During the encounter phase, players may discard 5 Hunt points worth of locations from the victory display to engage Carcharoth. The players may decide which player will engage with Carcharoth.\r\n\r\nCarcharoth Combat\r\n\r\nWhen Carcharoth attacks a location, subtract the threat of the location from Carcharoth's attack. The difference is the number of damage tokens placed on the location. If a location receives damage equal to its quest points, it is considered to be destroyed and is discarded. If Carcharoth attacks the active location, the first player may declare a defender. Note that Carcharoth the Red Maw attacks twice during the combat phase. Choose a random location for each attack. He may attack the same location twice if it is chosen twice.",
                Quantity = 1,
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 161,
                Artist = Artist.Dechambo
            }.WithSlugSuffix("Campaign"));
            Cards.Add(new LotRCard() {
                Title = "A Doom Fulfilled",
                
                Id = "59f3a810-fc7e-4aa3-bbc6-2d66dc489909",
                CardType = CardType.Treachery,
                Traits = new List<string>() { "Doom." },
                Quantity = 3,
                Text = "When Revealed: Attach to Carcharoth as a Condition attachment with the text, 'After an attack against Carcharoth resolves, discard one character that participated in the attack and discard A Doom Fulfilled.'",
                Shadow = "Shadow: The attacking enemy cannot be damaged this turn unless the defending player discards one character.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 183,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "Devil's Cunning",
                
                Id = "98a5aadf-1e0f-4d9f-b774-edc353311bf0",
                CardType = CardType.Treachery,
                Quantity = 3,
                Text = "When Revealed: Carcharoth makes an immediate attack on the player with the most Willpower committed to the quest.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 186,
                Artist = Artist.Igor_Kordey
            });
            Cards.Add(new LotRCard() {
                Title = "Espied from Afar",
                
                Id = "c851ed2b-b69b-4f99-94cd-62c078e3d260",
                CardType = CardType.Treachery,
                Quantity = 2,
                Text = "When Revealed: The players must either discard the location in the victory display with the highest Hunt value or prevent all exhausted characters from readying during the refresh phase this round.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 185,
                Artist = Artist.Unknown
            });
            Cards.Add(new LotRCard() {
                Title = "Evil Days",
                
                Id = "3cd659f1-0aa4-4466-a654-f9a4bd4ecc6a",
                CardType = CardType.Treachery,
                Quantity = 3,
                Text = "When Revealed: Each player must either deal 1 damage to each location in play or deal 1 Corruption to each character he controls.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 180,
                Artist = Artist.Justin_Gerard
            });
            Cards.Add(new LotRCard() {
                Title = "Flame of Anguish",
                
                Id = "170846a1-d160-43fd-b56d-83bcb97c661a",
                CardType = CardType.Treachery,
                Quantity = 3,
                Text = "When Revealed: Remove 5 damage from Carcharoth and assign it to characters the first player controls. If Carcharoth has no damage, Flame of Anguish gains surge.",
                Shadow = "Shadow: Remove 5 damage from the attacking enemy.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 184,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "Fled in Fear",
                
                Id = "62db2179-f1a9-4447-957e-9ca03f503cc5",
                CardType = CardType.Treachery,
                Quantity = 3,
                Text = "When Revealed: Remove all allies from the quest. Allies cannot be declared as attackers or defenders until the end of the round.",
                Shadow = "Shadow: Allies cannot participate in an attack against the attacking enemy this round.",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 182,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "Stood Now in Wrath",
                Id = "9a0d9373-9886-4f4a-848e-969d612b5212",
                CardType = CardType.Treachery,
                Quantity = 2,
                Text = "When Revealed: Discard Carcharoth and reveal and add the next card from the Carcharoth deck.",
                Shadow = "Shadow: The attacking enemy gets +1 Attack. (+3 Attack instead if the attacking enemy has more than 5 damage on him.)",
                EncounterSet = "Hunting of the Wolf",
                CardNumber = 181,
                Artist = Artist.HazelFibonacci
            }.WithKeywords("Surge."));
            Cards.Add(new LotRCard() {
                Title = "Crazed Thrall",
                Id = "eb8ca983-1634-4be3-a327-e2c881a9490a",
                CardType = CardType.Enemy,
                Traits = new List<string>() { "Thrall." },
                EngagementCost = 28,
                Threat = 1,
                Attack = 2,
                Defense = 1,
                HitPoints = 3,
                Quantity = 3,
                Text = "Forced: Reveal 1 encounter card at the end of the round.Forced: After Crazed Thrall is destroyed by an attack, place 1 Corruption on each participating character.Response: After questing successfully, cancel all progress and instead remove Crazed Thrall from play.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 124,
                Artist = Artist.Unknown
            });
            Cards.Add(new LotRCard() {
                Title = "Devouring Werewolf",
                
                Id = "bcbde72b-55fa-487e-a3ff-9547c34d7e5e",
                IsUnique = true,
                CardType = CardType.Enemy,
                Traits = new List<string>() { "Creature.", "Werewolf." },
                EngagementCost = 1,
                Threat = 3,
                Attack = 6,
                Defense = 3,
                HitPoints = 10,
                Quantity = 1,
                Text = "Immune to player card effects. Cannot leave the pit area.\r\nForced: Characters destroyed by Devouring Werewolf are removed from the game.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 125,
                Artist = Artist.David_Wuertemburg
            });
            Cards.Add(new LotRCard() {
                Title = "Draugluin",
                Id = "fe9fb08b-52e3-4bc1-b55d-d5994fbab19c",
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 45,
                Threat = 4,
                Attack = 7,
                Defense = 4,
                HitPoints = 12,
                Quantity = 1,
                VictoryPoints = 3,
                Text = "Forced: After Draugluin is damaged by an attack, deal 1 damage to each character that participated in that attack.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 117,
                Artist = Artist.Taina_Dos
            }.WithTraits("Creature.", "Werewolf.")
            .WithKeywords("Relentless."));
            Cards.Add(new LotRCard() {
                Title = "Guard Wolf",
                
                Id = "282c7b69-c8c3-454f-ac9d-3d99175dd6c2",
                CardType = CardType.Enemy,
                Traits = new List<string>() { "Creature.", "Werewolf." },
                EngagementCost = 25,
                Threat = 2,
                Attack = 2,
                Defense = 3,
                HitPoints = 5,
                Quantity = 3,
                Text = "When Revealed: Choose one character committed to the quest and remove him from the quest. If Guard Wolf is not destroyed by the end of the round, that character does not ready during the refresh phase.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack. (+2 Attack instead if the enemy is a Werewolf.)",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 122,
                Artist = Artist.Unknown
            });
            Cards.Add(new LotRCard() {
                Title = "Hunting Wolf",
                
                Id = "7e54d64b-8b77-467c-b482-352cd9f9d9ef",
                CardType = CardType.Enemy,
                Traits = new List<string>() { "Creature.", "Werewolf." },
                EngagementCost = 32,
                Threat = 3,
                Attack = 3,
                Defense = 2,
                HitPoints = 4,
                Quantity = 4,
                Text = "Forced: After Hunting Wolf engages a player, raise that player's threat by 3.",
                Shadow = "Shadow: Raise the defending player's threat by 2.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 123,
                Artist = Artist.Unknown
            });
            Cards.Add(new LotRCard() {
                Title = "Monstrous Bat",
                
                Id = "cb6a1b6a-3f57-4184-90cb-7d46d0173457",
                CardType = CardType.Enemy,
                Traits = new List<string>() { "Creature.", "Vampire." },
                EngagementCost = 20,
                Threat = 2,
                Attack = 4,
                Defense = 1,
                HitPoints = 4,
                Quantity = 2,
                Text = "Forced: After Monstrous Bat deals damage to a character, raise its Defense by X until the end of the round, where X equals the amount of damage dealt.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 121,
                Artist = Artist.Damian_Ziomek
            });
            Cards.Add(new LotRCard() {
                Title = "Ravenous Werewolf",
                
                Id = "9e13b25d-2797-42be-812a-3af05738318e",
                CardType = CardType.Enemy,
                Traits = new List<string>() { "Creature.", "Werewolf." },
                EngagementCost = 30,
                Threat = 1,
                Attack = 2,
                Defense = 1,
                HitPoints = 5,
                Quantity = 4,
                Text = "Ravenous Werewolf gets +1 Attack for each damage token on characters you control.",
                Shadow = "Shadow: Attacking enemy gets +X Attack. X is the number of damage tokens on the defending character.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 119,
                Artist = Artist.Daniel_Ljunggren
            });
            Cards.Add(new LotRCard() {
                Title = "Thuringwethil",
                
                Id = "29d1487e-e223-4569-96ba-ac53a251eaba",
                IsUnique = true,
                CardType = CardType.Enemy,
                Traits = new List<string>() { "Vampire." },
                EngagementCost = 33,
                Threat = 3,
                Attack = 5,
                Defense = 1,
                HitPoints = 6,
                Quantity = 1,
                Text = "Forced: After Thuringwethil damages a character, remove an equal amount of damage from Thuringwethil.",
                Shadow = "Shadow: Remove all damage from the attacking enemy.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 120,
                Artist = Artist.Atomhawk
            });
            Cards.Add(new LotRCard() {
                Title = "Wolf-Sauron",
                Id = "86f818f2-aad7-4a8f-9bc8-c06ef4fae756",
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 48,
                Threat = 5,
                Attack = 9,
                Defense = 5,
                HitPoints = 20,
                Quantity = 1,
                VictoryPoints = 5,
                Text = "Forced: After Wolf-Sauron attacks, place 1 Corruption on a random ally controlled by the engaged player.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 118,
                Artist = Artist.Blaz_Porenta
            }.WithTraits("Maia.", "Werewolf.")
            .WithKeywords("Relentless."));
            addCard(new LotRCard() {
                Title = "No Living Creature",                
                Id = "ec67d8da-eac3-461b-ab76-e7eea78542a4",
                CardType = CardType.Event,
                Traits = new List<string>() { "Maia." },
                Quantity = 2,
                Text = "When Revealed: Each player must choose one: raise your threat by 1 for each character you control or place 1 Corruption on each character you control.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 103,
                Artist = Artist.Murasaki_Ri
            });
            Cards.Add(new LotRCard() {
                Title = "Bridge to the Isle",
                
                Id = "86c20ae9-1c32-4ea5-aacc-ac8e470fbb10",
                IsUnique = true,
                CardType = CardType.Location,
                Traits = new List<string>() { "Bridge.", "Water." },
                Threat = 3,
                QuestPoints = 6,
                Quantity = 1,
                VictoryPoints = 0,
                Text = "Immune to player card effects.\r\nWhile Bridge to the Isle is the active location, enemies with the Werewolf trait get +1 Attack and +1 Defense.Forced: After Bridge to the Isle is explored, add Draugluin to the staging area.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 111,
                Artist = Artist.Bogdan_Amidzic
            });
            Cards.Add(new LotRCard() {
                Title = "Dark Hills",
                
                Id = "655a251a-c839-4d93-a455-4cb7ac94f57a",
                CardType = CardType.Location,
                Traits = new List<string>() { "Hills." },
                Threat = 3,
                QuestPoints = 6,
                Quantity = 2,
                Text = "While Dark Hills is in play, players cannot use player card effects that allow them to look at cards in the encounter deck or player decks.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack for each shadow card it has been dealt.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 109,
                Artist = Artist.Silvery
            });
            Cards.Add(new LotRCard() {
                Title = "Deep Pit",
                
                Id = "020cc51d-16d3-4c81-9223-8e19874ead9d",
                CardType = CardType.Location,
                Traits = new List<string>() { "Dungeon." },
                Threat = 2,
                QuestPoints = 7,
                Quantity = 2,
                Text = "Response: After Deep Pit is explored, the first player chooses one: add 1 resource to Eyes in the Dark or move one hero to the pit area.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 105,
                Artist = Artist.Alyn_Spiller
            });
            Cards.Add(new LotRCard() {
                Title = "Gates of Tol-in-Gaurhoth",
                
                Id = "a9e19cb1-947a-49f4-a1b9-afbd9ce3da09",
                CardType = CardType.Location,
                Traits = new List<string>() { "Fortification." },
                Threat = 4,
                QuestPoints = 2,
                Quantity = 2,
                Text = "Immune to player card effects.\r\nThe first enemy with the Werewolf trait revealed each turn gains surge.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 106,
                Artist = Artist.Elshazam
            });
            Cards.Add(new LotRCard() {
                Title = "High Tower",
                
                Id = "0951f775-17ab-465f-9776-7495f45fa3b0",
                IsUnique = true,
                CardType = CardType.Location,
                Traits = new List<string>() { "Fortification." },
                Threat = 5,
                QuestPoints = 5,
                Quantity = 1,
                Text = 
@"While High Tower is the active location, all enemies get -20 engagement cost.
                
Response: After High Tower is explored as the active location, remove one Condition attachment from play.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 108,
                Artist = Artist.Stirzocular
            });
            Cards.Add(new LotRCard() {
                Title = "Vacant Pit",
                
                Id = "db13208a-926b-4037-bda4-aa5461efd0f3",
                CardType = CardType.Location,
                Traits = new List<string>() { "Dungeon." },
                Threat = 2,
                QuestPoints = 4,
                Quantity = 2,
                Text = "Forced: Remove 1 resource from Eyes in the Dark at the end of the round.",
                Shadow = "Shadow: If this attack destroys a character, remove 1 resource from Eyes in the Dark.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 110,
                Artist = Artist.ElderScroller
            });
            Cards.Add(new LotRCard() {
                Title = "Walls of Stone",
                
                Id = "eb292959-22e1-4e25-ae41-b2ad77549962",
                CardType = CardType.Location,
                Traits = new List<string>() { "Fortification." },
                Threat = 2,
                QuestPoints = 3,
                Quantity = 3,
                Text = "While Walls of Stone is in the staging area, progress cannot be placed on the current quest stage.",
                Shadow = "Shadow: If a character is destroyed by this attack, remove 5 progress tokens from the quest.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 107,
                Artist = Artist.Unknown
            });
            Cards.Add(new LotRCard() {
                Title = "Eyes in the Dark",
                Id = "111d8917-7733-41a8-8941-b24698ed17e4",
                CardType = CardType.Objective,
                Traits = new List<string>() { "Devoured." },
                Quantity = 1,
                Text = "Place 8 resource tokens on Eyes in the Dark.At the end of each round, discard 1 resource token from Eyes in the Dark.If there are no resource tokens to discard, remove Eyes in the Dark from play and put Devouring Werewolf into play in the pit area, engaged with the prisoners.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 112,
                Artist = Artist.Graeme_Skinner
            });
            Cards.Add(new LotRCard() {
                Title = "Finrod Felagund",
                Id = "829081e4-0ffa-41ea-9bb4-cb6d64aa06cc",
                IsUnique = true,
                CardType = CardType.Objective_Ally,
                Traits = new List<string>() { "Noldor.", "House of Finarfin.", "Noble." },
                Willpower = 3,
                Attack = 3,
                Defense = 1,
                HitPoints = 4,
                Quantity = 1,
                Text = "Action: Discard Finrod Felagund to deal 5 points of damage to an engaged enemy.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 116,
                Artist = Artist.Elfkin
            }.WithSlugSuffix("Objective-Ally"));
            Cards.Add(new LotRCard() {
                Title = "The Pits of Sauron",
                StageNumber = 2,
                Id = "62abfd48-b415-402f-bcd8-df92ae5a1b27",
                CardType = CardType.Quest,
                QuestPoints = null,
                Quantity = 1,
                Text = "When Revealed: Search the encounter deck for Finrod Felagund and Eyes in the Dark and add both to the pit area. Choose one hero to be placed in the pit area. That hero is captured. The controlling player may immediately replace the captured hero with another of his choice.",
                OppositeText = 
@"Heroes at this stage do not collect resources or commit to the quest and are immune to player card effects. Player cannot play or put into play allies or attachments into the pit area.

Forced: If the players quest unsuccessfully, remove 1 resource from Eyes in the Dark, if able.

If the captured hero is destroyed, the players lose the game. If Devouring Werewolf is destroyed, discard this stage from play and return all characters to their owner's control.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 114,
                Artist = Artist.Nicholas_Cloister
            });
            Cards.Add(new LotRCard() {
                Title = "Tol-in-Gaurhoth",
                StageNumber = 3,
                Id = "4016a752-46bf-4574-9c14-a51e4835bc0b",
                CardType = CardType.Quest,
                QuestPoints = null,
                Quantity = 1,
                Text = "When Revealed: Add Wolf-Sauron to the staging area. Reveal 1 encounter card per player.",
                OppositeText = 
@"Forced: After an enemy is revealed from the encounter deck, discard it instead of adding it to the staging area.

Planning Action: Exhaust a hero with X Willpower. Wolf-Sauron gets -X Defense until the end of the round. (Limit once per round.)

If the players destroy Wolf-Sauron, they have rescued the prisoners and won the game.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 115,
                Artist = Artist.Bogdan_Amidzic
            });
            Cards.Add(new LotRCard() {
                Title = "Upon the Bridge",
                StageNumber = 1,
                Id = "c794640f-5ecb-4ba2-a414-374ccc8d466f",
                CardType = CardType.Quest,
                QuestPoints = 20,
                Quantity = 1,
                Text = "Setup: Set aside Devouring Werewolf, Draugluin, Bridge to the Isle and Wolf-Sauron. Create a pit area with stage 2A and follow the setup instructions on that card.",
                OppositeText =
@"When Revealed: Add Bridge to the Isle to the staging area. Reveal X encounter cards where X equals the number of players in the game minus 1.

When this stage is completed, advance to stage 3A. This stage cannot be completed until Draugluin is in the victory display.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 113,
                Artist = Artist.Roger_Garland
            });
            Cards.Add(new LotRCard() {
                Title = "Isle of Werewolves",
                Id = "f03bc416-e4cd-4bda-944c-51a33a55b1d0",
                CardType = CardType.Campaign,
                Text = 
@"Corruption

When a character takes Corruption, place a progress token on it. If a character ever has Corruption greater than its willpower, it has become Corrupted. A Corrupted character loses the 'ally' or 'here' trait and gains the 'enemy' trait, immediately engaging the player that used to control it. The Willpower of the Corrupted character becomes its Threat and its engagement cost is 0.

Relentless

An enemy with Relentless cannot have its attack canceled or be prevented from attacking by any player card effect.",
                OppositeText = 
@"The Pit Area

Stage 2A instructs players to create a pit area. The pit area is a new play area, separate from the staging area, that represents the captives and their battle for survival against the Devouring Werewolf sent by Sauron. THe pit area consists of stage 2 of the quest deck, The Pits of Sauron, as well as Finrod Felagund and Eyes in the Dark objectives. The players decide on one hero to be placed in the pit area as captive. The player that controls that hero immediately chooses a hero to replace this captive, adjusting his starting threat to reflect this change.

Heroes in the pit area are immune to player card effects and cannot leave the pit area except through specific quest and encounter card effects. The captive hero cannot quest and does not collect resources. In addition, players cannot play attachments or allies into the pit area.",
                Quantity = 1,
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 112,
                Artist = Artist.Unknown
            }.WithSlugSuffix("Campaign"));
            Cards.Add(new LotRCard() {
                Title = "Foul Vapour",
                
                Id = "9f27803d-8a57-4512-914c-9a9435e947b6",
                CardType = CardType.Treachery,
                Quantity = 2,
                Text = "When Revealed: Each character in play gets -X Attack and -X Defense until the end of the round. X is the number of enemies with the Werewolf trait engaged with the controlling player. If there are no engaged enemies with the Werewolf trait, Foul Vapour gains surge.",
                Shadow = "Shadow: The defending character gets -1 Defense until the end of the phase.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 104,
                Artist = Artist.Alex_McVey
            });
            Cards.Add(new LotRCard() {
                Title = "Lord of Werewolves",
                
                Id = "5f59b83c-45bc-4625-9ff9-160019cb9ae2",
                CardType = CardType.Treachery,
                Quantity = 2,
                Text = "When Revealed: Each player must search the encounter deck and discard pile for one enemy with the Werewolf trait and add it to the staging area.",
                Shadow = "Shadow: The attacking enemy returns to the staging area after this attack.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 101,
                Artist = Artist.Unknown
            });
            Cards.Add(new LotRCard() {
                Title = "Master of Shadows",
                
                Id = "48540efb-e1d0-4453-a50e-c5cbb80fc176",
                CardType = CardType.Treachery,
                Traits = new List<string>() { "Maia." },
                Quantity = 2,
                Text = "When Revealed: Attach to the current quest stage. (Counts as a Condition attachment with the text: 'Each enemy is dealt an additional shadow card at the beginning of the combat phase.')",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 102,
                Artist = Artist.AlaisL
            });
            Cards.Add(new LotRCard() {
                Title = "Song of Wizardry",
                
                Id = "47fafb31-e329-4fc6-aa95-93a9ffb3dc8e",
                CardType = CardType.Treachery,
                Traits = new List<string>() { "Song." },
                Quantity = 2,
                Text = "When Revealed: Each player must discard the top card of his deck and place Corruption among his characters equal to its cost.",
                Shadow = "Shadow: Place 1 Corruption on the defending character if it is an ally.",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 99,
                Artist = Artist.HellgaZ
            });
            Cards.Add(new LotRCard() {
                Title = "Weight of Horror",
                
                Id = "4bcbe3a9-c908-46f8-b5b0-a459564067fa",
                CardType = CardType.Treachery,
                Traits = new List<string>() { "Condition." },
                Quantity = 2,
                Text = "When Revealed: Attach to the hero with the highest Willpower. (Counts as a Condition attachment with the text: 'The attached hero must spend 1 resource from his pool to commit to the quest. Limit 1 per hero.')",
                EncounterSet = "The Isle of Werewolves",
                CardNumber = 100,
                Artist = Artist.Ted_Nasmith
            });
            Cards.Add(new LotRCard() {
                Title = "Angband Orc",
                Id = "c020347f-a024-48f6-97de-8a9e73003739",
                CardType = CardType.Enemy,
                EngagementCost = 25,
                Threat = 2,
                Attack = 4,
                Defense = 1,
                HitPoints = 5,
                Quantity = 3,
                Text = "Forced: While Angband Orc is engaged with a player, raise that player's threat by an additional 1 at the end of the round.",
                Shadow = "Shadow: Add Angband Orc to the staging area.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 142,
                Artist = Artist.Christian_Quinot
            }.WithTraits("Orc.")
            .WithKeywords("Sneak.", "Doomed 1."));
            Cards.Add(new LotRCard() {
                Title = "Balrog of Angband",
                Id = "a35bb6d5-566b-4836-a792-3ab6b14c775e",
                CardType = CardType.Enemy,
                EngagementCost = 37,
                Threat = 4,
                Attack = 7,
                Defense = 3,
                HitPoints = 22,
                Quantity = 2,
                VictoryPoints = 5,
                Text = "Forced: After an event is played, lower the engagement cost of Balrog of Angband by 20 and increase its Threat by 1 until the end of the round.",
                Shadow = "Shadow: Discard all event cards from your hand.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 136,
                Artist = Artist.Echo539
            }.WithTraits("Balrog.")
            .WithKeywords("Sneak."));
            Cards.Add(new LotRCard() {
                Title = "Carcharoth",
                Id = "ad033513-3b27-4410-9171-5e890667fa15",
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 4,
                Threat = Card.VALUE_X,
                Attack = 7,
                Defense = 4,
                HitPoints = 15,
                Quantity = 1,
                Text = "Cannot leave play.\r\nX is 5 times the number of players.\r\nForced: Players cannot reduce their threat while Carcharoth is in play.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 135,
                Artist = Artist.Aogachou
            }.WithTraits("Creature.", "Werewolf.")
            .WithKeywords("Relentless.", "Indestructible."));
            Cards.Add(new LotRCard() {
                Title = "Fire-drake",
                Id = "e1a095dc-996f-4b3c-b17a-a20bc10f8953",
                CardType = CardType.Enemy,
                EngagementCost = 42,
                Threat = 5,
                Attack = 9,
                Defense = 5,
                HitPoints = 21,
                Quantity = 2,
                VictoryPoints = 5,
                Text = "Forced: At the beginning of the combat phase, deal 1 damage to each character controlled by the engaged player.",
                Shadow = "Shadow: Deal 1 damage to each character controlled by the engaged player.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 138,
                Artist = Artist.Sansyu
            }.WithTraits("Dragon.")
            .WithKeywords("Sneak."));
            Cards.Add(new LotRCard() {
                Title = "Gothmog",
                Id = "28ae9d78-15e7-4fbe-b156-e9ead6a37886",
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 40,
                Threat = 5,
                Attack = 10,
                Defense = 4,
                HitPoints = 25,
                Quantity = 1,
                VictoryPoints = 6,
                Text = "Forced: After Gothmog attacks, discard 1 attachment controlled by the defending player.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 139,
                Artist = Artist.Anja
            }.WithTraits("Balrog.")
            .WithKeywords("Sneak."));
            Cards.Add(new LotRCard() {
                Title = "Long-worm",
                Id = "4f26696d-0dc1-4e1e-883d-5ee7789c6339",
                CardType = CardType.Enemy,
                EngagementCost = 40,
                Threat = 5,
                Attack = 8,
                Defense = 5,
                HitPoints = 20,
                Quantity = 2,
                VictoryPoints = 5,
                Text = "Forced: When Long-worm engages a player, place 1 Corruption on the character with the lowest Willpower that he controls.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 137,
                Artist = Artist.Joas_Kleine
            }.WithTraits("Dragon.")
            .WithKeywords("Sneak."));
            Cards.Add(new LotRCard() {
                Title = "Morgoth",                
                Id = "f01c44ef-3494-48b4-abe7-f4d5213a3216",
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 50,
                Threat = 8,
                Attack = 15,
                Defense = 9,
                HitPoints = 40,
                Quantity = 1,
                Text = "Morgoth cannot leave the staging area and is considered to be engaged with each player.No Trap attachments can be attached to Morgoth.Forced: At the end of the round, each player must place 2 Corruption among characters he controls.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 134,
                Artist = Artist.Gerwell
            }.WithTraits("Vala.")
            .WithKeywords("Indestructible."));
            Cards.Add(new LotRCard() {
                Title = "Orc Captain",                
                Id = "08a9cee0-543b-4251-a085-2cb869140cd4",
                CardType = CardType.Enemy,
                EngagementCost = 28,
                Threat = 3,
                Attack = 5,
                Defense = 2,
                HitPoints = 6,
                Quantity = 2,
                Text = "Forced: When Orc Captain attacks, add the shadow card to the staging area if it is an enemy (ignoring any shadow effect).",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 141,
                Artist = Artist.Christian_Quinot
            }.WithTraits("Orc.")
            .WithKeywords("Sneak."));
            Cards.Add(new LotRCard() {
                Title = "Troll of Angband",
                Id = "ad8cf095-594e-4d14-adef-aafa4f31e60c",
                CardType = CardType.Enemy,
                EngagementCost = 30,
                Threat = 2,
                Attack = 6,
                Defense = 3,
                HitPoints = 9,
                Quantity = 3,
                Text = "Forced: After Troll of Angband attacks, raise the defending player's threat by 3.",
                Shadow = "Shadow: Raise the defending player's threat by 3.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 140,
                Artist = Artist.Ben_Daugherty
            }.WithTraits("Troll.")
            .WithKeywords("Sneak."));
            Cards.Add(new LotRCard() {
                Title = "Echoing Corridor",
                
                Id = "f77d7157-b5e6-4b8f-b3e0-fa4d512d214a",
                CardType = CardType.Location,
                Traits = new List<string>() { "Underground." },
                Threat = 4,
                QuestPoints = 3,
                Quantity = 2,
                Text = "Forced: At the beginning of the staging step, players must raise their threat by the number of characters they committed to the quest while Echoing Corridor is the active location.",
                Shadow = "Shadow: Raise the threat of the defending player by the Threat of the attacking enemy.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 148,
                Artist = Artist.Robert_Ryminiecki
            });
            Cards.Add(new LotRCard() {
                Title = "Labyrinthine Stairs",
                
                Id = "d4263007-1ce9-4437-92a8-e6031cff3b09",
                CardType = CardType.Location,
                Traits = new List<string>() { "Underground." },
                Threat = 2,
                QuestPoints = 6,
                Quantity = 3,
                Text = "Forced: After putting any amount of progress on Labyrinthine Stairs, discard the top card of the encounter deck. If it is a location, add it to the staging area.",
                Shadow = "Shadow: If this attack destroys a character, return the active location to the staging area.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 146,
                Artist = Artist.Neal_Hanson
            });
            Cards.Add(new LotRCard() {
                Title = "Nethermost Hall",
                
                Id = "32bd3aaa-a8bb-4258-9b17-28beeeb3430b",
                IsUnique = true,
                CardType = CardType.Location,
                Traits = new List<string>() { "Throne Room." },
                Threat = 5,
                QuestPoints = 7,
                Quantity = 1,
                VictoryPoints = 2,
                Text = 
@"Immune to player card effects.\r\nForced: After Nethermost Hall is explored as the active location, advance to stage 3.
                
Travel: Search the encounter deck and discard pile for Gothmog and add him to the staging area, if able.",
                Shadow = "Shadow: The attacking enemy gets +1 Attack and +1 Defense until the end of the phase.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 152,
                Artist = Artist.Unknown
            });
            Cards.Add(new LotRCard() {
                Title = "Orc Armory",
                
                Id = "692fd26f-06c5-4375-ba1c-ed7cf26df1d9",
                CardType = CardType.Location,
                Traits = new List<string>() { "Armory." },
                Threat = 3,
                QuestPoints = 3,
                Quantity = 2,
                Text = "While Orc Armory is the active location, all enemies lose the Sneak keyword.Response: After Orc Armory is explored as the active location, the first player attaches it to a hero. The attached hero gains +1 Attack and +1 Defense.",
                Shadow = "Shadow: The attacking enemy gets +1 Attack and +1 Defense until the end of the phase.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 151,
                Artist = Artist.Atomhawk
            });
            Cards.Add(new LotRCard() {
                Title = "Pits of Angband",
                
                Id = "d6362581-bf1a-4e9f-9059-9ef492ed157f",
                IsUnique = true,
                CardType = CardType.Location,
                Traits = new List<string>() { "Path." },
                Threat = 10,
                QuestPoints = 10,
                Quantity = 1,
                VictoryPoints = 1,
                Text = 
@"Immune to player card effects.\r\nThis location does not contribute its threat while it is in the staging area.

Forced: The first enemy revealed each round gains surge.

Response: After Pits of Angband leaves play, add Angband Sword to the staging area.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 143,
                Artist = Artist.Dan_Mitchell
            });
            Cards.Add(new LotRCard() {
                Title = "Subterranean Furnace",
                
                Id = "47564431-f77f-4389-879f-491e580d1704",
                CardType = CardType.Location,
                Traits = new List<string>() { "Underground." },
                Threat = 3,
                QuestPoints = 4,
                Quantity = 2,
                Text = "Forced: While Subterranean Furnace is the active location, each player must discard a random card from his hand at the end of the round.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 149,
                Artist = Artist.Unknown
            });
            Cards.Add(new LotRCard() {
                Title = "Thrall Quarters",
                
                Id = "85a7618b-8f0c-4ba2-8489-00aa65c9610c",
                IsUnique = true,
                CardType = CardType.Location,
                Traits = new List<string>() { "Path." },
                Threat = 5,
                QuestPoints = 15,
                Quantity = 1,
                VictoryPoints = 1,
                Text = "Immune to player card effects. This location does not contribute its threat while it is in the staging area.\r\nForced: While Thrall Quarters is the active location, add 1 to the Threat of discarded encounter cards when resolving a Sneak test.Response: After Thrall Quarters leaves play, add Dreadful Garments to the staging area.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 144,
                Artist = Artist.Clive_Lauzon
            });
            Cards.Add(new LotRCard() {
                Title = "Torturer's Dungeon",
                
                Id = "8c616380-0331-4e90-80b7-f0451ac75eb5",
                CardType = CardType.Location,
                Traits = new List<string>() { "Chamber." },
                Threat = 2,
                QuestPoints = 4,
                Quantity = 1,
                Text = "Forced: If there is no active location and you have the option to travel, you must either travel to Torturer's Dungeon or place 1 Corruption on each hero.Travel: Each player must search the encounter deck and discard pile for an enemy and put it into play engaged with him.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 147,
                Artist = Artist.Dardagan
            });
            Cards.Add(new LotRCard() {
                Title = "Trackless Cavern",
                
                Id = "fb3baa06-68d4-40c8-8154-97c1ee0f156b",
                CardType = CardType.Location,
                Traits = new List<string>() { "Underground.", "Dark." },
                Threat = 1,
                QuestPoints = 8,
                Quantity = 2,
                Text = "Response: After Trackless Cavern leaves play, each player reduces his threat by 5.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 150,
                Artist = Artist.Steven_Schreiner
            });
            Cards.Add(new LotRCard() {
                Title = "Tunnels of Shadow",
                
                Id = "c74ed070-15f4-4f80-bbe9-ce678a9cb935",
                IsUnique = true,
                CardType = CardType.Location,
                Traits = new List<string>() { "Path." },
                Threat = 1,
                QuestPoints = 20,
                Quantity = 1,
                VictoryPoints = 1,
                Text = "Immune to player card effects. This location does not contribute its threat while it is in the staging area.\r\nForced: While Tunnels of Shadow is the active location, the encounter deck is shuffled before discarding cards for a Sneak test.Response: After Tunnels of Shadow leaves play, add Element of Surprise to the staging area.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 145,
                Artist = Artist.Rebekah_Burlew
            });
            Cards.Add(new LotRCard() {
                Title = "Angband Sword",
                Id = "0921abfd-2cd7-493f-878b-ad4cb99e010c",
                CardType = CardType.Objective,
                Quantity = 1,
                Text = "Attached hero gains +5 Attack. Restricted.\r\nAttached hero gains an additional +1 Attack for each resource on Angband Sword.\r\nAction: Attach Angband Sword to a hero. Place 1 Corruption on that hero.Response: After attached hero deals damage, add 1 resource to Angband Sword.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 131,
                Artist = Artist.Daniel_Ljunggren
            }.WithTraits("Item.", "Weapon.")
            .WithKeywords("Restricted."));
            Cards.Add(new LotRCard() {
                Title = "Dreadful Garments",                
                Id = "78db9650-a652-4a3d-bff4-1423cbfb83e2",
                CardType = CardType.Objective,
                Quantity = 1,
                Text = "Action: Attach Dreadful Garments to a hero.Action: Exhaust Dreadful Garments to place 5 progress tokens on the active enemy.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 132,
                Artist = Artist.Ted_Nasmith
            }.WithTraits("Disguise."));
            Cards.Add(new LotRCard() {
                Title = "Element of Surprise",
                Id = "d2d61431-56a0-4aa4-8900-d9ba9aec4703",
                CardType = CardType.Objective,
                Quantity = 1,
                Text = "Action: Attach Element of Surprise to a hero.Combat Action: Exhaust Element of Surprise. Player attacks are made before enemy attacks during this phase.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 133,
                Artist = Artist.Kieran_Tatsue
            }.WithTraits("Initiative."));
            Cards.Add(new LotRCard() {
                Title = "Silmaril",
                
                Id = "8b38140d-9a06-4155-8bb3-f803ff353520",
                IsUnique = true,
                CardType = CardType.Objective,
                Traits = new List<string>() { "Item.", "Artifact.", "Silmaril." },
                Quantity = 1,
                Text = "Action: If Morgoth has 0 hit points, exhaust a hero to claim Silmaril.Action: Exhaust Silmaril and attached hero to either return an enemy to the staging area or reduce its Defense to 0 until the end of the round.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 130,
                Artist = Artist.Unknown
            });
            Cards.Add(new LotRCard() {
                Title = "Descent into Darkness",
                StageNumber = 2,
                Id = "53d6dc87-a084-4220-ad38-a39e655f1d44",
                CardType = CardType.Quest,
                QuestPoints = null,
                Quantity = 1,
                Text = "When Revealed: Remove Carcharoth from play. Add Pits of Angband, Thrall Quarters, and Tunnels of Shadow to the staging area. Each player must search the encounter deck and discard pile for 1 enemy and add it to the staging area.",
                OppositeText = 
@"Forced: After the first Path location is explored, add Nethermost Hall to the staging area.

Forced: After traveling to a unique location, players raise their threat by its Threat.

The players cannot advance unless Nethermost Hall is in the victory display.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 127,
                Artist = Artist.David_J_Findlay
            });
            Cards.Add(new LotRCard() {
                Title = "Doors of Angband",
                StageNumber = 1,
                Id = "5d55e464-f59d-454f-971c-a35f1376a420",
                CardType = CardType.Quest,
                QuestPoints = 15,
                Quantity = 1,
                Text = "Setup: Add Carcharoth to the staging area. Set Morgoth and all objectives and unique locations aside out of play. Set your threat equal to the number of heroes you control.",
                OppositeText = 
@"Forced: Skip the staging step during the quest phase. Instead, each player must discard the top card of his deck after committing characters to the quest. Add the cost of each discarded card to the total Threat in the staging area until the end of the phase.

If Carcharoth has 0 hit points, advance to stage 2 immediately.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 126,
                Artist = Artist.Danny_Staten
            });
            Cards.Add(new LotRCard() {
                Title = "The Greatest Deed",
                StageNumber = 3,
                Id = "7272499a-1047-4431-82d8-83e88e7de3e5",
                CardType = CardType.Quest,
                QuestPoints = 1,
                OppositeText = 
@"When Revealed: Add Morgoth to the staging area and attach Silmaril to him.

Response: After questing successfully, you may place progress tokens on Morgoth as damage instead of placing them on the quest.

The players cannot advance to the next stage unless they control the Silmaril objective.",
                Quantity = 1,
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 128,
                Artist = Artist.StrangerToTheRain
            });
            Cards.Add(new LotRCard() {
                Title = "To See the Light",
                StageNumber = 4,
                Id = "8432e9fc-ecb8-4948-a6dd-d75dad26e42e",
                CardType = CardType.Quest,
                QuestPoints = 15,
                Quantity = 1,
                Text = "When Revealed: Remove Morgoth from play. Add Carcharoth to the staging area, removing any damage that was previously placed.",
                OppositeText =
@"All enemies lose the Sneak keyword.

If the players defeat this stage or Carcharoth has 0 hit points, the players have won the game.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 129,
                Artist = Artist.Pete_Amachree
            });
            Cards.Add(new LotRCard() {
                Title = "The Seat of Morgoth",
                Id = "1ad0b223-e659-4358-bf3e-fbc687cba2aa",
                CardType = CardType.Campaign,
                Text =
@"Corruption

When a character takes Corruption, place a progress token on it. If a character ever has Corruption greater than its willpower, it has become Corrupted. A Corrupted character loses the 'ally' or 'here' trait and gains the 'enemy' trait, immediately engaging the player that used to control it. The Willpower of the Corrupted character becomes its Threat and its engagement cost is 0.

Relentless

An enemy with Relentless cannot have its attack canceled or be prevented from attacking by any player card effect.",
                OppositeText = 
@"Sneak

During the travel phase, the players may choose an enemy in the staging area with the Sneak keyword to be the 'active enemy'. This follows the decision to travel. The active enemy no longer contributes its threat to the staging area. Players must still make engagement checks against it, however.

During quest resolution, progress tokens are placed first on the active enemy, then the active location, and finally on the quest stage. If a number of progress tokens equal to the active enemy's threat is placed on it, that enemy is discarded.

Whenever an amount of progress is placed on the active enemy, the first player must pass a Sneak test. The first player may discard any number of cards from their hand, adding up the costs of those cards. Then, the top card of the encounter deck is discarded. Compare the cost of the discarded player cards against the threat value of the discarded encounter card. If the cost is greater than or equal to the threat value, then the Sneak attempt passes. If the cost is less than the threat value, the the Sneak attempt fails. If a Sneak attempt fails, the active enemy immediately engages the first player. Progress that was placed on the active location or quest is not affected.

When engaged with an enemy with the Sneak keyword, players may cancel all progress and instead place an equivalent number of damage tokens on enemies with the Sneak keyword instead.",
                Quantity = 1,
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 125,
                Artist = Artist.StrangerToTheRain
            }.WithSlugSuffix("Campaign"));
            Cards.Add(new LotRCard() {
                Title = "Clumsy Step",                
                Id = "d17ece37-4951-4dbf-a5b9-0b07092e8c5f",
                CardType = CardType.Treachery,
                Quantity = 3,
                Text = "When Revealed: Discard an additional encounter card when resolving Sneak tests this round. If there is no active enemy, Clumsy Step gains surge.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 154,
                Artist = Artist.Sam_R_Kennedy
            }.WithTraits("Noise.")
            .WithKeywords("Doomed 2."));
            Cards.Add(new LotRCard() {
                Title = "Devouring Spirit",
                Id = "11916b96-fe83-4a57-985d-4fb1746d4cfc",
                CardType = CardType.Treachery,
                Quantity = 2,
                Text = "When Revealed: Attach to the enemy in play with the lowest Threat. Attached enemy gets +1 Threat, +1 Attack, +1 Defense, and +3 hit points. If there are no enemies in play, Devouring Spirit gains surge.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 153,
                Artist = Artist.Sarah_Finnigan
            }.WithTraits("Condition."));
            addCard(new LotRCard() {
                Title = "Evil Lust",
                Id = "092d5e7a-6483-4ded-98c3-fa4478169f1f",
                CardType = CardType.Treachery,
                Quantity = 2,
                Text = "When Revealed: Attach to a hero. (Counts as a Condition attachment with the text: 'This hero must be declared as the defender against Morgoth (even if exhausted). Morgoth uses his Threat to attack and the attached hero uses his Willpower to defend. Limit 1 per hero.')",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 158,
                Artist = Artist.Andreas_Marschall
            }.WithTraits("Condition."));
            addCard(new LotRCard() {
                Title = "Filth and Desolation",
                Id = "074cb89d-4815-49d8-aa9b-07abd3c5331a",
                CardType = CardType.Treachery,
                Quantity = 2,
                Text = "When Revealed: Each player must either deal 1 damage to each character he committed to the quest or reduce the Willpower of each character he controls by 1 until the end of the round.",
                Shadow = "Shadow: Exhaust a character that the defending player controls.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 156,
                Artist = Artist.Aledin
            });
            addCard(new LotRCard() {
                Title = "Foolish Ruckus",
                Id = "715771dc-35aa-477e-a28f-e0d9e2954b54",
                CardType = CardType.Treachery,
                Quantity = 3,
                Text = "When Revealed: Raise the Threat of the active enemy by 3 until the end of the phase. If there is no active enemy, raise the Threat of all enemies in the staging area by 1 until the end of the phase.",
                Shadow = "Shadow: If this attack destroys a character, raise the defending player's threat by 2.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 155,
                Artist = Artist.Unknown
            }.WithTraits("Noise."));
            Cards.Add(new LotRCard() {
                Title = "Heroic Diversion",
                Id = "083af9c9-b1b3-4185-b09b-59eff4440f10",
                CardType = CardType.Treachery,
                Quantity = 3,
                Text = "When Revealed: Each player must either discard 1 character or raise his threat by 5.",
                EncounterSet = "The Seat of Morgoth",
                CardNumber = 157,
                Artist = Artist.Jenny_Dolfen
            }.WithKeywords("Doomed 1."));
        }
    }
}