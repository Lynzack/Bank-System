using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    public class Customer
    {
        private int customerID;
        private string customerName;
        private string phoneNumber;

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }// if no set, means read only
        }

        public string CustomerName
        {
            get { return customerName; }
            set {
                customerName = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                long num;
                if (value.Length == 10 || value.Length == 11 && long.TryParse(value, out num)){
                    phoneNumber = value; }
                else
                {
                    throw new ArgumentException("Phone must be 10 or 11 digit long");
                }
                    
                 
                }
            }
        public void displayCustomerInfo()
        {
            Console.WriteLine("ID : " + customerID);
            Console.WriteLine("Name : " + customerName);
            Console.WriteLine("Phone Number: " + phoneNumber );
            Console.WriteLine("\n");

        }
        }

        }

    

