namespace PROYEK_ACS_SALES_ORDER_V1
{
    partial class Statistic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblJudul = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.lbl_ = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.chStatistic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbJenis = new System.Windows.Forms.ComboBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblUntil = new System.Windows.Forms.Label();
            this.pbPrint = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chStatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(191, 21);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(90, 24);
            this.lblJudul.TabIndex = 67;
            this.lblJudul.Text = "Statistics";
            // 
            // pbIcon
            // 
            this.pbIcon.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.staticon;
            this.pbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIcon.Location = new System.Drawing.Point(146, 8);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(50, 50);
            this.pbIcon.TabIndex = 66;
            this.pbIcon.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.logo;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(119, 41);
            this.pbLogo.TabIndex = 65;
            this.pbLogo.TabStop = false;
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTable.Location = new System.Drawing.Point(13, 60);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.Size = new System.Drawing.Size(875, 217);
            this.dgvTable.TabIndex = 112;
            this.dgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellClick);
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(851, 9);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(16, 18);
            this.lbl_.TabIndex = 113;
            this.lbl_.Text = "_";
            this.lbl_.Click += new System.EventHandler(this.lbl__Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(870, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 18);
            this.lblX.TabIndex = 114;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // chStatistic
            // 
            chartArea2.Name = "ChartArea1";
            this.chStatistic.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chStatistic.Legends.Add(legend2);
            this.chStatistic.Location = new System.Drawing.Point(13, 284);
            this.chStatistic.Name = "chStatistic";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chStatistic.Series.Add(series2);
            this.chStatistic.Size = new System.Drawing.Size(875, 454);
            this.chStatistic.TabIndex = 115;
            this.chStatistic.Text = "chart1";
            // 
            // cbJenis
            // 
            this.cbJenis.FormattingEnabled = true;
            this.cbJenis.Location = new System.Drawing.Point(287, 21);
            this.cbJenis.Name = "cbJenis";
            this.cbJenis.Size = new System.Drawing.Size(137, 21);
            this.cbJenis.TabIndex = 116;
            this.cbJenis.SelectedIndexChanged += new System.EventHandler(this.cbJenis_SelectedIndexChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd MMMM yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(430, 22);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(133, 20);
            this.dtpFrom.TabIndex = 117;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dateChange);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd MMMM yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(584, 22);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(133, 20);
            this.dtpTo.TabIndex = 118;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dateChange);
            // 
            // lblUntil
            // 
            this.lblUntil.AutoSize = true;
            this.lblUntil.Location = new System.Drawing.Point(568, 24);
            this.lblUntil.Name = "lblUntil";
            this.lblUntil.Size = new System.Drawing.Size(10, 13);
            this.lblUntil.TabIndex = 120;
            this.lblUntil.Text = "-";
            // 
            // pbPrint
            // 
            this.pbPrint.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.print;
            this.pbPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPrint.Location = new System.Drawing.Point(787, 12);
            this.pbPrint.Name = "pbPrint";
            this.pbPrint.Size = new System.Drawing.Size(39, 37);
            this.pbPrint.TabIndex = 121;
            this.pbPrint.TabStop = false;
            this.pbPrint.Click += new System.EventHandler(this.pbPrint_Click);
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 750);
            this.Controls.Add(this.pbPrint);
            this.Controls.Add(this.lblUntil);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.cbJenis);
            this.Controls.Add(this.chStatistic);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.lblJudul);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistic";
            this.VisibleChanged += new System.EventHandler(this.Statistic_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chStatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chStatistic;
        private System.Windows.Forms.ComboBox cbJenis;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblUntil;
        private System.Windows.Forms.PictureBox pbPrint;
    }
}