using System;
using System.Collections.Generic;
using System.Linq;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class ErrataFilter : BooleanFilter
    {
        public ErrataFilter(Func<CardScore, double, bool> predicate, 
            ErrataVersion? target)
            : base((score) => Check(score, predicate, target), false) 
        {
            _target = target;
        }

        private readonly ErrataVersion? _target;

        public override bool IsEmpty
        {
            get
            {
                return !_target.HasValue || _target.Value == ErrataVersion.Any;
            }
        }

        private static bool Check(CardScore score, 
            Func<CardScore, double, bool> predicate,
            ErrataVersion? target)
        {
            if (!target.HasValue || target.Value == ErrataVersion.Any)
                return true;

            var targetValue = GetErrataValue(target);

            return predicate(score, targetValue);
        }

        private static double GetErrataValue(ErrataVersion? version)
        {
            if (!version.HasValue)
                return 0;

            switch (version.Value)
            {
                case ErrataVersion.FAQ_1_1:
                    return 1.1;
                case ErrataVersion.FAQ_1_2:
                    return 1.2;
                case ErrataVersion.FAQ_1_3:
                    return 1.3;
                case ErrataVersion.FAQ_1_4:
                    return 1.4;
                case ErrataVersion.FAQ_1_5:
                    return 1.5;
                case ErrataVersion.FAQ_1_6:
                    return 1.6;
                case ErrataVersion.FAQ_1_7:
                    return 1.7;
                case ErrataVersion.FAQ_1_8:
                    return 1.8;
                case ErrataVersion.FAQ_1_9:
                    return 1.9;
                default:
                    return 0;
            }
        }
    }
}