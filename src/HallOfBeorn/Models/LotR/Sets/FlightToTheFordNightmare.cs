using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class FlightToTheFordNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "Flight to the Ford Nightmare";
            Abbreviation = "FttFN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2064;

            Cards.Add(new LotRCard()
            {
                Title = "Flight to the Ford Nightmare",
                Id = "954C80B3-ABAD-464D-BA2F-985610926BEB",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing Nightmare mode.

The players cannot win while Ford of Bruinen is in play.",
                FlavorText = "\"There seem only to have been five of the enemy. Why they were not all here, I don't know; but I don't think they expected to be resisted. They have drawn off for the time being. But not far, I fear. They will come again another night, if we cannot escape.\" -Aragorn, The Fellowship of the Ring",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for the Flight to the Ford scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

4x Fell Rider
1x Ford of Bruinen
1x The Troll's Camp
3x Ettenmoors
3x Pain Assailed Him
3x The Old ~Road
3x Pathless Country
3x Striken Dumb
2x Rode Like a Gale

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Flight to the Ford encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = "Flight to the Ford Nightmare",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Julian_Kok
            });
            Cards.Add(LotRCard.Enemy("Fell Rider", "3125D3AE-527C-47FC-BFA6-2C1705EF4D67", "Flight to the Ford Nightmare", 30, 3, 5, 4, 6)
                .WithTraits("Nazgûl")
                .WithText("Cannot have non-Morgul attachments.\r\nForced: After Fell Rider attacks and destroys a character, reduce the Ring-bearer's life by 1.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if The One ~Ring is exhausted).")
                .WithInfo(2, 4, Artist.Dleoblack));
            Cards.Add(LotRCard.Location("Ford of Bruinen", "D612D16F-17BB-4E53-B8DF-DEB872A78558", "Flight to the Ford Nightmare", 3, 3)
                .WithUnique()
                .WithTraits("River.")
                .WithText("Immune to player card effects.\r\nTravel: Each player searches the encounter deck and discard pile for a Nazgûl enemy and puts it into play engaged with him. Shuffle the encounter deck.")
                .WithInfo(3, 1, Artist.Smirtouille));
            Cards.Add(LotRCard.Location("Trollshaw Forest", "EAC231F5-7DAC-4BCA-AB5A-FB8EF9665AAE", "Flight to the Ford Nightmare", 3, 5)
                .WithTraits("Forest.")
                .WithText("While Trollshaw ~Forest is in the staging area, it gains: \"Forced: After a 'when revealed' effect is canceled, reduce the Ring-bearer's life by 1.\"\r\nTravel: Reduce the Ring-bearer's life by 1 to travel here.")
                .WithInfo(4, 3, Artist.Julian_Kok));
            addCard(LotRCard.Location("Great East Road", "73B1FDBB-BEF6-4859-AB4E-729F83D3711B", "Flight to the Ford Nightmare", Card.VALUE_X, 5)
                .WithTraits("Road.")
                .WithText("X is 1 plus the number of Nazgûl enemies in play.\r\nWhile Great East ~Road is in the staging area, each Nazgûl enemy gets -5 engagement cost.")
                .WithShadow("Shadow: After this attack, attacking enemy engages the next player then makes an immediate attack.")
                .WithInfo(5, 3, Artist.Katy_Grierson));
            Cards.Add(LotRCard.Location("Pathless Wilderness", "32398738-3E58-4407-B4C2-A13316333740", "Flight to the Ford Nightmare", 2, 6)
                .WithTraits("Forest.", "Hills.")
                .WithText("Pathless Wilderness enters play with 3 resource tokens on it.\r\nForced: At the end of the round, discard 1 resource token here. Then, if there are no resource tokens here, reduce the Ring-bearer's life by 3.")
                .WithFlavor("Before the first day's march was over Frodo's pain began to grow again. -The Fellowship of the Ring")
                .WithInfo(6, 2, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Location("Ettendales", "F26AFBA2-CCBF-4722-AE28-FB14B6320704", "Flight to the Ford Nightmare", 5, 3)
                .WithTraits("Forest.", "Hills.")
                .WithText("Forced: When Ettendales is explored, shuffle the top card of the burden deck into the encounter deck.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack. If this attack destroys a character, reduce the Ring-bearer's life by 1.")
                .WithInfo(7, 2, Artist.Katy_Grierson));
            Cards.Add(LotRCard.Treachery("Come Back!", "4C2EF7A7-EDFC-40C0-9B40-8DAD975CE7DB", "Flight to the Ford Nightmare")
                .WithTraits("Enchantment.")
                .WithKeywords("Peril.", "Doomed 1.")
                .WithText("When Revealed: Reduce the Ring-bearer's life by 1 and remove all progress from the current quest.")
                .WithShadow("Shadow: Either reduce the Ring-bearer's life by 1, or this attack is considered undefended.")
                .WithInfo(8, 2, Artist.Mark_Behm));
            Cards.Add(LotRCard.Treachery("The Twilight World", "AC9D02D0-D014-41AA-86EA-D11675E3346A", "Flight to the Ford Nightmare")
                .WithTraits("Morgul.")
                .WithKeywords("Doomed 2.")
                .WithText("When Revealed: Attach to the Ring-bearer. Limit 1 per hero. (Counts as a Condition attachment with the text: \"Forced: At the beginning of the planning phase, either exhaust The One ~Ring, or reduce the Ring-bearer's life by 1.\")")
                .WithInfo(9, 2, Artist.Mark_Behm));
        }
    }
}