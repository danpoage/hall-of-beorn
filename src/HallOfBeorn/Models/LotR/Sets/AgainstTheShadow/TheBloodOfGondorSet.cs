/* Generated CardSet class: The Blood of Gondor */

using System;

namespace HallOfBeorn.Models.LotR.Sets.AgainstTheShadow
{
    public class TheBloodOfGondorSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Blood of Gondor";
            Abbreviation = "TBoG";
            Number = 20;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Against the Shadow";

            addHero("Caldara", 8, Sphere.Spirit, 2, 1, 2, 3)
                .WithTraits("Gondor.")
                .WithTextLine("Action: Discard Caldara to put 1 Spirit ally from your discard pile into play for each other hero you control with a printed Spirit resource icon. (Limit once per game.)")
                .WithFlavorLine("...there is no purpose higher in the world as it now stands than the good of Gondor...")
                .WithFlavorLine("-Denethor, The Return of the King")
                .WithErrata()
                .WithInfo(107, 1, Artist.Magali_Villeneuve);
            addAlly("Squire of the Citadel", 1, Sphere.Leadership, false, 0, 0, 1, 1)
                .WithTraits("Gondor.")
                .WithTextLine("Response: After Squire of the Citadel leaves play, add 1 resource to a Gondor hero's resource pool.")
                .WithFlavorLine("As he spoke he struck a small silver gong that stood near his footstool, and at once servants came forward.")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(108, 3, Artist.Anna_Steinbauer);
            addAttachment("Tome of Atanatar", 4, Sphere.Leadership, true)
                .WithTraits("Record.")
                .WithTextLine("Attach to a Leadership hero. Reduce the cost to play Tome of Atanatar by 1 for each hero you control with a printed Leadership resource icon.")
                .WithTextLine("Action: Discard Tome of Atanatar to play any Leadership event card in your discard pile as if it were in your hand. Then, place that event on the bottom of your deck.")
                .WithInfo(109, 3, Artist.Jason_Ward);
            addAlly("Guthlaf", 3, Sphere.Tactics, true, 1, 1, 2, 2)
                .WithTraits("Rohan.")
                .WithTextLine("If there is at least 1 Rohan hero in play, lower the cost to play Guthlaf by 1.")
                .WithTextLine("If there is at least 1 Gondor hero in play, Guthlaf gains sentinel.")
                .WithInfo(110, 3, Artist.Aaron_B_Miller);
            addEvent("The Hammer-stroke", 2, Sphere.Tactics)
                .WithTextLine("Encounter Action: Engage each enemy in play.")
                .WithFlavorLine("..we have this honour: ever we bear the brunt of the chief hatred of the Dark Lord, for that hatred comes down out of the of the depths of time and over the deeps of the Sea.")
                .WithFlavorLine("-Denethor, The Return of the King")
                .WithInfo(111, 3, Artist.Magali_Villeneuve);
            addAlly("Emery", 3, Sphere.Spirit, true, 1, 1, 2, 2)
                .WithTraits("Gondor.")
                .WithTextLine("Action: Discard the top 3 card of your deck to put Emery into play from your hand, under any player's control. Then, if any of the discarded cards have the Tactics, Lore or Leadership sphere, discard Emery.")
                .WithInfo(112, 3, Artist.Christina_Davis);
            addEvent("Children of the Sea", 0, Sphere.Spirit)
                .WithTextLine("Action: Choose a Silvan or Noldor ally you control. That ally gets +2 Willpower until the end of the phase. At the end of the phase, shuffle that ally into its owner's deck if it is still in play.")
                .WithFlavorLine("\"For deep in the hears of all my kindred lies the sea-longing, which it is perilous to stir\"")
                .WithFlavorLine("-Legolas, The Return of the King")
                .WithInfo(113, 3, Artist.Mark_Winters);
            addAlly("Anborn", 4, Sphere.Lore, true, 1, 3, 1, 3)
                .WithTraits("Gondor.", "Ranger.")
                .WithTextLine("Action: Exhaust Anborn to return 1 Trap card from your discard pile to your hand.")
                .WithFlavorLine("\"I sent my keenest huntsmen to seek him, but he slipped them, and they had no sight of him till now, save Anborn.\"")
                .WithFlavorLine("-Faramir, The Two Towers")
                .WithInfo(114, 3, Artist.Ilich_Henriquez);
            addAttachment("Poisoned Stakes", 2, Sphere.Lore, false)
                .WithTraits("Trap.")
                .WithTextLine("Play Poisoned Stakes into the staging area unattached.")
                .WithTextLine("If unattached, attach Poisoned Stakes to the next eligble enemy that enters the staging area.")
                .WithTextLine("At the end of each round, deal 2 damage to attached enemy.")
                .WithInfo(115, 3, Artist.Sara_Biddle);
            addEvent("Well-Equipped", 0, Sphere.Neutral)
                .WithTextLine("Action: Discard the top 2 cards of your deck. You may attach 1 attachment card discarded by this effect to an eligible Dwarf character in play.")
                .WithFlavorLine("Gimli the Dwarf alone wore openly a short shirt of steel-rings, for dwarves make light of burdens...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(116, 3, Artist.Blake_Henriksen);
            addQuest("The Ambush", EncounterSet.TheBloodOfGondor, 1, 'A', 11)
                .WithTextLine("Setup: Add the Crossroads and Black Númenorean to the staging area. Put the Faramir and Lord Alcaron objective allies into play. Shuffle the encounter deck and reveal 1 card from the encounter deck per player and add it to the staging area.")
                .WithFlavorLine("After the assault on Osgiliath, Lord Alcaron urges Boromi to pursue the retreating enemy. Boromir agrees and gives permission to Faramir and his rangers. Grateful for you valiant efforts in Gondor's defense, Faramir invites you to join the hunt...")
                .WithOppositeTextLine("At the beginning of the quest phase, each player takes 1 hidden card.")
                .WithOppositeTextLine("At the beginning of the combat phase, each player must either turn each of his hidden cards faceup or take 1 hidden card.")
                .WithOppositeFlavorLine("You've pursued the enemy all the way to the Crossroads when a wicked horn blares in the distance. Within minutes, a host of orcs swarms out of the trees from all sides, led by a foreboding robed figure...")
                .WithErrata()
                .WithIncludedEncounterSets(EncounterSet.RavagingOrcs)
                .WithInfo(117, 1, Artist.Adam_Lane);
            addQuest("Captured!", EncounterSet.TheBloodOfGondor, 2, 'A', 15)
                .WithKeywords("Battle.")
                .WithTextLine("When Revealed: Place Faramir and Lord Alcaron under Captured! (they are in play but players cannot gain control of them). Each player turns each of his hudden cards faceup.")
                .WithFlavorLine("Faramir and Lord Alcaron have been captured! Through the throng of warriors, you see their bloodied torn forms rushed eastward by a band of Uruks. You must move quickly to prevent the unthinkable! If there is to be any hope of rescuing your friends, you must fight your way out of the ambush.")
                .WithOppositeTextLine("At the beginning of the quest phase, each player takes 1 hidden card.")
                .WithOppositeTextLine("If a player has 5 hidden cards, he must turn them faceup.")
                .WithOppositeTextLine("If the players defeat this stage, they have won the game.")
                .WithIncludedEncounterSets(EncounterSet.RavagingOrcs)
                .WithInfo(118, 1, Artist.Darek_Zabrocki);
            addEnemy("Black Númenorean", EncounterSet.TheBloodOfGondor, 35, Card.VALUE_X, 5, 3, 5)
                .WithTraits("Mordor.")
                .WithTextLine("X is the total number of hidden cards in the game.")
                .WithTextLine("Forced: At the end of the round, each player must raise his threat by 1 for each hiddien card in his play area.")
                .WithVictoryPoints(3)
                .WithInfo(119, 1, Artist.Scott_Murphy);
            addEnemy("Orc Ambusher", EncounterSet.TheBloodOfGondor, 10, 2, 3, 1, 3)
                .WithTraits("Orc.", "Mordor.")
                .WithTextLine("Forced: After Orc Ambusher engages you, discard 1 non-objective ally you control, if able.")
                .WithShadow("Shadow: Attack enemy gets +1 Attack. (+3 Attack instead if undefended.)")
                .WithEasyModeQuantity(2)
                .WithInfo(120, 4, Artist.Jim_Pavelec);
            addEnemy("Brutal Uruk", EncounterSet.TheBloodOfGondor, 20, 3, 4, 1, 5)
                .WithTraits("Orc.", "Uruk.", "Mordor.")
                .WithTextLine("Forced: After Brutual Uruk attacks and destroys a character, that character's controller turns all hidden cards in his play area faceup. Deal a shadow card to each enemy turned faceup by this effect and resolve their attacks as normal.")
                .WithEasyModeQuantity(1)
                .WithInfo(121, 3, Artist.Tim_Tsang);
            addEnemy("Evil Crow", EncounterSet.TheBloodOfGondor, 5, 1, 1, 0, 2)
                .WithTraits("Creature.")
                .WithTextLine("Forced: When Evil Crow engages a player, that player takes 1 hidden card.")
                .WithShadow("Shadow: Take 1 hidden card.")
                .WithInfo(122, 2, Artist.Rafal_Hrynkiewicz);
            addLocation("The Cross-roads", EncounterSet.TheBloodOfGondor, Card.VALUE_X, 2)
                .WithUnique()
                .WithTraits("Ithilien.")
                .WithTextLine("The current quest card gains Siege (and loses Battle).")
                .WithTextLine("X is the number of players in the game.")
                .WithTextLine("Travel: The first player must take 1 hidden card to travel here.")
                .WithErrata()
                .WithVictoryPoints(3)
                .WithInfo(123, 1, Artist.Cristi_Balanescu);
            addLocation("Southern Road", EncounterSet.TheBloodOfGondor, 2, 4)
                .WithUnique()
                .WithTraits("Ithilien.", "Road.")
                .WithTextLine("Travel: The first player must take 1 hidden card to travel here.")
                .WithFlavorLine("This road, too, ran straight for a while, but soon it began to bend away southwards...-The Two Towers")
                .WithInfo(124, 1, Artist.Cristi_Balanescu);
            addLocation("Western Road", EncounterSet.TheBloodOfGondor, 2, 4)
                .WithUnique()
                .WithTraits("Ithilien.", "Road.")
                .WithTextLine("Western Road gets +5 quest points while it is in the staging area.")
                .WithTextLine("Travel: The first player must take 1 hidden card to travel here.")
                .WithFlavorLine("...he saw, beyond an arch of boughs, the road to Osgiliath running almost as straight as a streched ribbon down, down, into the West. -The Two Towers")
                .WithInfo(125, 1, Artist.Cristi_Balanescu);
            addLocation("Northern Road", EncounterSet.TheBloodOfGondor, 4, 3)
                .WithUnique()
                .WithTraits("Ithilien.", "Road.")
                .WithTextLine("Travel: The first player must take 1 hidden card to travel here.")
                .WithFlavorLine("Behind them lay the road to the Morannon...")
                .WithFlavorLine("-The Two Towers")
                .WithInfo(126, 1, Artist.Cristi_Balanescu);
            addLocation("Eastern Road", EncounterSet.TheBloodOfGondor, 4, 2)
                .WithUnique()
                .WithTraits("Ithilien.", "Road.")
                .WithTextLine("Easter Road gets +5 quest points while it is in the staging area.")
                .WithTextLine("Travel: The first player must take 2 hidden cards to travel here.")
                .WithFlavorLine("Black and forbidding it loomed above them, darker than the dark sky behind. -The Two Towers")
                .WithInfo(127, 1, Artist.Cristi_Balanescu);
            addLocation("The Dark Woods", EncounterSet.TheBloodOfGondor, 2, 2)
                .WithTraits("Forest.")
                .WithKeywords("Archery X.")
                .WithTextLine("X is the number of players in the game.")
                .WithTextLine("Forced: After The Dark Woods leaves play as an explored location, the first player discards 1 hidden card.")
                .WithInfo(128, 4, Artist.Michael_Rasmussen);
            addTreachery("Lying in Wait", EncounterSet.TheBloodOfGondor)
                .WithTextLine("When Revealed: The first player turns each hidden card in his play area faceup. Resolve the \"When Revealed\" effects of each encounter cards turned faceup by this effect. If a location is turned faceup, add it to the staging area.")
                .WithFlavorLine("Up came the Orcs, yelling, with their long arms stretched out to seize him. -The Two Towers")
                .WithInfo(129, 4, Artist.Rafal_Hrynkiewicz);
            addTreachery("Mordor Looms", EncounterSet.TheBloodOfGondor)
                .WithKeywords("Surge.")
                .WithTextLine("When Revealed: Each player takes 1 hidden card.")
                .WithShadow("Shadow: If this attack destoys a characters, that character's controller turns each of his hidden cards faceup.")
                .WithInfo(130, 3, Artist.Sidharth_Chatursedi);
            addTreachery("Conflict at the Crossroads", EncounterSet.TheBloodOfGondor)
                .WithTextLine("When Revealed: Until the end of the phase, Orc enemies engaged with players add their Threat to the staging area. If no Orc enemies are engaged with players, Conflict at the Crossroads gains surge.")
                .WithShadow("Shadow: Take 1 hidden card.")
                .WithEasyModeQuantity(0)
                .WithInfo(131, 2, Artist.Cristi_Balanescu);
            addObjectiveAlly("Faramir", EncounterSet.TheBloodOfGondor, 2, 3, 1, 4)
                .WithUnique()
                .WithTraits("Gondor.", "Noble.", "Ranger.")
                .WithTextLine("The first player gains control of Faramir.")
                .WithTextLine("Combat Action: Exhaust Faramir to turn 1 hidden card faceup. If that card is an enemy, deal 3 damage to it.")
                .WithTextLine("If Faramir leaves play, the players have lost the game.")
                .WithInfo(132, 1, Artist.Magali_Villeneuve);
            addObjectiveAlly("Lord Alcaron", EncounterSet.TheBloodOfGondor, 1, 2, 2, 3)
                .WithUnique()
                .WithTraits("Gondor.", "Noble.")
                .WithTextLine("The first player gains control of Lord Alcaron.")
                .WithTextLine("Action: Exhaust Lord Alcaron to return an enemy engaged with you to the staging area.")
                .WithTextLine("If Lord Alcaron leaves play, the players have lost the game.")
                .WithInfo(133, 1, Artist.Magali_Villeneuve);
        }
    }
}
