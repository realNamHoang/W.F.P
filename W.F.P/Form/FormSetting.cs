using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W.F.P
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            using(var database = new TotalData())
            {
                var dateTimeAdd = (from u in database.HoaDonNhaps group u.NgayNhap.Year by u.NgayNhap.Year into data 
                                  select data.Key).ToList();
                for (int i = 0; i < dateTimeAdd.Count; i++)
                {
                    yearBox.Items.Add(dateTimeAdd[i]);
                }
            }
        }
    }
}
