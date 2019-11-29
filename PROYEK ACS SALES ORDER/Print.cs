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
    public partial class Print : Form
    {
        public Login login;
        public Print(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lbl__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void crViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
