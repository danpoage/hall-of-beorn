/* Generated CardSet class: The Hills of Emyn Muil */

using System;

namespace HallOfBeorn.Models.LotR.Sets.ShadowsOfMirkwood
{
    public class TheHillsOfEmynMuilSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Hills of Emyn Muil";
            Abbreviation = "THoEM";
            Number = 5;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Shadows of Mirkwood";

            addHero("Brand son of Bain", 10, Sphere.Tactics, 2, 3, 2, 3)
                .WithTraits("Dale.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Response: After Brand son of Bain attacks and defeats an enemy engaged with another player, choose and ready one of that player's characters.")
                .WithFlavor("\"The grandson of Bard the Bowman rules them, Brand son of Bain son of Bard.\"\r\n-Glóin, The Fellowship of the Ring")
                .WithCommunityVersion("Brand-son-of-Bain-Grey-Company-Gen-Con-2015")
                .WithCommunityVersion("RiddermarkLord/Brand-Son-of-Bain-Tactics-Hero")
                .WithInfo(72, 1, Artist.Tiziano_Baracchi);
            addAlly("Keen-eyed Took", 2, Sphere.Leadership, false, 1, 0, 0, 2)
                .WithTraits("Hobbit.")
                .WithTextLine("Response: After Keen-eyed Took enters play, reveal the top card of each player's deck.")
                .WithTextLine("Action: Return Keen-eyed Took to your hand to discard the top card of each player's deck.")
                .WithFlavor("Then something Tookish woke up inside him...\r\n-The Hobbit")
                .WithInfo(73, 3, Artist.Anna_Mohrbacher);
            addEvent("Rear Guard", 1, Sphere.Leadership)
                .WithTextLine("Quest Action: Discard a Leadership ally to give each hero committed to this quest +1 Willpower until the end of the phase.")
                .WithFlavor("In the dark at the rear, grim and silent, walked Aragorn.\r\n-The Fellowship of the Ring")
                .WithInfo(74, 3, Artist.Lin_Bo);
            addAlly("Descendant of Thorondor", 4, Sphere.Tactics, false, 1, 2, 1, 2)
                .WithTraits("Creature.", "Eagle.")
                .WithTextLine("Descendant of Thorondor cannot have restricted attachments.")
                .WithTextLine("Response: After Descendant of Thorondor enters or leaves play, deal 2 damage to any 1 enemy in the staging area.")
                .WithInfo(75, 3, Artist.Igor_Kieryluk);
            addEvent("Meneldor's Flight", 0, Sphere.Tactics)
                .WithTextLine("Action: Choose an Eagle ally. Return that character to its owner's hand.")
                .WithFlavor("Not event an eagle poised against the sun would have marked the hobbits sitting there, under the weight of doom...\r\n-The Two Towers")
                .WithInfo(76, 3, Artist.A_M_Sartor);
            addAlly("The Riddermark's Finest", 2, Sphere.Spirit, false, 1, 1, 0, 2)
                .WithTraits("Creature.", "Rohan.")
                .WithTextLine("Action: Exhaust and discard The Riddermark's Finest to place 2 progress tokens on any location.")
                .WithFlavor("\"And there are no horses like the ones that are bred in that great vale between the Misty Mountains and the White.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(77, 3, Artist.Andrew_Johanson);
            addEvent("Ride to Ruin", 1, Sphere.Spirit)
                .WithTextLine("Action: Discard a Rohan ally to choose a location. Place 3 progress tokens on that location.")
                .WithFlavor("\"Death! Ride, ride to ruin and the world's ending!\"\r\n-Éomer, The Return of the King")
                .WithInfo(78, 3, Artist.Erfian_Asafat);
            addAlly("Gildor Inglorion", 5, Sphere.Lore, true, 3, 2, 3, 3)
                .WithTraits("Noldor.")
                .WithTextLine("Action: Exhaust Gildor Inglorion to look at the top 3 cards of your deck. Switch one of those cards with a card from your hand. Then, return the 3 cards to the top of your deck, in any order.")
                .WithFlavor("\"Go not to the Elves for counsel, for they will say both no and yes.\" -Frodo Baggins, The Fellowship of the Ring")
                .WithInfo(79, 3, Artist.Magali_Villeneuve);
            addEvent("Gildor's Counsel", 3, Sphere.Lore)
                .WithTextLine("Play during the Quest phase, before characters are committed to the Quest.")
                .WithTextLine("Action: Reveal 1 less card from the encounter deck this phase. (To a minimum of 1.)")
                .WithFlavor("\"The wide world is all about you: you can fence yourselves in, but you cannot for ever fence it out.\"\r\n-Gildor, The Fellowship of the Ring")
                .WithInfo(80, 3, Artist.Magali_Villeneuve);
            addAttachment("Song of Travel", 1, Sphere.Neutral, false)
                .WithTraits("Song.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Attached hero gains a Spirit resource icon.")
                .WithFlavor("The Road goes ever on and on\r\nDown from the door where it began.\r\nNow far ahead the road has gone,\r\nAnd I must follow, if I can.\r\n-The Fellowship of the Ring")
                .WithInfo(81, 3, Artist.Tiziano_Baracchi);
            addQuest("The Hills of Emyn Muil", "The Hills of Emyn Muil", 1, 'A', 1)
                .WithIncludedEncounterSets(EncounterSet.DolGuldurOrcs, EncounterSet.SauronsReach)
                .WithTextLine("Setup: Search the encounter deck for Amon Hen and Amon Lhaw, and add them to the staging area. Then shuffle the encounter deck.")
                .WithFlavor("The hunt for Gollum has led you to the south, and you are now approaching Rauros falls and the nearby hills of Emyn Muil...")
                .WithOppositeTextLine("Forced: If there are no location cards in the staging area, the first treachery card revealed during the quest phase gains surge.")
                .WithOppositeTextLine("Players cannot defeat this stage until there are no Emyn Muil locations in play, and they have collected at least 20 victory points.")
                .WithOppositeFlavor("You are certain that Gollum has fled into the area, and you must explore until you find the fresh trail.")
                .WithInfo(82, 1, Artist.Igor_Kieryluk);
            addLocation("Amon Hen", "The Hills of Emyn Muil", Card.VALUE_X, 5)
                .WithUnique()
                .WithTraits("Emyn Muil.")
                .WithTextLine("X is double the number of players in the game.")
                .WithTextLine("While Amon Hen is the active location, players cannot play events.")
                .WithVictoryPoints(5)
                .WithInfo(83, 1, Artist.Vincent_Proce);
            addLocation("Amon Lhaw", "The Hills of Emyn Muil", Card.VALUE_X, 5)
                .WithUnique()
                .WithTraits("Emyn Muil.")
                .WithTextLine("X is double the number of players in the game.")
                .WithTextLine("While Amon Lhaw is the active location, treat all attachments as if their printed text boxes were blank.")
                .WithVictoryPoints(5)
                .WithInfo(84, 1, Artist.Vincent_Proce);
            addLocation("The East Wall of Rohan", "The Hills of Emyn Muil", 4, 2)
                .WithTraits("Emyn Muil.")
                .WithTextLine("While The East Wall of Rohan is the active location, non-Rohan characters cost 2 additional matching resources to play.")
                .WithTemplate("<p>While {self} is the active location, non-{trait:Rohan.@Rohan} characters cost 2 additional matching resources to play.</p>{victory:3}")
                .WithVictoryPoints(3)
                .WithEasyModeQuantity(0)
                .WithInfo(85, 2, Artist.Ben_Zweifel);
            addLocation("The North Stair", "The Hills of Emyn Muil", 3, 3)
                .WithTraits("Emyn Muil.")
                .WithTextLine("Forced: After traveling to The North Stair, move the top card of the encounter discard pile to the staging area. Resolve any 'when revealed' effects on that card.")
                .WithTemplate("<p><b>Forced:</b> After traveling to The North Stair, move the top card of the encounter discard pile to the staging area. Resolve any &quot;when revealed&quot; effects on that card.</p>{victory:3}")
                .WithVictoryPoints(3)
                .WithInfo(86, 2, Artist.Michael_Rasmussen);
            addLocation("Rauros Falls", "The Hills of Emyn Muil", 2, 4)
                .WithTraits("Emyn Muil.")
                .WithTextLine("While Rauros Falls is the active location, all characters must commit to the current quest during the quest phase.")
                .WithShadow("Shadow: After this attack resolves, return attacking enemy to the staging area.")
                .WithVictoryPoints(3)
                .WithInfo(87, 2, Artist.Aaron_B_Miller);
            addLocation("The Shores of Nen Hithoel", "The Hills of Emyn Muil", 2, 2)
                .WithTraits("Emyn Muil.")
                .WithTextLine("Travel: The first player must discard 1 event card from his hand to travel to this location.")
                .WithShadow("Shadow: After this attack resolves, return attacking enemy to the staging area.")
                .WithTemplate("<p><b>Travel:</b> The first player must discard 1 {type:event} card from his hand to travel to this location.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> After this attack resolves, return attacking enemy to the staging area.</p>{victory:2}")
                .WithVictoryPoints(2)
                .WithInfo(88, 3, Artist.Lin_Bo);
            addLocation("The Outer Ridge", "The Hills of Emyn Muil", 2, 2)
                .WithTraits("Emyn Muil.")
                .WithTextLine("While The Outer Ridge is the active location, each location in the staging area gets +1 Threat.")
                .WithShadow("Shadow: After this attack resolves, return attacking enemy to the staging area.")
                .WithVictoryPoints(2)
                .WithInfo(89, 3, Artist.Lin_Bo);
            addLocation("The Highlands", "The Hills of Emyn Muil", 1, 1)
                .WithTraits("Emyn Muil.")
                .WithTextLine("Travel: In order to travel to The Highlands, the players must reveal the top card of the encounter deck, and add it to the staging area.")
                .WithTemplate("<p><b>Travel:</b> In order to travel to {self}, the players must reveal the top card of the encounter deck, and add it to the staging area.</p>{victory:1}")
                .WithVictoryPoints(1)
                .WithInfo(90, 4, Artist.Bill_Corbett);
            addTreachery("Impassable Chasm", "The Hills of Emyn Muil")
                .WithTraits("Hazard.")
                .WithTextLine("When Revealed: If there is an active location, remove all progress tokens from that location and return it to the staging area. If no location is moved by this effect, this card gains surge.")
                .WithEasyModeQuantity(2)
                .WithInfo(91, 4, Artist.Noah_Bradley);
            addTreachery("Rockslide", "The Hills of Emyn Muil")
                .WithTraits("Hazard.")
                .WithTextLine("When Revealed: Deal 2 damage to each character committed to this quest.")
                .WithShadow("Shadow: Remove defending character from combat. This attack is considered undefended.")
                .WithEasyModeQuantity(1)
                .WithInfo(92, 3, Artist.Stu_Barnes);
            addTreachery("Slick Footing", "The Hills of Emyn Muil")
                .WithTraits("Hazard.")
                .WithTextLine("When Revealed: Remove 1 progress token from each location in play. Then, discard the top card of each player's deck for each progress token removed by this effect.")
                .WithInfo(93, 3, Artist.Magali_Villeneuve);
            addEnemy("Orc Horse Thieves", "The Hills of Emyn Muil", 35, 3, 1, 2, 6)
                .WithTraits("Mordor.", "Orc.")
                .WithKeywords("Doomed 2.")
                .WithTextLine("Doomed 2.")
                .WithTextLine("Orc Horse Thieves get +1 Attack for each location in the staging area.")
                .WithTemplate("<p>{self} get +1 {Attack} for each location in the staging area.</p>")
                .WithEasyModeQuantity(2)
                .WithInfo(94, 3, Artist.Brian_Valenzuela);
        }
    }
}
