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
    public partial class frmProduct : Form
    {
        SqlConnection connect = Connection.connect;
        SqlCommand command;

        public frmProduct()
        {
            InitializeComponent();
            LoadDataProduct();
            LoadCategoryName();
        }

        public void LoadDataProduct()
        {
            string query = @"select IDProduct as 'Mã sản phẩm', NameProduct as 'Tên sản phẩm', Quantity as 'Số lượng', Price as 'Giá sản phẩm', IdCategory as 'Danh mục', CreateDate as 'Ngày', Description as 'Mô tả'from Products";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dtgvProduct.DataSource = dataTable;
            connect.Close();
        }

        public void LoadCategoryName()
        {
            string query = @"select * from ProductCategory";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connect);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            cbCategoryName.Items.Clear();
            foreach (DataRow item in data.Rows)
            {
                cbCategoryName.Items.Add(item["IdCategory"].ToString());
            }
            connect.Close();
        }

        private void iconBtnAdd_Click(object sender, EventArgs e)
        {
            string IDProduct = dtgvProduct.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrWhiteSpace(txtIDProduct.Text) || IDProduct == txtIDProduct.Text)
            {
                MessageBox.Show("Vui lòng thay đổi mã sản phẩm");
                txtIDProduct.Clear();
            }
            else
            {
                using (var cmd = new SqlCommand("insert into Products (IdProduct, NameProduct, Quantity, Price, IdCategory, Description) values (@IdProduct, @NameProduct, @Quantity, @Price, @IdCategory, @Description)"))
                {
                    cmd.Connection = connect;
                    cmd.Parameters.AddWithValue("@IdProduct", txtIDProduct.Text);
                    cmd.Parameters.AddWithValue("@NameProduct", txtNameProduct.Text);
                    cmd.Parameters.AddWithValue("@Quantity", nmQuantity.Value);
                    cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@IdCategory", cbCategoryName.Text);
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    connect.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        Clear();
                        MessageBox.Show("Đã thêm sản phẩm thành công");
                        connect.Close();
                        LoadDataProduct();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công");
                    }
                    connect.Close();
                }
            }
        }

        private void dtgvProduct_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvProduct.CurrentRow.Index != -1)
            {
                Clear();
                txtIDProduct.Text = dtgvProduct.CurrentRow.Cells[0].Value.ToString();
                txtNameProduct.Text = dtgvProduct.CurrentRow.Cells[1].Value.ToString();
                nmQuantity.Text = dtgvProduct.CurrentRow.Cells[2].Value.ToString();
                txtPrice.Text = dtgvProduct.CurrentRow.Cells[3].Value.ToString();
                cbCategoryName.Text = dtgvProduct.CurrentRow.Cells[4].Value.ToString();
                txtDescription.Text = dtgvProduct.CurrentRow.Cells[6].Value.ToString();
            }
        }

        public void Clear()
        {
            txtIDProduct.Clear();
            txtNameProduct.Clear();
            nmQuantity.ResetText();
            txtPrice.Clear();
            txtDescription.Clear();
            cbCategoryName.Text = null;
        }

        private void iconBtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDProduct.Text))
            {
                MessageBox.Show("Thông tin sản phẩm không tồn tại");
            }
            else
            {
                try
                {
                    using (var cmd = new SqlCommand("update Products set NameProduct=@NameProduct, Quantity=@Quantity, Price=@Price, IdCategory=@IdCategory, Description=@Description where IdProduct = @IdProduct"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@IdProduct", txtIDProduct.Text);
                        cmd.Parameters.AddWithValue("@NameProduct", txtNameProduct.Text);
                        cmd.Parameters.AddWithValue("@Quantity", nmQuantity.Value);
                        cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                        cmd.Parameters.AddWithValue("@IdCategory", cbCategoryName.Text);
                        cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Thông tin sản phẩm đã được cập nhật");
                            LoadDataProduct();
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật sản phẩm không thành công");
                        }
                        connect.Close();
                    }
                }
                catch (Exception ex)
                {
                    connect.Close();
                    MessageBox.Show("Error Insert:" + ex.Message);
                }
            }
        }

        private void iconBtnDelete_Click(object sender, EventArgs e)
        {
            String IDProduct = dtgvProduct.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (this.dtgvProduct.SelectedRows.Count > 0)
            {
                if (result == DialogResult.OK)
                {
                    if (string.IsNullOrWhiteSpace(txtIDProduct.Text) || IDProduct != txtIDProduct.Text)
                    {
                        MessageBox.Show("Thông tin trống: Vui lòng chọn lại sản phẩm");
                        Clear();
                    }
                    else
                    {
                        try
                        {
                            using (var cmd = new SqlCommand("delete Products where IDProduct=@IDProduct"))
                            {
                                cmd.Connection = connect;
                                cmd.Parameters.AddWithValue("@IDProduct", txtIDProduct.Text);
                                connect.Open();
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Đã xóa sản phẩm thành công");
                                    Clear();
                                    LoadDataProduct();
                                }
                                else
                                {
                                    MessageBox.Show("Xóa sản phẩm không thành công");
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
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * from Products where (IdProduct like '" + txtSearch.Text + "%' OR NameProduct like N'" + txtSearch.Text + "%' or Price like '" + txtSearch.Text + "')", connect))
                {
                    DataTable data = new DataTable("Products");
                    sqlDataAdapter.Fill(data);
                    dtgvProduct.DataSource = data;
                }
                connect.Close();
                if (dtgvProduct.Rows.Count > 0 && dtgvProduct.Rows != null)
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
                    LoadDataProduct();
                }
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show("Error Search:" + ex.Message);
            }
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
