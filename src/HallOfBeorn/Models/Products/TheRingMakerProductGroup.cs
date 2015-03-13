using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheRingMakerProductGroup : ProductGroup
    {
        public TheRingMakerProductGroup()
            : base("The Ring-maker Cycle")
        {
            MainProduct = new TheVoiceOfIsengardProduct();
            AddProduct(new TheDunlandTrapProduct());
            AddProduct(new TheThreeTrialsProduct());
            AddProduct(new TroubleInTharbadProduct());
            AddProduct(new TheNinInEilphProduct());
            AddProduct(new CelebrimborsSecretProduct());
            AddProduct(new TheAntleredCrownProduct());
        }
    }
}