namespace FutureCom.UI
{
    partial class OgretmenForm
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
            this.dtgOgretmen = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOgrenciId = new System.Windows.Forms.TextBox();
            this.txtOgretmenAd = new System.Windows.Forms.TextBox();
            this.txtOgretmenSoyad = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnOnceki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOgretmen)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgOgretmen
            // 
            this.dtgOgretmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOgretmen.Location = new System.Drawing.Point(55, 37);
            this.dtgOgretmen.Name = "dtgOgretmen";
            this.dtgOgretmen.RowTemplate.Height = 25;
            this.dtgOgretmen.Size = new System.Drawing.Size(696, 150);
            this.dtgOgretmen.TabIndex = 0;
            this.dtgOgretmen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgOgretmen_CellClick);
            this.dtgOgretmen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgOgretmen_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğretmen Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Öğretmen Ad";
            // 
            // txtOgrenciId
            // 
            this.txtOgrenciId.Location = new System.Drawing.Point(150, 220);
            this.txtOgrenciId.Name = "txtOgrenciId";
            this.txtOgrenciId.Size = new System.Drawing.Size(224, 23);
            this.txtOgrenciId.TabIndex = 4;
            // 
            // txtOgretmenAd
            // 
            this.txtOgretmenAd.Location = new System.Drawing.Point(150, 268);
            this.txtOgretmenAd.Name = "txtOgretmenAd";
            this.txtOgretmenAd.Size = new System.Drawing.Size(224, 23);
            this.txtOgretmenAd.TabIndex = 5;
            // 
            // txtOgretmenSoyad
            // 
            this.txtOgretmenSoyad.Location = new System.Drawing.Point(150, 307);
            this.txtOgretmenSoyad.Name = "txtOgretmenSoyad";
            this.txtOgretmenSoyad.Size = new System.Drawing.Size(224, 23);
            this.txtOgretmenSoyad.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(61, 385);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(381, 385);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 8;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(271, 385);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(171, 385);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(686, 286);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(75, 23);
            this.btnIleri.TabIndex = 11;
            this.btnIleri.Text = "Diğer Sayfa";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOnceki
            // 
            this.btnOnceki.Location = new System.Drawing.Point(539, 286);
            this.btnOnceki.Name = "btnOnceki";
            this.btnOnceki.Size = new System.Drawing.Size(96, 23);
            this.btnOnceki.TabIndex = 12;
            this.btnOnceki.Text = "Önceki Sayfa";
            this.btnOnceki.UseVisualStyleBackColor = true;
            this.btnOnceki.Click += new System.EventHandler(this.btnOnceki_Click);
            // 
            // OgretmenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOnceki);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtOgretmenSoyad);
            this.Controls.Add(this.txtOgretmenAd);
            this.Controls.Add(this.txtOgrenciId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgOgretmen);
            this.Name = "OgretmenForm";
            this.Text = "OgretmenForm";
            this.Load += new System.EventHandler(this.OgretmenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOgretmen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgOgretmen;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtOgrenciId;
        private TextBox txtOgretmenAd;
        private TextBox txtOgretmenSoyad;
        private Button btnEkle;
        private Button btnAra;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnIleri;
        private Button btnOnceki;
    }
}