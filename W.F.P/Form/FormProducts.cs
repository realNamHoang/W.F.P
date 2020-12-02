using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace W.F.P
{
    public partial class FormCustommers : Form
    {
        public FormCustommers()
        {
            InitializeComponent();
        }

        private void FormCustommers_Load(object sender, System.EventArgs e)
        {
            using (var database = new TotalData())
            {
                var sanpham = (from u in database.SanPhams select u).ToList();
                if (sanpham.Count > 0)
                {
                    //1
                    pictureBox1.Image = Image.FromFile(@"D:\\program\\CNTT3_59\\CNTT3_59C#\\W.F.P\\W.F.P\\ImageData\\" + sanpham[0].Anh);
                    SanPham1.Text = sanpham[0].TenGiayDep;
                    label1.Text = sanpham[0].DonGiaBan.ToString();
                    //2
                    pictureBox2.Image = Image.FromFile(@"D:\\program\\CNTT3_59\\CNTT3_59C#\\W.F.P\\W.F.P\\ImageData\\" + sanpham[1].Anh);
                    SanPham2.Text = sanpham[1].TenGiayDep;
                    label2.Text = sanpham[1].DonGiaBan.ToString();
                    // 3
                    pictureBox3.Image = Image.FromFile(@"D:\\program\\CNTT3_59\\CNTT3_59C#\\W.F.P\\W.F.P\\ImageData\\" + sanpham[2].Anh);
                    SanPham3.Text = sanpham[2].TenGiayDep;
                    label3.Text = sanpham[2].DonGiaBan.ToString();
                    //4
                    pictureBox4.Image = Image.FromFile(@"D:\\program\\CNTT3_59\\CNTT3_59C#\\W.F.P\\W.F.P\\ImageData\\" + sanpham[3].Anh);
                    SanPham4.Text = sanpham[3].TenGiayDep;
                    label4.Text = sanpham[3].DonGiaBan.ToString();
                }
            }
        }
    }
}
