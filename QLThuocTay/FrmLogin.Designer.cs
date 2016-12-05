namespace QLThuocTay
{
    partial class FrmLogin
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
            this.btnDn = new System.Windows.Forms.Button();
            this.btnTh = new System.Windows.Forms.Button();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.lblTk = new System.Windows.Forms.Label();
            this.LblMk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDn
            // 
            this.btnDn.Location = new System.Drawing.Point(180, 153);
            this.btnDn.Name = "btnDn";
            this.btnDn.Size = new System.Drawing.Size(75, 23);
            this.btnDn.TabIndex = 0;
            this.btnDn.Text = "Đăng nhập";
            this.btnDn.UseVisualStyleBackColor = true;
            this.btnDn.Click += new System.EventHandler(this.btnDn_Click);
            // 
            // btnTh
            // 
            this.btnTh.Location = new System.Drawing.Point(335, 153);
            this.btnTh.Name = "btnTh";
            this.btnTh.Size = new System.Drawing.Size(75, 23);
            this.btnTh.TabIndex = 1;
            this.btnTh.Text = "Thoát";
            this.btnTh.UseVisualStyleBackColor = true;
            this.btnTh.Click += new System.EventHandler(this.btnTh_Click);
            // 
            // txtMk
            // 
            this.txtMk.Location = new System.Drawing.Point(217, 89);
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(162, 20);
            this.txtMk.TabIndex = 2;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(219, 48);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(160, 20);
            this.txtTK.TabIndex = 3;
            // 
            // lblTk
            // 
            this.lblTk.AutoSize = true;
            this.lblTk.Location = new System.Drawing.Point(153, 51);
            this.lblTk.Name = "lblTk";
            this.lblTk.Size = new System.Drawing.Size(55, 13);
            this.lblTk.TabIndex = 4;
            this.lblTk.Text = "Tài khoản";
            // 
            // LblMk
            // 
            this.LblMk.AutoSize = true;
            this.LblMk.Location = new System.Drawing.Point(153, 96);
            this.LblMk.Name = "LblMk";
            this.LblMk.Size = new System.Drawing.Size(52, 13);
            this.LblMk.TabIndex = 5;
            this.LblMk.Text = "Mật khẩu";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 223);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.btnTh);
            this.Controls.Add(this.btnDn);
            this.Controls.Add(this.LblMk);
            this.Controls.Add(this.lblTk);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDn;
        private System.Windows.Forms.Button btnTh;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label lblTk;
        private System.Windows.Forms.Label LblMk;
    }
}