using System.Collections.Generic;
using System.Linq;
using Paritanssi.DAL;
using Paritanssi.Models;

namespace Paritanssi.Logic.ProjectLogic {
    public class ProjectRepository : IRepository<Project> {
        private DatabaseContext _context;

        public ProjectRepository() {
            _context = new DatabaseContext();
        }

        public ProjectRepository(DatabaseContext context) {
            _context = context;
        }


        public void Add(Project project) {
            _context.Projects.Add(project);
        }

        public ICollection<Project> FindAll() {
            return _context.Projects.ToList();
        }

        public void Save() {
            _context.SaveChanges();
        }
    }
}