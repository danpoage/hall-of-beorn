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
            AddContentSource(new TheGreyCompanyContentSource());
        }

        private readonly Dictionary<string, IContentSource> sourcesBySlug 
            = new Dictionary<string, IContentSource>();

        private void AddContentSource(IContentSource source)
        {
            sourcesBySlug[source.Name.ToSlug()] = source;
        }

        public IContentSource GetContentSource(string slug)
        {
            return sourcesBySlug.ContainsKey(slug)
                ? sourcesBySlug[slug]
                : null;

        }

        public IEnumerable<IContentSource> AllContentSources()
        {
            return sourcesBySlug.Values;
        }
    }
}