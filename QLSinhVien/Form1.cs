using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            string user = txb_1.Text.Trim();
            string pass = txb_2.Text.Trim();

            if (user == "admin" && pass == "admin")
            {
                MessageBox.Show("Chào Admin!");
                frm_admin f = new frm_admin();
                f.Show();
                this.Hide();
            }
        }
    }
}
