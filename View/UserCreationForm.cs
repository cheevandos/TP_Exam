using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class UserCreationForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IUserLogic userLogic;
        private readonly IRoleLogic roleLogic;
        public int ID { set { Id = value; } }
        private int? Id;

        public UserCreationForm(IUserLogic userLogic, IRoleLogic roleLogic)
        {
            InitializeComponent();
            this.userLogic = userLogic;
            this.roleLogic = roleLogic;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show(
                    "Поле \"ФИО\" не заполнено",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (roleComboBox.SelectedValue == null)
            {
                MessageBox.Show(
                    "Необходимо выбрать роль из списка",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(loginTextBox.Text))
            {
                MessageBox.Show(
                    "Поле \"Логин\" не заполнено",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show(
                    "Поле \"Пароль\" не заполнено",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            try
            {
                userLogic.CreateOrUpdate(new UserBindingModel
                {
                    FullName = nameTextBox.Text,
                    RoleID = Convert.ToInt32(roleComboBox.SelectedValue),
                    Login = loginTextBox.Text,
                    Password = passwordTextBox.Text
                });
                MessageBox.Show(
                    "Пользователь сохранен",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void UserCreationForm_Load(object sender, EventArgs e)
        {
            LoadRoles();
            if (Id.HasValue)
            {
                try
                {
                    UserViewModel user = userLogic.Read(new UserBindingModel
                    {
                        ID = Id.Value
                    })?[0];
                    if (user != null)
                    {
                        roleComboBox.SelectedIndex =
                            roleComboBox.FindStringExact(user.RoleName);
                        nameTextBox.Text = user.FullName;
                        loginTextBox.Text = user.Login;
                        passwordTextBox.Text = user.Password;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Ошибка загрузки данных пользователя",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void LoadRoles()
        {
            try
            {
                List<RoleViewModel> roleList = roleLogic.Read(null);
                if (roleList != null)
                {
                    roleComboBox.DisplayMember = "Name";
                    roleComboBox.ValueMember = "ID";
                    roleComboBox.DataSource = roleList;
                    roleComboBox.SelectedItem = null;
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
