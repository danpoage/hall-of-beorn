﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Setup
{
    public class DrawSetupHand
        : GameSegment
    {
        public DrawSetupHand()
            : base(SetupStep.Setup_Draw_Setup_Hand, Phase.None, FrameworkStep.None)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            game.Phase = Phase.None;
            game.SetupStep = SetupStep.Setup_Draw_Setup_Hand;

            var effects = LookupEffectsByTrigger(Trigger.Setup_Determine_Starting_Hand_Size);

            foreach (var player in game.Players)
            {
                player.IsActivePlayer = true;
                player.SetupStep = SetupStep.Setup_Draw_Setup_Hand;

                var hand = player.Deck.Draw(player.SetupHandSize);
                player.Hand.AddRange(hand);
                game.Log(string.Format("Player {0} Draws {1} Cards in their Setup Hand", player.Name, player.SetupHandSize));

                var handList = string.Join("\r\n", player.Hand.Select(h => h.Card.NormalizedTitle));

                var mulliganChoice = new Choice(ChoiceType.Exclusive) { 
                    Description = string.Format("Does {0} want to take a mulligan?\r\nExisting hand:\r\n{1}", player.Name, handList)
                };
                mulliganChoice.Options.Add(new Option { Description = "Keep your starting hand", Context = player.Name, IsDecline = true });
                mulliganChoice.Options.Add(new Option { Description = "Draw a new starting hand", Context = player.Name, IsAccept = true });
                
                var mulliganEffect = Effect.Create(SetupStep.Setup_Draw_Setup_Hand, EffectTiming.After, Trigger.Setup_Draw_Setup_Hand,
                    string.Format("Player {0} may take a mulligan", player.Name))
                    .WithCriteria((gm) => true)
                    .WithChoice(mulliganChoice)
                    .Accept((gm) => {
                        var mulliganPlayer = gm.Players.First(p => p.Name == player.Name);
                        var oldHand = mulliganPlayer.Hand.ToList();
                        mulliganPlayer.Hand.Clear();
                        mulliganPlayer.Deck.ShuffleIntoDeck(oldHand);
                        var newHand = mulliganPlayer.Deck.Draw(mulliganPlayer.SetupHandSize);
                        mulliganPlayer.Hand.AddRange(newHand);
                        mulliganPlayer.HasTakenMulligan = true;
                        return string.Format("{0} accepts a mulligan, drawing {1} cards:\r\n{2}", 
                            mulliganPlayer.Name, mulliganPlayer.SetupHandSize, string.Join("\r\n", newHand.Select(h => h.Card.Title)));
                    })
                    .Decline((gm) => {
                        var mulliganPlayer = gm.Players.First(p => p.Name == player.Name);
                        mulliganPlayer.HasTakenMulligan = false;
                        return string.Format("{0} declines a mulligan, keeping their opening hand", mulliganPlayer.Name);
                    });

                effects.Add(mulliganEffect);
            }

            return effects;
        }
    }
}
