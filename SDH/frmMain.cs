using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDH
{
    public partial class frmMain : Form
    {

        //khai bao ham truyen du lieu giua cac form
        private string _message;


        public frmMain()
        {
            InitializeComponent();
        }

        // ham nhan du lieu tu form login thong qua Properties
        // huong dan : https://aptech.vn/kien-thuc-tin-hoc/c-truyen-du-lieu-giua-cac-form.html
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }


        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void frmCNFB_Click(object sender, EventArgs e)
        {
            frmCNFB frmCNFB = new frmCNFB();
            this.Hide();
            frmCNFB.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblReceived.Text = _message;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin();
            this.Hide();
            frmAdmin.ShowDialog();
        }

        private void btnQLHS_Click(object sender, EventArgs e)
        {
            frmQLHS frmQLHS = new frmQLHS();
            this.Hide();
            frmQLHS.ShowDialog();
        }

        private void btnYKNH_Click(object sender, EventArgs e)
        {
            frmYKNH frmYKNH = new frmYKNH();
            this.Hide();
            frmYKNH.ShowDialog();
        }

        

        private void frmPL_Click(object sender, EventArgs e)
        {
            frmPL frmPL = new frmPL();
            this.Hide();
            frmPL.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
