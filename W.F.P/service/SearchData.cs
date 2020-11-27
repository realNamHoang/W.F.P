using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W.F.P.service
{
    class SearchData
    {
        public void ControlSearchDataProducts(string Data)
        {
            int blackflag = 0;
            string StrCompare = new string(Data.Take(4).ToArray());
            MaSanPhamSearch(blackflag, StrCompare, Data);
            TenSanPhamSearch(blackflag, Data);
        }

        public void ControlSearchDataExportImport(string dataIO,string DataExportImport)
        {
            int blackflag = 0;
            string DataIOCompare = new string(dataIO.Take(4).ToArray());
            string DataExportImportCompare = new string(DataExportImport.Take(4).ToArray());
            CheckHDN(blackflag, DataIOCompare);
            CheckHDB(blackflag, DataIOCompare);
            MaHangHD(blackflag, DataExportImportCompare, DataExportImport);
            NhanVienHD(blackflag, DataExportImportCompare, DataExportImport);
            KhachHangHDB(blackflag, DataExportImportCompare, DataExportImport);
            NCCHDN(blackflag, DataExportImportCompare, DataExportImport);
        }

        private int MaSanPhamSearch(int blackflag, string StrCompare, string Data)
        {
            if(blackflag == 0 && string.Equals(StrCompare, "MaGD"))
            {
                blackflag = 1;
            }
            return blackflag;
        }

        private void TenSanPhamSearch(int blackflag, string Data)
        {
            if (blackflag == 0)
            {
                
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

        private int MaHangHD(int blackflag, string  DataExportImportCompare, string DataExportImport) 
        {
            if(blackflag != 3 && string.Equals(DataExportImportCompare, "MaGD"))
            {
                blackflag = 3;
                if(blackflag == 0)
                {

                }
                if (blackflag == 1)
                {

                }
                if(blackflag == 2)
                {

                }
            }
            return blackflag;
        }

        private int NhanVienHD(int blackflag, string DataExportImportCompare, string DataExportImport)
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

        private int KhachHangHDB(int blackflag, string DataExportImportCompare, string DataExportImport)
        {
            if(blackflag !=3 && blackflag == 2 && string.Equals(DataExportImportCompare, "MaKH"))
            {
                blackflag = 3;
            }
            return blackflag;
        }

        private int NCCHDN(int blackflag, string DataExportImportCompare, string DataExportImport)
        {
            if(blackflag !=3 && blackflag == 1 && string.Equals(DataExportImportCompare, "MNCC"))
            {
                blackflag = 3;
            }
            return blackflag;
        }
    }
}
