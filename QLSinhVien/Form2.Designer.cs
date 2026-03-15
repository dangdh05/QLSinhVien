using System.Windows.Forms;
using System.Drawing;

namespace QLSinhVien
{
    partial class frm_admin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgv_Admin_SinhVien = new DataGridView();
            this.pnl_Left = new Panel();
            this.pnl_Search = new Panel();
            this.lbl_Search = new Label();
            this.txt_Search = new TextBox();
            this.btn_Search = new Button();
            this.pnl_Right = new Panel();
            this.lbl_Title = new Label();
            this.lbl_MaSV = new Label();
            this.txt_MaSV = new TextBox();
            this.lbl_HoSV = new Label();
            this.txt_HoSV = new TextBox();
            this.lbl_TenSV = new Label();
            this.txt_TenSV = new TextBox();
            this.lbl_Phai = new Label();
            this.chk_Phai = new CheckBox();
            this.lbl_NgaySinh = new Label();
            this.dtp_NgaySinh = new DateTimePicker();
            this.lbl_NoiSinh = new Label();
            this.txt_NoiSinh = new TextBox();
            this.lbl_MaKH = new Label();
            this.cbo_MaKH = new ComboBox();
            this.lbl_HocBong = new Label();
            this.txt_HocBong = new TextBox();
            this.btn_Them = new Button();
            this.btn_Sua = new Button();
            this.btn_Xoa = new Button();
            this.btn_LamMoi = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Admin_SinhVien)).BeginInit();
            this.pnl_Left.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            this.pnl_Right.SuspendLayout();
            this.SuspendLayout();

            // pnl_Search - thanh tim kiem phia tren DataGridView
            this.pnl_Search.Dock = DockStyle.Top;
            this.pnl_Search.Size = new Size(680, 45);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.BackColor = Color.WhiteSmoke;
            this.pnl_Search.Controls.Add(this.lbl_Search);
            this.pnl_Search.Controls.Add(this.txt_Search);
            this.pnl_Search.Controls.Add(this.btn_Search);

            this.lbl_Search.Location = new Point(10, 13); this.lbl_Search.Size = new Size(60, 20); this.lbl_Search.Text = "Tim kiem:";
            this.txt_Search.Location = new Point(75, 10); this.txt_Search.Size = new Size(480, 22); this.txt_Search.Name = "txt_Search";
            this.btn_Search.Location = new Point(565, 8); this.btn_Search.Size = new Size(80, 28); this.btn_Search.Text = "Tim"; this.btn_Search.Name = "btn_Search"; this.btn_Search.BackColor = Color.SteelBlue; this.btn_Search.ForeColor = Color.White;

            // dgv_Admin_SinhVien
            this.dgv_Admin_SinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Admin_SinhVien.BackgroundColor = Color.White;
            this.dgv_Admin_SinhVien.ColumnHeadersHeight = 29;
            this.dgv_Admin_SinhVien.Dock = DockStyle.Fill;
            this.dgv_Admin_SinhVien.Name = "dgv_Admin_SinhVien";
            this.dgv_Admin_SinhVien.RowHeadersWidth = 51;
            this.dgv_Admin_SinhVien.TabIndex = 0;
            this.dgv_Admin_SinhVien.ReadOnly = true;
            this.dgv_Admin_SinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // pnl_Right - chua pnl_Search + dgv
            this.pnl_Right.Dock = DockStyle.Fill;
            this.pnl_Right.Name = "pnl_Right";
            this.pnl_Right.Controls.Add(this.dgv_Admin_SinhVien);
            this.pnl_Right.Controls.Add(this.pnl_Search);

            // pnl_Left
            this.pnl_Left.Dock = DockStyle.Left;
            this.pnl_Left.Size = new Size(370, 650);
            this.pnl_Left.Name = "pnl_Left";
            this.pnl_Left.TabIndex = 1;
            this.pnl_Left.Controls.Add(this.lbl_Title);
            this.pnl_Left.Controls.Add(this.lbl_MaSV);
            this.pnl_Left.Controls.Add(this.txt_MaSV);
            this.pnl_Left.Controls.Add(this.lbl_HoSV);
            this.pnl_Left.Controls.Add(this.txt_HoSV);
            this.pnl_Left.Controls.Add(this.lbl_TenSV);
            this.pnl_Left.Controls.Add(this.txt_TenSV);
            this.pnl_Left.Controls.Add(this.lbl_Phai);
            this.pnl_Left.Controls.Add(this.chk_Phai);
            this.pnl_Left.Controls.Add(this.lbl_NgaySinh);
            this.pnl_Left.Controls.Add(this.dtp_NgaySinh);
            this.pnl_Left.Controls.Add(this.lbl_NoiSinh);
            this.pnl_Left.Controls.Add(this.txt_NoiSinh);
            this.pnl_Left.Controls.Add(this.lbl_MaKH);
            this.pnl_Left.Controls.Add(this.cbo_MaKH);
            this.pnl_Left.Controls.Add(this.lbl_HocBong);
            this.pnl_Left.Controls.Add(this.txt_HocBong);
            this.pnl_Left.Controls.Add(this.btn_Them);
            this.pnl_Left.Controls.Add(this.btn_Sua);
            this.pnl_Left.Controls.Add(this.btn_Xoa);
            this.pnl_Left.Controls.Add(this.btn_LamMoi);

            // lbl_Title
            this.lbl_Title.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            this.lbl_Title.Location = new Point(15, 15);
            this.lbl_Title.Size = new Size(330, 30);
            this.lbl_Title.Text = "Thong tin sinh vien";

            this.lbl_MaSV.Location = new Point(15, 55); this.lbl_MaSV.Size = new Size(100, 20); this.lbl_MaSV.Text = "Ma SV:";
            this.txt_MaSV.Location = new Point(15, 75); this.txt_MaSV.Size = new Size(330, 22); this.txt_MaSV.Name = "txt_MaSV";
            this.lbl_HoSV.Location = new Point(15, 107); this.lbl_HoSV.Size = new Size(100, 20); this.lbl_HoSV.Text = "Ho:";
            this.txt_HoSV.Location = new Point(15, 127); this.txt_HoSV.Size = new Size(330, 22); this.txt_HoSV.Name = "txt_HoSV";
            this.lbl_TenSV.Location = new Point(15, 159); this.lbl_TenSV.Size = new Size(100, 20); this.lbl_TenSV.Text = "Ten:";
            this.txt_TenSV.Location = new Point(15, 179); this.txt_TenSV.Size = new Size(330, 22); this.txt_TenSV.Name = "txt_TenSV";
            this.lbl_Phai.Location = new Point(15, 211); this.lbl_Phai.Size = new Size(100, 20); this.lbl_Phai.Text = "Phai:";
            this.chk_Phai.Location = new Point(15, 231); this.chk_Phai.Size = new Size(80, 22); this.chk_Phai.Text = "Nam"; this.chk_Phai.Checked = true; this.chk_Phai.Name = "chk_Phai";
            this.lbl_NgaySinh.Location = new Point(15, 263); this.lbl_NgaySinh.Size = new Size(100, 20); this.lbl_NgaySinh.Text = "Ngay sinh:";
            this.dtp_NgaySinh.Location = new Point(15, 283); this.dtp_NgaySinh.Size = new Size(330, 22); this.dtp_NgaySinh.Name = "dtp_NgaySinh"; this.dtp_NgaySinh.Format = DateTimePickerFormat.Short;
            this.lbl_NoiSinh.Location = new Point(15, 315); this.lbl_NoiSinh.Size = new Size(100, 20); this.lbl_NoiSinh.Text = "Noi sinh:";
            this.txt_NoiSinh.Location = new Point(15, 335); this.txt_NoiSinh.Size = new Size(330, 22); this.txt_NoiSinh.Name = "txt_NoiSinh";
            this.lbl_MaKH.Location = new Point(15, 367); this.lbl_MaKH.Size = new Size(100, 20); this.lbl_MaKH.Text = "Ma KH:";
            this.cbo_MaKH.Location = new Point(15, 387); this.cbo_MaKH.Size = new Size(330, 22); this.cbo_MaKH.Name = "cbo_MaKH"; this.cbo_MaKH.DropDownStyle = ComboBoxStyle.DropDownList;
            this.lbl_HocBong.Location = new Point(15, 419); this.lbl_HocBong.Size = new Size(100, 20); this.lbl_HocBong.Text = "Hoc bong:";
            this.txt_HocBong.Location = new Point(15, 439); this.txt_HocBong.Size = new Size(330, 22); this.txt_HocBong.Name = "txt_HocBong";
            this.btn_Them.BackColor = Color.LightBlue;   this.btn_Them.Location = new Point(15, 490);  this.btn_Them.Size = new Size(75, 35); this.btn_Them.Text = "Them";   this.btn_Them.Name = "btn_Them";
            this.btn_Sua.BackColor  = Color.LightGreen;  this.btn_Sua.Location  = new Point(100, 490); this.btn_Sua.Size  = new Size(75, 35); this.btn_Sua.Text  = "Sua";    this.btn_Sua.Name  = "btn_Sua";
            this.btn_Xoa.BackColor  = Color.LightCoral;  this.btn_Xoa.Location  = new Point(185, 490); this.btn_Xoa.Size  = new Size(75, 35); this.btn_Xoa.Text  = "Xoa";    this.btn_Xoa.Name  = "btn_Xoa";
            this.btn_LamMoi.BackColor = Color.LightGray; this.btn_LamMoi.Location = new Point(270, 490); this.btn_LamMoi.Size = new Size(75, 35); this.btn_LamMoi.Text = "Lam moi"; this.btn_LamMoi.Name = "btn_LamMoi";

            // frm_admin
            this.ClientSize = new Size(1050, 650);
            this.Controls.Add(this.pnl_Right);
            this.Controls.Add(this.pnl_Left);
            this.Name = "frm_admin";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "He thong Quan tri Sinh vien";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Admin_SinhVien)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Right.ResumeLayout(false);
            this.pnl_Left.ResumeLayout(false);
            this.pnl_Left.PerformLayout();
            this.ResumeLayout(false);
        }

        private DataGridView dgv_Admin_SinhVien;
        private Panel pnl_Left;
        private Panel pnl_Right;
        private Panel pnl_Search;
        private Label lbl_Search;
        private TextBox txt_Search;
        private Button btn_Search;
        private Label lbl_Title;
        private Label lbl_MaSV;
        private TextBox txt_MaSV;
        private Label lbl_HoSV;
        private TextBox txt_HoSV;
        private Label lbl_TenSV;
        private TextBox txt_TenSV;
        private Label lbl_Phai;
        private CheckBox chk_Phai;
        private Label lbl_NgaySinh;
        private DateTimePicker dtp_NgaySinh;
        private Label lbl_NoiSinh;
        private TextBox txt_NoiSinh;
        private Label lbl_MaKH;
        private ComboBox cbo_MaKH;
        private Label lbl_HocBong;
        private TextBox txt_HocBong;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_LamMoi;
    }
}