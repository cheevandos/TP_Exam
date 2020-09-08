namespace View
{
    partial class ReportForm
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
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.createButton = new System.Windows.Forms.Button();
            this.componentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createReportGroupBox = new System.Windows.Forms.GroupBox();
            this.createReportGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(157, 23);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.startDateTimePicker.TabIndex = 0;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(157, 67);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.endDateTimePicker.TabIndex = 1;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.White;
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(10, 100);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(347, 40);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Сохранить";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // componentLabel
            // 
            this.componentLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.componentLabel.Location = new System.Drawing.Point(6, 23);
            this.componentLabel.Name = "componentLabel";
            this.componentLabel.Size = new System.Drawing.Size(145, 27);
            this.componentLabel.TabIndex = 5;
            this.componentLabel.Text = "Начало периода:";
            this.componentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "конец периода:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // createReportGroupBox
            // 
            this.createReportGroupBox.Controls.Add(this.componentLabel);
            this.createReportGroupBox.Controls.Add(this.startDateTimePicker);
            this.createReportGroupBox.Controls.Add(this.endDateTimePicker);
            this.createReportGroupBox.Controls.Add(this.label1);
            this.createReportGroupBox.Controls.Add(this.createButton);
            this.createReportGroupBox.Location = new System.Drawing.Point(12, 12);
            this.createReportGroupBox.Name = "createReportGroupBox";
            this.createReportGroupBox.Size = new System.Drawing.Size(368, 151);
            this.createReportGroupBox.TabIndex = 9;
            this.createReportGroupBox.TabStop = false;
            this.createReportGroupBox.Text = "Данные для отчета";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(393, 178);
            this.Controls.Add(this.createReportGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет";
            this.createReportGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label componentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox createReportGroupBox;
    }
}