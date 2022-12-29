using FutureCom.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureCom.Dals
{
   public class OgretmenDal
    {
        // sql bağlantı oluştur
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ROTCU0Q;Initial Catalog=FutureCom;Integrated Security=True;TrustServerCertificate=True");
        // datatable listele
        public DataTable GetAll()
        {
            
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            else
            {
                ///
            }
            SqlCommand command = new SqlCommand("Select * From Ogretmen", connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable db = new DataTable();
            db.Load(reader);
            reader.Close();
            connection.Close();
            return db;
        }
        // ekle
        public void Ekle(Ogretmen ogretmen)

        {
            string kayit = "Insert Into Ogretmen(OgretmenAd,OgretmenSoyad,OgrenciId) values (@ad,@soyad,@OgrenciId)";

            if (connection.State == ConnectionState.Closed)

            {
                connection.Open();
            }

            SqlCommand ekle = new SqlCommand(kayit, connection);
            ekle.Parameters.AddWithValue("@Ad", ogretmen.Ad);
            ekle.Parameters.AddWithValue("@Soyad", ogretmen.Soyad);
            ekle.Parameters.AddWithValue("@OgrenciId",ogretmen.OgrenciId);
            ekle.ExecuteNonQuery();
            connection.Close();


        }

        public void ConnectionKontrol()
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

        }

        public void Delete(int id)
        {

            ConnectionKontrol();


            SqlCommand command = new SqlCommand("Delete from Ogretmen where Id=@id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(Ogretmen ogretmen)
        {

            ConnectionKontrol();


            SqlCommand cmd = new SqlCommand("Update Ogretmen Set OgretmenAd=@ad, OgretmenSoyad=@soyad,OgrenciId=@ogrenciId where Id=@id", connection);
            cmd.Parameters.AddWithValue("@id", ogretmen.Id);
            cmd.Parameters.AddWithValue("@ad", ogretmen.Ad);
            cmd.Parameters.AddWithValue("@soyad", ogretmen.Soyad);
            cmd.Parameters.AddWithValue("@OgrenciId", ogretmen.OgrenciId);
           
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}