namespace QLSinhVien
{
    partial class frm_login
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
        private void InitializeComponent()
        {
            this.lbl_1 = new System.Windows.Forms.Label();
            this.txb_1 = new System.Windows.Forms.TextBox();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.txb_2 = new System.Windows.Forms.TextBox();
            this.bt_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(30, 30);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(73, 16);
            this.lbl_1.TabIndex = 4;
            this.lbl_1.Text = "Tài khoản :";
            // 
            // txb_1
            // 
            this.txb_1.Location = new System.Drawing.Point(30, 55);
            this.txb_1.Name = "txb_1";
            this.txb_1.Size = new System.Drawing.Size(220, 22);
            this.txb_1.TabIndex = 3;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(30, 100);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(67, 16);
            this.lbl_2.TabIndex = 2;
            this.lbl_2.Text = "Mật khẩu :";
            // 
            // txb_2
            // 
            this.txb_2.Location = new System.Drawing.Point(30, 125);
            this.txb_2.Name = "txb_2";
            this.txb_2.PasswordChar = '*';
            this.txb_2.Size = new System.Drawing.Size(220, 22);
            this.txb_2.TabIndex = 1;
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(30, 175);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(220, 35);
            this.bt_1.TabIndex = 0;
            this.bt_1.Text = "ĐĂNG NHẬP";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // frm_login
            // 
            this.ClientSize = new System.Drawing.Size(284, 251);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.txb_2);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.txb_1);
            this.Controls.Add(this.lbl_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập Hệ Thống";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Khai báo biến (Dán vào cuối file Designer)
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.TextBox txb_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.TextBox txb_2;
        private System.Windows.Forms.Button bt_1;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        

        #endregion
    }
}