using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LieuMinhTrong_26_ThiCSharp
{
    public partial class DinhDang : Form
    {
        public DinhDang()
        {
            InitializeComponent();
        }

        private void txtNhapten_TextChanged(object sender, EventArgs e)
        {
            txtLaptrinh.Text = txtNhapten.Text;
            txtLaptrinh.Text = txtNhapten.Text;
        }

        private void DinhDang_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            this.CancelButton = btnThoat;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "radRed":
                    lblLaptrinh.ForeColor = Color.Red;
                    txtNhapten.ForeColor = Color.Red;
                    txtLaptrinh.ForeColor = Color.Red;
                    break;
                case "radGreen":
                    lblLaptrinh.ForeColor = Color.Green;
                    txtNhapten.ForeColor = Color.Green;
                    txtLaptrinh.ForeColor = Color.Green;
                    break;
                case "radBlue":
                    lblLaptrinh.ForeColor = Color.Blue;
                    txtNhapten.ForeColor = Color.Blue;
                    txtLaptrinh.ForeColor = Color.Blue;
                    break;
                case "radBlack":
                    lblLaptrinh.ForeColor = Color.Black;
                    txtNhapten.ForeColor = Color.Black;
                    txtLaptrinh.ForeColor = Color.Black;
                    break;

            }
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox r = (CheckBox)sender;
            switch (r.Name)
            {
                case "chkBold":
                    lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name, lblLaptrinh.Font.Size, lblLaptrinh.Font.Style ^ FontStyle.Bold);
                    break;
                case "chkNghieng":
                    lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name, lblLaptrinh.Font.Size, lblLaptrinh.Font.Style ^ FontStyle.Bold);
                    break;
                case "chkUnderline":
                    lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name, lblLaptrinh.Font.Size, lblLaptrinh.Font.Style ^ FontStyle.Bold);
                    break;

            }
        }
    }
}




