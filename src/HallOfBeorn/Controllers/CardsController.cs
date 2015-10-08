using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using HallOfBeorn.Models;
using HallOfBeorn.Models.Simple;
using HallOfBeorn.Services;

namespace HallOfBeorn.Controllers
{
    public class CardsController : Controller
    {
        public CardsController()
        {
            cardRepository = (CardRepository)System.Web.HttpContext.Current.Application[Extensions.CardRepositoryKey];
            productRepository = (ProductRepository)System.Web.HttpContext.Current.Application[Extensions.ProductRepositoryKey];
            searchService = (SearchService)System.Web.HttpContext.Current.Application[Extensions.SearchServiceKey];
            categoryService = (CategoryService)System.Web.HttpContext.Current.Application[Extensions.CategoryServiceKey];
            scenarioService = (ScenarioService)System.Web.HttpContext.Current.Application[Extensions.ScenarioServiceKey];
            statService = (StatService)System.Web.HttpContext.Current.Application[Extensions.StatServiceKey];
        }

        private readonly SearchService searchService;
        private readonly CardRepository cardRepository;
        private readonly ProductRepository productRepository;
        private readonly CategoryService categoryService;
        private readonly ScenarioService scenarioService;
        private readonly StatService statService;

        private List<string> strongPhrases = new List<string> {
            "lost the game",
            "lose the game",
            "win the game",
            "won the game",
            "end the game",
            "win this game",
            "the players cannot"
        };

        private void InitializeSearch(SearchViewModel model)
        {
            model.Cards = new List<CardViewModel>();

            SearchViewModel.Keywords = statService.Keywords().GetSelectListItems();
            SearchViewModel.Traits = statService.Traits().GetSelectListItems();
            SearchViewModel.ResourceCosts = statService.ResourceCosts().GetSelectListItems();
            SearchViewModel.ThreatCosts = statService.ThreatCosts().GetSelectListItems();
            SearchViewModel.EngagementCosts = statService.EngagementCosts().GetSelectListItems();
            SearchViewModel.VictoryPointValues = statService.VictoryPointsValues().GetSelectListItems();
            SearchViewModel.AttackStrengthValues = statService.AttackStrengthValues().GetSelectListItems();
            SearchViewModel.DefenseStrengthValues = statService.DefenseStrengthValues().GetSelectListItems();
            SearchViewModel.HitPointsValues = statService.HitPointsValues().GetSelectListItems();
            SearchViewModel.WillpowerStrengthValues = statService.WillpowerStrengthValues().GetSelectListItems();
            SearchViewModel.ThreatStrengthValues = statService.ThreatStrengthValues().GetSelectListItems();
            SearchViewModel.QuestPointsValues = statService.QuestPointsValues().GetSelectListItems();

            SearchViewModel.CardSets = scenarioService.SetNames().GetSelectListItems();
            SearchViewModel.Scenarios = scenarioService.ScenarioTitles().GetSelectListItems();
            SearchViewModel.EncounterSets = scenarioService.EncounterSetNames().GetSelectListItems();

            SearchViewModel.Categories = categoryService.CategoryNames().GetSelectListItems();
            SearchViewModel.EncounterCategories = categoryService.EncounterCategoryNames().GetSelectListItems();
            SearchViewModel.QuestCategories = categoryService.QuestCategoryNames().GetSelectListItems();
        }

        private IEnumerable<CardEffect> ParseCardEffects(Card card, string text)
        {
            if (string.IsNullOrEmpty(text))
                return Enumerable.Empty<CardEffect>();

            var effects = new List<CardEffect>();

            var isFirst = true;
            foreach (var line in text.Split(new string[] { "\r\n" }, StringSplitOptions.None))
            {
                if (string.IsNullOrEmpty(line))
                    continue;

                effects.Add(ParseCardEffect(card, line, isFirst));
                isFirst = false;
            }

            return effects;
        }

        private void checkForSuffix(Token token, string part, string normalized)
        {
            if (part.Length > normalized.Length)
            {
                var prefixLength = part.StartsWith("(") ? 1 : 0;
                var suffixLength = part.Length - normalized.Length - prefixLength;
                token.Suffix = part.Substring(part.Length - suffixLength, suffixLength);
            }
        }

