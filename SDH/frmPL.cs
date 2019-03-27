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
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "8nRfThVBUj182flmg4hA88mxFOHd9MgQY6YxsMGH",
            BasePath = "https://sdhtdmu.firebaseio.com/"
        };

        IFirebaseClient client;

        String URL = null;


        public frmPL()
        {
            InitializeComponent();
        }

        private void frmPL_Load(object sender, EventArgs e)
        {
            webSDTLTK5.Hide();
            btnSDTLTK5.Show();

        }

        private void btnSDTLTK5_Click(object sender, EventArgs e)
        {
            webSDTLTK5.Show();
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


            frmPLWS Child = new frmPLWS();
            Child.Message = URL;
            this.Hide();
            Child.ShowDialog();
        }
    }
}
