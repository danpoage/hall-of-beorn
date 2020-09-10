using System;

using HallOfBeorn.Models;

namespace HallOfBeorn.Data.Cycles.ShadowsOfMirkwood
{
    public static class TheHuntForGollumProduct
    {
        public static ProductBuilder Builder()
        {
            var builder = new ProductBuilder(ProductNames.TheHuntForGollum, ProductCodes.TheHuntForGollum, new DateTime(2011, 7, 21));

            var ap = builder.AdventurePack(CardSetNames.TheHuntForGollum, CardSetAbbreviations.TheHuntForGollum, 2);

            ap.addHero("Bilbo Baggins", 9, Sphere.Lore, 1, 1, 2, 2)
                .WithTraits("Hobbit.")
                .WithTextLine("The first player draws 1 additional card in the resource phase.")
                .WithFlavor("\"Well, my dear fellow,\" said bilbo, \"now you've heard the news, can't you spare me a moment? I want your help in something urgent.\" -The Fellowship of the Ring")
                .WithTemplate("<p>The first player draws 1 additional card in the resource phase.</p><p class='flavor-text'>&quot;Well, my dear fellow,&quot; said Bilbo, &quot;now you've heard the news, can't you spare me a moment? I want your help in something urgent.&quot;<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(1, 1, Artists.Tony_Foti);
            ap.addAttachment("Dúnedain Mark", 1, Sphere.Leadership, false)
                .WithTraits("Signal.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Attached hero gains +1 Attack.")
                .WithTextLine("Action: Pay 1 resource from attached hero's pool to attach Dunedain Mark to another hero.")
                .WithInfo(2, 3, Artists.Joko_Mulyono);
            ap.addEvent("Campfire Tales", 1, Sphere.Leadership)
                .WithTextLine("Action: Each player draws 1 card.")
                .WithFlavor("\"It is a fair tale, though it is sad, as are all the tales of Middle-earth, and yet it may lift up your hearts.\" -Strider, The Fellowship of the Ring")
                .WithInfo(3, 3, Artists.Felicia_Cano);
            ap.addAlly("Winged Guardian", 2, Sphere.Tactics, false, 0, 0, 4, 1)
                .WithTraits("Creature.", "Eagle.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel. Winged Guardian cannot have restricted attachments.")
                .WithTextLine("Forced: After an attack in which Winged Guardian defends resolves, pay 1 Tactics resource or discard Winged Guardian from play.")
                .WithInfo(4, 3, Artists.David_A_Nash);
            ap.addEvent("The Eagles Are Coming!", 0, Sphere.Tactics)
                .WithTraits("Eagle.")
                .WithTextLine("Action: Search the top 5 cards of your deck for any number of Eagle cards and add them to your hand. Shuffle the other cards back into your deck.")
                .WithFlavor("\"The Eagles! The Eagles!\" -Bilbo Baggins, The Hobbit")
                .WithInfo(5, 3, Artists.Jake_Murray);
            ap.addAlly("Westfold Horse-Breaker", 2, Sphere.Spirit, false, 1, 0, 1, 1)
                .WithTraits("Rohan.")
                .WithTextLine("Action: Discard Westfold Horse-Breaker to choose and ready a hero.")
                .WithFlavor("\"Your own valour has done more, and the stout legs of the Westfold-men marching through the night.\" -Gandalf, The Two Towers")
                .WithInfo(6, 3, Artists.Magali_Villeneuve);
            ap.addEvent("Mustering the Rohirrim", 1, Sphere.Spirit)
                .WithTextLine("Action: Search the top 10 cards of your deck for any 1 Rohan ally card and add it to your hand. Then, shuffle the other cards back into your deck.")
                .WithFlavor("\"More speed we cannot make, if the strength of Rohan is to be gathered.\" -Éomer, The Return of the King")
                .WithInfo(7, 3, Artists.Stu_Barnes);
            ap.addAlly("Rivendell Minstrel", 3, Sphere.Lore, false, 2, 0, 0, 1)
                .WithTraits("Noldor.")
                .WithTextLine("Response: After you play Rivendell Minstrel from your hand, search your deck for 1 Song card and add it to your hand. Shuffle your deck.")
                .WithFlavor("As Elrond entered and went towards the seat prepared for him, Elvish minstrels began to make sweet music. -The Fellowship of the Ring")
                .WithInfo(8, 3, Artists.Katherine_Dinger);
            ap.addEvent("Strider's Path", 1, Sphere.Lore)
                .WithTextLine("Response: After a location is revealed from the encounter deck, immediately travel to that location without resolving its Travel effect. If another location is currently active, return it to the staging area.")
                .WithFlavor("\"My cuts, short or long, don't go wrong.\" -Strider, The Fellowship of the Ring")
                .WithInfo(9, 3, Artists.Ben_Zweifel);
            ap.addAttachment("Song of Kings", 1, Sphere.Neutral, false)
                .WithTraits("Song.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Attached hero gains a Leadership resource icon.")
                .WithFlavor("From the ashes a fire shall be woken,\r\nA light from the shadows shall spring:\r\nRenewed shall be blade that was broken,\r\nThe crownless again shall be king.\r\n-The Fellowship of the Ring")
                .WithInfo(10, 3, Artists.John_Gravato);

            var es = ap.EncounterSet(EncounterSetNames.TheHuntForGollum);
            es.addQuest("The Hunt Begins", 1, 'A', 8)
                .WithIncludedEncounterSets(EncounterSetNames.JourneyAlongTheAnduin, EncounterSetNames.SauronsReach)
                .WithTextLine("Setup: Reveal 1 card per player from the encounter deck, and add it to the staging area.")
                .WithFlavor("Gandalf has requested your assistance in the search for the elusive creature known as Gollum. Your search begins in the Anduin Valley between Mirkwood Forest and the Misty Mountains")
                .WithOppositeTextLine("Forced: After the players quest successfully, the first player looks at the top 3 card fo the encounter deck. Reveal and add 1 of those cards to the staging area, and discard the other 2 cards.")
                .WithOppositeFlavor("You make your way along the banks of the Anduin River, a likely place for Gollum to find food.")
                .WithInfo(11, 1, Artists.Igor_Kieryluk);
            es.addQuest("A New Terror Abroad", 2, 'A', 10)
                .WithIncludedEncounterSets(EncounterSetNames.JourneyAlongTheAnduin, EncounterSetNames.SauronsReach)
                .WithFlavor("The wood was full of the rumor of him, dreadful tales even among beasts and birds. The Woodmen said that there was some new terror abroad, a ghost that drank blood. -The Fellowship of the Ring")
                .WithOppositeTextLine("Forced: At the beginning of the quest phase, the first player looks at the top 2 cards of the encounter deck. Reveal and add 1 of those cards to the staging area, and discard the other.")
                .WithOppositeFlavor("Rumors have led you to the eaves of Mirkwood Forest, where the Woodmen whisper of a new terror in the night...")
                .WithInfo(12, 1, Artists.David_A_Nash);
            es.addQuest("On the Trail", 3, 'A', 8)
                .WithIncludedEncounterSets(EncounterSetNames.JourneyAlongTheAnduin, EncounterSetNames.SauronsReach)
                .WithFlavor("\"But at the western edge of Mirkwood the trail turned away. It wandered off southwards and passed out of the Wood-elves' ken, and was lost.\" -Gandalf, The Fellowship of the Ring")
                .WithOppositeTextLine("Any player who does not control a hero with at least 1 Clue objective attached cannot commit characters to this quest. If there are ever no heroes with Clue objectives attached in play, reset the quest deck to stage 2B.")
                .WithOppositeTextLine("If the players defeat this stage, the players have once again found a true sign of Gollum's passing, and have won the game.")
                .WithInfo(13, 1, Artists.Carolina_Eade);
            es.addObjective("Signs of Gollum")
                .WithTraits("Clue.")
                .WithKeywords("Guarded.")
                .WithTextLine("Guarded.")
                .WithTextLine("Response: After the players quest successfully, the players may claim Signs of Gollum if it has no attached encounters. When claimed, attach Signs of Gollum to any hero committed to the quest. (Counts as a Condition attachment with: 'Forced: After attached hero is damaged or leaves play, return this card to the top of the encounter deck.')")
                .WithInfo(14, 4, Artists.David_A_Nash);
            es.addLocation("The Old Ford", Stats.VALUE_X, 2)
                .WithTraits("Riverland.")
                .WithTextLine("X is the number of ally cards in play.")
                .WithShadow("Shadow: Discard from play all allies with a printed cost lower than the number of Riverland locations in play.")
                .WithEasyModeQuantity(0)
                .WithInfo(15, 2, Artists.Timo_Karhula);
            es.addLocation("The Eaves of Mirkwood", 2, 2)
                .WithTraits("Forest.")
                .WithTextLine("While The Eaves of Mirkwood is the active location, encounter card effects cannot be canceled.")
                .WithFlavor("By the afternoon they had reached the eaves of Mirkwood, and were resting almost beneath the great overhanging boughs of its outer trees. -The Hobbit")
                .WithInfo(16, 3, Artists.Timo_Karhula);
            es.addLocation("River Ninglor", 2, 4)
                .WithTraits("Riverland.")
                .WithTextLine("While River Ninglor is the active location, remove 1 progress token from it and from the current quest at the end of each round.")
                .WithShadow("Shadow: Remove 1 progress token from the current quest. (2 progress tokens instead if this attack is undefended.)")
                .WithTemplate("<p>While {self} is the active location, remove 1 progress token from it and from the current quest at the end of each round.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Remove 1 progress token from the current quest. (2 progress tokens instead if this attack is undefended.)</p>")
                .WithInfo(17, 2, Artists.David_Lecossu);
            es.addLocation("The East Bank", 3, 3)
                .WithTraits("Riverland.")
                .WithTextLine("While The East Bank is the active location, ally cards cost 1 additional matching resource to play from hand.")
                .WithShadow("Shadow: If you do not control at least 1 hero with a Clue card attached, return this enemy to the staging area after its attack resolves.")
                .WithInfo(18, 2, Artists.Cristi_Balanescu);
            es.addLocation("The West Bank", 3, 3)
                .WithTraits("Riverland.")
                .WithTextLine("While The West Bank is the active location, attachment and event cards cost 1 additional matching resource to play from hand.")
                .WithShadow("Shadow: If you do not control at least 1 hero with a Clue card attached, double this enemy's base Attack for this attack.")
                .WithInfo(19, 2, Artists.Cristi_Balanescu);
            es.addEnemy("Goblintown Scavengers", 12, 1, 1, 0, 3)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("When Revealed: Discard the top card of each player's deck. Until the end of the phase, increase Goblintown Scavenger's Threat by the total printed cost of all cards discarded in this way.")
                .WithEasyModeQuantity(1)
                .WithInfo(20, 2, Artists.Jarreau_Wimberly);
            es.addEnemy("Hunters from Mordor", 34, 2, 2, 2, 6)
                .WithTraits("Mordor.")
                .WithTextLine("Hunters from Mordor get +2 Attack and +2 Threat for each Clue card in play.")
                .WithShadow("Shadow: Deal 1 damage to each hero with a Clue card attached. (3 damage instead if this attack is undefended.)")
                .WithEasyModeQuantity(2)
                .WithInfo(21, 5, Artists.Igor_Kieryluk);
            es.addTreachery("False Lead")
                .WithTextLine("When Revealed: The first player chooses and shuffles a card with the printed Clue trait back into the encounter deck. If there are no Clue cards in play, False Lead gains surge.")
                .WithInfo(22, 2, Artists.Even_Mehl_Amundsen);
            es.addTreachery("Flooding")
                .WithTraits("Disaster.")
                .WithKeywords("Doomed 1.", "Surge.")
                .WithTextLine("Doomed 1. Surge.")
                .WithTextLine("When Revealed: Remove all progress tokens from all Riverland locations.")
                .WithShadow("Shadow: Resolve the 'when revealed' effect of this card.")
                .WithInfo(23, 2, Artists.David_Lecossu);
            es.addTreachery("Old Wives' Tales")
                .WithTraits("Gossip.")
                .WithTextLine("When Revealed: Discard 1 resource from each hero's resource pool, if able. Exhaust any hero that could not discard a resource from its pool.")
                .WithEasyModeQuantity(1)
                .WithInfo(24, 3, Artists.Brian_Valenzuela);

            return builder;
        }
    }
}
