using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W.F.P.service
{
    class ExportExcel
    {
        public void DefaultMH(DataGridView view)
        {
            using (var database = new TotalData())
            {
                //var data = (from u in database.SanPhams select u).ToList();
                var data = database.SanPhams.SqlQuery("Select * from SanPham").ToList<SanPham>();
                view.DataSource = data;
            }
        }

        public void defaultHDNX(DataGridView view)
        {
            using (var database = new TotalData())
            {
                var data = (from u in database.ChiTietHDBs
                           join HDB in database.HoaDonBans on u.SoHDB equals HDB.SoHDB
                           select new
                           {
                               SoHDB = u.SoHDB,
                               MaNV = HDB.MaNV,
                               MaGiayDep = u.MaGiayDep,
                               SoLuong = u.SoLuong,
                               GiamGia = u.GiamGia,
                               ThanhTien = u.ThanhTien,
                               NgayBan = HDB.NgayBan,
                               MaKH = HDB.MaKhach,
                               TongTien = HDB.TongTien
                           }).ToList();
                view.DataSource = data;
            }
        }
    }
}
