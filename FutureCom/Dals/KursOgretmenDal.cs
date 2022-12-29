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
    public class KursOgretmenDal
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
            SqlCommand command = new SqlCommand("Select * From Kurs left join Ogretmen on Kurs.Id=Ogretmen.Id", connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable db = new DataTable();
            db.Load(reader);
            reader.Close();
            connection.Close();
            return db;
        }
       

        public void ConnectionKontrol()
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

        }

       
    }
}
