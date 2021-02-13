using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1001;
            customer1.Name = "Osman";
            customer1.SurName = "Anar";
            customer1.Age = 30;
            customer1.Adress = "Ankara";
            customer1.PhoneNumber = 05000000;

            

            Customer customer2 = new Customer();
            customer2.Id = 1002;
            customer2.Name = "Göktuğ";
            customer2.SurName = "Anar";
            customer2.Age = 18;
            customer2.Adress="Ankara";
            customer2.PhoneNumber = 05000001;

            Customer customer3 = new Customer();
            customer3.Id = 1003;
            customer3.Name = "Tuğba";
            customer3.SurName = "Anar";
            customer3.Age = 29;
            customer3.Adress = "Ankara";
            customer3.PhoneNumber = 05000002;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            Console.WriteLine(customers);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.SurName);
                Console.WriteLine(customer.Age);
                Console.WriteLine(customer.Adress);
                Console.WriteLine(customer.PhoneNumber);
                Console.WriteLine("----------------------");
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);

           
            customerManager.GetList(customers);
            Console.WriteLine("-----------");

        }
    }
}
