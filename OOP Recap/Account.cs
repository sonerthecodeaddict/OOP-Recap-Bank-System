using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public abstract class Account
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void DisplayInfo();
    }

    public class CheckingAccount : Account
    {
        public override void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"{amount} Vadesiz hesaba para yatırma işlemi tamamlandı. Güncel bakiye: {Balance} £");
        }

        public override void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} Vadesiz hesaptan para çekme işlemi tamamlandı. Güncel bakiye: {Balance} £");
            }
            else
            {
                Console.WriteLine("Bakiye yetersiz!");
            }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Vadesiz Hesap - Hesap Numarası: {AccountNumber}, Bakiye: {Balance}");
        }
    }

    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public override void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"{amount} Tasarruf hesabına para yatırma işlemi tamamlandı. Güncel bakiye: {Balance} £");
        }

        public override void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} Tasarruf hesabından para çekme işlemi tamamlandı. Güncel bakiye: {Balance} £");
            }
            else
            {
                Console.WriteLine("Bakiye yetersiz!");
            }
        }

        public void CalculateInterest()
        {
            Balance += Balance * InterestRate / 100;
            Console.WriteLine($"Faiz hesaplandı. Yeni bakiye: {Balance} £");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Tasarruf Hesabı - Hesap Numarası: {AccountNumber}, Bakiye: {Balance} £, Faiz Oranı: {InterestRate}%");
        }
    }
}
