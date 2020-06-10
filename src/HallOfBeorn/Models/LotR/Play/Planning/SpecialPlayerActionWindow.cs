using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Planning
{
    public class SpecialPlayerActionWindow
        : GameSegment
    {
        public SpecialPlayerActionWindow()
            : base(Phase.Planning, FrameworkStep.Planning_Special_Player_Action_Window)
        {
        }

        private bool MatchesCriteria(Game game, IEnumerable<Effect> effects)
        {
            var hasCriteria = effects.Any(ce => ce.Criteria != null);
            if (hasCriteria)
            {
                foreach (var ce in effects.Where(ce => ce.Criteria != null))
                {
                    if (!ce.Criteria(game))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void AddCostAndResultTargets(
            Player player, CardRef card, Choice choice, IEnumerable<Target> costTargets, IEnumerable<Target> resultTargets)
        {
            foreach (var costTarget in costTargets)
            {
                foreach (var resultTarget in resultTargets)
                {
                    var sphere = card.Card.Sphere == Sphere.Neutral ? "" : card.Card.Sphere.ToString() + " ";
                    choice.Options.Add(new Option
                    {
                        Description = string.Format("Play {0} for {1} {2}resources, targeting {3} for cost and {4} for results",
                            card.Name, card.Card.ResourceCost, sphere, costTarget.Name, resultTarget.Name),
                        IsAccept = true,
                        Context = player.Name,
                        Value = card.Id,
                        CostTarget = costTarget.Id,
                        ResultTarget = resultTarget.Id,
                    });
                }
            }
        }

        private void AddCostTargets(
            Player player, CardRef card, Choice choice, IEnumerable<Target> targets)
        {
            foreach (var target in targets)
            {
                var sphere = card.Card.Sphere == Sphere.Neutral ? "" : card.Card.Sphere.ToString() + " ";
                choice.Options.Add(new Option
                {
                    Description = string.Format("Play {0} for {1} {2}resources, targeting {3}",
                        card.Name, card.Card.ResourceCost, sphere, target.Name),
                    IsAccept = true,
                    Context = player.Name,
                    Value = card.Id,
                    CostTarget = target.Id,
                });
            }
        }

        private void AddResultTargets(
            Player player, CardRef card, Choice choice, IEnumerable<Target> targets)
        {
            foreach (var target in targets)
            {
                var sphere = card.Card.Sphere == Sphere.Neutral ? "" : card.Card.Sphere.ToString() + " ";
                choice.Options.Add(new Option
                {
                    Description = string.Format("Play {0} for {1} {2}resources, targeting {3}",
                        card.Name, card.Card.ResourceCost, sphere, target.Name),
                    IsAccept = true,
                    Context = player.Name,
                    Value = card.Id,
                    ResultTarget = target.Id,
                });
            }
        }

        private bool AddTargetOptions(
            Game game, Player player, CardRef card, Choice choice, IEnumerable<Effect> effects)
        {
            var hasCostTargets = effects.Any(ef => ef.GetCostTargets != null);
            var costTargets = effects.Where(ef => ef.GetCostTargets != null).SelectMany(ef => ef.GetCostTargets(game));

            if (hasCostTargets && costTargets.Count() == 0)
                return false;

            var hasResultTargets = effects.Any(ef => ef.GetResultTargets != null);
            var resultTargets = effects.Where(ef => ef.GetResultTargets != null).SelectMany(ef => ef.GetResultTargets(game));

            if (hasResultTargets && resultTargets.Count() == 0)
                return false;

            if (hasCostTargets && hasResultTargets)
            {
                AddCostAndResultTargets(player, card, choice, costTargets, resultTargets);
            }
            else if (hasCostTargets)
            {
                AddCostTargets(player, card, choice, costTargets);
            }
            else if (hasResultTargets)
            {
                AddResultTargets(player, card, choice, resultTargets);
            }
            return true;
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            var effects = new List<Effect>();

            var activePlayer = game.ActivePlayer();

            if (game.BeingPlayed != null)
            {
                return PlayACard.PayForACard(game);
            }

            foreach (var player in game.Players)
            {
                var resources = player.GetResourceMap();

                var playChoice = new Choice(ChoiceType.Exclusive)
                {
                    Description = string.Format("{0}, which card do you want to play?", player.Name),
                    FrameworkStep = Play.FrameworkStep.Planning_Special_Player_Action_Window,
                };

                foreach (var card in player.Hand)
                {
                    //Only the active player can play allies, attachments, and side quests
                    if (!player.IsActivePlayer && (
                        card.Card.CardType == CardType.Ally || card.Card.CardType == CardType.Attachment || card.Card.CardType == CardType.Player_Side_Quest))
                    {
                        continue;
                    }

                    if (resources[card.Card.Sphere]
                        >= card.Card.ResourceCost.GetValueOrDefault(0))
                    {
                        var cardEffects = LookupEffects(card.Card.Slug, CardSide.Front)
                            .Where(ef => ef.Trigger == Trigger.Player_Action_Window);

                        if (!MatchesCriteria(game, cardEffects))
                            continue;

                        var hasCostTargets = cardEffects.Any(ce => ce.GetCostTargets != null);
                        var hasResultTargets = cardEffects.Any(ce => ce.GetResultTargets != null);

                        if (hasCostTargets || hasResultTargets)
                        {
                            if (!AddTargetOptions(game, player, card, playChoice, cardEffects))
                                continue;
                        }
                        else
                        {
                            playChoice.Options.Add(new Option { 
                                Description = string.Format("Play {0} for {1} {2} resources", 
                                    card.Name, card.Card.ResourceCost, card.Card.Sphere),
                                IsAccept = true,
                                Context = player.Name,
                                Value = card.Id
                            });
                        }
                    }
                }

                playChoice.Options.Add(new Option { Description = "Pass on playing cards", IsDecline = true, Context = player.Name });

                var playEffect = Effect.Create(
                    FrameworkStep.Planning_Special_Player_Action_Window, EffectTiming.When, Trigger.When_Player_Takes_an_Action, "When player takes an action")
                    .WithChoice(playChoice)
                    .Accept((gm) =>
                        {
                            var selected = gm.CurrentChoice.Options.First(opt => opt.IsAccept && opt.IsChosen);
                            var currentPlayer = gm.Players.First(p => p.Name == selected.Context);

                            //TODO: Add Status to indicate current player is playing a card
                            currentPlayer.FrameworkStep = Play.FrameworkStep.Planning_Special_Player_Action_Window;
                            var handCard = currentPlayer.Hand.First(h => h.Id == selected.Value);
                            gm.BeingPlayed = new CardInPlay(handCard.Deck, handCard.Card, handCard.Id);
                            return string.Format("{0} will play {1}", currentPlayer.Name, handCard.Card.NormalizedTitle);
                        })
                    .Decline((gm) =>
                        {
                            var active = gm.ActivePlayer();
                            active.HasPassedOnActionOpportunity = true;

                            if (gm.Players.All(p => p.HasPassedOnActionOpportunity))
                            {
                                gm.FrameworkStep = Play.FrameworkStep.Planning_End;
                                return "All players have passed on their action opportunities";
                            } else {
                                var next = gm.MakeNextPlayerActive();
                                return string.Format("{0} passed on their action opportunity, {1} is now the active player",
                                    active.Name, next.Name);
                            }
                        });

                //TODO: Only add effect is this player has cards they can play
                effects.Add(playEffect);
            }

            return effects;
        }
    }
}