using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar1
{
    class SepetManager
    {
        //naming convetion
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete eklendi :" + urun.Adi);
        }
        // üçünü birden ekle genelde tercih edilmez parantez içine yeni
        // bilgi girileceğinde tüm sayfalarda tüm ürünler için güncelleme
        // yapmak gerekir yoksa sayfa hata verr.Buyüzden product a eklemek ve class kullanmak
        // her zaman daha sağlıklıdır.Bu tür clas kullanımına encapsulation denir
        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("Sepete eklendi :" + urunAdi);
        }
    }
}
