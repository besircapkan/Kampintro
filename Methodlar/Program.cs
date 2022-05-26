using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Aciklama = "Amasya Elması";
            urun1.Fiyati = 15;
            urun1.StokAdeti = 10;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.Fiyati = 50;
            urun2.StokAdeti = 9;

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati+" TL");
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");

            }
            Console.WriteLine("---------Methodlar-------------");


            // Örnek:
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            Console.WriteLine("---------------------------------------");

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,5);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 15,2);
            sepetManager.Ekle2("Kavun", "Diyarbakır Karpuzu", 112,1);

        }
    }
}


// Do not Repeat yourself kendini tekrar etmeme prensibi kısaca -DRY olarak geçiyor