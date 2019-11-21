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
            login.hThirdParty.judul = "Add Third Party";
            Object id = login.db.executeScalar($"SELECT COUNT(ID_THIRD_PARTY)+1 FROM THIRD_PARTY");
            login.hThirdParty.id = "TP" + id.ToString().PadLeft(3, '0');  
            string idUser = cbSales.SelectedValue.ToString();
            login.hThirdParty.iduser = idUser;
            login.hThirdParty.ShowDialog();
        }

        public void loadSSH(string parameter, ref ComboBox cb,string cabang="")
        {
            if (parameter == "Admin")
            {
                cb.DataSource = login.db.executeDataTable($"SELECT * FROM USER_DATA WHERE U_STATUS='3'");
                cb.DisplayMember = "U_NAME";
                cb.ValueMember = "USER_ROW_ID";
            }
            else if (parameter == "Manager")
            {
                cb.DataSource = login.db.executeDataTable($"SELECT * FROM USER_DATA WHERE U_STATUS='3' AND ID_BRANCH='{cabang}'");
                cb.DisplayMember = "U_NAME";
                cb.ValueMember = "USER_ROW_ID";
            }
        }

        private void ThirdParties_VisibleChanged(object sender, EventArgs e)
        {
            if (login.jabatanUser == "Admin")
            {
                masterUserToolStripMenuItem.Visible = true;
                lblBranch.Text = "";
                loadSSH("Admin", ref cbSales);
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
            loadSSHcb("THIRD_PARTY_TYPE", ref cbType);
            loadSSHcb("ACTIVE_STATUS", ref cbStatus);
        }

        public void loadDGV(string name = "", string alias = "", string id = "", string city = "", string code = "",string phone = "",string type="",string status="")
        {
            dgvTP.Columns.Clear();
            dgvTP.DataSource = login.db.executeDataTable($"SELECT FORMAL_NAME AS NAME,ALIAS_NAME AS ALIAS, ID_THIRD_PARTY AS CODE,CITY,POSTAL_CODE AS POSTCODE,PHONE_NUMBER AS PHONE,CASE THIRD_PARTY_TYPE WHEN '1' THEN 'PROSPECT' WHEN '2' THEN 'CUSTOMER' WHEN '3' THEN 'VENDOR' WHEN '4' THEN 'OTHERS' END AS TYPE,CASE ACTIVE_STATUS WHEN '0' THEN 'NON ACTIVE' WHEN '1' THEN 'ACTIVE' END AS STATE FROM THIRD_PARTY WHERE FORMAL_NAME like '%{name}%' AND ALIAS_NAME like '%{alias}%' AND ID_THIRD_PARTY like '%{id}%' AND CITY like '%{city}%' AND POSTAL_CODE like '%{code}%' AND PHONE_NUMBER like '%{phone}%' AND THIRD_PARTY_TYPE like '%{type}%' AND ACTIVE_STATUS like '%{status}%' AND USER_ROW_ID={cbSales.SelectedValue} ORDER BY 1");
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "checkBox";
            checkColumn.HeaderText = "CHECK";
            dgvTP.Columns.Add(checkColumn);
        }

        private void pbUnsearch_Click(object sender, EventArgs e)
        {
            loadDGV();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            loadDGV(tbName.Text, tbAlias.Text, tbCode.Text, tbCity.Text, tbPostcode.Text, tbPhone.Text, (cbType.SelectedIndex + 1).ToString(), cbStatus.SelectedIndex.ToString());
        }

        public void loadSSHcb(string parameter, ref ComboBox cb)
        {
            cb.DataSource = login.db.executeDataTable($"SELECT * FROM SSH_VARIABLES WHERE TIPE='{parameter}'");
            cb.DisplayMember = "isi";
        }

        private void pbCheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvTP.Rows.Count; i++)
            {
                if (dgvTP.Rows[i].Cells[8].Value == null || dgvTP.Rows[i].Cells[8].Value.ToString() == "False")
                {
                    dgvTP.Rows[i].Cells[8].Value = true;
                }
                btnActive.Visible = true;
                btnInactive.Visible = true;
            }
        }

        private void pbUncheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvTP.Rows.Count; i++)
            {
                if (dgvTP.Rows[i].Cells[8].Value == null || dgvTP.Rows[i].Cells[8].Value.ToString() == "True")
                {
                    dgvTP.Rows[i].Cells[8].Value = false;
                }
                btnActive.Visible = false;
                btnInactive.Visible = false;
            }
        }
        List<int> rowChecked;

        private void btnActive_Click(object sender, EventArgs e)
        {
            rowChecked = new List<int>();
            for (int i = 0; i < dgvTP.Rows.Count; i++)
            {
                DataGridViewRow row = dgvTP.Rows[i];
                if (row.Cells[8].Value != null && row.Cells[8].Value.ToString() == "True")
                {
                    rowChecked.Add(i);
                }
            }
            for (int i = 0; i < rowChecked.Count; i++)
            {
                updateUser(0, dgvTP.Rows[rowChecked[i]].Cells[0].Value.ToString());
            }
            btnActive.Visible = false;
            btnInactive.Visible = false;
        }

        public void updateUser(int status, string nama = "")
        {
            if (status == 0)
            {
                login.db.executeNonQuery($"UPDATE THIRD_PARTY SET ACTIVE_STATUS='1' WHERE FORMAL_NAME LIKE '%{nama}%'");
            }
            else
            {
                login.db.executeNonQuery($"UPDATE THIRD_PARTY SET ACTIVE_STATUS='0' WHERE FORMAL_NAME LIKE '%{nama}%'");
            }
            loadDGV();
        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
            rowChecked = new List<int>();
            for (int i = 0; i < dgvTP.Rows.Count; i++)
            {
                DataGridViewRow row = dgvTP.Rows[i];
                if (row.Cells[8].Value != null && row.Cells[8].Value.ToString() == "True")
                {
                    rowChecked.Add(i);
                }
            }
            for (int i = 0; i < rowChecked.Count; i++)
            {
                updateUser(1, dgvTP.Rows[rowChecked[i]].Cells[0].Value.ToString());
            }
            btnActive.Visible = false;
            btnInactive.Visible = false;
        }

        private void dgvTP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                if (dgvTP.Rows[e.RowIndex].Cells[8].Value == null || dgvTP.Rows[e.RowIndex].Cells[8].Value.ToString() == "False")
                {
                    dgvTP.Rows[e.RowIndex].Cells[8].Value = true;
                }
                else
                {
                    dgvTP.Rows[e.RowIndex].Cells[8].Value = false;
                }
                btnActive.Visible = true;
                btnInactive.Visible = true;
            }
        }

        private void dgvTP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            login.hThirdParty.judul = "Edit Third Party";
            Object id = login.db.executeScalar($"SELECT ID_THIRD_PARTY FROM THIRD_PARTY WHERE FORMAL_NAME='{dgvTP.Rows[e.RowIndex].Cells[0].Value.ToString()}'");
            login.hThirdParty.id = id.ToString();
            string idUser = cbSales.SelectedValue.ToString();
            login.hThirdParty.iduser = idUser;
            login.hThirdParty.name = dgvTP.Rows[e.RowIndex].Cells[0].Value.ToString();
            login.hThirdParty.city = dgvTP.Rows[e.RowIndex].Cells[3].Value.ToString();
            Object alamat = login.db.executeScalar($"SELECT ADDRESS FROM THIRD_PARTY WHERE FORMAL_NAME='{dgvTP.Rows[e.RowIndex].Cells[0].Value.ToString()}'");
            login.hThirdParty.address = alamat.ToString();
            Object mail = login.db.executeScalar($"SELECT EMAIL FROM THIRD_PARTY WHERE FORMAL_NAME='{dgvTP.Rows[e.RowIndex].Cells[0].Value.ToString()}'");
            login.hThirdParty.email = mail.ToString();
            Object web = login.db.executeScalar($"SELECT WEBSITE FROM THIRD_PARTY WHERE FORMAL_NAME='{dgvTP.Rows[e.RowIndex].Cells[0].Value.ToString()}'");
            login.hThirdParty.website = web.ToString();
            if (dgvTP.Rows[e.RowIndex].Cells[7].Value.ToString() == "ACTIVE")
            {
                login.hThirdParty.status = "1";
            }
            else
            {
                login.hThirdParty.status = "0";
            }
            login.hThirdParty.telp = dgvTP.Rows[e.RowIndex].Cells[5].Value.ToString();
            login.hThirdParty.postal = dgvTP.Rows[e.RowIndex].Cells[4].Value.ToString();
            login.hThirdParty.alias = dgvTP.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dgvTP.Rows[e.RowIndex].Cells[6].Value.ToString() == "PROSPECT")
            {
                login.hThirdParty.type = "0";
            }
            else if(dgvTP.Rows[e.RowIndex].Cells[6].Value.ToString() == "CUSTOMER")
            {
                login.hThirdParty.type = "1";
            }
            else if (dgvTP.Rows[e.RowIndex].Cells[6].Value.ToString() == "VENDOR")
            {
                login.hThirdParty.type = "2";
            }
            else if (dgvTP.Rows[e.RowIndex].Cells[6].Value.ToString() == "OTHERS")
            {
                login.hThirdParty.type = "3";
            }
            login.hThirdParty.ShowDialog();
        }
    }
}
