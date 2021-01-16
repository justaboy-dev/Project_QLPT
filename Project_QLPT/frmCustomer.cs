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
    public partial class frmCustomer : UserControl
    {
        public frmCustomer()
        {
            InitializeComponent();
            init();
        }
        private QLPT_DB context = new QLPT_DB();
        private string ID;
        private void CreateColumns(DataGridView dgview)
        {
            dgview.Columns.Add("IDNGUOITHUE", "Mã người thuê");
            dgview.Columns.Add("TENNGUOITHUE", "Tên người thuê");
            dgview.Columns.Add("NAMSINH", "Năm sinh");
            dgview.Columns.Add("CMND", "Số CMND");
            dgview.Columns.Add("SDT", "Số ĐT");
            dgview.Columns["IDNGUOITHUE"].DataPropertyName = "IDNGUOITHUE";
            dgview.Columns["TENNGUOITHUE"].DataPropertyName = "TENNGUOITHUE";
            dgview.Columns["NAMSINH"].DataPropertyName = "NAMSINH";
            dgview.Columns["CMND"].DataPropertyName = "CMND";
            dgview.Columns["SDT"].DataPropertyName = "SDT";
        }
        public void SetGridViewStyle(DataGridView dgview)
        {
            dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgview.Columns["IDNGUOITHUE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgview.Sort(dgview.Columns["IDNGUOITHUE"], System.ComponentModel.ListSortDirection.Ascending);
            dgview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgview.ScrollBars = ScrollBars.Both;
            dgview.BorderStyle = BorderStyle.None;
            dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgview.BackgroundColor = Color.White;
            dgview.EnableHeadersVisualStyles = false;
            dgview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview.AllowUserToResizeColumns = false;
            dgview.AllowUserToResizeRows = false;
            dgview.AllowUserToDeleteRows = false;
            dgview.AllowUserToAddRows = false;
            dgview.AllowUserToOrderColumns = true;
            dgview.MultiSelect = false;
            dgview.ReadOnly = true;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
      
        public void clear()
        {
            txtCMND.Clear();
            txtName.Clear();
            txtNS.Clear();
            txtPhone.Clear();;
        }
        public void loadGridview()
        {
            dataGridView1.DataSource = context.NGUOITHUEs
                .Select
                (
                    p => new
                    {
                        IDNGUOITHUE = p.IDNGUOITHUE,
                        TENNGUOITHUE = p.TENNGUOITHUE,
                        NAMSINH = p.NAMSINH,
                        CMND = p.CMND,
                        SDT = p.SDT,
                    }
                )
                .ToList();
        }
        public void init()
        {
            CreateColumns(dataGridView1);
            SetGridViewStyle(dataGridView1);
            loadGridview();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dataGridView1.Rows.Count)
            {
                ID = dataGridView1.Rows[e.RowIndex].Cells["IDNGUOITHUE"].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["TENNGUOITHUE"].Value.ToString();
                txtNS.Text = dataGridView1.Rows[e.RowIndex].Cells["NAMSINH"].Value.ToString();
                txtCMND.Text = dataGridView1.Rows[e.RowIndex].Cells["CMND"].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Equals(string.Empty) || txtCMND.Text.Equals(string.Empty) || txtNS.Text.Equals(string.Empty) || txtPhone.Text.Equals(string.Empty))
                    throw new Exception("Vui lòng nhập đầy đủ thông tin !");
                string IDLast = context.NGUOITHUEs.Select(p => p.IDNGUOITHUE).ToList().Last();
                NGUOITHUE NT = new NGUOITHUE();
                NT.IDNGUOITHUE = "N" + (int.Parse(IDLast.Replace("N", "")) + 1).ToString();
                NT.TENNGUOITHUE = txtName.Text;
                NT.NAMSINH = txtNS.Text;
                NT.SDT = txtPhone.Text;
                NT.CMND = txtCMND.Text;
                context.NGUOITHUEs.Add(NT);
                context.SaveChanges();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadGridview();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if(ID==null)
                    throw new Exception("Vui lòng chọn khách hàng cần sửa !");
                if (txtName.Text.Equals(string.Empty) || txtCMND.Text.Equals(string.Empty) || txtNS.Text.Equals(string.Empty) || txtPhone.Text.Equals(string.Empty))
                    throw new Exception("Vui lòng nhập đầy đủ thông tin !");
                NGUOITHUE NT = context.NGUOITHUEs.Where(p => p.IDNGUOITHUE.Equals(ID)).FirstOrDefault();
                NT.TENNGUOITHUE = txtName.Text;
                NT.NAMSINH = txtNS.Text;
                NT.SDT = txtPhone.Text;
                NT.CMND = txtCMND.Text;
                context.Entry(NT).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadGridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !e.KeyChar.Equals((char)Keys.Back))
                e.Handled = true;
        }

        private void txtNS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !e.KeyChar.Equals((char)Keys.Back))
                e.Handled = true;
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !e.KeyChar.Equals((char)Keys.Back))
                e.Handled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID == null)
                    throw new Exception("Vui lòng chọn khách hàng cần xoá !");
                if (txtName.Text.Equals(string.Empty) || txtCMND.Text.Equals(string.Empty) || txtNS.Text.Equals(string.Empty) || txtPhone.Text.Equals(string.Empty))
                    throw new Exception("Vui lòng nhập đầy đủ thông tin !");
                if(MessageBox.Show("Bạn thật sự muốn xoá, thao tác này sẽ xoá các thông tin liên quan đến khách hàng này","Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.No)
                    throw new Exception("Xoá thất bại");
                NGUOITHUE NT = context.NGUOITHUEs.Where(p => p.IDNGUOITHUE.Equals(ID)).FirstOrDefault();
                context.NGUOITHUEs.Remove(NT);
                context.SaveChanges();
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadGridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
