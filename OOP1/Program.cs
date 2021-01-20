using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Masa";
            product1.CategoryId = 2; //2 nin mobilyaya karşılık geldiğini bil simülasyon
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            //başka bi yöntem ürün tanımında(5 nolu kategori = kırtasiye olsun )
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5,ProductName = "kalem",UnitPrice = 35 };

            //PascalCase    //camelCase  -Burda isimlendirmenin önemine değindi ki çok mantıklı :D 
            //case sensitive (b k harf duyarlı)
            //burdaki ProductManager türünde bi productName değişkeni

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName); //kamera olcak çünük klas referans tiptir



            


        }
    }
}
