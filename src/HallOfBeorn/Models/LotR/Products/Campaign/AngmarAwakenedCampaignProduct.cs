using System;

namespace HallOfBeorn.Models.LotR.Products.Campaign
{
    public class AngmarAwakenedCampaignProduct
        : Product
    {
        public AngmarAwakenedCampaignProduct()
            : base("Angmar Awakened Campaign Expansion", "MEC108", ImageType.Jpg, new DateTime(2022, 9, 16))
        {
            AddCardSet(CardSet.AngmarAwakenedCampaignExpansion);
        }
    }
}