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
    public partial class ThirdParties : Form
    {
        public Login login;
        public ThirdParties(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void lbl__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.contact.Show();
            Hide();
        }

        private void salesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.sales.Show();
            Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.Show();
            Hide();
        }

        private void pbStatistic_Click(object sender, EventArgs e)
        {
            login.statistic.tipe = "TP";
            login.statistic.ShowDialog();
        }

        private void masterUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.master_User.Show();
            Hide();
        }

        private void pbPrint_Click(object sender, EventArgs e)
        {
            login.print.ShowDialog();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            login.hThirdParty.ShowDialog();
        }

        public void loadSSH(string parameter, ref ComboBox cb,string cabang="")
        {
            if(parameter == "Admin")
            {
                cb.DataSource = login.db.executeDataTable($"SELECT * FROM USER_DATA WHERE U_STATUS='3'");
                cb.DisplayMember = "U_NAME";
            }
            else if(parameter == "Manager")
            {
                cb.DataSource = login.db.executeDataTable($"SELECT * FROM USER_DATA WHERE U_STATUS='3' AND ID_BRANCH='{cabang}'");
                cb.DisplayMember = "U_NAME";
            }
        }

        private void ThirdParties_VisibleChanged(object sender, EventArgs e)
        {
            if (login.jabatanUser == "Admin")
            {
                masterUserToolStripMenuItem.Visible = true;
                lblBranch.Text = "";
                loadSSH("Admin",ref cbSales);
            }
            else if (login.jabatanUser == "Manager")
            {
                masterUserToolStripMenuItem.Visible = false;
                lblBranch.Text = login.branchUser;
                Object idBranch = login.db.executeScalar($"Select id_branch from branch where branch_name='{login.branchUser}'");
                loadSSH("Manager", ref cbSales, idBranch.ToString());
            }
            else if (login.jabatanUser == "Sales")
            {
                masterUserToolStripMenuItem.Visible = false;
                lblBranch.Text = login.branchUser;
                lblSales.Visible = false;
                cbSales.Visible = false;
            }
            lblUser.Text = login.namaUser + " (" + login.jabatanUser + ")";
            loadDGV();
        }

        public void loadDGV(string name = "", string alias = "", string id = "", string city = "", string code = "",string phone = "",string type="",string status="")
        {
            dgvTP.Columns.Clear();
            dgvTP.DataSource = login.db.executeDataTable($"SELECT FORMAL_NAME AS NAME,ALIAS_NAME AS ALIAS, ID_THIRD_PARTY AS CODE,CITY,POSTAL_CODE AS POSTCODE,PHONE_NUMBER AS PHONE,CASE THIRD_PARTY_TYPE WHEN '1' THEN 'PROSPECT' WHEN '2' THEN 'CUSTOMER' WHEN '3' THEN 'VENDOR' WHEN '4' THEN 'OTHERS' END AS TYPE,CASE ACTIVE_STATUS WHEN '0' THEN 'NON ACTIVE' WHEN '1' THEN 'ACTIVE' END AS STATE FROM THIRD_PARTY WHERE FORMAL_NAME like '%{name}%' AND ALIAS_NAME like '%{alias}%' AND ID_THIRD_PARTY like '%{id}%' AND CITY like '%{city}%' AND POSTAL_CODE like '%{code}%' AND PHONE_NUMBER like '%{phone}%' AND THIRD_PARTY_TYPE like '%{type}%' AND ACTIVE_STATUS like '%{status}%' ORDER BY 1");
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "checkBox";
            checkColumn.HeaderText = "CHECK";
            dgvTP.Columns.Add(checkColumn);
        }

        private void pbUnsearch_Click(object sender, EventArgs e)
        {

        }

        private void pbSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
