using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== BANK SYSTEM ==========");


            // Create Customer
            Customer customer = new Customer();

            Console.Write("\nEnter Customer Name: ");
            customer.CustomerName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            customer.PhoneNumber = Console.ReadLine();

            customer.CustomerID = 1;

            Console.WriteLine("\n");

            // Create Bank Account
            BankAccount account = new BankAccount(10001, customer.CustomerName, "Saving", 1000);

            Transaction t1 = new Transaction(account.accountNumber, "", 0, account.balance);

           
           t1.Deposit(account, 500);     // deposit

            Transaction t2 = new Transaction(account.accountNumber, "", 0, account.balance);
            t2.Withdraw(account,200);    // withdraw
            
            // Display Information
            customer.displayCustomerInfo();
            account.displayAccountInfo();
            t1.DisplayTransactionInfo();
            t2.DisplayTransactionInfo();
            Console.WriteLine("\n--- Transaction Completed ---");
        }

    }
    }

