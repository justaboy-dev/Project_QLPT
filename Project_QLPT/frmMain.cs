using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Project_QLPT
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        string username;
        public frmMain(string usr)
        {
            InitializeComponent();
            username = usr;
        }
        
        private Button currentBtn;
        public void loadUS(UserControl us)
        {
            us.Dock = DockStyle.Fill;
            us.Show();
            pnlDesktop.Controls.Clear();
            pnlDesktop.Controls.Add(us);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            UserControl us = new frmHome();
            loadUS(us);
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(128,128,255);
                currentBtn.ForeColor = Color.Gainsboro;
            }
        }

        private void SelectButton(object sender)
        {
            DisableButton();
            currentBtn = (Button)sender;
            currentBtn.BackColor = Color.White;
            currentBtn.ForeColor = Color.BlueViolet;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = !pnlMenu.Visible;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SelectButton(sender);
            UserControl us = new frmHome();
            loadUS(us);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            SelectButton(sender);
            UserControl us = new frmRent();
            loadUS(us);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            SelectButton(sender);
            UserControl us = new frmCustomer();
            loadUS(us);
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            SelectButton(sender);
            UserControl us = new frmRoom();
            loadUS(us);
        }

        private void btnChangepass_Click(object sender, EventArgs e)
        {
            SelectButton(sender);
            UserControl us = new frmChangePass(username);
            loadUS(us);
        }

        private void btnStatis_Click(object sender, EventArgs e)
        {
            SelectButton(sender);
            UserControl us = new frmStatis();
            loadUS(us);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMinium_Click(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Normal)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnMiniMize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
