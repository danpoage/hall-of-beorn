using System;

namespace HallOfBeorn.Data.Pods
{
    public static class TheMassingAtOsgiliathProduct
    {
        public static ProductBuilder Builder()
        {
            var builder = new ProductBuilder(ProductNames.TheMassingAtOsgiliath, ProductCodes.TheMassingAtOsgiliath, new DateTime(2011, 9, 21));

            var cs = builder.GenConExpansion(CardSetNames.TheMassingAtOsgiliath, CardSetAbbreviations.TheMassingAtOsgiliath, 3001);

            var es = cs.EncounterSet(EncounterSetNames.TheMassingAtOsgiliath);

            es.addEnemy("The Witch-king", 40, 6, 6, 6, 11)
                .WithUnique()
                .WithTraits("Nazgûl.", "Captain.")
                .WithTextLine("Players cannot play attachments on The Witch-king.")
                .WithTextLine("While The Witch-king is in the staging area, each character gets -1 Willpower.")
                .WithTextLine("Forced: After The Witch-king attacks, he returns to the staging area unless the defending player raises his threat by 3.")
                .WithInfo(1, 1, Artists.Igor_Kieryluk);
            es.addEnemy("Snaga Scouts", 1, 1, 1, 0, 2)
                .WithTraits("Orc.", "Scout.")
                .WithTextLine("Forced: At the beginning of the encounter phase, all copies of Snaga Scouts engage the player with the lowest threat. (The first player chooses in case of a tie.)")
                .WithInfo(2, 4, Artists.Paul_Guzenko);
            es.addEnemy("Wolves from Mordor", 27, 1, 4, 1, 3)
                .WithTraits("Creature.", "Scout.")
                .WithTextLine("Forced: After Wolves from Mordor attack and destroy a character, shuffle Wolves from Mordor into the encounter deck.")
                .WithShadow("Shadow: Deal 2 damage to the defending character.")
                .WithInfo(3, 4, Artists.Allison_Theus);
            es.addEnemy("Wainriders", 35, 2, 3, 1, 4)
                .WithTraits("Easterling.", "Scout.")
                .WithTextLine("Each damage dealt by Wainriders raises the defending player's threat by 1.")
                .WithInfo(4, 4, Artists.David_Chen);
            es.addEnemy("Wainrider Captain", 40, 3, 3, 3, 4)
                .WithTraits("Easterling.", "Captain.")
                .WithTextLine("When Revealed: Move the top Scout enemy from the encounter discard pile to the staging area. (Top 2 Scout enemies instead if the players have crossed the Anduin.)")
                .WithShadow("Shadow: If this attack is undefended, attacking enemy gets +2 Attack if it is a Scout.")
                .WithInfo(5, 3, Artists.David_Horne);
            es.addEnemy("Uruk Vanguard", 45, 2, 2, 1, 8)
                .WithTraits("Uruk.", "Orc.")
                .WithTextLine("If the players have crossed the Anduin, Uruk Vanguard gets +3 Attack.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. (+2 Attack instead if players have crossed the Anduin).")
                .WithInfo(6, 3, Artists.Matthew_Starbuck);
            es.addLocation("Captured Watchtower", 1, 2)
                .WithTraits("West Bank.")
                .WithTextLine("If the players have crossed the Anduin, Captured Watchtower gets +3 Threat.")
                .WithShadow("Shadow: Remove all defending characters from combat. This attack is considered undefended.")
                .WithInfo(7, 3, Artists.Michael_Rasmussen);
            es.addLocation("Emyn Arnen Overlook", 2, 5)
                .WithTraits("East Bank.", "Highlands.")
                .WithTextLine("The first Scout enemy revealed from the encounter deck each round gains surge and doomed 2.")
                .WithInfo(8, 1, Artists.Igor_Kieryluk);
            es.addLocation("Morgulduin", 1, 3)
                .WithTraits("East Bank.", "Polluted.")
                .WithTextLine("While Morgulduin is the active Location, it gains: \"Forced: When a character commits to a Quest, deal 1 damage to that character.\"")
                .WithShadow("Shadow: If the players have not yet crossed the Anduin, return any current active location to the staging area. Morgulduin becomes the active location.")
                .WithInfo(9, 2, Artists.Michael_Rasmussen);
            es.addLocation("Pelennor Fields", 1, 7)
                .WithTraits("West Bank.")
                .WithTextLine("If the players have crossed the Anduin, Pelennor Fields gains: \"When faced with the option to travel, the players must either travel to Pelennor Fields or raise each player's threat by 3.\"")
                .WithVictoryPoints(1)
                .WithInfo(10, 2, Artists.Michael_Rasmussen);
            es.addLocation("Ruins of Osgiliath", 1, 2)
                .WithTraits("East Bank.")
                .WithTextLine("If the players have not crossed the Anduin, Ruins of Osgiliath gets +3 Threat.")
                .WithInfo(11, 3, Artists.David_A_Nash);
            es.addTreachery("Cut Off")
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Each player must discard all ally cards from his hand, if able.")
                .WithShadow("Shadow: Defending player must discard 1 ally card from his hand or attacking enemy gets +3 Attack. (2 allies instead if this attack is undefended.")
                .WithInfo(12, 4, Artists.Ben_Zweifel);
            es.addTreachery("Dark Pursuit")
                .WithTextLine("When Revealed: Raise the total Threat of the staging area by 1 for each Scout enemy in play. If there are no Scout enemies in play, Dark Pursuit gains surge.")
                .WithInfo(13, 2, Artists.Jake_Murray);
            es.addTreachery("Massing at Osgiliath")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Until the end of the phase, each card revealed by the encounter deck gains doomed 1. (Doomed 3 instead if the players have crossed the Anduin.)")
                .WithInfo(14, 3, Artists.Cristi_Balanescu);
            es.addObjectiveAlly("Ranger of Ithilien", 2, 2, 1, 2)
                .WithTraits("Gondor.", "Ranger.", "Ally.")
                .WithTextLine("When Revealed: The first player takes control of Ranger of Ithilien, exhausted and committed to the quest. Then, Ranger of Ithilien gains surge.")
                .WithShadow("Shadow: Deal 2 damage to attacking enemy. The defending player may exhaust a character he controls to take control of Ranger of Ithilien.")
                .WithInfo(15, 2, Artists.Eric_Braddock);
            es.addQuest("Beyond Expectations", 1, 'A', 7)
                .WithTextLine("Setup: Search the encounter deck for 12 Scout cards, and add 3 per player (one of each title), to the staging area. Remove The Witch-king from the encounter deck and set him aside, out of play. Shuffle any unused Scoutcards back into the encounter deck.")
                .WithFlavor("There are reports of increased Orc activity around Ithilien, and you have been sent to investigate. You enter Osgiliath and cross the river. On the outskirts of the city, you see a horde that surpassses all expectations coming down the Morgul Road.")
                .WithOppositeTextLine("Players cannot travel to West Bank locations.")
                .WithOppositeFlavor("As the van of the army enters the city, some of the horde's outriders are aware of your presence, and head in your direction. Drawing back, your make a hasty retreat towards the river.")
                .WithInfo(16, 1, Artists.Ben_Zweifel);
            es.addQuest("Through the Ruins", 2, 'A', 5)
                .WithFlavor("The outriders and scouts of the army have cut you off from the bridge. You desperately seek the likeliest place to cross the Anduin.")
                .WithOppositeTextLine("Players cannot travel to West Bank locations.")
                .WithOppositeTextLine("Each player cannot play or put into play more than 1 card from his hand each round.")
                .WithInfo(17, 1, Artists.Cristi_Balanescu);
            es.addQuest("Anduin Crossing", 3, 'A', 1)
                .WithFlavor("The cold waters of the Anduin river rush before you, but the current is weaker here and you have to cross. The outriders and van of the Dark Lord's army are closing fast behind, and their archers will make the attempted crossing even more dangerous. The bravest members of your band turn back to distract the oncoming horde, so that the rest of you might escape.")
                .WithOppositeTextLine("Progress tokens from card effects cannot be placed on this quest card or the active location.")
                .WithOppositeTextLine("Players cannot travel to East Bank or West Bank locations.\r\nIn order to commit characters to the quest, a player must first choose a hero or 1 Ranger of Ithilien card he controls. Discard each chosen card from play.")
                .WithInfo(18, 1, Artists.Marco_Caradonna);
            es.addQuest("Race to Minas Tirith", 4, 'A', 15)
                .WithFlavor("You made it across the Anduin and are leaving Osgiliath when a fell shriek splits the air. You begin the race across the Pelennor Fields to the safety of Minas Tirith, but a new enemy follows behind.")
                .WithOppositeTextLine("When Revealed: Add The Witch-king to the staging area.")
                .WithOppositeTextLine("Players have now crossed the Anduin. Players cannot travel to East Bank locations.If the players defeat this stage, they have won the game.")
                .WithInfo(19, 1, Artists.Igor_Kieryluk);

            return builder;
        }
    }
}
