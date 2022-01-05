
namespace ComputerStoreManager.ChildForm
{
    partial class frmCategory
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCategory = new System.Windows.Forms.TextBox();
            this.iconBtnAdd = new FontAwesome.Sharp.IconButton();
            this.iconBtnEdit = new FontAwesome.Sharp.IconButton();
            this.iconBtnDelete = new FontAwesome.Sharp.IconButton();
            this.iconBtnReset = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.txtNameCategory = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(397, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "DANH MỤC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã danh mục:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên danh mục:";
            // 
            // txtIdCategory
            // 
            this.txtIdCategory.Location = new System.Drawing.Point(141, 24);
            this.txtIdCategory.Multiline = true;
            this.txtIdCategory.Name = "txtIdCategory";
            this.txtIdCategory.Size = new System.Drawing.Size(354, 26);
            this.txtIdCategory.TabIndex = 12;
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
            this.iconBtnAdd.Location = new System.Drawing.Point(261, 218);
            this.iconBtnAdd.Name = "iconBtnAdd";
            this.iconBtnAdd.Size = new System.Drawing.Size(94, 30);
            this.iconBtnAdd.TabIndex = 56;
            this.iconBtnAdd.Text = "Thêm";
            this.iconBtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnAdd.UseVisualStyleBackColor = false;
            this.iconBtnAdd.Click += new System.EventHandler(this.iconBtnAdd_Click);
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
            this.iconBtnEdit.Location = new System.Drawing.Point(378, 218);
            this.iconBtnEdit.Name = "iconBtnEdit";
            this.iconBtnEdit.Size = new System.Drawing.Size(92, 30);
            this.iconBtnEdit.TabIndex = 57;
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
            this.iconBtnDelete.Location = new System.Drawing.Point(506, 218);
            this.iconBtnDelete.Name = "iconBtnDelete";
            this.iconBtnDelete.Size = new System.Drawing.Size(90, 30);
            this.iconBtnDelete.TabIndex = 58;
            this.iconBtnDelete.Text = "Xóa";
            this.iconBtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnDelete.UseVisualStyleBackColor = false;
            this.iconBtnDelete.Click += new System.EventHandler(this.iconBtnDelete_Click);
            // 
            // iconBtnReset
            // 
            this.iconBtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(167)))));
            this.iconBtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnReset.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnReset.ForeColor = System.Drawing.Color.White;
            this.iconBtnReset.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.iconBtnReset.IconColor = System.Drawing.Color.White;
            this.iconBtnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnReset.IconSize = 28;
            this.iconBtnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnReset.Location = new System.Drawing.Point(618, 218);
            this.iconBtnReset.Name = "iconBtnReset";
            this.iconBtnReset.Size = new System.Drawing.Size(89, 30);
            this.iconBtnReset.TabIndex = 59;
            this.iconBtnReset.Text = "Hủy";
            this.iconBtnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnReset.UseVisualStyleBackColor = false;
            this.iconBtnReset.Click += new System.EventHandler(this.iconBtnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvCategory);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(51, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 247);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách danh mục";
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.AllowUserToAddRows = false;
            this.dtgvCategory.AllowUserToDeleteRows = false;
            this.dtgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCategory.Location = new System.Drawing.Point(3, 21);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.Size = new System.Drawing.Size(797, 223);
            this.dtgvCategory.TabIndex = 9;
            this.dtgvCategory.DoubleClick += new System.EventHandler(this.dtgvCategory_DoubleClick);
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Location = new System.Drawing.Point(141, 75);
            this.txtNameCategory.Multiline = true;
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(354, 26);
            this.txtNameCategory.TabIndex = 61;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNameCategory);
            this.groupBox2.Controls.Add(this.txtIdCategory);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(194, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 124);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 539);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iconBtnReset);
            this.Controls.Add(this.iconBtnDelete);
            this.Controls.Add(this.iconBtnEdit);
            this.Controls.Add(this.iconBtnAdd);
            this.Controls.Add(this.label3);
            this.Name = "frmCategory";
            this.Text = "frmCategory";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCategory;
        private FontAwesome.Sharp.IconButton iconBtnAdd;
        private FontAwesome.Sharp.IconButton iconBtnEdit;
        private FontAwesome.Sharp.IconButton iconBtnDelete;
        private FontAwesome.Sharp.IconButton iconBtnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private System.Windows.Forms.TextBox txtNameCategory;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}