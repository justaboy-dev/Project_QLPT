using Project_QLPT.DataBase;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Project_QLPT
{
    public partial class frmRent : UserControl
    {
        public frmRent()
        {
            InitializeComponent();
            init();
        }
        private QLPT_DB context = new QLPT_DB();
        string IDphieu;
        string IDLastRoom;
        private void CreateColumns(DataGridView dgview)
        {
            dgview.Columns.Add("IDPHIEU", "Mã phiếu");
            dgview.Columns.Add("TENPHONG", "Tên phòng");
            dgview.Columns.Add("TENNGUOITHUE", "Tên người thuê");
            dgview.Columns.Add("NGAYTHUE", "Ngày thuê");
            dgview.Columns.Add("GIAPHONG", "Giá phòng");
            dgview.Columns.Add("GHICHU", "Ghi chú");
            dgview.Columns["IDPHIEU"].DataPropertyName = "IDPHIEU";
            dgview.Columns["TENPHONG"].DataPropertyName = "TENPHONG";
            dgview.Columns["TENNGUOITHUE"].DataPropertyName = "TENNGUOITHUE";
            dgview.Columns["NGAYTHUE"].DataPropertyName = "NGAYTHUE";
            dgview.Columns["GIAPHONG"].DataPropertyName = "GIAPHONG";
            dgview.Columns["GHICHU"].DataPropertyName = "GHICHU";
        }
        public void SetGridViewStyle(DataGridView dgview)
        {
            dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgview.Columns["GHICHU"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgview.Columns["GIAPHONG"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgview.Columns["GIAPHONG"].DefaultCellStyle.Format = "C0";
            dgview.Sort(dgview.Columns["IDPHIEU"], System.ComponentModel.ListSortDirection.Ascending);
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
        public void loadEmptyRoom()
        {
            var room = context.PHONGs.Where(p => p.TRANGTHAI.Equals("Trống")).Select(p => new { p.IDPHONG, p.TENPHONG }).ToList();
            if (room.Count == 0)
                MessageBox.Show("Không còn phòng trống !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                cboRoom.DataSource = room;
                cboRoom.DisplayMember = "TENPHONG";
                cboRoom.ValueMember = "IDPHONG";
            }
        }

        public void clear()
        {
            txtCMND.Clear();
            txtName.Clear();
            txtNote.Clear();
            txtNS.Clear();
            txtPhone.Clear();
            IDLastRoom = null;
            IDphieu = null;
            loadEmptyRoom();
        }
        public void loadRoom()
        {
            cboRoom.DataSource = context.PHONGs.Select(p => new { p.IDPHONG, p.TENPHONG }).ToList();
            cboRoom.DisplayMember = "TENPHONG";
            cboRoom.ValueMember = "IDPHONG";
        }
        public void loadGridview()
        {
            dataGridView1.DataSource = context.PHONGs.Join
                (
                    context.PHIEUTHUEs,
                    PH => PH.IDPHONG,
                    PT => PT.IDPHONG,
                    (PH, PT) => new { PH, PT }
                ).Join
                (
                    context.NGUOITHUEs,
                    PP => PP.PT.IDNGUOITHUE,
                    NT => NT.IDNGUOITHUE,
                    (PP, NT) => new { PP, NT }
                ).Select
                (
                    p => new
                    {
                        IDPHIEU = p.PP.PT.IDPHIEU,
                        TENPHONG = p.PP.PH.TENPHONG,
                        TENNGUOITHUE = p.NT.TENNGUOITHUE,
                        NGAYTHUE = p.PP.PT.NGAYTHUE,
                        GIAPHONG = p.PP.PH.GIAPHONG,
                        GHICHU = p.PP.PT.GHICHU,
                    }
                ).ToList();
        }
        public void init()
        {
            CreateColumns(dataGridView1);
            SetGridViewStyle(dataGridView1);
            loadGridview();
            loadEmptyRoom();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dataGridView1.Rows.Count)
            {

                IDphieu = dataGridView1.Rows[e.RowIndex].Cells["IDPHIEU"].Value.ToString();

                string room = dataGridView1.Rows[e.RowIndex].Cells["TENPHONG"].Value.ToString();

                loadRoom();
                cboRoom.SelectedValue = context.PHONGs.Where(p => p.TENPHONG.Equals(room)).Select(P => P.IDPHONG).FirstOrDefault();

                string ten = dataGridView1.Rows[e.RowIndex].Cells["TENNGUOITHUE"].Value.ToString();
                txtNS.Text = context.NGUOITHUEs.Where(p => p.TENNGUOITHUE.Equals(ten)).Select(P => P.NAMSINH).FirstOrDefault();

                txtName.Text = ten;

                txtNote.Text = dataGridView1.Rows[e.RowIndex].Cells["GHICHU"].Value.ToString();

                txtPhone.Text = context.NGUOITHUEs.Where(p => p.TENNGUOITHUE.Equals(ten)).Select(P => P.SDT).FirstOrDefault();

                txtCMND.Text = context.NGUOITHUEs.Where(p => p.TENNGUOITHUE.Equals(ten)).Select(P => P.CMND).FirstOrDefault();

                IDLastRoom = cboRoom.SelectedValue.ToString();
            }
        }
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            try
            {
                string ID = cboRoom.SelectedValue.ToString();
                if ((context.PHONGs.Where(p => p.IDPHONG.Equals(ID)).Select(p => p.TRANGTHAI).FirstOrDefault()).Equals("Đang thuê"))
                    throw new Exception("Phòng đã có người thuê, vui lòng chọn phòng khác");
                if (txtCMND.Text.Equals(string.Empty) || txtName.Text.Equals(string.Empty) || txtNote.Text.Equals(string.Empty) || txtNS.Text.Equals(string.Empty) || txtPhone.Text.Equals(string.Empty))
                    throw new Exception("Vui lòng nhập đủ thông tin !");
                string IDLast = context.NGUOITHUEs.Select(p => p.IDNGUOITHUE).ToList().Last();
                NGUOITHUE NT = new NGUOITHUE();
                NT.IDNGUOITHUE = "N" + (int.Parse(IDLast.Replace("N", "")) + 1).ToString();
                NT.TENNGUOITHUE = txtName.Text;
                NT.CMND = txtCMND.Text;
                NT.SDT = txtPhone.Text;
                NT.NAMSINH = txtNS.Text;
                context.NGUOITHUEs.Add(NT);
                PHIEUTHUE PT = new PHIEUTHUE();
                PT.IDPHIEU = "P" + (int.Parse(ID.Replace("P", "")) + 1).ToString();
                PT.IDPHONG = cboRoom.SelectedValue.ToString();
                PT.IDNGUOITHUE = NT.IDNGUOITHUE;
                PT.NGAYTHUE = System.DateTime.Now;
                PT.GHICHU = txtNote.Text;
                context.PHIEUTHUEs.Add(PT);

                PHONG P = context.PHONGs.Where(p => p.IDPHONG.Equals(ID)).FirstOrDefault();
                P.TRANGTHAI = "Đang thuê";
                context.Entry(P).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
                loadEmptyRoom();
                loadGridview();
                clear();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = IDphieu;
                string IDroom = cboRoom.SelectedValue.ToString();
                if (ID == null)
                    throw new Exception("Vui lòng chọn phiếu cần xoá !");
                PHIEUTHUE pt = context.PHIEUTHUEs.Where(p => p.IDPHIEU.Equals(ID)).FirstOrDefault();
                if (pt == null)
                    throw new Exception("Không tìm thấy phiếu !");
                PHONG PH = context.PHONGs.Where(p => p.IDPHONG.Equals(IDroom)).FirstOrDefault();
                PH.TRANGTHAI = "Trống";
                context.Entry(PH).State = System.Data.Entity.EntityState.Modified;
                context.PHIEUTHUEs.Remove(pt);
                context.SaveChanges();
                loadGridview();
                loadEmptyRoom();
                clear();
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = IDphieu;
                string IDroom = cboRoom.SelectedValue.ToString();
                if (ID == null)
                    throw new Exception("Vui lòng chọn phiếu cần sửa !");
                PHIEUTHUE pt = context.PHIEUTHUEs.Where(p => p.IDPHIEU.Equals(ID)).FirstOrDefault();
                if (pt == null)
                    throw new Exception("Không tìm thấy phiếu !");
                if (txtCMND.Text.Equals(string.Empty) || txtName.Text.Equals(string.Empty) || txtNote.Text.Equals(string.Empty) || txtNS.Text.Equals(string.Empty) || txtPhone.Text.Equals(string.Empty))
                    throw new Exception("Vui lòng nhập đủ thông tin !");
                if ((context.PHONGs.Where(p => p.IDPHONG.Equals(IDroom)).Select(p => p.TRANGTHAI).FirstOrDefault()).Equals("Trống") || IDroom.Equals(IDLastRoom))
                {
                    PHIEUTHUE PT = context.PHIEUTHUEs.Where(p => p.IDPHIEU.Equals(ID)).FirstOrDefault();
                    PT.IDPHONG = cboRoom.SelectedValue.ToString();
                    PT.GHICHU = txtNote.Text;
                    context.Entry(PT).State = System.Data.Entity.EntityState.Modified;

                    NGUOITHUE NT = context.NGUOITHUEs.Where(p => p.TENNGUOITHUE.Equals(txtName.Text)).FirstOrDefault();
                    NT.TENNGUOITHUE = txtName.Text;
                    NT.CMND = txtCMND.Text;
                    NT.SDT = txtPhone.Text;
                    NT.NAMSINH = txtNS.Text;
                    context.Entry(NT).State = System.Data.Entity.EntityState.Modified;



                    PHONG P = context.PHONGs.Where(p => p.IDPHONG.Equals(IDLastRoom)).FirstOrDefault();
                    P.TRANGTHAI = "Trống";
                    context.Entry(P).State = System.Data.Entity.EntityState.Modified;


                    P = context.PHONGs.Where(p => p.IDPHONG.Equals(IDroom)).FirstOrDefault();
                    P.TRANGTHAI = "Đang thuê";
                    context.Entry(P).State = System.Data.Entity.EntityState.Modified;

                    context.SaveChanges();
                    loadEmptyRoom();
                    loadGridview();
                    clear();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Phòng đã có người ở, vui lòng chọn phòng khác !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = IDphieu;
                string IDroom = cboRoom.SelectedValue.ToString();
                if (ID == null)
                    throw new Exception("Vui lòng chọn phiếu cần sửa !");
                PHIEUTHUE pt = context.PHIEUTHUEs.Where(p => p.IDPHIEU.Equals(ID)).FirstOrDefault();
                if (pt == null)
                    throw new Exception("Không tìm thấy phiếu !");
                if (pt.GHICHU.Equals("Đã trả phòng"))
                    throw new Exception("Phòng đã trả trước đó rồi !");
                pt.NGAYTRA = System.DateTime.Now;
                pt.GHICHU = "Đã trả phòng";

                PHONG PH = context.PHONGs.Where(p => p.IDPHONG.Equals(IDroom)).FirstOrDefault();
                PH.TRANGTHAI = "Trống";

                context.Entry(PH).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                loadEmptyRoom();
                loadGridview();
                clear();
                MessageBox.Show("Trả phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !e.KeyChar.Equals((char)Keys.Back))
                e.Handled = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !e.KeyChar.Equals((char)Keys.Back))
                e.Handled = true;
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !e.KeyChar.Equals((char)Keys.Back))
                e.Handled = true;
        }
    }
}
