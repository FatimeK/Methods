using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elması";


            Product product2 = new Product();
            product2.Adi = "karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır karpuzu";


            Product[] products = new Product[] { product1, product2 }; // ürün arrayi oluşturdum

            //bizim datalarımız bir veri kaynağından gelir.
            //api,excel dosyası,veri tabanı gibi kaynaklardan geliyo. 3 hafta sonranın konusu

            //diziler çoğul isimlendirliri.

            foreach (Product product in products) //products adlı dizidekş elemanları tek tek gez.
                                                  // Product product ne peki = küçük olan takma ad olan alien soldaki da veri tipidir.çünkü c# tip güvenli bi dil.bu da çalışcağı veri tipini bilmesi demektir. var da yazsan olur.
            {

                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine("   ");

            }

            Console.WriteLine("**********metotlar**********\n");

            // instance = class örneği oluşturmak
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2); //ekleyi tanımlarken parametre verdin ama burda parametre vermedin vermesen kızar

            sepetManager.Ekle2("armut", "yeşil armut", 12, 10); //bu 4.parametreyi sonradan ekledik encapsulation için
            sepetManager.Ekle2("elma", "yeşil elma", 15, 8);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 22, 7); //burda yapılan hataya bak
                                                                       //Ekle metodu varken bunu kullanmak çok saçma.

            //stok adedi eklemk istedik Ekle2 metodu patladı ama Ekle() gayet uyumluydu.encapsulation oldu.
            //ben aslında ayrı ayrı yazacağım ve düzensiz olacak yapıyı bi kapsül içinde sokup bi düzen içinde çalışıyorum

            //atıyorum sonra yönetim dedi ki bi de stok adedini ekleyek.

        }
    }
}
