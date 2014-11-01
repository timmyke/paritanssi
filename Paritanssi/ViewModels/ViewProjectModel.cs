using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Paritanssi.Models;

namespace Paritanssi.ViewModels {
    public class ViewProjectModel {

        /// <summary>
        /// Projekti johon taskit kuuluu.
        /// </summary>
        public Project Project { get; set; }

        /// <summary>
        /// Annetaan mahdollisuus luoda uusi taski
        /// </summary>
        public Task NewTask { get; set; }

        /// <summary>
        /// Projektiin kuuluvat taskit
        /// </summary>
        public ICollection<Task> Tasks { get; set; }

    }
}