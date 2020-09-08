using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using System;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class RolesManagementForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IRoleLogic roleLogic;
        public RolesManagementForm(IRoleLogic roleLogic)
        {
            InitializeComponent();
            this.roleLogic = roleLogic;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            RoleCreationForm form = Container.Resolve<RoleCreationForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (rolesGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<RoleCreationForm>();
                form.ID = Convert.ToInt32(rolesGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (rolesGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(
                    "Действительно хотите удалить роль?",
                    "Требуется подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int roleID = Convert.ToInt32(rolesGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        roleLogic.Delete(new RoleBindingModel { ID = roleID });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message,
                            "Не удалось удалить роль",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void RolesManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var rolesList = roleLogic.Read(null);
                if (rolesList != null)
                {
                    rolesGridView.DataSource = rolesList;
                    rolesGridView.Columns[0].Visible = false;
                    rolesGridView.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка загрузки списка ролей",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
