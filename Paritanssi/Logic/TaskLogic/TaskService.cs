using Paritanssi.DAL;
using Paritanssi.Models;

namespace Paritanssi.Logic.TaskLogic {
    public class TaskService {

        // Tähän väliin ei jaskettu tunkea omaa repoa.
        private DatabaseContext _db;
        public TaskService() {
            _db = new DatabaseContext();
        }

        public TaskService(DatabaseContext db) {
            _db = db;
        }

        public void Add(Task task) {
            _db.Tasks.Add(task);
            _db.SaveChanges();
        }

    }
}