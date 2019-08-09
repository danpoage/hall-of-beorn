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
        private const string setEasterlingRiders = "Easterling Riders";
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
                .WithText("Surge.\r\nForced: After Easterling Outrider engages a player, either place 1 resource on Easterling Pursuit, or Easterling Outrider makes an immediate attack.")
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
                .WithText("Archery 2.\r\nRider of Rhûn gets -10 enagement cost for each Easterling attachment it has.\r\nWhen Revealed: Search the encounter deck and discard pile for an Easterling Horse and attach it to Rider of Rhûn. Shuffle the encounter deck.")
                .WithEasyModeQuantity(1)
                .WithInfo(18, 2, Artist.Marco_Caradonna);
            addTreachery("Easterling Horse", setRidersOfRhun)
                .WithTraits("Easterling.")
                .WithText("While attached to an enemy, counts as a Mount attachment with the text: \"Attached enemy gets +2 Threat. Forced: At the end of the round, return attached enemy to the staging area.\"\r\nWhen Revealed: Attach to the lowest engagement cost Easterling enemy without an Easterling Horse and return it to the staging area. Otherwise, Easterling Horse gains surge.")
                .WithInfo(19, 3, Artist.Guillaume_Ducos);

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
        }
    }
}