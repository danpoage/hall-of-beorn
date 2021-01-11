/* Generated CardSet class: The City of Corsairs */

using System;

namespace HallOfBeorn.Models.LotR.Sets.DreamChaser
{
    public class TheCityOfCorsairsSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The City of Corsairs";
            Abbreviation = "TCoC";
            Number = 40;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dream-chaser";

            addHero("Prince Imrahil", 11, Sphere.Tactics, 2, 3, 2, 4)
                .WithAlternateSlug("Timrahil")
                .WithTraits("Gondor.", "Noble.", "Warrior.")
                .WithTextLine("Combat Action: Spend 1 resource from Prince Imrahil's resource pool to search the top 5 cards of your deck for an ally who shares at least 1 Trait with him, and put that ally into play. Shuffle your deck. At the end of the phase, if that ally is still in play, shuffle it into your deck. (Limit once per round.)")
                .WithCommunityVersion("Hrodebert/Prince-Imrahil-Tactics-Hero")
                .WithInfo(138, 1, Artist.Micah_Epstein);
            addAlly("Knight of the White Tower", 4, Sphere.Leadership, false, 2, 2, 3, 3)
                .WithTraits("Gondor.", "Warrior.")
                .WithTextLine("Knight of the White Tower's resource cost must be paid from a single hero’s resource pool.")
                .WithFlavorLine("\"...to be only a man of arms of the Guard of the Tower of Gondor is held worthy in the City, and such men have honour in the land.\" -Beregond, The Return of the King")
                .WithInfo(139, 3, Artist.Owen_William_Weber);
            addEvent("Hold the Line", 0, Sphere.Leadership)
                .WithTextLine("Response: When an enemy attacks a player, that player may declare up to 3 eligible characters as defenders against this attack. Then, the players as a group may spend 2 Tactics resources to ready each defending character that takes no damage from this attack.")
                .WithInfo(140, 3, Artist.Guillaume_Ducos);
            addAlly("Soldier of Dol Amroth", 2, Sphere.Tactics, false, 0, 1, 1, 2)
                .WithTraits("Gondor.", "Warrior.")
                .WithTextLine("Response: After Soldier of Dol Amroth enters play, reduce the cost of the next Tactics card you play this phase by 1.")
                .WithFlavorLine("...he and his knights still held themselves like lords in whom the race of Númenor ran true")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(141, 3, Artist.Mariusz_Gandzel);
            addAlly("Súlien", 4, Sphere.Spirit, true, 3, 0, 2, 2)
                .WithTraits("Dúnedain.", "Scout.")
                .WithTextLine("Action: Spend 1 Lore resource to exhaust Súlien. Then, each location in the staging area gets –1 Threat until the end of the phase. Any player may trigger this action.")
                .WithCommunityVersion("Autumn/Sulien")
                .WithInfo(142, 3, Artist.Andreia_Ugrai);
            addEvent("Inspiring Presence", 2, Sphere.Spirit)
                .WithTextLine("Action: Choose a hero you control. Each hero with lower threat cost than the chosen hero gets +2 Defense until the end of the phase. Then, the players as a group may spend 2 Leadership resources to give +2 Attack to each hero with lower threat cost than the chosen hero until the end of the phase.")
                .WithFlavorLine("Wherever he came men's hearts would lift again, and the winged shadows pass from memory.")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(143, 3, Artist.Dmitry_Prosvirnin);
            addAlly("Guardian of Ithilien", 1, Sphere.Lore, false, 0, 1, 0, 1)
                .WithTraits("Gondor.", "Ranger.")
                .WithTextLine("Response: After Guardian of Ithilien enters play, return an enemy engaged with you to the staging area.")
                .WithFlavorLine("From such men the Lord Denethor chose his forayers…to harry the Orcs and other enemies that roamed between the Ephel Dúath and the River.")
                .WithFlavorLine("-The Two Towers")
                .WithInfo(144, 3, Artist.Taylor_Ingvarsson);
            addAttachment("Ranger Spear", 1, Sphere.Lore, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Ranger character. Restricted.")
                .WithTextLine("Attached character gets +1 Attack (+2 Attack instead when attacking an enemy with an attachment on it).")
                .WithFlavorLine("Two had spears in their hands with broad bright heads.")
                .WithFlavorLine("-The Two Towers")
                .WithInfo(145, 3, Artist.Marius_Bota);
            addAttachment("Prince of Dol Amroth", 3, Sphere.Neutral, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to Prince Imrahil.")
                .WithTextLine("Price Imrahil gains the Outlands trait.")
                .WithTextLine("While you control Outlands allies that belong to 4 different spheres, add 1 additional resource to Prince Imrahil's resource pool when you collect resources during the resource phase (if Prince Imrahil is a hero).")
                .WithInfo(146, 3, Artist.Drazenka_Kimpel);
            addQuest("The Coast of Umbar", EncounterSet.CoastOfUmbar, 1, 'A', 15)
                .WithKeywords("Sailing.")
                .WithTextLine("Setup: Shuffle the Coast of Umbar, Corsair Raiders, Stormy Weather, Umbar Fleet, and Voyage Across Belegaer encounter sets into one encounter deck and make it the active encounter deck. Set The City of Corsairs encounter set aside, as an inactive second encounter deck. Prepare the Corsair deck. Players prepare their fleet. Add the Stormcaller to the staging area. Add 1 copy of Southern Belfalas to the staging area (2 instead if there are 3 or 4 players in the game). Shuffle the encounter deck.")
                .WithOppositeTextLine("Sailing.")
                .WithOppositeTextLine("Progress cannot be placed on The Coast of Umbar if the players are off-course.")
                .WithOppositeTextLine("If the Stormcaller is destroyed (or if this stage has 15 or more progress on it), advance to stage 2.")
                .WithOppositeFlavorLine("Deep in enemy waters, you must recover the artifact from the Stormcaller.")
                .WithIncludedEncounterSets(EncounterSet.CorsairRaiders, EncounterSet.StormyWeather, EncounterSet.UmbarFleet, EncounterSet.VoyageAcrossBelegaer, EncounterSet.TheDreamChasersFleet)
                .WithInfo(147, 1, Artist.Simon_Dominic);
            addQuest("Fate of the Dream-chaser", EncounterSet.CoastOfUmbar, 2, 'A', Card.VALUE_NA)
                .WithTextLine("When Revealed: Each player assigns damage among non-Ship characters he controls equal to the total damage on each Ship objective he controls. Discard all Ship enemies, Ship objective and Ocean locations in play.")
                .WithFlavorLine("Suddenly, all of the beacons and lights along the watch-tower are snuffed as fog rolls in from the west. \"Pull up the sails!\" you hear, but it is too late. The Corsair ships turn at once, and the Dream-chaser smashes into the rocks. You are plunged into the cold waters, struggling to stay afloat.")
                .WithOppositeTextLine("When Revealed: Shuffle the Corsair deck and Corsair discard pile into the second encounter deck. Search the encounter deck and discard piule for each copy of Battle-hardened and each copy of Watch Tower, shuffle them into the second encounter deck. Set the current encounter deck and discard pil aside, inactive. The second encounter deck becomes the active encounter deck. Advance to stage 3.")
                .WithOppositeFlavorLine("Your ships have shattered upon the rocks. You barely manage to make it to shore.")
                .WithIncludedEncounterSets(EncounterSet.CorsairRaiders, EncounterSet.StormyWeather, EncounterSet.UmbarFleet, EncounterSet.VoyageAcrossBelegaer)
                .WithInfo(148, 1, Artist.Michael_Suchanek);
            addQuest("The Haven of Umbar", EncounterSet.TheCityOfCorsairs, 3, 'A', 18)
                .WithTextLine("When Revealed: Search the encounter deck for The Shattered Monument and Captain Sahír, and set them aside, out of play. Each player searches the encounter deck for 1 enemy and 1 location, and adds them to the staging area. If the Stormcaller was not destroyed at stage 1, add 1 resource to each Raider enemy in play.")
                .WithFlavorLine("The Dream-chaser and her fleet have met their ultimate fate, but you still have your mission to complete. Sahír is somewhere within the city.")
                .WithOppositeFlavorLine("\"Find them!\" You can here shouting throughout the city. Sahír has raised the alarm. Set upon on all sides by Corsairs, you must fight your way through and stop the captain.")
                .WithIncludedEncounterSets(EncounterSet.CorsairRaiders)
                .WithInfo(149, 1, Artist.Sergey_Glushakov);
            addQuest("Final Confrontation", EncounterSet.TheCityOfCorsairs, 4, 'A', Card.VALUE_NA)
                .WithTextLine("When Revealed: Add The Shattered Monument to the staging area. Put Captain Sahír into play, engaged with the first player. Each player searches the encounter deck and discard pile for an enemy and adds it to the staging area. Shuffle the encounter deck. Add 1 resource to each Raider enemy in play.")
                .WithFlavorLine("You chase Sahír through the streets, eventually cornering him in the broken monument atop a hill overlooking the city. He grins as you confront him. \"You're not easy to kill,\" he scoffs, and unsheaths a long dark blade.")
                .WithOppositeTextLine("While any enemy has resources on it, Captain Sahír is indestructible.")
                .WithOppositeTextLine("Forced: When a hero or enemy is destroyed, add its resources to Captain Sahír.")
                .WithOppositeTextLine("If Captain Sahír is destroyed, the players have finally put an end to the Corsair's treacherous plot and win the game.")
                .WithOppositeFlavorLine("Sahír cackles, a crazed look in his eyes. \"With the power of this sword, I will rule the seas from here to the Grey Havens!\"")
                .WithIncludedEncounterSets(EncounterSet.CorsairRaiders)
                .WithInfo(150, 1, Artist.Sara_Winters);
            addEnemy("Stormcaller", EncounterSet.CoastOfUmbar, 20, 2, 6, 6, 18)
                .WithUnique()
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 1.")
                .WithTextLine("Boarding 1. Cannot have attachments.")
                .WithTextLine("Forced: At the end of the round, if the Stormcaller is engaged with a player, either return it to the staging area or shift your heading off-course.")
                .WithVictoryPoints(10)
                .WithInfo(151, 1, Artist.Davis_Engel);
            addShipEnemy("Slave Ship", EncounterSet.CoastOfUmbar, 32, 3, 7, 5, 5)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 1.")
                .WithTextLine("Boarding 1. Cannot have attachments.")
                .WithTextLine("For each point of damage dealt to a Ship objective by Slave Ship's attack, deal 1 point of damage to a non-Ship character controlled by the defending player, as well.")
                .WithInfo(152, 2, Artist.Lukasz_Jaskolski);
            addEnemy("Umbar Slaver", EncounterSet.CoastOfUmbar, 28, 2, 2, 3, 5)
                .WithTraits("Corsair.", "Raider.")
                .WithTextLine("Corsair Slaver gets +1 Attack and +1 Threat for each resource on it.")
                .WithTextLine("Forced: After the engaged player spends any number of resources, place 1 of those resources on Umbar Slaver.")
                .WithEasyModeQuantity(1)
                .WithInfo(153, 3, Artist.Ramon_Puasa_Jr);
            addLocation("Southern Belfalas", EncounterSet.CoastOfUmbar, 3, 5)
                .WithTraits("Ocean.", "Coastland.")
                .WithTextLine("Travel: One player must reveal the top card of the Corsair deck and engage it to travel here.")
                .WithShadow("Shadow: If this attack destroys a character, discard an ally controlled by the defending player.")
                .WithInfo(154, 2, Artist.Nicholas_Gregory);
            addLocation("Corsair Waters", EncounterSet.CoastOfUmbar, 4, 3)
                .WithTraits("Ocean.", "Coastland.")
                .WithTextLine("While Corsair Waters is the active location, no more than 1 ally can enter play each round.")
                .WithShadow("Shadow: Either shift your heading off-course, or treat this attack as undefended.")
                .WithEasyModeQuantity(1)
                .WithInfo(155, 2, Artist.Simon_Dominic);
            addLocation("Watch Tower", EncounterSet.CoastOfUmbar, 2, 3)
                .WithTraits("Umbar.", "Coastland.")
                .WithTextLine("While Watch Tower is in the staging area, it gains: \"Forced: When a Raider enemy enters play, add 1 resource to it.\"")
                .WithShadow("Shadow: If this attack destroys an ally, add resources to a Raider enemy in play equal to that character's printed resource cost.")
                .WithEasyModeQuantity(1)
                .WithInfo(156, 2, Artist.Joshua_Cairos);
            addTreachery("Serpent's Tail", EncounterSet.CoastOfUmbar)
                .WithTextLine("When Revealed: Deal 1 shadow card to each Ship enemy in play. Then, if you are off-course (Cloudy, Rainy, Stormy), each Ship enemy in play gets -10 enagement cost until the end of the round.")
                .WithInfo(157, 2, Artist.Michael_Rasmussen);
            addEnemy("Captain Sahír", EncounterSet.TheCityOfCorsairs, 4, 6, 6, 2, 8)
                .WithUnique()
                .WithTraits("Corsair.", "Raider.", "Corrupt.")
                .WithTextLine("Captain Sahír engages the first player.")
                .WithTextLine("For each point of damage Captain Sahír would take, discard 1 resource from him and cancel that damage.")
                .WithTextLine("For every 5 resources on Captain Sahír, he makes an additional attack against the engaged player each combat phase.")
                .WithVictoryPoints(20)
                .WithInfo(158, 1, Artist.Sara_Winters);
            addLocation("The Shattered Monument", EncounterSet.TheCityOfCorsairs, 4, 8)
                .WithUnique()
                .WithTraits("Umbar.")
                .WithTextLine("Each Raider enemy with at least 1 resource on it is immune to player events.")
                .WithTextLine("Forced: At the beginning of the resource phase, add 1 resource to each Raider enemy in play.")
                .WithFlavorLine("So it stood, until after the second arising of Sauron, which now approached. Umbar fell under the dominion of his servants, and the memorial of his humiliation was thrown down.")
                .WithFlavorLine("-The Return of the King")
                .WithVictoryPoints(5)
                .WithInfo(159, 1, Artist.Mariusz_Gandzel);
            addLocation("Streets of Umbar", EncounterSet.TheCityOfCorsairs, 1, 5)
                .WithTraits("Umbar.", "City.")
                .WithTextLine("When faced with the option to travel, if Streets of Umbar is in the staging area, the players must either travel to a location named Streets of Umbar or add 2 resources to a Raider enemy in play.")
                .WithShadow("Shadow: If attacking enemy is a Raider, deal it an additional shadow card for each resource token on it, to a maximum of 3 additional shadow cards.")
                .WithInfo(160, 3, Artist.Sergey_Glushakov);
            addLocation("City of Corsairs", EncounterSet.TheCityOfCorsairs, Card.VALUE_X, 4)
                .WithTraits("Umbar.", "City.")
                .WithTextLine("X is the highest number of resources on a Raider enemy in play.")
                .WithTextLine("Travel: Search the encounter deck and discard pile for a Corsair enemy and add it to the staging area. Shuffle the encounter deck.")
                .WithEasyModeQuantity(1)
                .WithInfo(161, 2, Artist.Nicholas_Gregory);
            addLocation("Umbar Harbor", EncounterSet.TheCityOfCorsairs, 4, 4)
                .WithTraits("Umbar.", "City.")
                .WithTextLine("While Umbar Harbor is the active location, Corsair enemies get +2 Defense.")
                .WithShadow("Shadow: If attacking enemy is a Raider, move 1 resource from a hero you control to attacking enemy.")
                .WithEasyModeQuantity(2)
                .WithInfo(162, 3, Artist.Mariusz_Gandzel);
            addTreachery("Foes of Ecthelion", EncounterSet.TheCityOfCorsairs)
                .WithTextLine("When Revealed: Add 2 resources to a Raider enemy in the staging area. Each Raider enemy in the staging area gets +1 Threat for each resource on it until the end of the phase. If there are no Raider enemies in the staging area, Foes of Ecthelion gains surge.")
                .WithEasyModeQuantity(1)
                .WithInfo(163, 2, Artist.Mariusz_Gandzel);
            addTreachery("Umbar Patrol", EncounterSet.TheCityOfCorsairs)
                .WithTextLine("When Revealed: Each player returns an enemy engaged with him to the staging area. Until the end of the round, enemies cannot be optionally engaged. If there are no enemies in the staging area, search the encounter deck and discard pile for an enemy and add it to the staging area.")
                .WithInfo(164, 2, Artist.Michael_Suchanek);
            addTreachery("Fury and Malice", EncounterSet.TheCityOfCorsairs)
                .WithTextLine("When Revealed: Add 1 resource to each engaged Raider enemy. Then, each player assigns damage among characters he controls equal to the number of resource tokens on Raider enemies engaged with him. If no damage is assigned by this effect, Fury and Malice gains surge.")
                .WithEasyModeQuantity(2)
                .WithInfo(165, 3, Artist.Nikolas_Hagialas);
        }
    }
}
