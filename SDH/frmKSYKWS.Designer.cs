namespace SDH
{
    partial class frmKSYKWS
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
            this.webKSYK = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webKSYK
            // 
            this.webKSYK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webKSYK.Location = new System.Drawing.Point(0, 0);
            this.webKSYK.MinimumSize = new System.Drawing.Size(20, 20);
            this.webKSYK.Name = "webKSYK";
            this.webKSYK.Size = new System.Drawing.Size(800, 450);
            this.webKSYK.TabIndex = 0;
            // 
            // frmKSYKWS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webKSYK);
            this.Name = "frmKSYKWS";
            this.Text = "frmKSYKWS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKSYKWS_FormClosed);
            this.Load += new System.EventHandler(this.frmKSYKWS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webKSYK;
    }
}