using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //manager tarzı bi isimlendirme görürsen anla ki ürünle ilgili operasyonları içerecek olan class
    class ProductManager 
    {

        public void Add(Product product)
        {
            //manager tarzı bi isimlendirme görürsen anla ki ürünle ilgili operasyonları içerecek olan class
            Console.WriteLine(product.ProductName + "eklendi.");
        }
        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + "güncellendi.");

        }

        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2; // git başka istediğin yerde de kullan.
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2); //işlemi yapar ve döndürür ve işi biter bağ kopar
        }
    }
}
