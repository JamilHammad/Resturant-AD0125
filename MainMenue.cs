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
    public partial class frmMainMenue : Form
    {
        private string ShowName;
        public frmMainMenue(string showName)
        {
            InitializeComponent();
            ShowName = showName;    
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            lblShowName.Text = ShowName;
        }

        private void btnMenue_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            frmMenue frm = new frmMenue();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panel3.Controls.Add(frm);
            frm.Show();
        }

        private void btnOpinion_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            frmOpinion frm3 = new frmOpinion();
            frm3.TopLevel = false;
            frm3.Dock = DockStyle.Fill;
            panel3.Controls.Add(frm3);
            frm3.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            frmOrder frm4 = new frmOrder();
            frm4.TopLevel = false;
            frm4.Dock = DockStyle.Fill;
            panel3.Controls.Add(frm4);
            frm4.Show();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
