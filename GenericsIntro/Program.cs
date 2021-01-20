using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList isimler = new MyList(); Butip bağımlı çalşyrm o yüzden bana çalışacağın tipi de ver diycek ve kızcak
            MyList<string> isimler = new MyList<string>(); //string ver int ver artık ne istersen ver
            isimler.Add("Engin"); //yukarda kendi T mi str verdiğim için add fonksiyonu içine str ister.int versen T'yi ;ozmn int isterdi


        }
    }
}
