using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseImplementation.Models
{
    public class Role
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        [ForeignKey("RoleID")]
        public virtual List<User> Users { get; set; }
    }
}
