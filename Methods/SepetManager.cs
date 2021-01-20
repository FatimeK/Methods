using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention = isimlendirme kuralı
        public void Ekle(Product product) //içine parametre veriyorum ki fonk neyle uğraşcanı bilsin
        {
            Console.WriteLine("sepete eklendi: " + product.Adi);

        }

        public void Ekle2(string Adi, string aciklama, double Fiyat, int stok_adedi) //bir klas içinde birden fazla metod olabilir.
        {//bu fonksiyonda büyük bi hata var yapılan sektöre.//hadi stok adedi ekleelm dediler.vee noldu ekle2 için tüm sayfalarda kullandığın yerler gümleldii.tüm sayfalar patladı ama Ekle de öyle mi oldu hayır

            Console.WriteLine("sepete eklendi: " + Adi);
        }
    }
}
    

