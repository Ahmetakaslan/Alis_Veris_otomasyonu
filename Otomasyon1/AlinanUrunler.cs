using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon1
{

    [FirestoreData]
    internal class AlinanUrunler
    {
        [FirestoreProperty]
        public string isim { get; set; }
        [FirestoreProperty]
        public double UrunFiyati { get; set; }
        [FirestoreProperty]
        public int UrunAdedi { get; set; }
        [FirestoreProperty]
        public string UrunAciklamasi { get; set; }
        [FirestoreProperty]
        public string AlimTarihi { get; set; }
        [FirestoreProperty]
        public string UrunTuru { get; set; }
    

    }
}
