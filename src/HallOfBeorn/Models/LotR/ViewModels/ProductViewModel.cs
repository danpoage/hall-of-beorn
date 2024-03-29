﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel(Product product, Func<string, byte> getPopularity)
        {
            _product = product;
            Popularity = 0;

            double popCardCount = 0;
            double totalPop = 0;
            foreach (var set in product.CardSets.Where(setHasPopularity))
            {
                foreach (var card in set.Cards)
                {
                    var pop = getPopularity(card.Slug);
                    if (pop > 1)
                    {
                        popCardCount++;
                        totalPop += pop;
                    }
                }
            }

            if (popCardCount > 0 && totalPop > 0)
            {
                AveragePopularity = totalPop / popCardCount;
                if (AveragePopularity > 7) 
                {
                    AveragePopularity = 7;
                }
                Popularity = (byte)Math.Round(AveragePopularity, MidpointRounding.AwayFromZero);
            }
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
        private readonly List<CardViewModel> _cards = new List<CardViewModel>();

        private bool hasPopularity()
        {
            if (_product.Code.EndsWith("PRM"))
            {
                return false;
            }

            if (!string.IsNullOrEmpty(_product.Code) && _product.Code.StartsWith("MEC"))
            {
                switch (_product.Code)
                {
                    case "MEC15":
                    case "MEC33":
                    case "MEC35":
                    case "MEC36":
                    case "MEC37":
                    case "MEC75":
                        return false;
                    default:
                        return true;
                }
            }

            return false;
        }

        public string Name { get { return _product.Name; } }
        public string Code { get { return _product.Code; } }
        public bool IsPremier { get { return _product.IsPremier; } }
        public bool IsNewSubGroup { get { return _product.IsNewSubGroup; } }
        public byte Popularity { get; private set; }
        public double AveragePopularity { get; private set; }
        public string PopularityHtml
        {
            get
            {
                if (!hasPopularity())
                {
                    return string.Empty;
                }

                const string icon = "<img src='/Images/gold-ring.png' height='16' width='16'/>";

                if (Popularity > 0)
                {
                    var html = new System.Text.StringBuilder();
                    
                    for (var i = 0; i < Popularity; i++)
                    {
                        html.Append(icon);
                    }

                    return html.ToString();
                }
                else
                {
                    return icon;
                }
            }
        }

        public string ImagePath
        {
            get
            {
                var ext = (_product.ImageType == ImageType.Jpg) ? "jpg" : "png";

                return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/Products/{0}.{1}", _product.Code, ext);
            }
        }
        public int ImageWidth
        {
            get
            {
                return _product.CardSets.Any(x => x.SetType == SetType.Core || x.SetType == SetType.Deluxe_Expansion || x.SetType == SetType.Saga_Expansion) ?
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
        
        public string BrowseLink
        {
            get
            {
                return string.Format("/LotR/Products/{0}?View=Browse", _product.Name.NormalizeCaseSensitiveString().ToUrlSafeString());
            }
        }

        public string ChronologicalLink
        {
            get
            {
                return string.Format("/LotR/Products/{0}?View=Chronological", _product.Name.NormalizeCaseSensitiveString().ToUrlSafeString());
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

        public bool IsOfficial()
        {
            return !_product.CardSets.First().SetType.IsCommunity();
        }

        public DateTime FirstReleased
        {
            get { return _product.FirstReleased; }
        }

        public string ProductType()
        {
            return _product.CardSets.First().SetType.ToString().Replace("_", " ");
        }

        public IEnumerable<ScenarioViewModel> Scenarios
        {
            get { return _scenarios; }
        }

        public IEnumerable<CardViewModel> Cards
        {
            get { return _cards; }
        }

        public int TotalCardCount()
        {
            var count = 0;
            foreach (var cardSet in _product.CardSets)
            {
                foreach (var card in cardSet.Cards)
                {
                    if (card.SideLetter.GetValueOrDefault('a') == 'b')
                    {
                        continue;
                    }

                    count += card.Quantity;
                }
            }
            return count;
        }

        public void AddCard(CardViewModel card)
        {
            _cards.Add(card);
        }

        public bool HasCards()
        {
            return _cards.Count > 0;
        }
    }
}