namespace SDH
{
    partial class frmKSYK
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
            this.btnTQYKNH = new System.Windows.Forms.Button();
            this.btnPTYKNH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTQYKNH
            // 
            this.btnTQYKNH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTQYKNH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTQYKNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTQYKNH.ForeColor = System.Drawing.Color.Indigo;
            this.btnTQYKNH.Location = new System.Drawing.Point(61, 38);
            this.btnTQYKNH.Name = "btnTQYKNH";
            this.btnTQYKNH.Size = new System.Drawing.Size(319, 68);
            this.btnTQYKNH.TabIndex = 11;
            this.btnTQYKNH.Text = "TỔNG QUÁT - Ý KIẾN NGƯỜI HỌC";
            this.btnTQYKNH.UseVisualStyleBackColor = true;
            this.btnTQYKNH.Click += new System.EventHandler(this.btnTQYKNH_Click);
            // 
            // btnPTYKNH
            // 
            this.btnPTYKNH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPTYKNH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPTYKNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPTYKNH.ForeColor = System.Drawing.Color.Indigo;
            this.btnPTYKNH.Location = new System.Drawing.Point(61, 123);
            this.btnPTYKNH.Name = "btnPTYKNH";
            this.btnPTYKNH.Size = new System.Drawing.Size(319, 68);
            this.btnPTYKNH.TabIndex = 11;
            this.btnPTYKNH.Text = "PHÂN TÍCH - Ý KIẾN NGƯỜI HỌC";
            this.btnPTYKNH.UseVisualStyleBackColor = true;
            this.btnPTYKNH.Click += new System.EventHandler(this.btnPTYKNH_Click);
            // 
            // KSYK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 449);
            this.Controls.Add(this.btnPTYKNH);
            this.Controls.Add(this.btnTQYKNH);
            this.Name = "KSYK";
            this.Text = "frmYKNH";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KSYK_FormClosed);
            this.Load += new System.EventHandler(this.KSYK_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTQYKNH;
        private System.Windows.Forms.Button btnPTYKNH;
    }
}