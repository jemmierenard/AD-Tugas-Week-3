using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Week_2
{
    public partial class FormWarna : Form
    {
        public FormWarna()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void BtnProses_Click(object sender, EventArgs e)
        {
            if (TBoxIsi.Text.Substring(0,4) == "ISI:")
            {
                LblOutput.Text = TBoxIsi.Text.Substring(4);
            }
            else if (TBoxIsi.Text == "HIDE")
            {
                LblOutput.Visible = false;
            }
            else if (TBoxIsi.Text == "SHOWN")
            {
                LblOutput.Visible = true;
            }
            else if (TBoxIsi.Text == "WARNA: DEFAULT")
            {
                LblOutput.ForeColor = Color.Black;
            }
            else if (TBoxIsi.Text == "WARNA: MERAH")
            {
                LblOutput.ForeColor = Color.Red;
            }
            else if (TBoxIsi.Text == "WARNA: HIJAU")
            {
                LblOutput.ForeColor = Color.Green;
            }
            else if (TBoxIsi.Text == "WARNA: BIRU")
            {
                LblOutput.ForeColor = Color.Blue;
            }
            else if (TBoxIsi.Text == "RESTART")
            {
                LblOutput.ForeColor = Color.Black;
                LblOutput.Text = "[EMPTY]";
            }
            else if (TBoxIsi.Text == "BESARKAN")
            {
                var upSize = LblOutput.Font.Size;
                upSize++;
                LblOutput.Font = new Font(LblOutput.Font.FontFamily, upSize);
            }
            else if (TBoxIsi.Text == "KECILKAN")
            {
                var downSize = LblOutput.Font.Size;
                downSize--;
                LblOutput.Font = new Font(LblOutput.Font.FontFamily, downSize);
            }
            else
            {
                MessageBox.Show("Syntax Tidak Terdaftar!");
            }
        }
    }
}
