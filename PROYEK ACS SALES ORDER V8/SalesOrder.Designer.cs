namespace PROYEK_ACS_SALES_ORDER_V1
{
    partial class SalesOrder
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
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbTP = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.dgvHOrder = new System.Windows.Forms.DataGridView();
            this.lblJudul = new System.Windows.Forms.Label();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thirdPartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbBill = new System.Windows.Forms.ComboBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.cbTOrder = new System.Windows.Forms.ComboBox();
            this.cbTDelivery = new System.Windows.Forms.ComboBox();
            this.cbMOrder = new System.Windows.Forms.ComboBox();
            this.cbMDelivery = new System.Windows.Forms.ComboBox();
            this.pbCheck = new System.Windows.Forms.PictureBox();
            this.pbUncheck = new System.Windows.Forms.PictureBox();
            this.pbUnsearch = new System.Windows.Forms.PictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pbPrint = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbStatistic = new System.Windows.Forms.PictureBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.lbl_ = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.cbSales = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHOrder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUncheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(837, 117);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(97, 21);
            this.cbStatus.TabIndex = 49;
            // 
            // tbPostcode
            // 
            this.tbPostcode.Location = new System.Drawing.Point(345, 117);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(104, 20);
            this.tbPostcode.TabIndex = 46;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(259, 117);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(81, 20);
            this.tbCity.TabIndex = 45;
            // 
            // tbTP
            // 
            this.tbTP.Location = new System.Drawing.Point(160, 117);
            this.tbTP.Name = "tbTP";
            this.tbTP.Size = new System.Drawing.Size(94, 20);
            this.tbTP.TabIndex = 43;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(55, 117);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(100, 20);
            this.tbCode.TabIndex = 42;
            // 
            // dgvHOrder
            // 
            this.dgvHOrder.AllowUserToAddRows = false;
            this.dgvHOrder.AllowUserToDeleteRows = false;
            this.dgvHOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHOrder.Location = new System.Drawing.Point(12, 143);
            this.dgvHOrder.Name = "dgvHOrder";
            this.dgvHOrder.ReadOnly = true;
            this.dgvHOrder.Size = new System.Drawing.Size(1031, 435);
            this.dgvHOrder.TabIndex = 39;
            this.dgvHOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHOrder_CellContentClick);
            this.dgvHOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHOrder_CellDoubleClick);
            this.dgvHOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHOrder_CellValueChanged);
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(191, 44);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(121, 24);
            this.lblJudul.TabIndex = 36;
            this.lblJudul.Text = "Sales Order";
            // 
            // cbAction
            // 
            this.cbAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Location = new System.Drawing.Point(717, 85);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(119, 26);
            this.cbAction.TabIndex = 58;
            this.cbAction.Visible = false;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(654, 117);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(91, 20);
            this.tbTotal.TabIndex = 46;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterUserToolStripMenuItem,
            this.thirdPartyToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.salesOrderToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 28);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterUserToolStripMenuItem
            // 
            this.masterUserToolStripMenuItem.Name = "masterUserToolStripMenuItem";
            this.masterUserToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.masterUserToolStripMenuItem.Text = "Master User";
            this.masterUserToolStripMenuItem.Click += new System.EventHandler(this.masterUserToolStripMenuItem_Click);
            // 
            // thirdPartyToolStripMenuItem
            // 
            this.thirdPartyToolStripMenuItem.Name = "thirdPartyToolStripMenuItem";
            this.thirdPartyToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.thirdPartyToolStripMenuItem.Text = "Third Party";
            this.thirdPartyToolStripMenuItem.Click += new System.EventHandler(this.thirdPartyToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // salesOrderToolStripMenuItem
            // 
            this.salesOrderToolStripMenuItem.Name = "salesOrderToolStripMenuItem";
            this.salesOrderToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.salesOrderToolStripMenuItem.Text = "Sales Order";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // cbBill
            // 
            this.cbBill.FormattingEnabled = true;
            this.cbBill.Location = new System.Drawing.Point(750, 117);
            this.cbBill.Name = "cbBill";
            this.cbBill.Size = new System.Drawing.Size(82, 21);
            this.cbBill.TabIndex = 64;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.logo;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(12, 38);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(119, 41);
            this.pbLogo.TabIndex = 67;
            this.pbLogo.TabStop = false;
            // 
            // pbIcon
            // 
            this.pbIcon.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.so;
            this.pbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIcon.Location = new System.Drawing.Point(136, 24);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(70, 65);
            this.pbIcon.TabIndex = 68;
            this.pbIcon.TabStop = false;
            // 
            // cbTOrder
            // 
            this.cbTOrder.FormattingEnabled = true;
            this.cbTOrder.Location = new System.Drawing.Point(499, 117);
            this.cbTOrder.Name = "cbTOrder";
            this.cbTOrder.Size = new System.Drawing.Size(50, 21);
            this.cbTOrder.TabIndex = 78;
            // 
            // cbTDelivery
            // 
            this.cbTDelivery.FormattingEnabled = true;
            this.cbTDelivery.Location = new System.Drawing.Point(599, 117);
            this.cbTDelivery.Name = "cbTDelivery";
            this.cbTDelivery.Size = new System.Drawing.Size(50, 21);
            this.cbTDelivery.TabIndex = 80;
            // 
            // cbMOrder
            // 
            this.cbMOrder.FormattingEnabled = true;
            this.cbMOrder.Location = new System.Drawing.Point(454, 117);
            this.cbMOrder.Name = "cbMOrder";
            this.cbMOrder.Size = new System.Drawing.Size(40, 21);
            this.cbMOrder.TabIndex = 81;
            // 
            // cbMDelivery
            // 
            this.cbMDelivery.FormattingEnabled = true;
            this.cbMDelivery.Location = new System.Drawing.Point(554, 117);
            this.cbMDelivery.Name = "cbMDelivery";
            this.cbMDelivery.Size = new System.Drawing.Size(40, 21);
            this.cbMDelivery.TabIndex = 82;
            // 
            // pbCheck
            // 
            this.pbCheck.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.check;
            this.pbCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCheck.Location = new System.Drawing.Point(977, 114);
            this.pbCheck.Name = "pbCheck";
            this.pbCheck.Size = new System.Drawing.Size(30, 30);
            this.pbCheck.TabIndex = 93;
            this.pbCheck.TabStop = false;
            this.pbCheck.Click += new System.EventHandler(this.pbCheck_Click);
            // 
            // pbUncheck
            // 
            this.pbUncheck.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.uncheck;
            this.pbUncheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUncheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUncheck.Location = new System.Drawing.Point(1013, 114);
            this.pbUncheck.Name = "pbUncheck";
            this.pbUncheck.Size = new System.Drawing.Size(30, 30);
            this.pbUncheck.TabIndex = 92;
            this.pbUncheck.TabStop = false;
            this.pbUncheck.Click += new System.EventHandler(this.pbUncheck_Click);
            // 
            // pbUnsearch
            // 
            this.pbUnsearch.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.unsearch;
            this.pbUnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUnsearch.Location = new System.Drawing.Point(1013, 83);
            this.pbUnsearch.Name = "pbUnsearch";
            this.pbUnsearch.Size = new System.Drawing.Size(30, 30);
            this.pbUnsearch.TabIndex = 91;
            this.pbUnsearch.TabStop = false;
            this.pbUnsearch.Click += new System.EventHandler(this.pbUnsearch_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.search;
            this.pbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearch.Location = new System.Drawing.Point(977, 83);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(30, 30);
            this.pbSearch.TabIndex = 90;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // pbPrint
            // 
            this.pbPrint.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.print;
            this.pbPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPrint.Location = new System.Drawing.Point(745, 37);
            this.pbPrint.Name = "pbPrint";
            this.pbPrint.Size = new System.Drawing.Size(47, 42);
            this.pbPrint.TabIndex = 89;
            this.pbPrint.TabStop = false;
            this.pbPrint.Click += new System.EventHandler(this.pbPrint_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.addtp;
            this.pbAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdd.Location = new System.Drawing.Point(950, 37);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(93, 42);
            this.pbAdd.TabIndex = 88;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbStatistic
            // 
            this.pbStatistic.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.statistics;
            this.pbStatistic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStatistic.Location = new System.Drawing.Point(798, 37);
            this.pbStatistic.Name = "pbStatistic";
            this.pbStatistic.Size = new System.Drawing.Size(146, 42);
            this.pbStatistic.TabIndex = 87;
            this.pbStatistic.TabStop = false;
            this.pbStatistic.Click += new System.EventHandler(this.pbStatistic_Click);
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(80)))), ((int)(((byte)(137)))));
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.ForeColor = System.Drawing.Color.White;
            this.btnAction.Location = new System.Drawing.Point(842, 82);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(126, 30);
            this.btnAction.TabIndex = 86;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Visible = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(1006, 9);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(16, 18);
            this.lbl_.TabIndex = 83;
            this.lbl_.Text = "_";
            this.lbl_.Click += new System.EventHandler(this.lbl__Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(1025, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 18);
            this.lblX.TabIndex = 84;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // lblBranch
            // 
            this.lblBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranch.Location = new System.Drawing.Point(589, 48);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(150, 18);
            this.lblBranch.TabIndex = 95;
            this.lblBranch.Text = "-";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(326, 48);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(257, 18);
            this.lblUser.TabIndex = 94;
            this.lblUser.Text = "-";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.Location = new System.Drawing.Point(202, 86);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(176, 18);
            this.lblSales.TabIndex = 97;
            this.lblSales.Text = "Sales Representatives";
            // 
            // cbSales
            // 
            this.cbSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSales.FormattingEnabled = true;
            this.cbSales.Location = new System.Drawing.Point(384, 83);
            this.cbSales.Name = "cbSales";
            this.cbSales.Size = new System.Drawing.Size(221, 26);
            this.cbSales.TabIndex = 96;
            this.cbSales.SelectedIndexChanged += new System.EventHandler(this.cbSales_SelectedIndexChanged);
            // 
            // SalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 590);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.cbSales);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pbUnsearch);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.pbPrint);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.pbStatistic);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.cbMDelivery);
            this.Controls.Add(this.cbMOrder);
            this.Controls.Add(this.cbTDelivery);
            this.Controls.Add(this.cbTOrder);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.cbBill);
            this.Controls.Add(this.cbAction);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbPostcode);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbTP);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.dgvHOrder);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.pbCheck);
            this.Controls.Add(this.pbUncheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesOrder";
            this.VisibleChanged += new System.EventHandler(this.SalesOrder_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHOrder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUncheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox tbPostcode;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbTP;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.DataGridView dgvHOrder;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thirdPartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbBill;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.ToolStripMenuItem masterUserToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbTOrder;
        private System.Windows.Forms.ComboBox cbTDelivery;
        private System.Windows.Forms.ComboBox cbMOrder;
        private System.Windows.Forms.ComboBox cbMDelivery;
        private System.Windows.Forms.PictureBox pbCheck;
        private System.Windows.Forms.PictureBox pbUncheck;
        private System.Windows.Forms.PictureBox pbUnsearch;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.PictureBox pbPrint;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pbStatistic;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.ComboBox cbSales;
    }
}