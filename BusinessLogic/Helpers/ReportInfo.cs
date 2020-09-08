using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Helpers
{
    public class ReportInfo
    {
        public string FileName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<ReportViewModel> Roles { get; set; }
    }
}
