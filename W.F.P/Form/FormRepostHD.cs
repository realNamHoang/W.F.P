using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W.F.P.service;

namespace W.F.P
{
    public partial class FormRepostHD : Form
    {
        SearchData searchData = new SearchData();
        ExportExcel exportExcel = new ExportExcel();
        public FormRepostHD()
        {
            InitializeComponent();
        }

        private void FormRepostHD_Load(object sender, EventArgs e)
        {
            ExtraDataView.Hide();
            ExportExcel.Hide();
            exportExcel.defaultHDNX(DGVExport);
        }

        private void DataSearchRequestBox_Enter(object sender, EventArgs e)
        {
            //searchData.ControlSearchDataExportImport(DataSearchHDBox.Text, DataSearchRequestBox.Text, DGVExport, ExtraDataView);
        }

        private void FormRepostHD_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                searchData.ControlSearchDataExportImport(DataSearchHDBox.Text, DataSearchRequestBox.Text, DGVExport, ExtraDataView, ExportExcel);
            }

        }
    }
}
