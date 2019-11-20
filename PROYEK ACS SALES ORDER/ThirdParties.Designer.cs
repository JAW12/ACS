namespace PROYEK_ACS_SALES_ORDER_V1
{
    partial class ThirdParties
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.dgvTP = new System.Windows.Forms.DataGridView();
            this.cbSales = new System.Windows.Forms.ComboBox();
            this.lblSales = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAlias = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnActive = new System.Windows.Forms.Button();
            this.btnInactive = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thirdPartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lbl_ = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.pbPrint = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbCheck = new System.Windows.Forms.PictureBox();
            this.pbUncheck = new System.Windows.Forms.PictureBox();
            this.pbUnsearch = new System.Windows.Forms.PictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pbStatistic = new System.Windows.Forms.PictureBox();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTP)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUncheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(191, 43);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(111, 24);
            this.lblJudul.TabIndex = 13;
            this.lblJudul.Text = "Third Party";
            // 
            // dgvTP
            // 
            this.dgvTP.AllowUserToAddRows = false;
            this.dgvTP.AllowUserToDeleteRows = false;
            this.dgvTP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTP.Location = new System.Drawing.Point(12, 142);
            this.dgvTP.Name = "dgvTP";
            this.dgvTP.ReadOnly = true;
            this.dgvTP.Size = new System.Drawing.Size(1031, 436);
            this.dgvTP.TabIndex = 16;
            this.dgvTP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTP_CellClick);
            this.dgvTP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTP_CellDoubleClick);
            // 
            // cbSales
            // 
            this.cbSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSales.FormattingEnabled = true;
            this.cbSales.Location = new System.Drawing.Point(384, 83);
            this.cbSales.Name = "cbSales";
            this.cbSales.Size = new System.Drawing.Size(221, 26);
            this.cbSales.TabIndex = 17;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.Location = new System.Drawing.Point(202, 86);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(176, 18);
            this.lblSales.TabIndex = 18;
            this.lblSales.Text = "Sales Representatives";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 117);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(120, 20);
            this.tbName.TabIndex = 19;
            // 
            // tbAlias
            // 
            this.tbAlias.Location = new System.Drawing.Point(138, 117);
            this.tbAlias.Name = "tbAlias";
            this.tbAlias.Size = new System.Drawing.Size(100, 20);
            this.tbAlias.TabIndex = 20;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(244, 117);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(134, 20);
            this.tbCode.TabIndex = 21;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(384, 117);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(119, 20);
            this.tbCity.TabIndex = 22;
            // 
            // tbPostcode
            // 
            this.tbPostcode.Location = new System.Drawing.Point(509, 117);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(96, 20);
            this.tbPostcode.TabIndex = 22;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(611, 117);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 23;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(717, 117);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(124, 21);
            this.cbType.TabIndex = 24;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(847, 117);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(124, 21);
            this.cbStatus.TabIndex = 25;
            // 
            // btnActive
            // 
            this.btnActive.BackColor = System.Drawing.Color.Lime;
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.ForeColor = System.Drawing.Color.Black;
            this.btnActive.Location = new System.Drawing.Point(715, 83);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(126, 30);
            this.btnActive.TabIndex = 29;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Visible = false;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnInactive
            // 
            this.btnInactive.BackColor = System.Drawing.Color.Red;
            this.btnInactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactive.ForeColor = System.Drawing.Color.White;
            this.btnInactive.Location = new System.Drawing.Point(847, 83);
            this.btnInactive.Name = "btnInactive";
            this.btnInactive.Size = new System.Drawing.Size(126, 30);
            this.btnInactive.TabIndex = 29;
            this.btnInactive.Text = "Inactive";
            this.btnInactive.UseVisualStyleBackColor = false;
            this.btnInactive.Visible = false;
            this.btnInactive.Click += new System.EventHandler(this.btnInactive_Click);
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
            this.menuStrip1.TabIndex = 33;
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
            this.salesOrderToolStripMenuItem.Click += new System.EventHandler(this.salesOrderToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(326, 47);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(257, 18);
            this.lblUser.TabIndex = 18;
            this.lblUser.Text = "-";
            // 
            // lblBranch
            // 
            this.lblBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranch.Location = new System.Drawing.Point(589, 47);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(150, 18);
            this.lblBranch.TabIndex = 35;
            this.lblBranch.Text = "-";
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(1006, 9);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(16, 18);
            this.lbl_.TabIndex = 43;
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
            this.lblX.TabIndex = 44;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // pbPrint
            // 
            this.pbPrint.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.print;
            this.pbPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPrint.Location = new System.Drawing.Point(745, 37);
            this.pbPrint.Name = "pbPrint";
            this.pbPrint.Size = new System.Drawing.Size(47, 42);
            this.pbPrint.TabIndex = 42;
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
            this.pbAdd.TabIndex = 32;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbCheck
            // 
            this.pbCheck.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.check;
            this.pbCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCheck.Location = new System.Drawing.Point(977, 113);
            this.pbCheck.Name = "pbCheck";
            this.pbCheck.Size = new System.Drawing.Size(30, 30);
            this.pbCheck.TabIndex = 31;
            this.pbCheck.TabStop = false;
            this.pbCheck.Click += new System.EventHandler(this.pbCheck_Click);
            // 
            // pbUncheck
            // 
            this.pbUncheck.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.uncheck;
            this.pbUncheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUncheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUncheck.Location = new System.Drawing.Point(1013, 113);
            this.pbUncheck.Name = "pbUncheck";
            this.pbUncheck.Size = new System.Drawing.Size(30, 30);
            this.pbUncheck.TabIndex = 30;
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
            this.pbUnsearch.TabIndex = 27;
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
            this.pbSearch.TabIndex = 26;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // pbStatistic
            // 
            this.pbStatistic.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.statistics;
            this.pbStatistic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStatistic.Location = new System.Drawing.Point(798, 37);
            this.pbStatistic.Name = "pbStatistic";
            this.pbStatistic.Size = new System.Drawing.Size(146, 42);
            this.pbStatistic.TabIndex = 15;
            this.pbStatistic.TabStop = false;
            this.pbStatistic.Click += new System.EventHandler(this.pbStatistic_Click);
            // 
            // pbIcon
            // 
            this.pbIcon.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.thirdparty;
            this.pbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIcon.Location = new System.Drawing.Point(136, 24);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(70, 65);
            this.pbIcon.TabIndex = 12;
            this.pbIcon.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.logo;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(13, 37);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(119, 41);
            this.pbLogo.TabIndex = 11;
            this.pbLogo.TabStop = false;
            // 
            // ThirdParties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 590);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvTP);
            this.Controls.Add(this.pbPrint);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.pbCheck);
            this.Controls.Add(this.pbUncheck);
            this.Controls.Add(this.btnInactive);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.pbUnsearch);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbPostcode);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.tbAlias);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.cbSales);
            this.Controls.Add(this.pbStatistic);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbIcon);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ThirdParties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThirdParties";
            this.VisibleChanged += new System.EventHandler(this.ThirdParties_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTP)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUncheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.PictureBox pbStatistic;
        private System.Windows.Forms.DataGridView dgvTP;
        private System.Windows.Forms.ComboBox cbSales;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAlias;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbPostcode;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.PictureBox pbUnsearch;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.PictureBox pbUncheck;
        private System.Windows.Forms.PictureBox pbCheck;
        private System.Windows.Forms.Button btnInactive;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thirdPartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.PictureBox pbPrint;
        private System.Windows.Forms.ToolStripMenuItem masterUserToolStripMenuItem;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Label lblX;
    }
}