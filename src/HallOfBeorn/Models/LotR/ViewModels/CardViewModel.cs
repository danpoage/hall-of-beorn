using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class CardViewModel
    {
        public CardViewModel(LotRCard card, Func<string, IEnumerable<Category>> getPlayerCategories, Func<string, IEnumerable<EncounterCategory>> getEncounterCategories, Func<string, IEnumerable<QuestCategory>> getQuestCategories)
            : this(card, 0f, string.Empty, getPlayerCategories, getEncounterCategories, getQuestCategories)
        {
        }

        public CardViewModel(CardScore score, Func<string, IEnumerable<Category>> getPlayerCategories, Func<string, IEnumerable<EncounterCategory>> getEncounterCategories, Func<string, IEnumerable<QuestCategory>> getQuestCategories)
            : this(score.Card, score.Score(), score.Description, getPlayerCategories, getEncounterCategories, getQuestCategories)
        {
        }

        public CardViewModel(LotRCard card, float score, string searchDescription, Func<string, IEnumerable<Category>> getPlayerCategories, Func<string, IEnumerable<EncounterCategory>> getEncounterCategories, Func<string, IEnumerable<QuestCategory>> getQuestCategories)
        {
            _card = card;
            _score = score;
            _searchDescription = searchDescription;
            this.getPlayerCategories = getPlayerCategories;
            this.getEncounterCategories = getEncounterCategories;
            this.getQuestCategories = getQuestCategories;

            foreach (var encounterSet in _card.IncludedEncounterSets)
            {
                _includedEncounterSets.Add(new EncounterSetViewModel(encounterSet));
            }
        }

        private LotRCard _card;
        private float _score;
        private string _searchDescription;

        private Func<string, IEnumerable<Category>> getPlayerCategories;
        private Func<string, IEnumerable<EncounterCategory>> getEncounterCategories;
        private Func<string, IEnumerable<QuestCategory>> getQuestCategories;

        private readonly List<CardEffect> _keywordEffects = new List<CardEffect>();
        private readonly List<CardEffect> _textEffects = new List<CardEffect>();
        private readonly List<CardEffect> _oppositeTextEffects = new List<CardEffect>();
        private readonly List<CardEffect> _shadowEffects = new List<CardEffect>();
        private readonly List<EncounterSetViewModel> _includedEncounterSets = new List<EncounterSetViewModel>();

        public List<CardEffect> KeywordEffects { get { return _keywordEffects; } }
        public List<CardEffect> TextEffects { get { return _textEffects; } }
        public List<CardEffect> OppositeTextEffects { get { return _oppositeTextEffects; } }
        public List<CardEffect> ShadowEffects { get { return _shadowEffects; } }

        public bool HasIncludedEncounterSets { get { return _includedEncounterSets.Count > 0; } }
        public List<EncounterSetViewModel> IncludedEncounterSets { get { return _includedEncounterSets; } }

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
            get { return _card.Title; }
        }

        public string Description
        {
            get { return string.Format("{0} ({1})", _card.Title, _card.CardSet.Abbreviation); }
        }

        public string Url
        {
            get { return string.Format("/Cards/Details/{0}", Slug); }
        }

        public string SetSearchUrl
        {
            get
            {
                return string.Format("/Cards/Search?CardSet={0}", _card.CardSet.Name.Replace(" ", "+"));
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
                return IsQuest() ? "180px" : "127px";
            }
        }

        public string smallHeight
        {
            get
            {
                return IsQuest() ? "127px" : "180px";
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

        public bool HasBlogs { get { return true; } }

        public List<Link> Blogs()
        {
            var links = new List<Link>();

            links.Add(new Link(LinkType.Hall_of_Beorn, _card));
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
            get { return _card.CardNumber.ToString(); }
        }

        public string Quantity
        {
            get { return _card.Quantity.ToString(); }
        }

        public string EasyModeQuantity
        {
            get { return _card.EasyModeQuantity.HasValue ? _card.EasyModeQuantity.Value.ToString() : string.Empty; }
        }

        public IEnumerable<string> Keywords
        {
            get
            {
                foreach (var keyword in _card.Keywords)
                {
                    yield return keyword.ToDisplayString(_card.Title);
                }
            }
        }

        public IEnumerable<string> Traits
        {
            get { return _card.Traits; }
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
            get { return _card.CardType.ToString().Replace('_', '-'); }
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

        public string EncounterSetLink
        {
            get
            {
                return !string.IsNullOrEmpty(EncounterSet) ?
                    string.Format("/Cards/Search?EncounterSet={0}", _card.EncounterSet.ToSearchString())
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
                char from = _card.StageLetter;
                char to = (Char)(Convert.ToUInt16(_card.StageLetter) + 1);

                return string.Format("{0}-{1}", from, to);
            }
        }

        public char GetSecondStageLetter()
        {
            var second = (Char)(Convert.ToUInt16(_card.StageLetter) + 1);
            return second;
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
                    if (_card.CardType == Models.LotR.CardType.Enemy || _card.CardType == Models.LotR.CardType.Location || _card.CardType == Models.LotR.CardType.Treachery || _card.CardType == Models.LotR.CardType.Objective || _card.CardType == Models.LotR.CardType.Objective_Ally || _card.CardType == Models.LotR.CardType.Objective_Location || _card.CardType == Models.LotR.CardType.Encounter_Side_Quest)
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
                    if (_card.CardType == Models.LotR.CardType.Enemy || _card.CardType == Models.LotR.CardType.Location || _card.CardType == Models.LotR.CardType.Treachery || _card.CardType == Models.LotR.CardType.Objective || _card.CardType == Models.LotR.CardType.Objective_Ally || _card.CardType == Models.LotR.CardType.Objective_Location || _card.CardType == Models.LotR.CardType.Encounter_Side_Quest)
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
                    if (_card.CardType == Models.LotR.CardType.Enemy || _card.CardType == Models.LotR.CardType.Location || _card.CardType == Models.LotR.CardType.Treachery || _card.CardType == Models.LotR.CardType.Objective || _card.CardType == Models.LotR.CardType.Objective_Ally || _card.CardType == Models.LotR.CardType.Objective_Location || _card.CardType == Models.LotR.CardType.Encounter_Side_Quest)
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
                    if (_card.CardType == Models.LotR.CardType.Enemy || _card.CardType == Models.LotR.CardType.Location || _card.CardType == Models.LotR.CardType.Treachery || _card.CardType == Models.LotR.CardType.Objective || _card.CardType == Models.LotR.CardType.Objective_Ally || _card.CardType == Models.LotR.CardType.Objective_Location || _card.CardType == Models.LotR.CardType.Encounter_Side_Quest)
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
                    if (_card.CardType == Models.LotR.CardType.Enemy || _card.CardType == Models.LotR.CardType.Location || _card.CardType == Models.LotR.CardType.Treachery || _card.CardType == Models.LotR.CardType.Objective || _card.CardType == Models.LotR.CardType.Objective_Ally || _card.CardType == Models.LotR.CardType.Objective_Location || _card.CardType == Models.LotR.CardType.Encounter_Side_Quest)
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
                    if (_card.CardType == Models.LotR.CardType.Enemy || _card.CardType == Models.LotR.CardType.Location || _card.CardType == Models.LotR.CardType.Treachery || _card.CardType == Models.LotR.CardType.Objective || _card.CardType == Models.LotR.CardType.Objective_Ally || _card.CardType == Models.LotR.CardType.Objective_Location || _card.CardType == Models.LotR.CardType.Encounter_Side_Quest)
                    {
                        return "rgba(0, 0, 0, .1)";
                    }
                    else if (_card.CardType == Models.LotR.CardType.Quest)
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

        public string EngagementCost
        {
            get { return _card.EngagementCost.HasValue ? _card.EngagementCost.ToString() : string.Empty; }
        }

        public string Text
        {
            get {
                return !string.IsNullOrEmpty(_card.Text) ?
                    _card.Text.ToDisplayString(_card.Title)
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
            get { return _card.OppositeTitle; }
        }

        public string OppositeText
        {
            get {
                return !string.IsNullOrEmpty(_card.OppositeText) ?
                    _card.OppositeText.ToDisplayString(_card.Title)
                    : string.Empty;
            }
        }

        public string ImagePath
        {
            get
            {
                var set = !string.IsNullOrEmpty(_card.CardSet.NormalizedName) ? _card.CardSet.NormalizedName.ToUrlSafeString() : _card.CardSet.Name.ToUrlSafeString();
                var title = _card.Title.ToUrlSafeString();
                var suffix = !string.IsNullOrEmpty(_card.SlugSuffix) ? string.Format("-{0}", _card.SlugSuffix.ToUrlSafeString()) : string.Empty;

                return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/Cards/{0}/{1}{2}.jpg", set, title, suffix);
            }
        }

        public string ThumbImagePath
        {
            get
            {
                var set = !string.IsNullOrEmpty(_card.CardSet.NormalizedName) ? _card.CardSet.NormalizedName.ToUrlSafeString() : _card.CardSet.Name.ToUrlSafeString();
                var title = _card.Title.ToUrlSafeString();
                var suffix = !string.IsNullOrEmpty(_card.SlugSuffix) ? string.Format("-{0}", _card.SlugSuffix.ToUrlSafeString()) : string.Empty;
                var thumb = _card.HasThumbnail ? "_thumb" : string.Empty;

                return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/Cards/{0}/{1}{2}{3}.jpg", set, title, suffix, thumb);
            }
        }

        public string getQuestCardImagePath(bool isFirst)
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

            return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/Cards/{0}/{1}{2}-{3}{4}.jpg", set, title, suffix, number, letter);
        }

        public string getSetupCardImagePath(bool isFirst)
        {
            var set = (_card.CardSet != null && !string.IsNullOrEmpty(_card.CardSet.NormalizedName)) ? _card.CardSet.NormalizedName.ToUrlSafeString() : _card.CardSet.Name.ToUrlSafeString();
            var title = _card.Title.ToUrlSafeString();
            var letter = isFirst ? "A" : "B";

            return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/Cards/{0}/{1}-Setup{2}.jpg", set, title, letter);
        }

        public bool HasSecondImage
        {
            get
            {
                if (_card.CardType == LotR.CardType.Location && !string.IsNullOrEmpty(_card.OppositeTitle)) {
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
                    default:
                        return false;
                }
            }
        }

        private string secondImagePath
        {
            get
            {
                if (_card.CardType == CardType.Location && !string.IsNullOrEmpty(_card.OppositeTitle))
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
                        return getQuestCardImagePath(true); 
                    case Models.LotR.CardType.Campaign:
                    case Models.LotR.CardType.Nightmare_Setup:
                    case Models.LotR.CardType.GenCon_Setup:
                    case Models.LotR.CardType.Scenario:
                        return getSetupCardImagePath(true);
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
                        return getQuestCardImagePath(false);
                    case Models.LotR.CardType.Campaign:
                    case Models.LotR.CardType.Nightmare_Setup:
                    case Models.LotR.CardType.GenCon_Setup:
                    case Models.LotR.CardType.Scenario:
                        return getSetupCardImagePath(false);
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
            get { return !string.IsNullOrEmpty(_card.Html); }
        }

        public string Html
        {
            get { return _card.Html; }
        }

        public bool HasHtml2
        {
            get { return !string.IsNullOrEmpty(_card.Html2); }
        }

        public string Html2
        {
            get { return _card.Html2; }
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

        public byte Popularity
        {
            get;
            set;
        }

        public string CharacterUrl { get; set; }

        public string PopularityHtml
        {
            get
            {
                if (Popularity > 0)
                {
                    const string icon = "<img src='/Images/gold-ring.png' height='16' width='16' title='Popularity'/>";

                    var html = new System.Text.StringBuilder();

                    for (var i = 0; i < Popularity; i++)
                    {
                        html.Append(icon);
                    }

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
    }
}