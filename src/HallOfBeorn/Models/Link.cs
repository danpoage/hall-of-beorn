using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class Link : ILink
    {
        private const string parterBaseUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Partners";
        private const int defaultThumbnailWidth = 210;
        private const int defaultThumbnailHeight = 118;

        public Link(LinkType type, ICard card)
            : this(type, card, null)
        {
        }
        
        public Link(LinkType type, ICard card, string title)
        {
            this.Type = type;

            var linkTitle = string.IsNullOrEmpty(title) ? getTitle(type) : title;
            this.Title = linkTitle;

            this.Text = getText(type, card, linkTitle);
            this.Url = getUrl(type, card, defaltLanguage);
        }

        public Link(LinkType type, string url, string title)
            : this(type, url, title, string.Empty, null, null)
        {
        }

        public Link(LinkType type, string url, string title, string thumbnailUrl)
            : this(type, url, title, thumbnailUrl, null, null)
        {
        }

        private static string GetPartnerLogo(LinkType type, string name)
        {
            var image = string.IsNullOrEmpty(name)
                ? type.ToString().Replace("_", "-")
                : name;
            
            return string.Format("{0}/{1}.jpg", 
                parterBaseUrl, 
                image);
        }

        private readonly static Dictionary<LinkType, string> partnerLinkTypes 
            = new Dictionary<LinkType, string>
        {
            { LinkType.The_Grey_Company, "" },
            { LinkType.Cardboard_of_the_Rings, "" },
            { LinkType.Card_Talk, "" },
            { LinkType.The_Card_Game_Cooperative, "" },
            { LinkType.Tales_from_the_Cards, "" },
            { LinkType.Hall_of_Beorn, "" },
            { LinkType.Master_of_Lore, "" },
            { LinkType.Darkling_Door, "" },
            { LinkType.Vision_of_the_Palantir, "" },
            { LinkType.The_Book_of_Elessar, "" },
            { LinkType.Die_Manner_von_Gondor, "Die-Männer-von-Gondor" },
            { LinkType.Susurros_del_Bosque_Viejo, "" }
        };

        public Link(LinkType type, string url, string title, string thumbnailUrl, int? thumbnailHeight, int? thumbnailWidth)
        {
            this.Type = type;
            this.Title = title;
            this.Text = title;
            this.Url = url;
            this.ThumbnailUrl = thumbnailUrl;

            _thumbnailHeight = thumbnailHeight.HasValue 
                ? thumbnailHeight.Value : defaultThumbnailHeight;

            _thumbnailWidth = thumbnailWidth.HasValue
                ? thumbnailWidth.Value : defaultThumbnailWidth;

            if (string.IsNullOrWhiteSpace(thumbnailUrl))
            {
                if (partnerLinkTypes.ContainsKey(type))
                {
                    var name = partnerLinkTypes[type];
                    ThumbnailUrl = GetPartnerLogo(type, name);
                }
            }
        }

        private const string defaltLanguage = "en";

        private static string getUrl(LinkType type, ICard card, string language)
        {
            var title = card.Title.ToUrlSafeString();

            switch (type)
            {
                case LinkType.Dor_Cuarthol:
                    return string.Format("https://dorcuarthol.wordpress.com/?s={0}", title);
                case LinkType.Encyclopedia_of_Arda:
                    return string.Format("http://www.glyphweb.com/arda/search.asp?search={0}", title);
                case LinkType.Expecting_Mischief:
                    return string.Format("https://expectingmischief.wordpress.com/?s={0}", title);
                case LinkType.Hall_of_Beorn:
                    return string.Format("http://hallofbeorn.wordpress.com/?s={0}", title);
                case LinkType.Lord_of_the_Rings_Wiki:
                    return string.Format("http://lotr.wikia.com/wiki/{0}", title);
                case LinkType.Master_of_Lore:
                    return string.Format("http://masteroflore.wordpress.com/?s={0}", title);
                case LinkType.Second_Hand_Took:
                    return string.Format("http://secondhandtook.wordpress.com/?s={0}", title);
                case LinkType.Tales_from_the_Cards:
                    return string.Format("http://talesfromthecards.wordpress.com/?s={0}", title);
                case LinkType.Tolkien_Gateway:
                    return string.Format("http://tolkiengateway.net/wiki/{0}", title);
                case LinkType.Wikipedia:
                    return string.Format("https://en.wikipedia.org/wiki/{0}", title);

                case LinkType.The_Mirkwood_Runner:
                    return string.Format("http://mirkwoodrunner.blogspot.com/search/label/{0}", title.ToLowerSafe());
                case LinkType.Warden_of_Arnor:
                    return string.Format("http://wardenofarnor.wordpress.com/?s={0}", title);
                case LinkType.Heroes_of_the_Rings:
                    return string.Format("http://heroesoftherings.blogspot.com/search/label/{0}", title.ToLowerSafe());
                case LinkType.Very_Late_Adventurer:
                    return string.Format("https://verylateadventurer.wordpress.com/?s={0}", title);
                case LinkType.Susurros_del_Bosque_Viejo:
                    return string.Format("http://susurrosdelbosqueviejo.blogspot.com/search/label/{0}", title.ToLowerSafe());
                case LinkType.El_Libro_Rojo_de_Bolson_Cerrado:
                    return string.Format("https://ellibrorojodebolsoncerrado.wordpress.com/?s={0}", title);
                case LinkType.Die_Manner_von_Gondor:
                    return string.Format("https://menofgondor.wordpress.com/?s={0}", title);
                case LinkType.Hall_of_Beorn_LotR_Detail:
                case LinkType.Hall_of_Beorn_LotR_Image:
                    //var slug = string.IsNullOrEmpty(card.SlugSuffix) ? card.Slug : card.Slug + card.SlugSuffix;
                    return string.Format("/LotR/Details/{0}", card.Slug);
                case LinkType.Hall_of_Beorn_Digital_Detail:
                case LinkType.Hall_of_Beorn_Digital_Image:
                    return string.Format("/Digital/Details/{0}", card.Slug);
                default:
                    return string.Empty;
            }
        }

        private static string getTitle(LinkType type)
        {
            return type != LinkType.None
                ? type.ToString().Replace('_', ' ')
                : string.Empty;
        }

        private static string getText(LinkType type, ICard card, string title)
        {
            if (type == LinkType.Hall_of_Beorn_LotR_Image) {
                var slug = string.Empty;
                if (card.IsCampaign) {
                    slug = string.Format("{0}-SetupA", card.Title.ToUrlSafeString());
                } else if (card.IsQuest) {
                    slug = string.Format("{0}-{1}{2}", card.Title.ToUrlSafeString(), card.StageNumber, card.StageLetter);
                } else if (card.IsSetup) {
                    slug = card.Title.ToUrlSafeString() + "-SetupA";
                } else if (!string.IsNullOrEmpty(card.OppositeText)) {
                    slug = card.Title.ToUrlSafeString() + "-SideA";
                } else {
                    slug = string.IsNullOrEmpty(card.SlugSuffix) ? card.Title.ToUrlSafeString() : string.Format("{0}-{1}", card.Title.ToUrlSafeString(), card.SlugSuffix);
                }
                return string.Format("<img src=\"https://s3.amazonaws.com/hallofbeorn-resources/Images/Cards/{0}/{1}.jpg\" title=\"{2}\" style=\"height:180px\"></img>", card.CardSetName.NormalizeCaseSensitiveString().ToUrlSafeString(), slug, title.Replace("'", "’"));
            } else if (type == LinkType.Hall_of_Beorn_Digital_Image) {
                var slug = card.Title.NormalizeCaseSensitiveString().ToUrlSafeString();
                return string.Format("<img src=\"https://s3.amazonaws.com/hallofbeorn-resources/Images/Digital/{0}/{1}.jpg\" title=\"{2}\" style=\"height:180px\"></img>", card.CardSetName.NormalizeCaseSensitiveString().ToUrlSafeString(), slug, title.Replace("'", "’"));
            } else {
                return title;
            }
        }

        private readonly int? _thumbnailHeight;
        private readonly int? _thumbnailWidth;

        public LinkType Type { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
        public string ThumbnailUrl { get; private set; }
        public int ThumbnailHeight { get { return _thumbnailHeight.HasValue ? _thumbnailHeight.Value : 118; } } 
        public int ThumbnailWidth { get { return _thumbnailWidth.HasValue ? _thumbnailWidth.Value : 210; } }

        public static ILink CreateLotRImageLink(LotR.LotRCard card)
        {
            if (card == null)
                return null;

            var sphere = card.Sphere != LotR.Sphere.None ? card.Sphere.ToString() + " " : string.Empty;
            var title = string.Format("{0} ({1}{2})", card.Title, sphere, card.CardType.ToString().Replace("_", "-"));

            return new Link(LinkType.Hall_of_Beorn_LotR_Image, card, title);
        }
    }

    public class CreatorLink
    {
        public CreatorLink(ICreator creator, ILink link)
        {
            Creator = creator;
            Link = link;
        }

        public ICreator Creator { get; private set; }
        public ILink Link { get; private set; }

        public CreatorLink WithAssociation(string cardSlug)
        {
            Creator.AssociateCardToUrl(cardSlug, Link.Url);
            return this;
        }
    }
}
