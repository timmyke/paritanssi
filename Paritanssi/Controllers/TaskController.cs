using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Paritanssi.Logic.ProjectLogic;
using Paritanssi.ViewModels;

namespace Paritanssi.Controllers
{
    public class TaskController : Controller
    {

        private ProjectService _pser;

        public TaskController() {
            _pser = new ProjectService();
        }


        /// <summary>
        /// Projektiin liittyvien taskien tarkistelu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ViewTasks(int id) {
            var model = new ViewTasksModel {Project = _pser.FindById(id)};
            var testi = _pser.FindById(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult ViewTasks(ViewTasksModel model) {
            var task = model.NewTask;
            task.ProjectId = model.Project.Id;

            return RedirectToAction("ViewTasks");
        }
	}
}