using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerStoreManager.ChildForm
{
    public partial class frmStoreInformation : Form
    {
        SqlConnection connect = Connection.connect;

        public frmStoreInformation()
        {
            if (frmMain.UsernameLogin == "Admin")
            {
                InitializeComponent();
            }
            else
            {
                MessageBox.Show("Chỉ admin mới có thể truy cập chức năng này!");
            }
        }

        private void frmStoreInformation_Load(object sender, EventArgs e)
        {
            GetStore();
        }

        public void GetStore()
        {
            try
            {
                connect.Close();
                connect.Open();
                string query = "select IdStore, NameStore, Address, Phone, Greeting from StoreInformation";
                SqlCommand sqlCommand = new SqlCommand(query, connect);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    txtStoreName.Text = sqlDataReader["NameStore"].ToString();
                    txtPhone.Text = sqlDataReader["Phone"].ToString();
                    txtAddress.Text = sqlDataReader["Address"].ToString();
                    txtGreeting.Text = sqlDataReader["Greeting"].ToString();
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                connect.Close();
            }
        }

        public void Clear()
        {
            txtStoreName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtGreeting.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStoreName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text)
                || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtGreeting.Text))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin cửa hàng");
            }
            else
            {
                try
                {
                    using (var cmd = new SqlCommand("update StoreInformation set NameStore=@StoreName, Phone=@Phone, Address=@Address, Greeting=@Greeting where IdStore=1"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@StoreName", txtStoreName.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@Greeting", txtGreeting.Text);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Đã cập nhật thành công");
                            connect.Close();
                            Clear();
                            GetStore();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công");
                        }
                        connect.Close();
                    }
                }
                catch (Exception ex)
                {
                    connect.Close();
                    MessageBox.Show("Error Update:" + ex.Message);
                }
            }
        }
    }
}
