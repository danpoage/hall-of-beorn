using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class Plan
    {
        public Plan(IEnumerable<IComponent> steps)
        {
            this.steps = steps;
        }

        private readonly IEnumerable<IComponent> steps;
        
        public IOrderedEnumerable<CardScore> Execute(IOrderedEnumerable<CardScore> scores)
        {
            var results = scores;

            foreach (var step in steps)
            {
                results = step.Apply(results);
            }

            return results;
        }
    }
}