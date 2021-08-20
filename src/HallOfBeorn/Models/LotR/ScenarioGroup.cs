using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR
{
    public class ScenarioGroup
    {
        public ScenarioGroup()
        {
        }

        public ScenarioGroup(string name, IEnumerable<Scenario> scenarios)
        {
            this.Name = name;

            foreach (var scenario in scenarios)
            {
                AddScenario(scenario);
            }
        }

        private readonly List<Scenario> scenarios = new List<Scenario>();

        public string Name { get; set; }
        
        public IEnumerable<Scenario> Scenarios
        {
            get
            {
                return scenarios.OrderBy(sc => sc.Number).ToList();
            }
        }

        public void AddScenario(Scenario scenario)
        {
            scenarios.Add(scenario);
        }

        public const string TheHobbit = "The Hobbit";
        public const string TheLordOfTheRings = "The Lord of the Rings";
        public const string GenConDecks = "Gen Con Decks";
        public const string FellowshipDecks = "Fellowship Decks";
        public const string ScenarioPacks = "Scenario Packs";
        public const string FirstAge = "First Age";
        public const string DoomMastered = "Doom Mastered";
        public const string ChildrenOfEorl = "Children of Eorl";
        public const string OathsOfTheRohirrim = "Oaths of the Rohirrim";
        public const string TheScouringOfTheShire = "The Scouring of the Shire";
    }
}