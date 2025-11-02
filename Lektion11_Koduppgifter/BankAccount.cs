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

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"{amount.ToString("c")} has been withdrawn.");
            }
        }
    }
}
