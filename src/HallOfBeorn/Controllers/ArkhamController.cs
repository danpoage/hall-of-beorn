using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

using HallOfBeorn.Models.Arkham;
using HallOfBeorn.Models.Arkham.ViewModels;
using HallOfBeorn.Services.Arkham;

namespace HallOfBeorn.Controllers
{
    public class ArkhamController : Controller
    {
        public ArkhamController()
        {
            productRepository = new ArkhamProductRepository();
            searchService = new ArkhamSearchService(productRepository);
        }

        private readonly ArkhamProductRepository productRepository;
        private readonly ArkhamSearchService searchService;

        private void initSearch(ArkhamSearchViewModel model)
        {
            if (string.IsNullOrEmpty(model.Product) || model.Product == "None" || model.Product == "Any")
            {
                model.Product = null;
            }
            if (model.CardType.HasValue && model.CardType.Value == ArkhamCardType.None)
            {
                model.CardType = null;
            }
            if (model.DeckType.HasValue && model.DeckType.Value == ArkhamDeckType.None) {
                model.DeckType = null;
            }
            if (model.ClassSymbol.HasValue && model.ClassSymbol.Value == ClassSymbol.None)
            {
                model.ClassSymbol = null;
            }
            if (model.IsUnique.HasValue && model.IsUnique.Value == Models.Uniqueness.Any)
            {
                model.IsUnique = null;
            }
            if (model.SkillIcon.HasValue && model.SkillIcon.Value == SkillIcon.None) {
                model.SkillIcon = null;
            }
            if (model.Slot.HasValue && model.Slot.Value == AssetSlot.None)
            {
                model.Slot = null;
            }

            if (string.IsNullOrEmpty(model.Health) || model.Health == "Any") {
                model.Health = null;
                model.HealthOp = null;
            }
            if (string.IsNullOrEmpty(model.Sanity) || model.Sanity == "Any") {
                model.Sanity = null;
                model.SanityOp = null;
            }
            if (!model.Willpower.HasValue || model.Willpower.Value == 0) {
                model.Willpower = null;
                model.WillpowerOp = null;
            }
            if (!model.Intellect.HasValue || model.Intellect.Value == 0) {
                model.Intellect = null;
                model.IntellectOp = null;
            }
            if (!model.Combat.HasValue || model.Combat.Value == 0) {
                model.Combat = null;
                model.CombatOp = null;
            }
            if (!model.Agility.HasValue || model.Agility.Value == 0) {
                model.Agility = null;
                model.AgilityOp = null;
            }

            if (string.IsNullOrEmpty(model.Trait) || model.Trait == "None" || model.Trait == "Any")
            {
                model.Trait = null;
            }
            if (string.IsNullOrEmpty(model.Keyword) || model.Keyword == "None" || model.Keyword == "Any")
            {
                model.Keyword = null;
            }
            if (string.IsNullOrEmpty(model.VictoryPoints) ||  model.VictoryPoints == "Any") {
                model.VictoryPoints = null;
            }
            if (string.IsNullOrEmpty(model.Cost) || model.Cost == "Any") {
                model.Cost = null;
                model.CostOp = null;
            }
            if (string.IsNullOrEmpty(model.Level) || model.Level == "Any") {
                model.Level = null;
                model.LevelOp = null;
            }
            if (model.Sort.HasValue && model.Sort.Value == ArkhamSearchSort.None)
            {
                model.Sort = null;
            }
            if (model.View.HasValue && model.View.Value == ArkhamSearchView.None)
            {
                model.View = null;
            }
            if (model.LocationSymbol.HasValue && model.LocationSymbol.Value == ConnectionSymbol.None)
            {
                model.LocationSymbol = null;
            }
            if (model.ConnectsTo.HasValue && model.ConnectsTo.Value == ConnectionSymbol.None)
            {
                model.ConnectsTo = null;
            }
            if (string.IsNullOrEmpty(model.EnemyFightValue) || model.EnemyFightValue == "Any")
            {
                model.EnemyFightValue = null;
                model.EnemyFightValueOp = null;
            }
            if (string.IsNullOrEmpty(model.EnemyHealthValue) || model.EnemyHealthValue == "Any")
            {
                model.EnemyHealthValue = null;
                model.EnemyHealthValueOp = null;
            }
            if (string.IsNullOrEmpty(model.EnemyEvadeValue) || model.EnemyEvadeValue == "Any")
            {
                model.EnemyEvadeValue = null;
                model.EnemyEvadeValueOp = null;
            }
            if (string.IsNullOrEmpty(model.Damage) || model.Damage == "Any")
            {
                model.Damage = null;
                model.DamageOp = null;
            }
            if (string.IsNullOrEmpty(model.Horror) || model.Horror == "Any")
            {
                model.Horror = null;
                model.HorrorOp = null;
            }
            if (string.IsNullOrEmpty(model.Shroud) || model.Shroud == "Any")
            {
                model.Shroud = null;
                model.ShroudOp = null;
            }
            if (string.IsNullOrEmpty(model.ClueValue) || model.ClueValue == "Any")
            {
                model.ClueValue = null;
                model.ClueValueOp = null;
            }
            if (string.IsNullOrEmpty(model.DoomThreshold) || model.DoomThreshold == "Any")
            {
                model.DoomThreshold = null;
                model.DoomThresholdOp = null;
            }
            if (string.IsNullOrEmpty(model.ClueThreshold) || model.ClueThreshold == "Any")
            {
                model.ClueThreshold = null;
                model.ClueThresholdOp = null;
            }
            if (string.IsNullOrEmpty(model.Artist) || model.Artist == "Any")
            {
                model.Artist = null;
            }

            ArkhamSearchViewModel.Products = productRepository.Products().Select(x => { return x.Name; }).GetExtendedSelectListItems();
            ArkhamSearchViewModel.Traits = productRepository.Traits().Distinct().OrderBy(x => { return x; }).GetExtendedSelectListItems();
            ArkhamSearchViewModel.Keywords = productRepository.Keywords().Distinct().OrderBy(x => { return x; }).GetExtendedSelectListItems();
            ArkhamSearchViewModel.VictoryPointsValues = productRepository.VictoryPointsValues().Distinct().OrderBy(x => { return x; }).GetExtendedSelectListItems();
            ArkhamSearchViewModel.HealthValues = productRepository.HealthValues().Distinct().OrderBy(x => { return x; }).GetExtendedSelectListItems();
            ArkhamSearchViewModel.SanityValues = productRepository.SanityValues().Distinct().OrderBy(x => { return x; }).GetExtendedSelectListItems();
            ArkhamSearchViewModel.CostValues = productRepository.CostValues().Distinct().OrderBy(x => { return x; }).GetExtendedSelectListItems();
            ArkhamSearchViewModel.DoomThresholdValues = productRepository.DoomThresholdValues().Distinct().OrderBy(x => { return x; }).GetExtendedSelectListItems();
            ArkhamSearchViewModel.ClueThresholdValues = productRepository.ClueThresholdValues().Distinct().OrderBy(x => { return x; }).GetExtendedSelectListItems();
            ArkhamSearchViewModel.LoadSkillValues(Skill.Willpower, productRepository.SkillValues(Skill.Willpower).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadSkillValues(Skill.Intellect, productRepository.SkillValues(Skill.Intellect).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadSkillValues(Skill.Combat, productRepository.SkillValues(Skill.Combat).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadSkillValues(Skill.Agility, productRepository.SkillValues(Skill.Agility).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadCardStats(StatType.FightValue, productRepository.Stats(StatType.FightValue, ArkhamCardViewModel.PerInvestigatorDescription).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadCardStats(StatType.HealthValue, productRepository.Stats(StatType.HealthValue, ArkhamCardViewModel.PerInvestigatorDescription).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadCardStats(StatType.EvadeValue, productRepository.Stats(StatType.EvadeValue, ArkhamCardViewModel.PerInvestigatorDescription).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadCardStats(StatType.Damage, productRepository.Stats(StatType.Damage, ArkhamCardViewModel.PerInvestigatorDescription).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadCardStats(StatType.Horror, productRepository.Stats(StatType.Horror, ArkhamCardViewModel.PerInvestigatorDescription).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadCardStats(StatType.Shroud, productRepository.Stats(StatType.Shroud, ArkhamCardViewModel.PerInvestigatorDescription).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadCardStats(StatType.ClueValue, productRepository.Stats(StatType.ClueValue, ArkhamCardViewModel.PerInvestigatorDescription).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.ArtistValues = productRepository.Artists().Distinct().OrderBy(x => { return x; }).GetExtendedSelectListItems();
        }

        public ActionResult Details(string id)
        {
            ArkhamCard found = null;

            foreach (var product in productRepository.Products())
            {
                foreach (var card in product.Cards())
                {
                    if (card.Slug == id)
                    {
                        found = card;
                        break;
                    }
                }

                if (found != null)
                {
                    break;
                }
            }

            if (found != null)
            {
                return View(new ArkhamCardViewModel(found));
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult Search(ArkhamSearchViewModel model)
        {
            initSearch(model);

            var results = searchService.Search(model);

            model.LoadCards(results.Select(x => { return new ArkhamCardViewModel(x.Card); }));

            return View(model);
        }

        [HttpPost]
        [ActionName("Search")]
        public ActionResult Search_Post(ArkhamSearchViewModel model)
        {
            initSearch(model);

            return RedirectToAction("Search", "Arkham", model);
        }
    }
}