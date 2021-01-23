using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ müsterisi(gerçek)
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";


            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234586890";


            //Gerçek müşteri - Tüzel müşteri (bunlar sırf birbirine benziyo diye birbirinin yerine kullanılamazlar!!)

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            //Musteri klası hem gerçek hem de tüzel müşterinin referansını tutabiliyo

            //base klas olan Musteri klasını parametre istemesine rağmen hem tüzel hem de gerçek müşteriyi verebiliyorum.çünkü miras aldık
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri3);
        }
    }
}
