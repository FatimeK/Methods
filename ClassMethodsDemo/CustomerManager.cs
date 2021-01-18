using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodsDemo
{
    class CustomerManager
    {
        public void ListPropsOfCustomers(Customer[] customers)
        {
            Console.WriteLine("currently names in list:\n");
            foreach (var customer in customers)
            {
                Console.WriteLine("{0}(id: {1})", customer.Name, customer.Id);

            }

        }
        public void CreateCustomer()
        {
            Customer customer_new = new Customer();

            Console.WriteLine("Name: ");
            customer_new.Name = Console.ReadLine();

            Console.WriteLine("Lastname: ");
            customer_new.LastName = Console.ReadLine();

            Console.WriteLine("id: ");
            customer_new.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Age: ");
            customer_new.Age = Convert.ToInt32(Console.ReadLine());






        }
        public void AddCustomer(Customer customer)
        {


            Console.WriteLine("Customer: " + customer.Name + ",added to list succesfully...");
            Console.WriteLine("Name: {0}\nLastname: {1}\nId: {2}\nAge: {3}\n", customer.Name, customer.LastName, customer.Id, customer.Age);
        }
    }
}
