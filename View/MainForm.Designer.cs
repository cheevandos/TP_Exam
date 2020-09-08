namespace View
{
    partial class MainForm
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
            this.rolesButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.serializeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rolesButton
            // 
            this.rolesButton.BackColor = System.Drawing.Color.White;
            this.rolesButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.rolesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.rolesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rolesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rolesButton.Location = new System.Drawing.Point(12, 12);
            this.rolesButton.Name = "rolesButton";
            this.rolesButton.Size = new System.Drawing.Size(300, 40);
            this.rolesButton.TabIndex = 2;
            this.rolesButton.Text = "Роли";
            this.rolesButton.UseVisualStyleBackColor = false;
            this.rolesButton.Click += new System.EventHandler(this.RolesButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.BackColor = System.Drawing.Color.White;
            this.usersButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.usersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersButton.Location = new System.Drawing.Point(12, 58);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(300, 40);
            this.usersButton.TabIndex = 3;
            this.usersButton.Text = "Пользователи";
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.Color.White;
            this.reportButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.reportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportButton.Location = new System.Drawing.Point(12, 104);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(300, 40);
            this.reportButton.TabIndex = 4;
            this.reportButton.Text = "Отчет";
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // serializeButton
            // 
            this.serializeButton.BackColor = System.Drawing.Color.White;
            this.serializeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.serializeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.serializeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serializeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serializeButton.Location = new System.Drawing.Point(12, 150);
            this.serializeButton.Name = "serializeButton";
            this.serializeButton.Size = new System.Drawing.Size(300, 40);
            this.serializeButton.TabIndex = 5;
            this.serializeButton.Text = "Сериализация";
            this.serializeButton.UseVisualStyleBackColor = false;
            this.serializeButton.Click += new System.EventHandler(this.SerializeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 205);
            this.Controls.Add(this.serializeButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.rolesButton);
            this.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button rolesButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button serializeButton;
    }
}