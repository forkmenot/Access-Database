using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessDatabase
{
    public partial class TStudents : UserControl
    {
        public TStudents()
        {
            InitializeComponent();

            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.FlatAppearance.BorderColor = Color.White;
            btnProfile.FlatAppearance.BorderSize = 3;
        }

        public string StudentID { get => tbxStudentID.Text; set => tbxStudentID.Text = value; }
        public string LastName { get => tbxLastName.Text; set => tbxLastName.Text = value; }
        public string FirstName { get => tbxFirstName.Text; set => tbxFirstName.Text = value; }
        public string Course { get => tbxCourse.Text; set => tbxCourse.Text = value; }
        public string YearLevel { get => tbxYearLevel.Text; set => tbxYearLevel.Text = value; }

        public void ClearControls()
        {
            tbxStudentID.Clear();
            tbxLastName.Clear();
            tbxFirstName.Clear();
            tbxCourse.Clear();
            tbxYearLevel.Clear();
        }
    }
}
