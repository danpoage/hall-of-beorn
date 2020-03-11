/* Generated CardSet class: Return to Mirkwood */

using System;

namespace HallOfBeorn.Models.LotR.Sets.ShadowsOfMirkwood
{
    public class ReturnToMirkwoodSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Return to Mirkwood";
            Abbreviation = "RtM";
            Number = 7;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Shadows of Mirkwood";

            addHero("Dáin Ironfoot", 11, Sphere.Leadership, 1, 2, 3, 5)
                .WithTraits("Dwarf.")
                .WithTextLine("While Dáin Ironfoot is ready, Dwarf characters get +1 Attack and +1 Willpower.")
                .WithFlavor("\"You have not heard of Dáin and the dwarves of the Iron Hills?\" -Bilbo Baggins, The Hobbit")
                .WithInfo(116, 1, Artist.Tiziano_Baracchi);
            addAttachment("Dúnedain Signal", 1, Sphere.Leadership, false)
                .WithTraits("Signal.")
                .WithTextLine("Attach to a hero. Attached hero gains sentinel.")
                .WithTextLine("Action: Pay 1 resource from attached hero's pool to attach Dunedain Signal to another hero.")
                .WithTemplate("<p>Attach to a hero.</p><p>Attached hero gains {keyword:Sentinel.@sentinel}.<p><b>Action:</b> Pay 1 resource from attached hero's pool to attach {self} to another hero.</p>")
                .WithInfo(117, 3, Artist.Ijur);
            addEvent("Dawn Take You All", 2, Sphere.Leadership)
                .WithTextLine("Play after shadow cards have been dealt, before any attacks have resolved.")
                .WithTextLine("Combat Action: Each player may choose and discard 1 facedown shadow card from an enemy with which he is engaged.")
                .WithFlavor("\"Dawn take you all, and be stone to you!\" -Gandalf, The Hobbit")
                .WithInfo(118, 3, Artist.Ben_Zweifel);
            addAlly("Eagles of the Misty Mountains", 4, Sphere.Tactics, false, 2, 2, 2, 4)
                .WithTraits("Creature.", "Eagle.")
                .WithTextLine("Eagles of the Misty Mountains cannot have restricted attachments. Eagles of the Misty Mountains gets +1 Attack and +1 Defense for each facedown attachment it has.")
                .WithTextLine("Response: After another Eagle character leaves play, you may attach that card facedown to Eagles of the Misty Mountains.")
                .WithInfo(119, 3, Artist.Sandara_Tang);
            addAttachment("Support of the Eagles", 3, Sphere.Tactics, false)
                .WithTraits("Boon.")
                .WithTextLine("Attach to a Tactics hero.")
                .WithTextLine("Action: Exhaust Support of the Eagles to choose an Eagle ally. Until the end of the phase, attached hero adds that ally's Attack or Defense (choose 1) to its own.")
                .WithFlavor("\"I would bear you, whither you will, even were you made of stone.\" -Gwaihir, The Return of the King")
                .WithInfo(120, 3, Artist.Ilich_Henriquez);
            addAlly("West Road Traveller", 2, Sphere.Spirit, false, 2, 0, 0, 1)
                .WithTraits("Rohan.")
                .WithTextLine("Response: After you play West Road Traveller from your hand, switch the active location with any other location in the staging area.")
                .WithFlavor("The dark world was rushing by, and the wind sang loudly in his ears. -The Return of the King")
                .WithTemplate("<p><b>Response:</b> After you play {self} from your hand, switch the active location with any other location in the staging area.</p><p class='flavor-text'>The dark world was rushing by, and the wind sang loudly in his ears.<br>&ndash;The Return of the King</p>")
                .WithInfo(121, 3, Artist.Sara_Biddle);
            addEvent("Astonishing Speed", 3, Sphere.Spirit)
                .WithTextLine("Action: Until the end of the phase, all Rohan characters get +2 Willpower.")
                .WithFlavor("With astonishing speed and skill they checked their steeds, wheeled, and came charging round. -The Two Towers")
                .WithInfo(122, 3, Artist.Anna_Christenson);
            addAlly("Mirkwood Runner", 3, Sphere.Lore, false, 1, 2, 0, 2)
                .WithTraits("Silvan.", "Scout.")
                .WithTextLine("While Mirkwood Runner is attacking alone, the defending enemy does not count its Defense.")
                .WithFlavor("\"...let a ploughman plough, but choose an otter for swimming, and for running light over grass and leaf or over snow-an Elf.\" -Legolas, The Fellowship of the Ring")
                .WithTemplate("<p>While {self} is attacking alone, the defending enemy does not count its {Defense}.</p><p class='flavor-text-smaller'>&quot;...let a ploughman plough, but choose an otter for swimming, and for running light over grass and leaf or over snow-an Elf.&quot;<br>&ndash;Legolas, The Fellowship of the Ring</p>")
                .WithInfo(123, 3, Artist.Magali_Villeneuve);
            addEvent("Rumour from the Earth", 0, Sphere.Lore)
                .WithTextLine("Action: Look at the top card of the encounter deck. Then, you may pay 1 Lore resource to return Rumour from the Earth to your hand.")
                .WithFlavor("'Where sight fails the earth may bring us rumour,' said Aragorn. 'The land must groan under their hated feet.' -The Two Towers")
                .WithInfo(124, 3, Artist.Ilich_Henriquez);
            addEvent("Shadow of the Past", 2, Sphere.Neutral)
                .WithTextLine("Action: Move the top card of the encounter discard pile to the top of the encounter deck.")
                .WithFlavor("The wizard's face remained grave and attentive, and only a flicker in his deep eyes showed that he was startled and indeed alarmed. 'It has been called that before,' he said, 'but not by you.' -The Fellowship of the Ring")
                .WithInfo(125, 3, Artist.Henning_Ludvigsen);
            addQuest("Through the Forest", "Return to Mirkwood", 1, 'A', 12)
                .WithIncludedEncounterSets(EncounterSet.SpidersOfMirkwood, EncounterSet.Wilderlands)
                .WithTextLine("Setup: Search the encounter deck for Gollum. Choose a player to guard Gollum at the start of the game, and place Gollum in front of that player. Then shuffle the encounter deck. Reveal 1 card per player from the encounter deck, and add it to the staging area.")
                .WithTemplate("<p class='flavor-text'>Having captured Gollum, you must now escort him through Mirkwood Forest for interrogation at Thranduil's Palace.</p><p><b>Setup:</b> Search the encounter deck for <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a>. Choose a player to guard <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a> at the start of the game, and place <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a> in front of that player. Then shuffle the encounter deck. Reveal 1 card per player from the encounter deck, and add it to the staging area.</p>")
                .WithOppositeFlavor("Mirkwood is always a dangerous place, but it is even worse with Gollum. Between the outbursts, tantrums, and the flying provisions, you are not afforded a moment's peace")
                .WithInfo(126, 1, Artist.Ignacio_Bazan_Lazcano);
            addQuest("Escape Attempt", "Return to Mirkwood", 2, 'A', 3)
                .WithIncludedEncounterSets(EncounterSet.SpidersOfMirkwood, EncounterSet.Wilderlands)
                .WithFlavor("As soon as he thinks that no one is watching, Gollum attempts to slip his bonds and escape.")
                .WithOppositeTextLine("The player guarding ~Gollum cannot commit characters to this quest (unless he is the only player in the game).")
                .WithOppositeTextLine("If the players quest unsuccessfully, Gollum escapes and the players have lost the game.")
                .WithTemplate2("<p>The player guarding <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a> cannot commit characters to this quest (unless he is the only player remaining in the game).</p><p><b>If the player quest unsuccessfully, <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a> escapes and the player have lost the game.</b></p>")
                .WithInfo(127, 1, Artist.Tom_Garden);
            addQuest("To the Elvin King's Halls", "Return to Mirkwood", 3, 'A', 7)
                .WithIncludedEncounterSets(EncounterSet.SpidersOfMirkwood, EncounterSet.Wilderlands)
                .WithFlavor("Having thwarted Gollum's escape attempt, you tighten his rope and push on through Mirkwood, to Thranduil's palace.")
                .WithOppositeTextLine("The player guarding ~Gollum cannot play cards from his hand.")
                .WithTemplate2("<p>The player guarding <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a> cannot play cards from his hand.</p>")
                .WithInfo(128, 1, Artist.Timo_Karhula);
            addQuest("Ambush", "Return to Mirkwood", 4, 'A', 2)
                .WithIncludedEncounterSets(EncounterSet.SpidersOfMirkwood, EncounterSet.Wilderlands)
                .WithFlavor("As you make the final push to Thranduil's Palace, your enemies make a desperate attempt to ambush your party, and seize Gollum for themselves.")
                .WithOppositeTextLine("Forced: At the beginning of the combat phase, all enemies in play enage the player guarding ~Gollum.")
                .WithOppositeTextLine("Player cannot defeat this stage if there are any enemies in play. If players defeat this stage, they have won the game.")
                .WithTemplate2("<p><b>Forced:</b> At the beginning of the combat phase, all enemies in play engage the player guarding <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a>.<p><p><b>Players cannot defeat this stage if there are any enemies in play. If players defeat this stage, they have won the game.</b></p>")
                .WithInfo(129, 1, Artist.John_Gravato);
            addObjectiveAlly("Gollum", "Return to Mirkwood", Card.VALUE_NA, Card.VALUE_NA, Card.VALUE_NA, 5)
                .WithUnique()
                .WithTraits("Creature.")
                .WithTextLine("Damage from undefended attacks against you must be dealt to Gollum. If Gollum is destroyed, or if the player guarding ~Gollum is eliminated, the players have lost the game.")
                .WithTextLine("")
                .WithTextLine("Forced: At the end of each round, raise the threat of the player guarding ~Gollum by 3. Then, that player may choose a new player to guard ~Gollum.")
                .WithInfo(130, 1, Artist.Tiziano_Baracchi);
            addLocation("The Spiders' Ring", "Return to Mirkwood", 3, 2)
                .WithTraits("Forest.")
                .WithTextLine("While The Spider's Ring is the active location, the player guarding ~Gollum cannot change.")
                .WithShadow("Shadow: If this attack is undefended, return any current active location to the staging area. The Spider's Ring becomes the active location.")
                .WithTemplate("<p>While {self} is the active location, the player guarding <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a> cannot change.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> If this attack is undefended, return any current active location to the staging area. {self} becomes the active location.</p>")
                .WithEasyModeQuantity(2)
                .WithInfo(131, 4, Artist.Andrew_Johanson);
            addLocation("Dry Watercourse", "Return to Mirkwood", 2, 2)
                .WithTraits("Forest.")
                .WithTextLine("While Dry Watercourse is the active location, all treachery card effects that target the player guarding ~Gollum also target each other player.")
                .WithTemplate("<p>While {self} is the active location, all treachery card effects that target the player guarding <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a> also target each other player.</p>")
                .WithInfo(132, 3, Artist.Bill_Corbett);
            addLocation("Woodman's Glade", "Return to Mirkwood", 2, 2)
                .WithTraits("Forest.")
                .WithTextLine("Travel: The player guarding ~Gollum must exhaust a hero he controls to travel to Woodman's Glade.Response: After exploring Woodman's Glade, reduce the threat of each player not guarding ~Gollum by 2.")
                .WithTemplate("<p><b>Travel:</b> The player guarding <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a> must exhaust a hero he controls to travel to {self}.</p><p><b>Response:</b> After exploring {self}, reduce the threat of each player not guarding <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a> by 2.</p>")
                .WithInfo(133, 3, Artist.Mark_Poole);
            addLocation("Wood Elf Path", "Return to Mirkwood", 1, 3)
                .WithTraits("Forest.")
                .WithTextLine("Response: After the players travel to Wood Elf Path, the player guarding ~Gollum may choose a new player to guard him.")
                .WithTemplate("<p><b>Response:</b> After the players travel to {self}, the player guarding <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a> may choose a new player to guard him.</p>")
                .WithInfo(134, 3, Artist.Stacey_Diana_Clark);
            addTreachery("Gollum's Anguish", "Return to Mirkwood")
                .WithTraits("Tantrum.")
                .WithTextLine("When Revealed: Raise the threat of the player guarding ~Gollum by 8. That player must choose a new player to guard Gollum, if able.")
                .WithShadow("Shadow: Raise the threat of the player guarding ~Gollum by 4.")
                .WithTemplate("<p><b>When Revealed:</b> Raise the threat of the player guarding <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a> by 8. That player must choose a new player to guard <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a>, if able.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Raise the threat of the player guarding <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a> by 4.</p>")
                .WithEasyModeQuantity(1)
                .WithInfo(135, 2, Artist.Tom_Garden);
            addTreachery("Gollum's Bite", "Return to Mirkwood")
                .WithTraits("Tantrum.")
                .WithTextLine("When Revealed: Deal 4 damage to a hero controlled by the player guarding ~Gollum. That player must choose a new player to guard Gollum, if able.")
                .WithShadow("Shadow: Deal 2 damage to a hero controlled by the player guarding ~Gollum.")
                .WithTemplate("<p><b>When Revealed:</b> Deal 4 damage to a hero controlled by the player guarding <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a>. That player must choose a new player to guard <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a>, if able.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Deal 2 damage to a hero controlled by the player guarding <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a>.</p>")
                .WithEasyModeQuantity(1)
                .WithInfo(136, 2, Artist.Tom_Garden);
            addTreachery("Wasted Provisions", "Return to Mirkwood")
                .WithTraits("Tantrum.")
                .WithTextLine("When Revealed: Discard the top 10 cards from the deck of the player guarding ~Gollum. That player must choose a new player to guard Gollum, if able.")
                .WithShadow("Shadow: Discard the top 5 cards from the deck of the player guarding ~Gollum.")
                .WithTemplate("<p><b>When Revealed:</b> Discard the top 10 cards from the deck of the player guarding <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a>. That player must choose a new player to guard <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a>, if able.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Discard the top 5 cards from the deck of the player guarding <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a>.</p>")
                .WithEasyModeQuantity(2)
                .WithInfo(137, 3, Artist.David_A_Nash);
            addEnemy("Mirkwood Bats", "Return to Mirkwood", 22, 1, 1, 1, 1)
                .WithTraits("Creature.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Forced: After Mirkwood Bats engages a player, deal 1 damage to each character controlled by the player guarding ~Gollum.")
                .WithTemplate("<p>{keyword:Surge.}</p><p><b>Forced:</b> After {self} engages a player, deal 1 damage to each character controlled by the player guarding <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a>.</p>")
                .WithEasyModeQuantity(2)
                .WithInfo(138, 4, Artist.Felicia_Cano);
            addEnemy("Attercop, Attercop", "Return to Mirkwood", 44, 2, 8, 4, 6)
                .WithTraits("Creature.", "Spider.")
                .WithTextLine("Forced: At the beginning of the encounter phase, Attercop, Attercop automatically engages the player guarding ~Gollum, regardless of his threat.")
                .WithFlavor("\"Attercop! Attercop! Won't you stop...\" -Bilbo Baggins, The Hobbit")
                .WithTemplate("<p><b>Forced:</b> At the beginning of the encounter phase, {self} automatically engages the player guarding <a title='Gollum (Return to Mirkwood)' target='_blank' href='/Cards/Details/Gollum-RtM'>Gollum</a>, regardless of his threat.</p><p class='flavor-text'>&quot;Attercop! Attercop! Won't you stop...&quot;<br>&ndash;Bilbo Baggins, The Hobbit</p>")
                .WithEasyModeQuantity(0)
                .WithInfo(139, 3, Artist.Aaron_B_Miller);
        }
    }
}
