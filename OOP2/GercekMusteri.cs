using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //individual customer
    //miras - inheritance (gerçek müşteri bir müşteridir demenin sytnaxi
    class GercekMusteri :Musteri 
    {
        
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
