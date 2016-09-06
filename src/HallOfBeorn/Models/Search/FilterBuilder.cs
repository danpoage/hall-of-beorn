using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Search
{
    public class FilterBuilder
    {
        public static SearchFilter ErrataFilter(ErrataVersion version, Func<string, double, bool> hasErrata)
        {
            double faq = 0;

            switch (version)
            {
                case ErrataVersion.Has_Errata:
                    return new SearchFilter((s, c) => { return hasErrata(c.Slug, 0); }, 100, "Has Errata");
                case ErrataVersion.No_Errata:
                    return new SearchFilter((s, c) => { return !hasErrata(c.Slug, 0); }, 100, "Does Not Have Errata");
                case ErrataVersion.FAQ_1_1:
                    faq = 1.1;
                    break;
                case ErrataVersion.FAQ_1_2:
                    faq = 1.2;
                    break;
                case ErrataVersion.FAQ_1_3:
                    faq = 1.3;
                    break;
                case ErrataVersion.FAQ_1_4:
                    faq = 1.4;
                    break;
                case ErrataVersion.FAQ_1_5:
                    faq = 1.5;
                    break;
                case ErrataVersion.FAQ_1_6:
                    faq = 1.6;
                    break;
                case ErrataVersion.FAQ_1_7:
                    faq = 1.7;
                    break;
                case ErrataVersion.FAQ_1_8:
                    faq = 1.8;
                    break;
                default:
                    break;
            }

            return (faq > 0) ?
                new SearchFilter((s, c) => { return hasErrata(c.Slug, faq); }, 100, "Has Errata from " + version.ToString().Replace("FAQ_1_", " FAQ 1."))
                : null;
        }
    }
}