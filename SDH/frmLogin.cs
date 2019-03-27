using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


// them goi thu vien firesharp vao project
// link xem cach them : https://www.youtube.com/watch?v=jZMwwZHJXJc&list=PL-BanGEyyB0TtfH1dxNdj0ImH-3AXfSdy
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace SDH
{
    public partial class frmLogin : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "8nRfThVBUj182flmg4hA88mxFOHd9MgQY6YxsMGH",
            BasePath = "https://sdhtdmu.firebaseio.com/"
        };

        IFirebaseClient client;

        public frmLogin()
        {
            InitializeComponent();
        }


        private void btExit_Click(object sender, EventArgs e)
        {
            // thoat chuong trinh
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Bạn có muốn thoát chương trình hay không?", "THÔNG BÁO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (a == DialogResult.OK) { Application.Exit(); }
            if (a == DialogResult.Cancel) { tbId.Focus(); }
            //Application.Exit();
        }

        private async void btLogin_Click(object sender, EventArgs e)
        {
          


            //chuc nang load du lieu theo ma sinh vien
            FirebaseResponse response = await client.GetTaskAsync("Account/" + tbId.Text);
            Data obj = response.ResultAs<Data>();


            //lay thong tin dang nhap
            //khai bao bien chua du lieu get tu firebase ve
            String tempid = obj.Id;
            String temppass = obj.Password;
            String tempname = obj.Name;
            String templevel = obj.Level;



            if (tbId.Text == tempid)
            {
                if (tbPass.Text == temppass)// dang nhap thanh cong
                {
                   
                    cmdSend_Click(sender, e);
                    //code lam mau 
                    pic_clock.Hide();
                    pic_open.Show();
                    //
                    //test thong bao dang nhap thanh cong// MessageBox.Show("Đăng nhập thành công", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //Thread.Sleep(1000);
                    
                    
                    //frmMain frmMain = new frmMain();
                    //this.Hide();
                    //frmMain.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Sai tên mật khẩu", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else {
                MessageBox.Show("Sai tên đăng nhập", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
           //MessageBox.Show("lay du lieu thanh cong!");










            // private async void btLogin_ClickAsync(object sender, EventArgs e)

            //var data = new Data
            //{
            //    Id = tbId.Text,
            //    Password = tbPass.Text
            //};


            //SetResponse setResponse = await client.SetTaskAsync("Information/" + tbId.Text, data);
            //SetResponse response = setResponse;
            //Data result = response.ResultAs<Data>();

            //MessageBox.Show("Data Inserted " + result.Id);

        }


        //ham gui gia tri qua form main(dung de gui ten nguoi dung)
        private async void cmdSend_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetTaskAsync("Account/" + tbId.Text);
            Data obss = response.ResultAs<Data>();



            String temp = obss.Id;

            frmMain Child = new frmMain();
            Child.Message = temp;
            this.Hide();
            Child.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pic_clock.Show();
            pic_open.Hide();
            tbId.Focus();
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



        //code them tai khoan
        //private async void button1_Click(object sender, EventArgs e)
        //{
        //    var data = new Data
        //    {
        //        Id = tbId.Text,
        //        Password = tbPass.Text

        //    };

        //    SetResponse setResponse = await client.SetTaskAsync("Account/" + tbId.Text, data);
        //    SetResponse response = setResponse;
        //    Data result = response.ResultAs<Data>();
        //    MessageBox.Show("Đã Thêm tài khoản" + result.MaSv);
        //}
    }
}
