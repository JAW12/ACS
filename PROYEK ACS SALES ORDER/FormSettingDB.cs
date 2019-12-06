using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace PROYEK_ACS_SALES_ORDER_V1
{
    public partial class FormSettingDB : Form
    {
        Boolean Eye;

        public FormSettingDB()
        {
            InitializeComponent();
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            String dbsource = "", dbuser = "", dbpassword = "", dbip = "";
            dbsource = tbDataSource.Text;
            dbuser = tbDBUsername.Text;
            dbpassword = tbDBPassword.Text;
            dbip = "Current IP Address : " + GetLocalIPAddress();
            MessageBox.Show(dbip);

            if (dbsource != "" && dbuser != "" && dbpassword != "")
            {
                Boolean berhasil = connectionSuccessful(dbsource, dbuser, dbpassword);
                if (!berhasil)
                {
                    this.tbDataSource.Focus();
                    MessageBox.Show("Connecting Error : Please Recheck Your Data", "Setting Up Database Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Hide();
                    clearAllTextbox();
                    Login formLogin = new Login();
                    formLogin.dbSource = dbsource;
                    formLogin.dbUser = dbuser;
                    formLogin.dbPass = dbpassword;
                    formLogin.dbIP = dbip;
                    formLogin.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Please Complete All Data First", "Setting Up Database Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbDataSource_KeyDown(object sender, KeyEventArgs e)
        {
            enterEqualsButtonClicked(sender, e);
        }

        private void tbDBUsername_KeyDown(object sender, KeyEventArgs e)
        {
            enterEqualsButtonClicked(sender, e);
        }

        private void tbDBPassword_KeyDown(object sender, KeyEventArgs e)
        {
            enterEqualsButtonClicked(sender, e);
        }

        private void enterEqualsButtonClicked(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGo_Click(sender, e);
            }
        }

        private void clearAllTextbox()
        {
            foreach (Component c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Clear();
                }
            }
        }

        private Boolean connectionSuccessful(String datasource, String user, String pass)
        {
            Boolean success = false;
            try
            {
                OracleConnection conn = new OracleConnection($"Data Source = {datasource}; User ID = {user}; Password = {pass};");
                conn.Open();
                conn.Close();
                success = true;
            }
            catch (Exception)
            {
                success = false;
            }
            return success;
        }

        private void pbEye_Click(object sender, EventArgs e)
        {
            if (Eye)
            {
                pbEye.BackgroundImage = Properties.Resources.eyehide;
                tbDBPassword.PasswordChar = '*';
                Eye = !Eye;
            }
            else if (!Eye)
            {
                pbEye.BackgroundImage = Properties.Resources.eye;
                tbDBPassword.PasswordChar = '\0';
                Eye = !Eye;
            }
        }

        private void FormSettingDB_Load(object sender, EventArgs e)
        {
            Eye = true;
            pbEye_Click(sender, e);
        }
    }
}
