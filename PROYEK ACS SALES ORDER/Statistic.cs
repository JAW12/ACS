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
            if(tipe == "TP")
            {
                dt = new DataTable();
                dt = login.db.executeDataTable("SELECT CASE THIRD_PARTY_TYPE WHEN '1' THEN 'Prospect' WHEN '2' THEN 'Customer' WHEN '3' THEN 'Vendor' WHEN '4' THEN 'Others' END AS TYPE, COUNT(THIRD_PARTY_TYPE) AS AMOUNT FROM THIRD_PARTY GROUP BY THIRD_PARTY_TYPE");
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
                dt = new DataTable();
                dt = login.db.executeDataTable("SELECT ORDER_STATUS AS STATUS, COUNT(ORDER_STATUS) AS AMOUNT FROM H_SORDER GROUP BY ORDER_STATUS");
                dgvTable.DataSource = dt;
                dgvTable.Columns[0].Width = dgvTable.Columns[1].Width + 200;

                chStatistic.Series.Clear();
                chStatistic.Legends.Clear();

                //Add a new Legend(if needed) and do some formating
                chStatistic.Legends.Add("Status");
                chStatistic.Legends[0].LegendStyle = LegendStyle.Table;
                chStatistic.Legends[0].Docking = Docking.Bottom;
                chStatistic.Legends[0].Alignment = StringAlignment.Center;
                chStatistic.Legends[0].Title = "Sales Order Status";
                chStatistic.Legends[0].BorderColor = Color.Black;

                //Add a new chart-series
                string seriesname = "SOStatus";
                chStatistic.Series.Add(seriesname);
                //set the chart-type to "Pie"
                chStatistic.Series[seriesname].ChartType = SeriesChartType.Pie;
                chStatistic.Series[seriesname].LabelForeColor = Color.White;
                chStatistic.Series[seriesname].Font = new Font("default", 10, FontStyle.Bold);

                //Add some datapoints so the series. in this case you can pass the values to this method
                foreach (DataGridViewRow row in dgvTable.Rows)
                {
                    chStatistic.Series[seriesname].Points.AddXY(row.Cells[0].Value, row.Cells[1].Value);
                }
            }
        }
    }
}
