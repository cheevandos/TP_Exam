using System;
using System.ComponentModel;

namespace BusinessLogic.ViewModels
{
    public class RoleViewModel
    {
        public int ID { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Тип")]
        public string Type { get; set; }
        [DisplayName("Дата создания")]
        public DateTime CreationDate { get; set; }
    }
}
