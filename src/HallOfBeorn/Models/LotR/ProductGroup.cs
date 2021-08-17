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

        protected void AddMainProduct(Product product)
        {
            mainProducts.Add(product);
        }

        protected void AddChildProduct(Product product)
        {
            childProducts.Add(product);
        }

        private readonly List<Product> mainProducts = new List<Product>();
        private readonly List<Product> childProducts = new List<Product>();

        public string Name { get; private set; }
        public string Abbreviation { get { return Name; } }

        public IEnumerable<Product> MainProducts { get { return mainProducts; } }
        public IEnumerable<Product> ChildProducts { get { return childProducts; } }

        #region Static Members
        public static ProductGroup ShadowsOfMirkwood = new ShadowsOfMirkwoodProductGroup();
        public static ProductGroup Dwarrowdelf = new DwarrowdelfProductGroup();
        public static ProductGroup AgainstTheShadow = new AgainstTheShadowProductGroup();
        public static ProductGroup TheRingMaker = new TheRingMakerProductGroup();
        public static ProductGroup AngmarAwakened = new AngmarAwakenedProductGroup();
        public static ProductGroup DreamChaser = new DreamChaserProductGroup();
        public static ProductGroup Haradrim = new HaradrimProductGroup();
        public static ProductGroup EredMithrin = new EredMithrinProductGroup();
        public static ProductGroup VengeanceOfMordor = new VengeanceOfMordorProductGroup();
        public static ProductGroup TheHobbitSaga = new TheHobbitSagaProductGroup();
        public static ProductGroup TheLordOfTheRingsSaga = new TheLordOfTheRingsSagaProductGroup();
        public static ProductGroup GenConDeck = new GenConDeckProductGroup();
        public static ProductGroup FellowshipDeck = new FellowshipDeckProductGroup();
        public static ProductGroup CustomScenarioKits = new CustomScenarioKitProductGroup();
        public static ProductGroup ScenarioPack = new ScenarioPackProductGroup();
        
        public static ProductGroup ShadowsOfMirkwoodNightmare = new ShadowsOfMirkwoodNightmareProductGroup();
        public static ProductGroup DwarrowdelfNightmare = new DwarrowdelfNightmareProductGroup();
        public static ProductGroup AgainstTheShadowNightmare = new AgainstTheShadowNightmareProductGroup();
        public static ProductGroup TheRingMakerNightmare = new TheRingMakerNightmareProductGroup();
        public static ProductGroup AngmarAwakenedNightmare = new AngmarAwakenedNightmareProductGroup();
        public static ProductGroup DreamChaserNightmare = new DreamChaserNightmareProductGroup();
        public static ProductGroup TheHobbitSagaNightmare = new TheHobbitSagaNightmareProductGroup();
        public static ProductGroup TheLordOfTheRingsSagaNightmare = new TheLordOfTheRingsSagaNightmareProductGroup();

        public static ProductGroup DoomMastered = new DoomMasteredProductGroup();

        public static ProductGroup OathsOfTheRohirrim = new OathsOfTheRohirrimProductGroup();
        public static ProductGroup TheScouringOfTheShire = new TheScouringTheShireProductGroup();
        #endregion
    }
}