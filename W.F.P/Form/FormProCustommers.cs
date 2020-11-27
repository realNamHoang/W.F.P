using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using W.F.P.service;

namespace W.F.P
{
    public partial class FormProdusterCustommer : Form
    {
        DatabaseAccess databaseAccess = new DatabaseAccess();
        string filedateInsert;
        Form1 mainForm = new Form1();
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

        }

        private void ButtonAddData_Click(object sender, EventArgs e)
        {
            SanPham sanPhamMoi = new SanPham();
            databaseAccess.CheckDataTextBox(MaGiayDepBox);
            sanPhamMoi.MaGiayDep = MaGiayDepBox.Text;
            databaseAccess.CheckDataTextBox(TenGiayDepBox);
            sanPhamMoi.TenGiayDep = TenGiayDepBox.Text;
            databaseAccess.CheckDataComboBox(MaLoaiBox);
            sanPhamMoi.MaLoai = MaLoaiBox.SelectedText;
            databaseAccess.CheckDataComboBox(MaLoaiBox);
            sanPhamMoi.MaCo = MaCoBox.SelectedText;
            databaseAccess.CheckDataComboBox(MaCoBox);
            sanPhamMoi.MaChatLieu = MaChatLieuBox.SelectedText;
            databaseAccess.CheckDataComboBox(MaChatLieuBox);
            sanPhamMoi.MaMau = MaMauBox.SelectedText;
            databaseAccess.CheckDataComboBox(MaMauBox);
            sanPhamMoi.MaDoiTuong = MaDoiTuongBox.SelectedText;
            databaseAccess.CheckDataComboBox(MaDoiTuongBox);
            sanPhamMoi.MaMua = MaMuaBox.SelectedText;
            databaseAccess.CheckDataComboBox(MaMauBox);
            sanPhamMoi.MaNuocSX = MaNuocSXBox.SelectedText;
            databaseAccess.CheckDataComboBox(MaNuocSXBox);
            databaseAccess.CheckDataTextBox(SoLuongBox);
            sanPhamMoi.SoLuong = int.Parse(SoLuongBox.Text);
            sanPhamMoi.Anh = filedateInsert;
            databaseAccess.AddSanPham(sanPhamMoi);
        }

        private void RenewButton_Click(object sender, EventArgs e)
        {
            MaGiayDepBox.Text = "";
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
    }
}
