using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYP_AJANS_PROJE
{
    public partial class AJANS : Form
    {
        public AJANS()
        {
            InitializeComponent();
        }
        string adminID = "admin", adminSifre = "admin123", müdürID = "müdür", mudurSifre = "müdür123";
        Oyuncular oyuncu = new Oyuncular();
        int no = 0,toplamGelir=0,toplamGider=0;
        const int sabitGider = 18000;
        private void btnOyuncuEkle_Click(object sender, EventArgs e)
        {

            

            oyuncu.adi = txtOyuncuAdı.Text;
            oyuncu.bransi = cbBrans.Text;
            oyuncu.no = no;
            no++;
            
          


            if (oyuncu.bransi == "") 
            { MessageBox.Show("Brans Secmediniz."); }
            else if (oyuncu.adi == "")
            { MessageBox.Show("Ad Girmediniz."); }
            else
            { listboxOyuncuListesi.Items.Add(oyuncu.no+" " + oyuncu.adi + " "+ oyuncu.bransi); }
            

            
        }

        private void brnOyuncuGoruntule_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOyuncuSil_Click(object sender, EventArgs e)
        {
            listboxOyuncuListesi.Items.Remove(listboxOyuncuListesi.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bilanco = toplamGelir - (sabitGider + toplamGider);
            
            if(bilanco <0)
            {
                lblBilanco.ForeColor = Color.Red;
                lblBilanco.Text = (bilanco).ToString() + "TL ile zarardayız." ;
            }
            else if(bilanco > 0)
            {
                lblBilanco.ForeColor = Color.Green;
                lblBilanco.Text = (bilanco).ToString() + "TL ile kârdayız.";
            }
            else if (bilanco == 0)
            {
                lblBilanco.ForeColor = Color.Blue;
                lblBilanco.Text = (bilanco).ToString() + "TL ile fitiz";
            }

        }
        

        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            Firma firma = new Firma();
            firma.adi = txtFirmaAdi.Text;
            firma.sehir = txtFirmaSehri.Text;

            txtFirma.Items.Add(firma.adi);
        }

        int firma1=0, firma2=0;

        private void btnFirmaGoster_Click(object sender, EventArgs e)
        {
            label15.Text = txtFirma.Items[0].ToString() + " ile " + firma1para + " TL lik " + firma1 + " tane iş Yapıldı " + "\n" + txtFirma.Items[1].ToString() + " ile " + firma2para + " TL lik " + firma2 + " iş yapıldı.";
        }

        private void AJANS_Load(object sender, EventArgs e)
        {
            this.Width = 274;
            this.Height = 183;
            btbCikis.Location = new Point(180, 108);
        }

        int firma1para = 0, firma2para = 0;
        private void btnIsEkle_Click(object sender, EventArgs e)
        {
            
            int i = Convert.ToInt32(txtOyuncuNo.Text);
            string temp = listboxOyuncuListesi.Items[i].ToString();
            listboxOyuncuListesi.Items.RemoveAt(i);
            

            oyuncu.isi = txtIs.Text;
            oyuncu.firmasi = txtFirma.Text;
            oyuncu.iseGirisTarihi = txtGiris.Text;
            oyuncu.isiBitirmeTarihi = txtBitis.Text;
            oyuncu.maasi = Convert.ToInt32(txtMaas.Text);
            toplamGider += oyuncu.maasi;
            oyuncu.aktiflik = true;
            listboxOyuncuListesi.Items.Insert(i,temp + " " + oyuncu.isi + " " +oyuncu.firmasi + " " +oyuncu.iseGirisTarihi + " " +oyuncu.isiBitirmeTarihi + " " +oyuncu.maasi + "TL." );
             int odenek = Convert.ToInt32(txtOdenek.Text);

            if(txtFirma.SelectedIndex==0)
            {
                firma1++;
                if (firma1 >= 3 )
                {
                    odenek = (odenek * 80) / 100;

                    lblOdenek.Text = "Aynı Firma ile 3. iş için %20 indirim : " + odenek + "TL.";
                }
                firma1para += odenek;
            }
            else if(txtFirma.SelectedIndex == 1)
            { 
                firma2++;
                if (firma2 >= 3)
                {
                    odenek = (odenek * 80) / 100;

                    lblOdenek.Text = "Aynı Firma ile 3. iş için %20 indirim : " + odenek + "TL.";
                }
                firma2para += odenek;
            }
            
            toplamGelir += odenek;

        }


        private void txtOyuncuNo_Click(object sender, EventArgs e)
        {
            txtOyuncuNo.Text = "";
        }

        bool giristuru;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            

            if (txbxID.Text=="admin" && txbxSifre.Text=="admin123")
            {
                giristuru = true;
                MessageBox.Show("ADMİN girişi yapıldı.");
                label1.Visible = false;
                label2.Visible = false;
                txbxID.Visible = false;
                txbxSifre.Visible = false;
                btnGiris.Visible = false;
                gbOyuncuİşlem.Visible = true;
                gbMaaliisler.Visible = true;
                gbFirmaEkle.Visible = true;
                txbxID.Text = "";
                txbxSifre.Text = "";
                lblKim.Text = "ADMİN";
                lblKim.Visible = true;
                txtMaas.Enabled = true;
                this.Width = 726;
                this.Height = 544;
                btbCikis.Location = new Point(624, 12);


            }
            else if (txbxID.Text == "müdür" && txbxSifre.Text == "müdür123")
            {
                giristuru = false;
                MessageBox.Show("MÜDÜR girişi yapıldı.");
                label1.Visible = false;
                label2.Visible = false;
                txbxID.Visible = false;
                txbxSifre.Visible = false;
                btnGiris.Visible = false;
                gbOyuncuİşlem.Visible = true;
                gbMaaliisler.Visible = true;
                gbFirmaEkle.Visible = true;
                txbxID.Text = "";
                txbxSifre.Text = "";
                lblKim.Text = "MÜDÜR";
                lblKim.Visible = true;
                txtMaas.Enabled = false;
                this.Width = 726;
                this.Height = 544;
                btbCikis.Location = new Point(624, 12);

            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.");
            }


        }

        private void btbCikis_Click(object sender, EventArgs e)
        {
            btbCikis.Location = new Point(180,108);
            this.Width = 274;
            this.Height = 183;
            label1.Visible = true;
            label2.Visible = true;
            txbxID.Visible = true;
            txbxSifre.Visible = true;
            btnGiris.Visible = true;
            txbxID.Text = "";
            txbxSifre.Text = "";
            lblKim.Visible = false;
            gbOyuncuİşlem.Visible = false;
            gbMaaliisler.Visible = false;
            gbFirmaEkle.Visible = false ;
            txtMaas.Enabled = true;
        }
    }
}
