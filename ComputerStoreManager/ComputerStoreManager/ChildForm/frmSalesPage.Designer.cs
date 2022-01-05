
namespace ComputerStoreManager.ChildForm
{
    partial class frmSalesPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.cbIdProduct = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.iconBtnAdd = new FontAwesome.Sharp.IconButton();
            this.iconBtnThanhtoan = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iconBtnHuy = new FontAwesome.Sharp.IconButton();
            this.iconBtnEdit = new FontAwesome.Sharp.IconButton();
            this.iconBtnDelete = new FontAwesome.Sharp.IconButton();
            this.lbTT = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IdOrderDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrderDetail)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(35, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã sản phẩm:";
            // 
            // cbIdProduct
            // 
            this.cbIdProduct.FormattingEnabled = true;
            this.cbIdProduct.Location = new System.Drawing.Point(153, 26);
            this.cbIdProduct.Name = "cbIdProduct";
            this.cbIdProduct.Size = new System.Drawing.Size(219, 21);
            this.cbIdProduct.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(35, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số lượng:";
            // 
            // nmQuantity
            // 
            this.nmQuantity.Location = new System.Drawing.Point(149, 75);
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(222, 20);
            this.nmQuantity.TabIndex = 58;
            this.nmQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(35, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 59;
            this.label1.Text = "Giá:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(147, 121);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(222, 26);
            this.txtTotal.TabIndex = 60;
            // 
            // iconBtnAdd
            // 
            this.iconBtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(167)))));
            this.iconBtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnAdd.ForeColor = System.Drawing.Color.White;
            this.iconBtnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconBtnAdd.IconColor = System.Drawing.Color.White;
            this.iconBtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAdd.IconSize = 28;
            this.iconBtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAdd.Location = new System.Drawing.Point(17, 36);
            this.iconBtnAdd.Name = "iconBtnAdd";
            this.iconBtnAdd.Size = new System.Drawing.Size(173, 36);
            this.iconBtnAdd.TabIndex = 61;
            this.iconBtnAdd.Text = "Thêm sản phẩm";
            this.iconBtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnAdd.UseVisualStyleBackColor = false;
            this.iconBtnAdd.Click += new System.EventHandler(this.iconBtnAdd_Click);
            // 
            // iconBtnThanhtoan
            // 
            this.iconBtnThanhtoan.BackColor = System.Drawing.Color.DodgerBlue;
            this.iconBtnThanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnThanhtoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnThanhtoan.ForeColor = System.Drawing.Color.White;
            this.iconBtnThanhtoan.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.iconBtnThanhtoan.IconColor = System.Drawing.Color.White;
            this.iconBtnThanhtoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnThanhtoan.IconSize = 35;
            this.iconBtnThanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnThanhtoan.Location = new System.Drawing.Point(465, 209);
            this.iconBtnThanhtoan.Name = "iconBtnThanhtoan";
            this.iconBtnThanhtoan.Size = new System.Drawing.Size(166, 48);
            this.iconBtnThanhtoan.TabIndex = 62;
            this.iconBtnThanhtoan.Text = "Thanh toán";
            this.iconBtnThanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnThanhtoan.UseVisualStyleBackColor = false;
            this.iconBtnThanhtoan.Click += new System.EventHandler(this.iconBtnThanhtoan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvOrderDetail);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 255);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dtgvOrderDetail
            // 
            this.dtgvOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOrderDetail,
            this.IdProduct,
            this.Quantity,
            this.IdOrder,
            this.Total});
            this.dtgvOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvOrderDetail.Location = new System.Drawing.Point(3, 20);
            this.dtgvOrderDetail.Name = "dtgvOrderDetail";
            this.dtgvOrderDetail.Size = new System.Drawing.Size(844, 232);
            this.dtgvOrderDetail.TabIndex = 0;
            this.dtgvOrderDetail.DoubleClick += new System.EventHandler(this.dtgvOrderDetail_DoubleClick);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Red;
            this.lbTotal.Location = new System.Drawing.Point(783, 225);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(19, 21);
            this.lbTotal.TabIndex = 64;
            this.lbTotal.Text = "0";
            this.lbTotal.Click += new System.EventHandler(this.lbTotal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(35, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 65;
            this.label2.Text = "Khách hàng:";
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Location = new System.Drawing.Point(145, 171);
            this.txtIdCustomer.Multiline = true;
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(222, 26);
            this.txtIdCustomer.TabIndex = 66;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.iconBtnHuy);
            this.groupBox2.Controls.Add(this.iconBtnAdd);
            this.groupBox2.Controls.Add(this.iconBtnEdit);
            this.groupBox2.Controls.Add(this.iconBtnDelete);
            this.groupBox2.Location = new System.Drawing.Point(465, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 163);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            // 
            // iconBtnHuy
            // 
            this.iconBtnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(167)))));
            this.iconBtnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnHuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnHuy.ForeColor = System.Drawing.Color.White;
            this.iconBtnHuy.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.iconBtnHuy.IconColor = System.Drawing.Color.White;
            this.iconBtnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnHuy.IconSize = 28;
            this.iconBtnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnHuy.Location = new System.Drawing.Point(209, 96);
            this.iconBtnHuy.Name = "iconBtnHuy";
            this.iconBtnHuy.Size = new System.Drawing.Size(170, 35);
            this.iconBtnHuy.TabIndex = 55;
            this.iconBtnHuy.Text = "Hủy";
            this.iconBtnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnHuy.UseVisualStyleBackColor = false;
            this.iconBtnHuy.Click += new System.EventHandler(this.iconBtnHuy_Click);
            // 
            // iconBtnEdit
            // 
            this.iconBtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(167)))));
            this.iconBtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnEdit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnEdit.ForeColor = System.Drawing.Color.White;
            this.iconBtnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconBtnEdit.IconColor = System.Drawing.Color.White;
            this.iconBtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnEdit.IconSize = 28;
            this.iconBtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnEdit.Location = new System.Drawing.Point(17, 96);
            this.iconBtnEdit.Name = "iconBtnEdit";
            this.iconBtnEdit.Size = new System.Drawing.Size(173, 35);
            this.iconBtnEdit.TabIndex = 72;
            this.iconBtnEdit.Text = "Sửa";
            this.iconBtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnEdit.UseVisualStyleBackColor = false;
            this.iconBtnEdit.Click += new System.EventHandler(this.iconBtnEdit_Click);
            // 
            // iconBtnDelete
            // 
            this.iconBtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(167)))));
            this.iconBtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnDelete.ForeColor = System.Drawing.Color.White;
            this.iconBtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconBtnDelete.IconColor = System.Drawing.Color.White;
            this.iconBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnDelete.IconSize = 28;
            this.iconBtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnDelete.Location = new System.Drawing.Point(209, 37);
            this.iconBtnDelete.Name = "iconBtnDelete";
            this.iconBtnDelete.Size = new System.Drawing.Size(170, 35);
            this.iconBtnDelete.TabIndex = 71;
            this.iconBtnDelete.Text = "Xóa";
            this.iconBtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnDelete.UseVisualStyleBackColor = false;
            this.iconBtnDelete.Click += new System.EventHandler(this.iconBtnDelete_Click);
            // 
            // lbTT
            // 
            this.lbTT.AutoSize = true;
            this.lbTT.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTT.Location = new System.Drawing.Point(673, 223);
            this.lbTT.Name = "lbTT";
            this.lbTT.Size = new System.Drawing.Size(85, 21);
            this.lbTT.TabIndex = 68;
            this.lbTT.Text = "Tổng tiền:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbIdProduct);
            this.groupBox3.Controls.Add(this.txtIdCustomer);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.nmQuantity);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Location = new System.Drawing.Point(30, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 234);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(685, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 70;
            // 
            // IdOrderDetail
            // 
            this.IdOrderDetail.FillWeight = 12.69036F;
            this.IdOrderDetail.HeaderText = "ID";
            this.IdOrderDetail.Name = "IdOrderDetail";
            // 
            // IdProduct
            // 
            this.IdProduct.FillWeight = 121.8274F;
            this.IdProduct.HeaderText = "Mã sản phẩm";
            this.IdProduct.Name = "IdProduct";
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 121.8274F;
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            // 
            // IdOrder
            // 
            this.IdOrder.FillWeight = 121.8274F;
            this.IdOrder.HeaderText = "Mã hóa đơn";
            this.IdOrder.Name = "IdOrder";
            // 
            // Total
            // 
            this.Total.FillWeight = 121.8274F;
            this.Total.HeaderText = "Thành tiền";
            this.Total.Name = "Total";
            // 
            // frmSalesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 539);
            this.Controls.Add(this.iconBtnThanhtoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbTT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSalesPage";
            this.Text = "frmSalesPage";
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrderDetail)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbIdProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private FontAwesome.Sharp.IconButton iconBtnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvOrderDetail;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private FontAwesome.Sharp.IconButton iconBtnThanhtoan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconBtnDelete;
        private FontAwesome.Sharp.IconButton iconBtnEdit;
        private FontAwesome.Sharp.IconButton iconBtnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}