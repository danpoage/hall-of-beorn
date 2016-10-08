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
        private readonly ArkhamSearchService searchService = new ArkhamSearchService();

        public ActionResult Search(ArkhamSearchViewModel model)
        {
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