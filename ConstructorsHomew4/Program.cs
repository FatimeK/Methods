using System;

namespace ConstructorsHomew4
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id = 1,FirtsName = "Fatime",LastName = "kıran",City = "Ankara" }; //aman diikatt bu parametre verme değil

            Customer customer2 = new Customer(1,"fatime","kıran","ankara");

            //customer klası birnevi method gibi çalşr ben ona parametre vererek çağırmak isteyebilir
            //o zaman yapmam gereken şey customer klasında parantez içine benm parametreleerimi geçmek gerekir. 
        }

        
    }

    class Customer  //bu öreneğimizde ctorları özellik barındıran sınıflarımızı newediğimzde çalşmasını istediğim şeyler için kullandık
                    //bi de diğer bi şekli vardı.method barındıran classlardaki ctorlar.o sonraki ders konusu
    {
        //default constructor 
        public Customer()
        {
            //parametresi olmayan constructor a default constructor denir. 9 ve 11.satırları beraber kullanabilek için 2 tane ctor yaptık birine paramaetre verdik birini normal değer atayarak yaptık

        }
        public Customer(int id,string firstName,string lastName,string city) //bu ctor bloğunu yaz veya yazma sen bi klası newlediğin zmn bu default çalşcak
        {
            Console.WriteLine("Yapıcı(constructor) blok çalıştı");
            Id = id;
            FirtsName = firstName;
            LastName = lastName;            //constructor da değerleri set etmek
            City = city;
            
        }
        
        public int Id { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
