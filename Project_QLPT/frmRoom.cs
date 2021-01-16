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
    public partial class frmRoom : UserControl
    {
        public frmRoom()
        {
            InitializeComponent();
            init();
        }

        private QLPT_DB context = new QLPT_DB();
        private string IDcurrent;
        private void CreateColumns(DataGridView dgview)
        {
            dgview.Columns.Add("IDPHONG", "Mã phòng");
            dgview.Columns.Add("TENPHONG", "Tên phòng");
            dgview.Columns.Add("TRANGTHAI", "Trạng thái");
            dgview.Columns.Add("GIAPHONG", "Giá phòng");
            dgview.Columns["IDPHONG"].DataPropertyName = "IDPHONG";
            dgview.Columns["TENPHONG"].DataPropertyName = "TENPHONG";
            dgview.Columns["TRANGTHAI"].DataPropertyName = "TRANGTHAI";
            dgview.Columns["GIAPHONG"].DataPropertyName = "GIAPHONG";
        }
        public void SetGridViewStyle(DataGridView dgview)
        {
            dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgview.Columns["IDPHONG"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgview.Sort(dgview.Columns["IDPHONG"], System.ComponentModel.ListSortDirection.Ascending);
            dgview.Columns["GIAPHONG"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgview.Columns["GIAPHONG"].DefaultCellStyle.Format = "c0";
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
            txtName.Clear();
            txtPrice.Clear();
            IDcurrent = null;
        }
        public void loadGridview()
        {
            dataGridView1.DataSource = context.PHONGs.Select(
                p=> new
                {
                    IDPHONG = p.IDPHONG,
                    TENPHONG = p.TENPHONG,
                    TRANGTHAI = p.TRANGTHAI,
                    GIAPHONG = p.GIAPHONG,
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
            if(e.RowIndex >= 0 && e.RowIndex <= dataGridView1.Rows.Count)
            {
                IDcurrent = dataGridView1.Rows[e.RowIndex].Cells["IDPHONG"].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["TENPHONG"].Value.ToString();
                txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells["GIAPHONG"].Value.ToString();
            }    
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Equals(string.Empty) || txtPrice.Text.Equals(string.Empty))
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                string IDLastroom;
                IDLastroom = context.PHONGs.Select(p => p.IDPHONG).ToList().Last();

                PHONG PH = new PHONG();
                PH.IDPHONG = ("P" + (int.Parse(IDLastroom.Replace("P", "")) + 1)).ToString();
                PH.TENPHONG = txtName.Text;
                PH.TRANGTHAI = "Trống";
                PH.GIAPHONG = int.Parse(txtPrice.Text);
                context.PHONGs.Add(PH);
                context.SaveChanges();
                clear();
                loadGridview();
                MessageBox.Show("Thêm thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(IDcurrent==null)
                    throw new Exception("Vui lòng chọn phòng cần xoá");
                if (txtName.Text.Equals(string.Empty) || txtPrice.Text.Equals(string.Empty))
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                PHONG PH = context.PHONGs.Where(p => p.IDPHONG.Equals(IDcurrent)).FirstOrDefault();
                if (PH == null)
                    throw new Exception("Không tìm thấy phòng");

                if(MessageBox.Show("Nếu xoá phòng này, các thông tin liên quan đến phòng này cũng sẽ bị xoá","Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.No)
                    throw new Exception("Xoá thất bại");
                context.PHONGs.Remove(PH);
                context.SaveChanges();
                clear();
                loadGridview();
                MessageBox.Show("Xoá thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !e.KeyChar.Equals((char)Keys.Back))
                e.Handled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDcurrent == null)
                    throw new Exception("Vui lòng chọn phòng cần xoá");
                if (txtName.Text.Equals(string.Empty) || txtPrice.Text.Equals(string.Empty))
                    if (txtName.Text.Equals(string.Empty) || txtPrice.Text.Equals(string.Empty))
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                PHONG PH = context.PHONGs.Where(p => p.IDPHONG.Equals(IDcurrent)).FirstOrDefault();
                if (PH == null)
                    throw new Exception("Không tìm thấy phòng");
                PH.TENPHONG = txtName.Text;
                PH.GIAPHONG = int.Parse(txtPrice.Text);
                context.Entry(PH).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                clear();
                loadGridview();
                MessageBox.Show("Sửa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
