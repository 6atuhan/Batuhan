namespace NYP_AJANS_PROJE
{
    partial class AJANS
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
            this.btnGiris = new System.Windows.Forms.Button();
            this.txbxID = new System.Windows.Forms.TextBox();
            this.txbxSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btbCikis = new System.Windows.Forms.Button();
            this.lblKim = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOyuncuAdı = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOyuncuEkle = new System.Windows.Forms.Button();
            this.cbBrans = new System.Windows.Forms.ComboBox();
            this.gbOyuncuİşlem = new System.Windows.Forms.GroupBox();
            this.txtFirma = new System.Windows.Forms.ComboBox();
            this.lblOdenek = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOdenek = new System.Windows.Forms.TextBox();
            this.txtOyuncuNo = new System.Windows.Forms.TextBox();
            this.btnIsEkle = new System.Windows.Forms.Button();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.txtBitis = new System.Windows.Forms.TextBox();
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.txtIs = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOyuncuSil = new System.Windows.Forms.Button();
            this.listboxOyuncuListesi = new System.Windows.Forms.ListBox();
            this.gbMaaliisler = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBilanco = new System.Windows.Forms.Label();
            this.gbFirmaEkle = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFirmaSehri = new System.Windows.Forms.TextBox();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.btnFirmaEkle = new System.Windows.Forms.Button();
            this.btnFirmaGoster = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.gbOyuncuİşlem.SuspendLayout();
            this.gbMaaliisler.SuspendLayout();
            this.gbFirmaEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(98, 109);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 29);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txbxID
            // 
            this.txbxID.Location = new System.Drawing.Point(131, 26);
            this.txbxID.Name = "txbxID";
            this.txbxID.Size = new System.Drawing.Size(100, 26);
            this.txbxID.TabIndex = 1;
            // 
            // txbxSifre
            // 
            this.txbxSifre.Location = new System.Drawing.Point(131, 67);
            this.txbxSifre.Name = "txbxSifre";
            this.txbxSifre.Size = new System.Drawing.Size(100, 26);
            this.txbxSifre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre : ";
            // 
            // btbCikis
            // 
            this.btbCikis.Location = new System.Drawing.Point(624, 12);
            this.btbCikis.Name = "btbCikis";
            this.btbCikis.Size = new System.Drawing.Size(75, 27);
            this.btbCikis.TabIndex = 5;
            this.btbCikis.Text = "Çıkış";
            this.btbCikis.UseVisualStyleBackColor = true;
            this.btbCikis.Click += new System.EventHandler(this.btbCikis_Click);
            // 
            // lblKim
            // 
            this.lblKim.AutoSize = true;
            this.lblKim.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKim.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKim.Location = new System.Drawing.Point(-1, -1);
            this.lblKim.Name = "lblKim";
            this.lblKim.Size = new System.Drawing.Size(0, 34);
            this.lblKim.TabIndex = 6;
            this.lblKim.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Oyuncu Listesi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Oyuncu Ekle";
            // 
            // txtOyuncuAdı
            // 
            this.txtOyuncuAdı.Location = new System.Drawing.Point(126, 47);
            this.txtOyuncuAdı.Name = "txtOyuncuAdı";
            this.txtOyuncuAdı.Size = new System.Drawing.Size(120, 26);
            this.txtOyuncuAdı.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Oyuncu Adı : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Oyuncu Branşı : ";
            // 
            // btnOyuncuEkle
            // 
            this.btnOyuncuEkle.Location = new System.Drawing.Point(252, 47);
            this.btnOyuncuEkle.Name = "btnOyuncuEkle";
            this.btnOyuncuEkle.Size = new System.Drawing.Size(75, 59);
            this.btnOyuncuEkle.TabIndex = 16;
            this.btnOyuncuEkle.Text = "Oyuncu Ekle";
            this.btnOyuncuEkle.UseVisualStyleBackColor = true;
            this.btnOyuncuEkle.Click += new System.EventHandler(this.btnOyuncuEkle_Click);
            // 
            // cbBrans
            // 
            this.cbBrans.FormattingEnabled = true;
            this.cbBrans.Items.AddRange(new object[] {
            "Sinema",
            "Reklam",
            "Sesli Radyo"});
            this.cbBrans.Location = new System.Drawing.Point(125, 79);
            this.cbBrans.Name = "cbBrans";
            this.cbBrans.Size = new System.Drawing.Size(121, 27);
            this.cbBrans.TabIndex = 17;
            // 
            // gbOyuncuİşlem
            // 
            this.gbOyuncuİşlem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbOyuncuİşlem.Controls.Add(this.txtFirma);
            this.gbOyuncuİşlem.Controls.Add(this.lblOdenek);
            this.gbOyuncuİşlem.Controls.Add(this.label9);
            this.gbOyuncuİşlem.Controls.Add(this.txtOdenek);
            this.gbOyuncuİşlem.Controls.Add(this.txtOyuncuNo);
            this.gbOyuncuİşlem.Controls.Add(this.btnIsEkle);
            this.gbOyuncuİşlem.Controls.Add(this.txtMaas);
            this.gbOyuncuİşlem.Controls.Add(this.txtBitis);
            this.gbOyuncuİşlem.Controls.Add(this.txtGiris);
            this.gbOyuncuİşlem.Controls.Add(this.txtIs);
            this.gbOyuncuİşlem.Controls.Add(this.label12);
            this.gbOyuncuİşlem.Controls.Add(this.label11);
            this.gbOyuncuİşlem.Controls.Add(this.label10);
            this.gbOyuncuİşlem.Controls.Add(this.txt);
            this.gbOyuncuİşlem.Controls.Add(this.label8);
            this.gbOyuncuİşlem.Controls.Add(this.label7);
            this.gbOyuncuİşlem.Controls.Add(this.btnOyuncuSil);
            this.gbOyuncuİşlem.Controls.Add(this.listboxOyuncuListesi);
            this.gbOyuncuİşlem.Controls.Add(this.label4);
            this.gbOyuncuİşlem.Controls.Add(this.cbBrans);
            this.gbOyuncuİşlem.Controls.Add(this.btnOyuncuEkle);
            this.gbOyuncuİşlem.Controls.Add(this.label3);
            this.gbOyuncuİşlem.Controls.Add(this.label6);
            this.gbOyuncuİşlem.Controls.Add(this.label5);
            this.gbOyuncuİşlem.Controls.Add(this.txtOyuncuAdı);
            this.gbOyuncuİşlem.Location = new System.Drawing.Point(12, 55);
            this.gbOyuncuİşlem.Name = "gbOyuncuİşlem";
            this.gbOyuncuİşlem.Size = new System.Drawing.Size(392, 447);
            this.gbOyuncuİşlem.TabIndex = 18;
            this.gbOyuncuİşlem.TabStop = false;
            this.gbOyuncuİşlem.Text = "Oyuncu İşlemi";
            this.gbOyuncuİşlem.Visible = false;
            // 
            // txtFirma
            // 
            this.txtFirma.FormattingEnabled = true;
            this.txtFirma.Location = new System.Drawing.Point(80, 329);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(101, 27);
            this.txtFirma.TabIndex = 36;
            // 
            // lblOdenek
            // 
            this.lblOdenek.AutoSize = true;
            this.lblOdenek.Location = new System.Drawing.Point(8, 416);
            this.lblOdenek.Name = "lblOdenek";
            this.lblOdenek.Size = new System.Drawing.Size(0, 19);
            this.lblOdenek.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "Ödenek : ";
            // 
            // txtOdenek
            // 
            this.txtOdenek.Location = new System.Drawing.Point(266, 324);
            this.txtOdenek.Name = "txtOdenek";
            this.txtOdenek.Size = new System.Drawing.Size(100, 26);
            this.txtOdenek.TabIndex = 33;
            // 
            // txtOyuncuNo
            // 
            this.txtOyuncuNo.Location = new System.Drawing.Point(80, 262);
            this.txtOyuncuNo.Name = "txtOyuncuNo";
            this.txtOyuncuNo.Size = new System.Drawing.Size(100, 26);
            this.txtOyuncuNo.TabIndex = 32;
            this.txtOyuncuNo.Text = "Oyuncu No";
            this.txtOyuncuNo.Click += new System.EventHandler(this.txtOyuncuNo_Click);
            // 
            // btnIsEkle
            // 
            this.btnIsEkle.Location = new System.Drawing.Point(186, 361);
            this.btnIsEkle.Name = "btnIsEkle";
            this.btnIsEkle.Size = new System.Drawing.Size(160, 26);
            this.btnIsEkle.TabIndex = 31;
            this.btnIsEkle.Text = "EKLE";
            this.btnIsEkle.UseVisualStyleBackColor = true;
            this.btnIsEkle.Click += new System.EventHandler(this.btnIsEkle_Click);
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(266, 294);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(100, 26);
            this.txtMaas.TabIndex = 30;
            // 
            // txtBitis
            // 
            this.txtBitis.Location = new System.Drawing.Point(266, 265);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(100, 26);
            this.txtBitis.TabIndex = 29;
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(80, 360);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(100, 26);
            this.txtGiris.TabIndex = 28;
            // 
            // txtIs
            // 
            this.txtIs.Location = new System.Drawing.Point(80, 298);
            this.txtIs.Name = "txtIs";
            this.txtIs.Size = new System.Drawing.Size(100, 26);
            this.txtIs.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "Firma : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(187, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "Maaş : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(187, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "İşi Bitiriş : ";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(6, 361);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(82, 19);
            this.txt.TabIndex = 22;
            this.txt.Text = "İşe Giriş : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "İşi : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(7, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 27);
            this.label7.TabIndex = 20;
            this.label7.Text = "İş Ekle";
            // 
            // btnOyuncuSil
            // 
            this.btnOyuncuSil.Location = new System.Drawing.Point(6, 227);
            this.btnOyuncuSil.Name = "btnOyuncuSil";
            this.btnOyuncuSil.Size = new System.Drawing.Size(210, 29);
            this.btnOyuncuSil.TabIndex = 19;
            this.btnOyuncuSil.Text = "Oyuncu Sil";
            this.btnOyuncuSil.UseVisualStyleBackColor = true;
            this.btnOyuncuSil.Click += new System.EventHandler(this.btnOyuncuSil_Click);
            // 
            // listboxOyuncuListesi
            // 
            this.listboxOyuncuListesi.FormattingEnabled = true;
            this.listboxOyuncuListesi.ItemHeight = 19;
            this.listboxOyuncuListesi.Location = new System.Drawing.Point(6, 141);
            this.listboxOyuncuListesi.Name = "listboxOyuncuListesi";
            this.listboxOyuncuListesi.Size = new System.Drawing.Size(338, 80);
            this.listboxOyuncuListesi.TabIndex = 18;
            // 
            // gbMaaliisler
            // 
            this.gbMaaliisler.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbMaaliisler.Controls.Add(this.button1);
            this.gbMaaliisler.Controls.Add(this.lblBilanco);
            this.gbMaaliisler.Location = new System.Drawing.Point(404, 55);
            this.gbMaaliisler.Name = "gbMaaliisler";
            this.gbMaaliisler.Size = new System.Drawing.Size(301, 215);
            this.gbMaaliisler.TabIndex = 19;
            this.gbMaaliisler.TabStop = false;
            this.gbMaaliisler.Tag = "";
            this.gbMaaliisler.Text = "Maliye";
            this.gbMaaliisler.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bilanço";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBilanco
            // 
            this.lblBilanco.AutoSize = true;
            this.lblBilanco.Location = new System.Drawing.Point(6, 34);
            this.lblBilanco.Name = "lblBilanco";
            this.lblBilanco.Size = new System.Drawing.Size(127, 19);
            this.lblBilanco.TabIndex = 0;
            this.lblBilanco.Text = "Gelir Giderlerimiz.";
            // 
            // gbFirmaEkle
            // 
            this.gbFirmaEkle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbFirmaEkle.Controls.Add(this.label15);
            this.gbFirmaEkle.Controls.Add(this.btnFirmaGoster);
            this.gbFirmaEkle.Controls.Add(this.label14);
            this.gbFirmaEkle.Controls.Add(this.label13);
            this.gbFirmaEkle.Controls.Add(this.txtFirmaSehri);
            this.gbFirmaEkle.Controls.Add(this.txtFirmaAdi);
            this.gbFirmaEkle.Controls.Add(this.btnFirmaEkle);
            this.gbFirmaEkle.Location = new System.Drawing.Point(404, 269);
            this.gbFirmaEkle.Name = "gbFirmaEkle";
            this.gbFirmaEkle.Size = new System.Drawing.Size(301, 233);
            this.gbFirmaEkle.TabIndex = 20;
            this.gbFirmaEkle.TabStop = false;
            this.gbFirmaEkle.Text = "Firma Ekle";
            this.gbFirmaEkle.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "Firma Şehri : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Firma Adı : ";
            // 
            // txtFirmaSehri
            // 
            this.txtFirmaSehri.Location = new System.Drawing.Point(130, 57);
            this.txtFirmaSehri.Name = "txtFirmaSehri";
            this.txtFirmaSehri.Size = new System.Drawing.Size(100, 26);
            this.txtFirmaSehri.TabIndex = 2;
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Location = new System.Drawing.Point(130, 25);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(100, 26);
            this.txtFirmaAdi.TabIndex = 1;
            // 
            // btnFirmaEkle
            // 
            this.btnFirmaEkle.Location = new System.Drawing.Point(130, 88);
            this.btnFirmaEkle.Name = "btnFirmaEkle";
            this.btnFirmaEkle.Size = new System.Drawing.Size(100, 26);
            this.btnFirmaEkle.TabIndex = 0;
            this.btnFirmaEkle.Text = "Firma Ekle";
            this.btnFirmaEkle.UseVisualStyleBackColor = true;
            this.btnFirmaEkle.Click += new System.EventHandler(this.btnFirmaEkle_Click);
            // 
            // btnFirmaGoster
            // 
            this.btnFirmaGoster.Location = new System.Drawing.Point(172, 196);
            this.btnFirmaGoster.Name = "btnFirmaGoster";
            this.btnFirmaGoster.Size = new System.Drawing.Size(123, 31);
            this.btnFirmaGoster.TabIndex = 5;
            this.btnFirmaGoster.Text = "Firmaları Göster";
            this.btnFirmaGoster.UseVisualStyleBackColor = true;
            this.btnFirmaGoster.Click += new System.EventHandler(this.btnFirmaGoster_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 19);
            this.label15.TabIndex = 6;
            this.label15.Text = "label15";
            // 
            // AJANS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 491);
            this.Controls.Add(this.gbFirmaEkle);
            this.Controls.Add(this.gbMaaliisler);
            this.Controls.Add(this.gbOyuncuİşlem);
            this.Controls.Add(this.lblKim);
            this.Controls.Add(this.btbCikis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbxSifre);
            this.Controls.Add(this.txbxID);
            this.Controls.Add(this.btnGiris);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AJANS";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AJANS_Load);
            this.gbOyuncuİşlem.ResumeLayout(false);
            this.gbOyuncuİşlem.PerformLayout();
            this.gbMaaliisler.ResumeLayout(false);
            this.gbMaaliisler.PerformLayout();
            this.gbFirmaEkle.ResumeLayout(false);
            this.gbFirmaEkle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txbxID;
        private System.Windows.Forms.TextBox txbxSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btbCikis;
        private System.Windows.Forms.Label lblKim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOyuncuAdı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOyuncuEkle;
        private System.Windows.Forms.ComboBox cbBrans;
        private System.Windows.Forms.GroupBox gbOyuncuİşlem;
        private System.Windows.Forms.ListBox listboxOyuncuListesi;
        private System.Windows.Forms.Button btnOyuncuSil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.TextBox txtBitis;
        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.TextBox txtIs;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnIsEkle;
        private System.Windows.Forms.TextBox txtOyuncuNo;
        private System.Windows.Forms.GroupBox gbMaaliisler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBilanco;
        private System.Windows.Forms.Label lblOdenek;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOdenek;
        private System.Windows.Forms.GroupBox gbFirmaEkle;
        private System.Windows.Forms.ComboBox txtFirma;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFirmaSehri;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.Button btnFirmaEkle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnFirmaGoster;
    }
}

