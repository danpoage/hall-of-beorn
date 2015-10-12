using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class Scenario
    {
        protected Scenario(bool hasNightmareMode)
        {
            this.hasNightmareMode = hasNightmareMode;
        }

        public Scenario()
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

        private readonly Dictionary<string, Tuple<byte, byte, byte>> cardCountMap = new Dictionary<string, Tuple<byte, byte, byte>>();

        protected void DeluxeExpansion(string title, string product, int number)
        {
            Title = title;
            ProductName = product;
            GroupName = product;
            Number = number;
        }

        protected void SagaExpansion(string title, string product, int number)
        {
            DeluxeExpansion(title, product, number);
        }

        protected void AdventurePack(string title, string cycle, int number)
        {
            Title = title;
            ProductName = title;
            GroupName = cycle;
            Number = number;
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
            excludedEasyModeCards.Add(slug, numberExcluded);
        }

        protected void ExcludeFromNightmareMode(string slug, byte numberExcluded)
        {
            excludedNightmareModeCards.Add(slug, numberExcluded);
        }

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

        public void AddQuestCard(Card card, byte easyQuantity, byte normalQuantity, byte nigtmareQuantity)
        {
            var sqc = new ScenarioQuestCard(card);
            sqc.EasyModeQuantity = easyQuantity;
            sqc.NormalModeQuantity = normalQuantity;
            sqc.NightmareModeQuantity = nigtmareQuantity;
            questCards.Add(sqc);
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
            return releaseQuantity;
        }

        public byte EasyModeCount(string slug, byte releaseQuantity)
        {
            if (excludedEasyModeCards.ContainsKey(slug))
            {
                return (byte)(releaseQuantity - excludedEasyModeCards[slug]);
            }

            return releaseQuantity;
        }

        public byte NightmareModeCount(string slug, byte releaseQuantity)
        {
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

        public List<Tuple<Card, byte, byte, byte>> CardsWithCounts(Func<string, Card> cardLookup)
        {
            var cards = cardCountMap.Select(x => {
                return new Tuple<Card, byte, byte, byte>(cardLookup(x.Key), x.Value.Item1, x.Value.Item2, x.Value.Item3);
            }).ToList();

            return cards;
        }
    }
}