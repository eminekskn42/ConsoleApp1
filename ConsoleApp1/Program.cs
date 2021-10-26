using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtikete = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi =false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
           
            {
                Console.WriteLine("Azalış butonu ");

            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }

            else
            {
                Console.WriteLine("değişim yok");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");     
            }
            else
            {
                // bool sistemeGirisYapmisMi =false olduğu için bu satır çalışır
                Console.WriteLine("Giriş yap butonu");
            }
          
            Console.WriteLine(kategoriEtikete);
            Console.WriteLine(kategoriEtikete);
            Console.WriteLine(kategoriEtikete);
            //çıktısı
            //Kategori
            //Kategori
            //Kategori





        }
    }
}
