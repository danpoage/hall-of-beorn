/* Generated CardSet class: First Age */

using System;

namespace HallOfBeorn.Models.LotR.Sets.FirstAge
{
    public class FirstAgeSet : CardSet
    {
        public const string setName = "First Age";

        protected override void addCard(LotRCard card)
        {
            card.WithAges(Age.First_Age);
            base.addCard(card);
        }

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "FA";
            Number = 9001;
            SetType = Models.SetType.First_Age;

            addScenario(EncounterSet.HuntingOfTheWolf.Name, 1, setName)
                .WithTextLine("Corruption")
                .WithTextLine("When a character takes Corruption, place a progress token on it. If a character ever has Corruption greater than its willpower, it has become Corrupted. A Corrupted character loses the \"ally\" or \"hero\" card type and gains the \"enemy\" trait, immediately engaging the player that used to control it. The Willpower of the Corrupted character becomes its Threat and its engagement cost is 0.")
                .WithTextLine("Relentless")
                .WithTextLine("An enemy with Relentless cannot have its attack canceled or be prevented from attacking by any player card effect.")
                .WithOppositeTextLine("Carcharoth Deck")
                .WithOppositeTextLine("During the quest phase, reveal the top card of the Carcharoth deck after characters have commited to the quest and before staging. Place this card in the staging area and discard any previous copies of Carcharoth into a separate discard pile for the Carcharoth deck. Transfer any damage and attachments to the new version of Carcharoth. If the Carcharoth deck is empty when you need to reveal a card from this deck, shuffle the discard pile for the Carcharoth deck to form a new Carcharoth deck.")
                .WithOppositeTextLine("Hunt")
                .WithOppositeTextLine("When a location with the Hunt keyword is explored as the active location, add it to the victory display. During the encounter phase, players may discard 5 Hunt points worth of locations from the victory display to engage Carcharoth. The players may decide which player will engage with Carcharoth.")
                .WithOppositeTextLine("Carcharoth Combat")
                .WithOppositeTextLine("When Carcharoth attacks a location, subtract the threat of the location from Carcharoth's attack. The difference is the number of damage tokens placed on the location. If a location receives damage equal to its quest points, it is considered to be destroyed and is discarded. If Carcharoth attacks the active location, the first player may declare a defender. Note that Carcharoth the Red Maw attacks twice during the combat phase. Choose a random location for each attack. He may attack the same location twice if it is chosen twice.")
                .WithInfo(0, 1, Artist.Unknown);
            addScenario(EncounterSet.TheIsleOfWerewolves.Name, 2, setName)
                .WithTextLine("Corruption")
                .WithTextLine("When a character takes Corruption, place a progress token on it. If a character ever has Corruption greater than its willpower, it has become Corrupted. A Corrupted character loses the \"ally\" or \"hero\" card type and gains the \"enemy\" trait, immediately engaging the player that used to control it. The Willpower of the Corrupted character becomes its Threat and its engagement cost is 0.")
                .WithTextLine("Relentless")
                .WithTextLine("An enemy with Relentless cannot have its attack canceled or be prevented from attacking by any player card effect.")
                .WithOppositeTextLine("The Pit Area")
                .WithOppositeTextLine("Stage 2A instructs players to create a pit area. The pit area is a new play area, separate from the staging area, that represents the captives and their battle for survival against the Devouring Werewolf sent by Sauron. THe pit area consists of stage 2 of the quest deck, The Pits of Sauron, as well as Finrod Felagund and Eyes in the Dark objectives. The players decide on one hero to be placed in the pit area as captive. The player that controls that hero immediately chooses a hero to replace this captive, adjusting his starting threat to reflect this change.")
                .WithOppositeTextLine("Heroes in the pit area are immune to player card effects and cannot leave the pit area except through specific quest and encounter card effects. The captive hero cannot quest and does not collect resources. In addition, players cannot play attachments or allies into the pit area.")
                .WithInfo(0, 1, Artist.Unknown);
            addScenario(EncounterSet.TheSeatOfMorgoth.Name, 3, setName)
                .WithTextLine("Corruption")
                .WithTextLine("When a character takes Corruption, place a progress token on it. If a character ever has Corruption greater than its willpower, it has become Corrupted. A Corrupted character loses the \"ally\" or \"hero\" card type and gains the \"enemy\" trait, immediately engaging the player that used to control it. The Willpower of the Corrupted character becomes its Threat and its engagement cost is 0.")
                .WithTextLine("Relentless")
                .WithTextLine("An enemy with Relentless cannot have its attack canceled or be prevented from attacking by any player card effect.")
                .WithOppositeTextLine("Sneak")
                .WithOppositeTextLine("During the travel phase, the players may choose an enemy in the staging area with the Sneak keyword to be the \"active enemy\". This follows the decision to travel. The active enemy no longer contributes its threat to the staging area. Players must still make engagement checks against it, however.")
                .WithOppositeTextLine("During quest resolution, progress tokens are placed first on the active enemy, then the active location, and finally on the quest stage. If a number of progress tokens equal to the active enemy's threat is placed on it, that enemy is discarded.")
                .WithTextLine("Whenever an amount of progress is placed on the active enemy, the first player must pass a Sneak test. The first player may discard any number of cards from their hand, adding up the costs of those cards. Then, the top card of the encounter deck is discarded. Compare the cost of the discarded player cards against the threat value of the discarded encounter card. If the cost is greater than or equal to the threat value, then the Sneak attempt passes. If the cost is less than the threat value, the the Sneak attempt fails. If a Sneak attempt fails, the active enemy immediately engages the first player. Progress that was placed on the active location or quest is not affected. When engaged with an enemy with the Sneak keyword, players may cancel all progress and instead place an equivalent number of damage tokens on enemies with the Sneak keyword instead.")
                .WithInfo(0, 1, Artist.Unknown);
            addHero("Finrod Felagund", 10, Sphere.Leadership, 3, 3, 1, 4)
                .WithTraits("Noldor.", "House of Finarfin.", "Noble.")
                .WithTextLine("While Finrod Felagund is in play, each Edain character gets +1 Willpower.")
                .WithInfo(2, 1, Artist.Niyochara);
            addHero("Fingon", 11, Sphere.Leadership, 3, 1, 2, 5)
                .WithTraits("Noldor.", "House of Fingolfin.", "Noble.")
                .WithTextLine("Action: Exhaust Fingon to remove 1 Corruption from a character in play. (Limit once per round.)")
                .WithInfo(3, 1, Artist.Venlian);
            addHero("Lúthien", 8, Sphere.Spirit, 5, 0, 1, 3)
                .WithTraits("Teleri.", "Noble.")
                .WithTextLine("Action: Exhaust Lúthien and pay 2 resources from her pool to place an enemy facedown (4 resources instead if the enemy is unique). That enemy is considered to be out of play for all purposes (except victory and advancement conditions) until the end of the phase.")
                .WithInfo(4, 1, Artist.Miao_Yu);
            addHero("Eärendil", 8, Sphere.Spirit, 4, 1, 1, 3)
                .WithTraits("Half-elven.", "Noble.")
                .WithTextLine("Response: After Eärendil commits to the quest, shuffle the encounter deck and discard the top card. If it is a treachery, deal 1 damage to Eärendil. Otherwise, reduce your threat by 1 and draw 1 card.")
                .WithInfo(5, 1, Artist.Jenny_Dolfen);
            addHero("Haleth", 6, Sphere.Spirit, 2, 1, 1, 4)
                .WithTraits("Edain.", "House of Haleth.", "Noble.")
                .WithTextLine("Haleth gets +1 Willpower for each enemy engaged with you.")
                .WithTextLine("If Haleth did not commit to the quest this round, she may use Willpower instead of Defense when defending.")
                .WithInfo(6, 1, Artist.ZavgoSpb);
            addHero("Fëanor", 12, Sphere.Mastery, 3, 4, 1, 5)
                .WithTraits("Noldor.", "House of Fëanor.", "Noble.")
                .WithTextLine("Action: Place 1 Corruption on Fëanor to place 3 progress tokens on the quest. (Limit once per round).")
                .WithTextLine("Action: Place 1 Corruption on Fëanor to play an attachment from any sphere of influence for no cost.")
                .WithInfo(7, 1, Artist.Vishal);
            addHero("Thingol", 7, Sphere.Mastery, 3, 1, 2, 4)
                .WithTraits("Teleri.", "Noble.")
                .WithTextLine("While at least 1 character with the House of Fëanor trait is in play, Thingol's Willpower is treated as 1 for the purposes of Corruption.Setup: Choose 10 different cards from your deck and shuffle them into a separate Menegroth deck. After an enemy engages you, draw 1 card from the Menegroth deck.")
                .WithInfo(8, 1, Artist.Michael_Boatwright);
            addHero("Túrin Turambar", 9, Sphere.Mastery, 1, 2, 2, 4)
                .WithTraits("Edain.", "House of Hador.", "Warrior.")
                .WithTextLine("Action: Raise your threat by 1 to give Túrin Turambar +1 Attack until the end of the round.")
                .WithTextLine("Response: After Túrin Turambar is dealt any amount of damage, discard a character you control to cancel that damage. (Limit once per phase.)")
                .WithInfo(9, 1, Artist.Alan_Lee);
            addHero("Fingolfin", 11, Sphere.Tactics, 1, 1, 4, 6)
                .WithTraits("Noldor.", "House of Fingolfin.", "Noble.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Action: Raise your threat by 3 to choose an enemy in play. Engage the chosen enemy. Until the end of the round, Fingolfin does not exhaust to defend against the chosen enemy.")
                .WithInfo(10, 1, Artist.Murat_Calis);
            addHero("Húrin", 8, Sphere.Tactics, 2, 2, 2, 4)
                .WithTraits("Edain.", "House of Hador.", "Warrior.")
                .WithTextLine("Húrin gets +1 Attack for each enemy engaged with you.")
                .WithInfo(11, 1, Artist.Kimberly80);
            addHero("Ecthelion", 11, Sphere.Tactics, 1, 4, 3, 4)
                .WithTraits("Noldor.", "Warrior.")
                .WithTextLine("When Ecthelion attacks alone, the defending enemy does not count its Defense.")
                .WithInfo(12, 1, Artist.Jan_Pospisil);
            addHero("Círdan", 9, Sphere.Lore, 3, 1, 2, 4)
                .WithTraits("Teleri.", "Noble.")
                .WithTextLine("Círdan gets +1 Defense for each attached character.")
                .WithTextLine("Planning Action: Attach a character to Círdan. This character is considered to be out of play. At the end of the round, heal 3 damage on that character and put it back into play. (Limit twice per round.)")
                .WithInfo(13, 1, Artist.MouMou38);
            addHero("Turgon", 11, Sphere.Lore, 2, 2, 3, 5)
                .WithTraits("Noldor.", "House of Fingolfin.", "Noble.")
                .WithTextLine("Response: After raising your threat, name an encounter card type. Look at the top card of the encounter deck. If it matches the type you named, draw 1 card. If not, shuffle the encounter deck. (Limit once per phase.)")
                .WithInfo(14, 1, Artist.Sattarov);
            addHero("Idril Celebrindal", 7, Sphere.Lore, 3, 1, 1, 3)
                .WithTraits("Noldor.", "House of Fingolfin.", "Noble.")
                .WithTextLine("Response: After the active location is explored, return 1 ally of X cost from your discard pile to your hand. X is the Threat of the active location.")
                .WithInfo(15, 1, Artist.LigaMarta);
            addAlly("Melian", 3, Sphere.Neutral, true, 4, 0, 0, 3)
                .WithTraits("Maia.")
                .WithTextLine("At the end of the round, discard Melian from play.")
                .WithTextLine("Melian cannot attack or defend.")
                .WithTextLine("Response: After you play Melian from hand, choose a player and (choose 1): enemies do not make engagement checks against the chosen player until the end of the round, enemies cannot attack the chosen player this round, or the chosen player may look at the top 3 cards of the encounter deck.")
                .WithInfo(16, 3, Artist.Andrew_Ryan);
            addAlly("Eöl", 4, Sphere.Mastery, true, 2, 1, 3, 2)
                .WithTraits("Teleri.")
                .WithTextLine("Action: Place 1 Corruption on Eöl to search the top 15 cards of your deck for an attachment and add it to your hand.")
                .WithInfo(17, 3, Artist.CS_Marks);
            addAlly("Celegorm", 3, Sphere.Mastery, true, 1, 3, 1, 3)
                .WithTraits("Noldor.", "House of Fëanor.")
                .WithTextLine("Celegorm gets +1 Attack for each non-unique location in the staging area.Action: Place 1 Corruption on Celegorm to search the top 10 cards of the encounter deck for a location and add it to the staging area.")
                .WithInfo(18, 3, Artist.Lomacchi);
            addAlly("Maglor", 4, Sphere.Mastery, true, 3, 1, 1, 2)
                .WithTraits("Noldor.", "House of Fëanor.")
                .WithTextLine("Response: When a Corruption token would be placed on a character you control by the encounter deck, exhaust Maglor to place that Corruption token on Maglor instead.")
                .WithInfo(19, 3, Artist.Jenny_Dolfen);
            addAlly("Caranthir", 3, Sphere.Mastery, true, 0, 2, 1, 3)
                .WithTraits("Noldor.", "House of Fëanor.")
                .WithTextLine("Response: After a treachery is revealed and resolved, attach that card facedown to Caranthir. That attachment gains the Fury trait. (Limit once per round.)")
                .WithTextLine("Action: Attach a Fury attachment to an enemy engaged with you. That enemy gets +1 Attack and -1 Defense.")
                .WithInfo(20, 3, Artist.Lomacchi);
            addAlly("Maeglin", 3, Sphere.Mastery, true, 0, 2, 1, 2)
                .WithTraits("Noldor.", "Teleri.")
                .WithTextLine("Response: After the active location is explored, add 1 resource to a hero's resource pool (2 resources instead if you place 1 Corruption on that hero).")
                .WithInfo(21, 3, Artist.Virginie_Carquin);
            addAlly("Maedhros", 5, Sphere.Mastery, true, 3, 3, 2, 3)
                .WithTraits("Noldor.", "House of Fëanor.")
                .WithTextLine("While Maedhros has no Corruption on him, all Noldor characters get +1 Willpower.")
                .WithTextLine("While Maedhros has at least 1 Corruption on him, all characters with the House of Fëanor trait get +1 Attack.")
                .WithTextLine("Action: Place 1 Corruption on Maedhros")
                .WithInfo(22, 3, Artist.Jenny_Dolfen);
            addAlly("Mablung", 4, Sphere.Leadership, true, 2, 2, 2, 3)
                .WithTraits("Teleri.", "Warrior.")
                .WithTextLine("Response: After Mablung commits to a quest, choose a character. That character gets +1 Willpower and +1 Defense until the end of the round.")
                .WithInfo(23, 3, Artist.Cherif_Fortin);
            addAlly("Orodreth", 4, Sphere.Leadership, true, 2, 3, 1, 2)
                .WithTraits("Noldor.", "House of Finarfin.", "Noble.")
                .WithTextLine("Response: After a unique character with the House of Finarfin trait leaves play, put Orodreth into play from your hand.")
                .WithInfo(24, 3, Artist.Unknown);
            addAlly("Chieftain of Men", 2, Sphere.Leadership, false, 1, 2, 0, 2)
                .WithTraits("Edain.")
                .WithTextLine("Response: After your threat is raised by an encounter card effect, discard Chieftain of Men from play to cancel that effect.")
                .WithInfo(25, 3, Artist.Unknown);
            addAlly("Thorondor", 5, Sphere.Tactics, true, 2, 4, 1, 4)
                .WithTraits("Creature.", "Eagle.", "Noble.")
                .WithTextLine("Cannot have restricted attachments.")
                .WithTextLine("Response: After you play Thorondor from hand, put a character from any player's discard pile into play under its owner's control.")
                .WithInfo(26, 3, Artist.Ted_Nasmith);
            addAlly("Gondolin Guard", 2, Sphere.Tactics, false, 0, 1, 4, 1)
                .WithTraits("Noldor.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithInfo(27, 3, Artist.Unknown);
            addAlly("Huan", 4, Sphere.Tactics, true, 1, 4, 1, 4)
                .WithTraits("Hound.")
                .WithTextLine("Action: Huan gets +5 Attack until the end of the phase. At the end of the phase in which you trigger this effect, discard Huan. (Limit once per round.)")
                .WithTextLine("Action: Attach Huan to Beren or Lúthien. (Counts as a Mount attachment with the text: \"While attached hero is committed to the quest, deal 2 damage to each enemy revealed during staging\"")
                .WithInfo(28, 3, Artist.Rick_Ritchie);
            addAlly("Aredhel", 3, Sphere.Lore, true, 2, 1, 1, 2)
                .WithTraits("Noldor.", "House of Fingolfin.")
                .WithTextLine("Response: After the active location is explored, discard the top card of your deck. If it is an ally, take it into your hand.")
                .WithInfo(29, 3, Artist.Miao_Yu);
            addAlly("Dwarf of the Blue Mountains", 2, Sphere.Lore, false, 1, 1, 2, 2)
                .WithTraits("Dwarf.")
                .WithTextLine("Dwarf of the Blue Mountains gets +1 hit point for each unique attachment you control.")
                .WithInfo(30, 3, Artist.David_Gaillet);
            addAlly("Telchar the Smith", 3, Sphere.Lore, true, 1, 1, 1, 3)
                .WithTraits("Dwarf.")
                .WithTextLine("Action: Exhaust Telchar the Smith to choose an Armor or Weapon attachment in play. Until the end of the round, if the chosen attachment is Armor, it gains: \"Attached character gets +1 Defense.\" Until the end of the round, if the chosen attachment is a Weapon, it gains: \"Attached character gets +1 Attack.\"")
                .WithInfo(31, 3, Artist.Luc_de_Haan);
            addAlly("Green-elf Ranger", 2, Sphere.Lore, false, 1, 1, 0, 2)
                .WithTraits("Nandor.", "Ranger.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Quest Action: Exhaust Green-elf Ranger to choose enemy or location. The next encounter card of the chosen type that is added to the staging area gets -3 Threat until the end of the phase.")
                .WithInfo(32, 3, Artist.Paulo_Puggioni);
            addAlly("Daeron", 2, Sphere.Lore, true, 2, 1, 1, 2)
                .WithTraits("Teleri.", "Minstrel.")
                .WithTextLine("Action: Exhaust Daeron to draw 2 cards. Then discard 1 card from your hand.")
                .WithInfo(33, 3, Artist.Ebe_Kastein);
            addAlly("Elwing", 3, Sphere.Spirit, true, 3, 0, 0, 1)
                .WithTraits("Half-elven.")
                .WithTextLine("While Eärendil is in play, Elwing gains: \"Response: After Elwing is destroyed, you may immediately put her back into play for 1 Spirit resource. (Limit once per round.)\"")
                .WithInfo(34, 3, Artist.Miao_Yu);
            addAlly("Huor", 3, Sphere.Tactics, true, 1, 1, 2, 3)
                .WithTraits("Edain.", "House of Hador.", "Warrior.")
                .WithTextLine("Huor may be assigned damage from undefended attacks.")
                .WithInfo(35, 3, Artist.Unknown);
            addAlly("Bëor", 2, Sphere.Spirit, true, 1, 1, 1, 2)
                .WithTraits("Edain.", "House of Bëor.")
                .WithTextLine("Action: Attach Bëor facedown to a character with the House of Finarfin trait. (Counts as a Vassal attachment with the text: \"Attached character gets +2 Willpower.\")")
                .WithInfo(36, 3, Artist.Stefan_Meisl);
            addAlly("Hador", 3, Sphere.Leadership, true, 1, 2, 1, 2)
                .WithTraits("Edain.", "House of Hador.")
                .WithTextLine("Action: Discard Hador to reveal the top 5 cards of your deck. Put up to 2 revealed allies with the Edain trait into play, if able. Shuffle all other revealed cards back into your deck.")
                .WithInfo(37, 3, Artist.Unknown);
            addAlly("Barahir", 3, Sphere.Leadership, true, 1, 1, 3, 3)
                .WithTraits("Edain.", "House of Bëor.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Response: After a shadow card is revealed, exhaust Barahir to add his Defense to the Defense of the defending character until the end of the phase.")
                .WithInfo(38, 3, Artist.Saturnoarg);
            addAlly("Morwen", 3, Sphere.Spirit, true, 2, 0, 1, 2)
                .WithTraits("Edain.", "House of Bëor.")
                .WithTextLine("Action: Raise your threat by 1 to give Morwen +1 Willpower until the end of the round. (Limit twice per round.)")
                .WithInfo(39, 3, Artist.Ekaterina_Kovalevskaya);
            addAlly("Tuor", 4, Sphere.Spirit, true, 3, 1, 1, 3)
                .WithTraits("Edain.", "House of Hador.")
                .WithTextLine("Action: Exhaust Tuor to choose a player. That player looks at the top 3 cards of his deck. He may discard 1 to discard the top card of the encounter deck, returning the remaining cards to the top of his deck in any order.")
                .WithInfo(40, 3, Artist.Luca_Michelucci);
            addAlly("Finduilas", 1, Sphere.Spirit, true, 2, 0, 0, 2)
                .WithTraits("Noldor.", "House of Finarfin.")
                .WithTextLine("Forced: Damage from undefended attacks must be assigned to Finduilas. After Finduilas leaves play, raise your threat by 2.")
                .WithInfo(41, 3, Artist.Kuun_Suru);
            addAlly("Azaghâl", 4, Sphere.Tactics, true, 1, 3, 2, 4)
                .WithTraits("Dwarf.", "Warrior.")
                .WithTextLine("Response: After Azaghâl is destroyed as the result of an enemy attack, deal 3 damage to the attacking enemy.")
                .WithInfo(42, 3, Artist.Even_Mehl_Amundsen);
            addAlly("Curufin", 3, Sphere.Mastery, true, 2, 2, 0, 3)
                .WithTraits("Noldor.", "House of Fëanor.")
                .WithTextLine("While Fëanor is in play, Curufin gains: \"Action: Place 1 Corruption on Curufin. Until the end of the round, Curufin's Willpower, Attack and Defense are equal to the printed Willpower, Attack, and Defense of Fëanor.\"")
                .WithInfo(43, 3, Artist.Alan_Michael_S);
            addAttachment("High Kingship of the Noldor", 2, Sphere.Leadership, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a Noldor hero.")
                .WithTextLine("Action: Exhaust High Kingship of the Noldor to add 2 resources to attached hero's resource pool.")
                .WithInfo(44, 3, Artist.Mathia_Arkoniel);
            addAttachment("Elf-friend", 1, Sphere.Spirit, false)
                .WithTraits("Title.")
                .WithTextLine("Attach to an Edain hero.")
                .WithTextLine("Attached hero gains the Noldor trait.")
                .WithInfo(45, 3, Artist.Anke_Eissmann);
            addAttachment("Shadowy Cloak", 2, Sphere.Spirit, true)
                .WithTraits("Enchantment.")
                .WithTextLine("Attach to Lúthien.")
                .WithTextLine("Resources on Shadowy Cloak can only be used to pay for Lúthien's ability.")
                .WithTextLine("Action: Exhaust Shadowy Cloak to either add 1 resource to Shadowy Cloak or ready Lúthien.")
                .WithInfo(46, 3, Artist.Ted_Nasmith);
            addAttachment("Vingilot", 2, Sphere.Spirit, true)
                .WithTraits("Ship.")
                .WithTextLine("Attach to a hero with the Half-elven trait.")
                .WithTextLine("Action: Exhaust Vingilot to use the attached hero's Willpower instead of Defense (or Attack, if attached hero is Eärendil) until the end of the phase.")
                .WithInfo(47, 3, Artist.Ted_Nasmith);
            addAttachment("Harp of Fingon", 2, Sphere.Leadership, true)
                .WithTraits("Instrument.")
                .WithTextLine("Attach to a hero with the House of Fingolfin trait.")
                .WithTextLine("Response: After a Corruption token is removed from play, exhaust Harp of Fingon to add 1 resource to the attached hero's resource pool.")
                .WithInfo(48, 3, Artist.Egor_Gafidov);
            addAttachment("Oath of Friendship", 1, Sphere.Leadership, false)
                .WithTraits("Oath.")
                .WithTextLine("Attach to a hero. Limit 2 in play.")
                .WithTextLine("Action: Move any number of resources from the attached hero's resource pool to the resource pool of another hero with Oath of Friendship attached.")
                .WithTextLine("Response: After you play Oath of Friendship, you may immediately search your deck for another copy of Oath of Friendship and add it to your hand. Then, shuffle your deck.")
                .WithInfo(49, 3, Artist.Catherine_Karina_Chmiel);
            addAttachment("Oath of Vengeance", 2, Sphere.Tactics, false)
                .WithTraits("Oath.")
                .WithTextLine("Attach to a hero. Limit 1 per hero.")
                .WithTextLine("Response: After a character you control is destroyed, place 1 resource on Oath of Vengeance.")
                .WithTextLine("Action: Spend 1 resource from Oath of Vengeance to give attached hero +1 Willpower or +1 Attack until the end of the phase.")
                .WithInfo(50, 3, Artist.Meanor);
            addAttachment("Oath of Fëanor", 1, Sphere.Mastery, false)
                .WithTraits("Oath.")
                .WithTextLine("Attach to a character with the House of Fëanor trait. Limit 1 per character.")
                .WithTextLine("Corruption on the attached character cannot be removed.")
                .WithTextLine("Planning Action: Exhaust Oath of Fëanor to switch the printed Attack and Willpower of the attached character until the end of the round.")
                .WithInfo(51, 3, Artist.Jenny_Dolfen);
            addAttachment("Oath of Silence", 0, Sphere.Lore, false)
                .WithTraits("Oath.")
                .WithTextLine("Attach to a hero. Limit 1 per hero.")
                .WithTextLine("Forced: Discard one card from your hand at the end of each round.")
                .WithTextLine("Response: After Oath of Silence is attached to a hero you control, search your deck for 2 cards and add them to your hand. Then, shuffle your deck.")
                .WithInfo(52, 3, Artist.Ted_Nasmith);
            addAttachment("Haudh-en-Ndengin", 1, Sphere.Lore, true)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a location in play.")
                .WithTextLine("While Haudh-en-Ndengin has at least one facedown attachment, the Threat of the attached location is reduced to 0.Response: After a character is destroyed, attach that card facedown to Haudh-en-Ndengin.")
                .WithInfo(53, 3, Artist.Ted_Nasmith);
            addAttachment("Hidden House", 1, Sphere.Lore, false)
                .WithTraits("Hideout.")
                .WithTextLine("Attach to a location in play.")
                .WithTextLine("While the attached location is the active location, enemies do not make engagement checks.")
                .WithInfo(54, 3, Artist.Ted_Nasmith);
            addAttachment("Solitary Outlaw", 0, Sphere.Neutral, false)
                .WithTraits("Condition.")
                .WithTextLine("Limit 1 per hero.")
                .WithTextLine("Setup: Attach to a hero. This hero must be the only hero you control.")
                .WithTextLine("Attached hero gets +2 Willpower, +2 Attack, +2 Defense, +2 hit points and does not exhaust to quest.")
                .WithInfo(55, 3, Artist.Ted_Nasmith);
            addAttachment("Nauglamír", 5, Sphere.Mastery, true)
                .WithTraits("Item.", "Artifact.", "Silmaril.")
                .WithTextLine("Lower the cost to play Nauglamír by 1 for each Dwarf in play. Attach to a hero.")
                .WithTextLine("Each hero you control gets +1 Willpower, +1 Attack, and +1 Defense.")
                .WithTextLine("Forced: At the start of the combat phase, discard a resource from the attached hero's resource pool for each Dwarf in play. Any Dwarf for which you did not discard a resource immediately becomes corrupted.")
                .WithInfo(56, 3, Artist.Ted_Nasmith);
            addAttachment("Ard-galen Horse", 3, Sphere.Lore, false)
                .WithTraits("Mount.")
                .WithTextLine("Attach to a Noldor hero. Limit 1 per hero.")
                .WithTextLine("Action: Exhaust Ard-galen Horse to place 1 progress token on each location in the staging area.")
                .WithInfo(57, 3, Artist.Unknown);
            addAttachment("Galvorn Armor", 2, Sphere.Mastery, false)
                .WithTraits("Item.", "Armor.")
                .WithTextLine("Attach to a Mastery hero. Limit 1 per hero.")
                .WithTextLine("Attached hero gets +1 Defense. Attached hero gets an additional +1 Defense for each Corruption on the attached hero.")
                .WithInfo(58, 3, Artist.Unknown);
            addAttachment("Poisoned Javelin", 2, Sphere.Mastery, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Mastery character. Restricted.")
                .WithTextLine("Response: After attached character damages an enemy, attach Poisoned Javelin to that enemy.")
                .WithTextLine("Forced: At the end of each round, if Poisoned Javelin is attached to an enemy, deal 2 damage to that enemy. You may place 1 Corruption on a hero you control to increase this to 4 damage.")
                .WithInfo(59, 3, Artist.John_G);
            addAttachment("Ring of Barahir", 2, Sphere.Leadership, true)
                .WithTraits("Item.", "Artifact.")
                .WithTextLine("Attach to an Edain hero.")
                .WithTextLine("Action: Discard Ring of Barahir to put a unique Noldor ally into play from your hand.")
                .WithInfo(60, 3, Artist.Anke_Eissmann);
            addAttachment("Ringil", 2, Sphere.Tactics, true)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero with the House of Fingolfin trait. Restricted.")
                .WithTextLine("Attached hero gets +1 Attack (+2 Attack if Fingolfin).")
                .WithTextLine("If the attached hero is Fingolfin, Ringil gains: \"Response: After the attached character attacks alone, cancel all damage from the attack and reduce your threat by that amount instead.\"")
                .WithInfo(61, 3, Artist.Sarafiel);
            addAttachment("Rochallor", 2, Sphere.Tactics, true)
                .WithTraits("Mount.")
                .WithTextLine("Attach to Fingolfin.")
                .WithTextLine("Combat Action: Choose an enemy in the staging area. Exhaust Rochallor and the attached hero to make an attack on that enemy. The attached hero gets +1 Attack (+2 Attack if the enemy is unique).")
                .WithInfo(62, 3, Artist.Hector_Hanoteau);
            addAttachment("Blue Shield", 1, Sphere.Tactics, true)
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero with the House of Fingolfin trait. Restricted.")
                .WithTextLine("Attached hero gets +1 Defense (+2 Defense if the attached hero is Fingolfin).")
                .WithInfo(63, 3, Artist.Peter_Xavier_Pric);
            addAttachment("Dragon-helm", 3, Sphere.Tactics, true)
                .WithTraits("Item.", "Armor.", "Artifact.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero with the House of Hador trait. Restricted.")
                .WithTextLine("Response: After attached hero is damaged, exhaust Dragon-helm and raise your threat by 3 to cancel all damage from that attack.")
                .WithTextLine("If attached hero is Túrin, Dragon-helm gains, \"Response: After an enemy engages with you, it gets -1 Attack and -1 Defense until the end of the round.\"")
                .WithInfo(64, 3, Artist.Mahdi_Mehrnegar);
            addAttachment("Gurthang", 2, Sphere.Mastery, true)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero with a printed Mastery resource icon. Restricted.")
                .WithTextLine("Attached hero gets +1 Attack.")
                .WithTextLine("Response: After attached hero damages an enemy, shuffle the encounter deck and discard the top card. If it is a treachery, cancel all damage from the attack and discard a hero. Otherwise, the enemy is destroyed.")
                .WithInfo(65, 3, Artist.Elena_Kukanova);
            addAttachment("Mormegil", 1, Sphere.Mastery, true)
                .WithTraits("Name.")
                .WithTextLine("Attach to Túrin Turambar. Limit 1 Name in play.")
                .WithTextLine("Túrin Turambar gains a Tactics resource icon.")
                .WithTextLine("All enemies get -1 Threat and -10 engagement cost.")
                .WithInfo(66, 3, Artist.Horhe_Soloma);
            addAttachment("Nimphelos", 0, Sphere.Spirit, true)
                .WithTraits("Item.", "Artifact.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Action: Pay 1 resource from attached hero's resource pool to give attached hero +1 Willpower until the end of the phase. (Limit three times per phase.)")
                .WithInfo(67, 3, Artist.US_Pixelstory);
            addEvent("Strength of Men", 3, Sphere.Leadership)
                .WithTextLine("Action: Exhaust an ally with the Edain trait. Add the Willpower, Attack, and Defense of that ally to all characters with the Noldor trait you control until the end of the round.")
                .WithInfo(68, 3, Artist.Riyahd_Cassiem);
            addEvent("Erchamion", 3, Sphere.Spirit)
                .WithTraits("Condition.")
                .WithTextLine("Response: After a character is destroyed, put that character back into play under its owner's control. Attach Erchamion to that character. (Counts as a Condition attachment with the text: 'The attached character gets -1 Attack and -1 Defense.'")
                .WithInfo(69, 3, Artist.Dylan_Palmer);
            addEvent("The Day Has Come!", 2, Sphere.Spirit)
                .WithTextLine("Action: Until the end of the phase, all Noldor characters get +1 Willpower.")
                .WithInfo(70, 3, Artist.Lady_Elleth);
            addEvent("Song of Lúthien", 2, Sphere.Spirit)
                .WithTraits("Song.")
                .WithTextLine("Action: If you control Lúthien or a unique Maia character, reduce each player's threat by 3.")
                .WithInfo(71, 3, Artist.Ted_Nasmith);
            addEvent("Song of Staying", 1, Sphere.Spirit)
                .WithTraits("Song.")
                .WithTextLine("Response: After a treachery with doomed or surge is revealed, cancel the effects of all keywords on that treachery.")
                .WithInfo(72, 3, Artist.FangornSpirit);
            addEvent("Arts of Felagund", 3, Sphere.Lore)
                .WithTraits("Enchantment.")
                .WithTextLine("Quest Action: Until the end of the phase, each enemy revealed during staging is discarded and replaced with the next encounter card instead. Add this card to the victory display.")
                .WithVictoryPoints(1)
                .WithInfo(73, 3, Artist.Alan_Lee);
            addEvent("Passed in Peace", 1, Sphere.Lore)
                .WithTextLine("Response: After a character with the Edain trait leaves play, play Passed in Peace to draw 2 cards.")
                .WithInfo(74, 3, Artist.Rafael_Damiani);
            addEvent("Leaguer", 0, Sphere.Neutral)
                .WithTextLine("Action: Exhaust characters with X points of total Defense to choose enemies with up to X points of total Attack. Those enemies cannot attack this round.")
                .WithInfo(75, 3, Artist.John_Howe);
            addEvent("Madness of Rage", 0, Sphere.Mastery)
                .WithTextLine("Action: Choose a character you control. Until the end of the phase, that character gets +3 Attack and must attack alone.")
                .WithInfo(76, 3, Artist.Joel_M_Kilpatrick);
            addEvent("Hour of Need", 2, Sphere.Leadership)
                .WithTextLine("Response: If at least X enemies are engaged with players (X being equal to twice the number of players), each player may put 1 ally into play from his hand, if able.")
                .WithInfo(77, 3, Artist.Justin_Gerard);
            addEvent("A Great Doom", 2, Sphere.Lore)
                .WithTraits("Doom.")
                .WithTextLine("Response: After a player card is drawn or an encounter card is revealed (including a shadow effect), shuffle that card back into its deck and draw a new card.")
                .WithInfo(78, 3, Artist.Ted_Nasmith);
            addEvent("Fire of Life", 0, Sphere.Mastery)
                .WithTraits("Condition.")
                .WithTextLine("Response: After a character with the House of Fëanor trait is damaged, cancel 1 point of that damage and attach Fire of Life to that character. (Counts as a Condition attachment with the text: \"Limit 1 per character. Attached character gets +1 Attack.\")")
                .WithInfo(79, 3, Artist.Rick_Ritchie);
            addEvent("Defied and Mocked", 1, Sphere.Mastery)
                .WithTextLine("Action: Choose an ally. That ally can be assigned damage from undefended attacks until the end of the phase.")
                .WithInfo(80, 3, Artist.Ted_Nasmith);
            addEvent("Dreadful Death", 0, Sphere.Mastery)
                .WithTextLine("Response: After a corrupted character destroys a hero or ally, remove all Corruption from that character and place it under your control.")
                .WithInfo(81, 3, Artist.Ted_Nasmith);
            addEvent("Dark Heart of the Smith", 0, Sphere.Mastery)
                .WithTextLine("Action: Place 1 Corruption on a character with a unique Weapon attached. All damage dealt by that character is doubled this round. Only 1 copy of Dark Heart of the Smith may be played on a character each round.")
                .WithInfo(82, 3, Artist.Noldomirwen);
            addEvent("Undismayed", 1, Sphere.Tactics)
                .WithTextLine("Response: After a character is destroyed by an enemy attack, put that character back into play. That character gets +3 Attack and is discarded at the end of the phase.")
                .WithInfo(83, 3, Artist.Carlo_Pagulayan);
            addEvent("Feast of Reuniting", 3, Sphere.Tactics)
                .WithTextLine("Action: All characters gain ranged and sentinel until the end of the phase.")
                .WithInfo(84, 3, Artist.Pieter_Claesz);
            addEvent("Banners and Horns", 1, Sphere.Tactics)
                .WithTextLine("Response: After a unique ally you control enters play, choose any non-unique enemy in play. That enemy gets -X Attack and -X Defense until the end of the round. (X is equal to the cost of that ally.)")
                .WithInfo(85, 3, Artist.Jenny_Dolfen);
            addEvent("No Better Hope", 1, Sphere.Spirit)
                .WithTextLine("Action: Exhaust a hero you control to discard a corrupted character from play.")
                .WithInfo(86, 3, Artist.Ted_Nasmith);
            addEvent("Hold to the Oath", 1, Sphere.Leadership)
                .WithTraits("Oath.")
                .WithTextLine("Action: Each character with an attached Oath gets +1 Willpower, +1 Attack, and +1 Defense until the end of the round.")
                .WithInfo(87, 3, Artist.Ted_Nasmith);
            addHero("Beren", 8, Sphere.Leadership, 3, 2, 1, 4)
                .WithTraits("Edain.", "House of Bëor.", "Noble.")
                .WithTextLine("While Beren is committed to the quest, he gains: 'Response: After an encounter card with at least 3 Threat is revealed from the encounter deck, add 1 resource to Beren's resource pool.'")
                .WithInfo(87, 3, Artist.Anke_Eissmann);
            addEvent("Manwë's Pity", 0, Sphere.Leadership)
                .WithTraits("Vala.")
                .WithTextLine("Response: After a unique Noldor ally you control is destroyed by an enemy attack, immediately put into play another copy of that ally from your hand.")
                .WithInfo(88, 3, Artist.Ted_Nasmith);
            addEvent("Secrets of Craft", 1, Sphere.Lore)
                .WithTextLine("Action: Choose a player. That player draws 1 card for each Item attachment you control.")
                .WithInfo(89, 3, Artist.Steamey);
            addEvent("Dreams from Ulmo", 1, Sphere.Lore)
                .WithTraits("Vala.")
                .WithTextLine("If the active location is a River or Water location, reduce the cost to play Dreams from Ulmo by 1.")
                .WithTextLine("Action: Choose one character you control. Shuffle the encounter deck and look at its top card. Until the end of the phase, the chosen character gets +X Willpower. X is equal to the revealed card's Threat.")
                .WithInfo(90, 3, Artist.Ted_Nasmith);
            addEvent("Friendship of Ulmo", 2, Sphere.Lore)
                .WithTraits("Vala.")
                .WithTextLine("If the active location is a River or Water location, reduce the cost to play Friendship of Ulmo by 2.")
                .WithTextLine("Action: Reveal all shadow cards in play. Then, choose two shadow cards from different enemies and switch them.")
                .WithInfo(91, 3, Artist.John_Howe);
            addEvent("Strengthen the Watch", 0, Sphere.Tactics)
                .WithTextLine("Encounter Action: Exhaust a character. All enemies that engaged you this phase get -1 Attack until the end of the round.")
                .WithInfo(92, 3, Artist.Felix_Sotomayor);
            addEvent("Secret Toil", 1, Sphere.Leadership)
                .WithTextLine("Action: Exhaust 2 heroes you control to reveal the top 5 cards of your deck. Choose one attachment or ally and put it into play for no cost. Shuffle all other revealed cards back into your deck.")
                .WithInfo(93, 3, Artist.Ted_Nasmith);
            addEvent("...And Yet A Warning", 1, Sphere.Tactics)
                .WithTextLine("Response: After you attack and destroy an enemy, choose one: add 1 resource to the resource pool of a hero you control, draw 1 card, or lower your threat by 1.")
                .WithInfo(94, 3, Artist.Ted_Nasmith);
            addEvent("Song of Gladness", 0, Sphere.Spirit)
                .WithTraits("Song.")
                .WithTextLine("Play only if there are no enemies engaged with you.")
                .WithTextLine("Action: Reduce your threat by 3.")
                .WithInfo(95, 3, Artist.Ted_Nasmith);
            addEvent("Flame Light! Flee Night!", 1, Sphere.Leadership)
                .WithTextLine("Play only if you control a hero with the Edain trait.")
                .WithTextLine("Action: Search your deck for a character with the Edain trait and put it into play. That character does not exhaust to quest, attack, or defend until the end of the round. Discard that character at the end of the round.")
                .WithInfo(96, 3, Artist.John_Howe);
            addEvent("Open Battle", 0, Sphere.Mastery)
                .WithTraits("Plan.")
                .WithKeywords("Doomed 2.")
                .WithTextLine("Doomed 2.")
                .WithTextLine("Action: Each player may search his deck for a Weapon or Armor attachment and add it to his hand.")
                .WithInfo(97, 3, Artist.Unknown);
            addEvent("Day Shall Come Again", 1, Sphere.Tactics)
                .WithTextLine("Response: After a character you control destroys an enemy, ready that character. That character gets +1 Attack until the end of the round. You may pay 1 Tactics resource to return Day Shall Come Again to your hand.")
                .WithInfo(98, 3, Artist.Julia_Alekseeva);
            addTreachery("Song of Wizardry", EncounterSet.TheIsleOfWerewolves)
                .WithTraits("Song.")
                .WithTextLine("When Revealed: Each player must discard the top card of his deck and place Corruption among his characters equal to its cost.")
                .WithShadow("Shadow: Place 1 Corruption on the defending character if it is an ally.")
                .WithInfo(99, 2, Artist.HellgaZ);
            addTreachery("Weight of Horror", EncounterSet.TheIsleOfWerewolves)
                .WithTraits("Condition.")
                .WithTextLine("When Revealed: Attach to the hero with the highest Willpower. (Counts as a Condition attachment with the text: 'The attached hero must spend 1 resource from his pool to commit to the quest. Limit 1 per hero.')")
                .WithInfo(100, 2, Artist.Ted_Nasmith);
            addTreachery("Lord of Werewolves", EncounterSet.TheIsleOfWerewolves)
                .WithTextLine("When Revealed: Each player must search the encounter deck and discard pile for one enemy with the Werewolf trait and add it to the staging area.")
                .WithShadow("Shadow: The attacking enemy returns to the staging area after this attack.")
                .WithInfo(101, 2, Artist.Unknown);
            addTreachery("Master of Shadows", EncounterSet.TheIsleOfWerewolves)
                .WithTraits("Maia.")
                .WithTextLine("When Revealed: Attach to the current quest stage. (Counts as a Condition attachment with the text: 'Each enemy is dealt an additional shadow card at the beginning of the combat phase.')")
                .WithInfo(102, 2, Artist.AlaisL);
            addTreachery("No Living Creature", EncounterSet.TheIsleOfWerewolves)
                .WithTraits("Maia.")
                .WithTextLine("When Revealed: Each player must choose one: raise your threat by 1 for each character you control or place 1 Corruption on each character you control.")
                .WithInfo(103, 2, Artist.Murasaki_Ri);
            addTreachery("Foul Vapour", EncounterSet.TheIsleOfWerewolves)
                .WithTextLine("When Revealed: Each character in play gets -X Attack and -X Defense until the end of the round. X is the number of enemies with the Werewolf trait engaged with the controlling player. If there are no engaged enemies with the Werewolf trait, Foul Vapour gains surge.")
                .WithShadow("Shadow: The defending character gets -1 Defense until the end of the phase.")
                .WithInfo(104, 2, Artist.Alex_McVey);
            addLocation("Deep Pit", EncounterSet.TheIsleOfWerewolves, 2, 7)
                .WithTraits("Dungeon.")
                .WithTextLine("Response: After Deep Pit is explored, the first player chooses one: add 1 resource to Eyes in the Dark or move one hero to the pit area.")
                .WithInfo(105, 2, Artist.Alyn_Spiller);
            addLocation("Gates of Tol-in-Gaurhoth", EncounterSet.TheIsleOfWerewolves, 4, 2)
                .WithTraits("Fortification.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("The first enemy with the Werewolf trait revealed each turn gains surge.")
                .WithInfo(106, 2, Artist.Elshazam);
            addLocation("Walls of Stone", EncounterSet.TheIsleOfWerewolves, 2, 3)
                .WithTraits("Fortification.")
                .WithTextLine("While Walls of Stone is in the staging area, progress cannot be placed on the current quest stage.")
                .WithShadow("Shadow: If a character is destroyed by this attack, remove 5 progress tokens from the quest.")
                .WithInfo(107, 3, Artist.Unknown);
            addLocation("High Tower", EncounterSet.TheIsleOfWerewolves, 5, 5)
                .WithUnique()
                .WithTraits("Fortification.")
                .WithTextLine("While High Tower is the active location, all enemies get -20 engagement cost.")
                .WithTextLine("Response: After High Tower is explored as the active location, remove one Condition attachment from play.")
                .WithInfo(108, 1, Artist.Stirzocular);
            addLocation("Dark Hills", EncounterSet.TheIsleOfWerewolves, 3, 6)
                .WithTraits("Hills.")
                .WithTextLine("While Dark Hills is in play, players cannot use player card effects that allow them to look at cards in the encounter deck or player decks.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each shadow card it has been dealt.")
                .WithInfo(109, 2, Artist.Silvery);
            addLocation("Vacant Pit", EncounterSet.TheIsleOfWerewolves, 2, 4)
                .WithTraits("Dungeon.")
                .WithTextLine("Forced: Remove 1 resource from Eyes in the Dark at the end of the round.")
                .WithShadow("Shadow: If this attack destroys a character, remove 1 resource from Eyes in the Dark.")
                .WithInfo(110, 2, Artist.ElderScroller);
            addLocation("Bridge to the Isle", EncounterSet.TheIsleOfWerewolves, 3, 6)
                .WithUnique()
                .WithTraits("Bridge.", "Water.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("While Bridge to the Isle is the active location, enemies with the Werewolf trait get +1 Attack and +1 Defense.Forced: After Bridge to the Isle is explored, add Draugluin to the staging area.")
                .WithInfo(111, 1, Artist.Bogdan_Amidzic);
            addObjective("Eyes in the Dark", EncounterSet.TheIsleOfWerewolves)
                .WithTraits("Devoured.")
                .WithTextLine("Place 8 resource tokens on Eyes in the Dark.At the end of each round, discard 1 resource token from Eyes in the Dark.")
                .WithTextLine("If there are no resource tokens to discard, remove Eyes in the Dark from play and put Devouring Werewolf into play in the pit area, engaged with the prisoners.")
                .WithInfo(112, 1, Artist.Graeme_Skinner);
            addQuest("Upon the Bridge", EncounterSet.TheIsleOfWerewolves, 1, 'A', 20)
                .WithTextLine("Setup: Set aside Devouring Werewolf, Draugluin, Bridge to the Isle and Wolf-Sauron. Create a pit area with stage 2A and follow the setup instructions on that card.")
                .WithOppositeTextLine("When Revealed: Add Bridge to the Isle to the staging area. Reveal X encounter cards where X equals the number of players in the game minus 1.")
                .WithOppositeTextLine("When this stage is completed, advance to stage 3A. This stage cannot be completed until Draugluin is in the victory display.")
                .WithInfo(113, 1, Artist.Roger_Garland);
            addQuest("The Pits of Sauron", EncounterSet.TheIsleOfWerewolves, 2, 'A', null)
                .WithTextLine("When Revealed: Search the encounter deck for Finrod Felagund and Eyes in the Dark and add both to the pit area. Choose one hero to be placed in the pit area. That hero is captured. The controlling player may immediately replace the captured hero with another of his choice.")
                .WithOppositeTextLine("Heroes at this stage do not collect resources or commit to the quest and are immune to player card effects. Player cannot play or put into play allies or attachments into the pit area.")
                .WithOppositeTextLine("Forced: If the players quest unsuccessfully, remove 1 resource from Eyes in the Dark, if able.")
                .WithOppositeTextLine("If the captured hero is destroyed, the players lose the game. If Devouring Werewolf is destroyed, discard this stage from play and return all characters to their owner's control.")
                .WithInfo(114, 1, Artist.Nicholas_Cloister);
            addQuest("Tol-in-Gaurhoth", EncounterSet.TheIsleOfWerewolves, 3, 'A', null)
                .WithTextLine("When Revealed: Add Wolf-Sauron to the staging area. Reveal 1 encounter card per player.")
                .WithOppositeTextLine("Forced: After an enemy is revealed from the encounter deck, discard it instead of adding it to the staging area.")
                .WithOppositeTextLine("Planning Action: Exhaust a hero with X Willpower. Wolf-Sauron gets -X Defense until the end of the round. (Limit once per round.)")
                .WithOppositeTextLine("If the players destroy Wolf-Sauron, they have rescued the prisoners and won the game.")
                .WithInfo(115, 1, Artist.Bogdan_Amidzic);
            addObjectiveAlly("Finrod Felagund", EncounterSet.TheIsleOfWerewolves, 3, 3, 1, 4)
                .WithUnique()
                .WithSlugSuffix("Objective-Ally")
                .WithTraits("Noldor.", "House of Finarfin.", "Noble.")
                .WithTextLine("The first player gains control of Finrod Felagund.")
                .WithTextLine("Action: Discard Finrod Felagund to deal 5 points of damage to an engaged enemy.")
                .WithInfo(116, 1, Artist.Elfkin);
            addEnemy("Draugluin", EncounterSet.TheIsleOfWerewolves, 45, 4, 7, 4, 12)
                .WithUnique()
                .WithTraits("Creature.", "Werewolf.")
                .WithKeywords("Relentless.")
                .WithTextLine("Relentless.")
                .WithTextLine("Forced: After Draugluin is damaged by an attack, deal 1 damage to each character that participated in that attack.")
                .WithVictoryPoints(3)
                .WithInfo(117, 1, Artist.Taina_Dos);
            addEnemy("Wolf-Sauron", EncounterSet.TheIsleOfWerewolves, 48, 5, 9, 5, 20)
                .WithUnique()
                .WithTraits("Maia.", "Werewolf.")
                .WithKeywords("Relentless.")
                .WithTextLine("Relentless.")
                .WithTextLine("Forced: After Wolf-Sauron attacks, place 1 Corruption on a random ally controlled by the engaged player.")
                .WithVictoryPoints(5)
                .WithInfo(118, 1, Artist.Blaz_Porenta);
            addEnemy("Ravenous Werewolf", EncounterSet.TheIsleOfWerewolves, 30, 1, 2, 1, 5)
                .WithTraits("Creature.", "Werewolf.")
                .WithTextLine("Ravenous Werewolf gets +1 Attack for each damage token on characters you control.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack. X is the number of damage tokens on the defending character.")
                .WithInfo(119, 4, Artist.Daniel_Ljunggren);
            addEnemy("Thuringwethil", EncounterSet.TheIsleOfWerewolves, 33, 3, 5, 1, 6)
                .WithUnique()
                .WithTraits("Vampire.")
                .WithTextLine("Forced: After Thuringwethil damages a character, remove an equal amount of damage from Thuringwethil.")
                .WithShadow("Shadow: Remove all damage from the attacking enemy.")
                .WithInfo(120, 1, Artist.Atomhawk);
            addEnemy("Monstrous Bat", EncounterSet.TheIsleOfWerewolves, 20, 2, 4, 1, 4)
                .WithTraits("Creature.", "Vampire.")
                .WithTextLine("Forced: After Monstrous Bat deals damage to a character, raise its Defense by X until the end of the round, where X equals the amount of damage dealt.")
                .WithInfo(121, 2, Artist.Damian_Ziomek);
            addEnemy("Guard Wolf", EncounterSet.TheIsleOfWerewolves, 25, 2, 2, 3, 5)
                .WithTraits("Creature.", "Werewolf.")
                .WithTextLine("When Revealed: Choose one character committed to the quest and remove him from the quest. If Guard Wolf is not destroyed by the end of the round, that character does not ready during the refresh phase.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. (+2 Attack instead if the enemy is a Werewolf.)")
                .WithInfo(122, 3, Artist.Unknown);
            addEnemy("Hunting Wolf", EncounterSet.TheIsleOfWerewolves, 32, 3, 3, 2, 4)
                .WithTraits("Creature.", "Werewolf.")
                .WithTextLine("Forced: After Hunting Wolf engages a player, raise that player's threat by 3.")
                .WithShadow("Shadow: Raise the defending player's threat by 2.")
                .WithInfo(123, 4, Artist.Unknown);
            addEnemy("Crazed Thrall", EncounterSet.TheIsleOfWerewolves, 28, 1, 2, 1, 3)
                .WithTraits("Thrall.")
                .WithTextLine("Forced: Reveal 1 encounter card at the end of the round.Forced: After Crazed Thrall is destroyed by an attack, place 1 Corruption on each participating character.Response: After questing successfully, cancel all progress and instead remove Crazed Thrall from play.")
                .WithInfo(124, 3, Artist.Unknown);
            addEnemy("Devouring Werewolf", EncounterSet.TheIsleOfWerewolves, 1, 3, 6, 3, 10)
                .WithUnique()
                .WithTraits("Creature.", "Werewolf.")
                .WithTextLine("Immune to player card effects. Cannot leave the pit area.")
                .WithTextLine("Forced: Characters destroyed by Devouring Werewolf are removed from the game.")
                .WithInfo(125, 1, Artist.David_Wuertemburg);
            addQuest("Doors of Angband", EncounterSet.TheSeatOfMorgoth, 1, 'A', 15)
                .WithTextLine("Setup: Add Carcharoth to the staging area. Set Morgoth and all objectives and unique locations aside out of play. Set your threat equal to the number of heroes you control.")
                .WithOppositeTextLine("Forced: Skip the staging step during the quest phase. Instead, each player must discard the top card of his deck after committing characters to the quest. Add the cost of each discarded card to the total Threat in the staging area until the end of the phase.")
                .WithOppositeTextLine("If Carcharoth has 0 hit points, advance to stage 2 immediately.")
                .WithInfo(126, 1, Artist.Danny_Staten);
            addQuest("Descent into Darkness", EncounterSet.TheSeatOfMorgoth, 2, 'A', null)
                .WithTextLine("When Revealed: Remove Carcharoth from play. Add Pits of Angband, Thrall Quarters, and Tunnels of Shadow to the staging area. Each player must search the encounter deck and discard pile for 1 enemy and add it to the staging area.")
                .WithOppositeTextLine("Forced: After the first Path location is explored, add Nethermost Hall to the staging area.")
                .WithOppositeTextLine("Forced: After traveling to a unique location, players raise their threat by its Threat.")
                .WithOppositeTextLine("The players cannot advance unless Nethermost Hall is in the victory display.")
                .WithInfo(127, 1, Artist.David_J_Findlay);
            addQuest("The Greatest Deed", EncounterSet.TheSeatOfMorgoth, 3, 'A', 1)
                .WithOppositeTextLine("When Revealed: Add Morgoth to the staging area and attach Silmaril to him.")
                .WithOppositeTextLine("Response: After questing successfully, you may place progress tokens on Morgoth as damage instead of placing them on the quest.")
                .WithOppositeTextLine("The players cannot advance to the next stage unless they control the Silmaril objective.")
                .WithInfo(128, 1, Artist.Stranger_To_The_Rain);
            addQuest("To See the Light", EncounterSet.TheSeatOfMorgoth, 4, 'A', 15)
                .WithTextLine("When Revealed: Remove Morgoth from play. Add Carcharoth to the staging area, removing any damage that was previously placed.")
                .WithOppositeTextLine("All enemies lose the Sneak keyword.")
                .WithOppositeTextLine("If the players defeat this stage or Carcharoth has 0 hit points, the players have won the game.")
                .WithInfo(129, 1, Artist.Pete_Amachree);
            addObjective("Silmaril", EncounterSet.TheSeatOfMorgoth)
                .WithUnique()
                .WithTraits("Item.", "Artifact.", "Silmaril.")
                .WithTextLine("Action: If Morgoth has 0 hit points, exhaust a hero to claim Silmaril.Action: Exhaust Silmaril and attached hero to either return an enemy to the staging area or reduce its Defense to 0 until the end of the round.")
                .WithInfo(130, 1, Artist.Unknown);
            addObjective("Angband Sword", EncounterSet.TheSeatOfMorgoth)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attached hero gains +5 Attack. Restricted.")
                .WithTextLine("Attached hero gains an additional +1 Attack for each resource on Angband Sword.")
                .WithTextLine("Action: Attach Angband Sword to a hero. Place 1 Corruption on that hero.Response: After attached hero deals damage, add 1 resource to Angband Sword.")
                .WithInfo(131, 1, Artist.Daniel_Ljunggren);
            addObjective("Dreadful Garments", EncounterSet.TheSeatOfMorgoth)
                .WithTraits("Disguise.")
                .WithTextLine("Action: Attach Dreadful Garments to a hero.Action: Exhaust Dreadful Garments to place 5 progress tokens on the active enemy.")
                .WithInfo(132, 1, Artist.Ted_Nasmith);
            addObjective("Element of Surprise", EncounterSet.TheSeatOfMorgoth)
                .WithTraits("Initiative.")
                .WithTextLine("Action: Attach Element of Surprise to a hero.Combat Action: Exhaust Element of Surprise. Player attacks are made before enemy attacks during this phase.")
                .WithInfo(133, 1, Artist.Kieran_Tatsue);
            addEnemy("Morgoth", EncounterSet.TheSeatOfMorgoth, 50, 8, 15, 9, 40)
                .WithUnique()
                .WithTraits("Vala.")
                .WithKeywords("Indestructible.")
                .WithTextLine("Indestructible.")
                .WithTextLine("Morgoth cannot leave the staging area and is considered to be engaged with each player.No Trap attachments can be attached to Morgoth.Forced: At the end of the round, each player must place 2 Corruption among characters he controls.")
                .WithInfo(134, 1, Artist.Gerwell);
            addEnemy("Carcharoth", EncounterSet.TheSeatOfMorgoth, 4, Card.VALUE_X, 7, 4, 15)
                .WithUnique()
                .WithTraits("Creature.", "Werewolf.")
                .WithKeywords("Relentless.", "Indestructible.")
                .WithTextLine("Relentless. Indestructible. Cannot leave play.")
                .WithTextLine("X is 5 times the number of players.")
                .WithTextLine("Forced: Players cannot reduce their threat while Carcharoth is in play.")
                .WithInfo(135, 1, Artist.Aogachou);
            addEnemy("Balrog of Angband", EncounterSet.TheSeatOfMorgoth, 37, 4, 7, 3, 22)
                .WithTraits("Balrog.")
                .WithKeywords("Sneak.")
                .WithTextLine("Sneak.")
                .WithTextLine("Forced: After an event is played, lower the engagement cost of Balrog of Angband by 20 and increase its Threat by 1 until the end of the round.")
                .WithShadow("Shadow: Discard all event cards from your hand.")
                .WithVictoryPoints(5)
                .WithInfo(136, 2, Artist.Echo539);
            addEnemy("Long-worm", EncounterSet.TheSeatOfMorgoth, 40, 5, 8, 5, 20)
                .WithTraits("Dragon.")
                .WithKeywords("Sneak.")
                .WithTextLine("Sneak.")
                .WithTextLine("Forced: When Long-worm engages a player, place 1 Corruption on the character with the lowest Willpower that he controls.")
                .WithVictoryPoints(5)
                .WithInfo(137, 2, Artist.Joas_Kleine);
            addEnemy("Fire-drake", EncounterSet.TheSeatOfMorgoth, 42, 5, 9, 5, 21)
                .WithTraits("Dragon.")
                .WithKeywords("Sneak.")
                .WithTextLine("Sneak.")
                .WithTextLine("Forced: At the beginning of the combat phase, deal 1 damage to each character controlled by the engaged player.")
                .WithShadow("Shadow: Deal 1 damage to each character controlled by the engaged player.")
                .WithVictoryPoints(5)
                .WithInfo(138, 2, Artist.Sansyu);
            addEnemy("Gothmog", EncounterSet.TheSeatOfMorgoth, 40, 5, 10, 4, 25)
                .WithUnique()
                .WithTraits("Balrog.")
                .WithKeywords("Sneak.")
                .WithTextLine("Sneak.")
                .WithTextLine("Forced: After Gothmog attacks, discard 1 attachment controlled by the defending player.")
                .WithVictoryPoints(6)
                .WithInfo(139, 1, Artist.Anja);
            addEnemy("Troll of Angband", EncounterSet.TheSeatOfMorgoth, 30, 2, 6, 3, 9)
                .WithTraits("Troll.")
                .WithKeywords("Sneak.")
                .WithTextLine("Sneak.")
                .WithTextLine("Forced: After Troll of Angband attacks, raise the defending player's threat by 3.")
                .WithShadow("Shadow: Raise the defending player's threat by 3.")
                .WithInfo(140, 3, Artist.Ben_Daugherty);
            addEnemy("Orc Captain", EncounterSet.TheSeatOfMorgoth, 28, 3, 5, 2, 6)
                .WithTraits("Orc.")
                .WithKeywords("Sneak.")
                .WithTextLine("Sneak.")
                .WithTextLine("Forced: When Orc Captain attacks, add the shadow card to the staging area if it is an enemy (ignoring any shadow effect).")
                .WithInfo(141, 2, Artist.Christian_Quinot);
            addEnemy("Angband Orc", EncounterSet.TheSeatOfMorgoth, 25, 2, 4, 1, 5)
                .WithTraits("Orc.")
                .WithKeywords("Sneak.", "Doomed 1.")
                .WithTextLine("Sneak. Doomed 1.")
                .WithTextLine("Forced: While Angband Orc is engaged with a player, raise that player's threat by an additional 1 at the end of the round.")
                .WithShadow("Shadow: Add Angband Orc to the staging area.")
                .WithInfo(142, 3, Artist.Christian_Quinot);
            addLocation("Pits of Angband", EncounterSet.TheSeatOfMorgoth, 10, 10)
                .WithUnique()
                .WithTraits("Path.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("This location does not contribute its threat while it is in the staging area.")
                .WithTextLine("Forced: The first enemy revealed each round gains surge.")
                .WithTextLine("Response: After Pits of Angband leaves play, add Angband Sword to the staging area.")
                .WithVictoryPoints(1)
                .WithInfo(143, 1, Artist.Dan_Mitchell);
            addLocation("Thrall Quarters", EncounterSet.TheSeatOfMorgoth, 5, 15)
                .WithUnique()
                .WithTraits("Path.")
                .WithTextLine("Immune to player card effects. This location does not contribute its threat while it is in the staging area.")
                .WithTextLine("Forced: While Thrall Quarters is the active location, add 1 to the Threat of discarded encounter cards when resolving a Sneak test.Response: After Thrall Quarters leaves play, add Dreadful Garments to the staging area.")
                .WithVictoryPoints(1)
                .WithInfo(144, 1, Artist.Clive_Lauzon);
            addLocation("Tunnels of Shadow", EncounterSet.TheSeatOfMorgoth, 1, 20)
                .WithUnique()
                .WithTraits("Path.")
                .WithTextLine("Immune to player card effects. This location does not contribute its threat while it is in the staging area.")
                .WithTextLine("Forced: While Tunnels of Shadow is the active location, the encounter deck is shuffled before discarding cards for a Sneak test.Response: After Tunnels of Shadow leaves play, add Element of Surprise to the staging area.")
                .WithVictoryPoints(1)
                .WithInfo(145, 1, Artist.Rebekah_Burlew);
            addLocation("Labyrinthine Stairs", EncounterSet.TheSeatOfMorgoth, 2, 6)
                .WithTraits("Underground.")
                .WithTextLine("Forced: After putting any amount of progress on Labyrinthine Stairs, discard the top card of the encounter deck. If it is a location, add it to the staging area.")
                .WithShadow("Shadow: If this attack destroys a character, return the active location to the staging area.")
                .WithInfo(146, 3, Artist.Neal_Hanson);
            addLocation("Torturer's Dungeon", EncounterSet.TheSeatOfMorgoth, 2, 4)
                .WithTraits("Chamber.")
                .WithTextLine("Forced: If there is no active location and you have the option to travel, you must either travel to Torturer's Dungeon or place 1 Corruption on each hero.Travel: Each player must search the encounter deck and discard pile for an enemy and put it into play engaged with him.")
                .WithInfo(147, 1, Artist.Dardagan);
            addLocation("Echoing Corridor", EncounterSet.TheSeatOfMorgoth, 4, 3)
                .WithTraits("Underground.")
                .WithTextLine("Forced: At the beginning of the staging step, players must raise their threat by the number of characters they committed to the quest while Echoing Corridor is the active location.")
                .WithShadow("Shadow: Raise the threat of the defending player by the Threat of the attacking enemy.")
                .WithInfo(148, 2, Artist.Robert_Ryminiecki);
            addLocation("Subterranean Furnace", EncounterSet.TheSeatOfMorgoth, 3, 4)
                .WithTraits("Underground.")
                .WithTextLine("Forced: While Subterranean Furnace is the active location, each player must discard a random card from his hand at the end of the round.")
                .WithInfo(149, 2, Artist.Unknown);
            addLocation("Trackless Cavern", EncounterSet.TheSeatOfMorgoth, 1, 8)
                .WithTraits("Underground.", "Dark.")
                .WithTextLine("Response: After Trackless Cavern leaves play, each player reduces his threat by 5.")
                .WithInfo(150, 2, Artist.Steven_Schreiner);
            addLocation("Orc Armory", EncounterSet.TheSeatOfMorgoth, 3, 3)
                .WithTraits("Armory.")
                .WithTextLine("While Orc Armory is the active location, all enemies lose the Sneak keyword.Response: After Orc Armory is explored as the active location, the first player attaches it to a hero. The attached hero gains +1 Attack and +1 Defense.")
                .WithShadow("Shadow: The attacking enemy gets +1 Attack and +1 Defense until the end of the phase.")
                .WithInfo(151, 2, Artist.Atomhawk);
            addLocation("Nethermost Hall", EncounterSet.TheSeatOfMorgoth, 5, 7)
                .WithUnique()
                .WithTraits("Throne Room.")
                .WithTextLine("Immune to player card effects.\r\nForced: After Nethermost Hall is explored as the active location, advance to stage 3.")
                .WithTextLine("")
                .WithTextLine("Travel: Search the encounter deck and discard pile for Gothmog and add him to the staging area, if able.")
                .WithShadow("Shadow: The attacking enemy gets +1 Attack and +1 Defense until the end of the phase.")
                .WithVictoryPoints(2)
                .WithInfo(152, 1, Artist.Unknown);
            addTreachery("Devouring Spirit", EncounterSet.TheSeatOfMorgoth)
                .WithTraits("Condition.")
                .WithTextLine("When Revealed: Attach to the enemy in play with the lowest Threat. Attached enemy gets +1 Threat, +1 Attack, +1 Defense, and +3 hit points. If there are no enemies in play, Devouring Spirit gains surge.")
                .WithInfo(153, 2, Artist.Sarah_Finnigan);
            addTreachery("Clumsy Step", EncounterSet.TheSeatOfMorgoth)
                .WithTraits("Noise.")
                .WithKeywords("Doomed 2.")
                .WithTextLine("Doomed 2.")
                .WithTextLine("When Revealed: Discard an additional encounter card when resolving Sneak tests this round. If there is no active enemy, Clumsy Step gains surge.")
                .WithInfo(154, 3, Artist.Sam_R_Kennedy);
            addTreachery("Foolish Ruckus", EncounterSet.TheSeatOfMorgoth)
                .WithTraits("Noise.")
                .WithTextLine("When Revealed: Raise the Threat of the active enemy by 3 until the end of the phase. If there is no active enemy, raise the Threat of all enemies in the staging area by 1 until the end of the phase.")
                .WithShadow("Shadow: If this attack destroys a character, raise the defending player's threat by 2.")
                .WithInfo(155, 3, Artist.Unknown);
            addTreachery("Filth and Desolation", EncounterSet.TheSeatOfMorgoth)
                .WithTextLine("When Revealed: Each player must either deal 1 damage to each character he committed to the quest or reduce the Willpower of each character he controls by 1 until the end of the round.")
                .WithShadow("Shadow: Exhaust a character that the defending player controls.")
                .WithInfo(156, 2, Artist.Aledin);
            addTreachery("Heroic Diversion", EncounterSet.TheSeatOfMorgoth)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Each player must either discard 1 character or raise his threat by 5.")
                .WithInfo(157, 3, Artist.Jenny_Dolfen);
            addTreachery("Evil Lust", EncounterSet.TheSeatOfMorgoth)
                .WithTraits("Condition.")
                .WithTextLine("When Revealed: Attach to a hero. (Counts as a Condition attachment with the text: 'This hero must be declared as the defender against Morgoth (even if exhausted). Morgoth uses his Threat to attack and the attached hero uses his Willpower to defend. Limit 1 per hero.')")
                .WithInfo(158, 2, Artist.Andreas_Marschall);
            addEvent("Dark Elf", 0, Sphere.Mastery)
                .WithTextLine("Action: Place X Corruption on heroes you control to draw X cards. (X cannot be greater than the number of heroes you control.)")
                .WithInfo(159, 0, Artist.Ted_Nasmith);
            addAlly("Haladin Woodsman", 2, Sphere.Spirit, false, 1, 1, 2, 2)
                .WithTraits("Edain.", "House of Haleth.")
                .WithTextLine("Response: After a shadow effect resolves on an enemy engaged with you, Haladin Woodsman gets +1 Attack and +1 Defense until the end of the round. (Limit twice per round.)")
                .WithInfo(160, 0, Artist.Deelane);
            addAttachment("Aranrúth", 2, Sphere.Mastery, true)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero with a printed Mastery icon. Restricted.")
                .WithTextLine("Action: Exhaust Aranrúth to give attached hero a Leadership, Lore, Tactics, or Spirit icon until the end of the phase.")
                .WithTextLine("If attached hero is Thingol, Aranrúth gains, 'Attached hero gets +2 Attack.'")
                .WithInfo(161, 0, Artist.Mathieu_Degrotte);
            addQuest("Ride Forth in the Morning", EncounterSet.HuntingOfTheWolf, 1, 'A', 20)
                .WithTextLine("Setup: Place Carcharoth the Tormented and Gates of Menegroth aside, out of play. Shuffle all other copies of Carcharoth into a Carcharoth deck. Each player must search the encounter deck for 1 different location and add it to the staging area. Put the Beleg Strongbow objective ally into play.")
                .WithOppositeTextLine("Forced: After a location is destroyed, place 1 damage on this quest stage. After the 10th damage is placed on this stage, advance to stage 3.")
                .WithOppositeTextLine("Forced: If there is no location in play at the end of the round, the first player must search the encounter deck and discard pile for 1 location and add it to the staging area.")
                .WithOppositeTextLine("Players cannot advance to stage 2 unless Carcharoth has at least 10 damage on him.")
                .WithInfo(162, 1, Artist.Anke_Eissmann);
            addQuest("At Last Upon the Wolf", EncounterSet.HuntingOfTheWolf, 2, 'A', null)
                .WithTextLine("When Revealed: Remove Carcharoth from play and put the Carcharoth deck aside. Add Carcharoth the Tormented to the staging area. Remove half of the damage on Carcharoth (rounding up).")
                .WithOppositeTextLine("When Revealed: Discard all Hunt locations from the victory display.")
                .WithOppositeTextLine("Forced: If an ally is destroyed by Carcharoth, place 1 damage on this stage. After the 4th damage is placed on this stage, reset the quest deck to stage 1A and follow the setup instructions again.")
                .WithOppositeTextLine("If Carcharoth the Tormented is destroyed, you have recovered the Silmaril and won the game.")
                .WithInfo(163, 1, Artist.Unknown);
            addQuest("Ruin Upon the World", EncounterSet.HuntingOfTheWolf, 3, 'A', null)
                .WithTextLine("When Revealed: Gates of Menegroth becomes the active location, moving any previous active location to the staging area.")
                .WithOppositeTextLine("Siege.")
                .WithOppositeTextLine("Forced: Reveal 1 additional encounter card from the encounter deck each quest phase.")
                .WithOppositeTextLine("Forced: After Gates of Menegroth is explored as the active location, reset the quest deck to stage 1B.")
                .WithOppositeTextLine("If Gates of Menegroth is destroyed, the players lose the game.")
                .WithInfo(164, 1, Artist.Steamey);
            addObjective("Beleg Strongbow", EncounterSet.HuntingOfTheWolf)
                .WithUnique()
                .WithTraits("Teleri.")
                .WithTextLine("The first player gains control of Beleg Strongbow.Action: Exhaust Beleg Strongbow to remove 2 damage from a location in play.")
                .WithInfo(165, 1, Artist.BrokenMachine86);
            addEnemy("Carcharoth the Red Maw", EncounterSet.HuntingOfTheWolf, 50, 5, 6, 7, 20)
                .WithUnique()
                .WithTraits("Creature.", "Werewolf.")
                .WithKeywords("Indestructible.")
                .WithTextLine("Indestructible. Immune to player card effects.")
                .WithTextLine("Forced: While Carcharoth the Red Maw is in the staging area, he attacks a random location in play during the combat phase (the first player may declare a defender if it is the active location).")
                .WithTextLine("Forced: Caracharoth the Red Maw makes two attacks during the combat phase. (Deal a separate shadow card for each attack.)")
                .WithInfo(166, 3, Artist.WavingMonsterStudios);
            addEnemy("Carcharoth the Wolf of Angband", EncounterSet.HuntingOfTheWolf, 50, 6, 5, 8, 20)
                .WithUnique()
                .WithTraits("Creature.", "Werewolf.")
                .WithKeywords("Indestructible.")
                .WithTextLine("Indestructible. Immune to player card effects.")
                .WithTextLine("Forced: While Carcharoth the Wolf of Angband is in the staging area, he attacks a random location in play during the combat phase (the first player may declare a defender if it is the active location).")
                .WithTextLine("When Revealed: Add 1 damage to the current quest stage.")
                .WithInfo(167, 3, Artist.Razielmn);
            addEnemy("Carcharoth the Devouring Spirit", EncounterSet.HuntingOfTheWolf, 50, 4, 8, 6, 20)
                .WithUnique()
                .WithTraits("Creature.", "Werewolf.")
                .WithKeywords("Indestructible.")
                .WithTextLine("Indestructible. Immune to player card effects.")
                .WithTextLine("Forced: While Carcharoth the Devouring Spirit is in the staging area, he attacks a random location in play during the combat phase (the first player may declare a defender if it is the active location).")
                .WithTextLine("When Revealed: Carcharoth the Devouring Spirit makes an immediate attack on the first player.")
                .WithInfo(168, 3, Artist.Nasko_Moskov);
            addEnemy("Carcharoth the Tormented", EncounterSet.HuntingOfTheWolf, 1, 6, 9, 9, 25)
                .WithUnique()
                .WithTraits("Creature.", "Werewolf.")
                .WithKeywords("Relentless.")
                .WithTextLine("Relenthless. Cannot leave play.")
                .WithTextLine("Forced: Carcharoth the Tormented engages the first player during the encounter phase.")
                .WithTextLine("Forced: After an attack by Carcharoth the Tormented resolves, discard one character the defending player controls.")
                .WithInfo(169, 1, Artist.Dechambo);
            addLocation("Taur-nu-Fuin", EncounterSet.HuntingOfTheWolf, 4, 2)
                .WithTraits("Forest.", "Dark.")
                .WithKeywords("Hunt 2.")
                .WithTextLine("Hunt 2.")
                .WithTextLine("Travel: Each player places the top card of his deck face down in front of him as if it just engaged him from the staging area. These cards are called 'Phantom' and act as enemies with: 3 hit points, 4 Attack, and 1 Defense.")
                .WithInfo(170, 2, Artist.Darek_Zabrocki);
            addLocation("Pass of Anach", EncounterSet.HuntingOfTheWolf, 3, 4)
                .WithUnique()
                .WithTraits("Mountain.")
                .WithKeywords("Hunt 2.")
                .WithTextLine("Hunt 2.")
                .WithTextLine("Travel: Each player must discard 1 character he controls.")
                .WithInfo(171, 1, Artist.Ferdinand_Dumago_Ladera);
            addLocation("Dimbar Field", EncounterSet.HuntingOfTheWolf, 2, 5)
                .WithTraits("Plain.")
                .WithKeywords("Hunt 1.")
                .WithTextLine("Hunt 1.")
                .WithTextLine("While Dimbar Field is the active location, all heroes gain ranged.")
                .WithTextLine("Travel: Discard all allies in each player's hand.")
                .WithShadow("Shadow: The attacking enemy makes an additional attack after this one.")
                .WithInfo(172, 2, Artist.Bobby_Fieldhouse);
            addLocation("Brethil Dwelling", EncounterSet.HuntingOfTheWolf, 3, 5)
                .WithTraits("Outpost.")
                .WithKeywords("Hunt 2.")
                .WithTextLine("Hunt 2.")
                .WithTextLine("Forced: After Brethil Dwelling is destroyed, each player must deal 3 Corruption among heroes he controls.")
                .WithInfo(173, 3, Artist.Unknown);
            addLocation("Eaves of Region", EncounterSet.HuntingOfTheWolf, 2, 3)
                .WithTraits("Forest.")
                .WithKeywords("Hunt 1.")
                .WithTextLine("Hunt 1.")
                .WithTextLine("While Eaves of Region is the active location, Carcharoth takes 1 damage at the end of the round.")
                .WithTextLine("Travel: Each player must discard 1 random card from his hand.")
                .WithShadow("Shadow: Either destroy a location in play or choose a new defender. (You may choose a location that is the target of this attack.)")
                .WithInfo(174, 3, Artist.FrozenStocks);
            addLocation("Banks of the Esgalduin", EncounterSet.HuntingOfTheWolf, 2, 5)
                .WithTraits("River.", "Water.")
                .WithKeywords("Hunt 1.")
                .WithTextLine("Hunt 1.")
                .WithTextLine("Forced: If Banks of the Esgalduin is destroyed, remove 5 damage from Carcharoth.Travel: Each player must discard an attachment he controls.")
                .WithInfo(175, 2, Artist.Ao_Yi_Chuan);
            addLocation("Neldoreth Settlement", EncounterSet.HuntingOfTheWolf, 3, 6)
                .WithTraits("Outpost.")
                .WithKeywords("Hunt 2.")
                .WithTextLine("Hunt 2.")
                .WithTextLine("Forced: If Neldoreth Settlement is destroyed, deal 1 Corruption to each character in play.")
                .WithShadow("Shadow: If the defending character or location is destroyed, exhausted characters do not ready at the end of the round.")
                .WithInfo(176, 3, Artist.Ron_Crabb);
            addLocation("Iant Iaur", EncounterSet.HuntingOfTheWolf, 5, 4)
                .WithUnique()
                .WithTraits("Bridge.", "Water.")
                .WithKeywords("Hunt 1.")
                .WithTextLine("Hunt 1.")
                .WithTextLine("Forced: After Iant Iaur is destroyed, add 1 damage to the current quest stage.Response: After Iant Iaur is added to the victory display, remove 1 damage from the current quest stage.")
                .WithInfo(177, 1, Artist.Nimarra);
            addLocation("Gates of Menegroth", EncounterSet.HuntingOfTheWolf, 4, 10)
                .WithUnique()
                .WithTraits("Fortification.")
                .WithTextLine("Forced: If Gates of Menegroth is destroyed, the players lose the game.")
                .WithInfo(178, 1, Artist.Ilya_Nazarov);
            addLocation("Dark Valley", EncounterSet.HuntingOfTheWolf, 2, 6)
                .WithUnique()
                .WithTraits("Valley.", "Water.")
                .WithKeywords("Hunt 3.")
                .WithTextLine("Hunt 3.")
                .WithTextLine("While Dark Valley is the active location, you may choose which Carcharoth is revealed at the beginning of the quest phase. Shuffle the Carcharoth deck.")
                .WithTextLine("Travel: Carcharoth makes an immediate attack against the first player.")
                .WithInfo(179, 2, Artist.Albert_Bierstadt);
            addTreachery("Evil Days", EncounterSet.HuntingOfTheWolf)
                .WithTextLine("When Revealed: Each player must either deal 1 damage to each location in play or deal 1 Corruption to each character he controls.")
                .WithInfo(180, 3, Artist.Justin_Gerard);
            addTreachery("Stood Now in Wrath", EncounterSet.HuntingOfTheWolf)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Discard Carcharoth and reveal and add the next card from the Carcharoth deck.")
                .WithShadow("Shadow: The attacking enemy gets +1 Attack. (+3 Attack instead if the attacking enemy has more than 5 damage on him.)")
                .WithInfo(181, 2, Artist.HazelFibonacci);
            addTreachery("Fled in Fear", EncounterSet.HuntingOfTheWolf)
                .WithTextLine("When Revealed: Remove all allies from the quest. Allies cannot be declared as attackers or defenders until the end of the round.")
                .WithShadow("Shadow: Allies cannot participate in an attack against the attacking enemy this round.")
                .WithInfo(182, 3, Artist.Ted_Nasmith);
            addTreachery("A Doom Fulfilled", EncounterSet.HuntingOfTheWolf)
                .WithTraits("Doom.")
                .WithTextLine("When Revealed: Attach to Carcharoth as a Condition attachment with the text, 'After an attack against Carcharoth resolves, discard one character that participated in the attack and discard A Doom Fulfilled.'")
                .WithShadow("Shadow: The attacking enemy cannot be damaged this turn unless the defending player discards one character.")
                .WithInfo(183, 3, Artist.Ted_Nasmith);
            addTreachery("Flame of Anguish", EncounterSet.HuntingOfTheWolf)
                .WithTextLine("When Revealed: Remove 5 damage from Carcharoth and assign it to characters the first player controls. If Carcharoth has no damage, Flame of Anguish gains surge.")
                .WithShadow("Shadow: Remove 5 damage from the attacking enemy.")
                .WithInfo(184, 3, Artist.Ted_Nasmith);
            addTreachery("Espied from Afar", EncounterSet.HuntingOfTheWolf)
                .WithTextLine("When Revealed: The players must either discard the location in the victory display with the highest Hunt value or prevent all exhausted characters from readying during the refresh phase this round.")
                .WithInfo(185, 2, Artist.Unknown);
            addTreachery("Devil's Cunning", EncounterSet.HuntingOfTheWolf)
                .WithTextLine("When Revealed: Carcharoth makes an immediate attack on the player with the most Willpower committed to the quest.")
                .WithInfo(186, 3, Artist.Igor_Kordey);
        }
    }
}
