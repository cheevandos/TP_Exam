using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseImplementation.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        public int RoleID { get; set; }
        public virtual Role Role { get; set; }
    }
}
