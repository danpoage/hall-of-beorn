using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HallOfBeorn.Handlers.Digital;
using HallOfBeorn.Models;
using HallOfBeorn.Models.Digital;
using HallOfBeorn.Models.Digital.ViewModels;
using HallOfBeorn.Services;
using HallOfBeorn.Services.Digital;

namespace HallOfBeorn.Controllers
{
    public class DigitalController : Controller
    {
        public DigitalController()
        {
            _characterRepository = new CharacterRepository();
            _productRepository = new DigitalProductRepository();
            _cardRepository = new DigitalCardRepository(_productRepository);
            _detailsHandler = new DetailsHandler(_cardRepository, _characterRepository);
            _searchHandler = new SearchHandler(_productRepository);
        }

        private readonly CharacterRepository _characterRepository;
        private readonly DigitalProductRepository _productRepository;
        private readonly DigitalCardRepository _cardRepository;
        private readonly DetailsHandler _detailsHandler;
        private readonly SearchHandler _searchHandler;
        
        [HttpGet]
        public ActionResult Details(string id)
        {
            var redirectUrl = _detailsHandler.HandleRedirect(id);
            if (!string.IsNullOrWhiteSpace(redirectUrl))
            {
                return Redirect(redirectUrl);
            }

            var model = _detailsHandler.HandleDetails(id);

            return View(model);
        }

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