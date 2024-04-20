using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCostumers
{
    public class CustomerManager
    {

        public void AddCustomer(Customer customer) {

            Console.WriteLine("Tebrikler " + " " + customer.Name + " " + customer.SurName + " " + "EKLENDİ !");
        }

        public void RemoveCustomer(Customer customer)
        {
            Console.WriteLine("Tebrikler " + " " + customer.Name + " " + customer.SurName + " " + "SİLİNDİ !");
        }

        public void ListCustomer(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Müşteri : " + customer.Name + " " + customer.SurName + " " + "Identity Number: " + customer.IdentityNumber ); 
            }
        }
    }
}
