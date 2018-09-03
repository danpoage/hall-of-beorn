using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR.ProductGroups;

namespace HallOfBeorn.Models.LotR
{
    public class ProductGroup : IProductGroup<Product, CardSet, LotRCard>
    {
        protected ProductGroup(string name)
        {
            Name = name;
        }

        protected void AddProduct(Product product)
        {
            childProducts.Add(product);
        }

        private readonly List<Product> childProducts = new List<Product>();

        public string Name { get; private set; }
        public string Abbreviation { get { return Name; } }

        public Product MainProduct { get; protected set; }
        public IEnumerable<Product> ChildProducts { get { return childProducts; } }

        #region Static Members
        public static ProductGroup ShadowsOfMirkwood = new ShadowsOfMirkwoodProductGroup();
        public static ProductGroup TheDwarrowdelf = new TheDwarrowdelfProductGroup();
        public static ProductGroup AgainstTheShadow = new AgainstTheShadowProductGroup();
        public static ProductGroup TheRingMaker = new TheRingMakerProductGroup();
        public static ProductGroup AngmarAwakened = new AngmarAwakenedProductGroup();
        public static ProductGroup DreamChaser = new DreamChaserProductGroup();
        public static ProductGroup Haradrim = new HaradrimProductGroup();
        public static ProductGroup EredMithrin = new EredMithrinProductGroup();
        public static ProductGroup TheHobbitSaga = new TheHobbitSagaProductGroup();
        public static ProductGroup TheLordOfTheRingsSaga = new TheLordOfTheRingsSagaProductGroup();
        public static ProductGroup Starter = new StarterProductGroup();
        public static ProductGroup GenConDeck = new GenConDeckProductGroup();
        public static ProductGroup NightmareDeck = new NightmareDeckProductGroup();
        public static ProductGroup DoomMastered = new DoomMasteredProductGroup();
        #endregion
    }
}