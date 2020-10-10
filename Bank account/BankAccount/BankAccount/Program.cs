using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner firstOwner = new Owner("Gigi", "Becali", 1110569254156, "Bucuresti");
            Account firstAccount = new Account(firstOwner);

            Console.WriteLine(firstAccount.Withdraw(254875));
            Console.WriteLine(firstAccount.Deposit(1257489));
            Console.WriteLine(firstAccount.Withdraw(254));
            firstAccount.Closing();
            Console.WriteLine(firstAccount.Deposit(255));

            EconomyAccount economyAccount = new EconomyAccount(firstOwner);
            economyAccount.Deposit(100);
            Console.WriteLine(economyAccount.Sum);
            economyAccount.Withdraw(10);
            Console.WriteLine(economyAccount.Sum);

            SecretAccount secretAccount = new SecretAccount(firstOwner);
            secretAccount.Deposit(100);
            Console.WriteLine(secretAccount.Withdraw(10));

            IDeposit deposit = firstAccount;
            deposit = secretAccount;
            deposit = new GameAccount();
        }
    }
}
