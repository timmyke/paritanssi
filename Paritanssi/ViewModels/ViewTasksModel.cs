using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Paritanssi.Models;

namespace Paritanssi.ViewModels {
    public class ViewTasksModel {

        private Task _task;

        /// <summary>
        /// Projekti johon taskit kuuluu.
        /// </summary>
        public Project Project { get; set; }

        /// <summary>s
        /// Annetaan mahdollisuus luoda uusi taski
        /// </summary>
        public Task NewTask {
            get { return _task ?? new Task(); }
            set { _task = value; }
        }

        /// <summary>
        /// Projektiin kuuluvat taskit
        /// </summary>
        public ICollection<Task> Tasks { get; set; }

    }
}