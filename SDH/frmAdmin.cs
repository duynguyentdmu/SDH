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
    public partial class frmAdmin : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "8nRfThVBUj182flmg4hA88mxFOHd9MgQY6YxsMGH",
            BasePath = "https://sdhtdmu.firebaseio.com/"
        };

        IFirebaseClient client;


        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
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
        }

        private async void btt_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Id = tbId.Text,
                Password = tbPas.Text,
                Name = tbName.Text,
                 Level = tbLv.Text
            };

            SetResponse setResponse = await client.SetTaskAsync("Account/" + tbId.Text, data);
            SetResponse response = setResponse;
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Đã Thêm tài khoản" + result.MaSv);
        }
    }
}
