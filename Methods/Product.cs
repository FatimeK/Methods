using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Product
    {
        //property - özellik
        public int Id { get; set; }

        public string Adi { get; set; }

        public double Fiyati { get; set; }

        public string Aciklama { get; set; }

        //sonradan ekledik ekle metodu için manager içinde

        public int stokadedi { get; set; } //buna encapsulation denirr

    }
}
