using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class Product
    {
        protected Product(string name, string code, ImageType imageType)
        {
            this.Name = name;
            this.Code = code;
            this.ImageType = imageType;
            this.CardSets = new List<CardSet>();
        }

        public string Name { get; private set; }
        public string Code { get; private set; }
        public ImageType ImageType { get; private set; }
        public bool IsPremier { get; protected set; }
        public bool IsNewSubGroup { get; protected set; }
        public string RulesUrl { get; protected set; }

        public List<CardSet> CardSets { get; private set; }

        public static ProductGroup ShadowOfMirkwoodProductGroup = new Models.Products.ShadowsOfMirkwoodProductGroup();
        public static ProductGroup TheDwarrowdelProductGroup = new Models.Products.TheDwarrowdelfProductGroup();
        public static ProductGroup AgainstTheShadowProductGroup = new Models.Products.AgainstTheShadowProductGroup();
        public static ProductGroup TheRingmakerProductGroup = new Models.Products.TheRingMakerProductGroup();
        public static ProductGroup AngmarAwakenedProductGroup = new Models.Products.AngmarAwakenedProductGroup();
        public static ProductGroup TheHobbitSagaProductGroup = new Models.Products.TheHobbitSagaProductGroup();
        public static ProductGroup TheLordOfTheRingsProductGroup = new Models.Products.TheLordOfTheRingsSagaProductGroup();
        public static ProductGroup GenConProductGroup = new Models.Products.GenConDeckProductGroup();
        public static ProductGroup NightmareDeckProductGroup = new Models.Products.NightmareDeckProductGroup();
        public static ProductGroup CustomProductGroup = new Models.Products.CustomProductGroup();
    }
}