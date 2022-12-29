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
  public class KursDal
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
            SqlCommand command = new SqlCommand("Select * From Kurs", connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable db = new DataTable();
            db.Load(reader);
            reader.Close();
            connection.Close();
            return db;
        }
        // ekle
        public void Ekle(Kurs kurs)

        {
            string kayit = "Insert Into Kurs(KursAdi) values (@KursAdi)";

            if (connection.State == ConnectionState.Closed)

            {
                connection.Open();
            }

            SqlCommand ekle = new SqlCommand(kayit, connection);
            ekle.Parameters.AddWithValue("@KursAdi", kurs.KursAdi);
           
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


            SqlCommand command = new SqlCommand("Delete from Kurs where Id=@id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(Kurs kurs)
        {

            ConnectionKontrol();

            
            SqlCommand cmd = new SqlCommand("Update Kurs Set KursAdi=@KursAdi where Id=@id", connection);
            cmd.Parameters.AddWithValue("@id",kurs.Id);
            cmd.Parameters.AddWithValue("@KursAdi", kurs.KursAdi);
           

            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}