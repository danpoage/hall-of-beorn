using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.OathsOfTheRohirrim
{
    public class TheAldburgPlotSet
        : CardSet
    {
        private const string setName = "The Aldburg Plot";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TAP";
            Number = 10002;
            SetType = Models.SetType.A_Long_extended_Party;
            Cycle = "Oaths of the Rohirrim";

            addHero("Fatty Bolger", 7, Sphere.Lore, 1, 1, 2, 3)
                .WithTraits("Hobbit.")
                .WithTextLine("Setup: Reduce your threat by 2.")
                .WithTextLine("Response: Raise your threat by 4 and exhaust Fatty Bolger to cancel a non-unique enemy just revealed from the encounter deck and add it to the victory display. (Limit once per game for the group.)")
                .WithFlavorLine("Fatty Bolger had not been idle. As soon as he saw the dark shapes creep from the garden, he knew that he must run for it, or perish.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithTemplate("<p class='main-text'><b>Setup:</b> Reduce your threat by 2.</p><p class='main-text'><b>Response:</b> Raise your threat by 4 and exhaust {self} to cancel a non-unique enemy just revealed from the encounter deck and add it to the victory display. (Limit once per game for the group.)</p><p class='flavor-text'>Fatty Bolger had not been idle. As soon as he saw the dark shapes creep from the garden, he knew that he must run for it, or perish.<br>&mdash;The Fellowship of the Ring</p>")
                .WithInfo(1, 1, Artist.Yang_Zhao);
            addHero("Widfast", 10, Sphere.Spirit, 2, 1, 2, 3)
                .WithTraits("Woodman.", "Scout.")
                .WithTextLine("Setup: Search your collection for a Creature ally and add it to your hand. For the first round, reduce its cost by 2.")
                .WithTextLine("Travel Action: If there is 1 active location, spend 1 resource from Widfast's pool to travel to another location, resolving its Travel effect. (There are now 2 active locations.)")
                .WithTemplate("<p class='main-text'><b>Setup:</b> Search your collection for a {trait:Creature.@Creature} ally and add it to your hand. For the first round, reduce its cost by 2.</p><p class='main-text'><b>Travel Action:</b> If there is 1 active location, spend 1 resource from {self}'s pool to travel to another location, resolving its <b>Travel</b> effect. (There are now 2 active locations.)</p>")
                .WithInfo(2, 1, Artist.Katerina_Poliakova);
            addAlly("Lily Cotton", 2, Sphere.Leadership, true, 1, 1, 1, 2)
                .WithTraits("Hobbit.")
                .WithTextLine("Action: Exhaust Lily Cotton to ready a different Hobbit ally and add Lily Cotton's Willpower, Attack, and Defense to that ally's Willpower, Attack, and Defense respectively until the end of the phase. At the end of the phase, if that ally is still in play, return it to your hand (Limit once per phase.)")
                .WithFlavorLine("There is little or no magic about them, except the ordinary everyday sort which helps them disappear quietly and quickly...")
                .WithFlavorLine("-The Hobbit")
                .WithTemplate("<p class='main-text'><b>Action:</b> Exhaust {self} to ready a different {trait:Hobbit.@Hobbit} ally and add {self}'s {Willpower}, {Attack}, and {Defense} to that ally's {Willpower}, {Attack}, and {Defense} respectively until the end of the phase. At the end of the phase, if that ally is still in play, return it to your hand (Limit once per phase.)</p><p class='main-text'></p><p class='flavor-text'>There is little or no magic about them, except the ordinary everyday sort which helps them disappear quietly and quickly...<br>&mdash;The Hobbit</p>")
                .WithInfo(3, 3, Artist.Francesco_Amadio);
            addEvent("A Lesson in Caution", 1, Sphere.Leadership)
                .WithKeywords("Secrecy 1.")
                .WithTextLine("Secrecy 1.")
                .WithTextLine("Action: Draw 1 card. Then, either reduce your threat by 2, or the next card you play this phase gains secrecy 1.")
                .WithFlavorLine("Hobbits go light, and their footprints are not easy even for a Ranger to read...")
                .WithFlavorLine("-The Two Towers")
                .WithTemplate("<p class='main-text'>{keyword:Secrecy 1.}</p><p class='main-text'><b>Action:</b> Draw 1 card. Then, either reduce your threat by 2, or the next card you play this phase gains secrecy 1.</p><p class='flavor-text'>Hobbits go light, and their footprints are not easy even for a Ranger to read...<br>&mdash;The Two Towers</p>")
                .WithInfo(4, 3, Artist.John_Howe);
            addEvent("There and Back Again", 1, Sphere.Leadership)
                .WithKeywords("Secrecy 1.")
                .WithTextLine("Response: After a Hobbit ally leaves play, search your hand or discard pile for a copy of that ally and put it into play, under any player's control.")
                .WithFlavorLine("The legal bother, indeed, lasted for years. It was quite a long time before Mr. Baggins was in fact admitted to be alive again.")
                .WithFlavorLine("-The Hobbit")
                .WithTemplate("<p class='main-text'>{keyword:Secrecy 1.}</p><p class='main-text'><b>Response:</b> After a {trait:Hobbit.@Hobbit} ally leaves play, search your hand or discard pile for a copy of that ally and put it into play, under any player's control.</p><p class='flavor-text'>The legal bother, indeed, lasted for years. It was quite a long time before Mr. Baggins was in fact admitted to be alive again.<br>&mdash;The Hobbit</p>")
                .WithInfo(5, 3, Artist.Dan_Pilla);
            addAlly("Buckland Shirriff", 3, Sphere.Lore, false, 1, 2, 0, 2)
                .WithTraits("Hobbit.", "Shirriff.")
                .WithKeywords("Devoted.", "Ranged.")
                .WithTextLine("Response: After an enemy that shares a Trait with an enemy in the victory display is added to the staging area, spend 1 Lore resource to put Buckland Shirriff into play from your hand, under your control.")
                .WithTemplate("<p class='main-text'>{keyword:Devoted.} {keyword:Ranged.}</p><p class='main-text'><b>Response:</b> After an enemy that shares a <b><i>Trait</i></b> with an enemy in the victory display is added to the staging area, spend 1 {sphere:Lore} resource to put {self} into play from your hand, under your control.</p><p class='flavor-text'></p>")
                .WithInfo(6, 3, Artist.Justin_Gerard);
            addEvent("Weep No More!", 1, Sphere.Lore)
                .WithTextLine("Limit 3 copies of Weep No More! in the victory display.")
                .WithTextLine("Response: After a \"when revealed\" effect or a shadow effect on a treachery card resolved, add Weep No More! to the victory display to add that treachery card to the victory display.")
                .WithFlavorLine("\"At least we may yet be avenged. Let us gird ourselves and weep no more!\"")
                .WithFlavorLine("-Aragorn, The Fellowship of the Ring")
                .WithTemplate("<p class='main-text'>Limit 3 copies of {self} in the victory display.</p><p class='main-text'><b>Response:</b> After a \"when revealed\" effect or a shadow effect on a treachery card resolved, add {self} to the victory display to add that treachery card to the victory display.</p><p class='flavor-text'>&ldquo;At least we may yet be avenged. Let us gird ourselves and weep no more!&rdquo;<br>&mdash;Aragorn, The Fellowship of the Ring</p>")
                .WithInfo(7, 3, Artist.Andrea_Piparo);
            addEvent("Fear! Fire! Foes!", 2, Sphere.Lore)
                .WithKeywords("Secrecy 1.")
                .WithTextLine("Secrecy 1. Play only if you do not control a Warrior hero.")
                .WithTextLine("Action: Choose a non-unique enemy and an attribute (Threat, Attack, or Defense). Until the end of the phase, reduce the chosen attribute of that enemy to 0.")
                .WithFlavorLine("Far away answering horns were heard. The alarm was spreading.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithTemplate("<p class='main-text'>{keyword:Secrecy 1.} Play only if you do not control a {trait:Warrior.@Warrior} hero.</p><p class='main-text'><b>Action:</b> Choose a non-unique enemy and an attribute ({Threat}, {Attack}, or {Defense}). Until the end of the phase, reduce the chosen attribute of that enemy to 0.</p><p class='flavor-text'>Far away answering horns were heard. The alarm was spreading.<br>&mdash;The Fellowship of the Ring</p>")
                .WithInfo(8, 3, Artist.John_Howe);
            addAttachment("Horn-call of Buckland", 1, Sphere.Lore, true)
                .WithTraits("Skill.")
                .WithTextLine("Attach to a Lore or Hobbit hero.")
                .WithTextLine("Response: After you engage an enemy that shares a Trait with an enemy in the victory display, exhaust Horn-call of Buckland to ready attached hero. Then, that enemy gets -1 Attack and -1 Defense until the end of the round.")
                .WithFlavorLine("At that moment, among the tress nearby, a horn rang out. It rent the night like fire on a hill-top.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithTemplate("<p class='main-text'>Attach to a {sphere:Lore} or {trait:Hobbit.@Hobbit} hero.</p><p class='main-text'><b>Response:</b> After you engage an enemy that shares a <b><i>Trait</i></b> with an enemy in the victory display, exhaust {self} to ready attached hero. Then, that enemy gets -1 {Attack} and -1 {Defense} until the end of the round.</p><p class='flavor-text'></p>")
                .WithInfo(9, 3, Artist.Peter_Polach);
            addAlly("Young Tom", 1, Sphere.Spirit, true, 1, 1, 0, 1)
                .WithTraits("Hobbit.")
                .WithTextLine("During the round that Young Tom enters play, enemies get +5 engagement cost.")
                .WithFlavorLine("\"Not all is well there,\" said Frodo, \"but certainly gardeners are honoured.\"")
                .WithFlavorLine("-The Two Towers")
                .WithTemplate("<p class='main-text'>During the round that {self} enters play, enemies get +5 engagement cost.</p><p class='flavor-text'>&ldquo;Not all is well there,&rdquo; said Frodo, &ldquo;but certainly gardeners are honoured.&rdquo;<br>&mdash;The Two Towers</p>")
                .WithInfo(10, 3, Artist.Franco_Rivolli);
            addAlly("Gavin", 2, Sphere.Spirit, true, 1, 1, 0, 1)
                .WithTraits("Creature.", "Scout.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Response: After resolving the staging of an encounter card without surge, exhaust Gavin to give that card surge and add 1 resource to the pool of a Scout hero you control. If the next encounter card revealed is not a location, discard it without resolving its effects.")
                .WithTemplate("<p class='main-text'>Cannot have attachments.</p><p class='main-text'><b>Response:</b> After resolving the staging of an encounter card without surge, exhaust {self} to give that card surge and add 1 resource to the pool of a {trait:Scout.@Scout} hero you control. If the next encounter card revealed is not a location, discard it without resolving its effects.</p>")
                .WithInfo(11, 3, Artist.Paul_Canavan);

            addEncounterSideQuest("Red Harvest", EncounterSet.TheAldburgPlot, 4)
                .WithFlavorLine("With brutal speed, The Whisperer's men fall upon you. You'll have to fight tooth and nail to make your way to the armoury.")
                .WithTextLine("Forced: After an enemy engages a player, that player deals 2 damage to a character they control.")
                .WithTextLine("Forced: After this stage is defeated, shuffle the encounter discard pile into the encounter deck. Each player discards cards from the encounter deck until an enemy is discarded and adds that enemy to the staging area. Add The Armoury to the staging area.")
                .WithVictoryPoints(10)
                .WithInfo(12, 1, Artist.Jon_Foster);
            addEncounterSideQuest("The Prisoner in White", EncounterSet.TheAldburgPlot, 4)
                .WithFlavorLine("In an attempt to cover his tracks, the spy master's agent has infiltrated the prison.")
                .WithTextLine("The players cannot travel to locations or make locations active with player card effects.")
                .WithTextLine("Forced: After this stage is defeated, add Ossian to the staging area.")
                .WithVictoryPoints(10)
                .WithInfo(13, 1, Artist.Taleworlds_Entertainment);
            addEncounterSideQuest("The Man with the Twisted Lip", EncounterSet.TheAldburgPlot, 8)
                .WithFlavorLine("You've begun to track the secretive spy master of Aldburg, though it's hard to tell which of you is the cat and which is the mouse.")
                .WithTextLine("Forced: At the end of the round, raise each player's threat by 1.")
                .WithTextLine("Forced: After this stage is defeated, add The Spy Master to the staging area.")
                .WithVictoryPoints(10)
                .WithInfo(14, 1, Artist.Servia_Art);
            addEncounterSideQuest("A Fire Rises", EncounterSet.TheAldburgPlot, 4)
                .WithFlavorLine("Something foul is afoot in Aldburg. As you begin putting the pieces together, you see smoke and flame from a nearby building.")
                .WithTextLine("Increase the cost to play each event by 1.")
                .WithTextLine("Forced: After this stage is defeated, reveal Spreading Inferno.")
                .WithVictoryPoints(10)
                .WithInfo(15, 1, Artist.Paolo_Puggioni);
            addEncounterSideQuest("A Case of Identity", EncounterSet.TheAldburgPlot, 6)
                .WithFlavorLine("The mystery of The Whisperer's true identity remains. You must be on the right trail, judging by her cutthroats skulking in the alleyways.")
                .WithTextLine("Forced: At the end of the staging step, discard cards from the top of the encounter deck until an enemy is discarded. Reveal that enemy.")
                .WithTextLine("Forced: After this stage is defeated, add Great Mead Hall to the staging area.")
                .WithVictoryPoints(10)
                .WithInfo(16, 1, Artist.Nele_Diel);
            addEncounterSideQuest("Whisperer in the Darkness", EncounterSet.TheAldburgPlot, 6)
                .WithFlavorLine("The tavern was alight with rumors of an assassin called \"The Whisperer.\" If you're to unravel this mystery, you will have to seek her out, and stop her before she strikes.")
                .WithTextLine(">Forced: After a location is explored, raise each player's threat by 1.")
                .WithTextLine("Forced: After this stage is defeated, add The Whisperer to the staging area.")
                .WithVictoryPoints(10)
                .WithInfo(17, 1, Artist.JLIEN);
            addObjective("Spreading Inferno", EncounterSet.TheAldburgPlot)
                .WithTraits("Inferno.", "Suspicious.")
                .WithKeywords("Guarded (location).")
                .WithTextLine("Guarded (location).")
                .WithTextLine("Forced: At the beginning of the travel phase, discard the attached location, raise each player's threat by 1, and discard the lowest printed cost ally controlled by each player. Reveal Spreading Inferno.")
                .WithTextLine("Forced: When the attached location is explored, flip this card over and reveal it.")
                .WithSideA()
                .WithInfo(18, 1, Artist.Elli_Lebedeva);
            addObjective("Ruby Cloak-pin", EncounterSet.TheAldburgPlot)
                .WithTraits("Clue.")
                .WithTextLine("If unattached, attach to a hero with the fewest Clue objectives attached.")
                .WithTextLine("Forced: After attached hero readies, discard the top 4 cards of your deck.")
                .WithFlavorLine("Among the ashes, you recognize this pin immediately. It belongs to the cur Gálmód. Queen Morwen's \"trusted\" advisor.")
                .WithSideB()
                .WithInfo(18, 1, Artist.June_Jenssen);
            addEnemy("The Whisperer", EncounterSet.TheAldburgPlot, 45, 3, 5, 3, 5)
                .WithUnique()
                .WithTraits("Gondor.", "Traitor.", "Suspicious.")
                .WithTextLine("Forced: At the end of the round, return The Whisperer to the staging area, if able. The Whisperer makes an immediate attack against the first player. Damage that would be dealt by this attack is instead assigned as an increase to the first player's threat.")
                .WithTextLine("Forced: When The Whisperer is defeated, flip this card over and reveal it.")
                .WithSideA()
                .WithInfo(19, 1, Artist.Akunohako);
            addObjective("Silver Dagger", EncounterSet.TheAldburgPlot)
                .WithTraits("Clue.")
                .WithTextLine("When Revealed: Add A Case of Identity and Red Harvest to the staging area.")
                .WithTextLine("If unattached, attach to the hero with the fewest Clue objectives attached.")
                .WithTextLine("Forced: After attached hero readies, deal 1 damage to it.")
                .WithFlavorLine("The Whisperer has escaped into the streets of Aldburg, but she has left behind a distinctive, and expensive, weapon.")
                .WithSideB()
                .WithInfo(19, 1, Artist.Bogdan_Marica);
            addEnemy("The Spy Master", EncounterSet.TheAldburgPlot, 0, 2, 4, 4, 6)
                .WithUnique()
                .WithTraits("Rohan.", "Spy.", "Suspicious.")
                .WithTextLine("Forced: When The Spy Master is dealt a shadow card with no shadow effect, deal 1 damage to the defending character and deal The Spy Master another shadow card (limit twice per attack).")
                .WithTextLine("Forced: When The Spy Mmaster is defeated, flip this card over and reveal it.")
                .WithSideA()
                .WithInfo(20, 1, Artist.Bethesda_Softworks);
            addObjective("Prison Key", EncounterSet.TheAldburgPlot)
                .WithTraits("Clue.")
                .WithTextLine("When Revealed: Add A Fire Rises and The Prisoner in White to the staging area.")
                .WithTextLine("If unattached, attach to the hero with the fewest Clue objectives attached.")
                .WithTextLine("Forced: After attached hero readies, discard a non-Clue objective from it.")
                .WithFlavorLine("Wounded and scrabbling for escape, the Spy Master parts with a key detail: one of his agents is already on the move, and heading for the town prison.")
                .WithSideB()
                .WithInfo(20, 1, Artist.Darek_Zabrocki);
            addEnemy("Ossian", EncounterSet.TheAldburgPlot, 50, 3, 6, 5, 7)
                .WithTraits("Rohan.", "Assassin.", "Suspicious.")
                .WithTextLine("Immune to player card effects. Ossian cannot take more than X damage each round, where X is the number of Clue objectives controlled by the players.")
                .WithTextLine("Forced: When Ossian is defeated, flip this card over and reveal it.")
                .WithFlavorLine("You find Ossian bent over a white-clad corpse. Hearing your approach, he turns.")
                .WithSideA()
                .WithInfo(21, 1, Artist.Oleksandra_Ishchenko);
            addObjective("Traitor's Confession", EncounterSet.TheAldburgPlot)
                .WithTraits("Clue.")
                .WithTextLine("If unattached, attach to the hero with the fewest Clue objectives attached.")
                .WithTextLine("Forced: After attached hero readies, discard a card at random from your hand.")
                .WithFlavorLine("With his dying breath, the traitor Ossian reveals Gálmód commanded him to slay one of the members of his own éored: a witness to a terrible betrayal.")
                .WithSideB()
                .WithInfo(21, 1, Artist.Alexander_Nanitchkov);
            addLocation("Garrison Barracks", EncounterSet.TheAldburgPlot, Card.VALUE_X, 4)
                .WithUnique()
                .WithTraits("Aldburg.", "Suspicious.")
                .WithTextLine("Immune to player card effects. X is twice the number of Clue objectives controlled by the players.")
                .WithTextLine("Travel: Shuffle all set aside Dunland enemies into the encounter deck.")
                .WithTextLine("Forced: When Garrison Barracks is explored, flip this card over and reveal it.")
                .WithFlavorLine("The city watch has eyes and ears on everything in Aldburg. But who is watching them?")
                .WithSideA()
                .WithInfo(22, 1, Artist.Michael_Drake);
            addObjective("Raven Signet Ring", EncounterSet.TheAldburgPlot)
                .WithTraits("Clue.")
                .WithTextLine("When Revealed: Add The Man with the Twisted Lip to the staging area.")
                .WithTextLine("If unattached, attach to the hero with the fewest Clue objectives attached.")
                .WithTextLine("Forced: After attached hero readies, discard all resources in its resource pool.")
                .WithFlavorLine("The prisoner has told the guards of an operative called \"the spy master.\" The only lead presently is this ring, believed to belong to him.")
                .WithSideB()
                .WithInfo(22, 1, Artist.Jiefeng_Jiao);
            addLocation("The Horse's Tail", EncounterSet.TheAldburgPlot, Card.VALUE_X, 6)
                .WithUnique()
                .WithTraits("Aldburg.", "Suspicious.")
                .WithTextLine("When Revealed: Add The Man with the Twisted Lip to the staging area.")
                .WithTextLine("If unattached, attach to the hero with the fewest Clue objectives attached.")
                .WithTextLine("Forced: After attached hero readies, discard all resources in its resource pool.")
                .WithFlavorLine("The prisoner has told the guards of an operative called \"the spy master.\" The only lead presently is this ring, believed to belong to him.")
                .WithSideA()
                .WithInfo(23, 1, Artist.Dominik_Zdenkovic);
            addObjective("Rohirric Coins", EncounterSet.TheAldburgPlot)
                .WithTraits("Clue.")
                .WithTextLine("When Revealed: Add Whisperer in the Darkness to the staging area.")
                .WithTextLine("If unattached, attach to a hero with the fewest Clue objectives attached.")
                .WithTextLine("Forced: After attached hero readies, exhaust another character you control.")
                .WithFlavorLine("An unknown figure bumps inot your table. Apologizing profusely, he stumbles into the night. By the time you notice the sack of coin he left behind, he's already gone.")
                .WithSideB()
                .WithInfo(23, 1, Artist.Rockford_Media);
            addLocation("The Armoury", EncounterSet.TheAldburgPlot, 2, 4)
                .WithUnique()
                .WithTraits("Aldburg.", "Suspicious.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Travel: Each player must exhaust the ready character they control with the highest Defense.")
                .WithTextLine("Forced: When The Armoury is explored, flip this card over and reveal it.")
                .WithFlavorLine("The Whisperer wielded a distinctive, familiar-looking dagger. Perhaps the armoury's quartermaster can tell you something about it.")
                .WithSideA()
                .WithInfo(24, 1, Artist.HF_Evergreen);
            addObjective("Red Fletched Arrow", EncounterSet.TheAldburgPlot)
                .WithTraits("Clue.")
                .WithTextLine("If unattached, attach to the hero with the fewest Clue objectives attached.")
                .WithTextLine("Forced: After attached hero readies, raise your threat by 1.")
                .WithFlavorLine("The armoury's quartermaster informs you that he personally forged the dagger, as well as this unusual arrow, for Lord Gálmód.")
                .WithSideB()
                .WithInfo(24, 1, Artist.Aleksander_Karcz);
            addLocation("Great Mead Hall", EncounterSet.TheAldburgPlot, 3, 5)
                .WithUnique()
                .WithTraits("Aldburg.", "Suspicious.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Travel: The players must raise their threat by X where X is the number of enemies in the staging area.")
                .WithTextLine("Forced: When Great Mead Hall is explored, flip this card over and reveal it.")
                .WithFlavorLine("You have tracked the Whisperer's agents to the very halls of Marshal Éomund. How deep does this conspiracy run?")
                .WithSideA()
                .WithInfo(25, 1, Artist.Norm_Newberry);
            addObjective("Letter from Dunland", EncounterSet.TheAldburgPlot)
                .WithTraits("Clue.")
                .WithTextLine("If unattached, attach to the hero with the fewest Clue objectives attached.")
                .WithTextLine("Forced: After attached hero readies, discard 2 progress from each location and quest card.")
                .WithFlavorLine("Hidden away, you find a sealed letter written in choppy Rohirric, signed \"Grimrede.\" It is addresses to a man you thought your friend - Gálmód")
                .WithSideB()
                .WithInfo(25, 1, Artist.Tiziano_Baracchi);
            addEnemy("Town Guard", EncounterSet.TheAldburgPlot, 45, 3, 4, 4, 2)
                .WithTraits("Garrison.")
                .WithTextLine("If the players control 2 or more Clue objectives Town Guard gets +2 Threat.")
                .WithTextLine("Forced: After Town Guard attacks and destroys a character you control. discard 1 resource from each hero you control with a Clue objective.")
                .WithFlavorLine("\"Do I hope in vain that you have been sent to me for a help in doubt and need?\"")
                .WithFlavorLine("-Éomer, The Two Towers")
                .WithEasyModeQuantity(2)
                .WithInfo(26, 3, Artist.Bethesda_Softworks);
            addEnemy("Dunlending Agents", EncounterSet.TheAldburgPlot, 35, 1, 4, 2, 4)
                .WithTraits("Dunland.")
                .WithTextLine("If the players control 2 or more Clue objectives, Dunlending Agents gets +2 Attack.")
                .WithTextLine("Forced: After Dunlending Agents attacks and destroys a character you control, deal 1 damage to each hero you control with a Clue objective.")
                .WithFlavorLine("The Dunlendings and many men of the garrison of the Burg were at work.")
                .WithFlavorLine("-The Return of the King")
                .WithEasyModeQuantity(2)
                .WithInfo(27, 3, Artist.Grafit_Studio);
            addEnemy("Aldburg Malcontent", EncounterSet.TheAldburgPlot, 25, 1, 3, 2, 3)
                .WithTraits("Rohan.", "Traitor.")
                .WithTextLine("When Revealed: If the players control 3 or more Clue objectives, Aldburg Malcontent gains surge.")
                .WithShadow("Shadow: If the players control 2 or more Clue objectives, return attacking enemy to the staging area after this attack.")
                .WithInfo(28, 2, Artist.Tom_Edwards);
            addLocation("Misty Street", EncounterSet.TheAldburgPlot, 2, 2)
                .WithTraits("Aldburg.")
                .WithTextLine("When Revealed: Discard all attachments and tokens from the highest cost ally the first player controls and attach that ally facedown under Misty Street.")
                .WithTextLine("Forced: After Misty Street leaves play, return the attached ally to its owner's control, faceup and ready.")
                .WithShadow("Shadow: Discard a non-Clue attachment you control.")
                .WithInfo(29, 2, Artist.John_Valenti);
            addLocation("Well-lit Hall", EncounterSet.TheAldburgPlot, 2, 1)
                .WithTraits("Aldburg.")
                .WithTextLine("While Well-lit Hall is in the staging area, no more than 3 progress can be placed on a quest card as a result of questing successfully.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending character has a Clue attachment).</p>")
                .WithInfo(30, 2, Artist.Jon_Hodgson);
            addLocation("Decrepit Hovel", EncounterSet.TheAldburgPlot, 1, 3)
                .WithTraits("Aldburg.")
                .WithTextLine("Ally resource costs must be paid from a single hero's resource pool.")
                .WithShadow("Shadow: Discard 1 resource from a hero you control.")
                .WithFlavorLine("\"They go out there roving round, thieving or 'gathering' as they call it.\"")
                .WithFlavorLine("-Tom Cotton, The Return of the King")
                .WithInfo(31, 3, Artist.Artur_Jag);
            addTreachery("Taken by the Night", EncounterSet.TheAldburgPlot)
                .WithTextLine("When Revealed: Each player must discard the lowest printed cost ally they control. If no allies with a printed cost of 2 or higher were discarded this way, Taken by the Night gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if this enemy is attacking from the staging area).")
                .WithInfo(32, 2, Artist.Eric_de_Mander);
            addTreachery("False Lead", EncounterSet.TheAldburgPlot)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Each player removes a hero they control with an attached Clue objective from the quest, if able. Then, each player exhausts a hero they control that is not committed to the quest.")
                .WithFlavorLine("\"...are you now trying to snare me with a flasehood?\"")
                .WithFlavorLine("-Frodo Baggins, The Two Towers")
                .WithEasyModeQuantity(2)
                .WithInfo(33, 3, Artist.Gunship_Revolution);
            addTreachery("Sudden Ambush", EncounterSet.TheAldburgPlot)
                .WithTextLine("When Revealed: The first player must choose: either raise your threat by 4, or the topmost enemy in the encounter discard pile engages you and makes an immediate attack. You must declare the ready character you control with the highest Willpower as the defender for this attack, if able.")
                .WithShadow("Shadow: Resolve this card's \"when revealed\" effect.")
                .WithInfo(34, 1, Artist.Henrik_Karppinen);
            addQuest("Evil Under the Moon", EncounterSet.TheAldburgPlot, 1, 'A', Card.VALUE_NA)
                .WithFlavorLine("With the knowledge that a faction of rebels has taken up residence in Aldburg, Ealdwulf entreats you to root them out.")
                .WithTextLine("Setup: Set each encounter side quest, each copy of Town Guard, and each copy of Dunlending Agents aside, out of play. Set each double-sided encounter card aside, out of play, Clue side facedown. Add Garrison Barracks and The Horse’s Tail to the staging area. Search the encounter deck for an enemy and add it to the staging area (2 different enemies instead if there are 3 or more players). Shuffle the encounter deck")
                .WithOppositeFlavorLine("Where to begin the hunt? Will you seek the help of the town guards or investigate the criminal underworld as a seedy tavern?")
                .WithOppositeTextLine("Enemies cannot be optionally engaged.")
                .WithOppositeTextLine("Forced: At the end of the round, raise each player's threat by 1.")
                .WithOppositeTextLine("If the players control 1 or more Clue objectives, advance to the next stage.")
                .WithIncludedEncounterSets(EncounterSet.RohanEncampment, EncounterSet.FaithlessRohirrim)
                .WithInfo(35, 1, Artist.Nick_Silva);
            addQuest("Gathering Clues", EncounterSet.TheAldburgPlot, 2, 'A', Card.VALUE_NA)
                .WithFlavorLine("The Rohirric town of Aldburg is rife with mystery. Around every corner waits a new riddle, and behind every riddle a sharpened, desperate blade. Before the sun rises, you will have to go deeper to uncover the truth.")
                .WithOppositeFlavorLine("It appears Aldburg is playing host to a twin-headed mystery. If you can only graps a single thread, you may be able to untangle this corrupt and biter web. It is past midnight. Time is drawing thin.")
                .WithOppositeTextLine("Response: At the end of the round, if the players contol at least 4 Clue objectives, they may advance to stage 3A.")
                .WithIncludedEncounterSets(EncounterSet.RohanEncampment, EncounterSet.FaithlessRohirrim)
                .WithInfo(36, 1, Artist.Igor_Kieryluk);
            addQuest("The Uncertain Dawn", EncounterSet.TheAldburgPlot, 3, 'A', 45)
                .WithFlavorLine("As sun breaks over the streets of Aldburg, your cornered foes reveal themselves. You have gathered your clues. Now, bring them to bear as you battle for your lives - and for the soul of Rohan.")
                .WithTextLine("When Revealed: Remove all Suspicious cards and encounter side quests from the game. Add any set aside Dunland or Garrison enemies to the staging area, if able.")
                .WithOppositeTextLine("The Uncertain Dawn gets -5 quest points for each Clue objective the players control.")
                .WithOppositeTextLine("Forced: At the beginning of the quest phase, discard cards from the top of the encounter deck until an enemy is discarded. Reveal that enemy and add it to the staging area.")
                .WithOppositeTextLine("This stage cannot be defeated except at the end of the round. If the players defeat this stage, they win the game.")
                .WithIncludedEncounterSets(EncounterSet.RohanEncampment, EncounterSet.FaithlessRohirrim)
                .WithInfo(37, 1, Artist.Min_Bak);
        }
    }
}