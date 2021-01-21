using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Sayın " + musteri.Ad + " " + musteri.Soyad + ";\nKaydınız Eklendi.");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Sayın " + musteri.Ad + " " + musteri.Soyad + 
                ";\nBilgileriniz Şu Şekildedir : " + 
                "\nAdınız Soyadınız : " + musteri.Ad + " " + musteri.Soyad + 
                "\nAdresiniz : " + musteri.Adres + 
                "\nCinsiyetiniz : " + musteri.Cinsiyet + 
                "\nBoyunuz : " + musteri.Boy);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Sayın " + musteri.Ad + " " + musteri.Soyad + ";\nSilme İşleminiz Başarılı");
        }
    }
}
