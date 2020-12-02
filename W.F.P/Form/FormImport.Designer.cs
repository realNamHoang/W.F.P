namespace W.F.P
{
    partial class FormImport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SoHDN = new System.Windows.Forms.Label();
            this.SoHDNBox = new System.Windows.Forms.TextBox();
            this.nameProduct = new System.Windows.Forms.Label();
            this.MaGiayDepBox = new System.Windows.Forms.TextBox();
            this.SoLuong = new System.Windows.Forms.Label();
            this.SoLuongBox = new System.Windows.Forms.TextBox();
            this.ButtonAddData = new FontAwesome.Sharp.IconButton();
            this.RenewButton = new FontAwesome.Sharp.IconButton();
            this.MaNV = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.countBox = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.Label();
            this.DGVImport = new System.Windows.Forms.DataGridView();
            this.NgayNhapBox = new System.Windows.Forms.TextBox();
            this.MaNCC = new System.Windows.Forms.Label();
            this.NgayNhap = new System.Windows.Forms.Label();
            this.addToDGView = new FontAwesome.Sharp.IconButton();
            this.MaNVBox = new System.Windows.Forms.ComboBox();
            this.MaNCCBox = new System.Windows.Forms.ComboBox();
            this.SHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGiayDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVImport)).BeginInit();
            this.SuspendLayout();
            // 
            // SoHDN
            // 
            this.SoHDN.AutoSize = true;
            this.SoHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoHDN.ForeColor = System.Drawing.Color.Gainsboro;
            this.SoHDN.Location = new System.Drawing.Point(159, 24);
            this.SoHDN.Name = "SoHDN";
            this.SoHDN.Size = new System.Drawing.Size(117, 16);
            this.SoHDN.TabIndex = 1;
            this.SoHDN.Text = "Số Hóa Đơn Nhập";
            // 
            // SoHDNBox
            // 
            this.SoHDNBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoHDNBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoHDNBox.Location = new System.Drawing.Point(277, 21);
            this.SoHDNBox.Margin = new System.Windows.Forms.Padding(5);
            this.SoHDNBox.Name = "SoHDNBox";
            this.SoHDNBox.Size = new System.Drawing.Size(149, 22);
            this.SoHDNBox.TabIndex = 2;
            // 
            // nameProduct
            // 
            this.nameProduct.AutoSize = true;
            this.nameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.nameProduct.Location = new System.Drawing.Point(159, 64);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(92, 16);
            this.nameProduct.TabIndex = 1;
            this.nameProduct.Text = "Mã Sản Phẩm";
            // 
            // MaGiayDepBox
            // 
            this.MaGiayDepBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaGiayDepBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaGiayDepBox.Location = new System.Drawing.Point(277, 64);
            this.MaGiayDepBox.Name = "MaGiayDepBox";
            this.MaGiayDepBox.Size = new System.Drawing.Size(149, 22);
            this.MaGiayDepBox.TabIndex = 2;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSize = true;
            this.SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuong.ForeColor = System.Drawing.Color.Gainsboro;
            this.SoLuong.Location = new System.Drawing.Point(550, 24);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(65, 16);
            this.SoLuong.TabIndex = 6;
            this.SoLuong.Text = "Số Lượng";
            // 
            // SoLuongBox
            // 
            this.SoLuongBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoLuongBox.Location = new System.Drawing.Point(643, 24);
            this.SoLuongBox.Name = "SoLuongBox";
            this.SoLuongBox.Size = new System.Drawing.Size(149, 20);
            this.SoLuongBox.TabIndex = 2;
            this.SoLuongBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoLuongBox_KeyPress);
            // 
            // ButtonAddData
            // 
            this.ButtonAddData.FlatAppearance.BorderSize = 0;
            this.ButtonAddData.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonAddData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddData.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonAddData.IconColor = System.Drawing.Color.Black;
            this.ButtonAddData.IconSize = 16;
            this.ButtonAddData.Location = new System.Drawing.Point(37, 396);
            this.ButtonAddData.Name = "ButtonAddData";
            this.ButtonAddData.Rotation = 0D;
            this.ButtonAddData.Size = new System.Drawing.Size(147, 55);
            this.ButtonAddData.TabIndex = 7;
            this.ButtonAddData.Text = "Thêm Hóa Đơn Nhập";
            this.ButtonAddData.UseVisualStyleBackColor = true;
            this.ButtonAddData.Click += new System.EventHandler(this.ButtonAddData_Click);
            // 
            // RenewButton
            // 
            this.RenewButton.FlatAppearance.BorderSize = 0;
            this.RenewButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.RenewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenewButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.RenewButton.IconColor = System.Drawing.Color.Black;
            this.RenewButton.IconSize = 16;
            this.RenewButton.Location = new System.Drawing.Point(717, 396);
            this.RenewButton.Name = "RenewButton";
            this.RenewButton.Rotation = 0D;
            this.RenewButton.Size = new System.Drawing.Size(147, 55);
            this.RenewButton.TabIndex = 7;
            this.RenewButton.Text = "Làm lại";
            this.RenewButton.UseVisualStyleBackColor = true;
            this.RenewButton.Click += new System.EventHandler(this.RenewButton_Click);
            // 
            // MaNV
            // 
            this.MaNV.AutoSize = true;
            this.MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNV.ForeColor = System.Drawing.Color.Gainsboro;
            this.MaNV.Location = new System.Drawing.Point(159, 107);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(90, 16);
            this.MaNV.TabIndex = 1;
            this.MaNV.Text = "Mã Nhân viên";
            // 
            // priceBox
            // 
            this.priceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceBox.Location = new System.Drawing.Point(643, 64);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(149, 20);
            this.priceBox.TabIndex = 2;
            this.priceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoLuongBox_KeyPress);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Gainsboro;
            this.price.Location = new System.Drawing.Point(550, 64);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(54, 16);
            this.price.TabIndex = 6;
            this.price.Text = "Đơn giá";
            // 
            // countBox
            // 
            this.countBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countBox.Location = new System.Drawing.Point(643, 107);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(149, 22);
            this.countBox.TabIndex = 2;
            this.countBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoLuongBox_KeyPress);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.ForeColor = System.Drawing.Color.Gainsboro;
            this.count.Location = new System.Drawing.Point(550, 107);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(62, 16);
            this.count.TabIndex = 6;
            this.count.Text = "Giảm giá";
            // 
            // DGVImport
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVImport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVImport.BackgroundColor = System.Drawing.Color.White;
            this.DGVImport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVImport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVImport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVImport.ColumnHeadersHeight = 48;
            this.DGVImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SHDN,
            this.MaGiayDep,
            this.SoLuongView,
            this.DonGia,
            this.GiamGia,
            this.ThanhTien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVImport.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVImport.EnableHeadersVisualStyles = false;
            this.DGVImport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVImport.Location = new System.Drawing.Point(0, 201);
            this.DGVImport.Name = "DGVImport";
            this.DGVImport.RowHeadersVisible = false;
            this.DGVImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVImport.Size = new System.Drawing.Size(964, 189);
            this.DGVImport.TabIndex = 8;
            // 
            // NgayNhapBox
            // 
            this.NgayNhapBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NgayNhapBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayNhapBox.Location = new System.Drawing.Point(643, 150);
            this.NgayNhapBox.Name = "NgayNhapBox";
            this.NgayNhapBox.Size = new System.Drawing.Size(149, 22);
            this.NgayNhapBox.TabIndex = 2;
            // 
            // MaNCC
            // 
            this.MaNCC.AutoSize = true;
            this.MaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNCC.ForeColor = System.Drawing.Color.Gainsboro;
            this.MaNCC.Location = new System.Drawing.Point(159, 150);
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Size = new System.Drawing.Size(113, 16);
            this.MaNCC.TabIndex = 1;
            this.MaNCC.Text = "Mã Nhà cung cấp";
            // 
            // NgayNhap
            // 
            this.NgayNhap.AutoSize = true;
            this.NgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayNhap.ForeColor = System.Drawing.Color.Gainsboro;
            this.NgayNhap.Location = new System.Drawing.Point(550, 150);
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Size = new System.Drawing.Size(74, 16);
            this.NgayNhap.TabIndex = 6;
            this.NgayNhap.Text = "Ngày nhập";
            // 
            // addToDGView
            // 
            this.addToDGView.FlatAppearance.BorderSize = 0;
            this.addToDGView.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.addToDGView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToDGView.IconChar = FontAwesome.Sharp.IconChar.None;
            this.addToDGView.IconColor = System.Drawing.Color.Black;
            this.addToDGView.IconSize = 16;
            this.addToDGView.Location = new System.Drawing.Point(819, 127);
            this.addToDGView.Name = "addToDGView";
            this.addToDGView.Rotation = 0D;
            this.addToDGView.Size = new System.Drawing.Size(113, 45);
            this.addToDGView.TabIndex = 7;
            this.addToDGView.Text = "Thêm dữ liệu vào bảng ghi";
            this.addToDGView.UseVisualStyleBackColor = true;
            this.addToDGView.Click += new System.EventHandler(this.addToDGView_Click);
            // 
            // MaNVBox
            // 
            this.MaNVBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNVBox.FormattingEnabled = true;
            this.MaNVBox.Location = new System.Drawing.Point(277, 104);
            this.MaNVBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.MaNVBox.Name = "MaNVBox";
            this.MaNVBox.Size = new System.Drawing.Size(149, 23);
            this.MaNVBox.TabIndex = 9;
            // 
            // MaNCCBox
            // 
            this.MaNCCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNCCBox.FormattingEnabled = true;
            this.MaNCCBox.ItemHeight = 15;
            this.MaNCCBox.Location = new System.Drawing.Point(277, 147);
            this.MaNCCBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.MaNCCBox.Name = "MaNCCBox";
            this.MaNCCBox.Size = new System.Drawing.Size(149, 23);
            this.MaNCCBox.TabIndex = 9;
            // 
            // SHDN
            // 
            this.SHDN.HeaderText = "SHDN";
            this.SHDN.Name = "SHDN";
            // 
            // MaGiayDep
            // 
            this.MaGiayDep.HeaderText = "MaGiayDep";
            this.MaGiayDep.Name = "MaGiayDep";
            // 
            // SoLuongView
            // 
            this.SoLuongView.HeaderText = "SoLuong";
            this.SoLuongView.Name = "SoLuongView";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "DonGia";
            this.DonGia.Name = "DonGia";
            // 
            // GiamGia
            // 
            this.GiamGia.HeaderText = "GiamGia";
            this.GiamGia.Name = "GiamGia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(964, 477);
            this.Controls.Add(this.MaNCCBox);
            this.Controls.Add(this.MaNVBox);
            this.Controls.Add(this.DGVImport);
            this.Controls.Add(this.RenewButton);
            this.Controls.Add(this.addToDGView);
            this.Controls.Add(this.ButtonAddData);
            this.Controls.Add(this.NgayNhap);
            this.Controls.Add(this.count);
            this.Controls.Add(this.price);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.MaNCC);
            this.Controls.Add(this.MaNV);
            this.Controls.Add(this.MaGiayDepBox);
            this.Controls.Add(this.NgayNhapBox);
            this.Controls.Add(this.nameProduct);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.SoLuongBox);
            this.Controls.Add(this.SoHDNBox);
            this.Controls.Add(this.SoHDN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormImport";
            this.Text = "FormProduster";
            this.Load += new System.EventHandler(this.FormProdusterCustommer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SoHDN;
        private System.Windows.Forms.TextBox SoHDNBox;
        private System.Windows.Forms.Label nameProduct;
        private System.Windows.Forms.TextBox MaGiayDepBox;
        private System.Windows.Forms.Label SoLuong;
        private System.Windows.Forms.TextBox SoLuongBox;
        private FontAwesome.Sharp.IconButton ButtonAddData;
        private FontAwesome.Sharp.IconButton RenewButton;
        private System.Windows.Forms.Label MaNV;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.DataGridView DGVImport;
        private System.Windows.Forms.TextBox NgayNhapBox;
        private System.Windows.Forms.Label MaNCC;
        private System.Windows.Forms.Label NgayNhap;
        private FontAwesome.Sharp.IconButton addToDGView;
        private System.Windows.Forms.ComboBox MaNVBox;
        private System.Windows.Forms.ComboBox MaNCCBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiayDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}