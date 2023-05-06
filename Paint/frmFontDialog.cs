using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class frmFontDialog : Form
    {
        
        public frmFontDialog()
        {
            InitializeComponent();
        }

        public string Mytext
        {
            get { return lblEjemplo.Text; }
        }

        public Font Myfont
        {
            get { return lblEjemplo.Font; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int newFontStyle = lboxFontStyle.SelectedIndex;
            txtFontStyle.Text = lboxFontStyle.GetItemText(lboxFontStyle.SelectedItem);

            switch (newFontStyle)
            {
                case 0:
                    lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, lblEjemplo.Font.Size, FontStyle.Regular);
                    if (chbxStrikeout.Checked == true)
                    {
                        lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, lblEjemplo.Font.Size, lblEjemplo.Font.Style | FontStyle.Strikeout);
                    }
                    if (chbxUnderline.Checked == true)
                    {
                        lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, lblEjemplo.Font.Size, lblEjemplo.Font.Style | FontStyle.Underline);
                    }
                    break;
                case 1:
                    lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, lblEjemplo.Font.Size, FontStyle.Bold);
                    if (chbxStrikeout.Checked == true)
                    {
                        lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, lblEjemplo.Font.Size, lblEjemplo.Font.Style | FontStyle.Strikeout);
                    }
                    if (chbxUnderline.Checked == true)
                    {
                        lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, lblEjemplo.Font.Size, lblEjemplo.Font.Style | FontStyle.Underline);
                    }
                    break;
                case 2:
                    lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, lblEjemplo.Font.Size, FontStyle.Italic);
                    if (chbxStrikeout.Checked == true)
                    {
                        lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, lblEjemplo.Font.Size, lblEjemplo.Font.Style | FontStyle.Strikeout);
                    }
                    if (chbxUnderline.Checked == true)
                    {
                        lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, lblEjemplo.Font.Size, lblEjemplo.Font.Style | FontStyle.Underline);
                    }
                    break;
                default:
                    break;
            }
        }

        private void lboxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newFont = lboxFont.GetItemText(lboxFont.SelectedItem);
            lblEjemplo.Font = new Font(newFont, lblEjemplo.Font.Size, lblEjemplo.Font.Style);
            txtFont.Text = newFont;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void lboxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int newFontSize = Convert.ToInt32(lboxSize.SelectedItem);
            lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, newFontSize, lblEjemplo.Font.Style);
            txtSize.Text = lboxSize.GetItemText(lboxSize.SelectedItem);
        }

        private void txtFont_TextChanged(object sender, EventArgs e)
        {
            string newFont = lboxFont.GetItemText(lboxFont.SelectedItem);
            txtFont.Text = newFont;
        }

        private void txtFontStyle_TextChanged(object sender, EventArgs e)
        {
            string newFontStyle = lboxFontStyle.GetItemText(lboxFontStyle.SelectedItem);
            txtFontStyle.Text = newFontStyle;
        }

        private void lblEjemplo_Click(object sender, EventArgs e)
        {

        }

        private void chbxStrikeout_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxStrikeout.Checked == true)
            {
                lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, lblEjemplo.Font.Size, lblEjemplo.Font.Style | FontStyle.Strikeout);
            }
            else if (chbxStrikeout.Checked == false)
            {
                lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, lblEjemplo.Font.Size, FontStyle.Regular);
                if (chbxUnderline.Checked == true)
                {
                    lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, lblEjemplo.Font.Size, lblEjemplo.Font.Style | FontStyle.Underline);

                }
            }
            

        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void chbxUnderline_CheckedChanged(object sender, EventArgs e)
        {

            if (chbxUnderline.Checked == true)
            {
                
                lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, lblEjemplo.Font.Size, lblEjemplo.Font.Style | FontStyle.Underline);
                
            }
            else if (chbxUnderline.Checked == false)
            {
                lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, lblEjemplo.Font.Size, FontStyle.Regular);
                if (chbxStrikeout.Checked == true)
                {
                    lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, lblEjemplo.Font.Size, lblEjemplo.Font.Style | FontStyle.Strikeout);
                }
            }
        }

        private void frmFontDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
