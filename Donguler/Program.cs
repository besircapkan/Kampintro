using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kursu";
            string kurs2 = "Programlamaya Başlangıç Kursu";
            string kurs3 = "Java Kursu";

            // arry - diziler yani liste demek liste böyle oluşuyor
            string[] kurslar = new string[] { "Yazılım Geliştirici Kursu", 
                "Programlamaya Başlangıç Kursu",
                "Java Kursu","Python Kursu","C#","C++"};



            for (int i = 0; i <kurslar.Length; i++) // i=i+2 2 2 artır demektir veya i+=2 2 2 artırt demek bu aynı şekil 1++ ise 1 1 artır demek
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("----------FOR BİTTİ----------");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu Flooter");
        }
    }
}