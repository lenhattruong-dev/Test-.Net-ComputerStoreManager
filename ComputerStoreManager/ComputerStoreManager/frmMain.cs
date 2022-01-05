using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using ComputerStoreManager.ChildForm;

namespace ComputerStoreManager
{
    public partial class frmMain : Form
    {
        SqlConnection connect = Connection.connect;

        public static string UsernameLogin = ""; 

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public frmMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
           
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color = Color.FromArgb(52, 152, 219);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true; 
                leftBorderBtn.BringToFront();

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(52, 152, 219);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlPageChild.Controls.Add(childForm);
            pnlPageChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void ibtnMain_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            OpenChildForm(new frmSalesPage());
        }

        private void ibtnOrders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            OpenChildForm(new frmBillOrders());
        }

        private void ibtnCategoryProduct_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            OpenChildForm(new frmCategory());
        }
        private void ibtnProduct_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            OpenChildForm(new frmProduct());
        }

        private void ibtnStoreInformation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            OpenChildForm(new frmStoreInformation());
        }

        private void ibtnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            OpenChildForm(new frmCustomer());
        }

        private void iconPicLogo_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();

        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        //Kéo cái biểu mẫu
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ibtnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            if (result == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void ibtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ibtnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void ibtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand sqlCommand = new SqlCommand();
                SqlDataReader sqlDataReader;
                sqlCommand.CommandText = "select Username, Name from Account where Username = '" +frmLogin.Adminstractor + "'";
                sqlCommand.Connection = connect;
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    lbUserLogin.Text = sqlDataReader.GetString(1);
                    UsernameLogin = sqlDataReader.GetString(1);
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        
    }
}
