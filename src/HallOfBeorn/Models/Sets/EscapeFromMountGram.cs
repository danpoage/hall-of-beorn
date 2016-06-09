using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class EscapeFromMountGram : CardSet
    {
        protected override void Initialize()
        {
            Name = "Escape from Mount Gram";
            Abbreviation = "EfMG";
            Number = 31;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Angmar Awakened";

            Cards.Add(Card.Hero("Rossiel", "", Sphere.Lore, 8, 2, 1, 2, 3)
                .WithTraits("Silvan.")
                .WithText("If the active location shares a Trait with a location in the victory display, Rossiel gets +2 Willpower.\r\nIf the attacking enemy shares a Trait with an enemy in the victory display, Rossiel gets +2 Defense.")
                .WithFlavor("\"Did you not say that you wished to see Elf-magic?\" —Galadriel, The Fellowship of the Ring")
                .WithTemplate("<p>If the active location shares a <b><i>Trait</i></b> with a location in the victory display, {self} gets +2 {Willpower}.</p><p>If the attacking enemy shares a <b><i>Trait</i></b> with an enemy in the victory display, {self} gets +2 {Defense}.</p><p style='text-align:center;'><i>&quot;Did you not say that you wished to see Elf-magic?&quot;<br>&ndash;Galadriel, The Fellowship of the Ring</i></p>")
                .WithInfo(28, 1, Artist.Alexandre_Dainche));
            Cards.Add(Card.Ally("Veteran of Osgiliath", "", Sphere.Leadership, 3, 1, 2, 1, 2)
                .WithGeneric()
                .WithTraits("Gondor.", "Warrior.")
                .WithText("Veteran of Osgiliath gets +1 Willpower, +1 Attack, and +1 Defense while your threat is 40 or higher.")
                .WithFlavor("\"So do we ever watch the shores nigh Osgiliath, which our enemies now partly hold, and issue from it to harry our lands.\" —Faramir, The Two Towers")
                .WithTemplate("<p>{self} gets +1 {Willpower}, +1 {Attack}, and +1 {Defense} while your threat is 40 or higher.</p><p class='flavor-text'>&quot;So do we ever watch the shores nigh Osgiliath, which our enemies now partly hold, and issue from it to harry our lands.&quot;<br>&ndash;Faramir, The Two Towers</p>")
                .WithInfo(29, 3, Artist.John_Stanko));
            Cards.Add(Card.Event("Descendants of Kings", "", Sphere.Leadership, 1)
                .WithText("Ready up to X Dúnedain characters you control. X is the number of enemies engaged with you.")
                .WithFlavor("\"But when dark things come from the houseless hills, or creep from sunless woods, they fly from us.\" —Aragorn, The Fellowship of the Ring")
                .WithTemplate("<p>Ready up to X {trait:Dunedain.@Dúnedain} characters you control. X is the number of enemies engaged with you.</p><p style='text-align:center;'>&quot;But when dark things come from the houseless hills, or creep from sunless woods, they fly from us.&quot;<br>&ndash;Aragorn, The Fellowship of the Ring</p>")
                .WithInfo(30, 3, Artist.Smirtouille));
            Cards.Add(Card.Ally("Derndingle Warrior", "", Sphere.Tactics, 2, 1, 1, 2, 3)
                .WithGeneric()
                .WithTraits("Ent.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Cannot have restricted attachments. Enters play exhausted.\r\n While Derndingle Warrior is defending, it gains: \"Action: Deal 1 damage to Derndingle Warrior to give it +3 Defense for this attack.\" (Limit once per attack.)")
                .WithInfo(31, 3, Artist.Oscar_Romer));
            Cards.Add(Card.Event("Boomed and Trumpeted", "", Sphere.Tactics, 1)
                .WithTraits("Ent.")
                .WithText("Response: After an Ent character takes any amount of damage, ready it. That character gets +3 Attack until the end of the phase.")
                .WithFlavor("\"They roared and boomed and trumpeted, until stones began to crack and fall at the mere noise of them.\" —Merry, The Two Towers")
                .WithTemplate("<p><b>Response:</b> After an {trait:Ent.@Ent} character takes any amount of damage, ready it. That character gets +3 {Attack} until the end of the phase.</p><p style='text-align:center'>&quot;They roared and boomed and trumpeted, until stones began to crack and fall at the mere noise of them.&quot; &ndash;Merry, The Two Towers</p>")
                .WithInfo(32, 3, Artist.Jordan_Saia));
            Cards.Add(Card.Ally("Elven Jeweler", "", Sphere.Spirit, 2, 1, 1, 1, 2)
                .WithGeneric()
                .WithTraits("Noldor.", "Craftsman.")
                .WithText(" Discard 2 cards from your hand to put Elven Jeweler into play from your hand, under your control.")
                .WithFlavor("\"...to the Elven-smiths they were but trifles...\" -Gandalf, The Fellowship of the Ring")
                .WithInfo(33, 3, Artist.Cassandre_Bolan));
            Cards.Add(Card.PlayerSideQuest("Double Back", "", Sphere.Spirit, 0, 4)
                .WithText("Limit 1 per deck.\r\nResponse: When this stage is defeated, reduce each player's threat by 5.")
                .WithFlavor("He was taking a wandering course with many turns and doublings, to put off any pursuit. -The Fellowship of the Ring")
                .WithInfo(34, 3, Artist.Jorge_Barrero));
            Cards.Add(Card.Event("Leave No Trace", "", Sphere.Lore, 1)
                .WithText("Limit 3 copies of Leave No Trace in the victory display.\r\nResponse: After a non-unique location is explored, add Leave No Trace to the victory display to add that location to the victory display.")
                .WithInfo(35, 3, Artist.Aurelien_Hubert));
            Cards.Add(Card.Event("Distant Stars", "", Sphere.Lore, 0)
                .WithText("Action: Exhaust a Ranger or Scout character to discard a non-unique active location. Then, search the encounter deck and discard pile for a non-unique location and make it the active location. Shuffle the encounter deck.")
                .WithFlavor("\"I have crossed many mountains and many rivers, and trodden many plains, even into the far countries of Rhûn and Harad where the stars are strange...\" —Aragorn, The Fellowship of the Ring")
                .WithTemplate("<p><b>Action:</b> Exhaust a {trait:Ranger.@Ranger} or {trait:Scout.@Scout} character to discard a non-unique active location. Then, search the encounter deck and discard pile for a non-unique location and make it the active location. Shuffle the encounter deck.</p><p style='text-align:center'>&quot;I have crossed many mountains and many rivers, and trodden many plains, even into the far countries of Rhûn and Harad where the stars are strange...&quot;<br>&ndash;Aragorn, The Fellowship of the Ring</i></p>")
                .WithInfo(36, 3, Artist.John_Stanko));
            Cards.Add(Card.Event("Keen as Lances", "", Sphere.Neutral, 5)
                .WithText("Reduce the cost to play Keen as Lances by 1 for each card worth no victory points in the victory display.\r\nAction: Add Keen as Lances to the victory display. Then, choose one: add 2 resources to a hero's resource pool, draw 3 cards, or reduce your threat by 4.")
                .WithInfo(37, 3, Artist.Magali_Villeneuve));
            Cards.Add(Card.Quest("Unexpected Rescue", "", 2, 1, "Escape from Mount Gram", 255)
                .WithFlavor("You have been captured and imprisoned by the goblins of Mount Gram.")
                .WithText("Setup: Each player shuffles his starting hand into his deck. Each player prepares a separate captured deck (see insert). Each player adds 2 resources to his starting hero and sets his threat to that hero's threat cost. Set Southern ~Gate, Jailor Gornákh and the Angmar Orcs encounter set aside, out of play. Shuffle the encounter deck. Each player draws a new starting hand of 3 cards.")
                .WithOppositeFlavor("You have endured much during your imprisonment in Mount Gram at the hands of a cruel goblin known as Gornákh. But before you are taken north as prizes for \"Lord Daechanar,\" Amarthiúl comes to your rescue. After he frees you, he slips off to find Iârion, whom you suspect is imprisoned nearby. Armed with only your wits and resolve, you must find the rest of your company.")
                .WithOppositeText("When Revealed: Each player creates his own staging area and advances to a different stage 2A.")
                .WithIncludedEncounterSets(EncounterSet.AngmarOrcs)
                .WithInfo(38, 1, Artist.Tomasz_Jedruszek));
            Cards.Add(Card.Quest("Gornákh's Dungeons", "", 2, 2, "Escape from Mount Gram", 255)
                .WithNormalizedTitle("Gornakh's Dungeons")
                .WithFlavor("Alone and without your equipment, you steel yourself and being to search for your companions and belongings.")
                .WithKeywords("Capture 7.")
                .WithText("When Revealed: Search the encounter deck for 1 copy of Prison Cell, reveal it, and add it to your staging area. Then capture an additional 2 cards from the top of your captured deck underneath that copy of Prison Cell.")
                .WithOppositeText("Any time players would place progress on this quest, resuce an equal number of captured cards at random from underneath it instead. (Progress is placed on the active location before triggering this effect.)\r\nForced: If there are no captured cards underneath Gornákh's Dungeons, join another player at the beginning of the travel phase. If you cannot join another player, all players advance to stage 3A together.")
                .WithIncludedEncounterSets(EncounterSet.AngmarOrcs)
                .WithInfo(39, 4, Artist.Katayanagi));
            Cards.Add(Card.Quest("Flight from Mount Gram", "", 2, 3, "Escape from Mount Gram", 16)
                .WithFlavor("Having rescued as many of your companions as you can find, you begin to make your way towards the dungeon's hidden exit. By now Gornákh is surely aware of your escape, and the orcs that were with Thaurdir are now searching for you, as well.")
                .WithText("When Revealed: Add Southern ~Gate and Jailor Gornakh to the staging area. Shuffle the Angmar Orcs encounter set into the encounter deck. Then, reveal 1 encounter card per player from the top of the encounter deck.")
                .WithOppositeFlavor("Orcs and Goblins rush to find you before you can make your escape. You must make haste if you wish to make it out of Mount Gram alive!")
                .WithOppositeText("The player cannot travel to Southern ~Gate unless there is at least 16 progress on this stage.\r\nThe players cannot defeat this stage while Souther ~Gate is in play. If the players defeat this stage, they have escaped Mount Gram and win the game.")
                .WithIncludedEncounterSets(EncounterSet.AngmarOrcs)
                .WithInfo(40, 1, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Enemy("Jailor Gornákh", "", "Escape from Mount Gram", 44, 3, 5, 3, 8)
                .WithUnique()
                .WithNormalizedTitle("Jailor Gornakh")
                .WithTraits("Goblin.", "Orc.")
                .WithText("Forced: After 1 or more captured cards are rescued, Jailor Gornákh engages the player with the highest threat and makes an immediate attack.")
                .WithFlavor("\"Come on now! We've talked enough. Let's go and have a look at the prisoner!\"\r\n-Shagrat, The Two Towers")
                .WithVictoryPoints(5)
                .WithInfo(41, 1, Artist.Joel_Hustak));
            Cards.Add(Card.Location("Southern Gate", "", "Escape from Mount Gram", 3, 8)
                .WithUnique()
                .WithTraits("Mountain.")
                .WithText("Immune to player card effects.\r\nWhite Southern ~Gate s the active location, each Orc enemy gets +2 Attack.\r\nForced: When Southern ~Gate becomes the active location, each player with less than 35 threat must raise his threat to 35.")
                .WithVictoryPoints(2)
                .WithInfo(42, 1, Artist.Jake_Bullock));
            Cards.Add(Card.Enemy("Cruel Torturer", "", "Escape from Mount Gram", 36, 2, 3, 2, 3)
                .WithTraits("Goblin.", "Orc.")
                .WithKeywords("Capture 1.")
                .WithText("Forced: When Cruel Torturer would damage an ally by an attack, capture that ally underneath Cruel Torturer instead.")
                .WithFlavor("\"You'll get bed and breakfast all right: more than you can stomach\"\r\n-Uglúk, The Two Towers")
                .WithInfo(43, 2, Artist.Nicholas_Gregory));
            Cards.Add(Card.Enemy("Dungeon Guard", "", "Escape from Mount Gram", 16, 1, 2, 1, 2)
                .WithTraits("Goblin.", "Orc.")
                .WithKeywords("Capture 1.")
                .WithText("Response: After the captured card(s) underneath Dungeon Guard are rescued, the players may put 1 of them into play at no cost.")
                .WithInfo(44, 3, Artist.Anthony_Feliciano));
            Cards.Add(Card.Enemy("Goblin Tormentor", "", "Escape from Mount Gram", 28, 2, 255, 1, 3)
                .WithTraits("Goblin.", "Orc.")
                .WithKeywords("Capture 1.")
                .WithText("X is the number of cards in play with 1 or more captured cards underneath them.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if it has no captured cards underneath it).")
                .WithEasyModeQuantity(0)
                .WithInfo(45, 2, Artist.Rafal_Hrynkiewicz));
            Cards.Add(Card.Location("Prison Cell", "", "Escape from Mount Gram", 1, 3)
                .WithTraits("Underground.")
                .WithKeywords("Capture 1.")
                .WithText("Response: After the players travel to Prison Cell, look at the captured card(s) underneath it and choose 1 to put into play at no cost. Place the other cards back underneath Prison Cell.")
                .WithFlavor("...goblins don't care who they catch, as long as it isa done smart and secret, and the prisoners are not able to defend themselves.\r\n-The Hobbit")
                .WithInfo(46, 4, Artist.Ferdinand_Dumago_Ladera));
            Cards.Add(Card.Location("Patrol Room", "", "Escape from Mount Gram", 3, 2)
                .WithTraits("Underground.")
                .WithKeywords("Capture 2.")
                .WithText("Travel: Each player raises his threat by 3 to travel here.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending player's threat is 20 or higher).")
                .WithInfo(47, 2, Artist.Jordan_Saia));
            Cards.Add(Card.Location("Tunnels of Mount Gram", "", "Escape from Mount Gram", 254, 4)
                .WithTraits("Underground.")
                .WithKeywords("Capture 1.")
                .WithText("X is the number of captured cards underneath Tunnels of Mount Gram.")
                .WithShadow("Shadow: Capture each attachment attached to the defending character underneath the attacking enemy.")
                .WithInfo(48, 2, Artist.Ferdinand_Dumago_Ladera));
            Cards.Add(Card.Treachery("Sound the Alarm!", "", "Escape from Mount Gram")
                .WithKeywords("Doomed 3.")
                .WithText("When Revealed: Until the end of the round, each enemy gets -10 engagement cost and +1 Attack. If there are no enemies in play, search the encounter deck and discard pile for an enemy and add it to the staging area.")
                .WithEasyModeQuantity(1)
                .WithInfo(49, 2, Artist.Owen_William_Weber));
            Cards.Add(Card.Treachery("Feeble and Weary", "", "Escape from Mount Gram")
                .WithText("When Revealed: Each player must either deal 1 damage to each exhausted character he controls, or remove each exhausted character he controls from the quest.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithInfo(50, 2, Artist.Tawny_Fritzinger));
            Cards.Add(Card.Treachery("Captives of Gornákh", "", "Escape from Mount Gram")
                .WithNormalizedTitle("Captives of Gornakh")
                .WithText("When Revealed: Each player chooses one of his allies and captures it underneath the encounter card with the highest Threat.")
                .WithShadow("Shadow: If this attack would damage an ally, capture that ally underneath the attacking enemy instead.")
                .WithEasyModeQuantity(1)
                .WithInfo(51, 2, Artist.Kaija_Rudkiewicz));
            Cards.Add(Card.Treachery("Interrogation", "", "Escape from Mount Gram")
                .WithText("When Revealed: Each player discards the top card of his captured deck and raises his threat by that card's printed resource cost. If at least 1 player discarded no cards from this effect, Interrogation gains Doomed 2.")
                .WithShadow("Shadow: Discard a random card from your hand and raise your threat by its printed cost.")
                .WithInfo(52, 2, Artist.Rafal_Hrynkiewicz));
            Cards.Add(Card.EncounterSideQuest("Stop the Executioners!", "", "Escape from Mount Gram", 6)
                .WithKeywords("Capture 5.", "Time 4.")
                .WithFlavor("Several of your captured companions are being sent to the executioner's block. If you make it in time, you might be able to save them before they are slain!")
                .WithText("Forced: When the last time counter is removed from this quest, discard its captured cards and remove this quest from the game. Then, raise each player's threat by 3 for each of his characters that was discarded by this effect.")
                .WithVictoryPoints(10)
                .WithInfo(53, 1, Artist.Guillaume_Ducos));
        }
    }
}