namespace SDH
{
    partial class frmPLWS
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
            this.webPLS = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webPLS
            // 
            this.webPLS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webPLS.Location = new System.Drawing.Point(0, 0);
            this.webPLS.MinimumSize = new System.Drawing.Size(20, 20);
            this.webPLS.Name = "webPLS";
            this.webPLS.Size = new System.Drawing.Size(800, 450);
            this.webPLS.TabIndex = 0;
            // 
            // frmPLWS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webPLS);
            this.Name = "frmPLWS";
            this.Text = "SHOW WEB PHỤ LỤC";
            this.Load += new System.EventHandler(this.frmPLWS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webPLS;
    }
}