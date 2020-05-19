﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Setup
{
    public class PlaceHeroesAndSetInitialThreat
        : GameSegment
    {
        public override IEnumerable<Effect> Execute(Game game)
        {
            var effects = new List<Effect>();

            foreach (var player in game.Players)
            {
                var placeHeroEffects = player.Heroes.SelectMany(h => 
                    LookupEffects(h.Card.Slug, CardSide.Front).Where(ef => ef.Trigger == Trigger.Setup_Place_Hero));

                var determineThreatEffects = player.Heroes.SelectMany(h => 
                    LookupEffects(h.Card.Slug, CardSide.Front).Where(ef => ef.Trigger == Trigger.Setup_Determine_Hero_Starting_Threat));

                player.IsActivePlayer = true;

                game.Log(string.Format("Placed Heroes for {0}", player.Name));

                foreach (var hero in player.Heroes)
                {
                    var placeHero = new GameEvent { Description = "Place Hero" +  hero.Card.Title };
                    placeHero.CardsInPlay.Add(hero);
                    //ExecuteAutomaticEffects(placeHeroEffects);
                    game.Log(placeHero);
                    player.PlayArea.Add(hero);

                    var determineThreat = new GameEvent{Description = "Determine Starting Threat for Hero " + hero.Card.Title};
                    determineThreat.CardsInPlay.Add(hero);
                    //ExecuteAutomaticEffects(determineThreatEffects);
                    game.Log(determineThreat);
                    player.Threat += hero.Card.ThreatCost.Value;
                }

                game.Log(string.Format("Set Initial Threat for {0} to {1}", player.Name, player.Threat));
            }

            return effects;
        }
    }
}