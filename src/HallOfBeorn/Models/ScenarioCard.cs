using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class ScenarioCard
    {
        public ScenarioCard(Tuple<Card, byte, byte, byte> map)
        {
            Init(map.Item1);

            EasyQuantity = map.Item2;
            NormalQuantity = map.Item3;
            NightmareQuantity = map.Item4;
        }

        public ScenarioCard(Card card)
        {
            Init(card);

            NightmareQuantity = card.Quantity;

            if (card.CardSet.Cycle == "NIGHTMARE")
            {
                NormalQuantity = 0;
                EasyQuantity = 0;
            }
            else
            {
                NormalQuantity = card.Quantity;
                EasyQuantity = card.EasyModeQuantity.HasValue ? card.EasyModeQuantity.Value : card.Quantity;
            }
        }

        private void Init(Card card)
        {
            Card = card;
            Title = card.Title;
            Set = card.CardSet.NormalizedName;
            EncounterSet = card.EncounterSet;
            EncounterSetNumber = card.CardSet.Number;
            Link = string.Format("/Cards/Details/{0}", card.Slug);
        }

        public Card Card { get; private set; }
        public string Title { get; private set; }
        public string Set { get; private set; }
        public string EncounterSet { get; private set; }
        public int EncounterSetNumber { get; private set; }
        public string EncounterSetImage
        {
            get { return string.Format("/Images/Cards/{0}/{1}.png", Set.ToUrlSafeString(), EncounterSet.ToUrlSafeString()); }
        }
        public string Link { get; private set; }

        public int NormalQuantity { get; set; }
        public int NightmareQuantity { get; set; }
        public int EasyQuantity { get; set; }
    }
}