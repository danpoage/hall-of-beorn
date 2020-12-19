using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.VengeanceOfMordor
{
    public class TheFortressOfNurnSet
        : CardSet
    {
        public const string setName = "The Fortress of Nurn";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TFoN";
            Number = 62;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Vengeance of Mordor";

            addHero("Aragorn", 12, Sphere.Spirit, 2, 3, 2, 5)
                .WithTraits("Dúnedain.", "Ranger.", "Scout.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Action: Exhaust Aragorn to choose a location in the staging area. Until the end of the phase, that location gets -X Threat, where X is Aragorn's Willpower. If this effect reduces the location's Threat to 0, place 1 progress on it. (Limit once per round.)")
                .WithCommunityVersion("Autumn/Aragorn-Spirit-Hero")
                .WithInfo(137, 1, Artist.Aleksander_Karcz);
            addAttachment("Shining Shield", 1, Sphere.Leadership, false)
                .WithTraits("Armor.", "Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Noble hero. Limit 1 per hero.")
                .WithTextLine("Restricted.")
                .WithTextLine("Attached hero gets +1 Defense (+2 Defense instead if your threat is 40 or higher).")
                .WithFlavorLine("...his shinning shield was scored with runs...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(138, 3, Artist.Alvaro_Calvo_Escudero);
            addEvent("Knowledge of the Enemy", 0, Sphere.Leadership)
                .WithTextLine("Planning Action: Choose a hero you control. Add 1 resource to its resource pool for each enemy engaged with you. You can only play 1 Knowledge of the Enemy each round.")
                .WithFlavorLine("\"If a man must needs walk in sight of the Black Gate, or tread the deadly flowers of Morgul Vale, then perils he will have.\"")
                .WithFlavorLine("-Aragorm, The Fellowship of the Ring")
                .WithInfo(139, 3, Artist.Kevin_Zamir_Goeke);
            addAlly("Haleth", 4, Sphere.Lore, true, 2, 2, 1, 3)
                .WithTraits("Woodman.", "Scout.")
                .WithTextLine("Response: After Haleth quests successfully, search the top 5 cards of your deck for an attachment and add it to your hand. Shuffle your deck.")
                .WithCommunityVersion("Autumn/Haleth-MotK")
                .WithInfo(140, 3, Artist.Kevin_Zamir_Goeke);
            addEvent("Woodman Lore", 1, Sphere.Lore)
                .WithTextLine("Action: Ready up to X Woodman characters you control, where X is the number of locations with player card attachments.")
                .WithFlavorLine("The Woodman said that there was some new terror abroad...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(141, 3, Artist.Alyn_Spiller);
            addAlly("Westfold Lancer", 3, Sphere.Tactics, false, 2, 2, 0, 2)
                .WithTraits("Rohan.", "Warrior.")
                .WithTextLine("Response: After Westfold Lancer quests successfully, discard it to choose a non-unique enemy in the staging area. Deal 2 damage to the chosen enemy.")
                .WithFlavorLine("...the white fury of the Northmen burned the hotter, and more skilled was their knighthood with long spears...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(142, 3, Artist.Stanislav_Dikolenko);
            addAttachment("Tireless Thoroughbred", 2, Sphere.Tactics, false)
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Warrior character.")
                .WithTextLine("Restricted.")
                .WithTextLine("Attached character gains ranged and sentinel.")
                .WithFlavorLine("Then he leapt forward, spurring the earth, and was gone like the north wine from the mountains.")
                .WithFlavorLine("-The Two Towers.")
                .WithInfo(143, 3, Artist.Carlos_Palma_Cruchaga);
            addAlly("Misty Mountain Journeyman", 1, Sphere.Spirit, false, 2, 0, 0, 1)
                .WithTraits("Dúnedain.", "Scout.")
                .WithTextLine("You cannot play Misty Mountain Journeyman from your hand unless you are engaged with an enemy.")
                .WithFlavorLine("Rangers passed at times beyond the hills, but they were few and did not stay.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(144, 3, Artist.Aleksander_Karcz);
            addEvent("A Desperate Path", 2, Sphere.Spirit)
                .WithTextLine("At the end of the staging step, discard cards from the top of the encounter deck until you discard a treachery. Resolve its 'when revealed' effects to ready each of your questing characters. Each of your questing characters gets +1 Willpower until the end of the phase.")
                .WithInfo(145, 3, Artist.Aleksander_Karcz);
            addAttachment("Thorongil", 3, Sphere.Neutral, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a non-Fellowship, non-Baggins hero you control.")
                .WithTextLine("Response: After you attach Thorongil to a hero, search your collection for a different non-Fellowship, non-Baggins version of that hero and attach it to Thorongil. While Thorongil is in play, attached hero gains the game text and resource icon of the attached hero card. If Thorongil leaves play, remove the hero card attached to it from the game.")
                .WithInfo(146, 3, Artist.Chris_Grun);
            addContract("Bond of Friendship")
                .WithTextLine("Your deck must be exactly 50 players cards and include exactly 10 cards from each of these four spheres: Leadership, Lore, Spirit, and Tactics. You cannot include more than 2 copies of any card by title in your deck.")
                .WithTextLine("When choosing your starting heroes, you may choose 4 heroes instead of 3. Each of your heroes must belong to a different sphere.")
                .WithFlavorLine("\"You can trust us to stick to you through think and thin - to the bitter end.\"")
                .WithFlavorLine("-Merry, The Fellowship of the Ring")
                .WithInfo(147, 1, Artist.Borja_Pindado);
            addEnemy("Thane Ulchor", EncounterSet.TheFortressOfNurn, 0, Card.VALUE_X, 6, 4, 12)
                .WithUnique()
                .WithTraits("Mordor.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("X is 1 more than the number of Castle side quests in the victory display.")
                .WithTextLine("Forced: After Thane Ulchor attacks, reveal the top card of the encounter deck.")
                .WithVictoryPoints(6)
                .WithInfo(148, 1, Artist.Michele_Frigo);
            addEnemy("Soldier of Nurn", EncounterSet.TheFortressOfNurn, 28, 2, 3, 1, 4)
                .WithTraits("Mordor.")
                .WithTextLine("Forced: After Soldier of Nurn attacks, place 1 card from your hand facedown under a Castle side quest.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, place 1 card from your hand facedown under a Castle side quest.")
                .WithInfo(149, 3, Artist.Daniel_Zrom);
            addEnemy("Easterling Mercenary", EncounterSet.TheFortressOfNurn, 32, 3, 4, 2, 3)
                .WithTraits("Easterling.")
                .WithTextLine("When Revealed: Either reveal an additional encounter card, or no progress can be placed on the current quest this phase.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each Castle side quest in the victory display.")
                .WithEasyModeQuantity(1)
                .WithInfo(150, 2, Artist.Nikolas_Hagialas);
            addEnemy("Mordor Olog-hai", EncounterSet.TheFortressOfNurn, 34, 4, 6, 3, 9)
                .WithTraits("Troll.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Forced: After Mordor Olog-hai attacks and destroys a character you control, exhaust a character you control.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(151, 2, Artist.Matthew_Cowdery);
            addEnemy("Guard Dogs", EncounterSet.TheFortressOfNurn, 12, 1, 2, 1, 2)
                .WithTraits("Creature.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Forced: After Guard Dogs engages you, deal 1 damage to a character you control.")
                .WithShadow("Shadow: Put Guard Dogs into play engaged with you.")
                .WithEasyModeQuantity(1)
                .WithInfo(152, 3, Artist.Carlos_Palma_Cruchaga);
            addLocation("Fortress Walls", EncounterSet.TheFortressOfNurn, 3, 6)
                .WithTraits("City.")
                .WithTextLine("While Fortress Walls is in the staging area, the cost to play each ally is increased by 1.")
                .WithTextLine("Travel: Each player places 1 card from his hand under a Castle side quest.")
                .WithEasyModeQuantity(1)
                .WithInfo(153, 2, Artist.Federico_Musetti);
             addLocation("Guard Tower", EncounterSet.TheFortressOfNurn, 2, 4)
                .WithTraits("City.")
                .WithTextLine("While Guard Tower is in the staging area, players cannot draw cards or gain resources from player card effects.")
                .WithTextLine("Travel: Each player exhausts a character he controls.")
                .WithInfo(154, 3, Artist.Frej_Agelii);
             addLocation("Plaza of Nurn", EncounterSet.TheFortressOfNurn, Card.VALUE_X, 5)
                 .WithTraits("City.")
                 .WithTextLine("X is 1 more than the number of Castle side quests in the victory display.")
                 .WithTextLine("Travel: Each player assigns X damage characters he controls.")
                 .WithFlavorLine("...nothing could waft away the glooms and the sad mists that clung about...")
                 .WithFlavorLine("-The Return of the King")
                 .WithEasyModeQuantity(2)
                 .WithInfo(155, 3, Artist.Kamila_Szutenberg);
              addTreachery("Determined Defense", EncounterSet.TheFortressOfNurn)
                  .WithTextLine("When Revealed: Until the end of the phase, add 2 Threat to the staging area. Add 2 additional Threat for each Castle side quest in the victory display.")
                  .WithShadow("Shadow: Exhaust a character you control.")
                  .WithInfo(156, 3, Artist.Tropa_Entertainment);
              addTreachery("The Dark Lord's Reach", EncounterSet.TheFortressOfNurn)
                  .WithTextLine("When Revealed: Deal 1 damage to each exhausted character. Discard an attachment from each character damaged by this effect.")
                  .WithShadow("Shadow: Discard an attachment you control.")
                  .WithFlavorLine("\"His arm has grown long.\"")
                  .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                  .WithEasyModeQuantity(1)
                  .WithInfo(157, 2, Artist.Federico_Musetti);
              addEncounterSideQuest("The Dungeons of Dol Rhugar", EncounterSet.TheFortressOfNurn, 4)
                  .WithFlavorLine("The dungeons of Dol Rhugar are full of prisoners with no hope of escape.")
                  .WithKeywords("Surge.")
                  .WithTextLine("Surge.")
                  .WithTextLine("No more than 4 progress can be placed on the current quest each round.")
                  .WithTextLine("Response: When this stage is defeated, the first player chooses a Castle side quest. Each player looks at his facedown cards under that quest and adds 1 to his hand.")
                  .WithVictoryPoints(10)
                  .WithInfo(158, 1, Artist.Andreia_Ugrai);
               addQuest("Assault on Dol Rhugar", EncounterSet.TheFortressOfNurn, 1, 'A', 3)
                   .WithFlavorLine("Your quest to defeat Thane Ulchor has brought you to his stronghold in Mordor.")
                   .WithTextLine("Setup: Player decks cannot exceed 50 cards. Create the Power of Mordor deck (see insert) and set it next to the quest deck. Each player puts 1 copy of Ulchor's Guard into play engaged with him. Add Thane Ulchor and all 4 copies of the Storm the Castle side quest to the staging area. Place the top card of the Power of Mordor deck faceup under each side quest in play. Each player places 8 cards from top of his deck under the quest deck and each side quest in play.")
                   .WithOppositeFlavorLine("You lead an army of rescued slaves in a surprise attack on Ulchor's fortress.")
                   .WithOppositeTextLine("Thane Ulchor cannot leave the staging area.")
                   .WithOppositeTextLine("While there are at least 3 progress tokens on this stage, it cannot be chosen as the current quest stage during the quest phase.")
                   .WithOppositeTextLine("This stage cannot be defeated unless it is the end of the round and there are 3 Castle side quests in the victory display.")
                   .WithIncludedEncounterSets(EncounterSet.UlchorsGuard, EncounterSet.UnderGuard , EncounterSet.ThePowerOfMordor)
                   .WithInfo(159, 1, Artist.Piotr_Arendzikowski);
                addQuest("The Final Confrontation", EncounterSet.TheFortressOfNurn, 2, 'A', 12)
                    .WithFlavorLine("You have reached the great hall inside Dol Rhugar. There you find Ulchor, Thane of Nurn, waiting for you. \"You arrogant fools!\" he says, rising to his full height. \"You have pursued me all this way only to die here where my power is at its strongest!\"")
                    .WithTextLine("When Revealed: Reveal the top card of The Power of Mordor deck. Shuffle the encounter discard pile into the encounter deck. Thane Ulchor makes an immediate attack against each player in turn order.")
                    .WithOppositeFlavorLine("Ulchor strikes at you with undeniable power, but you hold your ground. You will either see him finally brought low, or die valiantly in the attempt.")
                    .WithOppositeTextLine("Encounter card effects cannot be canceled.")
                    .WithOppositeTextLine("The number of damage tokens on Than Ulchor cannot exceed the number of progress tokens here.")
                    .WithOppositeTextLine("When Thane Ulchor is defeated, the players win the game.")
                    .WithIncludedEncounterSets(EncounterSet.UlchorsGuard, EncounterSet.UnderGuard , EncounterSet.ThePowerOfMordor)
                    .WithInfo(160, 1, Artist.Michele_Frigo);
                addEncounterSideQuest("Storm the Castle", EncounterSet.TheFortressOfNurn, 6)
                    .WithOppositeTitle("Castle Garrison")
                    .WithTraits("Castle.")
                    .WithFlavorLine("You charge into the castle, not knowing what you will find within...")
                    .WithTextLine("The faceup encounter card underneath this quest is not in play.")
                    .WithTextLine("Forced: When this quest becomes the current quest, reveal the faceup encounter card under it. Then, flip this card ovewr and make it the current quest until the end of the phase.")
                    .WithOppositeTextLine("When Revealed: Discard cards from the top of the encounter deck until X enemies are discarded, where X is the number of players. Add each enemy discarded this way to the staging area.")
                    .WithOppositeTextLine("When this stage is defeated, shuffle each player card underneath it into its owner's deck. Then, each player draws 1 card.")
                    .WithVictoryPoints(10)
                    .WithBackArtist(Artist.Martin_de_Diego_Sadaba)
                    .WithInfo(161, 1, Artist.Tropa_Entertainment);
                addEncounterSideQuest("Storm the Castle", EncounterSet.TheFortressOfNurn, 10)
                    .WithOppositeTitle("Lethal Counterattack")
                    .WithTraits("Castle.")
                    .WithFlavorLine("You charge into the castle, not knowing what you will find within...")
                    .WithTextLine("The faceup encounter card underneath this quest is not in play.")
                    .WithTextLine("Forced: When this quest becomes the current quest, reveal the faceup encounter card under it. Then, flip this card ovewr and make it the current quest until the end of the phase.")
                    .WithOppositeTextLine("When Revealed: Deal 1 damage to each character in play.")
                    .WithOppositeTextLine("When this stage is defeated, shuffle each player card underneath it into its owner's deck. Then, each player draws 1 card.")
                    .WithVictoryPoints(10)
                    .WithBackArtist(Artist.Kamila_Szutenberg)
                    .WithInfo(162, 1, Artist.Tropa_Entertainment);
                addEncounterSideQuest("Storm the Castle", EncounterSet.TheFortressOfNurn, 12)
                    .WithOppositeTitle("No Quarter")
                    .WithTraits("Castle.")
                    .WithFlavorLine("You charge into the castle, not knowing what you will find within...")
                    .WithTextLine("The faceup encounter card underneath this quest is not in play.")
                    .WithTextLine("Forced: When this quest becomes the current quest, reveal the faceup encounter card under it. Then, flip this card ovewr and make it the current quest until the end of the phase.")
                    .WithOppositeTextLine("When Revealed: Each player randomly discards 4 of his cards from under this quest. Then, each player discards each card he controls, or holds in his hand, that share a title with one of the cards he just discarded.")
                    .WithOppositeTextLine("When this stage is defeated, shuffle each player card underneath it into its owner's deck. Then, each player draws 1 card.")
                    .WithVictoryPoints(10)
                    .WithBackArtist(Artist.Mauro_Dal_Bo)
                    .WithInfo(163, 1, Artist.Tropa_Entertainment);
                addEncounterSideQuest("Storm the Castle", EncounterSet.TheFortressOfNurn, 8)
                    .WithOppositeTitle("Stronghold of Mordor")
                    .WithTraits("Castle.")
                    .WithFlavorLine("You charge into the castle, not knowing what you will find within...")
                    .WithTextLine("The faceup encounter card underneath this quest is not in play.")
                    .WithTextLine("Forced: When this quest becomes the current quest, reveal the faceup encounter card under it. Then, flip this card ovewr and make it the current quest until the end of the phase.")
                    .WithOppositeTextLine("When Revealed: Discard cards from the top of the encounter deck until X locations are discarded, where X is the number of players. Added each location discarded this way to the staging area.")
                    .WithOppositeTextLine("When this stage is defeated, shuffle each player card underneath it into its owner's deck. Then, each player draws 1 card.")
                    .WithVictoryPoints(10)
                    .WithBackArtist(Artist.Kamila_Szutenberg)
                    .WithInfo(164, 1, Artist.Tropa_Entertainment);
        }
    }
}