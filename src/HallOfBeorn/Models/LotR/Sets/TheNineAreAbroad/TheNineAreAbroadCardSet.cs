//CardSet: The Nine are Abroad
/* Generated CardSet class: The Nine are Abroad */

using System;

namespace HallOfBeorn.Models.LotR.Sets.TheNineAreAbroad
{
    public class TheNineAreAbroadSet : CardSet
    {

        public const string setName = "The Nine are Abroad";
        public const string regionEncounterSet = "Region";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TNaA";
            Number = 8;
            SetType = Models.SetType.A_Long_extended_Party;

            addRegion("The Blue Mountains", regionEncounterSet)
                .WithTraits("Coastland.", "Dwarf.", "Lossoth.")
                .WithSetNumberAndCost(1, null)
                .WithInfo(1, 1, Artist.In_The_Reads);
            addRegion("Arnor", regionEncounterSet)
                .WithTraits("Road.", "Dúnedain.")
                .WithSetNumberAndCost(2, null)
                .WithInfo(2, 1, Artist.In_The_Reads);
            addRegion("Rhovanion", regionEncounterSet)
                .WithTraits("River.", "Dale.", "Eagle.", "Beorning.")
                .WithSetNumberAndCost(3, null)
                .WithInfo(3, 1, Artist.In_The_Reads);
            addRegion("Harlindon", regionEncounterSet)
                .WithTraits("Coastland.", "Noldor.")
                .WithSetNumberAndCost(4, null)
                .WithInfo(4, 1, Artist.In_The_Reads);
            addRegion("Eriador", regionEncounterSet)
                .WithTraits("Road.", "Hobbit.", "Bree.")
                .WithSetNumberAndCost(5, null)
                .WithInfo(5, 1, Artist.In_The_Reads);
            addRegion("Mirkwood", regionEncounterSet)
                .WithTraits("River.", "Silvan.", "Woodman.")
                .WithSetNumberAndCost(6, null)
                .WithInfo(6, 1, Artist.In_The_Reads);
            addRegion("Enedwaith", regionEncounterSet)
                .WithTraits("Road.", "Isengard.", "Dunland.")
                .WithSetNumberAndCost(7, null)
                .WithInfo(7, 1, Artist.In_The_Reads);
            addRegion("Rohan", regionEncounterSet)
                .WithTraits("River.", "Rohan.", "Ent.")
                .WithSetNumberAndCost(8, null)
                .WithInfo(8, 1, Artist.In_The_Reads);
            addRegion("The Outlands", regionEncounterSet)
                .WithTraits("Coastland.", "Outlands.", "Corsair.")
                .WithSetNumberAndCost(9, null)
                .WithInfo(9, 1, Artist.In_The_Reads);
            addRegion("Gondor", regionEncounterSet)
                .WithTraits("Coastland.", "Gondor.", "Wose.", "Harad.")
                .WithSetNumberAndCost(10, null)
                .WithInfo(10, 1, Artist.In_The_Reads);
            addQuest("Search for the Nine", EncounterSet.TheNineAreAbroad, 1, 'A', Card.VALUE_NA)
                .WithTextLine("Setup: Assemble the Middle-earth Map. Place 1 progress token on the region that shares a Trait with the greatest number of heroes. This is your current region. Set Chief of the Nine aside, out of play. Put Shadows of Terror into play, Abroad side faceup. Choose a player to take control of Dúnedain Tracker, Standard side faceup. If there are 2 or more groups, flip it to the Epic side, and familiarize yourself with the treachery called The Nine Are Abroad. Each player searches the encounter deck for a non-unique location and reveals it. Shuffle the encounter deck.")
                .WithOppositeTextLine("Forced: After placing a third resource token on a region, remove 3 resource tokens from it. Then, shuffle the encounter discard pile into the encounter deck and discard cards until a Nazgûl enemy is discarded and place it on that region. Tell each other group to search their encounter deck and discard pile for the same enemy, place it on their copy of that region, and shuffle their encounter deck. Do not trigger the “when revealed” effects on these enemies.")
                .WithOppositeTextLine("When the number of Nazgûl enemies in play matches the number of groups, advance to stage 2A at the end of the current phase.")
                .WithInfo(11, 1, Artist.Unknown);
            addQuest("To Mordor We Will Send Them", EncounterSet.TheNineAreAbroad, 2, 'A', Card.VALUE_NA)
                .WithTextLine("When Revealed: Remove all resource tokens from each region. Flip Shadows of Terror over, Found side faceup. Attach the set aside Chief of the Nine objective to the Nazgûl enemy that entered play last. That enemy is “the Witch-king”. If there are other groups, take a moment to strategize with them about who will handle each Nazgûl enemy.")
                .WithFlavorLine("The rumors were true! The dreaded Witch-king of Angmar once again walks Middle-earth, driven by some fell purpose.")
                .WithOppositeTextLine("When calculating the remaining hit points of a Nazgûl enemy, add up all damage on each copy of that enemy among all groups.")
                .WithOppositeTextLine("Forced: When you would investigate rumors, each player draws 1 card instead.")
                .WithOppositeTextLine("If there are no Nazgûl enemies in play, the players win the game.")
                .WithOppositeFlavorLine("The Nazgûl cannot be allowed to pursue their aims unhindered. You must disrupt their plans and send them back to their master.")
                .WithInfo(12, 1, Artist.Turbine);
            addObjective("Chief of the Nine", EncounterSet.TheNineAreAbroad)
                .WithTraits("Nazgûl.")
                .WithTextLine("The Witch-king gets +5 Threat, +2 Attack, and its attacks are immune to sentinel. Your group cannot deal it more than 5Per Player damage per round, and it cannot be defeated while there are other Nazgûl enemies in play.")
                .WithTextLine("Instead of its printed hit points, the Witch-king has 10 hit points for each group, plus 5 hit points for each player among all groups.")
                .WithInfo(13, 1, Artist.Anato_Finnstark);
            addObjective("Shadows of Terror", EncounterSet.TheNineAreAbroad)
                .WithSlugSuffix("Abroad")
                .WithSideA()
                .WithTraits("Abroad.")
                .WithTextLine("Nazgûl enemies are immune to player card effects and cannot be optionally engaged.")
                .WithTextLine("Forced: The first time a Nazgûl enemy is revealed each round, the first player must trigger its shadow effect.")
                .WithFlavorLine("“My news is evil.” Then he looked about him, as if the hedges might have ears. “Nazgûl,” he whispered. “The Nine are abroad again.”")
                .WithFlavorLine("—Radagast, The Fellowship of the Ring")
                .WithInfo(14, 1, Artist.Guglielmo_Simonini);
            addObjective("Shadows of Terror", EncounterSet.TheNineAreAbroad)
                .WithSlugSuffix("Found")
                .WithSideB()
                .WithTraits("Found.")
                .WithTextLine("Nazgûl enemies are immune to player card effects and cannot be optionally engaged. Nazgûl enemies on your current region are considered to be engaged with each player.")
                .WithTextLine("Forced: After a Nazgûl enemy attacks, it triggers its own shadow effect.")
                .WithTextLine("Forced: At the end of the round, each player triggers the Witch-king’s shadow effect.")
                .WithInfo(14, 1, Artist.Guglielmo_Simonini);
            addObjectiveAlly("Dúnedain Tracker", EncounterSet.TheNineAreAbroad, 2, 1, 1, 3)
                .WithSlugSuffix("Standard")
                .WithSideA()
                .WithTraits("Dúnedain.", "Scout.", "Standard.")
                .WithTextLine("Cannot quest. If Dúnedain Tracker leaves play, remove it from the game.")
                .WithTextLine("Planning Action: Exhaust Dúnedain Tracker to reveal the bottommost location in the encounter discard pile.")
                .WithTextLine("Action: Discard Dúnedain Tracker to move 1 resource token from your current region to a neighboring region.")
                .WithInfo(15, 1, Artist.JanPhilipp_Eckert);
            addObjectiveAlly("Dúnedain Tracker", EncounterSet.TheNineAreAbroad, 2, 1, 1, 3)
                .WithSlugSuffix("Epic")
                .WithSideB()
                .WithTraits("Dúnedain.", "Scout.", "Epic.")
                .WithTextLine("Cannot quest. If Dúnedain Tracker leaves play, remove it from the game.")
                .WithTextLine("Planning Action: Exhaust Dúnedain Tracker to reveal the bottommost location in the encounter discard pile.")
                .WithTextLine("Action: Discard Dúnedain Tracker to move 1 resource token from a region in your map to a copy of that region in another group’s map.")
                .WithInfo(15, 1, Artist.JanPhilipp_Eckert);
            addObjective("Nameless Fear", EncounterSet.TheNineAreAbroad)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Place Nameless Fear between Eriador and Mirkwood. Cannot be canceled.")
                .WithTextLine("Forced: After your group moves between Eriador and Mirkwood, add Nameless Fear to the victory display. Then, deal 5 damage to 1 hero the players control.")
                .WithVictoryPoints(5)
                .WithInfo(16, 1, Artist.Anato_Finnstark);
            addObjective("Birds of Ill Omen", EncounterSet.TheNineAreAbroad)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Place Birds of Ill Omen between Enedwaith and Rohan. Cannot be canceled.")
                .WithTextLine("Forced: After your group moves between Enedwaith and Rohan, trigger doomed 2.")
                .WithInfo(17, 1, Artist.Pamela_Shanteau);
            addEnemy("The First Rider", EncounterSet.TheNineAreAbroad, 50, 0, 6, 6, 20)
                .WithUnique()
                .WithTraits("Nazgûl.")
                .WithTextLine("When Revealed: This card gains surge. Discard this card.")
                .WithTextLine("Rumor: Each player must trigger this card’s shadow effect. Choose either the region east or west of your current region and place 1 resource token on it.")
                .WithShadow("Shadow: Raise your threat by 1.")
                .WithInfo(18, 1, Artist.Anato_Finnstark);
            addEnemy("The Second Rider", EncounterSet.TheNineAreAbroad, 50, 0, 6, 6, 20)
                .WithUnique()
                .WithTraits("Nazgûl.")
                .WithTextLine("When Revealed: This card gains surge. Discard this card.")
                .WithTextLine("Rumor: Each player must trigger this card’s shadow effect. Choose either the region north or south of your current region and place 1 resource token on it.")
                .WithShadow("Shadow: Discard 1 resource from the pool of each hero you control.")
                .WithInfo(19, 1, Artist.Anato_Finnstark);
            addEnemy("The Third Rider", EncounterSet.TheNineAreAbroad, 50, 0, 6, 6, 20)
                .WithUnique()
                .WithTraits("Nazgûl.")
                .WithTextLine("When Revealed: This card gains surge. Discard this card.")
                .WithTextLine("Rumor: Each player must trigger this card’s shadow effect. Choose either the region northeast or southwest of your current region and place 1 resource token on it.")
                .WithShadow("Shadow: Exhaust 1 hero you control.")
                .WithInfo(20, 1, Artist.Anato_Finnstark);
            addEnemy("The Fourth Rider", EncounterSet.TheNineAreAbroad, 50, 0, 6, 6, 20)
                .WithUnique()
                .WithTraits("Nazgûl.")
                .WithTextLine("When Revealed: This card gains surge. Discard this card.")
                .WithTextLine("Rumor: Each player must trigger this card’s shadow effect. Choose either the region southeast or northwest of your current region and place 1 resource token on it.")
                .WithShadow("Shadow: Discard 1 random card from your hand.")
                .WithInfo(21, 1, Artist.Anato_Finnstark);
            addEnemy("The Fifth Rider", EncounterSet.TheNineAreAbroad, 50, 0, 6, 6, 20)
                .WithUnique()
                .WithTraits("Nazgûl.")
                .WithTextLine("When Revealed: This card gains surge. Discard this card.")
                .WithTextLine("Rumor: Each player must trigger this card’s shadow effect. Choose either the region north or south of your current region and place 1 resource token on it.")
                .WithShadow("Shadow: Deal 2 damage to a character you control.")
                .WithInfo(22, 1, Artist.Anato_Finnstark);
            addEnemy("The Sixth Rider", EncounterSet.TheNineAreAbroad, 50, 0, 6, 6, 20)
                .WithUnique()
                .WithTraits("Nazgûl.")
                .WithTextLine("When Revealed: This card gains surge. Discard this card.")
                .WithTextLine("Rumor: Each player must trigger this card’s shadow effect. Choose either the region east or west of your current region and place 1 resource token on it.")
                .WithShadow("Shadow: Discard an attachment you control.")
                .WithInfo(23, 1, Artist.Anato_Finnstark);
            addEnemy("The Seventh Rider", EncounterSet.TheNineAreAbroad, 50, 0, 6, 6, 20)
                .WithUnique()
                .WithTraits("Nazgûl.")
                .WithTextLine("When Revealed: This card gains surge. Discard this card.")
                .WithTextLine("Rumor: Each player must trigger this card’s shadow effect. Choose either the region northeast or southwest of your current region and place 1 resource token on it.")
                .WithShadow("Shadow: Choose 1 ready ally you control. Exhaust it and deal 1 damage to it.")
                .WithInfo(24, 1, Artist.Anato_Finnstark);
            addEnemy("The Eighth Rider", EncounterSet.TheNineAreAbroad, 50, 0, 6, 6, 20)
                .WithUnique()
                .WithTraits("Nazgûl.")
                .WithTextLine("When Revealed: This card gains surge. Discard this card.")
                .WithTextLine("Rumor: Each player must trigger this card’s shadow effect. Choose either the region southeast or northwest of your current region and place 1 resource token on it.")
                .WithShadow("Shadow: Discard the top card of your deck, then discard 1 copy of that card from play.")
                .WithInfo(25, 1, Artist.Anato_Finnstark);
            addEnemy("The Ninth Rider", EncounterSet.TheNineAreAbroad, 50, 0, 6, 6, 20)
                .WithUnique()
                .WithTraits("Nazgûl.")
                .WithTextLine("When Revealed: This card gains surge. Discard this card.")
                .WithTextLine("Rumor: Each player must trigger this card’s shadow effect. Place 1 resource token on your current region.")
                .WithShadow("Shadow: Discard the top card of the encounter deck. If it is a non-unique enemy, engage it.")
                .WithInfo(26, 1, Artist.Anato_Finnstark);
            addEnemy("Johnny Goblin-fingers", EncounterSet.TheNineAreAbroad, 27, 3, 4, 3, 5)
                .WithUnique()
                .WithTraits("Bree.", "Brigand.")
                .WithTextLine("While not engaged, place this card on Eriador.")
                .WithTextLine("Forced: When Johnny Goblin-fingers is defeated, your group investigates rumors.")
                .WithShadow("Shadow: Reveal Johnny Goblin-fingers.")
                .WithVictoryPoints(5)
                .WithInfo(27, 1, Artist.Romana_Kendelic);
            addEnemy("Pursuing Wargs", EncounterSet.TheNineAreAbroad, 10, 3, 3, 1, 3)
                .WithTraits("Creature.", "Warg.")
                .WithTextLine("While not engaged, place this card on your current region.")
                .WithTextLine("Pursuing Wargs cannot take combat damage unless it has been dealt a shadow card with a shadow effect this round.")
                .WithShadow("Shadow: Engage Pursuing Wargs.")
                .WithInfo(28, 2, Artist.John_Howe);
            addEnemy("Roaming Easterling", EncounterSet.TheNineAreAbroad, 29, 3, 3, 2, 3)
                .WithTraits("Easterling.")
                .WithTextLine("While not engaged, place this card on Rhovanion.")
                .WithTextLine("If Roaming Easterling did not enter play this round, it gets +2 Attack.")
                .WithTextLine("Rumor: The first player engages this enemy. Choose either the region north or south of your current region and place 1 resource token on it.")
                .WithInfo(29, 2, Artist.John_Howe);
            addEnemy("South Downs Troll", EncounterSet.TheNineAreAbroad, 37, 2, 6, 1, 10)
                .WithTraits("Troll.")
                .WithTextLine("While not engaged, place this card on Eriador.")
                .WithTextLine("Excess combat damage dealt by South Downs Troll must be assigned as an increase to your threat.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, attacking enemy makes an additional attack.")
                .WithInfo(30, 2, Artist.John_Howe);
            addEnemy("Barrow-wight", EncounterSet.TheNineAreAbroad, 27, 3, 4, 2, 5)
                .WithTraits("Undead.", "Wight.")
                .WithTextLine("While not engaged, place this card on Arnor.")
                .WithTextLine("Characters attacking or defending Barrow-wight use their Willpower in place of their Attack and Defense.")
                .WithTextLine("Rumor: The first player engages this enemy. Choose either the region east or west of your current region and place 1 resource token on it.")
                .WithInfo(31, 2, Artist.John_Howe);
            addEnemy("Dunlending Warband", EncounterSet.TheNineAreAbroad, 31, 2, Card.VALUE_X, 2, Card.VALUE_X)
                .WithTraits("Dunland.")
                .WithTextLine("While not engaged, place this card on Enedwaith.")
                .WithTextLine("X is the number of cards in the hand of the player with the greatest number of cards in their hand.")
                .WithShadow("Shadow: Deal 1 damage to the defending character.")
                .WithInfo(32, 2, Artist.John_Howe);
            addEnemy("Morgul Scout", EncounterSet.TheNineAreAbroad, 15, 4, 3, 0, 1)
                .WithTraits("Mordor.", "Orc.")
                .WithTextLine("While not engaged, place this card on Gondor.")
                .WithTextLine("Forced: After Morgul Scout is destroyed, reveal an encounter card.")
                .WithTextLine("Rumor: The first player engages this enemy. Choose either the region northeast or southwest of your current region and place 1 resource token on it.")
                .WithInfo(33, 2, Artist.John_Howe);
            addEnemy("Anfalas Pillager", EncounterSet.TheNineAreAbroad, 33, 3, 3, 3, 3)
                .WithTraits("Corsair.", "Raider.")
                .WithTextLine("While not engaged, place this card on The Outlands. Anfalas Pillager gets +1 Defense for each resource token on it.")
                .WithTextLine("Forced: After Anfalas Pillager attacks, move 1 resource from a hero you control to Anfalas Pillager.")
                .WithTextLine("Rumor: The first player engages this enemy. Choose either the region southeast or northwest of your current region and place 1 resource token on it.")
                .WithInfo(34, 2, Artist.Grafit_Studio);
            addLocation("Gladden Fields", EncounterSet.TheNineAreAbroad, 3, 4)
                .WithUnique()
                .WithTraits("Marshland.")
                .WithTextLine("Forced: After this card enters play, place it on Mirkwood. Then, raise each player’s threat by 2.")
                .WithTextLine("Forced: After Gladden Fields is explored, choose a group. If you are in stage 1, place 1 resource token on that group’s Mirkwood region. Then, your group investigates rumors.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack.")
                .WithVictoryPoints(5)
                .WithInfo(35, 1, Artist.David_Henderson);
            addLocation("Icebay of Forochel", EncounterSet.TheNineAreAbroad, 4, 4)
                .WithUnique()
                .WithTraits("Coastland.", "Ocean.")
                .WithTextLine("Forced: After this card enters play, place it on The Blue Mountains. Then, the first player must discard the highest cost attachment they control.")
                .WithTextLine("Forced: After Icebay of Forochel is explored, choose a group. Reduce each player’s threat in that group by 5. Then, your group investigates rumors.")
                .WithVictoryPoints(5)
                .WithInfo(36, 1, Artist.David_Rosenthal);
            addLocation("The Carrock", EncounterSet.TheNineAreAbroad, 3, 4)
                .WithUnique()
                .WithTraits("Mountain.")
                .WithTextLine("Forced: After this card enters play, place it on Rhovanion. Then, each player must exhaust 1 non-Creature character they control.")
                .WithTextLine("Forced: When The Carrock is explored, choose a group. That group may move from their current region to any other region in their map. Then, your group investigates rumors.")
                .WithVictoryPoints(5)
                .WithInfo(37, 1, Artist.Alan_Lee);
            addLocation("Old Púkel Land", EncounterSet.TheNineAreAbroad, 3, 4)
                .WithUnique()
                .WithTraits("Wose.", "Plains.")
                .WithTextLine("Forced: After this card enters play, place it on The Outlands. Then, discard 1 resource from each hero in play.")
                .WithTextLine("Forced: When Old Púkel Land is explored, choose a group. Add 6 progress to that group’s main quest for each player in that group (bypassing any active locations). Then, your group investigates rumors.")
                .WithVictoryPoints(5)
                .WithInfo(38, 1, Artist.Douglas_Chaffee);
            addLocation("Paths of the Dead", EncounterSet.TheNineAreAbroad, 3, 4)
                .WithUnique()
                .WithTraits("Underground.")
                .WithTextLine("Forced: After this card enters play, place it on Rohan. Then, for each non-Noble hero in play, its controller must either exhaust it or deal 1 damage to it.")
                .WithTextLine("Forced: After Paths of the Dead is explored, choose a group. Deal 2 damage to all enemies engaged with that group’s players. Then, your group investigates rumors.")
                .WithVictoryPoints(5)
                .WithInfo(39, 1, Artist.Funcom);
            addLocation("The Anduin River", EncounterSet.TheNineAreAbroad, 2, 4)
                .WithTraits("River.")
                .WithTextLine("Forced: After this card enters play, place it on a River region without a copy of The Anduin River on it.")
                .WithTextLine("Forced: After The Anduin River is explored, the first player shuffles up to 2 cards from their discard pile into their deck. Then, your group must investigate rumors.")
                .WithInfo(40, 2, Artist.Clark_Mitchell);
            addLocation("Shores of Belegaer", EncounterSet.TheNineAreAbroad, 2, 4)
                .WithTraits("Coastland.")
                .WithTextLine("Forced: After this card enters play, place it on a Coastland region without a copy of Shores of Belegaer on it.")
                .WithTextLine("Forced: After Shores of Belegaer is explored, the first player reduces their threat by 2. Then, your group investigates rumors.")
                .WithFlavorLine("…looking upon Belegaer the Great Sea he was enamoured of it, and the sound of it and the longing for it were ever in his heart and ear…")
                .WithFlavorLine("—The Silmarillion")
                .WithInfo(41, 3, Artist.Todd_White);
            addLocation("Old North-South Road", EncounterSet.TheNineAreAbroad, 2, 4)
                .WithTraits("Road.")
                .WithTextLine("Forced: After this card enters play, place it on a Road region without a copy of Old North-South Road on it.")
                .WithTextLine("Forced: After Old North-South Road is explored, the first player discards the top 2 cards of their deck and may add 1 of those cards to their hand. Then, your group investigates rumors.")
                .WithInfo(42, 2, Artist.Fawn_McNeill);
            addTreachery("Late for Tea", EncounterSet.TheNineAreAbroad)
                .WithTextLine("When Revealed: Heal 1 damage from each character that shares a Trait with your current region. Deal 1 damage to each exhausted character that does not.")
                .WithTextLine("Rumor: Each player deals 3 damage among characters they control. Place 1 resource token on your current region.")
                .WithInfo(43, 2, Artist.Raoul_Vitale);
            addTreachery("The Nine are Abroad", EncounterSet.TheNineAreAbroad)
                .WithSlugSuffix("Treachery")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Announce to all groups, “The Nine are Abroad.” Each player in each group must choose to either deal 1 damage to 1 character they control, or raise their threat by 1. Then, add The Nine are Abroad to the victory display.")
                .WithShadow("Shadow: Resolve this card’s “when revealed” effect.")
                .WithVictoryPoints(1)
                .WithInfo(44, 1, Artist.Inessa_Khanenko);
            addTreachery("Ash Nazg Durbatulûk", EncounterSet.TheNineAreAbroad)
                .WithTraits("Black Speech.")
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Each player must resolve this card’s shadow effect.")
                .WithShadow("Shadow: For each attachment you control, either exhaust it, discard it, or deal 1 damage to its attached character.")
                .WithInfo(45, 1, Artist.Kenneth_Sofia);
            addTreachery("Ash Nazg Gimbatul", EncounterSet.TheNineAreAbroad)
                .WithTraits("Black Speech.")
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Each player must resolve this card’s shadow effect.")
                .WithShadow("Shadow: Raise your threat by 2.")
                .WithInfo(46, 1, Artist.Kenneth_Sofia);
            addTreachery("Ash Nazg Thrakatulûk", EncounterSet.TheNineAreAbroad)
                .WithTraits("Black Speech.")
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Each player must resolve this card’s shadow effect.")
                .WithShadow("Shadow: Either engage a non-unique enemy on a region other than your current region, or discard the top 3 cards of the encounter deck and engage the topmost non-unique enemy in the encounter discard pile.")
                .WithInfo(47, 1, Artist.Kenneth_Sofia);
            addTreachery("Agh Burzum-ishi Krimpatul", EncounterSet.TheNineAreAbroad)
                .WithTraits("Black Speech.")
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Each player must resolve this card’s shadow effect.")
                .WithShadow("Shadow: Exhaust 1 character you control. Until the end of the round, your characters cannot be readied by player card effects.")
                .WithInfo(48, 1, Artist.Kenneth_Sofia);
            addTreachery("Lost in Goblin Town", EncounterSet.TheNineAreAbroad)
                .WithTextLine("When Revealed: Attach to a hero. Counts as a Condition attachment with the text: “Attached hero cannot quest, attack, defend, or ready. Treat attached hero’s text box as if it were blank, except for Traits. Response: After the players move between Arnor and Rhovanion, add Lost in Goblin Town to the victory display.”")
                .WithVictoryPoints(5)
                .WithInfo(49, 1, Artist.Tara_Rueping);
            addEncounterSideQuest("Charter the Dream-chaser", EncounterSet.TheNineAreAbroad, 5)
                .WithKeywords("Surge.")
                .WithTextLine("Surge. Charter the Dream-chaser cannot be chosen as the current quest during the quest phase unless your current region is Harlindon.")
                .WithTextLine("When Revealed: Place Charter the Dream-chaser to the west of Harlindon.")
                .WithTextLine("Response: After Charter the Dream-chaser is defeated, move your group to any other Coastland region. If you are in stage 1, place 1 resource token on that region. Otherwise, place 4 progress tokens on a location on that region.")
                .WithVictoryPoints(10)
                .WithInfo(50, 1, Artist.Ivan_Aivazovsky);
            addEncounterSideQuest("Mordor", EncounterSet.TheNineAreAbroad, 5)
                .WithKeywords("Surge.")
                .WithTextLine("Surge. Mordor is not a map region, and cannot be chosen as the current quest during the quest phase unless your current region is Gondor.")
                .WithTextLine("Black Speech card effects cannot be canceled.")
                .WithTextLine("When Revealed: Place Mordor to the east of Gondor.")
                .WithTextLine("Forced: At the end of the round, raise each player’s threat by 1.")
                .WithVictoryPoints(10)
                .WithInfo(51, 1, Artist.In_The_Reads);
            addEncounterSideQuest("Rhûn", EncounterSet.TheNineAreAbroad, 5)
                .WithKeywords("Surge.")
                .WithTextLine("Surge. Rhûn is not a map region, and cannot be chosen as the current quest during the quest phase unless your current region is Rohan.")
                .WithTextLine("When Revealed: Place Rhûn to the east of Rohan.")
                .WithTextLine("Forced: At the end of the round, discard the top card of the encounter deck. If that card is a non-unique enemy, reveal it.")
                .WithVictoryPoints(10)
                .WithInfo(52, 1, Artist.In_The_Reads);
            addContract("At the End of All Things")
                .WithTextLine("You can only choose 2 starting heroes. They each get +4 threat cost, +1 Willpower, +1 Attack, +1 Defense, +1 hit point, and they each gain a resource icon matching the other hero’s printed sphere. They cannot gain resources from attachment card effects, and they cannot be healed.")
                .WithTextLine("Action: Exhaust At the End of All Things to deal 1 damage to one of your starting heroes and ready your other starting hero.")
                .WithTextLine("Action: Flip this card over. You cannot trigger this effect during the first 3 rounds.")
                .WithOppositeTextLine("Your starting heroes each get +4 threat cost, +1 Willpower, +1 Attack, +1 Defense, +1 hit point, and they each gain a resource icon matching the other hero’s printed sphere. They cannot gain resources from attachment card effects.")
                .WithOppositeTextLine("Forced: When this card flips to this side, add 3 resources to each of your starting heroes’ pools. Search your deck for 2 cards and add them to your hand. Shuffle your deck.")
                .WithInfo(53, 1, Artist.Michael_Whelan);
            /*
            addGenConSetup("Back Card", EncounterSet.TheScouringOfTheShire)
                .WithTextLine("Credits")
                .WithTextLine("CEO & Game Design: SeastanArt: banania")
                .WithTextLine("COO & Software: A.R.Rules: alonewolf87")
                .WithTextLine("Playtesting: Shellin & The Purple WizardStorytelling: John Leo")
                .WithTextLine("Graphic Design & Printing: thaurdirEditing: Darkling Door")
                .WithTextLine("Lore: BobbymcbobfaceCommunity: Shellin")
                .WithTextLine("Scenario Design: Seastan")
                .WithTextLine("Assistants: [DTP]Anzu, Admiral Polaris, ALeP Cron Bot, Annaeru, argonui, AstroSnail (Stephen), Baloosh, Barthadra, Beleg489, Ben or Break, Beorn, BeornBot, bgamerjoe, Brewer Bear, Brinx, Bullroarer Took, Bundeswill, CamMitchell, carlosm88, ceciltettledeer, Celia, Comtedelafere, cowZarific, croatoan, Cryoshark, d20woodworking, DavidJMartin, DEER PARK, deiseach, Dieter, Dimitri, divinityofnumber, doomguard, du, dwaynek, Edmund, EdY, Emilius, Emmental, Emreis, estel_edain, filgonfin, Franlag, fuzzyslippers, Glamcrist (JeffTheJeff), Gorthaur, granny.sheep, Great Glorfindel, GreenWizard, Greyjoy, Gu Xi, Helena, Ipswatch, Ira, JasonRed3, Jaywana, JoshuaK, KingDom, klarlack, kokatrix, Krakua, KYpatzer, LeeA, Levanthalas, Lively, Lorunks, madslaust, Mag, Makoshark13, Mazdaist, McDog3, migal, miklemas, Minoso, Mormegil, MrSpaceBear, MrThomnas, MurstonThor, nelloianiro, Nuls, oldoly, Onidsen, Pablo, Palantir Record Keeper, Pining For Fimbrethil, rduda, RegisF, Rimogard, RogueThirteen, rouxxor, Salted Pork, secondhandtook, Speder, Splice, tamhas, Taudir, Tegyrius, Thaimor, thanatopsis, The Purple Wizard, TheChap, thorsome, tlawrence, Trialus, TritonWreck, Truck, Tuhma, VeggieGollum, Verwegner (Jan), Vyntares, Watch-Captain Alain, Watcher in the Water, wlk, wolframius, xavdu92, xaviermutant, Xenon, ycarium, Zapier, Zarkanth, zoomboy")
                .WithTextLine("Special thanks to HeavyKaragh for his work on the Strange Eons plugin, RiddermarkLord for his work on the card templates, and Troy L for the ALeP logo and encounter set icon designs. We credit Marko Manev for the ALeP encounter card back art.")
                .WithOppositeTextLine("The lieutenants of Sauron have spread across Middle-earth in service of their dark master. Rumors of evil abound from Rhovanion to the fallen spires of Angmar. Yet as the Nazgûl hunt for the One Ring, you hunt the Nazgûl. Follow the sounds of black hoof and fell shriek in this epic multiplayer scenario.")
                .WithInfo(54, 1, Artist.None);
             */
            addHero("Glorfindel", 5, Sphere.Spirit, 3, 3, 1, 5)
                .WithTraits("Noldor.", "Noble.", "Warrior.")
                .WithTextLine("Forced: After Glorfindel exhausts to commit to a quest, raise your threat by 1.")
                .WithPromotion()
                .WithInfo(101, 1, Artist.Jan_Pospisil);
        }
    }
}
