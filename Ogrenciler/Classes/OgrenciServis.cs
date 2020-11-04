using System.Collections.Generic;
using System.Linq;

namespace Ogrenciler.Classes
{
    class OgrenciServis
    {
        public void Goster(List<Ogrenci> ogrenciler)
        {
            System.Console.WriteLine("Öğrenci Listesi");
            foreach (var ogrenci in ogrenciler)
            {
                System.Console.WriteLine(ogrenci.Id + " - " + ogrenci.Adi + " - " + ogrenci.Soyadi + "  (" + ogrenci.CsSeviyesi + ") ");
            }
        }
        public void Ekle(Ogrenci ogrenci, List<Ogrenci>ogrenciler)
        {
            List<int> idler = new List<int>();
            foreach (var o in ogrenciler)
            {
                idler.Add(o.Id);
            }
            int yeniId = idler.Max();
            ogrenci.Id = yeniId + 1;
            ogrenciler.Add(ogrenci);
            
        }
    }
}
