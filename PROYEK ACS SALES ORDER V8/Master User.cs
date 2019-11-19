using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace PROYEK_ACS_SALES_ORDER_V1
{
    public partial class Master_User : Form
    {
        public Login login;
        public Master_User(Login login)
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


        private void thirdPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.thirdParties.Show();
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

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.contact.Show();
            Hide();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            login.hUser.judul = "Add User";
            login.hUser.ShowDialog();
        }


        public void loadDGV(string username = "", string nama = "", string jabatan = "", string branch = "", string status_user = "")
        {
            dgvUser.Columns.Clear();
            if (jabatan != "4")
            {
                dgvUser.DataSource = login.db.executeDataTable($"SELECT USERNAME,U_NAME as NAME, CASE U_STATUS WHEN '1' THEN 'ADMIN' WHEN '2' THEN 'MANAGER' WHEN '3' THEN 'SALES' END AS JABATAN,ID_BRANCH AS BRANCH ,CASE U_ACTIVE_STATUS WHEN '0' THEN 'NON ACTIVE' WHEN '1' THEN 'ACTIVE' END AS STATE FROM USER_DATA WHERE USERNAME like '%{username}%' AND U_NAME like '%{nama}%' AND U_STATUS like '%{jabatan}%' AND ID_BRANCH like '%{branch}%' AND U_ACTIVE_STATUS like '%{status_user}%' ORDER BY 1");
            }
            else
            {
                dgvUser.DataSource = login.db.executeDataTable($"SELECT USERNAME,U_NAME as NAME, CASE U_STATUS WHEN '1' THEN 'ADMIN' WHEN '2' THEN 'MANAGER' WHEN '3' THEN 'SALES' END AS JABATAN,ID_BRANCH AS BRANCH ,CASE U_ACTIVE_STATUS WHEN '0' THEN 'NON ACTIVE' WHEN '1' THEN 'ACTIVE' END AS STATE FROM USER_DATA WHERE USERNAME like '%{username}%' AND U_NAME like '%{nama}%' AND U_STATUS like '%{""}%' AND ID_BRANCH like '%{branch}%' AND U_ACTIVE_STATUS like '%{status_user}%' ORDER BY 1");
            }
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "checkBox";
            checkColumn.HeaderText = "CHECK";
            dgvUser.Columns.Add(checkColumn);
        }

        public void loadSSH(string parameter, ref ComboBox cb)
        {
            cb.DataSource = login.db.executeDataTable($"SELECT * FROM SSH_VARIABLES WHERE TIPE='{parameter}'");
            cb.DisplayMember = "isi";
        }

        private void pbUnsearch_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "";
            tbName.Text = "";
            cbRole.SelectedIndex = 0;
            tbBranch.Text = "";
            cbStatus.SelectedIndex = 0;
            loadDGV();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            loadDGV(tbUsername.Text, tbName.Text, (cbRole.SelectedIndex + 1).ToString(), tbBranch.Text, cbStatus.SelectedIndex.ToString());
        }

        private void Master_User_VisibleChanged(object sender, EventArgs e)
        {
            lblUser.Text = login.namaUser + " (" + login.jabatanUser + ")";
            loadDGV();
            loadSSH("USER_TYPE", ref cbRole);
            loadSSH("ACTIVE_STATUS", ref cbStatus);
        }

        private void pbStatistic_Click(object sender, EventArgs e)
        {

        }

        private void pbPrint_Click(object sender, EventArgs e)
        {

        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (dgvUser.Rows[e.RowIndex].Cells[5].Value == null || dgvUser.Rows[e.RowIndex].Cells[5].Value.ToString() == "False")
                {
                    dgvUser.Rows[e.RowIndex].Cells[5].Value = true;
                }
                else
                {
                    dgvUser.Rows[e.RowIndex].Cells[5].Value = false;
                }
                btnActive.Visible = true;
                btnInactive.Visible = true;
            }
        }

        public void updateUser(int status, string nama = "")
        {
            if (status == 0)
            {
                login.db.executeNonQuery($"UPDATE USER_DATA SET U_ACTIVE_STATUS='1' WHERE USERNAME LIKE '%{nama}%'");
            }
            else
            {
                login.db.executeNonQuery($"UPDATE USER_DATA SET U_ACTIVE_STATUS='0' WHERE USERNAME LIKE '%{nama}%'");
            }
            loadDGV();
        }
        List<int> rowChecked;

        private void btnActive_Click(object sender, EventArgs e)
        {
            rowChecked = new List<int>();
            for (int i = 0; i < dgvUser.Rows.Count; i++)
            {
                DataGridViewRow row = dgvUser.Rows[i];
                if (row.Cells[5].Value != null && row.Cells[5].Value.ToString() == "True")
                {
                    rowChecked.Add(i);
                }
            }
            for (int i = 0; i < rowChecked.Count; i++)
            {
                updateUser(0, dgvUser.Rows[rowChecked[i]].Cells[0].Value.ToString());
            }
            btnActive.Visible = false;
            btnInactive.Visible = false;
        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
            rowChecked = new List<int>();
            for (int i = 0; i < dgvUser.Rows.Count; i++)
            {
                DataGridViewRow row = dgvUser.Rows[i];
                if (row.Cells[5].Value != null && row.Cells[5].Value.ToString() == "True")
                {
                    rowChecked.Add(i);
                }
            }
            for (int i = 0; i < rowChecked.Count; i++)
            {
                updateUser(1, dgvUser.Rows[rowChecked[i]].Cells[0].Value.ToString());
            }
            btnActive.Visible = false;
            btnInactive.Visible = false;
        }

        private void pbCheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvUser.Rows.Count; i++)
            {
                if (dgvUser.Rows[i].Cells[5].Value == null || dgvUser.Rows[i].Cells[5].Value.ToString() == "False")
                {
                    dgvUser.Rows[i].Cells[5].Value = true;
                }
                btnActive.Visible = true;
                btnInactive.Visible = true;
            }
        }

        private void pbUncheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvUser.Rows.Count; i++)
            {
                if (dgvUser.Rows[i].Cells[5].Value == null || dgvUser.Rows[i].Cells[5].Value.ToString() == "True")
                {
                    dgvUser.Rows[i].Cells[5].Value = false;
                }
                btnActive.Visible = false;
                btnInactive.Visible = false;
            }
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            login.hUser.judul = "Edit User";
            Object id = login.db.executeScalar($"SELECT USER_ROW_ID FROM USER_DATA WHERE USERNAME='{dgvUser.Rows[e.RowIndex].Cells[0].Value.ToString()}'");
            login.hUser.id = id.ToString();
            login.hUser.ShowDialog();
        }
    }
}
