namespace PROYEK_ACS_SALES_ORDER_V1
{
    partial class Browse
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
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pbUnsearch = new System.Windows.Forms.PictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudReduction = new System.Windows.Forms.NumericUpDown();
            this.lblPReduction = new System.Windows.Forms.Label();
            this.lblSReduction = new System.Windows.Forms.Label();
            this.nudMargin = new System.Windows.Forms.NumericUpDown();
            this.lblPMargin = new System.Windows.Forms.Label();
            this.lblSMargin = new System.Windows.Forms.Label();
            this.nudMarkup = new System.Windows.Forms.NumericUpDown();
            this.lblPMarkup = new System.Windows.Forms.Label();
            this.lblSMarkup = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSSubtotal = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbl_ = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(191, 21);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(167, 24);
            this.lblJudul.TabIndex = 67;
            this.lblJudul.Text = "Browse Products";
            // 
            // pbIcon
            // 
            this.pbIcon.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.products;
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
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(87, 68);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(449, 24);
            this.tbSearch.TabIndex = 99;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(11, 98);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(582, 293);
            this.dgvProducts.TabIndex = 109;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(21, 71);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(55, 18);
            this.lblSearch.TabIndex = 110;
            this.lblSearch.Text = "Search";
            // 
            // pbUnsearch
            // 
            this.pbUnsearch.Location = new System.Drawing.Point(571, 69);
            this.pbUnsearch.Name = "pbUnsearch";
            this.pbUnsearch.Size = new System.Drawing.Size(20, 20);
            this.pbUnsearch.TabIndex = 112;
            this.pbUnsearch.TabStop = false;
            this.pbUnsearch.Click += new System.EventHandler(this.pbUnsearch_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Location = new System.Drawing.Point(545, 69);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(20, 20);
            this.pbSearch.TabIndex = 111;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(309, 551);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 41);
            this.btnAdd.TabIndex = 133;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(184, 551);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 41);
            this.btnCancel.TabIndex = 132;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nudReduction
            // 
            this.nudReduction.DecimalPlaces = 2;
            this.nudReduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudReduction.Location = new System.Drawing.Point(445, 490);
            this.nudReduction.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudReduction.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudReduction.Name = "nudReduction";
            this.nudReduction.Size = new System.Drawing.Size(120, 24);
            this.nudReduction.TabIndex = 148;
            this.nudReduction.ValueChanged += new System.EventHandler(this.nudReduction_ValueChanged);
            // 
            // lblPReduction
            // 
            this.lblPReduction.AutoSize = true;
            this.lblPReduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPReduction.Location = new System.Drawing.Point(571, 492);
            this.lblPReduction.Name = "lblPReduction";
            this.lblPReduction.Size = new System.Drawing.Size(21, 18);
            this.lblPReduction.TabIndex = 146;
            this.lblPReduction.Text = "%";
            // 
            // lblSReduction
            // 
            this.lblSReduction.AutoSize = true;
            this.lblSReduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSReduction.Location = new System.Drawing.Point(353, 492);
            this.lblSReduction.Name = "lblSReduction";
            this.lblSReduction.Size = new System.Drawing.Size(75, 18);
            this.lblSReduction.TabIndex = 147;
            this.lblSReduction.Text = "Reduction";
            // 
            // nudMargin
            // 
            this.nudMargin.DecimalPlaces = 2;
            this.nudMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMargin.Location = new System.Drawing.Point(445, 460);
            this.nudMargin.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudMargin.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudMargin.Name = "nudMargin";
            this.nudMargin.Size = new System.Drawing.Size(120, 24);
            this.nudMargin.TabIndex = 145;
            this.nudMargin.ValueChanged += new System.EventHandler(this.nudMargin_ValueChanged);
            // 
            // lblPMargin
            // 
            this.lblPMargin.AutoSize = true;
            this.lblPMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMargin.Location = new System.Drawing.Point(571, 462);
            this.lblPMargin.Name = "lblPMargin";
            this.lblPMargin.Size = new System.Drawing.Size(21, 18);
            this.lblPMargin.TabIndex = 143;
            this.lblPMargin.Text = "%";
            // 
            // lblSMargin
            // 
            this.lblSMargin.AutoSize = true;
            this.lblSMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMargin.Location = new System.Drawing.Point(375, 462);
            this.lblSMargin.Name = "lblSMargin";
            this.lblSMargin.Size = new System.Drawing.Size(53, 18);
            this.lblSMargin.TabIndex = 144;
            this.lblSMargin.Text = "Margin";
            // 
            // nudMarkup
            // 
            this.nudMarkup.DecimalPlaces = 2;
            this.nudMarkup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMarkup.Location = new System.Drawing.Point(445, 430);
            this.nudMarkup.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudMarkup.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudMarkup.Name = "nudMarkup";
            this.nudMarkup.Size = new System.Drawing.Size(120, 24);
            this.nudMarkup.TabIndex = 142;
            this.nudMarkup.ValueChanged += new System.EventHandler(this.nudMarkup_ValueChanged);
            // 
            // lblPMarkup
            // 
            this.lblPMarkup.AutoSize = true;
            this.lblPMarkup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMarkup.Location = new System.Drawing.Point(571, 432);
            this.lblPMarkup.Name = "lblPMarkup";
            this.lblPMarkup.Size = new System.Drawing.Size(21, 18);
            this.lblPMarkup.TabIndex = 140;
            this.lblPMarkup.Text = "%";
            // 
            // lblSMarkup
            // 
            this.lblSMarkup.AutoSize = true;
            this.lblSMarkup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMarkup.Location = new System.Drawing.Point(370, 432);
            this.lblSMarkup.Name = "lblSMarkup";
            this.lblSMarkup.Size = new System.Drawing.Size(58, 18);
            this.lblSMarkup.TabIndex = 141;
            this.lblSMarkup.Text = "Markup";
            // 
            // nudQty
            // 
            this.nudQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQty.Location = new System.Drawing.Point(111, 426);
            this.nudQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(120, 24);
            this.nudQty.TabIndex = 139;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.ValueChanged += new System.EventHandler(this.nudQty_ValueChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(440, 516);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 18);
            this.lblTotal.TabIndex = 134;
            this.lblTotal.Text = "0";
            this.lblTotal.TextChanged += new System.EventHandler(this.lblTotal_TextChanged);
            // 
            // lblSTotal
            // 
            this.lblSTotal.AutoSize = true;
            this.lblSTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTotal.Location = new System.Drawing.Point(380, 516);
            this.lblSTotal.Name = "lblSTotal";
            this.lblSTotal.Size = new System.Drawing.Size(46, 18);
            this.lblSTotal.TabIndex = 135;
            this.lblSTotal.Text = "Total";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(442, 399);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(14, 18);
            this.lblSubtotal.TabIndex = 136;
            this.lblSubtotal.Text = "-";
            this.lblSubtotal.TextChanged += new System.EventHandler(this.lblSubtotal_TextChanged);
            this.lblSubtotal.Click += new System.EventHandler(this.lblSubtotal_Click);
            // 
            // lblSSubtotal
            // 
            this.lblSSubtotal.AutoSize = true;
            this.lblSSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSubtotal.Location = new System.Drawing.Point(358, 399);
            this.lblSSubtotal.Name = "lblSSubtotal";
            this.lblSSubtotal.Size = new System.Drawing.Size(70, 18);
            this.lblSSubtotal.TabIndex = 137;
            this.lblSSubtotal.Text = "Subtotal";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(63, 428);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(31, 18);
            this.lblQty.TabIndex = 138;
            this.lblQty.Text = "Qty";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(17, 399);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(77, 18);
            this.lblPrice.TabIndex = 150;
            this.lblPrice.Text = "Input Price";
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(111, 396);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(220, 24);
            this.tbPrice.TabIndex = 149;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(556, 8);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(16, 18);
            this.lbl_.TabIndex = 151;
            this.lbl_.Text = "_";
            this.lbl_.Click += new System.EventHandler(this.lbl__Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(575, 8);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 18);
            this.lblX.TabIndex = 152;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // Browse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 604);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.nudReduction);
            this.Controls.Add(this.lblPReduction);
            this.Controls.Add(this.lblSReduction);
            this.Controls.Add(this.nudMargin);
            this.Controls.Add(this.lblPMargin);
            this.Controls.Add(this.lblSMargin);
            this.Controls.Add(this.nudMarkup);
            this.Controls.Add(this.lblPMarkup);
            this.Controls.Add(this.lblSMarkup);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblSSubtotal);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pbUnsearch);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.pbIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Browse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browse";
            this.VisibleChanged += new System.EventHandler(this.Browse_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.PictureBox pbUnsearch;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudReduction;
        private System.Windows.Forms.Label lblPReduction;
        private System.Windows.Forms.Label lblSReduction;
        private System.Windows.Forms.NumericUpDown nudMargin;
        private System.Windows.Forms.Label lblPMargin;
        private System.Windows.Forms.Label lblSMargin;
        private System.Windows.Forms.NumericUpDown nudMarkup;
        private System.Windows.Forms.Label lblPMarkup;
        private System.Windows.Forms.Label lblSMarkup;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSSubtotal;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Label lblX;
    }
}