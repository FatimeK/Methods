using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"engin","murat","kerem","halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            ////peki ben buraya yeni eleman eklemek istersem?
            ////isimler[4] = "ilker;" dersem patlar. yer yok hatası alırsın

            //isimler = new string[5]; //yeni bi referans adresi ve eski herşey patlar
            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            //burda 4. elemanı yazar ama diğer tüm elemanları siiler çünkü sen new dediğin anda yepyeni boş dizi oluşturupsadece 4. elemana ilker koyar.diğerleri patlar

            //peki napcazzz. C# KOLEKSİYONLARI GELİŞTİRDİİİ

            List<string> isimler2 = new List<string> { "engin", "murat", "kerem", "halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker"); //yani array değil de liste yapınca paşa paşa add ile eklerim
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }

    }
}
