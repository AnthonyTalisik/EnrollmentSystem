namespace EnrollmentSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.StudentEntryButton = new System.Windows.Forms.Button();
            this.SubjectEntryButton = new System.Windows.Forms.Button();
            this.ScheduleEntryButton = new System.Windows.Forms.Button();
            this.EnrollmentEntryButton = new System.Windows.Forms.Button();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // StudentEntryButton
            // 
            this.StudentEntryButton.BackColor = System.Drawing.SystemColors.Info;
            this.StudentEntryButton.Location = new System.Drawing.Point(1, 0);
            this.StudentEntryButton.Name = "StudentEntryButton";
            this.StudentEntryButton.Size = new System.Drawing.Size(169, 155);
            this.StudentEntryButton.TabIndex = 0;
            this.StudentEntryButton.Text = "Student Entry";
            this.StudentEntryButton.UseVisualStyleBackColor = false;
            this.StudentEntryButton.Click += new System.EventHandler(this.StudentEntryButton_Click_1);
            // 
            // SubjectEntryButton
            // 
            this.SubjectEntryButton.BackColor = System.Drawing.SystemColors.Info;
            this.SubjectEntryButton.Location = new System.Drawing.Point(1, 150);
            this.SubjectEntryButton.Name = "SubjectEntryButton";
            this.SubjectEntryButton.Size = new System.Drawing.Size(169, 155);
            this.SubjectEntryButton.TabIndex = 1;
            this.SubjectEntryButton.Text = "Subject Entry";
            this.SubjectEntryButton.UseVisualStyleBackColor = false;
            this.SubjectEntryButton.Click += new System.EventHandler(this.SubjectEntryButton_Click);
            // 
            // ScheduleEntryButton
            // 
            this.ScheduleEntryButton.BackColor = System.Drawing.SystemColors.Info;
            this.ScheduleEntryButton.Location = new System.Drawing.Point(1, 300);
            this.ScheduleEntryButton.Name = "ScheduleEntryButton";
            this.ScheduleEntryButton.Size = new System.Drawing.Size(169, 155);
            this.ScheduleEntryButton.TabIndex = 2;
            this.ScheduleEntryButton.Text = "Schedule Entry";
            this.ScheduleEntryButton.UseVisualStyleBackColor = false;
            this.ScheduleEntryButton.Click += new System.EventHandler(this.ScheduleEntryButton_Click);
            // 
            // EnrollmentEntryButton
            // 
            this.EnrollmentEntryButton.BackColor = System.Drawing.SystemColors.Info;
            this.EnrollmentEntryButton.Location = new System.Drawing.Point(1, 453);
            this.EnrollmentEntryButton.Name = "EnrollmentEntryButton";
            this.EnrollmentEntryButton.Size = new System.Drawing.Size(169, 163);
            this.EnrollmentEntryButton.TabIndex = 3;
            this.EnrollmentEntryButton.Text = "Enrollment Entry";
            this.EnrollmentEntryButton.UseVisualStyleBackColor = false;
            this.EnrollmentEntryButton.Click += new System.EventHandler(this.EnrollmentEntryButton_Click);
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DashboardPanel.Location = new System.Drawing.Point(209, 12);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(800, 576);
            this.DashboardPanel.TabIndex = 4;
            this.DashboardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DashboardPanel_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1051, 611);
            this.Controls.Add(this.DashboardPanel);
            this.Controls.Add(this.EnrollmentEntryButton);
            this.Controls.Add(this.ScheduleEntryButton);
            this.Controls.Add(this.SubjectEntryButton);
            this.Controls.Add(this.StudentEntryButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "University of Cebu Enrollment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StudentEntryButton;
        private System.Windows.Forms.Button SubjectEntryButton;
        private System.Windows.Forms.Button ScheduleEntryButton;
        private System.Windows.Forms.Button EnrollmentEntryButton;
        private System.Windows.Forms.Panel DashboardPanel;
    }
}