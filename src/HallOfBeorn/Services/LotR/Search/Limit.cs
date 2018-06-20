using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class Limit : IComponent
    {
        public Limit(int count)
        {
            this.count = count;
        }

        private readonly int count;

        public bool IsEmpty
        {
            get { return count > 0; }
        }

        public IEnumerable<CardScore> Apply(IEnumerable<CardScore> scores)
        {
            return scores.Take(count);
        }
    }
}