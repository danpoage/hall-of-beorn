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
                var resources = new Dictionary<Sphere, uint> {
                    { Sphere.Neutral, 0},
                    { Sphere.Leadership, 0},
                    { Sphere.Tactics, 0 },
                    { Sphere.Spirit, 0 },
                    { Sphere.Lore, 0 },
                    { Sphere.Baggins, 0 },
                    { Sphere.Fellowship, 0 },
                    { Sphere.Mastery, 0 }
                };

                var spheres = new HashSet<Sphere>
                {
                    Sphere.Neutral, Sphere.Leadership, Sphere.Tactics, Sphere.Spirit, Sphere.Lore,
                    Sphere.Baggins, Sphere.Fellowship, Sphere.Mastery
                };

                foreach (var hero in player.Heroes)
                {
                    foreach (var sphere in spheres)
                    {
                        if (hero.HasSphere(sphere))
                        {
                            resources[sphere] += hero.ResourceTokens;
                        }
                    }
                }

                var playChoice = new Choice(ChoiceType.Exclusive)
                {
                    Description = string.Format("{0}, which card do you want to play?", player.Name),
                    FrameworkStep = Play.FrameworkStep.Planning_Special_Player_Action_Window,
                };

                //TODO: Add actions from cards in play

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
                        playChoice.Options.Add(new Option { 
                            Description = string.Format("Play {0} for {1} resources ({2})", 
                            card.Card.NormalizedTitle, card.Card.ResourceCost.GetValueOrDefault(0), card.Card.Sphere),
                            IsAccept = true,
                            Context = player.Name,
                            Value = card.Id
                        });
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
                            gm.BeingPlayed = new CardInPlay(handCard.Deck, handCard.Card);
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