using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

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
    }
}
