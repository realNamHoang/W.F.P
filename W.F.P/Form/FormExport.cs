using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using W.F.P.service;

namespace W.F.P
{
    public partial class FormExport : Form
    {
        DatabaseAccess databaseAccess = new DatabaseAccess();
        public FormExport()
        {
            InitializeComponent();
        }

        private void FormProdusterCustommer_Load(object sender, EventArgs e)
        {
            using (var database = new TotalData())
            {
                var soHDB = (from u in database.ChiTietHDBs select u).ToList();
                string countnumber = (soHDB.Count() + 1).ToString().PadLeft(6, '0');
                SoHDBBox.Text = "SHDB" + countnumber;
                var NhanVien = (from u in database.NhanViens select u).ToList();
                var MaKhach = (from u in database.KhachHangs select u).ToList();
                for (int i = 0; i < NhanVien.Count; i++)
                {
                    MaNVBox.Items.Add(NhanVien[i].MaNhanVien);
                }
                for (int i = 0; i < MaKhach.Count; i++)
                {
                    MaKhachBox.Items.Add(MaKhach[i].MaKhach);
                }
            }
        }

        private void ButtonAddData_Click(object sender, EventArgs e)
        {
            long data = 0;
            using (var database = new TotalData())
            {
                var setDetailProduceImport = database.Set<ChiTietHDB>();
                var setProduceImport = database.Set<HoaDonBan>();
                foreach (DataGridViewRow row in DGVExport.Rows)
                {
                    ChiTietHDB chiTietHDN = new ChiTietHDB();
                    chiTietHDN.SoHDB = row.Cells[0].Value.ToString();
                    chiTietHDN.MaGiayDep = row.Cells[1].Value.ToString();
                    chiTietHDN.SoLuong = int.Parse(row.Cells[2].Value.ToString());
                    chiTietHDN.GiamGia = long.Parse(row.Cells[3].Value.ToString());
                    chiTietHDN.ThanhTien = long.Parse(row.Cells[4].Value.ToString());
                    setDetailProduceImport.Add(chiTietHDN);
                    data += long.Parse(row.Cells[5].Value.ToString());
                }
                HoaDonBan sanPhamMoi = new HoaDonBan();
                databaseAccess.CheckDataTextBox(SoHDBBox);
                sanPhamMoi.SoHDB = SoHDBBox.Text;
                databaseAccess.CheckDataTextBox(MaGiayDepBox);
                sanPhamMoi.MaNV = MaGiayDepBox.Text;
                databaseAccess.CheckDataTextBox(SoLuongBox);
                sanPhamMoi.MaKhach = MaKhachBox.Text;
                sanPhamMoi.NgayBan = DateTime.Parse(NgayBanBox.Text);
                foreach (DataGridViewRow row in DGVExport.Rows)
                {
                    data += long.Parse(row.Cells[6].Value.ToString());
                }
                sanPhamMoi.TongTien = data;
                setProduceImport.Add(sanPhamMoi);
                renew();
            }
        }
        private void renew()
        {
            using (var database = new TotalData())
            {
                var soHDB = (from u in database.ChiTietHDBs select u).ToList();
                string countnumber = (soHDB.Count() + 1).ToString().PadLeft(6, '0');
                SoHDBBox.Text = "SHDB" + countnumber;
            }
            MaGiayDepBox.Text = "";
            SoLuongBox.Text = "";
            countBox.Text = "";
            NgayBanBox.Text = "";
            MaKhachBox.SelectedItem = null;
            MaKhachBox.SelectedText = "";
            MaNVBox.SelectedItem = null;
            MaNVBox.SelectedText = "";
            DGVExport.Rows.Clear();
            DGVExport.Refresh();
        }

        private void RenewButton_Click(object sender, EventArgs e)
        {
            renew();
        }

        private void renewDetail()
        {
            using (var database = new TotalData())
            {
                var soHDB = (from u in database.ChiTietHDBs select u).ToList();
                string countnumber = (soHDB.Count() + 1).ToString().PadLeft(6, '0');
                SoHDBBox.Text = "SHDB" + countnumber;
            }
            MaGiayDepBox.Text = "";
            SoLuongBox.Text = "";
            countBox.Text = "";
        }
        

        private void SoLuongBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            databaseAccess.CheckDataTextBox(SoHDBBox);
            databaseAccess.CheckDataTextBox(MaGiayDepBox);
            databaseAccess.CheckDataTextBox(SoLuongBox);
            databaseAccess.CheckDataTextBox(countBox);
            DataGridViewRow chiTietHDB = new DataGridViewRow();
            chiTietHDB.CreateCells(DGVExport);
            chiTietHDB.Cells[0].Value = SoHDBBox.Text;
            chiTietHDB.Cells[1].Value = MaGiayDepBox.Text;
            chiTietHDB.Cells[2].Value = int.Parse(SoLuongBox.Text);
            chiTietHDB.Cells[3].Value = long.Parse(countBox.Text);
            using (var database = new TotalData())
            {
                var priceData = (from u in database.SanPhams where u.MaGiayDep.Equals(MaGiayDepBox.Text) select u).ToList();
                chiTietHDB.Cells[4].Value = priceData[0].DonGiaBan * int.Parse(SoLuongBox.Text) - long.Parse(countBox.Text);
            }
            DGVExport.Rows.Add(chiTietHDB);
            renewDetail();
        }
    }
}
