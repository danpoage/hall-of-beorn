/* Generated CardSet class: Roam Across Rhovanion */

using System;

namespace HallOfBeorn.Models.LotR.Sets.EredMithrin
{
    public class RoamAcrossRhovanionSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Roam Across Rhovanion";
            Abbreviation = "RAR";
            Number = 51;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Ered Mithrin";

            addHero("Haldan", 10, Sphere.Lore, 2, 3, 1, 4)
                .WithTraits("Woodman.", "Scout.")
                .WithTextLine("While the active location has an attachment on it, Haldan does not exhaust to quest.")
                .WithTextLine("Response: When the active location is explored, draw 1 card for each attachment on it.")
                .WithCommunityVersion("Autumn/Haldan")
                .WithInfo(26, 1, Artist.Alexander_Kozachenko);
            addAlly("Wiglaf", 5, Sphere.Leadership, true, 2, 2, 1, 3)
                .WithTraits("Dale.", "Scout.", "Warrior.")
                .WithTextLine("Response: After you play Wiglaf, play an Item attachment on him from your hand for no cost.")
                .WithTextLine("Action: Exhaust an attachment on Wiglaf to ready him. (Limit once per phase.)")
                .WithInfo(27, 3, Artist.Aleksander_Karcz);
            addAttachment("Ancestral Armor", 4, Sphere.Leadership, false)
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Leadership or Noble character. Restricted. Limit 1 per character")
                .WithTextLine("Attached character gets +2 Defense and +2 hit points.")
                .WithTemplate("<p class='main-text'>Attach to a {sphere:Leadership} or {trait:Noble.@Noble} character. {keyword:Restricted.} Limit 1 per character.</p><p>Attached character gets +2 {Defense} and +2 hit points.</p><p class='flavor-text'>&ldquo;May it keep you well!&rdquo; said Théoden. &ldquo;It was made for me in Thengel's day, while still I was a boy.&rdquo; &ndash;The Two Towers</p>")
                .WithInfo(28, 3, Artist.Aleksander_Karcz);
            addAttachment("Glamdring", 1, Sphere.Lore, true)
                .WithTraits("Artifact.", "Item.", "Weapon.")
                .WithKeywords("Guarded (enemy or location).", "Restricted.")
                .WithTextLine("Attach to a hero or Gandalf. Restricted.")
                .WithTextLine("Attached character gets +2 Attack.")
                .WithTextLine("Response: After attached character destroys an enemy, draw 1 card.")
                .WithTemplate("<p class='main-text'>{keyword:Guarded (enemy or location).}</p><p class='main-text'>Attach to a hero or {title:Gandalf}. {keyword:Restricted.}</p><p class='main-text'>Attached character gets +2 {Attack}.</p><b>Response:</b> After attached character destroys an enemy, draw 1 card.</p>")
                .WithAges(Age.First_Age, Age.Second_Age, Age.Third_Age)
                .WithInfo(29, 3, Artist.Tropa_Entertainment);
            addAttachment("Woodmen's Path", 1, Sphere.Lore, false)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a location with no progress tokens on it.")
                .WithTextLine("While attached location is the active location, reduce its quest point value to 1.")
                .WithFlavorLine("It was a path made by strong arms and heavy feet.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(30, 3, Artist.Leanna_Crossan);
            addAlly("Meneldor", 3, Sphere.Tactics, true, 2, 2, 1, 2)
                .WithTraits("Creature.", "Eagle.")
                .WithTextLine("Cannot have restricted attachments.")
                .WithTextLine("Response: After Meneldor enters or leaves play, place 2 progress on a location.")
                .WithFlavorLine("...Meneldor young and swift. -The Return of the King")
                .WithInfo(31, 3, Artist.Dmitry_Prosvirnin);
            addEvent("Flight of the Eagles", 0, Sphere.Tactics)
                .WithTextLine("Action: Return an Eagle ally to your hand to shuffle a set-aside ~Eagle of the North into the encounter deck. Then, remove Flight of the Eagles from the game.")
                .WithFlavorLine("Behind them in long swift lines came all their vassals from the northern mountains, speeding on a gathering wind.")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(32, 3, Artist.Carlos_Palma_Cruchaga);
            addAlly("Wild Stallion", 2, Sphere.Spirit, false, 1, 1, 1, 1)
                .WithTraits("Creature.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Planning Action: Attach Wild Stallion to an ally you control. (Counts as a Mount attachment with the text: \"Restricted. Limit 1 per ally. Attached ally gets +1 Willpower, +1 Attack, +1 Defense, and +1 hit point.\")")
                .WithInfo(33, 3, Artist.Carlos_Palma_Cruchaga);
            addEvent("South Away!", 0, Sphere.Spirit)
                .WithTraits("Song.")
                .WithTextLine("Travel Action: Choose a location in the staging area with a player card attachment and make it the active location, returning any previous active location to the staging area. Reduce each player's threat by X, where X is the number of attachments on the active location.")
                .WithFlavorLine("South away! and South away!")
                .WithFlavorLine("Seek the sunlight and the day.")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(34, 3, Artist.Yoann_Boissonnet);
            addAlly("Eagle of the North", 255, Sphere.Neutral, false, 2, 3, 1, 3)
                .WithTraits("Creature.", "Eagle.")
                .WithKeywords("Encounter.", "Surge.")
                .WithTextLine("Encounter. Surge.")
                .WithTextLine("Cannot have restricted attachments.")
                .WithTextLine("When Revealed: The first player chooses a player to take control of Eagle of the North. The chosen player may choose and discard a non-unique enemy in the staging area.")
                .WithTemplate("<p class='main-text'>{keyword:Encounter.} {keyword:Surge.}</p><p class='main-text'>Cannot have restricted attachments.</p><p class='main-text'><b>When Revealed:</b> The first player chooses a player to take control of {self}. The chosen player may choose and discard a non-unique enemy in the staging area.</p>")
                .WithInfo(35, 3, Artist.Alvaro_Calvo_Escudero);
            addObjective("Durin's Key", EncounterSet.RoamAcrossRhovanion)
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithTextLine("While Durin's ~Key is free of encounters, the first player attached it to a hero he controls.")
                .WithTextLine("Action: Exhaust Durin's ~Key to give each location -1 Threat until the end of the phase.")
                .WithTextLine("Forced: At the beginning of the quest phase, the player who controls Durin's Key looks at the top 3 cards of the encounter deck, chooses 1 to reveal, and discards the rest.")
                .WithInfo(36, 1, Artist.Igor_Burlakov);
            addObjective("Urdug's Horn", EncounterSet.RoamAcrossRhovanion)
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithTextLine("While Urdug's Horn is free ot encounters attack it to Urdug.")
                .WithTextLine("Forced: When Urdug attacks, discard the top card of the encounter deck and add it's Threat to his Attack until the end of the phase.")
                .WithInfo(37, 1, Artist.Sebastian_Zakrzewski);
            addEnemy("Grey Mountain Giant", EncounterSet.RoamAcrossRhovanion, 44, 2, 5, 2, 11)
                .WithTraits("Giant.")
                .WithTextLine("Cannot have non-objective attachments.")
                .WithTextLine("Forced: When Grey Mountain Giant engages you, discard the top 5 cards of your deck. Assign damage among characters you control equal to the number of allies discarded by this effect.")
                .WithEasyModeQuantity(1)
                .WithInfo(38, 2, Artist.Sebastian_Zakrzewski);
            addEnemy("Hunting Eagle", EncounterSet.RoamAcrossRhovanion, 50, 1, 3, 1, 3)
                .WithTraits("Creature.", "Eagle.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge. Cannot be optionally engaged.")
                .WithTextLine("Forced: When the encounter phase begins, Hunting Eagle engages the first player.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if attacking enemy has the Creature trait).")
                .WithEasyModeQuantity(2)
                .WithInfo(39, 3, Artist.Carlos_Palma_Cruchaga);
            addEnemy("Wilderland Bear", EncounterSet.RoamAcrossRhovanion, 30, 3, 4, 1, 5)
                .WithTraits("Creature.")
                .WithTextLine("When Revealed: The first player must choose: either Wilderland Bear makes an immediate attack against him, or each player discards 1 random card from his hand.")
                .WithInfo(40, 2, Artist.Brendan_C_Murphy);
            addLocation("Grey Moorland", EncounterSet.RoamAcrossRhovanion, 3, 4)
                .WithTraits("Hills.")
                .WithTextLine("Forced: After Grey Moorland becomes the active location, shuffle the encounter discard pile into the encounter deck and discard cards from it until a treachery is discarded. Resolve the 'When Revealed' effect on that treachery.")
                .WithShadow("Shadow: Return attacking enemy to the staging area after this attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(41, 2, Artist.Matthew_Cowdery);
            addLocation("Deep Ravine", EncounterSet.RoamAcrossRhovanion, 2, 3)
                .WithTraits("Hills.")
                .WithTextLine("While ~Deep Ravine is in the staging area, no more than 1 progress can be placed on locations in the staging area each round.")
                .WithTextLine("Travel: The first player must either exhaust Urdug, or raise each player's threat by 2 to travel here.")
                .WithEasyModeQuantity(2)
                .WithInfo(42, 3, Artist.Derek_D_Edgell);
            addLocation("Slopes of Ered Mithrin", EncounterSet.RoamAcrossRhovanion, 2, 4)
                .WithTraits("Hills.")
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("Response: After the players travel to Slopes of Ered Mithrin, the first player may ready a character he controls.")
                .WithShadow("Shadow: If the first player controls Urdug, exhaust him.")
                .WithInfo(43, 3, Artist.Yog_Joshi);
            addTreachery("Sneaking Off", EncounterSet.RoamAcrossRhovanion)
                .WithTextLine("When Revealed: The first player loses control of Urdug, then attach Urdug to a location in the staging area as a guarded objective. If he cannot, add 5 to the total Threat in the staging area until the end of the phase. In either case, remove Sneaking Off from the game.")
                .WithEasyModeQuantity(1)
                .WithInfo(44, 3, Artist.Ivan_Dixon);
            addTreachery("Harsh Weather", EncounterSet.RoamAcrossRhovanion)
                .WithTraits("Weather.")
                .WithTextLine("When Revealed: For each ready character a player controls, he must choose: either exhaust that character or raise his threat by 1.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, exhaust a character you control.")
                .WithInfo(45, 3, Artist.Tyler_Edlin);
            addTreachery("Wild Creatures", EncounterSet.RoamAcrossRhovanion)
                .WithTextLine("When Revealed: Starting with the first player, each player chooses an enemy in the staging area and engages it. Then, if any player did not engage an enemy this way, discard cards from the encounter deck until a Creature enemy is discarded and add it to the staging area.")
                .WithInfo(46, 2, Artist.Carlos_Palma_Cruchaga);
            addQuest("The Goblin's Task", EncounterSet.RoamAcrossRhovanion, 1, 'A', Card.VALUE_NA)
                .WithTextLine("Setup: The first player takes control of Urdug, objective side face-up. Set each other objective and objective-ally aside, out of play. Shuffle the encounter deck and discard cards from the top until X locations are discarded, where X is the number of players. Add each discarded location to the staging area.")
                .WithFlavorLine("The Goblin, Urdug, has agreed to show you a secret entrance to Mount Gundabad, but only if you help him recover some things he lost in Rhovanion.")
                .WithOppositeTextLine("Progress cannot be placed on locations in the staging area.")
                .WithOppositeTextLine("Forced: When the active location is explored, if the first player controls Urdug, advance to a random stage 2A.")
                .WithOppositeFlavorLine("You have agreed to help the Goblin in return for his assistance, but you keep a wary eye on him all the same.")
                .WithIncludedEncounterSets(EncounterSet.FellBeasts, EncounterSet.LostInWilderland, EncounterSet.HillsOfWilderland)
                .WithInfo(47, 1, Artist.Marius_Bota);
            addQuest("Rescue Tiny", EncounterSet.RoamAcrossRhovanion, 2, 'A', 5)
                .WithTextLine("The 'when revealed' effects of treachery cards cannot be canceled.")
                .WithTextLine("Forced: When the players defeat this stage, remove it from the game. Advance to a random stage 2A, if able. Otherwise, advance to stage 3A.")
                .WithTextLine("The players cannot travel to the Grey Moorland guarding Tiny unless there is at least 5 progress on this stage. This stage cannot be defeated unless the first player controls Urdug and Tiny.")
                .WithFlavorLine("Urdug's friend, Tiny, turns out to be an enormous Hill-troll. You find him trapped in a deep bog and Urdug begs you to help rescue him.")
                .WithIncludedEncounterSets(EncounterSet.FellBeasts, EncounterSet.LostInWilderland, EncounterSet.HillsOfWilderland)
                .WithInfo(48, 1, Artist.Guillaume_Ducos);
            addQuest("Retrieve Urdug's Horn", EncounterSet.RoamAcrossRhovanion, 2, 'A', 5)
                .WithTextLine("When Revealed: The first player searches the encounter deck, discard pile, and victory display for a Grey Mountain Giant, adds it to the staging area, and attaches the set-aside Urdug's Horn to it as a guarded objective. Shuffle the encounter deck. Each other player reveals an encounter card.")
                .WithFlavorLine("You thought Urdug's story about being chased by a Giant sounded funny until you come upon a mean-looking Giant using the Goblin's horn as a tooth-pick. Urdug insists he won't lead you anywhere without that horn.")
                .WithOppositeTextLine("Each enemy with 1 or more guarded attachments gets +2 Threat and +2 Defense.")
                .WithOppositeTextLine("Forced: When the players defeat this stage, remove it from the game. Advance to a random stage 2A, if able. Otherwise, advane to stage 3A.")
                .WithOppositeTextLine("The Grey Mountain Giant guarding Urdug's Horn cannot take damage unless there is at least 5 progress on this stage. This stage cannot be defeated unless the first player controls Urdug with Urdug's Horn attached.")
                .WithIncludedEncounterSets(EncounterSet.FellBeasts, EncounterSet.LostInWilderland, EncounterSet.HillsOfWilderland)
                .WithInfo(49, 1, Artist.Sebastian_Zakrzewski);
            addQuest("Find Durin's Key", EncounterSet.RoamAcrossRhovanion, 2, 'A', 5)
                .WithTextLine("When Revealed: The first player searches the encounter deck, discrd pile, and victory display for a Deep Ravine, adds it to the staging area, and attaches the set-aside Durin's ~Key to it as a guarded objective. Shuffle the encounter deck. Each player reveals an encounter card.")
                .WithFlavorLine("You have your doubts about Durin's Key, as well as Urdug, but the Goblin insists he dropped it in a ravine as he was fleeing for his life. You follow him as he retraces his steps back to the ravine.")
                .WithOppositeTextLine("Each encounter card guarding a card is immune to player card effects.")
                .WithOppositeTextLine("Forced: When the players defeat this stage, remove it from the game. Advance to a random stage 2A, if able. Otherwise, advance to stage 3A.")
                .WithOppositeTextLine("The players cannot travel to the Deep Ravine guarding Durin's Key unless there is at least 5 progress on this stage. This stage cannot be defeated unless the players control Urdug and Durin's ~Key.")
                .WithIncludedEncounterSets(EncounterSet.FellBeasts, EncounterSet.LostInWilderland, EncounterSet.HillsOfWilderland)
                .WithInfo(50, 1, Artist.Leanna_Crossan);
            addQuest("Urdug's Gambit", EncounterSet.RoamAcrossRhovanion, 3, 'A', 5)
                .WithTextLine("When Revealed:  The first player loses control of both Urdug and Tiny, flips them to their enemy sides, and adds them to the staging area. (Remove any damage that was one them.) Each other player reveals an encounter card.")
                .WithFlavorLine("You suspected Urdug would betray you once you gathered the things he required, so you're not surprised when he and Tiny try to sneak away in the night. Urdug hisses at Tiny to keep quiet, but the lumbering Troll is about as subtle as a thunder storm. You grab your weapons and chase after them.")
                .WithOppositeTextLine("Progress cannot be placed on this quest from questing successfully.")
                .WithOppositeTextLine("Forced: When the players quest unsuccessfully, they do not raise their threat. Instead, place X progress here, where X is the amount by which they would have raised their threat. Then, if this stage has progress equal to its quest points, the player lose the game.")
                .WithOppositeTextLine("When Urdug has no hit points remaining, the players win the game.")
                .WithIncludedEncounterSets(EncounterSet.FellBeasts, EncounterSet.LostInWilderland, EncounterSet.HillsOfWilderland)
                .WithInfo(51, 1, Artist.Ivan_Dixon);
            addObjectiveAlly("Urdug", EncounterSet.RoamAcrossRhovanion, 2, 3, 2, 5)
                .WithUnique()
                .WithSlugSuffix("Objective-Ally")
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("While Urdug is free of encounters, the first player gains control of Urdug.")
                .WithTextLine("If Urdug is destroyed, the players lose the game.")
                .WithInfo(52, 1, Artist.Ivan_Dixon);
            addEnemy("Urdug", EncounterSet.RoamAcrossRhovanion, 15, 2, 3, 2, 5)
                .WithUnique()
                .WithSlugSuffix("Enemy")
                .WithTraits("Goblin.", "Orc.")
                .WithKeywords("Indestructible.")
                .WithTextLine("Indestructible. Immune to player card effects.")
                .WithTextLine("While Urdug is engaged with a player, he gains, \"Forced: At the beginning of the quest phase, Urdug makes an immediate attack. If this attack deals damage, return Urdug and Tiny (if he is in play) to the staging area.\"")
                .WithSideB()
                .WithInfo(53, 1, Artist.Ivan_Dixon);
            addObjectiveAlly("Tiny", EncounterSet.RoamAcrossRhovanion, 1, 6, 3, 9)
                .WithUnique()
                .WithSlugSuffix("Objective-Ally")
                .WithTraits("Troll.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("While Tiny is free of encounters, the first player gains control of Tiny.")
                .WithTextLine("Forced: After Tiny exhausts, raise your threat by 2.")
                .WithTextLine("If Tiny is destroyed, the players lose the game.")
                .WithInfo(54, 1, Artist.Guillaume_Ducos);
            addEnemy("Tiny", EncounterSet.RoamAcrossRhovanion, 50, 1, 6, 3, 9)
                .WithUnique()
                .WithSlugSuffix("Enemy")
                .WithTraits("Troll.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Urdug cannot take damage.")
                .WithTextLine("Forced: After Urdug engages a player, Tiny engages that player.")
                .WithVictoryPoints(6)
                .WithSideB()
                .WithInfo(55, 1, Artist.Guillaume_Ducos);
        }
    }
}
