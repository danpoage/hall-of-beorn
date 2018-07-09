using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class ByteComparisonFilter : Filter
    {
        public ByteComparisonFilter(Func<CardScore, byte?> getValue, string target, NumericOperator? op)
        {
            if (!op.HasValue)
                return;

            predicate = GetPredicate(getValue, new List<string> { target }, op.Value, false);
        }

        public ByteComparisonFilter(Func<CardScore, byte?> getValue, string value, bool isNegation)
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

        private static byte? parseByte(string target)
        {
            var normalizedTarget = target;
            if (target == "-") {
                normalizedTarget = "255";
            } else if (target == "X")
            {
                normalizedTarget = "254";
            }

            byte parsed = 0;
            if (!byte.TryParse(normalizedTarget, out parsed))
            {
                return null;
            }

            return parsed;
        }

        private static Func<byte?, byte, bool> getComparison(CardScore score, NumericOperator op)
        {
            switch (op)
            {
                case NumericOperator.lt:
                    return (value, target) => value.HasValue && value.Value < target;
                case NumericOperator.lteq:
                    return (value, target) => value.HasValue && value.Value <= target;
                case NumericOperator.gt:
                    return (value, target) => value.HasValue && value.Value > target && value.Value < 254;
                case NumericOperator.gteq:
                    return (value, target) => value.HasValue && value.Value >= target && value.Value < 254;
                case NumericOperator.eq:
                default:
                    return (value, target) => value.HasValue && value.Value == target;
            }
        }

        private static Func<CardScore, bool> GetPredicate(Func<CardScore, byte?> getValue, IEnumerable<string> targets, NumericOperator op, bool isNegation)
        {
            var values = new List<byte>();
            foreach (var target in targets)
            {
                var parsed = parseByte(target);
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