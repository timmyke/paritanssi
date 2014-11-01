using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Paritanssi.Models;

namespace Paritanssi.ViewModels {
    public class HomeIndexModel {
        private Project _project;
        private ICollection<Project> _projects; 

        public Project NewProject { get { return _project ?? new Project(); } set { _project = value; } }

        public ICollection<Project> Projects {
            get { return _projects ?? new List<Project>(); }
            set { _projects = value; }
        }
    }
}