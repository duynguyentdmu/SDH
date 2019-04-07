using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//them thu vien cua fire base
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace SDH
{
    public partial class frmCNFB : Form
    {
        DataTable dt = new DataTable();

        // doan nay mo ta lien ket den co do du lieu(luu y vi tri dat doan nay)
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "8nRfThVBUj182flmg4hA88mxFOHd9MgQY6YxsMGH",
            BasePath = "https://sdhtdmu.firebaseio.com/"
        };
        IFirebaseClient client;
        private object data;

        // ket thuc mo ta



        public frmCNFB()
        {
            InitializeComponent();
        }

        private void frmCNFB_Load(object sender, EventArgs e)
        {
            picConn.Hide();
            picLost.Hide();
            //kiem tra ket noi den csdl fire base co thanh cong hay khong
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                picConn.Show();
                picLost.Hide();
                //MessageBox.Show("ket noi thanh cong!");
            }
            if (client == null)
            {
                picConn.Hide();
                picLost.Show();
                MessageBox.Show("khong the ket noi csdl");
            }
            //==============

            dt.Columns.Add("Idt");
            dt.Columns.Add("Text");
            dgvTest.DataSource = dt;
        }

        private async void btt_Click(object sender, EventArgs e)
        {
            // private async void btLogin_ClickAsync(object sender, EventArgs e)

            var data = new Data
            {
                MaSv = tbMasv.Text,
                Ten = tbTen.Text,
                Tuoi = tbTuoi.Text
            };

            SetResponse setResponse = await client.SetTaskAsync("Information/" + tbMasv.Text, data);
            SetResponse response = setResponse;
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Đã Thêm " + result.MaSv);
        }

        private async void btx_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteTaskAsync("Information/" + tbMasv.Text);
            MessageBox.Show("Đã xóa " + tbMasv.Text);
        }

        private async void bts_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                MaSv = tbMasv.Text,
                Ten = tbTen.Text,
                Tuoi = tbTuoi.Text
            };
            FirebaseResponse response = await client.UpdateTaskAsync("Information/" + tbMasv.Text, data);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Đã cập nhật mã " + result.MaSv);
        }

        private async void btget_Click(object sender, EventArgs e)
        {
            //chuc nang load du lieu theo ma sinh vien
            FirebaseResponse response = await client.GetTaskAsync("Information/" + tbMasv.Text);
            Data obj = response.ResultAs<Data>();

            tbMasv.Text = obj.MaSv;
            tbTen.Text = obj.Ten;
            tbTuoi.Text = obj.Tuoi;
            MessageBox.Show("lay du lieu thanh cong!");
        }

        private async void btxtt_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteTaskAsync("Information");
            MessageBox.Show("xoa toan bo goc");
        }

        private async void btTtm_Click(object sender, EventArgs e)
        {
            //chuc nang nay la chuc nang tu viet
            //muc dich la de them thu muc vao trong cay thu muc cua firebase
            //chuc nang nay tam thoi van dang phat trien, chua hoan chinh (loi te le)


            //FirebaseResponse response = await client.DeleteTaskAsync("ads");
            // private async void btLogin_ClickAsync(object sender, EventArgs e)

            var data = new Data
            {
                //cau truc
                // ten truong khai bao trong file data = ten textbox
                MaSv = tbMasv.Text,
                Ten = tbTen.Text,
                Tuoi = tbTuoi.Text
            };

            FirebaseResponse response = await client.SetTaskAsync("sad/", tbMasv.Text);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Đã Thêm " + result.MaSv);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.ShowDialog();
        }

        private async void Insert_Click(object sender, EventArgs e)
        {





            FirebaseResponse resp = await client.GetTaskAsync("Counter/node");
            Counter_Class get = resp.ResultAs<Counter_Class>();
            // MessageBox.Show(get.cnt);


            var datagr = new Data
            {
                Idt = (Convert.ToInt32(get.cnt) + 1).ToString(),
                Text = txtText.Text
            };

            SetResponse setResponse = await client.SetTaskAsync("grid/" + txtIdt.Text, datagr);
       
            SetResponse response = setResponse;

            Data result = response.ResultAs<Data>();
            MessageBox.Show("Đã Thêm mã: " + result.Idt);

            var obj = new Counter_Class
            {
                cnt = datagr.Idt
            };

            SetResponse response1 = await client.SetTaskAsync("Counter/node", obj);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            fcexport();
        }
        private async void fcexport()
        {
            int i = 0;

            FirebaseResponse respExport1 = await client.GetTaskAsync("Counter/node");
            Counter_Class objExport1 = respExport1.ResultAs<Counter_Class>();
            int cnt = Convert.ToInt32(objExport1.cnt);
            MessageBox.Show(cnt.ToString());
            while (true)
            {
                if (i == cnt)
                {
                    break;
                }
                i++;
                try
                {
                    FirebaseResponse respExport2 = await client.GetTaskAsync("grid/" + i);
                    Data objExport2 = respExport2.ResultAs<Data>();

                    DataRow row = dt.NewRow();
                    row["Idt"] = objExport2.Idt;
                    row["Text"] = objExport2.Text;

                    dt.Rows.Add(row);


                }
                catch
                {

                }

            }
            MessageBox.Show("Done!!!");
        }
    }
}
