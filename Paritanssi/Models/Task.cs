using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Paritanssi.Models {
    public class Task : IEntity {

        public Task() {
            WhenMade = DateTime.Now;
        }

            [Key]
            public int Id { get; set; }

            [Required]
            public int ProjectId { get; set; }
            public int Status { get; set; }
            public string Description { get; set; }
            public DateTime WhenMade { get; set; }

        
    }
}


