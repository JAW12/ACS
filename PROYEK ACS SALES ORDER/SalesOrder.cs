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
    public partial class SalesOrder : Form
    {
        public Login login;
        public String invoiceNumber;
        public int salesRowID, idxSalesRep;
        Boolean editMode;

        public SalesOrder(Login login)
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


        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.contact.Show();
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
            login.print.ShowDialog();
        }

        private void pbStatistic_Click(object sender, EventArgs e)
        {
            login.statistic.tipe = "SO";
            login.statistic.ShowDialog();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            if(login.jabatanUser != "Manager") { 
                resetHOrder();
                login.hSales.ShowDialog();

                //tambahan winda untuk munculin orderan baru/perubahan orderan
                loadDataTable();
                loadDGV();
            }
            else
            {
                MessageBox.Show("Manager Tidak Bisa Menambahkan Sales Order");
            }
        }

        public void resetHOrder()
        {
            login.hSales.editMode = false;
            for (int i = 0; i < 6; i++)
            {
                login.hSales.arrData[0] = "-";
                if (i < 2)
                {
                    login.hSales.arrDate[i] = DateTime.Now;
                }
            }
            
        }

        private void SalesOrder_VisibleChanged(object sender, EventArgs e)
        {
            invoiceNumber = "";
            foreach (DataGridViewRow row in dgvHOrder.Rows)
            {
                row.Cells[9].Value = false;
            }

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
            idBranch = login.db.executeScalar($"SELECT ID_BRANCH FROM BRANCH WHERE BRANCH_NAME = '{login.branchUser}'").ToString();
            if (login.jabatanUser == "Sales")
            {
                loadCBSales();
                cbSales.Visible = false;
                lblSales.Visible = false;
            }
            else
            {
                cbSales.Visible = true;
                lblSales.Visible = true;
                loadCBSales();
            }
            
            loadCBDate();
            loadDataTable();
            loadDGV();
            loadCBAction();
            loadCBBill();
            loadCBStatus();
        }

        private void loadCBSales()
        {
            if (login.jabatanUser == "Admin")
            {
                ds = new DataSet();
                login.db.executeDataSet($"SELECT NULL AS \"USER_ROW_ID\", NULL AS \"U_NAME\" FROM DUAL UNION SELECT USER_ROW_ID, U_NAME FROM USER_DATA WHERE U_STATUS <> 2 ORDER BY 2 NULLS FIRST ", ref ds, "sales");
                cbSales.DataSource = ds.Tables["sales"];
                cbSales.DisplayMember = "U_NAME";
                cbSales.ValueMember = "USER_ROW_ID";
            }
            else if(login.jabatanUser == "Manager")
            {
                ds = new DataSet();
                login.db.executeDataSet($"SELECT NULL AS \"USER_ROW_ID\", '' AS \"U_NAME\" FROM DUAL UNION SELECT USER_ROW_ID, U_NAME FROM USER_DATA WHERE ID_BRANCH = '{idBranch}' AND U_STATUS <> 2 ORDER BY 2 ASC NULLS FIRST", ref ds, "sales");
                cbSales.DataSource = ds.Tables["sales"];
                cbSales.DisplayMember = "U_NAME";
                cbSales.ValueMember = "USER_ROW_ID";
            }
            else if(login.jabatanUser == "Sales")
            {
                ds = new DataSet();
                login.db.executeDataSet($"SELECT USER_ROW_ID, U_NAME FROM USER_DATA WHERE ID_BRANCH = '{idBranch}' AND USER_ROW_ID = {login.idUser} AND U_STATUS <> 2 ORDER BY 2 ASC NULLS FIRST", ref ds, "sales");
                cbSales.DataSource = ds.Tables["sales"];
                cbSales.DisplayMember = "U_NAME";
                cbSales.ValueMember = "USER_ROW_ID";
            }
        }
        string idBranch;
        DataSet ds;
        private void loadDataTable()
        {
            ds = new DataSet();
            login.db.executeDataSet($"SELECT H.INVOICE_NUMBER AS \"INV NUMBER\", T.FORMAL_NAME AS \"NAME\", T.CITY, T.POSTAL_CODE AS \"POSTAL CODE\", TO_CHAR(H.ORDER_CREATED_DATE, 'DD/MM/YYYY') AS \"ORDER DATE\", TO_CHAR(H.DELIVERY_DATE, 'DD/MM/YYYY') AS \"DELIVERY DATE\", H.NET_TOTAL AS \"TOTAL\", INITCAP(H.STATUS_BILLED) AS \"BILLED\", H.ORDER_STATUS AS \"STATUS\" FROM H_SORDER H, THIRD_PARTY T WHERE H.ID_THIRD_PARTY = T.ID_THIRD_PARTY AND H.INVOICE_NUMBER LIKE '%{tbCode.Text}%' AND T.FORMAL_NAME LIKE '%{tbTP.Text}%' AND T.CITY LIKE '%{tbCity.Text}%' AND T.POSTAL_CODE LIKE '%{tbPostcode.Text}%' AND TO_CHAR(H.ORDER_CREATED_DATE, 'MM') LIKE '%{cbMOrder.Text}%' AND TO_CHAR(H.ORDER_CREATED_DATE, 'YYYY') LIKE '%{cbTOrder.Text}%' AND TO_CHAR(H.DELIVERY_DATE, 'MM') LIKE '%{cbMDelivery.Text}%' AND TO_CHAR(H.DELIVERY_DATE, 'YYYY') LIKE '%{cbTDelivery.Text}%' AND H.NET_TOTAL LIKE '%{tbTotal.Text}%' AND H.STATUS_BILLED LIKE '%{cbBill.Text.ToUpper()}%' AND H.ORDER_STATUS LIKE '%{cbStatus.Text}%' AND SALES_ROW_ID LIKE '%{cbSales.SelectedValue}%' ORDER BY 1", ref ds, "dgv");
        }

        private void loadDGV()
        {
            dgvHOrder.Columns.Clear();
            dgvHOrder.DataSource = null;
            dgvHOrder.DataSource = ds.Tables["dgv"];
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.TrueValue = true;
            checkColumn.FalseValue = false;
            checkColumn.Name = "checkBox";
            checkColumn.HeaderText = "CHECK";
            dgvHOrder.Columns.Add(checkColumn);
        }

        private void loadCBDate()
        {
            cbMOrder.Items.Clear();
            cbMDelivery.Items.Clear();
            cbTOrder.Items.Clear();
            cbTDelivery.Items.Clear();

            cbMOrder.Items.Add("");
            cbMDelivery.Items.Add("");
            cbTOrder.Items.Add("");
            cbTDelivery.Items.Add("");
            for (int i = 1; i <= 12; i++)
            {
                cbMOrder.Items.Add(i.ToString());
                cbMDelivery.Items.Add(i.ToString());
            }
            for(int i =0; i <= 30; i++)
            { 
                cbTOrder.Items.Add((2030-i).ToString());
                cbTDelivery.Items.Add((2030-i).ToString());
            }
        }

        private void loadCBBill()
        {
            cbBill.Items.Clear();
            cbBill.Items.Add("");
            cbBill.Items.Add("Yes");
            cbBill.Items.Add("No");
        }

        private void loadCBStatus()
        {
            cbStatus.DataSource = null;
            cbStatus.Items.Clear();
            cbStatus.DataSource = login.db.executeDataTable("SELECT NULL AS ISI FROM DUAL UNION SELECT INITCAP(ISI) FROM SSH_VARIABLES WHERE TIPE = 'ORDER_STATUS' ORDER BY 1 ASC NULLS FIRST");
            cbStatus.DisplayMember = "isi";
            cbStatus.ValueMember = "isi";
        }

        private void loadCBAction()
        {
            cbAction.Items.Clear();

            cbAction.Items.Add("");
            
            if(login.jabatanUser == "Sales" || login.jabatanUser == "Admin")
            {
                cbAction.Items.Add("Cancel");
                cbAction.Items.Add("Pending");
            }
            if (login.jabatanUser == "Manager" || login.jabatanUser == "Admin")
            {
                cbAction.Items.Add("Validate");
                cbAction.Items.Add("Reject");
            }
            if (login.jabatanUser == "Sales" || login.jabatanUser == "Admin")
            {
                cbAction.Items.Add("Billed");
                cbAction.Items.Add("Unbilled");
            }
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            loadDataTable();
            loadDGV();
        }

        private void pbUnsearch_Click(object sender, EventArgs e)
        {
            tbCode.Clear();
            tbTP.Clear();
            tbCity.Clear();
            tbPostcode.Clear();
            cbMOrder.Text = "";
            cbTOrder.Text = "";
            cbMDelivery.Text = "";
            cbTDelivery.Text = "";
            tbTotal.Clear();
            cbBill.Text = "";
            cbStatus.Text = "";
            cbSales.Text = "";
            loadDataTable();
            loadDGV();
        }

        private void dgvHOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                if (dgvHOrder.Rows[e.RowIndex].Cells[9].Value == null || dgvHOrder.Rows[e.RowIndex].Cells[9].Value.ToString() == "False")
                {
                    dgvHOrder.Rows[e.RowIndex].Cells[9].Value = true;
                }
                else
                {
                    dgvHOrder.Rows[e.RowIndex].Cells[9].Value = false;
                }
            }
            else
            {
                invoiceNumber = "";
                editMode = false;
            }
        }

        List<int> rowChecked;
        private void dgvHOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            rowChecked = new List<int>();
            for(int i =0; i < dgvHOrder.Rows.Count; i++)
            {
                DataGridViewRow row = dgvHOrder.Rows[i];
                if (row.Cells[9].Value != null && row.Cells[9].Value.ToString() == "True")
                {
                    rowChecked.Add(i);
                }
            }
            if(rowChecked.Count > 0)
            {
                cbAction.Visible = true;
                btnAction.Visible = true;
            }
            else
            {
                cbAction.Visible = false;
                btnAction.Visible = false;
            }
        }

        private void pbCheck_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvHOrder.Rows)
            {
                row.Cells[9].Value = true;
            }
        }

        private void pbUncheck_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvHOrder.Rows)
            {
                row.Cells[9].Value = false;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            for(int i =0; i < rowChecked.Count; i++)
            {
                if(dgvHOrder.Rows[rowChecked[i]].Cells[8].Value.ToString() == "Draft")
                {
                    if(cbAction.Text == "Cancel")
                    {
                        login.db.executeNonQuery($"UPDATE H_SORDER SET ORDER_STATUS = 'Cancelled' WHERE INVOICE_NUMBER = '{dgvHOrder.Rows[rowChecked[i]].Cells[0].Value.ToString()}'");
                    }
                    else if(cbAction.Text == "Pending")
                    {
                        login.db.executeNonQuery($"UPDATE H_SORDER SET ORDER_STATUS = 'Pending' WHERE INVOICE_NUMBER = '{dgvHOrder.Rows[rowChecked[i]].Cells[0].Value.ToString()}'");
                    }
                }
                else if(dgvHOrder.Rows[rowChecked[i]].Cells[8].Value.ToString() == "Pending")
                {
                    if (cbAction.Text == "Validate")
                    {
                        login.db.executeNonQuery($"UPDATE H_SORDER SET ORDER_STATUS = 'Validated' WHERE INVOICE_NUMBER = '{dgvHOrder.Rows[rowChecked[i]].Cells[0].Value.ToString()}'");
                    }
                    else if (cbAction.Text == "Reject")
                    {
                        login.db.executeNonQuery($"UPDATE H_SORDER SET ORDER_STATUS = 'Rejected' WHERE INVOICE_NUMBER = '{dgvHOrder.Rows[rowChecked[i]].Cells[0].Value.ToString()}'");
                    }
                }

                if(cbAction.Text == "Billed")
                {
                    login.db.executeNonQuery($"UPDATE H_SORDER SET STATUS_BILLED = 'YES' WHERE INVOICE_NUMBER = '{dgvHOrder.Rows[rowChecked[i]].Cells[0].Value.ToString()}'");
                }
                else if(cbAction.Text == "Unbilled")
                {
                    login.db.executeNonQuery($"UPDATE H_SORDER SET STATUS_BILLED = 'NO' WHERE INVOICE_NUMBER = '{dgvHOrder.Rows[rowChecked[i]].Cells[0].Value.ToString()}'");
                }
            }
            loadDataTable();
            loadDGV();
        }

        private void dgvHOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                login.hSales.editMode = true;
                login.hSales.invoiceNumber = dgvHOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
                login.hSales.ShowDialog();

                //tambahan winda untuk munculin orderan baru/perubahan orderan
                loadDataTable();
                loadDGV();
            }
            else
            {

            }
        }
        
        private void cbSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            idxSalesRep = cbSales.SelectedIndex;
        }

        public int getSalesRowId()
        {
            int id = Convert.ToInt32(login.idUser);
            if (idxSalesRep > 0)
            {
                id = Convert.ToInt32(cbSales.SelectedValue);
            }
            return id;
        }
    }
}
