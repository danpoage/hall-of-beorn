using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR
{
    public class Scenario
    {
        protected Scenario(bool hasNightmareMode)
        {
            this.hasNightmareMode = hasNightmareMode;

            RulesReferenceUrl =  
                "https://images-cdn.fantasyflightgames.com/filer_public/90/19/90191e4e-a341-4379-b398-5963b7a87ebf/mec01_online_only_rules_reference_for_website.pdf";
            RulesReferenceLabel = "Rules Reference 1.0";
        }

        public Scenario()
            : this(false)
        {
        }

        private readonly bool hasNightmareMode;
        private ScenarioCard campaignCard;
        private readonly List<ScenarioQuestCard> questCards = new List<ScenarioQuestCard>();
        private readonly List<ScenarioCard> scenarioCards = new List<ScenarioCard>();

        private readonly Dictionary<string, EncounterSet> encounterSets = new Dictionary<string, EncounterSet>();
        private readonly Dictionary<string, byte> questCardIds = new Dictionary<string, byte>();
        private readonly Dictionary<string, byte> excludedEasyModeCards = new Dictionary<string, byte>();
        private readonly Dictionary<string, byte> excludedNightmareModeCards = new Dictionary<string, byte>();
        private readonly Dictionary<string, byte> excludedAllModeCards = new Dictionary<string, byte>();

        private readonly Dictionary<string, Tuple<byte, byte, byte>> cardCountMap = new Dictionary<string, Tuple<byte, byte, byte>>();

        private readonly List<Link> _playLinks = new List<Link>();

        private const string DarklingDoorLogo = "https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Partners/Darkling-Door.png";
        private const string TheWhiteTowerLogo = "https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Partners/The-White-Tower.png";
        private const string TheHallOfBeornBlogLogo = "https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Partners/Hall-of-Beorn-Blog.jpg";
        private const string WarriorsOfTheWestLogo = "https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Partners/Warriors-of-the-West.jpg";

        protected void AddBeornsPathLink(string url)
        {
            AddPlayLink(LinkType.Beorn__s_Path, url, Title, TheHallOfBeornBlogLogo);
        }

        protected void AddCardboardOfTheRingsLink(string url, string title, string thumbnailUrl)
        {
            AddPlayLink(LinkType.Cardboard_of_Rings, url, title, thumbnailUrl);
        }

        protected void AddPathLessTraveledLink(string url)
        {
            AddPlayLink(LinkType.Path_Less_Traveled, url, Title, DarklingDoorLogo);
        }

        protected void AddProgressionSeriesLink(string title, string videoId)
        {
            AddYouTubeLink(LinkType.The_Progression_Series, title, videoId);
        }

        protected void AddTheGreyCompanyLink(string url, string title, string thumbnailUrl)
        {
            AddPlayLink(LinkType.The_Grey_Company, url, title, thumbnailUrl);
        }

        protected void AddTheHallOfBeornBlogLink(string url, string title)
        {
            AddPlayLink(LinkType.Hall_of_Beorn, url, title, TheHallOfBeornBlogLogo);
        }

        protected void AddTheLineUnbrokenLink(string url, string title, string thumbnailUrl)
        {
            AddPlayLink(LinkType.The_Line_Unbroken, url, title, thumbnailUrl);
        }

        protected void AddThematicNightmareLink(string url)
        {
            AddPlayLink(LinkType.Thematic_Nightmare, url, Title + " Nightmare", DarklingDoorLogo);
        }

        protected void AddTheWhiteTowerLink(string url, string title)
        {
            AddPlayLink(LinkType.The_White_Tower, url, title, TheWhiteTowerLogo);
        }

        protected void AddWarriorsOfTheWestLink(string url, string title)
        {
            AddPlayLink(LinkType.Warriors_of_the_West, url, title, WarriorsOfTheWestLogo);
        }

        protected void AddYouTubeLink(LinkType type, string title, string videoId)
        {
            var url = string.Format("https://www.youtube.com/watch?v={0}", videoId);
            var thumbnailUrl = string.Format("https://i.ytimg.com/vi/{0}/hqdefault.jpg", videoId);
            AddPlayLink(type, url, title, thumbnailUrl);
        }

        protected void AddPlayLink(LinkType type, string url, string title)
        {
            AddPlayLink(type, url, title, string.Empty, null, null);
        }

        protected void AddPlayLink(LinkType type, string url, string title, string thumbnailUrl)
        {
            AddPlayLink(type, url, title, thumbnailUrl, null, null);
        }

        protected void AddPlayLink(LinkType type, string url, string title, string thumbnailUrl, int? height, int? width)
        {
            _playLinks.Add(new Link(type, url, title, thumbnailUrl, height, width));
        }

        protected void AddEncounterSet(EncounterSet set)
        {
            encounterSets[set.Name] = set;
        }

        protected void AddQuestCardId(string slug)
        {
            questCardIds.Add(slug, 0);
        }

        protected void ExcludeFromEasyMode(string slug, byte numberExcluded)
        {
            excludedEasyModeCards[slug] = numberExcluded;
        }

        protected void ExcludeFromAllModes(string slug)
        {
            excludedAllModeCards[slug] = 0;
        }

        protected void ExcludeFromNightmareMode(string slug, byte numberExcluded)
        {
            excludedNightmareModeCards[slug] = numberExcluded;
        }

        public int Number { get; set; }
        public string GroupName { get; set; }
        public bool IsSubGroup { get; set; }
        public string Title { get; set; }
        public string ProductName { get; set; }
        public string RulesUrl { get; set; }
        public int RulesImageCount { get; set; }
        public string AlternateTitle { get; set; }

        public float DifficultyRating { get; set; }
        public byte Difficulty { get { return (byte)Math.Round(DifficultyRating, 0); } }
        public int Votes { get; set; }

        public string CardsLink { get; set; }

        public string QuestCompanionSlug { get; set; }
        public string QuestCompanionUrl
        {
            get
            {
                return !string.IsNullOrWhiteSpace(QuestCompanionSlug) ?
                    string.Format("http://www.lotr-lcg-quest-companion.gamersdungeon.net/{0}.html", QuestCompanionSlug)
                    : string.Empty;
            }
        }

        public string RulesReferenceUrl { get; protected set; }
        public string RulesReferenceLabel { get; protected set; }

        public IEnumerable<Link> PlayLinks { get { return _playLinks; } }

        public ScenarioCard CampaignCard
        {
            get { return campaignCard; }
        }

        public IEnumerable<ScenarioQuestCard> QuestCards
        {
            get { return questCards.OrderBy(x => x.StageNumber).ToList(); }
        }

        public IEnumerable<ScenarioCard> ScenarioCards
        {
            get { return scenarioCards.OrderBy(x => x.EncounterSet).ThenBy(x => x.Title).ToList(); }
        }

        public void SetCampaignCard(LotRCard card)
        {
            campaignCard = new ScenarioCard(card);
        }

        public void AddQuestCard(LotRCard card)
        {
            questCards.Add(new ScenarioQuestCard(card));
        }

        public void AddQuestCard(LotRCard card, byte easyQuantity, byte normalQuantity, byte nigtmareQuantity)
        {
            var sqc = new ScenarioQuestCard(card);
            sqc.EasyModeQuantity = easyQuantity;
            sqc.NormalModeQuantity = normalQuantity;
            sqc.NightmareModeQuantity = nigtmareQuantity;
            questCards.Add(sqc);
        }

        public void AddScenarioCard(LotRCard card)
        {
            scenarioCards.Add(new ScenarioCard(card));
        }

        public bool IncludesEncounterSet(string encounterSet)
        {
            foreach (var questCard in questCards)
            {
                if (questCard.IncludedEncounterSets.Any(x => x.Name == encounterSet))
                    return true;
            }

            return false;
        }

        public string NightmareEncounterSet()
        {
            return hasNightmareMode ? string.Format("{0} Nightmare", Title) : string.Empty;
        }

        public IEnumerable<EncounterSet> EncounterSets()
        {
            return encounterSets.Values;
        }

        public IEnumerable<string> QuestCardIds()
        {
            return questCardIds.Keys;
        }

        public byte NormalModeCount(string slug, byte releaseQuantity)
        {
            if (excludedAllModeCards.ContainsKey(slug))
            {
                return 0;
            }

            return releaseQuantity;
        }

        public byte EasyModeCount(string slug, byte releaseQuantity)
        {
            if (excludedAllModeCards.ContainsKey(slug))
            {
                return 0;
            }

            if (excludedEasyModeCards.ContainsKey(slug))
            {
                return (byte)(releaseQuantity - excludedEasyModeCards[slug]);
            }

            return releaseQuantity;
        }

        public byte NightmareModeCount(string slug, byte releaseQuantity)
        {
            if (excludedAllModeCards.ContainsKey(slug))
            {
                return 0;
            }

            if (excludedNightmareModeCards.ContainsKey(slug))
            {
                return (byte)(releaseQuantity - excludedNightmareModeCards[slug]);
            }

            return releaseQuantity;
        }

        public void MapCardCount(string slug, byte easyCount, byte normalCount, byte nightmareCount)
        {
            if (cardCountMap.ContainsKey(slug))
            {
                return;
            }

            cardCountMap[slug] = new Tuple<byte, byte, byte>(easyCount, normalCount, nightmareCount);
        }

        public List<Tuple<LotRCard, byte, byte, byte>> CardsWithCounts(Func<string, LotRCard> cardLookup)
        {
            var cards = cardCountMap.Select(x => {
                return new Tuple<LotRCard, byte, byte, byte>(cardLookup(x.Key), x.Value.Item1, x.Value.Item2, x.Value.Item3);
            }).ToList();

            return cards;
        }
    }
}