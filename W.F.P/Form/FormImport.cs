using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using W.F.P.service;

namespace W.F.P
{
    public partial class FormImport : Form
    {
        DatabaseAccess databaseAccess = new DatabaseAccess();
        public FormImport()
        {
            InitializeComponent();
        }

        private void FormProdusterCustommer_Load(object sender, EventArgs e)
        {
            using (var database = new TotalData())
            {
                var soHDN = (from u in database.ChiTietHDNs select u).ToList();
                string countnumber = (soHDN.Count() + 1).ToString().PadLeft(6, '0');
                SoHDNBox.Text = "SHDN" + countnumber;
                var NhanVien = (from u in database.NhanViens select u).ToList();
                var MaCungCap = (from u in database.NhaCungCaps select u).ToList();
                for (int i = 0; i < NhanVien.Count; i++)
                {
                    MaNVBox.Items.Add(NhanVien[i].MaNhanVien);
                }
                for (int i = 0; i < MaCungCap.Count; i++)
                {
                    MaNCCBox.Items.Add(MaCungCap[i].MaNCC);
                }
            }
        }

        private void ButtonAddData_Click(object sender, EventArgs e)
        {
            long data = 0;
            using (var database = new TotalData())
            {
                var setDetailProduceImport = database.Set<ChiTietHDN>();
                var setProduceImport = database.Set<HoaDonNhap>();
                foreach (DataGridViewRow row in DGVImport.Rows)
                {
                    ChiTietHDN chiTietHDN = new ChiTietHDN();
                    chiTietHDN.SoHDN = row.Cells[0].Value.ToString();
                    chiTietHDN.MaGiayDep = row.Cells[1].Value.ToString();
                    chiTietHDN.SoLuong = int.Parse(row.Cells[2].Value.ToString());
                    chiTietHDN.DonGia = long.Parse(row.Cells[3].Value.ToString());
                    chiTietHDN.GiamGia = long.Parse(row.Cells[4].Value.ToString());
                    chiTietHDN.ThanhTien = long.Parse(row.Cells[5].Value.ToString());
                    setDetailProduceImport.Add(chiTietHDN);
                    data += long.Parse(row.Cells[5].Value.ToString());
                }
                HoaDonNhap sanPhamMoi = new HoaDonNhap();
                databaseAccess.CheckDataTextBox(SoHDNBox);
                sanPhamMoi.SoHDN = SoHDNBox.Text;
                databaseAccess.CheckDataTextBox(MaGiayDepBox);
                sanPhamMoi.MaNV = MaGiayDepBox.Text;
                databaseAccess.CheckDataTextBox(SoLuongBox);
                sanPhamMoi.MaNCC = MaNCCBox.Text;
                sanPhamMoi.NgayNhap = DateTime.Parse(NgayNhapBox.Text);
                foreach (DataGridViewRow row in DGVImport.Rows)
                {
                    data += long.Parse(row.Cells[6].Value.ToString());
                }
                sanPhamMoi.TongTien = data;
                setProduceImport.Add(sanPhamMoi);
                renew();
            }
        }

        private void RenewButton_Click(object sender, EventArgs e)
        {
            renew();
        }

        private void renew()
        {
            using (var database = new TotalData())
            {
                var soHDN = (from u in database.ChiTietHDNs select u).ToList();
                string countnumber = (soHDN.Count() + 1).ToString().PadLeft(6, '0');
                SoHDNBox.Text = "SHDN" + countnumber;
            }
            MaGiayDepBox.Text = "";
            SoLuongBox.Text = "";
            priceBox.Text = "";
            countBox.Text = "";
            NgayNhapBox.Text = "";
            MaNCCBox.SelectedItem = null;
            MaNCCBox.SelectedText = "";
            MaNVBox.SelectedItem = null;
            MaNVBox.SelectedText = "";
            DGVImport.Rows.Clear();
            DGVImport.Refresh();
        }

        private void renewDetail()
        {
            using (var database = new TotalData())
            {
                var soHDN = (from u in database.ChiTietHDNs select u).ToList();
                string countnumber = (soHDN.Count() + 1).ToString().PadLeft(6, '0');
                SoHDNBox.Text = "SHDN" + countnumber;
            }
            MaGiayDepBox.Text = "";
            SoLuongBox.Text = "";
            priceBox.Text = "";
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

        private void addToDGView_Click(object sender, EventArgs e)
        {
            databaseAccess.CheckDataTextBox(SoHDNBox);
            databaseAccess.CheckDataTextBox(MaGiayDepBox);
            databaseAccess.CheckDataTextBox(SoLuongBox);
            databaseAccess.CheckDataTextBox(priceBox);
            databaseAccess.CheckDataTextBox(countBox);
            DataGridViewRow chiTietHDN = new DataGridViewRow();
            chiTietHDN.CreateCells(DGVImport);
            chiTietHDN.Cells[0].Value = SoHDNBox.Text;
            chiTietHDN.Cells[1].Value = MaGiayDepBox.Text;
            chiTietHDN.Cells[2].Value = int.Parse(SoLuongBox.Text);
            chiTietHDN.Cells[3].Value = long.Parse(priceBox.Text);
            chiTietHDN.Cells[4].Value = long.Parse(countBox.Text);
            chiTietHDN.Cells[5].Value = long.Parse(priceBox.Text) * int.Parse(SoLuongBox.Text) - long.Parse(countBox.Text);
            DGVImport.Rows.Add(chiTietHDN);
            renewDetail();
        }
    }
}
