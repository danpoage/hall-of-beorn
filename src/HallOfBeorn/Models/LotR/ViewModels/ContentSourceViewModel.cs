﻿using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class ContentSourceViewModel
    {
        public ContentSourceViewModel(
            IContentSource source)
        {
            this.source = source;
        }

        public ContentSourceViewModel(
            IEnumerable<IContentSource> allSources)
        {
            this.allSources.AddRange(allSources);
        }

        private readonly IContentSource source;
        private readonly List<IContentSource> allSources = new List<IContentSource>();

        private const string partnerLogoFormat
            = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Partners/{0}.jpg";

        public string Name
        { 
            get
            {
                return source != null
                    ? source.Name
                    : "Creators";
            } 
        }

        public bool IsListView { get { return allSources.Count > 0; } }

        private static string GetPartnerLogoUrl(IContentSource source)
        {
            return
                string.Format(partnerLogoFormat, source.Name.ToSlug());
        }

        public string PartnerUrl
        {
            get
            {
                return source != null
                    ? source.Url
                    : string.Empty;
            }
        }

        public string PartnerLogoUrl
        {
            get
            {
                return source != null
                    ? GetPartnerLogoUrl(source)
                    : string.Empty;
            }
        }

        public IEnumerable<LinkViewModel> Links()
        {
            if (source == null)
                yield break;

            foreach (var link in source.Links())
            {
                yield return new LinkViewModel(link);
            }
        }

        public IEnumerable<LinkViewModel> Creators()
        {
            foreach (var source in allSources)
            {
                var url = "/LotR/Creators/" + source.Name.ToSlug();

                yield return new LinkViewModel(
                    new Link(LinkType.None, url, source.Name, GetPartnerLogoUrl(source))
                );
            }
        }
    }
}
