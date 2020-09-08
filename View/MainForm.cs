using BusinessLogic.BusinessLogic;
using System;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class MainForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly SerializationLogic serializationLogic;

        public MainForm(SerializationLogic serializationLogic)
        {
            InitializeComponent();
            this.serializationLogic = serializationLogic;
        }

        private void RolesButton_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<RolesManagementForm>();
            form.ShowDialog();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<UsersManagementForm>();
            form.ShowDialog();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<ReportForm>();
            form.ShowDialog();
        }

        private void SerializeButton_Click(object sender, EventArgs e)
        {
            try
            {
                serializationLogic.Serialize();
                MessageBox.Show(
                    "Данные сохранены в папке \"Документы\"",
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
