using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class ProductViewModel
    {
        public ProductViewModel(Product product, Func<string, byte> getPopularity)
        {
            _product = product;
            Popularity = 0;

            var popCardCount = 0;
            var totalPop = 0;
            foreach (var set in product.CardSets().Where(setHasPopularity))
            {
                foreach (var card in set.Cards)
                {
                    var pop = getPopularity(card.Slug);
                    if (pop > 0)
                    {
                        popCardCount++;
                        totalPop += pop;
                    }
                }
            }

            if (popCardCount > 0 && totalPop > 0)
            {
                var avgPop = Convert.ToInt16(totalPop / popCardCount);
                if (avgPop > 7) 
                {
                    avgPop = 7;
                }
                Popularity = (byte)avgPop;
            }

            //var scenarioTitle = string.Empty;
            //const string linkFormat = "/Scenarios/Details/{0}";

            /*
            foreach (var cardSet in product.CardSets)
            {
                foreach (var card in cardSet.Cards.Where(x => (x.CardType == CardType.Quest || (x.EncounterSet != null && x.EncounterSet.EndsWith("Nightmare"))) && !string.IsNullOrEmpty(x.EncounterSet)))
                {
                    scenarioTitle = !string.IsNullOrEmpty(card.ScenarioTitle) ? card.ScenarioTitle : card.EncounterSet;

                    if (!_scenarios.Any(x => x.Title == scenarioTitle))
                    {
                        _scenarios.Add(new ScenarioViewModel { Title = scenarioTitle, Link = string.Format(linkFormat, scenarioTitle.ToUrlSafeString()) });
                    }
                }
            }*/
        }

        private Func<CardSet, bool> setHasPopularity = (set) =>
        {
            switch (set.SetType)
            {
                case SetType.Core:
                case SetType.Adventure_Pack:
                case SetType.Deluxe_Expansion:
                case SetType.Saga_Expansion:
                    return true;
                default:
                    return false;
            }
        };

        private readonly Product _product;
        private readonly List<ScenarioViewModel> _scenarios = new List<ScenarioViewModel>();

        public string Name { get { return _product.Name; } }
        public string Code { get { return _product.Code; } }
        public bool IsPremier { get { return _product.IsPremier; } }
        public bool IsNewSubGroup { get { return _product.IsNewSubGroup; } }
        public int Popularity { get; private set; }
        public string PopularityHtml
        {
            get
            {
                if (Popularity > 0)
                {
                    const string icon = "<img src='/Images/gold-ring.png' height='16' width='16'/>";

                    var html = new System.Text.StringBuilder();

                    for (var i = 0; i < Popularity; i++)
                    {
                        html.Append(icon);
                    }

                    return html.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public string ImagePath
        {
            get
            {
                var ext = (_product.ImageType == ImageType.Jpg) ? "jpg" : "png";

                return string.Format("/Images/Products/{0}.{1}", _product.Code, ext);
            }
        }
        public int ImageWidth
        {
            get
            {
                return _product.CardSets().Any(x => x.SetType == SetType.Core || x.SetType == SetType.Deluxe_Expansion || x.SetType == SetType.Saga_Expansion) ?
                    235 : 142;
            }
        }
        public int ImageHeight
        {
            get
            {
                return 235;
            }
        }
        
        public string Link
        {
            get
            {
                return string.Format("/Cards/Browse/{0}", _product.Name.NormalizeCaseSensitiveString().ToUrlSafeString());
            }
        }

        public string RulesLink
        {
            get { return _product.RulesUrl; }
        }

        public bool HasBuyLink
        {
            get { return !string.IsNullOrEmpty(_product.BuyLink); }
        }

        public string BuyLink
        {
            get { return _product.BuyLink; }
        }

        public IEnumerable<ScenarioViewModel> Scenarios
        {
            get { return _scenarios; }
        }
    }
}