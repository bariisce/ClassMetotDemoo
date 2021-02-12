using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemoo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("MUSTERI EKLENDI  : " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Id);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("MUSTERI SILINDI  : " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Id);
        }

        public void Array(Musteri[] musteriler)
        {
            foreach (var muz in musteriler)
            {
                Console.WriteLine("MUSTERI ADI : " + muz.Ad);
                Console.WriteLine("MUSTERI SOYADI : " + muz.Soyad);
                Console.WriteLine("MUSTERI ID : " + muz.Id);

                Console.WriteLine("------------------");
            }
        }
    }
}
