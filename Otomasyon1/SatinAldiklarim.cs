using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Cloud.Firestore;

namespace Otomasyon1
{
    public partial class SatinAldiklarim : Form
    {
        public SatinAldiklarim()
        {
            InitializeComponent();
        }
        FirestoreDb db;
        private void SatinAldiklarim_Load(object sender , EventArgs e)
        {
            connect();
            GetAllData(FormGirisYap.email,FormGirisYap.kullaniciAdi);
           dataGridView1.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.Fill;


        }
        public void connect()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"otomasyon.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS" , path);
            db = FirestoreDb.Create("otomasyon-eb3fe");
        }
       async public void GetAllData(String nameOfCollectiion,String personName)
        {
            Query query = db.Collection("Alıcılar").Document(nameOfCollectiion).Collection(personName);
            QuerySnapshot snap= await query.GetSnapshotAsync();
            foreach(DocumentSnapshot snapshot in snap)
            {
                 AlinanUrunler alinan = snapshot.ConvertTo<AlinanUrunler>();
                if (snapshot.Exists)
                {
                     dataGridView1.Rows.Add( alinan.isim , alinan.UrunFiyati  , alinan.UrunAdedi.ToString() , alinan.UrunAciklamasi,alinan.AlimTarihi,alinan.UrunTuru);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender , DataGridViewCellEventArgs e)
        {

        }
    }
}
