using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Paritanssi.Models {
    public class Project : IEntity {

        [Key]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        public virtual ICollection<Task> Tasks { get; set; } 
    }
}