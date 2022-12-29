using FutureCom.Dals;
using FutureCom.UI;
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
    public partial class OgretmenKurs : Form
    {
        public OgretmenKurs()
        {
            InitializeComponent();
        }
       KursOgretmenDal detay = new KursOgretmenDal();
        private void OgretmenKurs_Load(object sender, EventArgs e)
        {
          // önemsiz
        }

        private void OgretmenKurs_Load_1(object sender, EventArgs e)
        {
            dtgOgretmenKursDetay.DataSource = detay.GetAll();
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            KursForm kurs = new KursForm();
            kurs.Show();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            OgrenciForm ogr = new OgrenciForm();
            ogr.Show();
        }
    }
}
