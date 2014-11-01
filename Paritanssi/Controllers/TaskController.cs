using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Paritanssi.Logic.ProjectLogic;
using Paritanssi.Logic.TaskLogic;
using Paritanssi.Models;
using Paritanssi.ViewModels;

namespace Paritanssi.Controllers
{
    public class TaskController : Controller
    {

        private readonly ProjectService _pser;
        private TaskService _taskService;

        public TaskController() {
            _pser = new ProjectService();
            _taskService = new TaskService();
        }


        /// <summary>
        /// Projektiin liittyvien taskien tarkistelu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ViewTasks(int id) {
            var model = new ViewTasksModel {Project = _pser.FindById(id)};
            
            return View(model);
        }

        [HttpPost]
        public ActionResult ViewTasks(ViewTasksModel model) {
            var task = model.NewTask;
            var pid = model.Project.Id;
            var project = _pser.FindById(pid);

            //var task = new Task
            //    {
            //        Description = model.NewTask.Description,
            //        ProjectId = pid 
            //    };

            task.ProjectId = pid;
            _taskService.Add(task);
            return RedirectToAction("ViewTasks", new { id = pid});
        }
	}
}