using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_QLPT.DataBase;

namespace Project_QLPT
{
    public partial class frmChangePass : UserControl
    {
        public frmChangePass()
        {
            InitializeComponent();
        }
        string username;
        public frmChangePass(string user)
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
            txtRepeatPass.UseSystemPasswordChar = true;
            checkBox1.Checked = false;
            username = user;
        }
        private QLPT_DB context = new QLPT_DB();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text.Equals(string.Empty) || txtRepeatPass.Text.Equals(string.Empty))
                    throw new Exception("Vui lòng nhập đủ thông tin !");
                if (!txtPass.Text.Equals(txtRepeatPass.Text))
                    throw new Exception("Mật khẩu không trùng khớp !");
                ACCOUNT acc = context.ACCOUNTs.Where(p => p.USR.Equals(username)).FirstOrDefault();
                acc.PWD = txtPass.Text;
                context.Entry(acc).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Đổi mật khẩu thành công, vui lòng mở phần mềm lại");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked.Equals(true))
            {
                txtPass.UseSystemPasswordChar = false;
                txtRepeatPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                txtRepeatPass.UseSystemPasswordChar = true;
            }
        }
    }
}
