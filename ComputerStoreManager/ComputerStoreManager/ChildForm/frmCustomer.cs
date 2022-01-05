using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerStoreManager.ChildForm
{
    public partial class frmCustomer : Form
    {
        SqlConnection connect = Connection.connect;
        SqlDataAdapter sqlDataAdapter;
        DataSet data;

        public frmCustomer()
        {
            InitializeComponent();
            LoadDataCustomer();
        }

        private void Clear()
        {
            txtIdCustomer.Clear();
            txtNameCustomer.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone.Clear();

        }

        private void LoadDataCustomer()
        {
            string query = @"select IdCustomer as 'Mã khách hàng', NameCustomer as 'Tên khách hàng', Address as 'Địa chỉ', Phone as 'Phone', Email as 'Email' from Customers";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connect);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            dtgvCustomer.DataSource = data;
            connect.Close();
        }

        private void iconBtnAdd_Click(object sender, EventArgs e)
        {
            string IdCustomer = dtgvCustomer.CurrentRow.Cells[0].Value.ToString();

            if (string.IsNullOrWhiteSpace(txtIdCustomer.Text) || string.IsNullOrWhiteSpace(txtNameCustomer.Text)
                || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (IdCustomer == txtIdCustomer.Text)
                {
                    MessageBox.Show("Thông tin khách hàng đã tồn tại");
                    
                }
                else
                {
                    using (var cmd = new SqlCommand("insert into Customers(IdCustomer, NameCustomer, Phone, Address, Email) values (@IdCustomer, @NameCustomer, @Phone, @Address, @Email)"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@IdCustomer", txtIdCustomer.Text);
                        cmd.Parameters.AddWithValue("@NameCustomer", txtNameCustomer.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Thêm khách hàng thành công");
                            connect.Close();
                            Clear();
                            LoadDataCustomer();
                        }
                        else
                        {
                            MessageBox.Show("Thêm khách hàng không thành công");
                            connect.Close();
                        }
                        connect.Close();
                    }
                }
            }
           
        }

        private void dtgvCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvCustomer.CurrentRow.Index != -1)
            {
                txtIdCustomer.Text = dtgvCustomer.CurrentRow.Cells[0].Value.ToString();
                txtNameCustomer.Text = dtgvCustomer.CurrentRow.Cells[1].Value.ToString();
                txtPhone.Text = dtgvCustomer.CurrentRow.Cells[2].Value.ToString();
                txtAddress.Text = dtgvCustomer.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = dtgvCustomer.CurrentRow.Cells[4].Value.ToString();
               
            }
        }

        private void iconBtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdCustomer.Text))
            {
                MessageBox.Show("Thông tin khách hàng trống");
            }
            else
            {
                try
                {
                    using (var cmd = new SqlCommand("update Customers set NameCustomer=@NameCustomer, Phone=@Phone, Address=@Address, Email=@Email where IdCustomer=@IdCustomer"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@IdCustomer", txtIdCustomer.Text);
                        cmd.Parameters.AddWithValue("@NameCustomer", txtNameCustomer.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Cập nhật thành công");
                            connect.Close();
                            Clear();
                            LoadDataCustomer();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật Không thành công");
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

        private void iconBtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa khách hàng hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (this.dtgvCustomer.SelectedRows.Count > 0)
            {
                if (result == DialogResult.OK)
                {
                    if (string.IsNullOrWhiteSpace(txtIdCustomer.Text))
                    {
                        MessageBox.Show("Mời bạn chọn lại khách hàng");
                    }
                    else
                    {
                        try
                        {
                            using (var cmd = new SqlCommand("delete Customers where IdCustomer=@IdCustomer"))
                            {
                                cmd.Connection = connect;
                                cmd.Parameters.AddWithValue("@IdCustomer", txtIdCustomer.Text);
                                connect.Open();
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Đã xóa khách hàng thành công");
                                    connect.Close();
                                    Clear();
                                    LoadDataCustomer();
                                }
                                else
                                {
                                    MessageBox.Show("Xóa không thành công");
                                }
                                connect.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            connect.Close();
                            MessageBox.Show("Error Delete:" + ex.Message);
                        }
                    }
                }
                Clear();
            }
        }

        private void iconBtnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * from Customers where (IdCustomer like '" + txtSearch.Text + "%' OR NameCustomer like N'" + txtSearch.Text + "%' or Phone like '" + txtSearch.Text + "')", connect))
                {
                    DataTable data = new DataTable("Customers");
                    sqlDataAdapter.Fill(data);
                    dtgvCustomer.DataSource = data;
                }
                connect.Close();
                if (dtgvCustomer.Rows.Count > 0 && dtgvCustomer.Rows != null)
                {
                    lbResult.Text = "Đã tìm thấy kết quả";
                }
                else
                {
                    lbResult.Text = "Không tìm thấy";
                }
                if (txtSearch.Text == "")
                {
                    lbResult.Text = "";
                    LoadDataCustomer();
                }
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show("Error Search:" + ex.Message);
            }
        }
    }
}
