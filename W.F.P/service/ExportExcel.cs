using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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

        private void copyAlltoClipboard(DataGridView view)
        {
            view.SelectAll();
            if (view.Rows.Count == 0)
            {
                MessageBox.Show("Error", "Không có dữ liệu");
            }
            else
            {
                DataObject dataObj = view.GetClipboardContent();
                if (dataObj != null)
                {
                    Clipboard.SetDataObject(dataObj);
                }
            }
        }

        public void ExportToExcel(DataGridView view)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel Documents (*.xls)|*.xls";
            saveFile.FileName = "Inventory_Adjustment_Export.xls";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                copyAlltoClipboard(view);

                object misValue = System.Reflection.Missing.Value;
                Excel.Application xlexcel = new Excel.Application();

                xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Format column D as text before pasting results, this was required for my data
                Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
                rng.NumberFormat = "@";

                // Paste clipboard results to worksheet range
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                // For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
                // Delete blank column A and select cell A1
                Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();

                // Save the excel file under the captured location from the SaveFileDialog
                xlWorkBook.SaveAs(saveFile.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                view.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(saveFile.FileName))
                    System.Diagnostics.Process.Start(saveFile.FileName);
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
