using FutureCom.Dals;
using FutureCom.Entities;
using FutureCom.UI;
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

namespace FutureCom
{
    public partial class KursForm : Form
    {
        public KursForm()
        {
            InitializeComponent();
        }
        KursDal kursDal=new KursDal();
        private void KursForm_Load(object sender, EventArgs e)
        {
            // önemsiz kendisi oluşturmuş
        }

        private void dtgKurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // önemsiz kendisi oluşturmuş
        }

        private void dtgKurs_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgKurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKurs.Text = dtgKurs.CurrentRow.Cells[1].Value.ToString();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kursDal.Ekle(new Kurs
            {
               KursAdi=txtKurs.Text
            }) ;
            MessageBox.Show("kayıt eklendi");
            dtgKurs.DataSource = kursDal.GetAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgKurs.CurrentRow.Cells[0].Value);
            kursDal.Delete(id);
            dtgKurs.DataSource=kursDal.GetAll();
            MessageBox.Show("kayıt silindi");
        }

        private void bntAra_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ROTCU0Q;Initial Catalog=FutureCom;Integrated Security=True;TrustServerCertificate=True");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand ara = new SqlCommand("select * from Kurs where KursAdi like'%" + txtKurs.Text + "%'", connection);
            SqlDataAdapter da = new SqlDataAdapter(ara);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtgKurs.DataSource = ds.Tables[0];
            connection.Close();

        }

        private void KursForm_Load_1(object sender, EventArgs e)
        {
            dtgKurs.DataSource = kursDal.GetAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           
            Kurs kurs = new Kurs
            {
                Id = Convert.ToInt32(dtgKurs.CurrentRow.Cells[0].Value.ToString()),
                KursAdi = txtKurs.Text,
               
               
            };
            kursDal.Update(kurs);

            MessageBox.Show("güncellendi");
           dtgKurs.DataSource = kursDal.GetAll();
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            OgretmenKurs ogrKurs = new OgretmenKurs();
            ogrKurs.Show();

        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            OgretmenForm ogretmen = new OgretmenForm();
            ogretmen.Show();
        }
    }
}
