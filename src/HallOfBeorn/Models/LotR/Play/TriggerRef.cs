using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class TriggerRef
        : CardRef
    {
        public TriggerRef(CardRef card)
            : base(card.Deck, card.Card, card.Id)
        {
            ActiveSide = CardSide.Front;
        }

        public CardSide ActiveSide { get; set; }
        public byte ResourceCost { get; set; }
        public List<Target> CostTargets = new List<Target>();
        public List<Target> ResultTargets = new List<Target>();
    }
}