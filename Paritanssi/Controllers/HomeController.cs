using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Paritanssi.Logic.ProjectLogic;
using Paritanssi.Services;
using Paritanssi.ViewModels;

namespace Paritanssi.Controllers
{
    public class HomeController : Controller {
        //
        // GET: /Home/
        public ActionResult Index() {
            return RedirectToAction("Index", "Project");
        }

    }
}