using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class Filter : IComponent
    {
        public Filter()
        {
        }

        public Filter(Func<CardScore, bool> predicate)
        {
            this.predicate = predicate;
        }

        protected const string defaultValue = "Any";
        protected Func<CardScore, bool> predicate;

        protected IEnumerable<string> GetStringValues(string value, string suffix)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return Enumerable.Empty<string>();
            }

            return value.Replace('_', ' ').SplitOnCommaOrPipe()
                .Select(s => string.IsNullOrWhiteSpace(s) ? s : s + suffix);
        }

        protected IEnumerable<TEnum> GetEnumValues<TEnum>(string value)
            where TEnum: struct
        {
            var values = new List<TEnum>();

            if (string.IsNullOrWhiteSpace(value))
            {
                return values;
            }

            var tokens = value.Replace(' ', '_').SplitOnCommaOrPipe();
            foreach (var token in tokens)
            {
                var parsed = default(TEnum);
                if (Enum.TryParse<TEnum>(token, true, out parsed))
                {
                    values.Add(parsed);
                }
            }

            return values;
        }

        public virtual bool IsEmpty
        {
            get { return predicate == null; }
        }

        public IOrderedEnumerable<CardScore> Apply(IOrderedEnumerable<CardScore> scores)
        {
            return scores.Where(predicate).OrderBy(s => 1);
        }
    }
}