using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.Community.CardboardOfTheRings;
using HallOfBeorn.Models.LotR.Community.HallOfBeorn;
using HallOfBeorn.Models.LotR.Community.TheGreyCompany;

namespace HallOfBeorn.Services.LotR.Community
{
    public class CreatorService
        : ICreatorService
    {
        public CreatorService()
        {
            AddCreator(new TheGreyCompanyCreator());
            AddCreator(new HallOfBeornCreator());
            AddCreator(new CardboardOfTheRingsCreator());
        }

        private readonly Dictionary<string, ICreator> creatorsBySlug 
            = new Dictionary<string, ICreator>();

        private void AddCreator(ICreator creator)
        {
            creatorsBySlug[creator.Name.ToSlug()] = creator;
        }

        public ICreator GetCreator(string slug)
        {
            return creatorsBySlug.ContainsKey(slug)
                ? creatorsBySlug[slug]
                : null;

        }

        public IEnumerable<ICreator> AllCreators()
        {
            return creatorsBySlug.Values;
        }
    }
}