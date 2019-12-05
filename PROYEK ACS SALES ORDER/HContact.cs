using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Text.RegularExpressions;

namespace PROYEK_ACS_SALES_ORDER_V1
{
    public partial class HContact : Form
    {
        public Login login;
        int activegak = 0;
        Boolean validasi = true;
        string tempidcontact;
        string idcontact = "";
        public const string MatchEmailPattern =
            @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
     + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
     + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";
        Boolean benaremail;

        public HContact(Login login, string idcontact)
        {
            InitializeComponent();
            this.login = login;
            this.idcontact = idcontact;
        }

        public HContact(Login login)
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
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            validasi = true;
            if (cbTP.SelectedIndex ==-1)
            {
                cbTP.BackColor = Color.Red;
                validasi = false;
            }
            if (cbTitle.SelectedIndex==-1)
            {
                cbTitle.BackColor = Color.Red;
                validasi = false;
            }
            if (tbFirst.Text=="")
            {
                tbFirst.BackColor = Color.Red;
                validasi = false;
            }
            if (tbCity.Text=="")
            {
                tbCity.BackColor = Color.Red;
                validasi = false;
            }
            if (tbAddress.Text=="")
            {
                tbAddress.BackColor = Color.Red;
                validasi = false;
            }
            if (cbJob.SelectedIndex==-1)
            {
                cbJob.BackColor = Color.Red;
                validasi = false;
            }
            if (tbLast.Text=="")
            {
                tbLast.BackColor = Color.Red;
                validasi = false;
            }
            if (tbBirth.Text=="")
            {
                tbBirth.BackColor = Color.Red;
                validasi = false;
            }
            if (tbMobile.Text=="")
            {
                tbMobile.BackColor = Color.Red;
                validasi = false;
            }
            if (tbEmail.Text != null) benaremail = Regex.IsMatch(tbEmail.Text, MatchEmailPattern);
            else benaremail = false;
            if (benaremail == true&& validasi==true)
            {
                if (idcontact == "")
                {
                    if (lblStatus.Text.ToString() == "No Active")
                    {
                        activegak = 0;
                    }
                    else if (lblStatus.Text.ToString() == "Active")
                    {
                        activegak = 1;
                    }
                    login.db.executeNonQuery($"Insert into contact values(" +
                         $"'{lblCCode.Text.ToString()}'," +
                         $"'{cbTitle.SelectedItem.ToString()}', " +
                         $"'{tbLast.Text.ToString()}', " +
                         $"'{tbFirst.Text.ToString()}', " +
                         $"'{tbTelp.Text.ToString()}', " +
                         $"'{tbMobile.Text.ToString()}', " +
                         $"'{tbEmail.Text.ToString()}', " +
                         $"'{tbCity.Text.ToString()}', " +
                         $"'{tbAddress.Text.ToString()}', " +
                         $"to_Date('{dtpBirth.Value.ToString("dd/MM/yyyy")}','dd/mm/yyyy'), " +
                         $"'{tbBirth.Text.ToString()}', " +
                         $"'{activegak.ToString()}', " +
                         $"'{cbJob.SelectedItem.ToString()}', " +
                         $"'{cbTP.SelectedValue.ToString()}', " +
                         $"'1')");
                    bershin_data();
                }
                else
                {
                    if (lblStatus.Text.ToString() == "No Active")
                    {
                        activegak = 0;
                    }
                    else if (lblStatus.Text.ToString() == "Active")
                    {
                        activegak = 1;
                    }
                    login.db.executeNonQuery($"UPDATE CONTACT SET FORMAL_TITLE = '{cbTitle.SelectedItem.ToString()}' WHERE id_contact = '" + idcontact + "'");
                    login.db.executeNonQuery($"UPDATE CONTACT SET LAST_NAME = '{tbLast.Text.ToString()}' WHERE id_contact = '" + idcontact + "'");
                    login.db.executeNonQuery($"UPDATE CONTACT SET FIRST_NAME = '{tbFirst.Text.ToString()}' WHERE id_contact = '" + idcontact + "'");
                    login.db.executeNonQuery($"UPDATE CONTACT SET PHONE_NUMBER = '{tbTelp.Text.ToString()}' WHERE id_contact = '" + idcontact + "'");
                    login.db.executeNonQuery($"UPDATE CONTACT SET MOBILE_NUMBER = '{tbMobile.Text.ToString()}' WHERE id_contact = '" + idcontact + "'");
                    login.db.executeNonQuery($"UPDATE CONTACT SET EMAIL = '{tbEmail.Text.ToString()}' WHERE id_contact = '" + idcontact + "'");
                    login.db.executeNonQuery($"UPDATE CONTACT SET CITY = '{tbCity.Text.ToString()}' WHERE id_contact = '" + idcontact + "'");
                    login.db.executeNonQuery($"UPDATE CONTACT SET ADDRESS = '{tbAddress.Text.ToString()}' WHERE id_contact = '" + idcontact + "'");
                    login.db.executeNonQuery($"UPDATE CONTACT SET DATE_OF_BIRTH = to_Date('{dtpBirth.Value.ToString("dd/MM/yyyy")}','dd/mm/yyyy')  WHERE id_contact = '" + idcontact + "'");
                    login.db.executeNonQuery($"UPDATE CONTACT SET PLACE_OF_BIRTH = '{tbBirth.Text.ToString()}' WHERE id_contact = '" + idcontact + "'");
                    login.db.executeNonQuery($"UPDATE CONTACT SET ACTIVE_STATUS = '{activegak.ToString()}' WHERE id_contact = '" + idcontact + "'");
                    login.db.executeNonQuery($"UPDATE CONTACT SET JOB_POSITION = '{cbJob.SelectedItem.ToString()}' WHERE id_contact = '" + idcontact + "'");
                    login.db.executeNonQuery($"UPDATE CONTACT SET ID_THIRD_PARTY = '{cbTP.SelectedValue.ToString()}' WHERE id_contact = '" + idcontact + "'");
                    this.Close();
                }
            }
            else if (benaremail == false)
            {
                tbEmail.BackColor = Color.Red;
            }
            if (validasi==false)
            {
                MessageBox.Show("Please Check again");
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Active")
            {
                lblStatus.Text = "No Active";
                btnStatus.Text = "Active";
            }
            else if (lblStatus.Text == "No Active")
            {
                lblStatus.Text = "Active";
                btnStatus.Text = "No Active";
            }
        }
       
