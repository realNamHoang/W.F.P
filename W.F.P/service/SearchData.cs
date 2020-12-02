using System.Linq;
using System.Windows.Forms;

namespace W.F.P.service
{
    class SearchData
    {
        public void ControlSearchDataProducts(string Data, DataGridView view, Button excel)
        {
            int blackflag = 0;
            string StrCompare = new string(Data.Take(4).ToArray());
            MaSanPhamSearch(blackflag, StrCompare, Data, view, excel);
            TenSanPhamSearch(blackflag, Data, view, excel);
        }

        public void ControlSearchDataExportImport(string dataIO, string DataExportImport, DataGridView view, DataGridView extraView, Button excel)
        {
            int blackflag = 0;
            string DataIOCompare = new string(dataIO.Take(4).ToArray());
            string DataExportImportCompare = new string(DataExportImport.Take(4).ToArray());
            CheckHDN(blackflag, DataIOCompare);
            CheckHDB(blackflag, DataIOCompare);
            MaHangHD(blackflag, DataExportImportCompare, dataIO, DataExportImport, view, extraView, excel);
            NhanVienHD(blackflag, DataExportImportCompare, dataIO, DataExportImport, view, extraView, excel);
            KhachHangHDB(blackflag, DataExportImportCompare, DataExportImport, view, excel);
            NCCHDN(blackflag, DataExportImportCompare, DataExportImport, view, excel);
        }

        private int MaSanPhamSearch(int blackflag, string StrCompare, string Data, DataGridView view, Button excel)
        {
            if (blackflag == 0 && string.Equals(StrCompare, "MaGD"))
            {
                excel.Show();
                blackflag = 1;
                using (var database = new TotalData())
                {
                    //var query = database.SanPhams.SqlQuery("Select u from SanPham u where u.MaGiayDep like concat('%'" + Data + "'%')'").ToList<SanPham>();
                    var querydata = from u in database.SanPhams where u.MaGiayDep.Contains(Data) select u;
                    view.DataSource = querydata.ToList<SanPham>();
                }
            }
            return blackflag;
        }

        private void TenSanPhamSearch(int blackflag, string Data, DataGridView view, Button excel)
        {
            if (blackflag == 0)
            {
                using (var database = new TotalData())
                {
                    excel.Show();
                    //var query = database.SanPhams.SqlQuery("Select u from SanPham u where u.TenGiayDep like concat('%" + Data + "')").ToList<SanPham>();
                    var querydata = (from u in database.SanPhams where u.TenGiayDep.Contains(Data) select u).ToList<SanPham>();
                    view.DataSource = querydata;
                }
            }
        }

        private int CheckHDN(int blackflag, string DataIOCompare)
        {
            if (blackflag == 0 && string.Equals(DataIOCompare, "SHDN"))
            {
                blackflag = 1;
            }
            return blackflag;
        }

        private int CheckHDB(int blackflag, string DataIOCompare)
        {
            if (blackflag == 0 && string.Equals(DataIOCompare, "SHDB"))
            {
                blackflag = 2;
            }
            return blackflag;
        }

