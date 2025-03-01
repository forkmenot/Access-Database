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
            save = new ToolStripMenuItem();
            saveTables = new ToolStripMenuItem();
            saveTStudents = new ToolStripMenuItem();
            saveTSubjects = new ToolStripMenuItem();
            saveTGrades = new ToolStripMenuItem();
            saveQueries = new ToolStripMenuItem();
            saveQSubjects = new ToolStripMenuItem();
            saveQGrades = new ToolStripMenuItem();
            btnConnection = new Button();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            flpInputs = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvDatabase).BeginInit();
            mstrpFile.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDatabase
            // 
            dgvDatabase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDatabase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDatabase.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDatabase.BackgroundColor = Color.Black;
            dgvDatabase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatabase.Location = new Point(12, 46);
            dgvDatabase.Name = "dgvDatabase";
            dgvDatabase.ReadOnly = true;
            dgvDatabase.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatabase.Size = new Size(1018, 455);
            dgvDatabase.TabIndex = 0;
            dgvDatabase.CellClick += dgvDatabase_CellClick;
            // 
            // panelDGV
            // 
            panelDGV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            loadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { load, save });
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
            load.Size = new Size(180, 24);
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
            loadTStudents.Click += loadTStudents_Click;
            // 
            // loadTSubjects
            // 
            loadTSubjects.Name = "loadTSubjects";
            loadTSubjects.Size = new Size(130, 24);
            loadTSubjects.Text = "Subjects";
            loadTSubjects.Click += loadTSubjects_Click;
            // 
            // loadTGrades
            // 
            loadTGrades.Name = "loadTGrades";
            loadTGrades.Size = new Size(130, 24);
            loadTGrades.Text = "Grades";
            loadTGrades.Click += loadTGrades_Click;
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
            loadQSubjects.Size = new Size(179, 24);
            loadQSubjects.Text = "Student Subjects";
            loadQSubjects.Click += loadQSubjects_Click;
            // 
            // loadQGrades
            // 
            loadQGrades.Name = "loadQGrades";
            loadQGrades.Size = new Size(179, 24);
            loadQGrades.Text = "Student Grades";
            loadQGrades.Click += loadQGrades_Click;
            // 
            // save
            // 
            save.DropDownItems.AddRange(new ToolStripItem[] { saveTables, saveQueries });
            save.Font = new Font("Arial Narrow", 12F);
            save.Name = "save";
            save.Size = new Size(180, 24);
            save.Text = "Save";
            // 
            // saveTables
            // 
            saveTables.DropDownItems.AddRange(new ToolStripItem[] { saveTStudents, saveTSubjects, saveTGrades });
            saveTables.Name = "saveTables";
            saveTables.Size = new Size(180, 24);
            saveTables.Text = "Table";
            // 
            // saveTStudents
            // 
            saveTStudents.Name = "saveTStudents";
            saveTStudents.Size = new Size(180, 24);
            saveTStudents.Text = "Students";
            saveTStudents.Click += saveTStudents_Click;
            // 
            // saveTSubjects
            // 
            saveTSubjects.Name = "saveTSubjects";
            saveTSubjects.Size = new Size(180, 24);
            saveTSubjects.Text = "Subjects";
            saveTSubjects.Click += saveTSubjects_Click;
            // 
            // saveTGrades
            // 
            saveTGrades.Name = "saveTGrades";
            saveTGrades.Size = new Size(180, 24);
            saveTGrades.Text = "Grades";
            saveTGrades.Click += saveTGrades_Click;
            // 
            // saveQueries
            // 
            saveQueries.DropDownItems.AddRange(new ToolStripItem[] { saveQSubjects, saveQGrades });
            saveQueries.Name = "saveQueries";
            saveQueries.Size = new Size(180, 24);
            saveQueries.Text = "Query";
            // 
            // saveQSubjects
            // 
            saveQSubjects.Name = "saveQSubjects";
            saveQSubjects.Size = new Size(180, 24);
            saveQSubjects.Text = "Student Subjects";
            saveQSubjects.Click += saveQSubjects_Click;
            // 
            // saveQGrades
            // 
            saveQGrades.Name = "saveQGrades";
            saveQGrades.Size = new Size(180, 24);
            saveQGrades.Text = "Student Grades";
            saveQGrades.Click += saveQGrades_Click;
            // 
            // btnConnection
            // 
            btnConnection.BackColor = Color.FromArgb(255, 18, 79);
            btnConnection.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnection.Location = new Point(848, 511);
            btnConnection.Name = "btnConnection";
            btnConnection.Padding = new Padding(5);
            btnConnection.Size = new Size(186, 40);
            btnConnection.TabIndex = 4;
            btnConnection.Text = "CONNECTION TEST";
            btnConnection.UseVisualStyleBackColor = false;
            btnConnection.Click += btnConnection_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(255, 0, 160);
            btnInsert.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(848, 589);
            btnInsert.Name = "btnInsert";
            btnInsert.Padding = new Padding(5);
            btnInsert.Size = new Size(90, 60);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 0, 160);
            btnDelete.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(848, 655);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(5);
            btnDelete.Size = new Size(186, 60);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 0, 160);
            btnUpdate.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(944, 589);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(5);
            btnUpdate.Size = new Size(90, 60);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // flpInputs
            // 
            flpInputs.Location = new Point(8, 511);
            flpInputs.Name = "flpInputs";
            flpInputs.Size = new Size(834, 204);
            flpInputs.TabIndex = 8;
            // 
            // AccessDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 4, 88);
            ClientSize = new Size(1042, 727);
            Controls.Add(flpInputs);
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
        private FlowLayoutPanel flpInputs;
        private ToolStripMenuItem save;
        private ToolStripMenuItem saveTables;
        private ToolStripMenuItem saveQueries;
        private ToolStripMenuItem saveTStudents;
        private ToolStripMenuItem saveTSubjects;
        private ToolStripMenuItem saveTGrades;
        private ToolStripMenuItem saveQSubjects;
        private ToolStripMenuItem saveQGrades;
    }
}
