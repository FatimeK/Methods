using System;
using System.Collections.Generic;

namespace GenericsHomew4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            Console.WriteLine(cities.Count);


            MyList<string> cities2 = new MyList<string>();
            cities2.Add("Ankara");
            cities2.Add("fkgjfdlk");
            Console.WriteLine(cities2.Count);
        }
    }

    //kendi mylistimizi yazalm diyoruz

    //Type in T'si
    class MyList<T>   //T koyunca artık bnm bu klasım generic bi klas.hangi veritipini verirsem onla çalşr.tam istediğim gibi
    {
        T[] _array; //T tipinde bi array olştrdm
                    //koleksiyonlar arka planda bi array yönetiyor.ve ben array olştrnca eleman sayısını vermem lzm
        public MyList()
        {
            _array = new T[0]; //0 elemanlı bi array olştrdm constructorumda
        }
        public void Add(T item)
        {
            T[] _temp = new T[_array.Length];
            _temp = _array;
           
            _array = new T[_array.Length + 1]; //evet eleman sayımı artırdım ama tüm datam üçtuu ve gittii..
                                               //bunun için ben bir temp arrayi olştruo datamı ona bi süreliğine emanet etcem

            for (int i = 0; i < _array.Length - 1; i++)
            {
                _array[i] = _temp[i];
            }

            _array[_array.Length - 1] = item;




        }

        private int _count; //count bi metot değil propertydir
                
        public int Count //kendi olştrdğmz mylist klasına count özelliği ekliyorz
        {
            get { return _array.Length; }
            
        }

    }
}
