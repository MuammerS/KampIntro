using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {


            Product urun1 = new Product();
            urun1.ProductAdi = "Koşu Bandı";
            urun1.ProductFiyati = 2600;

            Product urun2 = new Product();
            urun2.ProductAdi = "Basketball Topu";
            urun2.ProductFiyati = 120;

            Product urun3 = new Product();
            urun3.ProductAdi = "Spor Ayakkabı";
            urun3.ProductFiyati = 450;

            Console.WriteLine(urun1.ProductAdi + " : " + urun1.ProductFiyati);
            Console.WriteLine(urun2.ProductAdi + " : " + urun2.ProductFiyati);
            Console.WriteLine(urun3.ProductAdi + " : " + urun3.ProductFiyati);

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Burdan Sonrası Classla yapıldı");
            Console.WriteLine("---------------------------------");


            Product[] esyalar = new Product[] { urun1, urun2, urun3 };

            foreach (var esya in esyalar)
            {
                Console.Write(esya.ProductAdi+":");
                Console.Write(esya.ProductFiyati);
                Console.WriteLine(" ");
            }
        }
    }
    class Product
    {
        public string ProductAdi { get; set; }
        public int ProductFiyati { get; set; }
    }
}
