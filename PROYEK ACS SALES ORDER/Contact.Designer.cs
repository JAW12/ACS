﻿namespace PROYEK_ACS_SALES_ORDER_V1
{
    partial class Contact
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
            this.dgvContact = new System.Windows.Forms.DataGridView();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.tbJob = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbTP = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thirdPartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pbCheck = new System.Windows.Forms.PictureBox();
            this.pbUncheck = new System.Windows.Forms.PictureBox();
            this.btnInactive = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.pbUnsearch = new System.Windows.Forms.PictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.lbl_ = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.pbPrint = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUncheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(191, 44);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(197, 24);
            this.lblJudul.TabIndex = 13;
            this.lblJudul.Text = "Contact / Addresses";
            // 
            // dgvContact
            // 
            this.dgvContact.AllowUserToAddRows = false;
            this.dgvContact.AllowUserToDeleteRows = false;
            this.dgvContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContact.Location = new System.Drawing.Point(12, 141);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.ReadOnly = true;
            this.dgvContact.Size = new System.Drawing.Size(1031, 437);
            this.dgvContact.TabIndex = 16;
            this.dgvContact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContact_CellContentClick);
            this.dgvContact.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContact_CellValueChanged);
            // 
            // tbLast
            // 
            this.tbLast.Location = new System.Drawing.Point(12, 117);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(100, 20);
            this.tbLast.TabIndex = 19;
            // 
            // tbFirst
            // 
            this.tbFirst.Location = new System.Drawing.Point(118, 117);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(130, 20);
            this.tbFirst.TabIndex = 20;
            // 
            // tbJob
            // 
            this.tbJob.Location = new System.Drawing.Point(254, 117);
            this.tbJob.Name = "tbJob";
            this.tbJob.Size = new System.Drawing.Size(99, 20);
            this.tbJob.TabIndex = 21;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(359, 117);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(100, 20);
            this.tbCity.TabIndex = 22;
            // 
            // tbMobile
            // 
            this.tbMobile.Location = new System.Drawing.Point(465, 117);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(100, 20);
            this.tbMobile.TabIndex = 22;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(571, 117);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(140, 20);
            this.tbEmail.TabIndex = 23;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(847, 117);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(124, 21);
            this.cbStatus.TabIndex = 25;
            // 
            // tbTP
            // 
            this.tbTP.Location = new System.Drawing.Point(717, 117);
            this.tbTP.Name = "tbTP";
            this.tbTP.Size = new System.Drawing.Size(124, 20);
            this.tbTP.TabIndex = 32;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterUserToolStripMenuItem,
            this.thirdPartyToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.salesOrderToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 28);
            this.menuStrip1.TabIndex = 34;
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
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.logo;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(12, 38);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(119, 41);
            this.pbLogo.TabIndex = 39;
            this.pbLogo.TabStop = false;
            // 
            // pbIcon
            // 
            this.pbIcon.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.contact;
            this.pbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIcon.Location = new System.Drawing.Point(136, 24);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(70, 65);
            this.pbIcon.TabIndex = 40;
            this.pbIcon.TabStop = false;
            // 
            // pbCheck
            // 
            this.pbCheck.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.check;
            this.pbCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCheck.Location = new System.Drawing.Point(977, 113);
            this.pbCheck.Name = "pbCheck";
            this.pbCheck.Size = new System.Drawing.Size(30, 30);
            this.pbCheck.TabIndex = 52;
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
            this.pbUncheck.TabIndex = 51;
            this.pbUncheck.TabStop = false;
            this.pbUncheck.Click += new System.EventHandler(this.pbUncheck_Click);
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
            this.btnInactive.TabIndex = 49;
            this.btnInactive.Text = "Inactive";
            this.btnInactive.UseVisualStyleBackColor = false;
            this.btnInactive.Visible = false;
            this.btnInactive.Click += new System.EventHandler(this.btnInactive_Click);
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
            this.btnActive.TabIndex = 50;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Visible = false;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // pbUnsearch
            // 
            this.pbUnsearch.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.unsearch;
            this.pbUnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUnsearch.Location = new System.Drawing.Point(1013, 83);
            this.pbUnsearch.Name = "pbUnsearch";
            this.pbUnsearch.Size = new System.Drawing.Size(30, 30);
            this.pbUnsearch.TabIndex = 48;
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
            this.pbSearch.TabIndex = 47;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(1006, 9);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(16, 18);
            this.lbl_.TabIndex = 54;
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
            this.lblX.TabIndex = 55;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // pbPrint
            // 
            this.pbPrint.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.print;
            this.pbPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPrint.Location = new System.Drawing.Point(897, 37);
            this.pbPrint.Name = "pbPrint";
            this.pbPrint.Size = new System.Drawing.Size(47, 42);
            this.pbPrint.TabIndex = 61;
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
            this.pbAdd.TabIndex = 60;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // lblBranch
            // 
            this.lblBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranch.Location = new System.Drawing.Point(677, 48);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(150, 18);
            this.lblBranch.TabIndex = 97;
            this.lblBranch.Text = "-";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(414, 48);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(257, 18);
            this.lblUser.TabIndex = 96;
            this.lblUser.Text = "-";
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 590);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pbPrint);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.tbTP);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbJob);
            this.Controls.Add(this.tbFirst);
            this.Controls.Add(this.tbLast);
            this.Controls.Add(this.dgvContact);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbCheck);
            this.Controls.Add(this.pbUncheck);
            this.Controls.Add(this.btnInactive);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.pbUnsearch);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.pbIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "a";
            this.VisibleChanged += new System.EventHandler(this.Contact_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.DataGridView dgvContact;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.TextBox tbJob;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox tbTP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thirdPartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.ToolStripMenuItem masterUserToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbCheck;
        private System.Windows.Forms.PictureBox pbUncheck;
        private System.Windows.Forms.Button btnInactive;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.PictureBox pbUnsearch;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.PictureBox pbPrint;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblUser;
    }
}