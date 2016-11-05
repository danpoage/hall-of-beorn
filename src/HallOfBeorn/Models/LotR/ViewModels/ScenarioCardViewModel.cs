using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR
{
    public class ScenarioCardViewModel
    {
        public ScenarioCardViewModel(ScenarioCard scenarioCard)
        {
            Title = scenarioCard.Card.SlugIncludesType ? string.Format("{0} ({1})", scenarioCard.Title, scenarioCard.Card.CardType.ToString().Replace('_', ' ')) : scenarioCard.Title;
            EncounterSet = scenarioCard.EncounterSet;
            EncounterSetLink = string.Format("/Cards/Search?EncounterSet={0}", scenarioCard.EncounterSet.Replace(" ", "%20"));
            EncounterSetImage = scenarioCard.EncounterSetImage;
            Link = scenarioCard.Link;

            NormalQuantity = scenarioCard.NormalQuantity > 0 ? scenarioCard.NormalQuantity.ToString() : "-";
            NightmareQuantity = scenarioCard.NightmareQuantity > 0 ? scenarioCard.NightmareQuantity.ToString() : "-";
            EasyQuantity = scenarioCard.EasyQuantity > 0 ? scenarioCard.EasyQuantity.ToString() : "-";
            NormalCount = scenarioCard.NormalQuantity;
            EasyCount = scenarioCard.EasyQuantity;
            NightmareCount = scenarioCard.NightmareQuantity;
        }

        public string Title { get; private set; }
        public string EncounterSet { get; private set; }
        public string EncounterSetLink { get; private set; }
        public string EncounterSetImage { get; private set; }
        public string Link { get; private set; }
        public string NormalQuantity { get; private set; }
        public string NightmareQuantity { get; private set; }
        public string EasyQuantity { get; private set; }
        public int NormalCount { get; private set; }
        public int EasyCount { get; private set; }
        public int NightmareCount { get; private set; }
    }
}