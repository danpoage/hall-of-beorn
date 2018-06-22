using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class Offset : IComponent
    {
        public Offset(int count)
        {
            this.count = count;
        }

        private readonly int count;

        public bool IsEmpty
        {
            get { return count > 0; }
        }

        public IOrderedEnumerable<CardScore> Apply(IOrderedEnumerable<CardScore> scores)
        {
            return scores.Skip(count).OrderBy(s => 1);
        }
    }
}