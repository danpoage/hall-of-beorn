using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class ScenarioViewModel
    {
        public ScenarioViewModel(Scenario scenario)
        {
            _scenario = scenario;

            _campaignCard = _scenario.CampaignCard != null ? new ScenarioCardViewModel(_scenario.CampaignCard) : null;

            foreach (var questCard in scenario.QuestCards)
            {
                _questCards.Add(new ScenarioQuestViewModel(questCard));
            }

            foreach (var scenarioCard in scenario.ScenarioCards)
            {
                _scenarioCards.Add(new ScenarioCardViewModel(scenarioCard));
            }
        }

        private readonly Scenario _scenario;
        private readonly ScenarioCardViewModel _campaignCard;
        private readonly List<ScenarioQuestViewModel> _questCards = new List<ScenarioQuestViewModel>();
        private readonly List<ScenarioCardViewModel> _scenarioCards = new List<ScenarioCardViewModel>();

        public string Title { get { return _scenario.Title; } }
        public string Link { get { return string.Format("/Cards/Scenarios/{0}", _scenario.Title.ToUrlSafeString()); } }
        public string RulesUrl { get { return _scenario.RulesUrl; } }
        public string RulesLabel { get { return string.Format("Rules Sheet for {0}", _scenario.ProductName); } }

        public ScenarioCardViewModel CampaignCard { get { return _campaignCard; } }
        public List<ScenarioQuestViewModel> QuestCards { get { return _questCards; } }
        public List<ScenarioCardViewModel> ScenarioCards { get { return _scenarioCards; } }
    }
}