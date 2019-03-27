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
    public partial class frmPLWS : Form
    {
        private string _message;
        public frmPLWS()
        {
            InitializeComponent();
        }




        private void frmPLWS_Load(object sender, EventArgs e)
        {

            this.webPLS.Navigate(_message);
        }
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private void frmPLWS_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPL frmPL = new frmPL();
            this.Hide();
            frmPL.ShowDialog();
        }
    }
}
