using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class AKnifeInTheDarkNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "A Knife in the Dark Nightmare";
            Abbreviation = "AKitDN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2063;

            Cards.Add(new LotRCard()
            {
                Title = "A Knife in the Dark Nightmare",
                HasSecondImage = true,
                Id = "29431129-B0BA-4589-AB3D-329247065C52",
                CardType = CardType.Nightmare_Setup,
                Text = "You are playing Nightmare mode.\r\nWhile Bill Ferny is in the staging area, he gains: \"Immune to player card effects.\"",
                FlavorText = "The night deepened. There came the soft sound of horses led with stealth along the lane. Outside the gate they stopped, and three black figures entered, like shades of night creeping across the ground. -The Fellowship of the Ring",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for the A Knife in the ~Dark scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

4x Shady Bree-lander
3x Weather ~Hills
1x Unwanted Attention
3x Pathless Country
1x Weathertop

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard A Knife in the ~Dark encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = "A Knife in the Dark Nightmare",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Juan_Carlos_Barquet
                /*
                UpdateScenarioCards = (groups) =>
                {
                    foreach (var group in groups)
                    {
                        var scenario = group.Scenarios.Where(x => x.Title == "A Knife in the Dark").FirstOrDefault();
                        if (scenario == null)
                            continue;

                        foreach (var card in scenario.ScenarioCards.Where(x => !x.EncounterSet.EndsWith(" Nightmare")))
                        {
                            switch (card.Title)
                            {
                                case "Shady Bree-lander":
                                    card.NightmareQuantity -= 4;
                                    break;
                                case "Weather Hills":
                                    card.NightmareQuantity -= 3;
                                    break;
                                case "Unwanted Attention":
                                    card.NightmareQuantity -= 1;
                                    break;
                                case "Pathless Country":
                                    card.NightmareQuantity -= 3;
                                    break;
                                case "Weathertop":
                                    card.NightmareQuantity -= 1;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }

                    return true;
                }*/
            });
            Cards.Add(LotRCard.Enemy("Menacing Wraith", "2B12F498-3840-4831-9513-E54B0FF7132A", "A Knife in the Dark Nightmare", 40, 4, 5, 4, 6)
                .WithTraits("Nazgûl")
                .WithText("Cannot have non-Morgul attachments.\r\nForced: After The One Ring is exhausted, Menacing Weath engages the first player and makes an immediate attack.")
                .WithFlavor("\"Open, in the name of Mordor!\" said a voice thin and menacing, -The Fellowship of the Ring")
                .WithInfo(2, 2, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Enemy("Southern Spy", "E57784A3-EF74-4EAC-8830-B712D5DC9661", "A Knife in the Dark Nightmare", 25, 3, 4, 2, 4)
                .WithTraits("Spy.")
                .WithText("When Revealed: Either shuffle an out of play Ringwraith into the encounter deck, or Southern Spy makes an immediate attack against you.")
                .WithShadow("Shadow: Defending character gets -1 Defense (-3 Defense instead if The One Ring is exhausted).")
                .WithInfo(3, 4, Artist.Lukasz_Jaskolski));
            Cards.Add(LotRCard.Location("Weathertop", "B6B4518F-1A04-475F-91F3-AE4C44F6F151", "A Knife in the Dark Nightmare", 4, 6)
                .WithUnique()
                .WithTraits("Hills.", "Ruins.")
                .WithText("Immune to player card effects.\r\nThe Witch-king cannot be damaged.\r\nForced: After Weathertop becomes the active location, exhaust The One Ring. The One Ring cannot ready while Weathertop is the active location.")
                .WithVictoryPoints(3)
                .WithInfo(4, 1, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Location("Weather Hills", "12C7C2E0-3D60-43ED-BF31-458122AE34CC", "A Knife in the Dark Nightmare", 3, 5)
                .WithTraits("Hills.")
                .WithText("While the players are at stage 1, progress cannot be placed here.\r\nWhile The One ~Ring is exhausted, ~Weather ~Hills gets +2 Threat.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack.")
                .WithInfo(5, 3, Artist.Jake_Bullock));
            Cards.Add(LotRCard.Location("The Old Road", "94465F77-53CB-4B7A-9F91-A6A5B9F8A4D9", "A Knife in the Dark Nightmare", 2, 8)
                .WithTraits("Road.")
                .WithText("The Old Road enters play with 3 resource tokens on it.\r\nForced: At the end of the round, discard 1 resource token here. Then, if there are no resource tokens here, shuffle 1 out of play Ringwraith into the encounter deck.")
                .WithInfo(6, 3, Artist.Juan_Carlos_Barquet));
            Cards.Add(LotRCard.Location("Forsaken Inn", "9F04DEA7-A655-4941-8DFC-16AFF7B9748B", "A Knife in the Dark Nightmare", 254, 4)
                .WithTraits("Inn.")
                .WithText("X is the number of characters the first player controls.\r\nTravel: The first player searches the encounter deck and discard pile for a Spy enemy, reveals it, and adds it to the staging area. Shuffle the encounter deck.")
                .WithFlavor("\"I don't know if the Road has ever been measured in miles beyond the Forsaken Inn...\" -The Fellowship of the Ring")
                .WithInfo(7, 2, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Treachery("The Ring's Will", "880F02B4-7C63-4078-B311-6DE55F764DC8", "A Knife in the Dark Nightmare")
                .WithText("When Revealed: Raise each player's threat by 5. This effect cannot be canceled by the Ring-bearer's effect, or if The One Ring is exhausted.")
                .WithShadow("Shadow: After this attack, attacking enemy engages the next player then makes an immediate attack.")
                .WithInfo(8, 2, Artist.Sara_Betsy));
            Cards.Add(LotRCard.Treachery("Blade Tip", "993E2EB0-22F8-41BB-9E65-5498AFF37065", "A Knife in the Dark Nightmare")
                .WithTraits("Morgul.")
                .WithKeywords("Surge.", "Doomed 1.")
                .WithShadow("Shadow: If the defending character is damaged by this attack, attach Blade Tip to that character. (Counts as a Condition attachment with the text: \"Forced: At the end of the refresh phase, raise your threat by 2.\")")
                .WithInfo(9, 2, Artist.Florian_Devos));
        }
    }
}