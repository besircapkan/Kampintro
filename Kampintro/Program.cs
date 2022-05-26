using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety = tip güvenliği
            string kategoriEtiketi = "Kategoriler";
            int ogrencisayisi = 120;
            double ondalikliSayilar = 15.4;
            bool sistemegirisYapmismi = false;
            double doladun = 7.35;
            double dolarbugun = 7.45;
            if (doladun>dolarbugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else if (doladun<dolarbugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else
            {
                Console.WriteLine("Stabil");
            }








            if (sistemegirisYapmismi==true)// parantezin içine şartı yazıyoruz 
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap");
            }
            Console.WriteLine(kategoriEtiketi);

        }
    }
}
