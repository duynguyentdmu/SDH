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
    public partial class frmKSYK : Form
    {
        public frmKSYK()
        {
            InitializeComponent();
        }

        //https://docs.google.com/spreadsheets/d/125LITKiPcy-kHGB9Eb1K-CQLtKqF97j7aJbeA9c0OL8/edit?usp=sharing
        String URL = null;

        private void KSYK_Load(object sender, EventArgs e)
        {

        }

        private void KSYK_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.ShowDialog();
        }

        private void btnTQYKNH_Click(object sender, EventArgs e)
        {
            // tong quat y kien nguoi hoc
            URL = "https://docs.google.com/spreadsheets/d/125LITKiPcy-kHGB9Eb1K-CQLtKqF97j7aJbeA9c0OL8/edit?usp=sharing";
            cmdSend_Click(sender, e);
        }
        private void cmdSend_Click(object sender, EventArgs e)
        {
            frmKSYKWS frmKSYKWS = new frmKSYKWS();
            frmKSYKWS.Message = URL;
            this.Hide();
            frmKSYKWS.ShowDialog();
        }

        private void btnPTYKNH_Click(object sender, EventArgs e)
        {
            //phan tich y kien nguoi hoc
            URL = "https://docs.google.com/forms/d/1-bQoQ5qos0qH8fX2hSj9tGfdrOA6LEiYbEgCE3fXt_8/edit#responses";
            cmdSend_Click(sender, e);
        }
    }
}
