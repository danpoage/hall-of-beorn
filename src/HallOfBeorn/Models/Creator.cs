using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.Categories;

namespace HallOfBeorn.Models
{
    public class Creator
        : ICreator
    {
        protected Creator(string name, string siteUrl, string feedUrl, LinkType defaultLinkType)
        {
            Name = name;
            SiteUrl = siteUrl;
            FeedUrl = feedUrl;
            DefaultLinkType = defaultLinkType;
        }

        private readonly List<ILink> allLinks = new List<ILink>();
        private readonly Dictionary<string, ILink> linksByUrl = new Dictionary<string, ILink>();

        private readonly Dictionary<string, List<string>> urlsByCardSlug 
            = new Dictionary<string, List<string>>();

        private const string partnerLogoFormat =
            "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Partners/{0}.jpg";

        private const string simpleTitleFormat = "{0} [{1}]";

        protected CreatorLink AddLink(ILink link)
        {
            allLinks.Add(link);

            if (!string.IsNullOrWhiteSpace(link.Url))
            {
                linksByUrl[link.Url] = link;
            }

            return new CreatorLink(this, link);
        }

        protected CreatorLink AddLink(string title, string url, string releaseDate)
        {
            var date = DateTime.Parse(releaseDate);
            var fullTitle = string.Format(simpleTitleFormat, title, date.ToString("MMM dd, yyyy"));
            var link = new Link(DefaultLinkType, url, fullTitle);
            AddLink(link);
            return new CreatorLink(this, link);
        }

        protected void AddYear(int year)
        {
            AddLink(new Link(LinkType.None, string.Empty, year.ToString()));
        }

        protected void AddAlternateSource(string name, string url)
        {
            AddLink(
                new Link(LinkType.Logo, url, name, 
                    string.Format(partnerLogoFormat, name.ToSlug()), 118, 210)
                );
        }

        public void AssociateCardToUrl(string cardSlug, string url)
        {
            if (!urlsByCardSlug.ContainsKey(cardSlug))
            {
                urlsByCardSlug[cardSlug] = new List<string>();
            }

            urlsByCardSlug[cardSlug].Add(url);
        }

        public string Name
        {
            get;
            private set;
        }

        public string SiteUrl
        {
            get;
            private set;
        }

        public string FeedUrl
        {
            get;
            private set;
        }

        public LinkType DefaultLinkType
        {
            get; private set;
        }

        public IEnumerable<ILink> Links()
        {
            return allLinks;
        }

        public IEnumerable<ILink> GetLinks(string cardSlug)
        {
            return urlsByCardSlug.ContainsKey(cardSlug)
                ? urlsByCardSlug[cardSlug]
                    .Where(url => linksByUrl.ContainsKey(url))
                    .Select(url => linksByUrl[url])
                    .Distinct()
                : new List<ILink>();
        }

        public Func<LotR.PlayerCategory, IEnumerable<string>> LabelsByPlayerCategory
        {
            get
            {
                Func<LotR.PlayerCategory, IEnumerable<string>> func = (cat) =>
                {
                    var titles = new HashSet<string>();

                    foreach (var cardSet in ProductRepository.Instance.CardSets())
                    {
                        foreach (var card in cardSet.Cards
                            .Where(c => PlayerCategoryService.Instance.HasCategory(c, cat)))
                        {
                            if (!titles.Contains(card.Title))
                            {
                                titles.Add(card.Title);
                                if (card.NormalizedTitle != card.Title && !titles.Contains(card.NormalizedTitle))
                                {
                                    titles.Add(card.NormalizedTitle);
                                }
                            }
                        }
                    }

                    return titles;
                };

                return func;
            }
        }
    }
}
