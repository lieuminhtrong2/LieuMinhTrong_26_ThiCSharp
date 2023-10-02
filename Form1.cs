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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            string HoTenSV = "Lieu Minh Trong";
            string MSSV = "1223360165";
            string Monthi = "Lập trình Windows 2 C#";

            lblInfor.Text = "Họ và Tên: " + HoTenSV;
            lblInfor.Text += "\nMSSV" + MSSV;
            lblInfor.Text += "\nMonThi" + Monthi;
            lblInfor.Text += "\nTime" + System.DateTime.Now.ToString();

        }
    }
}
