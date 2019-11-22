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
    public partial class Browse : Form
    {
        public Login login;
        public Browse(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        DataTable dt;
        Double costPrice;
        String productName, productType;

        private void lbl__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void loadDGVProduct(ref DataGridView dgv, String keyword)
        {
            String query = $"select id, type as \"Product Type\", name as \"Product Name\", stock as \"Qty\", costprice as \"Cost Price\", branch_name as \"Branch Name\" from v_detail_produk";

            if (login.branchUser != "ALL" || keyword != "")
            {
                query += " where ";

                if (login.branchUser != "ALL")
                {
                    query += $"UPPER(branch_name) = '{login.branchUser.ToUpper()}'";
                }

                if (keyword != "")
                {
                    if (login.branchUser != "ALL")
                    {
                        query += " and ";
                    }
                    query += $"UPPER(name) like '%{keyword.ToUpper()}%'";
                }
            }

            dt = login.db.executeDataTable(query);
            dgv.DataSource = dt;
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                login.dSales.idProductBrowse = dt.Rows[e.RowIndex][0].ToString();
                btnAdd_Click(sender, e);
                this.Hide();
            }
        }

        private void Browse_VisibleChanged(object sender, EventArgs e)
        {
            costPrice = 0;
            productName = "-";
            productType = "";
            resetField();
            loadDGVProduct(ref dgvProducts,"");
        }

        private void addDetailRow(ref DataSet ds, String namaTable)
        {
            DataRow row = ds.Tables[namaTable].NewRow();
            int qty = 0;
            if (productType == "Product")
            {
                qty = Convert.ToInt32(nudQty.Value);
            }
            row[0] = productType;
            row[1] = productName;
            row[2] = nudReduction.Value;
            row[3] = costPrice;
            row[4] = nudMargin.Value;
            row[5] = nudMarkup.Value;
            row[6] = lblTotal.Text;
            row[7] = login.hSales.orderRowId;
            row[8] = qty;
            row[9] = login.dSales.idProduct;
            row.EndEdit();
            ds.Tables[namaTable].Rows.Add(row);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                addDetailRow(ref login.dSales.transDs, "detail");
                MessageBox.Show("Adding Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                login.dSales.adaPerubahanDetail = true;
                this.Hide();                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Adding Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            
        }

        private void resetField()
        {
            lblSubtotal.Text = "0";
            lblTotal.Text = "0";
            tbPrice.Clear();
            nudQty.Value = nudQty.Minimum;
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            loadDGVProduct(ref dgvProducts, tbSearch.Text);
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pbSearch_Click(sender, e);
            }
        }

        private void pbUnsearch_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
            loadDGVProduct(ref dgvProducts, "");
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
       {
            setNumericKeypress(sender, e);
        }

        private void setNumericKeypress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            if (tbPrice.Text.Length > 0)
            {
                hitungSubtotal();
                hitungMarginMarkupReduction(Convert.ToDouble(tbPrice.Text));
                hitungTotalPrice(0);
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                costPrice = Convert.ToDouble(dgvProducts.Rows[e.RowIndex].Cells[4].Value);
                productType = dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                productName = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                login.dSales.idProduct = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbPrice.Text = dgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            else
            {
                tbPrice.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void hitungSubtotal()
        {
            if (tbPrice.Text.Length >= 1)
            {
                int sub = Convert.ToInt32(tbPrice.Text) * Convert.ToInt32(nudQty.Value);
                lblSubtotal.Text = sub.ToString();
            }
            else
            {
                lblSubtotal.Text = "0";
            }
        }

        private void hitungTotalPrice(int tipe)
        {
            double ttlPrice = Convert.ToDouble(lblSubtotal.Text);
            double marginRate = Convert.ToDouble(nudMargin.Value);
            double markupRate = Convert.ToDouble(nudMarkup.Value);
            double reduction = Convert.ToDouble(nudReduction.Value);

            if (tipe == 1) //margin rate berubah
            {
                ttlPrice = marginRate * costPrice + costPrice;
            }
            else if (tipe == 2) //mark up rate berubah
            {
                ttlPrice = costPrice;
                if (markupRate != 1)
                {
                    ttlPrice /= (1 - markupRate);
                }
                
            }
            else if (tipe == 3) //reduction rate berubah
            {
                ttlPrice = costPrice - reduction * costPrice;
            }

            lblTotal.Text = Math.Round(ttlPrice, 0).ToString();
        }

        private void hitungMarginMarkupReduction(Double inpPrice)
        {
            double marginRate = (inpPrice - costPrice) / costPrice;
            double markupRate = (inpPrice - costPrice) / inpPrice;
            double reduction = (costPrice - inpPrice) / costPrice;

            try
            {
                nudMargin.Value = (Decimal)(Math.Round(marginRate, 2));
            }
            catch (Exception)
            {
                nudMargin.Value = 0;
            }

            try
            {
                nudMarkup.Value = (Decimal)(Math.Round(markupRate, 2));
            }
            catch (Exception)
            {
                nudMarkup.Value = 0;
            }

            try
            {
                nudReduction.Value = (Decimal)(Math.Round(reduction, 2));
            }
            catch (Exception)
            {
                nudReduction.Value = 0;
            }
            
        }
        
        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void lblSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            if (nudQty.Value > 0)
            {
                hitungSubtotal();
                hitungTotalPrice(0);
            }
        }

        private void nudMarkup_ValueChanged(object sender, EventArgs e)
        {
            hitungTotalPrice(2);
        }

        private void nudMargin_ValueChanged(object sender, EventArgs e)
        {
            hitungTotalPrice(1);
        }

        private void nudReduction_ValueChanged(object sender, EventArgs e)
        {
            hitungTotalPrice(3);
        }

        private void lblTotal_TextChanged(object sender, EventArgs e)
        {
            hitungMarginMarkupReduction(Convert.ToDouble(lblTotal.Text));
        }
    }
}
