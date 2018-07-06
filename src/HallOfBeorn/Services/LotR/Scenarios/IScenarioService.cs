using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;

namespace HallOfBeorn.Services.LotR.Scenarios
{
    public interface IScenarioService
    {
        IEnumerable<string> SetNames();
        IEnumerable<CardSet> CardSets();
        IEnumerable<string> EncounterSetNames();
        IEnumerable<ScenarioGroup> ScenarioGroups();
        IEnumerable<string> ScenarioTitles();
        Scenario GetScenario(string scenarioTitle);
        ScenarioListViewModel GetListViewModel();
        bool BelongsToScenario(string cardSlug, CardType cardType, string scenarioTitle);
        bool HasSetType(LotRCard card, SetType? setType);
    }
}
