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
    public class ProjectController : Controller
    {
    private ProjectService _pser;


        public ProjectController() {
            _pser = new ProjectService();
        }


        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index() {

            var service = new TaskService();

            service.createTestData();
            var model = new HomeIndexModel();

            model.Projects = _pser.FindAll();


            return View(model);
        }

        [HttpPost]
        public ActionResult Index(HomeIndexModel model) {
            _pser.Add(model.NewProject);
            return RedirectToAction("Index");
        }


	}
}