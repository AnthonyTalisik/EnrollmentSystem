using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class EnrollmentEntryForm : Form
    {
        // Connection string to the Access database
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Talisik\OneDrive\文档\School Works\APPSDEV22.accdb";

        public EnrollmentEntryForm()
        {
            InitializeComponent();

            // Subscribe to KeyDown "Enter key" event for EDP code input
            EdpCodeTextBox.KeyDown += EdpCodeTextBox_KeyDown;

            // Clear grid at start
            EnrollmentDataGridView.DataSource = null;

            // Setup DataGridView appearance
            EnrollmentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EnrollmentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EnrollmentDataGridView.ReadOnly = true;
        }

        // Event handler for EDP code input when "Enter" key is pressed
        private void EdpCodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // prevent beep sound
                string edpCode = EdpCodeTextBox.Text.Trim();

                if (string.IsNullOrEmpty(edpCode))
                {
                    MessageBox.Show("Please enter an EDP code.");
                    return;
                }

                LoadSubjectByEDP(edpCode);
            }
        }

        // Method to load subject schedule based on EDP code
        private void LoadSubjectByEDP(string edpCode)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT SSFEDPCODE, SSFSUBJCODE, SSFSTARTTIME, SSFENDTIME, SSFDAYS, SSFROOM FROM SubjectSchedFile WHERE SSFEDPCODE = ?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", edpCode);

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("No subject schedule found for that EDP code.");
                                EnrollmentDataGridView.DataSource = null; // Clear the grid if no results
                                return;
                            }

                            EnrollmentDataGridView.DataSource = dt;

                            // Friendly column headers
                            EnrollmentDataGridView.Columns["SSFEDPCODE"].HeaderText = "EDP Code";
                            EnrollmentDataGridView.Columns["SSFSUBJCODE"].HeaderText = "Subject Code";
                            EnrollmentDataGridView.Columns["SSFSTARTTIME"].HeaderText = "Start Time";
                            EnrollmentDataGridView.Columns["SSFENDTIME"].HeaderText = "End Time";
                            EnrollmentDataGridView.Columns["SSFDAYS"].HeaderText = "Days";
                            EnrollmentDataGridView.Columns["SSFROOM"].HeaderText = "Room";

                            // Format the time columns to display only time
                            EnrollmentDataGridView.Columns["SSFSTARTTIME"].DefaultCellStyle.Format = "hh:mm tt"; // 12-hour format
                            EnrollmentDataGridView.Columns["SSFENDTIME"].DefaultCellStyle.Format = "hh:mm tt"; // 12-hour format
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subject schedule: " + ex.Message);
            }
        }

        // Event handler for Save Entry button click
        private void SaveEntryButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection subjectConnection = new OleDbConnection(connectionString))
                {
                    subjectConnection.Open();
                    OleDbDataAdapter studentAdapter = new OleDbDataAdapter("SELECT * FROM [ENROLLMENTHEADERFILE]", subjectConnection);
                    OleDbCommandBuilder studentBuilder = new OleDbCommandBuilder(studentAdapter);

                    DataSet studentDataSet = new DataSet();
                    studentAdapter.Fill(studentDataSet, "EnrollmentHeaderFile");

                    // Set primary key
                    DataColumn[] studentKeyColumn = new DataColumn[1];
                    studentKeyColumn[0] = studentDataSet.Tables["EnrollmentHeaderFile"].Columns["ENRHFSTUDID"];
                    studentDataSet.Tables["EnrollmentHeaderFile"].PrimaryKey = studentKeyColumn;

                    string searchValue = IdNumberTextBox.Text;
                    DataRow findRow = studentDataSet.Tables["EnrollmentHeaderFile"].Rows.Find(searchValue);

                    if (findRow == null)
                    {
                        DataRow studentRow = studentDataSet.Tables["EnrollmentHeaderFile"].NewRow();
                        studentRow["ENRHFSTUDID"] = IdNumberTextBox.Text;
                        studentRow["ENRHFSTUDDATEENROLL"] = DateTimePicker.Value.Date;
                        studentRow["ENRHFSTUDSCHLYR"] = YearTextBox.Text;
                        studentRow["ENRHFSTUDENCODER"] = EncoderTextBox.Text;
                        studentRow["ENRHFSTUDTOTALUNITS"] = TotalUnitsTextBox.Text;
                        studentRow["ENRHFSTUDSTATUS"] = "AC";

                        studentDataSet.Tables["EnrollmentHeaderFile"].Rows.Add(studentRow);
                        studentAdapter.Update(studentDataSet, "EnrollmentHeaderFile");

                        // Save selected subjects
                        foreach (DataGridViewRow row in EnrollmentDataGridView.SelectedRows)
                        {
                           
                            string subjectCode = row.Cells["SSFSUBJCODE"].Value.ToString();
                        
                        }

                        MessageBox.Show("Student entry saved successfully.");
                        
                        // Clear fields
                        IdNumberTextBox.Clear();
                        NameTextBox.Clear();
                        CourseTextBox.Clear();
                        YearTextBox.Clear();
                        EncoderTextBox.Clear();
                        TotalUnitsTextBox.Clear();
                        EdpCodeTextBox.Clear();
                        EnrollmentDataGridView.DataSource = null;

                    }
                    else
                    {
                        MessageBox.Show("Duplicate student ID found!");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        // Clear fields on Cancel button click
        private void CancelEntryButton_Click(object sender, EventArgs e)
        {
            // Clear fields
            IdNumberTextBox.Clear();
            NameTextBox.Clear();
            CourseTextBox.Clear();
            YearTextBox.Clear();
            EncoderTextBox.Clear();
            TotalUnitsTextBox.Clear();
            EdpCodeTextBox.Clear();
            EnrollmentDataGridView.DataSource = null;
        }
    }
}
