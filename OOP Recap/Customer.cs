using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public abstract class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<Account> Accounts { get; set; } = new List<Account>();
        public List<CreditCard> CreditCards { get; set; } = new List<CreditCard>();

        public abstract void DisplayInfo();
    }

    public class IndividualCustomer : Customer
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Bireysel Müşteri: {FirstName} {LastName}, eposta: {Email}");
            Console.WriteLine("Hesaplar:");
            foreach (var account in Accounts)
            {
                account.DisplayInfo();
            }
            Console.WriteLine("Kredi kartları:");
            foreach (var card in CreditCards)
            {
                card.DisplayInfo();
            }
        }
    }

    public class CorporateCustomer : Customer
    {
        public string CompanyName { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Kurumsal Müşteri: {CompanyName}, Müşteri Temsilcisi: {FirstName} {LastName}, eposta: {Email}");
            Console.WriteLine("Hesaplar:");
            foreach (var account in Accounts)
            {
                account.DisplayInfo();
            }
            Console.WriteLine("Kredi kartları:");
            foreach (var card in CreditCards)
            {
                card.DisplayInfo();
            }
        }
    }
}
