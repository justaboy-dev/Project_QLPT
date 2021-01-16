using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_QLPT.DataBase;

namespace Project_QLPT
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
            checkBox1.Checked = false;
        }
        private QLPT_DB context = new QLPT_DB();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text.Equals(string.Empty) || txtPass.Text.Equals(string.Empty))
                    throw new Exception("Vui lòng nhập đủ thông tin đăng nhập !");
                if (context.ACCOUNTs.Where(p => p.USR.Equals(txtUser.Text)).FirstOrDefault()==null)
                    throw new Exception("Không tìm thấy tài khoản !");
                if (!context.ACCOUNTs.Where(p=>p.USR.Equals(txtUser.Text)).Select(p => p.USR).FirstOrDefault().Equals(txtUser.Text)
                    || !context.ACCOUNTs.Where(p => p.USR.Equals(txtUser.Text)).Select(p => p.PWD).FirstOrDefault().Equals(txtPass.Text))
                    throw new Exception("Sai thông tin đăng nhập !");
                frmMain frm = new frmMain(txtUser.Text);
                frm.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked.Equals(true))
            {
                txtPass.UseSystemPasswordChar = false;
            }    
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }   
        }
    }
}
