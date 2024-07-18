using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Bank
    {
        public string BankName { get; set; }
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
            Console.WriteLine($"{customer.FirstName} {customer.LastName} adlı müşteri banka  sistemine eklendi.");
        }

        public void GenerateReport()
        {
            Console.WriteLine($"{BankName} adlı banka raporu:");
            foreach (var customer in Customers)
            {
                customer.DisplayInfo();
            }
        }
    }
}
