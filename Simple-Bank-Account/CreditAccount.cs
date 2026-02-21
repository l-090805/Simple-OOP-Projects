using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    public class CreditAccount : BankAccount
    {
        private decimal creditLimit { get; set; }
        public decimal GetCreditLimit()
        {
            return creditLimit;
        }
        public CreditAccount(string accountHolder,string accountNumber,decimal creditLimit) : base(accountHolder, accountNumber)
        {
            this.creditLimit = creditLimit;
        }
        public override void Withdraw(decimal amount)
        {
            if(GetBalance() - amount < - GetCreditLimit() || amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive and within the credit limit.");
            }
            else
            {
                base.Withdraw(amount);
                Console.WriteLine($"{amount}$ has been withdrawn from your credit account. Updated credit limit: {GetCreditLimit()}");
            }
        }
        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {GetAccountHolder()}");
            Console.WriteLine($"Account Number: {GetAccountNumber()}");
            Console.WriteLine($"Balance: {GetBalance()}$");
            Console.WriteLine($"Credit Limit: {GetCreditLimit()}$");
        }
    }
}
