using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.VengeanceOfMordor
{
    public class TheCityOfUlfastSet : CardSet
    {
        public const string setName = "The City of Ulfast";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TCoU";
            Number = 58;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Vengeance of Mordor";

            addHero("Lothíriel", 8, Sphere.Spirit, 3, 1, 1, 3)
                .WithTraits("Gondor.", "Noble.")
                .WithTextLine("If Éomer is in play, Lothíriel gains the Rohan trait.")
                .WithTextLine("Response: After Lothíriel commits to a quest, choose an ally in your hand. If that ally shares a Trait with her, put that ally into play exhausted and committed to the quest. At the end of the phase, if that ally is still in play, shuffle it into your deck.")
                .WithInfo(27, 1, Artist.Alvaro_Calvo_Escudero);

            addAlly("Angbor the Fearless", 2, Sphere.Leadership, true, 2, 1, 0, 2)
                .WithTraits("Gondor.", "Warrior.")
                .WithTextLine("While your threat is 40 or higher, Angbor the Fearless gets +2 Attack and does not exhaust to quest.")
                .WithFlavorLine("\"Four thousands I sent marching from Pelargir through Lossarnach two days ago; and Angbor the fearless rides before them.\"")
                .WithFlavorLine("-Aragorn, The Return of the King")
                .WithInfo(28, 3, Artist.Unknown);
            addEvent("Need Drives Them", 3, Sphere.Leadership)
                .WithTextLine("Action: Each player whose threat is 40 or higher readies all characters he controls.")
                .WithInfo(29, 3, Artist.Unknown);
            addAlly("Woodland Sentry", 3, Sphere.Lore, false, 1, 1, 1, 2)
                .WithTraits("Silvan.")
                .WithTextLine("Response: After you play Woodland Sentry from your hand, choose an enemy or location in play. If there is a copy of that card in the victory display, discard the chosen card.")
                .WithFlavorLine("In the Wide World the Wood-elves lingered in the twilight of our Sun and Moon but loved best the stars...")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(30, 3, Artist.Sara_Biddle);
            addAttachment("Keen Longbow", 2, Sphere.Lore, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Lore hero. Limit 1 per hero.")
                .WithTextLine("Restricted.")
                .WithTextLine("Attached hero gains ranged.")
                .WithTextLine("Response: After attached hero is declared an as attacker against an enemy, discard up to 3 cards from your hand to deal 1 damage to that enemy for each card discarded this way.")
                .WithInfo(31, 3, Artist.Unknown);
            addAttachment("War Axe", 1, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Tactics character. Limit 1 per character. Restricted.")
                .WithTextLine("Attached characters gets +1 Attack for each attachment it has with the restricted keyword.")
                .WithFlavorLine("\"Gimli Glóin's son, have you your axe ready?\"")
                .WithFlavorLine("-Éomer, The Return of the King")
                .WithInfo(32, 3, Artist.Unknown);
            addAttachment("Strength and Courage", 1, Sphere.Tactics, false)
                .WithTraits("Master.")
                .WithTextLine("Attach to the hero with The One Ring.")
                .WithTextLine("Limit 1 per hero. Attached hero gets +1 Attack.")
                .WithTextLine("Response: After attached hero is declared as an attacker, exhaust The One Ring and raise your threat by 1 to double attached hero's printed Attack for this attack.")
                .WithInfo(33, 3, Artist.Unknown);
            addAlly("Knight of Belfalas", 2, Sphere.Spirit, false, 1, 2, 0, 2)
                .WithTraits("Gondor.", "Warrior.")
                .WithTextLine("Response: After Knight of Belfalas enters play, return a Gondor ally from your discard pile to your hand.")
                .WithFlavorLine("The mounted knights returned, and at their rear the banner of Dol Amroth...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(34, 3, Artist.Unknown);
            addAttachment("Horn of the Mark", 1, Sphere.Spirit, true)
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Rohan hero or Merry. Restricted.")
                .WithTextLine("Response: When a character leaves play, if that character shares at least one trait with the attached hero, exhaust Horn of the Mark to draw 1 card.")
                .WithFlavorLine("Then Éowyn gave to Merry an ancient horn, small but cunningly wrought all of fair silver with a baldric of green.")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(35, 3, Artist.Unknown);
            addEvent("Host of Galadhrim", 4, Sphere.Neutral)
                .WithTextLine("Planning Action: Return each Silvan ally you control to your hand. Then, play each of those allies from your hand one at a time at no cost.")
                .WithFlavorLine("Celeborn came forth and led the host of Lórien...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(36, 3, Artist.Leanna_Crossan);
            addEnemy("City Guard", EncounterSet.TheCityOfUlfast, 45, Card.VALUE_X, 9, 4, 20)
                .WithUnique()
                .WithTraits("Easterling.")
                .WithKeywords("Indestructible.")
                .WithTextLine("Immune to player card effects. Indestructible.")
                .WithTextLine("X is 1 more than the number of resources on the main quest.")
                .WithTextLine("City Guard cannot leave the staging area but is considered to be engaged with each player whose threat is equal to or higher than its engagement cost.")
                .WithVictoryPoints(5)
                .WithInfo(37, 1, Artist.Kamila_Szutenberg);
            addEnemy("Ulfast Sentry", EncounterSet.TheCityOfUlfast, 25, 2, Card.VALUE_X, 1, 3)
                .WithTraits("Easterling.")
                .WithTextLine("X is 1 more than the number of resources on the main quest.")
                .WithTextLine("Forced: After Ulfast Sentry engages you, either place 1 resource on the main quest or Ulfast Sentry makes an attack.")
                .WithEasyModeQuantity(2)
                .WithInfo(38, 3, Artist.Sara_Biddle);
            addEnemy("The King's Elite", EncounterSet.TheCityOfUlfast, 30, 3, 5, 2, 5)
                .WithTraits("Easterling.")
                .WithTextLine("Cannot have player card attachments.")
                .WithTextLine("Forced: When The King's Elite attacks, place 1 resource on the main quest.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack after this one.")
                .WithEasyModeQuantity(1)
                .WithInfo(39, 2, Artist.Stanislav_Dikolenko);
            addEnemy("Ulchor's Agent", EncounterSet.TheCityOfUlfast, 32, 3, 3, 2, 4)
                .WithTraits("Mordor.")
                .WithTextLine("When Revealed: Raise each player's threat by 3.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, raise each player's threat by 1.")
                .WithInfo(40, 2, Artist.Alvaro_Calvo_Escudero);
            addLocation("The King's Lawn", EncounterSet.TheCityOfUlfast, 3, 5)
                .WithTraits("City.")
                .WithTextLine("While The King's Lawn is in the staging area, each player must raise his threat by 1 additional point during the refresh phase.")
                .WithTextLine("Travel: Place 1 resource on the main quest.")
                .WithInfo(41, 2, Artist.Frej_Agelii);
            addLocation("Guarded Archway", EncounterSet.TheCityOfUlfast, 2, 4)
                .WithTraits("City.")
                .WithTextLine("While Guarded Archway is in the staging area, each player engaged with City Guard cannot reduce his threat.")
                .WithTextLine("Travel: City Guard makes an attack against the first player.")
                .WithEasyModeQuantity(2)
                .WithInfo(42, 3, Artist.Michael_Edward_Smith);
            addLocation("Crowded Market", EncounterSet.TheCityOfUlfast, 2, 2)
                .WithTraits("City.")
                .WithTextLine("While Crowded Market is the active location, City Guard gets +20 engagement cost.")
                .WithTextLine("Travel: Shuffle the encounter discard pile into the encounter deck and discard cards from the top until an enemy is discarded. Add that enemy to the staging area.")
                .WithInfo(43, 2, Artist.Kamila_Szutenberg);
            addLocation("Streets of Ulfast", EncounterSet.TheCityOfUlfast, Card.VALUE_X, 5)
                .WithTraits("City.")
                .WithTextLine("X is 1 more than the number of resources on the main quest.")
                .WithTextLine("Travel: Raise each player's threat by X.")
                .WithShadow("Shadow: Return attacking enemy to the staging area after this attack.")
                .WithEasyModeQuantity(2)
                .WithInfo(44, 3, Artist.Torbjorn_Kallstrom);
            addTreachery("Extra Vigil", EncounterSet.TheCityOfUlfast)
                .WithTextLine("When Revealed: Attach to City Guard. (Counts as a Condition attachment with the text: \"City Guard gets -10 engagement cost. Response: After you attack and damage City Guard, raise your threat by 1 and discard Extra Vigil.\")")
                .WithShadow("Shadow: If attacking enemy is City Guard, attach Extra Vigil to it.")
                .WithInfo(45, 2, Artist.Leanna_Crossan);
            addTreachery("We've Been Seen", EncounterSet.TheCityOfUlfast)
                .WithTextLine("When Revealed: Each player must choose: either City Guard makes an attack against you, or raise your threat by X, where X is 1 more than the number of allies you control.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, excess damage must be assigned among characters you control.")
                .WithEasyModeQuantity(1)
                .WithInfo(46, 3, Artist.Jon_Bosco);
            addTreachery("Patrolling the Streets", EncounterSet.TheCityOfUlfast)
                .WithTextLine("When Revealed: Place 1 resource on the main quest. Then, either progress cannot be placedon the current quest this phase, or raise each player's threat by X, where X is 1 more than the number of resources on the main quest.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each resource on the main quest.")
                .WithInfo(47, 3, Artist.Stanislav_Dikolenko);
            addEncounterSideQuest("Cat and Mouse", EncounterSet.TheCityOfUlfast, 10)
                .WithFlavorLine("Too many Easterlings have noted your presence in their city. Now you must throw them off your trail if you are to continue your pursuit of Ulchor unnoticed.")
                .WithTextLine("Each enemy in the staging area gets -10 engagement cost.")
                .WithTextLine("Response: After Cat and Mouse is defeated, each player may discard a non-unique enemy engaged with him.")
                .WithVictoryPoints(10)
                .WithInfo(48, 1, Artist.Torbjorn_Kallstrom);
            addContract("Forth, The Three Hunters!")
                .WithTextLine("Your deck cannot include ally cards.")
                .WithTextLine("Each of your heroes can have 1 additional restricted attachment. Reduce the cost of the first restricted attachment you play on each of your heroes each round by 1.")
                .WithTextLine("Refresh Action: If each of your heroes has at least 2 restricted attachments, flip this card over.")
                .WithFlavorLine("\"...we that remain cannot forsake our companions while we have strength left.\"")
                .WithFlavorLine("-Aragorn, The Two Towers")
                .WithOppositeTextLine("Each of your heroes can have 1 additional restricted attachment and gets +1 Willpower for each restricted attachment on it.")
                .WithOppositeTextLine("Action: Exhaust this card to heal 1 damage from each of your heroes.")
                .WithOppositeFlavorLine("\"With hope or without hope we will follow the trail of our enemies. And woe to them, if we prove the swifter!\"")
                .WithOppositeFlavorLine("-Aragorn, The Two Towers")
                .WithInfo(49, 1, Artist.Justin_Gerard);
            addQuest("Searching for Ulchor", EncounterSet.TheCityOfUlfast, 1, 'A', 5)
                .WithFlavorLine("After his defeat in Dorwinion. Ulchor fled east with the remnants of his army. You have pursued him to the City of Ulfast on the southern shore of the Sea of Rhûn. Determined to bring the villain to justice, you sneak into the city at night and begin searching for him.")
                .WithTextLine("Setup: Add City Guard to the staging area. Each player adds a different location to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavorLine("Ulfast is a city of Easterlings, and they do not take kindly to intruders. You must take care to avoid the city guard as you search about.")
                .WithOppositeTextLine("City Guard cannot have more than 5 damage, and it gets -5 engagement cost for each resource here.")
                .WithOppositeTextLine("Forced: At the end of the round, place 1 resource here.")
                .WithIncludedEncounterSets(EncounterSet.ServantsOfSauron, EncounterSet.UnderGuard)
                .WithInfo(50, 1, Artist.Frej_Agelii);
            addQuest("Trying to Blend In", EncounterSet.TheCityOfUlfast, 2, 'A', 10)
                .WithFlavorLine("So far your search has revealed nothing of Ulchor's whereabouts, so you attempt to blend in with the city populace in order to learn what you can. It is a risky but necessary decision.")
                .WithTextLine("When Revealed: Each player must choose: either raise your threat by 5, or reveal an encounter card.")
                .WithOppositeTextLine("City Guard cannot have more than 10 damage, and it gets -5 engagement cost for each resource here.")
                .WithOppositeTextLine("Forced: At the end of the round, place 1 resource here.")
                .WithIncludedEncounterSets(EncounterSet.ServantsOfSauron, EncounterSet.UnderGuard)
                .WithInfo(51, 1, Artist.Drazenka_Kimpel);
            addQuest("Drawing Attention", EncounterSet.TheCityOfUlfast, 3, 'A', 15)
                .WithFlavorLine("You've learned that Ulchor seeks an audience with the King of Ulfast, but your attempts to blend in with the locals have backfired: the city guard has been alerted to your presence!")
                .WithTextLine("When Revealed: Each player must choose: either raise your threat by 5, or City Guard makes an immediate attack against you.")
                .WithOppositeFlavorLine("You must escape the notice of the city guard if you hope to reach Ulchor.")
                .WithOppositeTextLine("City Guard cannot have more than 15 damage, and it gets -5 engagement cost for each resource here.")
                .WithOppositeTextLine("Forced: At the end of the round, place 1 resource here.")
                .WithIncludedEncounterSets(EncounterSet.ServantsOfSauron, EncounterSet.UnderGuard)
                .WithInfo(52, 1, Artist.Borja_Pindado);
            addQuest("Ulchor's Trap", EncounterSet.TheCityOfUlfast, 4, 'A', 20)
                .WithFlavorLine("You have reached the King's palace only to discover the city guard waiting for you. Ulchor must have warned the King that you were coming and urged him to lay this trap for you. It will be a bitter fight if you are to escape.")
                .WithTextLine("When Revealed: Shuffle the encounter discard pile into the encounter deck and discard cards from the top until X enemies are discarded. X is the number of players. Add each enemy discarded this way to the staging area.")
                .WithOppositeFlavorLine("You must escape the notice of the city guard if you hope to reach Ulchor.")
                .WithOppositeTextLine("City Guard cannot have more than 20 damage, and it gets -5 engagement cost for each resource here.")
                .WithOppositeTextLine("Forced: At the end of the round, place 1 resource here.")
                .WithOppositeTextLine("This stage cannot be defeated while City Guardhas hit points remaining. When this stage is defeated, the players win the game.")
                .WithIncludedEncounterSets(EncounterSet.ServantsOfSauron, EncounterSet.UnderGuard)
                .WithInfo(53, 1, Artist.Mauro_Dal_Bo);
        }
    }
}
