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
