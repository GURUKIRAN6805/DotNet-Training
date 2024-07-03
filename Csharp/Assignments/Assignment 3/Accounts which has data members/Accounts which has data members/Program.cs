using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts_which_has_data_members
{
    internal class Accounts
    {
        private int accountNumber;
        private string customerName;
        private string accountType;
        private char transactionType;
        private double amount;
        private double balance;
        public Accounts(int accountNumber, string customerName, string accountType)
        {
            this.accountNumber = accountNumber;
            this.customerName = customerName;
            this.accountType = accountType;
            this.balance = 0;
        }
        public void UpdateBalance(char transactionType, double amount)
        {
            if (transactionType == 'D')
            {
                Credit(amount);
            }
            else if (transactionType == 'W')
            {
                Debit(amount);
            }
            else
            {
                Console.WriteLine("Invalid transaction type!");
            }
        }
        private void Credit(double amount)
        {
            this.balance += amount;
            Console.WriteLine($"Amount {amount} credited. New balance: {balance}");
        }
        private void Debit(double amount)
        {
            if (amount <= balance)
            {
                this.balance -= amount;
                Console.WriteLine($"Amount {amount} debited. New balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        public void ShowData()
        {
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Current Balance: {balance}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Accounts myAccount = new Accounts(3654, "GURUKIRAN", "Savings");
            myAccount.UpdateBalance('D', 6700); 
            myAccount.UpdateBalance('W', 200); 
            myAccount.UpdateBalance('W', 400);
            myAccount.ShowData();
            Console.ReadLine();
        }
    }
}
