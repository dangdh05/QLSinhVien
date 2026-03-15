using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class frm_admin : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["QLSinhVienDB"].ConnectionString;

        public frm_admin()
        {
            InitializeComponent();
            LoadKhoa();
            LoadData();
            dgv_Admin_SinhVien.CellClick += dgv_Admin_SinhVien_CellClick;
            btn_Them.Click += btn_Them_Click;
            btn_Sua.Click += btn_Sua_Click;
            btn_Xoa.Click += btn_Xoa_Click;
            btn_LamMoi.Click += btn_LamMoi_Click;
            chk_Phai.CheckedChanged += (s, e) => chk_Phai.Text = chk_Phai.Checked ? "Nam" : "Nu";
        }

        private void LoadKhoa()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT MaKH FROM Khoa", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbo_MaKH.DataSource = dt;
                    cbo_MaKH.DisplayMember = "MaKH";
                    cbo_MaKH.ValueMember = "MaKH";
                }
            }
            catch (Exception ex) { MessageBox.Show("Loi load Khoa: " + ex.Message); }
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SinhVien", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_Admin_SinhVien.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("Loi ket noi: " + ex.Message); }
        }

        private void ClearInputs()
        {
            txt_MaSV.Text = ""; txt_HoSV.Text = ""; txt_TenSV.Text = "";
            txt_NoiSinh.Text = ""; txt_HocBong.Text = "";
            dtp_NgaySinh.Value = DateTime.Today;
            chk_Phai.Checked = true; chk_Phai.Text = "Nam";
            txt_MaSV.ReadOnly = false;
            if (cbo_MaKH.Items.Count > 0) cbo_MaKH.SelectedIndex = 0;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_MaSV.Text) || string.IsNullOrWhiteSpace(txt_TenSV.Text))
            { MessageBox.Show("Vui long nhap Ma SV va Ten SV."); return false; }
            if (txt_MaSV.Text.Trim().Length > 3)
            { MessageBox.Show("Ma SV toi da 3 ky tu."); return false; }
            if (txt_HoSV.Text.Trim().Length > 15)
            { MessageBox.Show("Ho SV toi da 15 ky tu."); return false; }
            if (txt_TenSV.Text.Trim().Length > 7)
            { MessageBox.Show("Ten SV toi da 7 ky tu."); return false; }
            return true;
        }

        private void dgv_Admin_SinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgv_Admin_SinhVien.Rows[e.RowIndex];
            txt_MaSV.Text = row.Cells["MaSV"].Value?.ToString();
            txt_HoSV.Text = row.Cells["HoSV"].Value?.ToString();
            txt_TenSV.Text = row.Cells["TenSV"].Value?.ToString();
            txt_NoiSinh.Text = row.Cells["NoiSinh"].Value?.ToString();
            txt_HocBong.Text = row.Cells["HocBong"].Value?.ToString();
            if (row.Cells["NgaySinh"].Value != null)
                dtp_NgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
            bool isNam = row.Cells["Phai"].Value != null && Convert.ToBoolean(row.Cells["Phai"].Value);
            chk_Phai.Checked = isNam;
            chk_Phai.Text = isNam ? "Nam" : "Nu";
            cbo_MaKH.SelectedValue = row.Cells["MaKH"].Value?.ToString();
            txt_MaSV.ReadOnly = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "INSERT INTO SinhVien (MaSV,HoSV,TenSV,Phai,NgaySinh,NoiSinh,MaKH,HocBong) VALUES (@MaSV,@HoSV,@TenSV,@Phai,@NgaySinh,@NoiSinh,@MaKH,@HocBong)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaSV", txt_MaSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@HoSV", txt_HoSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenSV", txt_TenSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phai", chk_Phai.Checked);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtp_NgaySinh.Value.Date);
                    cmd.Parameters.AddWithValue("@NoiSinh", txt_NoiSinh.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaKH", cbo_MaKH.SelectedValue?.ToString());
                    cmd.Parameters.AddWithValue("@HocBong", string.IsNullOrWhiteSpace(txt_HocBong.Text) ? (object)DBNull.Value : double.Parse(txt_HocBong.Text));
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Them thanh cong."); ClearInputs(); LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Loi: " + ex.Message); }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "UPDATE SinhVien SET HoSV=@HoSV,TenSV=@TenSV,Phai=@Phai,NgaySinh=@NgaySinh,NoiSinh=@NoiSinh,MaKH=@MaKH,HocBong=@HocBong WHERE MaSV=@MaSV";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@HoSV", txt_HoSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenSV", txt_TenSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phai", chk_Phai.Checked);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtp_NgaySinh.Value.Date);
                    cmd.Parameters.AddWithValue("@NoiSinh", txt_NoiSinh.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaKH", cbo_MaKH.SelectedValue?.ToString());
                    cmd.Parameters.AddWithValue("@HocBong", string.IsNullOrWhiteSpace(txt_HocBong.Text) ? (object)DBNull.Value : double.Parse(txt_HocBong.Text));
                    cmd.Parameters.AddWithValue("@MaSV", txt_MaSV.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Cap nhat thanh cong."); ClearInputs(); LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Loi: " + ex.Message); }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaSV.Text))
            { MessageBox.Show("Vui long chon sinh vien can xoa."); return; }
            if (MessageBox.Show("Ban co chac muon xoa?", "Xac nhan", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM SinhVien WHERE MaSV=@MaSV", conn);
                    cmd.Parameters.AddWithValue("@MaSV", txt_MaSV.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Xoa thanh cong."); ClearInputs(); LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Loi: " + ex.Message); }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e) { ClearInputs(); LoadData(); }
    }
}