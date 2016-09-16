using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheFlameOfTheWest : CardSet
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

            Cards.Add(Card.Hero("Aragorn", "", Sphere.Fellowship, 0, 2, 3, 2, 5)
                .WithTraits("Dúnedain.", "Noble.", "Ranger.")
                .WithText("The first player gains control of Aragorn. If Aragorn leaves play, the players lose the game.\r\nWhile Aragorn has an Artifact attached, he gains sentinel and does not exhaust to quest.")
                .WithFlavor("\"I have no help to send, therefore I must go myself...\"\r\n-The Return of the King")
                .WithInfo(1, 1, Artist.Javier_Charro_Martinez));
            Cards.Add(Card.Hero("Éowyn", "", Sphere.Tactics, 9, 4, 1, 1, 3)
                .WithTraits("Rohan.", "Noble.")
                .WithText("Setup: Reduce your threat by 3.\r\nAction: Raise your threat by 3 to ready Éowyn. She gets +9 Attack until the end of the phase. (Limit once per game for the group.)")
                .WithFlavor("\"But no living man am I! You look upon a woman. Éowyn I am, Éomund's daughter.\"\r\n-The Return of the King")
                .WithInfo(2, 1, Artist.Magali_Villeneuve));
            Cards.Add(Card.Hero("Beregond", "", Sphere.Spirit, 10, 0, 1, 4, 4)
                .WithTraits("Gondor.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After Beregond defends an attack and takes no damage, reduce the defending player's threat by 1. (Limit once per round.)")
                .WithFlavor("\"The Lord does not permit those who wear the black and silver to leave their post for any cause...\"\r\n-The Return of the King")
                .WithInfo(3, 1, Artist.Adam_Lane));
            Cards.Add(Card.Ally("Grimbold", "", Sphere.Tactics, 3, 2, 1, 1, 2)
                .WithUnique()
                .WithTraits("Rohan.", "Warrior.")
                .WithText("Combat Action: Discard Grimbold to choose an enemy engaged with a player. That enemy cannot attack that player this phase.")
                .WithFlavor("Grimbold's men turned aside and passed round to a great gap in the wall further eastward.\r\n-The Return of the King")
                .WithInfo(4, 3, Artist.Lucas_Durham));
            Cards.Add(Card.Ally("Prince Imrahil", "", Sphere.Spirit, 4, 2, 2, 2, 3)
                .WithUnique()
                .WithTraits("Gondor.", "Noble.")
                .WithText("While there is a hero in your discard pile, Prince Imrahil loses the ally card type and gains the hero card type.")
                .WithFlavor("\"We must gather all of the strength that we can find.\r\n-The Return of the King")
                .WithInfo(5, 3, Artist.Gabriel_Verdon));
            Cards.Add(Card.Ally("Halbarad", "", Sphere.Leadership, 4, 2, 2, 2, 3)
                .WithUnique()
                .WithTraits("Dúnedain.", "Ranger.")
                .WithText("Reduce the cost to play Halbarad by 1 for each enemy engaged with you.\r\nEach enemy engaged with you gets +10 engagement cost.")
                .WithFlavor("\"Halbarad Dunadan, Ranger of the North I am...\"\r\n-The Return of the King")
                .WithInfo(6, 3, Artist.Adam_Lane));
            Cards.Add(Card.Ally("Ghân-buri-Ghân", "", Sphere.Lore, 2, 254, 1, 1, 2)
                .WithNormalizedTitle("Ghan-buri-Ghan")
                .WithUnique()
                .WithTraits("Wose.")
                .WithText("X is the Threat of the active location.\r\nTravel Action: Discard Ghân-buri-Ghân to travel to a location without resolving its Travel effect.")
                .WithInfo(7, 3, Artist.Piya_Wannachaiwong));
            Cards.Add(Card.Event("Sterner than Steel", "", Sphere.Tactics, 0)
                .WithText("Response: Exhaust a Weapon or Armor card attached to the defending character to cancel a shadow effect just triggered in combat")
                .WithFlavor("\"Do what you will; but I will hinder it, if I may.\"\r\n-Éowyn, The Return of the King")
                .WithInfo(8, 3, Artist.Chris_Rahn));
            Cards.Add(Card.Event("Desperate Defense", "", Sphere.Spirit, 1)
                .WithText("Response: After a sentinel character is declared as a defender, it gets +2 Defense for this attack. If this attack deals no damage, ready the defending character.")
                .WithFlavor("...but alone in the porch upon the topmost step stood Beregond, clad in the black and silver of the Guard; and he held the door against them.\r\n-The Return of the King")
                .WithInfo(9, 3, Artist.Adam_Lane));
            Cards.Add(Card.Attachment("Golden Shield", "", Sphere.Tactics, 1)
                .WithUnique()
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Rohan hero. Response: After attached hero is declared as a defender, exhaust Golden Shield to add attached hero's Willpower to it's Defense for this attack.")
                .WithFlavor("His golden shield was uncovered, and lo! it shone like an image of the Sun...\r\n-The Return of the King")
                .WithInfo(10, 3, Artist.Unknown));
            Cards.Add(Card.Attachment("Livery of the Tower", "", Sphere.Spirit, 0)
                .WithGeneric()
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Gondor hero.\r\nResponse: Spend X resources from attached hero's pool to cancel X damage just dealt to attached hero.")
                .WithFlavor("This was the livery of the heirs of Elendil, and none wore it now in all Gondor, save the Guards of the Citadel...\r\n-The Return of the King")
                .WithInfo(11, 3, Artist.Suzanne_Helmigh));
            Cards.Add(Card.Attachment("Roheryn", "", Sphere.Leadership, 2)
                .WithUnique()
                .WithTraits("Mount.")
                .WithText("Attach to a Dúnedain hero.\r\nIf the attached hero is Aragorn, he gains a Tactics icon.\r\nResponse: After you optionally engage an enemy, exhaust Roheryn and attached hero to declare attached hero as an attacker (and resolve its attack) against that eneny.")
                .WithFlavor("\"Aragorn's own horse that they had brought from the North; Roheryn was his name.\"\r\n-The Return of the King")
                .WithInfo(12, 3, Artist.Eva_Maria_Toker));
            Cards.Add(Card.Attachment("Banner of Elendil", "", Sphere.Fellowship, 3)
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithText("Attach to Aragorn.\r\nWhile Aragorn is questing, each other questing character you control gets +1 Willpower.\r\nWhile Aragorn is attacking, each other attacking character you control gets +1 Attack.")
                .WithFlavor("Seven stars were about it, and a high crown above it, the signs of Elendil that no lord had borne for years beyond count.\r\n-The Return of the King")
                .WithInfo(13, 3, Artist.Jenn_Tran));
            Cards.Add(Card.Attachment("Esquire of Rohan", "", Sphere.Neutral, 0)
                .WithUnique()
                .WithBoon()
                .WithTraits("Title.")
                .WithText("Setup: Attach to a hero.\r\nAttached hero gains the Rohan trait.\r\nAttached hero gets +1 Attack while attacking with another Rohan character.")
                .WithFlavor("\"Rise now, Meriadoc, esquire of Rohan of the household of Meduseld!\"\r\n-Théoden, The Return of the King")
                .WithInfo(14, 1, Artist.Romana_Kendelic));
            Cards.Add(Card.Attachment("Esquire of Gondor", "", Sphere.Neutral, 0)
                .WithUnique()
                .WithBoon()
                .WithTraits("Title.")
                .WithText("Setup: Attach to a hero.\r\nAttached hero gains the Gondor trait.\r\nAttached hero gets +1 Willpower while commited to the quest with another Gondor character.")
                .WithFlavor("\"Here do I swear fealty and service to Gondor, and to the Lord and Steward of the realm...\"\r\n-Pippin, The Return of the King")
                .WithInfo(15, 1, Artist.Romana_Kendelic));
            Cards.Add(Card.Objective("Overcome by Fear", string.Empty, setThePassingOfTheGreyCompany)
                .WithBurden()
                .WithTraits("Fear.")
                .WithText("Setup: Attach to your threat dial. Limit 1 per threat dial.\r\nYour threat cannot be reduced.\r\nForced: At the end of the round, raise your threat by 1. Then you may spend 1 Fellowship resource to detach Overcome by ~Fear and set it aside, out of play.")
                .WithInfo(16, 4, Artist.Micah_Epstein));
            Cards.Add(Card.Location("The Stone of Erech", string.Empty, setThePassingOfTheGreyCompany, 5, 5)
                .WithUnique()
                .WithTraits("Hill.")
                .WithText("Immune to player card effects.\r\nForced: After The Stone of Erech becomes the active location, each player searches the encounter deck and discard pile for an Oathbreaker enemy and adds it to the staging area. Shuffle the encounter deck.\r\nTravel: Remove 5 progress from stage 3B to travel here.")
                .WithInfo(17, 1, Artist.Dawn_Carlos));
            Cards.Add(Card.Location("Dark Door", string.Empty, setThePassingOfTheGreyCompany, 4, 4)
                .WithTraits("Underground.")
                .WithText("While Dark Door is in the staging area, progress cannot be placed on locations in the staging area.\r\nTravel: The first player reveals an encounter card to travel here.")
                .WithFlavor("...before him stood a stony door closed fast...\r\n-The Return of the King")
                .WithEasyModeQuantity(1)
                .WithInfo(18, 2, Artist.Yoann_Boissonnet));
            Cards.Add(Card.Location("Trysting Place", string.Empty, setThePassingOfTheGreyCompany, 3, 3)
                .WithTraits("Underground.")
                .WithText("While Trysting Place is in the staging area, each enemy in the staging area cannot take damage.\r\nTravel: The first player searches the encounter deck and discard pile for an Oathbreaker enemy and puts it into play engaged with him. Shuffle the encounter deck.")
                .WithEasyModeQuantity(2)
                .WithInfo(19, 3, Artist.Leanna_Crossan));
            Cards.Add(Card.Location("Deadly Road", string.Empty, setThePassingOfTheGreyCompany, 2, 3)
                .WithTraits("Underground.")
                .WithText("While Deadly Road is in the staging area, it gains: \"Forced: After a 'when revealed' effecvt is canceled, raise each player's threat by 1.\"\r\nTravel: Spend 1 Fellowship resource to travel here.")
                .WithFlavor("\"I was held to the road only by the will of Aragorn.\"\r\n-Gimli, The Return of the King")
                .WithInfo(20, 3, Artist.Pedro_Amato));
            Cards.Add(Card.Location("Haunted Path", string.Empty, setThePassingOfTheGreyCompany, 1, 4)
                .WithTraits("Underground.")
                .WithText("Haunted Path gets +1 Threat for each player with a threat of 35 or higher.\r\nTravel: Raise each player's threat by 1 to travel here.")
                .WithShadow("Shadow: Either raise your your threat by 2, or return attacking enemy to the staging area after this attack.")
                .WithInfo(21, 3, Artist.Stephen_Najarian));
            Cards.Add(Card.Enemy("Dead Man of Dunharrow", string.Empty, setThePassingOfTheGreyCompany, 30, 2, 2, 1, 3)
                .WithGeneric()
                .WithTraits("Undead.", "Oathbreaker.")
                .WithKeywords("Phantom.")
                .WithText("Forced: After Dead Man of Dunharrow engages you, either attach a set aside Overcome by Fear to your threat dial, or raise your threat by 2.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack.")
                .WithInfo(22, 4, Artist.Anthony_Devine));
            Cards.Add(Card.Enemy("Faithless Dead", string.Empty, setThePassingOfTheGreyCompany, 35, 2, 3, 1, 4)
                .WithGeneric()
                .WithTraits("Undead.", "Oathbreaker.")
                .WithKeywords("Peril.", "Phantom.")
                .WithText("When Revealed: Either raise each player's threat by 2, or reveal an additional encounter card.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack and loses the Phantom keyword for this attack.")
                .WithEasyModeQuantity(2)
                .WithInfo(23, 3, Artist.Chris_Grun));
            Cards.Add(Card.Enemy("Ghosts of Men", string.Empty, setThePassingOfTheGreyCompany, 40, 3, 3, 1, 5)
                .WithGeneric()
                .WithTraits("Undead.", "Oathbreaker.")
                .WithKeywords("Peril.", "Phantom.")
                .WithText("When Revealed: Either attach a set aside Overcome by Fear to your threat dial, or Ghosts of Men makes an immediate attack against you.")
                .WithFlavor("...a rumour came after him like the shadow-sound of many feet. -The Return of the King")
                .WithInfo(24, 2, Artist.Jose_Vega));
            Cards.Add(Card.Enemy("Shadow Host", string.Empty, setThePassingOfTheGreyCompany, 45, 4, 4, 2, 6)
                .WithGeneric()
                .WithTraits("Undead.", "Oathbreaker.")
                .WithKeywords("Phantom.")
                .WithText("Forced: When Shadow Host engages you, either attach a set aside Overcome by Fear to your threat dial, or it makes an immediate attack.")
                .WithFlavor("\"In that gloom the Shadow Host seemed to grow stronger and more terrible to look upon.\"\r\n-Legolas, The Return of the King")
                .WithEasyModeQuantity(1)
                .WithInfo(25, 2, Artist.Preston_Stone));
            Cards.Add(Card.Treachery("Blood Runs Chill", string.Empty, setThePassingOfTheGreyCompany)
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Each player with a threat of 35 or higher deal 1 damage to each exhausted character he controls.")
                .WithShadow("Shadow: If your threat is 35 or higher, defending character cannot ready until the end of the round.")
                .WithEasyModeQuantity(1)
                .WithInfo(26, 3, Artist.Uriah_Voth));
            Cards.Add(Card.Treachery("The Way is Shut", string.Empty, setThePassingOfTheGreyCompany)
                .WithKeywords("Peril.", "Surge.")
                .WithText("When Revealed: Either attach a set aside Overcome by Fear to your threat dial, or progress cannot be placed on the current quest until the end of the round.")
                .WithFlavor("\"It was made by those who are Dead, and the Dead keep it...\" -Old Man, The Return of the King")
                .WithInfo(27, 2, Artist.Yoann_Boissonnet));
            Cards.Add(Card.Treachery("Whispers in the Dark", string.Empty, setThePassingOfTheGreyCompany)
                .WithKeywords("Peril.")
                .WithText("When Revealed: Either attach a set aside Overcome by Fear to your threat dial, or each character you control gets -1 Willpower, -1 Attack, and -1 Defense until the end of the round.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if undefended).")
                .WithInfo(28, 3, Artist.Gabriel_Verdon));
            Cards.Add(Card.Treachery("No Turning Back", string.Empty, setThePassingOfTheGreyCompany)
                .WithText("When Revealed: Each player must choose: either attach a set aside Overcome by Fear to your threat dial, or discard an ally you control")
                .WithShadow("Shadow: Either attach a set aside Overcome by Fear to your threat dial, or attacking enemy makes an additional attack after this one.")
                .WithEasyModeQuantity(1)
                .WithInfo(29, 2, Artist.Preston_Stone));
            Cards.Add(Card.Location("Great Corsair Ship", string.Empty, setTheSiegeOfGondor, 255, 5)
                .WithUnique()
                .WithTraits("Ship.")
                .WithText("X is the number of resources on The Corsair Fleet.\r\nThe players cannot travel here unless there are at least 3 ship locations in the victory display.\r\nTravel: Each player searches the encounter deck and discard pile for a Corsair enemy and adds it to the staging area. Once of those enemies must be Corsair Captain, if able.")
                .WithVictoryPoints(5)
                .WithInfo(30, 1, Artist.Johan_Tornlund));
            Cards.Add(Card.Location("Umbar War Galley", string.Empty, setTheSiegeOfGondor, 3, 3)
                .WithText("While Umbar War Galley is the active location, each Corsair enemy gets -10 engagement cost.\r\nTravel: Shuffle the encounter discard pile into the encounter deck and discard cards from the encounter deck until a Corsair enemy is discarded. Add the discarded enemy to the staging area.")
                .WithFlavor("\"The Corsairs are upon us! It is the last stroke of doom!\"\r\n-Men of Gondor, The Return of the King")
                .WithVictoryPoints(3)
                .WithInfo(31, 3, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(Card.Location("Corsair Dromon", string.Empty, setTheSiegeOfGondor, 2, 2)
                .WithTraits("Ship.")
                .WithText("While Corsair Dromon is the active location, each Corsair enemy gains Archery 1.\r\nTravel: Shuffle the encounter discard pile into the encounter deck and discard cards from the top until a Corsair enemy is discarded. Add the discarded enemy to the staging area.")
                .WithVictoryPoints(2)
                .WithInfo(32, 3, Artist.Jessica_Cheng));
            Cards.Add(Card.Location("Port of Pelargir", string.Empty, setTheSiegeOfGondor, 2, 4)
                .WithTraits("City.")
                .WithText("While Port of Pelargir is in the staging area, no more than 1 damage can be healed from each character each round.")
                .WithShadow("Shadow: If this attack damages a character, that character cannot ready until the end of the round.")
                .WithInfo(33, 3, Artist.Eva_Maria_Toker));
            Cards.Add(Card.Location("Pelargir Quays", string.Empty, setTheSiegeOfGondor, 3, 4)
                .WithTraits("City.")
                .WithText("Forced: At the end of the round, place a damage token here. Then, if there are 4 damage tokens here, discard Pelargir Quays and assign 4 damage among characters in play.")
                .WithFlavor("\"...this attack will draw off much of the help that we looked to have from Lebennin and Belfalas...\"\r\n-Beregond, The Return of the King")
                .WithEasyModeQuantity(0)
                .WithInfo(34, 2, Artist.Eva_Maria_Toker));
            Cards.Add(Card.Enemy("Corsair Captain", string.Empty, setTheSiegeOfGondor, 49, 3, 5, 3, 6)
                .WithTraits("Corsair.")
                .WithText("Cannot be optionally engaged.\r\nIf the active location is a Ship, ~Corsair ~Captain gets -30 engagement cost and gains: \"Forced: When ~Corsair ~Captain engages you, it makes an immediate attack.\"")
                .WithEasyModeQuantity(1)
                .WithInfo(35, 2, Artist.Gabriel_Verdon));
            Cards.Add(Card.Enemy("Corsair of Umbar", string.Empty, setTheSiegeOfGondor, 29, 2, 2, 1, 3)
                .WithTraits("Corsair.")
                .WithText("If the active location is a Ship, ~Corsair of Umbar gets +2 Attack and +2 Defense.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the active location is a Ship).")
                .WithInfo(36, 3, Artist.Ivan_Dixon));
            Cards.Add(Card.Enemy("Umbar Pirate Crew", string.Empty, setTheSiegeOfGondor, 39, 3, 6, 2, 8)
                .WithTraits("Corsair.")
                .WithText("Cannot have attachments.\r\nForced: When Umbar Pirate Crew engages you, exhaust a character you control.")
                .WithShadow("Shadow: If the active location is a Ship, return attacking enemy to the staging area after this attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(37, 2, Artist.Gabriel_Verdon));
            Cards.Add(Card.Enemy("Haradrim Pirate", string.Empty, setTheSiegeOfGondor, 34, 2, 3, 2, 4)
                .WithTraits("Corsair.")
                .WithText("Forced: When Haradrim Pirate engages you, deal 1 damage to a character you control (2 damage instead if the active location is a Ship).")
                .WithShadow("Shadow: Defending character gets -1 Defense for each damage on it.")
                .WithInfo(38, 3, Artist.Owen_William_Weber));
            Cards.Add(Card.Treachery("Fell Folk of Umbar", string.Empty, setTheSiegeOfGondor)
                .WithKeywords("Peril.")
                .WithText("When Revealed: Either return each Corsair enemy engaged with you to the staging area, or discard cards from the top of the encounter deck until a Corsair enemy is discarded and put that enemy into play engaged with you.")
                .WithFlavor("\"...there men of Lamedon contested the fords with fell folk of Umbar and Harad who had sailed up the river.\"\r\n-Legolas, The Return of the King")
                .WithInfo(39, 2, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(Card.Treachery("Black Sails", string.Empty, setTheSiegeOfGondor)
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Each Ship location in the staging area gets +1 Threat until the end of the phase. If there are no non-unique Ship locations in the staging area, search the encounter deck and discard pile for a Ship location and add it to the staging area. Shuffle the encounter deck.")
                .WithInfo(40, 3, Artist.Jose_Vega));
            Cards.Add(Card.Treachery("Raiding the Coasts", string.Empty, setTheSiegeOfGondor)
                .WithText("When Revealed: Each player must choose: either add 3 to the total Threat in the staging area until the end of the phase, or discard the highest cost attachment you control.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, discard an attachment you control.")
                .WithEasyModeQuantity(1)
                .WithInfo(41, 2, Artist.Johan_Tornlund));
            Cards.Add(Card.Treachery("Driven to the Brink", string.Empty, setTheSiegeOfGondor)
                .WithKeywords("Peril.")
                .WithText("When Revealed: Either immediately end the quest phase (without resolving the quest), or assign X damage among questing characters you control. X is the number of resources on The Corsair Fleet.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithEasyModeQuantity(1)
                .WithInfo(42, 2, Artist.Jenn_Tran));

            Cards.Add(Card.Quest("The Forbidden Door", string.Empty, 13, 1, setThePassingOfTheGreyCompany, null)
                .WithFlavor("\"I must take new counsel for myself and my kindred. We must ride our own road, and no longer in secret. For me the time of stealth has passed. I will ride by the swiftest way, and I will take the Paths of the Dead.\" -Aragorn, The Return of the King")
                .WithText("Setup: Set The Stone of Erech and Army of the Dead aside, out of play. Each player attaches a copy of Overcome by ~Fear to his threat dial. Remove each unattached copy of Overcome by ~Fear from the game.")
                .WithOppositeFlavor("\"This is an evil door,\" said Halbarad, \"and my death lies beyond it. I will dare to pass nonetheless...\" -The Return of the King")
                .WithOppositeText("When Revealed: Each player may add 1 resource to the resource pool of each hero he controls. Each player who does so must raise his threat by 3.\r\nForced: At the end of the planning phase, discard all cards in each player’s hand and advance to stage 2A.")
                .WithInfo(63, 1, Artist.Yoann_Boissonnet));
            Cards.Add(Card.Quest("The Paths of the Dead", string.Empty, 13, 2, setThePassingOfTheGreyCompany, 254)
                .WithFlavor("He could see nothing but the dim flame of the torches; but if the company halted, there seemed an endless whisper of voices all about him, a murmur of words in no tongue that he had ever heard before. -The Return of the King")
                .WithText("When Revealed: Each player searches the encounter deck for a different location and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("...there could be no turning back; all the paths behind were thronged by an unseen host that followed in the dark. -The Return of the King")
                .WithOppositeText("X is the threat of the player with the highest threat.\r\nEach player cannot reduce his threat below his initial threat level.\r\nForced: At the beginning of the planning phase each player must choose: either raise your threat by 1, or you cannot play cards this phase.")
                .WithInfo(64, 1, Artist.Jennifer_Hrabota_Lesser));
            Cards.Add(Card.Quest("The Dead are Following", string.Empty, 13, 3, setThePassingOfTheGreyCompany, 5)
                .WithFlavor("\"I see shapes of Men and of horses, and pale banners like shreds of cloud, and spears like winter-thickets on a misty night. The Dead are following.\" -Legolas, The Return of the King")
                .WithText("When Revealed: Add The Stone of Erech and Army of the Dead (enemy side faceup) to the staging area. Each player may raise his threat by 3 to detach Overcome by ~Fear from his threat dial and set it aside, out of play.")
                .WithOppositeFlavor("\"Yes, the Dead ride behind. They have been summoned.\" -Elladan, The Return of the King")
                .WithOppositeText("While Stone of Erech is the active location, each Oathbreaker enemy loses the Phantom keyword and gets -20 engagement cost.\r\nWhen The Stone of Erech leaves play as an explored location, the players win the game.")
                .WithInfo(65, 1, Artist.S_C_Watson));
            Cards.Add(Card.Campaign("The Passing of the Grey Company", string.Empty, 13, setThePassingOfTheGreyCompany, "The Lord of the Rings - Part 13")
                .WithText("Setup: Each player may trade heroes without incurring a threat penalty. The first player may raise each player’s threat by 1 to search his deck for Anduril and add it to his hand. Remove each burden with these burden set icons from the encounter deck: A Shadow of the Past, Flight to the Ford, The Ring Goes South, The Passage of the Marshes, Shelob’s Lair")
                .WithFlavor("\"...there is only one way through the mountains that will bring me to the coastlands before all is lost. That is the Paths of the Dead.\" -Aragorn, The Return of the King")
                .WithOppositeText("Resolution: Add each copy of Overcome by Fear attached to a player's threat dial to the campaign pool and record the name of each player it was attached to. If Army of the Dead is in the victory display, add the Army of the Dead boon to the campaign pool. The players have earned each card added to the campaign pool")
                .WithOppositeFlavor("Then Aragorn said: \"The hour is come at last. Now I go to Pelargir upon Anduin, and ye shall come after me. And when all this land is clean of the servants of Sauron, I will hold the oath fulfilled, and ye shall have peace and depart for ever. For I am Elessar, Isildur's heir of Gondor.\" -The Return of the King")
                .WithInfo(66, 1, Artist.Yoann_Boissonnet));
            Cards.Add(Card.Enemy("Army of the Dead", string.Empty, setThePassingOfTheGreyCompany, 50, 255, 6, 2, 8)
                .WithSlugIncludesType()
                .WithUnique()
                .WithTraits("Undead.", "Oathbreaker.")
                .WithKeywords("Phantom.")
                .WithText("Immune to player card effects.\r\nX is twice the number of players in the game.\r\nForced: When Army of the Dead attacks, you must either attach a set aside Overcome by ~Fear to your threat dial, or discard an ally you control.")
                .WithVictoryPoints(6)
                .WithInfo(67, 1, Artist.Uwe_Jarling));
            Cards.Add(Card.ObjectiveAlly("Army of the Dead", string.Empty, setThePassingOfTheGreyCompany, 4, 6, 2, 8)
                .WithBoon()
                .WithSlugIncludesType()
                .WithUnique()
                .WithTraits("Undead.")
                .WithText("Immune to player card effects. The first player gains control of Army of the Dead.\r\nSetup: The first player takes control of Army of the Dead.\r\nIf Army of the Dead leaves play, remove it from the game.")
                .WithFlavor("\"Now come! By the Black Stone I call you!\"\r\n-Aragorn, The Return of the King")
                .WithInfo(68, 1, Artist.Uwe_Jarling));
            Cards.Add(Card.Quest("Attack on Pelargir", string.Empty, 14, 1, setTheSiegeOfGondor, 20)
                .WithFlavor("\"There at Pelargir lay the main fleet of Umbar, fifty great ships and smaller vessels beyond count. Many of those that we pursued had reached the havens before us...\"\r\n-Gimli, The Return of the King")
                .WithText("Setup: Add The ~Corsair Fleet (Corsair side faceup) and Great Corsair Ship to the staging area. Each player searches the encounter deck for a Ship location and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("\"But the Haradrim, being now driven to the brink, turned at bay, and they were fierce in despair; and they laughed when the looked on us, for they were a great army still.\" -Gimli, The Return of the King")
                .WithOppositeText("Each Ship location in the staging area is immune to player card effects.\r\nThe players cannot defeat this stage while Great Corsair Ship is in play. When this stage is defeated, the players win the game.")
                .WithInfo(69, 1, Artist.Javier_Charro_Martinez));
            Cards.Add(Card.Campaign("The Siege of Gondor", string.Empty, 14, setTheSiegeOfGondor, "The Lord of the Rings - Part 14")
                .WithText("Setup: The first player may raise each player's threat by 1 to search his deck for Andúril and add it to his hand. Remove each burden with the following burden set icons from the encounter deck:")
                .WithFlavor("\"There is a great fleet drawing near to the mouths of Anduin, manned by the Corsairs of Umbar in the South. They have long ceased to fear the might of Gondor, and they have allied with the Enemy, and now make a heavy stroke in his cause.\"\r\n-Beregond, The Return of the King")
                .WithOppositeText("Resolution: Count the number of resources on The Corsair Fleet and record that number in the notes section of the quest log. Remove Army of the Dead from the Campaign pool.")
                .WithOppositeFlavor("\"But mighty indeed was Aragorn that day. Lo! all the black fleet was in his hands; and he chose the greatest ship to be his own, and he went up into it.\"\r\n-Gimli, The Return of the King")
                .WithInfo(70, 1, Artist.Javier_Charro_Martinez));
            Cards.Add(Card.Objective("The Corsair Fleet", string.Empty, setTheSiegeOfGondor)
                .WithUnique()
                .WithTraits("Corsair.")
                .WithSuffix("Corsair")
                .WithText("Forced: At the beginning of the staging step, place 1 resource on this objective. Then, each player must choose: either reveal an encounter card, or assign X damage among characters he controls. X is the number of resources here.")
                .WithFlavor("...ships of great draught with many oars, and with black sails bellying in the breeze. -The Return of the King")
                .WithInfo(71, 1, Artist.Johan_Tornlund));
            Cards.Add(Card.Objective("The Corsair Fleet", string.Empty, setTheSiegeOfGondor)
                .WithUnique()
                .WithTraits("Gondor.")
                .WithSuffix("Gondor")
                .WithText("Forced: At the beginning of the quest phase, remove 1 resource from The Corsair Fleet. Then, if there are no resources here, the first player takes control of Aragorn and adds The Corsair Fleet to the victory display.")
                .WithFlavor("\"The oars were now wielded by free men, and manfully they laboured...\"\r\n-Legolas, The Return of the King")
                .WithInfo(72, 1, Artist.Johan_Tornlund));
        }
    }
}