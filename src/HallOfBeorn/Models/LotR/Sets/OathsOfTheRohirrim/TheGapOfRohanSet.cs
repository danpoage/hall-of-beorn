//CardSet: The Gap of Rohan
/* Generated CardSet class: The Gap of Rohan */

using System;

namespace HallOfBeorn.Models.LotR.Sets.OathsOfTheRohirrim
{
    public class TheGapOfRohanSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Gap of Rohan";
            Abbreviation = "TGoR";
            Number = 10004;
            SetType = Models.SetType.A_Long_extended_Party;
            Cycle = "Oaths of the Rohirrim";

            addHero("Barliman Butterbur", 8, Sphere.Lore, 2, 1, 0, 5)
                .WithTraits("Bree.")
                .WithTextLine("Response: After Barliman Butterbur takes damage from an undefended attack, draw 1 card.")
                .WithFlavorLine("“I’m run off my feet; but I’ll see what I can do for you.”")
                .WithFlavorLine("—The Fellowship of the Ring")
                .WithInfo(71, 1, Artist.Stanislav_Dikolenko);
            addHero("Nob", 7, Sphere.Lore, 2, 1, 0, 3)
                .WithTraits("Hobbit.", "Bree.", "Servant.")
                .WithTextLine("Reduce the cost of the first Item attachment you play on another Bree or Hobbit character each round by 1.")
                .WithTextLine("Action: Exhaust Nob to draw a card. If that card is an Item attachment, ready a Bree character. (Limit once per round.)")
                .WithFlavorLine("“Where are you, you woolly-footed slow-coach?”")
                .WithFlavorLine("—Barliman Butterbur, The Fellowship of the Ring")
                .WithInfo(72, 1, Artist.Stanislav_Dikolenko);
            addHero("Harry Goatleaf", 8, Sphere.Spirit, 2, 2, 0, 4)
                .WithTraits("Bree.")
                .WithTextLine("Response: Cancel 1 point of combat damage just dealt to a hero you control. (Limit once per round per hero.)")
                .WithFlavorLine("“Your business is your own, no doubt, but it’s my business to ask questions after nightfall.”")
                .WithFlavorLine("—The Fellowship of the Ring")
                .WithInfo(73, 1, Artist.Lukasz_Jaskolski);
            addAlly("Bob", 2, Sphere.Lore, true, 1, 1, 0, 2)
                .WithTraits("Hobbit.", "Bree.", "Servant.")
                .WithTextLine("Response: After Bob enters play, search your deck for a Mount or Pony card and add it to your hand. Shuffle your deck.")
                .WithFlavorLine("“A poor old half-starved creature it is, but he won’t part with it for less than thrice its worth.”")
                .WithFlavorLine("—The Fellowship of the Ring")
                .WithInfo(74, 3, Artist.Stanislav_Dikolenko);
            addAttachment("Bree Pony", 1, Sphere.Lore, false)
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Bree or Hobbit character. Restricted.")
                .WithTextLine("Attached character gets +1 hit point.")
                .WithTextLine("Response: When attached character takes damage from an undefended attack, exhaust Bree Pony to reduce that damage by 1.")
                .WithFlavorLine("No horse or pony was to be got for love or money in the neighbourhood – except one.")
                .WithFlavorLine("—The Fellowship of the Ring")
                .WithInfo(75, 3, Artist.Ted_Nasmith);
            addAttachment("Half-pint", 1, Sphere.Lore, false)
                .WithTraits("Item.")
                .WithTextLine("Attach to a character.")
                .WithTextLine("Refresh Action: Discard Half-pint to heal up to 2 damage from attached character. Then, put an Item attachment in your discard pile on the top of your deck.")
                .WithFlavorLine("“I’ve a drop of good ale on tap, if you and your friends are willing.”")
                .WithFlavorLine("—Farmer Maggot, The Fellowship of the Ring")
                .WithInfo(76, 3, Artist.Bethesda_Softworks);
            addAttachment("Seasoned Forager", 1, Sphere.Lore, false)
                .WithTraits("Skill.")
                .WithTextLine("Attach to a hero you control. Limit 1 per player.")
                .WithTextLine("Your heroes cannot gain resources from player card effects.")
                .WithTextLine("Action: Exhaust Seasoned Forager to reduce the cost of the next card you play this phase that matches the attached hero’s sphere by 1.")
                .WithInfo(77, 3, Artist.Bethesda_Softworks);
            addAttachment("Pint", 2, Sphere.Lore, false)
                .WithTraits("Item.")
                .WithTextLine("Play only if you control a unique Bree character.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Action: Exhaust Pint to heal 1 damage from attached hero.")
                .WithTextLine("Action: Discard Pint to heal 5 damage from attached hero.")
                .WithFlavorLine("“Well, my merry folk, will you drink another draught with me before you go?”")
                .WithFlavorLine("—Treebeard, The Return of the King")
                .WithInfo(78, 3, Artist.Darek_Zabrocki);
            addAlly("Scheming Staddler", 1, Sphere.Spirit, false, 1, 0, 0, 1)
                .WithTraits("Bree.")
                .WithTextLine("Response: After an undefended attack damages a hero you control, deal 1 damage to the attacking enemy. (Limit once per phase.)")
                .WithFlavorLine("“He would sell anything to anybody; or make mischief for amusement.”")
                .WithFlavorLine("—Aragorn, The Fellowship of the Ring")
                .WithInfo(79, 3, Artist.Aleksandra_Wojtas);
            addAlly("Bree-land Protector", 2, Sphere.Spirit, false, 0, 2, 1, 2)
                .WithTraits("Dúnedain.", "Bree.")
                .WithKeywords("Devoted.")
                .WithTextLine("Devoted.")
                .WithTextLine("Response: Exhaust Bree-land Protector to cancel a shadow effect just triggered during an attack and deal the attacking enemy another shadow card. If this attack deals no damage, return Bree-land Protector to its owner’s hand after the attack.")
                .WithInfo(80, 3, Artist.Gal_Or);
            addEvent("A Stout Heart", 0, Sphere.Spirit)
                .WithTextLine("Response: Cancel a shadow effect just triggered during an undefended attack. After this attack damages a single hero, the controller of that hero may spend 1 resource from its pool to reduce their threat by 3.")
                .WithFlavorLine("“We come now to the very brink, where hope and despair are akin. To waver is to fall.”")
                .WithFlavorLine("—Aragorn, The Return of the King")
                .WithInfo(81, 3, Artist.John_Howe);
            addAttachment("Gift of Foresight", 2, Sphere.Spirit, false)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a hero with at least 2 printed Willpower. Limit 1 per hero.")
                .WithTextLine("Attached hero gets +2 Defense if it has not committed to the quest this round.")
                .WithFlavorLine("“Do not think that only by singing amid the trees, nor even by the slender arrows of elven-bows, is this land of Lothlórien maintained and defended.”")
                .WithFlavorLine("–Galadriel, The Fellowship of the Ring")
                .WithInfo(82, 3, Artist.Incantata);
            addAlly("Archet Alekeeper", 3, Sphere.Tactics, false, 1, 2, 0, 2)
                .WithTraits("Bree.")
                .WithKeywords("Devoted.")
                .WithTextLine("Devoted.")
                .WithTextLine("Response: After an undefended attack damages a hero you control, ready Archet Alekeeper and give it +1 Attack until the end of the phase.")
                .WithFlavorLine("“Gave me a chance of walking round the country and seeing folk, and hearing the news, and knowing where the good beer was.”")
                .WithFlavorLine("—Robin Smallburrow, The Return of the King")
                .WithInfo(83, 3, Artist.Dan_Scott);
            addObjective("Gálmód", EncounterSet.TheGapOfRohan)
                .WithUnique()
                .WithTraits("Rohan.", "Traitor.")
                .WithKeywords("Time 7.")
                .WithTextLine("Time 7.")
                .WithTextLine("When the last time counter is removed from Gálmód, the players lose the game.")
                .WithFlavorLine("The oathbreaker has fled westward, into the heart of a raging storm.")
                .WithInfo(84, 1, Artist.Daniel_Jimenez_Villalba);
            addEnemy("Gálmód’s Escort", EncounterSet.TheGapOfRohan, 50, 3, 4, 4, 5)
                .WithTraits("Rohan.", "Traitor.")
                .WithTextLine("Immune to player card effects. Gálmód’s Escort cannot leave the staging area and is considered to be engaged with each player.")
                .WithTextLine("Damage that would be dealt to Gálmód’s Escort must first be dealt as progress to copies of Snowbank in the staging area, if able.")
                .WithVictoryPoints(5)
                .WithInfo(85, 1, Artist.Stu_Harrington);
            addEnemy("Frantic Dunlending", EncounterSet.TheGapOfRohan, 23, 2, 2, 1, 3)
                .WithTraits("Dunland.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Forced: At the end of the round, return Frantic Dunlending to the staging area.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack for this attack. X is the Frostbite value on the main quest.")
                .WithInfo(86, 4, Artist.Unknown);
            addEnemy("Dunlending Rearguard", EncounterSet.TheGapOfRohan, 45, 4, 4, 3, 5)
                .WithTraits("Dunland.")
                .WithTextLine("Forced: At the end of the encounter phase, if Dunlending Rearguard is in the staging area, remove 1 time counter from Gálmód.")
                .WithFlavorLine("“Death to the Strawheads! Death to the robbers of the North!”")
                .WithFlavorLine("—The Two Towers")
                .WithEasyModeQuantity(1)
                .WithInfo(87, 2, Artist.Slawomir_Maniak);
            addLocation("Snowbank", EncounterSet.TheGapOfRohan, 1, 3)
                .WithTraits("Westfold.", "Snow.")
                .WithTextLine("Forced: When progress would be placed on a quest card or on the active location, place it on a copy of Snowbank instead.")
                .WithTextLine("Quest Action: Exhaust a hero you control to place X progress on this location, where X is the exhausted hero’s printed attack.")
                .WithShadow("Shadow: Add Snowbank to the staging area.")
                .WithEasyModeQuantity(1)
                .WithInfo(88, 6, Artist.Daniel_Gastager);
            addLocation("Exposed Ridge", EncounterSet.TheGapOfRohan, 4, 1)
                .WithTraits("Westfold.", "Mountain.")
                .WithTextLine("While Exposed Ridge is in the staging area, progress cannot be placed here.")
                .WithTextLine("Travel: Deal 1 damage to each exhausted character controlled by the first player.")
                .WithFlavorLine("“How I do hate looking down from a height! But looking’s better than climbing.”")
                .WithFlavorLine("—Sam Gamgee, The Two Towers")
                .WithInfo(89, 2, Artist.Warlock_Artist);
            addLocation("Frozen Lake", EncounterSet.TheGapOfRohan, 3, 2)
                .WithTraits("Westfold.", "Lake.")
                .WithTextLine("While Frozen Lake is the active location, treat the text box of each Snowbank in the staging area as if it were blank.")
                .WithTextLine("Forced: After Frozen Lake leaves play as an explored location, discard the top card of the encounter deck. If that card is a treachery, each player discards an ally they control.")
                .WithInfo(90, 2, Artist.Tom_Honz);
            addLocation("Slippery Hill", EncounterSet.TheGapOfRohan, 3, Card.VALUE_X)
                .WithTraits("Westfold.", "Hill.")
                .WithTextLine("X is 1 more than the number of allies controlled by the player with the most allies.")
                .WithFlavorLine("“Come after me – you will see the way I go.”")
                .WithFlavorLine("—Gandalf, The Hobbit")
                .WithInfo(91, 2, Artist.Timi_Honkanen);
            addTreachery("Snow Squall", EncounterSet.TheGapOfRohan)
                .WithTraits("Weather.")
                .WithTextLine("When Revealed: Add 2 copies of Snowbank from the encounter discard pile to the staging area. If fewer than 2 copies of Snowbank were added to the staging area as a result of this effect, Snow Squall gains surge.")
                .WithShadow("Shadow: Search the encounter discard pile for 1 copy of Snowbank and add it to the staging area.")
                .WithEasyModeQuantity(1)
                .WithInfo(92, 2, Artist.Brandon_Moore);
            addTreachery("Frozen Solid", EncounterSet.TheGapOfRohan)
                .WithTraits("Weather.")
                .WithTextLine("When Revealed: Exhaust all attachments the players control. Attachments cannot ready until the end of the round. If no attachments were exhausted this way, Frozen Solid gains surge.")
                .WithFlavorLine("“Either stop where we are, or go back. It is no good going on.”")
                .WithFlavorLine("—Gandalf, The Fellowship of the Ring")
                .WithEasyModeQuantity(1)
                .WithInfo(93, 2, Artist.Bartlomiej_Gawel);
            addTreachery("Stumble in the Snow", EncounterSet.TheGapOfRohan)
                .WithTraits("Weather.")
                .WithTextLine("When Revealed: Each player exhausts a character they control and deals X damage to it, where X is the Frostbite value on the main quest.")
                .WithShadow("Shadow: Defending character cannot ready until the end of the round.")
                .WithEasyModeQuantity(1)
                .WithInfo(94, 2, Artist.Gintas_Galvanauskas);
            addTreachery("Unnatural Cold", EncounterSet.TheGapOfRohan)
                .WithTraits("Weather.")
                .WithTextLine("While attached to a quest, counts as a Condition attachment with the text: “Forced: After an ally or enemy enters play, deal 1 damage to it. If it is an ally, its controller may exhaust it to cancel this effect.”")
                .WithTextLine("When Revealed: Attach to the main quest if it does not have a copy of Unnatural Cold attached.")
                .WithEasyModeQuantity(1)
                .WithInfo(95, 2, Artist.Paolo_Puggioni);
            addEncounterSideQuest("White Wall", EncounterSet.TheGapOfRohan, 0)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("White Wall gets +4Per Player quest points.")
                .WithTextLine("Forced: At the beginning of the quest phase, search the encounter discard pile for 1 copy of Snowbank and add it to the staging area.")
                .WithFlavorLine("The great driving blizzard seems to have no end. The mountain’s great gales and fell winds bring with them vast, implacable walls of snow.")
                .WithVictoryPoints(1)
                .WithInfo(96, 1, Artist.Musaab_Shukri);
            addQuest("Giving Chase", EncounterSet.TheGapOfRohan, 1, 'A', 10)
                .WithTextLine("Setup: Set Gálmód’s Escort aside, out of play. Add Gálmód and 1Per Player copies of Snowbank to the staging area.")
                .WithFlavorLine("You have pursued the traitor Gálmód to the Gap of Rohan. However, unseasonable snows have made your passage difficult.")
                .WithOppositeTextLine("Frostbite 1.")
                .WithOppositeTextLine("Characters cannot be readied by player card effects.")
                .WithOppositeFlavorLine("As the blizzard closes in, you must capture the treasonous Gálmód at any cost.")
                .WithIncludedEncounterSets(EncounterSet.FaithlessRohirrim, EncounterSet.RohanWeather)
                .WithInfo(97, 1, Artist.Reza_Afshar);
            addQuest("A Dangerous Pursuit", EncounterSet.TheGapOfRohan, 2, 'A', 8)
                .WithTextLine("When Revealed: Add 1 time counter to Gálmód. Shuffle the encounter discard pile into the encounter deck. Discard cards from the top of the encounter deck until 1Per Player enemies are discarded. Add each discarded enemy to the staging area.")
                .WithFlavorLine("Pressing onward, Gálmód is joined by a small group of fellow rebels. As he rides through, they close ranks behind him to stall your pursuit.")
                .WithOppositeTextLine("Frostbite 2.")
                .WithOppositeTextLine("Forced: At the beginning of the quest phase, deal 1 damage to each exhausted character.")
                .WithOppositeFlavorLine("A cruel gale howls through the mountain pass, and even your attackers seem perplexed at the storm’s ferocity. The white haze of wind-whipped snow is blinding as you prepare to face your foes.")
                .WithIncludedEncounterSets(EncounterSet.FaithlessRohirrim, EncounterSet.RohanWeather)
                .WithInfo(98, 1, Artist.Xia_Taptara);
            addQuest("Biting Winds", EncounterSet.TheGapOfRohan, 3, 'A', 8)
                .WithTextLine("When Revealed: Add 1 time counter to Gálmód. The first player searches the encounter deck, encounter discard pile, and victory display for a copy of Unnatural Cold and attaches it to the main quest. Shuffle the encounter deck. Each other player reveals an encounter card.")
                .WithFlavorLine("As Gálmód races through the flurry, the brutal weather worsens. He pushes his stallion beyond all limits, determined to escape a traitor’s bloody justice.")
                .WithOppositeTextLine("Frostbite 2.")
                .WithOppositeTextLine("Treat the text box of each damaged character as if it were blank (except for Traits).")
                .WithOppositeTextLine("Unnatural Cold is immune to player card effects and gains surge.")
                .WithOppositeFlavorLine("Soon, even your party begins to slow and stagger. If the traitor escapes through the mountain pass, he will be far from Rohan’s reach.")
                .WithIncludedEncounterSets(EncounterSet.FaithlessRohirrim, EncounterSet.RohanWeather)
                .WithInfo(99, 1, Artist.John_Anthony_Di_Giovanni);
            addQuest("Recapture the Traitor", EncounterSet.TheGapOfRohan, 4, 'A', 6)
                .WithTextLine("When Revealed: Add 1 time counter to Gálmód. The first player adds Gálmód’s Escort to the staging area and attaches Gálmód to it as a guarded objective. Each other player searches the encounter deck, encounter discard pile, and victory display for a copy of Snowbank and adds it to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("As the traitor’s horse stumbles just ahead of the mountain pass, one of Gálmód’s confederates rips him from his saddle.")
                .WithOppositeTextLine("Frostbite 3.")
                .WithOppositeTextLine("Gálmód’s Escort cannot take damage until Recapture the Traitor has at least 6 progress on it.")
                .WithOppositeTextLine("The players cannot defeat this stage while Gálmód is guarded by an enemy. When Gálmód is free of encounters, he is captured and the players win the game.")
                .WithOppositeFlavorLine("Gálmód and his bodyguard have nearly escaped into the wilderness! Soon he will be out of reach entirely.")
                .WithIncludedEncounterSets(EncounterSet.FaithlessRohirrim, EncounterSet.RohanWeather)
                .WithInfo(100, 1, Artist.Piotr_Foksowicz);
        }
    }
}
