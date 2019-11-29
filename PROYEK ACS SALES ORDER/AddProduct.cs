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
    public partial class AddProduct : Form
    {
        public Login login;
        Double costPrice;


        public AddProduct(Login login)
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
            this.Hide();
        }
        
        private void addDetailRow(ref DataSet ds, String namaTable)
        {
            String productType = "";
            int qty = 0;
            if (rbProduct.Checked)
            {
                productType = "Product";
                qty = Convert.ToInt32(nudQty.Value);
            }
            else if (rbService.Checked)
            {
                productType = "Service";
                qty = 0;
            }
            DataRow row = ds.Tables[namaTable].NewRow();
            row[0] = productType;
            row[1] = tbName.Text;
            row[2] = nudReduction.Value;
            row[3] = tbCostPrice.Text;
            row[4] = nudMargin.Value;
            row[5] = nudMarkup.Value;
            row[6] = lblTotal.Text;
            row[7] = login.hSales.orderRowId;
            row[8] = qty;
            row.EndEdit();
            ds.Tables[namaTable].Rows.Add(row);
        }

        private void editDatatableDetail(ref DataSet ds, String namatable, int idx)
        {
            String productType = "";
            int qty = 0;
            if (rbProduct.Checked)
            {
                productType = "Product";
                qty = Convert.ToInt32(nudQty.Value);
            }
            else if (rbService.Checked)
            {
                productType = "Service";
                qty = 0;
            }
            DataRow row = ds.Tables[namatable].Rows[idx];
            row[0] = productType;
            row[1] = tbName.Text;
            row[2] = nudReduction.Value;
            row[3] = tbCostPrice.Text;
            row[4] = nudMargin.Value;
            row[5] = nudMarkup.Value;
            row[6] = lblTotal.Text;
            row[7] = login.hSales.orderRowId;
            row[8] = qty;
            row.EndEdit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbCostPrice.Text != "" && tbName.Text != "" && tbPrice.Text != "")
                {
                    if (!login.dSales.editDetailMode)
                    {
                        addDetailRow(ref login.dSales.transDs, "detail");
                        MessageBox.Show("Adding successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        editDatatableDetail(ref login.dSales.transDs, "detail", login.dSales.idxEditDetail);
                        MessageBox.Show("Editing successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    login.dSales.adaPerubahanDetail = true;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please complete product's data first", "Unable to Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Adding new detail order failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nudMarkup_ValueChanged(object sender, EventArgs e)
        {
            hitungTotalPrice(2);
        }


        private void cekJabatanManager()
        {

        }


        private void hitungSubtotal()
        {
            if (tbPrice.Text.Length >= 1)
            {
                int sub = Convert.ToInt32(tbPrice.Text) * Convert.ToInt32(nudQty.Value);
                lblSubtotal.Text = sub.ToString();
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

        private void tbCostPrice_Leave(object sender, EventArgs e)
        {
            if (tbCostPrice.Text.Length >= 1)
            {
                costPrice = Convert.ToDouble(tbCostPrice.Text);
            }
            else
            {
                costPrice = 0;
            }
            
        }

        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            if (nudQty.Value > 0)
            {
                hitungSubtotal();
                hitungTotalPrice(0);
            }
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

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            if (tbPrice.Text.Length > 0 && tbCostPrice.Text.Length > 0)
            {
                hitungSubtotal();
                hitungMarginMarkupReduction(Convert.ToDouble(tbPrice.Text));
                hitungTotalPrice(0);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbCostPrice_TextChanged(object sender, EventArgs e)
        {
            if (tbPrice.Text.Length > 0 && tbCostPrice.Text.Length > 0)
            {
                hitungSubtotal();
                hitungMarginMarkupReduction(Convert.ToDouble(tbPrice.Text));
            }
            else
            {
                resetField();
            }
        }

        private void setNumericKeypress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void setNonNumericKeypress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void tbCostPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            setNumericKeypress(sender, e);
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            setNumericKeypress(sender, e);
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            setNonNumericKeypress(sender, e);
        }

        private void resetDataProduct()
        {
            tbName.Clear();
            tbPrice.Clear();
            tbCostPrice.Clear();
            nudQty.Value = nudQty.Minimum;
        }

        private void resetField()
        {
            nudMargin.Value = 0;
            nudMarkup.Value = 0;
            nudReduction.Value = 0;
            lblSubtotal.Text = "0";
            lblTotal.Text = "0";

        }

        private void loadMode()
        {
            if (login.dSales.editDetailMode)
            {
                lblJudul.Text = "Edit Product";
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
                if (login.dSales.arrDataDetailStr[0] == "Product")
                {
                    rbProduct.Checked = true;
                }
                else if (login.dSales.arrDataDetailStr[0] == "Service")
                {
                    rbService.Checked = true;
                }
                tbName.Text = login.dSales.arrDataDetailStr[1];
                tbCostPrice.Text = login.dSales.arrDataDetailStr[2];
                tbPrice.Text = login.dSales.arrDataDetailStr[3];

                nudQty.Value = Convert.ToInt32(login.dSales.arrDataDetailAngka[0]);
                nudMarkup.Value = Convert.ToDecimal(login.dSales.arrDataDetailAngka[1]);
                nudMargin.Value = Convert.ToDecimal(login.dSales.arrDataDetailAngka[2]);
                nudReduction.Value = Convert.ToDecimal(login.dSales.arrDataDetailAngka[3]);

                lblTotal.Text = login.dSales.arrDataDetailStr[3];
            }
        }

        private void AddProduct_VisibleChanged(object sender, EventArgs e)
        {
            resetDataProduct();
            resetField();
            loadMode();
        }

        private void rbService_CheckedChanged(object sender, EventArgs e)
        {
            nudQty.Enabled = false;
        }

        private void rbProduct_CheckedChanged(object sender, EventArgs e)
        {
            nudQty.Enabled = true;
        }
    }
}
