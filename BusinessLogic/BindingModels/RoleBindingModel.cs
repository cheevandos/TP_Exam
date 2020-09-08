using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModels
{
    public class RoleBindingModel
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
