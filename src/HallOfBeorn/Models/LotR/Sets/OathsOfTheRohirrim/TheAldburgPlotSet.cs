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
                .WithInfo(1, 1, Artist.Unknown); //Yang_Zhao
            addHero("Widfast", 10, Sphere.Spirit, 2, 1, 2, 3)
                .WithTraits("Woodman.", "Scout.")
                .WithTextLine("Setup: Search your collection for a Creature ally and add it to your hand. For the first round, reduce its cost by 2.")
                .WithTextLine("Travel Action: If there is 1 active location, spend 1 resource from Widfast's pool to travel to another location, resolving its Travel effect. (There are now 2 active locations.)")
                .WithTemplate("<p class='main-text'><b>Setup:</b> Search your collection for a {trait:Creature.@Creature} ally and add it to your hand. For the first round, reduce its cost by 2.</p><p class='main-text'><b>Travel Action:</b> If there is 1 active location, spend 1 resource from {self}'s pool to travel to another location, resolving its <b>Travel</b> effect. (There are now 2 active locations.)</p>")
                .WithInfo(2, 1, Artist.Unknown); //Katerina Poliskova
            addAlly("Lily Cotton", 2, Sphere.Leadership, true, 1, 1, 1, 2)
                .WithTraits("Hobbit.")
                .WithTextLine("Action: Exhaust Lily Cotton to ready a different Hobbit ally and add Lily Cotton's Willpower, Attack, and Defense to that ally's Willpower, Attack, and Defense respectively until the end of the phase. At the end of the phase, if that ally is still in play, return it to your hand (Limit once per phase.)")
                .WithFlavorLine("There is little or no magic about them, except the ordinary everyday sort which helps them disappear quietly and quickly...")
                .WithFlavorLine("-The Hobbit")
                .WithTemplate("<p class='main-text'><b>Action:</b> Exhaust {self} to ready a different {trait:Hobbit.@Hobbit} ally and add {self}'s {Willpower}, {Attack}, and {Defense} to that ally's {Willpower}, {Attack}, and {Defense} respectively until the end of the phase. At the end of the phase, if that ally is still in play, return it to your hand (Limit once per phase.)</p><p class='main-text'></p><p class='flavor-text'>There is little or no magic about them, except the ordinary everyday sort which helps them disappear quietly and quickly...<br>&mdash;The Hobbit</p>")
                .WithInfo(3, 3, Artist.Unknown); //Francisco Amadio
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
                .WithInfo(5, 3, Artist.Unknown); //Dan_Pilla
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
                .WithInfo(7, 3, Artist.Unknown); //Andrea Piparo
            addEvent("Fear! Fire! Foes!", 2, Sphere.Lore)
                .WithKeywords("Secrecy 1.")
                .WithTextLine("Secrecy 1. Play only if you do not control a Warrior hero.")
                .WithTextLine("Action: Choose a non-unique enemy and an attribute (Threat, Attack, or Defense). Until the end of the phase, reduce the chosen attribute of that enemy to 0.")
                .WithFlavorLine("Far away answering horns were heard. The alarm was spreading.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithTemplate("<p class='main-text'>{keyword:Secrecy 1.} Play only if you do not control a {trait:Warrior.@Warrior} hero.</p><p class='main-text'><b>Action:</b> Choose a non-unique enemy and an attribute ({Threat}, {Attack}, or {Defense}). Until the end of the phase, reduce the chosen attribute of that enemy to 0.</p><p class='flavor-text'>Far away answering horns were heard. The alarm was spreading.<br>&mdashThe Fellowship of the Ring</p>")
                .WithInfo(8, 3, Artist.John_Howe);
            addAttachment("Horn-call of Buckland", 1, Sphere.Lore, true)
                .WithTraits("Skill.")
                .WithTextLine("Attach to a Lore or Hobbit hero.")
                .WithTextLine("Response: After you engage an enemy that shares a Trait with an enemy in the victory display, exhaust Horn-call of Buckland to ready attached hero. Then, that enemy gets -1 Attack and -1 Defense until the end of the round.")
                .WithFlavorLine("At that moment, among the tress nearby, a horn rang out. It rent the night like fire on a hill-top.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithTemplate("<p class='main-text'>Attach to a {sphere:Lore} or {trait:Hobbit.@Hobbit} hero.</p><p class='main-text'><b>Response:</b> After you engage an enemy that shares a <b><i>Trait</i></b> with an enemy in the victory display, exhaust {self} to ready attached hero. Then, that enemy gets -1 {Attack} and -1 {Defense} until the end of the round.</p><p class='flavor-text'></p>")
                .WithInfo(9, 3, Artist.Unknown); //Peter_Polach
            addAlly("Young Tom", 1, Sphere.Spirit, true, 1, 1, 0, 1)
                .WithTraits("Hobbit.")
                .WithTextLine("During the round that Young Tom enters play, enemies get +5 engagement cost.")
                .WithFlavorLine("\"Not all is well there,\" said Frodo, \"but certainly gardeners are honoured.\"")
                .WithFlavorLine("-The Two Towers")
                .WithTemplate("<p class='main-text'>During the round that {self} enters play, enemies get +5 engagement cost.</p><p class='flavor-text'>&ldquo;Not all is well there,&rdquo; said Frodo, &ldquo;but certainly gardeners are honoured.&rdquo;<br>&mdash;The Two Towers</p>")
                .WithInfo(10, 3, Artist.Unknown); //Franco Rivelli
            addAlly("Gavin", 2, Sphere.Spirit, true, 1, 1, 0, 1)
                .WithTraits("Creature.", "Scout.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Response: After resolving the staging of an encounter card without surge, exhaust Gavin to give that card surge and add 1 resource to the pool of Scout hero you control. If the next encounter card revealed is not a location, discard it without resolving its effects.")
                .WithTemplate("<p class='main-text'>Cannot have attachments.</p><p class='main-text'><b>Response:</b> After resolving the staging of an encounter card without surge, exhaust {self} to give that card surge and add 1 resource to the pool of {trait:Scout.@Scout} hero you control. If the next encounter card revealed is not a location, discard it without resolving its effects.</p>")
                .WithInfo(11, 3, Artist.Unknown); //Paul Scott Camavan
            addEncounterSideQuest("Red Harvest", EncounterSet.TheAldburgPlot, 4)
                .WithVictoryPoints(10)
                .WithInfo(12, 1, Artist.Unknown);
            addEncounterSideQuest("The Prisoner in White", EncounterSet.TheAldburgPlot, 4)
                .WithVictoryPoints(10)
                .WithInfo(13, 1, Artist.Unknown);
            addEncounterSideQuest("The Man with the Twisted Lip", EncounterSet.TheAldburgPlot, 8)
                .WithVictoryPoints(10)
                .WithInfo(14, 1, Artist.Unknown);
            addEncounterSideQuest("A Fire Rises", EncounterSet.TheAldburgPlot, 4)
                .WithVictoryPoints(10)
                .WithInfo(15, 1, Artist.Unknown);
            addEncounterSideQuest("A Case of Identity", EncounterSet.TheAldburgPlot, 6)
                .WithVictoryPoints(10)
                .WithInfo(16, 1, Artist.Unknown);
            addEncounterSideQuest("Whisperer in the Darkness", EncounterSet.TheAldburgPlot, 6)
                .WithVictoryPoints(10)
                .WithInfo(17, 1, Artist.Unknown);
            addObjective("Spreading Inferno", EncounterSet.TheAldburgPlot)
                .WithTraits("Inferno.", "Suspicious.")
                .WithKeywords("Guarded (location).")
                .WithSideA()
                .WithInfo(18, 1, Artist.Unknown);
            addObjective("Ruby Cloak-pin", EncounterSet.TheAldburgPlot)
                .WithTraits("Clue.")
                .WithSideB()
                .WithInfo(18, 1, Artist.Unknown);
            addEnemy("The Whisperer", EncounterSet.TheAldburgPlot, 45, 3, 5, 3, 5)
                .WithUnique()
                .WithTraits("Gondor.", "Traitor.", "Suspicious.")
                .WithSideA()
                .WithInfo(19, 1, Artist.Unknown);
            addObjective("Silver Dagger", EncounterSet.TheAldburgPlot)
                .WithTraits("Clue.")
                .WithSideB()
                .WithInfo(19, 1, Artist.Unknown);
            addEnemy("The Spy Master", EncounterSet.TheAldburgPlot, 0, 2, 4, 4, 6)
                .WithUnique()
                .WithTraits("Rohan.", "Spy.", "Suspicious.")
                .WithSideA()
                .WithInfo(20, 1, Artist.Unknown);
            addObjective("Prison Key", EncounterSet.TheAldburgPlot)
                .WithTraits("Clue.")
                .WithSideB()
                .WithInfo(20, 1, Artist.Unknown);
            addEnemy("Ossian", EncounterSet.TheAldburgPlot, 50, 3, 6, 5, 7)
                .WithTraits("Rohan.", "Assassin.", "Suspicious.")
                .WithSideA()
                .WithInfo(21, 1, Artist.Unknown);
            addObjective("Traitor's Confession", EncounterSet.TheAldburgPlot)
                .WithTraits("Clue.")
                .WithSideB()
                .WithInfo(21, 1, Artist.Unknown);
            addLocation("Garrison Barracks", EncounterSet.TheAldburgPlot, Card.VALUE_X, 4)
                .WithUnique()
                .WithTraits("Aldburg.", "Suspicious.")
                .WithSideA()
                .WithInfo(22, 1, Artist.Unknown);
            addObjective("Raven Signet Ring", EncounterSet.TheAldburgPlot)
                .WithTraits("Clue.")
                .WithSideB()
                .WithInfo(22, 1, Artist.Unknown);
            addLocation("The Horse's Tail", EncounterSet.TheAldburgPlot, Card.VALUE_X, 6)
                .WithUnique()
                .WithTraits("Aldburg.", "Suspicious.")
                .WithSideA()
                .WithInfo(23, 1, Artist.Unknown);
            addObjective("Rohirric Coins", EncounterSet.TheAldburgPlot)
                .WithTraits("Clue.")
                .WithSideB()
                .WithInfo(23, 1, Artist.Unknown);
            addLocation("The Armoury", EncounterSet.TheAldburgPlot, 2, 4)
                .WithUnique()
                .WithTraits("Aldburg.", "Suspicious.")
                .WithSideA()
                .WithInfo(24, 1, Artist.Unknown);
            addObjective("Red Fletched Arrow", EncounterSet.TheAldburgPlot)
                .WithTraits("Clue.")
                .WithSideB()
                .WithInfo(24, 1, Artist.Aleksander_Karcz);
            addLocation("Great Mead Hall", EncounterSet.TheAldburgPlot, 3, 5)
                .WithUnique()
                .WithTraits("Aldburg.", "Suspicious.")
                .WithSideA()
                .WithInfo(25, 1, Artist.Unknown);
            addObjective("Letter from Dunland", EncounterSet.TheAldburgPlot)
                .WithTraits("Clue.")
                .WithSideB()
                .WithInfo(25, 1, Artist.Tiziano_Baracchi);
            addEnemy("Town Guard", EncounterSet.TheAldburgPlot, 45, 3, 4, 4, 2)
                .WithTraits("Garrison.")
                .WithInfo(26, 3, Artist.Bethesda_Softworks);
            addEnemy("Dunlending Agents", EncounterSet.TheAldburgPlot, 35, 1, 4, 2, 4)
                .WithTraits("Dunland.")
                .WithInfo(27, 3, Artist.Grafit_Studio);
            addEnemy("Aldburg Malcontent", EncounterSet.TheAldburgPlot, 25, 1, 3, 2, 3)
                .WithTraits("Rohan.", "Traitor.")
                .WithInfo(28, 2, Artist.Unknown);
            addLocation("Misty Street", EncounterSet.TheAldburgPlot, 2, 2)
                .WithTraits("Aldburg.")
                .WithInfo(29, 2, Artist.Unknown);
            addLocation("Well-lit Hall", EncounterSet.TheAldburgPlot, 2, 1)
                .WithTraits("Aldburg.")
                .WithInfo(30, 2, Artist.Jon_Hodgson);
            addLocation("Decrepit Hovel", EncounterSet.TheAldburgPlot, 1, 3)
                .WithTraits("Aldburg.")
                .WithInfo(31, 3, Artist.Unknown);
            addTreachery("Taken by the Night", EncounterSet.TheAldburgPlot)
                .WithInfo(32, 2, Artist.Unknown);
            addTreachery("False Lead", EncounterSet.TheAldburgPlot)
                .WithKeywords("Doomed 1.")
                .WithInfo(33, 3, Artist.Unknown);
            addTreachery("Sudden Ambush", EncounterSet.TheAldburgPlot)
                .WithInfo(34, 1, Artist.Unknown);
            addQuest("Evil Under the Moon", EncounterSet.TheAldburgPlot, 1, 'A', Card.VALUE_NA)
                .WithInfo(35, 1, Artist.Unknown);
            addQuest("Gathering Clues", EncounterSet.TheAldburgPlot, 2, 'A', Card.VALUE_NA)
                .WithInfo(36, 1, Artist.Igor_Kieryluk);
            addQuest("The Uncertain Dawn", EncounterSet.TheAldburgPlot, 3, 'A', 45)
                .WithInfo(37, 1, Artist.Unknown);
        }
    }
}