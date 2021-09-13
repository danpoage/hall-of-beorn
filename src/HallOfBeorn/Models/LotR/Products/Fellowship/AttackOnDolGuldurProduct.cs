using System;

namespace HallOfBeorn.Models.LotR.Products.Fellowship
{
    public class AttackOnDolGuldurProduct : Product
    {
        public AttackOnDolGuldurProduct()
            : base("Attack on Dol Guldur", "OP050", ImageType.Jpg, new DateTime(2018, 2, 15))
        {
            AddCardSet(CardSet.AttackOnDolGuldur);

            AddScenario(Scenario.AttackOnDolGuldur);
        }
    }
}