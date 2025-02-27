using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace AccessDatabase
{
    public partial class AccessDatabase : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        public AccessDatabase()
        {
            InitializeComponent();
        }

        private void AccessDatabase_Load(object sender, EventArgs e)
        {
            dgvDatabase.DefaultCellStyle.Font = new Font("Arial Narrow", 12F, FontStyle.Regular);
            dgvDatabase.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Narrow", 12F, FontStyle.Regular);
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            //myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\MS_Access\\SchoolDatabaseX.accdb");
            ds = new DataSet();
            myConn.Open();
            MessageBox.Show("Connected successfully!");
            myConn.Close();
        }

        private void loadTStudents_Click(object sender, EventArgs e)
        {
            //myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\MS_Access\\SchoolDatabaseX.accdb");
            da = new OleDbDataAdapter("SELECT * FROM Student", myConn);
            ds = new DataSet();
            da.Fill(ds, "Student");
            dgvDatabase.DataSource = ds.Tables["Student"];
            myConn.Close();

            flpInputs.Controls.Clear();
            flpInputs.Controls.Add(new TStudents());
        }

        private void loadTSubjects_Click(object sender, EventArgs e)
        {
            //myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\MS_Access\\SchoolDatabaseX.accdb");
            da = new OleDbDataAdapter("SELECT * FROM SubjectsEnrolled", myConn);
            ds = new DataSet();
            da.Fill(ds, "SubjectsEnrolled");
            dgvDatabase.DataSource = ds.Tables["SubjectsEnrolled"];
            myConn.Close();
        }

        private void loadTGrades_Click(object sender, EventArgs e)
        {
            //myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\MS_Access\\SchoolDatabaseX.accdb");
            da = new OleDbDataAdapter("SELECT * FROM FinalGrade", myConn);
            ds = new DataSet();
            da.Fill(ds, "FinalGrade");
            dgvDatabase.DataSource = ds.Tables["FinalGrade"];
            myConn.Close();
        }

        private void loadQSubjects_Click(object sender, EventArgs e)
        {
            //myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\MS_Access\\SchoolDatabaseX.accdb");
            string query = @"SELECT Student.StudentID, Student.LastName, Student.FirstName, 
                             SubjectsEnrolled.CourseNum1, SubjectsEnrolled.CourseNum2, SubjectsEnrolled.CourseNum3, SubjectsEnrolled.CourseNum4, SubjectsEnrolled.CourseNum5 
                             FROM Student INNER JOIN SubjectsEnrolled ON Student.StudentID = SubjectsEnrolled.StudentID";
            da = new OleDbDataAdapter(query, myConn);
            ds = new DataSet();
            da.Fill(ds, "StudentSubjects");
            dgvDatabase.DataSource = ds.Tables["StudentSubjects"];
            myConn.Close();
        }

        private void loadQGrades_Click(object sender, EventArgs e)
        {
            //myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\MS_Access\\SchoolDatabaseX.accdb");
            string query = @"SELECT Student.StudentID, Student.LastName, Student.FirstName, 
                             FinalGrade.FG1, FinalGrade.FG2, FinalGrade.FG3, FinalGrade.FG4, FinalGrade.FG5 
                             FROM (Student INNER JOIN SubjectsEnrolled ON Student.StudentID = SubjectsEnrolled.StudentID) 
                             INNER JOIN FinalGrade ON SubjectsEnrolled.StudentID = FinalGrade.StudentID";
            da = new OleDbDataAdapter(query, myConn);
            ds = new DataSet();
            da.Fill(ds, "StudentGrades");
            dgvDatabase.DataSource = ds.Tables["StudentGrades"];
            myConn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\MS_Access\\SchoolDatabaseX.accdb");

            if (flpInputs.Controls[0] is TStudents studentControl)
            {
                string query = "INSERT INTO Student (StudentID, LastName, FirstName, Course, YearLevel) VALUES (@id, @last, @first, @course, @year)";

                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("@id", studentControl.StudentID);
                    cmd.Parameters.AddWithValue("@last", studentControl.LastName);
                    cmd.Parameters.AddWithValue("@first", studentControl.FirstName);
                    cmd.Parameters.AddWithValue("@course", studentControl.Course);
                    cmd.Parameters.AddWithValue("@year", studentControl.YearLevel);

                    myConn.Open();
                    cmd.ExecuteNonQuery();
                    myConn.Close();

                    MessageBox.Show("Student record inserted!");
                    loadTStudents_Click(sender, e);
                    studentControl.ClearControls();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\MS_Access\\SchoolDatabaseX.accdb");

            if (flpInputs.Controls[0] is TStudents studentControl)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "DELETE FROM Student WHERE StudentID = @id";

                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@id", studentControl.StudentID);

                        myConn.Open();
                        cmd.ExecuteNonQuery();
                        myConn.Close();

                        MessageBox.Show("Student record deleted!");
                        loadTStudents_Click(sender, e);
                        studentControl.ClearControls();
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\MS_Access\\SchoolDatabaseX.accdb");

            if (flpInputs.Controls[0] is TStudents studentControl)
            {
                string query = "UPDATE Student SET LastName = @last, FirstName = @first, Course = @course, YearLevel = @year WHERE StudentID = @id";

                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("@last", studentControl.LastName);
                    cmd.Parameters.AddWithValue("@first", studentControl.FirstName);
                    cmd.Parameters.AddWithValue("@course", studentControl.Course);
                    cmd.Parameters.AddWithValue("@year", studentControl.YearLevel);
                    cmd.Parameters.AddWithValue("@id", studentControl.StudentID);

                    myConn.Open();
                    cmd.ExecuteNonQuery();
                    myConn.Close();

                    MessageBox.Show("Student record updated!");
                    loadTStudents_Click(sender, e);
                }
            }
        }

        private void dgvDatabase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && flpInputs.Controls[0] is TStudents studentControl)
            {
                DataGridViewRow row = dgvDatabase.Rows[e.RowIndex];

                studentControl.StudentID = row.Cells["StudentID"].Value.ToString();
                studentControl.LastName = row.Cells["LastName"].Value.ToString();
                studentControl.FirstName = row.Cells["FirstName"].Value.ToString();
                studentControl.Course = row.Cells["Course"].Value.ToString();
                studentControl.YearLevel = row.Cells["YearLevel"].Value.ToString();
            }
        }
    }
}
