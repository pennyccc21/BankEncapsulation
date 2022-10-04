using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pennyAccount = new BankAccount();
            
            Console.WriteLine("How much would you like too deposit");

            var amountToDeposit = double.Parse(Console.ReadLine());

            pennyAccount.Deposit(amountToDeposit);

            string value = ($"Thank you! Your balance is now {pennyAccount.GetBalance()}");
        }
           
    }
}
