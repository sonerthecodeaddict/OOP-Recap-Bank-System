using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class CreditCard
    {
        public string CardNumber { get; set; }
        public double Limit { get; set; }
        public double Debt { get; private set; }

        public void MakePurchase(double amount)
        {
            if (Debt + amount <= Limit)
            {
                Debt += amount;
                Console.WriteLine($"{amount} £ harcandı. Güncel borç: {Debt} £");
            }
            else
            {
                Console.WriteLine("Limit Yetersiz!");
            }
        }

        public void PayDebt(double amount)
        {
            if (amount <= Debt)
            {
                Debt -= amount;
                Console.WriteLine($"{amount} £ borç ödendi. Güncel borç: {Debt} £");
            }
            else
            {
                Console.WriteLine("Borcunuzdan fazla miktar girildi!");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Kredi Kartı - Kard Numarası: {CardNumber}, Limit: {Limit} £, Borç: {Debt} £");
        }
    }
}
