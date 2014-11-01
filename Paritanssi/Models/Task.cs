using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Paritanssi.Models {
    public class Task : IEntity {

        public Task() {
            WhenMade = DateTime.Now;
            Id = 0;
            Status = 0;
            ProjectId = 0;
        }

        /// <summary>
        /// Taskin  id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Mihin projektiin taski kuuluu.
        /// </summary>
        [Required]
        public int ProjectId { get; set; }

        /// <summary>
        /// Taskin nimi
        /// </summary>
        [Required]
        public String Name { get; set; }

        /// <summary>
        /// Taskin tila
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Taskin kuvaus
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Koska tehtiin
        /// </summary>
        public DateTime WhenMade { get; set; }


    }
}


