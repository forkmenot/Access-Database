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
            dgvDatabase.DefaultCellStyle.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular);
            dgvDatabase.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular);
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
            ds = new DataSet();
            myConn.Open();
            MessageBox.Show("Connected successfully!");
            myConn.Close();
        }

        private void loadTStudents_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
            da = new OleDbDataAdapter("SELECT * FROM Student", myConn);
            ds = new DataSet();
            da.Fill(ds, "Student");
            dgvDatabase.DataSource = ds.Tables["Student"];
            myConn.Close();
        }

        private void loadTSubjects_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
            da = new OleDbDataAdapter("SELECT * FROM SubjectsEnrolled", myConn);
            ds = new DataSet();
            da.Fill(ds, "SubjectsEnrolled");
            dgvDatabase.DataSource = ds.Tables["SubjectsEnrolled"];
            myConn.Close();
        }

        private void loadTGrades_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
            da = new OleDbDataAdapter("SELECT * FROM FinalGrade", myConn);
            ds = new DataSet();
            da.Fill(ds, "FinalGrade");
            dgvDatabase.DataSource = ds.Tables["FinalGrade"];
            myConn.Close();
        }

        private void loadQSubjects_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
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
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
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
            /*string query = "INSERT INTO Student (StudentID, LastName, FirstName, Course, YearLvl) VALUES (?, ?, ?, ?, ?)";
            cmd = new OleDbCommand(query, myConn);

            cmd.Parameters.AddWithValue("?", tbxStudentID.Text);
            cmd.Parameters.AddWithValue("?", tbxLastName.Text);
            cmd.Parameters.AddWithValue("?", tbxFirstName.Text);
            cmd.Parameters.AddWithValue("?", tbxCourse.Text);
            cmd.Parameters.AddWithValue("?", tbxYearLvl.Text);

            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();

            MessageBox.Show("Record inserted successfully!");
            loadTStudents_Click(sender, e);*/
            // depending on the loaded table/query, tbx controls will ask input to add new record

            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
        }
    }
}
