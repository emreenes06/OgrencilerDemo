using Ogrenciler.Classes;
using System;
using System.Collections.Generic;

namespace Ogrenciler
{
    class Program
    {
        static void Main(string[] args)
        {
            HafizaIslemleri hafizaIslemleri = new HafizaIslemleri();
            List<Ogrenci> ogrenciListesi = hafizaIslemleri.ListeyiGetir();
            OgrenciServis ogrenciServis = new OgrenciServis();
            ogrenciServis.Goster(ogrenciListesi);

            Console.Write("Yeni öğrenci adı: ");
            string girilenOgrenciAdi = Console.ReadLine();
            Console.Write("Yeni öğrenci soyadı: ");
            string girilenOgrenciSoyadi = Console.ReadLine();
            Console.Write("Yeni öğrenci Counter Strike Seviyesi (İyi: 3, Orta: 2, Kötü: 1, Belirsiz: 0): ");
            int csSeviye = Convert.ToInt32(Console.ReadLine());

            Ogrenci girilenOgrenci = new Ogrenci()
            {
                Adi = girilenOgrenciAdi,
                Soyadi = girilenOgrenciSoyadi,
                CsSeviyesi = (CsSeviyeEnum)csSeviye
            };
            ogrenciServis.Ekle(girilenOgrenci, ogrenciListesi);
            ogrenciServis.Goster(ogrenciListesi);

            Console.ReadLine();
        }
    }
}
