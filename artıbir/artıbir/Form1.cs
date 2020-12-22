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

namespace artıbir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-60IS5FR;Initial Catalog=artibir;Integrated Security=True");

        private void verileriGöster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from artibirtablosu",baglan);
            SqlDataReader oku = komut.ExecuteReader();
            
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku ["kisi"].ToString();
                ekle.SubItems.Add(oku["sebep"].ToString());
                ekle.SubItems.Add(oku["tarih"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void batucheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (batucheckbox.Checked == true)
            {
                mislinacheckbox.Checked = false;
                kisi = "Batuhan";
            }
                
        }

        private void mislinacheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (mislinacheckbox.Checked == true)
            {
                batucheckbox.Checked = false;
                kisi = "Mislina";
            }
                
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Application.Exit();
        }
        string kisi;
        string sebepmetni;
        string tarih;
        

        private void eklebtn_Click(object sender, EventArgs e)
        {

            sebepmetni =textBox1.Text;
            tarih= maskedTextBox1.Text.ToString();

            if (baglan.State == ConnectionState.Open)
                baglan.Close();

            baglan.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO artibirtablosu (kisi,sebep,tarih) VALUES ('"+kisi+"','"+sebepmetni+"','"+tarih+"') ",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            kisi = "";
            sebepmetni = "";
            tarih = "";

            batucheckbox.Checked = false;
            mislinacheckbox.Checked = false;
            MessageBox.Show("Eklendi.");
            maskedTextBox1.Text = "";
            textBox1.Text = "";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            verileriGöster();
        }
    }
}
