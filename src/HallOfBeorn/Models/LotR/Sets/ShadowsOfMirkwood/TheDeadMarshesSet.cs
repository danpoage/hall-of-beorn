/* Generated CardSet class: The Dead Marshes */

using System;

namespace HallOfBeorn.Models.LotR.Sets.ShadowsOfMirkwood
{
    public class TheDeadMarshesSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Dead Marshes";
            Abbreviation = "TDM";
            Number = 6;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Shadows of Mirkwood";

            addHero("Boromir", 11, Sphere.Tactics, 1, 3, 2, 5)
                .WithTraits("Gondor.", "Noble.", "Warrior.")
                .WithTextLine("Action: Raise your threat by 1 to ready Boromir. (Limit once per phase.)")
                .WithTextLine("Action: Discard Boromir to deal 2 damage to each enemy engaged with a single player.")
                .WithFlavor("\"...in Gondor we must trust to such weapons as we have.\" -The Fellowship of the Ring")
                .WithErrata(1)
                .WithCommunityVersion("Boromir-Grey-Company-Gen-Con-2014")
                .WithCommunityVersion("Boromir-Grey-Company-Gen-Con-2015")
                .WithInfo(95, 1, Artist.Tiziano_Baracchi);
            addAlly("Dúnedain Watcher", 3, Sphere.Leadership, false, 1, 1, 1, 2)
                .WithTraits("Dúnedain.")
                .WithTextLine("Response: Discard Dunedain Watcher from play to cancel the shadow effects of a card just triggered.")
                .WithFlavor("\"If simple folk are free from care and fear, simple they will be, and we must be secret to keep them so. That has been the task of my kindred, while the years have lengthened and the grass has grown.\" -Strider, The Fellowship of the Ring")
                .WithInfo(96, 3, Artist.Lindsey_Messecar);
            addAttachment("Dúnedain Cache", 2, Sphere.Leadership, false)
                .WithTraits("Item.")
                .WithTextLine("Attach to a hero. Attached hero gains ranged.")
                .WithTextLine("Action: Pay 1 resource from attached hero's pool to attach Dunedain Cache to another hero.")
                .WithTemplate("<p>Attach to a hero.</p><p>Attached hero gains ranged.</p><p><b>Action:</b> Pay 1 resource from attached hero's pool to attach {self} to another hero.</p>")
                .WithInfo(97, 3, Artist.Stephanie_M_Brown);
            addAlly("Vassal of the Windlord", 1, Sphere.Tactics, false, 0, 3, 0, 1)
                .WithTraits("Creature.", "Eagle.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged. Vassal of the Windlord cannot have restricted attachments.")
                .WithTextLine("Forced: After an attack in which Vassal of the Windlord attacked resolves, discard Vassal of the Windlord from play.")
                .WithTemplate("<p>{keyword:Ranged.}{self} cannot have restricted attachments.<p><p><b>Forced:</b> After an attack in which {self} attacked resolves, discard {self} from play.</p>")
                .WithInfo(98, 3, Artist.Anna_Christenson);
            addAttachment("Song of Mocking", 1, Sphere.Tactics, false)
                .WithTraits("Song.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Action: Exhaust Song of Mocking to choose another hero. Until the end of the phase, attached hero takes all damage assigned to the chosen hero.")
                .WithFlavor("Old fat spider spinning in a tree!\r\nOld fat spider can't see me!\r\nAttercop! Attercop!\r\nWon't you stop. Stop your spinning and look for me! \r\n-Bilbo Baggins, The Hobbit")
                .WithTemplate("<p>Attach to a hero.</p><p><b>Action:</b> Exhaust {self} to choose another hero. Until the end of the phase, attached hero takes all damage assigned to the chosen hero.</p><p class='flavor-text-smaller'>Old fat spider spinning in a tree!<br>Old fat spider can't see me!<br>Attercop! Attercop!<br>Won't you stop. Stop your spinning and look for me!<br>-Bilbo Baggins, The Hobbit</p>")
                .WithInfo(99, 3, Artist.Carolina_Eade);
            addAlly("Elfhelm", 4, Sphere.Spirit, true, 1, 2, 2, 3)
                .WithTraits("Rohan.", "Warrior.")
                .WithTextLine("While Elfhelm is ready, he gains: 'Response: After your threat is raised as the result of questing unsuccessfully, or by an encounter or quest card effect, reduce your threat by 1.'")
                .WithFlavor("\"But my lord sends word that we must set ourselves in readiness: orders may come for a sudden move.\" -The Return of the King")
                .WithInfo(100, 3, Artist.Magali_Villeneuve);
            addEvent("We Do Not Sleep", 5, Sphere.Spirit)
                .WithTextLine("Action: Until the end of the phase, Rohan characters do not exhaust to commit to quests.")
                .WithFlavor("\"But we must ride more warily; for war is abroad, and the Rohirrim, the Horse-lords, do not sleep, even if it seems so from afar.\" -Gandalf, The Two Towers")
                .WithInfo(101, 3, Artist.Lin_Bo);
            addAlly("Silvan Tracker", 3, Sphere.Lore, false, 1, 1, 1, 3)
                .WithTraits("Silvan.")
                .WithTextLine("Response: After a Silvan character readies during the refresh phase, heal 1 damage from that character.")
                .WithFlavor("\"The Wood-elves tracked him first, an easy task for them, for his trail was still fresh then.\" -Gandalf, The Fellowship of the Rings")
                .WithInfo(102, 3, Artist.Magali_Villeneuve);
            addAttachment("Fast Hitch", 1, Sphere.Lore, false)
                .WithTraits("Skill.")
                .WithTextLine("Attach to a Hobbit character.")
                .WithTextLine("Action: Exhaust Fast Hitch to ready attached character.")
                .WithFlavor("'And I put as fast a hitch over the stump as any one could have done, in the Shire or out of it.' -Sam, The Two Towers")
                .WithInfo(103, 3, Artist.David_A_Nash);
            addAttachment("Song of Battle", 1, Sphere.Neutral, false)
                .WithTraits("Song.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Attached hero gains a Tactics resource icon.")
                .WithFlavor("We go, we go, we go to war, to hew the stone and break the door. -The Two Towers")
                .WithInfo(104, 3, Artist.Leonardo_Borazio);
            addQuest("Into the Marshes", "The Dead Marshes", 1, 'A', 12)
                .WithIncludedEncounterSets(EncounterSet.SauronsReach, EncounterSet.Wilderlands)
                .WithTextLine("Setup: Search the encounter deck for Gollum, and add it to the staging area. Shuffle the encounter deck, then reveal 1 card per player from the encounter deck and add it to the staging area.")
                .WithFlavor("You have followed Gollum's trail for days, and are now closing in fast pursuit. In a last ditch effort to escape you, the creature has fled to The Dead Marshes.")
                .WithTemplate("<p class='flavor-text'>You have followed Gollum's trail for days, and are now closing in fast pursuit. In a last ditch effort to escape you, the creature has fled to The Dead Marshes.</p><p><b>Setup:</b> Search the encounter deck for <a title='Gollum (The Dead Marshes)' target='_blank' href='/Cards/Details/Gollum-TDM'>Gollum</a>, and add it to the staging area. Shuffle the encounter deck, then reveal 1 card per player from the encounter deck and add it to the staging area.</p>")
                .WithOppositeFlavor("'Yes, yes,' said Gollum. 'All dead, all rotten. Elves and Men and Orcs. The Dead Marshes. There was a great battle long ago, yes, so they told him when Smeagol was young, when I was young before teh Precious came. It was a great battle. Tall Men with long swords, and terrible Elves and Orcses shrieking. They fought on th eplain for days and months at the Black Gates. But the Marshes have grown since then, swallowed up the graves; always creeping, creeping.' -The Two Towers.")
                .WithInfo(105, 1, Artist.Ignacio_Bazan_Lazcano);
            addQuest("The Capture", "The Dead Marshes", 2, 'A', 3)
                .WithIncludedEncounterSets(EncounterSet.SauronsReach, EncounterSet.Wilderlands)
                .WithFlavor("After a tiring pursuit through the treacherous marshland, you have cornered Gollum, and move in for the capture.")
                .WithOppositeTextLine("Forced: After this stage is defeated, the first player chooses a player. That player must pass an ~Escape test, dealing 1 card from the encounter deck for each resource token on ~Gollum, to capture him. If ~Gollum is not captured at this time, reset the quest deck to stage 1B.")
                .WithOppositeTextLine("If this final Escape test is passed, the players have captured Gollum and won the game.")
                .WithTemplate2("<p><b>Forced:</b> After this stage is defeated, the first player chooses a player. That player must pass an Escape test, dealing 1 card from the encounter deck for each resource token on <a title='Gollum (The Dead Marshes)' target='_blank' href='/Cards/Details/Gollum-TDM'>Gollum</a>, to capture him. If <a title='Gollum (The Dead Marshes)' target='_blank' href='/Cards/Details/Gollum-TDM'>Gollum</a> is not captured at this time, reset the quest deck to stage 1B.</p><p><b>If this final Escape test is passed, the players have captured Gollum and won the game.</b></p>")
                .WithInfo(106, 1, Artist.Ignacio_Bazan_Lazcano);
            addObjective("Gollum", "The Dead Marshes")
                .WithUnique()
                .WithTraits("Gollum.")
                .WithTextLine("If Gollum ever has 8 or more resource tokens on him, shuffle him back into the encounter deck.")
                .WithTextLine("Forced: At the end of the quest phase, the party must make an escape test, dealing 1 card per player from the encounter deck. If this test is failed, place 2 resource tokens on Gollum.")
                .WithTemplate("<p>If {self} ever has 8 or more resource tokens on him, shuffle him back into the encounter deck.</p><p><b>Forced:</b> At the end of the quest phase, the party must make an escape test, dealing 1 card per player from the encounter deck. If this test is failed, place 2 resource tokens on {self}.</p>")
                .WithInfo(107, 1, Artist.John_Matson);
            addTreachery("A Wisp of Pale Sheen", "The Dead Marshes")
                .WithTraits("Escape.")
                .WithTextLine("When Revealed: Place 2 resource tokens on Gollum. Any player may exhaust a Lore hero to reduce this effect to 1 resource token.Escape: 4")
                .WithFlavor("Presently it grew altogether dark; the air itself seemed black and heavy to breathe. When lights appeared Sam rubbed his eyes: he thought his head was going queer. He first saw one with the corner of his left eye, a wisp of pale sheen that faded away... -The Two Towers")
                .WithTemplate("<p><b>When Revealed:</b> Place 2 resource tokens on <a title='Gollum (The Dead Marshes)' target='_blank' href='/Cards/Details/Gollum-TDM'>Gollum</a>. Any player may exhaust a {sphere:Lore} hero to reduce this effect to 1 resource token.<p><p><b>Escape:</b> 4</p><p class='flavor-text-smaller'>Presently it grew altogether dark; the air itself seemed black and heavy to breathe. When lights appeared Sam rubbed his eyes: he thought his head was going queer. He first saw one with the corner of his left eye, a wisp of pale sheen that faded away...<br>&ndash;The Two Towers</p>")
                .WithEasyModeQuantity(1)
                .WithInfo(108, 3, Artist.Carolina_Eade);
            addTreachery("Nightfall", "The Dead Marshes")
                .WithTraits("Escape.")
                .WithTextLine("When Revealed: The first player makes an escape test, dealing 2 cards from the encounter deck. If this test is failed, place 1 resource token on Gollum and raise each player's threat by 2.Escape: 2")
                .WithTemplate("<p><b>When Revealed:</b> The first player makes an escape test, dealing 2 cards from the encounter deck. If this test is failed, place 1 resource token on <a title='Gollum (The Dead Marshes)' target='_blank' href='/Cards/Details/Gollum-TDM'>Gollum</a> and raise each player's threat by 2.</p><p><b>Escape:</b> 2</p>")
                .WithInfo(109, 3, Artist.David_Lecossu);
            addTreachery("Through the Mist", "The Dead Marshes")
                .WithTraits("Escape.")
                .WithTextLine("When Revealed: The first player makes an escape test counting Attack instead of Willpower, dealing 2 cards from the encounter deck. If this test is failed, place 1 resource token on Gollum and raise each player's threat by 1.Escape: 3")
                .WithTemplate("<b>When Revealed:</b> The first player makes an escape test counting {Attack} instead of {Willpower}, dealing 2 cards from the encounter deck. If this test is failed, place 1 resource token on <a title='Gollum (The Dead Marshes)' target='_blank' href='/Cards/Details/Gollum-TDM'>Gollum</a> and raise each player's threat by 1.</p><p><b>Escape:</b> 3</p>")
                .WithInfo(110, 3, Artist.Igor_Kieryluk);
            addTreachery("The Lights of the Dead", "The Dead Marshes")
                .WithTraits("Escape.")
                .WithTextLine("When Revealed: Each player must make an escape test, dealing 2 cards from the encounter deck for each test. Each player that fails this test places 1 resource token on Gollum, and raises his threat by 1.Escape: 5")
                .WithTemplate("<p><b>When Revealed:</b> Each player must make an escape test, dealing 2 cards from the encounter deck for each test. Each player that fails this test places 1 resource token on <a title='Gollum (The Dead Marshes)' target='_blank' href='/Cards/Details/Gollum-TDM'>Gollum</a>, and raises his threat by 1.</p><p><b>Escape:</b> 5</p>")
                .WithEasyModeQuantity(2)
                .WithInfo(111, 4, Artist.Henning_Ludvigsen);
            addEnemy("Giant Marsh Worm", "The Dead Marshes", 36, 1, 3, 2, 6)
                .WithTraits("Creature.")
                .WithTextLine("Forced: Remove 2 damage from Giant Marsh Worm at the end of each round.Escape: 2")
                .WithFlavor("\"No birds here. There are snakeses, wormses, things in the pools. Lot of things, lots of nasty things.\" -Gollum, The Two Towers")
                .WithTemplate("<p><b>Forced:</b> Remove 2 damage from {self} at the end of each round.</p><p><b>Escape:</b> 2</p><p class='flavor-text'>&quot;No birds here. There are snakeses, wormses, things in the pools. Lot of things, lots of nasty things.&quot;<br>&ndash;Gollum, The Two Towers</p>")
                .WithEasyModeQuantity(2)
                .WithInfo(112, 4, Artist.Jake_Murray);
            addLocation("Impassable Bog", "The Dead Marshes", 1, 12)
                .WithTraits("Dead Marshes.")
                .WithTextLine("When Revealed: Place 1 resource token on Gollum for each location card in the staging area.Escape: 2")
                .WithTemplate("<p><b>When Revealed:</b> Place 1 resource token on <a title='Gollum (The Dead Marshes)' target='_blank' href='/Cards/Details/Gollum-TDM'>Gollum</a> for each location in the staging area.</p><p><b>Escape:</b> 2</p>{victory:7}")
                .WithVictoryPoints(7)
                .WithEasyModeQuantity(2)
                .WithInfo(113, 4, Artist.Yoann_Boissonnet);
            addLocation("The Heart of the Marshes", "The Dead Marshes", 3, 4)
                .WithTraits("Dead Marshes.")
                .WithTextLine("While The Heart of the Marshes is the active location, all cards dealt from the encounter deck for escape tests get +1 Escape. (Cards receive this bonus even if they do not have a printed escape value.)Escape: 1")
                .WithTemplate("<p>While {self} is the active location, all cards dealt from the encounter deck for escape tests get +1 Escape. <i>(Cards receive this bonus even if they do not have a printed escape value.)<i></p><p><b>Escape:</b> 1</p>")
                .WithEasyModeQuantity(2)
                .WithInfo(114, 4, Artist.Noah_Bradley);
            addLocation("Fens and Mires", "The Dead Marshes", 2, 2)
                .WithTraits("Dead Marshes.")
                .WithTextLine("Forced: After the players travel to this location, place 1 resource token on Gollum.Escape: 2")
                .WithTemplate("<p><b>Forced:</b> After the players travel to this location, place 1 resource token on <a title='Gollum (The Dead Marshes)' target='_blank' href='/Cards/Details/Gollum-TDM'>Gollum</a> for each location in the staging area.</p><p><b>Escape:</b> 2</p>")
                .WithInfo(115, 4, Artist.Stacey_Diana_Clark);
        }
    }
}
