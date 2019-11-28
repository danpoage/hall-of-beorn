using System;

namespace HallOfBeorn.Models.LotR.Sets.DreamChaser
{
    public class TheCityOfCorsairsNightmareSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The City of Corsairs Nightmare";
            Abbreviation = "TCoCN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2089;

            addNightmareSetup(EncounterSet.TheCityOfCorsairsNightmare)
                .WithTextLine("You are playing Nightmare mode.")
                .WithTextLine("Forced: When the 'when revealed' effect on stage 2B resolves, also search the encounter deck and discard pule for each copy of Umbar Bridge and each copy of Inspiring Fury and shuffle them into the second encounter deck.")
                .WithTextLine("Forced: When the 'when revealed' effect on stage 3A resolves, also search the encounter deck for The Cursed Sword and attack it to the set-aside Captain Sahír.")
                .WithOppositeTextLine("Begin with the standard quest deck and encounter deck for The City of Corsairs scenario.")
                .WithOppositeTextLine("Remove the following card, in the specified quantities, from the standard encounter deck:")
                .WithOppositeTextLine("2x Corsair Infiltrator")
                .WithOppositeTextLine("2x Fog Bank")
                .WithOppositeTextLine("2x Starlit Sea")
                .WithOppositeTextLine("2x Scouting Ship")
                .WithOppositeTextLine("2x Serpent's Tail")
                .WithOppositeTextLine("1x Streets of Umbar")
                .WithOppositeTextLine("During setup, players are instructed to set The City of Corsairs encounter set aside, out of play. After doing so, shuffle the encounter cards in this Nightmare Deck that have The City of Corsairs encounter set icon into the set aside The City of Corsairs encounter set. Then, use the encounter cards in this Nightmare Deck that have the Coast of Umbar encounter set icon to build the standard encounter deck and Corsair deck.")
                .WithOppositeTextLine("Finally, flip this setup card over and placr it next to the quest deck. Its effect remains active throughout the game, which is now ready to being.")
                .WithOppositeTextLine("Wheel*: Some cards in The City of Corsairs Nightmare Deck have Sailing success symbols (Wheel) with an asterisk (*) next to them. This indicates that the card has a Forced effect which will trigger when the card is discarded during a Sailing test.")
                .WithInfo(1, 1, Artist.Logan_Feliciano);
            addEnemy("Patrol Ship", EncounterSet.CoastOfUmbarNightmare, 41, 2, 5, 2, 7)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 2.")
                .WithTextLine("Boarding 2.")
                .WithTextLine("Forced: After you shift your heading on-course, Patrol Ship gets -40 engagement cost this round.")
                .WithTextLine("*Forced: After Patrol Ship is discarded from the encounter deck during a Sailing test, cancel all Wheel symbols found unless you add it to the staging area.")
                .WithInfo(2, 2, Artist.Igor_Artyomenko);
            addEnemy("Corsair Loyalist", EncounterSet.CoastOfUmbarNightmare, 28, 4, 4, 2, 4)
                .WithTraits("Corsair.", "Raider.")
                .WithTextLine("While Corsair Loyalist has 4 or more resources on it, its attacks are considered to be undefended.")
                .WithShadow("Shadow: If attacking enemy is a Raider, either add 2 resources to attacking enemy, or attacking enemy makes an additional attack after this one.")
                .WithInfo(3, 2, Artist.Ryan_Valle);
            addLocation("Walls of Umbar", EncounterSet.CoastOfUmbarNightmare, 5, 4)
                .WithTraits("Ocean.", "Coastland.")
                .WithTextLine("While Walls of Umbar is in the staging area, it gains: \"Forced: After a player commits an ally to a Sailing test, raise his or her threat by 1.")
                .WithTextLine("*Forced: After Walls of Umbar is discarded from the encounter deck during a Sailing test, raise each player's threat by 1 for each ally he or she committed to that test.")
                .WithInfo(4, 2, Artist.Logan_Feliciano);
            addLocation("Umbar Bridge", EncounterSet.CoastOfUmbarNightmare, 3, 6)
                .WithTraits("Umbar.", "Coastland.")
                .WithTextLine("While Umbar Bridge is in the staging area, cancel the first X progress that would be placed on the current quest each round, where X is the highest number of resources on a Raider enemy in play.")
                .WithTextLine("Travel: Reduce the engagement cost of each Corsair enemy to 0 until the end of the round.")
                .WithInfo(5, 2, Artist.Logan_Feliciano);
            addTreachery("Inspiring Fury", EncounterSet.CoastOfUmbarNightmare)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Deal Ispiring Fury to the enemy with the highest Attack, as a shadow card.")
                .WithShadow("Shadow: Shuffle the encounter discard pile into the encounter deck and deal attacking enemy 3 additional shadow cards. During this attack, shadow effects cannot be canceled.")
                .WithInfo(6, 2, Artist.Guillaume_Ducos);
            addObjective("The Cursed Sword", EncounterSet.TheCityOfCorsairsNightmare)
                .WithUnique()
                .WithTraits("Artifact.", "Item.", "Cursed.")
                .WithTextLine("Cannot be discarded by player card effects.")
                .WithTextLine("The Cursed Sword counts as a Weapon attachment with the text: \"Forced: After Captain Sahír attacks and deals excess damage, assign that excess damage to Captain Sahír as resources. (Limit once per round.)\"")
                .WithInfo(7, 1, Artist.Carlos_Palma_Cruchaga);
            addEnemy("Umbar Patrol", EncounterSet.TheCityOfCorsairsNightmare, 48, 3, 3, 4, 6)
                .WithTraits("Corsair.")
                .WithTextLine("Forced: At the end of the encounter phase, if Umbar Patrol is in the staging area, add 2 resources to the Raider enemy with the most resources on it.")
                .WithShadow("Shadow: Add 1 resource to each Raider enemy engaged with you.")
                .WithInfo(8, 3, Artist.Guillaume_Ducos);
            addTreachery("Raise the Alarm!", EncounterSet.TheCityOfCorsairsNightmare)
                .WithTextLine("When Revealed: Discard cards from the top of the encounter deck until a Raider enemy is discarded. Add that enemy to the staging area and place 3 resources on it.")
                .WithShadow("Shadow: If attacking enemy is a Raider, after this attack ends, add 1 resource to attacking enemy for each damage dealt by this attack.")
                .WithInfo(9, 2, Artist.Monztre);
            addTreachery("Slave Trade", EncounterSet.TheCityOfCorsairsNightmare)
                .WithTextLine("When Revealed: Each player deals 2 damage to an ally he or she controls. For each ally destroyed by this effect, place resources on a Raider enemy in play equal to that ally's resource cost.")
                .WithShadow("Shadow: Discard an attachment you control. If attacking enemy is a Raider, add resources to it equal to that attachment's printed cost.")
                .WithInfo(10, 3, Artist.Guillaume_Ducos);
        }
    }
}