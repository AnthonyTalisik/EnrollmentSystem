using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        // Event handler for the Student Entry button
        private void StudentEntryButton_Click_1(object sender, EventArgs e)
        {
            StudentEntryForm studentForm = new StudentEntryForm();

            studentForm.TopLevel = false;
            studentForm.FormBorderStyle = FormBorderStyle.None;
            studentForm.Dock = DockStyle.Fill;

            DashboardPanel.Controls.Clear();

            DashboardPanel.Padding = new Padding(3); // <-- Add this line
            DashboardPanel.Controls.Add(studentForm);
            studentForm.Show();
        }


        // Event handler for the Subject Entry button
        private void SubjectEntryButton_Click(object sender, EventArgs e)
        {
            SubjectEntryForm subjectForm = new SubjectEntryForm();

            subjectForm.TopLevel = false;
            subjectForm.FormBorderStyle = FormBorderStyle.None;
            subjectForm.Dock = DockStyle.Fill;

            DashboardPanel.Controls.Clear();

            DashboardPanel.Padding = new Padding(3); 
            DashboardPanel.Controls.Add(subjectForm);
            subjectForm.Show();
        }


        // Event handler for the Schedule Entry button
        private void ScheduleEntryButton_Click(object sender, EventArgs e)
        {
            ScheduleEntryForm scheduleForm = new ScheduleEntryForm();

            scheduleForm.TopLevel = false;
            scheduleForm.FormBorderStyle = FormBorderStyle.None;
            scheduleForm.Dock = DockStyle.Fill;

            DashboardPanel.Controls.Clear();

            DashboardPanel.Padding = new Padding(3);
            DashboardPanel.Controls.Add(scheduleForm);
            scheduleForm.Show();
        }


        // Event handler for the Enrollment Entry button
        private void EnrollmentEntryButton_Click(object sender, EventArgs e)
        {
            EnrollmentEntryForm enrollmentForm = new EnrollmentEntryForm();

            enrollmentForm.TopLevel = false;
            enrollmentForm.FormBorderStyle = FormBorderStyle.None;
            enrollmentForm.Dock = DockStyle.Fill;

            DashboardPanel.Controls.Clear();

            DashboardPanel.Padding = new Padding(3);
            DashboardPanel.Controls.Add(enrollmentForm);
            enrollmentForm.Show();
        }


        //Thicken the border of the DashboardPanel
        private void DashboardPanel_Paint(object sender, PaintEventArgs e)
        {
            int borderThickness = 3; 
            Color borderColor = Color.Black; 

            ControlPaint.DrawBorder(e.Graphics, DashboardPanel.ClientRectangle,
                borderColor, borderThickness, ButtonBorderStyle.Solid,  // Left
                borderColor, borderThickness, ButtonBorderStyle.Solid,  // Top
                borderColor, borderThickness, ButtonBorderStyle.Solid,  // Right
                borderColor, borderThickness, ButtonBorderStyle.Solid); // Bottom
        }

        
    }
}
