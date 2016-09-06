using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Search
{
    public class SearchFilter
    {
        public SearchFilter(Func<SearchViewModel, Card, bool> check, float score, string description)
            : this(check, score, 0f, description)
        {
        }

        public SearchFilter(Func<SearchViewModel, Card, bool> check, float score, float miss, string description)
            : this(check, score, miss, description, true)
        {
        }

        public SearchFilter(Func<SearchViewModel, Card, bool> check, float score, float miss, string description, bool isWeighted)
        {
            _check = check;
            _score = score;
            _miss = miss;
            _description = description;
            _isWeighted = isWeighted;
        }

        public SearchFilter(IEnumerable<SearchFilter> filters)
        {
            _filters = filters;
        }

        private Func<SearchViewModel, Card, bool> _check;
        private readonly IEnumerable<SearchFilter> _filters;
        private float _score;
        private readonly float _miss;
        private string _description;
        private readonly bool _isWeighted = true;

        protected void init(Func<SearchViewModel, Card, bool> check, float score, string description)
        {
            this._check = check;
        }

        public string Description(SearchViewModel search, Card card)
        {
            if (!string.IsNullOrEmpty(_description))
            {
                return _description;
            }

            if (_filters != null && _filters.Count() > 0)
            {
                var bestScore = 0f;
                var bestDescription = string.Empty;
                foreach (var filter in _filters)
                {
                    var score = filter.Score(search, card);
                    if (score > bestScore)
                    {
                        bestScore = score;
                        bestDescription = filter.Description(search, card);
                    }
                }

                return bestDescription;
            }

            return string.Empty;
        }

        public float Score(SearchViewModel search, Card card)
        {
            if (_filters != null)
            {
                var bestScore = 0f;
                foreach (var filter in _filters)
                {
                    var score = filter.Score(search, card);
                    if (score > bestScore)
                    {
                        bestScore = score;
                    }
                }

                return bestScore;
            }
            else
            {
                if (_check(search, card))
                {
                    return _isWeighted ? WeightedScore(card, _score) : _score;
                }
                else
                {
                    return _miss;
                }
            }
        }

        public static float WeightedScore(Card card, float score)
        {
            var weight = 0;

            if (card.IsUnique)
                weight += 3;

            switch (card.CardType)
            {
                case CardType.Hero:
                    weight += 13;
                    break;
                case CardType.Ally:
                    weight += 9;
                    break;
                case CardType.Objective_Ally:
                    weight += 8;
                    break;
                case CardType.Objective_Location:
                    weight += 2;
                    break;
                case CardType.Attachment:
                    weight += 7;
                    break;
                case CardType.Objective:
                    weight += 6;
                    break;
                case CardType.Event:
                    weight += 5;
                    break;
                case CardType.Enemy:
                    weight += 4;
                    break;
                case CardType.Location:
                    weight += 2;
                    break;
                case CardType.Treachery:
                    weight += 1;
                    break;
                default:
                    break;
            }

            var weighted = score + weight;

            //TODO: Fix weighted score normalization
            //if (weighted > 100)
            //{
            //    weighted = 20 + (weighted - 100);
            //}

            return weighted;
        }
    }
}