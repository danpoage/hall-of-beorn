using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class ScenarioQuestViewModel
    {
        public ScenarioQuestViewModel(ScenarioQuestCard questCard, Func<string, IEnumerable<PlayerCategory>> getPlayerCategories, Func<string, IEnumerable<EncounterCategory>> getEncounterCategories, Func<string, IEnumerable<QuestCategory>> getQuestCategories)
        {
            _questCard = questCard;
            _cardViewModel = new CardViewModel(questCard.Quest, getPlayerCategories, getEncounterCategories, getQuestCategories);
        }

        private ScenarioQuestCard _questCard;
        private CardViewModel _cardViewModel;

        public bool IsNightmare { get { return _cardViewModel.IsNightmare; } }
        public string StageNumber { get { return _cardViewModel.StageNumber.ToString(); } }
        public string FullTitle { get { return _cardViewModel.FullTitle; } }
        public string Url { get { return _cardViewModel.Url; } }
        public bool HasSecondImage { get { return _cardViewModel.HasSecondImage; } }
        public string ImagePath { get { return _cardViewModel.ImagePath; } }
        public string ImagePath1 { get { return _cardViewModel.ImagePath1; } }
        public string ImagePath2 { get { return _cardViewModel.ImagePath2; } }

        public string NormalQuantity { get { return _questCard.NormalModeQuantity > 0 ? _questCard.NormalModeQuantity.ToString() : "-"; } }
        public string NightmareQuantity { get { return _questCard.NightmareModeQuantity > 0 ? _questCard.NightmareModeQuantity.ToString() : "-"; } }
        public string EasyQuantity { get { return _questCard.EasyModeQuantity > 0 ? _questCard.EasyModeQuantity.ToString() : "-"; } }
    }
}