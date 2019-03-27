using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



// them goi thu vien firesharp vao project
// link xem cach them : https://www.youtube.com/watch?v=jZMwwZHJXJc&list=PL-BanGEyyB0TtfH1dxNdj0ImH-3AXfSdy
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace SDH
{
    public partial class frmMain : Form
    {

        //khai bao ham truyen du lieu giua cac form
        private string _message;


        //khai bao ham truyen du lieu giua cac form
        
        String tempid = "";
        String temppass = "";
        String tempname = "";
        String templevel = "";


        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "8nRfThVBUj182flmg4hA88mxFOHd9MgQY6YxsMGH",
            BasePath = "https://sdhtdmu.firebaseio.com/"
        };

        IFirebaseClient client;

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

            //kiem tra ket noi den csdl fire base co thanh cong hay khong
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                //MessageBox.Show("ket noi thanh cong!");
            }
            if (client == null)
            { MessageBox.Show("khong the ket noi csdl"); }
            //==============


            taiDULIEU(sender, e);
        }

        private async void taiDULIEU(object sender, EventArgs e)
        {

            FirebaseResponse response = await client.GetTaskAsync("Account/" + _message);
            Data oddd = response.ResultAs<Data>();

            tempid = oddd.Id;
            temppass = oddd.Password;
            tempname = oddd.Name;
            templevel = oddd.Level;
            lblReceived.Text = "Xin Chào: " + tempname + " !";

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
            frmKSYK frmYKNH = new frmKSYK();
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
