namespace taslak
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbYayınEviNo = new System.Windows.Forms.ComboBox();
            this.cmbYazarNo = new System.Windows.Forms.ComboBox();
            this.txtKitapSayisi = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtYayinEviAdi = new System.Windows.Forms.TextBox();
            this.btnYayinEviEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUyeSoyadi = new System.Windows.Forms.TextBox();
            this.txtUyeAdi = new System.Windows.Forms.TextBox();
            this.btUyeEkle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbUyeNo = new System.Windows.Forms.ComboBox();
            this.btnUyeSil = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtYazarSoyad = new System.Windows.Forms.TextBox();
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnYazarEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUyeGoster = new System.Windows.Forms.Button();
            this.btnKitaplarıGoster = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cmbUyeGetirNo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbKitapNo = new System.Windows.Forms.ComboBox();
            this.btnİslemEkle = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cmbİslemNo = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbYayınEviNo);
            this.groupBox1.Controls.Add(this.cmbYazarNo);
            this.groupBox1.Controls.Add(this.txtKitapSayisi);
            this.groupBox1.Controls.Add(this.txtKitapAdi);
            this.groupBox1.Controls.Add(this.btnKitapEkle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Ekle";
            // 
            // cmbYayınEviNo
            // 
            this.cmbYayınEviNo.FormattingEnabled = true;
            this.cmbYayınEviNo.Location = new System.Drawing.Point(96, 119);
            this.cmbYayınEviNo.Name = "cmbYayınEviNo";
            this.cmbYayınEviNo.Size = new System.Drawing.Size(100, 21);
            this.cmbYayınEviNo.TabIndex = 12;
            // 
            // cmbYazarNo
            // 
            this.cmbYazarNo.FormattingEnabled = true;
            this.cmbYazarNo.Location = new System.Drawing.Point(96, 93);
            this.cmbYazarNo.Name = "cmbYazarNo";
            this.cmbYazarNo.Size = new System.Drawing.Size(100, 21);
            this.cmbYazarNo.TabIndex = 11;
            // 
            // txtKitapSayisi
            // 
            this.txtKitapSayisi.Location = new System.Drawing.Point(96, 61);
            this.txtKitapSayisi.Name = "txtKitapSayisi";
            this.txtKitapSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtKitapSayisi.TabIndex = 8;
            this.txtKitapSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKitapSayisi_KeyPress);
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(96, 26);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKitapAdi.TabIndex = 7;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(96, 149);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKitapEkle.TabIndex = 5;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "YayınEvi No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yazar No : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sayfa Sayısı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPlaka);
            this.groupBox2.Controls.Add(this.txtYayinEviAdi);
            this.groupBox2.Controls.Add(this.btnYayinEviEkle);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(231, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 178);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "YayınEvi Ekle";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(83, 87);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(100, 20);
            this.txtPlaka.TabIndex = 13;
            // 
            // txtYayinEviAdi
            // 
            this.txtYayinEviAdi.Location = new System.Drawing.Point(83, 48);
            this.txtYayinEviAdi.Name = "txtYayinEviAdi";
            this.txtYayinEviAdi.Size = new System.Drawing.Size(100, 20);
            this.txtYayinEviAdi.TabIndex = 12;
            // 
            // btnYayinEviEkle
            // 
            this.btnYayinEviEkle.Location = new System.Drawing.Point(47, 121);
            this.btnYayinEviEkle.Name = "btnYayinEviEkle";
            this.btnYayinEviEkle.Size = new System.Drawing.Size(93, 23);
            this.btnYayinEviEkle.TabIndex = 6;
            this.btnYayinEviEkle.Text = "YayınEvi Ekle";
            this.btnYayinEviEkle.UseVisualStyleBackColor = true;
            this.btnYayinEviEkle.Click += new System.EventHandler(this.btnYayinEviEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "YayınEvi Adı : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "İL Plakası : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtUyeSoyadi);
            this.groupBox3.Controls.Add(this.txtUyeAdi);
            this.groupBox3.Controls.Add(this.btUyeEkle);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(5, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 150);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Üye Ekle";
            // 
            // txtUyeSoyadi
            // 
            this.txtUyeSoyadi.Location = new System.Drawing.Point(86, 71);
            this.txtUyeSoyadi.Name = "txtUyeSoyadi";
            this.txtUyeSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtUyeSoyadi.TabIndex = 8;
            // 
            // txtUyeAdi
            // 
            this.txtUyeAdi.Location = new System.Drawing.Point(86, 35);
            this.txtUyeAdi.Name = "txtUyeAdi";
            this.txtUyeAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUyeAdi.TabIndex = 7;
            // 
            // btUyeEkle
            // 
            this.btUyeEkle.Location = new System.Drawing.Point(86, 106);
            this.btUyeEkle.Name = "btUyeEkle";
            this.btUyeEkle.Size = new System.Drawing.Size(75, 23);
            this.btUyeEkle.TabIndex = 6;
            this.btUyeEkle.Text = "Üye Ekle";
            this.btUyeEkle.UseVisualStyleBackColor = true;
            this.btUyeEkle.Click += new System.EventHandler(this.btUyeEkle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Üye Soyadı : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Üye  Adı : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbUyeNo);
            this.groupBox4.Controls.Add(this.btnUyeSil);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(231, 229);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 150);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Üye Sil";
            // 
            // cmbUyeNo
            // 
            this.cmbUyeNo.FormattingEnabled = true;
            this.cmbUyeNo.Location = new System.Drawing.Point(65, 32);
            this.cmbUyeNo.Name = "cmbUyeNo";
            this.cmbUyeNo.Size = new System.Drawing.Size(100, 21);
            this.cmbUyeNo.TabIndex = 10;
            // 
            // btnUyeSil
            // 
            this.btnUyeSil.Location = new System.Drawing.Point(65, 106);
            this.btnUyeSil.Name = "btnUyeSil";
            this.btnUyeSil.Size = new System.Drawing.Size(75, 23);
            this.btnUyeSil.TabIndex = 7;
            this.btnUyeSil.Text = "Üye Sil";
            this.btnUyeSil.UseVisualStyleBackColor = true;
            this.btnUyeSil.Click += new System.EventHandler(this.btnUyeSil_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Üye  No : ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtYazarSoyad);
            this.groupBox5.Controls.Add(this.txtYazarAd);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.btnYazarEkle);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(437, 44);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(254, 178);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Yazar Ekle";
            // 
            // txtYazarSoyad
            // 
            this.txtYazarSoyad.Location = new System.Drawing.Point(76, 80);
            this.txtYazarSoyad.Name = "txtYazarSoyad";
            this.txtYazarSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtYazarSoyad.TabIndex = 13;
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.Location = new System.Drawing.Point(76, 44);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(100, 20);
            this.txtYazarAd.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Yazar Adı : ";
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.Location = new System.Drawing.Point(76, 115);
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(75, 23);
            this.btnYazarEkle.TabIndex = 11;
            this.btnYazarEkle.Text = "Yazar Ekle";
            this.btnYazarEkle.UseVisualStyleBackColor = true;
            this.btnYazarEkle.Click += new System.EventHandler(this.btnYazarEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Yazar Soyadı : ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Controls.Add(this.btnUyeGoster);
            this.groupBox6.Controls.Add(this.btnKitaplarıGoster);
            this.groupBox6.Location = new System.Drawing.Point(5, 385);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(426, 183);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Görüntüleme Merkezi";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(309, 151);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnUyeGoster
            // 
            this.btnUyeGoster.Location = new System.Drawing.Point(321, 104);
            this.btnUyeGoster.Name = "btnUyeGoster";
            this.btnUyeGoster.Size = new System.Drawing.Size(99, 45);
            this.btnUyeGoster.TabIndex = 1;
            this.btnUyeGoster.Text = "Uyeleri Göster (STORED PROC)";
            this.btnUyeGoster.UseVisualStyleBackColor = true;
            this.btnUyeGoster.Click += new System.EventHandler(this.btnUyeGoster_Click);
            // 
            // btnKitaplarıGoster
            // 
            this.btnKitaplarıGoster.Location = new System.Drawing.Point(321, 37);
            this.btnKitaplarıGoster.Name = "btnKitaplarıGoster";
            this.btnKitaplarıGoster.Size = new System.Drawing.Size(99, 45);
            this.btnKitaplarıGoster.TabIndex = 0;
            this.btnKitaplarıGoster.Text = "Kitap Göster (STORED PROC)";
            this.btnKitaplarıGoster.UseVisualStyleBackColor = true;
            this.btnKitaplarıGoster.Click += new System.EventHandler(this.btnKitaplarıGoster_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cmbUyeGetirNo);
            this.groupBox7.Controls.Add(this.dateTimePicker1);
            this.groupBox7.Controls.Add(this.cmbKitapNo);
            this.groupBox7.Controls.Add(this.btnİslemEkle);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Location = new System.Drawing.Point(437, 229);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(254, 150);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Kitap Alım";
            // 
            // cmbUyeGetirNo
            // 
            this.cmbUyeGetirNo.FormattingEnabled = true;
            this.cmbUyeGetirNo.Location = new System.Drawing.Point(76, 16);
            this.cmbUyeGetirNo.Name = "cmbUyeGetirNo";
            this.cmbUyeGetirNo.Size = new System.Drawing.Size(121, 21);
            this.cmbUyeGetirNo.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // cmbKitapNo
            // 
            this.cmbKitapNo.FormattingEnabled = true;
            this.cmbKitapNo.Location = new System.Drawing.Point(76, 42);
            this.cmbKitapNo.Name = "cmbKitapNo";
            this.cmbKitapNo.Size = new System.Drawing.Size(121, 21);
            this.cmbKitapNo.TabIndex = 5;
            // 
            // btnİslemEkle
            // 
            this.btnİslemEkle.Location = new System.Drawing.Point(76, 106);
            this.btnİslemEkle.Name = "btnİslemEkle";
            this.btnİslemEkle.Size = new System.Drawing.Size(91, 23);
            this.btnİslemEkle.TabIndex = 4;
            this.btnİslemEkle.Text = "Kitap Alım Ekle";
            this.btnİslemEkle.UseVisualStyleBackColor = true;
            this.btnİslemEkle.Click += new System.EventHandler(this.btnİslemEkle_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Üye No : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Alış Tarihi : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap No : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Veriş Tarihi : ";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button1);
            this.groupBox8.Controls.Add(this.dateTimePicker2);
            this.groupBox8.Controls.Add(this.cmbİslemNo);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Location = new System.Drawing.Point(437, 385);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(254, 183);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Kitap Teslim";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Güncelle (Teslim Al)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(77, 96);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // cmbİslemNo
            // 
            this.cmbİslemNo.FormattingEnabled = true;
            this.cmbİslemNo.Location = new System.Drawing.Point(77, 66);
            this.cmbİslemNo.Name = "cmbİslemNo";
            this.cmbİslemNo.Size = new System.Drawing.Size(121, 21);
            this.cmbİslemNo.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "İşlem No : ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(565, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 25);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Yenile";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(701, 574);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnYayinEviEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtKitapSayisi;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtYayinEviAdi;
        private System.Windows.Forms.TextBox txtUyeSoyadi;
        private System.Windows.Forms.TextBox txtUyeAdi;
        private System.Windows.Forms.Button btUyeEkle;
        private System.Windows.Forms.Button btnUyeSil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtYazarSoyad;
        private System.Windows.Forms.TextBox txtYazarAd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnYazarEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbYazarNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbYayınEviNo;
        private System.Windows.Forms.ComboBox cmbUyeNo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUyeGoster;
        private System.Windows.Forms.Button btnKitaplarıGoster;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cmbKitapNo;
        private System.Windows.Forms.Button btnİslemEkle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbUyeGetirNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cmbİslemNo;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

