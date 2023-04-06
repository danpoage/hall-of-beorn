using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class ScenarioViewModel
    {
        public ScenarioViewModel(Scenario scenario, Func<string, LotRCard> lookupCard, 
            Func<string, IEnumerable<PlayerCategory>> getPlayerCategories, 
            Func<string, IEnumerable<EncounterCategory>> getEncounterCategories, 
            Func<string, IEnumerable<QuestCategory>> getQuestCategories,
            Func<string, IEnumerable<Region>> getRegions,
            Func<string, IEnumerable<Archetype>> getArchetypes,
            Func<string, string> translateTitle)
        {
            _scenario = scenario;

            this.Title = translateTitle != null ? translateTitle(scenario.Title) : scenario.Title;

            _campaignCard = _scenario.CampaignCard != null ? new ScenarioCardViewModel(_scenario.CampaignCard) : null;

            foreach (var questCard in scenario.QuestCards)
            {
                _questCards.Add(new ScenarioQuestViewModel(questCard, 
                    getPlayerCategories, getEncounterCategories, getQuestCategories, getRegions, getArchetypes));
            }

            var hasCardMap = false;
            if (lookupCard != null)
            {
                var cardsWithCounts = scenario.CardsWithCounts((slug) =>
                    {
                        return lookupCard(slug); 
                    }
                );

                if (cardsWithCounts.Count > 0)
                {
                    hasCardMap = true;
                    foreach (var map in cardsWithCounts)
                    {
                        _scenarioCards.Add(new ScenarioCardViewModel(new ScenarioCard(map)));
                    }
                }
            }

            if (!hasCardMap)
            {
                foreach (var scenarioCard in scenario.ScenarioCards)
                {
                    _scenarioCards.Add(new ScenarioCardViewModel(scenarioCard));
                }
            }
        }

        private readonly Scenario _scenario;
        private readonly ScenarioCardViewModel _campaignCard;
        private readonly List<ScenarioQuestViewModel> _questCards = new List<ScenarioQuestViewModel>();
        private readonly List<ScenarioCardViewModel> _scenarioCards = new List<ScenarioCardViewModel>();
        private readonly Func<string, string> translateTitle;

        public string Slug { get { return _scenario.Title.ToUrlSafeString(); } }
        public string Title { get; private set; }
        public string Link { get { return string.Format("/LotR/Scenarios/{0}", Slug); } }
        public string CardsLink {
            get {
                return !string.IsNullOrEmpty(_scenario.CardsLink) ? 
                    _scenario.CardsLink : 
                    string.Format("/LotR?Scenario={0}&Sort=Set_Number", _scenario.Title.UrlEncode());
            }
        }
        public string RulesUrl { get { return _scenario.RulesUrl; } }

        public bool HasRulesImages
        {
            get { return _scenario.RulesImageCount > 0; }
        }

        public IEnumerable<string> RulesImageLinks()
        {
            if (_scenario.RulesImageCount < 1)
                yield return string.Empty;

            var productName = _scenario.ProductName.ToUrlSafeString();

            for (var i = 1; i <= _scenario.RulesImageCount; i++)
            {
                yield return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Rules/{0}/Rules-{1:00}.jpg", productName, i);
            }
        }

        public string FirstAgeApprovedList
        {
            get
            {
                return _scenario.HasFirstAgeApprovedList
                    ? "https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Rules/First-Age/First-Age-Approved-List.pdf"
                    : null;
            }
        }

        public bool HasPlayLinks { get { return _scenario.PlayLinks.Count() > 0; } }
        public IEnumerable<LinkViewModel> PlayLinks
        { 
            get { return _scenario.PlayLinks.Select(pl => new LinkViewModel(pl.Item1)); }
        }

        public byte Difficulty { get { return _scenario.Difficulty; } }
        public int Votes { get { return _scenario.Votes; } }

        public string DifficultyHtml
        {
            get
            {
                if (Difficulty > 0)
                {
                    var html = string.Format("<span style='width:24px;display:inline-block;text-align:left;'>{0}</span><img src='/Images/eye-small.png' class='difficulty-icon' height='16' width='16' title='Difficulty {0} / 10  ({1} Votes)'/>", _scenario.DifficultyRating, Votes);

                    //var html = new System.Text.StringBuilder();

                    //for (var i = 0; i < Difficulty; i++)
                    //{
                    //    html.Append(icon);
                    //}

                    return !string.IsNullOrEmpty(QuestCompanionUrl) ?
                        string.Format("<a href='{0}' target='_blank'>{1}</a>", QuestCompanionUrl, html.ToString())
                        : html.ToString();
                }

                return string.Empty;
            }
        }

        public bool HasRulesReference { get { return !string.IsNullOrEmpty(_scenario.RulesReferenceUrl); } }
        public string RulesReferenceUrl { get { return _scenario.RulesReferenceUrl; } }
        public string RulesReferenceLabel { get { return _scenario.RulesReferenceLabel; } }

        public string RulesLabel { get { return string.Format("Rules Sheet for {0}", _scenario.ProductName); } }
        public string QuestCompanionUrl { get { return _scenario.QuestCompanionUrl; } }

        public string GroupName { get { return _scenario.GroupName; } }
        public bool IsSubGroup { get { return _scenario.IsSubGroup; } }
        public string ProductName { get { return _scenario.ProductName; } }
        public ScenarioCardViewModel CampaignCard { get { return _campaignCard; } }
        public List<ScenarioQuestViewModel> QuestCards { get { return _questCards; } }
        public List<ScenarioCardViewModel> ScenarioCards { get { return _scenarioCards; } }
    }
}