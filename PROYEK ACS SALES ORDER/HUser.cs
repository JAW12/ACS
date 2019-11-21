using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYEK_ACS_SALES_ORDER_V1
{
    public partial class HUser : Form
    {
        public string judul, id,uname,name,pass,type,branch,status;
        public Login login;
        public HUser(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void lbl__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            lblUserID.Text = "-";
            btnStatus.Enabled = false;
            lblStatus.Text = "-";
            btnStatus.Enabled = false;
            tbCity.Text = "";
            tbEmail.Text = "";
            tbFirst.Text = "";
            tbLast.Text = "";
            Hide();
        }

        public void loadSSH(ref ComboBox cb, string parameter)
        {
            if (parameter == "")
            {
                cb.DataSource = login.db.executeDataTable("SELECT * FROM V_BRANCH");
                cb.DisplayMember = "BRANCH_NAME";
                cb.ValueMember = "ID_BRANCH";
            }
            else
            {
                cb.DataSource = login.db.executeDataTable($"SELECT * FROM SSH_VARIABLES WHERE TIPE='{parameter}' AND ISI != 'ALL'");
                cb.DisplayMember = "isi";
            }
        }
        bool Eye = false;
        private void pbEye_Click(object sender, EventArgs e)
        {
            if (Eye)
            {
                pbEye.BackgroundImage = Properties.Resources.eyehide;
                tbEmail.PasswordChar = '*';
                tbCity.PasswordChar = '*';
                Eye = !Eye;
            }
            else if (!Eye)
            {
                pbEye.BackgroundImage = Properties.Resources.eye;
                tbEmail.PasswordChar = '\0';
                tbCity.PasswordChar = '\0';
                Eye = !Eye;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbFirst.Text != "" && tbLast.Text != "" && tbCity.Text != "" && tbEmail.Text != "" && cbType.SelectedIndex != -1 && cbBranch.SelectedIndex != -1)
            {
                if (tbEmail.Text == tbCity.Text)
                {
                    if (lblJudul.Text == "Add User")
                    {
                        login.db.executeNonQuery($"INSERT INTO USER_DATA VALUES('{lblUserID.Text}','{tbFirst.Text}','{tbEmail.Text}','{tbLast.Text}','{(cbType.SelectedIndex + 1).ToString()}','{1}','{cbBranch.SelectedValue.ToString()}')");
                    }
                    else
                    {
                        login.db.executeNonQuery($"UPDATE USER_DATA SET USERNAME='{tbFirst.Text}',U_PASSWORD='{tbEmail.Text}',U_NAME='{tbLast.Text}',U_STATUS='{(cbType.SelectedIndex + 1).ToString()}',U_ACTIVE_STATUS='{active}',ID_BRANCH='{cbBranch.SelectedValue.ToString()}' WHERE USER_ROW_ID='{lblUserID.Text}'");
                    }
                    lblX_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Password is not valid");
                }
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (btnStatus.Text == "Active")
            {
                active = "1";
                lblStatus.Text = "Active";
                btnStatus.Text = "Non Active";
            }
            else
            {
                active = "0";
                lblStatus.Text = "Non Active";
                btnStatus.Text = "Active";
            }
        }

        private void HUser_VisibleChanged(object sender, EventArgs e)
        {
            lblJudul.Text = judul;
            if (lblJudul.Text == "Add User")
            {
                Object newId = login.db.executeScalar("SELECT COUNT(USER_ROW_ID) + 1 FROM USER_DATA");
                lblUserID.Text = newId.ToString();
                lblStatus.Text = "Active";
                btnStatus.Enabled = false;
            }
            else
            {
                btnStatus.Enabled = true;
                lblUserID.Text = id;
            }
            loadSSH(ref cbType, "USER_TYPE");
            loadSSH(ref cbBranch, "");
            tbFirst.Text = uname;
            tbLast.Text = name;
            tbEmail.Text = pass;
            tbCity.Text = pass;
            cbType.SelectedIndex = Convert.ToInt32(type);
            Object namaBranch = login.db.executeScalar($"SELECT BRANCH_NAME FROM V_BRANCH WHERE ID_BRANCH='{branch}'");
            for (int i = 0; i < cbBranch.Items.Count; i++)
            {
                string nama = cbBranch.GetItemText(cbBranch.Items[i]);
                if (nama == namaBranch.ToString())
                {
                    cbBranch.SelectedIndex = i;
                    break;
                }
            }
            if(status == "0")
            {
                lblStatus.Text = "Non Active";
                btnStatus.Text = "Active";
            }
            else
            {
                lblStatus.Text = "Active";
                btnStatus.Text = "Non Active";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblX_Click(sender, e);
        }

        string active = "";
    }
}
