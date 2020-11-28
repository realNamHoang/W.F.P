using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.SqlClient;
using System.Windows.Forms;

namespace W.F.P.service
{
    class SearchData
    {
        public void ControlSearchDataProducts(string Data, DataGridView view)
        {
            int blackflag = 0;
            string StrCompare = new string(Data.Take(4).ToArray());
            MaSanPhamSearch(blackflag, StrCompare, Data, view);
            TenSanPhamSearch(blackflag, Data, view);
        }

        public void ControlSearchDataExportImport(string dataIO,string DataExportImport,DataGridView view)
        {
            int blackflag = 0;
            string DataIOCompare = new string(dataIO.Take(4).ToArray());
            string DataExportImportCompare = new string(DataExportImport.Take(4).ToArray());
            CheckHDN(blackflag, DataIOCompare);
            CheckHDB(blackflag, DataIOCompare);
            MaHangHD(blackflag, DataExportImportCompare,dataIO, DataExportImport,view);
            NhanVienHD(blackflag, DataExportImportCompare, dataIO, DataExportImport,view);
            KhachHangHDB(blackflag, DataExportImportCompare, DataExportImport,view);
            NCCHDN(blackflag, DataExportImportCompare, DataExportImport,view);
        }

        private int MaSanPhamSearch(int blackflag, string StrCompare, string Data, DataGridView view)
        {
            if(blackflag == 0 && string.Equals(StrCompare, "MaGD"))
            {
                blackflag = 1;
                using (var database =  new TotalData())
                {
                    var query = database.SanPhams.SqlQuery("Select u from SanPham u where u.MaGiayDep like concat('%" + Data + "')").ToList<SanPham>();
                    var querydata = from u in database.SanPhams where SqlMethods.Like(u.MaGiayDep, "%" + Data + "%") select u;
                    view.DataSource = querydata;
                }
            }
            return blackflag;
        }

        private void TenSanPhamSearch(int blackflag, string Data , DataGridView view)
        {
            if (blackflag == 0)
            {
                using (var database = new TotalData())
                {
                    var query = database.SanPhams.SqlQuery("Select u from SanPham u where u.TenGiayDep like concat('%" + Data + "')").ToList<SanPham>();
                    view.DataSource = query;
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

        private int MaHangHD(int blackflag, string  DataExportImportCompare,string dataIO, string DataExportImport, DataGridView view) 
        {
            if(blackflag != 3 && string.Equals(DataExportImportCompare, "MaGD"))
            {
                blackflag = 3;
                using (var database = new TotalData())
                {
                    if (blackflag == 0)
                    {
                        var queryData = from u in database.HoaDonBans where u.SoHDB == DataExportImport join
                    }
                    if (blackflag == 1)
                    {

                    }
                    if (blackflag == 2)
                    {

                    }
                }
            }
            return blackflag;
        }

        private int NhanVienHD(int blackflag, string DataExportImportCompare,string dataIO, string DataExportImport, DataGridView view)
        {
            if(blackflag != 3 && string.Equals(DataExportImportCompare, "MaNV"))
            {
                blackflag = 3;
                if (blackflag == 0)
                {

                }
                if (blackflag == 1)
                {
                    
                }
                if (blackflag == 2)
                {

                }
            }
            return blackflag;
        }

        private int KhachHangHDB(int blackflag, string DataExportImportCompare, string DataExportImport, DataGridView view)
        {
            if(blackflag !=3 && string.Equals(DataExportImportCompare, "MaKH"))
            {
                blackflag = 3;
            }
            return blackflag;
        }

        private int NCCHDN(int blackflag, string DataExportImportCompare, string DataExportImport, DataGridView view)
        {
            if(blackflag !=3 && string.Equals(DataExportImportCompare, "MNCC"))
            {
                blackflag = 3;
            }
            return blackflag;
        }
    }
}
