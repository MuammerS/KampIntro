using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Java";
            string kurs2 = "C#";
            string kurs3 = "Python";

            //array = Diziler

            string[] kurslar = new string[] { "Java","Python","C#","JavaScript","HTML","CSS","C++" };
            //Yazılım Dilleri Saymaya 0 dan başlar.

            for (int i = 0; i < kurslar.Length; i++) //Length eleman sayısıdır direk bize kaç
                                                     //adet olduğunu verir (6)
            {
                Console.WriteLine(kurslar[i]);   //Kursların i'ninci (i.) elemanını yazdırıyoruz


                foreach (string kurs in kurslar)
                {
                    Console.WriteLine(kurs);     //Burda String Dizileri için daha kolay bi yazma şekli sunuyo
                }
            }
        } 
    }
}
