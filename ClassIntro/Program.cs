using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Beşir";
            int yasi = 22;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 100;



            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmeni = "Engin Demiroğ";
            kurs3.IzlenmeOrani = 150;



            // Console.WriteLine(kurs1.Egitmeni+":"+kurs1.KursAdi);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };



            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+": "+kurs.Egitmeni);

            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
