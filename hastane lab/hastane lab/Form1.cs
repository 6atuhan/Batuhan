using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hasta h = new Hasta();
            h.Kimlik.KimlikBilgileriniGetir(111);
            MessageBox.Show(h.Kimlik.Ad + " " + h.Kimlik.Soyad);
            Poliklinik pol = new Poliklinik();
            pol.DoktorAdi = "mislina";
            pol.PolikinlikAdi = "kalp";
            pol.Tarih=Convert.ToDateTime("08.08.2019");
            h.SonGidilenPoliklinik = pol;
        }
    }
}
