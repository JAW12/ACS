namespace PROYEK_ACS_SALES_ORDER_V1
{
    partial class FormSettingDB
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbDataSource = new System.Windows.Forms.TextBox();
            this.tbDBUsername = new System.Windows.Forms.TextBox();
            this.tbDBPassword = new System.Windows.Forms.TextBox();
            this.lbl_ = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.pbEye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 277);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Database Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(156, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Source :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Database Password :";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(80)))), ((int)(((byte)(137)))));
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGo.Location = new System.Drawing.Point(249, 381);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(101, 36);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbDataSource
            // 
            this.tbDataSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataSource.Location = new System.Drawing.Point(249, 241);
            this.tbDataSource.Name = "tbDataSource";
            this.tbDataSource.Size = new System.Drawing.Size(205, 24);
            this.tbDataSource.TabIndex = 7;
            this.tbDataSource.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDataSource_KeyDown);
            // 
            // tbDBUsername
            // 
            this.tbDBUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDBUsername.Location = new System.Drawing.Point(249, 285);
            this.tbDBUsername.Name = "tbDBUsername";
            this.tbDBUsername.Size = new System.Drawing.Size(205, 24);
            this.tbDBUsername.TabIndex = 8;
            this.tbDBUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDBPassword_KeyDown);
            // 
            // tbDBPassword
            // 
            this.tbDBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDBPassword.Location = new System.Drawing.Point(249, 334);
            this.tbDBPassword.Name = "tbDBPassword";
            this.tbDBPassword.Size = new System.Drawing.Size(205, 24);
            this.tbDBPassword.TabIndex = 9;
            this.tbDBPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDBUsername_KeyDown);
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(534, 12);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(16, 18);
            this.lbl_.TabIndex = 10;
            this.lbl_.Text = "_";
            this.lbl_.Click += new System.EventHandler(this.lbl__Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(556, 12);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 18);
            this.lblX.TabIndex = 11;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // pbEye
            // 
            this.pbEye.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.eyehide;
            this.pbEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEye.Location = new System.Drawing.Point(470, 334);
            this.pbEye.Name = "pbEye";
            this.pbEye.Size = new System.Drawing.Size(30, 30);
            this.pbEye.TabIndex = 12;
            this.pbEye.TabStop = false;
            this.pbEye.Click += new System.EventHandler(this.pbEye_Click);
            // 
            // FormSettingDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 451);
            this.Controls.Add(this.pbEye);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.tbDBPassword);
            this.Controls.Add(this.tbDBUsername);
            this.Controls.Add(this.tbDataSource);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettingDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Up Database";
            this.Load += new System.EventHandler(this.FormSettingDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbDataSource;
        private System.Windows.Forms.TextBox tbDBUsername;
        private System.Windows.Forms.TextBox tbDBPassword;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.PictureBox pbEye;
    }
}