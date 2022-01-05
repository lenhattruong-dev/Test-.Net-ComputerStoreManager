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
    public partial class frmBillOrders : Form
    {
        SqlConnection connect = Connection.connect;
        public frmBillOrders()
        {
            InitializeComponent();
            LoadDataBillOrders();
        }

        public void LoadDataBillOrders()
        {
            string query = @"select Orders.IdOrder as 'Mã hóa đơn', Products.IdProduct as 'Mã sản phẩm', Products.NameProduct as 'Tên sản phẩm', Orders.Total as 'Tổng tiền', Orders.CreateDate as 'Ngày lập', Orders.SalesPerson as 'Người bán', Orders.IdCustomer as 'Mã khách hàng', 
                           OrderDetails.Quantity as 'Số lượng' from OrderDetails Join Orders on OrderDetails.IdOrder = Orders.IdOrder
                           Join Products on OrderDetails.IdProduct = Products.IdProduct";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dtgvBillOrders.DataSource = dataTable;
            connect.Close();

        }

    }
}
