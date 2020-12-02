using System.Windows.Forms;

namespace W.F.P.service
{
    class DatabaseAccess
    {
        public void AddSanPham(SanPham sanPham)
        {
            using (var database = new TotalData())
            {
                var setSanPham = database.Set<SanPham>();
                setSanPham.Add(sanPham);
            }
        }

        public void CheckDataTextBox(TextBox textBox)
        {
            if (textBox.TextLength == 0)
            {
                MessageBox.Show("You forgot not insert this" + textBox.Name + "?", "Error Detected in Input", MessageBoxButtons.YesNo);
                textBox.Focus();
            }
        }

        public void CheckDataComboBox(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == 0)
            {
                MessageBox.Show("You forgot not insert this" + comboBox.Name + "?", "Error Detected in Input", MessageBoxButtons.YesNo);
                comboBox.Focus();
            }
        }
    }
}
