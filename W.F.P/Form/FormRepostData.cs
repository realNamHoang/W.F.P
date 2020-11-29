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
    public partial class FormRepostData : Form
    {
        SearchData searchData = new SearchData();
        public FormRepostData()
        {
            InitializeComponent();
        }

        private void DataSearchBox_Enter(object sender, EventArgs e)
        {
            searchData.ControlSearchDataProducts(DataSearchBox.Text, DGVExport);
        }
    }
}
