using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using W.F.P.service;

namespace W.F.P
{
    public partial class FormSetting : Form
    {
        ExportExcel exportExcel = new ExportExcel();
        public FormSetting()
        {
            InitializeComponent();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            using (var database = new TotalData())
            {
                var dateTimeAdd = (from u in database.HoaDonNhaps
                                   group u.NgayNhap.Year by u.NgayNhap.Year into data
                                   select data.Key).ToList();
                for (int i = 0; i < dateTimeAdd.Count; i++)
                {
                    yearBox.Items.Add(dateTimeAdd[i]);
                }
            }
        }

        private void ExportExcel_Click(object sender, EventArgs e)
        {
            exportExcel.ExportToExcel(DGVExport);
        }

        private void Top3_Click(object sender, EventArgs e)
        {
            using (var database = new TotalData())
            {
                var query = database.HoaDonNhaps.SqlQuery("EXEC procedure @quy = '" + int.Parse(QuyBox.Text)+"'").ToList<HoaDonNhap>();
                DGVExport.DataSource = query;
            }
        }

        private void Enterbutton_Click(object sender, EventArgs e)
        {
            using (var database = new TotalData())
            {
                var query = database.HoaDonBans.SqlQuery("EXEC Top3_KH @quy = '" + int.Parse(QuyBox.Text) + "'").ToList<HoaDonBan>();
                DGVExport.DataSource = query;
            }
        }
    }
}
