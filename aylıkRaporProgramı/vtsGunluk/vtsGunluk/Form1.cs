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

namespace vtsGunluk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-60IS5FR;Initial Catalog=gunluk;Integrated Security=True");

        private void txtAyGirdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtYilGirdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAyCikti_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtYilCikti_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tablogoster();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtGiris.Text == "" || cmbGiris.Text == "" || txtAyGirdi.Text == "" || txtYilGirdi.Text == "")
            {
                MessageBox.Show("eksik giriş yaptınız.");
            }
            else
            {
                int ay = Convert.ToInt32(txtAyGirdi.Text), yil = Convert.ToInt32(txtYilGirdi.Text);
                string gun = cmbGiris.Text.ToString();
                string yazi = txtGiris.Text;
                string sql = "INSERT INTO " + gun + " (yazi,ay,yil) VALUES ('" + yazi + "','" + ay + "','" + yil + "')";

                SqlCommand cmd = new SqlCommand(sql, baglanti);
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                cmd.ExecuteNonQuery();
                baglanti.Close();
            }
            
           
        }

        private void cmbGoruntuleme_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        DataTable tablodegistir()
        {
             string gun = cmbGoruntuleme.Text.ToString();

            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM "+gun+"", baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        DataTable tablogoster()
        {
        int ay = Convert.ToInt32(txtAyCikti.Text), yil = Convert.ToInt32(txtYilCikti.Text);
        string gun = cmbGoruntuleme.Text.ToString();

        DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM " + gun + " WHERE ay = '" + ay + "' AND yil = '" + yil + "' ", baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt32(txtAyCikti.Text), yil = Convert.ToInt32(txtYilCikti.Text);
            string gun = cmbGoruntuleme.Text.ToString();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from "+gun+" where ay="+ay+" and yil="+yil+"", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silinmiştir.");
            dataGridView1.DataSource = tablodegistir();
        }

        private void btnGosterHepsi_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("TUMBILGILERIGETIR", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dr.Fill(ds, "TumGirdiler");
            dataGridView1.DataSource = ds.Tables[0];
            
            
        }

    }
     
}
