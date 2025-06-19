using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EnrollmentSystem
{
    public partial class StudentEntryForm : Form
    {
        // Connection string to the Access database
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Talisik\OneDrive\文档\School Works\APPSDEV22.accdb";

        public StudentEntryForm()
        {
            InitializeComponent();
        }

        private void SaveEntryButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Establishing connection to the database
                OleDbConnection subjectConnection = new OleDbConnection(connectionString);

                OleDbDataAdapter studentAdapter = new OleDbDataAdapter("SELECT * FROM [STUDENTFILE]", subjectConnection);
                OleDbCommandBuilder studentBuilder = new OleDbCommandBuilder(studentAdapter);

                DataSet studentDataSet = new DataSet();
                studentAdapter.Fill(studentDataSet, "StudentFile");


                /*Primary Key Setup*/
                DataColumn[] studentKeyColumn = new DataColumn[1];

                studentKeyColumn[0] = studentDataSet.Tables["StudentFile"].Columns["STFSTUDID"];
                studentDataSet.Tables["StudentFile"].PrimaryKey = studentKeyColumn;

                string searchValue = IdNumberTextBox.Text;


                //Saving the data to the StudentFile fields
                DataRow findRow = studentDataSet.Tables["StudentFile"].Rows.Find(searchValue);
                if (findRow == null)
                {
                    DataRow studentRow = studentDataSet.Tables["StudentFile"].NewRow();
                    // Assigning values to the new row
                    studentRow["STFSTUDID"] = IdNumberTextBox.Text;
                    studentRow["STFSTUDFNAME"] = FirstNameTextBox.Text;
                    studentRow["STFSTUDMNAME"] = MiddleNameTextBox.Text;
                    studentRow["STFSTUDLNAME"] = LastNameTextBox.Text;
                    studentRow["STFSTUDREMARKS"] = RemarksComboBox.Text;
                    studentRow["STFSTUDYEAR"] = YearTextBox.Text;
                    studentRow["STFSTUDSTATUS"] = "AC"; // Default status as Active

                    studentDataSet.Tables["StudentFile"].Rows.Add(studentRow);
                    studentAdapter.Update(studentDataSet, "StudentFile");

                    MessageBox.Show("Student entry saved successfully.");

                    // Clear all fields
                    IdNumberTextBox.Clear();
                    FirstNameTextBox.Clear();
                    MiddleNameTextBox.Clear();
                    LastNameTextBox.Clear();
                    RemarksComboBox.SelectedIndex = -1;
                    YearTextBox.Clear();
                    IdNumberTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Duplicate student ID found!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }


        // Clear the form fields when the Cancel button is clicked
        private void CancelButton_Click(object sender, EventArgs e)
        {
            IdNumberTextBox.Clear();
            FirstNameTextBox.Clear();
            MiddleNameTextBox.Clear();
            LastNameTextBox.Clear();
            RemarksComboBox.SelectedIndex = -1;
            YearTextBox.Clear();
            IdNumberTextBox.Focus();
        }
    }
}
