using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 100;
            musteri1.Ad = "Mehmet Akif";
            musteri1.Soyad = "TURAN";
            musteri1.Adres = "Balıkesir";
            musteri1.Cinsiyet = true;
            musteri1.Boy = 1.75;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 101;
            musteri2.Ad = "Irmak Nisa";
            musteri2.Soyad = "YILMAZ";
            musteri2.Adres = "Ordu";
            musteri2.Cinsiyet = false;
            musteri2.Boy = 1.55;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 102;
            musteri3.Ad = "Ali Kağan";
            musteri3.Soyad = "FATİH";
            musteri3.Adres = "Ankara";
            musteri3.Cinsiyet = true;
            musteri3.Boy = 1.85;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            Console.WriteLine("----------------------------------");
            musteriManager.Listele(musteri2);
            Console.WriteLine("----------------------------------");
            musteriManager.Sil(musteri3);
        }
    }
}
