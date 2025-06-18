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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
            EnrollmentButton.MouseEnter += EnrollmentButton_MouseEnter;
            EnrollmentButton.MouseLeave += EnrollmentButton_MouseLeave;
        }

        //Route to Form 2
        private void EnrollmentButton_Click(object sender, EventArgs e)
        {
            Dashboard form2 = new Dashboard();
            // Position Form2 where Form1 is currently located
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location; // same position as Form1
            form2.Show();  // Show Form2           
            this.Hide();
        }
        
        // Event for mouse hover
        private void EnrollmentButton_MouseEnter(object sender, EventArgs e)
        {
            EnrollmentButton.BackColor = Color.Gainsboro;
        }

        private void EnrollmentButton_MouseLeave(object sender, EventArgs e)
        {
            EnrollmentButton.BackColor = SystemColors.Info; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
