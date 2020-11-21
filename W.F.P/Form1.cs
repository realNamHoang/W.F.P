using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace W.F.P
{
    public partial class Form1 : Form
    {
        private IconButton currentButton;
        private Panel leftcurrentpanel;
        private Form currentChildForm;
        public Form1()
        {
            InitializeComponent();
            leftcurrentpanel = new Panel();
            leftcurrentpanel.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftcurrentpanel);
        }

        #region UI chance font setting
        private struct ColorChange
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 162, 251);
            public static Color color7 = Color.MediumPurple;
        }
        private void ActivateButton(object senderBtn,Color color)
        {
            if (senderBtn!= null)
            {
                DisableButton();
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftcurrentpanel.BackColor = color;
                leftcurrentpanel.Location = new Point(0, currentButton.Location.Y);
                leftcurrentpanel.Visible = true;
                leftcurrentpanel.BringToFront();
                iconCurrent.IconChar = currentButton.IconChar;
                iconCurrent.IconColor = color;
                lblTitlecurrent.Text = currentButton.Text;
            }
        }

        private void DisableButton()
        {
            if(currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(31, 30, 68);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender , ColorChange.color1);
            OpenChildForm(new FormProdusterCustommer());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ColorChange.color2);
            OpenChildForm(new FormCustommers());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ColorChange.color7);
            OpenChildForm(new FormSetting());
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftcurrentpanel.Visible = false;
            iconCurrent.IconChar = IconChar.Home;
            iconCurrent.IconColor = Color.MediumPurple;
            lblTitlecurrent.Text = "Home";
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ColorChange.color4);
            OpenChildForm(new FormOrders());
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitlecurrent.Text = childForm.Text;
        }
        #endregion
    }
}