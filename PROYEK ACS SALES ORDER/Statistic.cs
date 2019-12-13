using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PROYEK_ACS_SALES_ORDER_V1
{
    public partial class Statistic : Form
    {
        public Login login;
        public String tipe;
        public Statistic(Login login)
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
        DataTable dt;
        private void Statistic_VisibleChanged(object sender, EventArgs e)
        {
            cbJenis.Items.Clear();
            idProduk = "";
            namaProduk = "";
            if (tipe == "TP")
            {
                cbJenis.Visible = false;
                dtpFrom.Visible = false;
                lblUntil.Visible = false;
                dtpTo.Visible = false;
                pbPrint.Visible = false;
                dt = new DataTable();
                if(login.jabatanUser == "Manager") {
                    dt = login.db.executeDataTable($"SELECT CASE T.THIRD_PARTY_TYPE WHEN '1' THEN 'Prospect' WHEN '2' THEN 'Customer' WHEN '3' THEN 'Vendor' WHEN '4' THEN 'Others' END AS TYPE, COUNT(T.THIRD_PARTY_TYPE) AS AMOUNT FROM THIRD_PARTY T, USER_DATA U WHERE T.USER_ROW_ID = U.USER_ROW_ID AND U.ID_BRANCH = '%{login.idBranchUser}%' GROUP BY T.THIRD_PARTY_TYPE");
                }
                else if(login.jabatanUser == "Admin")
                {
                    dt = login.db.executeDataTable("SELECT CASE T.THIRD_PARTY_TYPE WHEN '1' THEN 'Prospect' WHEN '2' THEN 'Customer' WHEN '3' THEN 'Vendor' WHEN '4' THEN 'Others' END AS TYPE, COUNT(T.THIRD_PARTY_TYPE) AS AMOUNT FROM THIRD_PARTY T GROUP BY T.THIRD_PARTY_TYPE");
                }
                else if (login.jabatanUser == "Sales")
                {
                    dt = login.db.executeDataTable($"SELECT CASE T.THIRD_PARTY_TYPE WHEN '1' THEN 'Prospect' WHEN '2' THEN 'Customer' WHEN '3' THEN 'Vendor' WHEN '4' THEN 'Others' END AS TYPE, COUNT(T.THIRD_PARTY_TYPE) AS AMOUNT FROM THIRD_PARTY T, USER_DATA U WHERE T.USER_ROW_ID = U.USER_ROW_ID AND U.ID_BRANCH = '%{login.idBranchUser}%' AND T.USER_ROW_ID LIKE '%{login.idUser}%' GROUP BY T.THIRD_PARTY_TYPE");
                }
                dgvTable.DataSource = dt;
                dgvTable.Columns[0].Width = dgvTable.Columns[1].Width + 200;

                chStatistic.Series.Clear();
                chStatistic.Legends.Clear();

                //Add a new Legend(if needed) and do some formating
                chStatistic.Legends.Add("Type");
                chStatistic.Legends[0].LegendStyle = LegendStyle.Table;
                chStatistic.Legends[0].Docking = Docking.Bottom;
                chStatistic.Legends[0].Alignment = StringAlignment.Center;
                chStatistic.Legends[0].Title = "Third Party Type";
                chStatistic.Legends[0].BorderColor = Color.Black;

                //Add a new chart-series
                string seriesname = "TPType";
                chStatistic.Series.Add(seriesname);
                //set the chart-type to "Pie"
                chStatistic.Series[seriesname].ChartType = SeriesChartType.Pie;
                chStatistic.Series[seriesname].LabelForeColor = Color.White;
                chStatistic.Series[seriesname].Font = new Font("default", 14, FontStyle.Bold);

                //Add some datapoints so the series. in this case you can pass the values to this method
                foreach(DataGridViewRow row in dgvTable.Rows)
                {
                    chStatistic.Series[seriesname].Points.AddXY(row.Cells[0].Value, row.Cells[1].Value);
                }
            }
            else if(tipe == "SO")
            {
                cbJenis.Visible = true;
              
                cbJenis.Items.Add("Order Status");
                cbJenis.Items.Add("Product Overview");
                cbJenis.Items.Add("Product Detail");
                cbJenis.SelectedIndex = 0;

            }
            else if(tipe == "US")
            {
                cbJenis.Visible = false;
                dtpFrom.Visible = false;
                lblUntil.Visible = false;
                dtpTo.Visible = false;
                pbPrint.Visible = false;
                dt = new DataTable();
                //dt = login.db.executeDataTable($"SELECT CASE U_STATUS WHEN '1' THEN 'Admin' WHEN '2' THEN 'Manager' WHEN '3' THEN 'Sales' END AS TYPE, COUNT(U_STATUS) AS AMOUNT FROM USER_DATA GROUP BY U_STATUS");
                dt = login.db.executeDataTable($"SELECT U.U_NAME AS NAME, SUM(H.NET_TOTAL) AS TRANSACTION FROM USER_DATA U, H_SORDER H WHERE U.USER_ROW_ID = H.SALES_ROW_ID GROUP BY U.U_NAME");
                dgvTable.DataSource = dt;
                dgvTable.Columns[0].Width = dgvTable.Columns[1].Width + 200;

                chStatistic.Series.Clear();
                chStatistic.Legends.Clear();

                //Add a new chart-series
                string seriesname = "USType";
                chStatistic.Series.Add(seriesname);
                //set the chart-type to "Bar"
                chStatistic.Series[seriesname].ChartType = SeriesChartType.Bar;
                chStatistic.Series[seriesname].LabelForeColor = Color.White;
                chStatistic.Series[seriesname].Font = new Font("default", 14, FontStyle.Bold);

                //Add some datapoints so the series. in this case you can pass the values to this method
                foreach (DataGridViewRow row in dgvTable.Rows)
                {
                    chStatistic.Series[seriesname].Points.AddXY(row.Cells[0].Value, row.Cells[1].Value);
                }
                for(int i =0; i < dgvTable.Rows.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(38, 133, 203);
                    }
                    if (i % 3 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(74, 217, 90);
                    }
                    if (i % 4 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(254, 200, 27);
                    }
                    if (i % 5 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(253, 141, 20);
                    }
                    if (i % 6 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(206, 0, 230);
                    }
                    if (i % 7 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(75, 74, 211);
                    }
                    if (i % 8 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(252, 48, 38);
                    }
                    if (i % 9 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(125, 184, 255);
                    }
                    if (i % 10 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(106, 220, 136);
                    }
                    if (i % 11 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(254, 228, 95);
                    }
                }
            }
        }

        private void cbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            chStatistic.Series.Clear();
            chStatistic.Legends.Clear();
            if (tipe == "SO" && cbJenis.Items.Count > 0)
            {
                if (cbJenis.SelectedIndex == 0)
                {
                    dtpFrom.Visible = false;
                    lblUntil.Visible = false;
                    dtpTo.Visible = false;
                    pbPrint.Visible = false;
                    dt = new DataTable();
                    if(login.jabatanUser == "Manager")
                    {
                        dt = login.db.executeDataTable($"SELECT ORDER_STATUS AS STATUS, COUNT(ORDER_STATUS) AS AMOUNT FROM H_SORDER WHERE ID_BRANCH LIKE '%{login.idBranchUser}%' GROUP BY ORDER_STATUS");
                    }
                    else if(login.jabatanUser == "Admin")
                    {
                        dt = login.db.executeDataTable("SELECT ORDER_STATUS AS STATUS, COUNT(ORDER_STATUS) AS AMOUNT FROM H_SORDER GROUP BY ORDER_STATUS");
                    }
                    else if (login.jabatanUser == "Sales")
                    {
                        dt = login.db.executeDataTable($"SELECT ORDER_STATUS AS STATUS, COUNT(ORDER_STATUS) AS AMOUNT FROM H_SORDER WHERE ID_BRANCH LIKE '%{login.idBranchUser}%' AND SALES_ROW_ID LIKE '%{login.idUser}%' GROUP BY ORDER_STATUS");
                    }

                    dgvTable.DataSource = dt;
                    dgvTable.Columns[0].Width = dgvTable.Columns[1].Width + 200;

                    chStatistic.Series.Clear();
                    chStatistic.Legends.Clear();

                    //Add a new chart-series
                    string seriesname = "SOStatus";
                    chStatistic.Series.Add(seriesname);
                    //set the chart-type to "Pie"
                    chStatistic.Series[seriesname].ChartType = SeriesChartType.Bar;
                    chStatistic.Series[seriesname].LabelForeColor = Color.White;
                    chStatistic.Series[seriesname].Font = new Font("default", 10, FontStyle.Bold);

                    //Add some datapoints so the series. in this case you can pass the values to this method
                    foreach (DataGridViewRow row in dgvTable.Rows)
                    {
                        chStatistic.Series[seriesname].Points.AddXY(row.Cells[0].Value, row.Cells[1].Value);
                    }
                    for (int i = 0; i < dgvTable.Rows.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(38, 133, 203);
                        }
                        if (i % 3 == 0)
                        {
                            chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(74, 217, 90);
                        }
                        if (i % 4 == 0)
                        {
                            chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(254, 200, 27);
                        }
                        if (i % 5 == 0)
                        {
                            chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(253, 141, 20);
                        }
                        if (i % 6 == 0)
                        {
                            chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(206, 0, 230);
                        }
                        if (i % 7 == 0)
                        {
                            chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(75, 74, 211);
                        }
                        if (i % 8 == 0)
                        {
                            chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(252, 48, 38);
                        }
                        if (i % 9 == 0)
                        {
                            chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(125, 184, 255);
                        }
                        if (i % 10 == 0)
                        {
                            chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(106, 220, 136);
                        }
                        if (i % 11 == 0)
                        {
                            chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(254, 228, 95);
                        }
                    }
                }
                else if(cbJenis.SelectedIndex == 1)
                {
                    dtpFrom.Visible = true;
                    lblUntil.Visible = true;
                    dtpTo.Visible = true;
                    pbPrint.Visible = true;
                    showData();
                }
                else if (cbJenis.SelectedIndex == 2)
                {
                    dtpFrom.Visible = true;
                    lblUntil.Visible = true;
                    dtpTo.Visible = true;
                    pbPrint.Visible = false;
                    dt = new DataTable();
                    String query = $"select * from product";

                    dt = login.db.executeDataTable(query);
                    dgvTable.DataSource = dt;
                    dgvTable.Columns[3].Width = 300;
                    dgvTable.Columns[2].Width = 200;
                    dgvTable.Columns[4].Visible = false;
                }
            }
        }

        string idProduk = "";
        string namaProduk = "";
        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idProduk = "";
            namaProduk = "";
            if (tipe == "SO" && cbJenis.SelectedIndex == 2)
            {
                int row = e.RowIndex;
                int col = e.ColumnIndex;
                if (row > -1 && row < dgvTable.RowCount && col > -1 && col < dgvTable.ColumnCount)
                {
                    idProduk = dgvTable.Rows[row].Cells[0].Value.ToString();
                    namaProduk = dgvTable.Rows[row].Cells[2].Value.ToString();
                    showLine();
                }
            }
        }

        public void showLine()
        {
            if (idProduk != "" && cbJenis.SelectedIndex == 2)
            {
                chStatistic.Series.Clear();
                chStatistic.Legends.Clear();

                //Add a new Legend(if needed) and do some formating
                chStatistic.Legends.Add("Status");
                chStatistic.Legends[0].LegendStyle = LegendStyle.Table;
                chStatistic.Legends[0].Docking = Docking.Bottom;
                chStatistic.Legends[0].Alignment = StringAlignment.Center;
                chStatistic.Legends[0].Title = namaProduk + "'s Cashflow";
                chStatistic.Legends[0].BorderColor = Color.Black;

                //Add a new chart-series
                string seriesname2 = "Product Income Changes";
                chStatistic.Series.Add(seriesname2);
                //set the chart-type to "Pie"
                chStatistic.Series[seriesname2].ChartType = SeriesChartType.Line;
                chStatistic.Series[seriesname2].LabelForeColor = Color.White;
                chStatistic.Series[seriesname2].Font = new Font("default", 10, FontStyle.Bold);
                chStatistic.Series[seriesname2].BorderWidth = 5;

                //Add a new chart-series
                string seriesname = "Product Income";
                chStatistic.Series.Add(seriesname);
                //set the chart-type to "Pie"
                chStatistic.Series[seriesname].ChartType = SeriesChartType.Point;
                chStatistic.Series[seriesname].LabelForeColor = Color.White;
                chStatistic.Series[seriesname].Font = new Font("default", 10, FontStyle.Bold);
                chStatistic.Series[seriesname].MarkerSize = 10;

                DataTable dt = new DataTable();
                if (login.jabatanUser == "Admin")
                {
                    dt = login.db.executeDataTable($"SELECT H.ORDER_CREATED_DATE AS TGL, SUM((D.INPUT_PRICE - D.COSTPRICE) * D.QTY) AS PROFIT FROM D_SORDER D, H_SORDER H WHERE D.ID_PRODUCT = '{idProduk}' AND D.ORDER_ROW_ID = H.ORDER_ROW_ID AND H.ORDER_CREATED_DATE >= TO_DATE('{dtpFrom.Value.ToShortDateString()}', 'DD/MM/YYYY') AND H.ORDER_CREATED_DATE <= TO_DATE('{dtpTo.Value.ToShortDateString()}', 'DD/MM/YYYY') GROUP BY H.ORDER_CREATED_DATE");
                }
                else if (login.jabatanUser == "Manager")
                {
                    dt = login.db.executeDataTable($"SELECT H.ORDER_CREATED_DATE AS TGL, SUM((D.INPUT_PRICE - D.COSTPRICE) * D.QTY) AS PROFIT FROM D_SORDER D, H_SORDER H WHERE D.ID_PRODUCT = '{idProduk}' AND D.ORDER_ROW_ID = H.ORDER_ROW_ID AND H.ORDER_CREATED_DATE >= TO_DATE('{dtpFrom.Value.ToShortDateString()}', 'DD/MM/YYYY') AND H.ORDER_CREATED_DATE <= TO_DATE('{dtpTo.Value.ToShortDateString()}', 'DD/MM/YYYY') AND H.ID_BRANCH LIKE '%{login.idBranchUser}%' GROUP BY H.ORDER_CREATED_DATE");
                }
                else if (login.jabatanUser == "Sales")
                {
                    dt = login.db.executeDataTable($"SELECT H.ORDER_CREATED_DATE AS TGL, SUM((D.INPUT_PRICE - D.COSTPRICE) * D.QTY) AS PROFIT FROM D_SORDER D, H_SORDER H WHERE D.ID_PRODUCT = '{idProduk}' AND D.ORDER_ROW_ID = H.ORDER_ROW_ID AND H.ORDER_CREATED_DATE >= TO_DATE('{dtpFrom.Value.ToShortDateString()}', 'DD/MM/YYYY') AND H.ORDER_CREATED_DATE <= TO_DATE('{dtpTo.Value.ToShortDateString()}', 'DD/MM/YYYY') AND H.ID_BRANCH LIKE '%{login.idBranchUser}%' AND H.SALES_ROW_ID LIKE '%{login.idUser}%' GROUP BY H.ORDER_CREATED_DATE");
                }

                //Add some datapoints so the series. in this case you can pass the values to this method
                foreach (DataRow row in dt.Rows)
                {
                    chStatistic.Series[seriesname2].Points.AddXY(row[0], row[1]);
                    chStatistic.Series[seriesname].Points.AddXY(row[0], row[1]);
                }
            }
        }

        public void showData()
        {
            if(cbJenis.SelectedIndex == 1)
            {
                dt = new DataTable();
                if(login.jabatanUser == "Admin")
                {
                    String query = $"select p.id_product, p.product_name, sum((d.input_price - d.costprice)*d.qty) as subtotal from product p, d_sorder d, h_sorder h where p.id_product = d.id_product and d.order_row_id = h.order_row_id and H.ORDER_CREATED_DATE >= TO_DATE('{dtpFrom.Value.ToShortDateString()}', 'DD/MM/YYYY') AND H.ORDER_CREATED_DATE <= TO_DATE('{dtpTo.Value.ToShortDateString()}', 'DD/MM/YYYY') group by p.id_product, p.product_name order by 1 asc";
                    dt = login.db.executeDataTable(query);
                }
                else if(login.jabatanUser == "Manager")
                {
                    String query = $"select p.id_product, p.product_name, sum((d.input_price - d.costprice)*d.qty) as subtotal from product p, d_sorder d, h_sorder h where p.id_product = d.id_product and d.order_row_id = h.order_row_id and H.ORDER_CREATED_DATE >= TO_DATE('{dtpFrom.Value.ToShortDateString()}', 'DD/MM/YYYY') AND H.ORDER_CREATED_DATE <= TO_DATE('{dtpTo.Value.ToShortDateString()}', 'DD/MM/YYYY') AND H.ID_BRANCH LIKE '%{login.idBranchUser}%' group by p.id_product, p.product_name order by 1 asc";
                    dt = login.db.executeDataTable(query);
                }
                else if (login.jabatanUser == "Sales")
                {
                    String query = $"select p.id_product, p.product_name, sum((d.input_price - d.costprice)*d.qty) as subtotal from product p, d_sorder d, h_sorder h where p.id_product = d.id_product and d.order_row_id = h.order_row_id and H.ORDER_CREATED_DATE >= TO_DATE('{dtpFrom.Value.ToShortDateString()}', 'DD/MM/YYYY') AND H.ORDER_CREATED_DATE <= TO_DATE('{dtpTo.Value.ToShortDateString()}', 'DD/MM/YYYY') AND H.ID_BRANCH LIKE '%{login.idBranchUser}%' AND h.sales_row_id like '%{login.idUser}%' group by p.id_product, p.product_name order by 1 asc";
                    dt = login.db.executeDataTable(query);
                }
                dgvTable.DataSource = dt;

                chStatistic.Series.Clear();
                chStatistic.Legends.Clear();
            
                //Add a new chart-series
                string seriesname = "Product Overview";
                chStatistic.Series.Add(seriesname);
                //set the chart-type to "Bar"
                chStatistic.Series[seriesname].ChartType = SeriesChartType.Bar;
                chStatistic.Series[seriesname].LabelForeColor = Color.White;
                chStatistic.Series[seriesname].Font = new Font("default", 14, FontStyle.Bold);

                //Add some datapoints so the series. in this case you can pass the values to this method
                foreach (DataGridViewRow row in dgvTable.Rows)
                {
                    chStatistic.Series[seriesname].Points.AddXY(row.Cells[1].Value, row.Cells[2].Value);
                }
                for (int i = 0; i < dgvTable.Rows.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(38, 133, 203);
                    }
                    if (i % 3 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(74, 217, 90);
                    }
                    if (i % 4 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(254, 200, 27);
                    }
                    if (i % 5 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(253, 141, 20);
                    }
                    if (i % 6 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(206, 0, 230);
                    }
                    if (i % 7 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(75, 74, 211);
                    }
                    if (i % 8 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(252, 48, 38);
                    }
                    if (i % 9 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(125, 184, 255);
                    }
                    if (i % 10 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(106, 220, 136);
                    }
                    if (i % 11 == 0)
                    {
                        chStatistic.Series[seriesname].Points[i].Color = Color.FromArgb(254, 228, 95);
                    }
                }
            }
        }
        private void dateChange(object sender, EventArgs e)
        {
            showLine();
            showData();
        }

        private void pbPrint_Click(object sender, EventArgs e)
        {
            Rmargin crm = new Rmargin();
            string paramtgl1 = dtpFrom.Value.ToString("yyyy,MM,dd");
            string paramtgl2 = dtpTo.Value.ToString("yyyy,MM,dd");
            crm.SetDatabaseLogon(login.dbUser, login.dbPass, login.dbSource, "");
            crm.SetParameterValue(0,paramtgl1);
            crm.SetParameterValue(1,paramtgl2);
            
            if (login.jabatanUser == "Admin")
            {
                crm.SetParameterValue(2, "");
            }
            else if (login.jabatanUser == "Manager")
            {
                crm.SetParameterValue(2, login.idBranchUser);
            }
            else if (login.jabatanUser == "Sales")
            {
                crm.SetParameterValue(2, login.idBranchUser);
            }
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
}
