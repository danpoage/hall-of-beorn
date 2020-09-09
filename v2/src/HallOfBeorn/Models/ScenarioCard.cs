using System;
using System.Collections.Generic;
using System.Text;

namespace HallOfBeorn.Models
{
    public class ScenarioCard
    {
        public ScenarioCard(Card card)
        {
            Title = card.Title;
            Slug = card.Slug;
            EasyQuantity = card.EasyModeQuantity;
            NormalQuantity = card.Quantity;
        }
        
        public ScenarioCard(Card card, Card nightmareSetup)
        {
            Title = card.Title;
            Slug = card.Slug;
            NightmareQuantity = nightmareSetup.NightmareQuantityMap.ContainsKey(card.Slug)
                ? nightmareSetup.NightmareQuantityMap[card.Slug]
                : card.Quantity;
        }

        public Content Title { get; }
        public string Slug { get; }
        public byte? EasyQuantity { get; }
        public byte? NormalQuantity { get; }
        public byte? NightmareQuantity { get; }
    }
}
