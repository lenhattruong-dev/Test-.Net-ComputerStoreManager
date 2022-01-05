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
    public partial class frmCategory : Form
    {
        SqlConnection connect = Connection.connect;
        public frmCategory()
        {
            InitializeComponent();
            LoadDataCategory();
        }

        private void LoadDataCategory()
        {
            string query = @"select IdCategory as 'Mã danh mục', NameCategory as 'Tên danh mục' from ProductCategory";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connect);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            dtgvCategory.DataSource = data;
            connect.Close();
        }

        public void Clear()
        {
            txtIdCategory.Clear();
            txtNameCategory.Clear();
        }

        private void iconBtnAdd_Click(object sender, EventArgs e)
        {
            string idcategory = dtgvCategory.CurrentRow.Cells[0].Value.ToString();
            string namecategory = dtgvCategory.CurrentRow.Cells[1].Value.ToString();

            if (string.IsNullOrWhiteSpace(txtNameCategory.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin danh mục");
            }
            else if (idcategory == txtIdCategory.Text || namecategory == txtNameCategory.Text)
            {
                MessageBox.Show("Danh mục sản phẩm đã tồn tại");
            }
            else
            {
                using (var cmd = new SqlCommand("insert into ProductCategory (IdCategory, NameCategory) VALUES (@IdCategory, @NameCategory)"))
                {
                    cmd.Connection = connect;
                    cmd.Parameters.AddWithValue("@IdCategory", txtIdCategory.Text);
                    cmd.Parameters.AddWithValue("@NameCategory", txtNameCategory.Text);
                    connect.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã thêm danh mục sản phẩm");
                        connect.Close();
                        Clear();
                        LoadDataCategory();
                    }
                    else
                    {
                        MessageBox.Show("Thêm danh  mục sản phẩm không thành công");
                        connect.Close();
                    }
                }
            }
        }

        private void dtgvCategory_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvCategory.CurrentRow.Index != -1)
            {
                Clear();
                txtIdCategory.Text = dtgvCategory.CurrentRow.Cells[0].Value.ToString();
                txtNameCategory.Text = dtgvCategory.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void iconBtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameCategory.Text))
            {
                MessageBox.Show("Vui lòng chọn danh mục cần thay đổi");
            }
            else
            {
                try
                {
                    using (var cmd = new SqlCommand("update ProductCategory set NameCategory=@NameCategory where IdCategory=@IdCategory"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@IdCategory", txtIdCategory.Text);
                        cmd.Parameters.AddWithValue("@NameCategory", txtNameCategory.Text);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Đã cập nhật thành công");
                            connect.Close();
                            LoadDataCategory();
                        }
                        else
                        {
                            MessageBox.Show("Lưu không thành công");
                            connect.Close();
                        }
                        connect.Close();
                    }
                }
                catch (Exception ex)
                {
                    connect.Close();
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
            Clear();
        }

        private void iconBtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa danh mục này hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (this.dtgvCategory.SelectedRows.Count > 0)
            {
                if (result == DialogResult.OK)
                {
                    if (string.IsNullOrWhiteSpace(txtIdCategory.Text))
                    {
                        MessageBox.Show("Thông tin danh mục trống");
                    }
                    else
                    {
                        try
                        {
                            using (var cmd = new SqlCommand("delete ProductCategory where IdCategory=@IdCategory"))
                            {
                                cmd.Connection = connect;
                                cmd.Parameters.AddWithValue("@IdCategory", txtIdCategory.Text);
                                connect.Open();
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Đã xóa danh mục");
                                    connect.Close();
                                    Clear();
                                    LoadDataCategory();
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
    }
}
