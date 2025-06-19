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
    public partial class SubjectEntryForm : Form
    {
        // Connection string to the Access database
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Talisik\OneDrive\文档\School Works\APPSDEV22.accdb";

        public SubjectEntryForm()
        {
            InitializeComponent();
            Load += SubjectEntryForm_Load;
        }

        private void SubjectEntryForm_Load(object sender, EventArgs e)
        {
            // Combo box items with display text and stored value
            var offerings = new Dictionary<int, string>()
            {
                {1, "1 - First Sem"},
                {2, "2 - Second Sem"},
                {3, "3 - Summer"}
            };

            OfferingComboBox.DataSource = new BindingSource(offerings, null);
            OfferingComboBox.DisplayMember = "Value";
            OfferingComboBox.ValueMember = "Key";
            OfferingComboBox.SelectedIndex = -1; // no selection by default
        }

        private void LoadSubjectData()
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM [SUBJECTFILE]", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                SubjectDataGridView.DataSource = dt;
            }
        }

        private void SaveEntryButton_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection subjectConnection = new OleDbConnection(connectionString);

                OleDbDataAdapter subjectAdapter = new OleDbDataAdapter("SELECT * FROM [SUBJECTFILE]", subjectConnection);
                OleDbCommandBuilder studentBuilder = new OleDbCommandBuilder(subjectAdapter);

                DataSet subjectDataSet = new DataSet();
                subjectAdapter.Fill(subjectDataSet, "SubjectFile");
                SubjectDataGridView.DataSource = subjectDataSet.Tables["SubjectFile"];

                // Format DataGridView Columns
                SubjectDataGridView.Columns["SFSUBJCODE"].HeaderText = "Subject Code";
                SubjectDataGridView.Columns["SFSUBJDESC"].HeaderText = "Description";
                SubjectDataGridView.Columns["SFSUBJUNITS"].HeaderText = "Units";
                SubjectDataGridView.Columns["SFSUBJREGOFRNG"].HeaderText = "Offering";
                SubjectDataGridView.Columns["SFSUBJCATEGORY"].HeaderText = "Category";
                SubjectDataGridView.Columns["SFSUBJSTATUS"].HeaderText = "Status";
                SubjectDataGridView.Columns["SFSUBJCOURSECODE"].HeaderText = "Course Code";
                SubjectDataGridView.Columns["SFSUBJCURRCODE"].HeaderText = "Curriculum Code";

                /*Primary Key Setup*/
                DataColumn[] subjectKeyColumn = new DataColumn[2];
                subjectKeyColumn[0] = subjectDataSet.Tables["SubjectFile"].Columns["SFSUBJCODE"];
                subjectKeyColumn[1] = subjectDataSet.Tables["SubjectFile"].Columns["SFSUBJCOURSECODE"];
                subjectDataSet.Tables["SubjectFile"].PrimaryKey = subjectKeyColumn;

                string[] searchValues = new string[2];
                searchValues[0] = SubjectCodeTextBox.Text;
                searchValues[1] = CourseCodeTextBox.Text;

                DataRow findRow = subjectDataSet.Tables["SubjectFile"].Rows.Find(searchValues);
                if (findRow == null)
                {
                    DataRow subjectRow = subjectDataSet.Tables["SubjectFile"].NewRow();
                    subjectRow["SFSUBJCODE"] = SubjectCodeTextBox.Text;
                    subjectRow["SFSUBJDESC"] = DescriptionTextBox.Text;
                    subjectRow["SFSUBJUNITS"] = UnitsTextBox.Text;

                    // Save the selected key (1, 2, or 3) as integer to Database
                    if (OfferingComboBox.SelectedItem is KeyValuePair<int, string> selectedOffering)
                    {
                        subjectRow["SFSUBJREGOFRNG"] = selectedOffering.Key;
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid offering.");
                        return;
                    }

                    subjectRow["SFSUBJCATEGORY"] = CourseCodeTextBox.Text;
                    subjectRow["SFSUBJSTATUS"] = "AC";
                    subjectRow["SFSUBJCOURSECODE"] = CourseCodeTextBox.Text;
                    subjectRow["SFSUBJCURRCODE"] = CurriculumTextBox.Text;

                    subjectDataSet.Tables["SubjectFile"].Rows.Add(subjectRow);
                    subjectAdapter.Update(subjectDataSet, "SubjectFile"); // Commit to DB

                    // Re-fetch the inserted row from DB to ensure full data
                    using (OleDbConnection conn = new OleDbConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT * FROM SUBJECTFILE WHERE SFSUBJCODE = ? AND SFSUBJCOURSECODE = ?";
                        OleDbCommand cmd = new OleDbCommand(query, conn);
                        cmd.Parameters.AddWithValue("?", SubjectCodeTextBox.Text);
                        cmd.Parameters.AddWithValue("?", CourseCodeTextBox.Text);

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable result = new DataTable();
                        adapter.Fill(result);

                        SubjectDataGridView.DataSource = result; 
                    }

                    MessageBox.Show("Entries Recorded");

                    // Handle Pre-Requisite or Co-Requisite
                    if (PreReqRadioButton.Checked || CoReqRadioButton.Checked)
                    {
                        OleDbDataAdapter preReqAdapter = new OleDbDataAdapter("SELECT * FROM [SUBJECTPREQFILE]", subjectConnection);
                        OleDbCommandBuilder preReqBuilder = new OleDbCommandBuilder(preReqAdapter);

                        DataSet preReqDataSet = new DataSet();
                        preReqAdapter.Fill(preReqDataSet, "SubjectPreqFile");

                        DataRow preReqRow = preReqDataSet.Tables["SubjectPreqFile"].NewRow();
                        preReqRow["SUBJCODE"] = SubjectCodeTextBox.Text;
                        preReqRow["SUBJPRECODE"] = RequisiteSubjectTextBox.Text;
                        preReqRow["SUBJCATEGORY"] = PreReqRadioButton.Checked ? "PR" : "CR";

                        preReqDataSet.Tables["SubjectPreqFile"].Rows.Add(preReqRow);
                        preReqAdapter.Update(preReqDataSet, "SubjectPreqFile");

                        MessageBox.Show("Requisite subject saved.");
                    }

                    // Clear fields
                    SubjectCodeTextBox.Clear();
                    DescriptionTextBox.Clear();
                    UnitsTextBox.Clear();
                    OfferingComboBox.SelectedIndex = -1;
                    CategoryComboBox.SelectedIndex = -1;
                    CourseCodeTextBox.Clear();
                    CurriculumTextBox.Clear();
                    SubjectDataGridView.DataSource = null;
                    RequisiteSubjectTextBox.Clear();
                    PreReqRadioButton.Checked = false;
                    CoReqRadioButton.Checked = false;
                    SubjectCodeTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Duplicate Entries found!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        //Clear when Cancel button is clicked
        private void CancelEntryButton_Click(object sender, EventArgs e)
        {
            SubjectCodeTextBox.Clear();
            DescriptionTextBox.Clear();
            UnitsTextBox.Clear();
            OfferingComboBox.SelectedIndex = -1;
            CategoryComboBox.SelectedIndex = -1;
            CourseCodeTextBox.Clear();
            CurriculumTextBox.Clear();
            RequisiteSubjectTextBox.Clear();
            PreReqRadioButton.Checked = false;
            CoReqRadioButton.Checked = false;
            SubjectCodeTextBox.Focus();
        }
    }
}
