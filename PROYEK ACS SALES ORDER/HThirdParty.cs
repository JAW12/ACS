using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYEK_ACS_SALES_ORDER_V1
{
    public partial class HThirdParty : Form
    {
        public string judul, id;
        public Login login;
        public HThirdParty(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void lbl__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HThirdParty_VisibleChanged(object sender, EventArgs e)
        {
            lblJudul.Text = judul;
            lblTPCode.Text = id;
            loadSSH(ref cbType, "THIRD_PARTY_TYPE");
        }

        public void loadSSH(ref ComboBox cb, string parameter)
        {
            cb.DataSource = login.db.executeDataTable($"SELECT * FROM SSH_VARIABLES WHERE TIPE='{parameter}' AND ISI <> 'ALL'");
            cb.DisplayMember = "isi";
        }
        bool Eye = false;

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
