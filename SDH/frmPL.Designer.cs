namespace SDH
{
    partial class frmPL
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
            this.webSDTLTK5 = new System.Windows.Forms.WebBrowser();
            this.btnSDTLTK5 = new System.Windows.Forms.Button();
            this.btnSDTLTK34 = new System.Windows.Forms.Button();
            this.btnSDTLTK12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webSDTLTK5
            // 
            this.webSDTLTK5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webSDTLTK5.Location = new System.Drawing.Point(0, 0);
            this.webSDTLTK5.MinimumSize = new System.Drawing.Size(20, 20);
            this.webSDTLTK5.Name = "webSDTLTK5";
            this.webSDTLTK5.Size = new System.Drawing.Size(800, 450);
            this.webSDTLTK5.TabIndex = 0;
            this.webSDTLTK5.Url = new System.Uri("https://drive.google.com/file/d/1aX2XTJBNHcAyJ4ul1wqpPXePbKncFT4y/view", System.UriKind.Absolute);
            // 
            // btnSDTLTK5
            // 
            this.btnSDTLTK5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSDTLTK5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSDTLTK5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDTLTK5.ForeColor = System.Drawing.Color.Indigo;
            this.btnSDTLTK5.Location = new System.Drawing.Point(12, 22);
            this.btnSDTLTK5.Name = "btnSDTLTK5";
            this.btnSDTLTK5.Size = new System.Drawing.Size(319, 68);
            this.btnSDTLTK5.TabIndex = 11;
            this.btnSDTLTK5.Text = "SỐ ĐIỆN THOẠI LỚP TRƯỞNG K5";
            this.btnSDTLTK5.UseVisualStyleBackColor = true;
            this.btnSDTLTK5.Click += new System.EventHandler(this.btnSDTLTK5_Click);
            // 
            // btnSDTLTK34
            // 
            this.btnSDTLTK34.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSDTLTK34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSDTLTK34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDTLTK34.ForeColor = System.Drawing.Color.Indigo;
            this.btnSDTLTK34.Location = new System.Drawing.Point(12, 96);
            this.btnSDTLTK34.Name = "btnSDTLTK34";
            this.btnSDTLTK34.Size = new System.Drawing.Size(319, 68);
            this.btnSDTLTK34.TabIndex = 11;
            this.btnSDTLTK34.Text = "SỐ ĐIỆN THOẠI LỚP TRƯỞNG K3 - K4";
            this.btnSDTLTK34.UseVisualStyleBackColor = true;
            this.btnSDTLTK34.Click += new System.EventHandler(this.btnSDTLTK34_Click);
            // 
            // btnSDTLTK12
            // 
            this.btnSDTLTK12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSDTLTK12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSDTLTK12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDTLTK12.ForeColor = System.Drawing.Color.Indigo;
            this.btnSDTLTK12.Location = new System.Drawing.Point(12, 170);
            this.btnSDTLTK12.Name = "btnSDTLTK12";
            this.btnSDTLTK12.Size = new System.Drawing.Size(319, 68);
            this.btnSDTLTK12.TabIndex = 11;
            this.btnSDTLTK12.Text = "SỐ ĐIỆN THOẠI LỚP TRƯỞNG K1 - K2";
            this.btnSDTLTK12.UseVisualStyleBackColor = true;
            this.btnSDTLTK12.Click += new System.EventHandler(this.btnSDTLTK12_Click);
            // 
            // frmPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSDTLTK12);
            this.Controls.Add(this.btnSDTLTK34);
            this.Controls.Add(this.btnSDTLTK5);
            this.Controls.Add(this.webSDTLTK5);
            this.Name = "frmPL";
            this.Text = "PHỤ LỤC";
            this.Load += new System.EventHandler(this.frmPL_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webSDTLTK5;
        private System.Windows.Forms.Button btnSDTLTK5;
        private System.Windows.Forms.Button btnSDTLTK34;
        private System.Windows.Forms.Button btnSDTLTK12;
    }
}