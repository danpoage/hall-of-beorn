using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class CardViewModel
    {
        public CardViewModel(LotRCard card, 
            Func<string, IEnumerable<PlayerCategory>> getPlayerCategories, 
            Func<string, IEnumerable<EncounterCategory>> getEncounterCategories, 
            Func<string, IEnumerable<QuestCategory>> getQuestCategories,
            Func<string, IEnumerable<Region>> getRegions,
            Func<string, IEnumerable<Archetype>> getArchetypes,
            Language? lang)
            : this(card, 0f, string.Empty, 
            getPlayerCategories, getEncounterCategories, getQuestCategories, getRegions, getArchetypes, lang)
        {
        }

        public CardViewModel(CardScore score, 
            Func<string, IEnumerable<PlayerCategory>> getPlayerCategories, 
            Func<string, IEnumerable<EncounterCategory>> getEncounterCategories, 
            Func<string, IEnumerable<QuestCategory>> getQuestCategories,
            Func<string, IEnumerable<Region>> getRegions,
            Func<string, IEnumerable<Archetype>> getArchetypes,
            Language? lang)
            : this(score.Card, score.Score(), score.Description, 
            getPlayerCategories, getEncounterCategories, getQuestCategories, getRegions, getArchetypes, lang)
        {
        }

        public CardViewModel(LotRCard card, float score, string searchDescription, 
            Func<string, IEnumerable<PlayerCategory>> getPlayerCategories, 
            Func<string, IEnumerable<EncounterCategory>> getEncounterCategories, 
            Func<string, IEnumerable<QuestCategory>> getQuestCategories,
            Func<string, IEnumerable<Region>> getRegions,
            Func<string, IEnumerable<Archetype>> getArchetypes,
            Language? lang = Language.EN)
        {
            _card = card;
            _score = score;
            _searchDescription = searchDescription;
            _lang = lang.HasValue ? lang.Value : _card.DefaultLang;

            this.getPlayerCategories = getPlayerCategories;
            this.getEncounterCategories = getEncounterCategories;
            this.getQuestCategories = getQuestCategories;
            this.getRegions = getRegions;
            this.getArchetypes = getArchetypes;

            foreach (var encounterSet in _card.IncludedEncounterSets)
            {
                _includedEncounterSets.Add(new EncounterSetViewModel(encounterSet));
            }
        }

        private LotRCard _card;
        private float _score;
        private string _searchDescription;
        private Language _lang;

        private Func<string, IEnumerable<PlayerCategory>> getPlayerCategories;
        private Func<string, IEnumerable<EncounterCategory>> getEncounterCategories;
        private Func<string, IEnumerable<QuestCategory>> getQuestCategories;
        private Func<string, IEnumerable<Region>> getRegions;
        private Func<string, IEnumerable<Archetype>> getArchetypes;

        private readonly List<CardEffect> _keywordEffects = new List<CardEffect>();
        private readonly List<CardEffect> _textEffects = new List<CardEffect>();
        private readonly List<CardEffect> _oppositeTextEffects = new List<CardEffect>();
        private readonly List<CardEffect> _shadowEffects = new List<CardEffect>();
        private readonly List<EncounterSetViewModel> _includedEncounterSets = new List<EncounterSetViewModel>();

        public List<CardEffect> KeywordEffects { get { return _keywordEffects; } }
        
        public void AddTranslatedKeywords(IEnumerable<CardEffect> keywords)
        {
            KeywordEffects.AddRange(keywords);
        }

        public List<CardEffect> TextEffects { get { return _textEffects; } }
        public List<CardEffect> OppositeTextEffects { get { return _oppositeTextEffects; } }
        public List<CardEffect> ShadowEffects { get { return _shadowEffects; } }

        public bool HasIncludedEncounterSets { get { return _includedEncounterSets.Count > 0; } }
        public List<EncounterSetViewModel> IncludedEncounterSets { get { return _includedEncounterSets; } }

        public byte? DeckQuantity { get; set; }

        public string CountLabel
        {
            get
            {
                var easy = _card.EasyModeQuantity.HasValue ? _card.EasyModeQuantity.Value.ToString() : string.Empty;

                return string.IsNullOrEmpty(easy) ?
                    string.Format("(x{0})", _card.Quantity)
                    : string.Format("(x{0}/x{1})", _card.Quantity, easy);
            }
        }

        public LotRCard Card
        {
            get { return _card; }
        }

        public string SearchDescription
        {
            get { return _searchDescription; }
        }

        public double Score
        {
            get { return Math.Truncate(_score); }
        }

        public string Id
        {
            get { return _card.Id; }
        }

        public string Slug
        {
            get { return _card.Slug; }
        }

        //public string OctgnSlug
        //{
        //    get { return _card.OctgnSlug; }
        //}

        public string Title
        {
            get { return _card.GetTitle(_lang); }
        }

        public void SetTranslatedTitle(Language lang, string title)
        {
            _card.SetTitle(lang, title);
        }

        public void SetTranslatedOppositeTitle(Language lang, string oppositeTitle)
        {
            _card.SetOppositeTitle(lang, oppositeTitle);
        }

        public string Description
        {
            get { return string.Format("{0} ({1})", _card.Title, _card.CardSet.Abbreviation); }
        }

        public string Url
        {
            get {
                return Lang == Language.EN
                    ? string.Format("/LotR/Details/{0}", Slug)
                    : string.Format("/LotR/Details/{0}?Lang={1}", Slug, Lang);
            }
        }

        public string SetSearchUrl
        {
            get
            {
                return string.Format("/LotR?CardSet={0}", _card.CardSet.Name.Replace(" ", "+"));
            }
        }

        private bool IsQuest()
        {
            return _card.CardType == CardType.Quest || _card.CardType == CardType.Encounter_Side_Quest || _card.CardType == CardType.Player_Side_Quest;
        }

        public string smallWidth
        {
            get
            {
                return IsQuest() || Card.HasHorizontalArt || Card.CardType == LotR.CardType.Cave ? "180px" : "127px";
            }
        }

        public string smallHeight
        {
            get
            {
                return IsQuest() || Card.HasHorizontalArt || Card.CardType == LotR.CardType.Cave ? "127px" : "180px";
            }
        }

        /*
        public string HallOfBeornBlogSearchUrl
        {
            get
            {
                var search = !string.IsNullOrEmpty(_card.NormalizedTitle) ? _card.NormalizedTitle.ToSearchString() : _card.Title.ToSearchString();
                return string.Format("http://hallofbeorn.wordpress.com/?s={0}", search);
            }
        }

        public string TalesFromTheCardsBlogSearchUrl
        {
            get
            {
                var search = !string.IsNullOrEmpty(_card.NormalizedTitle) ? _card.NormalizedTitle.ToSearchString() : _card.Title.ToSearchString();
                return string.Format("http://talesfromthecards.wordpress.com/?s={0}", search);
            }
        }

        public string MasterOfLoreBlogSearchUrl
        {
            get
            {
                var search = !string.IsNullOrEmpty(_card.NormalizedTitle) ? _card.NormalizedTitle.ToSearchString() : _card.Title.ToSearchString();
                return string.Format("http://masteroflore.wordpress.com/?s={0}", search);
            }
        }
        */

        public bool HasLinkedCards { get { return LinkedCards != null && LinkedCards.Count > 0; } }
        
        public List<Link> LinkedCards { get; set; }

        public bool HasBlogs { get { return true; } }

        public List<Link> Blogs()
        {
            var links = new List<Link>();

            links.Add(new Link(LinkType.Hall_of_Beorn_Blog, _card));
            links.Add(new Link(LinkType.Tales_from_the_Cards, _card));
            links.Add(new Link(LinkType.Master_of_Lore, _card));
            links.Add(new Link(LinkType.Dor_Cuarthol, _card));
            links.Add(new Link(LinkType.Second_Hand_Took, _card));
            links.Add(new Link(LinkType.The_Mirkwood_Runner, _card));
            links.Add(new Link(LinkType.Warden_of_Arnor, _card));
            links.Add(new Link(LinkType.Expecting_Mischief, _card));
            links.Add(new Link(LinkType.Heroes_of_the_Rings, _card));
            links.Add(new Link(LinkType.Very_Late_Adventurer, _card));
            links.Add(new Link(LinkType.Susurros_del_Bosque_Viejo, _card, "Susurros del Bosque Viejo (ES)"));
            links.Add(new Link(LinkType.El_Libro_Rojo_de_Bolson_Cerrado, _card, "El Libro Rojo De Bolsón Cerrado (ES)"));
            links.Add(new Link(LinkType.Die_Manner_von_Gondor, _card, "Die Männer von Gondor (DE)"));
            
            return links;
        }

        public bool HasReferences { get { return true; } }

        public List<Link> References()
        {
            var links = new List<Link>();

            links.Add(new Link(LinkType.Wikipedia, _card));
            links.Add(new Link(LinkType.Tolkien_Gateway, _card));
            links.Add(new Link(LinkType.Lord_of_the_Rings_Wiki, _card));
            links.Add(new Link(LinkType.Encyclopedia_of_Arda, _card));
            
            return links;
        }

        public string BlogTagUrl
        {
            get
            {
                var search = _card.Title.Replace(' ', '-').Replace("!", string.Empty).Replace("?", string.Empty);
                return string.Format("http://hallofbeorn.wordpress.com/tag/{0}", search);
            }
        }

        public bool HasErrata
        {
            get { return _card.HasErrata; }
        }

        public string ErrataUrl
        {
            get { return _card.HasErrata ? "https://images-cdn.fantasyflightgames.com/filer_public/64/ee/64ee44ca-825d-4c14-b77b-b0ad7581ee31/lotr_faq_18.pdf" : string.Empty; }
        }

        public string FullTitle
        {
            get
            {
                var subtitle = string.Empty;
                if (!string.IsNullOrEmpty(OppositeTitle))
                {
                    subtitle = OppositeTitle;
                }
                else if (!string.IsNullOrEmpty(_card.SlugSuffix))
                {
                    subtitle = _card.SlugSuffix;
                }

                return !string.IsNullOrEmpty(subtitle) ?
                    string.Format("{0} ({1})", Title, subtitle)
                    : Title;
            }
        }

        public string TitleTrimmed
        {
            get
            {
                if (string.IsNullOrEmpty(Title))
                {
                    return string.Empty;
                }

                if (Title.Length > 18)
                {
                    return Title.Substring(0, 18) + "…";
                }

                return Title;
            }
        }

        public string SetName
        {
            get { return _card.CardSet.Name; }
        }

        public string SetNameTrimmed
        {
            get
            {
                if (string.IsNullOrEmpty(this.SetName))
                {
                    return string.Empty;
                }

                if (this.SetName.Length > 14)
                {
                    return this.SetName.Substring(0, 14) + "…";
                }

                return this.SetName;
            }
        }

        public string Number
        {
            get
            { 
                return _card.SideLetter.HasValue
                ? string.Format("{0}{1}", _card.CardNumber, _card.SideLetter.Value)
                : _card.CardNumber.ToString(); 
            }
        }

        public string Quantity
        {
            get { return _card.Quantity.ToString(); }
        }

        public byte QuantityNumber
        {
            get { return _card.Quantity; }
        }

        public string EasyModeQuantity
        {
            get { return _card.EasyModeQuantity.HasValue ? _card.EasyModeQuantity.Value.ToString() : string.Empty; }
        }

        public IEnumerable<string> Keywords
        {
            get
            {
                foreach (var keyword in _card.KeywordsByLang(_lang))
                {
                    yield return keyword.ToDisplayString(_card.GetTitle(_lang));
                }
            }
        }

        public IEnumerable<string> Traits
        {
            get { return _card.TraitsByLang(_lang); }
        }

        public void AddTranslatedTraits(Language lang, IEnumerable<string> traits)
        {
            _card.WithTraits(lang, traits.ToArray());
        }

        public CardType CardType
        {
            get { return _card.CardType; }
        }

        public CardSubtype CardSubtype
        {
            get { return _card.CardSubtype; }
        }

        public string CardTypeName
        {
            get;
            set;
        }

        public string CampaignCardType
        {
            get
            {
                return (_card.CardSubtype == Models.CardSubtype.Boon || _card.CardSubtype == Models.CardSubtype.Burden) ?
                    _card.CardSubtype.ToString()
                    : (string)null;

            }
        }

        public string Sphere
        {
            get { return _card.Sphere.ToString(); }
        }

        public string SphereIcon
        {
            get
            {
                switch (_card.Sphere)
                {
                    case Models.LotR.Sphere.Neutral:
                    case Models.LotR.Sphere.None:
                        return string.Empty;
                    default:
                        return string.Format("/Images/{0}.png", _card.Sphere);
                }
            }
        }

        public string ThreatCost
        {
            get { return _card.ThreatCost.ToString(); }
        }

        public string ResourceCost
        {
            get { return _card.ResourceCost.Description(); }
        }

        public string Willpower
        {
            get { return _card.Willpower.Description(); }
        }

        public string Attack
        {
            get {return _card.Attack.Description(); }
        }

        public string Defense
        {
            get { return _card.Defense.Description();  }
        }

        public string HitPoints
        {
            get { return _card.HitPoints.Description(); }
        }

        public string EncounterSet
        {
            get
            {
                return _card.CardType != CardType.Hero && _card.CardType != CardType.Ally && _card.CardType != CardType.Attachment && _card.CardType != CardType.Event ?
                    _card.EncounterSet
                    : string.Empty;
            }
        }

        public byte EncounterSetNumber
        {
            get
            {
                return _card.EncounterSetNumber.HasValue ? _card.EncounterSetNumber.Value : (byte)0;
            }
        }

        public byte? EncounterCost
        {
            get { return _card.EncounterCost; }
        }

        public string EncounterSetLink
        {
            get
            {
                return !string.IsNullOrEmpty(EncounterSet) ?
                    string.Format("/LotR?EncounterSet={0}", _card.EncounterSet.ToSearchString())
                    : string.Empty;
            }
        }

        public string StageNumber
        {
            get { return _card.StageNumber > 0 ? _card.StageNumber.ToString() : string.Empty; }
        }

        public string StageLetters
        {
            get
            {
                var from = _card.StageLetter;
                var to = GetSecondStageLetter();

                return string.Format("{0}-{1}", from, to);
            }
        }

        public char GetSecondStageLetter()
        {
            return getSecondStageLetter(_card);
        }

        private static char getSecondStageLetter(LotRCard card)
        {
            return card.BackStageLetter.HasValue ? card.BackStageLetter.Value : (Char)(Convert.ToUInt16(card.StageLetter) + 1);
        }

        public string QuestPoints
        {
            get { return _card.QuestPoints.Description(); }
        }

        public string Threat
        {
            get { return _card.Threat.Description(); }
        }

        public string VictoryPoints
        {
            get
            {
                if (_card.VictoryPoints == Models.Card.VALUE_X)
                    return "Victory X.";

                return _card.VictoryPoints > 0 ?
                    string.Format("Victory {0}.", _card.VictoryPoints)
                    : (string)null;
            }
        }

        public string SiegePoints
        {
            get
            {
                return _card.SiegePoints.HasValue ? string.Format("SIEGE {0}", _card.SiegePoints) : string.Empty;
            }
        }

        public Language Lang
        {
            get { return _lang; }
        }

        private bool IsEncounterCard()
        {
            var encounterCardTypes = new HashSet<CardType>
            {
                CardType.Enemy,
                CardType.Ship_Enemy,
                CardType.Location,
                CardType.Treachery,
                CardType.Objective,
                CardType.Objective_Ally,
                CardType.Objective_Hero,
                CardType.Objective_Location,
                CardType.Encounter_Side_Quest,
                CardType.Cave
            };

            return encounterCardTypes.Contains(_card.CardType);
        }

        private bool IsQuestCard()
        {
            return _card.CardType == CardType.Quest;
        }

        public string BackgroundImage()
        {
            switch (_card.Sphere) 
            {
                case Models.LotR.Sphere.Leadership:
                case Models.LotR.Sphere.Tactics:
                case Models.LotR.Sphere.Spirit:
                case Models.LotR.Sphere.Lore:
                case Models.LotR.Sphere.Baggins:
                case Models.LotR.Sphere.Fellowship:
                    return string.Format("/Images/{0}.png", _card.Sphere.ToString());
                default:
                    if (IsEncounterCard())
                    {
                        return "/Images/encounter-card-back.jpg";
                    }
                    return null;
            }
        }

        public string BackgroundImageTop()
        {
            switch (_card.Sphere)
            {
                case Models.LotR.Sphere.Leadership:
                case Models.LotR.Sphere.Tactics:
                case Models.LotR.Sphere.Spirit:
                case Models.LotR.Sphere.Lore:
                case Models.LotR.Sphere.Baggins:
                case Models.LotR.Sphere.Fellowship:
                    return "-5px";
                default:
                    if (IsEncounterCard())
                    {
                        return "0px";
                    }
                    return "-5px";
            }
        }

        public string BackgroundImageLeft()
        {
            //48px
            switch (_card.Sphere)
            {
                case Models.LotR.Sphere.Leadership:
                case Models.LotR.Sphere.Tactics:
                case Models.LotR.Sphere.Spirit:
                case Models.LotR.Sphere.Lore:
                case Models.LotR.Sphere.Baggins:
                case Models.LotR.Sphere.Fellowship:
                    return "48px";
                default:
                    if (IsEncounterCard())
                    {
                        return "0px";
                    }
                    return "48px;";
            }
        }

        public string BackgroundImageHeight()
        {
            switch (_card.Sphere)
            {
                case Models.LotR.Sphere.Leadership:
                case Models.LotR.Sphere.Tactics:
                case Models.LotR.Sphere.Spirit:
                case Models.LotR.Sphere.Lore:
                case Models.LotR.Sphere.Baggins:
                case Models.LotR.Sphere.Fellowship:
                    return "200px";
                default:
                    if (IsEncounterCard())
                    {
                        return "100%";
                    }
                    return "200px";
            }
        }

        public string BackgroundImageWidth()
        {
            switch (_card.Sphere)
            {
                case Models.LotR.Sphere.Leadership:
                case Models.LotR.Sphere.Tactics:
                case Models.LotR.Sphere.Spirit:
                case Models.LotR.Sphere.Lore:
                case Models.LotR.Sphere.Baggins:
                case Models.LotR.Sphere.Fellowship:
                    return "200";
                default:
                    if (IsEncounterCard())
                    {
                        return "100%";
                    }
                    return "200";
            }
        }

        public string BackgroundColor()
        {
            switch (_card.Sphere)
            {
                case Models.LotR.Sphere.Leadership:
                    return "rgba(128, 0, 128, .1)";
                case Models.LotR.Sphere.Tactics:
                    return "rgba(255, 0, 0, .1)";
                case Models.LotR.Sphere.Spirit:
                    return "rgba(0, 0, 255, .05)";
                case Models.LotR.Sphere.Lore:
                    return "rgba(0, 128, 0, .1)";
                case Models.LotR.Sphere.Baggins:
                    return "rgba(255, 255, 0, .1)";
                case Models.LotR.Sphere.Fellowship:
                    return "rgba(255, 210, 0, .1)";
                case Models.LotR.Sphere.Neutral:
                    return "#e4e4e4";
                default:
                    if (IsEncounterCard())
                    {
                        return "rgba(0, 0, 0, .1)";
                    }
                    else if (IsQuestCard())
                    {
                        return "#d3d3d3";
                    }
                    return "White";
            }
        }

        public string PassValue
        {
            get
            {
                return (_card.PassValue.HasValue && _card.PassValue.Value) ?
                    "PASS"
                    : string.Empty;
            }
        }

        public string DirectionValue
        {
            get { return _card.Direction; }
        }

        public string StatScore
        {
            get
            {
                return
                    (_card.StatScore() > 0D)
                    ? string.Format("{0:0}", _card.StatScore())
                    : "0";
            }
        }

        public string StatEfficiency
        {
            get
            {
                var score = _card.StatScore();

                return score > 0D
                    ? string.Format("{0:0}★", score)
                    : string.Empty;
                
                /*
                var max = Math.Round((efficiency - .5) * 10, MidpointRounding.AwayFromZero) + 1;

                //return string.Format("{0:00.00}", max);

                var html = new System.Text.StringBuilder();

                for (var i=1; i<5; i++)
                {
                    if (i <= max)
                        html.Append("★");
                }

                return html.ToString();
                */
            }
        }

        public string EngagementCost
        {
            get { return _card.EngagementCost.HasValue ? _card.EngagementCost.ToString() : string.Empty; }
        }

        public string Text
        {
            get {
                return !string.IsNullOrEmpty(_card.GetText(_lang)) ?
                    _card.GetText(_lang).ToDisplayString(_card.GetTitle(_lang))
                    : string.Empty;
            }
        }

        public string Shadow
        {
            get {
                return !string.IsNullOrEmpty(_card.Shadow) ?
                    _card.Shadow.ToDisplayString(_card.Title)
                    : string.Empty;
            }
        }

        public IEnumerable<string> FlavorText
        {
            get
            {
                return
                    !string.IsNullOrEmpty(_card.FlavorText) ?
                    _card.FlavorText.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList()
                    : Enumerable.Empty<string>();
            }
        }

        public bool HasFlavorText
        {
            get { return FlavorText.Count() > 0; }
        }

        public IEnumerable<string> OppositeFlavorText
        {
            get
            {
                return
                    !string.IsNullOrEmpty(_card.OppositeFlavorText) ?
                    _card.OppositeFlavorText.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList()
                    : Enumerable.Empty<string>();
            }
        }

        public bool HasOppositeFlavorText
        {
            get { return OppositeFlavorText.Count() > 0; }
        }


        public string OppositeTitle
        {
            get { return _card.GetOppositeTitle(_lang); }
        }

        public string OppositeText
        {
            get {
                return !string.IsNullOrEmpty(_card.OppositeText) ?
                    _card.OppositeText.ToDisplayString(_card.Title)
                    : string.Empty;
            }
        }

        public bool HasPreviousImages
        {
            get { return _card.PreviousVersions > 0; }
        }

        public IEnumerable<string> PreviousImages()
        {
            const string ext = ".jpg";
            for (var i = 1; i <= _card.PreviousVersions; i++)
            {
                var suffix = string.Format("_{0}.jpg", i);
                var path = string.Empty;
                if (HasSecondImage)
                {
                    yield return _card.ErrataFront 
                        ? ImagePath1.Replace(ext, suffix)
                        : ImagePath2.Replace(ext, suffix);
                }
                else 
                {
                    yield return _card.ErrataFront
                        ? ImagePath.Replace(ext, suffix)
                        : ImagePath2.Replace(ext, suffix);
                }
            }
        }

        public bool HasCommunityImages
        {
            get { return _card.CommunityVersions.Any(); }
        }

        public IEnumerable<Tuple<string, string>> CommunityImages()
        {
            return GetCommunityImages(_card.CommunityVersions);
        }

        public static IEnumerable<Tuple<string, string>> GetCommunityImages(IEnumerable<string> versions)
        {
            const string format = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Community/{0}.jpg";

            Func<string, string> getTitle = (s) => s.Replace('-', ' ').Replace("/", ": ");

            return versions.Select(
                slug => new Tuple<string, string>(getTitle(slug), string.Format(format, slug)));
        }

        public string ImagePath
        {
            get { return GetImagePathForLanguage(_card, _lang); }
        }

        public static string GetImagePathForLanguage(LotRCard card, Language? lang = null, bool isFirst = true)
        {
            var useLang = lang.HasValue ? lang.Value : card.DefaultLang;

            if (card.CardType == CardType.Quest)
            {
                return getQuestCardImagePath(card, isFirst, lang.GetValueOrDefault(Language.EN));
            }

            if (card.CardType == CardType.Contract)
            {
                return getContractCardImagePath(card, isFirst, useLang);
            }

            var setupCardTypes = new HashSet<CardType> { CardType.GenCon_Setup, CardType.Nightmare_Setup, CardType.Campaign, CardType.Scenario };

            if (setupCardTypes.Contains(card.CardType))
            {
                return getSetupCardImagePath(card, isFirst, useLang);
            }

            if (useLang == Language.EN)
            {
                var set = !string.IsNullOrEmpty(card.CardSet.NormalizedName) ? card.CardSet.NormalizedName.ToUrlSafeString() : card.CardSet.Name.ToUrlSafeString();
                var title = card.Title.ToUrlSafeString();
                var suffix = !string.IsNullOrEmpty(card.SlugSuffix) ? string.Format("-{0}", card.SlugSuffix.ToUrlSafeString()) : string.Empty;
                var extension = getEnglishImageExtension(card);

                return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/Cards/{0}/{1}{2}.{3}", set, title, suffix, extension);
            } 
            else
            {
                var set = !string.IsNullOrEmpty(card.CardSet.NormalizedName) ? card.CardSet.NormalizedName.ToUrlSafeString() : card.CardSet.Name.ToUrlSafeString();
                var title = card.GetTitle(useLang).ToUrlSafeString();
                var suffix = !string.IsNullOrEmpty(card.SlugSuffix) ? string.Format("-{0}", card.SlugSuffix.ToUrlSafeString()) : string.Empty;

                var langDirectory = Enum.GetName(typeof(Language), useLang);

                var extension = getTranslatedImageExtension(card, useLang);

                return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Cards/{0}/{1}/{2}{3}.{4}", langDirectory, set, title, suffix, extension);
            }
        }

        private static string getImagePath(LotRCard card, string directory, Language lang)
        {
            var set = !string.IsNullOrEmpty(card.CardSet.NormalizedName) ? card.CardSet.NormalizedName.ToUrlSafeString() : card.CardSet.Name.ToUrlSafeString();
            var title = card.GetTitle(lang).ToUrlSafeString();
            var suffix = !string.IsNullOrEmpty(card.SlugSuffix) ? string.Format("-{0}", card.SlugSuffix.ToUrlSafeString()) : string.Empty;

            var extension = getEnglishImageExtension(card);

            if (lang != Language.EN)
            {
                directory += "/" + Enum.GetName(typeof(Language), lang);
                extension = getTranslatedImageExtension(card, lang);
            }

            return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/{0}/{1}/{2}{3}.{4}", directory, set, title, suffix, extension);
        }

        private readonly static Dictionary<SetType, HashSet<Language>> translatedSetTypes = new Dictionary<SetType, HashSet<Language>>
        {
            { SetType.A_Long_extended_Party, new HashSet<Language> { Language.DE, Language.ES, Language.FR, Language.IT, Language.PL } },
            { SetType.Core, new HashSet<Language> { Language.ES, Language.FR } },
        };

        private static string getEnglishImageExtension(LotRCard card)
        {
            return card.CardSet.SetType == SetType.A_Long_extended_Party
                ? "png"
                : "jpg";
        }

        private static string getTranslatedImageExtension(LotRCard card, Language lang)
        {
            return card.CardSet != null && translatedSetTypes.ContainsKey(card.CardSet.SetType) && translatedSetTypes[card.CardSet.SetType].Contains(lang)
                ? "png"
                : "jpg";
        }

        public string ThumbImagePath
        {
            get
            {
                return _lang == Language.EN
                    ? getImagePath(_card, "Thumbnails", _lang)
                    : getImagePath(_card, "Cards", _lang);
                //var set = !string.IsNullOrEmpty(_card.CardSet.NormalizedName) ? _card.CardSet.NormalizedName.ToUrlSafeString() : _card.CardSet.Name.ToUrlSafeString();
                //var title = _card.Title.ToUrlSafeString();
                //var suffix = !string.IsNullOrEmpty(_card.SlugSuffix) ? string.Format("-{0}", _card.SlugSuffix.ToUrlSafeString()) : string.Empty;
                //var thumb = _card.HasThumbnail ? "_thumb" : string.Empty;

                //return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Thumbnails/{0}/{1}{2}.jpg", set, title, suffix);
            }
        }

        public string ArtImagePath
        {
            get { return getImagePath(_card, "Art", _lang); }
        }

        public string ArtImagePath1
        {
            get {
                switch (_card.CardType)
                {
                    case Models.LotR.CardType.Quest:
                        return getQuestCardArtImagePath(true); 
                    case Models.LotR.CardType.Campaign:
                    case Models.LotR.CardType.Nightmare_Setup:
                    case Models.LotR.CardType.GenCon_Setup:
                    case Models.LotR.CardType.Scenario:
                        return getSetupCardArtImagePath(true);
                    default:
                        return null;
                }
            }
        }

        public string ArtImagePath2
        {
            get {
                switch (_card.CardType)
                {
                    case Models.LotR.CardType.Quest:
                        return getQuestCardArtImagePath(false);
                    default:
                        return null;
                }
            }
        }

        public string getQuestCardImagePath(bool isFirst, Language lang)
        {
            return getQuestCardImagePath(_card, isFirst, lang);
        }

        public static string getQuestCardImagePath(LotRCard card, bool isFirst, Language lang)
        {
            var set = (card.CardSet != null && !string.IsNullOrEmpty(card.CardSet.NormalizedName)) ? card.CardSet.NormalizedName.ToUrlSafeString() : card.CardSet.Name.ToUrlSafeString();

            var path = "Cards";
            var extension = getEnglishImageExtension(card);

            if (lang != Language.EN)
            {
                set = lang.ToString() + "/" + set;
                path = "LotR/Cards";
                extension = getTranslatedImageExtension(card, lang);
            }

            var title = card.GetTitle(lang).ToUrlSafeString();
            var suffix = !string.IsNullOrEmpty( card.SlugSuffix) ? string.Format("-{0}", card.SlugSuffix.ToUrlSafeString()) : string.Empty;
            var number = card.StageNumber.ToString();

            var letter = isFirst ? "A" : "B";
            if (card.StageLetter != 'A')
            {
                letter = isFirst ? card.StageLetter.ToString() : getSecondStageLetter(card).ToString();
            }

            return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/{0}/{1}/{2}{3}-{4}{5}.{6}", path, set, title, suffix, number, letter, extension);
        }

        public static string getSetupCardImagePath(LotRCard card, bool isFirst, Language lang)
        {
            var set = (card.CardSet != null && !string.IsNullOrEmpty(card.CardSet.NormalizedName)) ? card.CardSet.NormalizedName.ToUrlSafeString() : card.CardSet.Name.ToUrlSafeString();

            var path = "Cards";
            var extension = getEnglishImageExtension(card);

            if (lang != Language.EN)
            {
                set = lang.ToString() + "/" + set;
                path = "LotR/Cards";
                extension = getTranslatedImageExtension(card, lang);
            }

            var title = card.GetTitle(lang).ToUrlSafeString();

            var suffix = card.CardType == LotR.CardType.Scenario
                ? "Scenario"
                : "Setup";
            
            var letter = isFirst ? "A" : "B";

            return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/{0}/{1}/{2}-{3}{4}.{5}", path, set, title, suffix, letter, extension);
        }

        public static string getContractCardImagePath(LotRCard card, bool isFirst, Language lang)
        {
            if (!string.IsNullOrEmpty(card.OppositeText))
            {
                var set = (card.CardSet != null && !string.IsNullOrEmpty(card.CardSet.NormalizedName)) ? card.CardSet.NormalizedName.ToUrlSafeString() : card.CardSet.Name.ToUrlSafeString();

                var path = "Cards";
                var extension = getEnglishImageExtension(card);

                if (lang != Language.EN)
                {
                    set = lang.ToString() + "/" + set;
                    path = "LotR/Cards";
                    extension = getTranslatedImageExtension(card, lang);
                }

                var title = card.GetTitle(lang).ToUrlSafeString();
                var letter = isFirst ? "A" : "B";

                return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/{0}/{1}/{2}-Side{3}.{4}", path, set, title, letter, extension);
            }
            else 
            {
                var set = (card.CardSet != null && !string.IsNullOrEmpty(card.CardSet.NormalizedName)) ? card.CardSet.NormalizedName.ToUrlSafeString() : card.CardSet.Name.ToUrlSafeString();

                var path = "Cards";
                var extension = getEnglishImageExtension(card);

                if (lang != Language.EN)
                {
                    set = lang.ToString() + "/" + set;
                    path = "LotR/Cards";
                    extension = getTranslatedImageExtension(card, lang);
                }

                var title = card.GetTitle(lang).ToUrlSafeString();
                return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/{0}/{1}/{2}.{3}", path, set, title, extension);
            }
        }

        public string getQuestCardArtImagePath(bool isFirst)
        {
            var set = (Card.CardSet != null && !string.IsNullOrEmpty(_card.CardSet.NormalizedName)) ? _card.CardSet.NormalizedName.ToUrlSafeString() : _card.CardSet.Name.ToUrlSafeString();
            var title = Title.ToUrlSafeString();
            var suffix = !string.IsNullOrEmpty(_card.SlugSuffix) ? string.Format("-{0}", _card.SlugSuffix.ToUrlSafeString()) : string.Empty;
            var number = _card.StageNumber.ToString();

            var letter = isFirst ? "A" : "B";
            if (_card.StageLetter != 'A')
            {
                letter = isFirst ? _card.StageLetter.ToString() : GetSecondStageLetter().ToString();
            }

            return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Art/{0}/{1}{2}-{3}{4}.jpg", set, title, suffix, number, letter);
        }

        public string getSetupCardArtImagePath(bool isFirst)
        {
            var set = (_card.CardSet != null && !string.IsNullOrEmpty(_card.CardSet.NormalizedName)) ? _card.CardSet.NormalizedName.ToUrlSafeString() : _card.CardSet.Name.ToUrlSafeString();
            var title = _card.Title.ToUrlSafeString();
            var letter = isFirst ? "A" : "B";

            return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Art/{0}/{1}-Setup{2}.jpg", set, title, letter);
        }

        private readonly HashSet<CardType> canBeDoubleSided = new HashSet<CardType> { CardType.Location, CardType.Encounter_Side_Quest };

        public bool HasSecondImage
        {
            get
            {
                if (!string.IsNullOrEmpty(_card.OppositeTitle) && canBeDoubleSided.Contains(_card.CardType)) {
                    return true;
                }

                switch (_card.CardType)
                {
                    case LotR.CardType.GenCon_Setup:
                        return !string.IsNullOrEmpty(_card.OppositeText);
                    case LotR.CardType.Quest:
                    case LotR.CardType.Scenario:
                    case LotR.CardType.Campaign:
                    case LotR.CardType.Nightmare_Setup:
                        return true;
                    case LotR.CardType.Contract:
                        return !string.IsNullOrWhiteSpace(_card.OppositeText);
                    default:
                        return false;
                }
            }
        }

        public bool HasSecondArtImage
        {
            get
            {
                if (!string.IsNullOrEmpty(_card.OppositeTitle) && canBeDoubleSided.Contains(_card.CardType)) {
                    return true;
                }

                return _card.CardType == LotR.CardType.Quest;
            }
        }

        private string secondImagePath
        {
            get
            {
                if (!string.IsNullOrEmpty(_card.OppositeTitle) && canBeDoubleSided.Contains(_card.CardType))
                {
                    return _card.OppositeTitle.ToUrlSafeString();
                }

                return string.Empty;
            }
        }

        public string ImagePath1
        {
            get {

                if (HasSecondImage && !string.IsNullOrEmpty(secondImagePath))
                {
                    return ImagePath;
                }

                switch (_card.CardType)
                {
                    case Models.LotR.CardType.Quest:
                        return getQuestCardImagePath(true, _lang); 
                    case Models.LotR.CardType.Campaign:
                    case Models.LotR.CardType.Nightmare_Setup:
                    case Models.LotR.CardType.GenCon_Setup:
                    case Models.LotR.CardType.Scenario:
                        return getSetupCardImagePath(_card, true, _lang);
                    case Models.LotR.CardType.Contract:
                        return getContractCardImagePath(_card, true, _lang);
                    default:
                        return null;
                }
            }
        }

        public string ImagePath2
        {
            get
            {
                if (HasSecondImage && !string.IsNullOrEmpty(secondImagePath))
                {
                    var set = !string.IsNullOrEmpty(_card.CardSet.NormalizedName) ? _card.CardSet.NormalizedName.ToUrlSafeString() : _card.CardSet.Name.ToUrlSafeString();
                    return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/Cards/{0}/{1}.jpg", set, secondImagePath);
                }

                switch (_card.CardType)
                {
                    case Models.LotR.CardType.Quest:
                        return getQuestCardImagePath(false, _lang);
                    case Models.LotR.CardType.Campaign:
                    case Models.LotR.CardType.Nightmare_Setup:
                    case Models.LotR.CardType.GenCon_Setup:
                    case Models.LotR.CardType.Scenario:
                        return getSetupCardImagePath(_card, false, _lang);
                    case Models.LotR.CardType.Contract:
                        return getContractCardImagePath(_card, false, _lang);
                    default:
                        return null;
                }
            }
        }

        public bool HasCategories
        {
            get { return getPlayerCategories(_card.Slug).Count() > 0; }
        }

        public bool HasEncounterCategories
        {
            get { return getEncounterCategories(_card.Slug).Count() > 0; }
        }

        public bool HasQuestCategories
        {
            get { return getQuestCategories(_card.Slug).Count() > 0; }
        }

        public bool HasRegions
        {
            get { return getRegions(_card.Slug).Any(); }
        }

        public bool HasArchetypes
        {
            get { return getArchetypes(_card.Slug).Any(); }
        }

        public Dictionary<string, string> Categories()
        {
            var categoryMap = new Dictionary<string, string>();

            foreach (var category in getPlayerCategories(_card.Slug))
            {
                var key = category.ToString().Replace('_', ' ');
                var value = string.Format("/Cards/Search?Category={0}", category.ToString().Replace('_', '+'));
                if (!categoryMap.ContainsKey(key))
                {
                    categoryMap.Add(key, value);
                }
            }

            return categoryMap;
        }

        public Dictionary<string, string> EncounterCategories()
        {
            var categoryMap = new Dictionary<string, string>();

            foreach (var category in getEncounterCategories(_card.Slug))
            {
                var key = category.ToString().Replace('_', ' ');
                var value = string.Format("/Cards/Search?EncounterCategory={0}", category.ToString().Replace('_', '+'));
                if (!categoryMap.ContainsKey(key))
                {
                    categoryMap.Add(key, value);
                }
            }

            return categoryMap;
        }

        public Dictionary<string, string> QuestCategories()
        {
            var categoryMap = new Dictionary<string, string>();

            foreach (var category in getQuestCategories(_card.Slug))
            {
                var key = category.ToString().Replace('_', ' ');
                var value = string.Format("/Cards/Search?QuestCategory={0}", category.ToString().Replace('_', '+'));
                if (!categoryMap.ContainsKey(key))
                {
                    categoryMap.Add(key, value);
                }
            }

            return categoryMap;
        }


        public Dictionary<string, string> Regions()
        {
            var regionMap = new Dictionary<string, string>();

            foreach (var region in getRegions(_card.Slug))
            {
                var key = region.ToString().Replace('_', ' ');
                var value = string.Format("/LotR?Region={0}", region.ToString().Replace('_', '+'));
                if (!regionMap.ContainsKey(key))
                {
                    regionMap.Add(key, value);
                }
            }

            return regionMap;
        }


        public Dictionary<string, string> Archetypes()
        {
            var archetypeMap = new Dictionary<string, string>();

            foreach (var archetype in getArchetypes(_card.Slug))
            {
                var key = archetype.ToString().Replace('_', ' ');
                var value = string.Format("/LotR?Archetype={0}", archetype.ToString().Replace('_', '+'));
                if (!archetypeMap.ContainsKey(key))
                {
                    archetypeMap.Add(key, value);
                }
            }

            return archetypeMap;
        }

        public string DetailPath
        {
            get { return string.Format("/Cards/Details/{0}", Id); }
        }

        public bool HasCharacterStats
        {
            get
            {
                return _card.Willpower > 0 || _card.Attack > 0 || _card.Defense > 0 || _card.HitPoints > 0;
            }
        }

        public bool IsUnique
        {
            get { return _card.IsUnique; }
        }

        public string Artist
        {
            get { return _card.Artist != null ? _card.Artist.Name : string.Empty; }
        }

        public string ArtistURL
        {
            get { return _card.Artist != null ? _card.Artist.URL : string.Empty; }
        }

        public string SecondArtist
        {
            get { return _card.SecondArtist != null ? _card.SecondArtist.Name : string.Empty; }
        }

        public string SecondArtistURL
        {
            get { return _card.SecondArtist != null ? _card.SecondArtist.URL : string.Empty; }
        }

        public string OppositeArtist
        {
            get { return _card.BackArtist != null ? _card.BackArtist.Name : string.Empty; }
        }

        public string OppositeArtistURL
        {
            get { return _card.BackArtist != null ? _card.BackArtist.URL : string.Empty; }
        }

        public string Year
        {
            get { return _card.Year > 0 ? _card.Year.ToString() : string.Empty; }
        }

        public bool HasSphere
        {
            get { return _card.Sphere == Models.LotR.Sphere.Leadership || _card.Sphere == Models.LotR.Sphere.Tactics || _card.Sphere == Models.LotR.Sphere.Spirit || _card.Sphere == Models.LotR.Sphere.Lore || _card.Sphere == Models.LotR.Sphere.Mastery || _card.Sphere == Models.LotR.Sphere.Fellowship || _card.Sphere == LotR.Sphere.Baggins; }
        }

        public bool HasEncounterSet
        {
            get { return !string.IsNullOrEmpty(EncounterSet); }
        }

        public bool HasEncounterSetNumber
        {
            get { return _card.EncounterSetNumber.HasValue; }
        }

        public bool HasCardSubtype
        {
            get { return _card.CardSubtype != Models.CardSubtype.None; }
        }

        public string EncounterSetImagePath
        {
            get
            {
                return HasEncounterSet ?
                    string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/Cards/{0}/{1}.png", _card.CardSet.NormalizedName.ToUrlSafeString(), _card.EncounterSet.ToUrlSafeString())
                    : string.Empty;
            }
        }

        public bool IsNightmare
        {
            get { return _card.CardSet.Cycle == "NIGHTMARE"; }
        }

        /*
        public IEnumerable<Deck> Decks
        {
            get { return _card.Decks.Values; }
        }

        public List<CardViewModel> RelatedCards
        {
            get {
                return _card.RelatedCards.Select(x => new CardViewModel(x)).ToList();
            }
        }
        */

        public bool HasHtml
        {
            get { return !string.IsNullOrEmpty(Html); }
        }

        public string Html
        {
            get { return _card.GetFrontHtml(_lang); }
        }

        public bool HasHtml2
        {
            get { return !string.IsNullOrEmpty(Html2); }
        }

        public string Html2
        {
            get { return _card.GetBackHtml(_lang); }
        }

        public string OctgnGuid
        {
            get;
            set;
        }

        public string RingsDbUrl
        {
            get;
            set;
        }

        public byte Popularity { get; set; }

        public uint Votes { get; set; }

        public string CharacterUrl { get; set; }

        public string PopularityHtml
        {
            get
            {
                if (Popularity > 0)
                {
                    var icon = string.Format("<b>{0}</b>&nbsp;<img src='/Images/gold-ring.png' style='margin-bottom:-2px;' height='16' width='16' title='Popularity {0}/10  (Rank {1})'/>", Popularity, Votes);

                    var html = new System.Text.StringBuilder(icon);

                    /*
                    for (var i = 0; i < Popularity; i++)
                    {
                        html.Append(icon);
                    }*/

                    //html.AppendFormat("<span style='color:gray;font-size:12px;margin-left:8px;margin-bottom:2px;'>[{0}]</span>", Votes);

                    return html.ToString();
                }

                return string.Empty;
            }
        }

        private readonly List<CardNote> notes = new List<CardNote>();

        public bool HasNotes()
        {
            return notes.Count > 0;
        }

        public IEnumerable<CardNote> Notes()
        {
            return notes;
        }

        public void LoadNotes(IEnumerable<CardNote> notes)
        {
            foreach (var note in notes)
            {
                this.notes.Add(note);
            }
        }

        private readonly List<CardTag> tags = new List<CardTag>();

        public bool HasTags()
        {
            return tags.Count > 0;
        }

        public IEnumerable<CardTag> Tags()
        {
            return tags;
        }

        public void LoadTags(IEnumerable<CardTag> tags)
        {
            foreach (var tag in tags)
            {
                this.tags.Add(tag);
            }
        }

        private readonly List<LinkViewModel> contentLinks = new List<LinkViewModel>();

        public IEnumerable<LinkViewModel> ContentLinks
        {
            get { return contentLinks; }
        }

        public void LoadContentLinks(IEnumerable<ILink> links)
        {
            foreach (var link in links)
            {
                contentLinks.Add(new LinkViewModel(link));
            }
        }

        public bool HasContentLinks()
        {
            return contentLinks.Count > 0;
        }
    }
}