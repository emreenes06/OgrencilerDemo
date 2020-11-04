using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenciler.Classes
{
    class HafizaIslemleri
    {
        public List<Ogrenci> ListeyiGetir()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci()
                {
                    Id = 1,
                    Adi = "Yiğit",
                    Soyadi = "Memeci",
                    CsSeviyesi = CsSeviyeEnum.Iyi
                },
                new Ogrenci()
                {
                    Id = 2,
                    Adi = "Bartu",
                    Soyadi = "Ünal",
                    CsSeviyesi = CsSeviyeEnum.Orta
                },
                new Ogrenci()
                {
                    Id = 3,
                    Adi = "Emre Enes",
                    Soyadi = "Koç",
                    CsSeviyesi = CsSeviyeEnum.Belirsiz
                }
            };
            return ogrenciler;
        }
    }
}
