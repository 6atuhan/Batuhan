namespace vtsGunluk
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
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.cmbGiris = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYilGirdi = new System.Windows.Forms.TextBox();
            this.txtAyGirdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGosterHepsi = new System.Windows.Forms.Button();
            this.txtYilCikti = new System.Windows.Forms.TextBox();
            this.txtAyCikti = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.cmbGoruntuleme = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(12, 19);
            this.txtGiris.Multiline = true;
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(417, 140);
            this.txtGiris.TabIndex = 0;
            // 
            // cmbGiris
            // 
            this.cmbGiris.FormattingEnabled = true;
            this.cmbGiris.Items.AddRange(new object[] {
            "pazartesi",
            "sali",
            "carsamba",
            "persembe",
            "cuma",
            "cumartesi",
            "pazar"});
            this.cmbGiris.Location = new System.Drawing.Point(435, 34);
            this.cmbGiris.Name = "cmbGiris";
            this.cmbGiris.Size = new System.Drawing.Size(121, 21);
            this.cmbGiris.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(432, 136);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(121, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYilGirdi);
            this.groupBox1.Controls.Add(this.txtAyGirdi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbGiris);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtGiris);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yazı";
            // 
            // txtYilGirdi
            // 
            this.txtYilGirdi.Location = new System.Drawing.Point(493, 97);
            this.txtYilGirdi.Name = "txtYilGirdi";
            this.txtYilGirdi.Size = new System.Drawing.Size(34, 20);
            this.txtYilGirdi.TabIndex = 8;
            this.txtYilGirdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYilGirdi_KeyPress);
            // 
            // txtAyGirdi
            // 
            this.txtAyGirdi.Location = new System.Drawing.Point(493, 69);
            this.txtAyGirdi.Name = "txtAyGirdi";
            this.txtAyGirdi.Size = new System.Drawing.Size(34, 20);
            this.txtAyGirdi.TabIndex = 7;
            this.txtAyGirdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAyGirdi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Yıl Girin : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ay Girin : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gün Seçin : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGosterHepsi);
            this.groupBox2.Controls.Add(this.txtYilCikti);
            this.groupBox2.Controls.Add(this.txtAyCikti);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnGoruntule);
            this.groupBox2.Controls.Add(this.cmbGoruntuleme);
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 205);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Görüntüleme";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnGosterHepsi
            // 
            this.btnGosterHepsi.Location = new System.Drawing.Point(432, 19);
            this.btnGosterHepsi.Name = "btnGosterHepsi";
            this.btnGosterHepsi.Size = new System.Drawing.Size(124, 26);
            this.btnGosterHepsi.TabIndex = 12;
            this.btnGosterHepsi.Text = "Hepsini Göster SP";
            this.btnGosterHepsi.UseVisualStyleBackColor = true;
            this.btnGosterHepsi.Click += new System.EventHandler(this.btnGosterHepsi_Click);
            // 
            // txtYilCikti
            // 
            this.txtYilCikti.Location = new System.Drawing.Point(509, 118);
            this.txtYilCikti.Name = "txtYilCikti";
            this.txtYilCikti.Size = new System.Drawing.Size(34, 20);
            this.txtYilCikti.TabIndex = 10;
            this.txtYilCikti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYilCikti_KeyPress);
            // 
            // txtAyCikti
            // 
            this.txtAyCikti.Location = new System.Drawing.Point(509, 94);
            this.txtAyCikti.Name = "txtAyCikti";
            this.txtAyCikti.Size = new System.Drawing.Size(34, 20);
            this.txtAyCikti.TabIndex = 9;
            this.txtAyCikti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAyCikti_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Yıl Girin : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ay Girin : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gün Seçin : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 177);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Location = new System.Drawing.Point(435, 144);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(121, 23);
            this.btnGoruntule.TabIndex = 1;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // cmbGoruntuleme
            // 
            this.cmbGoruntuleme.FormattingEnabled = true;
            this.cmbGoruntuleme.Items.AddRange(new object[] {
            "pazartesi",
            "sali",
            "carsamba",
            "persembe",
            "cuma",
            "cumartesi",
            "pazar"});
            this.cmbGoruntuleme.Location = new System.Drawing.Point(432, 68);
            this.cmbGoruntuleme.Name = "cmbGoruntuleme";
            this.cmbGoruntuleme.Size = new System.Drawing.Size(121, 21);
            this.cmbGoruntuleme.TabIndex = 0;
            this.cmbGoruntuleme.SelectedIndexChanged += new System.EventHandler(this.cmbGoruntuleme_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(447, 373);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 23);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 410);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.ComboBox cmbGiris;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.ComboBox cmbGoruntuleme;
        private System.Windows.Forms.TextBox txtYilGirdi;
        private System.Windows.Forms.TextBox txtAyGirdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYilCikti;
        private System.Windows.Forms.TextBox txtAyCikti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGosterHepsi;
    }
}

