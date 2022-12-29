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
    public class OgrenciDal
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
            SqlCommand command = new SqlCommand("Select * From Ogrenci", connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable db = new DataTable();
            db.Load(reader);
            reader.Close();
            connection.Close();
            return db;
        }
        // ekle
        public void Ekle(Ogrenci ogrenci)

        {
            string kayit = "Insert Into Ogrenci(Ad,Soyad) values (@ad,@soyad)";

            if (connection.State == ConnectionState.Closed)

            {
                connection.Open();
            }

            SqlCommand ekle = new SqlCommand(kayit, connection);
            ekle.Parameters.AddWithValue("@Ad", ogrenci.Ad);
            ekle.Parameters.AddWithValue("@Soyad", ogrenci.Soyad);
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


            SqlCommand command = new SqlCommand("Delete from Ogrenci where Id=@id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(Ogrenci ogrenci)
        {

            ConnectionKontrol();


            SqlCommand cmd = new SqlCommand("Update Ogrenci Set Ad=@ad,Soyad=@soyad where Id=@id", connection);

            cmd.Parameters.AddWithValue("@Ad", ogrenci.Ad);
            cmd.Parameters.AddWithValue("@Soyad", ogrenci.Soyad);
            cmd.Parameters.AddWithValue("@id", ogrenci.Id);

            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}