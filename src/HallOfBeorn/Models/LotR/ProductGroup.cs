using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR.ProductGroups;

namespace HallOfBeorn.Models.LotR
{
    public class ProductGroup
    {
        protected ProductGroup(string name)
        {
            Name = name;
            ChildProducts = new List<Product>();
        }

        protected void AddProduct(Product product)
        {
            ChildProducts.Add(product);
        }

        public string Name { get; private set; }
        public Product MainProduct { get; set; }
        public List<Product> ChildProducts { get; private set; }

        #region Static Members
        public static ProductGroup ShadowsOfMirkwood = new ShadowsOfMirkwoodProductGroup();
        public static ProductGroup TheDwarrowdelf = new TheDwarrowdelfProductGroup();
        public static ProductGroup AgainstTheShadow = new AgainstTheShadowProductGroup();
        public static ProductGroup TheRingMaker = new TheRingMakerProductGroup();
        public static ProductGroup AngmarAwakened = new AngmarAwakenedProductGroup();
        public static ProductGroup DreamChaser = new DreamChaserProductGroup();
        public static ProductGroup Haradrim = new HaradrimProductGroup();
        public static ProductGroup Rhovanion = new RhovanionProductGroup();
        public static ProductGroup TheHobbitSaga = new TheHobbitSagaProductGroup();
        public static ProductGroup TheLordOfTheRingsSaga = new TheLordOfTheRingsSagaProductGroup();
        public static ProductGroup GenConDeck = new GenConDeckProductGroup();
        public static ProductGroup NightmareDeck = new NightmareDeckProductGroup();
        public static ProductGroup DoomMastered = new DoomMasteredProductGroup();
        #endregion
    }
}