        private void checkForTitleReference(Token token, string part)
        {
            const string titleTag = "[Card]";

            if (part.Contains(titleTag))
            {
                token.IsTitleReference = true;

                if (part.Length > titleTag.Length && !part.EndsWith("]"))
                {
                    token.Text = part.Substring(0, titleTag.Length);
                    token.Suffix = part.Substring(titleTag.Length, part.Length - titleTag.Length);
                }
                else
                {
                    token.Text = part;
                }
            }
        }

        private string GetImagePath(string normalized)
        {
            if (normalized == null)
                return null;

            switch (normalized)
            {
                case "Willpower":
                    return "/Images/willpower.gif";
                case "Attack":
                    return "/Images/attack.gif";
                case "Defense":
                    return "/Images/defense.gif";
                case "Threat":
                    return "/Images/threat.png";
                case "Leadership":
                    return "/Images/Leadership.png";
                case "Tactics":
                    return "/Images/Tactics.png";
                case "Spirit":
                    return "/Images/Spirit.png";
                case "Lore":
                    return "/Images/Lore.png";
                case "Baggins":
                    return "/Images/Baggins.png";
                case "Fellowship":
                    return "/Images/Fellowship.png";
                default:
                    return null;
            }
        }

        private CardEffect ParseCardEffect(Card card, string text, bool isFirst)
        {
            if (text == null)
                return null;

            var effect = new CardEffect();

            var count = 0;
            foreach (var part in text.Split(' '))
            {
                if (string.IsNullOrEmpty(part))
                    continue;

                count++;

                var token = new Token();
                var partText = part;

                var normalized = part.TrimStart('(').TrimEnd('.', ',', ':', '"', '\'', ')');
                var escaped = part.StartsWith("~");

                if (part.Length > 0 && part.EndsWith(":") && char.IsUpper(part.GetFirstLetter()))
                {
                    token.IsTrigger = true;
                    token.Text = part;

                    if (count == 2)
                    {
                        effect.Tokens.First().IsTrigger = true;
                    }

                    checkForTitleReference(token, part);
                }
                else
                {
                    token.Prefix = count > 1 ? " " : string.Empty;

                    if (!escaped && normalized != "Attack")
                    {
                        //NOTE: A Sphere token has priority over a Trait token
                        if (statService.Traits().Any(x => string.Equals(x, normalized + ".")) && !statService.Spheres().Any(x => string.Equals(x, normalized)))
                        {
                            token.IsTrait = true;
                            token.Text = token.Prefix + part.Trim(',');
                            checkForSuffix(token, part, normalized);
                            effect.Tokens.Add(token);
                            continue;
                        }
                    }

                    token.ImagePath = GetImagePath(normalized);
                    if (token.IsIcon)
                    {
                        if (part.StartsWith("("))
                            token.Prefix = token.Prefix + "(";

                        token.Text = normalized;
                        checkForSuffix(token, part, normalized);
                        effect.Tokens.Add(token);
                        continue;
                    } else if (part.StartsWith("**") && part.EndsWith("**"))
                    {
                        token.IsStrong = true;
                        partText = part.Replace("**", string.Empty);
                    }
                    else if (part.StartsWith("*") && part.EndsWith("*"))
                    {
                        token.IsEmphasized = true;
                        partText = part.Trim('*');
                    }

                    token.Text = token.Prefix + partText.TrimStart('~');
                }

                checkForTitleReference(token, partText);
                
                effect.Tokens.Add(token);
            }

            foreach (var phrase in strongPhrases)
            {
                if (text.ToLower().Contains(phrase))
                {
                    if (!effect.Tokens[0].IsTrigger)
                    {
                        effect.IsCritical = true;
                    }
                }
            }

            return effect;
        }

        private CardViewModel GetCardViewModel(Card card)
        {
            var viewModel = new CardViewModel(card);

            foreach (var keyword in card.Keywords)
                viewModel.KeywordEffects.Add(ParseCardEffect(card, keyword, true));

            viewModel.TextEffects.AddRange(ParseCardEffects(card, card.Text));
            viewModel.OppositeTextEffects.AddRange(ParseCardEffects(card, card.OppositeText));

            if (!string.IsNullOrEmpty(card.Shadow))
                viewModel.ShadowEffects.Add(ParseCardEffect(card, card.Shadow, true));

            return viewModel;
        }

        public ActionResult Index()
        {
            var model = new SearchViewModel();

            return Redirect("/Cards/Search");
        }

