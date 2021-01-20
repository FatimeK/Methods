using System;

namespace ClassMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            Customer Customer1 = new Customer();
            Customer1.Id = 123456;
            Customer1.Name = "Harry";
            Customer1.LastName = "Nell";
            Customer1.Age = 49;


            Customer Customer2 = new Customer();
            Customer2.Id = 165956;
            Customer2.Name = "Karl";
            Customer2.LastName = "Moody";
            Customer2.Age = 69;


            Customer Customer3 = new Customer();
            Customer3.Id = 123456;
            Customer3.Name = "Mary";
            Customer3.LastName = "Polite";
            Customer3.Age = 36;




            Customer new_Customer = new Customer();
            customerManager.CreateCustomer();
            Customer[] customerList = new Customer[] { Customer1, Customer2, Customer3, new_Customer };
            customerManager.ListPropsOfCustomers(customerList);
            //customer.Add(new_Customer); why it is not working?
            //why ı can t use remove or add etc for this list?
            //ı wanna show the current list of customer's name in begin to create a customer.but there is a bug :D
            //the customer which ı created is not showing
            foreach (Customer customer in customerList)
            {
                customerManager.AddCustomer(customer);

            }





        }

    }
}
