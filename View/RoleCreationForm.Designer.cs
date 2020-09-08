namespace View
{
    partial class RoleCreationForm
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

        private void InitializeComponent()
        {
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.namePanel = new System.Windows.Forms.Panel();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typePanel = new System.Windows.Forms.Panel();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.namePanel.SuspendLayout();
            this.typePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.White;
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(12, 171);
            this.createButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(163, 40);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Сохранить";
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
            this.cancelButton.Location = new System.Drawing.Point(181, 171);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(163, 40);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
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
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(163, 30);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Название:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // namePanel
            // 
            this.namePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namePanel.Controls.Add(this.nameTextBox);
            this.namePanel.Location = new System.Drawing.Point(12, 42);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(332, 40);
            this.namePanel.TabIndex = 5;
            // 
            // typeLabel
            // 
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(12, 85);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(163, 30);
            this.typeLabel.TabIndex = 6;
            this.typeLabel.Text = "Тип:";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // typePanel
            // 
            this.typePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typePanel.Controls.Add(this.typeTextBox);
            this.typePanel.Location = new System.Drawing.Point(12, 118);
            this.typePanel.Name = "typePanel";
            this.typePanel.Size = new System.Drawing.Size(332, 40);
            this.typePanel.TabIndex = 6;
            // 
            // typeTextBox
            // 
            this.typeTextBox.BackColor = System.Drawing.Color.White;
            this.typeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeTextBox.Location = new System.Drawing.Point(9, 7);
            this.typeTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(312, 22);
            this.typeTextBox.TabIndex = 1;
            // 
            // RoleCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 223);
            this.Controls.Add(this.typePanel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RoleCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая роль";
            this.Load += new System.EventHandler(this.RoleCreationForm_Load);
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.typePanel.ResumeLayout(false);
            this.typePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Panel typePanel;
        private System.Windows.Forms.TextBox typeTextBox;
    }
}