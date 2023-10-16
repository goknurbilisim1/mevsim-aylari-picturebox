using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mevsimaylari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbAylar_SelectedIndexChanged(object sender, EventArgs e)
        {

            int secim = cmbAylar.SelectedIndex;

            if (secim == 2 || secim == 3 || secim == 4) //Mart Nisan Mayıs
            {
                lblMevsim.Text = "İlkbahar";
                pictureBox1.Image=Properties.Resources.ilkbahar;
            }
            else if (secim == 5 || secim == 6 || secim == 7) //Haziran Temmuz Ağustos
            {
                lblMevsim.Text = "Yaz";
                pictureBox1.Image = Properties.Resources.yaz;
            }
            else if (secim == 8 || secim == 9 || secim == 10) //Eylül Ekim Kasım
            {
                lblMevsim.Text = "Sonbahar";
                pictureBox1.Image = Properties.Resources.sonbahar;
            }
            else  //Diğer geri kalan durumlar
            {
                lblMevsim.Text = "Kış";
                pictureBox1.Image = Properties.Resources.kis;
            }
        }
    }
}
