namespace View
{
    partial class UserCreationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.roleLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.namePanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.White;
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(8, 306);
            this.createButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(163, 40);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(177, 306);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(163, 40);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // roleLabel
            // 
            this.roleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleLabel.Location = new System.Drawing.Point(8, 85);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(163, 30);
            this.roleLabel.TabIndex = 4;
            this.roleLabel.Text = "Роль:";
            this.roleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(8, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(163, 30);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Ф.И.О.:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // namePanel
            // 
            this.namePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namePanel.Controls.Add(this.nameTextBox);
            this.namePanel.Location = new System.Drawing.Point(8, 42);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(332, 40);
            this.namePanel.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(9, 7);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(312, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(8, 118);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(332, 27);
            this.roleComboBox.TabIndex = 7;
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(8, 148);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(163, 30);
            this.loginLabel.TabIndex = 8;
            this.loginLabel.Text = "Логин:";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginPanel
            // 
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPanel.Controls.Add(this.loginTextBox);
            this.loginPanel.Location = new System.Drawing.Point(8, 181);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(332, 40);
            this.loginPanel.TabIndex = 7;
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.Color.White;
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(9, 7);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(312, 22);
            this.loginTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(8, 224);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(163, 30);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Пароль:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passwordPanel
            // 
            this.passwordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordPanel.Controls.Add(this.passwordTextBox);
            this.passwordPanel.Location = new System.Drawing.Point(8, 257);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(332, 40);
            this.passwordPanel.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(9, 7);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(312, 22);
            this.passwordTextBox.TabIndex = 1;
            // 
            // UserCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 362);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый пользователь";
            this.Load += new System.EventHandler(this.UserCreationForm_Load);
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}