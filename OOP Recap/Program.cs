using System;
using System.Text;
using System.Collections.Generic;



namespace BankSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Bank bank = new Bank { BankName = "SONER Bank" };


            CorporateCustomer corporateCustomer = new CorporateCustomer
            {
                FirstName = "mehmet",
                LastName = "aslan",
                Email = "asdfasfasc@gmail.com",
                CompanyName = "aslan kebap"
            };

            IndividualCustomer individualCustomer = new IndividualCustomer
            {
                FirstName = "ahmet",
                LastName = "yılmaz",
                Email = "asdfasfasf@gmail.com"
            };


            CheckingAccount checkingAccount = new CheckingAccount { AccountNumber = "3169523169", Balance = 3000 };
            SavingsAccount savingsAccount = new SavingsAccount { AccountNumber = "5269315269", Balance = 10000, InterestRate = 3 };


            CreditCard creditCard = new CreditCard { CardNumber = "5231-5269-1234-3131", Limit = 5000 };


            individualCustomer.Accounts.Add(checkingAccount);
            individualCustomer.CreditCards.Add(creditCard);

            corporateCustomer.Accounts.Add(savingsAccount);


            bank.AddCustomer(individualCustomer);
            bank.AddCustomer(corporateCustomer);


            Console.WriteLine("\nHarcama - yatırma - faiz işlemleri");
            checkingAccount.Deposit(500);
            checkingAccount.Withdraw(1000);
            savingsAccount.CalculateInterest();
            Console.WriteLine("\nKredi kartı işlemleri");
            creditCard.MakePurchase(1000);
            creditCard.PayDebt(300);

            Console.WriteLine("\nBanka raporu");
            bank.GenerateReport();
        }
    }
    

}