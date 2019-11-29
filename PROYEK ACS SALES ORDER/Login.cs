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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.dbUser = "proyekacs";
            this.dbPass = "proyekacs";
            this.dbSource = "XE";
        }

        public String dbUser, dbPass, dbSource;
        public Database db;
        public AddProduct addProduct;
        public Browse browse;
        public Contact contact;
        public DSalesOrder dSales;
        public HContact hContact;
        public HSalesOrder hSales;
        public HThirdParty hThirdParty;
        public HUser hUser;
        public Login login;
        public Master_User master_User;
        public Print print;
        public SalesOrder sales;
        public Statistic statistic;
        public ThirdParties thirdParties;

        public string idUser;
        public string namaUser;
        public string jabatanUser;
        public string branchUser;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<Object[]> user = db.executeQuery("SELECT * FROM V_AKSES");
            int idxUser = -1;
            for(int i =0; i < user.Count; i++)
            {
                if(tbUsername.Text == user[i][1].ToString())
                {
                    idxUser = i;
                }
            }
            if(idxUser != -1)
            {
                if(user[idxUser][5].ToString() == "0")
                {
                    MessageBox.Show("User is inactive.");
                }
                else
                {
                    if (tbPassword.Text == user[idxUser][3].ToString())
                    {
                        idUser = user[idxUser][0].ToString();
                        namaUser = user[idxUser][2].ToString();

                        if (user[idxUser][4].ToString() == "1")
                        {
                            jabatanUser = "Admin";
                            branchUser = "ALL";
                        }
                        else if (user[idxUser][4].ToString() == "2")
                        {
                            jabatanUser = "Manager";
                            branchUser = db.executeScalar($"SELECT B.BRANCH_NAME FROM BRANCH B, USER_DATA U WHERE U.USER_ROW_ID = '{idUser}' AND U.ID_BRANCH = B.ID_BRANCH").ToString();
                        }
                        else if (user[idxUser][4].ToString() == "3")
                        {
                            jabatanUser = "Sales";
                            branchUser = db.executeScalar($"SELECT B.BRANCH_NAME FROM BRANCH B, USER_DATA U WHERE U.USER_ROW_ID = '{idUser}' AND U.ID_BRANCH = B.ID_BRANCH").ToString();
                        }
                       

                        MessageBox.Show("Login As " + jabatanUser);
                        thirdParties.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("User Does Not Exist");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            db = new Database(dbSource, dbUser, dbPass);
            addProduct = new AddProduct(this);
            browse = new Browse(this);
            contact = new Contact(this);
            dSales = new DSalesOrder(this);
            hContact = new HContact(this);
            hSales = new HSalesOrder(this);
            hThirdParty = new HThirdParty(this);
            hUser = new HUser(this);
            login = this;
            master_User = new Master_User(this);
            print = new Print(this);
            sales = new SalesOrder(this);
            statistic = new Statistic(this);
            thirdParties = new ThirdParties(this);
        }

        private void lbl__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool Eye = false;
        private void pbEye_Click(object sender, EventArgs e)
        {
            if (Eye)
            {
                pbEye.BackgroundImage = Properties.Resources.eyehide;
                tbPassword.PasswordChar = '*';
                Eye = !Eye;
            }
            else if (!Eye)
            {
                pbEye.BackgroundImage = Properties.Resources.eye;
                tbPassword.PasswordChar = '\0';
                Eye = !Eye;
            }
        }
    }
}
