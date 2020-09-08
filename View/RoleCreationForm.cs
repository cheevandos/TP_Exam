using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class RoleCreationForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IRoleLogic roleLogic;
        public int ID { set { Id = value; } }
        private int? Id;

        public RoleCreationForm(IRoleLogic roleLogic)
        {
            InitializeComponent();
            this.roleLogic = roleLogic;
        }

        private void RoleCreationForm_Load(object sender, EventArgs e)
        {
            if (Id.HasValue)
            {
                try
                {
                    var roleView = roleLogic.Read(new RoleBindingModel { ID = Id })?[0];
                    if (roleView != null)
                    {
                        nameTextBox.Text = roleView.Name;
                        typeTextBox.Text = roleView.Type;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Ошибка загрузки комплектующих",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string pattern = @"(\w*)";
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show(
                    "Поле \"Название\" не заполнено",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(typeTextBox.Text))
            {
                MessageBox.Show(
                    "Поле \"Тип\" не заполнено",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(nameTextBox.Text, pattern)
                && !Regex.IsMatch(typeTextBox.Text, pattern))
            {
                MessageBox.Show(
                    "Названия должны содержать только цифры, буквы и знаки подчеркивания",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            try
            {
                roleLogic.CreateOrUpdate(new RoleBindingModel
                {
                    ID = Id,
                    Name = nameTextBox.Text,
                    Type = typeTextBox.Text,
                    CreationDate = DateTime.Now
                });
                MessageBox.Show(
                    "Сохранение прошло успешно",
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
                    "Ошибка при сохранении роли",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
