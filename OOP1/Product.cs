using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //entity gibi isimler de verebiliriz
    {
        public int Id { get; set; } //primary key(anahtar)
        public int CategoryId { get; set; } //referans alanları(bu genelde okunabilirlik açısından 2. sırada yer alır)
        public string ProductName { get; set; } // ürün adı
        public double UnitPrice { get; set; } //fiyat
        public int UnitInStock { get; set; }

    }

    //bu tip klaslarda sadece özellik olur.
    //CRUD(create,read,update,delete) bu da diğer class tipi
}
