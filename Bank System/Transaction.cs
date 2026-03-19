using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    public class Transaction
    {
        public int accountNumber;
        public string transactionType;
        public double amount;
       public double newBalance;

        public Transaction(int accNo , string type, double amt, double newBal)
        {
            accountNumber = accNo;
            transactionType = type;
            amount = amt;

            newBalance = newBal;
        }

       

        public void Deposit(BankAccount account, double amt)
        {
            Console.WriteLine("========== Deposit ==========");

            amount = amt;
            newBalance += amt;
            transactionType = "Deposit";
           
            account.balance = newBalance;
            Console.WriteLine(" Deposit successfull ! \n New Balance is RM  " + newBalance );
            Console.WriteLine("\n");

    
        }

        public void Withdraw(BankAccount account, double amt)
        {
            Console.WriteLine("========== Withdraw ==========");
            
            if (amt > newBalance)
            {
                Console.WriteLine(" Insufficient balance ! \n Current Balance is RM " + newBalance);
            }
            else
            {
                amount = amt;
                newBalance -= amt;
                transactionType = "Withdraw";
                
               account.balance = newBalance;
                Console.WriteLine(" Withdraw successfull ! \n New Balance is RM  " + newBalance);
            }
            Console.WriteLine("\n");
        }

        public void DisplayTransactionInfo()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Transaction Type: " + transactionType);
            Console.WriteLine("Amount: RM " + amount);
            Console.WriteLine("New Balance: RM " + newBalance);
            Console.WriteLine("\n");
        }
    }
}
