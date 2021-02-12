using System;

namespace ClassMetotDemoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "SELİM";
            musteri1.Soyad = "DOLU";
            musteri1.Id = 12341232222;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "SALİM";
            musteri2.Soyad = "BOŞ";
            musteri2.Id = 12341211637;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager musteriYonet = new MusteriManager();

            Console.WriteLine("--- EKLENENLER ---");
            musteriYonet.Ekle(musteri1);
            musteriYonet.Ekle(musteri2);

            Console.WriteLine("--- SİLİNENLER ---");
            musteriYonet.Sil(musteri1);
            musteriYonet.Sil(musteri2);

            Console.WriteLine("---  MUSTERI LİSTE ---");
            musteriYonet.Array(musteriler);
        }
    }
}
