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
    public partial class frmSalesPage : Form
    {
        SqlConnection connect = Connection.connect;
        string Id;
        int Quantt;
        int index;
        string IdProductEdit;
        int QuantityEdit;

        public frmSalesPage()
        {
            InitializeComponent();
            LoadDataIdProduct();
        }
        
        public void LoadDataIdProduct()
        {
            string query = @"select * from Products";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connect);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            cbIdProduct.Items.Clear();
            foreach (DataRow item in data.Rows)
            {  
                cbIdProduct.Items.Add(item["IdProduct"].ToString());
            }
            connect.Close();
        }

        public string IdOrders()
        {
            connect.Open();
            string query = "select max(IdOrder) from OrderDetails";
            SqlCommand cmd = new SqlCommand(query, connect);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            string IDOrders = i.ToString();
            connect.Close();
            return IDOrders;
        }

        private void iconBtnAdd_Click(object sender, EventArgs e)
        {
            bool found = false;

            if (dtgvOrderDetail.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgvOrderDetail.Rows)
                {
                    if (Convert.ToString(row.Cells[1].Value) == cbIdProduct.Text)
                    {
                        row.Cells[2].Value = (int.Parse(nmQuantity.Value.ToString()) + Convert.ToInt16(row.Cells[2].Value.ToString()));
                        row.Cells[4].Value = (double.Parse(txtTotal.Text) + Convert.ToDouble(row.Cells[4].Value.ToString()));
                        found = true;
                    }
                }
                if (!found)
                {
                    dtgvOrderDetail.Rows.Add("", cbIdProduct.Text, nmQuantity.Value, IdOrders(), txtTotal.Text);
                }
                ClearInformation();
            }
            else
            {
                dtgvOrderDetail.Rows.Add("", cbIdProduct.Text, nmQuantity.Value, IdOrders(), txtTotal.Text);
            }
           

            double tongtien = 0;
            for (int i = 0; i < dtgvOrderDetail.Rows.Count; i++)
            {
                tongtien += Convert.ToDouble(dtgvOrderDetail.Rows[i].Cells[4].Value);
            }
            lbTotal.Text = tongtien.ToString("###,###");
        
            try
            {
                using (var updatequantity = new SqlCommand("update Products set Quantity = Quantity - '" + nmQuantity.Value +"' where IdProduct =  '" + cbIdProduct.Text + "';"))
                {
                    updatequantity.Connection = connect;
                    connect.Open();
                    if (updatequantity.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã Update");
                    }
                    else
                    {
                        MessageBox.Show("Update không thành công");
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


        private void iconBtnThanhtoan_Click(object sender, EventArgs e)
        {
                string Total = lbTotal.Text;

                DialogResult result = MessageBox.Show("Bạn có muốn thanh toán hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                if (string.IsNullOrWhiteSpace(txtIdCustomer.Text))
                {
                    MessageBox.Show("Bạn hãy nhập thông tin khách hàng vào");
                }
                else
                {
                    using (var cmd = new SqlCommand("insert into Orders(IdOrder, IdCustomer, SalesPerson, Total) values (@IdOrder, @IdCustomer, @SalesPerson, @Total)"))
                    {
                        cmd.Connection = connect;
                        connect.Close();
                        cmd.Parameters.AddWithValue("@IdCustomer", txtIdCustomer.Text);
                        cmd.Parameters.AddWithValue("@IdOrder", long.Parse(IdOrders()));
                        cmd.Parameters.AddWithValue("@SalesPerson", frmMain.UsernameLogin);
                        cmd.Parameters.AddWithValue("@Total", Total);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Thêm thành công trong bảng Orders");
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công");
                        }
                        connect.Close();
                    }


                    foreach (DataGridViewRow item in dtgvOrderDetail.Rows)
                    {

                        try
                        {
                            using (var cmd = new SqlCommand("insert into OrderDetails(IdProduct, Quantity, IdOrder) values (@IdProduct, @Quantity, @IdOrder)"))
                            {
                                cmd.Connection = connect;
                                cmd.Parameters.AddWithValue("@IdProduct", item.Cells[1].Value.ToString());
                                cmd.Parameters.AddWithValue("@Quantity", item.Cells[2].Value.ToString());
                                cmd.Parameters.AddWithValue("@IdOrder", item.Cells[3].Value.ToString());
                                connect.Open();
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Thêm thành công");
                                    Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Thêm không thành công");

                                }
                            }
                        }
                        catch (Exception ex)
                        {
                           
                        }
                        connect.Close();
                    }
                }
                
         
            }
        }
      
        private void iconBtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (this.dtgvOrderDetail.SelectedRows.Count > 0)
            {
                if (result == DialogResult.OK)
                {
                    foreach (DataGridViewRow item in this.dtgvOrderDetail.SelectedRows)
                    {
                        DataGridViewRow row = dtgvOrderDetail.Rows[item.Index];
                        Id = row.Cells[1].Value.ToString();
                        Quantt = Convert.ToInt32(row.Cells[2].Value.ToString());
                        dtgvOrderDetail.Rows.RemoveAt(item.Index);
                    }

                    //Pass Quantity
                    try
                    {
                        using (var editcong = new SqlCommand("update Products set Quantity = Quantity + '" + Quantt + "' where IdProduct = '" + Id + "'"))
                        {
                            editcong.Connection = connect;
                            connect.Open();
                            if (editcong.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Đã Update");
                                Clear();
                            }
                            else
                            {
                                MessageBox.Show("Update không thành công");

                            }
                            connect.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Update" + ex.Message);
                    }
                }
            }
            
        }

        public void ClearInformation()
        {
            txtIdCustomer.Clear();
            txtTotal.Clear();
            nmQuantity.Value = 1;
            cbIdProduct.Text = "";
           
        }

        public void Clear()
        {
            txtIdCustomer.Clear();
            txtTotal.Clear();
            nmQuantity.Value = 1;
            cbIdProduct.Text = "";
            lbTotal.Text = "0";
            dtgvOrderDetail.Rows.Clear();
            dtgvOrderDetail.Refresh();
        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

        }

        private void iconBtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbIdProduct.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần thay đổi");
            }
            else
            {
                //Pass Quantity Product
                using (var edit = new SqlCommand("update Products set Quantity = Quantity + '" + QuantityEdit + "' where IdProduct='" + IdProductEdit + "'"))
                {
                    edit.Connection = connect;
                    connect.Open();
                    if (edit.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã Update");
                    }
                    else
                    {
                        MessageBox.Show("Update không thành công");
                    }
                    connect.Close();
                }
                
                DataGridViewRow rownew = dtgvOrderDetail.Rows[index];
                rownew.Cells[1].Value = cbIdProduct.Text;
                rownew.Cells[2].Value = nmQuantity.Text;
                rownew.Cells[4].Value = txtTotal.Text;
 
                // - Quantity Product
                using (var edittru = new SqlCommand("update Products set Quantity = Quantity - '" + nmQuantity.Value + "' where IdProduct ='" + cbIdProduct.Text + "'"))
                {
                    edittru.Connection = connect;
                    connect.Open();
                    if (edittru.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã Update");
                    }
                    else
                    {
                        MessageBox.Show("Update không thành công");
                    }
                    connect.Close();
                }
            }
            ClearInformation();
        }

        private void dtgvOrderDetail_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvOrderDetail.CurrentRow.Index != -1)
            {
                ClearInformation();
                cbIdProduct.Text = dtgvOrderDetail.CurrentRow.Cells[1].Value.ToString();
                nmQuantity.Text = dtgvOrderDetail.CurrentRow.Cells[2].Value.ToString();
                txtTotal.Text = dtgvOrderDetail.CurrentRow.Cells[4].Value.ToString();
                IdProductEdit = dtgvOrderDetail.CurrentRow.Cells[1].Value.ToString();
                QuantityEdit = Convert.ToInt32(dtgvOrderDetail.CurrentRow.Cells[2].Value.ToString());
            }
            else
            {
                MessageBox.Show("Không có dữ liệu");
            }
        }

        private void iconBtnHuy_Click(object sender, EventArgs e)
        {
            ClearInformation();
        }
    }
}
