using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Paritanssi.DAL;
using Paritanssi.Logic.ProjectLogic;
using Paritanssi.Models;

namespace Paritanssi.Logic.ProjectLogic {
    public class ProjectService {

        private ProjectRepository _repo;

        public ProjectService() {
            
            _repo = new ProjectRepository();

        }

        public ProjectService(ProjectRepository repo) {
            _repo = repo;
        }

        public void Add(Project project) {
            _repo.Add(project);
            _repo.Save();
        }
        
        public ICollection<Project> FindAll() {
            return _repo.FindAll();
        } 

        public Project FindById(int id) {
            var context = new DatabaseContext();
            return context.Projects.Find(id);
        }

    }
}