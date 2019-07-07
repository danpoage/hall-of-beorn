using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheLordOfTheRings
{
    public class TheFlameOfTheWestSet : CardSet
    {
        private const string setThePassingOfTheGreyCompany = "The Passing of the Grey Company";
        private const string setTheSiegeOfGondor = "The Siege of Gondor";
        private const string setTheBattleOfThePelennorFields = "The Battle of the Pelennor Fields";

        protected override void Initialize()
        {
            Name = "The Flame of the West";
            Abbreviation = "TFotW";
            Number = 1007;
            SetType = Models.SetType.Saga_Expansion;
            Cycle = "The Lord of the Rings";

            Cards.Add(LotRCard.Hero("Aragorn", "", Sphere.Fellowship, 0, 2, 3, 2, 5)
                .WithTraits("Dúnedain.", "Noble.", "Ranger.")
                .WithText("The first player gains control of Aragorn. If Aragorn leaves play, the players lose the game.\r\nWhile Aragorn has an Artifact attached, he gains sentinel and does not exhaust to quest.")
                .WithFlavor("\"I have no help to send, therefore I must go myself...\"\r\n-The Return of the King")
                .WithInfo(1, 1, Artist.Javier_Charro_Martinez));
            Cards.Add(LotRCard.Hero("Éowyn", "", Sphere.Tactics, 9, 4, 1, 1, 3)
                .WithTraits("Rohan.", "Noble.")
                .WithText("Setup: Reduce your threat by 3.\r\nAction: Raise your threat by 3 to ready Éowyn. She gets +9 Attack until the end of the phase. (Limit once per game for the group.)")
                .WithFlavor("\"But no living man am I! You look upon a woman. Éowyn I am, Éomund's daughter.\"\r\n-The Return of the King")
                .WithInfo(2, 1, Artist.Magali_Villeneuve));
            addHero("Beregond", 10, Sphere.Spirit, 0, 1, 4, 4)
                .WithTraits("Gondor.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After Beregond defends an attack and takes no damage, reduce the defending player's threat by 1. (Limit once per round.)")
                .WithFlavor("\"The Lord does not permit those who wear the black and silver to leave their post for any cause...\"\r\n-The Return of the King")
                .WithTemplate("<p class='main-text'>{keyword:Sentinel.}</p><p class='main-text'><b>Response:</b> After {self} defends an attack and takes no damage, reduce the defending player's threat by 1. (Limit once per round.)</p><p class='flavor-text'>&ldquo;The Lord does not permit those who wear the black and silver to leave their post for any cause...&rdquo;<br>&ndash;The Return of the King</p>")
                .WithInfo(3, 1, Artist.Adam_Lane);
            Cards.Add(LotRCard.Ally("Grimbold", Sphere.Tactics, 3, 2, 1, 1, 2)
                .WithUnique()
                .WithTraits("Rohan.", "Warrior.")
                .WithText("Combat Action: Discard Grimbold to choose an enemy engaged with a player. That enemy cannot attack that player this phase.")
                .WithFlavor("Grimbold's men turned aside and passed round to a great gap in the wall further eastward.\r\n-The Return of the King")
                .WithInfo(4, 3, Artist.Lucas_Durham));
            Cards.Add(LotRCard.Ally("Prince Imrahil", Sphere.Spirit, 4, 2, 2, 2, 3)
                .WithUnique()
                .WithTraits("Gondor.", "Noble.")
                .WithText("While there is a hero in your discard pile, Prince Imrahil loses the ally card type and gains the hero card type.")
                .WithFlavor("\"We must gather all of the strength that we can find.\r\n-The Return of the King")
                .WithInfo(5, 3, Artist.Gabriel_Verdon));
            Cards.Add(LotRCard.Ally("Halbarad", Sphere.Leadership, 4, 2, 2, 2, 3)
                .WithUnique()
                .WithTraits("Dúnedain.", "Ranger.")
                .WithText("Reduce the cost to play Halbarad by 1 for each enemy engaged with you.\r\nEach enemy engaged with you gets +10 engagement cost.")
                .WithFlavor("\"Halbarad Dunadan, Ranger of the North I am...\"\r\n-The Return of the King")
                .WithInfo(6, 3, Artist.Adam_Lane));
            Cards.Add(LotRCard.Ally("Ghân-buri-Ghân", Sphere.Lore, 2, Card.VALUE_X, 1, 1, 2)
                .WithUnique()
                .WithTraits("Wose.")
                .WithText("X is the Threat of the active location.\r\nTravel Action: Discard Ghân-buri-Ghân to travel to a location without resolving its Travel effect.")
                .WithInfo(7, 3, Artist.Piya_Wannachaiwong));
            Cards.Add(LotRCard.Event("Sterner than Steel", "", Sphere.Tactics, 0)
                .WithText("Response: Exhaust a Weapon or Armor card attached to the defending character to cancel a shadow effect just triggered in combat")
                .WithFlavor("\"Do what you will; but I will hinder it, if I may.\"\r\n-Éowyn, The Return of the King")
                .WithInfo(8, 3, Artist.Chris_Rahn));
            Cards.Add(LotRCard.Event("Desperate Defense", "", Sphere.Spirit, 1)
                .WithText("Response: After a sentinel character is declared as a defender, it gets +2 Defense for this attack. If this attack deals no damage, ready the defending character.")
                .WithFlavor("...but alone in the porch upon the topmost step stood Beregond, clad in the black and silver of the Guard; and he held the door against them.\r\n-The Return of the King")
                .WithInfo(9, 3, Artist.Adam_Lane));
            addAttachment("Golden Shield", 1, Sphere.Tactics, true)
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Rohan hero.\r\nResponse: After attached hero is declared as a defender, exhaust Golden Shield to add attached hero's Willpower to its Defense for this attack.")
                .WithFlavor("His golden shield was uncovered, and lo! it shone like an image of the Sun...\r\n-The Return of the King")
                .WithTemplate("<p class='main-text'>Attach to a {trait:Rohan} hero. {keyword:Restricted.}</p><p class='main-text'><b>Response:</b> After attached hero is declared as a defender, exhaust {self} to add attached hero's {Willpower} to its {Defense} for this attack.</p><p class='flavor-text'>His golden shield was uncovered, and lo! it shone like an image of the Sun...<br>&ndash;The Return of the King</p>")
                .WithInfo(10, 3, Artist.Sasha_Jones);
            addAttachment("Livery of the Tower", 0, Sphere.Spirit, false)
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Gondor hero.\r\nResponse: Spend X resources from attached hero's pool to cancel X damage just dealt to attached hero.")
                .WithFlavor("This was the livery of the heirs of Elendil, and none wore it now in all Gondor, save the Guards of the Citadel...\r\n-The Return of the King")
                .WithTemplate("<p class='main-text'>Attach to {trait-hero:Gondor.@Gondor} hero. {keyword:Restricted.}</p><p class='main-text'><b>Response:</b> Spend X resources from attached hero's pool to cancel X damage just dealt to attached hero.</p><p class='flavor-text'>This was the livery of the heirs of Elendil, and none wore it now in all Gondor, save the Guards of the Citadel...<br>&ndash;The Return of the King</p>")
                .WithInfo(11, 3, Artist.Suzanne_Helmigh);
            Cards.Add(LotRCard.Attachment("Roheryn", "", Sphere.Leadership, 2)
                .WithUnique()
                .WithTraits("Mount.")
                .WithText("Attach to a Dúnedain hero.\r\nIf the attached hero is Aragorn, he gains a Tactics icon.\r\nResponse: After you optionally engage an enemy, exhaust Roheryn and attached hero to declare attached hero as an attacker (and resolve its attack) against that eneny.")
                .WithFlavor("\"Aragorn's own horse that they had brought from the North; Roheryn was his name.\"\r\n-The Return of the King")
                .WithInfo(12, 3, Artist.Eva_Maria_Toker));
            Cards.Add(LotRCard.Attachment("Banner of Elendil", "", Sphere.Fellowship, 3)
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithText("Attach to Aragorn.\r\nWhile Aragorn is questing, each other questing character you control gets +1 Willpower.\r\nWhile Aragorn is attacking, each other attacking character you control gets +1 Attack.")
                .WithFlavor("Seven stars were about it, and a high crown above it, the signs of Elendil that no lord had borne for years beyond count.\r\n-The Return of the King")
                .WithInfo(13, 3, Artist.Jenn_Tran));
            Cards.Add(LotRCard.Attachment("Esquire of Rohan", "", Sphere.Neutral, 0)
                .WithUnique()
                .WithBoon()
                .WithTraits("Title.")
                .WithKeywords("Permanent.")
                .WithText("Setup: Attach to a hero.\r\nAttached hero gains the Rohan trait.\r\nAttached hero gets +1 Attack while attacking with another Rohan character.")
                .WithFlavor("\"Rise now, Meriadoc, esquire of Rohan of the household of Meduseld!\"\r\n-Théoden, The Return of the King")
                .WithInfo(14, 1, Artist.Romana_Kendelic));
            Cards.Add(LotRCard.Attachment("Esquire of Gondor", "", Sphere.Neutral, 0)
                .WithUnique()
                .WithBoon()
                .WithTraits("Title.")
                .WithKeywords("Permanent.")
                .WithText("Setup: Attach to a hero.\r\nAttached hero gains the Gondor trait.\r\nAttached hero gets +1 Willpower while commited to the quest with another Gondor character.")
                .WithFlavor("\"Here do I swear fealty and service to Gondor, and to the Lord and Steward of the realm...\"\r\n-Pippin, The Return of the King")
                .WithInfo(15, 1, Artist.Romana_Kendelic));
            Cards.Add(LotRCard.Objective("Overcome by Fear", string.Empty, setThePassingOfTheGreyCompany)
                .WithBurden()
                .WithTraits("Fear.")
                .WithText("Setup: Attach to your threat dial. Limit 1 per threat dial.\r\nYour threat cannot be reduced.\r\nForced: At the end of the round, raise your threat by 1. Then you may spend 1 Fellowship resource to detach Overcome by ~Fear and set it aside, out of play.")
                .WithInfo(16, 4, Artist.Micah_Epstein));
            Cards.Add(LotRCard.Location("The Stone of Erech", string.Empty, setThePassingOfTheGreyCompany, 5, 5)
                .WithUnique()
                .WithTraits("Hill.")
                .WithText("Immune to player card effects.\r\nForced: After The Stone of Erech becomes the active location, each player searches the encounter deck and discard pile for an Oathbreaker enemy and adds it to the staging area. Shuffle the encounter deck.\r\nTravel: Remove 5 progress from stage 3B to travel here.")
                .WithInfo(17, 1, Artist.Dawn_Carlos));
            Cards.Add(LotRCard.Location("Dark Door", string.Empty, setThePassingOfTheGreyCompany, 4, 4)
                .WithTraits("Underground.")
                .WithText("While Dark Door is in the staging area, progress cannot be placed on locations in the staging area.\r\nTravel: The first player reveals an encounter card to travel here.")
                .WithFlavor("...before him stood a stony door closed fast...\r\n-The Return of the King")
                .WithEasyModeQuantity(1)
                .WithInfo(18, 2, Artist.Yoann_Boissonnet));
            Cards.Add(LotRCard.Location("Trysting Place", string.Empty, setThePassingOfTheGreyCompany, 3, 3)
                .WithTraits("Underground.")
                .WithText("While Trysting Place is in the staging area, each enemy in the staging area cannot take damage.\r\nTravel: The first player searches the encounter deck and discard pile for an Oathbreaker enemy and puts it into play engaged with him. Shuffle the encounter deck.")
                .WithEasyModeQuantity(2)
                .WithInfo(19, 3, Artist.Leanna_Crossan));
            Cards.Add(LotRCard.Location("Deadly Road", string.Empty, setThePassingOfTheGreyCompany, 2, 3)
                .WithTraits("Underground.")
                .WithText("While Deadly ~Road is in the staging area, it gains: \"Forced: After a 'when revealed' effect is canceled, raise each player's threat by 1.\"\r\nTravel: Spend 1 Fellowship resource to travel here.")
                .WithFlavor("\"I was held to the road only by the will of Aragorn.\"\r\n-Gimli, The Return of the King")
                .WithInfo(20, 3, Artist.Pedro_Amato));
            Cards.Add(LotRCard.Location("Haunted Path", string.Empty, setThePassingOfTheGreyCompany, 1, 4)
                .WithTraits("Underground.")
                .WithText("Haunted Path gets +1 Threat for each player with a threat of 35 or higher.\r\nTravel: Raise each player's threat by 1 to travel here.")
                .WithShadow("Shadow: Either raise your your threat by 2, or return attacking enemy to the staging area after this attack.")
                .WithInfo(21, 3, Artist.Stephen_Najarian));
            Cards.Add(LotRCard.Enemy("Dead Man of Dunharrow", string.Empty, setThePassingOfTheGreyCompany, 30, 2, 2, 1, 3)
                .WithTraits("Undead.", "Oathbreaker.")
                .WithKeywords("Phantom.")
                .WithText("Forced: After Dead Man of Dunharrow engages you, either attach a set aside Overcome by Fear to your threat dial, or raise your threat by 2.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack.")
                .WithInfo(22, 4, Artist.Anthony_Devine));
            Cards.Add(LotRCard.Enemy("Faithless Dead", string.Empty, setThePassingOfTheGreyCompany, 35, 2, 3, 1, 4)
                .WithTraits("Undead.", "Oathbreaker.")
                .WithKeywords("Peril.", "Phantom.")
                .WithText("When Revealed: Either raise each player's threat by 2, or reveal an additional encounter card.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack and loses the Phantom keyword for this attack.")
                .WithEasyModeQuantity(2)
                .WithInfo(23, 3, Artist.Chris_Grun));
            Cards.Add(LotRCard.Enemy("Ghosts of Men", string.Empty, setThePassingOfTheGreyCompany, 40, 3, 3, 1, 5)
                .WithTraits("Undead.", "Oathbreaker.")
                .WithKeywords("Peril.", "Phantom.")
                .WithText("When Revealed: Either attach a set aside Overcome by Fear to your threat dial, or Ghosts of Men makes an immediate attack against you.")
                .WithFlavor("...a rumour came after him like the shadow-sound of many feet. -The Return of the King")
                .WithInfo(24, 2, Artist.Jose_Vega));
            Cards.Add(LotRCard.Enemy("Shadow Host", string.Empty, setThePassingOfTheGreyCompany, 45, 4, 4, 2, 6)
                .WithTraits("Undead.", "Oathbreaker.")
                .WithKeywords("Phantom.")
                .WithText("Forced: When Shadow Host engages you, either attach a set aside Overcome by Fear to your threat dial, or it makes an immediate attack.")
                .WithFlavor("\"In that gloom the Shadow Host seemed to grow stronger and more terrible to look upon.\"\r\n-Legolas, The Return of the King")
                .WithEasyModeQuantity(1)
                .WithInfo(25, 2, Artist.Preston_Stone));
            Cards.Add(LotRCard.Treachery("Blood Runs Chill", string.Empty, setThePassingOfTheGreyCompany)
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Each player with a threat of 35 or higher deal 1 damage to each exhausted character he controls.")
                .WithShadow("Shadow: If your threat is 35 or higher, defending character cannot ready until the end of the round.")
                .WithEasyModeQuantity(1)
                .WithInfo(26, 3, Artist.Uriah_Voth));
            Cards.Add(LotRCard.Treachery("The Way is Shut", string.Empty, setThePassingOfTheGreyCompany)
                .WithKeywords("Peril.", "Surge.")
                .WithText("When Revealed: Either attach a set aside Overcome by Fear to your threat dial, or progress cannot be placed on the current quest until the end of the round.")
                .WithFlavor("\"It was made by those who are Dead, and the Dead keep it...\" -Old Man, The Return of the King")
                .WithInfo(27, 2, Artist.Yoann_Boissonnet));
            Cards.Add(LotRCard.Treachery("Whispers in the Dark", string.Empty, setThePassingOfTheGreyCompany)
                .WithKeywords("Peril.")
                .WithText("When Revealed: Either attach a set aside Overcome by Fear to your threat dial, or each character you control gets -1 Willpower, -1 Attack, and -1 Defense until the end of the round.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if undefended).")
                .WithInfo(28, 3, Artist.Gabriel_Verdon));
            Cards.Add(LotRCard.Treachery("No Turning Back", string.Empty, setThePassingOfTheGreyCompany)
                .WithText("When Revealed: Each player must choose: either attach a set aside Overcome by Fear to your threat dial, or discard an ally you control")
                .WithShadow("Shadow: Either attach a set aside Overcome by Fear to your threat dial, or attacking enemy makes an additional attack after this one.")
                .WithEasyModeQuantity(1)
                .WithInfo(29, 2, Artist.Preston_Stone));
            Cards.Add(LotRCard.Location("Great Corsair Ship", string.Empty, setTheSiegeOfGondor, Card.VALUE_X, 5)
                .WithUnique()
                .WithTraits("Ship.")
                .WithText("X is the number of resources on The ~Corsair Fleet.\r\nThe players cannot travel here unless there are at least 3 Ship locations in the victory display.\r\nTravel: Each player searches the encounter deck and discard pile for a Corsair enemy and adds it to the staging area. One of those enemies must be ~Corsair ~Captain, if able.")
                .WithVictoryPoints(5)
                .WithInfo(30, 1, Artist.Johan_Tornlund));
            Cards.Add(LotRCard.Location("Umbar War Galley", string.Empty, setTheSiegeOfGondor, 3, 3)
                .WithText("While Umbar War Galley is the active location, each Corsair enemy gets -10 engagement cost.\r\nTravel: Shuffle the encounter discard pile into the encounter deck and discard cards from the encounter deck until a Corsair enemy is discarded. Add the discarded enemy to the staging area.")
                .WithFlavor("\"The Corsairs are upon us! It is the last stroke of doom!\"\r\n-Men of Gondor, The Return of the King")
                .WithVictoryPoints(3)
                .WithInfo(31, 3, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Location("Corsair Dromon", string.Empty, setTheSiegeOfGondor, 2, 2)
                .WithTraits("Ship.")
                .WithText("While Corsair Dromon is the active location, each Corsair enemy gains Archery 1.\r\nTravel: Shuffle the encounter discard pile into the encounter deck and discard cards from the top until a Corsair enemy is discarded. Add the discarded enemy to the staging area.")
                .WithVictoryPoints(2)
                .WithInfo(32, 3, Artist.Jessica_Cheng));
            Cards.Add(LotRCard.Location("Port of Pelargir", string.Empty, setTheSiegeOfGondor, 2, 4)
                .WithTraits("City.")
                .WithText("While Port of Pelargir is in the staging area, no more than 1 damage can be healed from each character each round.")
                .WithShadow("Shadow: If this attack damages a character, that character cannot ready until the end of the round.")
                .WithInfo(33, 3, Artist.Eva_Maria_Toker));
            Cards.Add(LotRCard.Location("Pelargir Quays", string.Empty, setTheSiegeOfGondor, 3, 4)
                .WithTraits("City.")
                .WithText("Forced: At the end of the round, place a damage token here. Then, if there are 4 damage tokens here, discard Pelargir Quays and assign 4 damage among characters in play.")
                .WithFlavor("\"...this attack will draw off much of the help that we looked to have from Lebennin and Belfalas...\"\r\n-Beregond, The Return of the King")
                .WithEasyModeQuantity(0)
                .WithInfo(34, 2, Artist.Eva_Maria_Toker));
            Cards.Add(LotRCard.Enemy("Corsair Captain", string.Empty, setTheSiegeOfGondor, 49, 3, 5, 3, 6)
                .WithTraits("Corsair.")
                .WithText("Cannot be optionally engaged.\r\nIf the active location is a Ship, ~Corsair ~Captain gets -30 engagement cost and gains: \"Forced: When ~Corsair ~Captain engages you, it makes an immediate attack.\"")
                .WithEasyModeQuantity(1)
                .WithInfo(35, 2, Artist.Gabriel_Verdon));
            Cards.Add(LotRCard.Enemy("Corsair of Umbar", string.Empty, setTheSiegeOfGondor, 29, 2, 2, 1, 3)
                .WithTraits("Corsair.")
                .WithText("If the active location is a Ship, ~Corsair of Umbar gets +2 Attack and +2 Defense.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the active location is a Ship).")
                .WithInfo(36, 3, Artist.Ivan_Dixon));
            Cards.Add(LotRCard.Enemy("Umbar Pirate Crew", string.Empty, setTheSiegeOfGondor, 39, 3, 6, 2, 8)
                .WithTraits("Corsair.")
                .WithText("Cannot have attachments.\r\nForced: When Umbar Pirate Crew engages you, exhaust a character you control.")
                .WithShadow("Shadow: If the active location is a Ship, return attacking enemy to the staging area after this attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(37, 2, Artist.Gabriel_Verdon));
            Cards.Add(LotRCard.Enemy("Haradrim Pirate", string.Empty, setTheSiegeOfGondor, 34, 2, 3, 2, 4)
                .WithTraits("Corsair.")
                .WithText("Forced: When Haradrim Pirate engages you, deal 1 damage to a character you control (2 damage instead if the active location is a Ship).")
                .WithShadow("Shadow: Defending character gets -1 Defense for each damage on it.")
                .WithInfo(38, 3, Artist.Owen_William_Weber));
            Cards.Add(LotRCard.Treachery("Fell Folk of Umbar", string.Empty, setTheSiegeOfGondor)
                .WithKeywords("Peril.")
                .WithText("When Revealed: Either return each Corsair enemy engaged with you to the staging area, or discard cards from the top of the encounter deck until a Corsair enemy is discarded and put that enemy into play engaged with you.")
                .WithFlavor("\"...there men of Lamedon contested the fords with fell folk of Umbar and Harad who had sailed up the river.\"\r\n-Legolas, The Return of the King")
                .WithInfo(39, 2, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Treachery("Black Sails", string.Empty, setTheSiegeOfGondor)
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Each Ship location in the staging area gets +1 Threat until the end of the phase. If there are no non-unique Ship locations in the staging area, search the encounter deck and discard pile for a Ship location and add it to the staging area. Shuffle the encounter deck.")
                .WithInfo(40, 3, Artist.Jose_Vega));
            Cards.Add(LotRCard.Treachery("Raiding the Coasts", string.Empty, setTheSiegeOfGondor)
                .WithText("When Revealed: Each player must choose: either add 3 to the total Threat in the staging area until the end of the phase, or discard the highest cost attachment you control.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, discard an attachment you control.")
                .WithEasyModeQuantity(1)
                .WithInfo(41, 2, Artist.Johan_Tornlund));
            Cards.Add(LotRCard.Treachery("Driven to the Brink", string.Empty, setTheSiegeOfGondor)
                .WithKeywords("Peril.")
                .WithText("When Revealed: Either immediately end the quest phase (without resolving the quest), or assign X damage among questing characters you control. X is the number of resources on The Corsair Fleet.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithEasyModeQuantity(1)
                .WithInfo(42, 2, Artist.Jenn_Tran));
            Cards.Add(LotRCard.Objective("Minas Tirith", string.Empty, setTheBattleOfThePelennorFields)
                .WithUnique()
                .WithTraits("Gondor.", "City.")
                .WithText("Minas Tirith has 30 hit points plus 10 for each player.\r\nForced: At the end of the round, deal 1 damage to Minas Tirith for each enemy in the staging area. Then, if Minas Tirith has no hit points remaining, the players lose the game.")
                .WithInfo(43, 1, Artist.Kamila_Tzutenberg));
            addCard(LotRCard.Location("Grond", string.Empty, setTheBattleOfThePelennorFields, Card.VALUE_X, 3)
                .WithUnique()
                .WithTraits("Siege.")
                .WithText("Immune to player card effects.\r\nX is the number of resources on Grond.\r\nForced: At the beginning of the quest phase, place 1 resource on Grond. Then, deal X damage to Minas Tirith.\r\nTravel: The Witch-king makes an immediate attack against each player, in turn order.")
                .WithVictoryPoints(4)
                .WithInfo(44, 1, Artist.Jose_Vega));
            Cards.Add(LotRCard.Location("Gate of Gondor", string.Empty, setTheBattleOfThePelennorFields, 5, 3)
                .WithUnique()
                .WithTraits("Minas Tirith.")
                .WithText("Immune to player card effects.\r\nWhile Gate of Gondor is the active location, each enemy in play gets -30 engagement cost.\r\nForced: When Gate of Gondor is explored, return each engaged enemy to the staging area.")
                .WithFlavor("...it was the key, the weakest point in all that high and impenetrable wall. -The Return of the King")
                .WithVictoryPoints(5)
                .WithInfo(45, 1, Artist.Eva_Maria_Toker));
            Cards.Add(LotRCard.Location("City Wall", string.Empty, setTheBattleOfThePelennorFields, 3, 4)
                .WithTraits("Minas Tirith.")
                .WithText("While City Wall is the active location, damage that would be placed on Minas Tirith must be placed here first.\r\nForced: When City Walls has damage equal to its quest points, discard it. Then, each player raises his threat by 3.")
                .WithFlavor("For the main wall of the City was of great height and marvellous thickness... -The Return of the King")
                .WithInfo(46, 3, Artist.Eva_Maria_Toker));
            Cards.Add(LotRCard.Location("Pelennor Field", string.Empty, setTheBattleOfThePelennorFields, 2, 4)
                .WithTraits("Pelennor.")
                .WithText("While at least 1 enemy is in the staging area, progress cannot be placed on locations in the staging area.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if it has the Harad trait).")
                .WithInfo(47, 4, Artist.Kamila_Tzutenberg));
            Cards.Add(LotRCard.Location("Fire-filled Trench", string.Empty, setTheBattleOfThePelennorFields, 2, 3)
                .WithTraits("Pelennor.", "Siege.")
                .WithText("Forced: When a player plays an event that would cancel the effects of a treachery card just revealed from the encounter deck, cancel the effects of that event. Then, discard Fire-filled Trench.")
                .WithFlavor("...as the trenches were made each was filled with fire, though how it was kindled or fed, by art or devilry, none could see. -The Return of the King")
                .WithEasyModeQuantity(2)
                .WithInfo(48, 3, Artist.Jessica_Cheng));
            Cards.Add(LotRCard.Location("Siege Tower", string.Empty, setTheBattleOfThePelennorFields, 3, 3)
                .WithTraits("Siege.")
                .WithText("While Siege Tower is in the staging area, it gains Archery 3.\r\nForced: After Siege Tower becomes the active location, shuffle the encounter discard pile into the encounter deck and discard cards from the top until an enemy is discarded. Add the discarded enemy to the staging area.")
                .WithEasyModeQuantity(2)
                .WithInfo(49, 3, Artist.Adam_Lane));
            Cards.Add(LotRCard.Enemy("The Black Serpent", string.Empty, setTheBattleOfThePelennorFields, 38, 4, 5, 2, 5)
                .WithUnique()
                .WithTraits("Harad.")
                .WithText("Cannot have attachments or be attacked by more than 1 character at a time.\r\nWhen Revealed: The Black Serpent makes an immediate attack against the first player.")
                .WithFlavor("...he was filled with a red wrath and shouted aloud, and displaying his standard, black serpent upon scarlet, he came... -The Return of the King")
                .WithVictoryPoints(4)
                .WithEasyModeQuantity(0)
                .WithInfo(50, 1, Artist.Ryan_Barger));
            Cards.Add(LotRCard.Enemy("War Mûmak", string.Empty, setTheBattleOfThePelennorFields, 46, 4, 6, 2, 9)
                .WithTraits("Harad.", "Creature.")
                .WithKeywords("Archery 2.")
                .WithText("Cannot have attachments or take more than 3 damage each round.\r\nForced: When War Mûmak is defeated, reduce each player's threat by 4.")
                .WithVictoryPoints(4)
                .WithEasyModeQuantity(1)
                .WithInfo(51, 2, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Enemy("Southron Champion", string.Empty, setTheBattleOfThePelennorFields, 34, 2, 4, 2, 4)
                .WithTraits("Harad.")
                .WithText("Forced: After Southron Champion is dealt a shadow card with no shadow effect, either deal 3 damage to Minas Tirith, or it makes an additional attack after this one.")
                .WithShadow("Shadow: Deal 1 damage to Minas Tirith")
                .WithInfo(52, 2, Artist.Micah_Epstein));
            Cards.Add(LotRCard.Enemy("Morgul Captain", string.Empty, setTheBattleOfThePelennorFields, 35, 3, 3, 1, 4)
                .WithTraits("Orc.", "Mordor.")
                .WithKeywords("Peril.")
                .WithText("When Revealed: Put the topmost Orc enemy in the discard pile into play engaged with you.")
                .WithShadow("Shadow: If this attack destroys a character, return attacking enemy to the staging area.")
                .WithEasyModeQuantity(1)
                .WithInfo(53, 2, Artist.Tey_Bartolome));
            Cards.Add(LotRCard.Enemy("Orc of the Eye", string.Empty, setTheBattleOfThePelennorFields, 40, 2, 3, 1, 3)
                .WithTraits("Orc.", "Mordor.")
                .WithKeywords("Peril.", "Archery 1.")
                .WithText("When Revealed: Either deal 2 damage to a hero you control, or deal 2 damage to Minas Tirith.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if it has the Mordor trait).")
                .WithInfo(54, 3, Artist.Tey_Bartolome));
            Cards.Add(LotRCard.Enemy("Mordor Orc", string.Empty, setTheBattleOfThePelennorFields, 30, 1, 2, 1, 2)
                .WithTraits("Orc.", "Mordor.")
                .WithKeywords("Surge.")
                .WithText("While Minas Tirith is in play, undefended damage dealt by Mordor Orc must be dealt to Minas Tirith.")
                .WithShadow("Shadow: If Minas Tirith is in play, engage Mordor Orc and deal it a shadow card.")
                .WithEasyModeQuantity(4)
                .WithInfo(55, 5, Artist.Ivan_Dixon));
            Cards.Add(LotRCard.Treachery("The Rammas is Breached", string.Empty, setTheBattleOfThePelennorFields)
                .WithText("When Revealed: Each player searches the encounter deck and discard pile for an enemy and puts it into play engaged with him. Shuffle the encounter deck.")
                .WithShadow("Shadow: Either deal 3 damage to Minas Tirith or attacking enemy makes an additional attack after this one.")
                .WithEasyModeQuantity(1)
                .WithInfo(56, 2, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Treachery("Fell Beast", string.Empty, setTheBattleOfThePelennorFields)
                .WithTraits("Morgul.")
                .WithKeywords("Surge.")
                .WithText("When Revealed: Attach to a Nazgûl enemy. Limit 1 per enemy. (Counts as a Mount attachment with the text: \"Attached enemy gets +1 Threat, +1 Attack, +1 Defense and -10 engagement cost. Forced: At the end of the round, return attached enemy to the staging area.")
                .WithFlavor("...horrible as carrion-fowl yet greater than eagles, cruel as death. -The Return of the King")
                .WithEasyModeQuantity(1)
                .WithInfo(57, 2, Artist.Jokubas_Uoginitas));
            Cards.Add(LotRCard.Treachery("Black Dart", string.Empty, setTheBattleOfThePelennorFields)
                .WithTraits("Morgul.")
                .WithText("When Revealed: Remove a hero you control from the quest and attach Black Dart to that hero. Limit 1 per hero. (Counts as a Condition attachment with the text: \"Forced: At the end of the round, deal 1 damage to attached hero.\")")
                .WithShadow("Shadow: If this attack damages a hero, attach Black Dart to that hero.")
                .WithEasyModeQuantity(1)
                .WithInfo(58, 2, Artist.Johan_Tornlund));
            Cards.Add(LotRCard.Treachery("Spells of Ruin", string.Empty, setTheBattleOfThePelennorFields)
                .WithTraits("Sorcery.")
                .WithText("When Revealed: Either deal 1 damage to each exhausted character, or deal 5 damage to Minas Tirith.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, deal 2 damage to Minas Tirith.")
                .WithInfo(59, 2, Artist.Rafal_Hrynkiewicz));
            Cards.Add(LotRCard.Treachery("Dread and Despair", string.Empty, setTheBattleOfThePelennorFields)
                .WithTraits("Sorcery.")
                .WithKeywords("Peril.", "Doomed 1.")
                .WithText("When Revealed: Discard an ally you control. Until the end of the phase, add 1 to the total Threat in the staging area for each ally in your discard pile.")
                .WithShadow("Shadow: Discard a non-objective attachment you control.")
                .WithInfo(60, 2, Artist.Uriah_Voth));
            Cards.Add(LotRCard.Treachery("Shadow of Mordor", string.Empty, setTheBattleOfThePelennorFields)
                .WithTraits("Sorcery.")
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Each player deals 1 damage to a hero he controls. Until the end of the round, treat the printed text box of each damaged character as if it were blank, except for Traits.")
                .WithFlavor("...a great cloud streamed slowly westward from the Black Land, devouring light... -The Return of the King")
                .WithEasyModeQuantity(1)
                .WithInfo(61, 2, Artist.Kamila_Tzutenberg));
            Cards.Add(LotRCard.Enemy("Wraith on Wings", string.Empty, setTheBattleOfThePelennorFields, 45, 0, 6, 4, 12)
                .WithBurden()
                .WithTraits("Nazgûl.")
                .WithText("Setup: Add Wraith on Wings to the staging area.\r\nCannot have non-Morgul attachments.\r\nWraith on Wings gets +1 Threat and -1 enagement cost for each resource on it.\r\nForced: At the beginning of the quest phase, place 1 resource on Wraith on Wings (Limit 5 resources.)")
                .WithVictoryPoints(5)
                .WithInfo(62, 4, Artist.S_C_Watson));
            addCard(LotRCard.Quest("The Forbidden Door", 1, setThePassingOfTheGreyCompany, Card.VALUE_NA)
                .WithFlavor("\"I must take new counsel for myself and my kindred. We must ride our own road, and no longer in secret. For me the time of stealth has passed. I will ride by the swiftest way, and I will take the Paths of the Dead.\" -Aragorn, The Return of the King")
                .WithText("Setup: Set The Stone of Erech and Army of the Dead aside, out of play. Each player attaches a copy of Overcome by ~Fear to his threat dial. Remove each unattached copy of Overcome by ~Fear from the game.")
                .WithOppositeFlavor("\"This is an evil door,\" said Halbarad, \"and my death lies beyond it. I will dare to pass nonetheless...\" -The Return of the King")
                .WithOppositeText("When Revealed: Each player may add 1 resource to the resource pool of each hero he controls. Each player who does so must raise his threat by 3.\r\nForced: At the end of the planning phase, discard all cards in each player’s hand and advance to stage 2A.")
                .WithInfo(63, 1, Artist.Yoann_Boissonnet));
            addCard(LotRCard.Quest("The Paths of the Dead", 2, setThePassingOfTheGreyCompany, Card.VALUE_X)
                .WithFlavor("He could see nothing but the dim flame of the torches; but if the company halted, there seemed an endless whisper of voices all about him, a murmur of words in no tongue that he had ever heard before. -The Return of the King")
                .WithText("When Revealed: Each player searches the encounter deck for a different location and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("...there could be no turning back; all the paths behind were thronged by an unseen host that followed in the dark. -The Return of the King")
                .WithOppositeText("X is the threat of the player with the highest threat.\r\nEach player cannot reduce his threat below his initial threat level.\r\nForced: At the beginning of the planning phase each player must choose: either raise your threat by 1, or you cannot play cards this phase.")
                .WithInfo(64, 1, Artist.Jennifer_Hrabota_Lesser));
            Cards.Add(LotRCard.Quest("The Dead are Following", 3, setThePassingOfTheGreyCompany, 5)
                .WithFlavor("\"I see shapes of Men and of horses, and pale banners like shreds of cloud, and spears like winter-thickets on a misty night. The Dead are following.\" -Legolas, The Return of the King")
                .WithText("When Revealed: Add The Stone of Erech and Army of the Dead (enemy side faceup) to the staging area. Each player may raise his threat by 3 to detach Overcome by ~Fear from his threat dial and set it aside, out of play.")
                .WithOppositeFlavor("\"Yes, the Dead ride behind. They have been summoned.\" -Elladan, The Return of the King")
                .WithOppositeText("While Stone of Erech is the active location, each Oathbreaker enemy loses the Phantom keyword and gets -20 engagement cost.\r\nWhen The Stone of Erech leaves play as an explored location, the players win the game.")
                .WithInfo(65, 1, Artist.S_C_Watson));
            Cards.Add(LotRCard.Campaign("The Passing of the Grey Company", setThePassingOfTheGreyCompany, "The Lord of the Rings - Part 13")
                .WithText("Setup: Each player may trade heroes without incurring a threat penalty. The first player may raise each player’s threat by 1 to search his deck for Anduril and add it to his hand. Remove each burden with these burden set icons from the encounter deck: A Shadow of the Past, Flight to the Ford, The Ring Goes South, The Passage of the Marshes, Shelob’s Lair")
                .WithFlavor("\"...there is only one way through the mountains that will bring me to the coastlands before all is lost. That is the Paths of the Dead.\" -Aragorn, The Return of the King")
                .WithOppositeText("Resolution: Add each copy of Overcome by Fear attached to a player's threat dial to the campaign pool and record the name of each player it was attached to. If Army of the Dead is in the victory display, add the Army of the Dead boon to the campaign pool. The players have earned each card added to the campaign pool")
                .WithOppositeFlavor("Then Aragorn said: \"The hour is come at last. Now I go to Pelargir upon Anduin, and ye shall come after me. And when all this land is clean of the servants of Sauron, I will hold the oath fulfilled, and ye shall have peace and depart for ever. For I am Elessar, Isildur's heir of Gondor.\" -The Return of the King")
                .WithInfo(66, 1, Artist.Yoann_Boissonnet));
            Cards.Add(LotRCard.Enemy("Army of the Dead", string.Empty, setThePassingOfTheGreyCompany, 50, Card.VALUE_X, 6, 2, 8)
                .WithSuffix("Enemy")
                .WithUnique()
                .WithTraits("Undead.", "Oathbreaker.")
                .WithKeywords("Phantom.")
                .WithText("Immune to player card effects.\r\nX is twice the number of players in the game.\r\nForced: When Army of the Dead attacks, you must either attach a set aside Overcome by ~Fear to your threat dial, or discard an ally you control.")
                .WithVictoryPoints(6)
                .WithInfo(67, 1, Artist.Uwe_Jarling));
            Cards.Add(LotRCard.ObjectiveAlly("Army of the Dead", string.Empty, setThePassingOfTheGreyCompany, 4, 6, 2, 8)
                .WithSuffix("Objective-Ally")
                .WithBoon()
                .WithUnique()
                .WithTraits("Undead.")
                .WithText("Immune to player card effects. The first player gains control of Army of the Dead.\r\nSetup: The first player takes control of Army of the Dead.\r\nIf Army of the Dead leaves play, remove it from the game.")
                .WithFlavor("\"Now come! By the Black Stone I call you!\"\r\n-Aragorn, The Return of the King")
                .WithInfo(68, 1, Artist.Uwe_Jarling));
            Cards.Add(LotRCard.Quest("Attack on Pelargir", 1, setTheSiegeOfGondor, 20)
                .WithFlavor("\"There at Pelargir lay the main fleet of Umbar, fifty great ships and smaller vessels beyond count. Many of those that we pursued had reached the havens before us...\"\r\n-Gimli, The Return of the King")
                .WithText("Setup: Add The ~Corsair Fleet (Corsair side faceup) and Great Corsair Ship to the staging area. Each player searches the encounter deck for a Ship location and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("\"But the Haradrim, being now driven to the brink, turned at bay, and they were fierce in despair; and they laughed when the looked on us, for they were a great army still.\" -Gimli, The Return of the King")
                .WithOppositeText("Each Ship location in the staging area is immune to player card effects.\r\nThe players cannot defeat this stage while Great Corsair Ship is in play. When this stage is defeated, the players win the game.")
                .WithInfo(69, 1, Artist.Javier_Charro_Martinez));
            Cards.Add(LotRCard.Campaign("The Siege of Gondor", setTheSiegeOfGondor, "The Lord of the Rings - Part 14")
                .WithText("Setup: The first player may raise each player's threat by 1 to search his deck for Andúril and add it to his hand. Remove each burden with the following burden set icons from the encounter deck:")
                .WithFlavor("\"There is a great fleet drawing near to the mouths of Anduin, manned by the Corsairs of Umbar in the South. They have long ceased to fear the might of Gondor, and they have allied with the Enemy, and now make a heavy stroke in his cause.\"\r\n-Beregond, The Return of the King")
                .WithOppositeText("Resolution: Count the number of resources on The Corsair Fleet and record that number in the notes section of the quest log. Remove Army of the Dead from the Campaign pool.")
                .WithOppositeFlavor("\"But mighty indeed was Aragorn that day. Lo! all the black fleet was in his hands; and he chose the greatest ship to be his own, and he went up into it.\"\r\n-Gimli, The Return of the King")
                .WithInfo(70, 1, Artist.Javier_Charro_Martinez));
            Cards.Add(LotRCard.Objective("The Corsair Fleet", string.Empty, setTheSiegeOfGondor)
                .WithUnique()
                .WithTraits("Corsair.")
                .WithSuffix("Corsair")
                .WithText("Forced: At the beginning of the staging step, place 1 resource on this objective. Then, each player must choose: either reveal an encounter card, or assign X damage among characters he controls. X is the number of resources here.")
                .WithFlavor("...ships of great draught with many oars, and with black sails bellying in the breeze. -The Return of the King")
                .WithInfo(71, 1, Artist.Johan_Tornlund));
            Cards.Add(LotRCard.Objective("The Corsair Fleet", string.Empty, setTheSiegeOfGondor)
                .WithUnique()
                .WithTraits("Gondor.")
                .WithSuffix("Gondor")
                .WithText("Forced: At the beginning of the quest phase, remove 1 resource from The Corsair Fleet. Then, if there are no resources here, the first player takes control of Aragorn and adds The Corsair Fleet to the victory display.")
                .WithFlavor("\"The oars were now wielded by free men, and manfully they laboured...\"\r\n-Legolas, The Return of the King")
                .WithInfo(72, 1, Artist.Johan_Tornlund));
            Cards.Add(LotRCard.Quest("The Garrison of Gondor", 1, setTheBattleOfThePelennorFields, 2)
                .WithFlavor("\"Here will the hammer-stroke fall hardest. And for that reason Mithrandir came hither in such haste. For if we fall, who shall stand?\r\n-Beregond, The Return of the King")
                .WithText("Setup: Set Minas Tirith, Grond, The Witch-king, and each copy of ~Wraith of Wings aside, out of play. Search the encounter deck for a copy of ~Pelennor Field and make it the active location. Shuffle the encounter deck. The players may attach Esquire of ~Rohan and Esquire of ~Gondor to different heroes.")
                .WithOppositeFlavor("...companies came and were hailed and cheered and passed through the Gate, men of the Outlands marching to defend the City of Gondor in a dark hour.\r\n-The Return of the King")
                .WithOppositeText("Skip the quest phase and combat phase.\r\nForced: At the end of the planning phase, place 1 progress here.")
                .WithInfo(73, 1, Artist.Alvaro_Calvo_Escudero));
            addCard(LotRCard.Quest("Retreat from Osgiliath", 2, setTheBattleOfThePelennorFields, Card.VALUE_X)
                .WithFlavor("\"The enemy,\" men murmured. \"The dike is down. Here they come pouring through the breaches!\" -The Return of the King")
                .WithText("When Revealed: Each player adds 1 set aside ~Wraith on Wings to the staging area and reveals an encounter card. Starting with the first player, each player discards cards from the top of his deck until he discards an ally that is not in play. Put the discarded ally into play in the staging area and treat its text box as if it were blank until the end of the phase.")
                .WithOppositeFlavor("\"Where are our own folk?\" -Men of Gondor, The Return of the King")
                .WithOppositeText("X is the total cost of all allies in the staging area.\r\nAllies in the staging area are treated as if their text box is blank, are immune to player card effects, and are under no player's control.\r\nForced: At the end of the round, assign damage among the allies in the staging area equal to the number of enemies in the staging area.")
                .WithInfo(74, 1, Artist.Kamila_Tzutenberg));
            Cards.Add(LotRCard.Quest("The White City Besieged", 3, setTheBattleOfThePelennorFields, 4)
                .WithKeywords("Assault.")
                .WithFlavor("...at east the city was besieged, enclosed in a ring of foes. The Rammas was broken, and all the Pelennor was abandoned to the Enemy. -The Return of the King")
                .WithText("When Revealed: Each player takes control of each ally he owns in the staging area and exhausts it. The first player adds Minas Tirith, Grond, and The Witch-king (Captain side faceup) to the staging area. Each other player searches the encounter deck and discard pile for a different enemy and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("...since the middle night the great assault had gone on. -The Return of the King")
                .WithOppositeText("\r\nThe White ~City Besieged gets +4 quest points for each player in the game.\r\nThe players cannot travel to Pelennor locations.\r\nForced: When an enemy is destroyed, place progress on this stage equal to that enemy's total Threat (progress must be placed on the active location first).")
                .WithInfo(75, 1, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Quest("Rohan has Come!", 4, setTheBattleOfThePelennorFields, null)
                .WithFlavor("Horns, horns, horns. In dark Mindolluin's sides they dimly echoed. Great horns of the North wildly blowling. Rohan had come at last.\r\n-The Return of the King")
                .WithText("When Revealed: Set the Witch-king aside, out of play. Each player searches the top 10 cards of his deck for an ally that matches the sphere of a hero he controls and put it into play under his control. Each player shuffles his deck.")
                .WithOppositeFlavor("...the hosts of Mordor wailed, and terror took them, and they fled, and died, and the hoofs of wrath rode over them. -The Return of the King")
                .WithOppositeText("Progress cannot be placed on this stage by questing successfully is instead assigned as damage among enemies in play. (Progress must be placed on the active location first.)\r\nForced: At the end of the quest phase, advance to stage 5A.")
                .WithInfo(76, 1, Artist.Sara_Biddle));
            Cards.Add(LotRCard.Quest("Fighting in the Fields", 5, setTheBattleOfThePelennorFields, 20)
                .WithFlavor("And now the fighting waxed furious on the fields of the Pelennor; and the din of arms rose upon high, with the crying of men and the neighing of horses.\r\n-The Return of the King")
                .WithText("When Revealed: The first player adds The Witch-king to the staging area (Sorcerer side faceup). Then, he searches the encounter deck and discard pile for a Fell Beast and attaches it to The Witch-king, if able. Shuffle the encounter deck. Each other player reveals an encounter card.")
                .WithOppositeText("The Witch-king and shadow cards deal to The Witch-king are immune to player card effects.\r\nForced: When an enemy attacks and destroys a character, deal 1 damage to Minas Tirith.\r\nThis stage cannot be defeated unless Aragorn is in play and The Witch-king is in the victory display. If the players defeat this stage, they win the game.")
                .WithInfo(77, 1, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Campaign("The Battle of the Pelennor Fields", setTheBattleOfThePelennorFields, "The Lord of the Rings - Part 15")
                .WithText("Setup: Set each Harad enemy recorded in the campaign log aside, out of play. The first player attaches Andúril and Banner of Elendil to Aragorn and set him aside, out of play. Add The Corsair Fleet to the staging area (Gondor side faceup) and place X resources on it, where X is the number recorded in the campaign log. Remove each burden with the following burden set icons from the encounter deck, then flip this card over.")
                .WithOppositeText("Forced: When the players advance to stage 5B, add each set aside Harad enemy to the staging area.\r\nResolution: Add 1 copy, per player, of Wraith on Wings to the campaign pool. The players have earned those burdens. If Esquire of Gondor, or Esquire of Rohan, is attached to a hero, that hero's controller has earned that boon.")
                .WithOppositeFlavor("Thus came Aragorn son of Arathorn, Elessar, Isildur's heir, out of the Paths of the Dead, borne upon a wind from the Sea to the kingdom of Gondor.\r\n-The Return of the King")
                .WithInfo(78, 1, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Enemy("The Witch-king", string.Empty, setTheBattleOfThePelennorFields, 50, 6, 6, 6, 14)
                .WithSuffix("Captain")
                .WithUnique()
                .WithTraits("Nazgûl.", "Captain.")
                .WithText("Immune to player card effects.\r\nCannot be optionally engaged or take damage.\r\nForced: At the beginning of the quest phase, discard cards from the encounter deck until an enemy is discarded. Add the discarded enemy to the staging area.")
                .WithInfo(79, 1, Artist.Rafal_Hrynkiewicz));
            Cards.Add(LotRCard.Enemy("The Witch-king", string.Empty, setTheBattleOfThePelennorFields, 50, 6, 6, 6, 14)
                .WithSuffix("Sorcerer")
                .WithUnique()
                .WithTraits("Nazgûl.", "Sorcerer.")
                .WithText("Only the engaged player can declare attackers against the Witch-king.\r\nForced: At the beginning of the encounter phase, The Witch-king engages the first player. Then, it makes an immediate attack.")
                .WithFlavor("\"No living man may hinder me!\" -The Return of the King")
                .WithVictoryPoints(6)
                .WithInfo(80, 1, Artist.Chris_Rahn));
        }
    }
}