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
            this.StudentLabel = new System.Windows.Forms.Label();
            this.StudentPictureBox = new System.Windows.Forms.PictureBox();
            this.SubjectPictureBox = new System.Windows.Forms.PictureBox();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.SchedulePictureBox = new System.Windows.Forms.PictureBox();
            this.ScheduleLabel = new System.Windows.Forms.Label();
            this.EnrollmentLabel = new System.Windows.Forms.Label();
            this.EnrollmentPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchedulePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnrollmentPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentEntryButton
            // 
            this.StudentEntryButton.BackColor = System.Drawing.Color.PowderBlue;
            this.StudentEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentEntryButton.Location = new System.Drawing.Point(1, 0);
            this.StudentEntryButton.Name = "StudentEntryButton";
            this.StudentEntryButton.Size = new System.Drawing.Size(169, 153);
            this.StudentEntryButton.TabIndex = 0;
            this.StudentEntryButton.UseVisualStyleBackColor = false;
            this.StudentEntryButton.Click += new System.EventHandler(this.StudentEntryButton_Click_1);
            // 
            // SubjectEntryButton
            // 
            this.SubjectEntryButton.BackColor = System.Drawing.Color.PowderBlue;
            this.SubjectEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectEntryButton.Location = new System.Drawing.Point(1, 150);
            this.SubjectEntryButton.Name = "SubjectEntryButton";
            this.SubjectEntryButton.Size = new System.Drawing.Size(169, 155);
            this.SubjectEntryButton.TabIndex = 1;
            this.SubjectEntryButton.UseVisualStyleBackColor = false;
            this.SubjectEntryButton.Click += new System.EventHandler(this.SubjectEntryButton_Click);
            // 
            // ScheduleEntryButton
            // 
            this.ScheduleEntryButton.BackColor = System.Drawing.Color.PowderBlue;
            this.ScheduleEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleEntryButton.Location = new System.Drawing.Point(1, 300);
            this.ScheduleEntryButton.Name = "ScheduleEntryButton";
            this.ScheduleEntryButton.Size = new System.Drawing.Size(169, 155);
            this.ScheduleEntryButton.TabIndex = 2;
            this.ScheduleEntryButton.UseVisualStyleBackColor = false;
            this.ScheduleEntryButton.Click += new System.EventHandler(this.ScheduleEntryButton_Click);
            // 
            // EnrollmentEntryButton
            // 
            this.EnrollmentEntryButton.BackColor = System.Drawing.Color.PowderBlue;
            this.EnrollmentEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollmentEntryButton.Location = new System.Drawing.Point(1, 453);
            this.EnrollmentEntryButton.Name = "EnrollmentEntryButton";
            this.EnrollmentEntryButton.Size = new System.Drawing.Size(169, 158);
            this.EnrollmentEntryButton.TabIndex = 3;
            this.EnrollmentEntryButton.UseVisualStyleBackColor = false;
            this.EnrollmentEntryButton.Click += new System.EventHandler(this.EnrollmentEntryButton_Click);
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DashboardPanel.Controls.Add(this.pictureBox1);
            this.DashboardPanel.Location = new System.Drawing.Point(209, 12);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(800, 576);
            this.DashboardPanel.TabIndex = 4;
            this.DashboardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DashboardPanel_Paint);
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.BackColor = System.Drawing.Color.PowderBlue;
            this.StudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLabel.Location = new System.Drawing.Point(24, 112);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(120, 20);
            this.StudentLabel.TabIndex = 0;
            this.StudentLabel.Text = "Student Entry";
            // 
            // StudentPictureBox
            // 
            this.StudentPictureBox.BackColor = System.Drawing.Color.PowderBlue;
            this.StudentPictureBox.ErrorImage = null;
            this.StudentPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("StudentPictureBox.Image")));
            this.StudentPictureBox.Location = new System.Drawing.Point(42, 27);
            this.StudentPictureBox.Name = "StudentPictureBox";
            this.StudentPictureBox.Size = new System.Drawing.Size(85, 73);
            this.StudentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StudentPictureBox.TabIndex = 0;
            this.StudentPictureBox.TabStop = false;
            // 
            // SubjectPictureBox
            // 
            this.SubjectPictureBox.BackColor = System.Drawing.Color.PowderBlue;
            this.SubjectPictureBox.Image = global::EnrollmentSystem.Properties.Resources.SubjectIcon;
            this.SubjectPictureBox.Location = new System.Drawing.Point(42, 184);
            this.SubjectPictureBox.Name = "SubjectPictureBox";
            this.SubjectPictureBox.Size = new System.Drawing.Size(85, 73);
            this.SubjectPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SubjectPictureBox.TabIndex = 0;
            this.SubjectPictureBox.TabStop = false;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.BackColor = System.Drawing.Color.PowderBlue;
            this.SubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLabel.Location = new System.Drawing.Point(24, 260);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(117, 20);
            this.SubjectLabel.TabIndex = 5;
            this.SubjectLabel.Text = "Subject Entry";
            // 
            // SchedulePictureBox
            // 
            this.SchedulePictureBox.BackColor = System.Drawing.Color.PowderBlue;
            this.SchedulePictureBox.Image = global::EnrollmentSystem.Properties.Resources.ScheduleIcon;
            this.SchedulePictureBox.Location = new System.Drawing.Point(51, 333);
            this.SchedulePictureBox.Name = "SchedulePictureBox";
            this.SchedulePictureBox.Size = new System.Drawing.Size(67, 64);
            this.SchedulePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SchedulePictureBox.TabIndex = 6;
            this.SchedulePictureBox.TabStop = false;
            // 
            // ScheduleLabel
            // 
            this.ScheduleLabel.AutoSize = true;
            this.ScheduleLabel.BackColor = System.Drawing.Color.PowderBlue;
            this.ScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleLabel.Location = new System.Drawing.Point(24, 409);
            this.ScheduleLabel.Name = "ScheduleLabel";
            this.ScheduleLabel.Size = new System.Drawing.Size(131, 20);
            this.ScheduleLabel.TabIndex = 7;
            this.ScheduleLabel.Text = "Schedule Entry";
            // 
            // EnrollmentLabel
            // 
            this.EnrollmentLabel.AutoSize = true;
            this.EnrollmentLabel.BackColor = System.Drawing.Color.PowderBlue;
            this.EnrollmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollmentLabel.Location = new System.Drawing.Point(13, 568);
            this.EnrollmentLabel.Name = "EnrollmentLabel";
            this.EnrollmentLabel.Size = new System.Drawing.Size(142, 20);
            this.EnrollmentLabel.TabIndex = 8;
            this.EnrollmentLabel.Text = "Enrollment Entry";
            // 
            // EnrollmentPictureBox
            // 
            this.EnrollmentPictureBox.BackColor = System.Drawing.Color.PowderBlue;
            this.EnrollmentPictureBox.Image = global::EnrollmentSystem.Properties.Resources.EnrollmentIcon;
            this.EnrollmentPictureBox.Location = new System.Drawing.Point(51, 490);
            this.EnrollmentPictureBox.Name = "EnrollmentPictureBox";
            this.EnrollmentPictureBox.Size = new System.Drawing.Size(67, 64);
            this.EnrollmentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnrollmentPictureBox.TabIndex = 9;
            this.EnrollmentPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(159, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1051, 611);
            this.Controls.Add(this.EnrollmentPictureBox);
            this.Controls.Add(this.ScheduleLabel);
            this.Controls.Add(this.EnrollmentLabel);
            this.Controls.Add(this.SchedulePictureBox);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.SubjectPictureBox);
            this.Controls.Add(this.StudentPictureBox);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.DashboardPanel);
            this.Controls.Add(this.EnrollmentEntryButton);
            this.Controls.Add(this.ScheduleEntryButton);
            this.Controls.Add(this.SubjectEntryButton);
            this.Controls.Add(this.StudentEntryButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "University of Cebu Enrollment";
            this.DashboardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchedulePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnrollmentPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StudentEntryButton;
        private System.Windows.Forms.Button SubjectEntryButton;
        private System.Windows.Forms.Button ScheduleEntryButton;
        private System.Windows.Forms.Button EnrollmentEntryButton;
        private System.Windows.Forms.Panel DashboardPanel;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.PictureBox StudentPictureBox;
        private System.Windows.Forms.PictureBox SubjectPictureBox;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.PictureBox SchedulePictureBox;
        private System.Windows.Forms.Label ScheduleLabel;
        private System.Windows.Forms.Label EnrollmentLabel;
        private System.Windows.Forms.PictureBox EnrollmentPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}