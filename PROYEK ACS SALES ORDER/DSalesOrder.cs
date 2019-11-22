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
    public partial class DSalesOrder : Form
    {
        public Login login;
        public Boolean closingForm;
        public Boolean editDetailMode;
        public Boolean adaPerubahanDetail;
        public String[] arrDataDetailStr;
        public Double[] arrDataDetailAngka;
        public String idProduct;
        public int idxEditDetail;
        /*Str
            0 = product type
            1 = product name
            2 = cost price
            3 = total
          Angka
            0 = qty
            1 = markup
            2 = margin
            3 = reduction
        */

        public DSalesOrder(Login login)
        {
            InitializeComponent();
            this.login = login;
            this.conn = new OracleConnection("data source = " + login.dbSource +";user id = "+ login.dbUser+";password = " + login.dbPass);

            foreach (DataGridViewColumn col in dgvDetail.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            arrDataDetailStr = new String[4];
            arrDataDetailAngka = new Double[4];
        }

        public string idProductBrowse;
        public DataSet transDs;
        OracleTransaction otrans;
        OracleConnection conn;
        OracleDataAdapter da;
        OracleCommand cmd;
        OracleCommandBuilder builder;
        
        private void lbl__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            login.browse.ShowDialog();
            pbSearch_Click(sender, e);
            loadCashflow();
            setButtonPrint();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            login.addProduct.ShowDialog();
            pbSearch_Click(sender, e);
            loadCashflow();
            setButtonPrint();
        }

        private void DSalesOrder_VisibleChanged(object sender, EventArgs e)
        {
            declareArr();
            idProduct = "";
            adaPerubahanDetail = false;
            editDetailMode = false;
            idxEditDetail = -1;
            login.hSales.loadLabelOrderRow(ref lblSOCode);
            setButtonPrint();
            LoadAllData(closingForm);
        }
        
        public void loadDataHeader()
        {
            login.hSales.loadLabelOrderRow(ref lblSOCode);
            lblStatus.Text = login.hSales.arrData[1];
            lblTP.Text = loadNamaTp(login.hSales.arrData[0]);
            lblContact.Text = login.hSales.arrData[2];
            lblPTerms.Text = login.hSales.arrData[3];
            lblPType.Text = login.hSales.arrData[4];
            tbNote.Text = login.hSales.arrData[5];
            lblDate.Text = login.hSales.arrDate[0].ToShortDateString();
            lblDelivery.Text = login.hSales.arrDate[1].ToShortDateString();
        }

        public void setButtonPrint()
        {
            if (login.hSales.editMode)
            {
                if (adaPerubahanDetail)
                {
                    pbPrint.Visible = false;
                }
                else
                {
                    pbPrint.Visible = true;
                }
            }
            else
            {
                pbPrint.Visible = false;
            }

        }

        private void loadDatasetDetail(ref DataGridView dgv, String keyNama, String keyReduction, String keyCostPrice, String keyMargin, String keyMarkup, String keyInpPrice)
        {
            conn.Close();
            conn.Open();
            dgv.DataSource = null;
            transDs = new DataSet();

            String query = $"SELECT PRODUCT_TYPE, PRODUCT_NAME, REDUCTION_RATE, COSTPRICE, MARGIN_RATE, MARKUP_RATE, INPUT_PRICE, ORDER_ROW_ID, QTY, ID_PRODUCT, DETAIL_ROW_ID FROM D_SORDER WHERE ORDER_ROW_ID = {login.hSales.orderRowId}";

            cmd = new OracleCommand(query, conn);
            da = new OracleDataAdapter(cmd);
            builder = new OracleCommandBuilder(da);
            da.InsertCommand = builder.GetInsertCommand();
            da.UpdateCommand = builder.GetUpdateCommand();
            da.DeleteCommand = builder.GetDeleteCommand();

            da.Fill(transDs, "detail");
            conn.Close();
        }

        public void setButtonColumnDelete(ref DataGridView dgv)
        {
            int idxDetailId = dgv.Columns.Count - 2;
            DataGridViewButtonColumn btnDelete = (DataGridViewButtonColumn)dgv.Columns[idxDetailId + 1];
            btnDelete.FlatStyle = FlatStyle.Popup;

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                DataGridViewButtonCell bc = (DataGridViewButtonCell)dgv.Rows[i].Cells[idxDetailId + 1];
                if (dgv.Rows[i].Cells[idxDetailId].Value.ToString() != "")
                {
                    bc.Style.BackColor = Color.FromArgb(224, 222, 222);
                    bc.Style.SelectionBackColor = Color.FromArgb(224, 222, 222);
                    bc.UseColumnTextForButtonValue = false;
                    
                }
                else
                {
                    bc.Style.BackColor = Color.FromArgb(255, 46, 46);
                    bc.Style.SelectionBackColor = Color.FromArgb(240, 58, 58);
                    bc.Style.ForeColor = Color.White;
                    bc.UseColumnTextForButtonValue = true;
                }
            }
        }

        public void declareArr()
        {
            for (int i = 0; i < 4 ; i++)
            {
                arrDataDetailAngka[i] = 0;
                arrDataDetailStr[i] = "";
            }
        }

        public void loadDataDetail(ref DataGridView dgv, String keyNama, String keyReduction, String keyCostPrice, String keyMargin, String keyMarkup, String keyInpPrice, String keyType)
        {
            //reduction rate = input price - cost price
            int ctrCocok = 0;
            dgv.Rows.Clear();
            for (int i = 0; i < transDs.Tables["detail"].Rows.Count; i++)
            {
                ctrCocok = 0;
                if (transDs.Tables["detail"].Rows[i][4] == DBNull.Value)
                {
                    transDs.Tables["detail"].Rows[i][4] = 0;
                }

                if (transDs.Tables["detail"].Rows[i][5] == DBNull.Value)
                {
                    transDs.Tables["detail"].Rows[i][5] = 0;
                }
                
                countFieldSearch(ref ctrCocok, 0, keyType, i);
                countFieldSearch(ref ctrCocok, 1, keyNama, i);
                countFieldSearch(ref ctrCocok, 2, keyReduction, i);
                countFieldSearch(ref ctrCocok, 3, keyCostPrice, i);
                countFieldSearch(ref ctrCocok, 4, keyMargin, i);
                countFieldSearch(ref ctrCocok, 5, keyMarkup, i);
                countFieldSearch(ref ctrCocok, 6, keyInpPrice, i);                

                if (ctrCocok >= 7)
                {
                    DataRow r = transDs.Tables["detail"].Rows[i];
                    Object[] o = r.ItemArray;
                    dgv.Rows.Add(o);
                }
            }
            setButtonColumnDelete(ref dgv);
            loadCashflow();
        }
        
        private void countFieldSearch(ref int ctr, int col, String keyword, int idxRow)
        {
            if (keyword != "")
            {
                if (transDs.Tables["detail"].Rows[idxRow][col].ToString().ToLower().Contains(keyword.ToLower()))
                {
                    ctr++;
                }
            }
            else
            {
                ctr++;
            }
        }

        private void editQueryKeyword(ref String query, String dbField, String keyword)
        {
            if (keyword != "")
            {
                query += $" and UPPER({dbField}) LIKE '%{keyword.ToUpper()}%'";
            }
        }
        
        private void LoadAllData(Boolean closingForm)
        {
            if (!closingForm)
            {
                loadDataHeader();
                loadDatasetDetail(ref dgvDetail, "", "", "", "", "", "");
                loadDataDetail(ref dgvDetail, "","","","","","","");
            }
        }

        public String loadNamaTp(String id)
        {
            String nama = "";
            nama = login.db.executeScalar($"select formal from v_third_party where id = '{id}'").ToString();
            return nama;
        }

        public void resetSearchField()
        {
            tbType.Clear();
            tbName.Clear();
            tbReduction.Clear();
            tbReduction.Clear();
            tbCostP.Clear();
            tbMargin.Clear();
            tbMarkup.Clear();
            tbInputP.Clear();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            loadDataDetail(ref dgvDetail, tbName.Text, tbReduction.Text, tbCostP.Text, tbMargin.Text, tbMarkup.Text, tbInputP.Text, tbType.Text);
        }

        private void pbUnsearch_Click(object sender, EventArgs e)
        {
            resetSearchField();
            loadDataDetail(ref dgvDetail, "", "", "", "", "", "","");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvDetail.Rows.Count < 1)
            {
                if (login.hSales.editMode)
                {
                    MessageBox.Show("there is no data");
                }
                else
                {
                    MessageBox.Show("there is no data");
                }
            }
            else
            {
                conn.Close();
                conn.Open();

                otrans = conn.BeginTransaction();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.Transaction = otrans;

                String msgHeader = "";

                try
                {
                    if (!login.hSales.editMode)
                    {
                        String statusBilled = "NO";
                        if (login.hSales.statusBilled)
                        {
                            statusBilled = "YES";
                        }

                        cmd = new OracleCommand("insert into h_sorder(id_third_party,order_status,customer_name,payment_terms,payment_type,notes,order_created_date,delivery_date, status_billed, sales_row_id) values(:idtp,:status,:cust,:pterms,:ptype,:notes,:created,:delivery,:billed,:idsales)", conn);
                        cmd.Parameters.Add(":idtp", login.hSales.arrData[0]);
                        cmd.Parameters.Add(":status", login.hSales.arrData[1]);
                        cmd.Parameters.Add(":cust", login.hSales.arrData[2]);
                        cmd.Parameters.Add(":pterms", login.hSales.arrData[3]);
                        cmd.Parameters.Add(":ptype", login.hSales.arrData[4]);
                        cmd.Parameters.Add(":notes", login.hSales.arrData[5]);
                        cmd.Parameters.Add(":created", login.hSales.arrDate[0]);
                        cmd.Parameters.Add(":delivery", login.hSales.arrDate[1]);
                        cmd.Parameters.Add(":billed", statusBilled);
                        cmd.Parameters.Add(":idsales", login.sales.getSalesRowId());
                        cmd.ExecuteNonQuery();

                        msgHeader = "inserting new order ";
                    }
                    else
                    {
                        msgHeader = "updating order ";
                    }

                    da.Update(transDs, "detail");
                    otrans.Commit();
                    transDs.Clear();
                    MessageBox.Show(msgHeader + "succesful");
                    login.hSales.editDone = true;
                    this.Hide();
                }
                catch (Exception x)
                {
                    otrans.Rollback();
                    MessageBox.Show(x.Message, msgHeader + "failed");
                }
            }
        }

        private void loadCashflow()
        {
            double sellingPrice = 0, costPrice = 0, tax, marginRate, markupRate, margin, qty, inpPrice;
            Object o = login.db.executeScalar($"select nvl(amount_of_tax,0) from h_sorder where order_row_id = {login.hSales.orderRowId}");
            tax = Convert.ToDouble(o);

            for (int i = 0; i < dgvDetail.Rows.Count; i++)
            {
                sellingPrice += Convert.ToDouble(dgvDetail.Rows[i].Cells[6].Value);
                costPrice += Convert.ToDouble(dgvDetail.Rows[i].Cells[3].Value);
                inpPrice = Convert.ToDouble(dgvDetail.Rows[i].Cells[6].Value);
                qty = Convert.ToDouble(dgvDetail.Rows[i].Cells[8].Value);
                tax +=  0.1 * inpPrice * qty;
            }

            marginRate = (sellingPrice - costPrice) / costPrice;
            markupRate = (sellingPrice - costPrice) / sellingPrice;

            margin = sellingPrice - costPrice;

            lblTax.Text = tax.ToString();
            lblSP.Text = Math.Round(sellingPrice, 0).ToString();
            lblCP.Text = Math.Round(costPrice, 0).ToString();
            lblMarginRate.Text = Math.Round(marginRate, 2).ToString();
            lblMark.Text = Math.Round(markupRate, 2).ToString();
            lblMargin.Text = Math.Round(margin, 2).ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            closingForm = true;
            this.Hide();
        }

        private void enterSearch(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pbSearch_Click(sender, e);
            }
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            enterSearch(sender, e);
        }

        private void tbReduction_KeyDown(object sender, KeyEventArgs e)
        {
            enterSearch(sender, e);
        }

        private void tbCostP_KeyDown(object sender, KeyEventArgs e)
        {
            enterSearch(sender, e);
        }

        private void tbMargin_KeyDown(object sender, KeyEventArgs e)
        {
            enterSearch(sender, e);
        }

        private void tbMarkup_KeyDown(object sender, KeyEventArgs e)
        {
            enterSearch(sender, e);
        }

        private void tbInputP_KeyDown(object sender, KeyEventArgs e)
        {
            enterSearch(sender, e);
        }

        private void tbType_KeyDown(object sender, KeyEventArgs e)
        {
            enterSearch(sender, e);
        }

        private void dgvDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idxDetailId = dgvDetail.Columns.Count - 2;
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == dgvDetail.Columns.Count - 1)
                {
                    if (transDs.Tables["detail"].Rows.Count > 0)
                    {
                        if (dgvDetail.Rows[e.RowIndex].Cells[idxDetailId].Value.ToString() == "")
                        {
                            transDs.Tables["detail"].Rows.RemoveAt(e.RowIndex);
                            pbSearch_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("you can't delete detail order from database", "Delete Failed");
                        }
                        
                    }
                }
            }
        }

        private void dgvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > - 1)
            {
                editDetailMode = true;
                idxEditDetail = e.RowIndex;
                /*Str
                    0 = product type
                    1 = product name
                    2 = cost price
                    3 = total
                  Angka
                    0 = qty
                    1 = markup
                    2 = margin
                    3 = reduction
                */

                arrDataDetailStr[0] = dgvDetail.Rows[e.RowIndex].Cells[0].Value.ToString();
                arrDataDetailStr[1] = dgvDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
                arrDataDetailStr[2] = dgvDetail.Rows[e.RowIndex].Cells[3].Value.ToString();
                arrDataDetailStr[3] = dgvDetail.Rows[e.RowIndex].Cells[6].Value.ToString();

                arrDataDetailAngka[0] = Convert.ToDouble(dgvDetail.Rows[e.RowIndex].Cells[8].Value.ToString());
                arrDataDetailAngka[1] = Convert.ToDouble(dgvDetail.Rows[e.RowIndex].Cells[5].Value.ToString());
                arrDataDetailAngka[2] = Convert.ToDouble(dgvDetail.Rows[e.RowIndex].Cells[4].Value.ToString());
                arrDataDetailAngka[3] = Convert.ToDouble(dgvDetail.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
            else
            {
                editDetailMode = false;
                declareArr();
            }

            if (editDetailMode)
            {
                login.addProduct.ShowDialog();
                pbSearch_Click(sender, e);
            }
        }
    }
}
