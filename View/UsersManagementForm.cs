using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using System;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class UsersManagementForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IUserLogic userLogic;

        public UsersManagementForm(IUserLogic userLogic)
        {
            InitializeComponent();
            this.userLogic = userLogic;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            UserCreationForm form = Container.Resolve<UserCreationForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (usersGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<UserCreationForm>();
                form.ID = Convert.ToInt32(usersGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (usersGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(
                    "Действительно хотите удалить пользователя?",
                    "Требуется подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int roleID = Convert.ToInt32(usersGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        userLogic.Delete(new UserBindingModel { ID = roleID });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message,
                            "Не удалось удалить пользователя",
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

        private void LoadData()
        {
            try
            {
                var usersList = userLogic.Read(null);
                if (usersList != null)
                {
                    usersGridView.DataSource = usersList;
                    usersGridView.Columns[0].Visible = false;
                    usersGridView.Columns[2].Visible = false;
                    usersGridView.AutoResizeColumns();
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

        private void UsersManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
