using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion11_Koduppgifter
{
    public class BankAccount
    {
        public decimal Balance { get; private set; }
        public int AccountNumber { get; }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount.");
                return false;
            }
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"{amount.ToString("c")} has been withdrawn.");
                return true;
            }
            return false;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"{amount.ToString("c")} has been desposited.");
        }
    }
}
