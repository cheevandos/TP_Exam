using System;

namespace BusinessLogic.BindingModels
{
    public class UserBindingModel
    {
        public int? ID { get; set; }
        public int RoleID { get; set; }
        public string FullName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
