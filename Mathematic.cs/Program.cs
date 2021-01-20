using System;

namespace Mathematic.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem(); //ordaki klasdan bi değişkeni burda yarattım
                                                   //ve bambaşka bi sayfadan onu çağırdım

            dortIslem.Topla(9, 10); //gibi . yani bambaşka sayfadan çağırdım

        }
    }
}
