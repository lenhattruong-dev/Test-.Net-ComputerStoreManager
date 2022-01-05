using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ComputerStoreManager
{
    public partial class frmLogin : Form
    {
        SqlConnection connect = Connection.connect;

        public static string Adminstractor = "";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Adminstractor = txtUsername.Text;
            string query = "select * from Account where Username = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connect);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            if (data.Rows.Count == 1)
            {
                frmMain fmain = new frmMain();
                this.Hide();
                fmain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không hợp lệ");
            }

        }
    }
}
