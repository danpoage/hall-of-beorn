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
            predicate = GetPredicate(getValue, target, op);
        }

        private static Func<CardScore, bool> GetPredicate(Func<CardScore, byte?> getValue, string target, NumericOperator? op)
        {
            if (string.IsNullOrWhiteSpace(target) || target == defaultValue || !op.HasValue)
                return null;

            var normalizedTarget = target;
            if (target == "-") {
                normalizedTarget = "255";
            } else if (target == "X")
            {
                normalizedTarget = "254";
            }

            byte targetByte = 0;
            if (!byte.TryParse(normalizedTarget, out targetByte))
                return null;

            return (score) => {
                var value = getValue(score);
                if (!value.HasValue)
                    return false;

                switch (op)
                {
                    case NumericOperator.lt:
                        return value < targetByte && value < 254;
                    case NumericOperator.lteq:
                        return value <= targetByte && value < 254;
                    case NumericOperator.gt:
                        return value > targetByte && value < 254;
                    case NumericOperator.gteq:
                        return value >= targetByte && value < 254;
                    case NumericOperator.eq:
                    default:
                        return value.Value == targetByte;
                }
            };
        }
    }
}