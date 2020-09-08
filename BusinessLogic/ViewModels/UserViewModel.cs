using System;
using System.ComponentModel;

namespace BusinessLogic.ViewModels
{
    public class UserViewModel
    {
        public int ID { get; set; }
        [DisplayName("Ф.И.О.")]
        public string FullName { get; set; }
        public int RoleID { get; set; }
        [DisplayName("Роль")]
        public string RoleName { get; set; }
        [DisplayName("Логин")]
        public string Login { get; set; }
        [DisplayName("Пароль")]
        public string Password { get; set; }
        [DisplayName("Дата создания")]
        public DateTime CreationDate { get; set; }
        public DateTime RoleCreationDate { get; set; }
    }
}
