using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using HallOfBeorn.Models.Marvel;
using HallOfBeorn.Models.Marvel.ViewModels;
using HallOfBeorn.Services.Marvel;

namespace HallOfBeorn.Controllers
{
    public class MarvelController
        : Controller
    {
        public MarvelController()
        {
            this.productRepository = new MarvelProductRepository();
            this.searchService = new MarvelSearchService(productRepository);
        }

        private readonly MarvelProductRepository productRepository;
        private readonly MarvelSearchService searchService;

        public ActionResult Search(MarvelSearchViewModel model)
        {
            model.Init(productRepository.Products());

            var results = searchService.Search(model);

            model.LoadCards(results.Select(res => { return new MarvelCardViewModel(res.Card); }));

            return View(model);
        }

        [HttpPost]
        [ActionName("Search")]
        public ActionResult Search_Post(MarvelSearchViewModel model)
        {
            model.Init(productRepository.Products());

            return RedirectToAction("Search", "Arkham", model);
        }
    }
}
