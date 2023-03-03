using System;

namespace HallOfBeorn.Models.LotR.Products.Campaign
{
    public class DreamChaserCampaignProduct
        : Product
    {
        public DreamChaserCampaignProduct()
            : base("Dream-chaser Campaign Expansion", "MEC111", ImageType.Jpg, new DateTime(2023, 4, 15))
        {
            AddCardSet(CardSet.DreamChaserCampaignExpansion);
        }
    }
}