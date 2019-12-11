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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.lblJudul.Location = new System.Drawing.Point(255, 26);
            this.lblJudul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(118, 29);
            this.lblJudul.TabIndex = 67;
            this.lblJudul.Text = "Statistics";
            // 
            // pbIcon
            // 
            this.pbIcon.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.staticon;
            this.pbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIcon.Location = new System.Drawing.Point(195, 10);
            this.pbIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(67, 62);
            this.pbIcon.TabIndex = 66;
            this.pbIcon.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.logo;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(16, 15);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(159, 50);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTable.Location = new System.Drawing.Point(17, 74);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.Size = new System.Drawing.Size(1167, 267);
            this.dgvTable.TabIndex = 112;
            this.dgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellClick);
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(1135, 11);
            this.lbl_.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(20, 24);
            this.lbl_.TabIndex = 113;
            this.lbl_.Text = "_";
            this.lbl_.Click += new System.EventHandler(this.lbl__Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(1160, 11);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(24, 24);
            this.lblX.TabIndex = 114;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // chStatistic
            // 
            chartArea1.Name = "ChartArea1";
            this.chStatistic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chStatistic.Legends.Add(legend1);
            this.chStatistic.Location = new System.Drawing.Point(17, 350);
            this.chStatistic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chStatistic.Name = "chStatistic";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chStatistic.Series.Add(series1);
            this.chStatistic.Size = new System.Drawing.Size(1167, 559);
            this.chStatistic.TabIndex = 115;
            this.chStatistic.Text = "chart1";
            // 
            // cbJenis
            // 
            this.cbJenis.FormattingEnabled = true;
            this.cbJenis.Location = new System.Drawing.Point(383, 26);
            this.cbJenis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbJenis.Name = "cbJenis";
            this.cbJenis.Size = new System.Drawing.Size(181, 24);
            this.cbJenis.TabIndex = 116;
            this.cbJenis.SelectedIndexChanged += new System.EventHandler(this.cbJenis_SelectedIndexChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd MMMM yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(573, 27);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(176, 22);
            this.dtpFrom.TabIndex = 117;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dateChange);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd MMMM yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(779, 27);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(176, 22);
            this.dtpTo.TabIndex = 118;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dateChange);
            // 
            // lblUntil
            // 
            this.lblUntil.AutoSize = true;
            this.lblUntil.Location = new System.Drawing.Point(757, 30);
            this.lblUntil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUntil.Name = "lblUntil";
            this.lblUntil.Size = new System.Drawing.Size(13, 17);
            this.lblUntil.TabIndex = 120;
            this.lblUntil.Text = "-";
            // 
            // pbPrint
            // 
            this.pbPrint.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.print;
            this.pbPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPrint.Location = new System.Drawing.Point(1049, 15);
            this.pbPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPrint.Name = "pbPrint";
            this.pbPrint.Size = new System.Drawing.Size(52, 46);
            this.pbPrint.TabIndex = 121;
            this.pbPrint.TabStop = false;
            this.pbPrint.Click += new System.EventHandler(this.pbPrint_Click);
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 923);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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