using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Services.LotR;

namespace HallOfBeorn.Models.LotR.Play.Repositories
{
    public class EffectRepository
    {
        public EffectRepository(LotRCardRepository cardRepository)
        {
            this.cardRepository = cardRepository;

            Init();
        }

        private readonly LotRCardRepository cardRepository;

        private readonly Dictionary<string, List<Effect>> frontEffects
            = new Dictionary<string, List<Effect>>();

        private readonly Dictionary<string, List<Effect>> backEffects
            = new Dictionary<string, List<Effect>>();

        private LotRCard GetCard(string slug)
        {
            return cardRepository.FindBySlug(slug);
        }

        private void Init()
        {
            frontEffects["Aragorn-Core"] = new List<Effect>
            {
                Effect.Create(GetCard("Aragorn-Core"), Trigger.After_Self_Commits_to_Quest)
                    //TODO: Add cost choices and readying effect
            };

            frontEffects["Common-Cause-Core"] = new List<Effect>
            {
                Effect.Create(GetCard("Common-Cause-Core"), Trigger.Player_Action_Window)
                .WithCriteria((gm) => 
                    gm.ActivePlayer().Heroes.Any(h => !h.IsExhausted) && gm.ActivePlayer().Heroes.Any(h => h.IsExhausted))
                .WithCostTargets((gm) => gm.ActivePlayer().Heroes.Where(h => !h.IsExhausted))
                .WithResultTargets((gm) => gm.ActivePlayer().Heroes.Where(h => h.IsExhausted))
                .Accept((gm) => 
                    {
                        var exhaust = gm.CurrentCostTargets.First();
                        var ready = gm.CurrentResultTargets.Last();
                        return string.Format("Exhaust {0} to ready {1}", exhaust.Name, ready.Name);
                    })
            };

            frontEffects["Radagast's-Cunning-Core"] = new List<Effect>
            {
                Effect.Create(GetCard("Radagast's-Cunning-Core"), Trigger.Player_Action_Window)
                .WithCriteria((gm) => gm.Phase == Phase.Quest)
                .WithResultTargets((gm) => gm.StagingArea.Where(sa => sa.Card.CardType == CardType.Enemy))
                .Accept((gm) =>
                {
                    var target = gm.CurrentResultTargets.Single();
                    var inPlay = gm.StagingArea.Single(sa => sa.Id == target.Id);
                    var desc = string.Format("{0} does not count its threat this phase.", target.Name);
                    gm.PendingEffects.Add(
                        Effect.Create(FrameworkStep.Quest_Resolution, EffectTiming.When, Trigger.Determine_Card_Threat_Value,
                            "Until the end of the phase, that enemy does not contribute its Threat.")
                        .Accept((gm2) =>
                        {
                            gm2.StagingArea.Single(sa => sa.Id == target.Id).Threat = 0;
                            return desc;
                        }));
                    return desc;
                })
            };

            frontEffects["Sneak-Attack-Core"] = new List<Effect>
            {
                Effect.Create(GetCard("Sneak-Attack-Core"), Trigger.Player_Action_Window)
                .WithResultTargets(gm => {
                    return gm.ActivePlayer().Hand.Where(h => h.Card.CardType == CardType.Ally);
                })
                .Accept((gm) =>
                    {
                        var activePlayer = gm.ActivePlayer();
                        var target = gm.CurrentResultTargets.Single();

                        var inHand = activePlayer.Hand.Single(h => h.Id == target.Id);

                        activePlayer.Hand.Remove(inHand);

                        var enteringPlay = new CardInPlay(inHand.Deck, inHand.Card);
                        activePlayer.PlayArea.Add(enteringPlay);

                        gm.EnteringPlay.Add(enteringPlay);
                        
                        return string.Format("Putting {0} into play", target.Name); 
                    })
            };

            frontEffects["Flies-and-Spiders-Core"] = new List<Effect>
            {
                Effect.Create(GetCard("Flies-and-Spiders-Core"), Trigger.Setup_Setup_Quest_Card)
                .Auto().Accept((g) => {
                    var spider = g.EncounterDeck.RemoveCardByTitle("Forest Spider");
                    g.StagingArea.Add(new CardInPlay(g.EncounterDeck, spider));
                    var road = g.EncounterDeck.RemoveCardByTitle("Old Forest Road");
                    g.StagingArea.Add(new CardInPlay(g.EncounterDeck, road));
                    g.EncounterDeck.Shuffle();
                    return "Search the encounter deck for 1 copy of the Forest Spider and 1 copy of the Old Forest Road, and add them to the staging area. Then, shuffle the encounter deck.";
                })
                //.
            };
        }

        public IEnumerable<Effect> GetEffects(string slug, CardSide side)
        {
            var map = side == CardSide.Front
                ? frontEffects
                : backEffects;

            return map.ContainsKey(slug)
                ? map[slug]
                : Enumerable.Empty<Effect>();
        }
    }
}