        private int MaHangHD(int blackflag, string DataExportImportCompare, string dataIO, string DataExportImport, DataGridView view, DataGridView extraView, Button excel)
        {
            if (blackflag != 3 && string.Equals(DataExportImportCompare, "MaGD"))
            {
                excel.Show();
                extraView.Hide();
                blackflag = 3;
                using (var database = new TotalData())
                {
                    if (blackflag == 0)
                    {
                        extraView.Show();
                        var queryData = (from u in database.ChiTietHDBs
                                         join HDB in database.HoaDonBans on u.SoHDB equals HDB.SoHDB
                                         where u.MaGiayDep == DataExportImport
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
                        view.DataSource = queryData;
                        var extraData = (from u in database.ChiTietHDNs
                                         join HDN in database.HoaDonNhaps on u.SoHDN equals HDN.SoHDN
                                         where u.MaGiayDep == DataExportImport
                                         select new
                                         {
                                             SoHDN = u.SoHDN,
                                             MaNV = HDN.MaNV,
                                             MaGiayDep = u.MaGiayDep,
                                             SoLuong = u.SoLuong,
                                             GiamGia = u.GiamGia,
                                             ThanhTien = u.ThanhTien,
                                             MaNCC = HDN.MaNCC,
                                             NgayNhap = HDN.NgayNhap,
                                             TongTien = HDN.TongTien
                                         }).ToList();
                        extraView.DataSource = extraData;
                    }
                    if (blackflag == 1)
                    {
                        var queryData = (from u in database.ChiTietHDBs
                                         join HDB in database.HoaDonBans on u.SoHDB equals HDB.SoHDB
                                         where u.MaGiayDep == DataExportImport
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
                        view.DataSource = queryData;
                    }
                    if (blackflag == 2)
                    {
                        var extraData = (from u in database.ChiTietHDNs
                                         join HDN in database.HoaDonNhaps on u.SoHDN equals HDN.SoHDN
                                         where u.MaGiayDep == DataExportImport
                                         select new
                                         {
                                             SoHDN = u.SoHDN,
                                             MaNV = HDN.MaNV,
                                             MaGiayDep = u.MaGiayDep,
                                             SoLuong = u.SoLuong,
                                             GiamGia = u.GiamGia,
                                             ThanhTien = u.ThanhTien,
                                             MaNCC = HDN.MaNCC,
                                             NgayNhap = HDN.NgayNhap,
                                             TongTien = HDN.TongTien
                                         }).ToList();
                        view.DataSource = extraData;
                    }
                }
            }
            return blackflag;
        }

        private int NhanVienHD(int blackflag, string DataExportImportCompare, string dataIO, string DataExportImport, DataGridView view, DataGridView extraview, Button excel)
        {
            if (blackflag != 3 && string.Equals(DataExportImportCompare, "MaNV"))
            {
                excel.Show();
                extraview.Hide();
                blackflag = 3;
                using (var database = new TotalData())
                {
                    if (blackflag == 0)
                    {
                        extraview.Show();
                        var queryData = (from u in database.HoaDonBans
                                         where u.MaNV == DataExportImport
                                         select u).ToList<HoaDonBan>();
                        view.DataSource = queryData;
                        var extraData = (from u in database.HoaDonNhaps
                                         where u.MaNV == DataExportImport
                                         select u).ToList<HoaDonNhap>();
                        extraview.DataSource = extraData;
                    }
                    if (blackflag == 1)
                    {
                        var queryData = from u in database.HoaDonBans
                                        where u.MaNV == DataExportImport
                                        select u;
                        view.DataSource = queryData.ToList<HoaDonBan>();
                    }
                    if (blackflag == 2)
                    {
                        var extraData = from u in database.HoaDonNhaps
                                        where u.MaNV == DataExportImport
                                        select u;
                        view.DataSource = extraData.ToList<HoaDonNhap>();
                    }
                }
            }
            return blackflag;
        }

        private int KhachHangHDB(int blackflag, string DataExportImportCompare, string DataExportImport, DataGridView view, Button excel)
        {
            if (blackflag != 3 && string.Equals(DataExportImportCompare, "MaKH"))
            {
                excel.Show();
                blackflag = 3;
                using (var database = new TotalData())
                {
                    var extraData = from u in database.HoaDonBans
                                    where u.MaKhach == DataExportImport
                                    select u;
                    view.DataSource = extraData.ToList<HoaDonBan>();
                }
            }
            return blackflag;
        }

        private int NCCHDN(int blackflag, string DataExportImportCompare, string DataExportImport, DataGridView view, Button excel)
        {
            if (blackflag != 3 && string.Equals(DataExportImportCompare, "MNCC"))
            {
                excel.Show();
                blackflag = 3;
                using (var database = new TotalData())
                {
                    var Data = from u in database.HoaDonNhaps
                               where u.MaNCC == DataExportImport
                               select u;
                    view.DataSource = Data.ToList<HoaDonNhap>();
                }
            }
            return blackflag;
        }

        public void TonKho(DataGridView view, Button excel)
        {
            excel.Show();
            using (var database = new TotalData())
            {
                var Data = from u in database.SanPhams
                           where u.SoLuong > 0
                           select u;
                view.DataSource = Data.ToList<SanPham>();
            }
        }
    }
}
