using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

using HallOfBeorn.Models.Arkham;
using HallOfBeorn.Models.Arkham.ViewModels;

namespace HallOfBeorn.Controllers
{
    public class ArkhamController : Controller
    {
        public ActionResult Search(ArkhamSearchViewModel model)
        {
            return View(model);
        }
    }
}