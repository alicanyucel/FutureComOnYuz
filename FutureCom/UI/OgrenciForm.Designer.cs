namespace FutureCom.UI
{
    partial class OgrenciForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgOgrenci = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnIleri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgOgrenci
            // 
            this.dtgOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOgrenci.Location = new System.Drawing.Point(45, 23);
            this.dtgOgrenci.Name = "dtgOgrenci";
            this.dtgOgrenci.RowTemplate.Height = 25;
            this.dtgOgrenci.Size = new System.Drawing.Size(682, 150);
            this.dtgOgrenci.TabIndex = 0;
            this.dtgOgrenci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgOgrenci_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Soyadı";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(153, 231);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(268, 23);
            this.txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(153, 285);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(268, 23);
            this.txtSoyad.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(96, 366);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(207, 366);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(333, 366);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(468, 366);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 8;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(686, 263);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(75, 23);
            this.btnIleri.TabIndex = 9;
            this.btnIleri.Text = "Diğer Sayfa";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgOgrenci);
            this.Name = "OgrenciForm";
            this.Text = "OgrenciForm";
            this.Load += new System.EventHandler(this.OgrenciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOgrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgOgrenci;
        private Label label1;
        private Label label2;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnAra;
        private Button btnIleri;
    }
}