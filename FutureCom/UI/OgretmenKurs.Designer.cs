namespace FutureCom
{
    partial class OgretmenKurs
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
            this.dtgOgretmenKursDetay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOnceki = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOgretmenKursDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgOgretmenKursDetay
            // 
            this.dtgOgretmenKursDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOgretmenKursDetay.Location = new System.Drawing.Point(38, 72);
            this.dtgOgretmenKursDetay.Name = "dtgOgretmenKursDetay";
            this.dtgOgretmenKursDetay.RowTemplate.Height = 25;
            this.dtgOgretmenKursDetay.Size = new System.Drawing.Size(674, 150);
            this.dtgOgretmenKursDetay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Burada Öğretmen Ve Kurs Tablosu Left Joinle Birleştirilmiştir         ";
            // 
            // btnOnceki
            // 
            this.btnOnceki.Location = new System.Drawing.Point(587, 325);
            this.btnOnceki.Name = "btnOnceki";
            this.btnOnceki.Size = new System.Drawing.Size(100, 23);
            this.btnOnceki.TabIndex = 2;
            this.btnOnceki.Text = "Önceki Sayfa";
            this.btnOnceki.UseVisualStyleBackColor = true;
            this.btnOnceki.Click += new System.EventHandler(this.btnOnceki_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.Location = new System.Drawing.Point(587, 380);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(100, 23);
            this.btnHomePage.TabIndex = 3;
            this.btnHomePage.Text = "Ana Sayfa";
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // OgretmenKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.btnOnceki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgOgretmenKursDetay);
            this.Name = "OgretmenKurs";
            this.Text = "OgretmenKurs";
            this.Load += new System.EventHandler(this.OgretmenKurs_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOgretmenKursDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgOgretmenKursDetay;
        private Label label1;
        private Button btnOnceki;
        private Button btnHomePage;
    }
}