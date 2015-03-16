using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class WeightedSearchFilter
    {
        public WeightedSearchFilter(Func<SearchViewModel, Card, bool> check, float score, string description)
            : this(check, score, 0f, description)
        {
        }

        public WeightedSearchFilter(Func<SearchViewModel, Card, bool> check, float score, float miss, string description)
        {
            _check = check;
            _score = score;
            _miss = miss;
            _description = description;
        }

        public WeightedSearchFilter(IEnumerable<WeightedSearchFilter> filters)
        {
            _filters = filters;
        }

        private readonly Func<SearchViewModel, Card, bool> _check;
        private readonly IEnumerable<WeightedSearchFilter> _filters;
        private readonly float _score;
        private readonly float _miss;
        private readonly string _description;

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
                return _check(search, card) ? WeightedScore(card, _score) : _miss;
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

            return score + weight;
        }
    }
}