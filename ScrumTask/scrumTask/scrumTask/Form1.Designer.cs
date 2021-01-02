namespace scrumTask
{
    partial class TaskADD
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
            this.gbTaskAdd = new System.Windows.Forms.GroupBox();
            this.gbLogo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblartı1 = new System.Windows.Forms.Label();
            this.gbBelgeBilgileri = new System.Windows.Forms.GroupBox();
            this.mtxtTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtKartNo = new System.Windows.Forms.TextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblKartNo = new System.Windows.Forms.Label();
            this.gbTarihler = new System.Windows.Forms.GroupBox();
            this.txtGerceklesenSure = new System.Windows.Forms.TextBox();
            this.txtTahminTarih = new System.Windows.Forms.TextBox();
            this.lblTahmin = new System.Windows.Forms.Label();
            this.lblGercekSure = new System.Windows.Forms.Label();
            this.gbAdNo = new System.Windows.Forms.GroupBox();
            this.txtTeknikUzman = new System.Windows.Forms.TextBox();
            this.txtProjeNo = new System.Windows.Forms.TextBox();
            this.lblProjeNo = new System.Windows.Forms.Label();
            this.lblUzman = new System.Windows.Forms.Label();
            this.gbIsTakibi = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbNotlar = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtNotlar = new System.Windows.Forms.TextBox();
            this.gbAciklama = new System.Windows.Forms.GroupBox();
            this.txtIsAciklamasi = new System.Windows.Forms.TextBox();
            this.gbTaskAdd.SuspendLayout();
            this.gbLogo.SuspendLayout();
            this.gbBelgeBilgileri.SuspendLayout();
            this.gbTarihler.SuspendLayout();
            this.gbAdNo.SuspendLayout();
            this.gbIsTakibi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbNotlar.SuspendLayout();
            this.gbAciklama.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTaskAdd
            // 
            this.gbTaskAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gbTaskAdd.Controls.Add(this.gbLogo);
            this.gbTaskAdd.Controls.Add(this.gbBelgeBilgileri);
            this.gbTaskAdd.Controls.Add(this.gbTarihler);
            this.gbTaskAdd.Controls.Add(this.gbAdNo);
            this.gbTaskAdd.Controls.Add(this.gbIsTakibi);
            this.gbTaskAdd.Controls.Add(this.gbNotlar);
            this.gbTaskAdd.Controls.Add(this.gbAciklama);
            this.gbTaskAdd.Location = new System.Drawing.Point(13, 13);
            this.gbTaskAdd.Name = "gbTaskAdd";
            this.gbTaskAdd.Size = new System.Drawing.Size(807, 606);
            this.gbTaskAdd.TabIndex = 0;
            this.gbTaskAdd.TabStop = false;
            this.gbTaskAdd.Text = "Task ADD";
            // 
            // gbLogo
            // 
            this.gbLogo.Controls.Add(this.label2);
            this.gbLogo.Controls.Add(this.label1);
            this.gbLogo.Controls.Add(this.lblartı1);
            this.gbLogo.Location = new System.Drawing.Point(81, 20);
            this.gbLogo.Name = "gbLogo";
            this.gbLogo.Size = new System.Drawing.Size(321, 82);
            this.gbLogo.TabIndex = 12;
            this.gbLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "engineering";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "software ";
            // 
            // lblartı1
            // 
            this.lblartı1.AutoSize = true;
            this.lblartı1.Font = new System.Drawing.Font("Comic Sans MS", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblartı1.ForeColor = System.Drawing.Color.Maroon;
            this.lblartı1.Location = new System.Drawing.Point(5, 16);
            this.lblartı1.Name = "lblartı1";
            this.lblartı1.Size = new System.Drawing.Size(185, 56);
            this.lblartı1.TabIndex = 0;
            this.lblartı1.Text = "ART1bir";
            // 
            // gbBelgeBilgileri
            // 
            this.gbBelgeBilgileri.Controls.Add(this.mtxtTarih);
            this.gbBelgeBilgileri.Controls.Add(this.txtKartNo);
            this.gbBelgeBilgileri.Controls.Add(this.lblTarih);
            this.gbBelgeBilgileri.Controls.Add(this.lblKartNo);
            this.gbBelgeBilgileri.Location = new System.Drawing.Point(415, 20);
            this.gbBelgeBilgileri.Name = "gbBelgeBilgileri";
            this.gbBelgeBilgileri.Size = new System.Drawing.Size(325, 76);
            this.gbBelgeBilgileri.TabIndex = 11;
            this.gbBelgeBilgileri.TabStop = false;
            // 
            // mtxtTarih
            // 
            this.mtxtTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mtxtTarih.Location = new System.Drawing.Point(170, 16);
            this.mtxtTarih.Mask = "00/00/0000";
            this.mtxtTarih.Name = "mtxtTarih";
            this.mtxtTarih.Size = new System.Drawing.Size(100, 26);
            this.mtxtTarih.TabIndex = 6;
            this.mtxtTarih.ValidatingType = typeof(System.DateTime);
            this.mtxtTarih.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtTarih_KeyPress);
            // 
            // txtKartNo
            // 
            this.txtKartNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtKartNo.Enabled = false;
            this.txtKartNo.Location = new System.Drawing.Point(170, 44);
            this.txtKartNo.Name = "txtKartNo";
            this.txtKartNo.Size = new System.Drawing.Size(100, 26);
            this.txtKartNo.TabIndex = 5;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(6, 22);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(41, 18);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "Tarih";
            // 
            // lblKartNo
            // 
            this.lblKartNo.AutoSize = true;
            this.lblKartNo.Location = new System.Drawing.Point(6, 44);
            this.lblKartNo.Name = "lblKartNo";
            this.lblKartNo.Size = new System.Drawing.Size(51, 18);
            this.lblKartNo.TabIndex = 3;
            this.lblKartNo.Text = "KartNo";
            // 
            // gbTarihler
            // 
            this.gbTarihler.Controls.Add(this.txtGerceklesenSure);
            this.gbTarihler.Controls.Add(this.txtTahminTarih);
            this.gbTarihler.Controls.Add(this.lblTahmin);
            this.gbTarihler.Controls.Add(this.lblGercekSure);
            this.gbTarihler.Location = new System.Drawing.Point(415, 102);
            this.gbTarihler.Name = "gbTarihler";
            this.gbTarihler.Size = new System.Drawing.Size(325, 73);
            this.gbTarihler.TabIndex = 10;
            this.gbTarihler.TabStop = false;
            // 
            // txtGerceklesenSure
            // 
            this.txtGerceklesenSure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtGerceklesenSure.Location = new System.Drawing.Point(170, 42);
            this.txtGerceklesenSure.Name = "txtGerceklesenSure";
            this.txtGerceklesenSure.Size = new System.Drawing.Size(100, 26);
            this.txtGerceklesenSure.TabIndex = 7;
            this.txtGerceklesenSure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGerceklesenSure_KeyPress);
            // 
            // txtTahminTarih
            // 
            this.txtTahminTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTahminTarih.Enabled = false;
            this.txtTahminTarih.Location = new System.Drawing.Point(170, 14);
            this.txtTahminTarih.Name = "txtTahminTarih";
            this.txtTahminTarih.Size = new System.Drawing.Size(100, 26);
            this.txtTahminTarih.TabIndex = 6;
            // 
            // lblTahmin
            // 
            this.lblTahmin.AutoSize = true;
            this.lblTahmin.Location = new System.Drawing.Point(6, 22);
            this.lblTahmin.Name = "lblTahmin";
            this.lblTahmin.Size = new System.Drawing.Size(88, 18);
            this.lblTahmin.TabIndex = 4;
            this.lblTahmin.Text = "TahminiTarih";
            // 
            // lblGercekSure
            // 
            this.lblGercekSure.AutoSize = true;
            this.lblGercekSure.Location = new System.Drawing.Point(6, 44);
            this.lblGercekSure.Name = "lblGercekSure";
            this.lblGercekSure.Size = new System.Drawing.Size(111, 18);
            this.lblGercekSure.TabIndex = 5;
            this.lblGercekSure.Text = "GerçekleşenSüre";
            // 
            // gbAdNo
            // 
            this.gbAdNo.Controls.Add(this.txtTeknikUzman);
            this.gbAdNo.Controls.Add(this.txtProjeNo);
            this.gbAdNo.Controls.Add(this.lblProjeNo);
            this.gbAdNo.Controls.Add(this.lblUzman);
            this.gbAdNo.Location = new System.Drawing.Point(81, 102);
            this.gbAdNo.Name = "gbAdNo";
            this.gbAdNo.Size = new System.Drawing.Size(321, 73);
            this.gbAdNo.TabIndex = 9;
            this.gbAdNo.TabStop = false;
            // 
            // txtTeknikUzman
            // 
            this.txtTeknikUzman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTeknikUzman.Location = new System.Drawing.Point(171, 41);
            this.txtTeknikUzman.Name = "txtTeknikUzman";
            this.txtTeknikUzman.Size = new System.Drawing.Size(100, 26);
            this.txtTeknikUzman.TabIndex = 3;
            this.txtTeknikUzman.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTeknikUzman_KeyPress);
            // 
            // txtProjeNo
            // 
            this.txtProjeNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtProjeNo.Location = new System.Drawing.Point(171, 14);
            this.txtProjeNo.Name = "txtProjeNo";
            this.txtProjeNo.Size = new System.Drawing.Size(100, 26);
            this.txtProjeNo.TabIndex = 2;
            this.txtProjeNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProjeNo_KeyPress);
            // 
            // lblProjeNo
            // 
            this.lblProjeNo.AutoSize = true;
            this.lblProjeNo.Location = new System.Drawing.Point(6, 21);
            this.lblProjeNo.Name = "lblProjeNo";
            this.lblProjeNo.Size = new System.Drawing.Size(57, 18);
            this.lblProjeNo.TabIndex = 0;
            this.lblProjeNo.Text = "ProjeNo";
            // 
            // lblUzman
            // 
            this.lblUzman.AutoSize = true;
            this.lblUzman.Location = new System.Drawing.Point(6, 44);
            this.lblUzman.Name = "lblUzman";
            this.lblUzman.Size = new System.Drawing.Size(89, 18);
            this.lblUzman.TabIndex = 1;
            this.lblUzman.Text = "TeknikUzman";
            // 
            // gbIsTakibi
            // 
            this.gbIsTakibi.Controls.Add(this.dataGridView1);
            this.gbIsTakibi.Location = new System.Drawing.Point(6, 294);
            this.gbIsTakibi.Name = "gbIsTakibi";
            this.gbIsTakibi.Size = new System.Drawing.Size(795, 306);
            this.gbIsTakibi.TabIndex = 8;
            this.gbIsTakibi.TabStop = false;
            this.gbIsTakibi.Text = "İş Takibi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(789, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbNotlar
            // 
            this.gbNotlar.Controls.Add(this.btnEkle);
            this.gbNotlar.Controls.Add(this.txtNotlar);
            this.gbNotlar.Location = new System.Drawing.Point(415, 181);
            this.gbNotlar.Name = "gbNotlar";
            this.gbNotlar.Size = new System.Drawing.Size(325, 109);
            this.gbNotlar.TabIndex = 7;
            this.gbNotlar.TabStop = false;
            this.gbNotlar.Text = "Notlar";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(255, 26);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(64, 76);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtNotlar
            // 
            this.txtNotlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtNotlar.Location = new System.Drawing.Point(6, 25);
            this.txtNotlar.Multiline = true;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(243, 77);
            this.txtNotlar.TabIndex = 1;
            this.txtNotlar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNotlar_KeyPress);
            // 
            // gbAciklama
            // 
            this.gbAciklama.Controls.Add(this.txtIsAciklamasi);
            this.gbAciklama.Location = new System.Drawing.Point(81, 181);
            this.gbAciklama.Name = "gbAciklama";
            this.gbAciklama.Size = new System.Drawing.Size(321, 109);
            this.gbAciklama.TabIndex = 6;
            this.gbAciklama.TabStop = false;
            this.gbAciklama.Text = "İşin Açıklaması";
            // 
            // txtIsAciklamasi
            // 
            this.txtIsAciklamasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtIsAciklamasi.Location = new System.Drawing.Point(7, 26);
            this.txtIsAciklamasi.Multiline = true;
            this.txtIsAciklamasi.Name = "txtIsAciklamasi";
            this.txtIsAciklamasi.Size = new System.Drawing.Size(308, 77);
            this.txtIsAciklamasi.TabIndex = 0;
            this.txtIsAciklamasi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIsAciklamasi_KeyPress);
            // 
            // TaskADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(832, 631);
            this.Controls.Add(this.gbTaskAdd);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskADD";
            this.Text = "TaskADD";
            this.Load += new System.EventHandler(this.TaskADD_Load);
            this.gbTaskAdd.ResumeLayout(false);
            this.gbLogo.ResumeLayout(false);
            this.gbLogo.PerformLayout();
            this.gbBelgeBilgileri.ResumeLayout(false);
            this.gbBelgeBilgileri.PerformLayout();
            this.gbTarihler.ResumeLayout(false);
            this.gbTarihler.PerformLayout();
            this.gbAdNo.ResumeLayout(false);
            this.gbAdNo.PerformLayout();
            this.gbIsTakibi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbNotlar.ResumeLayout(false);
            this.gbNotlar.PerformLayout();
            this.gbAciklama.ResumeLayout(false);
            this.gbAciklama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTaskAdd;
        private System.Windows.Forms.GroupBox gbBelgeBilgileri;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblKartNo;
        private System.Windows.Forms.GroupBox gbTarihler;
        private System.Windows.Forms.Label lblTahmin;
        private System.Windows.Forms.Label lblGercekSure;
        private System.Windows.Forms.GroupBox gbAdNo;
        private System.Windows.Forms.Label lblProjeNo;
        private System.Windows.Forms.Label lblUzman;
        private System.Windows.Forms.GroupBox gbIsTakibi;
        private System.Windows.Forms.GroupBox gbNotlar;
        private System.Windows.Forms.GroupBox gbAciklama;
        private System.Windows.Forms.GroupBox gbLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblartı1;
        private System.Windows.Forms.MaskedTextBox mtxtTarih;
        private System.Windows.Forms.TextBox txtKartNo;
        private System.Windows.Forms.TextBox txtTeknikUzman;
        private System.Windows.Forms.TextBox txtProjeNo;
        private System.Windows.Forms.TextBox txtNotlar;
        private System.Windows.Forms.TextBox txtIsAciklamasi;
        private System.Windows.Forms.TextBox txtGerceklesenSure;
        private System.Windows.Forms.TextBox txtTahminTarih;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

