using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HallOfBeorn.Handlers.Digital;
using HallOfBeorn.Models;
using HallOfBeorn.Models.Digital;
using HallOfBeorn.Models.Digital.ViewModels;
using HallOfBeorn.Services.Digital;

namespace HallOfBeorn.Controllers
{
    public class DigitalController : Controller
    {
        public DigitalController()
        {
            _productRepository = new DigitalProductRepository();
            _searchHandler = new SearchHandler(_productRepository);
        }

        private readonly DigitalProductRepository _productRepository;
        private readonly SearchHandler _searchHandler;

        [HttpGet]
        public ActionResult Search(DigitalSearchViewModel model)
        {
            _searchHandler.HandleSearch(model);

            return View(model);
        }

        [HttpPost]
        [ActionName("Search")]
        public ActionResult Search_Post(DigitalSearchViewModel model)
        {
            model.Initialize();

            return RedirectToAction("Search", model);
        }
    }
}