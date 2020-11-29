namespace W.F.P
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Repost = new FontAwesome.Sharp.IconButton();
            this.Setting = new FontAwesome.Sharp.IconButton();
            this.Products = new FontAwesome.Sharp.IconButton();
            this.InsertProduct = new FontAwesome.Sharp.IconButton();
            this.BtnHome = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitlecurrent = new System.Windows.Forms.Label();
            this.iconCurrent = new FontAwesome.Sharp.IconPictureBox();
            this.panelShawdor = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.searchHD = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.searchHD);
            this.panelMenu.Controls.Add(this.Repost);
            this.panelMenu.Controls.Add(this.Setting);
            this.panelMenu.Controls.Add(this.Products);
            this.panelMenu.Controls.Add(this.InsertProduct);
            this.panelMenu.Controls.Add(this.BtnHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // Repost
            // 
            this.Repost.Dock = System.Windows.Forms.DockStyle.Top;
            this.Repost.FlatAppearance.BorderSize = 0;
            this.Repost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Repost.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Repost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repost.ForeColor = System.Drawing.Color.Gainsboro;
            this.Repost.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.Repost.IconColor = System.Drawing.Color.Gainsboro;
            this.Repost.IconSize = 32;
            this.Repost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Repost.Location = new System.Drawing.Point(0, 195);
            this.Repost.Name = "Repost";
            this.Repost.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Repost.Rotation = 0D;
            this.Repost.Size = new System.Drawing.Size(220, 60);
            this.Repost.TabIndex = 7;
            this.Repost.Text = "Tìm Kiếm Mặt Hàng";
            this.Repost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Repost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Repost.UseVisualStyleBackColor = true;
            this.Repost.Click += new System.EventHandler(this.Repost_Click);
            // 
            // Setting
            // 
            this.Setting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Setting.FlatAppearance.BorderSize = 0;
            this.Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setting.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setting.ForeColor = System.Drawing.Color.Gainsboro;
            this.Setting.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.Setting.IconColor = System.Drawing.Color.Gainsboro;
            this.Setting.IconSize = 32;
            this.Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Setting.Location = new System.Drawing.Point(0, 501);
            this.Setting.Name = "Setting";
            this.Setting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Setting.Rotation = 0D;
            this.Setting.Size = new System.Drawing.Size(220, 60);
            this.Setting.TabIndex = 6;
            this.Setting.Text = "Setting";
            this.Setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Setting.UseVisualStyleBackColor = true;
            this.Setting.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // Products
            // 
            this.Products.Dock = System.Windows.Forms.DockStyle.Top;
            this.Products.FlatAppearance.BorderSize = 0;
            this.Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Products.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.ForeColor = System.Drawing.Color.Gainsboro;
            this.Products.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.Products.IconColor = System.Drawing.Color.Gainsboro;
            this.Products.IconSize = 32;
            this.Products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Products.Location = new System.Drawing.Point(0, 135);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Products.Rotation = 0D;
            this.Products.Size = new System.Drawing.Size(220, 60);
            this.Products.TabIndex = 2;
            this.Products.Text = "Tổng quan mặt hàng";
            this.Products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Products.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Products.UseVisualStyleBackColor = true;
            this.Products.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // InsertProduct
            // 
            this.InsertProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.InsertProduct.FlatAppearance.BorderSize = 0;
            this.InsertProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertProduct.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.InsertProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.InsertProduct.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.InsertProduct.IconColor = System.Drawing.Color.Gainsboro;
            this.InsertProduct.IconSize = 32;
            this.InsertProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InsertProduct.Location = new System.Drawing.Point(0, 75);
            this.InsertProduct.Name = "InsertProduct";
            this.InsertProduct.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.InsertProduct.Rotation = 0D;
            this.InsertProduct.Size = new System.Drawing.Size(220, 60);
            this.InsertProduct.TabIndex = 1;
            this.InsertProduct.Text = "Nhập dữ liệu mặt hàng";
            this.InsertProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InsertProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InsertProduct.UseVisualStyleBackColor = true;
            this.InsertProduct.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.Location = new System.Drawing.Point(0, 0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnHome.Size = new System.Drawing.Size(220, 75);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.lblTitlecurrent);
            this.panel1.Controls.Add(this.iconCurrent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 75);
            this.panel1.TabIndex = 1;
            // 
            // lblTitlecurrent
            // 
            this.lblTitlecurrent.AutoSize = true;
            this.lblTitlecurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlecurrent.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitlecurrent.Location = new System.Drawing.Point(56, 35);
            this.lblTitlecurrent.Name = "lblTitlecurrent";
            this.lblTitlecurrent.Size = new System.Drawing.Size(95, 16);
            this.lblTitlecurrent.TabIndex = 1;
            this.lblTitlecurrent.Text = "Màn hình chính";
            // 
            // iconCurrent
            // 
            this.iconCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrent.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrent.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrent.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrent.Location = new System.Drawing.Point(18, 26);
            this.iconCurrent.Name = "iconCurrent";
            this.iconCurrent.Size = new System.Drawing.Size(32, 32);
            this.iconCurrent.TabIndex = 0;
            this.iconCurrent.TabStop = false;
            // 
            // panelShawdor
            // 
            this.panelShawdor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShawdor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShawdor.Location = new System.Drawing.Point(220, 75);
            this.panelShawdor.Name = "panelShawdor";
            this.panelShawdor.Size = new System.Drawing.Size(964, 9);
            this.panelShawdor.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(964, 477);
            this.panelDesktop.TabIndex = 3;
            // 
            // searchHD
            // 
            this.searchHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchHD.FlatAppearance.BorderSize = 0;
            this.searchHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchHD.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.searchHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchHD.ForeColor = System.Drawing.Color.Gainsboro;
            this.searchHD.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.searchHD.IconColor = System.Drawing.Color.Gainsboro;
            this.searchHD.IconSize = 32;
            this.searchHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchHD.Location = new System.Drawing.Point(0, 255);
            this.searchHD.Name = "searchHD";
            this.searchHD.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.searchHD.Rotation = 0D;
            this.searchHD.Size = new System.Drawing.Size(220, 60);
            this.searchHD.TabIndex = 8;
            this.searchHD.Text = "Tìm kiếm Hóa Đơn";
            this.searchHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchHD.UseVisualStyleBackColor = true;
            this.searchHD.Click += new System.EventHandler(this.searchHD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShawdor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel BtnHome;
        private FontAwesome.Sharp.IconButton Setting;
        private FontAwesome.Sharp.IconButton Products;
        private FontAwesome.Sharp.IconButton InsertProduct;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrent;
        private System.Windows.Forms.Label lblTitlecurrent;
        private System.Windows.Forms.Panel panelShawdor;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton Repost;
        private FontAwesome.Sharp.IconButton searchHD;
    }
}

