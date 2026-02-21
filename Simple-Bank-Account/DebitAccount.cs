using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class DebitAccount : BankAccount
    {
        public DebitAccount(string accountHolder, string accountNumber) : base(accountHolder, accountNumber)
        {
        }
        public override void Withdraw(decimal amount)
        {
            if (GetBalance() - amount < 0 || amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive and within the account balance.");
            }
            else
            {
                base.Withdraw(amount);
                Console.WriteLine($"{amount}$ has been withdrawn from your debit account.");
            }
        }
    }
}
