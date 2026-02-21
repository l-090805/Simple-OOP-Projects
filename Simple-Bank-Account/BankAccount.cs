using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    public class BankAccount
    {
        private decimal balance { get; set; }
        private string accountHolder { get; set; }
        private string accountNumber { get; set; }


        public BankAccount(string accountHolder, string accountNumber)
        {
            this.accountHolder = accountHolder;
            this.accountNumber = accountNumber;
            this.balance = 0.0m;
        }
        public decimal GetBalance()
        {
            return balance;
        }
        public string GetAccountHolder()
        {
            return accountHolder;
        }
        public string GetAccountNumber()
        {
            return accountNumber;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            else
            {
                balance += amount;
                Console.WriteLine($"{amount}$ is being deposited in your account");
            }
        }
        public virtual void Withdraw(decimal amount)
        {
            balance -= amount;
        }
        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {GetAccountHolder()}");
            Console.WriteLine($"Account Number: {GetAccountNumber()}");
            Console.WriteLine($"Balance: {GetBalance()}$");
        }
    }
}
