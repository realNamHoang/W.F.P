using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using W.F.P.service;

namespace W.F.P
{
    public partial class FormProdusterCustommer : Form
    {
        DatabaseAccess databaseAccess = new DatabaseAccess();
        string filedateInsert;
        public FormProdusterCustommer()
        {
            InitializeComponent();
        }

        private void InsertImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image File (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif)";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ImageBox.Image = new Bitmap(openFile.FileName);
                ImageBox.Image = Image.FromFile(openFile.FileName);
                filedateInsert = Path.GetFileName(openFile.FileName);
                //ImageBox.Image.Save(@Application.StartupPath + "\\ImageData\\" + filedateInsert);
                ImageBox.Image.Save(@"D:\\program\\CNTT3_59\\CNTT3_59C#\\W.F.P\\W.F.P\\ImageData\\" + filedateInsert);
            }
        }

        private void FormProdusterCustommer_Load(object sender, EventArgs e)
        {
            using (var database = new TotalData())
            {
                var MaGiayDep = (from u in database.SanPhams select u).ToList();
                string countnumber = (MaGiayDep.Count() + 1).ToString().PadLeft(6, '0');
                MaGiayDepBox.Text = "MaGD" + countnumber;
                var type = (from u in database.TheLoais select u).ToList();
                var size = (from u in database.Coes select u).ToList();
                var metal = (from u in database.ChatLieux select u).ToList();
                var color = (from u in database.Maus select u).ToList();
                var DoiTuong = (from u in database.DoiTuongs select u).ToList();
                var season = (from u in database.Muas select u).ToList();
                var madeBy = (from u in database.NuocSanXuats select u).ToList();
                for (int i = 0; i < type.Count; i++)
                {
                    MaLoaiBox.Items.Add(type[i].TenLoai);
                }
                for (int i = 0; i < size.Count; i++)
                {
                    MaCoBox.Items.Add(size[i].TenCo);
                }
                for (int i = 0; i < metal.Count; i++)
                {
                    MaChatLieuBox.Items.Add(metal[i].TenChatLieu);
                }
                for (int i = 0; i < color.Count; i++)
                {
                    MaMauBox.Items.Add(color[i].TenMau);
                }
                for (int i = 0; i < DoiTuong.Count; i++)
                {
                    MaDoiTuongBox.Items.Add(DoiTuong[i].TenDoiTuong);
                }
                for (int i = 0; i < season.Count; i++)
                {
                    MaMuaBox.Items.Add(season[i].TenMua);
                }
                for (int i = 0; i < madeBy.Count; i++)
                {
                    MaNuocSXBox.Items.Add(madeBy[i].MaNuocSX);
                }
            }
            messageLabel.Hide();
        }

        private void ButtonAddData_Click(object sender, EventArgs e)
        {
            SanPham sanPhamMoi = new SanPham();
            databaseAccess.CheckDataTextBox(MaGiayDepBox);
            sanPhamMoi.MaGiayDep = MaGiayDepBox.Text;
            databaseAccess.CheckDataTextBox(TenGiayDepBox);
            sanPhamMoi.TenGiayDep = TenGiayDepBox.Text;
            databaseAccess.CheckDataComboBox(MaLoaiBox);
            sanPhamMoi.MaLoai = MaLoaiBox.SelectedIndex.ToString();
            databaseAccess.CheckDataComboBox(MaLoaiBox);
            sanPhamMoi.MaCo = MaCoBox.SelectedIndex.ToString();
            databaseAccess.CheckDataComboBox(MaCoBox);
            sanPhamMoi.MaChatLieu = MaChatLieuBox.SelectedIndex.ToString();
            databaseAccess.CheckDataComboBox(MaChatLieuBox);
            sanPhamMoi.MaMau = MaMauBox.SelectedIndex.ToString();
            databaseAccess.CheckDataComboBox(MaMauBox);
            sanPhamMoi.MaDoiTuong = MaDoiTuongBox.SelectedIndex.ToString();
            databaseAccess.CheckDataComboBox(MaDoiTuongBox);
            sanPhamMoi.MaMua = MaMuaBox.SelectedIndex.ToString();
            databaseAccess.CheckDataComboBox(MaMauBox);
            sanPhamMoi.MaNuocSX = MaNuocSXBox.SelectedText;
            databaseAccess.CheckDataComboBox(MaNuocSXBox);
            if (SoLuongBox.Text != null)
            {
                databaseAccess.CheckDataTextBox(SoLuongBox);
            }
            sanPhamMoi.Anh = filedateInsert;
            try
            {
                databaseAccess.AddSanPham(sanPhamMoi);
                messageLabel.Text = "Lưu thành công";
                messageLabel.Show();
                Renew();
            }
            catch
            {
                messageLabel.Text = "Vẫn chưa lưu được";
                messageLabel.Show();
            }
        }

        private void RenewButton_Click(object sender, EventArgs e)
        {
            Renew();
        }

        private void Renew()
        {
            using (var database = new TotalData())
            {
                var MaGiayDep = (from u in database.SanPhams select u).ToList();
                string countnumber = (MaGiayDep.Count() + 1).ToString().PadLeft(6, '0');
                MaGiayDepBox.Text = "MaGD" + countnumber;
            }
            TenGiayDepBox.Text = "";
            MaLoaiBox.SelectedItem = null;
            MaLoaiBox.SelectedText = "";
            MaCoBox.SelectedItem = null;
            MaCoBox.SelectedText = "";
            MaChatLieuBox.SelectedItem = null;
            MaChatLieuBox.SelectedText = "";
            MaMauBox.SelectedItem = null;
            MaMauBox.SelectedText = "";
            MaDoiTuongBox.SelectedItem = null;
            MaDoiTuongBox.SelectedText = "";
            MaMuaBox.SelectedItem = null;
            MaMuaBox.SelectedText = "";
            MaNuocSXBox.SelectedItem = null;
            MaNuocSXBox.SelectedText = "";
            SoLuongBox.Text = "";
            filedateInsert = "";
            ImageBox.Image = null;
        }

        private void SoLuongBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
