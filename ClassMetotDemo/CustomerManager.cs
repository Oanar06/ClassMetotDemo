using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.Name + " " + 
                customer.SurName + " " + customer.Age + " " + customer.Adress 
                + " " + customer.PhoneNumber+"Müşteri Eklendi");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.Name + " " +
               customer.SurName + " " + customer.Age + " " + customer.Adress
               + " " + customer.PhoneNumber + "Müşteri silindi");
        }
        
        public void GetList(Customer[] customers)
        {
            foreach (var customer in customers)
            {

            
            Console.WriteLine("Müşteri Id Numarası:"+ customer.Id);
            Console.WriteLine("Müşteri Adı:"+customer.Name);
            Console.WriteLine("Müşteri Soyadı: " +customer.SurName);
            Console.WriteLine("Müşteri Yaş:"+customer.Age);
            Console.WriteLine("Müşteri Adresi:"+ customer.Adress);
            Console.WriteLine("Müşteri Tel No:"+ customer.PhoneNumber);
            }
            Console.WriteLine("Listeleme İşlemi Tamamlandı");
        }
    }
}
