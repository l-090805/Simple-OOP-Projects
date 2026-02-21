namespace Bank_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount debit = new DebitAccount("John Doe", "123456789");
            debit.Deposit(1000);
            debit.Withdraw(200);
            debit.DisplayAccountInfo();

            Console.WriteLine();

            BankAccount credit = new CreditAccount("Jane Doe", "987654321", 500);
            credit.Deposit(1000);
            credit.Withdraw(1200);
            credit.DisplayAccountInfo();

            Console.WriteLine();

            try
            {
                debit.Withdraw(900); // This should throw an exception
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                credit.Withdraw(700); // This should throw an exception
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
