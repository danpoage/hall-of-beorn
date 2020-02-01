using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class CreatorViewModel
    {
        public CreatorViewModel(
            ICreator source)
        {
            this.source = source;

            IsListView = false;
        }

        public CreatorViewModel(
            IEnumerable<ICreator> podcasts,
            IEnumerable<ICreator> blogs)
        {
            this.podcasts.AddRange(podcasts);
            this.blogs.AddRange(blogs);

            IsListView = true;
        }

        private readonly ICreator source;
        private readonly List<ICreator> podcasts = new List<ICreator>();
        private readonly List<ICreator> blogs = new List<ICreator>();

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

        public bool IsListView { get; private set; }

        private static string GetPartnerLogoUrl(ICreator source)
        {
            return
                string.Format(partnerLogoFormat, source.Name.ToSlug());
        }

        public string PartnerUrl
        {
            get
            {
                return source != null
                    ? source.SiteUrl
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

        public string CreatorFeedUrl
        {
            get
            {
                return source != null
                    ? source.FeedUrl
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

        private IEnumerable<LinkViewModel> GetCreatorLinks(
            IEnumerable<ICreator> creators)
        {
            foreach (var creator in creators)
            {
                var url = "/LotR/Creators/" + creator.Name.ToSlug();

                yield return new LinkViewModel(
                    new Link(LinkType.None, url, creator.Name, GetPartnerLogoUrl(creator))
                );
            }
        }

        public IEnumerable<LinkViewModel> Podcasts()
        {
            return GetCreatorLinks(podcasts);
        }

        public IEnumerable<LinkViewModel> Blogs()
        {
            return GetCreatorLinks(blogs);
        }
    }
}