        private void isicomboxthird()
        {
            DataTable dt = login.db.executeDataTable("select ID_THIRD_PARTY,FORMAL_NAME from third_party");

            cbTP.DataSource = dt;
            cbTP.ValueMember = "ID_THIRD_PARTY";
            cbTP.DisplayMember = "FORMAL_NAME";
        }
        private void autogenerate()
        {
            int count = Convert.ToInt32(login.db.executeScalar("select count(*) id_contact from contact"));
            count = count + 1;
            if (count < 10)
            {
                tempidcontact = "CO00" + count;
            }
            else if (count < 100)
            {
                tempidcontact = "CO0" + count;
            }
            else
            {
                tempidcontact = "CO" + count;
            }
            lblCCode.Text = tempidcontact;
        }
        private void bershin_data() {
            tbFirst.Text = "";
            tbEmail.Text = "";
            tbCity.Text = "";
            tbAddress.Text = "";
            tbLast.Text = "";
            tbAddress.Text = "";
            tbBirth.Text = "";
            tbTelp.Text = "";
            tbMobile.Text = "";
            cbJob.SelectedIndex = 0;
            cbTitle.SelectedIndex = 0;
            cbTP.SelectedIndex = 0;
            tbFirst.BackColor = Color.White;
            tbEmail.BackColor = Color.White;
            tbCity.BackColor = Color.White;
            tbAddress.BackColor = Color.White;
            tbLast.BackColor = Color.White;
            tbAddress.BackColor = Color.White;
            tbBirth.BackColor = Color.White;
            tbMobile.BackColor = Color.White;
            cbJob.BackColor = Color.White;
            cbTitle.BackColor = Color.White;
            cbTP.BackColor = Color.White;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            bershin_data();
        }

        private void HContact_VisibleChanged(object sender, EventArgs e)
        {
            if (idcontact == "")
            {
                lblStatus.Text = "No Active";
                autogenerate();
                isicomboxthird();
            }
            else
            {
                isicomboxthird();
                lblCCode.Text = idcontact + "";
                List<Object[]> dapat = login.db.executeQuery("select c.ACTIVE_STATUS , T.FORMAL_NAME, C.FORMAL_TITLE, C.FIRST_NAME, C.DATE_OF_BIRTH, C.EMAIL, C.CITY, C.ADDRESS, C.JOB_POSITION, C.LAST_NAME, C.PLACE_OF_BIRTH, C.PHONE_NUMBER, C.MOBILE_NUMBER FROM CONTACT C ,THIRD_PARTY T WHERE C.ID_CONTACT='" + idcontact + "' AND C.ID_THIRD_PARTY = T.ID_THIRD_PARTY");
                if (dapat[0][0].ToString() == "0")
                {
                    lblStatus.Text = "No Active";
                }
                else if (dapat[0][0].ToString() == "1")
                {
                    lblStatus.Text = "Active";
                }

                cbTP.Text = dapat[0][1].ToString();
                cbTitle.Text = dapat[0][2].ToString();
                tbFirst.Text = dapat[0][3].ToString();
                dtpBirth.Value = Convert.ToDateTime(dapat[0][4].ToString());
                tbEmail.Text = dapat[0][5].ToString();
                tbCity.Text = dapat[0][6].ToString();
                tbAddress.Text = dapat[0][7].ToString();
                String apa = dapat[0][8].ToString();
                cbJob.Text = dapat[0][8].ToString();

                tbLast.Text = dapat[0][9].ToString(); ;
                tbBirth.Text = dapat[0][10].ToString();
                tbTelp.Text = dapat[0][11].ToString();
                tbMobile.Text = dapat[0][12].ToString();
                if (lblStatus.Text == "Active")
                {
                    btnStatus.Text = "No Active";
                }
                else if (lblStatus.Text == "No Active")
                {
                    btnStatus.Text = "Active";
                }
            }
        }

        private void tbTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
