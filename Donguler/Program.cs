using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //çok fazla veri olacağı için tek tek string tanımlaması yapmak yerine dizileri kullanım kullanım kolaylığı sağlıyoruz.
            string kurss1 = "yazılım geliştirici ";
            string kurss2 = "programlama geliştirici ";
            string kurss3 = "java geliştirici ";
            //yerine array kullanacağız.

            string[] kurslar = new string[] { "yazılım geliştirici ", "programlama geliştirici ","python" , "java geliştirici "
        };

            //kurslar.Length kurs uzunluğuna göre çalıştır.

            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for sayfa sonu.......");


            //foreach dizilere uygulanır ve dizi elemanını tek tek dolaşır ve
            //her dönüşte kurs ismini kullanır.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



        }
    }
}
