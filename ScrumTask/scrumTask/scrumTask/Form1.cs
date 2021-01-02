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

namespace scrumTask
{
    public partial class TaskADD : Form
    {
        public TaskADD()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-60IS5FR;Initial Catalog=scrumtaskdb;Integrated Security=True");

        int kartnotemp;
        private void TaskADD_Load(object sender, EventArgs e)
        {
            listeleme();
            kartnobulma();
            txtTahminTarih.Text = ortalamahesapla().ToString()+" gün";

        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {

            isler is1 = new isler();
            
            is1.projeno = txtProjeNo.Text;
            is1.teknikuzman = txtTeknikUzman.Text;
            is1.tarih = mtxtTarih.Text.ToString();
            is1.gerceklesensure = txtGerceklesenSure.Text;
            is1.aciklama = txtIsAciklamasi.Text;
            is1.notlar = txtNotlar.Text;

            
            

            if (baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO scrumTablo(projeno,teknikuzman,tarih,gerceklesensure,isaciklamasi,notlar) VALUES('" + is1.projeno + "','" + is1.teknikuzman + "','" + is1.tarih + "','" + is1.gerceklesensure + "','" + is1.aciklama + "','" + is1.notlar + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                projelisteleme(is1.projeno);
                MessageBox.Show("İş Eklendi.");
                kartnotemp++;
                txtKartNo.Text = kartnotemp.ToString();
                
                txtTahminTarih.Text = ortalamahesapla().ToString()+" gün";


            }
            
        }
        void listeleme()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from scrumTablo";
                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adptr.Fill(ds, "scrumTablo");
                dataGridView1.DataSource = ds.Tables["scrumTablo"];
                baglanti.Close();
            }
        }


        void projelisteleme(string tempno)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from scrumTablo where projeno ='" + tempno + "' ", baglanti);
                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adptr.Fill(ds, "scrumTablo");
                dataGridView1.DataSource = ds.Tables["scrumTablo"];
                baglanti.Close();

            }
        }
        void kartnobulma()
        {
           int i;

            i = dataGridView1.Rows.Count;
            kartnotemp = i;
            txtKartNo.Text=i.ToString();


        }
        public double ortalamahesapla()
        {
            int i=0;
            double sayi=0,toplam=0,ortalama;
            i = dataGridView1.Rows.Count;
            for(int a =0;a<i;a++)
            {
                sayi = Convert.ToInt32(dataGridView1.Rows[a].Cells[3].Value);
                 toplam = toplam + sayi;
            }
            ortalama = toplam / i;
            ortalama=Math.Round(ortalama, 2);
            return ortalama;
        }

        private void txtTeknikUzman_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtIsAciklamasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNotlar_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtGerceklesenSure_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mtxtTarih_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtProjeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
