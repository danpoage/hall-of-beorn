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

        private readonly Dictionary<string, List<Effect>> effectsBySlug
            = new Dictionary<string, List<Effect>>();

        private LotRCard GetCard(string slug)
        {
            return cardRepository.FindBySlug(slug);
        }

        private void Init()
        {
            effectsBySlug["Aragorn-Core"] = new List<Effect>
            {
                Effect.Response(GetCard("Aragorn-Core"), Trigger.After_Self_Commits_to_Quest)
                    //TODO: Add cost choices and readying effect
            };
        }

        public IEnumerable<Effect> GetEffects(string slug)
        {
            return effectsBySlug.ContainsKey(slug)
                ? effectsBySlug[slug]
                : Enumerable.Empty<Effect>();
        }
    }
}
