using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Muammer";
            int yas = 17;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 75;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Muamer Sonmez";
            kurs2.IzlenmeOrani = 85;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Mark Zuckerberg";
            kurs3.IzlenmeOrani = 25;

            Console.WriteLine("Hello World!");

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)   //Var hangi veri tipindeyse o çalışır
            {
                Console.WriteLine(kurs.KursAdi+": "+kurs.Egitmen+"-"+kurs.IzlenmeOrani);
            }
        }
    }
                    //sanki kendi veri tipini oluşturuyormuşcasına
                    // Class ı
    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; } // property = özellik (prop yazıp tap+tap)

        public int IzlenmeOrani  { get; set; }

    }
}
