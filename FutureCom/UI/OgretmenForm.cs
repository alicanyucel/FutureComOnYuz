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
    public partial class OgretmenForm : Form
    {
        public OgretmenForm()
        {
            InitializeComponent();
        }
        OgretmenDal ogretmenDal = new OgretmenDal();
        private void OgretmenForm_Load(object sender, EventArgs e)
        {
            dtgOgretmen.DataSource = ogretmenDal.GetAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ogretmenDal.Ekle(new Ogretmen
            {
                OgrenciId=Convert.ToInt32(txtOgrenciId.Text),
                Ad=txtOgretmenAd.Text,
                Soyad=txtOgretmenSoyad.Text
            });
            MessageBox.Show("Kayıt Eklendi");
            dtgOgretmen.DataSource = ogretmenDal.GetAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgOgretmen.CurrentRow.Cells[0].Value);
            ogretmenDal.Delete(id);
            MessageBox.Show("Kayıt Silindi");
            dtgOgretmen.DataSource = ogretmenDal.GetAll();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ROTCU0Q;Initial Catalog=FutureCom;Integrated Security=True;TrustServerCertificate=True");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand ara = new SqlCommand("select * from Ogretmen where OgretmenAd like'%" + txtOgretmenAd.Text + "%'", connection);
            SqlDataAdapter da = new SqlDataAdapter(ara);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtgOgretmen.DataSource = ds.Tables[0];
            connection.Close();

        }

        private void dtgOgretmen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgOgretmen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
            txtOgretmenAd.Text = dtgOgretmen.CurrentRow.Cells[1].Value.ToString();
            txtOgrenciId.Text = dtgOgretmen.CurrentRow.Cells[3].Value.ToString();
            txtOgretmenSoyad.Text = dtgOgretmen.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Ogretmen ogretmen = new Ogretmen
            {
                Id = Convert.ToInt32(dtgOgretmen.CurrentRow.Cells[0].Value.ToString()),
                Ad=txtOgretmenAd.Text,
                Soyad=txtOgretmenSoyad.Text,
                OgrenciId=Convert.ToInt32(txtOgrenciId.Text)
            };
            ogretmenDal.Update(ogretmen);
            MessageBox.Show("Kayit Guncellendi");
            dtgOgretmen.DataSource = ogretmenDal.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KursForm kr = new KursForm();
            kr.Show();
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            OgrenciForm ogrenci = new OgrenciForm();
            ogrenci.Show();
        }
    }
}
