using System.Collections.Generic;
using System.Linq;
using Paritanssi.DAL;
using Paritanssi.Models;

namespace Paritanssi.Logic.TaskLogic {
    public class TaskService {

        // Yksi vastuu lisää...
        private int _maxStatus = 3;

        // Tähän väliin ei jaskettu tunkea omaa repoa.
        private DatabaseContext _db;
        public TaskService() {
            _db = new DatabaseContext();
        }

        public TaskService(DatabaseContext db) {
            _db = db;
        }

        /// <summary>
        /// Taskin persistointi
        /// </summary>
        /// <param name="task"></param>
        public void Add(Task task) {
            _db.Tasks.Add(task);
            _db.SaveChanges();
        }

        /// <summary>
        /// Taskien etsiminen projektin id:n perusteella
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ICollection<Task> FindByProject(int id) {
           return  _db.Tasks.Where(m => m.ProjectId == id).ToList();
        }

        public Task FindById(int id) {
            return _db.Tasks.Find(id);
        }

        /// <summary>
        /// Taskin tilan kohottaminen
        /// </summary>
        /// <param name="taskid"></param>
        public void Promote(int taskid) {
            // single responsibilyty principle... Hups...
            var task = _db.Tasks.Find(taskid);

            if (task.Status < _maxStatus) {
                task.Status++;
            }

            _db.SaveChanges();
        }


        /// <summary>
        /// Taskin tilan laskeminen
        /// </summary>
        /// <param name="taskid"></param>
        public void Demote(int taskid) {
            // single responsibilyty principle... Hups...
            var task = _db.Tasks.Find(taskid);

            if (task.Status > 0) {
                task.Status--;
            }

            _db.SaveChanges();
        }

    }
}