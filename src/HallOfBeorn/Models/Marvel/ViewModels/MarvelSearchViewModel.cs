using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HallOfBeorn.Models.Marvel.ViewModels
{
    public class MarvelSearchViewModel
    {
        private readonly List<MarvelCardViewModel> cards = new List<MarvelCardViewModel>();

        public string Query { get; set; }
        public MarvelSearchSort? Sort { get; set; }
        public MarvelSearchView? View { get; set; }

        public string Product { get; set; }
        public string EncounterSet { get; set; }

        public MarvelCardType? CardType { get; set; }
        
        public MarvelDeckType? DeckType { get; set; }
        public Uniqueness? IsUnique { get; set; }
        
        public NumericOperator? ThwartOp { get; set; }
        public byte? Thwart { get; set; }
        public NumericOperator? AttackOp { get; set; }
        public byte? Attack { get; set; }
        public NumericOperator? DefenseOp { get; set; }
        public byte? Defense { get; set; }
        public NumericOperator? RecoverOp { get; set; }
        public byte? Recover { get; set; }
        public NumericOperator? HitPointsOp { get; set; }
        public string HitPoints { get; set; }
        public NumericOperator? HandSizeOp { get; set; }
        public string HandSize { get; set; }
        
        public NumericOperator? CostOp { get; set; }
        public byte? Cost { get; set; }
        
        public string Trait { get; set; }
        public string Keyword { get; set; }
        
        public static IEnumerable<SelectListItem> Sorts
        {
            get { return typeof(MarvelSearchSort).GetSelectListItems(", "); }
        }

        public static IEnumerable<SelectListItem> Views
        {
            get { return typeof(MarvelSearchView).GetSelectListItems(" "); }
        }

        public static IEnumerable<SelectListItem> NumericOperators
        {
            get {
                Func<NumericOperator, string> mapFunction = (n) =>
                {
                    switch (n) {
                        case NumericOperator.eq:
                        default:
                            return "=";
                        case NumericOperator.gt:
                            return ">";
                        case NumericOperator.gteq:
                            return ">=";
                        case NumericOperator.lt:
                            return "<";
                        case NumericOperator.lteq:
                            return "<=";
                    }
                };
                return typeof(NumericOperator).GetSelectListItems<NumericOperator>(mapFunction); 
            }
        }

        public static IEnumerable<SelectListItem> CardTypes
        {
            get { return typeof(MarvelCardType).GetSelectListItems(" "); }
        }

        public static IEnumerable<SelectListItem> DeckTypes
        {
            get { return typeof(MarvelDeckType).GetSelectListItems(" "); }
        }

        public static IEnumerable<SelectListItem> Products
        {
            get;
            set;
        }

        public int GetResultsCount()
        {
            return cards.Count;
        }

        public IEnumerable<MarvelCardViewModel> Cards()
        {
            return cards;
        }

        public void Init(IEnumerable<MarvelProduct> products)
        {
            if (string.IsNullOrEmpty(Product) || Product == "None" || Product == "Any") {
                Product = null;
            }
            if (CardType.HasValue && CardType.Value == MarvelCardType.None) {
                CardType = null;
            }
            if (DeckType.HasValue && DeckType.Value == MarvelDeckType.None) {
                DeckType = null;
            }

            Products = products.Select(p => p.Name).GetSelectListItems();
        }

        public void LoadCards(IEnumerable<MarvelCardViewModel> viewModels)
        {
            cards.AddRange(viewModels);
        }
    }
}