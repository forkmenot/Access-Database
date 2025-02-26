namespace AccessDatabase
{
    partial class AccessDatabase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvDatabase = new DataGridView();
            panelDGV = new Panel();
            mstrpFile = new MenuStrip();
            loadToolStripMenuItem = new ToolStripMenuItem();
            load = new ToolStripMenuItem();
            loadTable = new ToolStripMenuItem();
            loadTStudents = new ToolStripMenuItem();
            loadTSubjects = new ToolStripMenuItem();
            loadTGrades = new ToolStripMenuItem();
            loadQuery = new ToolStripMenuItem();
            loadQSubjects = new ToolStripMenuItem();
            loadQGrades = new ToolStripMenuItem();
            btnConnection = new Button();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatabase).BeginInit();
            mstrpFile.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDatabase
            // 
            dgvDatabase.BackgroundColor = Color.Black;
            dgvDatabase.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvDatabase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatabase.Location = new Point(12, 46);
            dgvDatabase.Name = "dgvDatabase";
            dgvDatabase.Size = new Size(1018, 455);
            dgvDatabase.TabIndex = 0;
            // 
            // panelDGV
            // 
            panelDGV.BackColor = Color.FromArgb(255, 18, 79);
            panelDGV.BorderStyle = BorderStyle.FixedSingle;
            panelDGV.Location = new Point(8, 42);
            panelDGV.Name = "panelDGV";
            panelDGV.Size = new Size(1026, 463);
            panelDGV.TabIndex = 1;
            // 
            // mstrpFile
            // 
            mstrpFile.BackColor = Color.FromArgb(255, 0, 160);
            mstrpFile.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mstrpFile.Items.AddRange(new ToolStripItem[] { loadToolStripMenuItem });
            mstrpFile.Location = new Point(0, 0);
            mstrpFile.Name = "mstrpFile";
            mstrpFile.Padding = new Padding(5, 5, 0, 5);
            mstrpFile.Size = new Size(1042, 34);
            mstrpFile.TabIndex = 3;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { load });
            loadToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(50, 24);
            loadToolStripMenuItem.Text = "FILE";
            // 
            // load
            // 
            load.DropDownItems.AddRange(new ToolStripItem[] { loadTable, loadQuery });
            load.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            load.Name = "load";
            load.Size = new Size(108, 24);
            load.Text = "Load";
            // 
            // loadTable
            // 
            loadTable.DropDownItems.AddRange(new ToolStripItem[] { loadTStudents, loadTSubjects, loadTGrades });
            loadTable.Name = "loadTable";
            loadTable.Size = new Size(114, 24);
            loadTable.Text = "Table";
            // 
            // loadTStudents
            // 
            loadTStudents.Name = "loadTStudents";
            loadTStudents.Size = new Size(130, 24);
            loadTStudents.Text = "Students";
            // 
            // loadTSubjects
            // 
            loadTSubjects.Name = "loadTSubjects";
            loadTSubjects.Size = new Size(130, 24);
            loadTSubjects.Text = "Subjects";
            // 
            // loadTGrades
            // 
            loadTGrades.Name = "loadTGrades";
            loadTGrades.Size = new Size(130, 24);
            loadTGrades.Text = "Grades";
            // 
            // loadQuery
            // 
            loadQuery.DropDownItems.AddRange(new ToolStripItem[] { loadQSubjects, loadQGrades });
            loadQuery.Name = "loadQuery";
            loadQuery.Size = new Size(114, 24);
            loadQuery.Text = "Query";
            // 
            // loadQSubjects
            // 
            loadQSubjects.Name = "loadQSubjects";
            loadQSubjects.Size = new Size(130, 24);
            loadQSubjects.Text = "Subjects";
            // 
            // loadQGrades
            // 
            loadQGrades.Name = "loadQGrades";
            loadQGrades.Size = new Size(130, 24);
            loadQGrades.Text = "Grades";
            // 
            // btnConnection
            // 
            btnConnection.BackColor = Color.FromArgb(255, 18, 79);
            btnConnection.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnection.Location = new Point(874, 511);
            btnConnection.Name = "btnConnection";
            btnConnection.Padding = new Padding(5);
            btnConnection.Size = new Size(160, 40);
            btnConnection.TabIndex = 4;
            btnConnection.Text = "CONNECTION TEST";
            btnConnection.UseVisualStyleBackColor = false;
            btnConnection.Click += btnConnection_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(255, 0, 160);
            btnInsert.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(874, 583);
            btnInsert.Name = "btnInsert";
            btnInsert.Padding = new Padding(5);
            btnInsert.Size = new Size(160, 40);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 0, 160);
            btnDelete.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(874, 629);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(5);
            btnDelete.Size = new Size(160, 40);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 0, 160);
            btnUpdate.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(874, 675);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(5);
            btnUpdate.Size = new Size(160, 40);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // AccessDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 4, 88);
            ClientSize = new Size(1042, 727);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(btnConnection);
            Controls.Add(dgvDatabase);
            Controls.Add(panelDGV);
            Controls.Add(mstrpFile);
            Name = "AccessDatabase";
            Load += AccessDatabase_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatabase).EndInit();
            mstrpFile.ResumeLayout(false);
            mstrpFile.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatabase;
        private Panel panelDGV;
        private MenuStrip mstrpFile;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem load;
        private ToolStripMenuItem loadTable;
        private ToolStripMenuItem loadTStudents;
        private ToolStripMenuItem loadTSubjects;
        private ToolStripMenuItem loadTGrades;
        private ToolStripMenuItem loadQuery;
        private ToolStripMenuItem loadQSubjects;
        private ToolStripMenuItem loadQGrades;
        private Button btnConnection;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
    }
}
