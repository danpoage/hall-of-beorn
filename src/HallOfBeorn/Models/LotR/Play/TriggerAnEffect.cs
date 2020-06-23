using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class TriggerAnEffect
        : GamePart
    {
        public TriggerAnEffect(GameSegment segment, FrameworkStep step)
            : base(segment, step, null)
        {
        }

        private IEnumerable<Option> GetPaymentOptions(Game game, Player activePlayer)
        {
            var options = new List<Option>();

            var beingPlayed = game.BeingPlayed;

            var sphere = beingPlayed.Card.Sphere;
            var cost = beingPlayed.Card.ResourceCost.GetValueOrDefault(0);

            var heroes = activePlayer.Heroes.Where(h => h.HasSphere(sphere) && h.ResourceTokens > 0).ToList();

            var available = activePlayer.GetAvailableResources(beingPlayed.Card.Sphere);

            if (available < cost)
            {
                options.Add(new Option
                {
                    Description = string.Format("{0}, you don't have the resources to pay for {1}", activePlayer.Name, beingPlayed.Card.NormalizedTitle),
                    IsDecline = true,
                    Context = activePlayer.Name
                });
                return options;
            }

            
            Func<List<int>, int, List<int>> append = (existing, item) =>
                {
                    var result = new List<int>(existing);
                    result.Add(item);
                    return result;
                };

            Func<List<List<int>>, List<int>, List<List<int>>> permute = (existing, input) =>
                {
                    var permutations = new List<List<int>>();
                    if (existing.Count == 0)
                    {
                        foreach (var i in input)
                        {
                            permutations.Add(new List<int> { i });
                        }
                    }
                    else
                    {
                        foreach (var e in existing)
                        {
                            foreach (var i in input)
                            {
                                permutations.Add(append(e, i)); 
                            }
                        }
                    }
                    return permutations;
                };

            Func<List<int>, string> getDescription = (combo) =>
                {
                    var values = new List<string>();

                    for (var i=0;i<combo.Count;i++)
                    {
                        var hero = heroes[i].Card.NormalizedTitle;
                        if (combo[i] == 1)
                            values.Add(string.Format("1 resource from {0}'s resource pool", hero));
                        else if (combo[i] > 1)
                            values.Add(string.Format("{0} resources from {1}'s resource pool", combo[i], hero));
                    }

                    return "Pay " + string.Join(", ", values);
                };

            Func<List<int>, string> getValue = (combo) =>
                {
                    var values = new List<string>();

                    for (var i=0;i<combo.Count;i++)
                    {
                        if (combo[i] > 0)
                        {
                            var hero = heroes[i].Card.NormalizedTitle;
                            values.Add(string.Format("{0}={1}", hero, combo[i]));
                        }
                    }

                    return string.Join(",", values);
                };

            var combinations = new List<List<int>>();

            for (var i=0;i<heroes.Count;i++)
            {
                var resources = new List<int>();
                var max = heroes[i].ResourceTokens >= cost ? cost : heroes[i].ResourceTokens;
                for (var j = 0; j <= max; j++)
                    resources.Add(j);

                combinations = permute(combinations, resources); 
            }

            foreach (var combo in combinations)
            {
                if (combo.Sum() == cost)
                {
                    options.Add(new Option
                    {
                        Description = getDescription(combo),
                        IsAccept = true,
                        Context = activePlayer.Name,
                        Value = getValue(combo),
                    });
                }
            }

            //Add the optional to cancel playing the current card
            options.Add(new Option
            {
                Description = string.Format("On second thought, let's not play {0}", beingPlayed.Card.NormalizedTitle),
                IsDecline = true,
                Context = activePlayer.Name,
            });

            return options;
        }

        public override ExecutionResult Execute(Game game)
        {
            var effects = new List<Effect>();

            var activePlayer = game.ActivePlayer();
            var beingPlayed = game.BeingPlayed;

            var beingPlayedChoice = new Choice(ChoiceType.Exclusive)
            {
                Description = string.Format("{0}, how do you want to pay for {1}?", activePlayer.Name, game.BeingPlayed.Card.NormalizedTitle),
                FrameworkStep = game.FrameworkStep,
            };

            //TODO: Algorithm to get payment options
            var cost = game.BeingPlayed.Card.ResourceCost.GetValueOrDefault(0);
            if (cost == 0)
            {
                beingPlayedChoice.Options.Add(new Option
                {
                    Description = string.Format("Play {0} for no cost", game.BeingPlayed.Card.NormalizedTitle),
                    IsAccept = true,
                    Context = activePlayer.Name,
                    Value = game.BeingPlayed.Id
                });
            }
            else if (game.BeingPlayed.Card.ResourceCost == Card.VALUE_X)
            {
                //TODO: Check for target-based costs like Stand and Fight/Reforged
                var available = activePlayer.GetAvailableResources(beingPlayed.Card.Sphere);
                var costEffect = Segment.LookupEffects(game.BeingPlayed.Card.Slug, CardSide.Front)
                    .FirstOrDefault(ef => ef.Trigger == Trigger.When_Determining_Cost);

                if (costEffect != null)
                {
                    beingPlayedChoice.Options.AddRange(costEffect.GetChoice(game).Options);
                }
                else
                {
                    //NOTE: This is an error
                    beingPlayedChoice.Options.Add(new Option{
                        Description = string.Format("No valid cost options for {0}", game.BeingPlayed.Name),
                        IsDecline = true,
                        Context = activePlayer.Name,
                    });
                }
            }
            else if (game.BeingPlayed.Card.ResourceCost == Card.VALUE_NA)
            {
                beingPlayedChoice.Options.Add(new Option
                {
                    Description = string.Format("{0} cannot be played from your hand", game.BeingPlayed.Card.NormalizedTitle),
                    IsDecline = true,
                    Context = activePlayer.Name,
                    Value = game.BeingPlayed.Id
                });
            }
            else
            {
                beingPlayedChoice.Options.AddRange(GetPaymentOptions(game, activePlayer));
            }

            var beingPlayedEffect = Effect.Create(FrameworkStep.Planning_Special_Player_Action_Window, EffectTiming.When, Trigger.When_Player_Plays_a_Card, "When a player plays a card")
                .WithChoice(beingPlayedChoice)
                .Accept((gm) =>
                {
                    var payment = gm.CurrentChoice.Options.Single(opt => opt.IsChosen).Value;
                    PayResourceCost(game, payment);

                    PutIntoPlay(game);

                    //TODO: Select a target for events/attachments
                    //TODO: Either move this card to discard or put it into play
                    return string.Format("{0} plays {1}", activePlayer.Name, beingPlayed.Card.NormalizedTitle);
                });

            effects.Add(beingPlayedEffect);

            return ExecutionResult.Create(effects);
        }

        private static void PayResourceCost(Game game, string payment)
        {
            foreach (var pay in payment.SafeSplit(','))
            {
                var tokens = pay.SafeSplit('=');
                if (tokens.Length == 2)
                {
                    var name = tokens[0];
                    uint amount = 0; uint.TryParse(tokens[1], out amount);

                    var payor = game.ActivePlayer().PlayArea.Single(p => p.Name == name);
                    payor.ResourceTokens -= amount;
                }
            }
        }

        //TODO: Turn this into a framework effect
        private static void PutIntoPlay(Game game)
        {
            var activePlayer = game.ActivePlayer();
            var beingPlayed = game.BeingPlayed;
            var cardType = beingPlayed.Card.CardType;
            if (cardType == CardType.Ally || cardType == CardType.Player_Side_Quest)
            {
                activePlayer.PlayArea.Add(new CardInPlay(activePlayer.Deck, beingPlayed.Card)); 
            }
            if (cardType == CardType.Attachment)
            {
                //Find target
            }
            if (cardType == CardType.Event)
            {
                //Find target
                activePlayer.Deck.Discard(new List<CardRef> { beingPlayed });
            }

            var inHand = activePlayer.Hand.SingleOrDefault(h => h.Id == beingPlayed.Id);
            activePlayer.Hand.Remove(inHand);

            game.BeingPlayed = null;
            game.BeingPlayedCostChoice = null;
        }
    }
}