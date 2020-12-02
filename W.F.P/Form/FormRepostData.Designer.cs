namespace W.F.P
{
    partial class FormRepostData
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
            this.DGVExport = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Label();
            this.DataSearchBox = new System.Windows.Forms.TextBox();
            this.ExportExcel = new FontAwesome.Sharp.IconButton();
            this.XemTonKho = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVExport)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVExport
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVExport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVExport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVExport.BackgroundColor = System.Drawing.Color.White;
            this.DGVExport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVExport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVExport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVExport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVExport.ColumnHeadersHeight = 48;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVExport.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGVExport.EnableHeadersVisualStyles = false;
            this.DGVExport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVExport.Location = new System.Drawing.Point(0, 181);
            this.DGVExport.Name = "DGVExport";
            this.DGVExport.RowHeadersVisible = false;
            this.DGVExport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVExport.Size = new System.Drawing.Size(964, 296);
            this.DGVExport.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.Gainsboro;
            this.Search.Location = new System.Drawing.Point(243, 42);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(129, 16);
            this.Search.TabIndex = 1;
            this.Search.Text = "Tìm Kiếm Sản Phẩm";
            // 
            // DataSearchBox
            // 
            this.DataSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSearchBox.Location = new System.Drawing.Point(387, 40);
            this.DataSearchBox.Name = "DataSearchBox";
            this.DataSearchBox.Size = new System.Drawing.Size(156, 22);
            this.DataSearchBox.TabIndex = 2;
            this.DataSearchBox.Enter += new System.EventHandler(this.DataSearchBox_Enter);
            this.DataSearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DataSearchBox_KeyUp);
            // 
            // ExportExcel
            // 
            this.ExportExcel.FlatAppearance.BorderSize = 0;
            this.ExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportExcel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportExcel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ExportExcel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ExportExcel.IconColor = System.Drawing.Color.Black;
            this.ExportExcel.IconSize = 16;
            this.ExportExcel.Location = new System.Drawing.Point(705, 123);
            this.ExportExcel.Name = "ExportExcel";
            this.ExportExcel.Rotation = 0D;
            this.ExportExcel.Size = new System.Drawing.Size(198, 52);
            this.ExportExcel.TabIndex = 4;
            this.ExportExcel.Text = "Export to Excel";
            this.ExportExcel.UseVisualStyleBackColor = true;
            this.ExportExcel.Click += new System.EventHandler(this.ExportExcel_Click);
            // 
            // XemTonKho
            // 
            this.XemTonKho.FlatAppearance.BorderSize = 0;
            this.XemTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XemTonKho.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.XemTonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XemTonKho.ForeColor = System.Drawing.Color.Gainsboro;
            this.XemTonKho.IconChar = FontAwesome.Sharp.IconChar.None;
            this.XemTonKho.IconColor = System.Drawing.Color.Black;
            this.XemTonKho.IconSize = 16;
            this.XemTonKho.Location = new System.Drawing.Point(52, 123);
            this.XemTonKho.Name = "XemTonKho";
            this.XemTonKho.Rotation = 0D;
            this.XemTonKho.Size = new System.Drawing.Size(198, 52);
            this.XemTonKho.TabIndex = 4;
            this.XemTonKho.Text = "Tồn Kho";
            this.XemTonKho.UseVisualStyleBackColor = true;
            this.XemTonKho.Click += new System.EventHandler(this.XemTonKho_Click);
            // 
            // FormRepostData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(964, 477);
            this.Controls.Add(this.XemTonKho);
            this.Controls.Add(this.ExportExcel);
            this.Controls.Add(this.DataSearchBox);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.DGVExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRepostData";
            this.Text = "FormOrders";
            this.Load += new System.EventHandler(this.FormRepostData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVExport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVExport;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox DataSearchBox;
        private FontAwesome.Sharp.IconButton ExportExcel;
        private FontAwesome.Sharp.IconButton XemTonKho;
    }
}