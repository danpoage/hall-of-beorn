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
            if (model.CardClass.HasValue && model.CardClass.Value == ClassSymbol.None)
            {
                model.CardClass = null;
            }
            if (model.Willpower.HasValue && model.Willpower.Value == 0)
            {
                model.Willpower = null;
            }
            if (model.Intellect.HasValue && model.Intellect.Value == 0)
            {
                model.Intellect = null;
            }
            if (model.Combat.HasValue && model.Combat.Value == 0)
            {
                model.Combat = null;
            }
            if (model.Agility.HasValue && model.Agility.Value == 0)
            {
                model.Agility = null;
            }
            if (string.IsNullOrEmpty(model.Trait) || model.Trait == "None" || model.Trait == "Any")
            {
                model.Trait = null;
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

            ArkhamSearchViewModel.LoadProducts(productRepository.Products().Select(x => { return x.Name; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadTraits(productRepository.Traits().Distinct().OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadSkillValues(Skill.Willpower, productRepository.SkillValues(Skill.Willpower).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadSkillValues(Skill.Intellect, productRepository.SkillValues(Skill.Intellect).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadSkillValues(Skill.Combat, productRepository.SkillValues(Skill.Combat).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadSkillValues(Skill.Agility, productRepository.SkillValues(Skill.Agility).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadEnemyStats(EnemyStatType.FightValue, productRepository.EnemyStats(EnemyStatType.FightValue, ArkhamCardViewModel.perInvestigatorIcon).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadEnemyStats(EnemyStatType.HealthValue, productRepository.EnemyStats(EnemyStatType.HealthValue, ArkhamCardViewModel.perInvestigatorIcon).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadEnemyStats(EnemyStatType.EvadeValue, productRepository.EnemyStats(EnemyStatType.EvadeValue, ArkhamCardViewModel.perInvestigatorIcon).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadEnemyStats(EnemyStatType.Damage, productRepository.EnemyStats(EnemyStatType.Damage, ArkhamCardViewModel.perInvestigatorIcon).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
            ArkhamSearchViewModel.LoadEnemyStats(EnemyStatType.Horror, productRepository.EnemyStats(EnemyStatType.Horror, ArkhamCardViewModel.perInvestigatorIcon).Distinct().Where(x => { return !string.IsNullOrEmpty(x); }).OrderBy(x => { return x; }).GetExtendedSelectListItems());
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