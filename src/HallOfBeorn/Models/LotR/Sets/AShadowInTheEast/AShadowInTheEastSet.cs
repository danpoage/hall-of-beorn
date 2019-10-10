using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.AShadowInTheEast
{
    public class AShadowInTheEastSet : CardSet
    {
        private const string setName = "A Shadow in the East";
        private const string setTheRiverRunning = "The River Running";
        private const string setRidersOfRhun = "Riders of Rhûn";
        private const string setEasterlingRaiders = "Easterling Raiders";
        private const string setRollingPlains = "Rolling Plains";
        private const string setDangerInDorwinion = "Danger in Dorwinion";
        private const string setServantsOfSauron = "Servants of Sauron";
        private const string setCityOfRhun = "City of Rhûn";
        private const string setUnderGuard = "Under Guard";
        private const string setTempleOfDoom = "Temple of Doom";
        private const string setUlchorsGuard = "Ulchor's Guard";
        private const string setTwistedTunnels = "Twisted Tunnels";
        private const string setThePowerOfMordor = "The Power of Mordor";
        private const string setGollumAndSmeagol = "Gollum and Sméagol";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "ASitE";
            Number = 56;
            SetType = Models.SetType.Deluxe_Expansion;

            addAttachment("The One Ring", 0, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Ring.", "Master.")
                .WithKeywords("Restricted.")
                .WithText("Immune to non-Master card effects.\r\nSetup: Attach to a hero you control and search your deck for a Master card. Add it to your hand and shuffle your deck. Your threat elimination level is reduced by 5.\r\nIf The One Ring leaves play, the players lose the game.")
                .WithTemplate("<p class='main-text'>{keyword:Restricted.} Immune to non-{trait:Master.@Master} card effects.</p><p class='main-text'><b>Setup:</b> Attach to a hero you control and search your deck for a {trait:Master.@Master} card. Add it to your hand and shuffle your deck. Your threat elimination level is reduced by 5.</p><p class='main-text'><b>If {self} leaves play, the players lose the game.</b></p>")
                .WithInfo(1, 1, Artist.Torbjorn_Kallstrom);
            addHero("Frodo Baggins", 7, Sphere.Leadership, 2, 1, 2, 2)
                .WithTraits("Hobbit.")
                .WithText("Response: After Frodo commits to a quest, spend 1 resource from his resource pool to ready another questing unique character. If you quest successfully, reduce your threat by 1.")
                .WithFlavor("\"Keep your tempers and hold your hands to the last possible moment!\"\r\n-The Return of the King")
                .WithInfo(2, 1, Artist.Sara_Biddle);
            addAlly("Merry", 2, Sphere.Leadership, true, 2, 0, 0, 2)
                .WithTraits("Hobbit.")
                .WithText("Response: After Merry enters play, each unique ally you control gets +1 Willpower until the end of the round.")
                .WithFlavor("\"Shire-folk have been so comfortable so long they don't know what to do. They just want a match, though, and they'll go up in fire.\"\r\n-The Return of the King") 
                .WithInfo(3, 3, Artist.Torbjorn_Kallstrom);
            addAlly("Pippin", 2, Sphere.Tactics, true, 2, 0, 0, 2)
                .WithTraits("Hobbit.")
                .WithText("Pippin gets +2 Attack while attacking an enemy with an engagement cost higher than your threat.\r\nResponse: After you engage an enemy with an engagement cost higher than your threat, ready Pippin.")
                .WithFlavor("\"Down on your knees in the road and ask pardon, or I will set this troll's bane in you!\"\r\n-The Return of the King")
                .WithInfo(4, 3, Artist.Torbjorn_Kallstrom);
            addAlly("Faramir", 4, Sphere.Lore, true, 2, 1, 2, 3)
                .WithTraits("Gondor.", "Noble.", "Ranger.")
                .WithText("Response: After Faramir enters play, choose a non-unique enemy in the staging area. Engage that enemy and deal 2 damage to it (4 damage instead if it has an attachment on it).")
                .WithFlavor("\"There will be hard handstrokes nigh at hand ere the day is full.\"\r\n-The Two Towers")
                .WithInfo(5, 3, Artist.Greg_Bobrowski);
            addAlly("Derufin", 3, Sphere.Spirit, true, 1, 2, 1, 2)
                .WithTraits("Gondor.", "Warrior.")
                .WithKeywords("Ranged.")
                .WithText("Ranged. Response: After Derufin participates in an attack which destroys an enemy engaged with a player, discard Derufin to reduce the engaged player's threat by X, where X is the destroyed enemy's printed Threat.")
                .WithTemplate("<p class='main-text'>{keyword:Ranged.}</p><p class='main-text'><b>Response:</b> After {self} participates in an attack which destroys an enemy engaged with a player, discard {self} to reduce the engaged player's threat by X, where X is the destroyed enemy's printed {Threat}.</p>")
                .WithInfo(6, 3, Artist.Greg_Bobrowski);
            addEvent("The Gathering Storm", 0, Sphere.Leadership)
                .WithText("Planning Action: Search the top 5 cards of the encounter deck for an enemy. Add that enemy to the staging area to reduce the cost of the first ally you play this phase by X, where X is that enemy's Threat. Shuffle the encounter deck.")
                .WithInfo(7, 3, Artist.Leanna_Crossan);
            addAttachment("Put Off Pursuit", 1, Sphere.Lore, false)
                .WithTraits("Condition.")
                .WithText("Attach to the active location. Limit 1 per location.\r\nAttached location gets +2 quest points.\r\nResponse: After attached location is explored, discard cards from the encounter deck until a location is discarded. Add that location to the staging area to choose an non-unique enemy in the staging area and shuffle it into the encounter deck.")
                .WithInfo(8, 3, Artist.Marius_Bota);
            addEvent("The Master Ring", 0, Sphere.Neutral)
                .WithTraits("Master.")
                .WithText("Response: Exhaust The One ~Ring and raise your threat by 1 to cancel the effects of an encounter card just revealed from the encounter deck and discard that card. Then, reveal an encounter card.")
                .WithFlavor("\"If I, wearing it, were to command you, you would obey, even if it were to leap from a precipice or to cast yourself into the fire.\"\r\n-Frodo, The Two Towers")
                .WithInfo(9, 3, Artist.Marius_Bota);
            addEvent("The Ruling Ring", 0, Sphere.Neutral)
                .WithTraits("Master.")
                .WithText("Combat Action: Exhaust The One Ring and raise your threat by 1 to choose a non-Nazgul enemy engaged with you. Until the end of the phase, that enemy cannot attack you.")
                .WithFlavor("\"He vanished. I have never seen such a thing happen before...\"\r\n-Boromir, The Fellowship of the Ring")
                .WithInfo(10, 3, Artist.Lukasz_Jaskolski);
            addEvent("The Ring of Power", 0, Sphere.Neutral)
                .WithTraits("Master.")
                .WithText("Action: Exhaust The One Ring and raise your threat by 1 to ready the hero with The One Ring Attached. That hero gets +1 Willpower, +1 Attack, and +1 Defense until the end of the phase.")    
                .WithFlavor("\"And behold! in our need chance brings to light the Ring of Power.\"\r\n-Boromir, The Fellowship of the Ring")
                .WithInfo(11, 3, Artist.Echo_Chernik);
            addObjective("Easterling Pursuit", setTheRiverRunning)
                .WithText("Forced: At the end of the round, place 1 resource here. Then if there are at lest 3 resources here, remove 3 of them and shuffle the encounter discard pile into the encounter deck. Discard cards from the top until X enemies are discarded, where X is the number of players. Add each enemy discarded this way to the staging area.")
                .WithInfo(12, 1, Artist.Guillaume_Ducos);
            addEnemy("Easterling Outrider", setTheRiverRunning, 24, 1, 2, 1, 2)
                .WithTraits("Easterling.")
                .WithKeywords("Surge.")
                .WithText("Forced: After Easterling Outrider engages a player, either place 1 resource on Easterling Pursuit, or Easterling Outrider makes an immediate attack.")
                .WithShadow("Shadow: Discard an attachment you control.")
                .WithEasyModeQuantity(1)
                .WithInfo(13, 3, Artist.Guillaume_Ducos);
            addLocation("River Running", setTheRiverRunning, 2, 5)
                .WithTraits("Riverland.")
                .WithText("While River Running is in the staging area, enemies cannot be optionally engaged.\r\nTravel: The first player engages the highest engagement cost enemy in the staging area.")
                .WithFlavor("...below them were trees that looked like oaks and elms, and wide grass lands, and a river running through it all.\r\n-The Hobbit")
                .WithInfo(14, 2, Artist.Carlos_Palma_Cruchaga);
            addLocation("Exposed Riverbank", setTheRiverRunning, 4, 4)
                .WithTraits("Riverland.")
                .WithText("While Exposed Riverbank is in the staging area, it gains: \"Forced: After a 'when revealed' effect is canceled, place 1 resource on Easterling Pursuit.\"\r\nTravel: Place 1 resource on Easterling Pursuit.")
                .WithEasyModeQuantity(1)
                .WithInfo(15, 2, Artist.Guillaume_Ducos);
            addTreachery("Enemies Close Behind", setTheRiverRunning)
                .WithText("When Revealed: Place 1 resource on Easterling Pursuit. Then, raise each player's threat by 1 for each resource on Easterling Pursuit.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, place 1 resource on Easterling Pursuit.")
                .WithInfo(16, 2, Artist.Leanna_Crossan);
            addEnemy("Easterling Captain", setRidersOfRhun, 36, 3, 6, 3, 6)
                .WithUnique()
                .WithTraits("Easterling.")
                .WithText("Forced: When Easterling Captain enters play, discard cards from the encounter deck until an Easterling treachery is discarded. Attach that treachery to Easterling Captain.\r\nForced: When Easterling Captain would take any amount of damage, discard an Easterling attachment from him. Then, cancel the damage.")
                .WithVictoryPoints(6)
                .WithInfo(17, 1, Artist.Antonio_Jose_Manzanedo);
            addEnemy("Rider of Rhûn", setRidersOfRhun, 40, 2, 5, 2, 5)
                .WithTraits("Easterling.")
                .WithKeywords("Archery 2.")
                .WithText("Rider of Rhûn gets -10 enagement cost for each Easterling attachment it has.\r\nWhen Revealed: Search the encounter deck and discard pile for an Easterling Horse and attach it to Rider of Rhûn. Shuffle the encounter deck.")
                .WithEasyModeQuantity(1)
                .WithInfo(18, 2, Artist.Marco_Caradonna);
            addTreachery("Easterling Horse", setRidersOfRhun)
                .WithTraits("Easterling.")
                .WithText("While attached to an enemy, counts as a Mount attachment with the text: \"Attached enemy gets +2 Threat. Forced: At the end of the round, return attached enemy to the staging area.\"\r\nWhen Revealed: Attach to the lowest engagement cost Easterling enemy without an Easterling Horse and return it to the staging area. Otherwise, Easterling Horse gains surge.")
                .WithInfo(19, 3, Artist.Guillaume_Ducos);
            addEnemy("Easterling Raider", setEasterlingRaiders, 28, 2, 2, 2, 3)
                .WithTraits("Easterling.")
                .WithKeywords("Archery 1.")
                .WithText("Easterling Raider gets +1 Attack and +1 Defense for each Easterling attachment on it.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if it has an Easterling attachment).")
                .WithInfo(20, 3, Artist.Sebastian_Zakrzewski);
            addEnemy("Warrior of Rhûn", setEasterlingRaiders, 34, 3, 3, 3, 4)
                .WithTraits("Easterling.")
                .WithText("Forced: When Warrior of Rhûn attacks, attach the top Easterling treachery in the discard pile to it.")
                .WithShadow("Shadow: Attach the top Easterling treachery in the discard pile to attacking enemy.")
                .WithEasyModeQuantity(2)
                .WithInfo(21, 3, Artist.Chris_Grun);
            addTreachery("Sword of Rhûn", setEasterlingRaiders)
                .WithTraits("Easterling.")
                .WithKeywords("Surge.")
                .WithText("While attached to an enemy, counts as a Weapon attachment with the text: \"Attached enemy gets +2 Attack.\"\r\nWhen Revealed: Attach to the Easterling enemy with the lowest Attack without a Sword of Rhûn.")
                .WithEasyModeQuantity(1)
                .WithInfo(22, 2, Artist.Sebastian_Zakrzewski);
            addTreachery("Recurve Bow", setEasterlingRaiders)
                .WithTraits("Easterling.")
                .WithKeywords("Surge.")
                .WithText("While attached to an enemy, counts as a Weapon attachment with the text: \"Attached enemy gains Archery 2.\"\r\nWhen Revealed: Attach to the highest engagement cost Easterling enemy without a Recurve Bow.")
                .WithEasyModeQuantity(1)
                .WithInfo(23, 2, Artist.Martin_de_Diego_Sadaba);
            addEncounterSideQuest("Warriors of the East", setEasterlingRaiders, 8)
                .WithFlavor("The Easterlings are fearless warriors, but a stern defense may dissuade them.")
                .WithKeywords("Surge.")
                .WithText("When Revealed: After an Easterling enemy enters play, attach the top Easterling treachery in the discard pile to that enemy.\r\nForced: After Warriors of the East becomes the current quest, the highest Attack Easterling enemy in the staging area attacks the first player.")
                .WithVictoryPoints(10)
                .WithInfo(24, 1, Artist.Alvaro_Calvo_Escudero);
            addLocation("Rolling Plains", setRollingPlains, 2, 4)
                .WithTraits("Plains.")
                .WithText("When Revealed: Each copy of Rolling Plains gets +2 Threat until the end of the phase.\r\nTravel: Raise each player's threat by 2.")
                .WithFlavor("The falling stream vanished into a deep growth of cresses and water-plants, and they could hear it tinkling away in green tunnels, down long gentle slopes...\r\n-The Two Towers")
                .WithEasyModeQuantity(3)
                .WithInfo(25, 4, Artist.Alyn_Spiller);
            addLocation("Rocky Outcrop", setRollingPlains, 3, 3)
                .WithTraits("Plains.")
                .WithText("While Rocky Outcrop is in the staging area, characters cannot be readied by player card effects.\r\nTravel: The first player exhausts a hero he controls.")
                .WithEasyModeQuantity(1)
                .WithInfo(26, 2, Artist.Alyn_Spiller);
            addTreachery("Weary Lands", setRollingPlains)
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Each exhausted character gets -1 Willpower until the end of the phase.")
                .WithShadow("Shadow: Deal 1 damage to the defending character.")
                .WithEasyModeQuantity(1)
                .WithInfo(27, 2, Artist.Dual_Brush_Studios);
            addTreachery("Painful Fatigue", setRollingPlains)
                .WithText("When Revealed: Each player exhausts a character he controls and deals 1 damage to it.")
                .WithShadow("Shadow: Either exhaust a character you control, or return attacking enemy to the staging area after this attack.")
                .WithInfo(28, 2, Artist.JB_Casacop);
            addEncounterSideQuest("An Arduous Journey", setRollingPlains, 6)
                .WithFlavor("The lonely plains appear to stretch endlessly in each direction, and you tire just from looking at them.")
                .WithText("Each player cannot ready more than 6 characters he controls during the refresh phase.\r\nResponse: When this stage is defeated, each player may ready a hero he controls.")
                .WithVictoryPoints(10)
                .WithInfo(29, 1, Artist.Dual_Brush_Studios);
            addEnemy("Priest of Sauron", setDangerInDorwinion, 38, 3, 6, 2, 8)
                .WithUnique()
                .WithTraits("Cultist.")
                .WithText("Immune to player card effects.\r\nCannot be optionally engaged.\r\nForced: After Priest of Sauron attacks and destroys an ally, raise each player's threat by 2.")
                .WithVictoryPoints(6)
                .WithInfo(30, 1, Artist.Matthew_Cowdery);
            addEnemy("The Governor", setDangerInDorwinion, 44, 3, 4, 3, 8)
                .WithUnique()
                .WithTraits("Cultist.")
                .WithText("Immune to player card effects.\r\nForced: After a location is revealed from the encounter deck, The Governor engages the first player and makes an immediate attack.")
                .WithFlavor("\"In all the long wars with the Dark Tower treason has ever been our greatest foe.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithVictoryPoints(6)
                .WithInfo(31, 1, Artist.Greg_Bobrowski);
            addEnemy("Black Númenórean", setDangerInDorwinion, 40, 3, 5, 1, 9)
                .WithUnique()
                .WithTraits("Cultist.")
                .WithText("Immune to player card effects.\r\nDo not discard shadow cards dealt to Black Númenórean if they have a shadow effect.\r\nForward: When Black Númenórean attacks, resolve each of his faceup shadow cards as if they had been dealt this round.")
                .WithVictoryPoints(6)
                .WithInfo(32, 1, Artist.Stanislav_Dikolenko);
            addObjective("Bribes", setDangerInDorwinion)
                .WithTraits("Plot.")
                .WithText("Add +1 to the total Threat in the staging area for each resource here.\r\nForced: When the active location is explored, discard the top X cards of each player's deck, when X is that location's Threat. Then, place 1 resource here for each event discarded this way.")
                .WithInfo(33, 1, Artist.Lukasz_Jaskolski);
            addObjective("Submit or Die", setDangerInDorwinion)
                .WithTraits("Plot.")
                .WithText("Each non-unique enemy gets +1 Attack.\r\nForced: After an enemy attacks and destroys a character, place 1 damage token here. Then, if there are X damage tokens here, the players lose the game. X is 4 more than the number of players.")
                .WithInfo(34, 1, Artist.Lukasz_Jaskolski);
            addObjective("Sauron Worship", setDangerInDorwinion)
                .WithTraits("Plot.")
                .WithText("Sauron Worship enters play with 1 damage token on it.\r\nEach player's threat elimination level is reduced by 1 for each damage token here.\r\nForced: At the end of the round, place 1 damage token here.")
                .WithInfo(35, 1, Artist.Lukasz_Jaskolski);
            addObjective("Evidence of the Cult", setDangerInDorwinion)
                .WithTraits("Clue.")
                .WithKeywords("Guarded (enemy).")
                .WithText("Attached enemy gets +1 Threat, +1 Attack, and +1 Defense.\r\nWhen Evidence of the Cult is free of encounters, add it to the victory display. Then, place 1 resource on the main quest.")
                .WithVictoryPoints(1)
                .WithInfo(36, 3, Artist.Romana_Kendelic);
            addLocation("Hillside Manor", setDangerInDorwinion, 2, 4)
                .WithTraits("City.")
                .WithText("While Hillside Manor is in the staging area, each player's threat cannot be reduced by more than 1 each round by player card effects.\r\nTravel: Each player discards 1 random card from his hand.")
                .WithFlavor("The wine of Dorwinion brings deep and pleasant dreams.\r\n-The Hobbit")
                .WithInfo(37, 3, Artist.Greg_Bobrowski);
            addTreachery("Disappearances", setDangerInDorwinion)
                .WithText("When Revealed: Each player discards all ally cards from his hand. If no cards are discarded this way, Disappearances gains doomed 2.")
                .WithShadow("Shadow: Discard an attachment you control.")
                .WithEasyModeQuantity(1)
                .WithInfo(38, 2, Artist.Drazenka_Kimpel);
            addTreachery("Secret Cultist", setDangerInDorwinion)
                .WithText("When Revealed: Attach to the highest attack ally in play. (Counts as a Condition attachment with the text: \"Attached ally loses the ally card type, gains the enemy card type, and engages its owner. Treat attached ally's text box as if it were blank. If Secret Cultist is discarded, or the attached ally's owner is eliminated, discard attached ally.\")")
                .WithEasyModeQuantity(1)
                .WithInfo(39, 2, Artist.Nikolas_Hagialas);
            addEnemy("Messenger from Mordor", setServantsOfSauron, 34, 2, 4, 2, 4)
                .WithTraits("Mordor.")
                .WithText("When Revealed: Either raise each player's threat by X, where X is the active location's Threat, or Messenger from Mordor makes an immediate attack against the first player.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack.")
                .WithInfo(40, 3, Artist.Kevin_Zamir_Goeke);
            addEnemy("Servant of Sauron", setServantsOfSauron, 36, 1, 2, 1, 3)
                .WithTraits("Mordor.")
                .WithKeywords("Surge.")
                .WithText("Servant of Sauron engages the first player.\r\nForced: After the engaged player raises his threat, Servant of Sauron makes an immediate attack. (Limit once per phase.)")
                .WithEasyModeQuantity(1)
                .WithInfo(41, 2, Artist.Rafal_Hrynkiewicz);
            addTreachery("Overwhelmed", setServantsOfSauron)
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Until the end of the round, enemies engaged with the first player cannot take damage.")
                .WithShadow("Shadow: Either raise your threat by 2, or attacking enemy cannot take damage this round.")
                .WithEasyModeQuantity(1)
                .WithInfo(42, 2, Artist.Greg_Bobrowski);
            addEncounterSideQuest("Shadow of Fear", setServantsOfSauron, 6)
                .WithFlavor("The shadow of Mordor is on the servants of the Enemy, and they inspire fear in your companions. Only a stout heart can stand against them.")
                .WithKeywords("Surge.")
                .WithText("Forced: After an enemy engages a player, that player raises his threat by 1.\r\nResponse: When Shadow of Fear is defeated, reduce each player's threat by 3.")
                .WithVictoryPoints(10)
                .WithInfo(43, 1, Artist.Jarreau_Wimberly);
            addEnemy("Rhûn Backstabber", setCityOfRhun, 28, 2, 3, 2, 3)
                .WithTraits("Easterling.")
                .WithText("Forced: After Rhûn Backstabber engages you, either raise your threat by 2, or discard an ally you control with printed cost 2 or higher.")
                .WithShadow("Shadow: Raise your threat by 1 for each enemy engaged with you.")
                .WithInfo(44, 2, Artist.Jon_Bosco);
            addEnemy("Treacherous Easterling", setCityOfRhun, 32, 3, 3, 1, 5)
                .WithTraits("Easterling.")
                .WithText("Treacherous Easterlings gets +1 Attack and +1 Defense for each resource token on it (Limit +3 Attack and +3 Defense.)\r\nForced: After the engaged player raises his threat, place 1 resource token on Treacherous Easterling.")
                .WithEasyModeQuantity(1)
                .WithInfo(45, 2, Artist.Romana_Kendelic);
            addLocation("City Forum", setCityOfRhun, 1, 5)
                .WithTraits("City.")
                .WithText("City Forum gets +1 Threat for each resource here.\r\nWhile City Forum is in the staging area, it gains: \"Forced: After a location is explored, place 1 resource here.\"\r\nTravel: Each player raises his threat by 1 for each resource here.")
                .WithInfo(46, 2, Artist.Aleksander_Karcz);
            addLocation("Seedy Tavern", setCityOfRhun, 2, 5)
                .WithTraits("City.")
                .WithText("Immune to player card effects.\r\nForced: When Seedy Travern is explored, reveal each facedown card under it.\r\nTravel: Look at the top 5 cards of the encounter deck. Put one of those cards facedown under Seedy Tavern and shuffle the rest back into the encounter deck.")
                .WithVictoryPoints(2)
                .WithInfo(47, 2, Artist.Nikolas_Hagialas);
            addTreachery("Darkness in the East", setCityOfRhun)
                .WithText("When Revealed: Raise each player's threat by X, where X is the active location's Threat. If there is no active location, Darkness in the East gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if you raised your threat this round).")
                .WithInfo(48, 2, Artist.Lucas_Staniec);
            addLocation("Side Street", setUnderGuard, 3, 3)
                .WithTraits("City.")
                .WithText("While Side Street is in the staging area, progress cannot be placed on other locations in the staging area.\r\nTravel: Shuffle the encounter discard pile into the encounter deck and discard cards until a location is discarded. Add that location to the staging area.")
                .WithEasyModeQuantity(1)
                .WithInfo(49, 2, Artist.Carlos_Palma_Cruchaga);
            addLocation("Catacombs", setUnderGuard, 4, 4)
                .WithTraits("City.")
                .WithText("While Catacombs is in the staging area, enemes in the staging area cannot take damage.\r\nTravel: Each player discards the top card of the encounter deck. If a player discards an enemy this way, he puts it into play engaged with him.")
                .WithEasyModeQuantity(1)
                .WithInfo(50, 2, Artist.Dimitri_Bielak);
            addTreachery("Under Guard", setUnderGuard)
                .WithText("When Revealed: Resolve the Travel effect on the active location. If there is no active location, discard cards from the encounter deck until a location is discarded. Add that location to the staging area.")
                .WithShadow("Shadow: If this attack destroys a character, resolve the Travel effect on the active location.")
                .WithEasyModeQuantity(2)
                .WithInfo(51, 3, Artist.Aleksander_Karcz);
            addEncounterSideQuest("Unwelcome Travelers", setUnderGuard, 5)
                .WithFlavor("The longer you wander the streets, the more unwanted attention you attract.")
                .WithText("Each location in the staging area gets +1 Threat.\r\nForced: After Unwelcome Travelers becomes the current quest, the first player discards cards from the top of the encounter deck until an enemy is discarded and puts it into play engaged with him.")
                .WithVictoryPoints(10)
                .WithInfo(52, 1, Artist.Marius_Bota);
            addEncounterSideQuest("Tribute to Mordor", setTempleOfDoom, 12)
                .WithFlavor("The servants of Sauron perform ritual sacrifice to invoke the power of Mordor.")
                .WithText("Forced: At the end of the round, place 1 damage token here. Then, if there are 4 or more damage tokens here, remove 4 of them and reveal the top card of the Power of Mordor deck. If you cannot, the player lose the game.\r\nThis stage cannot be the active quest while Thane Ulchor has any hit points remaining. When this stage is defeated, the players win the game.")
                .WithVictoryPoints(10)
                .WithInfo(53, 1, Artist.Aleksander_Karcz);
            addEnemy("Thane Ulchor", setTempleOfDoom, 50, Card.VALUE_X, 6, 4, 9)
                .WithUnique()
                .WithTraits("Mordor.")
                .WithKeywords("Indestructible.")
                .WithText("Immune to player card effects.\r\nX is 1 more than the number of quest stages in the victory display. Cannot be engaged unless X is equal to 5.\r\nForced: When Thane Ulchor attacks and destroys a character, place 1 damage token on Tribute to Mordor.")
                .WithVictoryPoints(6)
                .WithInfo(54, 1, Artist.Ivan_Dixon);
            addLocation("Temple of Sauron", setTempleOfDoom, 4, 1)
                .WithTraits("Underground.")
                .WithText("Forced: When Temple of Sauron leaves play, place 1 damage token on Tribute to Mordor.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each quest stage in the victory display.")
                .WithEasyModeQuantity(1)
                .WithInfo(55, 2, Artist.Alexander_Chelyshev);
            addLocation("Hall of Horrors", setTempleOfDoom, Card.VALUE_X, 5)
                .WithTraits("Underground.")
                .WithText("X is 1 more than the number of quest stages in the victory display.\r\nForced: When Hall of Horrors leaves play, each player deals X damage to a character he controls.")
                .WithFlavor("...they had worshipped Sauron in the Dark Years.\r\n-The Return of the King")
                .WithEasyModeQuantity(2)
                .WithInfo(56, 3, Artist.Alvaro_Calvo_Escudero);
            addTreachery("Place of Evil", setTempleOfDoom)
                .WithText("When Revealed: Place 1 damage token on Tribute to Mordor. Then, either place 1 additional damage token on Tribute to Mordor, or Place of Evil gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, place 1 damage token on Tribute to Mordor.")
                .WithEasyModeQuantity(1)
                .WithInfo(57, 3, Artist.Federico_Musetti);
            addEnemy("Ulchor's Guard", setUlchorsGuard, 25, 2, 4, 1, 5)
                .WithTraits("Easterling.")
                .WithText("While Thane of Ulchor is engaged with a player, Ulchor's Guard engages that player.")
                .WithShadow("Shadow: Attacking enemy gets +2 Defense until the end of the phase.")
                .WithEasyModeQuantity(3)
                .WithInfo(58, 4, Artist.Kevin_Zamir_Goeke);
            addTreachery("Ulchor's Rage", setUlchorsGuard)
                .WithText("When Revealed: Thane Ulchor makes an immediate attack against the first player. If no attack is made this way, Ulchor's Rage gains surge.")
                .WithShadow("Shadow: Deal 1 damage to the defening character.")
                .WithEasyModeQuantity(1)
                .WithInfo(59, 3, Artist.Ivan_Dixon);
            addTreachery("Fanaticism", setUlchorsGuard)
                .WithTraits("Easterling.")
                .WithText("While attached to an enemy, counts as a Condition attachment with the text: \"Attached enemy gets +1 Threat, +1 Attack, +1 Defense, and is immune to player card effects.\"\r\nWhen Revealed: Attach to the Easterling enemy with the lowest Defense without a copy of Fanaticism. Otherwise, Fanaticism gains surge.")
                .WithInfo(60, 2, Artist.Guillaume_Ducos);
            addLocation("Twisted Tunnel", setTwistedTunnels, 2, 2)
                .WithTraits("Underground.")
                .WithText("When Revealed: Discard cards from the top of the encounter deck until an enemy is discarded. Add that enemy to the staging area.")
                .WithShadow("Shadow: Discard the top card of the encounter deck. If that card is an enemy, add it to the staging area.")
                .WithInfo(61, 2, Artist.Dual_Brush_Studios);
            addLocation("Narrow Opening", setTwistedTunnels, 3, 3)
                .WithTraits("Underground.")
                .WithText("While Narrow Opening is the active location, each player cannot play more than 1 card each round.\r\nForced: When Narrow Opening leaves play, each player discards 1 random card from his hand.")
                .WithFlavor("\"I got stuck in the door, which was only open a crack, and I lost lots of buttons...\"\r\n-Bilbo, The Hobbit")
                .WithInfo(62, 2, Artist.Dimitri_Bielak);
            addLocation("Crumbling Passage", setTwistedTunnels, 5, 3)
                .WithTraits("Underground.")
                .WithText("When Revealed: Make Crumbling Passage the active location, returning any previously active location to the staging area.\r\nForced: When Crumbling Passage leaves play, deal 1 damage to each exhausted character.")
                .WithFlavor("...at that moment a stone hurtling from above smote heavily on his helm, and he fell with a crash and knew no more.\r\n-The Hobbit")
                .WithEasyModeQuantity(1)
                .WithInfo(63, 2, Artist.Matthew_Cowdery);
            addTreachery("Fearful Shadows", setTwistedTunnels)
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Until the end of the round, treat the printed text box of each character as if it were blank (except for Traits).")
                .WithShadow("Shadow: Defending character cannot ready until the end of the round.")
                .WithEasyModeQuantity(1)
                .WithInfo(64, 2, Artist.Drazenka_Kimpel);
            addEncounterSideQuest("Lost in the Dark", setTwistedTunnels, 8)
                .WithFlavor("It's nearly impossible to find your way through this maze of dark tunnels.")
                .WithText("When Revealed: Each player places the top 10 cards of his deck facedown under his threat dial (without looking at them). When this stage is defeated, each player shuffles all cards under his threat dial back into his deck.\r\nForced: After a player raises his threat by any amount, he discards the top card from under his threat dial.")
                .WithVictoryPoints(10)
                .WithInfo(65, 1, Artist.Ilich_Henriquez);
            addEnemy("Khamûl the Easterling", setThePowerOfMordor, 49, 4, 6, 4, 9)
                .WithUnique()
                .WithTraits("Nazgûl.", "Easterling.", "Mordor.")
                .WithText("Immune to player card effects.\r\nKhamûl the Easterling engages the first player.\r\nOnly the engaged player can declare attackers or defenders against Khamûl the Easterling.")
                .WithInfo(66, 1, Artist.Sam_Lamont);
            addLocation("The Tower of Barad-dûr", setThePowerOfMordor, 5, Card.VALUE_NA)
                .WithUnique()
                .WithTraits("Mordor.")
                .WithText("Immune to player card effects.\r\nThe player cannot travel here.\r\nEach player's threat elimination level is reduced by 5.")
                .WithFlavor("...wall upon wall, battlement upon battlement, black, immeasurably strong, mountain of iron, gate of steel, tower of adamant, he saw it: Barad-dûr, Fortress of Sauron. All hope left him.\r\n-The Fellowship of the Ring")
                .WithInfo(67, 1, Artist.Federico_Musetti);
            addObjective("Under the Watchful Eye", setThePowerOfMordor)
                .WithTraits("Mordor.")
                .WithText("When Revealed: Each player with more than 5 cards in his hand discards cards from his hand until he has only 5.\r\nForced: After a player draws any number of cards, he raises his threat by 1.")
                .WithFlavor("\"Nothing can hide from them.\"\r\n-Gollum, The Two Towers")
                .WithInfo(68, 1, Artist.Tomasz_Jedruszek);
            addObjective("The Armies of Mordor", setThePowerOfMordor)
                .WithTraits("Mordor.")
                .WithText("Forced: After a non-unique enemy engages a player, that enemy cannot take damage until the end of the round.")
                .WithFlavor("...here the Dark Power, moving its armies like pieces on the board, was gathering them together.\r\n-The Return of the King")
                .WithInfo(69, 1, Artist.Stanislav_Dikolenko);
            addObjective("Covered in Darkness", setThePowerOfMordor)
                .WithTraits("Mordor.")
                .WithKeywords("Doomed 5.")
                .WithText("Each player's threat cannot be reduced by more than 1 each round by player card effects.")
                .WithFlavor("Darkness lay there under the Sun. Fire glowed amid the smoke. Mount Doom was burning, and a great reek rising.\r\n-The Fellowship of the Ring")
                .WithInfo(70, 1, Artist.Dimitri_Bielak);
            addTreachery("Stinker", EncounterSet.GollumAndSmeagol.Name)
                .WithTraits("Gollum.")
                .WithKeywords("Surge.")
                .WithText("When Revealed: ~Gollum makes an immediate attack. If no attach was made this way, discard all tokens from Sméagol and flip him to ~Gollum.")
                .WithShadow("Shadow: Raise your threat by 2 (by 4 instead if ~Gollum is engaged with you). Shuffle Stinker back into the encounter deck.")
                .WithInfo(71, 2, Artist.Rafal_Hrynkiewicz);
            addHero("Sméagol", 3, Sphere.Lore, 2, 2, 2, 3)
                .WithTraits("Gollum.")
                .WithText("Cannot have attachments.\r\nSetup: Shuffle 2 copies of Stinker into the encounter deck.\r\nResponse: After you travel to a location, raise your threat by 1 to draw 1 card.")
                .WithInfo(72, 1, Artist.Martin_de_Diego_Sadaba);
            addEnemy("Gollum", EncounterSet.GollumAndSmeagol.Name, 50, 2, 2, 2, 3)
                .WithUnique()
                .WithTraits("Gollum.")
                .WithText("Immune to non-Gollum card effects.\r\n~Gollum engages the first player.\r\nForced: When ~Gollum is defeated, flip him to Sméagol and return him to his owner's control, exhausted.")
                .WithTemplate("<p class='main-text'>Immune to non-{trait:Gollum.@Gollum} card effects.</p><p class='main-text'>{self} engages the first player.</p><p class='main-text'><b>Forced:</b> When {self} is defeated, flip him to Sméagol and return him to his owner's control, exhausted.</p>") 
                .WithInfo(73, 1, Artist.Alexander_Chelyshev);
            addContract("Fellowship")
                .WithText("You cannot play non-unique allies or put non-unique allies into play.\r\nForced: When you control exactly 9 unique characters, flip this card over.")
                .WithOppositeText("You cannot play allies or put allies into play.\r\nEach character you control gets +1 Willpower, +1 Attack, and +1 Defense.\r\nForced: After a character you control leaves play, flip this card over.")
                .WithInfo(74, 1, Artist.Leanna_Crossan);
            addQuest("Chased by Easterlings", setTheRiverRunning, 1, 'A', 5)
                .WithFlavor("You are traveling south along the River Running on your way to Dorwinion when you are attacked by Easterling raiders in the night. The raiders set fire to your boat, trapping you on the east side of the river, and you are forced to flee south on foot.")
                .WithText("Setup: Set Warriors of the East aside, out of play. Add Easterling Pursuit and 1 copy of River Running to the staging area. Each player adds 1 different Easterling enemy to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("Your only hope is to reach the safety of Dorwinion by the Crossing of Araw before your Easterling pursuers overtake you.")
                .WithOppositeText("This stage gets +5 quest points per player.\r\nAdd +1 Threat to the total threat in the staging area for each resource token on Easterling Pursuit.")
                .WithIncludedEncounterSets(EncounterSet.RidersOfRhun, EncounterSet.EasterlingRaiders, EncounterSet.RollingPlains)
                .WithInfo(75, 1, Artist.Aleksander_Karcz);
            addQuest("The Crossing of Araw", setTheRiverRunning, 2, 'A', 15)
                .WithFlavor("You have reached the crossing, but some of your enemies anticipated this course of action and raced here ahead of you. They fight to delay your escape while their comrades close in from behind.")
                .WithText("When Revealed: Add Warriors of the East to the staging area. Shuffle the encounter discard pile into the encounter deck and discard cards from the top until X enemies are discarded, where X is the number of players. Add each enemy discarded this way to the staging area.")
                .WithOppositeFlavor("You must fight your way past the Easterlings to cross into Dorwinion.")
                .WithOppositeText("Each enemy in the staging area gets -10 enagement cost.\r\nWhile at least one player is engaged with an enemy, no more than 5 progress can be placed here each round.\r\nWhen this stage is defeated, the players win the game.")
                .WithIncludedEncounterSets(EncounterSet.RidersOfRhun, EncounterSet.EasterlingRaiders, EncounterSet.RollingPlains)
                .WithInfo(76, 1, Artist.Chris_Grun);
            addQuest("A City in Turmoil", setDangerInDorwinion, 1, 'A', 5)
                .WithFlavor("A shadow hangs over the capital of Dorwinion. Fear grips the heart of the city on the Sea of Rhûn. People have been disappearing, and it is rumored that a cult of Sauron worshippers are responsible.")
                .WithText("Setup: Set each plot objective and each Cultist enemy aside, out of play. Each player searches the encounter deck for a different location and adds it to the staging area. One of those locations must be Side Street. Shuffle the encounter deck.")
                .WithOppositeFlavor("The people you came to help beg you to uncover the truth of these rumors and rescue their lost loved ones if you can.")
                .WithOppositeText("Forced: After the active location leaves play as an explored location, place 1 resource here.\r\nThis stage cannot be defeated unless there are at least 2 resources here.")
                .WithIncludedEncounterSets(EncounterSet.ServantsOfSauron, EncounterSet.CityOfRhun, EncounterSet.UnderGuard)
                .WithInfo(77, 1, Artist.Lucas_Staniec);
            addQuest("The Shadow of Mordor", setDangerInDorwinion, 2, 'A', 0)
                .WithFlavor("Your investigation has found that the rumors are true: a cult of Sauron worshippers has taken root in Dorwinion, and they are plotting to overthrow the peaceful country.")
                .WithText("When Revealed: Add 1 random set aside Plot objective to the staging area. Reveal 1 encounter card per player.")
                .WithOppositeFlavor("You must find the leader of the cult in order to put an end to this evil plot.")
                .WithOppositeText("Forced: After the active location leaves play as an explored location, reveal the top card of the encounter deck. Then, place 1 resource here.\r\nThis stage cannot be defeated unless there are at least X resources here, where X is 3 more than the number of players.")
                .WithIncludedEncounterSets(EncounterSet.ServantsOfSauron, EncounterSet.CityOfRhun, EncounterSet.UnderGuard)
                .WithInfo(78, 1, Artist.Matthew_Cowdery);
            addQuest("Leader of the Cult", setDangerInDorwinion, 3, 'A', Card.VALUE_NA)
                .WithFlavor("You have discovered the cult's secret meeting place in the catacombs below the city.")
                .WithText("When Revealed: Add 1 random set-aside Cultist enemy to the staging area. Shuffle the encounter discard pile into the encounter deck and discard cards until X enemies are discarded, where X is one less than the number of players. Add each enemy discarded this way to the staging area.")
                .WithOppositeFlavor("Inside the catacombs you see evidence of evil deeds done in Sauron's name, and the leader of the cult at the center of it. You must defeat this agent of Mordor in order order to put an end to these atrocities.")
                .WithOppositeText("The Cultist cannot take more than X damage each round, where X is the printed quest points of the active location.\r\nWhen the Cultist enemy is defeated, the players win the game.")
                .WithIncludedEncounterSets(EncounterSet.ServantsOfSauron, EncounterSet.CityOfRhun, EncounterSet.UnderGuard)
                .WithInfo(79, 1, Artist.Sebastian_Zakrzewski);
            addQuest("The Forgotten Temple", setTempleOfDoom, 1, 'A', Card.VALUE_NA)
                .WithFlavor("Your search for the missing Dorwinions has led you up the mountains of Rhûn. There you discover the remains of an ancient temple built to honor Sauron during the dark years of Middle-earth.")
                .WithText("Setup: Shuffle each of the stage 2 quest cards together and place them facedown under this stage. Create The Power of Mordor deck (see insert) and set it next to the quest deck. Add Thane Ulchor and Tribute to Mordor to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("The journey to reach this place has been difficult and you take a moment to prepare yourself before entering the dark temple.")
                .WithOppositeText("Skip the quest phase.\r\nForced: At the end of the planning phase, place 1 resource token here. Then, if there are 2 resource tokens here, add this stage to the victory display and advance to the topmost stage 2A.")
                .WithIncludedEncounterSets(EncounterSet.UlchorsGuard, EncounterSet.TwistedTunnels, EncounterSet.EasterlingRaiders, EncounterSet.ThePowerOfMordor)
                .WithVictoryPoints(10)
                .WithInfo(80, 1, Artist.Kevin_Zamir_Goeke);
            addQuest("The Legacy of Mordor", setTempleOfDoom, 2, 'A', 8)
                .WithFlavor("Rows of iron-barred cells line both sides of a dark dungeon built beneath the old temple. You shudder to think what horrible fate befell the captives that were held here in years past as you continue to search for the missing Dorwinions.")
                .WithText("When Revealed: Reveal 1 encounter card per player.")
                .WithOppositeText("Forced: At the beginning of the quest phase, each player deals 1 damage to a hero he controls and exhausts that hero. That hero cannot ready or be healed until the refresh phase.\r\nWhile there are 4 quest stages in the victory display, progress cannot be placed here.")
                .WithVictoryPoints(1)
                .WithIncludedEncounterSets(EncounterSet.UlchorsGuard, EncounterSet.TwistedTunnels, EncounterSet.EasterlingRaiders, EncounterSet.ThePowerOfMordor)
                .WithVictoryPoints(1)
                .WithInfo(81, 1, Artist.Stanislav_Dikolenko);
            addQuest("Memory of the Dark Years", setTempleOfDoom, 2, 'A', 12)
                .WithFlavor("All about you are the cruel trappings of Mordor: evidence of torture and death callously strewn about the cavern floor. You search among the bones and debris for fresh signs of those you seek.")
                .WithText("When Revealed: Reveal 1 encounter card per player.")
                .WithOppositeText("Forced: At the beginning of the quest phase, discard X cards from the top of the encounter deck, where X is 1 more than the number of quest stages in the victory display. Add 2 to the total Threat in the staging area for each different card type discarded this way.\r\nWhile there are 4 quest stages in the victory display, progress cannot be place here.")
                .WithIncludedEncounterSets(EncounterSet.UlchorsGuard, EncounterSet.TwistedTunnels, EncounterSet.EasterlingRaiders, EncounterSet.ThePowerOfMordor)
                .WithVictoryPoints(1)
                .WithInfo(83, 1, Artist.Dual_Brush_Studios);
            addQuest("Shrine to Sauron", setTempleOfDoom, 2, 'A', 16)
                .WithFlavor("A blood-stained altar to the Dark Lord of Mordor looks to have been used recently. Though the carved stone is ancient, the blood and cloth you find on it are fresh. You search about frantically to find the captive Dorwinions before more are slaughtered.")
                .WithText("When Revealed: Reveal 1 encounter card per player.")
                .WithOppositeText("Forced: At the beginning of the quest phase, each player discards the top X cards of his deck, where X is 1 more than the number of quest stages in the victory display. Each player examines the cards he controls and the cards in his hand. If any of these cards are copies of the cards he just discarded from the top of his deck, he must discard those copies as well.\r\nWhile there are 4 quest stages in the victory display, progress cannot be placed here.")
                .WithIncludedEncounterSets(EncounterSet.UlchorsGuard, EncounterSet.TwistedTunnels, EncounterSet.EasterlingRaiders, EncounterSet.ThePowerOfMordor)
                .WithVictoryPoints(1)
                .WithInfo(84, 1, Artist.Stanislav_Dikolenko);
            addQuest("The Lord of Middle-earth", setTempleOfDoom, 2, 'A', 0)
                .WithFlavor("At the center of a large temple room is a hideous state of Sauron seated upon an iron throne. It is a terrible reminder of the darkness that awaits Middle-earth should you fail in your vigilance.")
                .WithText("When Revealed: Reveal 1 encounter card per player.")
                .WithOppositeText("This stage gets +4 quest points per player.\r\nForced: At the beginning of the quest phase, each player discards 1 card from his hand. Until the end of the round, no more than X progress can be placed on this stage. X is the total cost of each card discarded by this effect.\r\nWhile there are 4 quest stages in the victory display, progress cannot be placed here.")
                .WithIncludedEncounterSets(EncounterSet.UlchorsGuard, EncounterSet.TwistedTunnels, EncounterSet.EasterlingRaiders, EncounterSet.ThePowerOfMordor)
                .WithVictoryPoints(1)
                .WithInfo(85, 1, Artist.Alexander_Chelyshev);
        }
    }
}