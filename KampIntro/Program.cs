using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = Tip Güvenliği
            //Do Not Repeat Yourself = Kendini Tekrarlama
            //Değer Tutucu = alias
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.42;
            bool sistemeGirisYapmisMi = true;

            double dolarBugun = 7.35;
            double dolarDun = 7.45;

            if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Azalış Oku Butonu");
            }
            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış Oku Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }







            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


               Console.WriteLine(kategoriEtiketi);



        }
    }
}
