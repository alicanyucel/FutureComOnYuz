namespace FutureCom
{
    partial class KursForm
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
            this.dtgKurs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKurs = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.bntAra = new System.Windows.Forms.Button();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnOnceki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKurs)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgKurs
            // 
            this.dtgKurs.CausesValidation = false;
            this.dtgKurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKurs.Location = new System.Drawing.Point(95, 42);
            this.dtgKurs.Name = "dtgKurs";
            this.dtgKurs.RowTemplate.Height = 25;
            this.dtgKurs.Size = new System.Drawing.Size(587, 139);
            this.dtgKurs.TabIndex = 0;
            this.dtgKurs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKurs_CellClick);
            this.dtgKurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKurs_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "KursAdı";
            // 
            // txtKurs
            // 
            this.txtKurs.Location = new System.Drawing.Point(163, 270);
            this.txtKurs.Name = "txtKurs";
            this.txtKurs.Size = new System.Drawing.Size(264, 23);
            this.txtKurs.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(80, 360);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(426, 360);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(243, 360);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // bntAra
            // 
            this.bntAra.Location = new System.Drawing.Point(596, 360);
            this.bntAra.Name = "bntAra";
            this.bntAra.Size = new System.Drawing.Size(75, 23);
            this.bntAra.TabIndex = 6;
            this.bntAra.Text = "Ara";
            this.bntAra.UseVisualStyleBackColor = true;
            this.bntAra.Click += new System.EventHandler(this.bntAra_Click);
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(659, 226);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(120, 49);
            this.btnIleri.TabIndex = 7;
            this.btnIleri.Text = "Diğer Sayfaya Geç";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnOnceki
            // 
            this.btnOnceki.Location = new System.Drawing.Point(496, 226);
            this.btnOnceki.Name = "btnOnceki";
            this.btnOnceki.Size = new System.Drawing.Size(120, 49);
            this.btnOnceki.TabIndex = 8;
            this.btnOnceki.Text = "Önceki Sayfaya Geç";
            this.btnOnceki.UseVisualStyleBackColor = true;
            this.btnOnceki.Click += new System.EventHandler(this.btnOnceki_Click);
            // 
            // KursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOnceki);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.bntAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtKurs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgKurs);
            this.Name = "KursForm";
            this.Text = "KursForm";
            this.Load += new System.EventHandler(this.KursForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgKurs;
        private Label label1;
        private TextBox txtKurs;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button bntAra;
        private Button btnIleri;
        private Button btnOnceki;
    }
}