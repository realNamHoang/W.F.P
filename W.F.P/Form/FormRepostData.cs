using System;
using System.Windows.Forms;
using W.F.P.service;

namespace W.F.P
{
    public partial class FormRepostData : Form
    {
        SearchData searchData = new SearchData();
        ExportExcel exportExcel = new ExportExcel();
        public FormRepostData()
        {
            InitializeComponent();
        }

        private void DataSearchBox_Enter(object sender, EventArgs e)
        {
            //searchData.ControlSearchDataProducts(DataSearchBox.Text, DGVExport);
        }

        private void FormRepostData_Load(object sender, EventArgs e)
        {
            exportExcel.DefaultMH(DGVExport);
            ExportExcel.Hide();
        }

        private void DataSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                searchData.ControlSearchDataProducts(DataSearchBox.Text, DGVExport, ExportExcel);
            }
        }

        private void XemTonKho_Click(object sender, EventArgs e)
        {
            searchData.TonKho(DGVExport, ExportExcel);
        }

        private void ExportExcel_Click(object sender, EventArgs e)
        {
            exportExcel.ExportToExcel(DGVExport);
        }
    }
}
