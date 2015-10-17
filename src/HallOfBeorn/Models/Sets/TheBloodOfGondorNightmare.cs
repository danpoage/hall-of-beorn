using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheBloodOfGondorNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Blood of Gondor Nightmare";
            Abbreviation = "TBoGN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2060;

            Cards.Add(new Card()
            {
                Title = "The Blood of Gondor Nightmare",
                HasSecondImage = true,
                Id = "08D3CCC2-D32F-406B-A497-33A3FD9CF044",
                CardType = CardType.Nightmare_Setup,
                Text = 
@"You are playing Nightmare mode.
Setup: Each player takes 1 hidden card.
The players cannot win the game unless The Crossroads and Black Númenórean are in the victory display.",
                FlavorText = "Then they yelled and dozens of other goblins had sprung out of the trees. -The Two Towers",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for the The Blood of ~Gondor scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

1x Black Númenorean
2x Evil Crow
2x Lying in Wait
4x The ~Dark ~Woods
1x ~Orc Rabble
1x ~Orc Arsonist
1x Scourge of ~Mordor

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Blood of ~Gondor encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = "The Blood of Gondor Nightmare",
                Quantity = 1,
                Number = 1,
                Artist = Artist.Piya_Wannachaiwong
                /*
                UpdateScenarioCards = (groups) =>
                {
                    foreach (var group in groups)
                    {
                        var scenario = group.Scenarios.Where(x => x.Title == "The Blood of Gondor").FirstOrDefault();
                        if (scenario == null)
                            continue;

                        foreach (var card in scenario.ScenarioCards.Where(x => !x.EncounterSet.EndsWith(" Nightmare")))
                        {
                            switch (card.Title)
                            {
                                case "Black Númenorean":
                                    card.NightmareQuantity -= 1;
                                    break;
                                case "Evil Crow":
                                    card.NightmareQuantity -= 2;
                                    break;
                                case "Lying in Wait":
                                    card.NightmareQuantity -= 2;
                                    break;
                                case "The Dark Woods":
                                    card.NightmareQuantity -= 4;
                                    break;
                                case "Orc Rabble":
                                    card.NightmareQuantity -= 1;
                                    break;
                                case "Orc Arsonist":
                                    card.NightmareQuantity -= 1;
                                    break;
                                case "Scourge of Mordor":
                                    card.NightmareQuantity -= 2;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }

                    return true;
                }*/
            });
            Cards.Add(Card.Enemy("Black Númenorean", "07C0FBEC-771B-4FD2-AF0E-B9AC9165A500", "The Blood of Gondor Nightmare", 35, 255, 5, 4, 9)
                .WithUnique()
                .WithNormalizedTitle("Black Numenorean")
                .WithTraits("Mordor.")
                .WithEffect(CardEffectType.Passive, "X is the total number of hidden cards in the game.")
                .WithEffect(CardEffectType.Forced, "Forced: When Black Númenórean engages you, turn all hidden cards in your play area faceup.")
                .WithEffect(CardEffectType.Forced, "Forced: At the end of the round, each player must raise his threat by 1 for each hidden card in his play area.")
                .WithInfo(2, 1, Artist.Melanie_Maier));
            Cards.Add(Card.Enemy("Orc Trickster", "DCE1FD22-F5A2-46A6-8FEB-6B8A5D734487", "The Blood of Gondor Nightmare", 20, 3, 3, 2, 2)
                .WithTraits("Orc.")
                .WithEffect(CardEffectType.Forced, "Forced: After Orc Trickster is turned faceup as a hidden card, it makes an immediate attack against the engaged player.")
                .WithEffect(CardEffectType.Forced, "Forced: When Orc Trickster would be damaged, a random player takes it facedown as a hidden card in his play area instead.")
                .WithInfo(3, 4, Artist.Piya_Wannachaiwong));
            Cards.Add(Card.Enemy("Uruk Marksman", "6E305E73-B5F4-4F84-B718-28B86B1A335D", "The Blood of Gondor Nightmare", 40, 4, 2, 2, 4)
                .WithTraits("Orc.", "Uruk.", "Mordor.")
                .WithKeywords("Archery 3.")
                .WithEffect(CardEffectType.Forced, "Forced: After Uruk Marksman is turned faceup as a hidden card, deal 3 damage to a character controlled by the engaged player and return Uruk Marksman to the staging area.")
                .WithInfo(4, 3, Artist.Niten));
            Cards.Add(Card.Location("Edge of Ithilien", "D78DB2CE-4A25-4B77-8CB5-A1E73BD6D314", "The Blood of Gondor Nightmare", 3, 6)
                .WithTraits("Ithilien.", "Forest.")
                .WithKeywords("Archery X.")
                .WithEffect(CardEffectType.Passive, "X is the highest number of hidden cards in any player's play area.")
                .WithShadow("Shadow: Turn 1 hidden card in your play area faceup. If it is a treachery card, attacking enemy makes an additional attack after this one.")
                .WithInfo(5, 3, Artist.Jose_Vega));
            Cards.Add(Card.Location("Mountains of Shadow", "F6F8BDC1-6D58-4B03-85A1-D0825145C839", "The Blood of Gondor Nightmare", 4, 4)
                .WithTraits("Mountain.")
                .WithEffect(CardEffectType.Passive, "While Mountains of Shadow is the active location, it gains: \"Forced: After you turn 1 or more hidden cards faceup, take 1 hidden card.\"")
                .WithShadow("Shadow: Either take 2 hidden cards, or this attack is considered undefended.")
                .WithInfo(6, 3, Artist.Mariusz_Gandzel));
            Cards.Add(Card.Treachery("Surrounded by Shadow", "83CB4803-3A7D-47F7-994B-2082FCE049EC", "The Blood of Gondor Nightmare")
                .WithKeywords("Doomed 2.")
                .WithEffect(CardEffectType.When_Revealed, "When Revealed: Each player must either take 1 hidden card for each questing hero he controls, or remove one hero he controls from the quest for each hidden card in his play area.")
                .WithInfo(7, 3, Artist.Anthony_Devine));
            Cards.Add(Card.Treachery("Sudden Onslaught", "FCDBFCA2-36BE-4AAD-95A2-74A9E799BADB", "The Blood of Gondor Nightmare")
                .WithEffect(CardEffectType.When_Revealed, "When Revealed: Each player turns each hidden card in his play area faceup. Each player then takes hidden cards equal to the number of hidden cards he just turned faceup.")
                .WithShadow("Shadow: Take 1 hidden card. Then, turn 1 hidden card in your play area faceup.")
                .WithInfo(8, 2, Artist.Guillaume_Ducos));
        }
    }
}