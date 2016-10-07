using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham
{
    public class ArkhamCardSet
    {
        public ArkhamCardSet(string name)
        {
            this.Name = name;

            Initialize();
        }

        private readonly List<ArkhamCard> cards = new List<ArkhamCard>();

        protected virtual void Initialize()
        {
        }

        protected void AddCard(ArkhamCard card)
        {
            cards.Add(card);
        }

        public string Name { get; set; }

        public IEnumerable<ArkhamCard> Cards()
        {
            return cards;
        }
    }
}