using FutureCom.Dals;
using FutureCom.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureCom.UI
{
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
        }
        OgrenciDal ogr = new OgrenciDal();
        private void dtgOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dtgOgrenci.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dtgOgrenci.CurrentRow.Cells[2].Value.ToString();
        }

        private void OgrenciForm_Load(object sender, EventArgs e)
        {
            dtgOgrenci.DataSource = ogr.GetAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ogr.Ekle(new Ogrenci
            {
                Ad=txtAd.Text,
                Soyad=txtSoyad.Text
            });
            MessageBox.Show("Kayıt Eklendi");
            dtgOgrenci.DataSource = ogr.GetAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgOgrenci.CurrentRow.Cells[0].Value);
            ogr.Delete(id);
            MessageBox.Show("Kayıt Silindi");
            dtgOgrenci.DataSource = ogr.GetAll();
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
            Ogrenci ogrenci = new Ogrenci
            {
                Id = Convert.ToInt32(dtgOgrenci.CurrentRow.Cells[0].Value.ToString()),
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text
            };
            ogr.Update(ogrenci);
            MessageBox.Show("Kayit Guncellendi");
            dtgOgrenci.DataSource = ogr.GetAll();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ROTCU0Q;Initial Catalog=FutureCom;Integrated Security=True;TrustServerCertificate=True");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand ara = new SqlCommand("select * from Ogrenci where Ad like'%" + txtAd.Text + "%'", connection);
  
            SqlDataAdapter da = new SqlDataAdapter(ara);
        
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            dtgOgrenci.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            OgretmenForm ogretmen = new OgretmenForm();
            ogretmen.Show();
        }
    }
}
