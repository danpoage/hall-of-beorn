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

        public static SearchFilter ProductFilter(SearchViewModel model)
        {
            var codes = new List<string>();

            if (model.MEC01.HasValue && model.MEC01.Value)
            {
                codes.Add("MEC01");
            }
            if (model.MEC02.HasValue && model.MEC02.Value)
            {
                codes.Add("MEC02");
            }
            if (model.MEC03.HasValue && model.MEC03.Value)
            {
                codes.Add("MEC03");
            }
            if (model.MEC04.HasValue && model.MEC04.Value)
            {
                codes.Add("MEC04");
            }
            if (model.MEC05.HasValue && model.MEC05.Value)
            {
                codes.Add("MEC05");
            }
            if (model.MEC06.HasValue && model.MEC06.Value)
            {
                codes.Add("MEC06");
            }
            if (model.MEC07.HasValue && model.MEC07.Value)
            {
                codes.Add("MEC07");
            }

            if (model.MEC08.HasValue && model.MEC08.Value)
            {
                codes.Add("MEC08");
            }
            if (model.MEC09.HasValue && model.MEC09.Value)
            {
                codes.Add("MEC09");
            }
            if (model.MEC10.HasValue && model.MEC10.Value)
            {
                codes.Add("MEC10");
            }
            if (model.MEC11.HasValue && model.MEC11.Value)
            {
                codes.Add("MEC11");
            }
            if (model.MEC12.HasValue && model.MEC12.Value)
            {
                codes.Add("MEC12");
            }
            if (model.MEC13.HasValue && model.MEC13.Value)
            {
                codes.Add("MEC13");
            }
            if (model.MEC14.HasValue && model.MEC14.Value)
            {
                codes.Add("MEC14");
            }

            if (model.MEC17.HasValue && model.MEC17.Value)
            {
                codes.Add("MEC17");
            }

            if (model.MEC18.HasValue && model.MEC18.Value)
            {
                codes.Add("MEC18");
            }
            if (model.MEC19.HasValue && model.MEC19.Value)
            {
                codes.Add("MEC19");
            }
            if (model.MEC20.HasValue && model.MEC20.Value)
            {
                codes.Add("MEC20");
            }
            if (model.MEC21.HasValue && model.MEC21.Value)
            {
                codes.Add("MEC21");
            }
            if (model.MEC22.HasValue && model.MEC22.Value)
            {
                codes.Add("MEC22");
            }
            if (model.MEC23.HasValue && model.MEC23.Value)
            {
                codes.Add("MEC23");
            }

            if (model.MEC25.HasValue && model.MEC25.Value)
            {
                codes.Add("MEC25");
            }
            if (model.MEC26.HasValue && model.MEC26.Value)
            {
                codes.Add("MEC26");
            }
            if (model.MEC27.HasValue && model.MEC27.Value)
            {
                codes.Add("MEC27");
            }
            if (model.MEC28.HasValue && model.MEC28.Value)
            {
                codes.Add("MEC28");
            }
            if (model.MEC29.HasValue && model.MEC29.Value)
            {
                codes.Add("MEC29");
            }
            if (model.MEC30.HasValue && model.MEC30.Value)
            {
                codes.Add("MEC30");
            }
            if (model.MEC31.HasValue && model.MEC31.Value)
            {
                codes.Add("MEC31");
            }

            if (model.MEC38.HasValue && model.MEC38.Value)
            {
                codes.Add("MEC38");
            }
            if (model.MEC39.HasValue && model.MEC39.Value)
            {
                codes.Add("MEC39");
            }
            if (model.MEC40.HasValue && model.MEC40.Value)
            {
                codes.Add("MEC40");
            }
            if (model.MEC41.HasValue && model.MEC41.Value)
            {
                codes.Add("MEC41");
            }
            if (model.MEC42.HasValue && model.MEC42.Value)
            {
                codes.Add("MEC42");
            }
            if (model.MEC43.HasValue && model.MEC43.Value)
            {
                codes.Add("MEC43");
            }
            if (model.MEC44.HasValue && model.MEC44.Value)
            {
                codes.Add("MEC44");
            }

            if (model.MEC47.HasValue && model.MEC47.Value)
            {
                codes.Add("MEC47");
            }
            if (model.MEC48.HasValue && model.MEC48.Value)
            {
                codes.Add("MEC48");
            }
            if (model.MEC49.HasValue && model.MEC49.Value)
            {
                codes.Add("MEC49");
            }
            if (model.MEC50.HasValue && model.MEC50.Value)
            {
                codes.Add("MEC50");
            }
            if (model.MEC51.HasValue && model.MEC51.Value)
            {
                codes.Add("MEC51");
            }

            if (model.MEC16.HasValue && model.MEC16.Value)
            {
                codes.Add("MEC16");
            }
            if (model.MEC24.HasValue && model.MEC24.Value)
            {
                codes.Add("MEC24");
            }

            if (model.MEC32.HasValue && model.MEC32.Value)
            {
                codes.Add("MEC32");
            }
            if (model.MEC34.HasValue && model.MEC34.Value)
            {
                codes.Add("MEC34");
            }
            if (model.MEC45.HasValue && model.MEC45.Value)
            {
                codes.Add("MEC45");
            }
            if (model.MEC46.HasValue && model.MEC46.Value)
            {
                codes.Add("MEC46");
            }
            if (model.MEC54.HasValue && model.MEC54.Value)
            {
                codes.Add("MEC54");
            }

            if (model.FA01.HasValue && model.FA01.Value)
            {
                codes.Add("FA01");
            }
            if (model.FA02.HasValue && model.FA02.Value)
            {
                codes.Add("FA02");
            }
            if (model.FA03.HasValue && model.FA03.Value)
            {
                codes.Add("FA03");
            }

            if (codes.Count > 0)
            {
                return new SearchFilter((m, c) => { return codes.Contains(c.CardSet.Product.Code); }, 100, "Product matches filters");
            }

            return null;
        }
    }
}