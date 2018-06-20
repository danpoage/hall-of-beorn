using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class StringExactFilter : StringFuzzyFilter
    {
        public StringExactFilter(Func<CardScore, string> getValue, string target)
            : base(getValue, target, (s1, s2) => s1 == s2)
        {
        }
    }
}