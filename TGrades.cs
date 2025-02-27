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
    public partial class TGrades : UserControl
    {
        public TGrades()
        {
            InitializeComponent();
        }

        public string StudentID { get => tbxStudentID.Text; set => tbxStudentID.Text = value; }
        public string FinalGrade1 { get => tbxFinalGrade1.Text; set => tbxFinalGrade1.Text = value; }
        public string FinalGrade2 { get => tbxFinalGrade2.Text; set => tbxFinalGrade2.Text = value; }
        public string FinalGrade3 { get => tbxFinalGrade3.Text; set => tbxFinalGrade3.Text = value; }
        public string FinalGrade4 { get => tbxFinalGrade4.Text; set => tbxFinalGrade4.Text = value; }
        public string FinalGrade5 { get => tbxFinalGrade5.Text; set => tbxFinalGrade5.Text = value; }

        public void ClearControls()
        {
            tbxStudentID.Clear();
            tbxFinalGrade1.Clear();
            tbxFinalGrade2.Clear();
            tbxFinalGrade3.Clear();
            tbxFinalGrade4.Clear();
            tbxFinalGrade5.Clear();
        }
    }
}
