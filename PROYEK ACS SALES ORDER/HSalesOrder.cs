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
    public partial class HSalesOrder : Form
    {
        public Login login;
        public String[] arrData;
        public DateTime[] arrDate;
        public Boolean editDone, awalLoad;
        /*ARR DATA
            0 = third party
            1 = status
            2 = contact
            3 = terms
            4 = type
            5 = notes
          ARR DATE
            0 = order created date
            1 = delivery date
        */

        public HSalesOrder(Login login)
        {
            InitializeComponent();
            this.login = login;
            this.arrData = new String[6];
            this.arrDate = new DateTime[2];
            setDtpFormat(ref dtpDelivery);
            setDtpFormat(ref dtpDate);
            editDone = false;
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public Boolean editMode, statusBilled;
        public int userId;
        public int statusJabatan;
        public int orderRowId;
        public String invoiceNumber;
        public String userIdBranch;

        DataSet ds;

        public void loadBranch()
        {
            userIdBranch = login.db.executeScalar($"select id_branch from user_data where user_row_id = '{userId}'").ToString();
        }

        public void loadLabelOrderRow(ref Label lbl)
        {
            lbl.Text = orderRowId.ToString();
        }

        private void resetField()
        {
            dtpDate.Value = DateTime.Now;
            dtpDelivery.Value = DateTime.Now;
            tbNotes.Clear();
            tbContact.Clear();
        }

        public void setDtpFormat(ref DateTimePicker dtp)
        {
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd/MM/yyyy";
        }
        
        private void loadCbStatus(int statusJabatan, ref ComboBox cb)
        {
            /*status jabatan
             1 = admin
             2 = manager
             3 = sales
            */
            String connStr = "";
            ds = new DataSet();
            
            connStr = "select tipe, initcap(isi) as isi from ssh_variables where tipe = 'ORDER_STATUS'";
            if (statusJabatan == 2) //manager
            {
                connStr += " and isi = 'VALIDATED' or LOWER(tipe) = 'order_status' and isi = 'REJECTED'";
            }
            else if (statusJabatan == 3) //sales
            {
                connStr += " and isi = 'DRAFT' or LOWER(tipe) = 'order_status' and isi = 'CANCELLED'";
            }

            login.db.executeDataSet(connStr, ref ds, "status");
            for (int i = 0; i < ds.Tables["status"].Rows.Count; i++)
            {
                cb.Items.Add(ds.Tables["status"].Rows[i]["isi"]);
            }
        }


        private void loadCbStatus(int statusJabatan, ref ComboBox cb, int orderRowId)
        {
            /*status jabatan
             1 = admin
             2 = manager
             3 = sales
            */
            cb.Items.Clear();
            String statusOrder = "";
            ds = new DataSet();
            try
            {
                if (login.db.executeScalar($"select INITCAP(order_status) from h_sorder where order_row_id = '{orderRowId}'") != null)
                {
                    statusOrder = login.db.executeScalar($"select INITCAP(order_status) from h_sorder where order_row_id = '{orderRowId}'").ToString();
                }

                Boolean masihBisaMilih = false;
                if (statusOrder != "") //ada status nya -> bukan add -> langsung selected aja tapi dicek dulu
                {
                    if (statusJabatan == 1)
                    {
                        masihBisaMilih = true;
                    }
                    else if (statusJabatan == 2) //manager
                    {
                        if (statusOrder == "Pending")
                        {
                            masihBisaMilih = true;
                        }
                    }
                    else if (statusJabatan == 3) //sales
                    {
                        if (statusOrder == "Draft")
                        {
                            masihBisaMilih = true;
                        }
                    }

                    if (masihBisaMilih)
                    {
                        loadCbStatus(statusJabatan, ref cb);
                        cb.Enabled = true;

                        if (statusOrder == "Pending" && statusJabatan == 2)
                        {
                            cb.Items.Add("Pending");
                            cb.SelectedIndex = cb.Items.Count - 1;
                        }
                        else
                        {
                            int idxCurrentStatus = cb.FindStringExact(statusOrder);
                            cb.SelectedIndex = idxCurrentStatus;
                        }
                    }
                    else
                    {
                        cb.Items.Add(statusOrder);
                        cb.Enabled = false;
                        cb.SelectedIndex = 0;
                    }
                }
                else //gaada statusnya -> ngeadd -> load berjalan
                {
                    loadCbStatus(statusJabatan, ref cb);
                    cb.Enabled = true;
                    cb.SelectedIndex = 0;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "load combobox status failed");
                //throw;
            }
        }

        private void setCbSelectedIndex(String str, ref ComboBox cb)
        {
            int idx = -1;
            idx = cb.FindStringExact(str);
            if (idx >= 0)
            {
                cb.SelectedIndex = idx;
            }
        }

        private void loadCbThirdParty(ref ComboBox cb)
        {
            ds = new DataSet();
            login.db.executeDataSet($"select id, formal from v_third_party", ref ds, "tp");
            cb.DataSource = ds.Tables["tp"];
            cb.DisplayMember = "formal";
            cb.ValueMember = "id";

            if (editMode)
            {
                Object tpId = login.db.executeScalar($"select id_third_party from h_sorder where order_row_id = '{orderRowId}'");
                Object o = login.db.executeScalar($"SELECT INITCAP(TP.FORMAL_NAME) FROM THIRD_PARTY TP, H_SORDER H WHERE H.ID_THIRD_PARTY = TP.ID_THIRD_PARTY AND TP.ID_THIRD_PARTY = '{tpId.ToString()}'");
                setCbSelectedIndex(o.ToString(), ref cb);                
            }
        }

        private void loadCbPaymentTerms(ref ComboBox cb)
        {
            ds = new DataSet();

            login.db.executeDataSet("select INITCAP(isi) as isi from ssh_variables where tipe = 'PAYMENT_TERMS'", ref ds, "payterms");
            cb.DataSource = ds.Tables["payterms"];
            cb.DisplayMember = "isi";
            cb.ValueMember = "isi";

            if (editMode)
            {
                Object oTerms = login.db.executeScalar($"select payment_terms from h_sorder where order_row_id = '{orderRowId}'");
                setCbSelectedIndex(oTerms.ToString(), ref cb);
            }
            else
            {
                resetField();
            }
        }

        private void loadCbPaymentType(ref ComboBox cb)
        {
            ds = new DataSet();

            login.db.executeDataSet("select initcap(isi) as isi from ssh_variables where tipe = 'PAYMENT_TYPE'", ref ds, "paytype");
            cb.DataSource = ds.Tables["paytype"];
            cb.DisplayMember = "isi";
            cb.ValueMember = "isi";
            if (editMode)
            {
                Object oType = login.db.executeScalar($"select payment_type from h_sorder where order_row_id = '{orderRowId}'");
                setCbSelectedIndex(oType.ToString(), ref cb);
            }
            else
            {
                resetField();
            }
        }
        
        private void setNonNumericKeypress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dtpDelivery.Value < dtpDate.Value)
            {
                MessageBox.Show("the delivery date must be after the order created date", "Order Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (editMode && orderRowId >= 0)
                {
                    String query = $"update h_sorder set id_third_party = '{cbTP.SelectedValue.ToString()}' , order_status = '{cbStatus.SelectedItem.ToString()}' , customer_name = '{tbContact.Text}', payment_terms = '{cbPTerms.SelectedValue.ToString()}', payment_type = '{cbPType.SelectedValue.ToString()}',notes = '{tbNotes.Text}' where order_row_id = {orderRowId}";
                    login.db.executeNonQuery(query);

                    //harus manual, parameter tanggal ga jalan di query pake model yang di atas
                    try
                    {
                        OracleConnection conn = new OracleConnection("data source = " + login.dbSource + ";user id = " + login.dbUser + ";password = " + login.dbPass);
                        conn.Open();
                        OracleCommand cmd = new OracleCommand("update h_sorder set order_created_date = :created, delivery_date = :deliver where order_row_id = :id", conn);
                        cmd.Parameters.Add(":created", dtpDate.Value);
                        cmd.Parameters.Add(":deliver", dtpDelivery.Value);
                        cmd.Parameters.Add(":id", orderRowId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("All changes are saved!", "Editing Order Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message, "editing header failed");
                    }
                }

                /*
                    0 = third party
                    1 = status
                    2 = contact
                    3 = terms
                    4 = type
                    5 = notes
                 */

                arrData[0] = cbTP.SelectedValue.ToString();
                arrData[1] = cbStatus.SelectedItem.ToString();
                arrData[2] = tbContact.Text;
                arrData[3] = cbPTerms.SelectedValue.ToString();
                arrData[4] = cbPType.SelectedValue.ToString();
                arrData[5] = tbNotes.Text;
                arrDate[0] = dtpDate.Value;
                arrDate[1] = dtpDelivery.Value;

                login.dSales.closingForm = false;
                login.dSales.ShowDialog();

                if (editDone)
                {
                    this.Hide();
                }
            }
            
        }

        private void loadTbContact(ref TextBox tb)
        {
            if (editMode)
            {
                Object oNama = login.db.executeScalar($"select INITCAP(customer_name) from h_sorder where order_row_id = '{orderRowId}'");
                tb.Text = oNama.ToString();
            }
            else
            {
                resetField();
            }
        }

        private void tbContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            setNonNumericKeypress(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetField();
            this.Hide();
        }

        private void HSalesOrder_VisibleChanged(object sender, EventArgs e)
        {
            awalLoad = true;
            editDone = false;
            orderRowId = getOrderRowId();
            userId = Convert.ToInt32(login.idUser);
            statusBilled = true;
            statusJabatan = getStatusJabatan();
            loadBranch();
            loadLabelOrderRow(ref lblSOCode);
            loadCbStatus(statusJabatan, ref cbStatus, orderRowId);
            loadCbThirdParty(ref cbTP);
            loadCbPaymentTerms(ref cbPTerms);
            loadCbPaymentType(ref cbPType);
            loadTbContact(ref tbContact);
            loadStatusBilled(ref lblBilled, ref btnBill);
            loadDate(ref dtpDate, "order_created_date");
            loadDate(ref dtpDelivery, "delivery_date");
            awalLoad = false;
        }

        private void loadDate(ref DateTimePicker dtp, String field)
        {
            Object o;
            o = login.db.executeScalar($"select {field} from h_sorder where order_row_id = {orderRowId}");
            if (o != null)
            {
                dtp.Value = (DateTime)o;
            }
            else
            {
                dtp.Value = DateTime.Now;
            }            

        }

        private int getStatusJabatan()
        {
            int status = -1;
            if (login.jabatanUser == "Admin")
            {
                status = 1;
            }
            else if (login.jabatanUser == "Manager")
            {
                status = 2;
            }
            else if (login.jabatanUser == "Sales")
            {
                status = 3;
            }
            return status;
        }

        private int getOrderRowId()
        {
            int id = -1;
            if (editMode)
            {
                Object o = login.db.executeScalar($"select order_row_id from h_sorder where invoice_number = '{invoiceNumber}'");
                id = Convert.ToInt32(o);
            }
            else
            {
                Object o = login.db.executeScalar("select count(order_row_id) + 1 from h_sorder");
                id = Convert.ToInt32(o);
            }
            return id;
        }

        private void lbl__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            loadStatusBilled(ref lblBilled, ref btnBill);
        }

        private void changeBilled(ref Label lbl, ref Button b, Boolean billed)
        {
            if (billed)
            {
                b.Text = "Not Billed";
                lbl.Text = "Yes";
            }
            else
            {
                b.Text = "Billed";
                lbl.Text = "No";
            }
        }

        private void checkDateFocusLeave(ref DateTimePicker dtp)
        {
            if (dtpDelivery.Value < dtpDate.Value)
            {
                dtp.Focus();
                btnSubmit.Enabled = false;
                MessageBox.Show("the delivery date must be after the order created date", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnSubmit.Enabled = true;
            }
        }
        
        private void dtpDelivery_Leave(object sender, EventArgs e)
        {
            checkDateFocusLeave(ref dtpDelivery);
        }

        private void dtpDate_Leave(object sender, EventArgs e)
        {
            checkDateFocusLeave(ref dtpDate);
        }
        
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void loadStatusBilled(ref Label lbl, ref Button b)
        {
            if (editMode)
            {
                if (awalLoad)
                {
                    Object o = login.db.executeScalar($"select lower(status_billed) as status from h_sorder where order_row_id = '{orderRowId}'");
                    String status = o.ToString();
                    if (status.ToLower() == "yes")
                    {
                        statusBilled = true;
                    }
                    else
                    {
                        statusBilled = false;
                    }
                }
                else
                {
                    statusBilled = !statusBilled;
                }
            }
            else
            {
                statusBilled = !statusBilled;

            }
            changeBilled(ref lbl, ref b, statusBilled);
        }
    }
}
