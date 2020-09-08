using BusinessLogic.Helpers;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using BusinessLogic.BindingModels;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic.BusinessLogic
{
    public class ReportLogic
    {
        private readonly IUserLogic userLogic;

        public ReportLogic(IUserLogic userLogic)
        {
            this.userLogic = userLogic;
        }

        public async void SaveReport(ReportInfo reportInfo)
        {
            await Task.Run(() =>
            {
                reportInfo.Roles = GetData(reportInfo);
                string path = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "report_" + DateTime.Now.ToLongDateString() + ".pdf");
                reportInfo.FileName = path;
                PdfService.CreateDoc(reportInfo);
            });
        }

        public List<ReportViewModel> GetData(ReportInfo reportInfo)
        {
            return userLogic.Read(new UserBindingModel
            {
                StartDate = reportInfo.StartDate,
                EndDate = reportInfo.EndDate
            }).Select(rec => new ReportViewModel
            {
                RoleName = rec.RoleName,
                UserName = rec.FullName,
                UserCreationDate = rec.CreationDate,
                UserLogin = rec.Login,
                RoleCreationDate = rec.RoleCreationDate
            }).ToList();
        }
    }
}
