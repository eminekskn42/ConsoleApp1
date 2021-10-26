using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "emine";
            int yas = 24;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c++";
            kurs1.Eğitmen = "ender";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "c";
            kurs2.Eğitmen = "emin";
            kurs2.IzlenmeOrani = 60;



            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "c#";
            kurs3.Eğitmen = "engin";
            kurs3.IzlenmeOrani = 65;


            // Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Eğitmen);

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Eğitmen);
            }
            
            
            
            
            Console.WriteLine("hello Word");
        }
    }
    class Kurs
    {

        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int IzlenmeOrani { get; set; }

        
    }
}
