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
    public partial class frmKSYKWS : Form
    {
        private string _message;
        public frmKSYKWS()
        {
            InitializeComponent();
        }
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private void frmKSYKWS_Load(object sender, EventArgs e)
        {
            this.webKSYK.Navigate(_message);
        }

        private void frmKSYKWS_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmKSYK frmKSYK = new frmKSYK();
            this.Hide();
            frmKSYK.ShowDialog();
        }
    }
}
