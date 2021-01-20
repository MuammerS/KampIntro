using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product urun3 = new Product();
            urun3.Adi = "Patates";
            urun3.Fiyati = 5;
            urun3.Aciklama = "Güzel Patates (Kırzatmalık)";

            Product[] urunler = new Product[] { urun1, urun2, urun3 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }
            Console.WriteLine("---------METODLAR---------");

            //instance - örneği oluşturmak 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
        }
    }
}
// Tekrar Tekrar Kullanılabilirliği sağlayan kod bloklarıdır: METOTLAR.
// dont repeat yourself : Kendini Tekrar ETME!
//Clean Code - BEST Practice