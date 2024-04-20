using BankCostumers;
using System;

internal class Program
{
    public static void Main(string[] args)
    {

        Customer customer1 = new Customer();
        customer1.Id = 1;
        customer1.IdentityNumber = 21877569834;
        customer1.Name = "Kerem";
        customer1.SurName = "Kayalar";
        customer1.PhoneNumber = "05388885566";

        Customer customer2 = new Customer();
        customer2.Id = 2;
        customer2.IdentityNumber = 21875564585;
        customer2.Name = "Zeliha";
        customer2.SurName = "Kayalar";
        customer2.PhoneNumber = "05556665544";

        Customer customer3 = new Customer();
        customer3.Id = 3;
        customer3.IdentityNumber = 44588796578;
        customer3.Name = "Derin";
        customer3.SurName = "Kaya";
        customer3.PhoneNumber = "05448788896";

        Customer[] customers = new Customer[] { customer1, customer2, customer3 };
        CustomerManager customerManager = new CustomerManager();

        Console.WriteLine("-------- Customer Add --------");
        customerManager.AddCustomer(customer1);
        customerManager.AddCustomer(customer2);

        Console.WriteLine("---------------------------");
        Console.WriteLine("-------- Customer Remove --------");
        customerManager.RemoveCustomer(customer1);
        customerManager.RemoveCustomer(customer2);
        customerManager.RemoveCustomer(customer3);

        Console.WriteLine("---------------------------");
        Console.WriteLine("-------- Customers List --------");
        customerManager.ListCustomer(customers);

    }
}