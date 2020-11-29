namespace W.F.P
{
    partial class FormSetting
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
            this.DGVExport = new System.Windows.Forms.DataGridView();
            this.Quý = new System.Windows.Forms.Label();
            this.QuyBox = new System.Windows.Forms.ComboBox();
            this.ExportExcel = new FontAwesome.Sharp.IconButton();
            this.Top3 = new FontAwesome.Sharp.IconButton();
            this.Enterbutton = new FontAwesome.Sharp.IconButton();
            this.year = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVExport)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVExport.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGVExport.EnableHeadersVisualStyles = false;
            this.DGVExport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVExport.Location = new System.Drawing.Point(0, 193);
            this.DGVExport.Name = "DGVExport";
            this.DGVExport.RowHeadersVisible = false;
            this.DGVExport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVExport.Size = new System.Drawing.Size(948, 245);
            this.DGVExport.TabIndex = 1;
            // 
            // Quý
            // 
            this.Quý.AutoSize = true;
            this.Quý.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quý.ForeColor = System.Drawing.Color.Gainsboro;
            this.Quý.Location = new System.Drawing.Point(248, 39);
            this.Quý.Name = "Quý";
            this.Quý.Size = new System.Drawing.Size(32, 16);
            this.Quý.TabIndex = 2;
            this.Quý.Text = "Quý";
            // 
            // QuyBox
            // 
            this.QuyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuyBox.FormattingEnabled = true;
            this.QuyBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.QuyBox.Location = new System.Drawing.Point(294, 36);
            this.QuyBox.Name = "QuyBox";
            this.QuyBox.Size = new System.Drawing.Size(205, 24);
            this.QuyBox.TabIndex = 3;
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
            this.ExportExcel.Location = new System.Drawing.Point(574, 39);
            this.ExportExcel.Name = "ExportExcel";
            this.ExportExcel.Rotation = 0D;
            this.ExportExcel.Size = new System.Drawing.Size(198, 52);
            this.ExportExcel.TabIndex = 5;
            this.ExportExcel.Text = "Export to Excel";
            this.ExportExcel.UseVisualStyleBackColor = true;
            // 
            // Top3
            // 
            this.Top3.FlatAppearance.BorderSize = 0;
            this.Top3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Top3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Top3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top3.ForeColor = System.Drawing.Color.Gainsboro;
            this.Top3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Top3.IconColor = System.Drawing.Color.Black;
            this.Top3.IconSize = 16;
            this.Top3.Location = new System.Drawing.Point(121, 119);
            this.Top3.Name = "Top3";
            this.Top3.Rotation = 0D;
            this.Top3.Size = new System.Drawing.Size(198, 52);
            this.Top3.TabIndex = 6;
            this.Top3.Text = "Ba Người cao Nhất";
            this.Top3.UseVisualStyleBackColor = true;
            // 
            // Enterbutton
            // 
            this.Enterbutton.FlatAppearance.BorderSize = 0;
            this.Enterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enterbutton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Enterbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enterbutton.ForeColor = System.Drawing.Color.Gainsboro;
            this.Enterbutton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Enterbutton.IconColor = System.Drawing.Color.Black;
            this.Enterbutton.IconSize = 16;
            this.Enterbutton.Location = new System.Drawing.Point(598, 119);
            this.Enterbutton.Name = "Enterbutton";
            this.Enterbutton.Rotation = 0D;
            this.Enterbutton.Size = new System.Drawing.Size(198, 52);
            this.Enterbutton.TabIndex = 6;
            this.Enterbutton.Text = "Trong quý đó";
            this.Enterbutton.UseVisualStyleBackColor = true;
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.ForeColor = System.Drawing.Color.Gainsboro;
            this.year.Location = new System.Drawing.Point(248, 77);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(37, 16);
            this.year.TabIndex = 2;
            this.year.Text = "Năm";
            // 
            // yearBox
            // 
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(294, 73);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(205, 24);
            this.yearBox.TabIndex = 3;
            // 
            // FormSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(948, 438);
            this.Controls.Add(this.Enterbutton);
            this.Controls.Add(this.Top3);
            this.Controls.Add(this.ExportExcel);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.year);
            this.Controls.Add(this.QuyBox);
            this.Controls.Add(this.Quý);
            this.Controls.Add(this.DGVExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVExport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVExport;
        private System.Windows.Forms.Label Quý;
        private System.Windows.Forms.ComboBox QuyBox;
        private FontAwesome.Sharp.IconButton ExportExcel;
        private FontAwesome.Sharp.IconButton Top3;
        private FontAwesome.Sharp.IconButton Enterbutton;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.ComboBox yearBox;
    }
}