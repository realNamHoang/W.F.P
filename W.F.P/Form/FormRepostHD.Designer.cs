﻿namespace W.F.P
{
    partial class FormRepostHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVExport = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Label();
            this.DataSearchHDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataSearchRequestBox = new System.Windows.Forms.TextBox();
            this.ExportExcel = new FontAwesome.Sharp.IconButton();
            this.ExtraDataView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtraDataView)).BeginInit();
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
            this.DGVExport.Location = new System.Drawing.Point(0, 219);
            this.DGVExport.Name = "DGVExport";
            this.DGVExport.RowHeadersVisible = false;
            this.DGVExport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVExport.Size = new System.Drawing.Size(964, 258);
            this.DGVExport.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.Gainsboro;
            this.Search.Location = new System.Drawing.Point(263, 42);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(120, 16);
            this.Search.TabIndex = 1;
            this.Search.Text = "Tìm Kiếm Hóa Đơn";
            // 
            // DataSearchHDBox
            // 
            this.DataSearchHDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataSearchHDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSearchHDBox.Location = new System.Drawing.Point(412, 40);
            this.DataSearchHDBox.Name = "DataSearchHDBox";
            this.DataSearchHDBox.Size = new System.Drawing.Size(174, 22);
            this.DataSearchHDBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(263, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Kiếm theo yêu cầu";
            // 
            // DataSearchRequestBox
            // 
            this.DataSearchRequestBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataSearchRequestBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSearchRequestBox.Location = new System.Drawing.Point(412, 76);
            this.DataSearchRequestBox.Name = "DataSearchRequestBox";
            this.DataSearchRequestBox.Size = new System.Drawing.Size(174, 22);
            this.DataSearchRequestBox.TabIndex = 2;
            this.DataSearchRequestBox.Enter += new System.EventHandler(this.DataSearchRequestBox_Enter);
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
            this.ExportExcel.Location = new System.Drawing.Point(667, 130);
            this.ExportExcel.Name = "ExportExcel";
            this.ExportExcel.Rotation = 0D;
            this.ExportExcel.Size = new System.Drawing.Size(198, 52);
            this.ExportExcel.TabIndex = 3;
            this.ExportExcel.Text = "Export to Excel";
            this.ExportExcel.UseVisualStyleBackColor = true;
            this.ExportExcel.Click += new System.EventHandler(this.ExportExcel_Click);
            // 
            // ExtraDataView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ExtraDataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ExtraDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExtraDataView.BackgroundColor = System.Drawing.Color.White;
            this.ExtraDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExtraDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ExtraDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExtraDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ExtraDataView.ColumnHeadersHeight = 48;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExtraDataView.DefaultCellStyle = dataGridViewCellStyle6;
            this.ExtraDataView.EnableHeadersVisualStyles = false;
            this.ExtraDataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ExtraDataView.Location = new System.Drawing.Point(12, 104);
            this.ExtraDataView.Name = "ExtraDataView";
            this.ExtraDataView.RowHeadersVisible = false;
            this.ExtraDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExtraDataView.Size = new System.Drawing.Size(679, 100);
            this.ExtraDataView.TabIndex = 6;
            // 
            // FormRepostHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(964, 477);
            this.Controls.Add(this.ExtraDataView);
            this.Controls.Add(this.ExportExcel);
            this.Controls.Add(this.DataSearchRequestBox);
            this.Controls.Add(this.DataSearchHDBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.DGVExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRepostHD";
            this.Text = "FormOrders";
            this.Load += new System.EventHandler(this.FormRepostHD_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormRepostHD_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.DGVExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtraDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVExport;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox DataSearchHDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DataSearchRequestBox;
        private FontAwesome.Sharp.IconButton ExportExcel;
        private System.Windows.Forms.DataGridView ExtraDataView;
    }
}