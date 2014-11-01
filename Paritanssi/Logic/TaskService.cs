using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Paritanssi.DAL;
using Paritanssi.Models;

namespace Paritanssi.Services {
    public class TaskService {

        public TaskService() {}


        public void createTestData() {
            var context = new DatabaseContext();
            //var taski = new Task();
            //taski.Description = "testi";

            //context.Projects.Add(taski);
            //context.SaveChanges();

        }
    }
}