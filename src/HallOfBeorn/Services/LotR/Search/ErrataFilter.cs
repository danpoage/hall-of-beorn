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

            if (target.Value == ErrataVersion.Has_Text_Errata)
            {
                return score.Card.PreviousVersions > 0;
            }

            var targetValue = GetErrataValue(target);

            return predicate(score, targetValue);
        }

        private static double GetErrataValue(ErrataVersion? version)
        {
            if (!version.HasValue)
                return 0;

            switch (version.Value)
            {
                case ErrataVersion.No_Errata:
                    return -1;
                case ErrataVersion.FAQ_1_1:
                    return 1.01;
                case ErrataVersion.FAQ_1_2:
                    return 1.02;
                case ErrataVersion.FAQ_1_3:
                    return 1.03;
                case ErrataVersion.FAQ_1_4:
                    return 1.04;
                case ErrataVersion.FAQ_1_5:
                    return 1.05;
                case ErrataVersion.FAQ_1_6:
                    return 1.06;
                case ErrataVersion.FAQ_1_7:
                    return 1.07;
                case ErrataVersion.FAQ_1_8:
                    return 1.08;
                case ErrataVersion.FAQ_1_9:
                    return 1.09;
                case ErrataVersion.FAQ_1_10:
                    return 1.10;
                case ErrataVersion.FAQ_1_11:
                    return 1.11;
                default:
                    return 0;
            }
        }
    }
}