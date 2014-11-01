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
        /// <summary>
        /// Projekti-olioihin liittyvä toiminnallisuus
        /// </summary>
        private ProjectService _pser;


        public ProjectController() {
            _pser = new ProjectService();
        }


        /// <summary>
        /// Index-sivu, jossa myös uuden projektin luonti ja 
        /// olemassaolevien listaus.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index() {

            var service = new TaskService();

            service.createTestData();
            var model = new ProjectListViewModel();

            model.Projects = _pser.FindAll();


            return View(model);
        }

        /// <summary>
        /// Uuden projektin luominen tietokantaan
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(ProjectListViewModel model) {
            _pser.Add(model.NewProject);
            return RedirectToAction("Index");
        }

        


	}
}