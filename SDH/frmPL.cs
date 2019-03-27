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
    public partial class frmPL : Form
    {
        //cau hinh firebase
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "8nRfThVBUj182flmg4hA88mxFOHd9MgQY6YxsMGH",
            BasePath = "https://sdhtdmu.firebaseio.com/"
        };

        IFirebaseClient client;
        //==========================


        //khai bao bien de luu tru url web
        String URL = null;


        public frmPL()
        {
            InitializeComponent();
        }

        private void frmPL_Load(object sender, EventArgs e)
        {

            btnSDTLTK5.Show();
            grSDT.Hide();

        }

        private void btnSDTLTK5_Click(object sender, EventArgs e)
        {

            URL = "https://drive.google.com/file/d/1aX2XTJBNHcAyJ4ul1wqpPXePbKncFT4y/view";
            cmdSend_Click(sender, e);
        }

        private void btnSDTLTK34_Click(object sender, EventArgs e)
        {
            URL = "https://drive.google.com/file/d/1CtoYvnG-D2g2O5LxPOOIlCrO39J7cJ_N/view?usp=sharing";
            cmdSend_Click(sender, e);
        }

        private void btnSDTLTK12_Click(object sender, EventArgs e)
        {
            URL = "https://drive.google.com/file/d/1fzUioF7f2kabuRAKFh9O9aWX5Yn6zNhO/view?usp=sharing";
            //this.webSDTLTK5.Navigate("http://www.microsoft.com");
            cmdSend_Click(sender, e);
        }


        private async void cmdSend_Click(object sender, EventArgs e)
        {
            frmPLWS frmPLWS = new frmPLWS();
            frmPLWS.Message = URL;
            this.Hide();
            frmPLWS.ShowDialog();
        }

        private void frmPL_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnSDTLT_Click(object sender, EventArgs e)
        {
            grSDT.Show();
            //them chu thich
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.ShowDialog();
        }
    }
}
