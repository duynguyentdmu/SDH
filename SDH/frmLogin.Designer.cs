namespace SDH
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_clock = new System.Windows.Forms.PictureBox();
            this.pic_open = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_clock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_open)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_clock
            // 
            this.pic_clock.Image = global::SDH.Properties.Resources.khoa1;
            this.pic_clock.Location = new System.Drawing.Point(33, 101);
            this.pic_clock.Name = "pic_clock";
            this.pic_clock.Size = new System.Drawing.Size(93, 88);
            this.pic_clock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_clock.TabIndex = 15;
            this.pic_clock.TabStop = false;
            // 
            // pic_open
            // 
            this.pic_open.Image = global::SDH.Properties.Resources.khoa;
            this.pic_open.Location = new System.Drawing.Point(33, 101);
            this.pic_open.Name = "pic_open";
            this.pic_open.Size = new System.Drawing.Size(93, 88);
            this.pic_open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_open.TabIndex = 16;
            this.pic_open.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(181, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "TÀI KHOẢN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(185, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "MẬT KHẨU";
            // 
            // btExit
            // 
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Location = new System.Drawing.Point(403, 151);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(175, 37);
            this.btExit.TabIndex = 12;
            this.btExit.Text = "THOÁT";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btLogin
            // 
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.Green;
            this.btLogin.Location = new System.Drawing.Point(183, 151);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(214, 37);
            this.btLogin.TabIndex = 11;
            this.btLogin.Text = "ĐĂNG NHẬP";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.DarkGray;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbPass.ForeColor = System.Drawing.Color.Black;
            this.tbPass.Location = new System.Drawing.Point(298, 101);
            this.tbPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbPass.Multiline = true;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(280, 37);
            this.tbPass.TabIndex = 10;
            this.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.DarkGray;
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbId.ForeColor = System.Drawing.Color.Black;
            this.tbId.Location = new System.Drawing.Point(298, 60);
            this.tbId.Margin = new System.Windows.Forms.Padding(2);
            this.tbId.Multiline = true;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(280, 37);
            this.tbId.TabIndex = 8;
            this.tbId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "PHÒNG ĐÀO TẠO SAU ĐẠI HỌC";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SDH.Properties.Resources.Untitled_23;
            this.ClientSize = new System.Drawing.Size(599, 252);
            this.Controls.Add(this.pic_clock);
            this.Controls.Add(this.pic_open);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_clock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_open)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_clock;
        private System.Windows.Forms.PictureBox pic_open;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
    }
}

