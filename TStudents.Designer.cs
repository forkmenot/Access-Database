namespace AccessDatabase
{
    partial class TStudents
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TStudents));
            lblID = new Label();
            lblLN = new Label();
            lblFN = new Label();
            lblC = new Label();
            lnYL = new Label();
            tbxStudentID = new TextBox();
            tbxLastName = new TextBox();
            tbxFirstName = new TextBox();
            tbxCourse = new TextBox();
            tbxYearLevel = new TextBox();
            btnProfile = new Button();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            lblID.ForeColor = Color.White;
            lblID.Location = new Point(219, 30);
            lblID.Name = "lblID";
            lblID.Size = new Size(87, 20);
            lblID.TabIndex = 0;
            lblID.Text = "STUDENT ID";
            // 
            // lblLN
            // 
            lblLN.AutoSize = true;
            lblLN.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            lblLN.ForeColor = Color.White;
            lblLN.Location = new Point(219, 120);
            lblLN.Name = "lblLN";
            lblLN.Size = new Size(85, 20);
            lblLN.TabIndex = 1;
            lblLN.Text = "LAST NAME";
            // 
            // lblFN
            // 
            lblFN.AutoSize = true;
            lblFN.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            lblFN.ForeColor = Color.White;
            lblFN.Location = new Point(219, 155);
            lblFN.Name = "lblFN";
            lblFN.Size = new Size(89, 20);
            lblFN.TabIndex = 2;
            lblFN.Text = "FIRST NAME";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            lblC.ForeColor = Color.White;
            lblC.Location = new Point(501, 120);
            lblC.Name = "lblC";
            lblC.Size = new Size(64, 20);
            lblC.TabIndex = 3;
            lblC.Text = "COURSE";
            // 
            // lnYL
            // 
            lnYL.AutoSize = true;
            lnYL.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            lnYL.ForeColor = Color.White;
            lnYL.Location = new Point(501, 155);
            lnYL.Name = "lnYL";
            lnYL.Size = new Size(91, 20);
            lnYL.TabIndex = 4;
            lnYL.Text = "YEAR LEVEL";
            // 
            // tbxStudentID
            // 
            tbxStudentID.Font = new Font("Arial Narrow", 12F);
            tbxStudentID.Location = new Point(317, 27);
            tbxStudentID.Name = "tbxStudentID";
            tbxStudentID.Size = new Size(156, 26);
            tbxStudentID.TabIndex = 5;
            // 
            // tbxLastName
            // 
            tbxLastName.Font = new Font("Arial Narrow", 12F);
            tbxLastName.Location = new Point(317, 117);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(156, 26);
            tbxLastName.TabIndex = 6;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Font = new Font("Arial Narrow", 12F);
            tbxFirstName.Location = new Point(317, 152);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(156, 26);
            tbxFirstName.TabIndex = 7;
            // 
            // tbxCourse
            // 
            tbxCourse.Font = new Font("Arial Narrow", 12F);
            tbxCourse.Location = new Point(599, 117);
            tbxCourse.Name = "tbxCourse";
            tbxCourse.Size = new Size(156, 26);
            tbxCourse.TabIndex = 8;
            // 
            // tbxYearLevel
            // 
            tbxYearLevel.Font = new Font("Arial Narrow", 12F);
            tbxYearLevel.Location = new Point(599, 152);
            tbxYearLevel.Name = "tbxYearLevel";
            tbxYearLevel.Size = new Size(156, 26);
            tbxYearLevel.TabIndex = 9;
            // 
            // btnProfile
            // 
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.Location = new Point(10, 12);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(180, 180);
            btnProfile.TabIndex = 14;
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // TStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 4, 88);
            Controls.Add(btnProfile);
            Controls.Add(tbxYearLevel);
            Controls.Add(tbxCourse);
            Controls.Add(tbxFirstName);
            Controls.Add(tbxLastName);
            Controls.Add(tbxStudentID);
            Controls.Add(lnYL);
            Controls.Add(lblC);
            Controls.Add(lblFN);
            Controls.Add(lblLN);
            Controls.Add(lblID);
            Name = "TStudents";
            Size = new Size(834, 204);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblLN;
        private Label lblFN;
        private Label lblC;
        private Label lnYL;
        private TextBox tbxStudentID;
        private TextBox tbxLastName;
        private TextBox tbxFirstName;
        private TextBox tbxCourse;
        private TextBox tbxYearLevel;
        private Button btnProfile;
    }
}
