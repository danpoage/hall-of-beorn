/* Generated CardSet class: Escape from Mount Gram */

using System;

namespace HallOfBeorn.Models.LotR.Sets.AngmarAwakened
{
    public class EscapeFromMountGramSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Escape from Mount Gram";
            Abbreviation = "EfMG";
            Number = 31;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Angmar Awakened";

            addHero("Rossiel", 8, Sphere.Lore, 2, 1, 2, 3)
                .WithTraits("Silvan.")
                .WithTextLine("If the active location shares a Trait with a location in the victory display, Rossiel gets +2 Willpower.")
                .WithTextLine("If the attacking enemy shares a Trait with an enemy in the victory display, Rossiel gets +2 Defense.")
                .WithFlavorLine("\"Did you not say that you wished to see Elf-magic?\" —Galadriel, The Fellowship of the Ring")
                .WithTemplate("<p>If the active location shares a <b><i>Trait</i></b> with a location in the victory display, {self} gets +2 {Willpower}.</p><p>If the attacking enemy shares a <b><i>Trait</i></b> with an enemy in the victory display, {self} gets +2 {Defense}.</p><p style='text-align:center;'><i>&quot;Did you not say that you wished to see Elf-magic?&quot;<br>&ndash;Galadriel, The Fellowship of the Ring</i></p>")
                .WithInfo(28, 1, Artist.Alexandre_Dainche);
            addAlly("Veteran of Osgiliath", 3, Sphere.Leadership, false, 1, 2, 1, 2)
                .WithTraits("Gondor.", "Warrior.")
                .WithTextLine("Veteran of Osgiliath gets +1 Willpower, +1 Attack, and +1 Defense while your threat is 40 or higher.")
                .WithFlavorLine("\"So do we ever watch the shores nigh Osgiliath, which our enemies now partly hold, and issue from it to harry our lands.\" —Faramir, The Two Towers")
                .WithTemplate("<p>{self} gets +1 {Willpower}, +1 {Attack}, and +1 {Defense} while your threat is 40 or higher.</p><p class='flavor-text'>&quot;So do we ever watch the shores nigh Osgiliath, which our enemies now partly hold, and issue from it to harry our lands.&quot;<br>&ndash;Faramir, The Two Towers</p>")
                .WithInfo(29, 3, Artist.John_Stanko);
            addEvent("Descendants of Kings", 1, Sphere.Leadership)
                .WithTextLine("Ready up to X Dúnedain characters you control. X is the number of enemies engaged with you.")
                .WithFlavorLine("\"But when dark things come from the houseless hills, or creep from sunless woods, they fly from us.\" —Aragorn, The Fellowship of the Ring")
                .WithTemplate("<p>Ready up to X {trait:Dunedain.@Dúnedain} characters you control. X is the number of enemies engaged with you.</p><p style='text-align:center;'>&quot;But when dark things come from the houseless hills, or creep from sunless woods, they fly from us.&quot;<br>&ndash;Aragorn, The Fellowship of the Ring</p>")
                .WithInfo(30, 3, Artist.Smirtouille);
            addAlly("Derndingle Warrior", 2, Sphere.Tactics, false, 1, 1, 2, 3)
                .WithTraits("Ent.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Cannot have restricted attachments. Enters play exhausted.")
                .WithTextLine("While Derndingle Warrior is defending, it gains: \"Action: Deal 1 damage to Derndingle Warrior to give it +3 Defense for this attack.\" (Limit once per attack.)")
                .WithInfo(31, 3, Artist.Oscar_Romer);
            addEvent("Boomed and Trumpeted", 1, Sphere.Tactics)
                .WithTraits("Ent.")
                .WithTextLine("Response: After an Ent character takes any amount of damage, ready it. That character gets +3 Attack until the end of the phase.")
                .WithFlavorLine("\"They roared and boomed and trumpeted, until stones began to crack and fall at the mere noise of them.\" —Merry, The Two Towers")
                .WithTemplate("<p><b>Response:</b> After an {trait:Ent.@Ent} character takes any amount of damage, ready it. That character gets +3 {Attack} until the end of the phase.</p><p style='text-align:center'>&quot;They roared and boomed and trumpeted, until stones began to crack and fall at the mere noise of them.&quot; &ndash;Merry, The Two Towers</p>")
                .WithInfo(32, 3, Artist.Jordan_Saia);
            addAlly("Elven Jeweler", 2, Sphere.Spirit, false, 1, 1, 1, 2)
                .WithTraits("Noldor.", "Craftsman.")
                .WithTextLine("Discard 2 cards from your hand to put Elven Jeweler into play from your hand, under your control.")
                .WithFlavorLine("\"...to the Elven-smiths they were but trifles...\" -Gandalf, The Fellowship of the Ring")
                .WithInfo(33, 3, Artist.Cassandre_Bolan);
            addPlayerSideQuest("Double Back", 0, Sphere.Spirit, 4)
                .WithTextLine("Limit 1 per deck.")
                .WithTextLine("Response: When this stage is defeated, reduce each player's threat by 5.")
                .WithFlavorLine("He was taking a wandering course with many turns and doublings, to put off any pursuit. -The Fellowship of the Ring")
                .WithInfo(34, 3, Artist.Jorge_Barrero);
            addEvent("Leave No Trace", 1, Sphere.Lore)
                .WithTextLine("Limit 3 copies of Leave No Trace in the victory display.")
                .WithTextLine("Response: After a non-unique location is explored, add Leave No Trace to the victory display to add that location to the victory display.")
                .WithInfo(35, 3, Artist.Aurelien_Hubert);
            addEvent("Distant Stars", 0, Sphere.Lore)
                .WithTextLine("Action: Exhaust a Ranger or Scout character to discard a non-unique active location. Then, search the encounter deck and discard pile for a non-unique location and make it the active location. Shuffle the encounter deck.")
                .WithFlavorLine("\"I have crossed many mountains and many rivers, and trodden many plains, even into the far countries of Rhûn and Harad where the stars are strange...\" —Aragorn, The Fellowship of the Ring")
                .WithTemplate("<p><b>Action:</b> Exhaust a {trait:Ranger.@Ranger} or {trait:Scout.@Scout} character to discard a non-unique active location. Then, search the encounter deck and discard pile for a non-unique location and make it the active location. Shuffle the encounter deck.</p><p style='text-align:center'>&quot;I have crossed many mountains and many rivers, and trodden many plains, even into the far countries of Rhûn and Harad where the stars are strange...&quot;<br>&ndash;Aragorn, The Fellowship of the Ring</i></p>")
                .WithInfo(36, 3, Artist.John_Stanko);
            addEvent("Keen as Lances", 5, Sphere.Neutral)
                .WithTextLine("Reduce the cost to play Keen as Lances by 1 for each card worth no victory points in the victory display.")
                .WithTextLine("Action: Add Keen as Lances to the victory display. Then, choose one: add 2 resources to a hero's resource pool, draw 3 cards, or reduce your threat by 4.")
                .WithInfo(37, 3, Artist.Magali_Villeneuve);
            addQuest("Unexpected Rescue", EncounterSet.EscapeFromMountGram, 1, 'A', Card.VALUE_NA)
                .WithTextLine("Setup: Each player shuffles his starting hand into his deck. Each player prepares a separate captured deck (see insert). Each player adds 2 resources to his starting hero and sets his threat to that hero's threat cost. Set Southern ~Gate, Jailor Gornákh and the Angmar Orcs encounter set aside, out of play. Shuffle the encounter deck. Each player draws a new starting hand of 3 cards.")
                .WithFlavorLine("You have been captured and imprisoned by the goblins of Mount Gram.")
                .WithOppositeTextLine("When Revealed: Each player creates his own staging area and advances to a different stage 2A.")
                .WithOppositeFlavorLine("You have endured much during your imprisonment in Mount Gram at the hands of a cruel goblin known as Gornákh. But before you are taken north as prizes for \"Lord Daechanar,\" Amarthiúl comes to your rescue. After he frees you, he slips off to find Iârion, whom you suspect is imprisoned nearby. Armed with only your wits and resolve, you must find the rest of your company.")
                .WithIncludedEncounterSets(EncounterSet.AngmarOrcs)
                .WithInfo(38, 1, Artist.Tomasz_Jedruszek);
            addQuest("Gornákh's Dungeons", EncounterSet.EscapeFromMountGram, 2, 'A', Card.VALUE_NA)
                .WithKeywords("Capture 7.")
                .WithTextLine("When Revealed: Search the encounter deck for 1 copy of Prison Cell, reveal it, and add it to your staging area. Then capture an additional 2 cards from the top of your captured deck underneath that copy of Prison Cell.")
                .WithFlavorLine("Alone and without your equipment, you steel yourself and being to search for your companions and belongings.")
                .WithOppositeTextLine("Any time players would place progress on this quest, resuce an equal number of captured cards at random from underneath it instead. (Progress is placed on the active location before triggering this effect.)")
                .WithOppositeTextLine("Forced: If there are no captured cards underneath Gornákh's Dungeons, join another player at the beginning of the travel phase. If you cannot join another player, all players advance to stage 3A together.")
                .WithIncludedEncounterSets(EncounterSet.AngmarOrcs)
                .WithInfo(39, 4, Artist.Katayanagi);
            addQuest("Flight from Mount Gram", EncounterSet.EscapeFromMountGram, 3, 'A', 16)
                .WithTextLine("When Revealed: Add Southern ~Gate and Jailor Gornakh to the staging area. Shuffle the Angmar Orcs encounter set into the encounter deck. Then, reveal 1 encounter card per player from the top of the encounter deck.")
                .WithFlavorLine("Having rescued as many of your companions as you can find, you begin to make your way towards the dungeon's hidden exit. By now Gornákh is surely aware of your escape, and the orcs that were with Thaurdir are now searching for you, as well.")
                .WithOppositeTextLine("The player cannot travel to Southern ~Gate unless there is at least 16 progress on this stage.")
                .WithOppositeTextLine("The players cannot defeat this stage while Souther ~Gate is in play. If the players defeat this stage, they have escaped Mount Gram and win the game.")
                .WithOppositeFlavorLine("Orcs and Goblins rush to find you before you can make your escape. You must make haste if you wish to make it out of Mount Gram alive!")
                .WithIncludedEncounterSets(EncounterSet.AngmarOrcs)
                .WithInfo(40, 1, Artist.Lukasz_Jaskolski);
            addEnemy("Jailor Gornákh", EncounterSet.EscapeFromMountGram, 44, 3, 5, 3, 8)
                .WithUnique()
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("Forced: After 1 or more captured cards are rescued, Jailor Gornákh engages the player with the highest threat and makes an immediate attack.")
                .WithFlavorLine("\"Come on now! We've talked enough. Let's go and have a look at the prisoner!\"")
                .WithFlavorLine("-Shagrat, The Two Towers")
                .WithVictoryPoints(5)
                .WithInfo(41, 1, Artist.Joel_Hustak);
            addLocation("Southern Gate", EncounterSet.EscapeFromMountGram, 3, 8)
                .WithUnique()
                .WithTraits("Mountain.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("White Southern ~Gate s the active location, each Orc enemy gets +2 Attack.")
                .WithTextLine("Forced: When Southern ~Gate becomes the active location, each player with less than 35 threat must raise his threat to 35.")
                .WithVictoryPoints(2)
                .WithInfo(42, 1, Artist.Jake_Bullock);
            addEnemy("Cruel Torturer", EncounterSet.EscapeFromMountGram, 36, 2, 3, 2, 3)
                .WithTraits("Goblin.", "Orc.")
                .WithKeywords("Capture 1.")
                .WithTextLine("Forced: When Cruel Torturer would damage an ally by an attack, capture that ally underneath Cruel Torturer instead.")
                .WithFlavorLine("\"You'll get bed and breakfast all right: more than you can stomach\"")
                .WithFlavorLine("-Uglúk, The Two Towers")
                .WithInfo(43, 2, Artist.Nicholas_Gregory);
            addEnemy("Dungeon Guard", EncounterSet.EscapeFromMountGram, 16, 1, 2, 1, 2)
                .WithTraits("Goblin.", "Orc.")
                .WithKeywords("Capture 1.")
                .WithTextLine("Response: After the captured card(s) underneath Dungeon Guard are rescued, the players may put 1 of them into play at no cost.")
                .WithInfo(44, 3, Artist.Anthony_Feliciano);
            addEnemy("Goblin Tormentor", EncounterSet.EscapeFromMountGram, 28, 2, Card.VALUE_X, 1, 3)
                .WithTraits("Goblin.", "Orc.")
                .WithKeywords("Capture 1.")
                .WithTextLine("X is the number of cards in play with 1 or more captured cards underneath them.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if it has no captured cards underneath it).")
                .WithEasyModeQuantity(0)
                .WithInfo(45, 2, Artist.Rafal_Hrynkiewicz);
            addLocation("Prison Cell", EncounterSet.EscapeFromMountGram, 1, 3)
                .WithTraits("Underground.")
                .WithKeywords("Capture 1.")
                .WithTextLine("Response: After the players travel to Prison Cell, look at the captured card(s) underneath it and choose 1 to put into play at no cost. Place the other cards back underneath Prison Cell.")
                .WithFlavorLine("...goblins don't care who they catch, as long as it isa done smart and secret, and the prisoners are not able to defend themselves.")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(46, 4, Artist.Ferdinand_Dumago_Ladera);
            addLocation("Patrol Room", EncounterSet.EscapeFromMountGram, 3, 2)
                .WithTraits("Underground.")
                .WithKeywords("Capture 2.")
                .WithTextLine("Travel: Each player raises his threat by 3 to travel here.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending player's threat is 20 or higher).")
                .WithInfo(47, 2, Artist.Jordan_Saia);
            addLocation("Tunnels of Mount Gram", EncounterSet.EscapeFromMountGram, Card.VALUE_X, 4)
                .WithTraits("Underground.")
                .WithKeywords("Capture 1.")
                .WithTextLine("X is the number of captured cards underneath Tunnels of Mount Gram.")
                .WithShadow("Shadow: Capture each attachment attached to the defending character underneath the attacking enemy.")
                .WithInfo(48, 2, Artist.Ferdinand_Dumago_Ladera);
            addTreachery("Sound the Alarm!", EncounterSet.EscapeFromMountGram)
                .WithKeywords("Doomed 3.")
                .WithTextLine("When Revealed: Until the end of the round, each enemy gets -10 engagement cost and +1 Attack. If there are no enemies in play, search the encounter deck and discard pile for an enemy and add it to the staging area.")
                .WithEasyModeQuantity(1)
                .WithInfo(49, 2, Artist.Owen_William_Weber);
            addTreachery("Feeble and Weary", EncounterSet.EscapeFromMountGram)
                .WithTextLine("When Revealed: Each player must either deal 1 damage to each exhausted character he controls, or remove each exhausted character he controls from the quest.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithInfo(50, 2, Artist.Tawny_Fritzinger);
            addTreachery("Captives of Gornákh", EncounterSet.EscapeFromMountGram)
                .WithTextLine("When Revealed: Each player chooses one of his allies and captures it underneath the encounter card with the highest Threat.")
                .WithShadow("Shadow: If this attack would damage an ally, capture that ally underneath the attacking enemy instead.")
                .WithEasyModeQuantity(1)
                .WithInfo(51, 2, Artist.Kaija_Rudkiewicz);
            addTreachery("Interrogation", EncounterSet.EscapeFromMountGram)
                .WithTextLine("When Revealed: Each player discards the top card of his captured deck and raises his threat by that card's printed resource cost. If at least 1 player discarded no cards from this effect, Interrogation gains Doomed 2.")
                .WithShadow("Shadow: Discard a random card from your hand and raise your threat by its printed cost.")
                .WithInfo(52, 2, Artist.Rafal_Hrynkiewicz);
            addEncounterSideQuest("Stop the Executioners!", EncounterSet.EscapeFromMountGram, 6)
                .WithKeywords("Capture 5.", "Time 4.")
                .WithTextLine("Forced: When the last time counter is removed from this quest, discard its captured cards and remove this quest from the game. Then, raise each player's threat by 3 for each of his characters that was discarded by this effect.")
                .WithFlavorLine("Several of your captured companions are being sent to the executioner's block. If you make it in time, you might be able to save them before they are slain!")
                .WithVictoryPoints(10)
                .WithInfo(53, 1, Artist.Guillaume_Ducos);
        }
    }
}
