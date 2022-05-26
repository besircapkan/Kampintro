using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetManager
    {
        public void Ekle(Urun spariş)
        {
            Console.WriteLine("Sepete Eklendi : "+ spariş.Adi+" "+spariş.StokAdeti);
        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokadeti)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi:"+urunAdi);
        }
    }
}
