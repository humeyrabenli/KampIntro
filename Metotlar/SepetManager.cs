﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi:" + product.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. sepete eklendi: " +urunAdi);
        }
    }
}
