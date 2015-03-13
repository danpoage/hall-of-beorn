using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class Scenario
    {
        public Scenario()
        {
        }

        private ScenarioCard campaignCard;
        private readonly List<ScenarioQuestCard> questCards = new List<ScenarioQuestCard>();
        private readonly List<ScenarioCard> scenarioCards = new List<ScenarioCard>();

        public int Number { get; set; }
        public string GroupName { get; set; }
        public string Title { get; set; }
        public string ProductName { get; set; }
        public string RulesUrl { get; set; }

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

        public void SetCampaignCard(Card card)
        {
            campaignCard = new ScenarioCard(card);
        }

        public void AddQuestCard(Card card)
        {
            questCards.Add(new ScenarioQuestCard(card));
        }

        public void AddScenarioCard(Card card)
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
    }
}