using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class IntoFangornNightmare : CardSet
    {
        const string setName = "Into Fangorn Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TCaON";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2067;

            Cards.Add(new Card()
            {
                Title = setName,
                HasSecondImage = true,
                CardType = CardType.Nightmare_Setup,
                Text = "You are playing Nightmare mode.\r\nSetup: Each player searches the encounter deck for a Huorn enemy and puts it into play engaged with him. Shuffle the encounter deck.\r\nThe Player cannot defeat stage 1B or 2B unless Edge of Fangorn is in the victory display.",
                FlavorText = "Ever nearer the tree-clad slopes of Fangorn loomed, slowly darkling as the sun went west. -The Two Towers",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for the Into Fangorn scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

3x Deadly Huorn
3x Tangled Wood
3x Turned Around

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Into Fangorn encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = setName,
                Quantity = 1,
                Number = 1,
                Artist = Artist.Katy_Grierson,
                UpdateScenarioCards = (groups) =>
                {
                    foreach (var group in groups)
                    {
                        var scenario = group.Scenarios.Where(x => x.Title == "Into Fangorn").FirstOrDefault();
                        if (scenario == null)
                            continue;

                        foreach (var card in scenario.ScenarioCards.Where(x => !x.EncounterSet.EndsWith(" Nightmare")))
                        {
                            switch (card.Title)
                            {
                                case "Deadly Huorn":
                                    card.NightmareQuantity -= 3;
                                    break;
                                case "Tangled Woods":
                                    card.NightmareQuantity -= 3;
                                    break;
                                case "Turned Around":
                                    card.NightmareQuantity -= 3;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }

                    return true;
                }
            });
            Cards.Add(Card.Enemy("Huorn of Fangorn", "", setName, 23, 3, 4, 3, 6)
                .WithTraits("Huorn.")
                .WithKeywords("Hinder.")
                .WithText("Cannot have attachments.\r\nForced: At the beginning of each resource phase, the engaged player discards 1 attachment he controls.")
                .WithShadow("Shadow: Deal 1 damage to the defending character.")
                .WithInfo(2, 3, Artist.Katy_Grierson));
            Cards.Add(Card.Enemy("Blocking Huorn", "", setName, 28, 2, 3, 3, 8)
                .WithTraits("Huorn.")
                .WithKeywords("Hinder.")
                .WithText("Cannot have attachments.\r\nWhile Blocking Huron is engaged with a player, it adds its Threat to the staging area.")
                .WithShadow("Shadow: Put Blocking Huorn into play engaged with you.")
                .WithInfo(3, 2, Artist.Katy_Grierson));
            Cards.Add(Card.Enemy("Wicked Huron", "", setName, 33, 3, 6, 4, 7)
                .WithTraits("Huorn.")
                .WithKeywords("Hinder.")
                .WithText("Cannot have attachments.\r\nForced: At the beginning of each resource phase, the engaged player exhausts a hero he controls.")
                .WithShadow("Shadow: Attacking enemy cannot take damage until the end of the round.")
                .WithInfo(4, 2, Artist.Mariusz_Gandzel));
            Cards.Add(Card.Location("Tangled Forest", "", setName, 2, 6)
                .WithTraits("Forest.")
                .WithText("While Tangled Forest is in the staging area, it gains: \"Forced: After any amount of progress is removed from the current quest, assign X damage amoung characters in play. X is the number of progress just removed. This ability does not stack with other copies of Tangled Forest.\"")
                .WithInfo(5, 3, Artist.Mariusz_Gandzel));
            Cards.Add(Card.Location("Entwood", "", setName, 3, 4)
                .WithTraits("Forest.")
                .WithText("While Entwood is in the staging area, each Huron enemy in the staging area gains: \"Immune to player card effects.\"\r\nTravel: The first player engages the highest engagement cost Huorn enemy in the staging area.")
                .WithInfo(6, 3, Artist.Julian_Kok));
            Cards.Add(Card.Location("Dark Corner of Fangorn", "", setName, 3, 5)
                .WithTraits("Forest.")
                .WithText("While Dark Corner of Fangorn is in the staging area, each Huorn enemy loses the hunder keyword.\r\nForced: After Dark Corner of Fangorn becomes the active location, each engaged Huorn enemy makes an immediate attack.")
                .WithFlavor("\"...it is perilous to touch the trees of that wood, it is said.\"\r\n-Aragorn, The Two Towers")
                .WithInfo(7, 2, Artist.Julian_Kok));
            Cards.Add(Card.Treachery("Stifling Woods", "", setName)
                .WithText("When Revealed: Either remove 6 progress from the current quest, or remove 1 time counter from the current quest.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, remove all progress from the current quest.")
                .WithInfo(8, 2, Artist.Suzanne_Helmigh));
            Cards.Add(Card.Treachery("Fangorn's Anger", "", setName)
                .WithText("When Revealed: If Mugash is attached to a hero, deal 2 damage to that hero. If Mugash is not attached to a hero, Fangorn's Anger gains surge and doomed 2.")
                .WithShadow("Shadow: After this attack, if Mugash is attached to a hero, attacking enemy engages the player who controls that hero.")
                .WithInfo(9, 2, Artist.Mariusz_Gandzel));
        }
    }
}