namespace PROYEK_ACS_SALES_ORDER_V1
{
    partial class AddProduct
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.nudMarkup = new System.Windows.Forms.NumericUpDown();
            this.lblSMarkup = new System.Windows.Forms.Label();
            this.lblPMarkup = new System.Windows.Forms.Label();
            this.nudMargin = new System.Windows.Forms.NumericUpDown();
            this.lblPMargin = new System.Windows.Forms.Label();
            this.lblSMargin = new System.Windows.Forms.Label();
            this.lblSSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.rbProduct = new System.Windows.Forms.RadioButton();
            this.rbService = new System.Windows.Forms.RadioButton();
            this.nudReduction = new System.Windows.Forms.NumericUpDown();
            this.lblPReduction = new System.Windows.Forms.Label();
            this.lblSReduction = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSCost = new System.Windows.Forms.Label();
            this.tbCostPrice = new System.Windows.Forms.TextBox();
            this.lbl_ = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(191, 21);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(126, 24);
            this.lblJudul.TabIndex = 67;
            this.lblJudul.Text = "Add Product";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(103, 101);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(289, 24);
            this.tbName.TabIndex = 99;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(38, 104);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 110;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(9, 163);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(77, 18);
            this.lblPrice.TabIndex = 110;
            this.lblPrice.Text = "Input Price";
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(103, 160);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(289, 24);
            this.tbPrice.TabIndex = 99;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(55, 192);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(31, 18);
            this.lblQty.TabIndex = 110;
            this.lblQty.Text = "Qty";
            // 
            // nudQty
            // 
            this.nudQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQty.Location = new System.Drawing.Point(103, 190);
            this.nudQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(120, 24);
            this.nudQty.TabIndex = 111;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.ValueChanged += new System.EventHandler(this.nudQty_ValueChanged);
            // 
            // nudMarkup
            // 
            this.nudMarkup.DecimalPlaces = 2;
            this.nudMarkup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMarkup.Location = new System.Drawing.Point(103, 248);
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
            this.nudMarkup.TabIndex = 113;
            this.nudMarkup.ValueChanged += new System.EventHandler(this.nudMarkup_ValueChanged);
            // 
            // lblSMarkup
            // 
            this.lblSMarkup.AutoSize = true;
            this.lblSMarkup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMarkup.Location = new System.Drawing.Point(28, 250);
            this.lblSMarkup.Name = "lblSMarkup";
            this.lblSMarkup.Size = new System.Drawing.Size(58, 18);
            this.lblSMarkup.TabIndex = 112;
            this.lblSMarkup.Text = "Markup";
            // 
            // lblPMarkup
            // 
            this.lblPMarkup.AutoSize = true;
            this.lblPMarkup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMarkup.Location = new System.Drawing.Point(229, 250);
            this.lblPMarkup.Name = "lblPMarkup";
            this.lblPMarkup.Size = new System.Drawing.Size(21, 18);
            this.lblPMarkup.TabIndex = 112;
            this.lblPMarkup.Text = "%";
            // 
            // nudMargin
            // 
            this.nudMargin.DecimalPlaces = 2;
            this.nudMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMargin.Location = new System.Drawing.Point(103, 278);
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
            this.nudMargin.TabIndex = 116;
            this.nudMargin.ValueChanged += new System.EventHandler(this.nudMargin_ValueChanged);
            // 
            // lblPMargin
            // 
            this.lblPMargin.AutoSize = true;
            this.lblPMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMargin.Location = new System.Drawing.Point(229, 280);
            this.lblPMargin.Name = "lblPMargin";
            this.lblPMargin.Size = new System.Drawing.Size(21, 18);
            this.lblPMargin.TabIndex = 114;
            this.lblPMargin.Text = "%";
            // 
            // lblSMargin
            // 
            this.lblSMargin.AutoSize = true;
            this.lblSMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMargin.Location = new System.Drawing.Point(33, 280);
            this.lblSMargin.Name = "lblSMargin";
            this.lblSMargin.Size = new System.Drawing.Size(53, 18);
            this.lblSMargin.TabIndex = 115;
            this.lblSMargin.Text = "Margin";
            // 
            // lblSSubtotal
            // 
            this.lblSSubtotal.AutoSize = true;
            this.lblSSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSubtotal.Location = new System.Drawing.Point(16, 223);
            this.lblSSubtotal.Name = "lblSSubtotal";
            this.lblSSubtotal.Size = new System.Drawing.Size(70, 18);
            this.lblSSubtotal.TabIndex = 110;
            this.lblSSubtotal.Text = "Subtotal";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(100, 223);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(14, 18);
            this.lblSubtotal.TabIndex = 110;
            this.lblSubtotal.Text = "-";
            // 
            // lblSTotal
            // 
            this.lblSTotal.AutoSize = true;
            this.lblSTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTotal.Location = new System.Drawing.Point(38, 334);
            this.lblSTotal.Name = "lblSTotal";
            this.lblSTotal.Size = new System.Drawing.Size(46, 18);
            this.lblSTotal.TabIndex = 110;
            this.lblSTotal.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(98, 334);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 18);
            this.lblTotal.TabIndex = 110;
            this.lblTotal.Text = "-";
            this.lblTotal.TextChanged += new System.EventHandler(this.lblTotal_TextChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(46, 73);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 18);
            this.lblType.TabIndex = 110;
            this.lblType.Text = "Type";
            // 
            // rbProduct
            // 
            this.rbProduct.AutoSize = true;
            this.rbProduct.Checked = true;
            this.rbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProduct.Location = new System.Drawing.Point(103, 71);
            this.rbProduct.Name = "rbProduct";
            this.rbProduct.Size = new System.Drawing.Size(78, 22);
            this.rbProduct.TabIndex = 117;
            this.rbProduct.TabStop = true;
            this.rbProduct.Text = "Product";
            this.rbProduct.UseVisualStyleBackColor = true;
            this.rbProduct.CheckedChanged += new System.EventHandler(this.rbProduct_CheckedChanged);
            // 
            // rbService
            // 
            this.rbService.AutoSize = true;
            this.rbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbService.Location = new System.Drawing.Point(187, 71);
            this.rbService.Name = "rbService";
            this.rbService.Size = new System.Drawing.Size(75, 22);
            this.rbService.TabIndex = 117;
            this.rbService.TabStop = true;
            this.rbService.Text = "Service";
            this.rbService.UseVisualStyleBackColor = true;
            this.rbService.CheckedChanged += new System.EventHandler(this.rbService_CheckedChanged);
            // 
            // nudReduction
            // 
            this.nudReduction.DecimalPlaces = 2;
            this.nudReduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudReduction.Location = new System.Drawing.Point(103, 308);
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
            this.nudReduction.TabIndex = 121;
            this.nudReduction.ValueChanged += new System.EventHandler(this.nudReduction_ValueChanged);
            // 
            // lblPReduction
            // 
            this.lblPReduction.AutoSize = true;
            this.lblPReduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPReduction.Location = new System.Drawing.Point(229, 310);
            this.lblPReduction.Name = "lblPReduction";
            this.lblPReduction.Size = new System.Drawing.Size(21, 18);
            this.lblPReduction.TabIndex = 119;
            this.lblPReduction.Text = "%";
            // 
            // lblSReduction
            // 
            this.lblSReduction.AutoSize = true;
            this.lblSReduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSReduction.Location = new System.Drawing.Point(11, 310);
            this.lblSReduction.Name = "lblSReduction";
            this.lblSReduction.Size = new System.Drawing.Size(75, 18);
            this.lblSReduction.TabIndex = 120;
            this.lblSReduction.Text = "Reduction";
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(211, 363);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 41);
            this.btnAdd.TabIndex = 131;
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
            this.btnCancel.Location = new System.Drawing.Point(86, 363);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 41);
            this.btnCancel.TabIndex = 130;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSCost
            // 
            this.lblSCost.AutoSize = true;
            this.lblSCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSCost.Location = new System.Drawing.Point(6, 133);
            this.lblSCost.Name = "lblSCost";
            this.lblSCost.Size = new System.Drawing.Size(78, 18);
            this.lblSCost.TabIndex = 133;
            this.lblSCost.Text = "Cost Price";
            // 
            // tbCostPrice
            // 
            this.tbCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostPrice.Location = new System.Drawing.Point(103, 130);
            this.tbCostPrice.Name = "tbCostPrice";
            this.tbCostPrice.Size = new System.Drawing.Size(289, 24);
            this.tbCostPrice.TabIndex = 132;
            this.tbCostPrice.TextChanged += new System.EventHandler(this.tbCostPrice_TextChanged);
            this.tbCostPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCostPrice_KeyPress);
            this.tbCostPrice.Leave += new System.EventHandler(this.tbCostPrice_Leave);
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(355, 8);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(16, 18);
            this.lbl_.TabIndex = 134;
            this.lbl_.Text = "_";
            this.lbl_.Click += new System.EventHandler(this.lbl__Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(374, 8);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 18);
            this.lblX.TabIndex = 135;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 427);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblSCost);
            this.Controls.Add(this.tbCostPrice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.nudReduction);
            this.Controls.Add(this.lblPReduction);
            this.Controls.Add(this.lblSReduction);
            this.Controls.Add(this.rbService);
            this.Controls.Add(this.rbProduct);
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
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.lblJudul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.VisibleChanged += new System.EventHandler(this.AddProduct_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.NumericUpDown nudMarkup;
        private System.Windows.Forms.Label lblSMarkup;
        private System.Windows.Forms.Label lblPMarkup;
        private System.Windows.Forms.NumericUpDown nudMargin;
        private System.Windows.Forms.Label lblPMargin;
        private System.Windows.Forms.Label lblSMargin;
        private System.Windows.Forms.Label lblSSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.RadioButton rbProduct;
        private System.Windows.Forms.RadioButton rbService;
        private System.Windows.Forms.NumericUpDown nudReduction;
        private System.Windows.Forms.Label lblPReduction;
        private System.Windows.Forms.Label lblSReduction;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSCost;
        private System.Windows.Forms.TextBox tbCostPrice;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Label lblX;
    }
}