        public ActionResult Browse()
        {
            var model = new BrowseViewModel();

            foreach (var productGroup in productRepository.ProductGroups())
            {
                model.ProductGroups.Add(new ProductGroupViewModel(productGroup));
            }

            return View(model);
        }

        public ActionResult Scenarios(string id)
        {
            var model = new ScenarioListViewModel();
            var lookupCard = new Func<string, Card>((slug) => { return cardRepository.FindBySlug(slug); });


            if (string.IsNullOrEmpty(id))
            {
                foreach (var scenarioGroup in scenarioService.ScenarioGroups())
                {
                    model.ScenarioGroups.Add(new ScenarioGroupViewModel(scenarioGroup, lookupCard));
                }
            }
            else
            {
                var scenario = scenarioService.GetScenario(id);

                if (scenario == null)
                {
                    return HttpNotFound("I'm sorry Mario, your Princess is in another castle.\n\nNo scenario found matching this URL");
                }

                model.Detail = new ScenarioViewModel(scenario, lookupCard);

                return View(model);
            }

            return View(model);
        }

        private enum Mode
        {
            Easy = 0,
            Normal = 1,
            Nightmare = 2
        }

        private class ScenarioTotalData
        {
            public ScenarioTotalData()
            {
                EasyData = new GameTypeData();
                NormalData = new GameTypeData();
                NightmareData = new GameTypeData();
            }

            public GameTypeData EasyData { get; private set; }
            public GameTypeData NormalData { get; private set; }
            public GameTypeData NightmareData { get; private set; }
        }

        private class GameTypeData
        {
            public GameTypeData()
            {
                ScenarioTitles = new List<string>();
                EnemyTotals = new List<float>();
                LocationTotals = new List<float>();
                TreacheryTotals = new List<float>();
                ObjectiveTotals = new List<float>();
                ObjectiveAllyTotals = new List<float>();
                ObjectiveLocationTotals = new List<float>();
                SideQuestTotals = new List<float>();
                ShadowTotals = new List<float>();
                SurgeTotals = new List<float>();
            }

            public List<string> ScenarioTitles { get; private set; }
            public List<float> EnemyTotals { get; private set; }
            public List<float> LocationTotals { get; private set; }
            public List<float> TreacheryTotals { get; private set; }
            public List<float> ObjectiveTotals { get; private set; }
            public List<float> ObjectiveAllyTotals { get; private set; }
            public List<float> ObjectiveLocationTotals { get; private set; }
            public List<float> SideQuestTotals { get; private set; }
            public List<float> ShadowTotals { get; private set; }
            public List<float> SurgeTotals { get; private set; }
        }

