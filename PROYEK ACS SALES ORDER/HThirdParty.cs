using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PROYEK_ACS_SALES_ORDER_V1
{
    public partial class HThirdParty : Form
    {
        string active = "";
        string MatchPhonePattern = @"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$";
        string MatchEmailPattern =
    @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
+ @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
+ @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
+ @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";
        bool cek = false;
        public string judul, id,iduser;
        public Login login;
        public HThirdParty(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void lbl__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HThirdParty_VisibleChanged(object sender, EventArgs e)
        {

            lblJudul.Text = judul;
            lblTPCode.Text = id;
            loadSSH(ref cbType, "THIRD_PARTY_TYPE");
            if(lblJudul.Text == "Add Third Party")
            {
                btnStatus.Enabled = false;
                lblStatus.Text = "Active";
            }
            else
            {
                btnStatus.Enabled = true;
            }
        }

        public void loadSSH(ref ComboBox cb, string parameter)
        {
            cb.DataSource = login.db.executeDataTable($"SELECT * FROM SSH_VARIABLES WHERE TIPE='{parameter}' AND ISI <> 'ALL'");
            cb.DisplayMember = "isi";
        }
        bool Eye = false;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(tbEmail.Text != "" && tbCity.Text != "")
            {
                if (Regex.IsMatch(tbEmail.Text, MatchEmailPattern))
                {
                    if(Regex.IsMatch(tbTelp.Text, MatchPhonePattern))
                    {
                        cek = true;
                    }
                }
                if (cek && tbName.Text != "" && tbCity.Text != "" && tbAddress.Text != "" && tbWeb.Text != "" && tbAlias.Text != "" && tbPostal.Text != "")
                {
                    if(lblJudul.Text == "Add Third Party")
                    {
                        login.db.executeNonQuery($"INSERT INTO THIRD_PARTY VALUES('{lblTPCode.Text}','{tbName.Text}','{tbAlias.Text}','{(cbType.SelectedIndex + 1).ToString()}','{tbCity.Text}','{tbPostal.Text}','{tbAddress.Text}','{tbEmail.Text}','{tbWeb.Text}','{tbTelp.Text}','{1}',{iduser})");
                    }
                    else
                    {
                        login.db.executeNonQuery($"UPDATE THIRD_PARTY SET FORMAL_NAME='{tbName.Text}',ALIAS_NAME='{tbAlias.Text}',THIRD_PARTY_TYPE='{(cbType.SelectedIndex + 1).ToString()}',CITY='{tbCity.Text}',POSTAL_CODE='{tbPostal.Text}',ADDRESS='{tbAddress.Text}',EMAIL='{tbEmail.Text}',WEBSITE='{tbWeb.Text}',PHONE_NUMBER='{tbTelp.Text}',ACTIVE_STATUS='{active}',USER_ROW_ID='{iduser}' WHERE ID_THIRD_PARTY='{lblTPCode.Text}'");
                    }
                    lblX_Click(sender, e);
                }
            }
            else if (!cek && tbName.Text != "" && tbCity.Text != "" && tbAddress.Text != "" && tbWeb.Text != "" && tbAlias.Text != "" && tbPostal.Text != "")
            {
                if (lblJudul.Text == "Add Third Party")
                {
                    login.db.executeNonQuery($"INSERT INTO THIRD_PARTY VALUES('{lblTPCode.Text}','{tbName.Text}','{tbAlias.Text}','{(cbType.SelectedIndex + 1).ToString()}','{tbCity.Text}','{tbPostal.Text}','{tbAddress.Text}','{null}','{tbWeb.Text}','{null}','{1}',{iduser})");
                }
                else
                {
                    login.db.executeNonQuery($"UPDATE THIRD_PARTY SET FORMAL_NAME='{tbName.Text}',ALIAS_NAME='{tbAlias.Text}',THIRD_PARTY_TYPE='{(cbType.SelectedIndex + 1).ToString()}',CITY='{tbCity.Text}',POSTAL_CODE='{tbPostal.Text}',ADDRESS='{tbAddress.Text}',EMAIL='{null}',WEBSITE='{tbWeb.Text}',PHONE_NUMBER='{null}',ACTIVE_STATUS='{active}' ,USER_ROW_ID={iduser} WHERE ID_THIRD_PARTY='{lblTPCode.Text}'");
                }
                lblX_Click(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbCity.Text = "";
            tbAddress.Text = "";
            tbEmail.Text = "";
            tbWeb.Text = "";
            tbAlias.Text = "";
            tbPostal.Text = "";
            tbTelp.Text = "";
            this.Hide();
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

        private void lblX_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbCity.Text = "";
            tbAddress.Text = "";
            tbEmail.Text = "";
            tbWeb.Text = "";
            tbAlias.Text = "";
            tbPostal.Text = "";
            tbTelp.Text = "";
            this.Hide();
        }
    }
}
