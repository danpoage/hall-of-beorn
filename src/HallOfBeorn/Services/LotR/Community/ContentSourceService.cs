using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.Community.TheGreyCompany;

namespace HallOfBeorn.Services.LotR.Community
{
    public class ContentSourceService
        : IContentSourceService
    {
        public ContentSourceService()
        {
            AddContentSource(new TheGreyCompanyCreator());
        }

        private readonly Dictionary<string, ICreator> sourcesBySlug 
            = new Dictionary<string, ICreator>();

        private void AddContentSource(ICreator source)
        {
            sourcesBySlug[source.Name.ToSlug()] = source;
        }

        public ICreator GetContentSource(string slug)
        {
            return sourcesBySlug.ContainsKey(slug)
                ? sourcesBySlug[slug]
                : null;

        }

        public IEnumerable<ICreator> AllContentSources()
        {
            return sourcesBySlug.Values;
        }
    }
}