﻿using CrystalDecisions.Shared;
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
            if (login.jabatanUser == "Admin")
            {
                RThirdParties crm = new RThirdParties();
                crm.SetDatabaseLogon(login.dbUser, login.dbPass, login.dbSource, "");
                crm.SetParameterValue(0, cbSales.SelectedValue.ToString());
                try
                {

                    foreach (CrystalDecisions.CrystalReports.Engine.Table table in crm.Database.Tables)
                    {
                        TableLogOnInfo ci = new TableLogOnInfo();
                        /** 
                         * @notes Ini itterate di masing-masing tabel pada RPT yang dibuat, sehingga koneksi berubah jadi ini
                         * Database itu dikosongi agar databasenya tetap seperti sebelumnya
                         * @see https://stackoverflow.com/q/17914605 
                         * @see https://stackoverflow.com/questions/4864169/crystal-report-and-problem-with-connection
                         */
                        ci.ConnectionInfo.DatabaseName = "";
                        ci.ConnectionInfo.ServerName = login.dbIP; //ganti ipnya
                        ci.ConnectionInfo.UserID = "proyekacs";
                        ci.ConnectionInfo.Password = "proyekacs";
                        table.ApplyLogOnInfo(ci);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                login.print.crViewer.ReportSource = crm;
                login.print.ShowDialog();
            }
            else if (login.jabatanUser == "Manager")
            {
                RThirdParties crm = new RThirdParties();
                crm.SetDatabaseLogon(login.dbUser, login.dbPass, login.dbSource, "");
                crm.SetParameterValue(0, cbSales.SelectedValue.ToString());
                try
                {

                    foreach (CrystalDecisions.CrystalReports.Engine.Table table in crm.Database.Tables)
                    {
                        TableLogOnInfo ci = new TableLogOnInfo();
                        /** 
                         * @notes Ini itterate di masing-masing tabel pada RPT yang dibuat, sehingga koneksi berubah jadi ini
                         * Database itu dikosongi agar databasenya tetap seperti sebelumnya
                         * @see https://stackoverflow.com/q/17914605 
                         * @see https://stackoverflow.com/questions/4864169/crystal-report-and-problem-with-connection
                         */
                        ci.ConnectionInfo.DatabaseName = "";
                        ci.ConnectionInfo.ServerName = login.dbIP; //ganti ipnya
                        ci.ConnectionInfo.UserID = "proyekacs";
                        ci.ConnectionInfo.Password = "proyekacs";
                        table.ApplyLogOnInfo(ci);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                login.print.crViewer.ReportSource = crm;
                login.print.ShowDialog();
            }
            else {
                RThirdParties crm = new RThirdParties();
                crm.SetDatabaseLogon(login.dbUser, login.dbPass, login.dbSource, "");
                crm.SetParameterValue(0, login.idUser.ToString());
                try
                {

                    foreach (CrystalDecisions.CrystalReports.Engine.Table table in crm.Database.Tables)
                    {
                        TableLogOnInfo ci = new TableLogOnInfo();
                        /** 
                         * @notes Ini itterate di masing-masing tabel pada RPT yang dibuat, sehingga koneksi berubah jadi ini
                         * Database itu dikosongi agar databasenya tetap seperti sebelumnya
                         * @see https://stackoverflow.com/q/17914605 
                         * @see https://stackoverflow.com/questions/4864169/crystal-report-and-problem-with-connection
                         */
                        ci.ConnectionInfo.DatabaseName = "";
                        ci.ConnectionInfo.ServerName = login.dbIP; //ganti ipnya
                        ci.ConnectionInfo.UserID = "proyekacs";
                        ci.ConnectionInfo.Password = "proyekacs";
                        table.ApplyLogOnInfo(ci);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                login.print.crViewer.ReportSource = crm;
                login.print.ShowDialog();
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            string idUser = "";
            login.hThirdParty.judul = "Add Third Party";
            Object id = login.db.executeScalar($"SELECT COUNT(ID_THIRD_PARTY)+1 FROM THIRD_PARTY");
            login.hThirdParty.id = "TP" + id.ToString().PadLeft(3, '0');
            if (cbSales.Items.Count > 0)
            {
                idUser = cbSales.SelectedValue.ToString();
            }
            else
            {
                idUser = login.idUser;
            }
            login.hThirdParty.iduser = idUser;
            login.hThirdParty.ShowDialog();
            loadDGV();
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
                pbAdd.Visible = true;
                pbCheck.Visible = true;
                pbUncheck.Visible = true;
                pbPrint.Left = 750;
                pbStatistic.Left = 800;
                pbSearch.Top = 82;
                pbUnsearch.Top = 82;
            }
            else if (login.jabatanUser == "Sales")
            {
                masterUserToolStripMenuItem.Visible = false;
                pbAdd.Visible = true;
                pbCheck.Visible = true;
                pbUncheck.Visible = true;
                pbPrint.Left = 750;
                pbStatistic.Left = 800;
                pbSearch.Top = 82;
                pbUnsearch.Top = 82;
            }
            else
            {
                masterUserToolStripMenuItem.Visible = false;
                pbAdd.Visible = false;
                pbCheck.Visible = false;
                pbUncheck.Visible = false;
                pbPrint.Left = 850;
                pbStatistic.Left = 900;
                pbSearch.Top = 112;
                pbUnsearch.Top = 112;
            }
            if (login.jabatanUser == "Admin")
            {
                masterUserToolStripMenuItem.Visible = true;
                lblBranch.Text = "";
                loadSSH("Admin", ref cbSales);
                pbAdd.Enabled = true;
                lblSales.Visible = true;
                cbSales.Visible = true;
            }
            else if (login.jabatanUser == "Manager")
            {
                masterUserToolStripMenuItem.Visible = false;
                lblBranch.Text = login.branchUser;
                Object idBranch = login.db.executeScalar($"Select id_branch from branch where branch_name='{login.branchUser}'");
                loadSSH("Manager", ref cbSales, idBranch.ToString());
                pbAdd.Enabled = false;
                lblSales.Visible = true;
                cbSales.Visible = true;

            }
            else if (login.jabatanUser == "Sales")
            {
                masterUserToolStripMenuItem.Visible = false;
                lblBranch.Text = login.branchUser;
                lblSales.Visible = false;
                cbSales.Visible = false;
                pbAdd.Enabled = true;
            }
            lblUser.Text = login.namaUser + " (" + login.jabatanUser + ")";
            loadSSHcb("THIRD_PARTY_TYPE", ref cbType);
            loadSSHcb("ACTIVE_STATUS", ref cbStatus);
            loadDGV();
        }

        public void loadDGV(string name = "", string alias = "", string id = "", string city = "", string code = "",string phone = "",string type="",string status="")
        {
            dgvTP.Columns.Clear();
            if (login.jabatanUser == "Manager")
            {
                if (cbSales.Items.Count > 0)
                {
                    if (type != "0" && status != "2")
                    {
                        dgvTP.DataSource = login.db.executeDataTable($"SELECT FORMAL_NAME AS NAME,ALIAS_NAME AS ALIAS, ID_THIRD_PARTY AS CODE,CITY,POSTAL_CODE AS POSTCODE,PHONE_NUMBER AS PHONE,CASE THIRD_PARTY_TYPE WHEN '1' THEN 'PROSPECT' WHEN '2' THEN 'CUSTOMER' WHEN '3' THEN 'VENDOR' WHEN '4' THEN 'OTHERS' END AS TYPE,CASE ACTIVE_STATUS WHEN '0' THEN 'NON ACTIVE' WHEN '1' THEN 'ACTIVE' END AS STATE FROM THIRD_PARTY WHERE FORMAL_NAME like '%{name}%' AND ALIAS_NAME like '%{alias}%' AND ID_THIRD_PARTY like '%{id}%' AND CITY like '%{city}%' AND POSTAL_CODE like '%{code}%' AND PHONE_NUMBER like '%{phone}%' AND THIRD_PARTY_TYPE like '%{type}%' AND ACTIVE_STATUS like '%{status}%' AND USER_ROW_ID={cbSales.SelectedValue} ORDER BY 1");
                    }
                    else if (type != "0" && status == "2")
                    {
                        dgvTP.DataSource = login.db.executeDataTable($"SELECT FORMAL_NAME AS NAME,ALIAS_NAME AS ALIAS, ID_THIRD_PARTY AS CODE,CITY,POSTAL_CODE AS POSTCODE,PHONE_NUMBER AS PHONE,CASE THIRD_PARTY_TYPE WHEN '1' THEN 'PROSPECT' WHEN '2' THEN 'CUSTOMER' WHEN '3' THEN 'VENDOR' WHEN '4' THEN 'OTHERS' END AS TYPE,CASE ACTIVE_STATUS WHEN '0' THEN 'NON ACTIVE' WHEN '1' THEN 'ACTIVE' END AS STATE FROM THIRD_PARTY WHERE FORMAL_NAME like '%{name}%' AND ALIAS_NAME like '%{alias}%' AND ID_THIRD_PARTY like '%{id}%' AND CITY like '%{city}%' AND POSTAL_CODE like '%{code}%' AND PHONE_NUMBER like '%{phone}%' AND THIRD_PARTY_TYPE like '%{type}%' AND ACTIVE_STATUS like '%{""}%' AND USER_ROW_ID={cbSales.SelectedValue} ORDER BY 1");
                    }
                    else if (type == "0" && status != "2")
                    {
                        dgvTP.DataSource = login.db.executeDataTable($"SELECT FORMAL_NAME AS NAME,ALIAS_NAME AS ALIAS, ID_THIRD_PARTY AS CODE,CITY,POSTAL_CODE AS POSTCODE,PHONE_NUMBER AS PHONE,CASE THIRD_PARTY_TYPE WHEN '1' THEN 'PROSPECT' WHEN '2' THEN 'CUSTOMER' WHEN '3' THEN 'VENDOR' WHEN '4' THEN 'OTHERS' END AS TYPE,CASE ACTIVE_STATUS WHEN '0' THEN 'NON ACTIVE' WHEN '1' THEN 'ACTIVE' END AS STATE FROM THIRD_PARTY WHERE FORMAL_NAME like '%{name}%' AND ALIAS_NAME like '%{alias}%' AND ID_THIRD_PARTY like '%{id}%' AND CITY like '%{city}%' AND POSTAL_CODE like '%{code}%' AND PHONE_NUMBER like '%{phone}%' AND THIRD_PARTY_TYPE like '%{""}%' AND ACTIVE_STATUS like '%{status}%' AND USER_ROW_ID={cbSales.SelectedValue} ORDER BY 1");
                    }
                    else
                    {
                        dgvTP.DataSource = login.db.executeDataTable($"SELECT FORMAL_NAME AS NAME,ALIAS_NAME AS ALIAS, ID_THIRD_PARTY AS CODE,CITY,POSTAL_CODE AS POSTCODE,PHONE_NUMBER AS PHONE,CASE THIRD_PARTY_TYPE WHEN '1' THEN 'PROSPECT' WHEN '2' THEN 'CUSTOMER' WHEN '3' THEN 'VENDOR' WHEN '4' THEN 'OTHERS' END AS TYPE,CASE ACTIVE_STATUS WHEN '0' THEN 'NON ACTIVE' WHEN '1' THEN 'ACTIVE' END AS STATE FROM THIRD_PARTY WHERE FORMAL_NAME like '%{name}%' AND ALIAS_NAME like '%{alias}%' AND ID_THIRD_PARTY like '%{id}%' AND CITY like '%{city}%' AND POSTAL_CODE like '%{code}%' AND PHONE_NUMBER like '%{phone}%' AND THIRD_PARTY_TYPE like '%{""}%' AND ACTIVE_STATUS like '%{""}%' AND USER_ROW_ID={cbSales.SelectedValue} ORDER BY 1");
                    }
                }
                else
                {
                    dgvTP.DataSource = login.db.executeDataTable($"SELECT FORMAL_NAME AS NAME,ALIAS_NAME AS ALIAS, ID_THIRD_PARTY AS CODE,CITY,POSTAL_CODE AS POSTCODE,PHONE_NUMBER AS PHONE,CASE THIRD_PARTY_TYPE WHEN '1' THEN 'PROSPECT' WHEN '2' THEN 'CUSTOMER' WHEN '3' THEN 'VENDOR' WHEN '4' THEN 'OTHERS' END AS TYPE,CASE ACTIVE_STATUS WHEN '0' THEN 'NON ACTIVE' WHEN '1' THEN 'ACTIVE' END AS STATE FROM THIRD_PARTY WHERE 1=2");
                    cbSales.SelectedIndex = -1;
                    cbSales.Text = "";
                }
            }
            else if (login.jabatanUser == "Sales")
            {
                if (type != "0" && status != "2")
                {
                    dgvTP.DataSource = login.db.executeDataTable($"SELECT FORMAL_NAME AS NAME,ALIAS_NAME AS ALIAS, ID_THIRD_PARTY AS CODE,CITY,POSTAL_CODE AS POSTCODE,PHONE_NUMBER AS PHONE,CASE THIRD_PARTY_TYPE WHEN '1' THEN 'PROSPECT' WHEN '2' THEN 'CUSTOMER' WHEN '3' THEN 'VENDOR' WHEN '4' THEN 'OTHERS' END AS TYPE,CASE ACTIVE_STATUS WHEN '0' THEN 'NON ACTIVE' WHEN '1' THEN 'ACTIVE' END AS STATE FROM THIRD_PARTY WHERE FORMAL_NAME like '%{name}%' AND ALIAS_NAME like '%{alias}%' AND ID_THIRD_PARTY like '%{id}%' AND CITY like '%{city}%' AND POSTAL_CODE like '%{code}%' AND PHONE_NUMBER like '%{phone}%' AND THIRD_PARTY_TYPE like '%{type}%' AND ACTIVE_STATUS like '%{status}%' AND USER_ROW_ID={login.idUser} ORDER BY 1");
                }
                else if (type != "0" && status == "2")
                {
                    dgvTP.DataSource = login.db.executeDataTable($"SELECT FORMAL_NAME AS NAME,ALIAS_NAME AS ALIAS, ID_THIRD_PARTY AS CODE,CITY,POSTAL_CODE AS POSTCODE,PHONE_NUMBER AS PHONE,CASE THIRD_PARTY_TYPE WHEN '1' THEN 'PROSPECT' WHEN '2' THEN 'CUSTOMER' WHEN '3' THEN 'VENDOR' WHEN '4' THEN 'OTHERS' END AS TYPE,CASE ACTIVE_STATUS WHEN '0' THEN 'NON ACTIVE' WHEN '1' THEN 'ACTIVE' END AS STATE FROM THIRD_PARTY WHERE FORMAL_NAME like '%{name}%' AND ALIAS_NAME like '%{alias}%' AND ID_THIRD_PARTY like '%{id}%' AND CITY like '%{city}%' AND POSTAL_CODE like '%{code}%' AND PHONE_NUMBER like '%{phone}%' AND THIRD_PARTY_TYPE like '%{type}%' AND ACTIVE_STATUS like '%{""}%' AND USER_ROW_ID={login.idUser} ORDER BY 1");
                }
                else if (type == "0" && status != "2")
                {
                    dgvTP.DataSource = login.db.executeDataTable($"SELECT FORMAL_NAME AS NAME,ALIAS_NAME AS ALIAS, ID_THIRD_PARTY AS CODE,CITY,POSTAL_CODE AS POSTCODE,PHONE_NUMBER AS PHONE,CASE THIRD_PARTY_TYPE WHEN '1' THEN 'PROSPECT' WHEN '2' THEN 'CUSTOMER' WHEN '3' THEN 'VENDOR' WHEN '4' THEN 'OTHERS' END AS TYPE,CASE ACTIVE_STATUS WHEN '0' THEN 'NON ACTIVE' WHEN '1' THEN 'ACTIVE' END AS STATE FROM THIRD_PARTY WHERE FORMAL_NAME like '%{name}%' AND ALIAS_NAME like '%{alias}%' AND ID_THIRD_PARTY like '%{id}%' AND CITY like '%{city}%' AND POSTAL_CODE like '%{code}%' AND PHONE_NUMBER like '%{phone}%' AND THIRD_PARTY_TYPE like '%{""}%' AND ACTIVE_STATUS like '%{status}%' AND USER_ROW_ID={login.idUser} ORDER BY 1");
                }
                else
                {
                    dgvTP.DataSource = login.db.executeDataTable($"SELECT FORMAL_NAME AS NAME,ALIAS_NAME AS ALIAS, ID_THIRD_PARTY AS CODE,CITY,POSTAL_CODE AS POSTCODE,PHONE_NUMBER AS PHONE,CASE THIRD_PARTY_TYPE WHEN '1' THEN 'PROSPECT' WHEN '2' THEN 'CUSTOMER' WHEN '3' THEN 'VENDOR' WHEN '4' THEN 'OTHERS' END AS TYPE,CASE ACTIVE_STATUS WHEN '0' THEN 'NON ACTIVE' WHEN '1' THEN 'ACTIVE' END AS STATE FROM THIRD_PARTY WHERE FORMAL_NAME like '%{name}%' AND ALIAS_NAME like '%{alias}%' AND ID_THIRD_PARTY like '%{id}%' AND CITY like '%{city}%' AND POSTAL_CODE like '%{code}%' AND PHONE_NUMBER like '%{phone}%' AND THIRD_PARTY_TYPE like '%{""}%' AND ACTIVE_STATUS like '%{""}%' AND USER_ROW_ID={login.idUser} ORDER BY 1");
                }
            }
            else
            {
                if (cbSales.Items.Count > 0)
                {
                    if (login.jabatanUser == "Admin")
                    {
                        if (type != "0" && status != "2")
                        {
                            dgvTP.DataSource = login.db.executeDataTable($"SELECT FORMAL_NAME AS NAME,ALIAS_NAME AS ALIAS, ID_THIRD_PARTY AS CODE,CITY,POSTAL_CODE AS POSTCODE,PHONE_NUMBER AS PHONE,CASE THIRD_PARTY_TYPE WHEN '1' THEN 'PROSPECT' WHEN '2' THEN 'CUSTOMER' WHEN '3' THEN 'VENDOR' WHEN '4' THEN 'OTHERS' END AS TYPE,CASE ACTIVE_STATUS WHEN '0' THEN 'NON ACTIVE' WHEN '1' THEN 'ACTIVE' END AS STATE FROM THIRD_PARTY WHERE FORMAL_NAME like '%{name}%' AND ALIAS_NAME like '%{alias}%' AND ID_THIRD_PARTY like '%{id}%' AND CITY like '%{city}%' AND POSTAL_CODE like '%{code}%' AND PHONE_NUMBER like '%{phone}%' AND THIRD_PARTY_TYPE like '%{type}%' AND ACTIVE_STATUS like '%{status}%' AND USER_ROW_ID={cbSales.SelectedValue} ORDER BY 1");
                        }
                        else if (type != "0" && status == "2")
                        {
                            dgvTP.DataSource = login.db.executeDataTable($"SELECT FORMAL_NAME AS NAME,ALIAS_NAME AS ALIAS, ID_THIRD_PARTY AS CODE,CITY,POSTAL_CODE AS POSTCODE,PHONE_NUMBER AS PHONE,CASE THIRD_PARTY_TYPE WHEN '1' THEN 'PROSPECT' WHEN '2' THEN 'CUSTOMER' WHEN '3' THEN 'VENDOR' WHEN '4' THEN 'OTHERS' END AS TYPE,CASE ACTIVE_STATUS WHEN '0' THEN 'NON ACTIVE' WHEN '1' THEN 'ACTIVE' END AS STATE FROM THIRD_PARTY WHERE FORMAL_NAME like '%{name}%' AND ALIAS_NAME like '%{alias}%' AND ID_THIRD_PARTY like '%{id}%' AND CITY like '%{city}%' AND POSTAL_CODE like '%{code}%' AND PHONE_NUMBER like '%{phone}%' AND THIRD_PARTY_TYPE like '%{type}%' AND ACTIVE_STATUS like '%{""}%' AND USER_ROW_ID={cbSales.SelectedValue} ORDER BY 1");
                        }
                        else if (type == "0" && status != "2")
                        {
                            dgvTP.DataSource = login.db.executeDataTable($"SELECT FORMAL_NAME AS NAME,ALIAS_NAME AS ALIAS, ID_THIRD_PARTY AS CODE,CITY,POSTAL_CODE AS POSTCODE,PHONE_NUMBER AS PHONE,CASE THIRD_PARTY_TYPE WHEN '1' THEN 'PROSPECT' WHEN '2' THEN 'CUSTOMER' WHEN '3' THEN 'VENDOR' WHEN '4' THEN 'OTHERS' END AS TYPE,CASE ACTIVE_STATUS WHEN '0' THEN 'NON ACTIVE' WHEN '1' THEN 'ACTIVE' END AS STATE FROM THIRD_PARTY WHERE FORMAL_NAME like '%{name}%' AND ALIAS_NAME like '%{alias}%' AND ID_THIRD_PARTY like '%{id}%' AND CITY like '%{city}%' AND POSTAL_CODE like '%{code}%' AND PHONE_NUMBER like '%{phone}%' AND THIRD_PARTY_TYPE like '%{""}%' AND ACTIVE_STATUS like '%{status}%' AND USER_ROW_ID={cbSales.SelectedValue} ORDER BY 1");
                        }
                        else
                        {
                            dgvTP.DataSource = login.db.executeDataTable($"SELECT FORMAL_NAME AS NAME,ALIAS_NAME AS ALIAS, ID_THIRD_PARTY AS CODE,CITY,POSTAL_CODE AS POSTCODE,PHONE_NUMBER AS PHONE,CASE THIRD_PARTY_TYPE WHEN '1' THEN 'PROSPECT' WHEN '2' THEN 'CUSTOMER' WHEN '3' THEN 'VENDOR' WHEN '4' THEN 'OTHERS' END AS TYPE,CASE ACTIVE_STATUS WHEN '0' THEN 'NON ACTIVE' WHEN '1' THEN 'ACTIVE' END AS STATE FROM THIRD_PARTY WHERE FORMAL_NAME like '%{name}%' AND ALIAS_NAME like '%{alias}%' AND ID_THIRD_PARTY like '%{id}%' AND CITY like '%{city}%' AND POSTAL_CODE like '%{code}%' AND PHONE_NUMBER like '%{phone}%' AND THIRD_PARTY_TYPE like '%{""}%' AND ACTIVE_STATUS like '%{""}%' AND USER_ROW_ID={cbSales.SelectedValue} ORDER BY 1");
                        }
                    }
                }
            }
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
            if(cbStatus.SelectedIndex == 1)
                loadDGV(tbName.Text, tbAlias.Text, tbCode.Text, tbCity.Text, tbPostcode.Text, tbPhone.Text, (cbType.SelectedIndex).ToString(), "0");
            else if(cbStatus.SelectedIndex == 2)
                loadDGV(tbName.Text, tbAlias.Text, tbCode.Text, tbCity.Text, tbPostcode.Text, tbPhone.Text, (cbType.SelectedIndex).ToString(), "1");
            else
                loadDGV(tbName.Text, tbAlias.Text, tbCode.Text, tbCity.Text, tbPostcode.Text, tbPhone.Text, (cbType.SelectedIndex).ToString(), "2");
        }

        public void loadSSHcb(string parameter, ref ComboBox cb)
        {
            cb.DataSource = login.db.executeDataTable($"SELECT * FROM SSH_VARIABLES WHERE TIPE='{parameter}' ORDER BY CASE WHEN ISI = 'ALL' THEN 0 ELSE 1 END,1");
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
            string idUser = "";
            login.hThirdParty.judul = "Edit Third Party";
            Object id = login.db.executeScalar($"SELECT ID_THIRD_PARTY FROM THIRD_PARTY WHERE FORMAL_NAME='{dgvTP.Rows[e.RowIndex].Cells[0].Value.ToString()}'");
            login.hThirdParty.id = id.ToString();
            if (cbSales.Items.Count > 0)
            {
                idUser = cbSales.SelectedValue.ToString();
            }
            else
            {
                idUser = login.idUser;
            }
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
            loadDGV();
        }
    }
}
