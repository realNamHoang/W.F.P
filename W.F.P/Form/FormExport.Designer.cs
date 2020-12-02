namespace W.F.P
{
    partial class FormExport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SoHDB = new System.Windows.Forms.Label();
            this.SoHDBBox = new System.Windows.Forms.TextBox();
            this.nameProduct = new System.Windows.Forms.Label();
            this.MaGiayDepBox = new System.Windows.Forms.TextBox();
            this.SoLuong = new System.Windows.Forms.Label();
            this.SoLuongBox = new System.Windows.Forms.TextBox();
            this.ButtonAddData = new FontAwesome.Sharp.IconButton();
            this.RenewButton = new FontAwesome.Sharp.IconButton();
            this.MaNV = new System.Windows.Forms.Label();
            this.countBox = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.Label();
            this.DGVExport = new System.Windows.Forms.DataGridView();
            this.NgayBanBox = new System.Windows.Forms.TextBox();
            this.MaKhach = new System.Windows.Forms.Label();
            this.Ngayban = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.MaNVBox = new System.Windows.Forms.ComboBox();
            this.MaKhachBox = new System.Windows.Forms.ComboBox();
            this.SHDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVExport)).BeginInit();
            this.SuspendLayout();
            // 
            // SoHDB
            // 
            this.SoHDB.AutoSize = true;
            this.SoHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoHDB.ForeColor = System.Drawing.Color.Gainsboro;
            this.SoHDB.Location = new System.Drawing.Point(344, 17);
            this.SoHDB.Name = "SoHDB";
            this.SoHDB.Size = new System.Drawing.Size(108, 16);
            this.SoHDB.TabIndex = 1;
            this.SoHDB.Text = "Số Hóa Đơn Bán";
            // 
            // SoHDBBox
            // 
            this.SoHDBBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoHDBBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoHDBBox.Location = new System.Drawing.Point(462, 14);
            this.SoHDBBox.Margin = new System.Windows.Forms.Padding(5);
            this.SoHDBBox.Name = "SoHDBBox";
            this.SoHDBBox.Size = new System.Drawing.Size(149, 22);
            this.SoHDBBox.TabIndex = 2;
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
            this.MaGiayDepBox.Location = new System.Drawing.Point(277, 58);
            this.MaGiayDepBox.Name = "MaGiayDepBox";
            this.MaGiayDepBox.Size = new System.Drawing.Size(149, 22);
            this.MaGiayDepBox.TabIndex = 2;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSize = true;
            this.SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuong.ForeColor = System.Drawing.Color.Gainsboro;
            this.SoLuong.Location = new System.Drawing.Point(550, 60);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(65, 16);
            this.SoLuong.TabIndex = 6;
            this.SoLuong.Text = "Số Lượng";
            // 
            // SoLuongBox
            // 
            this.SoLuongBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoLuongBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuongBox.Location = new System.Drawing.Point(643, 58);
            this.SoLuongBox.Name = "SoLuongBox";
            this.SoLuongBox.Size = new System.Drawing.Size(149, 22);
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
            this.ButtonAddData.Text = "Thêm Hóa đơn Bán";
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
            this.MaNV.Size = new System.Drawing.Size(92, 16);
            this.MaNV.TabIndex = 1;
            this.MaNV.Text = "Mã Nhân Viên";
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
            // DGVExport
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGVExport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVExport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVExport.BackgroundColor = System.Drawing.Color.White;
            this.DGVExport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVExport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVExport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVExport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVExport.ColumnHeadersHeight = 48;
            this.DGVExport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SHDB,
            this.MaSanPham,
            this.SoLuongView,
            this.GiamGia,
            this.ThanhTien});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVExport.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVExport.EnableHeadersVisualStyles = false;
            this.DGVExport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVExport.Location = new System.Drawing.Point(0, 201);
            this.DGVExport.Name = "DGVExport";
            this.DGVExport.RowHeadersVisible = false;
            this.DGVExport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVExport.Size = new System.Drawing.Size(964, 189);
            this.DGVExport.TabIndex = 8;
            // 
            // NgayBanBox
            // 
            this.NgayBanBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NgayBanBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayBanBox.Location = new System.Drawing.Point(643, 150);
            this.NgayBanBox.Name = "NgayBanBox";
            this.NgayBanBox.Size = new System.Drawing.Size(149, 22);
            this.NgayBanBox.TabIndex = 2;
            this.NgayBanBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoLuongBox_KeyPress);
            // 
            // MaKhach
            // 
            this.MaKhach.AutoSize = true;
            this.MaKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKhach.ForeColor = System.Drawing.Color.Gainsboro;
            this.MaKhach.Location = new System.Drawing.Point(159, 150);
            this.MaKhach.Name = "MaKhach";
            this.MaKhach.Size = new System.Drawing.Size(67, 16);
            this.MaKhach.TabIndex = 1;
            this.MaKhach.Text = "Mã Khách";
            // 
            // Ngayban
            // 
            this.Ngayban.AutoSize = true;
            this.Ngayban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ngayban.ForeColor = System.Drawing.Color.Gainsboro;
            this.Ngayban.Location = new System.Drawing.Point(550, 150);
            this.Ngayban.Name = "Ngayban";
            this.Ngayban.Size = new System.Drawing.Size(68, 16);
            this.Ngayban.TabIndex = 6;
            this.Ngayban.Text = "Ngày Bán";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(828, 127);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(105, 45);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "Thêm dữ liệu vào bảng ghi";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // MaNVBox
            // 
            this.MaNVBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNVBox.FormattingEnabled = true;
            this.MaNVBox.Location = new System.Drawing.Point(277, 104);
            this.MaNVBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.MaNVBox.Name = "MaNVBox";
            this.MaNVBox.Size = new System.Drawing.Size(149, 23);
            this.MaNVBox.TabIndex = 10;
            // 
            // MaKhachBox
            // 
            this.MaKhachBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKhachBox.FormattingEnabled = true;
            this.MaKhachBox.Location = new System.Drawing.Point(277, 147);
            this.MaKhachBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.MaKhachBox.Name = "MaKhachBox";
            this.MaKhachBox.Size = new System.Drawing.Size(149, 23);
            this.MaKhachBox.TabIndex = 10;
            // 
            // SHDB
            // 
            this.SHDB.HeaderText = "SHDB";
            this.SHDB.Name = "SHDB";
            // 
            // MaSanPham
            // 
            this.MaSanPham.HeaderText = "MaSanPham";
            this.MaSanPham.Name = "MaSanPham";
            // 
            // SoLuongView
            // 
            this.SoLuongView.HeaderText = "SoLuong";
            this.SoLuongView.Name = "SoLuongView";
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
            // FormExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(964, 477);
            this.Controls.Add(this.MaKhachBox);
            this.Controls.Add(this.MaNVBox);
            this.Controls.Add(this.DGVExport);
            this.Controls.Add(this.RenewButton);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.ButtonAddData);
            this.Controls.Add(this.Ngayban);
            this.Controls.Add(this.count);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.MaKhach);
            this.Controls.Add(this.MaNV);
            this.Controls.Add(this.MaGiayDepBox);
            this.Controls.Add(this.NgayBanBox);
            this.Controls.Add(this.nameProduct);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.SoLuongBox);
            this.Controls.Add(this.SoHDBBox);
            this.Controls.Add(this.SoHDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExport";
            this.Text = "FormProduster";
            this.Load += new System.EventHandler(this.FormProdusterCustommer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVExport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SoHDB;
        private System.Windows.Forms.TextBox SoHDBBox;
        private System.Windows.Forms.Label nameProduct;
        private System.Windows.Forms.TextBox MaGiayDepBox;
        private System.Windows.Forms.Label SoLuong;
        private System.Windows.Forms.TextBox SoLuongBox;
        private FontAwesome.Sharp.IconButton ButtonAddData;
        private FontAwesome.Sharp.IconButton RenewButton;
        private System.Windows.Forms.Label MaNV;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.DataGridView DGVExport;
        private System.Windows.Forms.TextBox NgayBanBox;
        private System.Windows.Forms.Label MaKhach;
        private System.Windows.Forms.Label Ngayban;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ComboBox MaNVBox;
        private System.Windows.Forms.ComboBox MaKhachBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongView;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}