using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace taslak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-60IS5FR;Initial Catalog=halkitap;Integrated Security=True");

        public void baslat()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.;Initial Catalog=halkitap;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT yazarNo FROM yazar";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbYazarNo.Items.Add(dr["yazarNo"]);
            }
            baglanti.Close();


            komut.CommandText = "SELECT yayimEviNo FROM yayimEvi";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr1;
            baglanti.Open();
            dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                cmbYayınEviNo.Items.Add(dr1["yayimEviNo"]);
            }
            baglanti.Close();

            komut.CommandText = "SELECT uyeNo FROM uyeBilgileri";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr2;
            baglanti.Open();
            dr2 = komut.ExecuteReader();
            while (dr2.Read())
            {
                cmbUyeNo.Items.Add(dr2["uyeNo"]);
            }
            baglanti.Close();

            komut.CommandText = "SELECT uyeNo FROM uyeBilgileri";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr4;
            baglanti.Open();
            dr4 = komut.ExecuteReader();
            while (dr4.Read())
            {
                cmbUyeGetirNo.Items.Add(dr4["uyeNo"]);
            }
            baglanti.Close();

            komut.CommandText = "SELECT kitapNo FROM kitap";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr5;
            baglanti.Open();
            dr5 = komut.ExecuteReader();
            while (dr5.Read())
            {
                cmbKitapNo.Items.Add(dr5["kitapNo"]);
            }
            baglanti.Close();

            komut.CommandText = "SELECT islemNo FROM islem";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr6;
            baglanti.Open();
            dr6 = komut.ExecuteReader();
            while (dr6.Read())
            {
                cmbİslemNo.Items.Add(dr6["islemNo"]);
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            baslat();
        }

        private void btnYayinEviEkle_Click(object sender, EventArgs e)
        {
            string yyeAd = txtYayinEviAdi.Text;
            int plaka = Convert.ToInt32(txtPlaka.Text);
            string sql = "INSERT INTO yayimEvi (yayimEviAdi,ilKodu) VALUES ('" + yyeAd + "','" + plaka + "')";
            if (yyeAd == "")
            {
                MessageBox.Show("Eksiksiz Giriş Yapınız.");
            }
            else
            {
                
                    SqlCommand cmd = new SqlCommand(sql, baglanti);
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("YayınEvi Eklenmiştir.");
                txtPlaka.Text = "";
                txtYayinEviAdi.Text = "";



            }
        }

        private void btUyeEkle_Click(object sender, EventArgs e)
        {
            string uyeAd = txtUyeAdi.Text;
            string uyeSoyad = txtUyeSoyadi.Text;
            string sql = "INSERT INTO uyeBilgileri (uyeAdi,uyeSoyadi) VALUES ('" + uyeAd + "','" + uyeSoyad + "')";
            if (uyeAd == ""|| uyeSoyad=="")
            {
                MessageBox.Show("Eksiksiz Giriş Yapınız.");
            }
            else
            {

                SqlCommand cmd = new SqlCommand(sql, baglanti);
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Uye Eklenmiştir.");
                txtUyeAdi.Text = "";
                txtUyeSoyadi.Text = "";


            }
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            int uyeNo = Convert.ToInt32(cmbUyeNo.Text);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from uyeBilgileri where uyeNo=" + uyeNo + " ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Uye Kaydı Silinmiştir.");
            
        }

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            string yazarAd = txtYazarAd.Text;
            string yazarSoyad = txtYazarSoyad.Text;
            string sql = "INSERT INTO yazar (yazarAd,yazarSoyad) VALUES ('" + yazarAd + "','" + yazarSoyad + "')";
            if (yazarAd == "" || yazarSoyad == "")
            {
                MessageBox.Show("Eksiksiz Giriş Yapınız.");
            }
            else
            {

                SqlCommand cmd = new SqlCommand(sql, baglanti);
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yazar Eklenmiştir.");
                txtYazarAd.Text = "";
                txtYazarSoyad.Text = "";


            }
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            string kitapAd = txtKitapAdi.Text;
            int kitapSayfaSayisi = Convert.ToInt32(txtKitapSayisi.Text);
            int yazarNo = Convert.ToInt32(cmbYazarNo.Text);
            int yayimEviNo = Convert.ToInt32(cmbYayınEviNo.Text);
            string sql = "INSERT INTO kitap (kitapAdi,sayfaSayisi,yazarNo,yayimEviNo) VALUES ('" + kitapAd + "','" + kitapSayfaSayisi + "','" + yazarNo + "','" + yayimEviNo + "')";
            if (kitapAd == "")
            {
                MessageBox.Show("Eksiksiz Giriş Yapınız.");
            }
            else
            {

                SqlCommand cmd = new SqlCommand(sql, baglanti);
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kitap Eklenmiştir.");
                txtKitapAdi.Text = "";
                txtKitapSayisi.Text = "";
            }
        }

        private void txtKitapSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btnKitaplarıGoster_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("KITAPLAR", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dr.Fill(ds, "kitaplarSTOREDprocedure");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnUyeGoster_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UYELISTESI", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dr.Fill(ds,"UYELISTESI");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnİslemEkle_Click(object sender, EventArgs e)
        {
            string tarih = dateTimePicker1.Value.ToString();
            int uyeno = Convert.ToInt32(cmbUyeGetirNo.Text);
            int kitapno = Convert.ToInt32(cmbKitapNo.Text);

            string sql = "INSERT INTO islem (kitapNo,alisTarihi,uyeNo) VALUES ('" + kitapno + "','" + tarih + "','" + uyeno + "')";

            SqlCommand cmd = new SqlCommand(sql, baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(uyeno +" Numaralı üyeye "+kitapno+" numaralı kitap "+tarih+" tarihinde verilmiştir.");
        }

        private void groupBox6_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tarih = dateTimePicker2.Value.ToString();
            int islemno = Convert.ToInt32(cmbİslemNo.Text);

            string sql = "UPDATE islem SET veristarihi= '"+tarih+"' WHERE islemNo="+islemno+"";

            SqlCommand cmd = new SqlCommand(sql, baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(islemno + " Numaralı islem " + tarih + " tarihinde teslim alınmıştır.");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            baslat();
            
        }
    }
}
