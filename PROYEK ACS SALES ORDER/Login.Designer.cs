namespace PROYEK_ACS_SALES_ORDER_V1
{
    partial class Login
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lbl_ = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbEye = new System.Windows.Forms.PictureBox();
            this.pbPass = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(214, 268);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(205, 24);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUsername_KeyDown);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(214, 305);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(205, 24);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(570, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 18);
            this.lblX.TabIndex = 4;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(551, 9);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(16, 18);
            this.lbl_.TabIndex = 3;
            this.lbl_.Text = "_";
            this.lbl_.Click += new System.EventHandler(this.lbl__Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(80)))), ((int)(((byte)(137)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogin.Location = new System.Drawing.Point(259, 335);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 36);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbEye
            // 
            this.pbEye.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.eyehide;
            this.pbEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEye.Location = new System.Drawing.Point(425, 300);
            this.pbEye.Name = "pbEye";
            this.pbEye.Size = new System.Drawing.Size(30, 30);
            this.pbEye.TabIndex = 4;
            this.pbEye.TabStop = false;
            this.pbEye.Click += new System.EventHandler(this.pbEye_Click);
            // 
            // pbPass
            // 
            this.pbPass.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.password;
            this.pbPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPass.Location = new System.Drawing.Point(178, 302);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(30, 30);
            this.pbPass.TabIndex = 3;
            this.pbPass.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.user;
            this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUser.Location = new System.Drawing.Point(178, 266);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(30, 30);
            this.pbUser.TabIndex = 2;
            this.pbUser.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::PROYEK_ACS_SALES_ORDER_V1.Properties.Resources.logo;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(45, 24);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(500, 300);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.pbEye);
            this.Controls.Add(this.pbPass);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbPass;
        private System.Windows.Forms.PictureBox pbEye;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Button btnLogin;
    }
}

