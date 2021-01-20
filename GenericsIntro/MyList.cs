using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //Ben mylist de T ile çalşcam demek. t dediği de type den gelir.tip anlamında
    {

        T[] items;

        //constructor= bu klası bi yerde new lersem bu otomotik çalışıyor daha başlangıçta yani
        public MyList()
        {
            items = new T[0]; //burda arrayı 0 elemanlı oluştdn işte

        }

        //generic class demek çalışacağım özel bi tip olacağını belirtmek için yazarız
        public void Add(T item) //VERDİĞİM TİPE KARŞILIK. ben sana t olarak ne verirsem isteyeceğim elemanın türü de odur.
        {
            //bi şey ekleyebilmek için arrayi newlemem lazım .bir class newlendiğinde çalışan bloğa constructor denir
            T[] tempArray = items;//geçiçi dizinin referansı items ın referansı artık elemanlarım kaybolmucak çünkü onu geçici diziye emanet ettim
            //ondan sonra rahat rahat eleman sayımı bir arttırıyorum
            
            items = new T[items.Length + 1];//mevcutta eleman sayın kaçsa onu bir arttır.artık eski listemin elemanlarını emanet de ettim tempe
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            } //artıık mutluyum listede yer açtımm ve yeni elemanı paşa paşa eklerim

            items[items.Length - 1] = item;
        }
    }
}
