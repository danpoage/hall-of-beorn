using System;

using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class ProjectFilter : Filter
    {
        public ProjectFilter(Project? target)
        {

            if (!target.HasValue)
                return;

            Project parsedProject = target.Value;

            predicate = (score) =>
            {
                var isAlep = score.Card.CardSet.SetType == Models.SetType.A_Long_extended_Party;
                var isFirstAge = score.Card.CardSet.SetType == Models.SetType.First_Age;

                switch (parsedProject)
                {
                    case Project.ALeP:
                        return isAlep;
                    case Project.First_Age:
                        return isFirstAge;
                    case Project.Community:
                        return isAlep || isFirstAge;
                    case Project.Official:
                        return !isAlep && !isFirstAge;
                    case Project.Any:
                    default:
                        return true;
                }
            };
        }
    }
}