        public JsonResult ScenarioTotals(string id)
        {
            var data = new ScenarioTotalData();
            
            var groupNames = new string[0];
            if (!string.IsNullOrEmpty(id)) {
                groupNames = id.Split(',');
            }

            var filter = (!string.IsNullOrEmpty(id)) ?
                new Func<ScenarioGroup, bool>((g) => { return !string.IsNullOrEmpty(g.Name) && groupNames.Any(y => y == g.Name); }) :
                new Func<ScenarioGroup, bool>((g) => { return !string.IsNullOrEmpty(g.Name); });
            
            foreach (var scenarioGroup in scenarioService.ScenarioGroups().Where(filter))
            {
                foreach (var scenario in scenarioGroup.Scenarios)
                {
                    data.EasyData.ScenarioTitles.Add(scenario.Title);
                    data.NormalData.ScenarioTitles.Add(scenario.Title);
                    data.NightmareData.ScenarioTitles.Add(scenario.Title);

                    var enemyTotals = new Dictionary<int, float>{{ 0, 0f }, {1, 0f }, {2, 0f }};
                    var locationTotals = new Dictionary<int, float> { { 0, 0f }, { 1, 0f }, { 2, 0f } };
                    var treacheryTotals = new Dictionary<int, float> { { 0, 0f }, { 1, 0f }, { 2, 0f } };
                    var objectiveTotals = new Dictionary<int, float> { { 0, 0f }, { 1, 0f }, { 2, 0f } };
                    var objectiveAllyTotals = new Dictionary<int, float> { { 0, 0f }, { 1, 0f }, { 2, 0f } };
                    var objectiveLocationTotals = new Dictionary<int, float> { { 0, 0f }, { 1, 0f }, { 2, 0f } };
                    var sideQuestTotals = new Dictionary<int, float> { { 0, 0f }, { 1, 0f }, { 2, 0f } };
                    var shadowTotals = new Dictionary<int, float> { { 0, 0f }, { 1, 0f }, { 2, 0f } };
                    var surgeTotals = new Dictionary<int, float> { { 0, 0f }, { 1, 0f }, { 2, 0f } };

                    foreach (var card in scenario.ScenarioCards)
                    {
                        switch (card.Card.CardType)
                        {
                            case CardType.Enemy:
                                enemyTotals[0] += card.EasyQuantity;
                                enemyTotals[1] += card.NormalQuantity;
                                enemyTotals[2] += card.NightmareQuantity;
                                break;
                            case CardType.Location:
                                locationTotals[0] += card.EasyQuantity;
                                locationTotals[1] += card.NormalQuantity;
                                locationTotals[2] += card.NightmareQuantity;
                                break;
                            case CardType.Treachery:
                                treacheryTotals[0] += card.EasyQuantity;
                                treacheryTotals[1] += card.NormalQuantity;
                                treacheryTotals[2] += card.NightmareQuantity;
                                break;
                            case CardType.Objective:
                                objectiveTotals[0] += card.EasyQuantity;
                                objectiveTotals[1] += card.NormalQuantity;
                                objectiveTotals[2] += card.NightmareQuantity;
                                break;
                            case CardType.Objective_Ally:
                                objectiveAllyTotals[0] += card.EasyQuantity;
                                objectiveAllyTotals[1] += card.NormalQuantity;
                                objectiveAllyTotals[2] += card.NightmareQuantity;
                                break;
                            case CardType.Objective_Location:
                                objectiveLocationTotals[0] += card.EasyQuantity;
                                objectiveLocationTotals[1] += card.NormalQuantity;
                                objectiveLocationTotals[2] += card.NightmareQuantity;
                                break;
                            case CardType.Encounter_Side_Quest:
                                sideQuestTotals[0] += card.EasyQuantity;
                                sideQuestTotals[1] += card.NormalQuantity;
                                sideQuestTotals[2] += card.NightmareQuantity;
                                break;
                            default:
                                break;
                        }

                        if (card.Card.Keywords.Any(x => x != null && x == "Surge.") || (!string.IsNullOrEmpty(card.Card.Text) && card.Card.Text.Contains(" surge")))
                        {
                            surgeTotals[0] += card.EasyQuantity;
                            surgeTotals[1] += card.NormalQuantity;
                            surgeTotals[2] += card.NightmareQuantity;
                        }

                        if (!string.IsNullOrEmpty(card.Card.Shadow))
                        {
                            shadowTotals[0] += card.EasyQuantity;
                            shadowTotals[1] += card.NormalQuantity;
                            shadowTotals[2] += card.NightmareQuantity;
                        }
                    }

                    data.EasyData.EnemyTotals.Add(enemyTotals[0]);
                    data.EasyData.LocationTotals.Add(locationTotals[0]);
                    data.EasyData.TreacheryTotals.Add(treacheryTotals[0]);
                    data.EasyData.ObjectiveTotals.Add(objectiveTotals[0]);
                    data.EasyData.ObjectiveAllyTotals.Add(objectiveAllyTotals[0]);
                    data.EasyData.ObjectiveLocationTotals.Add(objectiveLocationTotals[0]);
                    data.EasyData.SideQuestTotals.Add(sideQuestTotals[0]);
                    data.EasyData.ShadowTotals.Add(shadowTotals[0]);
                    data.EasyData.SurgeTotals.Add(surgeTotals[0]);

                    data.NormalData.EnemyTotals.Add(enemyTotals[1]);
                    data.NormalData.LocationTotals.Add(locationTotals[1]);
                    data.NormalData.TreacheryTotals.Add(treacheryTotals[1]);
                    data.NormalData.ObjectiveTotals.Add(objectiveTotals[1]);
                    data.NormalData.ObjectiveAllyTotals.Add(objectiveAllyTotals[1]);
                    data.NormalData.ObjectiveLocationTotals.Add(objectiveLocationTotals[1]);
                    data.NormalData.SideQuestTotals.Add(sideQuestTotals[1]);
                    data.NormalData.ShadowTotals.Add(shadowTotals[1]);
                    data.NormalData.SurgeTotals.Add(surgeTotals[1]);

                    data.NightmareData.EnemyTotals.Add(enemyTotals[2]);
                    data.NightmareData.LocationTotals.Add(locationTotals[2]);
                    data.NightmareData.TreacheryTotals.Add(treacheryTotals[2]);
                    data.NightmareData.ObjectiveTotals.Add(objectiveTotals[2]);
                    data.NightmareData.ObjectiveAllyTotals.Add(objectiveAllyTotals[2]);
                    data.NightmareData.ObjectiveLocationTotals.Add(objectiveLocationTotals[2]);
                    data.NightmareData.SideQuestTotals.Add(sideQuestTotals[2]);
                    data.NightmareData.ShadowTotals.Add(shadowTotals[2]);
                    data.NightmareData.SurgeTotals.Add(surgeTotals[2]);
                    
                }
            }

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ScenarioDetails(string id)
        {
            try
            {
                var details = new Dictionary<string, object>();
                
                var scenario = scenarioService.GetScenario(id);
                if (scenario != null)
                {
                    details["title"] = scenario.Title;

                    var cardCounts = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var enemyCounts = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var locationCounts = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var treacheryCounts = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var objectiveCounts = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var objectiveAllyCounts = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var objectiveLocationCounts = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var surgeCounts = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var shadowCounts = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var encounterSideQuestCounts = new Dictionary<int, int> { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var hasEasy = false;
                    var hasNightmare = false;

                    foreach (var card in scenario.ScenarioCards)
                    {
                        cardCounts[0] += card.EasyQuantity;
                        cardCounts[1] += card.NormalQuantity;
                        cardCounts[2] += card.NightmareQuantity;

                        if (cardCounts[0] != cardCounts[1])
                        {
                            hasEasy = true;
                        }

                        if (card.Card.Traits.Any(x => x == "Surge.") || card.Card.Text.Contains(" surge"))
                        {
                            surgeCounts[0] += card.EasyQuantity;
                            surgeCounts[1] += card.NormalQuantity;
                            surgeCounts[2] += card.NightmareQuantity;
                        }
                        if (!string.IsNullOrEmpty(card.Card.Shadow))
                        {
                            shadowCounts[0] += card.EasyQuantity;
                            shadowCounts[1] += card.NormalQuantity;
                            shadowCounts[2] += card.NightmareQuantity;
                        }

                        if (card.Card.CardSet.SetType == SetType.Nightmare_Expansion)
                        {
                            hasNightmare = true;
                        }

                        switch (card.Card.CardType)
                        {
                            case CardType.Enemy:
                                enemyCounts[0] += card.EasyQuantity;
                                enemyCounts[1] += card.NormalQuantity;
                                enemyCounts[2] += card.NightmareQuantity;
                                break;
                            case CardType.Location:
                                locationCounts[0] += card.EasyQuantity;
                                locationCounts[1] += card.NormalQuantity;
                                locationCounts[2] += card.NightmareQuantity;
                                break;
                            case CardType.Treachery:
                                treacheryCounts[0] += card.EasyQuantity;
                                treacheryCounts[1] += card.NormalQuantity;
                                treacheryCounts[2] += card.NightmareQuantity;
                                break;
                            case CardType.Objective:
                                objectiveCounts[0] += card.EasyQuantity;
                                objectiveCounts[1] += card.NormalQuantity;
                                objectiveCounts[2] += card.NightmareQuantity;
                                break;
                            case CardType.Objective_Ally:
                                objectiveAllyCounts[0] += card.EasyQuantity;
                                objectiveAllyCounts[1] += card.NormalQuantity;
                                objectiveAllyCounts[2] += card.NightmareQuantity;
                                break;
                            case CardType.Objective_Location:
                                objectiveLocationCounts[0] += card.EasyQuantity;
                                objectiveLocationCounts[1] += card.NormalQuantity;
                                objectiveLocationCounts[2] += card.NightmareQuantity;
                                break;
                            case CardType.Encounter_Side_Quest:
                                encounterSideQuestCounts[0] += card.EasyQuantity;
                                encounterSideQuestCounts[1] += card.NormalQuantity;
                                encounterSideQuestCounts[2] += card.NightmareQuantity;
                                break;
                        }
                    }

                    details["HasEasy"] = hasEasy;
                    details["HasNightmare"] = hasNightmare;

                    for (int i = 0; i < 3; i++)
                    {
                        var mode = (Mode)i;
                        var prefix = mode.ToString();

                        details[prefix + "Cards"] = cardCounts[i];
                        details[prefix + "Enemies"] = enemyCounts[i];
                        details[prefix + "EnemyPercentage"] = ((float)enemyCounts[i] / (float)cardCounts[i]); //*100;
                        details[prefix + "Locations"] = locationCounts[i];
                        details[prefix + "LocationPercentage"] = ((float)enemyCounts[i] / (float)cardCounts[i]); //*100;
                        details[prefix + "Treacheries"] = treacheryCounts[i];
                        details[prefix + "TreacheryPercentage"] = ((float)treacheryCounts[i] / (float)cardCounts[i]); //*100;
                        details[prefix + "Shadows"] = shadowCounts[i];
                        details[prefix + "ShadowPercentage"] = ((float)shadowCounts[i] / (float)cardCounts[i]); //*100;
                        details[prefix + "Objectives"] = objectiveCounts[i];
                        details[prefix + "ObjectivePercentage"] = ((float)objectiveCounts[i] / (float)cardCounts[i]); //*100;
                        details[prefix + "HasObjectives"] = (objectiveCounts[i] > 0);
                        details[prefix + "ObjectiveAllies"] = objectiveAllyCounts[i];
                        details[prefix + "ObjectiveAllyPercentage"] = ((float)objectiveAllyCounts[i] / (float)cardCounts[i]); //*100;
                        details[prefix + "HasObjectiveAllies"] = (objectiveAllyCounts[i] > 0);
                        details[prefix + "ObjectiveLocations"] = objectiveLocationCounts[i];
                        details[prefix + "ObjectiveLocationPercentage"] = ((float)objectiveLocationCounts[i] / (float)cardCounts[i]); //*100;
                        details[prefix + "HasObjectiveLocations"] = (objectiveLocationCounts[i] > 0);
                        details[prefix + "Surges"] = surgeCounts[i];
                        details[prefix + "SurgePercentage"] = ((float)surgeCounts[i] / (float)cardCounts[i]); //*100;
                        details[prefix + "HasSurge"] = (surgeCounts[i] > 0);
                        details[prefix + "EncounterSideQuests"] = encounterSideQuestCounts[i];
                        details[prefix + "EncounterSideQuestPercentage"] = ((float)encounterSideQuestCounts[i] / (float)cardCounts[i]);
                        details[prefix + "HasEncounterSideQuests"] = (encounterSideQuestCounts[i] > 0);
                    }
                }

                return Json(details, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Search(SearchViewModel model)
        {
            InitializeSearch(model);

            foreach (var score in searchService.Search(model))
            {
                model.Cards.Add(new CardViewModel(score));
            }

            return View(model);
        }

        public JsonResult SearchJson(SearchViewModel model)
        {
            Search(model);

            var data = new List<SimpleCard>();

            foreach (var cardViewModel in model.Cards)
            {
                data.Add(new SimpleCard(cardViewModel.Card));
            }

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ActionName("Search")]
        public ActionResult Search_Post(SearchViewModel model)
        {
            if (string.IsNullOrEmpty(model.CardSet) || model.CardSet == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.CardSet = null;
            }
            if (string.IsNullOrEmpty(model.EncounterSet) || model.EncounterSet == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.EncounterSet = null;
            }
            if (string.IsNullOrEmpty(model.Scenario) || model.Scenario == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Scenario = null;
            }
            if (string.IsNullOrEmpty(model.Quest) || model.Quest == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Quest = null;
            }
            if (model.CardType.HasValue && model.CardType.Value == Models.CardType.None)
            {
                model.CardType = null;
            }
            if (model.CardSubtype.HasValue && model.CardSubtype.Value == Models.CardSubtype.None)
            {
                model.CardSubtype = null;
            }
            if (model.SetType.HasValue && model.SetType.Value == Models.SetType.None)
            {
                model.SetType = null;
            }
            if (model.Sort.HasValue && model.Sort.Value == Models.Sort.None)
            {
                model.Sort = null;
            }
            if (model.DeckType.HasValue && model.DeckType.Value == Models.DeckType.None)
            {
                model.DeckType = null;
            }
            if (string.IsNullOrEmpty(model.Trait) || model.Trait == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Trait = null;
            }
            if (string.IsNullOrEmpty(model.Keyword) || model.Keyword == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Keyword = null;
            }
            if (string.IsNullOrEmpty(model.Artist) || model.Artist == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Artist = null;
            }
            if (model.Sphere.HasValue && model.Sphere.Value == Models.Sphere.None)
            {
                model.Sphere = null;
            }
            if (string.IsNullOrEmpty(model.Category) || model.Category == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Category = null;
            }
            if (string.IsNullOrEmpty(model.EncounterCategory) || model.EncounterCategory == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.EncounterCategory = null;
            }
            if (string.IsNullOrEmpty(model.QuestCategory) || model.QuestCategory == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.QuestCategory = null;
            }
            if (string.IsNullOrEmpty(model.VictoryPoints) || model.VictoryPoints == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.VictoryPoints = null;
            }

            if (model.IsUnique.HasValue && model.IsUnique.Value == Uniqueness.Any)
            {
                model.IsUnique = null;
            }
            if (model.HasShadow.HasValue && model.HasShadow.Value == HasShadow.Any)
            {
                model.HasShadow = null;
            }

            if (model.ThreatCostOperator.HasValue && model.ThreatCostOperator == NumericOperator.eq && (string.IsNullOrEmpty(model.ThreatCost) || model.ThreatCost == "Any"))
            {
                model.ThreatCost = null;
                model.ThreatCostOperator = null;
            }
            if (model.CostOperator.HasValue && model.CostOperator == NumericOperator.eq && (string.IsNullOrEmpty(model.Cost) || model.Cost == "Any"))
            {
                model.Cost = null;
                model.CostOperator = null;
            }
            if (model.EngagementCostOperator.HasValue && model.EngagementCostOperator == NumericOperator.eq && (string.IsNullOrEmpty(model.EngagementCost) || model.EngagementCost == "Any"))
            {
                model.EngagementCost = null;
                model.EngagementCostOperator = null;
            }
            if (model.AttackOp.HasValue && model.AttackOp == NumericOperator.eq && (string.IsNullOrEmpty(model.Attack) || model.Attack == "Any"))
            {
                model.Attack = null;
                model.AttackOp = null;
            }
            if (model.DefenseOp.HasValue && model.DefenseOp == NumericOperator.eq && (string.IsNullOrEmpty(model.Defense) || model.Defense == "Any"))
            {
                model.Defense = null;
                model.DefenseOp = null;
            }
            if (model.WillpowerOp.HasValue && model.WillpowerOp == NumericOperator.eq && (string.IsNullOrEmpty(model.Willpower) || model.Willpower == "Any"))
            {
                model.Willpower = null;
                model.WillpowerOp = null;
            }
            if (model.ThreatOp.HasValue && model.ThreatOp == NumericOperator.eq && (string.IsNullOrEmpty(model.Threat) || model.Threat == "Any"))
            {
                model.Threat = null;
                model.ThreatOp = null;
            }
            if (model.HitPointsOp.HasValue && model.HitPointsOp == NumericOperator.eq && (string.IsNullOrEmpty(model.HitPoints) || model.HitPoints == "Any"))
            {
                model.HitPoints = null;
                model.HitPointsOp = null;
            }
            if (model.QuestPointsOp.HasValue && model.QuestPointsOp == NumericOperator.eq && (string.IsNullOrEmpty(model.QuestPoints) || model.QuestPoints == "Any"))
            {
                model.QuestPoints = null;
                model.QuestPointsOp = null;
            }

            return RedirectToAction("Search", model);
        }

        private bool IsId(string id)
        {
            if (string.IsNullOrEmpty(id))
                return false;

            if (id.Length != 36)
                return false;

            if (id[8] != '-' || id[13] != '-' || id[18] != '-')
                return false;

            return true;
        }

        public ActionResult Details(string id)
        {
            CardViewModel model= null;

            Card card = null;
            var redirectURL = string.Empty;

            if (IsId(id))
            {
                card = cardRepository.Find(id);
                if (card != null)
                {
                    redirectURL = string.Format("/Cards/Details/{0}", card.Slug);
                }
            }
            else
            {
                card = cardRepository.FindBySlug(id);
                if (card != null && card.Slug != id)
                {
                    redirectURL = string.Format("/Cards/Details/{0}", card.Slug);
                }
            }

            if (card == null)
            {
                redirectURL = string.Format("/Cards/Search?Query={0}", id.Replace('-', '+'));
            }

            if (!string.IsNullOrEmpty(redirectURL))
            {
                return Redirect(redirectURL);
            }
            else
            {
                model = GetCardViewModel(card);
            }   

            return View(model);
        }
    }
}
