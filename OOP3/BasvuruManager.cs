using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection ... hangi kredi veya hangi loglauıcı olduğunun soyut halleri var ve somut halleri otomotik enjekte oluyo
        public void BasvuruYap(ICrediManager crediManager,ILoggerService loggerService) 
        {
            //Başvuran bilgi değerlendirme simülasyon
            //..
            KonutKrediManager konutKrediManager = new KonutKrediManager(); //boyle dersenn tüm başvurular konut kredisine göre değerlendirilir..kırılma noktası
            //ama gider parametreye base klasımdaki interfaceimi verirsem istediğim kredi türünü yollarım
            //artık burda istediğim şeyi yollarım zaten interfaceim onu benm için seçer.konu taşıt ihtiyac neyse benm için onu zaten tanır
            crediManager.Hesapla();
            loggerService.Log(); //hangi loglayıcı seçilmişse onu logla 

        }

        // 2. bi simülasyon örneği .//bankaya gelip araba alcam bana hangi kredi uyar diye soran adam simülasyonu
        public void KrediOnBilgilendirmesiYap(List<ICrediManager> krediler) //bana bi liste ver türü ıcredimanager olsn
        {
            foreach (var kredi in krediler)

            {
                kredi.Hesapla();

            }
        }

    }
}
