using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    public class BankAccount
    {
        public int accountNumber;
        public string accountHolderName;
        public  string accountType;
        public double balance;

        public BankAccount(int accountNumber, string accountHolderName, string accountType, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.accountType = accountType;
            this.balance = balance;
        }

        

        public void displayAccountInfo()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Holder Name: " + accountHolderName);
            Console.WriteLine("Account Type: " + accountType);
            Console.WriteLine("Balance: RM " + balance);
            Console.WriteLine("\n");
        }
    }
}
