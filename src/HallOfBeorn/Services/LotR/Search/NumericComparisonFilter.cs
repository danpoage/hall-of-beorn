using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class NumericComparisonFilter : Filter
    {
        public NumericComparisonFilter(Func<CardScore, int?> getValue, string target, NumericOperator? op)
        {
            if (!op.HasValue)
                return;

            predicate = GetPredicate(getValue, new List<string> { target }, op.Value, false);
        }

        public NumericComparisonFilter(Func<CardScore, int?> getValue, string value, bool isNegation)
        {
            if (string.IsNullOrWhiteSpace(value))
                return;

            var parsed = parseOperator(value);
            var op = parsed.Item1;
            
            var values = parseValues(parsed.Item2);
            if (values.Count() == 0)
                return;

            predicate = GetPredicate(getValue, values, op, isNegation);
        }

        private static IEnumerable<string> parseValues(string value)
        {
            if (value.Contains("-"))
            {
                var valueTokens = value.Split('-');
                if (valueTokens.Length == 2)
                {
                    var start = 0; var end = 0;
                    if (int.TryParse(valueTokens[0], out start) && int.TryParse(valueTokens[1], out end))
                    {
                        if (start < end)
                        {
                            var values = new List<string>();
                            for (var i = start; i <= end; i++)
                            {
                                values.Add(i.ToString());
                            }
                            return values;
                        }
                    }
                }
                return Enumerable.Empty<string>();
            }
            else
            {
                return value.SplitOnCommaOrPipe();
            }
        }

        private static Tuple<NumericOperator, string> parseOperator(string value)
        {
            var op = NumericOperator.eq;

            if (value.StartsWith(">="))
                op = NumericOperator.gteq;
            else if (value.StartsWith(">"))
                op = NumericOperator.gt;
            else if (value.StartsWith("<="))
                op = NumericOperator.lteq;
            else if (value.StartsWith("<"))
                op = NumericOperator.lt;

            return new Tuple<NumericOperator, string>(op, value.TrimStart(new char[]{'<', '>', '='}));
        }

        private static int? parseNumber(string target)
        {
            var parsed = 0;
            if (!int.TryParse(target, out parsed))
            {
                return null;
            }

            return parsed;
        }

        private static Func<int?, int, bool> getComparison(CardScore score, NumericOperator op)
        {
            switch (op)
            {
                case NumericOperator.lt:
                    return (value, target) => value.HasValue && value.Value < target;
                case NumericOperator.lteq:
                    return (value, target) => value.HasValue && value.Value <= target;
                case NumericOperator.gt:
                    return (value, target) => value.HasValue && value.Value > target;
                case NumericOperator.gteq:
                    return (value, target) => value.HasValue && value.Value >= target;
                case NumericOperator.eq:
                default:
                    return (value, target) => value.HasValue && value.Value == target;
            }
        }

        private static Func<CardScore, bool> GetPredicate(Func<CardScore, int?> getValue, IEnumerable<string> targets, NumericOperator op, bool isNegation)
        {
            var values = new List<int>();
            foreach (var target in targets)
            {
                var parsed = parseNumber(target);
                if (parsed.HasValue)
                    values.Add(parsed.Value);
            }

            if (values.Count == 0)
                return null;

            if (isNegation)
            {
                return (score) =>
                {
                    var value = getValue(score);
                    var compare = getComparison(score, op);
                    var match = !values.Any(target => compare(value, target));
                    score.AddScore(match ? 1 : 0);
                    return match;
                };
            }
            else 
            {
                return (score) =>
                {
                    var value = getValue(score);
                    var compare = getComparison(score, op);
                    var match = values.Any(target => compare(value, target));
                    score.AddScore(match ? 1 : 0);
                    return match;
                };
            }
        }
    }
}