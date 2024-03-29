/* Generated CardSet class: The Redhorn Gate */

using System;

namespace HallOfBeorn.Models.LotR.Sets.Dwarrowdelf
{
    public class TheRedhornGateSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Redhorn Gate";
            Abbreviation = "TRG";
            Number = 9;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dwarrowdelf";

            addHero("Elrohir", 10, Sphere.Leadership, 2, 2, 1, 4)
                .WithTraits("Noldor.", "Noble.", "Ranger.")
                .WithTextLine("While Elladan is in play, Elrohir gets +2 Defense.")
                .WithTextLine("Response: After Elrohir is declared as a defender, pay 1 resource from his resource pool to ready him.")
                .WithCommunityVersion("RiddermarkLord/Elrohir-Leadership-Hero")
                .WithInfo(1, 1, Artist.Magali_Villeneuve);
            addEvent("Taking Initiative", 0, Sphere.Leadership)
                .WithTextLine("Action: Discard the top card of your deck. If the discarded card's printed cost is equal to or higher than the number of characters you control, draw 2 cards and deal 2 damage to any enemy.")
                .WithInfo(2, 3, Artist.Melissa_Findley);
            addEvent("Timely Aid", 4, Sphere.Leadership)
                .WithKeywords("Secrecy 3.")
                .WithTextLine("Secrecy 3.")
                .WithTextLine("Action: Reveal the top 5 cards of your deck and put 1 revealed ally into play, if able. Shuffle all other revealed cards back into your deck.")
                .WithInfo(3, 3, Artist.Sandara_Tang);
            addEvent("Unseen Strike", 0, Sphere.Tactics)
                .WithTextLine("Action: Choose a character you control. Until the end of the phase, that character gets +3 Attack while attacking an enemy with a higher engagement cost than your threat.")
                .WithInfo(4, 3, Artist.Even_Mehl_Amundsen);
            addAttachment("Keeping Count", 0, Sphere.Tactics, false)
                .WithTextLine("Attach to a hero. Limit 1 per hero.")
                .WithTextLine("Attached hero gets +1 Attack for each resource token on another copy of Keeping Count that is above the current number of resource tokens on this card.")
                .WithTextLine("Forced: After attached hero attacks and destroys an enemy, place 1 resource token on this card.")
                .WithInfo(5, 3, Artist.Mark_Tarrisse);
            addAlly("Bofur", 3, Sphere.Spirit, true, 2, 1, 1, 3)
                .WithTraits("Dwarf.")
                .WithTextLine("Quest Action: Spend 1 Spirit resource to put Bofur into play from your hand, exhausted and committed to a quest. If you quest successfully this phase and Bofur is still in play, return him to your hand.")
                .WithFlavorLine("\"Get up lazy-bones...\" -The Hobbit")
                .WithInfo(6, 3, Artist.Ilich_Henriquez);
            addEvent("Renewed Friendship", 0, Sphere.Spirit)
                .WithTextLine("Response: After another player plays an attachment on a hero you control, you may (choose 1): ready 1 of that player's heroes, have that player draw 1 card, or lower that player's threat by 2.")
                .WithInfo(7, 3, Artist.Sara_Biddle);
            addAlly("Ravenhill Scout", 3, Sphere.Lore, false, 0, 1, 1, 3)
                .WithTraits("Dale.", "Scout.")
                .WithTextLine("Action: Exhaust Ravenhill Scout to move up to 2 progress tokens from 1 location to another location.")
                .WithFlavorLine("\"They made their first camp on the western side of the great southern spur, which ended in a height called Ravenhill.\" -The Hobbit")
                .WithInfo(8, 3, Artist.Garret_DeChellis);
            addEvent("Needful to Know", 2, Sphere.Lore)
                .WithKeywords("Secrecy 2.")
                .WithTextLine("Secrecy 2.")
                .WithTextLine("Action: Raise your threat by 1 to look at the top card of the encounter deck. Then, reduce your threat by X, where X is the threat of that card.")
                .WithInfo(9, 3, Artist.Magali_Villeneuve);
            addAttachment("Good Meal", 0, Sphere.Neutral, false)
                .WithTextLine("Attach to a Hobbit hero.")
                .WithTextLine("Action: Discard Good Meal to lower the cost of the next event you play this round that matches attached hero's sphere by 2.")
                .WithInfo(10, 3, Artist.David_A_Nash);
            addQuest("Up the Pass", "The Redhorn Gate", 1, 'A', 9)
                .WithTextLine("Setup: Add Caradhras to the staging area. Remove all copies of Snowstorm from the encounter deck and set them aside, out of play. Put Arwen Undomiel into play under the control of the first player.")
                .WithOppositeTextLine("When Revealed: Reveal 1 card from the encounter deck per player, and add it to the staging area.")
                .WithIncludedEncounterSets(EncounterSet.MistyMountains)
                .WithInfo(11, 1, Artist.Jason_Juta);
            addQuest("Snowdrifts", "The Redhorn Gate", 2, 'A', 11)
                .WithOppositeTextLine("When Revealed: Shuffle 1 more copy of Snowstorm into the encounter deck than the number of players.")
                .WithOppositeTextLine("Forced: After playing the 11th progress token on Snowdrifts, discard any active location. Caradhras becomes the active location.")
                .WithIncludedEncounterSets(EncounterSet.MistyMountains)
                .WithInfo(12, 1, Artist.Stu_Barnes);
            addQuest("The Mountains' Peaks", "The Redhorn Gate", 3, 'A', 13)
                .WithOppositeTextLine("When Revealed: Shuffle all copies of Snowstorm in the encounter discard pile back into the encounter deck.")
                .WithOppositeTextLine("Characters are discarded from play if their Willpower is ever 0.")
                .WithOppositeTextLine("Players cannot defeat this stage unless they have 5 victory points. If the players defeat this stage, they have won the game.")
                .WithIncludedEncounterSets(EncounterSet.MistyMountains)
                .WithInfo(13, 1, Artist.Cristi_Balanescu);
            addObjectiveAlly("Arwen Undómiel", "The Redhorn Gate", 2, 0, 1, 2)
                .WithUnique()
                .WithTraits("Noldor.", "Noble.", "Ally.")
                .WithTextLine("The first player gains control of Arwen Undomiel, as an ally.Response: After Arwen Undomiel exhausts, choose a hero. Add 1 resource to that hero's resource pool.If Arwen Undomiel leaves play, the players are defeated.")
                .WithInfo(14, 1, Artist.Magali_Villeneuve);
            addLocation("Caradhras", "The Redhorn Gate", 3, 9)
                .WithUnique()
                .WithTraits("Mountain.", "Snow.")
                .WithTextLine("While Caradhras is the active location, questing characters get -1 Willpower.")
                .WithTextLine("Players cannot travel to Caradhras except by quest card effects.")
                .WithVictoryPoints(3)
                .WithInfo(15, 1, Artist.Cristi_Balanescu);
            addLocation("Fanuidhol", "The Redhorn Gate", 3, 7)
                .WithUnique()
                .WithTraits("Mountain.", "Snow.")
                .WithTextLine("While Fanuidhol is the active loction, heroes must spend 1 resource from their resource pool to count their Willpower during the quest phase.")
                .WithVictoryPoints(2)
                .WithInfo(16, 1, Artist.Cristi_Balanescu);
            addLocation("Celebdil", "The Redhorn Gate", 3, 7)
                .WithUnique()
                .WithTraits("Mountain.", "Snow.")
                .WithTextLine("While Celebdil is the active location, remove 2 progress tokens from it at the end of each round.")
                .WithVictoryPoints(2)
                .WithInfo(17, 1, Artist.Cristi_Balanescu);
            addLocation("The Dimrill Stair", "The Redhorn Gate", 2, 3)
                .WithUnique()
                .WithTraits("Stair.")
                .WithTextLine("Travel: Reshuffle all locations in the discard pile and victory display back into the encounter deck. If you reshuffled at least two locations, reduce each player's threat by 11 and discard all copies of Freezing Cold from play.")
                .WithVictoryPoints(1)
                .WithInfo(18, 1, Artist.Trudi_Castle);
            addLocation("Rocky Crags", "The Redhorn Gate", 4, 2)
                .WithTraits("Mountain.")
                .WithTextLine("Travel: Each player must deal 2 damage to 1 character he controls to travel here.")
                .WithShadow("Shadow: attacking enemy gets +1 Attack for each progress token on the active location.")
                .WithEasyModeQuantity(1)
                .WithInfo(19, 3, Artist.David_Lecossu);
            addTreachery("Fell Voices", "The Redhorn Gate")
                .WithTextLine("When Revealed: Return the top 2 Snow cards in the encounter discard pile to the top of the encounter deck. If this effect returned less than 2 Snow treachery cards, Fell Voices gains surge.")
                .WithInfo(20, 2, Artist.K_R_Harris);
            addTreachery("Fallen Stones", "The Redhorn Gate")
                .WithTextLine("When Revealed: The first player (choose 1): removes all progress tokens from play, or reveals 2 cards from the encounter deck and adds them to the staging area.")
                .WithShadow("Shadow: attacking enemy gets +1 Attack for each progress token on the active location.")
                .WithInfo(21, 2, Artist.Cristi_Balanescu);
            addTreachery("Snowstorm", "The Redhorn Gate")
                .WithTraits("Snow.")
                .WithTextLine("When Revealed: Each questing character gets -1 Willpower until the end of the phase.")
                .WithShadow("Shadow: Until the end of the phase, characters defending this attack get -1 Willpower and are discarded if their Willpower is 0.")
                .WithInfo(22, 5, Artist.David_Lecossu);
            addTreachery("Freezing Cold", "The Redhorn Gate")
                .WithTraits("Snow.")
                .WithTextLine("When Revealed: The first player attaches this card to a hero he controls. Counts as a Condition Attachment with the text: 'Attached hero gets -2 Willpower and cannot commit to a quest. If attached hero has more than 1 copy of Freezing Cold attached, discard attached hero from play.'")
                .WithEasyModeQuantity(1)
                .WithInfo(23, 3, Artist.Eric_Braddock);
            addTreachery("Avalanche!", "The Redhorn Gate")
                .WithTraits("Snow.")
                .WithTextLine("When Revealed: Exhaust each ready character and if it is the quest phase commit them to the quest.")
                .WithEasyModeQuantity(0)
                .WithInfo(24, 1, Artist.David_Lecossu);
            addEnemy("Mountain Goblin", "The Redhorn Gate", 25, 1, 2, 2, 3)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("~Mountain Goblin gets +1 Attack for each Mountain location in the staging area.")
                .WithShadow("Shadow: attacking enemy gets +1 Attack. (+2 Attack instead if the active location is a Mountain.)")
                .WithInfo(25, 3, Artist.Dmitry_Burmak);
            addEnemy("Mountain Troll", "The Redhorn Gate", 35, 2, 5, 5, 7)
                .WithTraits("Troll.")
                .WithTextLine("~Mountain ~Troll gets +1 Attack for each Mountain location in the staging area.")
                .WithShadow("Shadow: attacking enemy gets +1 Attack. (+2 Attack instead if the active location is a Mountain.)")
                .WithEasyModeQuantity(0)
                .WithInfo(26, 2, Artist.Rafal_Hrynkiewicz);
            addEnemy("Snow Warg", "The Redhorn Gate", 28, 3, 3, 1, 4)
                .WithTraits("Creature.", "Snow.")
                .WithTextLine("Allies cannot defend while ~Snow ~Warg is attacking.")
                .WithTextLine("Forced: After a character is declared as a defender against ~Snow ~Warg, deal 1 damage to the defending character, if able.")
                .WithErrata(1)
                .WithInfo(27, 3, Artist.Allison_Theus);
        }
    }
}
