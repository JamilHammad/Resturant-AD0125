using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_ad0125
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

            if (txtPassword.Text == "0000")
            {
                frmMainMenue main = new frmMainMenue(txtUserName.Text);
                main.Show();
            }
            else
                MessageBox.Show("invalid password");
        }
    }
}
