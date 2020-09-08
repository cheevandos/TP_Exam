using BusinessLogic.BusinessLogic;
using BusinessLogic.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class ReportForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ReportLogic reportLogic;

        public ReportForm(ReportLogic reportLogic)
        {
            InitializeComponent();
            this.reportLogic = reportLogic;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (startDateTimePicker.Value.Date >= endDateTimePicker.Value.Date)
            {
                MessageBox.Show(
                    "Дата начала должна быть меньше даты окончания",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            try
            {
                reportLogic.SaveReport(new ReportInfo
                {
                    StartDate = startDateTimePicker.Value,
                    EndDate = endDateTimePicker.Value
                });
                MessageBox.Show(
                    "Отчет сохранен в папке \"Документы\"",
                    "Уведомление",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
