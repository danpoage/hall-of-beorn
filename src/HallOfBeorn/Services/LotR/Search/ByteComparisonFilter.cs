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
            }
            else if (target == "X")
            {
                normalizedTarget = "254";
            }
            else if (target == "*")
            {
                normalizedTarget = "253";
            }

            byte parsed = 0;
            if (!byte.TryParse(normalizedTarget, out parsed))
            {
                return null;
            }

            return parsed;
        }

        private static bool normalizedEqualTo(byte? value, byte target)
        {
            return value.GetValueOrDefault(255) == target;
        }

        private static bool normalizedLessThan(byte? value, byte target)
        {
            var norm = value.GetValueOrDefault(255);
            if (norm > 252 || target > 252)
            {
                return false;
            }
            return norm < target;
        }

        private static bool normalizedLessThanOrEqualTo(byte? value, byte target)
        {
            var norm = value.GetValueOrDefault(255);
            if (norm > 252 || target > 252)
            {
                return norm == target;
            }
            return norm <= target;
        }

        private static bool normalizedGreaterThan(byte? value, byte target)
        {
            var norm = value.GetValueOrDefault(255);
            if (norm > 252 || target > 252)
            {
                return false;
            }
            return norm > target;
        }

        private static bool normalizedGreaterThanOrEqualTo(byte? value, byte target)
        {
            var norm = value.GetValueOrDefault(255);
            if (norm > 252 || target > 252)
            {
                return norm == target;
            }
            return norm >= target;
        }

        private static Func<byte?, byte, bool> getComparison(CardScore score, NumericOperator op)
        {
            
            switch (op)
            {
                case NumericOperator.lt:
                    return (value, target) => normalizedLessThan(value, target);
                case NumericOperator.lteq:
                    return (value, target) => normalizedLessThanOrEqualTo(value, target);
                case NumericOperator.gt:
                    return (value, target) => normalizedGreaterThan(value, target);
                case NumericOperator.gteq:
                    return (value, target) => normalizedGreaterThanOrEqualTo(value, target);
                case NumericOperator.eq:
                default:
                    return (value, target) => normalizedEqualTo(value, target);
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