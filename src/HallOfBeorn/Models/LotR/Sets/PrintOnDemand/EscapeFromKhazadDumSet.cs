using System;

namespace HallOfBeorn.Models.LotR.Sets.PrintOnDemand
{
    public class EscapeFromKhazadDumSet
        : CardSet
    {
        private const string setName = "Escape from Khazad-dûm";
        private const string emptySetName = "";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "EFKD";
            SetType = Models.SetType.Fellowship_Deck;
            Cycle = "GenCon";
            Number = 3012;

            addQuest("Out of the Depths", EncounterSet.EscapeFromKhazadDum, 1, 'A', 10)
                .WithFlavorLine("You entered Moria with the hope of finding Mithril, but you have become lost underground instead. Below the ancient mansions of the Dwarves, untold dangers lurk in the darkness.")
                .WithTextLine("Setup: Add Dark Pit to the staging area. The opposing team searches the encounter deck for one different 0-cost enemy or location per player and adds them to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("Surrounded by utter black and running low on supplies, you must find your way out of Khazad-dûm before it's too late.")
                .WithOppositeTextLine("Forced: When Dark Pit is explored, flip it over and set Durin's Bane aside, out of play. Each player searches the top 5 cards of his deck for a card, adds it to his hand, and shuffles his deck.")
                .WithOppositeTextLine("This stage cannot be defeated while Dark Pit is in play.")
                .WithInfo(1, 1, Artist.Anthony_Palumbo);
            addQuest("Search for an Exit", EncounterSet.EscapeFromKhazadDum, 2, 'A', 10)
                .WithOppositeTitle("Old One Lair")
                .WithFlavorLine("The Mines of Moria are vast beyond your imagination. Though you feel that you are making progress, one wrong turn could mean disaster.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 1 or less (cost 2 or less instead if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. It's 'when revealed' effects cannot be canceled.")
                .WithOppositeTextLine("When Revealed: The opposing team searchs the encounter deck and discard pile for an enemy with cost 2 or less, adds it to the staging area, and places a resources on it. Shuffle the encounter deck.")
                .WithOppositeTextLine("The enemy with a resource on it is immune to player card effects, and progress cannot be placed on this stage while that enemy is in play.")
                .WithInfo(3, 1, Artist.Cristi_Balanescu);
            addQuest("Search for an Exit", EncounterSet.EscapeFromKhazadDum, 2, 'A', 15)
                .WithOppositeTitle("A Wrong Turn")
                .WithFlavorLine("The Mines of Moria are vast beyond your imagination. Though you feel that you are making progress, one wrong turn could mean disaster.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 1 or less (cost 2 or less instead if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. It's 'when revealed' effects cannot be canceled.")
                .WithOppositeTextLine("When Revealed: Each player chooses 1 card in his hand and shuffles the rest into his deck.")
                .WithBackArtist(Artist.David_Lecossu)
                .WithInfo(4, 1, Artist.Cristi_Balanescu);
            addQuest("Search for an Exit", EncounterSet.EscapeFromKhazadDum, 2, 'A', 20)
                .WithOppositeTitle("A Way Up")
                .WithFlavorLine("The Mines of Moria are vast beyond your imagination. Though you feel that you are making progress, one wrong turn could mean disaster.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 1 or less (cost 2 or less instead if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. It's 'when revealed' effects cannot be canceled.")
                .WithOppositeTextLine("Add the active location's Threat to the staging area.")
                .WithOppositeTextLine("During the travel phase, the players must travel, if able.")
                .WithBackArtist(Artist.Ben_Zweifel)
                .WithInfo(5, 1, Artist.Cristi_Balanescu);
            addQuest("Nearing the Gate", EncounterSet.EscapeFromKhazadDum, 2, 'A', 10)
                .WithOppositeTitle("The Bridge of Khazad-dûm")
                .WithFlavorLine("Your spirits rise as you are drawing near to the East Gate of Moria. But then a huge, dark shape rises in front of you and bursts into flames: a Balrog! Durin's Bane blocks your escape.")
                .WithTextLine("When Revealed: Add the set-aside Durin's Bane to the staging area. It cannot take damage this round. If there is more than 1 player, it makes an immediate attack against the first player.")
                .WithOppositeTextLine("No more than 5 progress can be placed here each round.")
                .WithOppositeTextLine("Forced: At the beginning of the quest phase, Durin's Bane makes an attack against the first player. Any undefended or excess damage dealt by this attack must be placed here.")
                .WithOppositeTextLine("If this stage has damage on it equal to or greater than its quest points, the players lose the game. If this stage is defeated the players win the game.")
                .WithBackArtist(Artist.Silver_Saaremael)
                .WithInfo(7, 1, Artist.Ben_Zweifel);
            addQuest("Nearing the Gate", EncounterSet.EscapeFromKhazadDum, 2, 'A', 15)
                .WithOppositeTitle("Last Lord of Moria")
                .WithFlavorLine("Your spirits rise as you are drawing near to the East Gate of Moria. But then a huge, dark shape rises in front of you and bursts into flames: a Balrog! Durin's Bane blocks your escape.")
                .WithTextLine("When Revealed: Add the set-aside Durin's Bane to the staging area. It cannot take damage this round. If there is more than 1 player, it makes an immediate attack against the first player.")
                .WithOppositeTextLine("Durin's Bane engages the first player.")
                .WithOppositeTextLine("Durin's Bane cannot take more than X damage per round, where X is the number of progress tokens on this stage.")
                .WithOppositeTextLine("This stage cannot be defeated while Durin's Bane is in play. If the players defeat this stage, they win the game.")
                .WithBackArtist(Artist.Dmitry_Burmak)
                .WithInfo(8, 1, Artist.Ben_Zweifel);
            addQuest("Nearing the Gate", EncounterSet.EscapeFromKhazadDum, 2, 'A', 20)
                .WithOppositeTitle("The Reat Guard")
                .WithFlavorLine("Your spirits rise as you are drawing near to the East Gate of Moria. But then a huge, dark shape rises in front of you and bursts into flames: a Balrog! Durin's Bane blocks your escape.")
                .WithTextLine("When Revealed: Add the set-aside Durin's Bane to the staging area. It cannot take damage this round. If there is more than 1 player, it makes an immediate attack against the first player.")
                .WithOppositeTextLine("Each player's threat cannot be reduced by player card effects.")
                .WithOppositeTextLine("Durin's Bane is considered to be engaged with each player and attacks each player in turn order during the combat phase. (Deal and resolve a shadow card for each attack.)")
                .WithOppositeTextLine("If the players defeat this stage, they win the game.")
                .WithBackArtist(Artist.Jason_Juta)
                .WithInfo(9, 1, Artist.Ben_Zweifel);
            addLocation("Dark Pit", EncounterSet.EscapeFromKhazadDum, 1, 1)
                .WithUnique()
                .WithTraits("Underground.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Travel: The opposing team searches the top 5 cards of the encounter deck for a card with cost 1 or less (cost 2 or less instead if there are 2 or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithInfo(10, 1, Artist.Igor_Kieryluk);
            addEnemy("Durin's Bane", EncounterSet.EscapeFromKhazadDum, 50, 4, 8, 3, 15)
                .WithUnique()
                .WithTraits("Balrog.")
                .WithTextLine("Immuned to player card effects.")
                .WithTextLine("Cannot be optionally engaged.")
                .WithTextLine("Forced: After Durin's Bane attacks and destroys a character you control, raise your threat by 2 and heal 2 damage from Durin's Bane.")
                .WithVictoryPoints(5)
                .WithInfo(11, 1, Artist.Magali_Villeneuve);

            addEnemy("Black Bats", emptySetName, 23, 1, 3, 1, 2)
                .WithSetNumberAndCost(15, 0)
                .WithTraits("Creature.")
                .WithTextLine("When Revealed: Eithe raise each player's threat by 2, or reveal an additional encounter card.")
                .WithShadow("Shadow: Either raise your threat by 2, or this attack is considered undefended.")
                .WithInfo(12, 3, Artist.Lukasz_Jaskolski);
            addLocation("Nest of Vermin", emptySetName, 3, 5)
                .WithSetNumberAndCost(15, 2)
                .WithUnique()
                .WithTraits("Underground.")
                .WithTextLine("While Nest of Vermin is in the staging area, each Creature enemy gets +1 Threat.")
                .WithTextLine("Forced: When Nest of Vermin is explored, the opposing team searches the encounter deck and discard pile for a Creature enemy with cost 1 or less and adds it to the staging area. Shuffle the encounter deck.")
                .WithInfo(13, 1, Artist.Jokubas_Uoginitas);
            addTreachery("Swarm of Bats", emptySetName)
                .WithSetNumberAndCost(15, 1)
                .WithTextLine("When Revealed: Each character gets -1 Willpower until the end of the phase.")
                .WithShadow("Shadow: Each character you control gets -1 Attack and -1 Defense until the end of the phase.")
                .WithInfo(14, 1, Artist.Nicholas_Gregory);

            addEnemy("Cave Spider", emptySetName, 28, 2, 3, 1, 5)
                .WithSetNumberAndCost(16, 1)
                .WithTraits("Spider.")
                .WithTextLine("Forced: When Cave Spider attacks, either remove 2 progress from the main quest, or Cave Spider gets +2 Attack for this attack.")
                .WithShadow("Shadow: Either remove 2 progress from the main quest or attacking enemy gets +2 Attack.")
                .WithInfo(15, 2, Artist.Allison_Theus);
            addLocation("The Mountain's Roots", emptySetName, Card.VALUE_X, 4)
                .WithSetNumberAndCost(16, 0)
                .WithTraits("Underground.")
                .WithTextLine("X is 1 more than the stage number of the main quest.")
                .WithTextLine("Travel: Each player discards the top X cards of his deck.")
                .WithInfo(16, 2, Artist.Stu_Barnes);
            addTreachery("Watchful Eyes", emptySetName)
                .WithSetNumberAndCost(16, 1)
                .WithTextLine("When Revealed: The opposing team attaches Watchful Eyes to a hero. (Counts as a Condition attachment with the text: \"Limit 1 per hero. Forced: If attached hero is exhausted at the end of the combat phase, reveal 1 card from the encounter deck.\")")
                .WithInfo(17, 1, Artist.Tiziano_Baracchi);

            addEnemy("Cave-troll", emptySetName, 36, 2, 5, 1, 6)
                .WithSetNumberAndCost(17, 1)
                .WithTraits("Troll.")
                .WithTextLine("Cannot have non-objective player card attachments.")
                .WithTextLine("Allies cannot be declared as attackers or defenders against Cave-troll.")
                .WithInfo(18, 1, Artist.Timo_Karhula);
        }
    }
}