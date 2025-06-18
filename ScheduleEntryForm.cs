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

namespace EnrollmentSystem
{
    public partial class ScheduleEntryForm : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Talisik\OneDrive\文档\School Works\APPSDEV22.accdb";

        public ScheduleEntryForm()
        {

            InitializeComponent();
            StartDateTimePicker.Format = DateTimePickerFormat.Custom;
            StartDateTimePicker.CustomFormat = "hh:mm tt";  // show hours and minutes with AM/PM
            StartDateTimePicker.ShowUpDown = true;          // enable up/down spin control instead of calendar
            EndDateTimePicker.Format = DateTimePickerFormat.Custom;
            EndDateTimePicker.CustomFormat = "hh:mm tt";
            EndDateTimePicker.ShowUpDown = true;

        }

        private void SaveEntryButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Establish connection to the database
                OleDbConnection subjectConnection = new OleDbConnection(connectionString);

                OleDbDataAdapter studentAdapter = new OleDbDataAdapter("SELECT * FROM [SUBJECTSCHEDFILE]", subjectConnection);
                OleDbCommandBuilder studentBuilder = new OleDbCommandBuilder(studentAdapter);

                DataSet studentDataSet = new DataSet();
                studentAdapter.Fill(studentDataSet, "SubjectSchedFile");

                /* Primary Key Setup */
                DataColumn[] studentKeyColumn = new DataColumn[1];
                studentKeyColumn[0] = studentDataSet.Tables["SubjectSchedFile"].Columns["SSFEDPCODE"];
                studentDataSet.Tables["SubjectSchedFile"].PrimaryKey = studentKeyColumn;

                string searchValue = SubjectEdpCodeTextBox.Text;

                // Check if entry already exists
                DataRow findRow = studentDataSet.Tables["SubjectSchedFile"].Rows.Find(searchValue);
                if (findRow == null)
                {
                    DataRow scheduleRow = studentDataSet.Tables["SubjectSchedFile"].NewRow();

                    scheduleRow["SSFEDPCODE"] = SubjectEdpCodeTextBox.Text;
                    scheduleRow["SSFSUBJCODE"] = SubjectCodeTextBox.Text;

                    // Save only the time part as string in 24-hour format
                    scheduleRow["SSFSTARTTIME"] = StartDateTimePicker.Value.ToString("hh:mm tt");  // 12-hour with AM/PM
                    scheduleRow["SSFENDTIME"] = EndDateTimePicker.Value.ToString("hh:mm tt");

                    scheduleRow["SSFDAYS"] = DaysTextBox.Text;
                    scheduleRow["SSFROOM"] = RoomTextBox.Text;
                    scheduleRow["SSFMAXSIZE"] = "30";
                    scheduleRow["SSFCLASSSIZE"] = "25";
                    scheduleRow["SSFSTATUS"] = StatusComboBox.Text;
                    scheduleRow["SSFSECTION"] = SectionTextBox.Text;
                    scheduleRow["SSFSCHOOLYEAR"] = SchoolYearTextBox.Text;

                    studentDataSet.Tables["SubjectSchedFile"].Rows.Add(scheduleRow);
                    studentAdapter.Update(studentDataSet, "SubjectSchedFile");

                    MessageBox.Show("Student entry saved successfully.");

                    // Clear all fields
                    SubjectEdpCodeTextBox.Clear();
                    SubjectCodeTextBox.Clear();
                    DaysTextBox.Clear();
                    RoomTextBox.Clear();
                    StatusComboBox.SelectedIndex = -1;
                    SectionTextBox.Clear();
                    SchoolYearTextBox.Clear();
                    SubjectEdpCodeTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Error: An entry with this EDP code already exists!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }
    }
}