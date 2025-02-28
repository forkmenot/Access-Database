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

            flpInputs.Controls.Clear();
            flpInputs.Controls.Add(new TStudents());
            flpInputs.Visible = true;
        }

        private void loadTSubjects_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
            da = new OleDbDataAdapter("SELECT * FROM SubjectsEnrolled", myConn);
            ds = new DataSet();
            da.Fill(ds, "SubjectsEnrolled");
            dgvDatabase.DataSource = ds.Tables["SubjectsEnrolled"];
            myConn.Close();

            flpInputs.Controls.Clear();
            flpInputs.Controls.Add(new TSubjects());
            flpInputs.Visible = true;
        }

        private void loadTGrades_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");
            da = new OleDbDataAdapter("SELECT * FROM FinalGrade", myConn);
            ds = new DataSet();
            da.Fill(ds, "FinalGrade");
            dgvDatabase.DataSource = ds.Tables["FinalGrade"];
            myConn.Close();

            flpInputs.Controls.Clear();
            flpInputs.Controls.Add(new TGrades());
            flpInputs.Visible = true;
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

            flpInputs.Visible = false;
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

            flpInputs.Visible = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");

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
            else if (flpInputs.Controls[0] is TSubjects subjectControl)
            {
                string query = "INSERT INTO SubjectsEnrolled (StudentID, CourseNum1, CourseNum2, CourseNum3, CourseNum4, CourseNum5) VALUES (@id, @c1, @c2, @c3, @c4, @c5)";

                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("@id", subjectControl.StudentID);
                    cmd.Parameters.AddWithValue("@c1", subjectControl.CourseNum1);
                    cmd.Parameters.AddWithValue("@c2", subjectControl.CourseNum2);
                    cmd.Parameters.AddWithValue("@c3", subjectControl.CourseNum3);
                    cmd.Parameters.AddWithValue("@c4", subjectControl.CourseNum4);
                    cmd.Parameters.AddWithValue("@c5", subjectControl.CourseNum5);

                    myConn.Open();
                    cmd.ExecuteNonQuery();
                    myConn.Close();

                    MessageBox.Show("Subject record inserted!");
                    loadTSubjects_Click(sender, e);
                    subjectControl.ClearControls();
                }
            }
            else if (flpInputs.Controls[0] is TGrades gradeControl)
            {
                string query = "INSERT INTO FinalGrade (StudentID, FG1, FG2, FG3, FG4, FG5) VALUES (@id, @g1, @g2, @g3, @g4, @g5)";

                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("@id", gradeControl.StudentID);
                    cmd.Parameters.AddWithValue("@g1", gradeControl.FinalGrade1);
                    cmd.Parameters.AddWithValue("@g2", gradeControl.FinalGrade2);
                    cmd.Parameters.AddWithValue("@g3", gradeControl.FinalGrade3);
                    cmd.Parameters.AddWithValue("@g4", gradeControl.FinalGrade4);
                    cmd.Parameters.AddWithValue("@g5", gradeControl.FinalGrade5);

                    myConn.Open();
                    cmd.ExecuteNonQuery();
                    myConn.Close();

                    MessageBox.Show("Grade record inserted!");
                    loadTGrades_Click(sender, e);
                    gradeControl.ClearControls();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");

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
            else if (flpInputs.Controls[0] is TSubjects subjectControl)
            {
                string query = "UPDATE SubjectsEnrolled SET CourseNum1 = @c1, CourseNum2 = @c2, CourseNum3 = @c3, CourseNum4 = @c4, CourseNum5 = @c5 WHERE StudentID = @id";

                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("@c1", subjectControl.CourseNum1);
                    cmd.Parameters.AddWithValue("@c2", subjectControl.CourseNum2);
                    cmd.Parameters.AddWithValue("@c3", subjectControl.CourseNum3);
                    cmd.Parameters.AddWithValue("@c4", subjectControl.CourseNum4);
                    cmd.Parameters.AddWithValue("@c5", subjectControl.CourseNum5);
                    cmd.Parameters.AddWithValue("@id", subjectControl.StudentID);

                    myConn.Open();
                    cmd.ExecuteNonQuery();
                    myConn.Close();

                    MessageBox.Show("Subject record updated!");
                    loadTSubjects_Click(sender, e);
                }
            }
            else if (flpInputs.Controls[0] is TGrades gradeControl)
            {
                string query = "UPDATE FinalGrade SET FG1 = @g1, FG2 = @g2, FG3 = @g3, FG4 = @g4, FG5 = @g5 WHERE StudentID = @id";

                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("@g1", gradeControl.FinalGrade1);
                    cmd.Parameters.AddWithValue("@g2", gradeControl.FinalGrade2);
                    cmd.Parameters.AddWithValue("@g3", gradeControl.FinalGrade3);
                    cmd.Parameters.AddWithValue("@g4", gradeControl.FinalGrade4);
                    cmd.Parameters.AddWithValue("@g5", gradeControl.FinalGrade5);
                    cmd.Parameters.AddWithValue("@id", gradeControl.StudentID);

                    myConn.Open();
                    cmd.ExecuteNonQuery();
                    myConn.Close();

                    MessageBox.Show("Grade record updated!");
                    loadTGrades_Click(sender, e);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\AccessDatabase\\SchoolDatabase.accdb");

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
            else if (flpInputs.Controls[0] is TSubjects subjectControl)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "DELETE FROM SubjectsEnrolled WHERE StudentID = @id";

                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@id", subjectControl.StudentID);

                        myConn.Open();
                        cmd.ExecuteNonQuery();
                        myConn.Close();

                        MessageBox.Show("Subject record deleted!");
                        loadTSubjects_Click(sender, e);
                        subjectControl.ClearControls();
                    }
                }
            }
            else if (flpInputs.Controls[0] is TGrades gradeControl)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "DELETE FROM FinalGrade WHERE StudentID = @id";

                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@id", gradeControl.StudentID);

                        myConn.Open();
                        cmd.ExecuteNonQuery();
                        myConn.Close();

                        MessageBox.Show("Grade record deleted!");
                        loadTGrades_Click(sender, e);
                        gradeControl.ClearControls();
                    }
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
            else if (e.RowIndex >= 0 && flpInputs.Controls[0] is TSubjects subjectControl)
            {
                DataGridViewRow row = dgvDatabase.Rows[e.RowIndex];

                subjectControl.StudentID = row.Cells["StudentID"].Value.ToString();
                subjectControl.CourseNum1 = row.Cells["CourseNum1"].Value.ToString();
                subjectControl.CourseNum2 = row.Cells["CourseNum2"].Value.ToString();
                subjectControl.CourseNum3 = row.Cells["CourseNum3"].Value.ToString();
                subjectControl.CourseNum4 = row.Cells["CourseNum4"].Value.ToString();
                subjectControl.CourseNum5 = row.Cells["CourseNum5"].Value.ToString();
            }
            else if (e.RowIndex >= 0 && flpInputs.Controls[0] is TGrades gradeControl)
            {
                DataGridViewRow row = dgvDatabase.Rows[e.RowIndex];

                gradeControl.StudentID = row.Cells["StudentID"].Value.ToString();
                gradeControl.FinalGrade1 = row.Cells["FG1"].Value.ToString();
                gradeControl.FinalGrade2 = row.Cells["FG2"].Value.ToString();
                gradeControl.FinalGrade3 = row.Cells["FG3"].Value.ToString();
                gradeControl.FinalGrade4 = row.Cells["FG4"].Value.ToString();
                gradeControl.FinalGrade5 = row.Cells["FG5"].Value.ToString();
            }
        }

        private void saveTables_Click(object sender, EventArgs e)
        {
            // save tables Student, SubjectsEnrolled and FinalGrade altogether in 1 PDF
        }

        private void saveQueries_Click(object sender, EventArgs e)
        {
            // save queries StudentSubjects and Student Grades altogether in 1 PDF
        }
    }
}
