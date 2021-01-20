using System.Linq;
using System;

namespace MetodlarıDahaIyiAnlamakIçin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekle();
            //Ekle();
            //Ekle();
            //Ekle();
            // Ekle Metodunu çağırır arka arkaya "Eklendi!" yazar.



            //var result = Ekle2(5, 7);
            // Console.WriteLine(result);


            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Ekle3(ref number1,number2);

            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2, 4, 5));
            Console.WriteLine(Ekle4(1,2,3,4,6,5,7,8,9));
            Console.ReadLine();

        }
        static void Ekle()
        {
            Console.WriteLine("Eklendi!");
        }
        static int Ekle2(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }

        static int Ekle3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }


        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Multiply(int x, int y, int c)
        {
            return x * y * c;
        }


        static int Ekle4(params int[] numbers)
        {
            return numbers.Sum();
        }



    }
}
// başa using System.Linq; yazmayı unutma!

//ref ve out değer türündeki verileri referans olarak metotlara geçmek
//için kullanılan anahtar kelimelerdir.
//eğer metodun içinde değer tanımlıyorsan out kullan
// eğer tanımlamıyorsan Ref kullan ama istersen üstteki çinde ref kullnabilirsin
//eğer dışarda bir değişken tanımladıysan ref kullanma.





