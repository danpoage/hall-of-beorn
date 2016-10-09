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

        private void initSearch()
        {
            ArkhamSearchViewModel.LoadProducts(productRepository.Products().Select(x => { return x.Name; }).GetExtendedSelectListItems());
        }

        public ActionResult Search(ArkhamSearchViewModel model)
        {
            initSearch();

            var results = searchService.Search(model);

            model.LoadCards(results.Select(x => { return new ArkhamCardViewModel(x.Card); }));

            return View(model);
        }

        [HttpPost]
        [ActionName("Search")]
        public ActionResult Search_Post(ArkhamSearchViewModel model)
        {
            return RedirectToAction("Search", "Arkham", model);
        }
    }
}