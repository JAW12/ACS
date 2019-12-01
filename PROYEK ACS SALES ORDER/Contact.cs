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
    public partial class Contact : Form
    {
        public Login login;
        DataSet ds;
        List<int> rowChecked;
        public Contact(Login login)
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


        private void masterUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.master_User.Show();
            Hide();
        }

        private void pbPrint_Click(object sender, EventArgs e)
        {
            RContact crm = new RContact();
            
            crm.SetDatabaseLogon("proyekacs", "proyekacs", "orcl", "");
            crm.SetParameterValue(0, tbTP.Text);
            login.print.crViewer.ReportSource = crm;
            login.print.ShowDialog();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            login.hContact.ShowDialog();
            isi_dataset();
            isi_dgv();
        }

        private void Contact_VisibleChanged(object sender, EventArgs e)
        {
            if (login.jabatanUser == "Admin")
            {
                masterUserToolStripMenuItem.Visible = true;
                lblBranch.Text = "";
            }
            else
            {
                masterUserToolStripMenuItem.Visible = false;
                lblBranch.Text = login.branchUser;
            }
            lblUser.Text = login.namaUser + " (" + login.jabatanUser + ")";
            isi_dataset();
            isi_dgv();
        }

        private void isi_dataset()
        {
            String hasil = "";
            if (cbStatus.SelectedText.ToString() == "") hasil = "";
            else if (cbStatus.SelectedText.ToString() == "Active") hasil = "1";
            else hasil = "0";
            ds = new DataSet();
            login.db.executeDataSet($"select C.ID_CONTACT, C.LAST_NAME,C.FIRST_NAME,C.JOB_POSITION, C.CITY, C.MOBILE_NUMBER, C.EMAIL, T.FORMAL_NAME,DECODE(C.ACTIVE_STATUS,'0','No Active','1','Active') as STATUS from CONTACT C, THIRD_PARTY T WHERE T.ID_THIRD_PARTY=C.ID_THIRD_PARTY AND C.LAST_NAME LIKE '%{tbLast.Text}%' AND C.FIRST_NAME LIKE '%{tbFirst.Text}%' AND C.JOB_POSITION LIKE '%{tbJob.Text}%' AND C.CITY LIKE '%{tbCity.Text}%' and C.MOBILE_NUMBER LIKE '%{tbMobile.Text}%' and C.EMAIL LIKE '%{tbEmail.Text}%' and T.FORMAL_NAME LIKE '%{tbTP.Text}%'AND c.ACTIVE_STATUS LIKE '%{hasil}%'", ref ds, "dgvcontact");
        }
        private void isi_dgv()
        {
            dgvContact.Columns.Clear();
            dgvContact.DataSource = null;
            dgvContact.DataSource = ds.Tables["dgvcontact"];
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.TrueValue = true;
            checkColumn.FalseValue = false;
            checkColumn.Name = "checkBox";
            checkColumn.HeaderText = "CHECK";
            dgvContact.Columns.Add(checkColumn);
            dgvContact.Columns[0].Visible = false;
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            isi_dataset();
            isi_dgv();
        }

        private void pbUnsearch_Click(object sender, EventArgs e)
        {
            tbLast.Text = "";
            tbFirst.Text = "";
            tbCity.Text = "";
            tbEmail.Text = "";
            tbJob.Text = "";
            tbMobile.Text = "";
            tbTP.Text = "";
            cbStatus.SelectedIndex = -1;
            isi_dataset();
            isi_dgv();
        }

        private void pbCheck_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvContact.Rows)
            {
                row.Cells[9].Value = true;
            }
            btnActive.Visible = true;
            btnInactive.Visible = true;
        }

        private void pbUncheck_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvContact.Rows)
            {
                row.Cells[9].Value = false;
            }
            btnActive.Visible = false;
            btnInactive.Visible = false;
        }

        private void dgvContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                if (dgvContact.Rows[e.RowIndex].Cells[9].Value == null || dgvContact.Rows[e.RowIndex].Cells[9].Value.ToString() == "False")
                {
                    dgvContact.Rows[e.RowIndex].Cells[9].Value = true;
                }
                else
                {
                    dgvContact.Rows[e.RowIndex].Cells[9].Value = false;
                }
            }
            else if (e.ColumnIndex > -1)
            {
                HContact hc = new HContact(login, dgvContact.Rows[e.RowIndex].Cells[0].Value.ToString());
                hc.ShowDialog();
                isi_dataset();
                isi_dgv();
            }
        }
        private void bersih()
        {
            foreach (DataGridViewRow row in dgvContact.Rows)
            {
                row.Cells[9].Value = false;
            }
            btnActive.Visible = false;
            btnInactive.Visible = false;
        }

        private void dgvContact_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            rowChecked = new List<int>();
            for (int i = 0; i < dgvContact.Rows.Count; i++)
            {
                DataGridViewRow row = dgvContact.Rows[i];
                if (row.Cells[9].Value != null && row.Cells[9].Value.ToString() == "True")
                {
                    rowChecked.Add(i);
                }
            }
            if (rowChecked.Count > 0)
            {
                btnInactive.Visible = true;
                btnActive.Visible = true;
            }
            else
            {
                btnInactive.Visible = false;
                btnActive.Visible = false;
            }
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rowChecked.Count; i++)
            {
                login.db.executeNonQuery($"UPDATE CONTACT SET ACTIVE_STATUS = '1' WHERE id_contact = '{dgvContact.Rows[rowChecked[i]].Cells[0].Value.ToString()}'");
            }
            bersih();
            isi_dataset();
            isi_dgv();
        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rowChecked.Count; i++)
            {
                login.db.executeNonQuery($"UPDATE CONTACT SET ACTIVE_STATUS = '0' WHERE id_contact = '{dgvContact.Rows[rowChecked[i]].Cells[0].Value.ToString()}'");
            }
            bersih();
            isi_dataset();
            isi_dgv();
        }
    }
}
