using System;

namespace HallOfBeorn.Models.LotR.Sets.VengeanceOfMordor
{
    public class TheLandOfSorrowSet
        : CardSet
    {
        public const string setName = "The Land of Sorrow";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TLoSo";
            Number = 61;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Vengeance of Mordor";

            addHero("Gwaihir", 13, Sphere.Tactics, 2, 4, 3, 4)
                .WithTraits("Creature.", "Eagle.")
                .WithKeywords("Ranged.", "Sentinel.")
                .WithTextLine("Ranged. Sentinel.")
                .WithTextLine("Cannot have restricted attachments. Gwaihir does not ready during the refresh phase.")
                .WithTextLine("Response: After an Eagle ally enters or leaves play, ready Gwaihir. (Limit once per phase.)")
                .WithCommunityVersion("Gwaihir-Nightmare-in-the-Fog")
                .WithInfo(108, 1, Artist.Carlos_Palma_Cruchaga);
            addAlly("Hobbit Archer", 2, Sphere.Leadership, false, 1, 1, 0, 2)
                .WithTraits("Hobbit.", "Archer.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Hobbit Archer gets +1 Attack while attacking an enemy with a higher engagement cost than your threat.")
                .WithFlavorLine("\"If you lay a finger on this farmer, or on anyone else, you will be shot at once.\"")
                .WithFlavorLine("-Merry, The Return of the King")
                .WithInfo(109, 3, Artist.Aleksander_Karcz);
            addAttachment("Red Book of Westmarch", 3, Sphere.Leadership, true)
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Hobbit hero. Restricted.")
                .WithTextLine("While attached hero is committed to the quest, each Hobbit character gets +1 Willpower.")
                .WithTextLine("Response: After you quest successfully, exhaust Red Book of Westmarch to add 1 resource to attached hero's resource pool.")
                .WithInfo(110, 3, Artist.Guillaume_Ducos);
            addAlly("Dale Messenger", 2, Sphere.Lore, false, 1, 1, 1, 2)
                .WithTraits("Dale.")
                .WithTextLine("Response: After Dale Messenger enters play, choose a player. That player heals 1 damage from each character he controls with a player card attachment.")
                .WithFlavorLine("\"We discover that messengers have come also to King Brand in Dale...\"")
                .WithFlavorLine("-Glóin, The Fellowship of the Ring")
                .WithInfo(111, 3, Artist.Sara_Biddle);
            addAttachment("Song of Healing", 0, Sphere.Lore, false)
                .WithTraits("Song.")
                .WithTextLine("Attach to a hero. Limit 1 per hero.")
                .WithTextLine("Action: Discard 1 card from your hand to heal 1 damage from attached hero. Any player may trigger this effect.")
                .WithFlavorLine("...behind him stood Galadriel, tall and white: a circlet of golden flowers was in her hair, and in her hand she held a hard, and she sang.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(112, 3, Artist.Magali_Villeneuve);
            addAlly("Eagle Emissary", 2, Sphere.Tactics, false, 2, 1, 0, 2)
                .WithTraits("Creature.", "Eagle.")
                .WithTextLine("Cannot have restricted attachments.")
                .WithTextLine("Forced: After ~Eagle Emissary quests successfully, pay 1 Tactics resource or discard it from play.")
                .WithFlavorLine("...and out of the East there came a great Eagle flying, and he bore tidings beyond hope from The Lords of the West...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(113, 3, Artist.Carlos_Palma_Cruchaga);
            addEvent("Bilbo's Plan", 0, Sphere.Tactics)
                .WithTextLine("Response: After you attack and destroy an enemy, shuffle the encounter discard pile into the encounter deck and discard cards from the top until an enemy is discarded. Add that enemy to the staging area to discard a non-unique location with Threat equal to or less that that enemy's Threat.")
                .WithInfo(114, 3, Artist.Guillaume_Ducos);
            addAttachment("Spare Pipe", 1, Sphere.Spirit, false)
                .WithTraits("Item.", "Pipe.")
                .WithTextLine("Attach to a character.")
                .WithTextLine("Attached character gets +1 hit point.")
                .WithTextLine("Response: After you play Spare Pipe, search the top 5 cards of your deck for an event and add it to your hand. Shuffle your deck.")
                .WithFlavorLine("\"I have carried it a long way, though I don't know why.\"")
                .WithFlavorLine("-Pippin, The Two Towers")
                .WithInfo(115, 3, Artist.Tamires_Para);
            addEvent("Smoke and Think", 0, Sphere.Spirit)
                .WithTextLine("Action: Reduce the cost of the next card you play by 1 for each Pipe you control.")
                .WithFlavorLine("Merry smiled. \"Well then,\" he said, \"if Strider will provide what is needed, I will smoke and think.\"")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(116, 3, Artist.David_Keen);
            addAlly("Wilyador", 1, Sphere.Neutral, true, 1, 3, 2, 3)
                .WithTraits("Creature.", "Eagle.")
                .WithKeywords("Ranged.", "Sentinel.")
                .WithTextLine("Ranged. Sentinel.")
                .WithTextLine("Cannot have restricted attachments.")
                .WithTextLine("Forced: At the end of the round, discard Wilyador unless the players as a group spend 1 resource.")
                .WithInfo(117, 3, Artist.Sam_White);
            addEnemy("Ulwarth", EncounterSet.TheLandOfSorrow, 34, 3, 4, 1, 6)
                .WithUnique()
                .WithTraits("Easterling.", "Warden.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Only the engaged player can declare attackers or defenders against Ulwarth.")
                .WithTextLine("Allies cannot be declared as attackers or defenders against Ulwarth.")
                .WithVictoryPoints(1)
                .WithInfo(118, 1, Artist.Guillaume_Ducos);
            addEnemy("Lorgan", EncounterSet.TheLandOfSorrow, 29, 1, 5, 3, 8)
                .WithUnique()
                .WithTraits("Easterling.", "Warden.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Only the engaged player can declare attackers or defenders against Lorgan.")
                .WithTextLine("Forced: After Lorgan attacks, raise each player's threat by 1 (2 instead if this attack destroys a character.")
                .WithVictoryPoints(1)
                .WithInfo(119, 1, Artist.Nikolas_Hagialas);
            addEnemy("Borlach", EncounterSet.TheLandOfSorrow, 33, 2, 6, 2, 9)
                .WithUnique()
                .WithTraits("Easterling.", "Warden.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Only the engaged player can declare attackers or defenders against Borlach.")
                .WithTextLine("Forced: After Borlach attacks and destroys a character, any excess damage must be assigned among characters you control.")
                .WithVictoryPoints(1)
                .WithInfo(120, 1, Artist.Borja_Pindado);
            addLocation("The Barracks", EncounterSet.TheLandOfSorrow, 1, 5)
                .WithUnique()
                .WithTraits("Camp.")
                .WithTextLine("Forced: After The Barracks becomes the active location, add the enemy under it to the staging area. That enemy cannot take damage this round.")
                .WithTextLine("Forced: When The Baracks is explored, the first player gains control of the objective ally it was guarding.")
                .WithVictoryPoints(1)
                .WithInfo(121, 1, Artist.Federico_Musetti);
            addLocation("Slave Quarters", EncounterSet.TheLandOfSorrow, 1, 3)
                .WithUnique()
                .WithTraits("Camp.")
                .WithTextLine("Forced: After Slave Quarters becomes the active location, the enemy under it engages the first player and makes an immediate attack.")
                .WithTextLine("Forced: When Slave Quarters is explored, the first player gains control of the objective ally it was guarding.")
                .WithVictoryPoints(1)
                .WithInfo(122, 1, Artist.Michael_Edward_Smith);
            addLocation("The Storehouse", EncounterSet.TheLandOfSorrow, 1, 4)
                .WithUnique()
                .WithTraits("Camp.")
                .WithTextLine("Forced: After The Storehouse becomes the active location, add the enemy under it to the staging area. That enemy gets +3 Attack and -30 engagement cost until the end of the round.")
                .WithTextLine("Forced: When The Storehouse is explored, the first player gains control of the objective ally it was guarding.")
                .WithVictoryPoints(1)
                .WithInfo(123, 1, Artist.Tropa_Entertainment);
            addObjectiveAlly("Edrahil", EncounterSet.TheLandOfSorrow, 3, 1, 0, 3)
                .WithUnique()
                .WithTraits("Captive.", "Silvan.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Response: After Edrahil quests successfully, choose a player to draw 1 card.")
                .WithTextLine("If Edrahil leaves play, the players lose the game.")
                .WithInfo(124, 1, Artist.Aleksander_Karcz);
            addObjectiveAlly("Arador", EncounterSet.TheLandOfSorrow, 0, 1, 3, 5)
                .WithUnique()
                .WithTraits("Captive.", "Gondor.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Response: After Arador is declared as a defender, ready him. (Limit once per round.)")
                .WithTextLine("If Arador leaves play, the players lose the game.")
                .WithInfo(125, 1, Artist.Aleksander_Karcz);
            addObjectiveAlly("Farin", EncounterSet.TheLandOfSorrow, 1, 3, 0, 4)
                .WithUnique()
                .WithTraits("Captive.", "Dwarf.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Response: After Farin is declared as an attacker against an enemy, deal 1 damage to an enemy engaged with a player.")
                .WithTextLine("If Farin leaves play, the players lose the game.")
                .WithInfo(126, 1, Artist.Aleksander_Karcz);
            addEnemy("Easterling Guard", EncounterSet.TheLandOfSorrow, 32, 3, 4, 2, 5)
                .WithTraits("Easterling.")
                .WithKeywords("Archery 2.")
                .WithTextLine("Archery 2.")
                .WithTextLine("When Revealed: Assign X damage among characters in play. X is the current archery total.")
                .WithShadow("Shadow: Defending character cannot ready this round.")
                .WithEasyModeQuantity(2)
                .WithInfo(127, 3, Artist.Alvaro_Calvo_Escudero);
            addEnemy("Nurn Slaver", EncounterSet.TheLandOfSorrow, 23, 2, 3, 2, 6)
                .WithTraits("Easterling.")
                .WithTextLine("While the number of Camp locations in the staging area is less than the number of players, Nurn Slavers gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each Camp location in the victory display.")
                .WithEasyModeQuantity(3)
                .WithInfo(128, 4, Artist.Michael_Edward_Smith);
            addLocation("Working Fields", EncounterSet.TheLandOfSorrow, 3, 4)
                .WithTraits("Plains.")
                .WithTextLine("While Working Fields is in the staging area, characters cannot be healed.")
                .WithTextLine("Travel: Each player deals 1 damage to a character he controls.")
                .WithFlavorLine("Neither he nor Frodo knew anything of the great slave-worked fields away south in this wide realm...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(129, 3, Artist.Stanislav_Dikolenko);
            addLocation("Watch Tower", EncounterSet.TheLandOfSorrow, Card.VALUE_X, 5)
                .WithTraits("Plains.")
                .WithTextLine("While Watch Tower is in the staging area, it gains archery X.")
                .WithTextLine("X is 1 more than the number of Captive objective allies the players control.")
                .WithTextLine("Travel: Reveal the top card of the encounter deck.")
                .WithEasyModeQuantity(1)
                .WithInfo(130, 3, Artist.Sarah_Lindstrom);
            addTreachery("Overseer's Whip", EncounterSet.TheLandOfSorrow)
                .WithTraits("Easterling.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("While attached to an enemy, counts as a Weapon attachment with the text: \"Forced: When attached enemy attacks, deal 1 damage to an exhausted character you control.")
                .WithTextLine("When Revealed: Attach to the Easterling enemy with the lowest engagement cost.")
                .WithEasyModeQuantity(1)
                .WithInfo(131, 2, Artist.Matt_Hansen);
            addTreachery("Cruelty of Mordor", EncounterSet.TheLandOfSorrow)
                .WithTextLine("When Revealed: Each player deals 1 damage to a character he controls. Then, each player must choose: either deal 1 damage to each damaged character you control, or raise your threat by 1 for each damaged character you control.")
                .WithShadow("Shadow: Attacking enemy gets +2 Defense until the end of the phase.")
                .WithEasyModeQuantity(2)
                .WithInfo(132, 3, Artist.Michael_Edward_Smith);
            addTreachery("Broken Captives", EncounterSet.TheLandOfSorrow)
                .WithTextLine("When Revealed: Exhaust each damaged character. If no characters are exhausted by this effect, Broken Captives gains surge and Doomed 1.")
                .WithShadow("Shadow: If attacking enemy is a Warden, it makes an additional attack against you after this one.")
                .WithEasyModeQuantity(1)
                .WithInfo(133, 2, Artist.Sara_Biddle);
            addContract("Messenger of the King")
                .WithTextLine("You cannot choose more than 2 heroes during setup.")
                .WithTextLine("Setup: Choose a non-neutral unique ally from your deck and put it into play. Add the sum of that ally's printed Willpower, Attack, Defense, and hit points to your starting threat. Then, flip this card over and attach it to that ally.")
                .WithFlavorLine("\"I am a messenger of the King,\" he said. \"You are speaking to the King's friend, and one of the most renowned in all the lands of the West.\"")
                .WithFlavorLine("-Pippin, The Return of the King")
                .WithOppositeTextLine("Attached ally loses the ally card type and gains the hero card type.")
                .WithOppositeTextLine("Attached character cannot be readied more than once per phase.")
                .WithOppositeTextLine("Messenger of the King is immune to card effects while attached character is in play. If attached character leaves play, remove Messenger of the King from the game.")
                .WithTemplate("<p class='main-text'>You cannot choose more than 2 heroes during setup.</p><p class='main-text'><b>Setup:</b> Choose a <a href='/LotR?Query=-sphere%3ANeutral&CardType=Ally&IsUnique=Yes' title='Search non-neutral unique allies' target='_blank'>non-neutral unique ally</a> from your deck and put it into play. Add the sum of that ally's printed {Willpower}, {Attack}, {Defense}, and hit points to your starting threat. Then, flip this card over and attach it to that ally.</p><p class='flavor-text'>&ldquo;I am a messenger of the King,&rdquo; he said. &ldquo;You are speaking to the King's friend, and one of the most renowned in all the lands of the West.&rdquo;<br>&ndash;Pippin, The Return of the King</p>")
                .WithTemplate2("<p class='main-text'>Attached ally loses the ally card type and gains the hero card type.</p><p class='main-text'>Attached character cannot be readied more than once per phase.</p><p class='main-text'>{self} is immune to card effects while attached character is in play. <b>If attached character leaves play, remove {self} from the game.</b></p>")
                .WithInfo(134, 1, Artist.Justin_Gerard);
            addQuest("Slaves of the Dark Lord", EncounterSet.TheLandOfSorrow, 1, 'A', 15)
                .WithFlavor("You've decided to risk everything to rescue Ulchor's captives from slavery.")
                .WithTextLine("Setup: Add each Camp location to the staging area. Attach a random Captive objective-ally to each Camp location as a guarded objective. Place 1 random Warden enemy faceup (but not in play) under each Camp location. Shuffle the encounter deck and discard cards from the top until X locations are discarded, where X is 1 less than the number of players. Add each location discarded this way to the staging area.")
                .WithOppositeTextLine("Each Camp location is immune to player card effects, and player cannot travel there while a Warden enemy is in play.")
                .WithOppositeTextLine("Forced: At the end of the round, raise each player's threat by 1 for each Camp location in the staging area.")
                .WithOppositeTextLine("This stage cannot be defeated unless players control all 3 Captive objective-allies.")
                .WithIncludedEncounterSets(EncounterSet.EasterlingRaiders, EncounterSet.RollingPlains)
                .WithInfo(135, 1, Artist.Alvaro_Calvo_Escudero);
            addQuest("Lead the Revolt", EncounterSet.TheLandOfSorrow, 2, 'A', 10)
                .WithFlavor("You've freed Ulchor's slaves, but his lieutenants are advancing with a garrison to recapture them. You must lead the prisoners in a desperate fight to win their freedom.")
                .WithTextLine("When Revealed: The first player returns each Warden enemy in the victory display to the staging area. Each other player discards cards from the top of the encounter deck until he discards an enemy and adds that enemy to the staging area.")
                .WithOppositeTextLine("This stage gets +10 quest points per player.")
                .WithOppositeTextLine("Forced: After a player commits characters to the quest, if he is not engaged with a Warden enemy he must reveal an encounter card.")
                .WithOppositeTextLine("This stage cannot be defeated while a Warden enemy is in play. When this stage is defeated, the players win the game.")
                .WithIncludedEncounterSets(EncounterSet.EasterlingRaiders, EncounterSet.RollingPlains)
                .WithInfo(136, 1, Artist.Aleksander_Karcz);
        }
    }
}