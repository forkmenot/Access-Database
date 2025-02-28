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
    public partial class TSubjects : UserControl
    {
        public TSubjects()
        {
            InitializeComponent();

            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.FlatAppearance.BorderColor = Color.White;
            btnProfile.FlatAppearance.BorderSize = 3;
        }

        public string StudentID { get => tbxStudentID.Text; set => tbxStudentID.Text = value; }
        public string CourseNum1 { get => tbxCourseNum1.Text; set => tbxCourseNum1.Text = value; }
        public string CourseNum2 { get => tbxCourseNum2.Text; set => tbxCourseNum2.Text = value; }
        public string CourseNum3 { get => tbxCourseNum3.Text; set => tbxCourseNum3.Text = value; }
        public string CourseNum4 { get => tbxCourseNum4.Text; set => tbxCourseNum4.Text = value; }
        public string CourseNum5 { get => tbxCourseNum5.Text; set => tbxCourseNum5.Text = value; }

        public void ClearControls()
        {
            tbxStudentID.Clear();
            tbxCourseNum1.Clear();
            tbxCourseNum2.Clear();
            tbxCourseNum3.Clear();
            tbxCourseNum4.Clear();
            tbxCourseNum5.Clear();
        }
    }
}
